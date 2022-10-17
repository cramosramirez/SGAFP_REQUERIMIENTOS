Imports System.ComponentModel
Imports System.Web.UI

''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_WebUC
''' Class	 : WebUC.ddlSOLIC_EMPLEO_ANTERIOR
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista Desplegable Web
''' de la tabla SOLIC_EMPLEO_ANTERIOR
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	19/01/2011	Created
''' </history>
''' -----------------------------------------------------------------------------
<DefaultProperty("ID_EMPLEO_ANT"), ToolboxData("<{0}:ddlSOLIC_EMPLEO_ANTERIOR runat=server></{0}:ddlSOLIC_EMPLEO_ANTERIOR>")> _
Public Class ddlSOLIC_EMPLEO_ANTERIOR
    Inherits ddlBase

    Private Sub RecuperarLista()
        Dim miComponente As New cSOLIC_EMPLEO_ANTERIOR
        Dim Lista As New ListaSOLIC_EMPLEO_ANTERIOR

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "TIEMPO_NO_TRABAJA"
        Me.DataValueField = "ID_EMPLEO_ANT"

        Me.DataBind()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el DropDownList con los Datos de la Tabla SOLIC_EMPLEO_ANTERIOR.
    ''' </summary>
    ''' <remarks>
    ''' Si la tabla es de llave compuesta, recibe los parametros de la Tabla Padre
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/01/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub Recuperar()
        RecuperarLista()
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
        Dim miComponente As New cSOLIC_EMPLEO_ANTERIOR
        Dim Lista As New ListaSOLIC_EMPLEO_ANTERIOR

        Lista = miComponente.ObtenerListaPorSOLICITUD_INSCRIPCION_AF(ID_SOLICITUD)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "TIEMPO_NO_TRABAJA"
        Me.DataValueField = "ID_EMPLEO_ANT"

        Me.DataBind()

    End Sub

End Class
