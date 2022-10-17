Imports System.ComponentModel
Imports System.Web.UI

''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_WebUC
''' Class	 : WebUC.ddlTIPO_EMPLEO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista Desplegable Web
''' de la tabla TIPO_EMPLEO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	14/02/2011	Created
''' </history>
''' -----------------------------------------------------------------------------
<DefaultProperty("ID_TIPO_EMPLEO"), ToolboxData("<{0}:ddlTIPO_EMPLEO runat=server></{0}:ddlTIPO_EMPLEO>")> _
Public Class ddlTIPO_EMPLEO
    Inherits ddlBase

    Private Sub RecuperarLista()
        Dim miComponente As New cTIPO_EMPLEO
        Dim Lista As New ListaTIPO_EMPLEO

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "NOMBRE_TIPO_EMPLEO"
        Me.DataValueField = "ID_TIPO_EMPLEO"

        Me.DataBind()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el DropDownList con los Datos de la Tabla TIPO_EMPLEO.
    ''' </summary>
    ''' <remarks>
    ''' Si la tabla es de llave compuesta, recibe los parametros de la Tabla Padre
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	14/02/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub Recuperar()
        RecuperarLista()
    End Sub

End Class
