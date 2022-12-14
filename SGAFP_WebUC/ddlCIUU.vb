Imports System.ComponentModel
Imports System.Web.UI

''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_WebUC
''' Class	 : WebUC.ddlCIUU
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista Desplegable Web
''' de la tabla CIUU
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
<DefaultProperty("CIUU"), ToolboxData("<{0}:ddlCIUU runat=server></{0}:ddlCIUU>")> _
Public Class ddlCIUU
    Inherits ddlBase

    Private Sub RecuperarLista()
        Dim miComponente As New cCIUU
        Dim Lista As New listaCIUU

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "DESCRIPCION_CIIU"
        Me.DataValueField = "CIUU"

        Me.DataBind()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el DropDownList con los Datos de la Tabla CIUU.
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

End Class
