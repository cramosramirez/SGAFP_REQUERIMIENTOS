Imports System.ComponentModel
Imports System.Web.UI
Imports System.Web.UI.WebControls

''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_WebUC
''' Class	 : WebUC.lbBase
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase Base para Controles ListBox Web
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
Public Class lbBase
    Inherits System.Web.UI.WebControls.ListBox

    Public Sub CargarPorLista(ByVal aLista As IBindingListView, Optional ByVal asDataTextField As String = "", Optional ByVal asDataValueField As String = "")
        If asDataTextField <> "" Then Me.DataTextField = asDataTextField
        If asDataValueField <> "" Then Me.DataValueField = asDataValueField
        If aLista Is Nothing Then Return
        Me.DataSource = aLista
        Me.DataBind()
    End Sub

End Class
