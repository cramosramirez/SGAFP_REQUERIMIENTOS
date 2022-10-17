Imports System.ComponentModel
Imports System.Web.UI

''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_WebUC
''' Class	 : WebUC.lbFUENTE_FINANCIAMIENTO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista de Seleccion Web
''' de la tabla FUENTE_FINANCIAMIENTO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	08/07/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
<DefaultProperty("ID_FUENTE"), ToolboxData("<{0}:lbFUENTE_FINANCIAMIENTO runat=server></{0}:lbFUENTE_FINANCIAMIENTO>")> _
Public Class lbFUENTE_FINANCIAMIENTO
    Inherits lbBase

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el ListBox con los Datos de la Tabla FUENTE_FINANCIAMIENTO.
    ''' </summary>
    ''' <remarks>
    ''' Si la tabla es de llave compuesta, recibe los parametros de la Tabla Padre
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	08/07/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub Recuperar()
        Dim miComponente As New cFUENTE_FINANCIAMIENTO
        Dim Lista As New listaFUENTE_FINANCIAMIENTO

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "NOMBRE_FUENTE"
        Me.DataValueField = "ID_FUENTE"

        Me.DataBind()
    End Sub

End Class
