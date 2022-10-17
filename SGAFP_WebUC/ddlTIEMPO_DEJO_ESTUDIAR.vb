Imports System.ComponentModel
Imports System.Web.UI

''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_WebUC
''' Class	 : WebUC.ddlTIEMPO_DEJO_ESTUDIAR
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista Desplegable Web
''' de la tabla TIEMPO_DEJO_ESTUDIAR
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	19/01/2011	Created
''' </history>
''' -----------------------------------------------------------------------------
<DefaultProperty("ID_TIEMPO_DEJO_ESTUDIAR"), ToolboxData("<{0}:ddlTIEMPO_DEJO_ESTUDIAR runat=server></{0}:ddlTIEMPO_DEJO_ESTUDIAR>")> _
Public Class ddlTIEMPO_DEJO_ESTUDIAR
    Inherits ddlBase

    Private Sub RecuperarLista()
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

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el DropDownList con los Datos de la Tabla TIEMPO_DEJO_ESTUDIAR.
    ''' </summary>
    ''' <remarks>
    ''' Si la tabla es de llave compuesta, recibe los parametros de la Tabla Padre
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/01/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub Recuperar()
        RecuperarLista()
    End Sub

End Class
