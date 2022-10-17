Imports System.ComponentModel
Imports System.Web.UI

''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_WebUC
''' Class	 : WebUC.ddlCENTRO_RESPONSABILIDAD
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista Desplegable Web
''' de la tabla CENTRO_RESPONSABILIDAD
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	05/10/2012	Created
''' </history>
''' -----------------------------------------------------------------------------
<DefaultProperty("ID_CENTRO_RESPONSABILIDAD"), ToolboxData("<{0}:ddlCENTRO_RESPONSABILIDAD runat=server></{0}:ddlCENTRO_RESPONSABILIDAD>")> _
Public Class ddlCENTRO_RESPONSABILIDAD
    Inherits ddlBase

    Private Sub RecuperarLista()
        Dim miComponente As New cCENTRO_RESPONSABILIDAD
        Dim Lista As New ListaCENTRO_RESPONSABILIDAD

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "CODIGO_CENTRO_RESPONSABILIDAD"
        Me.DataValueField = "ID_CENTRO_RESPONSABILIDAD"

        Me.DataBind()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el DropDownList con los Datos de la Tabla CENTRO_RESPONSABILIDAD.
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

End Class
