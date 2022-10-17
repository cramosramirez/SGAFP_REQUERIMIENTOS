Public Class xrInformesRecibidosCA

    Public Sub CargarPorFechaDevolucion(ByVal FECHA_INI As Date, ByVal FECHA_FIN As Date)
        Me.DS_DL1.Clear()
        Me.InformesRecibidosCentroAtencionTableAdapter1.FillPorFechaDevolucion(DS_DL1.InformesRecibidosCentroAtencion, FECHA_INI, FECHA_FIN)
    End Sub

    Public Sub CargarPorFechaRecepcion(ByVal FECHA_INI As Date, ByVal FECHA_FIN As Date)
        Me.DS_DL1.Clear()
        Me.InformesRecibidosCentroAtencionTableAdapter1.FillPorFechaRecepcion(DS_DL1.InformesRecibidosCentroAtencion, FECHA_INI, FECHA_FIN)
    End Sub

    Public Sub CargarPorFechaRevision(ByVal FECHA_INI As Date, ByVal FECHA_FIN As Date)
        Me.DS_DL1.Clear()
        Me.InformesRecibidosCentroAtencionTableAdapter1.FillPorFechaRevision(DS_DL1.InformesRecibidosCentroAtencion, FECHA_INI, FECHA_FIN)
    End Sub

    Public Sub CargarPorFechaObservadoOrden(ByVal FECHA_INI As Date, ByVal FECHA_FIN As Date)
        Me.DS_DL1.Clear()
        Me.InformesRecibidosCentroAtencionTableAdapter1.FillPorFechaObservado(DS_DL1.InformesRecibidosCentroAtencion, FECHA_INI, FECHA_FIN)
    End Sub

    Public Sub CargarPorFechaObservadoFactura(ByVal FECHA_INI As Date, ByVal FECHA_FIN As Date)
        Me.DS_DL1.Clear()
        Me.InformesRecibidosCentroAtencionTableAdapter1.FillFechaFacturaObservada(DS_DL1.InformesRecibidosCentroAtencion, FECHA_INI, FECHA_FIN)
    End Sub

    Public Sub CargarPorTramiteDePago(ByVal FECHA_INI As Date, ByVal FECHA_FIN As Date)
        Me.DS_DL1.Clear()
        Me.InformesRecibidosCentroAtencionTableAdapter1.FillPorFechaFacturaRecibida(DS_DL1.InformesRecibidosCentroAtencion, FECHA_INI, FECHA_FIN)
    End Sub

    Public Sub CargarPorInformesNoValidados(ByVal FECHA_INI As Date, ByVal FECHA_FIN As Date)
        Me.DS_DL1.Clear()
        Me.InformesRecibidosCentroAtencionTableAdapter1.FillinformesAtrasados(DS_DL1.InformesRecibidosCentroAtencion, FECHA_INI, FECHA_FIN)
    End Sub
End Class