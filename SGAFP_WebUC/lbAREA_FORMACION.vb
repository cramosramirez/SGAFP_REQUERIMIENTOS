Imports System.ComponentModel
Imports System.Web.UI

''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_WebUC
''' Class	 : WebUC.lbAREA_FORMACION
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista de Seleccion Web
''' de la tabla AREA_FORMACION
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
<DefaultProperty("ID_AREA_FORMACION"), ToolboxData("<{0}:lbAREA_FORMACION runat=server></{0}:lbAREA_FORMACION>")> _
Public Class lbAREA_FORMACION
    Inherits lbBase

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el ListBox con los Datos de la Tabla AREA_FORMACION.
    ''' </summary>
    ''' <remarks>
    ''' Si la tabla es de llave compuesta, recibe los parametros de la Tabla Padre
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub Recuperar()
        Dim miComponente As New cAREA_FORMACION
        Dim Lista As New listaAREA_FORMACION

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "AREA_FORMACION"
        Me.DataValueField = "ID_AREA_FORMACION"

        Me.DataBind()
    End Sub

End Class
