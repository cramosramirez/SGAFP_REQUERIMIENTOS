Imports SQLMembershipProvider.BL
Imports System.Web.Security
Imports SGAFP.EL.Enumeradores
Imports System.Text

Partial Public Class cACCION_FORMATIVA_SEGUI

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
    Public Function ActualizarACCION_FORMATIVA_SEGUI(ByVal aEntidad As ACCION_FORMATIVA_SEGUI) As Integer
        Try
            Return Me.ActualizarACCION_FORMATIVA_SEGUI(aEntidad, TipoConcurrencia.Pesimistica)
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
    Public Function ActualizarACCION_FORMATIVA_SEGUI(ByVal aEntidad As ACCION_FORMATIVA_SEGUI, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            Dim idAccionSegui As Int32 = aEntidad.ID_ACCION_FORMATIVA_SEGUI
            Dim lRet As Int32 = 0
            Dim lCCO As New List(Of String)
            Dim _mp As New cmembershipProvider
            Dim rolEnvioCorreo As Boolean = False
            Dim enviarCorreoProveedor As Boolean = False
            Dim listaRoles As New List(Of String)

            _mp = CType(Membership.Provider, cmembershipProvider)

            lRet = mDb.Actualizar(aEntidad, aTipoConcurrencia)

            Dim lAccion As ACCION_FORMATIVA = (New cACCION_FORMATIVA).ObtenerACCION_FORMATIVA(aEntidad.ID_ACCION_FORMATIVA)
            Dim lAccionDetalle As ACCION_FORMATIVA_DETALLE = (New cACCION_FORMATIVA_DETALLE).ObtenerACCION_FORMATIVA_DETALLE(aEntidad.ID_ACCION_FORMATIVA)

            listaRoles = _mp.ObtenerRoles(aEntidad.USUARIO_CREACION)
            If listaRoles IsNot Nothing AndAlso listaRoles.Count > 0 Then
                For i As Int32 = 0 To listaRoles.Count - 1
                    If (listaRoles(i) = Enumeradores.RolDeUsuario.Auditor OrElse listaRoles(i) = Enumeradores.RolDeUsuario.AuditorUMEFP) Then
                        rolEnvioCorreo = True
                        enviarCorreoProveedor = False
                        Exit For
                    End If
                Next
            End If

            If enviarCorreoProveedor AndAlso idAccionSegui = 0 Then

            End If

            If rolEnvioCorreo AndAlso idAccionSegui = 0 Then
                'Notificar por correo
                Dim lCorreosDestinatarios As New List(Of String)
                Dim CorreoUsuarioActual As String
                Dim lRolesAsocPrograma As New List(Of String)
                Dim lTecnicos As List(Of cmembershipUser)

                CorreoUsuarioActual = _mp.ObtenerEmailPorNombreUsuario(Utilerias.ObtenerUsuario)
                lRolesAsocPrograma.Add(RolDeUsuario.GerenteGFI)
                lRolesAsocPrograma.Add(RolDeUsuario.CoordinadorECentro)
                lRolesAsocPrograma.Add(RolDeUsuario.CoordinadorGFI)
                lRolesAsocPrograma.Add(RolDeUsuario.SoporteGFI)

                lTecnicos = _mp.ObtenerLista(lRolesAsocPrograma)
                For Each mUsuarioTecnico As cmembershipUser In lTecnicos
                    If mUsuarioTecnico.IsApproved Then
                        lCorreosDestinatarios.Add(mUsuarioTecnico.Email)
                    End If
                Next

                If lCorreosDestinatarios.Count > 0 Then
                    Dim lProveedor As PROVEEDOR_AF
                    Dim sInfoContrato As String = (New cACCION_FORMATIVA).ObtenerInfoContratacion(aEntidad.ID_ACCION_FORMATIVA)

                    If lAccion IsNot Nothing Then
                        lProveedor = (New cPROVEEDOR_AF).ObtenerPROVEEDOR_AF(lAccion.ID_PROVEEDOR_AF)
                    End If

                    Dim lUsuario As USUARIO = (New cUSUARIO).ObtenerUSUARIO(Utilerias.ObtenerUsuario)
                    Dim Cuerpo As New StringBuilder

                    Cuerpo.Append("<html>")
                    Cuerpo.Append("<body>")
                    Cuerpo.AppendLine("Visita de seguimiento") : Cuerpo.Append("<br/>")
                    Cuerpo.AppendLine("") : Cuerpo.Append("<br/>")
                    Cuerpo.AppendLine("")
                    Cuerpo.AppendLine("Informacion de la visita") : Cuerpo.Append("<br/>")
                    Cuerpo.AppendLine("") : Cuerpo.Append("<br/>")
                    If lUsuario IsNot Nothing Then
                        Cuerpo.Append("Ingresada por: ") : Cuerpo.AppendLine(lUsuario.NOMBRE) : Cuerpo.Append("<br/>")
                    End If
                    If lProveedor IsNot Nothing Then Cuerpo.Append("Proveedor: ") : Cuerpo.Append(lProveedor.NOMBRE_PROVEEDOR) : Cuerpo.Append("<br/>")
                    If sInfoContrato <> "" Then Cuerpo.Append(sInfoContrato) : Cuerpo.Append("<br/>")
                    If lAccion IsNot Nothing Then Cuerpo.Append("Curso: ") : Cuerpo.Append(lAccion.NOMBRE_ACCION_FORMATIVA) : Cuerpo.Append("<br/>")
                    If lAccion IsNot Nothing Then Cuerpo.Append("Codigo: ") : Cuerpo.Append(lAccion.CODIGO_GRUPO) : Cuerpo.Append("<br/>")
                    If lAccionDetalle IsNot Nothing Then Cuerpo.Append("Lugar ejecucion: ") : Cuerpo.Append(lAccionDetalle.LUGAR_EJECUCION) : Cuerpo.Append("<br/>")
                    Cuerpo.Append("Fecha de la visita: ") : Cuerpo.Append(aEntidad.FECHA_VISITA.ToString("dd/MM/yyyy")) : Cuerpo.Append("<br/>")
                    Cuerpo.Append("Observacion: ") : Cuerpo.Append(aEntidad.OBSERVACION) : Cuerpo.Append("<br/>")
                    Cuerpo.Append("Fecha de registro en sistema: ") : Cuerpo.Append(aEntidad.FECHA_CREACION.ToString("dd/MM/yyyy HH:mm")) : Cuerpo.Append("<br/>")
                    Cuerpo.Append("</body>")
                    Cuerpo.Append("</html>")

                    lCCO.Add(CorreoUsuarioActual)
                    Return _mp.EnviarCorreo(CorreoUsuarioActual, lCorreosDestinatarios, "Notificacion de Visita de Seguimiento", Cuerpo.ToString, , lCCO, True)
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
