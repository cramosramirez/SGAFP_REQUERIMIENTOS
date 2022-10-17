Imports SGAFP.BL
Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucListaSOLIC_EMPLEO_ANTERIOR
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar un listado de la tabla SOLIC_EMPLEO_ANTERIOR
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucListaSOLIC_EMPLEO_ANTERIOR
    Inherits ucBase
 
    Private mComponente As New cSOLIC_EMPLEO_ANTERIOR
    Public Event Seleccionado(ByVal ID_EMPLEO_ANT As Decimal) 
    Public Event Editando(ByVal ID_EMPLEO_ANT As Decimal) 

#Region"Propiedades"

    Public Property MostrarFooter() As Boolean
        Get
            Return Me.gvLista.ShowFooter
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.ShowFooter = Value
        End Set
    End Property

    Public Property PermitirPaginacion() As Boolean
        Get
            Return Me.gvLista.AllowPaging
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.AllowPaging = Value
        End Set
    End Property

    Private _PermitirEditar As Boolean = True
    Public Property PermitirEditar() As Boolean
        Get
            Return _PermitirEditar
        End Get
        Set(ByVal Value As Boolean)
            _PermitirEditar = Value
            If Not Me.ViewState("PermitirEditar") Is Nothing Then Me.ViewState.Remove("PermitirEditar")
            Me.ViewState.Add("PermitirEditar", Value)
        End Set
    End Property

    Private _PermitirSeleccionar As Boolean = False
    Public Property PermitirSeleccionar() As Boolean
        Get
            Return _PermitirSeleccionar
        End Get
        Set(ByVal Value As Boolean)
            _PermitirSeleccionar = Value
            Me.gvLista.Columns(0).Visible = Value
            If Not Me.ViewState("PermitirSeleccionar") Is Nothing Then Me.ViewState.Remove("PermitirSeleccionar")
            Me.ViewState.Add("PermitirSeleccionar", Value)
        End Set
    End Property

    Private _PermitirEliminar As Boolean = True
    Public Property PermitirEliminar() As Boolean
        Get
            Return _PermitirEliminar
        End Get
        Set(ByVal Value As Boolean)
            _PermitirEliminar = Value
            Me.gvLista.Columns(Me.gvLista.Columns.Count - 1).Visible = Value
            If Not Me.ViewState("PermitirEliminar") Is Nothing Then Me.ViewState.Remove("PermitirEliminar")
            Me.ViewState.Add("PermitirEliminar", Value)
        End Set
    End Property

    Private _TextoSeleccionar As String = "Seleccionar"
    Public Property TextoSeleccionar() As String
        Get
            Return _TextoSeleccionar
        End Get
        Set(ByVal Value As String)
            _TextoSeleccionar = Value
            If Not Me.ViewState("TextoSeleccionar") Is Nothing Then Me.ViewState.Remove("TextoSeleccionar")
            Me.ViewState.Add("TextoSeleccionar", Value)
        End Set
    End Property

    Private _ComandoSeleccionar As String = "Select"
    Public Property ComandoSeleccionar() As String
        Get
            Return _ComandoSeleccionar
        End Get
        Set(ByVal Value As String)
            _ComandoSeleccionar = Value
            If Not Me.ViewState("ComandoSeleccionar") Is Nothing Then Me.ViewState.Remove("ComandoSeleccionar")
            Me.ViewState.Add("ComandoSeleccionar", Value)
        End Set
    End Property

    Public Property TextoHeaderSeleccionar() As String
        Get
            Return Me.gvLista.Columns(0).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(0).HeaderText = Value
        End Set
    End Property

    Public Property VerID_EMPLEO_ANT() As Boolean
        Get
            Return Me.gvLista.Columns(1).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(1).Visible = Value
        End Set
    End Property

    Public Property VerID_SOLICITUD() As Boolean
        Get
            Return Me.gvLista.Columns(2).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(2).Visible = Value
        End Set
    End Property

    Public Property VerNOMBRE_EMPRESA() As Boolean
        Get
            Return Me.gvLista.Columns(3).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(3).Visible = Value
        End Set
    End Property

    Public Property VerDIRECCION() As Boolean
        Get
            Return Me.gvLista.Columns(4).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(4).Visible = Value
        End Set
    End Property

    Public Property VerZONA() As Boolean
        Get
            Return Me.gvLista.Columns(5).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(5).Visible = Value
        End Set
    End Property

    Public Property VerTELEFONO() As Boolean
        Get
            Return Me.gvLista.Columns(6).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(6).Visible = Value
        End Set
    End Property

    Public Property VerFAX() As Boolean
        Get
            Return Me.gvLista.Columns(7).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(7).Visible = Value
        End Set
    End Property

    Public Property VerEMAIL() As Boolean
        Get
            Return Me.gvLista.Columns(8).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(8).Visible = Value
        End Set
    End Property

    Public Property VerISSS() As Boolean
        Get
            Return Me.gvLista.Columns(9).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(9).Visible = Value
        End Set
    End Property

    Public Property VerJEFE_INMEDIATO() As Boolean
        Get
            Return Me.gvLista.Columns(10).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(10).Visible = Value
        End Set
    End Property

    Public Property VerACTIVIDAD_ECONOMICA() As Boolean
        Get
            Return Me.gvLista.Columns(11).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(11).Visible = Value
        End Set
    End Property

    Public Property VerPUESTO_CONTRATADO() As Boolean
        Get
            Return Me.gvLista.Columns(12).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(12).Visible = Value
        End Set
    End Property

    Public Property VerPUESTO_ACTUAL() As Boolean
        Get
            Return Me.gvLista.Columns(13).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(13).Visible = Value
        End Set
    End Property

    Public Property VerTIEMPO_TRABAJO() As Boolean
        Get
            Return Me.gvLista.Columns(14).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(14).Visible = Value
        End Set
    End Property

    Public Property VerAREA_TRABAJO() As Boolean
        Get
            Return Me.gvLista.Columns(15).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(15).Visible = Value
        End Set
    End Property

    Public Property VerAREA_OTRO() As Boolean
        Get
            Return Me.gvLista.Columns(16).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(16).Visible = Value
        End Set
    End Property

    Public Property VerCODIGO_MUNICIPIO() As Boolean
        Get
            Return Me.gvLista.Columns(17).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(17).Visible = Value
        End Set
    End Property

    Public Property VerCODIGO_REGION() As Boolean
        Get
            Return Me.gvLista.Columns(18).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(18).Visible = Value
        End Set
    End Property

    Public Property VerCODIGO_DEPARTAMENTO() As Boolean
        Get
            Return Me.gvLista.Columns(19).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(19).Visible = Value
        End Set
    End Property

    Public Property HeaderID_EMPLEO_ANT() As String
        Get
            Return Me.gvLista.Columns(1).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(1).HeaderText = Value
        End Set
    End Property

    Public Property HeaderID_SOLICITUD() As String
        Get
            Return Me.gvLista.Columns(2).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(2).HeaderText = Value
        End Set
    End Property

    Public Property HeaderNOMBRE_EMPRESA() As String
        Get
            Return Me.gvLista.Columns(3).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(3).HeaderText = Value
        End Set
    End Property

    Public Property HeaderDIRECCION() As String
        Get
            Return Me.gvLista.Columns(4).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(4).HeaderText = Value
        End Set
    End Property

    Public Property HeaderZONA() As String
        Get
            Return Me.gvLista.Columns(5).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(5).HeaderText = Value
        End Set
    End Property

    Public Property HeaderTELEFONO() As String
        Get
            Return Me.gvLista.Columns(6).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(6).HeaderText = Value
        End Set
    End Property

    Public Property HeaderFAX() As String
        Get
            Return Me.gvLista.Columns(7).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(7).HeaderText = Value
        End Set
    End Property

    Public Property HeaderEMAIL() As String
        Get
            Return Me.gvLista.Columns(8).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(8).HeaderText = Value
        End Set
    End Property

    Public Property HeaderISSS() As String
        Get
            Return Me.gvLista.Columns(9).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(9).HeaderText = Value
        End Set
    End Property

    Public Property HeaderJEFE_INMEDIATO() As String
        Get
            Return Me.gvLista.Columns(10).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(10).HeaderText = Value
        End Set
    End Property

    Public Property HeaderACTIVIDAD_ECONOMICA() As String
        Get
            Return Me.gvLista.Columns(11).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(11).HeaderText = Value
        End Set
    End Property

    Public Property HeaderPUESTO_CONTRATADO() As String
        Get
            Return Me.gvLista.Columns(12).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(12).HeaderText = Value
        End Set
    End Property

    Public Property HeaderPUESTO_ACTUAL() As String
        Get
            Return Me.gvLista.Columns(13).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(13).HeaderText = Value
        End Set
    End Property

    Public Property HeaderTIEMPO_TRABAJO() As String
        Get
            Return Me.gvLista.Columns(14).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(14).HeaderText = Value
        End Set
    End Property

    Public Property HeaderAREA_TRABAJO() As String
        Get
            Return Me.gvLista.Columns(15).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(15).HeaderText = Value
        End Set
    End Property

    Public Property HeaderAREA_OTRO() As String
        Get
            Return Me.gvLista.Columns(16).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(16).HeaderText = Value
        End Set
    End Property

    Public Property HeaderCODIGO_MUNICIPIO() As String
        Get
            Return Me.gvLista.Columns(17).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(17).HeaderText = Value
        End Set
    End Property

    Public Property HeaderCODIGO_REGION() As String
        Get
            Return Me.gvLista.Columns(18).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(18).HeaderText = Value
        End Set
    End Property

    Public Property HeaderCODIGO_DEPARTAMENTO() As String
        Get
            Return Me.gvLista.Columns(19).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(19).HeaderText = Value
        End Set
    End Property

#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla SOLIC_EMPLEO_ANTERIOR
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        Dim lSOLIC_EMPLEO_ANTERIOR As listaSOLIC_EMPLEO_ANTERIOR
        lSOLIC_EMPLEO_ANTERIOR = Me.mComponente.ObtenerLista()
        If lSOLIC_EMPLEO_ANTERIOR is Nothing Then
            Me.gvLista.Visible = False
            Return -1
        End If
        Me.gvLista.SelectedIndex = -1
        Me.gvLista.Visible = True
        Me.gvLista.DataSource = lSOLIC_EMPLEO_ANTERIOR
        Me.gvLista.DataBind()
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
    ''' 	[GenApp]	02/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorSOLICITUD_INSCRIPCION_AF(ByVal ID_SOLICITUD As Decimal) As Integer
        Dim lSOLIC_EMPLEO_ANTERIOR As listaSOLIC_EMPLEO_ANTERIOR
        lSOLIC_EMPLEO_ANTERIOR = Me.mComponente.ObtenerListaPorSOLICITUD_INSCRIPCION_AF(ID_SOLICITUD)
        If lSOLIC_EMPLEO_ANTERIOR is Nothing Then
            Me.gvLista.Visible = False
            Return -1
        End If
        Me.ViewState("PorSOLICITUD_INSCRIPCION_AF") = True
        Me.ViewState("ID_SOLICITUD") = ID_SOLICITUD
        Me.gvLista.SelectedIndex = -1
        Me.gvLista.Visible = True
        Me.gvLista.DataSource = lSOLIC_EMPLEO_ANTERIOR
        Me.gvLista.DataBind()
        Return 1
    End Function

    '''' -----------------------------------------------------------------------------
    '''' <summary>
    '''' Función que Carga la información de los registros de la tabla SOLIC_EMPLEO_ANTERIOR
    '''' filtrado por la tabla CIUU
    '''' </summary>
    '''' <param name="CIUU"></param>
    '''' <remarks>
    '''' </remarks>
    '''' <history>
    '''' 	[GenApp]	02/02/2010	Created
    '''' </history>
    '''' -----------------------------------------------------------------------------
    'Public Function CargarDatosPorCIUU(ByVal CIUU As String) As Integer
    '    Dim lSOLIC_EMPLEO_ANTERIOR As listaSOLIC_EMPLEO_ANTERIOR
    '    lSOLIC_EMPLEO_ANTERIOR = Me.mComponente.ObtenerListaPorCIUU(CIUU)
    '    If lSOLIC_EMPLEO_ANTERIOR is Nothing Then
    '        Me.gvLista.Visible = False
    '        Return -1
    '    End If
    '    Me.ViewState("PorCIUU") = True
    '    Me.ViewState("CIUU") = CIUU
    '    Me.gvLista.SelectedIndex = -1
    '    Me.gvLista.Visible = True
    '    Me.gvLista.DataSource = lSOLIC_EMPLEO_ANTERIOR
    '    Me.gvLista.DataBind()
    '    Return 1
    'End Function

    '''' -----------------------------------------------------------------------------
    '''' <summary>
    '''' Función que Carga la información de los registros de la tabla SOLIC_EMPLEO_ANTERIOR
    '''' filtrado por la tabla MUNICIPIO
    '''' </summary>
    '''' <param name="CODIGO_MUNICIPIO"></param>
    '''' <param name="CODIGO_REGION"></param>
    '''' <param name="CODIGO_DEPARTAMENTO"></param>
    '''' <remarks>
    '''' </remarks>
    '''' <history>
    '''' 	[GenApp]	02/02/2010	Created
    '''' </history>
    '''' -----------------------------------------------------------------------------
    'Public Function CargarDatosPorMUNICIPIO(ByVal CODIGO_MUNICIPIO As String, ByVal CODIGO_REGION As String, ByVal CODIGO_DEPARTAMENTO As String) As Integer
    '    Dim lSOLIC_EMPLEO_ANTERIOR As listaSOLIC_EMPLEO_ANTERIOR
    '    lSOLIC_EMPLEO_ANTERIOR = Me.mComponente.ObtenerListaPorMUNICIPIOCODIGO_MUNICIPIO, CODIGO_DEPARTAMENTO)
    '    If lSOLIC_EMPLEO_ANTERIOR is Nothing Then
    '        Me.gvLista.Visible = False
    '        Return -1
    '    End If
    '    Me.ViewState("PorMUNICIPIO") = True
    '    Me.ViewState("CODIGO_MUNICIPIO") = CODIGO_MUNICIPIO
    '    Me.ViewState("CODIGO_REGION") = CODIGO_REGION
    '    Me.ViewState("CODIGO_DEPARTAMENTO") = CODIGO_DEPARTAMENTO
    '    Me.gvLista.SelectedIndex = -1
    '    Me.gvLista.Visible = True
    '    Me.gvLista.DataSource = lSOLIC_EMPLEO_ANTERIOR
    '    Me.gvLista.DataBind()
    '    Return 1
    'End Function

    '''' -----------------------------------------------------------------------------
    '''' <summary>
    '''' Función que Carga la información de los registros de la tabla SOLIC_EMPLEO_ANTERIOR
    '''' filtrado por la tabla REGION
    '''' </summary>
    '''' <param name="CODIGO_REGION"></param>
    '''' <remarks>
    '''' </remarks>
    '''' <history>
    '''' 	[GenApp]	02/02/2010	Created
    '''' </history>
    '''' -----------------------------------------------------------------------------
    'Public Function CargarDatosPorREGION(ByVal CODIGO_REGION As String) As Integer
    '    Dim lSOLIC_EMPLEO_ANTERIOR As listaSOLIC_EMPLEO_ANTERIOR
    '    lSOLIC_EMPLEO_ANTERIOR = Me.mComponente.ObtenerListaPorREGION(CODIGO_REGION)
    '    If lSOLIC_EMPLEO_ANTERIOR is Nothing Then
    '        Me.gvLista.Visible = False
    '        Return -1
    '    End If
    '    Me.ViewState("PorREGION") = True
    '    Me.ViewState("CODIGO_REGION") = CODIGO_REGION
    '    Me.gvLista.SelectedIndex = -1
    '    Me.gvLista.Visible = True
    '    Me.gvLista.DataSource = lSOLIC_EMPLEO_ANTERIOR
    '    Me.gvLista.DataBind()
    '    Return 1
    'End Function

    '''' -----------------------------------------------------------------------------
    '''' <summary>
    '''' Función que Carga la información de los registros de la tabla SOLIC_EMPLEO_ANTERIOR
    '''' filtrado por la tabla DEPARTAMENTO
    '''' </summary>
    '''' <param name="CODIGO_REGION"></param>
    '''' <param name="CODIGO_DEPARTAMENTO"></param>
    '''' <remarks>
    '''' </remarks>
    '''' <history>
    '''' 	[GenApp]	02/02/2010	Created
    '''' </history>
    '''' -----------------------------------------------------------------------------
    'Public Function CargarDatosPorDEPARTAMENTO(ByVal CODIGO_REGION As String, ByVal CODIGO_DEPARTAMENTO As String) As Integer
    '    Dim lSOLIC_EMPLEO_ANTERIOR As listaSOLIC_EMPLEO_ANTERIOR
    '    lSOLIC_EMPLEO_ANTERIOR = Me.mComponente.ObtenerListaPorDEPARTAMENTO(CODIGO_DEPARTAMENTO)
    '    If lSOLIC_EMPLEO_ANTERIOR is Nothing Then
    '        Me.gvLista.Visible = False
    '        Return -1
    '    End If
    '    Me.ViewState("PorDEPARTAMENTO") = True
    '    Me.ViewState("CODIGO_REGION") = CODIGO_REGION
    '    Me.ViewState("CODIGO_DEPARTAMENTO") = CODIGO_DEPARTAMENTO
    '    Me.gvLista.SelectedIndex = -1
    '    Me.gvLista.Visible = True
    '    Me.gvLista.DataSource = lSOLIC_EMPLEO_ANTERIOR
    '    Me.gvLista.DataBind()
    '    Return 1
    'End Function

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not Me.ViewState("PermitirEditar") Is Nothing Then Me._PermitirEditar = Me.ViewState("PermitirEditar")
        If Not Me.ViewState("PermitirSeleccionar") Is Nothing Then Me._PermitirSeleccionar = Me.ViewState("PermitirSeleccionar")
        If Not Me.ViewState("PermitirEliminar") Is Nothing Then Me._PermitirEliminar = Me.ViewState("PermitirEliminar")
        If Not Me.ViewState("TextoSeleccionar") Is Nothing Then Me._TextoSeleccionar = Me.ViewState("TextoSeleccionar")
        If Not Me.ViewState("ComandoSeleccionar") Is Nothing Then Me._ComandoSeleccionar = Me.ViewState("ComandoSeleccionar")
    End Sub

    Private lDdlSOLICITUD_INSCRIPCION_AF As SGAFP.WebUC.ddlSOLICITUD_INSCRIPCION_AF
    Private lDdlCIUU As SGAFP.WebUC.ddlCIUU
    Private lDdlMUNICIPIO As SGAFP.WebUC.ddlMUNICIPIO
    Private lDdlREGION As SGAFP.WebUC.ddlREGION
    Private lDdlDEPARTAMENTO As SGAFP.WebUC.ddlDEPARTAMENTO

    Protected Sub gvLista_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles gvLista.RowCommand
        If e.CommandName = "Editar" Then
            RaiseEvent Editando(CInt(e.CommandArgument))
        End If
    End Sub

    Protected Sub gvLista_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles gvLista.RowDataBound
        If e.Row.RowType = DataControlRowType.DataRow Then
            If Me.PermitirEliminar Then 
                Dim a As LinkButton = CType(e.Row.FindControl("LinkButton1"), LinkButton)
                a.Attributes.Add("onclick", "if(!window.confirm('¿Esta seguro de Eliminar el Registro?')){return false;}")
            End If
            Dim lbDetalle As LinkButton 
            lbDetalle = e.Row.FindControl("LinkButtonDetalle") 
            Dim mLabelID_EMPLEO_ANT As Label
            mLabelID_EMPLEO_ANT = e.Row.FindControl("Label_ID_EMPLEO_ANT")
            mLabelID_EMPLEO_ANT.Visible = Not Me.PermitirEditar
            lbDetalle.Visible = Me.PermitirEditar
            If Me.VerID_SOLICITUD Then
                Dim mDdlSOLICITUD_INSCRIPCION_AF As SGAFP.WebUC.ddlSOLICITUD_INSCRIPCION_AF
                mDdlSOLICITUD_INSCRIPCION_AF = e.Row.FindControl("DdlSOLICITUD_INSCRIPCION_AF1")
                If lDdlSOLICITUD_INSCRIPCION_AF Is Nothing Then
                    lDdlSOLICITUD_INSCRIPCION_AF = New SGAFP.WebUC.ddlSOLICITUD_INSCRIPCION_AF
                    lDdlSOLICITUD_INSCRIPCION_AF.Recuperar()
                End If
                Dim mSOLICITUD_INSCRIPCION_AF As String
                mSOLICITUD_INSCRIPCION_AF = CType(e.Row.FindControl("Label_ID_SOLICITUD1"), Label).Text
                Dim lItem As ListItem = lDdlSOLICITUD_INSCRIPCION_AF.Items.FindByValue(mSOLICITUD_INSCRIPCION_AF)
                If mSOLICITUD_INSCRIPCION_AF <> "" And Not lItem Is Nothing Then
                    mDdlSOLICITUD_INSCRIPCION_AF.Items.Add(New ListItem(lItem.Text, lItem.Value))
                    mDdlSOLICITUD_INSCRIPCION_AF.SelectedValue = mSOLICITUD_INSCRIPCION_AF
                End If
            End If
            If Me.VerACTIVIDAD_ECONOMICA Then
                Dim mDdlCIUU As SGAFP.WebUC.ddlCIUU
                mDdlCIUU = e.Row.FindControl("DdlCIUU1")
                If lDdlCIUU Is Nothing Then
                    lDdlCIUU = New SGAFP.WebUC.ddlCIUU
                    lDdlCIUU.Recuperar()
                End If
                Dim mCIUU As String
                mCIUU = CType(e.Row.FindControl("Label_ACTIVIDAD_ECONOMICA1"), Label).Text
                Dim lItem As ListItem = lDdlCIUU.Items.FindByValue(mCIUU)
                If mCIUU <> "" And Not lItem Is Nothing Then
                    mDdlCIUU.Items.Add(New ListItem(lItem.Text, lItem.Value))
                    mDdlCIUU.SelectedValue = mCIUU
                End If
            End If
            If Me.VerCODIGO_MUNICIPIO Then
                Dim mDdlMUNICIPIO As SGAFP.WebUC.ddlMUNICIPIO
                mDdlMUNICIPIO = e.Row.FindControl("DdlMUNICIPIO1")
            Dim mLabelCODIGO_REGION As Label
            mLabelCODIGO_REGION = e.Row.FindControl("Label_CODIGO_REGION1")
            Dim mLabelCODIGO_DEPARTAMENTO As Label
            mLabelCODIGO_DEPARTAMENTO = e.Row.FindControl("Label_CODIGO_DEPARTAMENTO1")
                If lDdlMUNICIPIO Is Nothing Then
                    lDdlMUNICIPIO = New SGAFP.WebUC.ddlMUNICIPIO
                    lDdlMUNICIPIO.Recuperar(mLabelCODIGO_DEPARTAMENTO.Text)
                End If
                Dim mMUNICIPIO As String
                mMUNICIPIO = CType(e.Row.FindControl("Label_CODIGO_MUNICIPIO1"), Label).Text
                Dim lItem As ListItem = lDdlMUNICIPIO.Items.FindByValue(mMUNICIPIO)
                If mMUNICIPIO <> "" And Not lItem Is Nothing Then
                    mDdlMUNICIPIO.Items.Add(New ListItem(lItem.Text, lItem.Value))
                    mDdlMUNICIPIO.SelectedValue = mMUNICIPIO
                End If
            End If
            If Me.VerCODIGO_REGION Then
                Dim mDdlREGION As SGAFP.WebUC.ddlREGION
                mDdlREGION = e.Row.FindControl("DdlREGION1")
                If lDdlREGION Is Nothing Then
                    lDdlREGION = New SGAFP.WebUC.ddlREGION
                    lDdlREGION.Recuperar()
                End If
                Dim mREGION As String
                mREGION = CType(e.Row.FindControl("Label_CODIGO_REGION1"), Label).Text
                Dim lItem As ListItem = lDdlREGION.Items.FindByValue(mREGION)
                If mREGION <> "" And Not lItem Is Nothing Then
                    mDdlREGION.Items.Add(New ListItem(lItem.Text, lItem.Value))
                    mDdlREGION.SelectedValue = mREGION
                End If
            End If
            If Me.VerCODIGO_DEPARTAMENTO Then
                Dim mDdlDEPARTAMENTO As SGAFP.WebUC.ddlDEPARTAMENTO
                mDdlDEPARTAMENTO = e.Row.FindControl("DdlDEPARTAMENTO1")
            Dim mLabelCODIGO_REGION As Label
            mLabelCODIGO_REGION = e.Row.FindControl("Label_CODIGO_REGION1")
                If lDdlDEPARTAMENTO Is Nothing Then
                    lDdlDEPARTAMENTO = New SGAFP.WebUC.ddlDEPARTAMENTO
                    lDdlDEPARTAMENTO.Recuperar()
                End If
                Dim mDEPARTAMENTO As String
                mDEPARTAMENTO = CType(e.Row.FindControl("Label_CODIGO_DEPARTAMENTO1"), Label).Text
                Dim lItem As ListItem = lDdlDEPARTAMENTO.Items.FindByValue(mDEPARTAMENTO)
                If mDEPARTAMENTO <> "" And Not lItem Is Nothing Then
                    mDdlDEPARTAMENTO.Items.Add(New ListItem(lItem.Text, lItem.Value))
                    mDdlDEPARTAMENTO.SelectedValue = mDEPARTAMENTO
                End If
            End If
            If Me.PermitirSeleccionar Then
                Dim a As LinkButton = CType(e.Row.FindControl("LinkButton_Seleccionar"), LinkButton)
                a.Text = Me.TextoSeleccionar
                a.CommandName = Me.ComandoSeleccionar
                If a.CommandName = "Check" Then
                    CType(e.Row.FindControl("CheckBox_Seleccionar"), CheckBox).Visible = True
                    a.Visible = False
                End If
            End If

        End If
    End Sub
 
    Private Sub gvLista_RowDeleting(ByVal source As System.Object, ByVal e As System.Web.UI.WebControls.GridViewDeleteEventArgs) Handles gvLista.RowDeleting
        If Me.mComponente.EliminarSOLIC_EMPLEO_ANTERIOR(CDec(CType(Me.gvLista.Rows(e.RowIndex).FindControl("LinkButton1"), LinkButton).ToolTip)) <> 1 Then
            'Si se cometio un error
            Me.AsignarMensaje("Error al Eliminar Registro", True, True)
            e.Cancel = True
        Else
            If Me.CargarDatos() <> 1 Then
                Me.AsignarMensaje("Error al Recuperar Lista", True, True)
            End If
        End If
    End Sub
 
    Private Sub gvLista_SelectedIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewSelectEventArgs) Handles gvLista.SelectedIndexChanging
        RaiseEvent Seleccionado(CDec(CType(Me.gvLista.Rows(e.NewSelectedIndex).FindControl("LinkButton1"), LinkButton).ToolTip))
    End Sub

    Protected Sub gvLista_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles gvLista.PageIndexChanging
        Me.gvLista.PageIndex = e.NewPageIndex
        If Me.ViewState("PorSOLICITUD_INSCRIPCION_AF") Then
            Me.CargarDatosPorSOLICITUD_INSCRIPCION_AF(Me.ViewState("ID_SOLICITUD"))
            Return
        End If
        'If Me.ViewState("PorCIUU") Then
        '    Me.CargarDatosPorCIUU(Me.ViewState("CIUU"))
        '    Return
        'End If
        'If Me.ViewState("PorMUNICIPIO") Then
        '    Me.CargarDatosPorMUNICIPIO(Me.ViewState("CODIGO_MUNICIPIO"), Me.ViewState("CODIGO_REGION"), Me.ViewState("CODIGO_DEPARTAMENTO"))
        '    Return
        'End If
        'If Me.ViewState("PorREGION") Then
        '    Me.CargarDatosPorREGION(Me.ViewState("CODIGO_REGION"))
        '    Return
        'End If
        'If Me.ViewState("PorDEPARTAMENTO") Then
        '    Me.CargarDatosPorDEPARTAMENTO(Me.ViewState("CODIGO_REGION"), Me.ViewState("CODIGO_DEPARTAMENTO"))
        '    Return
        'End If
        Me.CargarDatos()
    End Sub

    Public Function DevolverSeleccionados() As listaSOLIC_EMPLEO_ANTERIOR
        Dim mLista As New listaSOLIC_EMPLEO_ANTERIOR
        For Each mRow As GridViewRow In Me.gvLista.Rows
            If CType(mRow.FindControl("CheckBox_Seleccionar"), CheckBox).Checked Then
                Dim mEntidad As New SOLIC_EMPLEO_ANTERIOR
                mEntidad.ID_EMPLEO_ANT = CInt(CType(mRow.FindControl("Label_ID_EMPLEO_ANT"), Label).Text)
                mLista.Add(mEntidad)
            End If
        Next
        Return mLista
    End Function

End Class
