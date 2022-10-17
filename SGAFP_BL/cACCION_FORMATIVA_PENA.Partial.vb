Imports SQLMembershipProvider.BL
Imports System.Text
Imports System.Web.Security

Partial Public Class cACCION_FORMATIVA_PENA


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
    ''' 	[GenApp]	20/02/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarACCION_FORMATIVA_PENA(ByVal aEntidad As ACCION_FORMATIVA_PENA) As Integer
        Try
            Return Me.ActualizarACCION_FORMATIVA_PENA(aEntidad, TipoConcurrencia.Pesimistica)
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
    ''' 	[GenApp]	20/02/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarACCION_FORMATIVA_PENA(ByVal aEntidad As ACCION_FORMATIVA_PENA, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            Dim lNotificar As Boolean = False
            Dim lRet As Int32 = 0

            If aEntidad.ID_ACCION_FORMATIVA_PENA = 0 Then
                'Notificar
                lNotificar = True
            Else
                Dim lPenaAntes As ACCION_FORMATIVA_PENA = (New cACCION_FORMATIVA_PENA).ObtenerACCION_FORMATIVA_PENA(aEntidad.ID_ACCION_FORMATIVA_PENA)
                If lPenaAntes IsNot Nothing AndAlso lPenaAntes.PORC_PENALIZACION <> aEntidad.PORC_PENALIZACION Then lNotificar = True
            End If
            lRet = mDb.Actualizar(aEntidad, aTipoConcurrencia)

            If lNotificar Then
                Notificar(aEntidad.ID_ACCION_FORMATIVA, aEntidad.USUARIO_CREACION, aEntidad.PORC_PENALIZACION, aEntidad.MOTIVO)
            End If

            Return lRet
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    Private Sub Notificar(ByVal ID_ACCION_FORMATIVA As Int32, ByVal USUARIO As String, ByVal PORC As Decimal, ByVal MOTIVO As String)

        'Enviar notificación por correo
        Dim _mp As New cmembershipProvider
        Dim listaCCO As New List(Of String)
        Dim listaCC As New List(Of String)
        Dim lUsuariosProvee As listaUSUARIO
        Dim sRemitente As String = ""
        Dim sAsunto As String
        Dim sCuerpo As New StringBuilder
        Dim lAccionFormativa As New ACCION_FORMATIVA
        Dim idProveedor As Integer = 0

        _mp = CType(Membership.Provider, cmembershipProvider)

        lAccionFormativa = (New cACCION_FORMATIVA).ObtenerACCION_FORMATIVA(ID_ACCION_FORMATIVA)
        If lAccionFormativa IsNot Nothing Then
            sAsunto = "NOTIFICACION DE PENALIZACIÓN A CURSO " + lAccionFormativa.NOMBRE_ACCION_FORMATIVA
            idProveedor = lAccionFormativa.ID_PROVEEDOR_AF
        Else
            Exit Sub
        End If

        '   Obtener cuentas de correo del proveedor                
        listaCCO = (New cListasDeDistribucionCorreo).ListaCorreosParaAutorizaciones
        lUsuariosProvee = (New cUSUARIO).ObtenerListaPorPROVEEDOR_AF(idProveedor)

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
        sCuerpo.AppendLine((New cPROVEEDOR_AF).ObtenerPROVEEDOR_AF(idProveedor).NOMBRE_PROVEEDOR)
        sCuerpo.Append("  Curso: ")
        sCuerpo.AppendLine(lAccionFormativa.NOMBRE_ACCION_FORMATIVA)
        sCuerpo.Append("  Codigo: ")
        sCuerpo.AppendLine(lAccionFormativa.CODIGO_GRUPO)
        sCuerpo.Append("  Porcentaje (%) aplicado: ")
        sCuerpo.AppendLine(PORC.ToString + " %")
        sCuerpo.Append("  Motivo de la penalizacion: ")
        sCuerpo.AppendLine(MOTIVO)

        If (listaCC IsNot Nothing AndAlso listaCC.Count > 0) OrElse (listaCCO IsNot Nothing AndAlso listaCCO.Count > 0) Then
            sRemitente = _mp.ObtenerEmailPorNombreUsuario(USUARIO)
            If Not listaCCO.Contains(sRemitente) Then listaCCO.Add(sRemitente)
            _mp.EnviarCorreo(sRemitente, New List(Of String), sAsunto, sCuerpo.ToString, listaCC, listaCCO)
        End If
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla ACCION_FORMATIVA_PENA que se le envía como parámetro.
    ''' </summary>
    ''' <param name="ID_ACCION_FORMATIVA_PENA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	20/02/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarACCION_FORMATIVA_PENA(ByVal ID_ACCION_FORMATIVA_PENA As Decimal) As Integer
        Try
            mEntidad.ID_ACCION_FORMATIVA_PENA = ID_ACCION_FORMATIVA_PENA
            Return Me.EliminarACCION_FORMATIVA_PENA(mEntidad, TipoConcurrencia.Pesimistica)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla ACCION_FORMATIVA_PENA que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia.
    ''' </summary>
    ''' <param name="aEntidad">Instancia de la Entidad a Eliminar en la Base de Datos.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	20/02/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarACCION_FORMATIVA_PENA(ByVal aEntidad As ACCION_FORMATIVA_PENA, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            Dim lRet As Int32 = 0

            lRet = mDb.Eliminar(aEntidad, aTipoConcurrencia)

            'Reactualizar monto a pagar si existen informes de ejecución
            Dim bInforme As New cINFORME_FINAL_AF
            Dim listaInformes As listaINFORME_FINAL_AF = bInforme.ObtenerListaPorACCION_FORMATIVA(aEntidad.ID_ACCION_FORMATIVA)
            If listaInformes IsNot Nothing AndAlso listaInformes.Count > 0 Then
                For Each lEntidad As INFORME_FINAL_AF In listaInformes
                    Dim lInforme As INFORME_FINAL_AF
                    lInforme = bInforme.GenerarInformeParcial(aEntidad.ID_ACCION_FORMATIVA, lEntidad.FECHA_INICIAL, lEntidad.FECHA_FINAL, False)

                    If lInforme IsNot Nothing Then
                        lInforme.ID_INFORME_FINAL = lEntidad.ID_INFORME_FINAL
                        lInforme.ID_ESTADO_INFORME = lEntidad.ID_ESTADO_INFORME
                        lInforme.ELABORADO_POR = lEntidad.ELABORADO_POR
                        lInforme.USERID = aEntidad.USUARIO_CREACION
                        lInforme.LASTUPDATE = Now
                        bInforme.ActualizarINFORME_FINAL_AF(lInforme, TipoConcurrencia.Pesimistica, False, False, False)
                    End If
                Next
            End If


            Return lRet

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function
End Class
