Imports SGAFP.BL
Imports SGAFP.EL


Partial Class controles_ucVistaDetalleCONTRATO_COMPRA
    Inherits ucBase

#Region "Propiedades"

    Private Property esNuevo As Boolean
        Get
            If Me.ViewState("esNuevo") IsNot Nothing Then
                Return CBool(Me.ViewState("esNuevo"))
            Else
                Return False
            End If
        End Get
        Set(value As Boolean)
            Me.ViewState("esNuevo") = value
        End Set
    End Property
    Public Property ID_CONTRATO_COMPRA() As Decimal
        Get
            If Me.ViewState("ID_CONTRATO_COMPRA") IsNot Nothing Then
                Return CInt(Me.ViewState("ID_CONTRATO_COMPRA"))
            Else
                Return -1
            End If
        End Get
        Set(ByVal Value As Decimal)
            Me.ViewState("ID_CONTRATO_COMPRA") = Value
            Me.lblREFERENCIA.Text = Guid.NewGuid.ToString
            If Value > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Property LISTA_CONTRATO_COMPRA_PENALIZACION As ListaCONTRATO_COMPRA_PENALIZACION
        Set(value As ListaCONTRATO_COMPRA_PENALIZACION)
            Session(Me.lblREFERENCIA.Text) = value
        End Set
        Get
            If Session(Me.lblREFERENCIA.Text) IsNot Nothing Then Return TryCast(Session(Me.lblREFERENCIA.Text), ListaCONTRATO_COMPRA_PENALIZACION) Else Return New ListaCONTRATO_COMPRA_PENALIZACION
        End Get
    End Property

    Private _Enabled As Boolean = True
    Private _sError As String
    Private _nuevo As Boolean = False
    Private mComponente As New cCONTRATO_COMPRA
    Private mEntidad As CONTRATO_COMPRA
    Public Event ErrorEvent(ByVal errorMessage As String)

    Public ReadOnly Property sError() As String
        Get
            Return _sError
        End Get
    End Property

    Public Property Enabled() As Boolean
        Get
            Return Me._Enabled
        End Get
        Set(ByVal Value As Boolean)
            Me._Enabled = Value
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property
#End Region

    Public Sub LimpiarSesion()
        If lblREFERENCIA.Text <> "" Then
            If Session(lblREFERENCIA.Text) IsNot Nothing Then
                Session.Remove(lblREFERENCIA.Text)
            End If
        End If
    End Sub

    Public Sub CargarDetallePenalizaciones()
        If Me.lblREFERENCIA.Text <> "" Then
            Me.ucListaCONTRATO_COMPRA_PENALIZACION1.CargarDatosCache(Me.lblREFERENCIA.Text)
        End If
    End Sub

    Private Sub CargarDatos()
        Dim sError As New String("")
        Dim listaPenalizaciones As ListaCONTRATO_COMPRA_PENALIZACION

        Me.esNuevo = False
        mEntidad = New CONTRATO_COMPRA
        mEntidad = mComponente.ObtenerCONTRATO_COMPRA(ID_CONTRATO_COMPRA)
        If mEntidad Is Nothing Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtID_CONTRATO_COMPRA.Text = mEntidad.ID_CONTRATO_COMPRA.ToString()
        Me.txtNO_CONTRATO_COMPRA.Text = mEntidad.NO_CONTRATO_COMPRA
        Me.dteFECHA_INGRESO.Date = mEntidad.FECHA_INGRESO
        Me.cbxUNIDAD_ORGANIZATIVA.Value = Convert.ToInt32(mEntidad.ID_UNIDAD_ORGANIZATIVA)
        Me.dteFECHA_INI_EJEC.Date = mEntidad.FECHA_INI_EJEC
        Me.dteFECHA_FIN_EJEC.Date = mEntidad.FECHA_FIN_EJEC
        Me.spePORC_ASISTENCIA_MIN.Value = mEntidad.PORC_ASISTENCIA_MIN
        Me.lstPAGO_POR_PARTICIPACION.SelectedIndex = mEntidad.PAGO_POR_PARTICIPACION
        If mEntidad.PAGO_POR_PARTICIPACION = CompraBasePago.PagoBaseDefinida Then
            Me.speBASE_PARTI.Value = mEntidad.BASE_PARTI
        Else
            Me.speBASE_PARTI.Value = Nothing
        End If
        listaPenalizaciones = (New cCONTRATO_COMPRA_PENALIZACION).ObtenerListaPorCONTRATO_COMPRA(mEntidad.ID_CONTRATO_COMPRA)
        If listaPenalizaciones IsNot Nothing AndAlso listaPenalizaciones.Count > 0 Then
            For i As Integer = 0 To listaPenalizaciones.Count - 1
                listaPenalizaciones(i).REFERENCIA = Me.lblREFERENCIA.Text
            Next
            Me.LISTA_CONTRATO_COMPRA_PENALIZACION = listaPenalizaciones
        Else
            Me.LISTA_CONTRATO_COMPRA_PENALIZACION = New ListaCONTRATO_COMPRA_PENALIZACION
        End If
        Me.CargarDetallePenalizaciones()
    End Sub

    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.txtID_CONTRATO_COMPRA.ClientEnabled = False
        Me.txtNO_CONTRATO_COMPRA.ClientEnabled = edicion
        Me.cbxUNIDAD_ORGANIZATIVA.ClientEnabled = edicion
        Me.dteFECHA_INGRESO.ClientEnabled = edicion
        Me.dteFECHA_INI_EJEC.ClientEnabled = edicion
        Me.dteFECHA_FIN_EJEC.ClientEnabled = edicion
        Me.spePORC_ASISTENCIA_MIN.ClientEnabled = edicion
        Me.lstPAGO_POR_PARTICIPACION.ClientEnabled = edicion
        If Me.lstPAGO_POR_PARTICIPACION.SelectedIndex = CompraBasePago.PagoBaseDefinida Then
            Me.speBASE_PARTI.ClientEnabled = edicion
        Else
            Me.speBASE_PARTI.ClientEnabled = False
        End If
        Me.btnCargarPlantilla.ClientEnabled = edicion
        Me.btnAgregar.ClientEnabled = edicion
        Me.btnBorrarRangos.ClientEnabled = edicion
    End Sub

    Private Sub Nuevo()
        Me.esNuevo = True
        Me.txtID_CONTRATO_COMPRA.Text = ""
        Me.txtNO_CONTRATO_COMPRA.Text = ""
        Me.cbxUNIDAD_ORGANIZATIVA.Value = Nothing
        Me.dteFECHA_INGRESO.Value = Nothing
        Me.dteFECHA_INI_EJEC.Value = Nothing
        Me.dteFECHA_FIN_EJEC.Value = Nothing
        Me.spePORC_ASISTENCIA_MIN.Text = ""
        Me.lstPAGO_POR_PARTICIPACION.SelectedIndex = -1
        Me.speBASE_PARTI.Value = Nothing
        Me.LISTA_CONTRATO_COMPRA_PENALIZACION = New ListaCONTRATO_COMPRA_PENALIZACION
        Me.CargarDetallePenalizaciones()
    End Sub

    Protected Sub btnBorrarRangos_Click(sender As Object, e As EventArgs) Handles btnBorrarRangos.Click
        Me.LISTA_CONTRATO_COMPRA_PENALIZACION = New ListaCONTRATO_COMPRA_PENALIZACION
        Me.CargarDetallePenalizaciones()
    End Sub

    Public Function Actualizar() As String
        Dim sError As New StringBuilder
        Dim bContratoCompra As New cCONTRATO_COMPRA
        Dim bContratoCompraPena As New cCONTRATO_COMPRA_PENALIZACION
        Dim listaPena As ListaCONTRATO_COMPRA_PENALIZACION
        Dim idContratoCompra As Integer = 0
        Dim lista As listaCONTRATO_COMPRA

        listaPena = Me.LISTA_CONTRATO_COMPRA_PENALIZACION
        If Not Me.esNuevo Then
            mEntidad = bContratoCompra.ObtenerCONTRATO_COMPRA(ID_CONTRATO_COMPRA)
            mEntidad.USUARIO_ACT = Me.ObtenerUsuario
            mEntidad.FECHA_ACT = Now
            idContratoCompra = ID_CONTRATO_COMPRA
        Else
            mEntidad = New CONTRATO_COMPRA
            mEntidad.ID_CONTRATO_COMPRA = 0
            mEntidad.USUARIO_CREA = Me.ObtenerUsuario
            mEntidad.FECHA_CREA = Now
            mEntidad.USUARIO_ACT = Me.ObtenerUsuario
            mEntidad.FECHA_ACT = Now
        End If

        If Me.txtNO_CONTRATO_COMPRA.Text.Trim = "" Then
            sError.AppendLine("* Ingrese el No. de oferta de compra")
        End If
        If Me.cbxUNIDAD_ORGANIZATIVA.Value Is Nothing Then
            sError.AppendLine("* Seleccione la unidad organizativa que administra la oferta")
        End If
        If Me.dteFECHA_INGRESO.Value = #12:00:00 AM# Then
            sError.AppendLine("* Digite la fecha de ingreso la oferta")
        End If
        If Me.dteFECHA_INI_EJEC.Value = #12:00:00 AM# Then
            sError.AppendLine("* Ingrese la fecha de inicio de ejecución de la oferta")
        End If
        If Me.dteFECHA_FIN_EJEC.Value = #12:00:00 AM# Then
            sError.AppendLine("* Ingrese la fecha de finalización de ejecución de la oferta")
        End If
        If Me.spePORC_ASISTENCIA_MIN.Value Is Nothing OrElse Not IsNumeric(Me.spePORC_ASISTENCIA_MIN.Text) Then
            sError.AppendLine("* Ingrese el porcentaje mínimo de asistencia")
        End If
        If Me.lstPAGO_POR_PARTICIPACION.SelectedIndex = -1 Then
            sError.AppendLine("* Seleccione una base para pago")
        End If
        If Me.lstPAGO_POR_PARTICIPACION.SelectedIndex = 1 AndAlso (Me.speBASE_PARTI.Text.Trim = "" OrElse Not IsNumeric(Me.speBASE_PARTI.Text.Trim)) Then
            sError.AppendLine("* Ingrese la cantidad base de participantes para pago")
        End If
        If Me.dteFECHA_INI_EJEC.Date > Me.dteFECHA_INI_EJEC.Value Then
            sError.AppendLine("* La fecha inicial no puede ser mayor que la fecha final de ejecucion")
        End If
        If listaPena Is Nothing OrElse listaPena.Count = 0 Then
            sError.AppendLine("* Ingrese el detalle de las penalizaciones que aplican a la ejecucion de la oferta")
        End If
        lista = mComponente.ObtenerListaPorNO_CONTRATO_COMPRA(Me.txtNO_CONTRATO_COMPRA.Text.Trim)
        If lista IsNot Nothing AndAlso lista.Count > 0 Then
            If Me.esNuevo OrElse (mEntidad.ID_CONTRATO_COMPRA <> lista(0).ID_CONTRATO_COMPRA) Then
                sError.AppendLine("* Ya existe una oferta de compra No. " + Me.txtNO_CONTRATO_COMPRA.Text.Trim + " registrada en el sistema")
                Return -1
            End If
        End If
        If sError.ToString <> "" Then
            Return sError.ToString
        End If

        mEntidad.NO_CONTRATO_COMPRA = Me.txtNO_CONTRATO_COMPRA.Text.Trim
        mEntidad.ID_UNIDAD_ORGANIZATIVA = Convert.ToDecimal(Me.cbxUNIDAD_ORGANIZATIVA.Value)
        mEntidad.FECHA_INGRESO = Me.dteFECHA_INGRESO.Date
        mEntidad.FECHA_INI_EJEC = Me.dteFECHA_INI_EJEC.Date
        mEntidad.FECHA_FIN_EJEC = Me.dteFECHA_FIN_EJEC.Date
        mEntidad.PORC_ASISTENCIA_MIN = Convert.ToDecimal(Me.spePORC_ASISTENCIA_MIN.Value)
        mEntidad.PAGO_POR_PARTICIPACION = lstPAGO_POR_PARTICIPACION.SelectedIndex
        If lstPAGO_POR_PARTICIPACION.SelectedIndex = 1 Then
            mEntidad.BASE_PARTI = Convert.ToDecimal(Me.speBASE_PARTI.Value)
        Else
            mEntidad.BASE_PARTI = -1
        End If

        'Guardar datos de la oferta
        If mComponente.ActualizarCONTRATO_COMPRA(mEntidad, TipoConcurrencia.Pesimistica) <> 1 Then
            Return "Fallo al guardar Oferta de Compra: " + mComponente.sError
        End If

        'Asignar ID_CONTRATO_COMPRA si es nuevo
        If esNuevo Then idContratoCompra = mEntidad.ID_CONTRATO_COMPRA

        'Guardar datos de las penalizaciones
        bContratoCompraPena.EliminarlistaCONTRATO_COMPRA_PENALIZACION(Me.ID_CONTRATO_COMPRA)
        If listaPena IsNot Nothing AndAlso listaPena.Count > 0 Then
            For i As Integer = 0 To listaPena.Count - 1
                Dim lEntidadPena As New CONTRATO_COMPRA_PENALIZACION
                lEntidadPena.ID_CONTRA_PENA = 0
                lEntidadPena.ID_CONTRATO_COMPRA = idContratoCompra
                lEntidadPena.ID_TIPO_PENA = listaPena(i).ID_TIPO_PENA
                lEntidadPena.RANGO_INI = listaPena(i).RANGO_INI
                lEntidadPena.RANGO_FIN = listaPena(i).RANGO_FIN
                lEntidadPena.PORC_PENA = listaPena(i).PORC_PENA
                lEntidadPena.USUARIO_CREA = Me.ObtenerUsuario
                lEntidadPena.FECHA_CREA = Now
                lEntidadPena.USUARIO_ACT = Me.ObtenerUsuario
                lEntidadPena.FECHA_ACT = Now

                bContratoCompraPena.ActualizarCONTRATO_COMPRA_PENALIZACION(lEntidadPena, TipoConcurrencia.Pesimistica)
            Next
        End If
        Me.esNuevo = False
        Return ""
    End Function

    Protected Sub lstPAGO_POR_PARTICIPACION_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstPAGO_POR_PARTICIPACION.SelectedIndexChanged
        If Me.lstPAGO_POR_PARTICIPACION.SelectedIndex = CompraBasePago.PagoBaseDefinida Then
            Me.speBASE_PARTI.ClientEnabled = True
        Else
            Me.speBASE_PARTI.ClientEnabled = False
            Me.speBASE_PARTI.Value = Nothing
        End If
    End Sub

    Protected Sub btnCargarPlantilla_Click(sender As Object, e As EventArgs) Handles btnCargarPlantilla.Click
        Dim listaPlantilla As listaRANGO_PORC_PENA = (New cRANGO_PORC_PENA).ObtenerListaPorPROGRAMA_FORMACION(ProgramasFormacion.HABIL_TECNICO_PERMANENTE)
        Dim listaContratoPena As New ListaCONTRATO_COMPRA_PENALIZACION
        Dim lEntidad As CONTRATO_COMPRA_PENALIZACION

        Me.LISTA_CONTRATO_COMPRA_PENALIZACION = New ListaCONTRATO_COMPRA_PENALIZACION
        If listaPlantilla IsNot Nothing AndAlso listaPlantilla.Count > 0 Then
            For i = 0 To listaPlantilla.Count - 1
                lEntidad = New CONTRATO_COMPRA_PENALIZACION
                lEntidad.ID_CONTRA_PENA = ObtenerIdPena(listaContratoPena)
                lEntidad.ID_TIPO_PENA = listaPlantilla(i).ID_TIPO_PENA
                lEntidad.RANGO_INI = listaPlantilla(i).RANGO_INI
                lEntidad.RANGO_FIN = listaPlantilla(i).RANGO_FIN
                lEntidad.PORC_PENA = listaPlantilla(i).PORC_PENA
                lEntidad.REFERENCIA = Me.lblREFERENCIA.Text
                listaContratoPena.Add(lEntidad)
            Next
        End If

        Me.LISTA_CONTRATO_COMPRA_PENALIZACION = listaContratoPena
        Me.CargarDetallePenalizaciones()
    End Sub

    Private Function ObtenerIdPena(ByVal lista As ListaCONTRATO_COMPRA_PENALIZACION) As Int32
        Dim Id As Int32 = 0
        For i As Integer = 0 To lista.Count - 1
            If lista(i).ID_CONTRA_PENA > Id Then
                Id = lista(i).ID_CONTRA_PENA
            End If
        Next
        Return (Id + 1)
    End Function

    Protected Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Me.lblMensajeError.Text = ""
        Me.cbxTIPO_PENALIZA.Value = Nothing
        Me.speRANGO_INICIAL.Value = Nothing
        Me.speRANGO_FINAL.Value = Nothing
        Me.spePORCENTAJE_PENALIZACION.Value = Nothing
        Me.popAgregarPenalizacion.ShowOnPageLoad = True
        Me.cbxTIPO_PENALIZA.Focus()
    End Sub

    Protected Sub btnAceptarPopup_Click(sender As Object, e As EventArgs) Handles btnAceptarPopup.Click
        Dim lista As ListaCONTRATO_COMPRA_PENALIZACION
        Dim lItem As New CONTRATO_COMPRA_PENALIZACION

        'Validar formulario popup
        If Me.cbxTIPO_PENALIZA.Value Is Nothing Then
            Me.lblMensajeError.Text = "* Seleccione la penalización automática"
            Return
        End If
        If Me.speRANGO_INICIAL.Text = "" Then
            Me.lblMensajeError.Text = "* Ingrese el rango inicial en días"
            Return
        End If
        If Me.speRANGO_FINAL.Text = "" Then
            Me.lblMensajeError.Text = "* Ingrese el rango final en días"
            Return
        End If
        If Me.speRANGO_INICIAL.Value >= Me.speRANGO_FINAL.Value Then
            Me.lblMensajeError.Text = "* Rango inicial en días no puede ser mayor o igual que rango final"
            Return
        End If
        If Me.spePORCENTAJE_PENALIZACION.Text = "" Then
            Me.lblMensajeError.Text = "* Ingrese el porcentaje de penalización"
            Return
        End If

        lista = Me.LISTA_CONTRATO_COMPRA_PENALIZACION
        If lista Is Nothing Then lista = New ListaCONTRATO_COMPRA_PENALIZACION
        lItem.ID_CONTRA_PENA = Me.ObtenerIdPena(lista)
        lItem.ID_TIPO_PENA = Convert.ToDecimal(Me.cbxTIPO_PENALIZA.Value)
        lItem.RANGO_INI = Convert.ToDecimal(Me.speRANGO_INICIAL.Value)
        lItem.RANGO_FIN = Convert.ToDecimal(Me.speRANGO_FINAL.Value)
        lItem.PORC_PENA = Convert.ToDecimal(Me.spePORCENTAJE_PENALIZACION.Value)
        lItem.REFERENCIA = Me.lblREFERENCIA.Text
        lista.Add(lItem)

        Me.LISTA_CONTRATO_COMPRA_PENALIZACION = lista
        Me.CargarDetallePenalizaciones()
        Me.popAgregarPenalizacion.ShowOnPageLoad = False
    End Sub

   
End Class
