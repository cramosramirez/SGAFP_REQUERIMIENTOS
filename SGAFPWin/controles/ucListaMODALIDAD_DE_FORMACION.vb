Imports SGAFP.EL
Public Class ucListaMODALIDAD_DE_FORMACION

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.ListaBindingNavigator.BindingSource = Me.ListaMODALIDAD_DE_FORMACIONBindingSource
    End Sub

    Private _mComponente As cMODALIDAD_DE_FORMACION
    Public ReadOnly Property mComponente() As cMODALIDAD_DE_FORMACION
        Get
            If _mComponente Is Nothing Then
                _mComponente = New cMODALIDAD_DE_FORMACION
            End If
            Return _mComponente
        End Get
    End Property

    Private _mListaMODALIDAD_DE_FORMACION As New listaMODALIDAD_DE_FORMACION
    Public Event CambioRegistro()
    Public Event Seleccionado(ByVal ID_MODALIDAD_FORMACION As Decimal) 

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

    Private _VerID_MODALIDAD_FORMACION As Boolean = True
    <DefaultValue(True)> _
    Public Property VerID_MODALIDAD_FORMACION() As Boolean
        Get
            Return Me._VerID_MODALIDAD_FORMACION
        End Get
        Set(ByVal value As Boolean)
            Me._VerID_MODALIDAD_FORMACION = value
            Me.colID_MODALIDAD_FORMACION.Visible = value
        End Set
    End Property

    Private _VerMODALIDAD_FORMACION As Boolean = True
    <DefaultValue(True)> _
    Public Property VerMODALIDAD_FORMACION() As Boolean
        Get
            Return Me._VerMODALIDAD_FORMACION
        End Get
        Set(ByVal value As Boolean)
            Me._VerMODALIDAD_FORMACION = value
            Me.colMODALIDAD_FORMACION.Visible = value
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
            Me.colNOTAS.Visible = value
        End Set
    End Property

    #End Region

    Public ReadOnly Property Current() As MODALIDAD_DE_FORMACION
        Get
            Return CType(Me.ListaMODALIDAD_DE_FORMACIONBindingSource.Current, MODALIDAD_DE_FORMACION)
        End Get
    End Property

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla MODALIDAD_DE_FORMACION
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        _mListaMODALIDAD_DE_FORMACION = Me.mComponente.ObtenerLista()
        If _mListaMODALIDAD_DE_FORMACION Is Nothing Then Return -1
        Me.ListaMODALIDAD_DE_FORMACIONBindingSource.DataSource = _mListaMODALIDAD_DE_FORMACION
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
        If Not Me.ListaMODALIDAD_DE_FORMACIONBindingSource.Current Is Nothing Then
            If Me.Current.ID_MODALIDAD_FORMACION = 0 Then Return 0
        End If
        If MyBase.Eliminar() = 0 Then Return 0
        If Not Me.ListaMODALIDAD_DE_FORMACIONBindingSource.Current Is Nothing Then
            If mComponente.EliminarMODALIDAD_DE_FORMACION(Me.Current.ID_MODALIDAD_FORMACION) <> 1 Then
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
        If Not Me.ListaMODALIDAD_DE_FORMACIONBindingSource.Current Is Nothing Then
            Me.ListaMODALIDAD_DE_FORMACIONBindingSource.EndEdit()
            If Not Me.Current.IsDirty Then Return 0
            Select Case mComponente.ActualizarMODALIDAD_DE_FORMACION(Me.Current)
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

    Private Sub ListaMODALIDAD_DE_FORMACIONBindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles ListaMODALIDAD_DE_FORMACIONBindingSource.AddingNew
        Dim lEntidad As New MODALIDAD_DE_FORMACION
        e.NewObject = lEntidad
    End Sub

    Private Sub ListaMODALIDAD_DE_FORMACIONBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaMODALIDAD_DE_FORMACIONBindingSource.PositionChanged
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
        Me.ListaMODALIDAD_DE_FORMACIONGridView.OptionsBehavior.AllowAddRows = Me.PermitirAgregar
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
        Me.ListaMODALIDAD_DE_FORMACIONGridView.OptionsBehavior.AllowDeleteRows = Me.PermitirEliminar
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
            Me.ListaMODALIDAD_DE_FORMACIONGridControl.Dock = DockStyle.None
            Me.ListaMODALIDAD_DE_FORMACIONGridControl.Size = New Size(Me.Size.Width, Me.Size.Height - Me.ListaBindingNavigator.Size.Height)
            Me.ListaMODALIDAD_DE_FORMACIONGridControl.Location = New Point(1, Me.ListaBindingNavigator.Size.Height + 1)
        Else
            Me.ListaMODALIDAD_DE_FORMACIONGridControl.Dock = DockStyle.Fill
        End If
    End Sub

End Class
