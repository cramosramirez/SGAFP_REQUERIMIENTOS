Imports System.ComponentModel
Imports System.Web.UI

''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_WebUC
''' Class	 : WebUC.ddlOFERTA_FORMATIVA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista Desplegable Web
''' de la tabla OFERTA_FORMATIVA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
<DefaultProperty("ID_OFERTA_FORMATIVA"), ToolboxData("<{0}:ddlOFERTA_FORMATIVA runat=server></{0}:ddlOFERTA_FORMATIVA>")> _
Public Class ddlOFERTA_FORMATIVA
    Inherits ddlBase

    Private Sub RecuperarLista()
        Dim miComponente As New cOFERTA_FORMATIVA
        Dim Lista As New listaOFERTA_FORMATIVA

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "DURACION_HORAS"
        Me.DataValueField = "ID_OFERTA_FORMATIVA"

        Me.DataBind()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el DropDownList con los Datos de la Tabla OFERTA_FORMATIVA.
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
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla EJERCICIO .
    ''' </summary>
    ''' <param name="ID_EJERCICIO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorEJERCICIO(ByVal ID_EJERCICIO As String)
        Dim miComponente As New cOFERTA_FORMATIVA
        Dim Lista As New listaOFERTA_FORMATIVA

        Lista = miComponente.ObtenerListaPorEJERCICIO(ID_EJERCICIO)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "DURACION_HORAS"
        Me.DataValueField = "ID_OFERTA_FORMATIVA"

        Me.DataBind()

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla OFERTA_FORMATIVA .
    ''' </summary>
    ''' <param name="ID_OFERTA_FORMATIVA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	03/01/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorOFERTA_FORMATIVA(ByVal ID_OFERTA_FORMATIVA As Decimal)
        Dim miComponente As New cOFERTA_FORMATIVA
        Dim Lista As New listaOFERTA_FORMATIVA
        Dim lEntidad As OFERTA_FORMATIVA = miComponente.ObtenerOFERTA_FORMATIVA(ID_OFERTA_FORMATIVA)

        lEntidad.TEMA_CURSO = (New cCURSO_TEMA).ObtenerCURSO_TEMA(lEntidad.ID_TEMA_CURSO).TEMA_CURSO
        Lista.Add(lEntidad)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "TEMA_CURSO"
        Me.DataValueField = "ID_OFERTA_FORMATIVA"

        Me.DataBind()

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla CURSO_TEMA .
    ''' </summary>
    ''' <param name="ID_TEMA_CURSO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorCURSO_TEMA(ByVal ID_TEMA_CURSO As Decimal)
        Dim miComponente As New cOFERTA_FORMATIVA
        Dim Lista As New listaOFERTA_FORMATIVA

        Lista = miComponente.ObtenerListaPorCURSO_TEMA(ID_TEMA_CURSO)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "DURACION_HORAS"
        Me.DataValueField = "ID_OFERTA_FORMATIVA"

        Me.DataBind()

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla PROVEEDOR_AF .
    ''' </summary>
    ''' <param name="ID_PROVEEDOR_AF"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorPROVEEDOR_AF(ByVal ID_PROVEEDOR_AF As Decimal)
        Dim miComponente As New cOFERTA_FORMATIVA
        Dim Lista As New listaOFERTA_FORMATIVA

        Lista = miComponente.ObtenerListaPorPROVEEDOR_AF(ID_PROVEEDOR_AF)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "DURACION_HORAS"
        Me.DataValueField = "ID_OFERTA_FORMATIVA"

        Me.DataBind()

    End Sub

End Class
