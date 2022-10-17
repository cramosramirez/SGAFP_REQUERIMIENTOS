Imports System.ComponentModel
Imports System.Web.UI

''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_WebUC
''' Class	 : WebUC.ddlTECNICOS_SITIOS_ASIG
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista Desplegable Web
''' de la tabla TECNICOS_SITIOS_ASIG
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	01/06/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
<DefaultProperty("ID_SITIO_CAPACITACION"), ToolboxData("<{0}:ddlTECNICOS_SITIOS_ASIG runat=server></{0}:ddlTECNICOS_SITIOS_ASIG>")> _
Public Class ddlTECNICOS_SITIOS_ASIG
    Inherits ddlBase

    Private Sub RecuperarLista(ByVal USUARIO As String, ByVal ID_PROVEEDOR_AF As Decimal)
        Dim miComponente As New cTECNICOS_SITIOS_ASIG
        Dim Lista As New listaTECNICOS_SITIOS_ASIG

        Lista = miComponente.ObtenerLista(USUARIO, ID_PROVEEDOR_AF)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "USERID"
        Me.DataValueField = "ID_SITIO_CAPACITACION"

        Me.DataBind()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el DropDownList con los Datos de la Tabla TECNICOS_SITIOS_ASIG.
    ''' </summary>
    ''' <param name="USUARIO"></param>
    ''' <param name="ID_PROVEEDOR_AF"></param>
    ''' <remarks>
    ''' Si la tabla es de llave compuesta, recibe los parametros de la Tabla Padre
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	01/06/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub Recuperar(ByVal USUARIO As String, ByVal ID_PROVEEDOR_AF As Decimal)
        RecuperarLista(USUARIO, ID_PROVEEDOR_AF)
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla USUARIO .
    ''' </summary>
    ''' <param name="USUARIO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	01/06/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorUSUARIO(ByVal USUARIO As String)
        Dim miComponente As New cTECNICOS_SITIOS_ASIG
        Dim Lista As New listaTECNICOS_SITIOS_ASIG

        Lista = miComponente.ObtenerListaPorUSUARIO(USUARIO)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "USERID"
        Me.DataValueField = "ID_SITIO_CAPACITACION"

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
    ''' 	[GenApp]	01/06/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorPROVEEDOR_AF(ByVal ID_PROVEEDOR_AF As Decimal)
        Dim miComponente As New cTECNICOS_SITIOS_ASIG
        Dim Lista As New listaTECNICOS_SITIOS_ASIG

        Lista = miComponente.ObtenerListaPorPROVEEDOR_AF(ID_PROVEEDOR_AF)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "USERID"
        Me.DataValueField = "ID_SITIO_CAPACITACION"

        Me.DataBind()

    End Sub

End Class
