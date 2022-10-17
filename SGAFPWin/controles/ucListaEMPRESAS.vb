Imports SGAFP.EL
Public Class ucListaEMPRESAS

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.ListaBindingNavigator.BindingSource = Me.ListaEMPRESASBindingSource
    End Sub

    Private mComponente As New cEMPRESAS
    Private _mListaEMPRESAS As New listaEMPRESAS
    Public Event CambioRegistro()
    Public Event Seleccionado(ByVal NUMERO_PATRONAL As String) 

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

    Private _VerNUMERO_PATRONAL As Boolean = True
    <DefaultValue(True)> _
    Public Property VerNUMERO_PATRONAL() As Boolean
        Get
            Return Me._VerNUMERO_PATRONAL
        End Get
        Set(ByVal value As Boolean)
            Me._VerNUMERO_PATRONAL = value
            Me.DataGridViewTextBoxNUMERO_PATRONAL.Visible = value
        End Set
    End Property

    Private _VerNIT_EMPRESA As Boolean = True
    <DefaultValue(True)> _
    Public Property VerNIT_EMPRESA() As Boolean
        Get
            Return Me._VerNIT_EMPRESA
        End Get
        Set(ByVal value As Boolean)
            Me._VerNIT_EMPRESA = value
            Me.DataGridViewTextBoxNIT_EMPRESA.Visible = value
        End Set
    End Property

    Private _VerCIUU As Boolean = True
    <DefaultValue(True)> _
    Public Property VerCIUU() As Boolean
        Get
            Return Me._VerCIUU
        End Get
        Set(ByVal value As Boolean)
            Me._VerCIUU = value
            Me.DataGridViewTextBoxCIUU.Visible = value
        End Set
    End Property

    Private _VerSECTOR_PRODUCTIVO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerSECTOR_PRODUCTIVO() As Boolean
        Get
            Return Me._VerSECTOR_PRODUCTIVO
        End Get
        Set(ByVal value As Boolean)
            Me._VerSECTOR_PRODUCTIVO = value
            Me.DataGridViewTextBoxSECTOR_PRODUCTIVO.Visible = value
        End Set
    End Property

    Private _VerCODIGO_ASESOR As Boolean = True
    <DefaultValue(True)> _
    Public Property VerCODIGO_ASESOR() As Boolean
        Get
            Return Me._VerCODIGO_ASESOR
        End Get
        Set(ByVal value As Boolean)
            Me._VerCODIGO_ASESOR = value
            Me.DataGridViewTextBoxCODIGO_ASESOR.Visible = value
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

    Private _VerTIPO_EMPRESA As Boolean = True
    <DefaultValue(True)> _
    Public Property VerTIPO_EMPRESA() As Boolean
        Get
            Return Me._VerTIPO_EMPRESA
        End Get
        Set(ByVal value As Boolean)
            Me._VerTIPO_EMPRESA = value
            Me.DataGridViewTextBoxTIPO_EMPRESA.Visible = value
        End Set
    End Property

    Private _VerCONTACTO_EMPRESA As Boolean = True
    <DefaultValue(True)> _
    Public Property VerCONTACTO_EMPRESA() As Boolean
        Get
            Return Me._VerCONTACTO_EMPRESA
        End Get
        Set(ByVal value As Boolean)
            Me._VerCONTACTO_EMPRESA = value
            Me.DataGridViewTextBoxCONTACTO_EMPRESA.Visible = value
        End Set
    End Property

    Private _VerTELEFONO_CONTACTO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerTELEFONO_CONTACTO() As Boolean
        Get
            Return Me._VerTELEFONO_CONTACTO
        End Get
        Set(ByVal value As Boolean)
            Me._VerTELEFONO_CONTACTO = value
            Me.DataGridViewTextBoxTELEFONO_CONTACTO.Visible = value
        End Set
    End Property

    Private _VerCARGO_CONTACTO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerCARGO_CONTACTO() As Boolean
        Get
            Return Me._VerCARGO_CONTACTO
        End Get
        Set(ByVal value As Boolean)
            Me._VerCARGO_CONTACTO = value
            Me.DataGridViewTextBoxCARGO_CONTACTO.Visible = value
        End Set
    End Property

    Private _VerDIRECCION_EMPRESA As Boolean = True
    <DefaultValue(True)> _
    Public Property VerDIRECCION_EMPRESA() As Boolean
        Get
            Return Me._VerDIRECCION_EMPRESA
        End Get
        Set(ByVal value As Boolean)
            Me._VerDIRECCION_EMPRESA = value
            Me.DataGridViewTextBoxDIRECCION_EMPRESA.Visible = value
        End Set
    End Property

    Private _VerTELEFONO_EMPRESA As Boolean = True
    <DefaultValue(True)> _
    Public Property VerTELEFONO_EMPRESA() As Boolean
        Get
            Return Me._VerTELEFONO_EMPRESA
        End Get
        Set(ByVal value As Boolean)
            Me._VerTELEFONO_EMPRESA = value
            Me.DataGridViewTextBoxTELEFONO_EMPRESA.Visible = value
        End Set
    End Property

    Private _VerFAX_EMPRESA As Boolean = True
    <DefaultValue(True)> _
    Public Property VerFAX_EMPRESA() As Boolean
        Get
            Return Me._VerFAX_EMPRESA
        End Get
        Set(ByVal value As Boolean)
            Me._VerFAX_EMPRESA = value
            Me.DataGridViewTextBoxFAX_EMPRESA.Visible = value
        End Set
    End Property

    Private _VerEMAIL_EMPRESA As Boolean = True
    <DefaultValue(True)> _
    Public Property VerEMAIL_EMPRESA() As Boolean
        Get
            Return Me._VerEMAIL_EMPRESA
        End Get
        Set(ByVal value As Boolean)
            Me._VerEMAIL_EMPRESA = value
            Me.DataGridViewTextBoxEMAIL_EMPRESA.Visible = value
        End Set
    End Property

    Private _VerESPECIALIDAD_EMPRESA As Boolean = True
    <DefaultValue(True)> _
    Public Property VerESPECIALIDAD_EMPRESA() As Boolean
        Get
            Return Me._VerESPECIALIDAD_EMPRESA
        End Get
        Set(ByVal value As Boolean)
            Me._VerESPECIALIDAD_EMPRESA = value
            Me.DataGridViewTextBoxESPECIALIDAD_EMPRESA.Visible = value
        End Set
    End Property

    Private _VerTOTAL_PERSONA As Boolean = True
    <DefaultValue(True)> _
    Public Property VerTOTAL_PERSONA() As Boolean
        Get
            Return Me._VerTOTAL_PERSONA
        End Get
        Set(ByVal value As Boolean)
            Me._VerTOTAL_PERSONA = value
            Me.DataGridViewTextBoxTOTAL_PERSONA.Visible = value
        End Set
    End Property

    Private _VerTOTAL_PLANILLA As Boolean = True
    <DefaultValue(True)> _
    Public Property VerTOTAL_PLANILLA() As Boolean
        Get
            Return Me._VerTOTAL_PLANILLA
        End Get
        Set(ByVal value As Boolean)
            Me._VerTOTAL_PLANILLA = value
            Me.DataGridViewTextBoxTOTAL_PLANILLA.Visible = value
        End Set
    End Property

    Private _VerREPRESENTANTE_LEGAL As Boolean = True
    <DefaultValue(True)> _
    Public Property VerREPRESENTANTE_LEGAL() As Boolean
        Get
            Return Me._VerREPRESENTANTE_LEGAL
        End Get
        Set(ByVal value As Boolean)
            Me._VerREPRESENTANTE_LEGAL = value
            Me.DataGridViewTextBoxREPRESENTANTE_LEGAL.Visible = value
        End Set
    End Property

    Private _VerFECHA_REGISTRO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerFECHA_REGISTRO() As Boolean
        Get
            Return Me._VerFECHA_REGISTRO
        End Get
        Set(ByVal value As Boolean)
            Me._VerFECHA_REGISTRO = value
            Me.DataGridViewTextBoxFECHA_REGISTRO.Visible = value
        End Set
    End Property

    Private _VerTOTAL_TRABAJADORES As Boolean = True
    <DefaultValue(True)> _
    Public Property VerTOTAL_TRABAJADORES() As Boolean
        Get
            Return Me._VerTOTAL_TRABAJADORES
        End Get
        Set(ByVal value As Boolean)
            Me._VerTOTAL_TRABAJADORES = value
            Me.DataGridViewTextBoxTOTAL_TRABAJADORES.Visible = value
        End Set
    End Property

    Private _VerFEMENINOS As Boolean = True
    <DefaultValue(True)> _
    Public Property VerFEMENINOS() As Boolean
        Get
            Return Me._VerFEMENINOS
        End Get
        Set(ByVal value As Boolean)
            Me._VerFEMENINOS = value
            Me.DataGridViewTextBoxFEMENINOS.Visible = value
        End Set
    End Property

    Private _VerMASCULINOS As Boolean = True
    <DefaultValue(True)> _
    Public Property VerMASCULINOS() As Boolean
        Get
            Return Me._VerMASCULINOS
        End Get
        Set(ByVal value As Boolean)
            Me._VerMASCULINOS = value
            Me.DataGridViewTextBoxMASCULINOS.Visible = value
        End Set
    End Property

    Private _VerTAMANO_EMPRESA As Boolean = True
    <DefaultValue(True)> _
    Public Property VerTAMANO_EMPRESA() As Boolean
        Get
            Return Me._VerTAMANO_EMPRESA
        End Get
        Set(ByVal value As Boolean)
            Me._VerTAMANO_EMPRESA = value
            Me.DataGridViewTextBoxTAMANO_EMPRESA.Visible = value
        End Set
    End Property

    Private _VerCON_MANDO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerCON_MANDO() As Boolean
        Get
            Return Me._VerCON_MANDO
        End Get
        Set(ByVal value As Boolean)
            Me._VerCON_MANDO = value
            Me.DataGridViewTextBoxCON_MANDO.Visible = value
        End Set
    End Property

    Private _VerSIN_MANDO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerSIN_MANDO() As Boolean
        Get
            Return Me._VerSIN_MANDO
        End Get
        Set(ByVal value As Boolean)
            Me._VerSIN_MANDO = value
            Me.DataGridViewTextBoxSIN_MANDO.Visible = value
        End Set
    End Property

    Private _VerADMINISTRATIVOS As Boolean = True
    <DefaultValue(True)> _
    Public Property VerADMINISTRATIVOS() As Boolean
        Get
            Return Me._VerADMINISTRATIVOS
        End Get
        Set(ByVal value As Boolean)
            Me._VerADMINISTRATIVOS = value
            Me.DataGridViewTextBoxADMINISTRATIVOS.Visible = value
        End Set
    End Property

    Private _VerMANDOS_MEDIOS As Boolean = True
    <DefaultValue(True)> _
    Public Property VerMANDOS_MEDIOS() As Boolean
        Get
            Return Me._VerMANDOS_MEDIOS
        End Get
        Set(ByVal value As Boolean)
            Me._VerMANDOS_MEDIOS = value
            Me.DataGridViewTextBoxMANDOS_MEDIOS.Visible = value
        End Set
    End Property

    Private _VerOPERATIVOS As Boolean = True
    <DefaultValue(True)> _
    Public Property VerOPERATIVOS() As Boolean
        Get
            Return Me._VerOPERATIVOS
        End Get
        Set(ByVal value As Boolean)
            Me._VerOPERATIVOS = value
            Me.DataGridViewTextBoxOPERATIVOS.Visible = value
        End Set
    End Property

    Private _VerGERENCIAL As Boolean = True
    <DefaultValue(True)> _
    Public Property VerGERENCIAL() As Boolean
        Get
            Return Me._VerGERENCIAL
        End Get
        Set(ByVal value As Boolean)
            Me._VerGERENCIAL = value
            Me.DataGridViewTextBoxGERENCIAL.Visible = value
        End Set
    End Property

    Private _VerSIGLAS As Boolean = True
    <DefaultValue(True)> _
    Public Property VerSIGLAS() As Boolean
        Get
            Return Me._VerSIGLAS
        End Get
        Set(ByVal value As Boolean)
            Me._VerSIGLAS = value
            Me.DataGridViewTextBoxSIGLAS.Visible = value
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

    Private _VerLASTUPDATE As Boolean = True
    <DefaultValue(True)> _
    Public Property VerLASTUPDATE() As Boolean
        Get
            Return Me._VerLASTUPDATE
        End Get
        Set(ByVal value As Boolean)
            Me._VerLASTUPDATE = value
            Me.DataGridViewTextBoxLASTUPDATE.Visible = value
        End Set
    End Property

    Private _VerOBSERVACION As Boolean = True
    <DefaultValue(True)> _
    Public Property VerOBSERVACION() As Boolean
        Get
            Return Me._VerOBSERVACION
        End Get
        Set(ByVal value As Boolean)
            Me._VerOBSERVACION = value
            Me.DataGridViewTextBoxOBSERVACION.Visible = value
        End Set
    End Property

    Private _VerNUM_PAT_ISSS As Boolean = True
    <DefaultValue(True)> _
    Public Property VerNUM_PAT_ISSS() As Boolean
        Get
            Return Me._VerNUM_PAT_ISSS
        End Get
        Set(ByVal value As Boolean)
            Me._VerNUM_PAT_ISSS = value
            Me.DataGridViewTextBoxNUM_PAT_ISSS.Visible = value
        End Set
    End Property

    Private _VerTIPOPERSON As Boolean = True
    <DefaultValue(True)> _
    Public Property VerTIPOPERSON() As Boolean
        Get
            Return Me._VerTIPOPERSON
        End Get
        Set(ByVal value As Boolean)
            Me._VerTIPOPERSON = value
            Me.DataGridViewTextBoxTIPOPERSON.Visible = value
        End Set
    End Property

    Private _VerNUM As Boolean = True
    <DefaultValue(True)> _
    Public Property VerNUM() As Boolean
        Get
            Return Me._VerNUM
        End Get
        Set(ByVal value As Boolean)
            Me._VerNUM = value
            Me.DataGridViewTextBoxNUM.Visible = value
        End Set
    End Property

    Private _VerREPRESENTANTE_PROFESION As Boolean = True
    <DefaultValue(True)> _
    Public Property VerREPRESENTANTE_PROFESION() As Boolean
        Get
            Return Me._VerREPRESENTANTE_PROFESION
        End Get
        Set(ByVal value As Boolean)
            Me._VerREPRESENTANTE_PROFESION = value
            Me.DataGridViewTextBoxREPRESENTANTE_PROFESION.Visible = value
        End Set
    End Property

    Private _VerCONTACTO_EMAIL As Boolean = True
    <DefaultValue(True)> _
    Public Property VerCONTACTO_EMAIL() As Boolean
        Get
            Return Me._VerCONTACTO_EMAIL
        End Get
        Set(ByVal value As Boolean)
            Me._VerCONTACTO_EMAIL = value
            Me.DataGridViewTextBoxCONTACTO_EMAIL.Visible = value
        End Set
    End Property

    Private _VerAPORTE_INSAFORP As Boolean = True
    <DefaultValue(True)> _
    Public Property VerAPORTE_INSAFORP() As Boolean
        Get
            Return Me._VerAPORTE_INSAFORP
        End Get
        Set(ByVal value As Boolean)
            Me._VerAPORTE_INSAFORP = value
            Me.DataGridViewTextBoxAPORTE_INSAFORP.Visible = value
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

    #End Region

    Public ReadOnly Property Current() As EMPRESAS
        Get
            Return CType(Me.ListaEMPRESASBindingSource.Current, EMPRESAS)
        End Get
    End Property

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla EMPRESAS
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        _mListaEMPRESAS = Me.mComponente.ObtenerLista()
        If _mListaEMPRESAS Is Nothing Then Return -1
        Me.ListaEMPRESASBindingSource.DataSource = _mListaEMPRESAS
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
        If Not Me.ListaEMPRESASBindingSource.Current Is Nothing Then
            If Me.Current.NUMERO_PATRONAL = 0 Then Return 0
        End If
        If MyBase.Eliminar() = 0 Then Return 0
        If Not Me.ListaEMPRESASBindingSource.Current Is Nothing Then
            If mComponente.EliminarEMPRESAS( Me.Current.NUMERO_PATRONAL) <> 1 Then
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
        If Not Me.ListaEMPRESASBindingSource.Current Is Nothing Then
            Me.ListaEMPRESASBindingSource.EndEdit()
            If Not Me.Current.IsDirty Then Return 0
            Select Case mComponente.ActualizarEMPRESAS(Me.Current)
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

    Private Sub ListaEMPRESASBindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles ListaEMPRESASBindingSource.AddingNew
        Dim lEntidad As New EMPRESAS
        e.NewObject = lEntidad
    End Sub

    Private Sub ListaEMPRESASBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaEMPRESASBindingSource.PositionChanged
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
        Me.ListaEMPRESASDataGridView.AllowUserToAddRows = Me.PermitirAgregar
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
        Me.ListaEMPRESASDataGridView.AllowUserToDeleteRows = Me.PermitirEliminar
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
            Me.ListaEMPRESASDataGridView.Dock = DockStyle.None
            Me.ListaEMPRESASDataGridView.Size = New Size(Me.Size.Width, Me.Size.Height - Me.ListaBindingNavigator.Size.Height)
            Me.ListaEMPRESASDataGridView.Location = New Point(1, Me.ListaBindingNavigator.Size.Height + 1)
        Else
            Me.ListaEMPRESASDataGridView.Dock = DockStyle.Fill
        End If
    End Sub

End Class
