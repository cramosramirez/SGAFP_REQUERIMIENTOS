Imports System.ComponentModel
Imports System.Web.UI

''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_WebUC
''' Class	 : WebUC.ddlAREA_FORMACION
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista Desplegable Web
''' de la tabla AREA_FORMACION
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
<DefaultProperty("ID_AREA_FORMACION"), ToolboxData("<{0}:ddlAREA_FORMACION runat=server></{0}:ddlAREA_FORMACION>")> _
Public Class ddlAREA_FORMACION
    Inherits ddlBase

    Private Sub RecuperarLista()
        Dim miComponente As New cAREA_FORMACION
        Dim Lista As New listaAREA_FORMACION

        Lista = miComponente.ObtenerLista(False, "AREA_FORMACION")
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "AREA_FORMACION"
        Me.DataValueField = "ID_AREA_FORMACION"

        Me.DataBind()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el DropDownList con los Datos de la Tabla AREA_FORMACION.
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
