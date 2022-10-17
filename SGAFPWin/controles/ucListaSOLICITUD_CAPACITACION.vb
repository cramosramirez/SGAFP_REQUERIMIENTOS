Imports SGAFP.EL
Imports SIFP.BL
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraEditors

Public Class ucListaSOLICITUD_CAPACITACION

    Dim lIdGrupoSolicitudSeleccionado As Decimal = 0
    Dim lIdFocusedRowHandle As Decimal = 0
    Private clone As DataView = Nothing

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.ListaBindingNavigator.Items.Add("Buscar", My.Resources.view, New EventHandler(AddressOf BuscarSolicitudes))
        'Me.ListaBindingNavigator.Items.Add("Agregar Grupo", My.Resources.aprobar, New EventHandler(AddressOf AgregarGrupo))
        'Me.ListaBindingNavigator.Items.Add("Eliminar Grupo", My.Resources.aprobar, New EventHandler(AddressOf EliminarGrupo))

        ' Add any initialization after the InitializeComponent() call.
        Me.ListaBindingNavigator.BindingSource = Me.ListaSOLICITUD_CAPACITACIONBindingSource
    End Sub

    'ByVal sender As Object, ByVal e As EventArgs
    Public Sub AgregarGrupo()
        If Me.Current IsNot Nothing Then
            If Me.Current.GRUPO_SOLICITUD_SOLICITUD_CAPACITACION Is Nothing Then Me.Current.GRUPO_SOLICITUD_SOLICITUD_CAPACITACION = New listaGRUPO_SOLICITUD
            Me.ListaGRUPO_SOLICITUDBindingSource.AddNew()
            Me.ListaSOLICITUD_CAPACITACIONGridView.ExpandMasterRow(Me.ListaSOLICITUD_CAPACITACIONGridView.GetSelectedRows(0))
        End If
    End Sub

    Private Sub BuscarSolicitudes(ByVal sender As Object, ByVal e As EventArgs)
        Dim lIdReferente As Decimal = -1
        Dim lIdProyecto As Decimal = -1
        Dim lFechaSolicitud As New System.Nullable(Of Date)
        Dim lTDR As String = ""

        If CbxREFERENTE1.SelectedValue IsNot Nothing Then lIdReferente = CbxREFERENTE1.SelectedValue
        If CbxPROYECTO_FORMACION1.SelectedValue IsNot Nothing Then lIdProyecto = CbxPROYECTO_FORMACION1.SelectedValue
        If dteFechaSolicitud.DateTime <> #12:00:00 AM# Then lFechaSolicitud = dteFechaSolicitud.DateTime
        If txtTDR.Text <> "" Then lTDR = txtTDR.Text
        Me.CargarDatosPorCriterios(lIdReferente, lIdProyecto, lFechaSolicitud, lTDR)
    End Sub

    'ByVal sender As Object, ByVal e As EventArgs
    Public Function EliminarGrupo() As Integer
        If Not Me.ListaSOLICITUD_CAPACITACIONBindingSource.Current Is Nothing Then
            If lIdGrupoSolicitudSeleccionado > 0 Then
                Dim bGrupoSolicitud As New cGRUPO_SOLICITUD
                Dim lGrupoSolicitud As GRUPO_SOLICITUD = bGrupoSolicitud.ObtenerGRUPO_SOLICITUD(lIdGrupoSolicitudSeleccionado)
                If lGrupoSolicitud IsNot Nothing Then
                    If lGrupoSolicitud.TDR.Trim <> "" Then
                        AsignarMensaje("El Grupo tiene asociado un Término de Referencia. No se puede eliminar", True)
                        Return -1
                    End If
                    bGrupoSolicitud.EliminarGRUPO_SOLICITUD(lIdGrupoSolicitudSeleccionado)
                    CType(Me.ListaSOLICITUD_CAPACITACIONBindingSource.Current, SOLICITUD_CAPACITACION).GRUPO_SOLICITUD_SOLICITUD_CAPACITACION.Remove(lGrupoSolicitud)
                End If
            Else
                Dim listaGrupos As New listaGRUPO_SOLICITUD
                listaGrupos = CType(Me.ListaSOLICITUD_CAPACITACIONBindingSource.Current, SOLICITUD_CAPACITACION).GRUPO_SOLICITUD_SOLICITUD_CAPACITACION
                If listaGrupos IsNot Nothing AndAlso listaGrupos.Count > 0 Then
                    listaGrupos.RemoveAt(lIdFocusedRowHandle)
                    CType(Me.ListaSOLICITUD_CAPACITACIONBindingSource.Current, SOLICITUD_CAPACITACION).GRUPO_SOLICITUD_SOLICITUD_CAPACITACION = listaGrupos
                End If
            End If
        End If
    End Function

    Private _mComponente As cSOLICITUD_CAPACITACION
    Public ReadOnly Property mComponente() As cSOLICITUD_CAPACITACION
        Get
            If _mComponente Is Nothing Then
                _mComponente = New cSOLICITUD_CAPACITACION
            End If
            Return _mComponente
        End Get
    End Property

    Private _mListaSOLICITUD_CAPACITACION As New listaSOLICITUD_CAPACITACION
    Public Event CambioRegistro()
    Public Event MostrarGruposCapacitacion()
    Public Event Seleccionado(ByVal ID_SOLICITUD As Decimal)

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

    Private _VerID_SOLICITUD As Boolean = True
    <DefaultValue(True)> _
    Public Property VerID_SOLICITUD() As Boolean
        Get
            Return Me._VerID_SOLICITUD
        End Get
        Set(ByVal value As Boolean)
            Me._VerID_SOLICITUD = value
            Me.colID_SOLICITUD.Visible = value
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

    Private _VerID_CENTRO_RESPONSABILIDAD As Boolean = True
    <DefaultValue(True)> _
    Public Property VerID_CENTRO_RESPONSABILIDAD() As Boolean
        Get
            Return Me._VerID_CENTRO_RESPONSABILIDAD
        End Get
        Set(ByVal value As Boolean)
            Me._VerID_CENTRO_RESPONSABILIDAD = value
            Me.colID_CENTRO_RESPONSABILIDAD.Visible = value
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

    Private _VerID_PROGRAMA_FORMACION As Boolean = True
    <DefaultValue(True)> _
    Public Property VerID_PROGRAMA_FORMACION() As Boolean
        Get
            Return Me._VerID_PROGRAMA_FORMACION
        End Get
        Set(ByVal value As Boolean)
            Me._VerID_PROGRAMA_FORMACION = value
            Me.colID_PROGRAMA_FORMACION.Visible = value
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

    Private _VerFECHA_SOLICITUD As Boolean = True
    <DefaultValue(True)> _
    Public Property VerFECHA_SOLICITUD() As Boolean
        Get
            Return Me._VerFECHA_SOLICITUD
        End Get
        Set(ByVal value As Boolean)
            Me._VerFECHA_SOLICITUD = value
            Me.colFECHA_SOLICITUD.Visible = value
        End Set
    End Property

    Private _VerOBJETIVO_CAPACITACION As Boolean = True
    <DefaultValue(True)> _
    Public Property VerOBJETIVO_CAPACITACION() As Boolean
        Get
            Return Me._VerOBJETIVO_CAPACITACION
        End Get
        Set(ByVal value As Boolean)
            Me._VerOBJETIVO_CAPACITACION = value
            Me.colOBJETIVO_CAPACITACION.Visible = value
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
            Me.colHORARIO.Visible = value
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

    Private _VerNOMBRES_CONTACTO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerNOMBRES_CONTACTO() As Boolean
        Get
            Return Me._VerNOMBRES_CONTACTO
        End Get
        Set(ByVal value As Boolean)
            Me._VerNOMBRES_CONTACTO = value
            Me.colNOMBRES_CONTACTO.Visible = value
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

    Public ReadOnly Property Current() As SOLICITUD_CAPACITACION
        Get
            Return CType(Me.ListaSOLICITUD_CAPACITACIONBindingSource.Current, SOLICITUD_CAPACITACION)
        End Get
    End Property

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla SOLICITUD_CAPACITACION
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        _mListaSOLICITUD_CAPACITACION = Me.mComponente.ObtenerLista()
        If _mListaSOLICITUD_CAPACITACION Is Nothing Then Return -1
        CargarGruposSolicitud(_mListaSOLICITUD_CAPACITACION)
        Me.ListaSOLICITUD_CAPACITACIONBindingSource.DataSource = _mListaSOLICITUD_CAPACITACION
        Return 1
    End Function

    Private Sub CargarGruposSolicitud(ByRef lista As listaSOLICITUD_CAPACITACION)
        Dim bGrupoSolicitud As New cGRUPO_SOLICITUD
        For i As Integer = 0 To lista.Count - 1
            Dim listaGrupos As listaGRUPO_SOLICITUD = bGrupoSolicitud.ObtenerListaPorSOLICITUD_CAPACITACION(_mListaSOLICITUD_CAPACITACION(i).ID_SOLICITUD)
            If listaGrupos IsNot Nothing Then
                lista(i).GRUPO_SOLICITUD_SOLICITUD_CAPACITACION = listaGrupos
            End If
        Next
    End Sub

    Public Function TieneAsociadaTDR() As Boolean
        'Verificar si al solicitud está asociada a un TDR
        If Not Me.Current Is Nothing Then
            Dim listaGrupos As listaGRUPO_SOLICITUD = (New cGRUPO_SOLICITUD).ObtenerListaPorSOLICITUD_CAPACITACION(Me.Current.ID_SOLICITUD)
            Dim conAsociacionTDR As Boolean = False
            If listaGrupos IsNot Nothing AndAlso listaGrupos.Count > 0 Then
                For Each lEntidad As GRUPO_SOLICITUD In listaGrupos
                    If lEntidad.TDR IsNot Nothing AndAlso lEntidad.TDR <> "" Then
                        Return True
                    End If
                Next
            End If
        End If
        Return False
    End Function

    Public Function GrupoTieneAsociadoTDR(ByVal ID_GRUPO_SOLICITUD As Decimal) As Boolean
        'Verificar si al solicitud está asociada a un TDR
        Dim lEntidadGrupo As GRUPO_SOLICITUD
        lEntidadGrupo = (New cGRUPO_SOLICITUD).ObtenerGRUPO_SOLICITUD(ID_GRUPO_SOLICITUD)
        If lEntidadGrupo IsNot Nothing Then
            If lEntidadGrupo.TDR IsNot Nothing AndAlso lEntidadGrupo.TDR <> "" Then
                Return True
            End If
        End If
        Return False
    End Function


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla SOLICITUD_CAPACITACION
    ''' filtrado por la tabla REFERENTE
    ''' </summary>
    ''' <param name="ID_REFERENTE"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorREFERENTE(ByVal ID_REFERENTE As Decimal) As Integer
        _mListaSOLICITUD_CAPACITACION = Me.mComponente.ObtenerListaPorREFERENTE(ID_REFERENTE)
        If _mListaSOLICITUD_CAPACITACION Is Nothing Then Return -1
        CargarGruposSolicitud(_mListaSOLICITUD_CAPACITACION)
        Me.ListaSOLICITUD_CAPACITACIONBindingSource.DataSource = _mListaSOLICITUD_CAPACITACION
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla SOLICITUD_CAPACITACION
    ''' filtrado por la tabla CENTRO_RESPONSABILIDAD
    ''' </summary>
    ''' <param name="ID_CENTRO_RESPONSABILIDAD"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorCENTRO_RESPONSABILIDAD(ByVal ID_CENTRO_RESPONSABILIDAD As Decimal) As Integer
        _mListaSOLICITUD_CAPACITACION = Me.mComponente.ObtenerListaPorCENTRO_RESPONSABILIDAD(ID_CENTRO_RESPONSABILIDAD)
        If _mListaSOLICITUD_CAPACITACION Is Nothing Then Return -1
        CargarGruposSolicitud(_mListaSOLICITUD_CAPACITACION)
        Me.ListaSOLICITUD_CAPACITACIONBindingSource.DataSource = _mListaSOLICITUD_CAPACITACION
        Return 1
    End Function


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla SOLICITUD_CAPACITACION
    ''' filtrado por criterios
    ''' </summary>
    ''' <param name="ID_SOLICITUD"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	19/06/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorIdSolicitud(ByVal ID_SOLICITUD As Decimal) As Integer
        Dim lEntidad As SOLICITUD_CAPACITACION = Me.mComponente.ObtenerSOLICITUD_CAPACITACION(ID_SOLICITUD)
        If lEntidad IsNot Nothing Then
            _mListaSOLICITUD_CAPACITACION = New listaSOLICITUD_CAPACITACION
            _mListaSOLICITUD_CAPACITACION.Add(lEntidad)
            CargarGruposSolicitud(_mListaSOLICITUD_CAPACITACION)
            Me.ListaSOLICITUD_CAPACITACIONBindingSource.DataSource = _mListaSOLICITUD_CAPACITACION
            Return 1
        End If
        Return -1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla SOLICITUD_CAPACITACION
    ''' filtrado por criterios
    ''' </summary>
    ''' <param name="ID_REFERENTE"></param>
    ''' <param name="ID_PROYECTO_FORMACION"></param>
    ''' <param name="FECHA_SOLICITUD"></param>
    ''' <param name="TDR"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	15/02/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorCriterios(ByVal ID_REFERENTE As Decimal, ByVal ID_PROYECTO_FORMACION As Decimal, ByVal FECHA_SOLICITUD As System.Nullable(Of Date), ByVal TDR As String) As Integer
        _mListaSOLICITUD_CAPACITACION = Me.mComponente.ObtenerListaPorCriterios(ID_REFERENTE, ID_PROYECTO_FORMACION, FECHA_SOLICITUD, TDR)
        If _mListaSOLICITUD_CAPACITACION Is Nothing Then Return -1
        CargarGruposSolicitud(_mListaSOLICITUD_CAPACITACION)
        Me.ListaSOLICITUD_CAPACITACIONBindingSource.DataSource = _mListaSOLICITUD_CAPACITACION
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla SOLICITUD_CAPACITACION
    ''' filtrado por criterios
    ''' </summary>    
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	19/06/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorCriterios() As Integer
        Dim lFechaSolicitud As New System.Nullable(Of Date)
        If dteFechaSolicitud.DateTime <> #12:00:00 AM# Then lFechaSolicitud = dteFechaSolicitud.DateTime
        _mListaSOLICITUD_CAPACITACION = Me.mComponente.ObtenerListaPorCriterios(CbxREFERENTE1.SelectedValue, CbxPROYECTO_FORMACION1.SelectedValue, lFechaSolicitud, txtTDR.Text)
        If _mListaSOLICITUD_CAPACITACION Is Nothing Then Return -1
        CargarGruposSolicitud(_mListaSOLICITUD_CAPACITACION)
        Me.ListaSOLICITUD_CAPACITACIONBindingSource.DataSource = _mListaSOLICITUD_CAPACITACION
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla SOLICITUD_CAPACITACION
    ''' filtrado por la tabla UNIDAD_ORGANIZATIVA
    ''' </summary>
    ''' <param name="ID_UNIDAD_ORGANIZATIVA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorUNIDAD_ORGANIZATIVA(ByVal ID_UNIDAD_ORGANIZATIVA As Decimal) As Integer
        _mListaSOLICITUD_CAPACITACION = Me.mComponente.ObtenerListaPorUNIDAD_ORGANIZATIVA(ID_UNIDAD_ORGANIZATIVA)
        If _mListaSOLICITUD_CAPACITACION Is Nothing Then Return -1
        CargarGruposSolicitud(_mListaSOLICITUD_CAPACITACION)
        Me.ListaSOLICITUD_CAPACITACIONBindingSource.DataSource = _mListaSOLICITUD_CAPACITACION
        Return 1
    End Function

    ' ''' -----------------------------------------------------------------------------
    ' ''' <summary>
    ' ''' Función que Carga la información de los registros de la tabla SOLICITUD_CAPACITACION
    ' ''' filtrado por la tabla DEPARTAMENTO
    ' ''' </summary>
    ' ''' <param name="CODIGO_DEPARTAMENTO"></param>
    ' ''' <remarks>
    ' ''' </remarks>
    ' ''' <history>
    ' ''' 	[GenApp]	05/10/2012	Created
    ' ''' </history>
    ' ''' -----------------------------------------------------------------------------
    'Public Function CargarDatosPorDEPARTAMENTO(ByVal CODIGO_DEPARTAMENTO As String) As Integer
    '    _mListaSOLICITUD_CAPACITACION = Me.mComponente.ObtenerListaPorDEPARTAMENTO(CODIGO_DEPARTAMENTO)
    '    If _mListaSOLICITUD_CAPACITACION Is Nothing Then Return -1
    '    CargarGruposSolicitud(_mListaSOLICITUD_CAPACITACION)
    '    Me.ListaSOLICITUD_CAPACITACIONBindingSource.DataSource = _mListaSOLICITUD_CAPACITACION
    '    Return 1
    'End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla SOLICITUD_CAPACITACION
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
    'Public Function CargarDatosPorMUNICIPIO(ByVal CODIGO_DEPARTAMENTO As String, ByVal CODIGO_MUNICIPIO As String) As Integer
    '    _mListaSOLICITUD_CAPACITACION = Me.mComponente.ObtenerListaPorMUNICIPIO(CODIGO_DEPARTAMENTO, CODIGO_MUNICIPIO)
    '    If _mListaSOLICITUD_CAPACITACION Is Nothing Then Return -1
    '    CargarGruposSolicitud(_mListaSOLICITUD_CAPACITACION)
    '    Me.ListaSOLICITUD_CAPACITACIONBindingSource.DataSource = _mListaSOLICITUD_CAPACITACION
    '    Return 1
    'End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla SOLICITUD_CAPACITACION
    ''' filtrado por la tabla PROGRAMA_FORMACION
    ''' </summary>
    ''' <param name="ID_PROGRAMA_FORMACION"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorPROGRAMA_FORMACION(ByVal ID_PROGRAMA_FORMACION As Decimal) As Integer
        _mListaSOLICITUD_CAPACITACION = Me.mComponente.ObtenerListaPorPROGRAMA_FORMACION(ID_PROGRAMA_FORMACION)
        If _mListaSOLICITUD_CAPACITACION Is Nothing Then Return -1
        CargarGruposSolicitud(_mListaSOLICITUD_CAPACITACION)
        Me.ListaSOLICITUD_CAPACITACIONBindingSource.DataSource = _mListaSOLICITUD_CAPACITACION
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla SOLICITUD_CAPACITACION
    ''' filtrado por la tabla PROYECTO_FORMACION
    ''' </summary>
    ''' <param name="ID_PROYECTO_FORMACION"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorPROYECTO_FORMACION(ByVal ID_PROYECTO_FORMACION As Decimal) As Integer
        _mListaSOLICITUD_CAPACITACION = Me.mComponente.ObtenerListaPorPROYECTO_FORMACION(ID_PROYECTO_FORMACION)
        If _mListaSOLICITUD_CAPACITACION Is Nothing Then Return -1
        CargarGruposSolicitud(_mListaSOLICITUD_CAPACITACION)
        Me.ListaSOLICITUD_CAPACITACIONBindingSource.DataSource = _mListaSOLICITUD_CAPACITACION
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
        If Not Me.ListaSOLICITUD_CAPACITACIONBindingSource.Current Is Nothing Then
            If Me.Current.ID_SOLICITUD = 0 Then Return 0
            If TieneAsociadaTDR() Then
                Me.sError = "No es posible eliminar la Solicitud debido a que tiene Término de Referencia Asociado."
                Return -1
            End If
        End If
        If MyBase.Eliminar() = 0 Then Return 0
        If Not Me.ListaSOLICITUD_CAPACITACIONBindingSource.Current Is Nothing Then
            If Me.Current.GRUPO_SOLICITUD_SOLICITUD_CAPACITACION IsNot Nothing Then
                Dim bGrupoSolicitud As New cGRUPO_SOLICITUD
                For Each lGrupo As GRUPO_SOLICITUD In Me.Current.GRUPO_SOLICITUD_SOLICITUD_CAPACITACION
                    bGrupoSolicitud.EliminarGRUPO_SOLICITUD(lGrupo.ID_GRUPO_SOLICITUD)
                Next
            End If
            If mComponente.EliminarSOLICITUD_CAPACITACION(Me.Current, TipoConcurrencia.Pesimistica) <> 1 Then
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
        Dim regGuardado As Boolean = False
        If MyBase.Guardar() = 0 Then
            Return 0
        End If

        If Not Me.ListaSOLICITUD_CAPACITACIONBindingSource.Current Is Nothing Then
            Me.ListaSOLICITUD_CAPACITACIONBindingSource.EndEdit()
            Me.ListaGRUPO_SOLICITUDBindingSource.EndEdit()

            'Actualizar modificados
            Dim listaSolicitudes As listaSOLICITUD_CAPACITACION = CType(Me.ListaSOLICITUD_CAPACITACIONBindingSource.DataSource, listaSOLICITUD_CAPACITACION)
            Dim bGrupoSolicitud As New cGRUPO_SOLICITUD
            For Each lSolic As SOLICITUD_CAPACITACION In listaSolicitudes
                If lSolic.IsDirty Then
                    If lSolic.FECHA_SOLICITUD = #12:00:00 AM# Then
                        Me.sError = "Fecha de la Solicitud es obligatoria."
                        Return -1
                    End If
                    If lSolic.ID_UNIDAD_ORGANIZATIVA = -1 Then
                        Me.sError = "Unidad Organizativa es obligatoria."
                        Return -1
                    End If
                    If lSolic.ID_PROGRAMA_FORMACION = -1 Then
                        Me.sError = "Programa de Formación es obligatorio."
                        Return -1
                    End If
                    If lSolic.ID_PROYECTO_FORMACION = -1 Then
                        Me.sError = "Proyecto de Formación es obligatorio."
                        Return -1
                    End If
                    If lSolic.ID_REFERENTE = -1 Then
                        Me.sError = "Referente es obligatorio."
                        Return -1
                    End If
                    If lSolic.TELEF1 Is Nothing OrElse lSolic.TELEF1.Trim = String.Empty Then
                        Me.sError = "Teléfono 1 es obligatorio."
                        Return -1
                    End If
                    If lSolic.NOMBRES_CONTACTO Is Nothing OrElse lSolic.NOMBRES_CONTACTO.Trim = String.Empty Then
                        Me.sError = "Nombres del contacto es obligatorio."
                        Return -1
                    End If
                    If lSolic.APELLIDOS_CONTACTO Is Nothing OrElse lSolic.APELLIDOS_CONTACTO.Trim = String.Empty Then
                        Me.sError = "Apellidos del contacto es obligatorio."
                        Return -1
                    End If
                    If lSolic.EMAIL_CONTACTO Is Nothing OrElse lSolic.EMAIL_CONTACTO.Trim = String.Empty Then
                        Me.sError = "Email del contacto es obligatorio."
                        Return -1
                    End If
                    If lSolic.OBJETIVO_CAPACITACION Is Nothing OrElse lSolic.OBJETIVO_CAPACITACION.Trim = String.Empty Then
                        Me.sError = "Objetivo de la capacitación es obligatorio."
                        Return -1
                    End If
                    If lSolic.HORARIO Is Nothing OrElse lSolic.HORARIO.Trim = String.Empty Then
                        Me.sError = "Horario de la capacitación es obligatorio."
                        Return -1
                    End If

                    Select Case mComponente.ActualizarSOLICITUD_CAPACITACION(lSolic, TipoConcurrencia.Pesimistica)
                        Case -1
                            Me.sError = "Suceso desconocido al actualizar Solicitud."
                            Return -1
                        Case Else
                            regGuardado = True
                    End Select
                    lSolic.IsDirty = False
                End If
                If lSolic.GRUPO_SOLICITUD_SOLICITUD_CAPACITACION IsNot Nothing Then
                    For Each lGrupo As GRUPO_SOLICITUD In lSolic.GRUPO_SOLICITUD_SOLICITUD_CAPACITACION
                        If lGrupo.IsDirty Then
                            lGrupo.ID_SOLICITUD = lSolic.ID_SOLICITUD
                            Select Case bGrupoSolicitud.ActualizarGRUPO_SOLICITUD(lGrupo, TipoConcurrencia.Pesimistica)
                                Case -1
                                    Me.sError = "Suceso desconocido al actualizar Grupo de Capacitación."
                                    Return -1
                                Case Else
                                    regGuardado = True
                            End Select
                            lGrupo.IsDirty = False
                        End If
                    Next
                End If
            Next
        End If
        If regGuardado Then AsignarMensaje("Solicitud(es) guardada con éxito!")
        Return 0
    End Function

    Private Sub ListaSOLICITUD_CAPACITACIONBindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles ListaSOLICITUD_CAPACITACIONBindingSource.AddingNew
        Dim lEntidad As New SOLICITUD_CAPACITACION
        e.NewObject = lEntidad
    End Sub

    Private Sub ListaSOLICITUD_CAPACITACIONBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaSOLICITUD_CAPACITACIONBindingSource.PositionChanged
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
        Me.ListaSOLICITUD_CAPACITACIONGridView.OptionsBehavior.AllowAddRows = Me.PermitirAgregar
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
        Me.ListaSOLICITUD_CAPACITACIONGridView.OptionsBehavior.AllowDeleteRows = Me.PermitirEliminar
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
            Me.ListaSOLICITUD_CAPACITACIONGridControl.Dock = DockStyle.None
            Me.ListaSOLICITUD_CAPACITACIONGridControl.Size = New Size(Me.Size.Width, Me.Size.Height - Me.ListaBindingNavigator.Size.Height)
            Me.ListaSOLICITUD_CAPACITACIONGridControl.Location = New Point(1, Me.ListaBindingNavigator.Size.Height + 1)
        Else
            Me.ListaSOLICITUD_CAPACITACIONGridControl.Dock = DockStyle.Fill
        End If
    End Sub

    Private Sub ListaSOLICITUD_CAPACITACIONGridView_BeforeLeaveRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowAllowEventArgs) Handles ListaSOLICITUD_CAPACITACIONGridView.BeforeLeaveRow
        Me.ListaSOLICITUD_CAPACITACIONBindingSource.EndEdit()
    End Sub

    Private Sub ListaSOLICITUD_CAPACITACIONGridView_CustomUnboundColumnData(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs) Handles ListaSOLICITUD_CAPACITACIONGridView.CustomUnboundColumnData
        Dim lEntidad As SOLICITUD_CAPACITACION = CType(e.Row, SOLICITUD_CAPACITACION)
        If lEntidad IsNot Nothing Then
            If e.Column Is colUNIDAD_ORGANIZATIVA AndAlso lEntidad.ID_UNIDAD_ORGANIZATIVA > 0 Then
                e.Value = (New cUNIDAD_ORGANIZATIVA).ObtenerUNIDAD_ORGANIZATIVA(lEntidad.ID_UNIDAD_ORGANIZATIVA).NOMBRE_UNIDAD
            ElseIf e.Column Is colCENTRO_RESPONSABILIDAD AndAlso lEntidad.ID_CENTRO_RESPONSABILIDAD > 0 Then
                e.Value = (New cCENTRO_RESPONSABILIDAD).ObtenerCENTRO_RESPONSABILIDAD(lEntidad.ID_CENTRO_RESPONSABILIDAD).CODIGO_CENTRO_RESPONSABILIDAD
            ElseIf e.Column Is colPROYECTO_FORMACION AndAlso lEntidad.ID_PROYECTO_FORMACION > 0 Then
                e.Value = (New cPROYECTO_FORMACION).ObtenerPROYECTO_FORMACION(lEntidad.ID_PROYECTO_FORMACION).NOMBRE_PROYECTO_FORMACION
            ElseIf e.Column Is colNOMBRE_REFERENTE AndAlso lEntidad.ID_REFERENTE > 0 Then
                e.Value = (New cREFERENTE).ObtenerREFERENTE(lEntidad.ID_REFERENTE).NOMBRE_REFERENTE
            End If
        End If
    End Sub

    Private Sub Inicializar()
        Dim lista_Departamento As listaDEPARTAMENTO

        lista_Departamento = (New cDEPARTAMENTO).ObtenerLista(False, False, "NOMBRE")
        Me.DEPARTAMENTOBindingSource.DataSource = lista_Departamento
        Me.PermitirNavegacion = False
        Me.CbxREFERENTE1.Recuperar(False, True)
        Me.CbxPROYECTO_FORMACION1.Recuperar(False, True)
        Me.ListaMODALIDAD_FORMACIONBindingSource.DataSource = (New cMODALIDAD_DE_FORMACION).ObtenerLista
        Me.ListaPROGRAMASBindingSource.DataSource = (New cProgramas).ObtenerListaActivos
        Me.ListaSOLICITUD_CAPACITACIONBindingSource.DataSource = (New listaSOLICITUD_CAPACITACION)
    End Sub

    Private Sub ucListaSOLICITUD_CAPACITACION_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Inicializar()
    End Sub

    Private Sub ListaGRUPO_SOLICITUDGridView_CustomColumnDisplayText(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles ListaGRUPO_SOLICITUDGridView.CustomColumnDisplayText
        If e.Column.FieldName = "CODIGO_MUNICIPIO" Then
            Dim grid As DevExpress.XtraGrid.Views.Grid.GridView
            Dim lEntidad As GRUPO_SOLICITUD
            grid = CType(sender, DevExpress.XtraGrid.Views.Grid.GridView)
            lEntidad = CType(grid.GetRow(e.RowHandle), GRUPO_SOLICITUD)
            e.DisplayText = (New cMUNICIPIO).ObtenerMUNICIPIO(lEntidad.CODIGO_DEPARTAMENTO, lEntidad.CODIGO_MUNICIPIO).NOMBRE
        End If
    End Sub

    Private Sub ListaGRUPO_SOLICITUDGridView_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles ListaGRUPO_SOLICITUDGridView.FocusedRowChanged
        lIdGrupoSolicitudSeleccionado = CType(sender, GridView).GetFocusedRowCellValue("ID_GRUPO_SOLICITUD")
        lIdFocusedRowHandle = e.FocusedRowHandle
    End Sub

    Private Sub ListaGRUPO_SOLICITUDGridView_HiddenEditor(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaGRUPO_SOLICITUDGridView.HiddenEditor
        If clone IsNot Nothing Then
            clone.Dispose()
            clone = Nothing
        End If
    End Sub

    Private Sub ListaGRUPO_SOLICITUDGridView_ShownEditor(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaGRUPO_SOLICITUDGridView.ShownEditor
        Dim grid As DevExpress.XtraGrid.Views.Grid.GridView
        grid = CType(sender, DevExpress.XtraGrid.Views.Grid.GridView)
        If grid.FocusedColumn.FieldName = "CODIGO_MUNICIPIO" AndAlso TypeOf grid.ActiveEditor Is DevExpress.XtraEditors.GridLookUpEdit Then
            Dim edit As DevExpress.XtraEditors.GridLookUpEdit
            Dim bs As New BindingSource
            Dim fila As GRUPO_SOLICITUD

            edit = CType(grid.ActiveEditor, DevExpress.XtraEditors.GridLookUpEdit)
            fila = CType(grid.GetRow(grid.FocusedRowHandle), GRUPO_SOLICITUD)
            If fila IsNot Nothing Then
                If fila.CODIGO_DEPARTAMENTO IsNot Nothing Then
                    bs.DataSource = (New cMUNICIPIO).ObtenerLista(fila.CODIGO_DEPARTAMENTO, False, False, "NOMBRE")
                Else
                    bs.DataSource = New listaMUNICIPIO
                End If
                edit.Properties.DataSource = bs
            End If
        End If
    End Sub

    Private Sub ListaGRUPO_SOLICITUDGridView_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles ListaGRUPO_SOLICITUDGridView.ValidateRow
        Dim view As GridView = CType(sender, GridView)
        Dim cGrupo As GridColumn = view.Columns("ID_GRUPO_SOLICITUD")
        Dim cSolicitud As GridColumn = view.Columns("ID_SOLICITUD")
        Dim cModalidad As GridColumn = view.Columns("ID_MODALIDAD_FORMACION")
        Dim cCodigoPrograma As GridColumn = view.Columns("CODIGO_PROGRAMA")
        Dim cDuracion As GridColumn = view.Columns("DURACION_HORAS")
        Dim cCantidadParticipantes As GridColumn = view.Columns("NUM_PARTICIPANTES")
        Dim cTDR As GridColumn = view.Columns("TDR")
        Dim cCodigoDepartamento As GridColumn = view.Columns("CODIGO_DEPARTAMENTO")
        Dim cCodigoMunicipio As GridColumn = view.Columns("CODIGO_MUNICIPIO")
        Dim cLugarEjecucion As GridColumn = view.Columns("LUGAR_EJECUCION")
        Dim cNombreAccionFormativa As GridColumn = view.Columns("NOMBRE_ACCION_FORMATIVA")

        Dim lGrupo As String = CType(view.GetRowCellValue(e.RowHandle, colID_GRUPO_SOLICITUD), String)
        Dim lModalidad As String = CType(view.GetRowCellValue(e.RowHandle, colID_MODALIDAD_FORMACION), String)
        Dim lCodigoPrograma As String = CType(view.GetRowCellValue(e.RowHandle, colCODIGO_PROGRAMA), String)
        Dim lDuracion As String = CType(view.GetRowCellValue(e.RowHandle, colDURACION_HORAS), Integer)
        Dim lCantidadParticipantes As String = CType(view.GetRowCellValue(e.RowHandle, colNUM_PARTICIPANTES), Integer)
        Dim lTDR As String = CType(view.GetRowCellValue(e.RowHandle, colTDR), String)
        Dim lCodigoDepartamento As String = CType(view.GetRowCellValue(e.RowHandle, colCODIGO_DEPARTAMENTO1), String)
        Dim lCodigoMunicipio As String = CType(view.GetRowCellValue(e.RowHandle, colCODIGO_MUNICIPIO1), String)
        Dim lLugarEjecucion As String = CType(view.GetRowCellValue(e.RowHandle, colLUGAR_EJECUCION), String)
        Dim lNombreAccionFormativa As String = CType(view.GetRowCellValue(e.RowHandle, colNOMBRE_ACCION_FORMATIVA), String)

        If Not IsDBNull(lTDR) AndAlso lTDR <> String.Empty Then
            e.Valid = False
            view.SetColumnError(cTDR, "No se puede modificar el curso actual ya que tiene asignado un TDR")
            Return
        End If
        If IsDBNull(lModalidad) Then
            e.Valid = False
            view.SetColumnError(cModalidad, "Ingrese la Modalidad")
        End If
        If lCodigoPrograma = String.Empty OrElse IsDBNull(lCodigoPrograma) Then
            e.Valid = False
            view.SetColumnError(cCodigoPrograma, "Ingrese el Programa")
        End If
        If IsDBNull(lDuracion) OrElse CDec(lDuracion) = 0 Then
            e.Valid = False
            view.SetColumnError(cDuracion, "Ingrese la Duración en horas")
        End If
        If IsDBNull(lCantidadParticipantes) OrElse CDec(lCantidadParticipantes) = 0 Then
            e.Valid = False
            view.SetColumnError(cCantidadParticipantes, "Ingrese la Cantidad de Participantes")
        End If
        If lCodigoDepartamento = String.Empty OrElse IsDBNull(lCodigoDepartamento) Then
            e.Valid = False
            view.SetColumnError(cCodigoDepartamento, "Seleccione el Departamento")
        End If
        If lCodigoMunicipio = String.Empty OrElse IsDBNull(lCodigoMunicipio) Then
            e.Valid = False
            view.SetColumnError(cCodigoMunicipio, "Seleccione el Municipio")
        End If
        If lLugarEjecucion = String.Empty OrElse IsDBNull(lLugarEjecucion) Then
            e.Valid = False
            view.SetColumnError(cLugarEjecucion, "Ingrese el lugar de Ejecución")
        Else
            If lLugarEjecucion.Length > 255 Then
                e.Valid = False
                view.SetColumnError(cLugarEjecucion, "El Lugar de Ejecución sobrepasa el tamaño permitido")
            End If
        End If
        If lNombreAccionFormativa = String.Empty OrElse IsDBNull(lNombreAccionFormativa) Then
            e.Valid = False
            view.SetColumnError(cNombreAccionFormativa, "Ingrese el Nombre del Curso según solicitud")
        Else
            If lNombreAccionFormativa.Length > 150 Then
                e.Valid = False
                view.SetColumnError(cNombreAccionFormativa, "El Nombre del Curso sobrepasa el tamaño permitido")
            End If
        End If

        If e.Valid Then
            Dim bGrupoSolicitud As New cGRUPO_SOLICITUD
            Dim lEntidadGrupo As New GRUPO_SOLICITUD
            If CDec(lGrupo) = 0 Then
                lEntidadGrupo.ID_GRUPO_SOLICITUD = 0
            Else
                lEntidadGrupo.ID_GRUPO_SOLICITUD = CDec(lGrupo)
            End If
            lEntidadGrupo.ID_SOLICITUD = Me.Current.ID_SOLICITUD
            lEntidadGrupo.ID_MODALIDAD_FORMACION = lModalidad
            lEntidadGrupo.CODIGO_PROGRAMA = lCodigoPrograma.TrimEnd
            lEntidadGrupo.DURACION_HORAS = CDec(lDuracion)
            lEntidadGrupo.NUM_PARTICIPANTES = CDec(lCantidadParticipantes)
            lEntidadGrupo.USERID = Utilerias.ObtenerUsuario
            lEntidadGrupo.LASTUPDATE = Now
            lEntidadGrupo.CORRELATIVO_GRUPO = -1
            lEntidadGrupo.USUARIO_CREACION = Utilerias.ObtenerUsuario
            lEntidadGrupo.FECHA_CREACION = Now
            lEntidadGrupo.CODIGO_DEPARTAMENTO = lCodigoDepartamento
            lEntidadGrupo.CODIGO_MUNICIPIO = lCodigoMunicipio
            lEntidadGrupo.LUGAR_EJECUCION = lLugarEjecucion
            lEntidadGrupo.NOMBRE_ACCION_FORMATIVA = lNombreAccionFormativa
            If bGrupoSolicitud.ActualizarGRUPO_SOLICITUD(lEntidadGrupo, TipoConcurrencia.Pesimistica) <> 1 Then
                AsignarMensaje(bGrupoSolicitud.sError, True)
            Else
                view.SetRowCellValue(view.FocusedRowHandle, cSolicitud, lEntidadGrupo.ID_SOLICITUD)
                view.SetRowCellValue(view.FocusedRowHandle, cGrupo, lEntidadGrupo.ID_GRUPO_SOLICITUD)
            End If
        End If
    End Sub

    Private Sub ListaGRUPO_SOLICITUDBindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles ListaGRUPO_SOLICITUDBindingSource.AddingNew
        Dim lEntidad As New GRUPO_SOLICITUD
        lEntidad.LASTUPDATE = Now
        e.NewObject = lEntidad
    End Sub

    Private Sub RepositoryGRUPO_DEPARTAMENTO_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RepositoryGRUPO_DEPARTAMENTO.EditValueChanged
        Dim view As New DevExpress.XtraGrid.Views.Grid.GridView
        view.SetRowCellValue(view.FocusedRowHandle, "CODIGO_MUNICIPIO", Nothing)
    End Sub

    Private Sub ListaGRUPO_SOLICITUDGridView_ValidatingEditor(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles ListaGRUPO_SOLICITUDGridView.ValidatingEditor
        Dim grid As GridView = CType(sender, GridView)
        If grid.FocusedColumn.Name = "colLUGAR_EJECUCION" OrElse grid.FocusedColumn.Name = "colNOMBRE_ACCION_FORMATIVA" Then
            If e.Value IsNot Nothing AndAlso Not IsDBNull(e.Value) Then
                e.Value = e.Value.ToString.Trim.ToUpper
            End If
        End If
    End Sub

    Private Sub RepositoryItemGridLookUpEdit2_EditValueChanged(sender As Object, e As System.EventArgs) Handles RepositoryItemGridLookUpEdit2.EditValueChanged
        Dim edit As GridLookUpEdit = CType(sender, GridLookUpEdit)
        Dim lPrograma As SIFP.EL.Programas = TryCast(edit.Properties.GetRowByKeyValue(edit.EditValue), SIFP.EL.Programas)
        Dim parentView As GridView = CType(Me.ListaSOLICITUD_CAPACITACIONGridControl.FocusedView, GridView)
        parentView.SetFocusedRowCellValue(parentView.Columns("NOMBRE_ACCION_FORMATIVA"), lPrograma.nombre_programa.TrimEnd.ToUpper)
    End Sub
End Class
