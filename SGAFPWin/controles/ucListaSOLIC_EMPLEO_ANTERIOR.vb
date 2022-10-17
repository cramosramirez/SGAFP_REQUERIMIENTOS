Imports SGAFP.EL
Public Class ucListaSOLIC_EMPLEO_ANTERIOR

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.ListaBindingNavigator.BindingSource = Me.ListaSOLIC_EMPLEO_ANTERIORBindingSource
    End Sub

    Private mComponente As New cSOLIC_EMPLEO_ANTERIOR
    Private _mListaSOLIC_EMPLEO_ANTERIOR As New listaSOLIC_EMPLEO_ANTERIOR
    Public Event CambioRegistro()
    Public Event Seleccionado(ByVal ID_EMPLEO_ANT As Decimal) 

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

    Private _VerID_EMPLEO_ANT As Boolean = True
    <DefaultValue(True)> _
    Public Property VerID_EMPLEO_ANT() As Boolean
        Get
            Return Me._VerID_EMPLEO_ANT
        End Get
        Set(ByVal value As Boolean)
            Me._VerID_EMPLEO_ANT = value
            Me.DataGridViewTextBoxID_EMPLEO_ANT.Visible = value
        End Set
    End Property

    Private _VerID_SOLICITUD As Boolean = True
    <DefaultValue(True)> _
    Public Property VerID_SOLICITUD() As Boolean
        Get
            Return Me._VerID_SOLICITUD
        End Get
        Set(ByVal value As Boolean)
            Me._VerID_SOLICITUD = value
            Me.DataGridViewTextBoxID_SOLICITUD.Visible = value
        End Set
    End Property

    Private _VerNOMBRE_EMPRESA As Boolean = True
    <DefaultValue(True)> _
    Public Property VerNOMBRE_EMPRESA() As Boolean
        Get
            Return Me._VerNOMBRE_EMPRESA
        End Get
        Set(ByVal value As Boolean)
            Me._VerNOMBRE_EMPRESA = value
            Me.DataGridViewTextBoxNOMBRE_EMPRESA.Visible = value
        End Set
    End Property

    Private _VerDIRECCION As Boolean = True
    <DefaultValue(True)> _
    Public Property VerDIRECCION() As Boolean
        Get
            Return Me._VerDIRECCION
        End Get
        Set(ByVal value As Boolean)
            Me._VerDIRECCION = value
            Me.DataGridViewTextBoxDIRECCION.Visible = value
        End Set
    End Property

    Private _VerZONA As Boolean = True
    <DefaultValue(True)> _
    Public Property VerZONA() As Boolean
        Get
            Return Me._VerZONA
        End Get
        Set(ByVal value As Boolean)
            Me._VerZONA = value
            Me.DataGridViewTextBoxZONA.Visible = value
        End Set
    End Property

    Private _VerTELEFONO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerTELEFONO() As Boolean
        Get
            Return Me._VerTELEFONO
        End Get
        Set(ByVal value As Boolean)
            Me._VerTELEFONO = value
            Me.DataGridViewTextBoxTELEFONO.Visible = value
        End Set
    End Property

    Private _VerFAX As Boolean = True
    <DefaultValue(True)> _
    Public Property VerFAX() As Boolean
        Get
            Return Me._VerFAX
        End Get
        Set(ByVal value As Boolean)
            Me._VerFAX = value
            Me.DataGridViewTextBoxFAX.Visible = value
        End Set
    End Property

    Private _VerEMAIL As Boolean = True
    <DefaultValue(True)> _
    Public Property VerEMAIL() As Boolean
        Get
            Return Me._VerEMAIL
        End Get
        Set(ByVal value As Boolean)
            Me._VerEMAIL = value
            Me.DataGridViewTextBoxEMAIL.Visible = value
        End Set
    End Property

    Private _VerISSS As Boolean = True
    <DefaultValue(True)> _
    Public Property VerISSS() As Boolean
        Get
            Return Me._VerISSS
        End Get
        Set(ByVal value As Boolean)
            Me._VerISSS = value
            Me.DataGridViewTextBoxISSS.Visible = value
        End Set
    End Property

    Private _VerJEFE_INMEDIATO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerJEFE_INMEDIATO() As Boolean
        Get
            Return Me._VerJEFE_INMEDIATO
        End Get
        Set(ByVal value As Boolean)
            Me._VerJEFE_INMEDIATO = value
            Me.DataGridViewTextBoxJEFE_INMEDIATO.Visible = value
        End Set
    End Property

    Private _VerACTIVIDAD_ECONOMICA As Boolean = True
    <DefaultValue(True)> _
    Public Property VerACTIVIDAD_ECONOMICA() As Boolean
        Get
            Return Me._VerACTIVIDAD_ECONOMICA
        End Get
        Set(ByVal value As Boolean)
            Me._VerACTIVIDAD_ECONOMICA = value
            Me.DataGridViewTextBoxACTIVIDAD_ECONOMICA.Visible = value
        End Set
    End Property

    Private _VerPUESTO_CONTRATADO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerPUESTO_CONTRATADO() As Boolean
        Get
            Return Me._VerPUESTO_CONTRATADO
        End Get
        Set(ByVal value As Boolean)
            Me._VerPUESTO_CONTRATADO = value
            Me.DataGridViewTextBoxPUESTO_CONTRATADO.Visible = value
        End Set
    End Property

    Private _VerPUESTO_ACTUAL As Boolean = True
    <DefaultValue(True)> _
    Public Property VerPUESTO_ACTUAL() As Boolean
        Get
            Return Me._VerPUESTO_ACTUAL
        End Get
        Set(ByVal value As Boolean)
            Me._VerPUESTO_ACTUAL = value
            Me.DataGridViewTextBoxPUESTO_ACTUAL.Visible = value
        End Set
    End Property

    Private _VerTIEMPO_TRABAJO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerTIEMPO_TRABAJO() As Boolean
        Get
            Return Me._VerTIEMPO_TRABAJO
        End Get
        Set(ByVal value As Boolean)
            Me._VerTIEMPO_TRABAJO = value
            Me.DataGridViewTextBoxTIEMPO_TRABAJO.Visible = value
        End Set
    End Property

    Private _VerAREA_TRABAJO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerAREA_TRABAJO() As Boolean
        Get
            Return Me._VerAREA_TRABAJO
        End Get
        Set(ByVal value As Boolean)
            Me._VerAREA_TRABAJO = value
            Me.DataGridViewTextBoxAREA_TRABAJO.Visible = value
        End Set
    End Property

    Private _VerAREA_OTRO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerAREA_OTRO() As Boolean
        Get
            Return Me._VerAREA_OTRO
        End Get
        Set(ByVal value As Boolean)
            Me._VerAREA_OTRO = value
            Me.DataGridViewTextBoxAREA_OTRO.Visible = value
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
            Me.DataGridViewTextBoxCODIGO_MUNICIPIO.Visible = value
        End Set
    End Property

    Private _VerCODIGO_REGION As Boolean = True
    <DefaultValue(True)> _
    Public Property VerCODIGO_REGION() As Boolean
        Get
            Return Me._VerCODIGO_REGION
        End Get
        Set(ByVal value As Boolean)
            Me._VerCODIGO_REGION = value
            Me.DataGridViewTextBoxCODIGO_REGION.Visible = value
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
            Me.DataGridViewTextBoxCODIGO_DEPARTAMENTO.Visible = value
        End Set
    End Property

    #End Region

    Public ReadOnly Property Current() As SOLIC_EMPLEO_ANTERIOR
        Get
            Return CType(Me.ListaSOLIC_EMPLEO_ANTERIORBindingSource.Current, SOLIC_EMPLEO_ANTERIOR)
        End Get
    End Property

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla SOLIC_EMPLEO_ANTERIOR
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        _mListaSOLIC_EMPLEO_ANTERIOR = Me.mComponente.ObtenerLista()
        If _mListaSOLIC_EMPLEO_ANTERIOR Is Nothing Then Return -1
        Me.ListaSOLIC_EMPLEO_ANTERIORBindingSource.DataSource = _mListaSOLIC_EMPLEO_ANTERIOR
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla SOLIC_EMPLEO_ANTERIOR
    ''' filtrado por la tabla SOLICITUD_INSCRIPCION_AF
    ''' </summary>
    ''' <param name="ID_SOLICITUD"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorSOLICITUD_INSCRIPCION_AF(ByVal ID_SOLICITUD As Decimal) As Integer
        _mListaSOLIC_EMPLEO_ANTERIOR = Me.mComponente.ObtenerListaPorSOLICITUD_INSCRIPCION_AF(ID_SOLICITUD)
        If _mListaSOLIC_EMPLEO_ANTERIOR Is Nothing Then Return -1
        Me.ListaSOLIC_EMPLEO_ANTERIORBindingSource.DataSource = _mListaSOLIC_EMPLEO_ANTERIOR
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
        If Not Me.ListaSOLIC_EMPLEO_ANTERIORBindingSource.Current Is Nothing Then
            If Me.Current.ID_EMPLEO_ANT = 0 Then Return 0
        End If
        If MyBase.Eliminar() = 0 Then Return 0
        If Not Me.ListaSOLIC_EMPLEO_ANTERIORBindingSource.Current Is Nothing Then
            If mComponente.EliminarSOLIC_EMPLEO_ANTERIOR( Me.Current.ID_EMPLEO_ANT) <> 1 Then
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
        If Not Me.ListaSOLIC_EMPLEO_ANTERIORBindingSource.Current Is Nothing Then
            Me.ListaSOLIC_EMPLEO_ANTERIORBindingSource.EndEdit()
            If Not Me.Current.IsDirty Then Return 0
            Select Case mComponente.ActualizarSOLIC_EMPLEO_ANTERIOR(Me.Current)
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

    Private Sub ListaSOLIC_EMPLEO_ANTERIORBindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles ListaSOLIC_EMPLEO_ANTERIORBindingSource.AddingNew
        Dim lEntidad As New SOLIC_EMPLEO_ANTERIOR
        e.NewObject = lEntidad
    End Sub

    Private Sub ListaSOLIC_EMPLEO_ANTERIORBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaSOLIC_EMPLEO_ANTERIORBindingSource.PositionChanged
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
        Me.ListaSOLIC_EMPLEO_ANTERIORDataGridView.AllowUserToAddRows = Me.PermitirAgregar
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
        Me.ListaSOLIC_EMPLEO_ANTERIORDataGridView.AllowUserToDeleteRows = Me.PermitirEliminar
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
            Me.ListaSOLIC_EMPLEO_ANTERIORDataGridView.Dock = DockStyle.None
            Me.ListaSOLIC_EMPLEO_ANTERIORDataGridView.Size = New Size(Me.Size.Width, Me.Size.Height - Me.ListaBindingNavigator.Size.Height)
            Me.ListaSOLIC_EMPLEO_ANTERIORDataGridView.Location = New Point(1, Me.ListaBindingNavigator.Size.Height + 1)
        Else
            Me.ListaSOLIC_EMPLEO_ANTERIORDataGridView.Dock = DockStyle.Fill
        End If
    End Sub

End Class
