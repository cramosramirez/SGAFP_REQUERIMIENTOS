Imports System.ComponentModel
Imports System.Web.UI

''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_WebUC
''' Class	 : WebUC.lbHALLAZGO_SUPERVISION
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista de Seleccion Web
''' de la tabla HALLAZGO_SUPERVISION
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
<DefaultProperty("ID_HALLAZGO_SUPERVISION"), ToolboxData("<{0}:lbHALLAZGO_SUPERVISION runat=server></{0}:lbHALLAZGO_SUPERVISION>")> _
Public Class lbHALLAZGO_SUPERVISION
    Inherits lbBase

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el ListBox con los Datos de la Tabla HALLAZGO_SUPERVISION.
    ''' </summary>
    ''' <remarks>
    ''' Si la tabla es de llave compuesta, recibe los parametros de la Tabla Padre
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub Recuperar()
        Dim miComponente As New cHALLAZGO_SUPERVISION
        Dim Lista As New listaHALLAZGO_SUPERVISION

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "HALLAZGO_SUPERVISION"
        Me.DataValueField = "ID_HALLAZGO_SUPERVISION"

        Me.DataBind()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla AREA_SUPERVISION .
    ''' </summary>
    ''' <param name="ID_AREA_SUPERVISION"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorAREA_SUPERVISION(ByVal ID_AREA_SUPERVISION As Decimal)
        Dim miComponente As New cHALLAZGO_SUPERVISION
        Dim Lista As New listaHALLAZGO_SUPERVISION

        Lista = miComponente.ObtenerListaPorAREA_SUPERVISION(ID_AREA_SUPERVISION)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "HALLAZGO_SUPERVISION"
        Me.DataValueField = "ID_HALLAZGO_SUPERVISION"

        Me.DataBind()

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla SUPERVISION_AF .
    ''' </summary>
    ''' <param name="ID_SUPERVISION_AF"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorSUPERVISION_AF(ByVal ID_SUPERVISION_AF As Decimal)
        Dim miComponente As New cHALLAZGO_SUPERVISION
        Dim Lista As New listaHALLAZGO_SUPERVISION

        Lista = miComponente.ObtenerListaPorSUPERVISION_AF(ID_SUPERVISION_AF)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "HALLAZGO_SUPERVISION"
        Me.DataValueField = "ID_HALLAZGO_SUPERVISION"

        Me.DataBind()

    End Sub

End Class
