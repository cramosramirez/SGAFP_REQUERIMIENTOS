Imports System.ComponentModel
Imports System.Web.UI

''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_WebUC
''' Class	 : WebUC.ddlPROGRAMA_FORMACION_TIPOPAGO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista Desplegable Web
''' de la tabla PROGRAMA_FORMACION_TIPOPAGO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	05/10/2012	Created
''' </history>
''' -----------------------------------------------------------------------------
<DefaultProperty("ID_TIPO_PAGO"), ToolboxData("<{0}:ddlPROGRAMA_FORMACION_TIPOPAGO runat=server></{0}:ddlPROGRAMA_FORMACION_TIPOPAGO>")> _
Public Class ddlPROGRAMA_FORMACION_TIPOPAGO
    Inherits ddlBase

    Private Sub RecuperarLista()
        Dim miComponente As New cPROGRAMA_FORMACION_TIPOPAGO
        Dim Lista As New ListaPROGRAMA_FORMACION_TIPOPAGO

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "NOMBRE_TIPO_PAGO"
        Me.DataValueField = "ID_TIPO_PAGO"

        Me.DataBind()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el DropDownList con los Datos de la Tabla PROGRAMA_FORMACION_TIPOPAGO.
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
