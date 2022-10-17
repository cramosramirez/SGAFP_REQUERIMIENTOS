Imports System.ComponentModel
Imports System.Web.UI

''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_WebUC
''' Class	 : WebUC.lbTERMINO_REFERENCIA_AF
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista de Seleccion Web
''' de la tabla TERMINO_REFERENCIA_AF
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	05/10/2012	Created
''' </history>
''' -----------------------------------------------------------------------------
<DefaultProperty("ID_ACCION_FORMATIVA"), ToolboxData("<{0}:lbTERMINO_REFERENCIA_AF runat=server></{0}:lbTERMINO_REFERENCIA_AF>")> _
Public Class lbTERMINO_REFERENCIA_AF
    Inherits lbBase

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el ListBox con los Datos de la Tabla TERMINO_REFERENCIA_AF.
    ''' </summary>
    ''' <remarks>
    ''' Si la tabla es de llave compuesta, recibe los parametros de la Tabla Padre
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub Recuperar()
        Dim miComponente As New cTERMINO_REFERENCIA_AF
        Dim Lista As New ListaTERMINO_REFERENCIA_AF

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "RESOLUCION"
        Me.DataValueField = "ID_ACCION_FORMATIVA"

        Me.DataBind()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla ACCION_FORMATIVA .
    ''' </summary>
    ''' <param name="ID_ACCION_FORMATIVA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorACCION_FORMATIVA(ByVal ID_ACCION_FORMATIVA As Decimal)
        Dim miComponente As New cTERMINO_REFERENCIA_AF
        Dim Lista As New ListaTERMINO_REFERENCIA_AF

        Lista = miComponente.ObtenerListaPorACCION_FORMATIVA(ID_ACCION_FORMATIVA)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "RESOLUCION"
        Me.DataValueField = "ID_ACCION_FORMATIVA"

        Me.DataBind()

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla SOLICITUD_CAPACITACION .
    ''' </summary>
    ''' <param name="ID_SOLICITUD"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorSOLICITUD_CAPACITACION(ByVal ID_SOLICITUD As Decimal)
        Dim miComponente As New cTERMINO_REFERENCIA_AF
        Dim Lista As New ListaTERMINO_REFERENCIA_AF

        Lista = miComponente.ObtenerListaPorSOLICITUD_CAPACITACION(ID_SOLICITUD)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "RESOLUCION"
        Me.DataValueField = "ID_ACCION_FORMATIVA"

        Me.DataBind()

    End Sub

End Class
