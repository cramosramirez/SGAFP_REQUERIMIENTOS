Imports SGAFP.BL
Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucVistaDetalleSUPERVISION_AF
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla SUPERVISION_AF
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleSUPERVISION_AF
    Inherits ucBase
 
#Region"Propiedades"

    Private _ID_SUPERVISION_AF As Decimal
    Public Property ID_SUPERVISION_AF() As Decimal
        Get
            Return Me.txtID_SUPERVISION_AF.Text
        End Get
        Set(ByVal Value As Decimal)
            Me._ID_SUPERVISION_AF = Value
            Me.txtID_SUPERVISION_AF.Text = CStr(Value)
            If Me._ID_SUPERVISION_AF > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Property VerID_SUPERVISION_AF() As Boolean
        Get
            Return Me.trID_SUPERVISION_AF.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_SUPERVISION_AF.Visible = value
        End Set
    End Property

    Public Property VerID_MODALIDAD_FORMACION() As Boolean
        Get
            Return Me.trID_MODALIDAD_FORMACION.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_MODALIDAD_FORMACION.Visible = value
        End Set
    End Property

    Public Property VerID_ACCION_FORMATIVA() As Boolean
        Get
            Return Me.trID_ACCION_FORMATIVA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_ACCION_FORMATIVA.Visible = value
        End Set
    End Property

    Public Property VerFECHA() As Boolean
        Get
            Return Me.trFECHA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trFECHA.Visible = value
        End Set
    End Property

    Public Property VerNOMBRE_AF() As Boolean
        Get
            Return Me.trNOMBRE_AF.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trNOMBRE_AF.Visible = value
        End Set
    End Property

    Public Property VerCENTRO_FORMACION() As Boolean
        Get
            Return Me.trCENTRO_FORMACION.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trCENTRO_FORMACION.Visible = value
        End Set
    End Property

    Public Property VerOPCION() As Boolean
        Get
            Return Me.trOPCION.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trOPCION.Visible = value
        End Set
    End Property

    Public Property VerGRUPO() As Boolean
        Get
            Return Me.trGRUPO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trGRUPO.Visible = value
        End Set
    End Property

    Public Property VerHORARIO() As Boolean
        Get
            Return Me.trHORARIO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trHORARIO.Visible = value
        End Set
    End Property

    Public Property VerCODIGO() As Boolean
        Get
            Return Me.trCODIGO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trCODIGO.Visible = value
        End Set
    End Property

    Public Property VerCOORDINADOR_CFP() As Boolean
        Get
            Return Me.trCOORDINADOR_CFP.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trCOORDINADOR_CFP.Visible = value
        End Set
    End Property

    Public Property VerDIRECTOR_CFP() As Boolean
        Get
            Return Me.trDIRECTOR_CFP.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trDIRECTOR_CFP.Visible = value
        End Set
    End Property

    Public Property VerPARTICIPANTES_PRESENTES() As Boolean
        Get
            Return Me.trPARTICIPANTES_PRESENTES.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trPARTICIPANTES_PRESENTES.Visible = value
        End Set
    End Property

    Public Property VerPARTICIPANTES_AUSENTES() As Boolean
        Get
            Return Me.trPARTICIPANTES_AUSENTES.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trPARTICIPANTES_AUSENTES.Visible = value
        End Set
    End Property

    Public Property VerPARTICIPANTES_INSCRITOS() As Boolean
        Get
            Return Me.trPARTICIPANTES_INSCRITOS.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trPARTICIPANTES_INSCRITOS.Visible = value
        End Set
    End Property

    Public Property VerPARTICIPANTES_DESERTADOS() As Boolean
        Get
            Return Me.trPARTICIPANTES_DESERTADOS.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trPARTICIPANTES_DESERTADOS.Visible = value
        End Set
    End Property

    Public Property VerPARTICIPANTES_SUPLENTES() As Boolean
        Get
            Return Me.trPARTICIPANTES_SUPLENTES.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trPARTICIPANTES_SUPLENTES.Visible = value
        End Set
    End Property

    Public Property VerOBJETIVO_VISITA() As Boolean
        Get
            Return Me.trOBJETIVO_VISITA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trOBJETIVO_VISITA.Visible = value
        End Set
    End Property

    Public Property VerNOTAS() As Boolean
        Get
            Return Me.trNOTAS.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trNOTAS.Visible = value
        End Set
    End Property

    Public Property VerDURACION_VISITA() As Boolean
        Get
            Return Me.trDURACION_VISITA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trDURACION_VISITA.Visible = value
        End Set
    End Property

    Private _Enabled As Boolean = True
    Private _sError As String
    Private _nuevo As Boolean = False
    Private mComponente As New cSUPERVISION_AF
    Private mEntidad As SUPERVISION_AF
    Public Event ErrorEvent(ByVal errorMessage As String)

    Public ReadOnly Property sError() As String
        Get
            Return _sError
        End Get
    End Property
 
    Public Property Enabled() As Boolean
        Get
            Return Me._Enabled
        End Get
        Set(ByVal Value As Boolean)
            Me._Enabled = Value
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not Me.ViewState("nuevo") Is Nothing Then Me._nuevo = Me.ViewState("nuevo")
        If Not Me.ViewState("ID_SUPERVISION_AF") Is Nothing Then Me._ID_SUPERVISION_AF = Me.ViewState("ID_SUPERVISION_AF")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información del registro de la tabla SUPERVISION_AF
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()

        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")
        mEntidad = New SUPERVISION_AF
        mEntidad.ID_SUPERVISION_AF = ID_SUPERVISION_AF
 
        If mComponente.ObtenerSUPERVISION_AF(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtID_SUPERVISION_AF.Text = mEntidad.ID_SUPERVISION_AF.ToString()
        Me.ddlMODALIDAD_DE_FORMACION1.Recuperar()
        Me.ddlMODALIDAD_DE_FORMACION1.SelectedValue = mEntidad.ID_MODALIDAD_FORMACION
        Me.ddlACCION_FORMATIVA1.Recuperar()
        Me.ddlACCION_FORMATIVA1.SelectedValue = mEntidad.ID_ACCION_FORMATIVA
        Me.txtFECHA.Text = IIf(Not mEntidad.FECHA = Nothing, Format(mEntidad.FECHA, "dd/MM/yyyy"), "")
        Me.txtNOMBRE_AF.Text = mEntidad.NOMBRE_AF
        Me.txtCENTRO_FORMACION.Text = mEntidad.CENTRO_FORMACION
        Me.txtOPCION.Text = mEntidad.OPCION
        Me.txtGRUPO.Text = mEntidad.GRUPO
        Me.txtHORARIO.Text = mEntidad.HORARIO
        Me.txtCODIGO.Text = mEntidad.CODIGO
        Me.txtCOORDINADOR_CFP.Text = mEntidad.COORDINADOR_CFP
        Me.txtDIRECTOR_CFP.Text = mEntidad.DIRECTOR_CFP
        Me.txtPARTICIPANTES_PRESENTES.Text = mEntidad.PARTICIPANTES_PRESENTES
        Me.txtPARTICIPANTES_AUSENTES.Text = mEntidad.PARTICIPANTES_AUSENTES
        Me.txtPARTICIPANTES_INSCRITOS.Text = mEntidad.PARTICIPANTES_INSCRITOS
        Me.txtPARTICIPANTES_DESERTADOS.Text = mEntidad.PARTICIPANTES_DESERTADOS
        Me.txtPARTICIPANTES_SUPLENTES.Text = mEntidad.PARTICIPANTES_SUPLENTES
        Me.txtOBJETIVO_VISITA.Text = mEntidad.OBJETIVO_VISITA
        Me.txtNOTAS.Text = mEntidad.NOTAS
        Me.txtDURACION_VISITA.Text = mEntidad.DURACION_VISITA
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que permite Habilitar/Deshabilitar el uso de los controles contenidos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.ddlMODALIDAD_DE_FORMACION1.Enabled = edicion
        Me.ddlACCION_FORMATIVA1.Enabled = edicion
        Me.txtFECHA.Enabled = edicion
        Me.txtNOMBRE_AF.Enabled = edicion
        Me.txtCENTRO_FORMACION.Enabled = edicion
        Me.txtOPCION.Enabled = edicion
        Me.txtGRUPO.Enabled = edicion
        Me.txtHORARIO.Enabled = edicion
        Me.txtCODIGO.Enabled = edicion
        Me.txtCOORDINADOR_CFP.Enabled = edicion
        Me.txtDIRECTOR_CFP.Enabled = edicion
        Me.txtPARTICIPANTES_PRESENTES.Enabled = edicion
        Me.txtPARTICIPANTES_AUSENTES.Enabled = edicion
        Me.txtPARTICIPANTES_INSCRITOS.Enabled = edicion
        Me.txtPARTICIPANTES_DESERTADOS.Enabled = edicion
        Me.txtPARTICIPANTES_SUPLENTES.Enabled = edicion
        Me.txtOBJETIVO_VISITA.Enabled = edicion
        Me.txtNOTAS.Enabled = edicion
        Me.txtDURACION_VISITA.Enabled = edicion
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Configura si es un registro nuevo el cargado
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub Nuevo()
        Me._nuevo = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Me.ddlMODALIDAD_DE_FORMACION1.Recuperar()
        Me.ddlACCION_FORMATIVA1.Recuperar()
        Me.txtFECHA.Text = ""
        Me.txtNOMBRE_AF.Text = ""
        Me.txtCENTRO_FORMACION.Text = ""
        Me.txtOPCION.Text = ""
        Me.txtGRUPO.Text = ""
        Me.txtHORARIO.Text = ""
        Me.txtCODIGO.Text = ""
        Me.txtCOORDINADOR_CFP.Text = ""
        Me.txtDIRECTOR_CFP.Text = ""
        Me.txtPARTICIPANTES_PRESENTES.Text = ""
        Me.txtPARTICIPANTES_AUSENTES.Text = ""
        Me.txtPARTICIPANTES_INSCRITOS.Text = ""
        Me.txtPARTICIPANTES_DESERTADOS.Text = ""
        Me.txtPARTICIPANTES_SUPLENTES.Text = ""
        Me.txtOBJETIVO_VISITA.Text = ""
        Me.txtNOTAS.Text = ""
        Me.txtDURACION_VISITA.Text = ""
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Guarda la información del registro en la tabla SUPERVISION_AF
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim sError As New String("")
        Dim alDatos As New ArrayList
        mEntidad = New SUPERVISION_AF
        If Me._nuevo Then
            mEntidad.ID_SUPERVISION_AF = 0
        Else
            mEntidad.ID_SUPERVISION_AF = CInt(Me.txtID_SUPERVISION_AF.Text)
        End If
        mEntidad.ID_MODALIDAD_FORMACION = Me.ddlMODALIDAD_DE_FORMACION1.SelectedValue
        mEntidad.ID_ACCION_FORMATIVA = Me.ddlACCION_FORMATIVA1.SelectedValue
        If Me.txtFECHA.Text <> "" Then mEntidad.FECHA = System.DateTime.Parse(Me.txtFECHA.Text, New System.Globalization.CultureInfo("fr-FR", True),  _
                System.Globalization.DateTimeStyles.NoCurrentDateDefault)
        mEntidad.NOMBRE_AF = Me.txtNOMBRE_AF.Text
        mEntidad.CENTRO_FORMACION = Me.txtCENTRO_FORMACION.Text
        mEntidad.OPCION = Me.txtOPCION.Text
        mEntidad.GRUPO = Me.txtGRUPO.Text
        mEntidad.HORARIO = Me.txtHORARIO.Text
        mEntidad.CODIGO = Me.txtCODIGO.Text
        mEntidad.COORDINADOR_CFP = Me.txtCOORDINADOR_CFP.Text
        mEntidad.DIRECTOR_CFP = Me.txtDIRECTOR_CFP.Text
        mEntidad.PARTICIPANTES_PRESENTES = Val(Me.txtPARTICIPANTES_PRESENTES.Text)
        mEntidad.PARTICIPANTES_AUSENTES = Val(Me.txtPARTICIPANTES_AUSENTES.Text)
        mEntidad.PARTICIPANTES_INSCRITOS = Val(Me.txtPARTICIPANTES_INSCRITOS.Text)
        mEntidad.PARTICIPANTES_DESERTADOS = Val(Me.txtPARTICIPANTES_DESERTADOS.Text)
        mEntidad.PARTICIPANTES_SUPLENTES = Val(Me.txtPARTICIPANTES_SUPLENTES.Text)
        mEntidad.OBJETIVO_VISITA = Me.txtOBJETIVO_VISITA.Text
        mEntidad.NOTAS = Me.txtNOTAS.Text
        mEntidad.DURACION_VISITA = Val(Me.txtDURACION_VISITA.Text)

        If mComponente.ActualizarSUPERVISION_AF(mEntidad) <> 1 Then
            Me.AsignarMensaje("Error al Guardar registro.", True, True)
            Return "Error al Guardar registro."
        End If
        Me.txtID_SUPERVISION_AF.Text = mEntidad.ID_SUPERVISION_AF.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function
End Class
