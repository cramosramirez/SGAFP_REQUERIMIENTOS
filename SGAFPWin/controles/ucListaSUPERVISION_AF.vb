Imports SGAFP.EL
Public Class ucListaSUPERVISION_AF

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.ListaBindingNavigator.BindingSource = Me.ListaSUPERVISION_AFBindingSource
    End Sub

    Private mComponente As New cSUPERVISION_AF
    Private _mListaSUPERVISION_AF As New listaSUPERVISION_AF
    Public Event CambioRegistro()
    Public Event Seleccionado(ByVal ID_SUPERVISION_AF As Decimal) 

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

    Private _VerID_SUPERVISION_AF As Boolean = True
    <DefaultValue(True)> _
    Public Property VerID_SUPERVISION_AF() As Boolean
        Get
            Return Me._VerID_SUPERVISION_AF
        End Get
        Set(ByVal value As Boolean)
            Me._VerID_SUPERVISION_AF = value
            Me.DataGridViewTextBoxID_SUPERVISION_AF.Visible = value
        End Set
    End Property

    Private _VerID_MODALIDAD_FORMACION As Boolean = True
    <DefaultValue(True)> _
    Public Property VerID_MODALIDAD_FORMACION() As Boolean
        Get
            Return Me._VerID_MODALIDAD_FORMACION
        End Get
        Set(ByVal value As Boolean)
            Me._VerID_MODALIDAD_FORMACION = value
            Me.DataGridViewTextBoxID_MODALIDAD_FORMACION.Visible = value
        End Set
    End Property

    Private _VerID_ACCION_FORMATIVA As Boolean = True
    <DefaultValue(True)> _
    Public Property VerID_ACCION_FORMATIVA() As Boolean
        Get
            Return Me._VerID_ACCION_FORMATIVA
        End Get
        Set(ByVal value As Boolean)
            Me._VerID_ACCION_FORMATIVA = value
            Me.DataGridViewTextBoxID_ACCION_FORMATIVA.Visible = value
        End Set
    End Property

    Private _VerFECHA As Boolean = True
    <DefaultValue(True)> _
    Public Property VerFECHA() As Boolean
        Get
            Return Me._VerFECHA
        End Get
        Set(ByVal value As Boolean)
            Me._VerFECHA = value
            Me.DataGridViewTextBoxFECHA.Visible = value
        End Set
    End Property

    Private _VerNOMBRE_AF As Boolean = True
    <DefaultValue(True)> _
    Public Property VerNOMBRE_AF() As Boolean
        Get
            Return Me._VerNOMBRE_AF
        End Get
        Set(ByVal value As Boolean)
            Me._VerNOMBRE_AF = value
            Me.DataGridViewTextBoxNOMBRE_AF.Visible = value
        End Set
    End Property

    Private _VerCENTRO_FORMACION As Boolean = True
    <DefaultValue(True)> _
    Public Property VerCENTRO_FORMACION() As Boolean
        Get
            Return Me._VerCENTRO_FORMACION
        End Get
        Set(ByVal value As Boolean)
            Me._VerCENTRO_FORMACION = value
            Me.DataGridViewTextBoxCENTRO_FORMACION.Visible = value
        End Set
    End Property

    Private _VerOPCION As Boolean = True
    <DefaultValue(True)> _
    Public Property VerOPCION() As Boolean
        Get
            Return Me._VerOPCION
        End Get
        Set(ByVal value As Boolean)
            Me._VerOPCION = value
            Me.DataGridViewTextBoxOPCION.Visible = value
        End Set
    End Property

    Private _VerGRUPO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerGRUPO() As Boolean
        Get
            Return Me._VerGRUPO
        End Get
        Set(ByVal value As Boolean)
            Me._VerGRUPO = value
            Me.DataGridViewTextBoxGRUPO.Visible = value
        End Set
    End Property

    Private _VerHORARIO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerHORARIO() As Boolean
        Get
            Return Me._VerHORARIO
        End Get
        Set(ByVal value As Boolean)
            Me._VerHORARIO = value
            Me.DataGridViewTextBoxHORARIO.Visible = value
        End Set
    End Property

    Private _VerCODIGO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerCODIGO() As Boolean
        Get
            Return Me._VerCODIGO
        End Get
        Set(ByVal value As Boolean)
            Me._VerCODIGO = value
            Me.DataGridViewTextBoxCODIGO.Visible = value
        End Set
    End Property

    Private _VerCOORDINADOR_CFP As Boolean = True
    <DefaultValue(True)> _
    Public Property VerCOORDINADOR_CFP() As Boolean
        Get
            Return Me._VerCOORDINADOR_CFP
        End Get
        Set(ByVal value As Boolean)
            Me._VerCOORDINADOR_CFP = value
            Me.DataGridViewTextBoxCOORDINADOR_CFP.Visible = value
        End Set
    End Property

    Private _VerDIRECTOR_CFP As Boolean = True
    <DefaultValue(True)> _
    Public Property VerDIRECTOR_CFP() As Boolean
        Get
            Return Me._VerDIRECTOR_CFP
        End Get
        Set(ByVal value As Boolean)
            Me._VerDIRECTOR_CFP = value
            Me.DataGridViewTextBoxDIRECTOR_CFP.Visible = value
        End Set
    End Property

    Private _VerPARTICIPANTES_PRESENTES As Boolean = True
    <DefaultValue(True)> _
    Public Property VerPARTICIPANTES_PRESENTES() As Boolean
        Get
            Return Me._VerPARTICIPANTES_PRESENTES
        End Get
        Set(ByVal value As Boolean)
            Me._VerPARTICIPANTES_PRESENTES = value
            Me.DataGridViewTextBoxPARTICIPANTES_PRESENTES.Visible = value
        End Set
    End Property

    Private _VerPARTICIPANTES_AUSENTES As Boolean = True
    <DefaultValue(True)> _
    Public Property VerPARTICIPANTES_AUSENTES() As Boolean
        Get
            Return Me._VerPARTICIPANTES_AUSENTES
        End Get
        Set(ByVal value As Boolean)
            Me._VerPARTICIPANTES_AUSENTES = value
            Me.DataGridViewTextBoxPARTICIPANTES_AUSENTES.Visible = value
        End Set
    End Property

    Private _VerPARTICIPANTES_INSCRITOS As Boolean = True
    <DefaultValue(True)> _
    Public Property VerPARTICIPANTES_INSCRITOS() As Boolean
        Get
            Return Me._VerPARTICIPANTES_INSCRITOS
        End Get
        Set(ByVal value As Boolean)
            Me._VerPARTICIPANTES_INSCRITOS = value
            Me.DataGridViewTextBoxPARTICIPANTES_INSCRITOS.Visible = value
        End Set
    End Property

    Private _VerPARTICIPANTES_DESERTADOS As Boolean = True
    <DefaultValue(True)> _
    Public Property VerPARTICIPANTES_DESERTADOS() As Boolean
        Get
            Return Me._VerPARTICIPANTES_DESERTADOS
        End Get
        Set(ByVal value As Boolean)
            Me._VerPARTICIPANTES_DESERTADOS = value
            Me.DataGridViewTextBoxPARTICIPANTES_DESERTADOS.Visible = value
        End Set
    End Property

    Private _VerPARTICIPANTES_SUPLENTES As Boolean = True
    <DefaultValue(True)> _
    Public Property VerPARTICIPANTES_SUPLENTES() As Boolean
        Get
            Return Me._VerPARTICIPANTES_SUPLENTES
        End Get
        Set(ByVal value As Boolean)
            Me._VerPARTICIPANTES_SUPLENTES = value
            Me.DataGridViewTextBoxPARTICIPANTES_SUPLENTES.Visible = value
        End Set
    End Property

    Private _VerOBJETIVO_VISITA As Boolean = True
    <DefaultValue(True)> _
    Public Property VerOBJETIVO_VISITA() As Boolean
        Get
            Return Me._VerOBJETIVO_VISITA
        End Get
        Set(ByVal value As Boolean)
            Me._VerOBJETIVO_VISITA = value
            Me.DataGridViewTextBoxOBJETIVO_VISITA.Visible = value
        End Set
    End Property

    Private _VerNOTAS As Boolean = True
    <DefaultValue(True)> _
    Public Property VerNOTAS() As Boolean
        Get
            Return Me._VerNOTAS
        End Get
        Set(ByVal value As Boolean)
            Me._VerNOTAS = value
            Me.DataGridViewTextBoxNOTAS.Visible = value
        End Set
    End Property

    Private _VerDURACION_VISITA As Boolean = True
    <DefaultValue(True)> _
    Public Property VerDURACION_VISITA() As Boolean
        Get
            Return Me._VerDURACION_VISITA
        End Get
        Set(ByVal value As Boolean)
            Me._VerDURACION_VISITA = value
            Me.DataGridViewTextBoxDURACION_VISITA.Visible = value
        End Set
    End Property

    #End Region

    Public ReadOnly Property Current() As SUPERVISION_AF
        Get
            Return CType(Me.ListaSUPERVISION_AFBindingSource.Current, SUPERVISION_AF)
        End Get
    End Property

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla SUPERVISION_AF
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        _mListaSUPERVISION_AF = Me.mComponente.ObtenerLista()
        If _mListaSUPERVISION_AF Is Nothing Then Return -1
        Me.ListaSUPERVISION_AFBindingSource.DataSource = _mListaSUPERVISION_AF
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla SUPERVISION_AF
    ''' filtrado por la tabla MODALIDAD_DE_FORMACION
    ''' </summary>
    ''' <param name="ID_MODALIDAD_FORMACION"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorMODALIDAD_DE_FORMACION(ByVal ID_MODALIDAD_FORMACION As Decimal) As Integer
        _mListaSUPERVISION_AF = Me.mComponente.ObtenerListaPorMODALIDAD_DE_FORMACION(ID_MODALIDAD_FORMACION)
        If _mListaSUPERVISION_AF Is Nothing Then Return -1
        Me.ListaSUPERVISION_AFBindingSource.DataSource = _mListaSUPERVISION_AF
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla SUPERVISION_AF
    ''' filtrado por la tabla ACCION_FORMATIVA
    ''' </summary>
    ''' <param name="ID_ACCION_FORMATIVA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorACCION_FORMATIVA(ByVal ID_ACCION_FORMATIVA As Decimal) As Integer
        _mListaSUPERVISION_AF = Me.mComponente.ObtenerListaPorACCION_FORMATIVA(ID_ACCION_FORMATIVA)
        If _mListaSUPERVISION_AF Is Nothing Then Return -1
        Me.ListaSUPERVISION_AFBindingSource.DataSource = _mListaSUPERVISION_AF
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
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Eliminar() As Integer
        If Not Me.ListaSUPERVISION_AFBindingSource.Current Is Nothing Then
            If Me.Current.ID_SUPERVISION_AF = 0 Then Return 0
        End If
        If MyBase.Eliminar() = 0 Then Return 0
        If Not Me.ListaSUPERVISION_AFBindingSource.Current Is Nothing Then
            If mComponente.EliminarSUPERVISION_AF( Me.Current.ID_SUPERVISION_AF) <> 1 Then
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
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Guardar() As Integer
        If MyBase.Guardar() = 0 Then
            Return 0
        End If
        If Not Me.ListaSUPERVISION_AFBindingSource.Current Is Nothing Then
            Me.ListaSUPERVISION_AFBindingSource.EndEdit()
            If Not Me.Current.IsDirty Then Return 0
            Select Case mComponente.ActualizarSUPERVISION_AF(Me.Current)
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

    Private Sub ListaSUPERVISION_AFBindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles ListaSUPERVISION_AFBindingSource.AddingNew
        Dim lEntidad As New SUPERVISION_AF
        e.NewObject = lEntidad
    End Sub

    Private Sub ListaSUPERVISION_AFBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaSUPERVISION_AFBindingSource.PositionChanged
        RaiseEvent CambioRegistro()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Sobreecribe el ancestro de PermitirAgregar y configura el Grid
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Sub OnPermitirAgregar()
        Me.ListaSUPERVISION_AFDataGridView.AllowUserToAddRows = Me.PermitirAgregar
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Sobreecribe el ancestro de PermitirEliminar y configura el Grid
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Sub OnPermitirEliminar()
        Me.ListaSUPERVISION_AFDataGridView.AllowUserToDeleteRows = Me.PermitirEliminar
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Sobreecribe el ancestro de VerToolBar y reubica el Grid dependiendo
    ''' de si se oculta o pone visible la barra.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Sub OnVerToolbar()
        If Me.VerToolBar Then
            Me.ListaSUPERVISION_AFDataGridView.Dock = DockStyle.None
            Me.ListaSUPERVISION_AFDataGridView.Size = New Size(Me.Size.Width, Me.Size.Height - Me.ListaBindingNavigator.Size.Height)
            Me.ListaSUPERVISION_AFDataGridView.Location = New Point(1, Me.ListaBindingNavigator.Size.Height + 1)
        Else
            Me.ListaSUPERVISION_AFDataGridView.Dock = DockStyle.Fill
        End If
    End Sub

End Class
