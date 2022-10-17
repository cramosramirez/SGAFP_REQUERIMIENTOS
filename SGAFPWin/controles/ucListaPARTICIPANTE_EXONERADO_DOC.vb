Imports SGAFP.EL
Public Class ucListaPARTICIPANTE_EXONERADO_DOC

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.ListaBindingNavigator.BindingSource = Me.ListaPARTICIPANTE_EXONERADO_DOCBindingSource
    End Sub

    Private _mComponente As cPARTICIPANTE_EXONERADO_DOC
    Public ReadOnly Property mComponente() As cPARTICIPANTE_EXONERADO_DOC
        Get
            If _mComponente Is Nothing Then
                _mComponente = New cPARTICIPANTE_EXONERADO_DOC
            End If
            Return _mComponente
        End Get
    End Property

    Private _mListaPARTICIPANTE_EXONERADO_DOC As New listaPARTICIPANTE_EXONERADO_DOC
    Public Event CambioRegistro()
    Public Event Seleccionado(ByVal ID_PARTICIPANTE As Decimal) 

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

    Private _VerID_PARTICIPANTE As Boolean = True
    <DefaultValue(True)> _
    Public Property VerID_PARTICIPANTE() As Boolean
        Get
            Return Me._VerID_PARTICIPANTE
        End Get
        Set(ByVal value As Boolean)
            Me._VerID_PARTICIPANTE = value
            Me.colID_PARTICIPANTE.Visible = value
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

    Public ReadOnly Property Current() As PARTICIPANTE_EXONERADO_DOC
        Get
            Return CType(Me.ListaPARTICIPANTE_EXONERADO_DOCBindingSource.Current, PARTICIPANTE_EXONERADO_DOC)
        End Get
    End Property

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla PARTICIPANTE_EXONERADO_DOC
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/06/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        _mListaPARTICIPANTE_EXONERADO_DOC = Me.mComponente.ObtenerLista()
        If _mListaPARTICIPANTE_EXONERADO_DOC Is Nothing Then Return -1
        Me.ListaPARTICIPANTE_EXONERADO_DOCBindingSource.DataSource = _mListaPARTICIPANTE_EXONERADO_DOC
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla PARTICIPANTE_EXONERADO_DOC
    ''' filtrado por la tabla PARTICIPANTE
    ''' </summary>
    ''' <param name="ID_PARTICIPANTE"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/06/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorPARTICIPANTE(ByVal ID_PARTICIPANTE As Decimal) As Integer
        _mListaPARTICIPANTE_EXONERADO_DOC = Me.mComponente.ObtenerListaPorPARTICIPANTE(ID_PARTICIPANTE)
        If _mListaPARTICIPANTE_EXONERADO_DOC Is Nothing Then Return -1
        Me.ListaPARTICIPANTE_EXONERADO_DOCBindingSource.DataSource = _mListaPARTICIPANTE_EXONERADO_DOC
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
    ''' 	[GenApp]	28/06/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Eliminar() As Integer
        If Not Me.ListaPARTICIPANTE_EXONERADO_DOCBindingSource.Current Is Nothing Then
            If Me.Current.ID_PARTICIPANTE = 0 Then Return 0
        End If
        If MyBase.Eliminar() = 0 Then Return 0
        If Not Me.ListaPARTICIPANTE_EXONERADO_DOCBindingSource.Current Is Nothing Then
            If mComponente.EliminarPARTICIPANTE_EXONERADO_DOC(Me.Current.ID_PARTICIPANTE) <> 1 Then
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
    ''' 	[GenApp]	28/06/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Guardar() As Integer
        If MyBase.Guardar() = 0 Then
            Return 0
        End If
        If Not Me.ListaPARTICIPANTE_EXONERADO_DOCBindingSource.Current Is Nothing Then
            Me.ListaPARTICIPANTE_EXONERADO_DOCBindingSource.EndEdit()
            If Not Me.Current.IsDirty Then Return 0
            Dim liRet As Integer
            If Me.Current.ID_PARTICIPANTE = 0 Then
                liRet = mComponente.ActualizarPARTICIPANTE_EXONERADO_DOC(Me.Current)
            Else
                liRet = mComponente.AgregarPARTICIPANTE_EXONERADO_DOC(Me.Current)
            End If
            Select Case liRet
                Case -1
                    Me.sError = "Suceso desconocido."
                    Return -1
                Case 0
                    Me.sError = "Registro no pudo ser Guardado."
                    Return -2
                Case Else
                    Return 1
            End Select
        End If
        Return 0
    End Function

    Private Sub ListaPARTICIPANTE_EXONERADO_DOCBindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles ListaPARTICIPANTE_EXONERADO_DOCBindingSource.AddingNew
        Dim lEntidad As New PARTICIPANTE_EXONERADO_DOC
        e.NewObject = lEntidad
    End Sub

    Private Sub ListaPARTICIPANTE_EXONERADO_DOCBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaPARTICIPANTE_EXONERADO_DOCBindingSource.PositionChanged
        RaiseEvent CambioRegistro()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Sobreecribe el ancestro de PermitirAgregar y configura el Grid
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/06/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Sub OnPermitirAgregar()
        Me.ListaPARTICIPANTE_EXONERADO_DOCGridView.OptionsBehavior.AllowAddRows = Me.PermitirAgregar
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Sobreecribe el ancestro de PermitirEliminar y configura el Grid
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/06/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Sub OnPermitirEliminar()
        Me.ListaPARTICIPANTE_EXONERADO_DOCGridView.OptionsBehavior.AllowDeleteRows = Me.PermitirEliminar
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Sobreecribe el ancestro de VerToolBar y reubica el Grid dependiendo
    ''' de si se oculta o pone visible la barra.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/06/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Sub OnVerToolbar()
        If Me.VerToolBar Then
            Me.ListaPARTICIPANTE_EXONERADO_DOCGridControl.Dock = DockStyle.None
            Me.ListaPARTICIPANTE_EXONERADO_DOCGridControl.Size = New Size(Me.Size.Width, Me.Size.Height - Me.ListaBindingNavigator.Size.Height)
            Me.ListaPARTICIPANTE_EXONERADO_DOCGridControl.Location = New Point(1, Me.ListaBindingNavigator.Size.Height + 1)
        Else
            Me.ListaPARTICIPANTE_EXONERADO_DOCGridControl.Dock = DockStyle.Fill
        End If
    End Sub

End Class
