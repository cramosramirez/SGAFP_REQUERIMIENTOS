Imports SGAFP.EL
Public Class ucListaREFERENTE

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.ListaBindingNavigator.BindingSource = Me.ListaREFERENTEBindingSource
    End Sub

    Private _mComponente As cREFERENTE
    Public ReadOnly Property mComponente() As cREFERENTE
        Get
            If _mComponente Is Nothing Then
                _mComponente = New cREFERENTE
            End If
            Return _mComponente
        End Get
    End Property

    Private _mListaREFERENTE As New listaREFERENTE
    Public Event CambioRegistro()
    Public Event Seleccionado(ByVal ID_REFERENTE As Decimal) 

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

    Private _PermitirEditarGrid As Boolean = False
    <DefaultValue(False)> _
    Public Property PermitirEditarGrid() As Boolean
        Get
            Return Me._PermitirEditarGrid
        End Get
        Set(ByVal value As Boolean)
            For Each columna As DevExpress.XtraGrid.Columns.GridColumn In Me.ListaREFERENTEGridView.Columns
                columna.OptionsColumn.AllowEdit = value
            Next
        End Set
    End Property

    Private _VerID_REFERENTE As Boolean = True
    <DefaultValue(True)> _
    Public Property VerID_REFERENTE() As Boolean
        Get
            Return Me._VerID_REFERENTE
        End Get
        Set(ByVal value As Boolean)
            Me._VerID_REFERENTE = value
            Me.colID_REFERENTE.Visible = value
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

    Private _VerNOMBRE_REFERENTE As Boolean = True
    <DefaultValue(True)> _
    Public Property VerNOMBRE_REFERENTE() As Boolean
        Get
            Return Me._VerNOMBRE_REFERENTE
        End Get
        Set(ByVal value As Boolean)
            Me._VerNOMBRE_REFERENTE = value
            Me.colNOMBRE_REFERENTE.Visible = value
        End Set
    End Property

    Private _VerDIRECCION_REFERENTE As Boolean = True
    <DefaultValue(True)> _
    Public Property VerDIRECCION_REFERENTE() As Boolean
        Get
            Return Me._VerDIRECCION_REFERENTE
        End Get
        Set(ByVal value As Boolean)
            Me._VerDIRECCION_REFERENTE = value
            Me.colDIRECCION_REFERENTE.Visible = value
        End Set
    End Property

    Private _VerTELEF1 As Boolean = True
    <DefaultValue(True)> _
    Public Property VerTELEF1() As Boolean
        Get
            Return Me._VerTELEF1
        End Get
        Set(ByVal value As Boolean)
            Me._VerTELEF1 = value
            Me.colTELEF1.Visible = value
        End Set
    End Property

    Private _VerTELEF2 As Boolean = True
    <DefaultValue(True)> _
    Public Property VerTELEF2() As Boolean
        Get
            Return Me._VerTELEF2
        End Get
        Set(ByVal value As Boolean)
            Me._VerTELEF2 = value
            Me.colTELEF2.Visible = value
        End Set
    End Property

    Private _VerTELEF3 As Boolean = True
    <DefaultValue(True)> _
    Public Property VerTELEF3() As Boolean
        Get
            Return Me._VerTELEF3
        End Get
        Set(ByVal value As Boolean)
            Me._VerTELEF3 = value
            Me.colTELEF3.Visible = value
        End Set
    End Property

    Private _VerTELEF_MOVIL As Boolean = True
    <DefaultValue(True)> _
    Public Property VerTELEF_MOVIL() As Boolean
        Get
            Return Me._VerTELEF_MOVIL
        End Get
        Set(ByVal value As Boolean)
            Me._VerTELEF_MOVIL = value
            Me.colTELEF_MOVIL.Visible = value
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
            Me.colFAX.Visible = value
        End Set
    End Property

    Private _VerNOMBRE_CONTACTO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerNOMBRE_CONTACTO() As Boolean
        Get
            Return Me._VerNOMBRE_CONTACTO
        End Get
        Set(ByVal value As Boolean)
            Me._VerNOMBRE_CONTACTO = value
            Me.colNOMBRE_CONTACTO.Visible = value
        End Set
    End Property

    Private _VerAPELLIDOS_CONTACTO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerAPELLIDOS_CONTACTO() As Boolean
        Get
            Return Me._VerAPELLIDOS_CONTACTO
        End Get
        Set(ByVal value As Boolean)
            Me._VerAPELLIDOS_CONTACTO = value
            Me.colAPELLIDOS_CONTACTO.Visible = value
        End Set
    End Property

    Private _VerEMAIL_CONTACTO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerEMAIL_CONTACTO() As Boolean
        Get
            Return Me._VerEMAIL_CONTACTO
        End Get
        Set(ByVal value As Boolean)
            Me._VerEMAIL_CONTACTO = value
            Me.colEMAIL_CONTACTO.Visible = value
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

    Public ReadOnly Property Current() As REFERENTE
        Get
            Return CType(Me.ListaREFERENTEBindingSource.Current, REFERENTE)
        End Get
    End Property

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla REFERENTE
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        _mListaREFERENTE = Me.mComponente.ObtenerLista()
        If _mListaREFERENTE Is Nothing Then Return -1
        Me.ListaREFERENTEBindingSource.DataSource = _mListaREFERENTE
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla REFERENTE
    ''' filtrado por la tabla DEPARTAMENTO
    ''' </summary>
    ''' <param name="CODIGO_DEPARTAMENTO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorDEPARTAMENTO(ByVal CODIGO_DEPARTAMENTO As String) As Integer
        _mListaREFERENTE = Me.mComponente.ObtenerListaPorDEPARTAMENTO(CODIGO_DEPARTAMENTO)
        If _mListaREFERENTE Is Nothing Then Return -1
        Me.ListaREFERENTEBindingSource.DataSource = _mListaREFERENTE
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla REFERENTE
    ''' filtrado por la tabla MUNICIPIO
    ''' </summary>
    ''' <param name="CODIGO_DEPARTAMENTO"></param>
    ''' <param name="CODIGO_MUNICIPIO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorMUNICIPIO(ByVal CODIGO_DEPARTAMENTO As String, ByVal CODIGO_MUNICIPIO As String) As Integer
        _mListaREFERENTE = Me.mComponente.ObtenerListaPorMUNICIPIO(CODIGO_DEPARTAMENTO, CODIGO_MUNICIPIO)
        If _mListaREFERENTE Is Nothing Then Return -1
        Me.ListaREFERENTEBindingSource.DataSource = _mListaREFERENTE
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
        If Not Me.ListaREFERENTEBindingSource.Current Is Nothing Then
            If Me.Current.ID_REFERENTE = 0 Then Return 0
        End If
        If MyBase.Eliminar() = 0 Then Return 0
        If Not Me.ListaREFERENTEBindingSource.Current Is Nothing Then
            If mComponente.EliminarREFERENTE(Me.Current.ID_REFERENTE) <> 1 Then
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
        Me.ListaREFERENTEBindingSource.EndEdit()
        Dim listaReferentes As listaREFERENTE = CType(ListaREFERENTEBindingSource.DataSource, listaREFERENTE)
        Dim bReferente As New cREFERENTE
        For Each lReferente As REFERENTE In listaReferentes
            If lReferente.IsDirty Then
                'Validar Entidad
                If lReferente.CODIGO_DEPARTAMENTO Is Nothing OrElse lReferente.CODIGO_DEPARTAMENTO = String.Empty Then
                    Me.sError = "El Departamento es obligatorio para el referente " + lReferente.NOMBRE_REFERENTE
                    Return -1
                End If
                If lReferente.CODIGO_MUNICIPIO Is Nothing OrElse lReferente.CODIGO_MUNICIPIO = String.Empty Then
                    Me.sError = "El Municipio es obligatorio para el referente " + lReferente.NOMBRE_REFERENTE
                    Return -1
                End If
                If lReferente.NOMBRE_REFERENTE Is Nothing OrElse lReferente.NOMBRE_REFERENTE.Trim = String.Empty Then
                    Me.sError = "El Nombre del Referente es obligatorio"
                    Return -1
                End If
                If lReferente.DIRECCION_REFERENTE Is Nothing OrElse lReferente.DIRECCION_REFERENTE.Trim = String.Empty Then
                    Me.sError = "La Dirección es obligatoria para el referente " + lReferente.NOMBRE_REFERENTE
                    Return -1
                End If
                If lReferente.TELEF1 Is Nothing OrElse lReferente.TELEF1.Trim = String.Empty Then
                    Me.sError = "Teléfono 1 es obligatorio para el referente " + lReferente.NOMBRE_REFERENTE
                    Return -1
                ElseIf lReferente.TELEF1.Length < 8 Then
                    Me.sError = "Teléfono 1 no es válido para el referente " + lReferente.NOMBRE_REFERENTE
                    Return -1
                End If
                If lReferente.TELEF2 IsNot Nothing AndAlso lReferente.TELEF2.Length < 8 Then
                    Me.sError = "Teléfono 2 no es válido para el referente " + lReferente.NOMBRE_REFERENTE
                    Return -1
                End If
                If lReferente.TELEF3 IsNot Nothing AndAlso lReferente.TELEF3.Length < 8 Then
                    Me.sError = "Teléfono 3 no es válido para el referente " + lReferente.NOMBRE_REFERENTE
                    Return -1
                End If
                If lReferente.NOMBRE_CONTACTO Is Nothing OrElse lReferente.NOMBRE_CONTACTO.Trim = String.Empty Then
                    Me.sError = "Nombres del Contacto son obligatorios para el referente " + lReferente.NOMBRE_REFERENTE
                    Return -1
                End If
                If lReferente.APELLIDOS_CONTACTO Is Nothing OrElse lReferente.APELLIDOS_CONTACTO.Trim = String.Empty Then
                    Me.sError = "Apellidos del Contacto son obligatorios para el referente " + lReferente.NOMBRE_REFERENTE
                    Return -1
                End If
                If lReferente.EMAIL_CONTACTO Is Nothing OrElse lReferente.EMAIL_CONTACTO.Trim = String.Empty Then
                    Me.sError = "Email del Contacto son obligatorios para el referente " + lReferente.NOMBRE_REFERENTE
                    Return -1
                End If

                Select Case mComponente.ActualizarREFERENTE(Me.Current, TipoConcurrencia.Pesimistica)
                    Case -1
                        Me.sError = "Suceso desconocido."
                        Return -1
                    Case 0
                        Me.sError = "Registro fue modificado por otro usuario antes de guardar. Recupere nuevamente los registros."
                        Return -2
                End Select
                lReferente.IsDirty = False
            End If
        Next
        Return 0
    End Function

    Public Function TieneSolicitudCapacitacion() As Boolean
        'Verificar si el referente está asociado a una Solicitud de Capacitacion
        If Not Me.Current Is Nothing Then
            Dim listaSolicitudes As listaSOLICITUD_CAPACITACION = (New cSOLICITUD_CAPACITACION).ObtenerListaPorREFERENTE(Me.Current.ID_REFERENTE)
            Dim tieneSolicitud As Boolean = False
            If listaSolicitudes IsNot Nothing AndAlso listaSolicitudes.Count > 0 Then
                Return True
            End If
        End If
        Return False
    End Function

    Private Sub ListaREFERENTEBindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles ListaREFERENTEBindingSource.AddingNew
        Dim lEntidad As New REFERENTE
        e.NewObject = lEntidad
    End Sub

    Private Sub ListaREFERENTEBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaREFERENTEBindingSource.PositionChanged
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
        Me.ListaREFERENTEGridView.OptionsBehavior.AllowAddRows = Me.PermitirAgregar
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
        Me.ListaREFERENTEGridView.OptionsBehavior.AllowDeleteRows = Me.PermitirEliminar
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
            Me.ListaREFERENTEGridControl.Dock = DockStyle.None
            Me.ListaREFERENTEGridControl.Size = New Size(Me.Size.Width, Me.Size.Height - Me.ListaBindingNavigator.Size.Height)
            Me.ListaREFERENTEGridControl.Location = New Point(1, Me.ListaBindingNavigator.Size.Height + 1)
        Else
            Me.ListaREFERENTEGridControl.Dock = DockStyle.Fill
        End If
    End Sub

    Private Sub ListaREFERENTEGridView_CustomUnboundColumnData(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs) Handles ListaREFERENTEGridView.CustomUnboundColumnData
        If e.Column Is colDEPARTAMENTO Then
            Dim eEntidad As REFERENTE = CType(e.Row, REFERENTE)
            If eEntidad IsNot Nothing AndAlso eEntidad.CODIGO_DEPARTAMENTO <> "" Then
                e.Value = (New cDEPARTAMENTO).ObtenerDEPARTAMENTO(eEntidad.CODIGO_DEPARTAMENTO).NOMBRE
            End If
        ElseIf e.Column Is colMUNICIPIO Then
            Dim eEntidad As REFERENTE = CType(e.Row, REFERENTE)
            If eEntidad IsNot Nothing AndAlso eEntidad.CODIGO_MUNICIPIO <> "" Then
                e.Value = (New cMUNICIPIO).ObtenerMUNICIPIO(eEntidad.CODIGO_DEPARTAMENTO, eEntidad.CODIGO_MUNICIPIO).NOMBRE
            End If
        End If
    End Sub
End Class
