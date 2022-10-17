Imports System.ComponentModel
Imports System.Web.UI

''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_WebUC
''' Class	 : WebUC.lbUNIDAD_ORGANIZATIVA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista de Seleccion Web
''' de la tabla UNIDAD_ORGANIZATIVA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	05/10/2012	Created
''' </history>
''' -----------------------------------------------------------------------------
<DefaultProperty("ID_UNIDAD_ORGANIZATIVA"), ToolboxData("<{0}:lbUNIDAD_ORGANIZATIVA runat=server></{0}:lbUNIDAD_ORGANIZATIVA>")> _
Public Class lbUNIDAD_ORGANIZATIVA
    Inherits lbBase

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el ListBox con los Datos de la Tabla UNIDAD_ORGANIZATIVA.
    ''' </summary>
    ''' <remarks>
    ''' Si la tabla es de llave compuesta, recibe los parametros de la Tabla Padre
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub Recuperar()
        Dim miComponente As New cUNIDAD_ORGANIZATIVA
        Dim Lista As New ListaUNIDAD_ORGANIZATIVA

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "NOMBRE_UNIDAD"
        Me.DataValueField = "ID_UNIDAD_ORGANIZATIVA"

        Me.DataBind()
    End Sub

End Class
