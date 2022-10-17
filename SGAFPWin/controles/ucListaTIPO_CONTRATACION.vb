Imports SGAFP.EL
Public Class ucListaTIPO_CONTRATACION

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.ListaBindingNavigator.BindingSource = Me.ListaTIPO_CONTRATACIONBindingSource
    End Sub

    Private _mComponente As cTIPO_CONTRATACION
    Public ReadOnly Property mComponente() As cTIPO_CONTRATACION
        Get
            If _mComponente Is Nothing Then
                _mComponente = New cTIPO_CONTRATACION
            End If
            Return _mComponente
        End Get
    End Property

    Private _mListaTIPO_CONTRATACION As New listaTIPO_CONTRATACION
    Public Event CambioRegistro()
    Public Event Seleccionado(ByVal ID_TIPO_CONTRA As Decimal) 

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

    Private _VerID_TIPO_CONTRA As Boolean = True
    <DefaultValue(True)> _
    Public Property VerID_TIPO_CONTRA() As Boolean
        Get
            Return Me._VerID_TIPO_CONTRA
        End Get
        Set(ByVal value As Boolean)
            Me._VerID_TIPO_CONTRA = value
            Me.colID_TIPO_CONTRA.Visible = value
        End Set
    End Property

    Private _VerNOM_TIPO_CONTRA As Boolean = True
    <DefaultValue(True)> _
    Public Property VerNOM_TIPO_CONTRA() As Boolean
        Get
            Return Me._VerNOM_TIPO_CONTRA
        End Get
        Set(ByVal value As Boolean)
            Me._VerNOM_TIPO_CONTRA = value
            Me.colNOM_TIPO_CONTRA.Visible = value
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

    Public ReadOnly Property Current() As TIPO_CONTRATACION
        Get
            Return CType(Me.ListaTIPO_CONTRATACIONBindingSource.Current, TIPO_CONTRATACION)
        End Get
    End Property

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla TIPO_CONTRATACION
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	11/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        _mListaTIPO_CONTRATACION = Me.mComponente.ObtenerLista()
        If _mListaTIPO_CONTRATACION Is Nothing Then Return -1
        Me.ListaTIPO_CONTRATACIONBindingSource.DataSource = _mListaTIPO_CONTRATACION
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
    ''' 	[GenApp]	11/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Eliminar() As Integer
        If Not Me.ListaTIPO_CONTRATACIONBindingSource.Current Is Nothing Then
            If Me.Current.ID_TIPO_CONTRA = 0 Then Return 0
        End If
        If MyBase.Eliminar() = 0 Then Return 0
        If Not Me.ListaTIPO_CONTRATACIONBindingSource.Current Is Nothing Then
            If mComponente.EliminarTIPO_CONTRATACION(Me.Current.ID_TIPO_CONTRA) <> 1 Then
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
    ''' 	[GenApp]	11/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Guardar() As Integer
        If MyBase.Guardar() = 0 Then
            Return 0
        End If
        If Not Me.ListaTIPO_CONTRATACIONBindingSource.Current Is Nothing Then
            Me.ListaTIPO_CONTRATACIONBindingSource.EndEdit()
            If Not Me.Current.IsDirty Then Return 0
            Select Case mComponente.ActualizarTIPO_CONTRATACION(Me.Current)
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

    Private Sub ListaTIPO_CONTRATACIONBindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles ListaTIPO_CONTRATACIONBindingSource.AddingNew
        Dim lEntidad As New TIPO_CONTRATACION
        e.NewObject = lEntidad
    End Sub

    Private Sub ListaTIPO_CONTRATACIONBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaTIPO_CONTRATACIONBindingSource.PositionChanged
        RaiseEvent CambioRegistro()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Sobreecribe el ancestro de PermitirAgregar y configura el Grid
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	11/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Sub OnPermitirAgregar()
        Me.ListaTIPO_CONTRATACIONGridView.OptionsBehavior.AllowAddRows = Me.PermitirAgregar
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Sobreecribe el ancestro de PermitirEliminar y configura el Grid
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	11/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Sub OnPermitirEliminar()
        Me.ListaTIPO_CONTRATACIONGridView.OptionsBehavior.AllowDeleteRows = Me.PermitirEliminar
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Sobreecribe el ancestro de VerToolBar y reubica el Grid dependiendo
    ''' de si se oculta o pone visible la barra.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	11/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Sub OnVerToolbar()
        If Me.VerToolBar Then
            Me.ListaTIPO_CONTRATACIONGridControl.Dock = DockStyle.None
            Me.ListaTIPO_CONTRATACIONGridControl.Size = New Size(Me.Size.Width, Me.Size.Height - Me.ListaBindingNavigator.Size.Height)
            Me.ListaTIPO_CONTRATACIONGridControl.Location = New Point(1, Me.ListaBindingNavigator.Size.Height + 1)
        Else
            Me.ListaTIPO_CONTRATACIONGridControl.Dock = DockStyle.Fill
        End If
    End Sub

End Class
