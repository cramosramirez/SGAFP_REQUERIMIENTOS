Public Class xrSubReporteCursosRecibidosSolic
    Inherits DevExpress.XtraReports.UI.XtraReport

    Private _ID_SOLICITUD As Decimal

    Private Sub SetearDatos(ByVal ID_SOLICITUD As Decimal)
        _ID_SOLICITUD = ID_SOLICITUD
    End Sub

    Public ReadOnly Property IdSolicitud() As Decimal
        Get
            Return _ID_SOLICITUD
        End Get
    End Property


    Public Sub CargarCursosRecibidosPorSolicitud(ByVal ID_SOLICITUD As Decimal)
        SetearDatos(ID_SOLICITUD)
        Me.DS_DL1.Clear()
        Me.CursosRecibidosTableAdapter1.FillBy(Me.DS_DL1.CursosRecibidos, ID_SOLICITUD)
        Me.DataMember = "CursosRecibidos"
        Me.DataSource = DS_DL1.CursosRecibidos
    End Sub
End Class