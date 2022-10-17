Imports SGAFP.EL
Public Class ucListaUNIDAD_ORGANIZATIVA

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.ListaBindingNavigator.BindingSource = Me.ListaUNIDAD_ORGANIZATIVABindingSource
    End Sub

    Private _mComponente As cUNIDAD_ORGANIZATIVA
    Public ReadOnly Property mComponente() As cUNIDAD_ORGANIZATIVA
        Get
            If _mComponente Is Nothing Then
                _mComponente = New cUNIDAD_ORGANIZATIVA
            End If
            Return _mComponente
        End Get
    End Property

    Private _mListaUNIDAD_ORGANIZATIVA As New listaUNIDAD_ORGANIZATIVA
    Public Event CambioRegistro()
    Public Event Seleccionado(ByVal ID_UNIDAD_ORGANIZATIVA As Decimal) 

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

    Private _VerID_UNIDAD_ORGANIZATIVA As Boolean = True
    <DefaultValue(True)> _
    Public Property VerID_UNIDAD_ORGANIZATIVA() As Boolean
        Get
            Return Me._VerID_UNIDAD_ORGANIZATIVA
        End Get
        Set(ByVal value As Boolean)
            Me._VerID_UNIDAD_ORGANIZATIVA = value
            Me.colID_UNIDAD_ORGANIZATIVA.Visible = value
        End Set
    End Property

    Private _VerNOMBRE_UNIDAD As Boolean = True
    <DefaultValue(True)> _
    Public Property VerNOMBRE_UNIDAD() As Boolean
        Get
            Return Me._VerNOMBRE_UNIDAD
        End Get
        Set(ByVal value As Boolean)
            Me._VerNOMBRE_UNIDAD = value
            Me.colNOMBRE_UNIDAD.Visible = value
        End Set
    End Property

    Private _VerCODIGO_UNIDAD As Boolean = True
    <DefaultValue(True)> _
    Public Property VerCODIGO_UNIDAD() As Boolean
        Get
            Return Me._VerCODIGO_UNIDAD
        End Get
        Set(ByVal value As Boolean)
            Me._VerCODIGO_UNIDAD = value
            Me.colCODIGO_UNIDAD.Visible = value
        End Set
    End Property

    Private _VerID_UNIDAD_PADRE As Boolean = True
    <DefaultValue(True)> _
    Public Property VerID_UNIDAD_PADRE() As Boolean
        Get
            Return Me._VerID_UNIDAD_PADRE
        End Get
        Set(ByVal value As Boolean)
            Me._VerID_UNIDAD_PADRE = value
            Me.colID_UNIDAD_PADRE.Visible = value
        End Set
    End Property

    Private _VerESTADO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerESTADO() As Boolean
        Get
            Return Me._VerESTADO
        End Get
        Set(ByVal value As Boolean)
            Me._VerESTADO = value
            Me.colESTADO.Visible = value
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

    Public ReadOnly Property Current() As UNIDAD_ORGANIZATIVA
        Get
            Return CType(Me.ListaUNIDAD_ORGANIZATIVABindingSource.Current, UNIDAD_ORGANIZATIVA)
        End Get
    End Property

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla UNIDAD_ORGANIZATIVA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        _mListaUNIDAD_ORGANIZATIVA = Me.mComponente.ObtenerLista()
        If _mListaUNIDAD_ORGANIZATIVA Is Nothing Then Return -1
        Me.ListaUNIDAD_ORGANIZATIVABindingSource.DataSource = _mListaUNIDAD_ORGANIZATIVA
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
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Eliminar() As Integer
        If Not Me.ListaUNIDAD_ORGANIZATIVABindingSource.Current Is Nothing Then
            If Me.Current.ID_UNIDAD_ORGANIZATIVA = 0 Then Return 0
        End If
        If MyBase.Eliminar() = 0 Then Return 0
        If Not Me.ListaUNIDAD_ORGANIZATIVABindingSource.Current Is Nothing Then
            If mComponente.EliminarUNIDAD_ORGANIZATIVA(Me.Current.ID_UNIDAD_ORGANIZATIVA) <> 1 Then
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
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Guardar() As Integer
        If MyBase.Guardar() = 0 Then
            Return 0
        End If
        If Not Me.ListaUNIDAD_ORGANIZATIVABindingSource.Current Is Nothing Then
            Me.ListaUNIDAD_ORGANIZATIVABindingSource.EndEdit()
            If Not Me.Current.IsDirty Then Return 0
            Select Case mComponente.ActualizarUNIDAD_ORGANIZATIVA(Me.Current)
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

    Private Sub ListaUNIDAD_ORGANIZATIVABindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles ListaUNIDAD_ORGANIZATIVABindingSource.AddingNew
        Dim lEntidad As New UNIDAD_ORGANIZATIVA
        e.NewObject = lEntidad
    End Sub

    Private Sub ListaUNIDAD_ORGANIZATIVABindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaUNIDAD_ORGANIZATIVABindingSource.PositionChanged
        RaiseEvent CambioRegistro()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Sobreecribe el ancestro de PermitirAgregar y configura el Grid
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Sub OnPermitirAgregar()
        Me.ListaUNIDAD_ORGANIZATIVAGridView.OptionsBehavior.AllowAddRows = Me.PermitirAgregar
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Sobreecribe el ancestro de PermitirEliminar y configura el Grid
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Sub OnPermitirEliminar()
        Me.ListaUNIDAD_ORGANIZATIVAGridView.OptionsBehavior.AllowDeleteRows = Me.PermitirEliminar
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Sobreecribe el ancestro de VerToolBar y reubica el Grid dependiendo
    ''' de si se oculta o pone visible la barra.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Sub OnVerToolbar()
        If Me.VerToolBar Then
            Me.ListaUNIDAD_ORGANIZATIVAGridControl.Dock = DockStyle.None
            Me.ListaUNIDAD_ORGANIZATIVAGridControl.Size = New Size(Me.Size.Width, Me.Size.Height - Me.ListaBindingNavigator.Size.Height)
            Me.ListaUNIDAD_ORGANIZATIVAGridControl.Location = New Point(1, Me.ListaBindingNavigator.Size.Height + 1)
        Else
            Me.ListaUNIDAD_ORGANIZATIVAGridControl.Dock = DockStyle.Fill
        End If
    End Sub

End Class
