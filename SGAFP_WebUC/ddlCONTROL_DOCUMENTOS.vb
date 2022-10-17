Imports System.ComponentModel
Imports System.Web.UI

''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_WebUC
''' Class	 : WebUC.ddlCONTROL_DOCUMENTOS
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista Desplegable Web
''' de la tabla CONTROL_DOCUMENTOS
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
<DefaultProperty("NUMERO_DOCUMENTO"), ToolboxData("<{0}:ddlCONTROL_DOCUMENTOS runat=server></{0}:ddlCONTROL_DOCUMENTOS>")> _
Public Class ddlCONTROL_DOCUMENTOS
    Inherits ddlBase

    Private Sub RecuperarLista()
        Dim miComponente As New cCONTROL_DOCUMENTOS
        Dim Lista As New listaCONTROL_DOCUMENTOS

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "NUMERO_PATRONAL"
        Me.DataValueField = "NUMERO_DOCUMENTO"

        Me.DataBind()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el DropDownList con los Datos de la Tabla CONTROL_DOCUMENTOS.
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
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla TIPO_SOLICITUD .
    ''' </summary>
    ''' <param name="ID_TIPO_SOLICITUD"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorTIPO_SOLICITUD(ByVal ID_TIPO_SOLICITUD As Decimal)
        Dim miComponente As New cCONTROL_DOCUMENTOS
        Dim Lista As New listaCONTROL_DOCUMENTOS

        Lista = miComponente.ObtenerListaPorTIPO_SOLICITUD(ID_TIPO_SOLICITUD)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "NUMERO_PATRONAL"
        Me.DataValueField = "NUMERO_DOCUMENTO"

        Me.DataBind()

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla ETAPA .
    ''' </summary>
    ''' <param name="CODIGO_ETAPA"></param>
    ''' <param name="CODIGO_PROCESO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorETAPA(ByVal CODIGO_ETAPA As String, ByVal CODIGO_PROCESO As String)
        Dim miComponente As New cCONTROL_DOCUMENTOS
        Dim Lista As New listaCONTROL_DOCUMENTOS

        Lista = miComponente.ObtenerListaPorETAPA(CODIGO_ETAPA, CODIGO_PROCESO)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "NUMERO_PATRONAL"
        Me.DataValueField = "NUMERO_DOCUMENTO"

        Me.DataBind()

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
        Dim miComponente As New cCONTROL_DOCUMENTOS
        Dim Lista As New listaCONTROL_DOCUMENTOS

        Lista = miComponente.ObtenerListaPorPROCESO(CODIGO_PROCESO)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "NUMERO_PATRONAL"
        Me.DataValueField = "NUMERO_DOCUMENTO"

        Me.DataBind()

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla ESTADO_SOLICITUD .
    ''' </summary>
    ''' <param name="ID_ESTADO_SOLICITUD"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorESTADO_SOLICITUD(ByVal ID_ESTADO_SOLICITUD As Decimal)
        Dim miComponente As New cCONTROL_DOCUMENTOS
        Dim Lista As New listaCONTROL_DOCUMENTOS

        Lista = miComponente.ObtenerListaPorESTADO_SOLICITUD(ID_ESTADO_SOLICITUD)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "NUMERO_PATRONAL"
        Me.DataValueField = "NUMERO_DOCUMENTO"

        Me.DataBind()

    End Sub

End Class
