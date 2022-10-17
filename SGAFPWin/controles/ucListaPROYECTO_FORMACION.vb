Imports SGAFP.EL
Public Class ucListaPROYECTO_FORMACION

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.ListaBindingNavigator.BindingSource = Me.ListaPROYECTO_FORMACIONBindingSource
    End Sub

    Private _mComponente As cPROYECTO_FORMACION
    Public ReadOnly Property mComponente() As cPROYECTO_FORMACION
        Get
            If _mComponente Is Nothing Then
                _mComponente = New cPROYECTO_FORMACION
            End If
            Return _mComponente
        End Get
    End Property

    Private _mListaPROYECTO_FORMACION As New listaPROYECTO_FORMACION
    Public Event CambioRegistro()
    Public Event Seleccionado(ByVal ID_PROYECTO_FORMACION As Decimal) 

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

    Private _VerID_PROYECTO_FORMACION As Boolean = True
    <DefaultValue(True)> _
    Public Property VerID_PROYECTO_FORMACION() As Boolean
        Get
            Return Me._VerID_PROYECTO_FORMACION
        End Get
        Set(ByVal value As Boolean)
            Me._VerID_PROYECTO_FORMACION = value
            Me.colID_PROYECTO_FORMACION.Visible = value
        End Set
    End Property

    Private _VerNOMBRE_PROYECTO_FORMACION As Boolean = True
    <DefaultValue(True)> _
    Public Property VerNOMBRE_PROYECTO_FORMACION() As Boolean
        Get
            Return Me._VerNOMBRE_PROYECTO_FORMACION
        End Get
        Set(ByVal value As Boolean)
            Me._VerNOMBRE_PROYECTO_FORMACION = value
            Me.colNOMBRE_PROYECTO_FORMACION.Visible = value
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

    Public ReadOnly Property Current() As PROYECTO_FORMACION
        Get
            Return CType(Me.ListaPROYECTO_FORMACIONBindingSource.Current, PROYECTO_FORMACION)
        End Get
    End Property

    Public Function TieneSolicitudCapacitacion() As Boolean
        'Verificar si el referente está asociado a una Solicitud de Capacitacion
        If Not Me.Current Is Nothing Then
            Dim listaSolicitudes As listaSOLICITUD_CAPACITACION = (New cSOLICITUD_CAPACITACION).ObtenerListaPorPROYECTO_FORMACION(Me.Current.ID_PROYECTO_FORMACION)
            Dim tieneSolicitud As Boolean = False
            If listaSolicitudes IsNot Nothing AndAlso listaSolicitudes.Count > 0 Then
                Return True
            End If
        End If
        Return False
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla PROYECTO_FORMACION
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        _mListaPROYECTO_FORMACION = Me.mComponente.ObtenerLista()
        If _mListaPROYECTO_FORMACION Is Nothing Then Return -1
        Me.ListaPROYECTO_FORMACIONBindingSource.DataSource = _mListaPROYECTO_FORMACION
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
        If Not Me.ListaPROYECTO_FORMACIONBindingSource.Current Is Nothing Then
            If Me.Current.ID_PROYECTO_FORMACION = 0 Then Return 0
        End If
        If MyBase.Eliminar() = 0 Then Return 0
        If Not Me.ListaPROYECTO_FORMACIONBindingSource.Current Is Nothing Then
            If mComponente.EliminarPROYECTO_FORMACION(Me.Current, TipoConcurrencia.Pesimistica) <> 1 Then
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
        If Not Me.ListaPROYECTO_FORMACIONBindingSource.Current Is Nothing Then
            'Validar Entidad
            Dim lEntidad As PROYECTO_FORMACION
            lEntidad = Me.ListaPROYECTO_FORMACIONBindingSource.Current
            If lEntidad.NOMBRE_PROYECTO_FORMACION Is Nothing OrElse lEntidad.NOMBRE_PROYECTO_FORMACION.Trim = String.Empty Then
                Me.sError = "Nombre del Proyecto de Formación es obligatorio."
                Return -1
            End If

            Me.ListaPROYECTO_FORMACIONBindingSource.EndEdit()

            Dim listaProyectos As listaPROYECTO_FORMACION = CType(ListaPROYECTO_FORMACIONBindingSource.DataSource, listaPROYECTO_FORMACION)
            Dim bProyectos As New cPROYECTO_FORMACION
            For Each lProyecto As PROYECTO_FORMACION In listaProyectos
                If lProyecto.IsDirty Then
                    Select Case mComponente.ActualizarPROYECTO_FORMACION(Me.Current, TipoConcurrencia.Pesimistica)
                        Case -1
                            Me.sError = "Suceso desconocido."
                            Return -1
                        Case 0
                            Me.sError = "Registro fue modificado por otro usuario antes de guardar. Recupere nuevamente los registros."
                            Return -2
                    End Select
                    lProyecto.IsDirty = False
                End If
            Next
        End If
        Return 0
    End Function

    Private Sub ListaPROYECTO_FORMACIONBindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles ListaPROYECTO_FORMACIONBindingSource.AddingNew
        Dim lEntidad As New PROYECTO_FORMACION
        e.NewObject = lEntidad
    End Sub

    Private Sub ListaPROYECTO_FORMACIONBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaPROYECTO_FORMACIONBindingSource.PositionChanged
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
        Me.ListaPROYECTO_FORMACIONGridView.OptionsBehavior.AllowAddRows = Me.PermitirAgregar
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
        Me.ListaPROYECTO_FORMACIONGridView.OptionsBehavior.AllowDeleteRows = Me.PermitirEliminar
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
            Me.ListaPROYECTO_FORMACIONGridControl.Dock = DockStyle.None
            Me.ListaPROYECTO_FORMACIONGridControl.Size = New Size(Me.Size.Width, Me.Size.Height - Me.ListaBindingNavigator.Size.Height)
            Me.ListaPROYECTO_FORMACIONGridControl.Location = New Point(1, Me.ListaBindingNavigator.Size.Height + 1)
        Else
            Me.ListaPROYECTO_FORMACIONGridControl.Dock = DockStyle.Fill
        End If
    End Sub


    Private _PermitirEditarGrid As Boolean = False
    <DefaultValue(False)> _
    Public Property PermitirEditarGrid() As Boolean
        Get
            Return Me._PermitirEditarGrid
        End Get
        Set(ByVal value As Boolean)
            For Each columna As DevExpress.XtraGrid.Columns.GridColumn In Me.ListaPROYECTO_FORMACIONGridView.Columns
                columna.OptionsColumn.AllowEdit = value
            Next
        End Set
    End Property
End Class
