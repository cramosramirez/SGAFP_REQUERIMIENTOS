Imports System.ComponentModel
Imports System.Web.UI

''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_WebUC
''' Class	 : WebUC.lbPROGRAMA_FORMACION_TIPOPAGO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista de Seleccion Web
''' de la tabla PROGRAMA_FORMACION_TIPOPAGO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	05/10/2012	Created
''' </history>
''' -----------------------------------------------------------------------------
<DefaultProperty("ID_TIPO_PAGO"), ToolboxData("<{0}:lbPROGRAMA_FORMACION_TIPOPAGO runat=server></{0}:lbPROGRAMA_FORMACION_TIPOPAGO>")> _
Public Class lbPROGRAMA_FORMACION_TIPOPAGO
    Inherits lbBase

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el ListBox con los Datos de la Tabla PROGRAMA_FORMACION_TIPOPAGO.
    ''' </summary>
    ''' <remarks>
    ''' Si la tabla es de llave compuesta, recibe los parametros de la Tabla Padre
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub Recuperar()
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

End Class
