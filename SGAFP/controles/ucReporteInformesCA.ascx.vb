
Partial Class controles_ucReporteInformesCA
    Inherits ucBase

    Public Property ESTADO_INFORME As Int32
        Get
            If cbxESTADO_INFORME.Value Is Nothing Then
                Return -1
            Else
                Return CInt(cbxESTADO_INFORME.Value)
            End If
        End Get
        Set(value As Int32)
            cbxESTADO_INFORME.Value = value
        End Set
    End Property

    Public Property FECHA_INI As Date
        Get
            If dteFECHA_INI.Value Is Nothing Then
                Return Nothing
            Else
                Return dteFECHA_INI.Date
            End If
        End Get
        Set(value As Date)
            dteFECHA_INI.Value = value
        End Set
    End Property

    Public Property FECHA_FIN As Date
        Get
            If dteFECHA_FIN.Value Is Nothing Then
                Return Nothing
            Else
                Return dteFECHA_FIN.Date
            End If
        End Get
        Set(value As Date)
            dteFECHA_FIN.Value = value
        End Set
    End Property

    Private Sub Inicializar()
        Me.ucBarraNavegacion1.PermitirNavegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.PermitirGuardar = False
        Me.ucBarraNavegacion1.CrearOpcion("Buscar", "Buscar", False, "~\imagenes\buscar.gif", "", "")
        Me.ucBarraNavegacion1.CargarOpciones()
    End Sub

    Protected Sub controles_ucReporteInformesCA_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Inicializar()
        End If
        CargarReporte()
    End Sub

    Protected Sub ucBarraNavegacion1_OpcionSeleccionada(CommandName As String) Handles ucBarraNavegacion1.OpcionSeleccionada
        If CommandName = "Buscar" Then
            CargarReporte()
        End If
    End Sub

    Public Sub CargarReporte()
        If ESTADO_INFORME = -1 Then
            'Me.AsignarMensaje("Seleccione el tipo de estado", False, True)
            Return
        End If
        If FECHA_INI = Nothing OrElse FECHA_FIN = Nothing Then
            ' Me.AsignarMensaje("Ingrese el periodo del reporte", False, True)
            Return
        End If

        Dim reporte As New xrInformesRecibidosCA
        Select Case Me.ESTADO_INFORME
            Case 1
                reporte.CargarPorFechaRecepcion(FECHA_INI, FECHA_FIN)
            Case 2
                reporte.CargarPorFechaRevision(FECHA_INI, FECHA_FIN)
            Case 3
                reporte.CargarPorFechaDevolucion(FECHA_INI, FECHA_FIN)
            Case 4
                reporte.CargarPorFechaObservadoOrden(FECHA_INI, FECHA_FIN)
            Case 5
                reporte.CargarPorFechaObservadoFactura(FECHA_INI, FECHA_FIN)
            Case 6
                reporte.CargarPorTramiteDePago(FECHA_INI, FECHA_FIN)
            Case 7
                reporte.CargarPorInformesNoValidados(FECHA_INI, FECHA_FIN)
        End Select

        reporte.ResumeLayout()
        Me.ucReporte1.CargarDatos(reporte)
    End Sub
End Class
