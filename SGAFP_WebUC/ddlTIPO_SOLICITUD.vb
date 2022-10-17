Imports System.ComponentModel
Imports System.Web.UI

''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_WebUC
''' Class	 : WebUC.ddlTIPO_SOLICITUD
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista Desplegable Web
''' de la tabla TIPO_SOLICITUD
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
<DefaultProperty("ID_TIPO_SOLICITUD"), ToolboxData("<{0}:ddlTIPO_SOLICITUD runat=server></{0}:ddlTIPO_SOLICITUD>")> _
Public Class ddlTIPO_SOLICITUD
    Inherits ddlBase

    Private Sub RecuperarLista()
        Dim miComponente As New cTIPO_SOLICITUD
        Dim Lista As New listaTIPO_SOLICITUD

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "TIPO_SOLICITUD"
        Me.DataValueField = "ID_TIPO_SOLICITUD"

        Me.DataBind()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el DropDownList con los Datos de la Tabla TIPO_SOLICITUD.
    ''' </summary>
    ''' <remarks>
    ''' Si la tabla es de llave compuesta, recibe los parametros de la Tabla Padre
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub Recuperar()
        RecuperarLista()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla PROCESO .
    ''' </summary>
    ''' <param name="CODIGO_PROCESO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorPROCESO(ByVal CODIGO_PROCESO As String)
        Dim miComponente As New cTIPO_SOLICITUD
        Dim Lista As New listaTIPO_SOLICITUD

        Lista = miComponente.ObtenerListaPorPROCESO(CODIGO_PROCESO)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "TIPO_SOLICITUD"
        Me.DataValueField = "ID_TIPO_SOLICITUD"

        Me.DataBind()

    End Sub

End Class
