Imports SGAFP.EL
Imports System.Web.Security.Membership
Imports SQLMembershipProvider.BL

Public Class ucListaCONTRATO_BOLPROS

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.ListaBindingNavigator.BindingSource = Me.ListaCONTRATO_BOLPROSBindingSource
    End Sub

    Private _mComponente As cCONTRATO_BOLPROS
    Public ReadOnly Property mComponente() As cCONTRATO_BOLPROS
        Get
            If _mComponente Is Nothing Then
                _mComponente = New cCONTRATO_BOLPROS
            End If
            Return _mComponente
        End Get
    End Property
   
    Private _mListaCONTRATO_BOLPROS As New listaCONTRATO_BOLPROS
    Public Event CambioRegistro()
    Public Event Seleccionado(ByVal ID_CONTRATO As Decimal) 

    #Region "Propiedades"

    Private _EsConsulta As Boolean = False
    <DefaultValue(False)> _
    Public Property EsConsulta() As Boolean
        Get
            Return Me._EsConsulta
        End Get
        Set(ByVal value As Boolean)
            Me._EsConsulta = value
            Me.VerToolBar = Not value
        End Set
    End Property

    Private _VerID_CONTRATO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerID_CONTRATO() As Boolean
        Get
            Return Me._VerID_CONTRATO
        End Get
        Set(ByVal value As Boolean)
            Me._VerID_CONTRATO = value
            Me.colID_CONTRATO.Visible = value
        End Set
    End Property

    Private _VerID_PROVEEDOR_AF As Boolean = True
    <DefaultValue(True)> _
    Public Property VerID_PROVEEDOR_AF() As Boolean
        Get
            Return Me._VerID_PROVEEDOR_AF
        End Get
        Set(ByVal value As Boolean)
            Me._VerID_PROVEEDOR_AF = value
            Me.colID_PROVEEDOR_AF.Visible = value
        End Set
    End Property

    Private _VerID_PROGRAMA_FORMACION As Boolean = True
    <DefaultValue(True)> _
    Public Property VerID_PROGRAMA_FORMACION() As Boolean
        Get
            Return Me._VerID_PROGRAMA_FORMACION
        End Get
        Set(ByVal value As Boolean)
            Me._VerID_PROGRAMA_FORMACION = value
            Me.colID_PROGRAMA_FORMACION.Visible = value
        End Set
    End Property

    Private _VerID_FUENTE As Boolean = True
    <DefaultValue(True)> _
    Public Property VerID_FUENTE() As Boolean
        Get
            Return Me._VerID_FUENTE
        End Get
        Set(ByVal value As Boolean)
            Me._VerID_FUENTE = value
            Me.colID_FUENTE.Visible = value
        End Set
    End Property

    'Private _VerNO_CONVOCATORIA As Boolean = True
    '<DefaultValue(True)> _
    'Public Property VerNO_CONVOCATORIA() As Boolean
    '    Get
    '        Return Me._VerNO_CONVOCATORIA
    '    End Get
    '    Set(ByVal value As Boolean)
    '        Me._VerNO_CONVOCATORIA = value
    '        Me.colNO_CONVOCATORIA.Visible = value
    '    End Set
    'End Property

    Private _VerNUM_CONTRATO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerNUM_CONTRATO() As Boolean
        Get
            Return Me._VerNUM_CONTRATO
        End Get
        Set(ByVal value As Boolean)
            Me._VerNUM_CONTRATO = value
            Me.colNUM_CONTRATO.Visible = value
        End Set
    End Property

    Private _VerMONTO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerMONTO() As Boolean
        Get
            Return Me._VerMONTO
        End Get
        Set(ByVal value As Boolean)
            Me._VerMONTO = value
            Me.colMONTO.Visible = value
        End Set
    End Property

    Private _VerLOTE As Boolean = True
    <DefaultValue(True)> _
    Public Property VerLOTE() As Boolean
        Get
            Return Me._VerLOTE
        End Get
        Set(ByVal value As Boolean)
            Me._VerLOTE = value
            Me.colLOTE.Visible = value
        End Set
    End Property

    Private _VerSUB_LOTE As Boolean = True
    <DefaultValue(True)> _
    Public Property VerSUB_LOTE() As Boolean
        Get
            Return Me._VerSUB_LOTE
        End Get
        Set(ByVal value As Boolean)
            Me._VerSUB_LOTE = value
            Me.colSUB_LOTE.Visible = value
        End Set
    End Property

    Private _VerUSUARIO_CREACION As Boolean = True
    <DefaultValue(True)> _
    Public Property VerUSUARIO_CREACION() As Boolean
        Get
            Return Me._VerUSUARIO_CREACION
        End Get
        Set(ByVal value As Boolean)
            Me._VerUSUARIO_CREACION = value
            Me.colUSUARIO_CREACION.Visible = value
        End Set
    End Property

    Private _VerFECHA_CREACION As Boolean = True
    <DefaultValue(True)> _
    Public Property VerFECHA_CREACION() As Boolean
        Get
            Return Me._VerFECHA_CREACION
        End Get
        Set(ByVal value As Boolean)
            Me._VerFECHA_CREACION = value
            Me.colFECHA_CREACION.Visible = value
        End Set
    End Property

    Private _VerUSERID As Boolean = True
    <DefaultValue(True)> _
    Public Property VerUSERID() As Boolean
        Get
            Return Me._VerUSERID
        End Get
        Set(ByVal value As Boolean)
            Me._VerUSERID = value
            Me.colUSERID.Visible = value
        End Set
    End Property

    Private _VerLASTUPDATE As Boolean = True
    <DefaultValue(True)> _
    Public Property VerLASTUPDATE() As Boolean
        Get
            Return Me._VerLASTUPDATE
        End Get
        Set(ByVal value As Boolean)
            Me._VerLASTUPDATE = value
            Me.colLASTUPDATE.Visible = value
        End Set
    End Property

    #End Region

    Public ReadOnly Property Current() As CONTRATO_BOLPROS
        Get
            Return CType(Me.ListaCONTRATO_BOLPROSBindingSource.Current, CONTRATO_BOLPROS)
        End Get
    End Property

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla CONTRATO_BOLPROS
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	12/04/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        _mListaCONTRATO_BOLPROS = Me.mComponente.ObtenerLista()
        If _mListaCONTRATO_BOLPROS Is Nothing Then Return -1
        Me.ListaCONTRATO_BOLPROSBindingSource.DataSource = _mListaCONTRATO_BOLPROS
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla CONTRATO_BOLPROS
    ''' filtrado por la tabla PROVEEDOR_AF
    ''' </summary>
    ''' <param name="ID_PROVEEDOR_AF"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	12/04/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorPROVEEDOR_AF(ByVal ID_PROVEEDOR_AF As Decimal) As Integer
        _mListaCONTRATO_BOLPROS = Me.mComponente.ObtenerListaPorPROVEEDOR_AF(ID_PROVEEDOR_AF)
        If _mListaCONTRATO_BOLPROS Is Nothing Then Return -1
        Me.ListaCONTRATO_BOLPROSBindingSource.DataSource = _mListaCONTRATO_BOLPROS
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla CONTRATO_BOLPROS
    ''' filtrado por la tabla PROVEEDOR_AF
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	12/04/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorCriterios() As Integer
        Dim lstContratoCompra As listaCONTRATO_COMPRA
        Dim idContratoCompra As Integer = -1

        lstContratoCompra = (New cCONTRATO_COMPRA).ObtenerListaPorNO_CONTRATO_COMPRA(Me.txtNoOfertaCompra.Text)
        If lstContratoCompra IsNot Nothing AndAlso lstContratoCompra.Count > 0 Then
            idContratoCompra = lstContratoCompra(0).ID_CONTRATO_COMPRA
        End If

        _mListaCONTRATO_BOLPROS = Me.mComponente.ObtenerListaPorCriterios(Me.CbxPROVEEDOR_AF1.SelectedValue, Me.CbxPROGRAMA_FORMACION1.SelectedValue, Me.txtNUM_CONTRATO.Text, idContratoCompra, "")
        If _mListaCONTRATO_BOLPROS Is Nothing Then Return -1
        Me.ListaCONTRATO_BOLPROSBindingSource.DataSource = _mListaCONTRATO_BOLPROS
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla CONTRATO_BOLPROS
    ''' filtrado por la tabla PROGRAMA_FORMACION
    ''' </summary>
    ''' <param name="ID_PROGRAMA_FORMACION"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	12/04/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorPROGRAMA_FORMACION(ByVal ID_PROGRAMA_FORMACION As Decimal) As Integer
        _mListaCONTRATO_BOLPROS = Me.mComponente.ObtenerListaPorPROGRAMA_FORMACION(ID_PROGRAMA_FORMACION)
        If _mListaCONTRATO_BOLPROS Is Nothing Then Return -1
        Me.ListaCONTRATO_BOLPROSBindingSource.DataSource = _mListaCONTRATO_BOLPROS
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla CONTRATO_BOLPROS
    ''' filtrado por la tabla FUENTE_FINANCIAMIENTO
    ''' </summary>
    ''' <param name="ID_FUENTE"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	12/04/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorFUENTE_FINANCIAMIENTO(ByVal ID_FUENTE As Decimal) As Integer
        _mListaCONTRATO_BOLPROS = Me.mComponente.ObtenerListaPorFUENTE_FINANCIAMIENTO(ID_FUENTE)
        If _mListaCONTRATO_BOLPROS Is Nothing Then Return -1
        Me.ListaCONTRATO_BOLPROSBindingSource.DataSource = _mListaCONTRATO_BOLPROS
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Sobreecribe el ancestro de Eliminar. En este método se elimina el
    ''' registro seleccionado del Grid.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	12/04/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Eliminar() As Integer
        If Not Me.ListaCONTRATO_BOLPROSBindingSource.Current Is Nothing Then
            If Me.Current.ID_CONTRATO = 0 Then Return 0
        End If
        If MyBase.Eliminar() = 0 Then Return 0
        If Not Me.ListaCONTRATO_BOLPROSBindingSource.Current Is Nothing Then
            If mComponente.EliminarCONTRATO_BOLPROS(Me.Current.ID_CONTRATO) <> 1 Then
                Me.sError = "Suceso desconocido."
                Return -1
            End If
        Else
            Me.sError = "No tiene elegido ningun registro a eliminar"
            Return -1
        End If
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Sobreecribe el ancestro de Guardar. En este método se Guarda el
    ''' registro seleccionado del Grid, si es nuevo se Agrega y sino se Actualiza.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	12/04/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Guardar() As Integer
        If MyBase.Guardar() = 0 Then
            Return 0
        End If
        If Not Me.ListaCONTRATO_BOLPROSBindingSource.Current Is Nothing Then
            Me.ListaCONTRATO_BOLPROSBindingSource.EndEdit()
            If Not Me.Current.IsDirty Then Return 0
            Select Case mComponente.ActualizarCONTRATO_BOLPROS(Me.Current)
                Case -1
                    Me.sError = "Suceso desconocido."
                    Return -1
                Case 0
                    Me.sError = "Registro fue modificado por otro usuario antes de guardar. Recupere nuevamente los registros."
                    Return -2
                Case Else
                    Return 1
            End Select
        End If
        Return 0
    End Function

    Private Sub ListaCONTRATO_BOLPROSBindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles ListaCONTRATO_BOLPROSBindingSource.AddingNew
        Dim lEntidad As New CONTRATO_BOLPROS
        e.NewObject = lEntidad
    End Sub

    Private Sub ListaCONTRATO_BOLPROSBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaCONTRATO_BOLPROSBindingSource.PositionChanged
        RaiseEvent CambioRegistro()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Sobreecribe el ancestro de PermitirAgregar y configura el Grid
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	12/04/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Sub OnPermitirAgregar()
        Me.ListaCONTRATO_BOLPROSGridView.OptionsBehavior.AllowAddRows = Me.PermitirAgregar
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Sobreecribe el ancestro de PermitirEliminar y configura el Grid
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	12/04/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Sub OnPermitirEliminar()
        Me.ListaCONTRATO_BOLPROSGridView.OptionsBehavior.AllowDeleteRows = Me.PermitirEliminar
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Sobreecribe el ancestro de VerToolBar y reubica el Grid dependiendo
    ''' de si se oculta o pone visible la barra.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	12/04/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Sub OnVerToolbar()
        If Me.VerToolBar Then
            Me.ListaCONTRATO_BOLPROSGridControl.Dock = DockStyle.None
            Me.ListaCONTRATO_BOLPROSGridControl.Size = New Size(Me.Size.Width, Me.Size.Height - Me.ListaBindingNavigator.Size.Height)
            Me.ListaCONTRATO_BOLPROSGridControl.Location = New Point(1, Me.ListaBindingNavigator.Size.Height + 1)
        Else
            Me.ListaCONTRATO_BOLPROSGridControl.Dock = DockStyle.Fill
        End If
    End Sub

    Sub Inicializar()
        Dim c As cmembershipProvider
        c = CType(Provider, cmembershipProvider)
        CbxPROGRAMA_FORMACION1.RecuperarPorRoles(c.ObtenerRoles(Utilerias.ObtenerUsuario), True)
        Me.CbxPROVEEDOR_AF1.Recuperar(False, True)
    End Sub

    Private Sub ucListaCONTRATO_BOLPROS_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Inicializar()
    End Sub

    Private Sub ListaCONTRATO_BOLPROSGridView_CustomUnboundColumnData(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs) Handles ListaCONTRATO_BOLPROSGridView.CustomUnboundColumnData
        If e.Column.FieldName = "colProveedor" Then
            Dim lIdProveedor As Decimal = CType(e.Row, CONTRATO_BOLPROS).ID_PROVEEDOR_AF
            e.Value = (New cPROVEEDOR_AF).ObtenerPROVEEDOR_AF(lIdProveedor).NOMBRE_PROVEEDOR
        ElseIf e.Column.FieldName = "colPrograma" Then
            Dim lIdPrograma As Decimal = CType(e.Row, CONTRATO_BOLPROS).ID_PROGRAMA_FORMACION
            e.Value = (New cPROGRAMA_FORMACION).ObtenerPROGRAMA_FORMACION(lIdPrograma).NOMBRE_PROGRAMA_FORMACION
        ElseIf e.Column.FieldName = "colTIPO_CONTRATO" Then
            Dim lIdTipoContratacion As Decimal = CType(e.Row, CONTRATO_BOLPROS).ID_TIPO_CONTRA
            e.Value = (New cTIPO_CONTRATACION).ObtenerTIPO_CONTRATACION(lIdTipoContratacion).NOM_TIPO_CONTRA
        ElseIf e.Column.FieldName = "colMontoItem" Then
            Dim idContrato As Decimal = CType(e.Row, CONTRATO_BOLPROS).ID_CONTRATO
            Dim montoItems As Decimal = 0
            Dim listaItems As listaACCION_CONTRATADA = (New cACCION_CONTRATADA).ObtenerListaPorCONTRATO_BOLPROS(idContrato)

            If listaItems IsNot Nothing AndAlso listaItems.Count > 0 Then
                For Each lAccion As ACCION_CONTRATADA In listaItems
                    montoItems += lAccion.MONTO
                Next
            End If
            e.Value = montoItems
        End If
    End Sub
End Class
