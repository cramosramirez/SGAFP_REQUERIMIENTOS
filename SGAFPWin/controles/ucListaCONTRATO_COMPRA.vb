Imports SGAFP.EL
Imports System.Web.Security.Membership
Imports SQLMembershipProvider.BL

Public Class ucListaCONTRATO_COMPRA

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.ListaBindingNavigator.BindingSource = Me.ListaCONTRATO_COMPRABindingSource
    End Sub

    Private _mComponente As cCONTRATO_COMPRA
    Public ReadOnly Property mComponente() As cCONTRATO_COMPRA
        Get
            If _mComponente Is Nothing Then
                _mComponente = New cCONTRATO_COMPRA
            End If
            Return _mComponente
        End Get
    End Property

    Private _mListaCONTRATO_COMPRA As New listaCONTRATO_COMPRA
    Public Event CambioRegistro()
    Public Event Seleccionado(ByVal ID_CONTRATO_COMPRA As Decimal) 

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

    Private _VerID_CONTRATO_COMPRA As Boolean = True
    <DefaultValue(True)> _
    Public Property VerID_CONTRATO_COMPRA() As Boolean
        Get
            Return Me._VerID_CONTRATO_COMPRA
        End Get
        Set(ByVal value As Boolean)
            Me._VerID_CONTRATO_COMPRA = value
            Me.colID_CONTRATO_COMPRA.Visible = value
        End Set
    End Property

    Private _VerNO_CONTRATO_COMPRA As Boolean = True
    <DefaultValue(True)> _
    Public Property VerNO_CONTRATO_COMPRA() As Boolean
        Get
            Return Me._VerNO_CONTRATO_COMPRA
        End Get
        Set(ByVal value As Boolean)
            Me._VerNO_CONTRATO_COMPRA = value
            Me.colNO_CONTRATO_COMPRA.Visible = value
        End Set
    End Property

    Private _VerFECHA_INGRESO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerFECHA_INGRESO() As Boolean
        Get
            Return Me._VerFECHA_INGRESO
        End Get
        Set(ByVal value As Boolean)
            Me._VerFECHA_INGRESO = value
            Me.colFECHA_INGRESO.Visible = value
        End Set
    End Property
#End Region

    Public ReadOnly Property Current() As CONTRATO_COMPRA
        Get
            Return CType(Me.ListaCONTRATO_COMPRABindingSource.Current, CONTRATO_COMPRA)
        End Get
    End Property

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla CONTRATO_COMPRA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	17/05/2016	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        _mListaCONTRATO_COMPRA = Me.mComponente.ObtenerLista()
        If _mListaCONTRATO_COMPRA Is Nothing Then Return -1
        Me.ListaCONTRATO_COMPRABindingSource.DataSource = _mListaCONTRATO_COMPRA
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
    ''' 	[GenApp]	17/05/2016	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Eliminar() As Integer
        If Not Me.ListaCONTRATO_COMPRABindingSource.Current Is Nothing Then
            If Me.Current.ID_CONTRATO_COMPRA = 0 Then Return 0
        End If
        If MyBase.Eliminar() = 0 Then Return 0
        If Not Me.ListaCONTRATO_COMPRABindingSource.Current Is Nothing Then
            If mComponente.EliminarCONTRATO_COMPRA(Me.Current.ID_CONTRATO_COMPRA) <> 1 Then
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
    ''' 	[GenApp]	17/05/2016	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Guardar() As Integer
        If MyBase.Guardar() = 0 Then
            Return 0
        End If
        If Not Me.ListaCONTRATO_COMPRABindingSource.Current Is Nothing Then
            Me.ListaCONTRATO_COMPRABindingSource.EndEdit()
            If Not Me.Current.IsDirty Then Return 0
            Select Case mComponente.ActualizarCONTRATO_COMPRA(Me.Current)
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

    Private Sub ListaCONTRATO_COMPRABindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles ListaCONTRATO_COMPRABindingSource.AddingNew
        Dim lEntidad As New CONTRATO_COMPRA
        e.NewObject = lEntidad
    End Sub

    Private Sub ListaCONTRATO_COMPRABindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaCONTRATO_COMPRABindingSource.PositionChanged
        RaiseEvent CambioRegistro()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Sobreecribe el ancestro de PermitirAgregar y configura el Grid
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	17/05/2016	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Sub OnPermitirAgregar()
        Me.ListaCONTRATO_COMPRAGridView.OptionsBehavior.AllowAddRows = Me.PermitirAgregar
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Sobreecribe el ancestro de PermitirEliminar y configura el Grid
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	17/05/2016	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Sub OnPermitirEliminar()
        Me.ListaCONTRATO_COMPRAGridView.OptionsBehavior.AllowDeleteRows = Me.PermitirEliminar
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Sobreecribe el ancestro de VerToolBar y reubica el Grid dependiendo
    ''' de si se oculta o pone visible la barra.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	17/05/2016	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Sub OnVerToolbar()
        If Me.VerToolBar Then
            Me.ListaCONTRATO_COMPRAGridControl.Dock = DockStyle.None
            Me.ListaCONTRATO_COMPRAGridControl.Size = New Size(Me.Size.Width, Me.Size.Height - Me.ListaBindingNavigator.Size.Height)
            Me.ListaCONTRATO_COMPRAGridControl.Location = New Point(1, Me.ListaBindingNavigator.Size.Height + 1)
        Else
            Me.ListaCONTRATO_COMPRAGridControl.Dock = DockStyle.Fill
        End If
    End Sub

End Class
