Imports SGAFP.EL
Imports System.Web.Security.Membership
Imports SQLMembershipProvider.BL

Public Class ucListaACCION_CONTRATADA

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.ListaBindingNavigator.BindingSource = Me.ListaACCION_CONTRATADABindingSource
    End Sub

    Private _mComponente As cACCION_CONTRATADA
    Public ReadOnly Property mComponente() As cACCION_CONTRATADA
        Get
            If _mComponente Is Nothing Then
                _mComponente = New cACCION_CONTRATADA
            End If
            Return _mComponente
        End Get
    End Property

    Private _mListaACCION_CONTRATADA As New listaACCION_CONTRATADA
    Public Event CambioRegistro()
    Public Event Seleccionado(ByVal ID_ACCION_CONTRATADA As Decimal) 

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


    Private _ID_PROVEEDOR_AF As Object
    Public Property ID_PROVEEDOR_AF() As Object
        Get
            Return Me.CbxPROVEEDOR_AF1.SelectedValue
        End Get
        Set(ByVal value As Object)
            Me.CbxPROVEEDOR_AF1.SelectedValue = value
        End Set
    End Property

    Public Property ID_PROGRAMA_FORMACION() As Object
        Get
            Return Me.CbxPROGRAMA_FORMACION1.SelectedValue
        End Get
        Set(ByVal value As Object)
            Me.CbxPROGRAMA_FORMACION1.SelectedValue = value
        End Set
    End Property

    Public Property NUM_CONTRATO() As String
        Get
            Return Me.TextEditNUM_CONTRATO.Text
        End Get
        Set(ByVal value As String)
            Me.TextEditNUM_CONTRATO.Text = value
        End Set
    End Property

    Private _VerID_ACCION_CONTRATADA As Boolean = True
    <DefaultValue(True)> _
    Public Property VerID_ACCION_CONTRATADA() As Boolean
        Get
            Return Me._VerID_ACCION_CONTRATADA
        End Get
        Set(ByVal value As Boolean)
            Me._VerID_ACCION_CONTRATADA = value
            Me.colID_ACCION_CONTRATADA.Visible = value
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

    Private _VerCODIGO_DEPARTAMENTO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerCODIGO_DEPARTAMENTO() As Boolean
        Get
            Return Me._VerCODIGO_DEPARTAMENTO
        End Get
        Set(ByVal value As Boolean)
            Me._VerCODIGO_DEPARTAMENTO = value
            Me.colCODIGO_DEPARTAMENTO.Visible = value
        End Set
    End Property

    Private _VerCODIGO_MUNICIPIO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerCODIGO_MUNICIPIO() As Boolean
        Get
            Return Me._VerCODIGO_MUNICIPIO
        End Get
        Set(ByVal value As Boolean)
            Me._VerCODIGO_MUNICIPIO = value
            Me.colCODIGO_MUNICIPIO.Visible = value
        End Set
    End Property

    Private _VerCODIGO_PROGRAMA As Boolean = True
    <DefaultValue(True)> _
    Public Property VerCODIGO_PROGRAMA() As Boolean
        Get
            Return Me._VerCODIGO_PROGRAMA
        End Get
        Set(ByVal value As Boolean)
            Me._VerCODIGO_PROGRAMA = value
            Me.colProgramaSIFP.Visible = value
        End Set
    End Property

    Private _VerDURACION As Boolean = True
    <DefaultValue(True)> _
    Public Property VerDURACION() As Boolean
        Get
            Return Me._VerDURACION
        End Get
        Set(ByVal value As Boolean)
            Me._VerDURACION = value
            Me.colDURACION.Visible = value
        End Set
    End Property

    Private _VerCANT_CURSOS As Boolean = True
    <DefaultValue(True)> _
    Public Property VerCANT_CURSOS() As Boolean
        Get
            Return Me._VerCANT_CURSOS
        End Get
        Set(ByVal value As Boolean)
            Me._VerCANT_CURSOS = value
            Me.colCANT_CURSOS.Visible = value
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

    Public ReadOnly Property Current() As ACCION_CONTRATADA
        Get
            Return CType(Me.ListaACCION_CONTRATADABindingSource.Current, ACCION_CONTRATADA)
        End Get
    End Property

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla ACCION_CONTRATADA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	12/04/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorCriterios() As Integer
        _mListaACCION_CONTRATADA = Me.mComponente.ObtenerListaPorCriterios(CbxPROVEEDOR_AF1.SelectedValue, CbxPROGRAMA_FORMACION1.SelectedValue, TextEditNUM_CONTRATO.Text)
        If _mListaACCION_CONTRATADA Is Nothing Then Return -1
        Me.ListaACCION_CONTRATADABindingSource.DataSource = _mListaACCION_CONTRATADA
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla ACCION_CONTRATADA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	12/04/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        _mListaACCION_CONTRATADA = Me.mComponente.ObtenerLista()
        If _mListaACCION_CONTRATADA Is Nothing Then Return -1
        Me.ListaACCION_CONTRATADABindingSource.DataSource = _mListaACCION_CONTRATADA
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla ACCION_CONTRATADA
    ''' filtrado por la tabla CONTRATO_BOLPROS
    ''' </summary>
    ''' <param name="ID_CONTRATO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	12/04/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorCONTRATO_BOLPROS(ByVal ID_CONTRATO As Decimal) As Integer
        _mListaACCION_CONTRATADA = Me.mComponente.ObtenerListaPorCONTRATO_BOLPROS(ID_CONTRATO)
        If _mListaACCION_CONTRATADA Is Nothing Then Return -1
        Me.ListaACCION_CONTRATADABindingSource.DataSource = _mListaACCION_CONTRATADA
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla ACCION_CONTRATADA
    ''' filtrado por la tabla DEPARTAMENTO
    ''' </summary>
    ''' <param name="CODIGO_DEPARTAMENTO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	12/04/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorDEPARTAMENTO(ByVal CODIGO_DEPARTAMENTO As String) As Integer
        _mListaACCION_CONTRATADA = Me.mComponente.ObtenerListaPorDEPARTAMENTO(CODIGO_DEPARTAMENTO)
        If _mListaACCION_CONTRATADA Is Nothing Then Return -1
        Me.ListaACCION_CONTRATADABindingSource.DataSource = _mListaACCION_CONTRATADA
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla ACCION_CONTRATADA
    ''' filtrado por la tabla MUNICIPIO
    ''' </summary>
    ''' <param name="CODIGO_DEPARTAMENTO"></param>
    ''' <param name="CODIGO_MUNICIPIO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	12/04/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorMUNICIPIO(ByVal CODIGO_DEPARTAMENTO As String, ByVal CODIGO_MUNICIPIO As String) As Integer
        _mListaACCION_CONTRATADA = Me.mComponente.ObtenerListaPorMUNICIPIO(CODIGO_DEPARTAMENTO, CODIGO_MUNICIPIO)
        If _mListaACCION_CONTRATADA Is Nothing Then Return -1
        Me.ListaACCION_CONTRATADABindingSource.DataSource = _mListaACCION_CONTRATADA
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
        If Not Me.ListaACCION_CONTRATADABindingSource.Current Is Nothing Then
            If Me.Current.ID_ACCION_CONTRATADA = 0 Then Return 0
        End If
        If MyBase.Eliminar() = 0 Then Return 0
        If Not Me.ListaACCION_CONTRATADABindingSource.Current Is Nothing Then
            If mComponente.EliminarACCION_CONTRATADA(Me.Current.ID_ACCION_CONTRATADA) <> 1 Then
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
        If Not Me.ListaACCION_CONTRATADABindingSource.Current Is Nothing Then
            Me.ListaACCION_CONTRATADABindingSource.EndEdit()
            If Not Me.Current.IsDirty Then Return 0
            Select Case mComponente.ActualizarACCION_CONTRATADA(Me.Current)
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

    Private Sub ListaACCION_CONTRATADABindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles ListaACCION_CONTRATADABindingSource.AddingNew
        Dim lEntidad As New ACCION_CONTRATADA
        e.NewObject = lEntidad
    End Sub

    Private Sub ListaACCION_CONTRATADABindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaACCION_CONTRATADABindingSource.PositionChanged
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
        Me.ListaACCION_CONTRATADAGridView.OptionsBehavior.AllowAddRows = Me.PermitirAgregar
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
        Me.ListaACCION_CONTRATADAGridView.OptionsBehavior.AllowDeleteRows = Me.PermitirEliminar
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
            Me.ListaACCION_CONTRATADAGridControl.Dock = DockStyle.None
            Me.ListaACCION_CONTRATADAGridControl.Size = New Size(Me.Size.Width, Me.Size.Height - Me.ListaBindingNavigator.Size.Height)
            Me.ListaACCION_CONTRATADAGridControl.Location = New Point(1, Me.ListaBindingNavigator.Size.Height + 1)
        Else
            Me.ListaACCION_CONTRATADAGridControl.Dock = DockStyle.Fill
        End If
    End Sub

    Sub Inicializar()
        Dim c As cmembershipProvider
        c = CType(Provider, cmembershipProvider)
        Me.CbxPROGRAMA_FORMACION1.RecuperarPorRoles(c.ObtenerRoles(Utilerias.ObtenerUsuario), True)
        Me.CbxPROVEEDOR_AF1.Recuperar(False, True)
        Me.TextEditNUM_CONTRATO.Text = ""
    End Sub

    Private Sub ucListaACCION_CONTRATADA_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Inicializar()
    End Sub


    Private Sub ListaACCION_CONTRATADAGridView_CustomUnboundColumnData(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs) Handles ListaACCION_CONTRATADAGridView.CustomUnboundColumnData
        If e.Column.FieldName = "colProveedor" Then
            Dim lIdContrato As Decimal = CType(e.Row, ACCION_CONTRATADA).ID_CONTRATO
            Dim lEntidadContrato As CONTRATO_BOLPROS = (New cCONTRATO_BOLPROS).ObtenerCONTRATO_BOLPROS(lIdContrato)
            If lEntidadContrato IsNot Nothing Then
                e.Value = (New cPROVEEDOR_AF).ObtenerPROVEEDOR_AF(lEntidadContrato.ID_PROVEEDOR_AF).NOMBRE_PROVEEDOR
            End If
        ElseIf e.Column.FieldName = "colPrograma" Then
            Dim lIdContrato As Decimal = CType(e.Row, ACCION_CONTRATADA).ID_CONTRATO
            Dim lEntidadContrato As CONTRATO_BOLPROS = (New cCONTRATO_BOLPROS).ObtenerCONTRATO_BOLPROS(lIdContrato)
            If lEntidadContrato IsNot Nothing Then
                e.Value = (New cPROGRAMA_FORMACION).ObtenerPROGRAMA_FORMACION(lEntidadContrato.ID_PROGRAMA_FORMACION).NOMBRE_PROGRAMA_FORMACION
            End If
        ElseIf e.Column.FieldName = "colProgramaSIFP" Then
            Dim lEntidadAccion As ACCION_CONTRATADA = CType(e.Row, ACCION_CONTRATADA)
            If lEntidadAccion IsNot Nothing Then
                Dim lEntidadPrograma As SIFP.EL.Programas = (New SIFP.BL.cProgramas).ObtenerProgramas(lEntidadAccion.CODIGO_PROGRAMA.Trim)
                If lEntidadPrograma IsNot Nothing Then
                    e.Value = lEntidadPrograma.nombre_programa
                Else
                    e.Value = ""
                End If
            End If
        ElseIf e.Column.FieldName = "colContrato" Then
            Dim lIdContrato As Decimal = CType(e.Row, ACCION_CONTRATADA).ID_CONTRATO
            Dim lEntidadContrato As CONTRATO_BOLPROS = (New cCONTRATO_BOLPROS).ObtenerCONTRATO_BOLPROS(lIdContrato)
            If lEntidadContrato IsNot Nothing Then
                e.Value = lEntidadContrato.NUM_CONTRATO
            End If
        ElseIf e.Column.FieldName = "colLote" Then
            Dim lIdContrato As Decimal = CType(e.Row, ACCION_CONTRATADA).ID_CONTRATO
            Dim lEntidadContrato As CONTRATO_BOLPROS = (New cCONTRATO_BOLPROS).ObtenerCONTRATO_BOLPROS(lIdContrato)
            If lEntidadContrato IsNot Nothing Then
                e.Value = lEntidadContrato.LOTE
            End If
        ElseIf e.Column.FieldName = "colSubLote" Then
            Dim lIdContrato As Decimal = CType(e.Row, ACCION_CONTRATADA).ID_CONTRATO
            Dim lEntidadContrato As CONTRATO_BOLPROS = (New cCONTRATO_BOLPROS).ObtenerCONTRATO_BOLPROS(lIdContrato)
            If lEntidadContrato IsNot Nothing Then
                e.Value = lEntidadContrato.SUB_LOTE
            End If
        ElseIf e.Column.FieldName = "colGruposPATI" Then
            Dim lEntidadAccion As ACCION_CONTRATADA = CType(e.Row, ACCION_CONTRATADA)
            Dim lListaGrupos As listaGRUPO_ACCION_CONTRATADA
            lListaGrupos = (New cGRUPO_ACCION_CONTRATADA).ObtenerListaPorACCION_CONTRATADA(lEntidadAccion.ID_ACCION_CONTRATADA)
            If lListaGrupos IsNot Nothing Then e.Value = lListaGrupos.Count Else e.Value = 0
        ElseIf e.Column.FieldName = "colDeptoMunicipio" Then
            Dim lEntidadAccion As ACCION_CONTRATADA = CType(e.Row, ACCION_CONTRATADA)
            e.Value = (New cDEPARTAMENTO).ObtenerDEPARTAMENTO(lEntidadAccion.CODIGO_DEPARTAMENTO).NOMBRE + ", " + _
                (New cMUNICIPIO).ObtenerMUNICIPIO(lEntidadAccion.CODIGO_DEPARTAMENTO, lEntidadAccion.CODIGO_MUNICIPIO).NOMBRE
        ElseIf e.Column.FieldName = "colHabilitada" Then
            Dim lEntidadAccion As ACCION_CONTRATADA = CType(e.Row, ACCION_CONTRATADA)
            Dim lListaGrupos As listaGRUPO_ACCION_CONTRATADA
            Dim lCantHabilitados As Integer = 0
            lListaGrupos = (New cGRUPO_ACCION_CONTRATADA).ObtenerListaPorACCION_CONTRATADA(lEntidadAccion.ID_ACCION_CONTRATADA)
            If lListaGrupos IsNot Nothing Then
                For i As Integer = 0 To lListaGrupos.Count - 1
                    If lListaGrupos(i).HABILITADO = 1 Then lCantHabilitados += 1
                Next
            End If
            e.Value = lCantHabilitados
        End If
    End Sub
End Class
