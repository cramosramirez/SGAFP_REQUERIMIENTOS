Imports System.ComponentModel
Imports System.Web.UI

''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_WebUC
''' Class	 : WebUC.ddlGRUPO_SOLICITUD
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista Desplegable Web
''' de la tabla GRUPO_SOLICITUD
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	05/10/2012	Created
''' </history>
''' -----------------------------------------------------------------------------
<DefaultProperty("ID_GRUPO_SOLICITUD"), ToolboxData("<{0}:ddlGRUPO_SOLICITUD runat=server></{0}:ddlGRUPO_SOLICITUD>")> _
Public Class ddlGRUPO_SOLICITUD
    Inherits ddlBase

    Private Sub RecuperarLista()
        Dim miComponente As New cGRUPO_SOLICITUD
        Dim Lista As New ListaGRUPO_SOLICITUD

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "CODIGO_PROGRAMA"
        Me.DataValueField = "ID_GRUPO_SOLICITUD"

        Me.DataBind()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el DropDownList con los Datos de la Tabla GRUPO_SOLICITUD.
    ''' </summary>
    ''' <remarks>
    ''' Si la tabla es de llave compuesta, recibe los parametros de la Tabla Padre
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub Recuperar()
        RecuperarLista()
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
        Dim miComponente As New cGRUPO_SOLICITUD
        Dim Lista As New ListaGRUPO_SOLICITUD

        Lista = miComponente.ObtenerListaPorSOLICITUD_CAPACITACION(ID_SOLICITUD)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "CODIGO_PROGRAMA"
        Me.DataValueField = "ID_GRUPO_SOLICITUD"

        Me.DataBind()

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla MODALIDAD_DE_FORMACION .
    ''' </summary>
    ''' <param name="ID_MODALIDAD_FORMACION"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorMODALIDAD_DE_FORMACION(ByVal ID_MODALIDAD_FORMACION As Decimal)
        Dim miComponente As New cGRUPO_SOLICITUD
        Dim Lista As New ListaGRUPO_SOLICITUD

        Lista = miComponente.ObtenerListaPorMODALIDAD_DE_FORMACION(ID_MODALIDAD_FORMACION)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "CODIGO_PROGRAMA"
        Me.DataValueField = "ID_GRUPO_SOLICITUD"

        Me.DataBind()

    End Sub

End Class
