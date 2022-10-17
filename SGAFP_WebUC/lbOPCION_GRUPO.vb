Imports System.ComponentModel
Imports System.Web.UI

''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_WebUC
''' Class	 : WebUC.lbOPCION_GRUPO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista de Seleccion Web
''' de la tabla OPCION_GRUPO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
<DefaultProperty("ID_OPCION_GRUPO"), ToolboxData("<{0}:lbOPCION_GRUPO runat=server></{0}:lbOPCION_GRUPO>")> _
Public Class lbOPCION_GRUPO
    Inherits lbBase

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el ListBox con los Datos de la Tabla OPCION_GRUPO.
    ''' </summary>
    ''' <remarks>
    ''' Si la tabla es de llave compuesta, recibe los parametros de la Tabla Padre
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub Recuperar()
        Dim miComponente As New cOPCION_GRUPO
        Dim Lista As New listaOPCION_GRUPO

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "FECHA_INGRESO"
        Me.DataValueField = "ID_OPCION_GRUPO"

        Me.DataBind()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla OPCION_MENU .
    ''' </summary>
    ''' <param name="ID_OPCION_MENU"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorOPCION_MENU(ByVal ID_OPCION_MENU As Decimal)
        Dim miComponente As New cOPCION_GRUPO
        Dim Lista As New listaOPCION_GRUPO

        Lista = miComponente.ObtenerListaPorOPCION_MENU(ID_OPCION_MENU)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "FECHA_INGRESO"
        Me.DataValueField = "ID_OPCION_GRUPO"

        Me.DataBind()

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla GRUPO_USUARIO .
    ''' </summary>
    ''' <param name="ID_GRUPO_USUARIO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorGRUPO_USUARIO(ByVal ID_GRUPO_USUARIO As Decimal)
        Dim miComponente As New cOPCION_GRUPO
        Dim Lista As New listaOPCION_GRUPO

        Lista = miComponente.ObtenerListaPorGRUPO_USUARIO(ID_GRUPO_USUARIO)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "FECHA_INGRESO"
        Me.DataValueField = "ID_OPCION_GRUPO"

        Me.DataBind()

    End Sub

End Class
