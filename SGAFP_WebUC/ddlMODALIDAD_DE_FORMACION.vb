Imports System.ComponentModel
Imports System.Web.UI

''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_WebUC
''' Class	 : WebUC.ddlMODALIDAD_DE_FORMACION
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista Desplegable Web
''' de la tabla MODALIDAD_DE_FORMACION
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	05/10/2012	Created
''' </history>
''' -----------------------------------------------------------------------------
<DefaultProperty("ID_MODALIDAD_FORMACION"), ToolboxData("<{0}:ddlMODALIDAD_DE_FORMACION runat=server></{0}:ddlMODALIDAD_DE_FORMACION>")> _
Public Class ddlMODALIDAD_DE_FORMACION
    Inherits ddlBase

    Private Sub RecuperarLista()
        Dim miComponente As New cMODALIDAD_DE_FORMACION
        Dim Lista As New ListaMODALIDAD_DE_FORMACION

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "MODALIDAD_FORMACION"
        Me.DataValueField = "ID_MODALIDAD_FORMACION"

        Me.DataBind()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el DropDownList con los Datos de la Tabla MODALIDAD_DE_FORMACION.
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
