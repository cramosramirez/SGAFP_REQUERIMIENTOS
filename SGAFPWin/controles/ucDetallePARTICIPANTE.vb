Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucDetallePARTICIPANTE
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	28/06/2012	Created
''' </history>
''' -----------------------------------------------------------------------------
Public Class ucDetallePARTICIPANTE

    Private _EsConsulta As Boolean = False
    <DefaultValue(False)> _
    Public Property EsConsulta() As Boolean
        Get
            Return Me._EsConsulta
        End Get
        Set(ByVal value As Boolean)
            Me._EsConsulta = value
            Me.HabilitarEdicion(Not value)
        End Set
    End Property

    Public ReadOnly Property Current() As PARTICIPANTE
        Get
            Return CType(Me.ListaPARTICIPANTEBindingSource.Current, PARTICIPANTE)
        End Get
    End Property

    Public Overrides Property DataSource() As System.Windows.Forms.BindingSource 
        Get 
            Return Me.ListaPARTICIPANTEBindingSource 
        End Get 
        Set(ByVal value As System.Windows.Forms.BindingSource) 
            Me.ListaPARTICIPANTEBindingSource = value 
        End Set 
    End Property 

    Private Sub ListaPARTICIPANTEBindingSource_CurrentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaPARTICIPANTEBindingSource.CurrentChanged
        Me.ID_PAIScbxPAIS.Recuperar()
        Me.ID_PAIScbxPAIS.SelectedValue = Me.Current.ID_PAIS
        Me.ID_ESTADO_CIVILcbxESTADO_CIVIL.Recuperar()
        Me.ID_ESTADO_CIVILcbxESTADO_CIVIL.SelectedValue = Me.Current.ID_ESTADO_CIVIL
        Me.CODIGO_DEPARTAMENTOcbxDEPARTAMENTO.Recuperar()
        Me.CODIGO_DEPARTAMENTOcbxDEPARTAMENTO.SelectedValue = Me.Current.CODIGO_DEPARTAMENTO
        Me.CODIGO_MUNICIPIOcbxMUNICIPIO.Recuperar(Me.CODIGO_DEPARTAMENTOCbxDEPARTAMENTO.SelectedValue)
        Me.CODIGO_MUNICIPIOcbxMUNICIPIO.SelectedValue = Me.Current.CODIGO_MUNICIPIO
        Me.ID_NIVEL_ACADEMICOcbxNIVEL_ACADEMICO.Recuperar()
        Me.ID_NIVEL_ACADEMICOcbxNIVEL_ACADEMICO.SelectedValue = Me.Current.ID_NIVEL_ACADEMICO
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que sobreescribe y realiza la acción de Guardar en la Base de Datos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/06/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Actualizar() As Integer 
        Dim mEntidad As New PARTICIPANTE 
        Me.ListaPARTICIPANTEBindingSource.EndEdit() 
        mEntidad = Me.Current 
        Dim mControl As New cPARTICIPANTE 
    	   If mControl.ActualizarPARTICIPANTE(mEntidad) < 1 Then 
            Me.AsignarMensaje("No se pudo guardar el registro", True) 
            Return -1 
        End If 
        Me.ID_PARTICIPANTETextEdit.Text = mEntidad.ID_PARTICIPANTE.ToString()
        Return 1 
    End Function 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que permite Habilitar/Deshabilitar el uso de los controles contenidos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/06/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.NOMBRESTextEdit.Enabled = edicion
        Me.APELLIDOSTextEdit.Enabled = edicion
        Me.GENEROTextEdit.Enabled = edicion
        Me.ID_PAIScbxPAIS.Enabled = edicion
        Me.FECHA_NACIMIENTODateEdit.Enabled = edicion
        Me.DIRECCIONTextEdit.Enabled = edicion
        Me.DUITextEdit.Enabled = edicion
        Me.NITTextEdit.Enabled = edicion
        Me.ISSSTextEdit.Enabled = edicion
        Me.TIPO_DOCTOSpinEdit.Enabled = edicion
        Me.NUM_DOCTOTextEdit.Enabled = edicion
        Me.TELEFONOTextEdit.Enabled = edicion
        Me.MOVILTextEdit.Enabled = edicion
        Me.EMAILTextEdit.Enabled = edicion
        Me.ID_ESTADO_CIVILcbxESTADO_CIVIL.Enabled = edicion
        Me.PROFESION_OFICIOTextEdit.Enabled = edicion
        Me.OCUPACION_ACTUALTextEdit.Enabled = edicion
        Me.TITULO_CERTIFICADO_OBTENIDOTextEdit.Enabled = edicion
        Me.DEPARTAMENTO_NACTextEdit.Enabled = edicion
        Me.MUNICIPIO_NACTextEdit.Enabled = edicion
        Me.CODIGO_DEPARTAMENTOcbxDEPARTAMENTO.Enabled = edicion
        Me.CODIGO_MUNICIPIOcbxMUNICIPIO.Enabled = edicion
        Me.ID_NIVEL_ACADEMICOcbxNIVEL_ACADEMICO.Enabled = edicion
        Me.OTRA_EDUCACION_FORMALTextEdit.Enabled = edicion
        Me.CON_DISCAPACIDADSpinEdit.Enabled = edicion
        Me.DISC_OTRATextEdit.Enabled = edicion
        Me.LASTUPDATEDateEdit.Enabled = edicion
        Me.USERIDTextEdit.Enabled = edicion
    End Sub

End Class
