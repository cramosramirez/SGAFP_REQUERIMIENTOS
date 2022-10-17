
Partial Class controles_ucCriteriosParticipante
    Inherits ucBase

    Public ReadOnly Property idParticipante() As Decimal
        Get
            If Me.txtID_PARTICIPANTE.Text <> "" Then
                Return CDec(Me.txtID_PARTICIPANTE.Text)
            End If
            Return -1
        End Get
    End Property

    Public ReadOnly Property nombresParticipante() As String
        Get
            Return Me.txtNOMBRES.Text
        End Get
    End Property

    Public ReadOnly Property apellidosParticipante() As String
        Get
            Return Me.txtAPELLIDOS.Text
        End Get
    End Property

    Public ReadOnly Property fechaNacimientoParticipante() As Date
        Get
            If Me.dteFECHA_NACIMIENTO.Value IsNot Nothing Then
                Return dteFECHA_NACIMIENTO.Date
            End If
            Return Nothing
        End Get
    End Property

    Public ReadOnly Property duiParticipante() As String
        Get
            Return Me.txtDUI.Text
        End Get
    End Property

    Public ReadOnly Property nitParticipante() As String
        Get
            Return Me.txtNIT.Text
        End Get
    End Property

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
End Class
