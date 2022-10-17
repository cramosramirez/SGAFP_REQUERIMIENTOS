Imports System.ComponentModel
Imports System.Web.UI

''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_WebUC
''' Class	 : WebUC.lbSUPERVISION_AF_DET
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista de Seleccion Web
''' de la tabla SUPERVISION_AF_DET
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
<DefaultProperty("ID_SUPERVISION_DET"), ToolboxData("<{0}:lbSUPERVISION_AF_DET runat=server></{0}:lbSUPERVISION_AF_DET>")> _
Public Class lbSUPERVISION_AF_DET
    Inherits lbBase

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el ListBox con los Datos de la Tabla SUPERVISION_AF_DET.
    ''' </summary>
    ''' <remarks>
    ''' Si la tabla es de llave compuesta, recibe los parametros de la Tabla Padre
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub Recuperar()
        Dim miComponente As New cSUPERVISION_AF_DET
        Dim Lista As New listaSUPERVISION_AF_DET

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "COMENTARIOS"
        Me.DataValueField = "ID_SUPERVISION_DET"

        Me.DataBind()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla LISTA_SUPERVISION_AF .
    ''' </summary>
    ''' <param name="ID_LISTA_SUPERVISION"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorLISTA_SUPERVISION_AF(ByVal ID_LISTA_SUPERVISION As Decimal)
        Dim miComponente As New cSUPERVISION_AF_DET
        Dim Lista As New listaSUPERVISION_AF_DET

        Lista = miComponente.ObtenerListaPorLISTA_SUPERVISION_AF(ID_LISTA_SUPERVISION)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "COMENTARIOS"
        Me.DataValueField = "ID_SUPERVISION_DET"

        Me.DataBind()

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla SUPERVISION_AF .
    ''' </summary>
    ''' <param name="ID_SUPERVISION_AF"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorSUPERVISION_AF(ByVal ID_SUPERVISION_AF As Decimal)
        Dim miComponente As New cSUPERVISION_AF_DET
        Dim Lista As New listaSUPERVISION_AF_DET

        Lista = miComponente.ObtenerListaPorSUPERVISION_AF(ID_SUPERVISION_AF)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "COMENTARIOS"
        Me.DataValueField = "ID_SUPERVISION_DET"

        Me.DataBind()

    End Sub

End Class
