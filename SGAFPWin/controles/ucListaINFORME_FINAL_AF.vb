Imports SGAFP.EL
Public Class ucListaINFORME_FINAL_AF

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.ListaBindingNavigator.BindingSource = Me.ListaINFORME_FINAL_AFBindingSource
    End Sub

    Private mComponente As New cINFORME_FINAL_AF
    Private _mListaINFORME_FINAL_AF As New listaINFORME_FINAL_AF
    Public Event CambioRegistro()
    Public Event Seleccionado(ByVal ID_INFORME_FINAL As Decimal) 

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

    Private _VerID_INFORME_FINAL As Boolean = True
    <DefaultValue(True)> _
    Public Property VerID_INFORME_FINAL() As Boolean
        Get
            Return Me._VerID_INFORME_FINAL
        End Get
        Set(ByVal value As Boolean)
            Me._VerID_INFORME_FINAL = value
            Me.DataGridViewTextBoxID_INFORME_FINAL.Visible = value
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

    Private _VerID_PROVEEDOR_AF As Boolean = True
    <DefaultValue(True)> _
    Public Property VerID_PROVEEDOR_AF() As Boolean
        Get
            Return Me._VerID_PROVEEDOR_AF
        End Get
        Set(ByVal value As Boolean)
            Me._VerID_PROVEEDOR_AF = value
            Me.DataGridViewTextBoxID_PROVEEDOR_AF.Visible = value
        End Set
    End Property

    Private _VerFECHA_INFORME As Boolean = True
    <DefaultValue(True)> _
    Public Property VerFECHA_INFORME() As Boolean
        Get
            Return Me._VerFECHA_INFORME
        End Get
        Set(ByVal value As Boolean)
            Me._VerFECHA_INFORME = value
            Me.DataGridViewTextBoxFECHA_INFORME.Visible = value
        End Set
    End Property

    Private _VerNUMERO_FACTURA As Boolean = True
    <DefaultValue(True)> _
    Public Property VerNUMERO_FACTURA() As Boolean
        Get
            Return Me._VerNUMERO_FACTURA
        End Get
        Set(ByVal value As Boolean)
            Me._VerNUMERO_FACTURA = value
            Me.DataGridViewTextBoxNUMERO_FACTURA.Visible = value
        End Set
    End Property

    Private _VerELABORADO_POR As Boolean = True
    <DefaultValue(True)> _
    Public Property VerELABORADO_POR() As Boolean
        Get
            Return Me._VerELABORADO_POR
        End Get
        Set(ByVal value As Boolean)
            Me._VerELABORADO_POR = value
            Me.DataGridViewTextBoxELABORADO_POR.Visible = value
        End Set
    End Property

    Private _VerMONTO_FACTURA As Boolean = True
    <DefaultValue(True)> _
    Public Property VerMONTO_FACTURA() As Boolean
        Get
            Return Me._VerMONTO_FACTURA
        End Get
        Set(ByVal value As Boolean)
            Me._VerMONTO_FACTURA = value
            Me.DataGridViewTextBoxMONTO_FACTURA.Visible = value
        End Set
    End Property

    Private _VerMONTO_APROBADO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerMONTO_APROBADO() As Boolean
        Get
            Return Me._VerMONTO_APROBADO
        End Get
        Set(ByVal value As Boolean)
            Me._VerMONTO_APROBADO = value
            Me.DataGridViewTextBoxMONTO_APROBADO.Visible = value
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

    Private _VerPARTICIPANTES_FINALES As Boolean = True
    <DefaultValue(True)> _
    Public Property VerPARTICIPANTES_FINALES() As Boolean
        Get
            Return Me._VerPARTICIPANTES_FINALES
        End Get
        Set(ByVal value As Boolean)
            Me._VerPARTICIPANTES_FINALES = value
            Me.DataGridViewTextBoxPARTICIPANTES_FINALES.Visible = value
        End Set
    End Property

    Private _VerPORC_PROM_ASISTENCIA As Boolean = True
    <DefaultValue(True)> _
    Public Property VerPORC_PROM_ASISTENCIA() As Boolean
        Get
            Return Me._VerPORC_PROM_ASISTENCIA
        End Get
        Set(ByVal value As Boolean)
            Me._VerPORC_PROM_ASISTENCIA = value
            Me.DataGridViewTextBoxPORC_PROM_ASISTENCIA.Visible = value
        End Set
    End Property

    Private _VerNOTA_PROMEDIO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerNOTA_PROMEDIO() As Boolean
        Get
            Return Me._VerNOTA_PROMEDIO
        End Get
        Set(ByVal value As Boolean)
            Me._VerNOTA_PROMEDIO = value
            Me.DataGridViewTextBoxNOTA_PROMEDIO.Visible = value
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
            Me.DataGridViewTextBoxESTADO.Visible = value
        End Set
    End Property

    Private _VerCOMENTARIOS As Boolean = True
    <DefaultValue(True)> _
    Public Property VerCOMENTARIOS() As Boolean
        Get
            Return Me._VerCOMENTARIOS
        End Get
        Set(ByVal value As Boolean)
            Me._VerCOMENTARIOS = value
            Me.DataGridViewTextBoxCOMENTARIOS.Visible = value
        End Set
    End Property

    Private _VerUSUARIO_APROBACION As Boolean = True
    <DefaultValue(True)> _
    Public Property VerUSUARIO_APROBACION() As Boolean
        Get
            Return Me._VerUSUARIO_APROBACION
        End Get
        Set(ByVal value As Boolean)
            Me._VerUSUARIO_APROBACION = value
            Me.DataGridViewTextBoxUSUARIO_APROBACION.Visible = value
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
            Me.DataGridViewTextBoxUSERID.Visible = value
        End Set
    End Property

    Private _VerLASTUDATE As Boolean = True
    <DefaultValue(True)> _
    Public Property VerLASTUDATE() As Boolean
        Get
            Return Me._VerLASTUDATE
        End Get
        Set(ByVal value As Boolean)
            Me._VerLASTUDATE = value
            Me.DataGridViewTextBoxLASTUDATE.Visible = value
        End Set
    End Property

    #End Region

    Public ReadOnly Property Current() As INFORME_FINAL_AF
        Get
            Return CType(Me.ListaINFORME_FINAL_AFBindingSource.Current, INFORME_FINAL_AF)
        End Get
    End Property

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla INFORME_FINAL_AF
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        _mListaINFORME_FINAL_AF = Me.mComponente.ObtenerLista()
        If _mListaINFORME_FINAL_AF Is Nothing Then Return -1
        Me.ListaINFORME_FINAL_AFBindingSource.DataSource = _mListaINFORME_FINAL_AF
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla INFORME_FINAL_AF
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
        _mListaINFORME_FINAL_AF = Me.mComponente.ObtenerListaPorACCION_FORMATIVA(ID_ACCION_FORMATIVA)
        If _mListaINFORME_FINAL_AF Is Nothing Then Return -1
        Me.ListaINFORME_FINAL_AFBindingSource.DataSource = _mListaINFORME_FINAL_AF
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla INFORME_FINAL_AF
    ''' filtrado por la tabla PROVEEDOR_AF
    ''' </summary>
    ''' <param name="ID_PROVEEDOR_AF"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorPROVEEDOR_AF(ByVal ID_PROVEEDOR_AF As Decimal) As Integer
        _mListaINFORME_FINAL_AF = Me.mComponente.ObtenerListaPorPROVEEDOR_AF(ID_PROVEEDOR_AF)
        If _mListaINFORME_FINAL_AF Is Nothing Then Return -1
        Me.ListaINFORME_FINAL_AFBindingSource.DataSource = _mListaINFORME_FINAL_AF
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
        If Not Me.ListaINFORME_FINAL_AFBindingSource.Current Is Nothing Then
            If Me.Current.ID_INFORME_FINAL = 0 Then Return 0
        End If
        If MyBase.Eliminar() = 0 Then Return 0
        If Not Me.ListaINFORME_FINAL_AFBindingSource.Current Is Nothing Then
            If mComponente.EliminarINFORME_FINAL_AF( Me.Current.ID_INFORME_FINAL) <> 1 Then
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
        If Not Me.ListaINFORME_FINAL_AFBindingSource.Current Is Nothing Then
            Me.ListaINFORME_FINAL_AFBindingSource.EndEdit()
            If Not Me.Current.IsDirty Then Return 0
            Select Case mComponente.ActualizarINFORME_FINAL_AF(Me.Current)
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

    Private Sub ListaINFORME_FINAL_AFBindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles ListaINFORME_FINAL_AFBindingSource.AddingNew
        Dim lEntidad As New INFORME_FINAL_AF
        e.NewObject = lEntidad
    End Sub

    Private Sub ListaINFORME_FINAL_AFBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaINFORME_FINAL_AFBindingSource.PositionChanged
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
        Me.ListaINFORME_FINAL_AFDataGridView.AllowUserToAddRows = Me.PermitirAgregar
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
        Me.ListaINFORME_FINAL_AFDataGridView.AllowUserToDeleteRows = Me.PermitirEliminar
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
            Me.ListaINFORME_FINAL_AFDataGridView.Dock = DockStyle.None
            Me.ListaINFORME_FINAL_AFDataGridView.Size = New Size(Me.Size.Width, Me.Size.Height - Me.ListaBindingNavigator.Size.Height)
            Me.ListaINFORME_FINAL_AFDataGridView.Location = New Point(1, Me.ListaBindingNavigator.Size.Height + 1)
        Else
            Me.ListaINFORME_FINAL_AFDataGridView.Dock = DockStyle.Fill
        End If
    End Sub

End Class
