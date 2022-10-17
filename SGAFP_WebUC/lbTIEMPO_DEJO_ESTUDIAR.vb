Imports System.ComponentModel
Imports System.Web.UI

''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_WebUC
''' Class	 : WebUC.lbTIEMPO_DEJO_ESTUDIAR
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista de Seleccion Web
''' de la tabla TIEMPO_DEJO_ESTUDIAR
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	19/01/2011	Created
''' </history>
''' -----------------------------------------------------------------------------
<DefaultProperty("ID_TIEMPO_DEJO_ESTUDIAR"), ToolboxData("<{0}:lbTIEMPO_DEJO_ESTUDIAR runat=server></{0}:lbTIEMPO_DEJO_ESTUDIAR>")> _
Public Class lbTIEMPO_DEJO_ESTUDIAR
    Inherits lbBase

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el ListBox con los Datos de la Tabla TIEMPO_DEJO_ESTUDIAR.
    ''' </summary>
    ''' <remarks>
    ''' Si la tabla es de llave compuesta, recibe los parametros de la Tabla Padre
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/01/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub Recuperar()
        Dim miComponente As New cTIEMPO_DEJO_ESTUDIAR
        Dim Lista As New ListaTIEMPO_DEJO_ESTUDIAR

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "NOMBRE_TIEMPO_DEJO_ESTUDIAR"
        Me.DataValueField = "ID_TIEMPO_DEJO_ESTUDIAR"

        Me.DataBind()
    End Sub

End Class
