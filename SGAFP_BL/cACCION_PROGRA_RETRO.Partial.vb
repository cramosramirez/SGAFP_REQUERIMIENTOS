Imports SQLMembershipProvider.BL
Imports System.Web.Security
Imports System.Text

Partial Public Class cACCION_PROGRA_RETRO

    Public Function ObtenerACCION_PROGRA_RETRO_PorCriterios(ByVal ID_PROVEEDOR_AF As Decimal, _
                                                            ByVal ID_EJERCICIO As String, _
                                                            ByVal CODIGO_GRUPO As String, _
                                                            ByVal CODIGO_ESTADO_AF_PROP As String, _
                                                            ByVal ACTIVO As Decimal) As listaACCION_PROGRA_RETRO
        Try
            Me.InhabilitarPorFechaExpiraACCION_PROGRA_RETRO()
            Return mDb.ObtenerACCION_PROGRA_RETRO_PorCriterios(ID_PROVEEDOR_AF, ID_EJERCICIO, CODIGO_GRUPO, CODIGO_ESTADO_AF_PROP, ACTIVO)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function


    Public Function InhabilitarPorFechaExpiraACCION_PROGRA_RETRO() As Int32
        Try
            Return mDb.InhabilitarPorFechaExpiraACCION_PROGRA_RETRO()

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Actualiza o Ingresa un registro de la Entidad que recibe de parámetro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad que contiene los datos a Actualizar o Ingresar.</param>
    ''' <remarks>La entidad ya debe estar inicializada. Si es una tabla de Muchos a Muchos
    ''' este método unicamente actualiza el registro. Si no es una tabla de Muchos a Muchos
    ''' puede Actualizar o insertar un registro, dependiendo si la llave única trae un valor
    ''' de Cero(0) para ser autoincrementada por el método de la Clase de Acceso a Datos.</remarks>
    ''' <history>
    ''' 	[GenApp]	10/02/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarACCION_PROGRA_RETRO(ByVal aEntidad As ACCION_PROGRA_RETRO) As Integer
        Try
            Return Me.ActualizarACCION_PROGRA_RETRO(aEntidad, TipoConcurrencia.Pesimistica)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Actualiza o Ingresa un registro de la Entidad que recibe de 
    ''' parámetro; en el caso de que sea actualizar toma en cuenta el Tipo de 
    ''' Concurrencia recibida de parametro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad que contiene los datos a Actualizar o Ingresar.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia del Registro a Actualizar</param>
    ''' <remarks>La entidad ya debe estar inicializada. Si es una tabla de Muchos a Muchos
    ''' este método unicamente actualiza el registro. Si no es una tabla de Muchos a Muchos
    ''' puede Actualizar o insertar un registro, dependiendo si la llave única trae un valor
    ''' de Cero(0) para ser autoincrementada por el método de la Clase de Acceso a Datos.</remarks>
    ''' <history>
    ''' 	[GenApp]	10/02/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarACCION_PROGRA_RETRO(ByVal aEntidad As ACCION_PROGRA_RETRO, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            Dim lRet As Integer = 0
            Dim esNuevo As Boolean = False
            Dim lAfter As ACCION_PROGRA_RETRO

            esNuevo = (aEntidad.ID_ACCION_PROGRA_RETRO = 0)
            lRet = mDb.Actualizar(aEntidad, aTipoConcurrencia)


            If esNuevo Then
                lAfter = Me.ObtenerACCION_PROGRA_RETRO(aEntidad.ID_ACCION_PROGRA_RETRO)
                If lAfter Is Nothing OrElse lAfter.ID_ACCION_PROGRA_RETRO <= 0 Then Return -1

                'Enviar notificación por correo
                Dim _mp As New cmembershipProvider
                Dim listaCCO As New List(Of String)
                Dim listaCC As New List(Of String)
                Dim lUsuariosProvee As listaUSUARIO
                Dim sRemitente As String = ""
                Dim sAsunto As String = "FORMACION INICIAL - AUTORIZACION PARA " + Utilerias.ObtenerNombreDeAutorizacion(aEntidad.CODIGO_ESTADO_AF_PROP)
                Dim sCuerpo As New StringBuilder

                _mp = CType(Membership.Provider, cmembershipProvider)

                '   Obtener cuentas de correo del proveedor                
                listaCCO = (New cListasDeDistribucionCorreo).ListaCorreosParaAutorizaciones
                lUsuariosProvee = (New cUSUARIO).ObtenerListaPorPROVEEDOR_AF(aEntidad.ID_PROVEEDOR_AF)

                '   Establecer la lista de destinatarios
                If lUsuariosProvee IsNot Nothing AndAlso lUsuariosProvee.Count > 0 Then
                    For i As Int32 = 0 To lUsuariosProvee.Count - 1
                        Dim sCorreo As String = _mp.ObtenerEmailPorNombreUsuario(lUsuariosProvee(i).USUARIO, True)
                        If sCorreo IsNot Nothing AndAlso sCorreo <> "" Then
                            If Not listaCC.Contains(sCorreo) Then listaCC.Add(sCorreo)
                        End If
                    Next
                End If
                sCuerpo.Append("  Proveedor: ")
                sCuerpo.AppendLine((New cPROVEEDOR_AF).ObtenerPROVEEDOR_AF(aEntidad.ID_PROVEEDOR_AF).NOMBRE_PROVEEDOR)
                sCuerpo.Append("  Curso: ")
                sCuerpo.AppendLine(aEntidad.NOMBRE_ACCION_FORMATIVA)
                sCuerpo.Append("  Codigo: ")
                sCuerpo.AppendLine(aEntidad.CODIGO_GRUPO)
                sCuerpo.Append("  Motivo autorizacion: ")
                sCuerpo.AppendLine(aEntidad.MOTIVO)

                If Not (aEntidad.FECHA_EXPIRA = Nothing OrElse aEntidad.FECHA_EXPIRA = #12:00:00 AM#) Then
                    sCuerpo.Append("  Fecha en que vence la autorizacion: ")
                    sCuerpo.AppendLine(aEntidad.FECHA_EXPIRA.ToString("dd/MM/yyyy"))
                End If
                sCuerpo.Append("  Tecnico que registro la autorizacion: ")
                sCuerpo.AppendLine((New cUSUARIO).ObtenerUSUARIO(aEntidad.USUARIO_CREACION).NOMBRE)

                If (listaCC IsNot Nothing AndAlso listaCC.Count > 0) OrElse (listaCCO IsNot Nothing AndAlso listaCCO.Count > 0) Then

                    sRemitente = _mp.ObtenerEmailPorNombreUsuario(aEntidad.USUARIO_CREACION)
                    If Not listaCCO.Contains(sRemitente) Then listaCCO.Add(sRemitente)

                    Return _mp.EnviarCorreo(sRemitente, _
                                            New List(Of String), sAsunto, sCuerpo.ToString, listaCC, listaCCO)
                Else
                    Return -1
                End If
            End If

            Return lRet
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function
End Class

