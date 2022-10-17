Imports System.ComponentModel
Imports System.Web.UI

''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_WebUC
''' Class	 : WebUC.ddlDISCA_POR_SOLICITUD
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista Desplegable Web
''' de la tabla DISCA_POR_SOLICITUD
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	19/01/2011	Created
''' </history>
''' -----------------------------------------------------------------------------
<DefaultProperty("ID_DISCAPACIDAD"), ToolboxData("<{0}:ddlDISCA_POR_SOLICITUD runat=server></{0}:ddlDISCA_POR_SOLICITUD>")> _
Public Class ddlDISCA_POR_SOLICITUD
    Inherits ddlBase

    Private Sub RecuperarLista(ByVal ID_SOLICITUD As Decimal)
        Dim miComponente As New cDISCA_POR_SOLICITUD
        Dim Lista As New ListaDISCA_POR_SOLICITUD

        Lista = miComponente.ObtenerLista(ID_SOLICITUD)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "USERID"
        Me.DataValueField = "ID_DISCAPACIDAD"

        Me.DataBind()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el DropDownList con los Datos de la Tabla DISCA_POR_SOLICITUD.
    ''' </summary>
    ''' <param name="ID_SOLICITUD"></param>
    ''' <remarks>
    ''' Si la tabla es de llave compuesta, recibe los parametros de la Tabla Padre
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/01/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub Recuperar(ByVal ID_SOLICITUD As Decimal)
        RecuperarLista(ID_SOLICITUD)
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla DISCAPACIDAD .
    ''' </summary>
    ''' <param name="ID_DISCAPACIDAD"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/01/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorDISCAPACIDAD(ByVal ID_DISCAPACIDAD As Decimal)
        Dim miComponente As New cDISCA_POR_SOLICITUD
        Dim Lista As New ListaDISCA_POR_SOLICITUD

        Lista = miComponente.ObtenerListaPorDISCAPACIDAD(ID_DISCAPACIDAD)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "USERID"
        Me.DataValueField = "ID_DISCAPACIDAD"

        Me.DataBind()

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla SOLICITUD_INSCRIPCION_AF .
    ''' </summary>
    ''' <param name="ID_SOLICITUD"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/01/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorSOLICITUD_INSCRIPCION_AF(ByVal ID_SOLICITUD As Decimal)
        Dim miComponente As New cDISCA_POR_SOLICITUD
        Dim Lista As New ListaDISCA_POR_SOLICITUD

        Lista = miComponente.ObtenerListaPorSOLICITUD_INSCRIPCION_AF(ID_SOLICITUD)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "USERID"
        Me.DataValueField = "ID_DISCAPACIDAD"

        Me.DataBind()

    End Sub

End Class
