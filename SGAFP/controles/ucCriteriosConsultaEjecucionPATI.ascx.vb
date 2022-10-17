Imports DevExpress.Web

Partial Class controles_ucCriteriosConsultaEjecucionPATI
    Inherits ucBase

#Region " Propiedades "
    Public Property ucIDClientInstanceCallbackPanel() As String
        Get
            If Me.ViewState("IdClientCallback") Is Nothing Then Return "CallbackPanel"
            Return Me.ViewState("IdClientCallback")
        End Get
        Set(ByVal value As String)
            Me.ViewState("IdClientCallback") = value
        End Set
    End Property

    Public Property VerFuente() As Boolean
        Get
            Return Me.trFuente.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trFuente.Visible = value
        End Set
    End Property

    Public Property VerConvocatoria() As Boolean
        Get
            Return Me.trConvocatoria.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trConvocatoria.Visible = value
        End Set
    End Property

    Private Sub SetClickPerformCallback()
        Dim scriptClick As New StringBuilder
        Dim Criterios As New StringBuilder

        'Definir los parámetros a enviar al método PerformCallback de CallbackPanel
        If Me.trFuente.Visible Then
            If Criterios.Length > 0 Then Criterios.Append(" + ';' + ")
            Criterios.Append(Me.cbxFuenteFinanc.ClientInstanceName + ".GetValue()")
        End If
        If Me.trConvocatoria.Visible Then
            If Criterios.Length > 0 Then Criterios.Append(" + ';' + ")
            Criterios.Append(Me.seConvocatoria.ClientInstanceName + ".GetValue()")
        End If

        'Implementando el evento click
        scriptClick.Append("  function(s, e){ ")
        scriptClick.Append(Me.ucIDClientInstanceCallbackPanel + ".PerformCallback(")
        scriptClick.Append(Criterios.ToString)
        scriptClick.Append(");")
        scriptClick.Append("  } ")
    End Sub

    Public ReadOnly Property idFuente() As Integer
        Get
            Return Me.cbxFuenteFinanc.Value
        End Get
    End Property

    Public ReadOnly Property noConvocatoria() As Integer
        Get
            Return Me.seConvocatoria.Value
        End Get
    End Property

#End Region

    Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
        cbxFuenteFinanc.DataSourceID = "odsFuenteFinanc"
        cbxFuenteFinanc.DataBind()
    End Sub
End Class
