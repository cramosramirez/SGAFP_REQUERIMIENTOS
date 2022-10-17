Imports SGAFP.BL
Imports SGAFP.EL


Partial Class controles_ucVistaDetalleASISTENCIA_PAGO
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
    Public Property ID_ASISTE_PAGO() As Decimal
        Get
            If Me.ViewState("ID_ASISTE_PAGO") IsNot Nothing Then
                Return CInt(Me.ViewState("ID_ASISTE_PAGO"))
            Else
                Return -1
            End If
        End Get
        Set(ByVal Value As Decimal)
            Me.ViewState("ID_ASISTE_PAGO") = Value
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

    Public Property LISTA_ASISTENCIA_PAGO_DET As listaASISTENCIA_PAGO_DET
        Set(value As listaASISTENCIA_PAGO_DET)
            Session(Me.lblREFERENCIA.Text) = value
        End Set
        Get
            If Session(Me.lblREFERENCIA.Text) IsNot Nothing Then Return TryCast(Session(Me.lblREFERENCIA.Text), listaASISTENCIA_PAGO_DET) Else Return New listaASISTENCIA_PAGO_DET
        End Get
    End Property

    Private _Enabled As Boolean = True
    Private _sError As String
    Private _nuevo As Boolean = False
    Private mComponente As New cASISTENCIA_PAGO
    Private mEntidad As ASISTENCIA_PAGO
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

    Public Sub CargarDetalleAsistenciaPago()
        If Me.lblREFERENCIA.Text <> "" Then
            Me.ucListaASISTENCIA_PAGO_DET1.CargarDatosCache(Me.lblREFERENCIA.Text)
        End If
    End Sub

    Private Sub CargarDatos()
        Dim sError As New String("")
        Dim listaAsistePagoDet As listaASISTENCIA_PAGO_DET

        Me.esNuevo = False
        mEntidad = New ASISTENCIA_PAGO
        mEntidad = mComponente.ObtenerASISTENCIA_PAGO(ID_ASISTE_PAGO)
        If mEntidad Is Nothing Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtID_ASISTE_PAGO.Text = mEntidad.ID_ASISTE_PAGO.ToString()
        Me.txtDESCRIPCION.Text = mEntidad.DESCRIPCION
        Me.cbxEJERCICIO.Value = mEntidad.ID_EJERCICIO
        
        listaAsistePagoDet = (New cASISTENCIA_PAGO_DET).ObtenerListaPorASISTENCIA_PAGO(mEntidad.ID_ASISTE_PAGO)
        If listaAsistePagoDet IsNot Nothing AndAlso listaAsistePagoDet.Count > 0 Then
            For i As Integer = 0 To listaAsistePagoDet.Count - 1
                listaAsistePagoDet(i).REFERENCIA = Me.lblREFERENCIA.Text
            Next
            Me.LISTA_ASISTENCIA_PAGO_DET = listaAsistePagoDet
        Else
            Me.LISTA_ASISTENCIA_PAGO_DET = New listaASISTENCIA_PAGO_DET
        End If
        Me.CargarDetalleAsistenciaPago()
    End Sub

    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.txtID_ASISTE_PAGO.ClientEnabled = False
        Me.txtDESCRIPCION.ClientEnabled = edicion
        Me.cbxEJERCICIO.ClientEnabled = edicion
        Me.btnAgregar.ClientEnabled = edicion
        Me.btnBorrarRangos.ClientEnabled = edicion
    End Sub

    Private Sub Nuevo()
        Me.esNuevo = True
        Me.txtID_ASISTE_PAGO.Text = ""
        Me.txtDESCRIPCION.Text = ""
        Me.cbxEJERCICIO.Value = Nothing
        Me.LISTA_ASISTENCIA_PAGO_DET = New listaASISTENCIA_PAGO_DET
        Me.CargarDetalleAsistenciaPago()
    End Sub

    Protected Sub btnBorrarRangos_Click(sender As Object, e As EventArgs) Handles btnBorrarRangos.Click
        Me.LISTA_ASISTENCIA_PAGO_DET = New listaASISTENCIA_PAGO_DET
        Me.CargarDetalleAsistenciaPago()
    End Sub

    Public Function Actualizar() As String
        Dim sError As New StringBuilder
        Dim bAsistenciaPago As New cASISTENCIA_PAGO
        Dim bAsistenciaPagoDet As New cASISTENCIA_PAGO_DET
        Dim listaPagoDet As listaASISTENCIA_PAGO_DET
        Dim idAsistePago As Integer = 0

        listaPagoDet = Me.LISTA_ASISTENCIA_PAGO_DET
        If Not Me.esNuevo Then
            mEntidad = bAsistenciaPago.ObtenerASISTENCIA_PAGO(ID_ASISTE_PAGO)
            mEntidad.USUARIO_ACT = Me.ObtenerUsuario
            mEntidad.FECHA_ACT = Now
            idAsistePago = ID_ASISTE_PAGO
        Else
            mEntidad = New ASISTENCIA_PAGO
            mEntidad.ID_ASISTE_PAGO = 0
            mEntidad.USUARIO_CREA = Me.ObtenerUsuario
            mEntidad.FECHA_CREA = Now
            mEntidad.USUARIO_ACT = Me.ObtenerUsuario
            mEntidad.FECHA_ACT = Now
        End If

        If Me.txtDESCRIPCION.Text.Trim = "" Then
            sError.AppendLine("* Ingrese la descripcion para el pago por asistencia")
        End If
        If Me.cbxEJERCICIO.Value Is Nothing Then
            sError.AppendLine("* Seleccione el ejercicio")
        End If
        If listaPagoDet Is Nothing OrElse listaPagoDet.Count = 0 Then
            sError.AppendLine("* Ingrese el detalle de los pagos por porcentaje de asistencia")
        End If
        If sError.ToString <> "" Then
            Return sError.ToString
        End If

        mEntidad.DESCRIPCION = Me.txtDESCRIPCION.Text.Trim.ToUpper
        mEntidad.ID_EJERCICIO = Convert.ToDecimal(Me.cbxEJERCICIO.Value)

        'Guardar datos de la oferta
        If mComponente.ActualizarASISTENCIA_PAGO(mEntidad, TipoConcurrencia.Pesimistica) <> 1 Then
            Return "Fallo al guardar el pago por asistencia: " + mComponente.sError
        End If

        'Asignar ID_CONTRATO_COMPRA si es nuevo
        If esNuevo Then idAsistePago = mEntidad.ID_ASISTE_PAGO

        'Guardar datos de las penalizaciones
        bAsistenciaPagoDet.EliminarlistaASISTENCIA_PAGO_DET(Me.ID_ASISTE_PAGO)
        If listaPagoDet IsNot Nothing AndAlso listaPagoDet.Count > 0 Then
            For i As Integer = 0 To listaPagoDet.Count - 1
                Dim lEntidadPagoDet As New ASISTENCIA_PAGO_DET
                lEntidadPagoDet.ID_ASISTE_PAGO_DET = 0
                lEntidadPagoDet.ID_ASISTE_PAGO = idAsistePago
                lEntidadPagoDet.ID_MODALIDAD_FORMACION = listaPagoDet(i).ID_MODALIDAD_FORMACION
                lEntidadPagoDet.PORC_ASISTE_INI = listaPagoDet(i).PORC_ASISTE_INI
                lEntidadPagoDet.PORC_ASISTE_FIN = listaPagoDet(i).PORC_ASISTE_FIN
                lEntidadPagoDet.PORC_PAGO_COSTO_PARTI = listaPagoDet(i).PORC_PAGO_COSTO_PARTI
                lEntidadPagoDet.USUARIO_CREA = Me.ObtenerUsuario
                lEntidadPagoDet.FECHA_CREA = Now
                lEntidadPagoDet.USUARIO_ACT = Me.ObtenerUsuario
                lEntidadPagoDet.FECHA_ACT = Now

                bAsistenciaPagoDet.ActualizarASISTENCIA_PAGO_DET(lEntidadPagoDet, TipoConcurrencia.Pesimistica)
            Next
        End If
        Me.esNuevo = False
        Return ""
    End Function

    Private Function ObtenerIdAsistePago(ByVal lista As listaASISTENCIA_PAGO_DET) As Int32
        Dim Id As Int32 = 0
        For i As Integer = 0 To lista.Count - 1
            If lista(i).ID_ASISTE_PAGO_DET > Id Then
                Id = lista(i).ID_ASISTE_PAGO_DET
            End If
        Next
        Return (Id + 1)
    End Function

    Protected Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Me.lblMensajeError.Text = ""
        Me.cbxMODALIDAD_FORMACION.Value = Nothing
        Me.spePORC_ASISTE_INI.Value = Nothing
        Me.spePORC_ASISTE_FIN.Value = Nothing
        Me.spePORC_PAGO_COSTO_PARTI.Value = Nothing
        Me.popAgregarAsistenciaPago.ShowOnPageLoad = True
        Me.cbxMODALIDAD_FORMACION.Focus()
    End Sub

    Protected Sub btnAceptarPopup_Click(sender As Object, e As EventArgs) Handles btnAceptarPopup.Click
        Dim lista As listaASISTENCIA_PAGO_DET
        Dim lItem As New ASISTENCIA_PAGO_DET

        'Validar formulario popup
        If Me.cbxMODALIDAD_FORMACION.Value Is Nothing Then
            Me.lblMensajeError.Text = "* Seleccione la modalidad de formación"
            Return
        End If
        If Me.spePORC_ASISTE_INI.Text = "" Then
            Me.lblMensajeError.Text = "* Ingrese el porcentaje de asistencia inicial"
            Return
        End If
        If Me.spePORC_ASISTE_FIN.Text = "" Then
            Me.lblMensajeError.Text = "* Ingrese el porcentaje de asistencia final"
            Return
        End If
        If Me.spePORC_ASISTE_INI.Value >= Me.spePORC_ASISTE_FIN.Value Then
            Me.lblMensajeError.Text = "* Porcentaje inicial de asistencia no puede ser mayor o igual que porcentaje final"
            Return
        End If
        If Me.spePORC_PAGO_COSTO_PARTI.Text = "" Then
            Me.lblMensajeError.Text = "* Ingrese el porcentaje de pago"
            Return
        End If

        lista = Me.LISTA_ASISTENCIA_PAGO_DET
        If lista Is Nothing Then lista = New listaASISTENCIA_PAGO_DET
        lItem.ID_ASISTE_PAGO_DET = Me.ObtenerIdAsistePago(lista)
        lItem.ID_MODALIDAD_FORMACION = Convert.ToDecimal(Me.cbxMODALIDAD_FORMACION.Value)
        lItem.PORC_ASISTE_INI = Convert.ToDecimal(Me.spePORC_ASISTE_INI.Value)
        lItem.PORC_ASISTE_FIN = Convert.ToDecimal(Me.spePORC_ASISTE_FIN.Value)
        lItem.PORC_PAGO_COSTO_PARTI = Convert.ToDecimal(Me.spePORC_PAGO_COSTO_PARTI.Value)
        lItem.REFERENCIA = Me.lblREFERENCIA.Text
        lista.Add(lItem)

        Me.LISTA_ASISTENCIA_PAGO_DET = lista
        Me.CargarDetalleAsistenciaPago()
        Me.popAgregarAsistenciaPago.ShowOnPageLoad = False
    End Sub

   
End Class
