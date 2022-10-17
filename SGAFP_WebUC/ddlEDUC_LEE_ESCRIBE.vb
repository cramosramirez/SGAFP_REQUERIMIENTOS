Imports System.ComponentModel
Imports System.Web.UI

''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_WebUC
''' Class	 : WebUC.ddlEDUC_LEE_ESCRIBE
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista Desplegable Web
''' de la tabla EDUC_LEE_ESCRIBE
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	19/01/2011	Created
''' </history>
''' -----------------------------------------------------------------------------
<DefaultProperty("ID_LEE_ESCRIBE"), ToolboxData("<{0}:ddlEDUC_LEE_ESCRIBE runat=server></{0}:ddlEDUC_LEE_ESCRIBE>")> _
Public Class ddlEDUC_LEE_ESCRIBE
    Inherits ddlBase

    Private Sub RecuperarLista()
        Dim miComponente As New cEDUC_LEE_ESCRIBE
        Dim Lista As New ListaEDUC_LEE_ESCRIBE

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "NOMBRE_LEE_ESCRIBE"
        Me.DataValueField = "ID_LEE_ESCRIBE"

        Me.DataBind()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el DropDownList con los Datos de la Tabla EDUC_LEE_ESCRIBE.
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

End Class
