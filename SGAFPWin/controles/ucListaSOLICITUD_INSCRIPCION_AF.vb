Imports SGAFP.EL
Public Class ucListaSOLICITUD_INSCRIPCION_AF

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.ListaBindingNavigator.BindingSource = Me.ListaSOLICITUD_INSCRIPCION_AFBindingSource
    End Sub

    Private mComponente As New cSOLICITUD_INSCRIPCION_AF
    Private _mListaSOLICITUD_INSCRIPCION_AF As New listaSOLICITUD_INSCRIPCION_AF
    Public Event CambioRegistro()
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
            Me.DataGridViewTextBoxID_SOLICITUD.Visible = value
        End Set
    End Property

    Private _VerFECHA_PRESENTACION As Boolean = True
    <DefaultValue(True)> _
    Public Property VerFECHA_PRESENTACION() As Boolean
        Get
            Return Me._VerFECHA_PRESENTACION
        End Get
        Set(ByVal value As Boolean)
            Me._VerFECHA_PRESENTACION = value
            Me.DataGridViewTextBoxFECHA_PRESENTACION.Visible = value
        End Set
    End Property

    Private _VerID_PARTICIPANTE As Boolean = True
    <DefaultValue(True)> _
    Public Property VerID_PARTICIPANTE() As Boolean
        Get
            Return Me._VerID_PARTICIPANTE
        End Get
        Set(ByVal value As Boolean)
            Me._VerID_PARTICIPANTE = value
            Me.DataGridViewTextBoxID_PARTICIPANTE.Visible = value
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

    Private _VerID_ESTADO_SOLICITUD As Boolean = True
    <DefaultValue(True)> _
    Public Property VerID_ESTADO_SOLICITUD() As Boolean
        Get
            Return Me._VerID_ESTADO_SOLICITUD
        End Get
        Set(ByVal value As Boolean)
            Me._VerID_ESTADO_SOLICITUD = value
            Me.DataGridViewTextBoxID_ESTADO_SOLICITUD.Visible = value
        End Set
    End Property

    Private _VerNUMERO_DOCUMENTO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerNUMERO_DOCUMENTO() As Boolean
        Get
            Return Me._VerNUMERO_DOCUMENTO
        End Get
        Set(ByVal value As Boolean)
            Me._VerNUMERO_DOCUMENTO = value
            Me.DataGridViewTextBoxNUMERO_DOCUMENTO.Visible = value
        End Set
    End Property

    Private _VerID_TIPO_SOLICITUD As Boolean = True
    <DefaultValue(True)> _
    Public Property VerID_TIPO_SOLICITUD() As Boolean
        Get
            Return Me._VerID_TIPO_SOLICITUD
        End Get
        Set(ByVal value As Boolean)
            Me._VerID_TIPO_SOLICITUD = value
            Me.DataGridViewTextBoxID_TIPO_SOLICITUD.Visible = value
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

    Private _VerCARGO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerCARGO() As Boolean
        Get
            Return Me._VerCARGO
        End Get
        Set(ByVal value As Boolean)
            Me._VerCARGO = value
            Me.DataGridViewTextBoxCARGO.Visible = value
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

    Private _VerNOMBRES As Boolean = True
    <DefaultValue(True)> _
    Public Property VerNOMBRES() As Boolean
        Get
            Return Me._VerNOMBRES
        End Get
        Set(ByVal value As Boolean)
            Me._VerNOMBRES = value
            Me.DataGridViewTextBoxNOMBRES.Visible = value
        End Set
    End Property

    Private _VerAPELLIDOS As Boolean = True
    <DefaultValue(True)> _
    Public Property VerAPELLIDOS() As Boolean
        Get
            Return Me._VerAPELLIDOS
        End Get
        Set(ByVal value As Boolean)
            Me._VerAPELLIDOS = value
            Me.DataGridViewTextBoxAPELLIDOS.Visible = value
        End Set
    End Property

    Private _VerLUGAR_NACIMIENTO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerLUGAR_NACIMIENTO() As Boolean
        Get
            Return Me._VerLUGAR_NACIMIENTO
        End Get
        Set(ByVal value As Boolean)
            Me._VerLUGAR_NACIMIENTO = value
            Me.DataGridViewTextBoxLUGAR_NACIMIENTO.Visible = value
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

    Private _VerTELEFONO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerTELEFONO() As Boolean
        Get
            Return Me._VerTELEFONO
        End Get
        Set(ByVal value As Boolean)
            Me._VerTELEFONO = value
            Me.DataGridViewTextBoxTELEFONO.Visible = value
        End Set
    End Property

    Private _VerMOVIL As Boolean = True
    <DefaultValue(True)> _
    Public Property VerMOVIL() As Boolean
        Get
            Return Me._VerMOVIL
        End Get
        Set(ByVal value As Boolean)
            Me._VerMOVIL = value
            Me.DataGridViewTextBoxMOVIL.Visible = value
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
            Me.DataGridViewTextBoxFAX.Visible = value
        End Set
    End Property

    Private _VerEMAIL As Boolean = True
    <DefaultValue(True)> _
    Public Property VerEMAIL() As Boolean
        Get
            Return Me._VerEMAIL
        End Get
        Set(ByVal value As Boolean)
            Me._VerEMAIL = value
            Me.DataGridViewTextBoxEMAIL.Visible = value
        End Set
    End Property

    Private _VerNIT As Boolean = True
    <DefaultValue(True)> _
    Public Property VerNIT() As Boolean
        Get
            Return Me._VerNIT
        End Get
        Set(ByVal value As Boolean)
            Me._VerNIT = value
            Me.DataGridViewTextBoxNIT.Visible = value
        End Set
    End Property

    Private _VerISSS As Boolean = True
    <DefaultValue(True)> _
    Public Property VerISSS() As Boolean
        Get
            Return Me._VerISSS
        End Get
        Set(ByVal value As Boolean)
            Me._VerISSS = value
            Me.DataGridViewTextBoxISSS.Visible = value
        End Set
    End Property

    Private _VerCIUO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerCIUO() As Boolean
        Get
            Return Me._VerCIUO
        End Get
        Set(ByVal value As Boolean)
            Me._VerCIUO = value
            Me.DataGridViewTextBoxCIUO.Visible = value
        End Set
    End Property

    Private _VerEDAD As Boolean = True
    <DefaultValue(True)> _
    Public Property VerEDAD() As Boolean
        Get
            Return Me._VerEDAD
        End Get
        Set(ByVal value As Boolean)
            Me._VerEDAD = value
            Me.DataGridViewTextBoxEDAD.Visible = value
        End Set
    End Property

    Private _VerDEPARTAMENTO_NAC As Boolean = True
    <DefaultValue(True)> _
    Public Property VerDEPARTAMENTO_NAC() As Boolean
        Get
            Return Me._VerDEPARTAMENTO_NAC
        End Get
        Set(ByVal value As Boolean)
            Me._VerDEPARTAMENTO_NAC = value
            Me.DataGridViewTextBoxDEPARTAMENTO_NAC.Visible = value
        End Set
    End Property

    Private _VerMUNICIPIO_NAC As Boolean = True
    <DefaultValue(True)> _
    Public Property VerMUNICIPIO_NAC() As Boolean
        Get
            Return Me._VerMUNICIPIO_NAC
        End Get
        Set(ByVal value As Boolean)
            Me._VerMUNICIPIO_NAC = value
            Me.DataGridViewTextBoxMUNICIPIO_NAC.Visible = value
        End Set
    End Property

    Private _VerFECHA_NACIMIENTO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerFECHA_NACIMIENTO() As Boolean
        Get
            Return Me._VerFECHA_NACIMIENTO
        End Get
        Set(ByVal value As Boolean)
            Me._VerFECHA_NACIMIENTO = value
            Me.DataGridViewTextBoxFECHA_NACIMIENTO.Visible = value
        End Set
    End Property

    Private _VerDUI As Boolean = True
    <DefaultValue(True)> _
    Public Property VerDUI() As Boolean
        Get
            Return Me._VerDUI
        End Get
        Set(ByVal value As Boolean)
            Me._VerDUI = value
            Me.DataGridViewTextBoxDUI.Visible = value
        End Set
    End Property

    Private _VerGENERO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerGENERO() As Boolean
        Get
            Return Me._VerGENERO
        End Get
        Set(ByVal value As Boolean)
            Me._VerGENERO = value
            Me.DataGridViewTextBoxGENERO.Visible = value
        End Set
    End Property

    Private _VerDIRECCION As Boolean = True
    <DefaultValue(True)> _
    Public Property VerDIRECCION() As Boolean
        Get
            Return Me._VerDIRECCION
        End Get
        Set(ByVal value As Boolean)
            Me._VerDIRECCION = value
            Me.DataGridViewTextBoxDIRECCION.Visible = value
        End Set
    End Property

    Private _VerPROFESION_OFICIO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerPROFESION_OFICIO() As Boolean
        Get
            Return Me._VerPROFESION_OFICIO
        End Get
        Set(ByVal value As Boolean)
            Me._VerPROFESION_OFICIO = value
            Me.DataGridViewTextBoxPROFESION_OFICIO.Visible = value
        End Set
    End Property

    Private _VerESTADO_CIVIL As Boolean = True
    <DefaultValue(True)> _
    Public Property VerESTADO_CIVIL() As Boolean
        Get
            Return Me._VerESTADO_CIVIL
        End Get
        Set(ByVal value As Boolean)
            Me._VerESTADO_CIVIL = value
            Me.DataGridViewTextBoxESTADO_CIVIL.Visible = value
        End Set
    End Property

    Private _VerNOMBRE_FAMILIAR As Boolean = True
    <DefaultValue(True)> _
    Public Property VerNOMBRE_FAMILIAR() As Boolean
        Get
            Return Me._VerNOMBRE_FAMILIAR
        End Get
        Set(ByVal value As Boolean)
            Me._VerNOMBRE_FAMILIAR = value
            Me.DataGridViewTextBoxNOMBRE_FAMILIAR.Visible = value
        End Set
    End Property

    Private _VerPARENTESCO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerPARENTESCO() As Boolean
        Get
            Return Me._VerPARENTESCO
        End Get
        Set(ByVal value As Boolean)
            Me._VerPARENTESCO = value
            Me.DataGridViewTextBoxPARENTESCO.Visible = value
        End Set
    End Property

    Private _VerDIRECCION_FAMILIAR As Boolean = True
    <DefaultValue(True)> _
    Public Property VerDIRECCION_FAMILIAR() As Boolean
        Get
            Return Me._VerDIRECCION_FAMILIAR
        End Get
        Set(ByVal value As Boolean)
            Me._VerDIRECCION_FAMILIAR = value
            Me.DataGridViewTextBoxDIRECCION_FAMILIAR.Visible = value
        End Set
    End Property

    Private _VerTELEFONO_FAMILIAR As Boolean = True
    <DefaultValue(True)> _
    Public Property VerTELEFONO_FAMILIAR() As Boolean
        Get
            Return Me._VerTELEFONO_FAMILIAR
        End Get
        Set(ByVal value As Boolean)
            Me._VerTELEFONO_FAMILIAR = value
            Me.DataGridViewTextBoxTELEFONO_FAMILIAR.Visible = value
        End Set
    End Property

    Private _VerOCUACT_TRABAJA As Boolean = True
    <DefaultValue(True)> _
    Public Property VerOCUACT_TRABAJA() As Boolean
        Get
            Return Me._VerOCUACT_TRABAJA
        End Get
        Set(ByVal value As Boolean)
            Me._VerOCUACT_TRABAJA = value
            Me.DataGridViewTextBoxOCUACT_TRABAJA.Visible = value
        End Set
    End Property

    Private _VerOCUACT_ESTUDIA As Boolean = True
    <DefaultValue(True)> _
    Public Property VerOCUACT_ESTUDIA() As Boolean
        Get
            Return Me._VerOCUACT_ESTUDIA
        End Get
        Set(ByVal value As Boolean)
            Me._VerOCUACT_ESTUDIA = value
            Me.DataGridViewTextBoxOCUACT_ESTUDIA.Visible = value
        End Set
    End Property

    Private _VerOCUACT_DESOCUPADO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerOCUACT_DESOCUPADO() As Boolean
        Get
            Return Me._VerOCUACT_DESOCUPADO
        End Get
        Set(ByVal value As Boolean)
            Me._VerOCUACT_DESOCUPADO = value
            Me.DataGridViewTextBoxOCUACT_DESOCUPADO.Visible = value
        End Set
    End Property

    Private _VerOCUACT_OFICIO_HOGAR As Boolean = True
    <DefaultValue(True)> _
    Public Property VerOCUACT_OFICIO_HOGAR() As Boolean
        Get
            Return Me._VerOCUACT_OFICIO_HOGAR
        End Get
        Set(ByVal value As Boolean)
            Me._VerOCUACT_OFICIO_HOGAR = value
            Me.DataGridViewTextBoxOCUACT_OFICIO_HOGAR.Visible = value
        End Set
    End Property

    Private _VerTIPTRA_EMPLEADO_EMPRESA As Boolean = True
    <DefaultValue(True)> _
    Public Property VerTIPTRA_EMPLEADO_EMPRESA() As Boolean
        Get
            Return Me._VerTIPTRA_EMPLEADO_EMPRESA
        End Get
        Set(ByVal value As Boolean)
            Me._VerTIPTRA_EMPLEADO_EMPRESA = value
            Me.DataGridViewTextBoxTIPTRA_EMPLEADO_EMPRESA.Visible = value
        End Set
    End Property

    Private _VerTIPTRA_EMPRESA_PROPIA As Boolean = True
    <DefaultValue(True)> _
    Public Property VerTIPTRA_EMPRESA_PROPIA() As Boolean
        Get
            Return Me._VerTIPTRA_EMPRESA_PROPIA
        End Get
        Set(ByVal value As Boolean)
            Me._VerTIPTRA_EMPRESA_PROPIA = value
            Me.DataGridViewTextBoxTIPTRA_EMPRESA_PROPIA.Visible = value
        End Set
    End Property

    Private _VerTIPTRA_EVENTUAL As Boolean = True
    <DefaultValue(True)> _
    Public Property VerTIPTRA_EVENTUAL() As Boolean
        Get
            Return Me._VerTIPTRA_EVENTUAL
        End Get
        Set(ByVal value As Boolean)
            Me._VerTIPTRA_EVENTUAL = value
            Me.DataGridViewTextBoxTIPTRA_EVENTUAL.Visible = value
        End Set
    End Property

    Private _VerTIPTRA_MEDIO_TIEMPO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerTIPTRA_MEDIO_TIEMPO() As Boolean
        Get
            Return Me._VerTIPTRA_MEDIO_TIEMPO
        End Get
        Set(ByVal value As Boolean)
            Me._VerTIPTRA_MEDIO_TIEMPO = value
            Me.DataGridViewTextBoxTIPTRA_MEDIO_TIEMPO.Visible = value
        End Set
    End Property

    Private _VerTIPTRA_INDEPENDIENTE As Boolean = True
    <DefaultValue(True)> _
    Public Property VerTIPTRA_INDEPENDIENTE() As Boolean
        Get
            Return Me._VerTIPTRA_INDEPENDIENTE
        End Get
        Set(ByVal value As Boolean)
            Me._VerTIPTRA_INDEPENDIENTE = value
            Me.DataGridViewTextBoxTIPTRA_INDEPENDIENTE.Visible = value
        End Set
    End Property

    Private _VerRTC_OCUPACION_EMPRESA As Boolean = True
    <DefaultValue(True)> _
    Public Property VerRTC_OCUPACION_EMPRESA() As Boolean
        Get
            Return Me._VerRTC_OCUPACION_EMPRESA
        End Get
        Set(ByVal value As Boolean)
            Me._VerRTC_OCUPACION_EMPRESA = value
            Me.DataGridViewTextBoxRTC_OCUPACION_EMPRESA.Visible = value
        End Set
    End Property

    Private _VerRTC_PROPIA_EMPRESA As Boolean = True
    <DefaultValue(True)> _
    Public Property VerRTC_PROPIA_EMPRESA() As Boolean
        Get
            Return Me._VerRTC_PROPIA_EMPRESA
        End Get
        Set(ByVal value As Boolean)
            Me._VerRTC_PROPIA_EMPRESA = value
            Me.DataGridViewTextBoxRTC_PROPIA_EMPRESA.Visible = value
        End Set
    End Property

    Private _VerRTC_TRABAJO_EVENTUAL As Boolean = True
    <DefaultValue(True)> _
    Public Property VerRTC_TRABAJO_EVENTUAL() As Boolean
        Get
            Return Me._VerRTC_TRABAJO_EVENTUAL
        End Get
        Set(ByVal value As Boolean)
            Me._VerRTC_TRABAJO_EVENTUAL = value
            Me.DataGridViewTextBoxRTC_TRABAJO_EVENTUAL.Visible = value
        End Set
    End Property

    Private _VerRTC_TRABAJO_MEDIO_TIEMPO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerRTC_TRABAJO_MEDIO_TIEMPO() As Boolean
        Get
            Return Me._VerRTC_TRABAJO_MEDIO_TIEMPO
        End Get
        Set(ByVal value As Boolean)
            Me._VerRTC_TRABAJO_MEDIO_TIEMPO = value
            Me.DataGridViewTextBoxRTC_TRABAJO_MEDIO_TIEMPO.Visible = value
        End Set
    End Property

    Private _VerRTC_INDEPENDIENTE As Boolean = True
    <DefaultValue(True)> _
    Public Property VerRTC_INDEPENDIENTE() As Boolean
        Get
            Return Me._VerRTC_INDEPENDIENTE
        End Get
        Set(ByVal value As Boolean)
            Me._VerRTC_INDEPENDIENTE = value
            Me.DataGridViewTextBoxRTC_INDEPENDIENTE.Visible = value
        End Set
    End Property

    Private _VerRTC_NO_OCUPACION_EMPRESA As Boolean = True
    <DefaultValue(True)> _
    Public Property VerRTC_NO_OCUPACION_EMPRESA() As Boolean
        Get
            Return Me._VerRTC_NO_OCUPACION_EMPRESA
        End Get
        Set(ByVal value As Boolean)
            Me._VerRTC_NO_OCUPACION_EMPRESA = value
            Me.DataGridViewTextBoxRTC_NO_OCUPACION_EMPRESA.Visible = value
        End Set
    End Property

    Private _VerRTC_NO_PROPIA_EMPRESA As Boolean = True
    <DefaultValue(True)> _
    Public Property VerRTC_NO_PROPIA_EMPRESA() As Boolean
        Get
            Return Me._VerRTC_NO_PROPIA_EMPRESA
        End Get
        Set(ByVal value As Boolean)
            Me._VerRTC_NO_PROPIA_EMPRESA = value
            Me.DataGridViewTextBoxRTC_NO_PROPIA_EMPRESA.Visible = value
        End Set
    End Property

    Private _VerRTC_NO_TRABAJO_EVENTUAL As Boolean = True
    <DefaultValue(True)> _
    Public Property VerRTC_NO_TRABAJO_EVENTUAL() As Boolean
        Get
            Return Me._VerRTC_NO_TRABAJO_EVENTUAL
        End Get
        Set(ByVal value As Boolean)
            Me._VerRTC_NO_TRABAJO_EVENTUAL = value
            Me.DataGridViewTextBoxRTC_NO_TRABAJO_EVENTUAL.Visible = value
        End Set
    End Property

    Private _VerRTC_NO_TRABAJO_MEDIO_TIEMPO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerRTC_NO_TRABAJO_MEDIO_TIEMPO() As Boolean
        Get
            Return Me._VerRTC_NO_TRABAJO_MEDIO_TIEMPO
        End Get
        Set(ByVal value As Boolean)
            Me._VerRTC_NO_TRABAJO_MEDIO_TIEMPO = value
            Me.DataGridViewTextBoxRTC_NO_TRABAJO_MEDIO_TIEMPO.Visible = value
        End Set
    End Property

    Private _VerRTC_NO_INDEPENDIENTE As Boolean = True
    <DefaultValue(True)> _
    Public Property VerRTC_NO_INDEPENDIENTE() As Boolean
        Get
            Return Me._VerRTC_NO_INDEPENDIENTE
        End Get
        Set(ByVal value As Boolean)
            Me._VerRTC_NO_INDEPENDIENTE = value
            Me.DataGridViewTextBoxRTC_NO_INDEPENDIENTE.Visible = value
        End Set
    End Property

    Private _VerNIVEL_ACADEMICO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerNIVEL_ACADEMICO() As Boolean
        Get
            Return Me._VerNIVEL_ACADEMICO
        End Get
        Set(ByVal value As Boolean)
            Me._VerNIVEL_ACADEMICO = value
            Me.DataGridViewTextBoxNIVEL_ACADEMICO.Visible = value
        End Set
    End Property

    Private _VerTITULO_CERTIFICADO_OBTENIDO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerTITULO_CERTIFICADO_OBTENIDO() As Boolean
        Get
            Return Me._VerTITULO_CERTIFICADO_OBTENIDO
        End Get
        Set(ByVal value As Boolean)
            Me._VerTITULO_CERTIFICADO_OBTENIDO = value
            Me.DataGridViewTextBoxTITULO_CERTIFICADO_OBTENIDO.Visible = value
        End Set
    End Property

    Private _VerTIEMPO_DEJO_ESTUDIAR As Boolean = True
    <DefaultValue(True)> _
    Public Property VerTIEMPO_DEJO_ESTUDIAR() As Boolean
        Get
            Return Me._VerTIEMPO_DEJO_ESTUDIAR
        End Get
        Set(ByVal value As Boolean)
            Me._VerTIEMPO_DEJO_ESTUDIAR = value
            Me.DataGridViewTextBoxTIEMPO_DEJO_ESTUDIAR.Visible = value
        End Set
    End Property

    Private _VerRECIBIO_CURSO_ANTERIOR As Boolean = True
    <DefaultValue(True)> _
    Public Property VerRECIBIO_CURSO_ANTERIOR() As Boolean
        Get
            Return Me._VerRECIBIO_CURSO_ANTERIOR
        End Get
        Set(ByVal value As Boolean)
            Me._VerRECIBIO_CURSO_ANTERIOR = value
            Me.DataGridViewTextBoxRECIBIO_CURSO_ANTERIOR.Visible = value
        End Set
    End Property

    Private _VerOBTUVO_BENEFICIOS_CURSO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerOBTUVO_BENEFICIOS_CURSO() As Boolean
        Get
            Return Me._VerOBTUVO_BENEFICIOS_CURSO
        End Get
        Set(ByVal value As Boolean)
            Me._VerOBTUVO_BENEFICIOS_CURSO = value
            Me.DataGridViewTextBoxOBTUVO_BENEFICIOS_CURSO.Visible = value
        End Set
    End Property

    Private _VerBENEF_PROM_EMP_ACT As Boolean = True
    <DefaultValue(True)> _
    Public Property VerBENEF_PROM_EMP_ACT() As Boolean
        Get
            Return Me._VerBENEF_PROM_EMP_ACT
        End Get
        Set(ByVal value As Boolean)
            Me._VerBENEF_PROM_EMP_ACT = value
            Me.DataGridViewTextBoxBENEF_PROM_EMP_ACT.Visible = value
        End Set
    End Property

    Private _VerBENEF_OBT_EMPLEO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerBENEF_OBT_EMPLEO() As Boolean
        Get
            Return Me._VerBENEF_OBT_EMPLEO
        End Get
        Set(ByVal value As Boolean)
            Me._VerBENEF_OBT_EMPLEO = value
            Me.DataGridViewTextBoxBENEF_OBT_EMPLEO.Visible = value
        End Set
    End Property

    Private _VerBENEF_OBT_ING_EXTRA As Boolean = True
    <DefaultValue(True)> _
    Public Property VerBENEF_OBT_ING_EXTRA() As Boolean
        Get
            Return Me._VerBENEF_OBT_ING_EXTRA
        End Get
        Set(ByVal value As Boolean)
            Me._VerBENEF_OBT_ING_EXTRA = value
            Me.DataGridViewTextBoxBENEF_OBT_ING_EXTRA.Visible = value
        End Set
    End Property

    Private _VerBENEF_CAMB_EMP_X_CURSO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerBENEF_CAMB_EMP_X_CURSO() As Boolean
        Get
            Return Me._VerBENEF_CAMB_EMP_X_CURSO
        End Get
        Set(ByVal value As Boolean)
            Me._VerBENEF_CAMB_EMP_X_CURSO = value
            Me.DataGridViewTextBoxBENEF_CAMB_EMP_X_CURSO.Visible = value
        End Set
    End Property

    Private _VerBENEF_TRAB_CTA_PROPIA As Boolean = True
    <DefaultValue(True)> _
    Public Property VerBENEF_TRAB_CTA_PROPIA() As Boolean
        Get
            Return Me._VerBENEF_TRAB_CTA_PROPIA
        End Get
        Set(ByVal value As Boolean)
            Me._VerBENEF_TRAB_CTA_PROPIA = value
            Me.DataGridViewTextBoxBENEF_TRAB_CTA_PROPIA.Visible = value
        End Set
    End Property

    Private _VerBENEF_OTRO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerBENEF_OTRO() As Boolean
        Get
            Return Me._VerBENEF_OTRO
        End Get
        Set(ByVal value As Boolean)
            Me._VerBENEF_OTRO = value
            Me.DataGridViewTextBoxBENEF_OTRO.Visible = value
        End Set
    End Property

    Private _VerRAZON_NO_BENEFICIO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerRAZON_NO_BENEFICIO() As Boolean
        Get
            Return Me._VerRAZON_NO_BENEFICIO
        End Get
        Set(ByVal value As Boolean)
            Me._VerRAZON_NO_BENEFICIO = value
            Me.DataGridViewTextBoxRAZON_NO_BENEFICIO.Visible = value
        End Set
    End Property

    Private _VerTRABAJA_ACTUALMENTE As Boolean = True
    <DefaultValue(True)> _
    Public Property VerTRABAJA_ACTUALMENTE() As Boolean
        Get
            Return Me._VerTRABAJA_ACTUALMENTE
        End Get
        Set(ByVal value As Boolean)
            Me._VerTRABAJA_ACTUALMENTE = value
            Me.DataGridViewTextBoxTRABAJA_ACTUALMENTE.Visible = value
        End Set
    End Property

    Private _VerTRABAJO_ANTERIOR As Boolean = True
    <DefaultValue(True)> _
    Public Property VerTRABAJO_ANTERIOR() As Boolean
        Get
            Return Me._VerTRABAJO_ANTERIOR
        End Get
        Set(ByVal value As Boolean)
            Me._VerTRABAJO_ANTERIOR = value
            Me.DataGridViewTextBoxTRABAJO_ANTERIOR.Visible = value
        End Set
    End Property

    Private _VerEXPFOR_PROMOCION_EMPLEO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerEXPFOR_PROMOCION_EMPLEO() As Boolean
        Get
            Return Me._VerEXPFOR_PROMOCION_EMPLEO
        End Get
        Set(ByVal value As Boolean)
            Me._VerEXPFOR_PROMOCION_EMPLEO = value
            Me.DataGridViewTextBoxEXPFOR_PROMOCION_EMPLEO.Visible = value
        End Set
    End Property

    Private _VerEXPFOR_CAMBIAR_EMPLEO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerEXPFOR_CAMBIAR_EMPLEO() As Boolean
        Get
            Return Me._VerEXPFOR_CAMBIAR_EMPLEO
        End Get
        Set(ByVal value As Boolean)
            Me._VerEXPFOR_CAMBIAR_EMPLEO = value
            Me.DataGridViewTextBoxEXPFOR_CAMBIAR_EMPLEO.Visible = value
        End Set
    End Property

    Private _VerEXPFOR_OBTENER_EMPLEO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerEXPFOR_OBTENER_EMPLEO() As Boolean
        Get
            Return Me._VerEXPFOR_OBTENER_EMPLEO
        End Get
        Set(ByVal value As Boolean)
            Me._VerEXPFOR_OBTENER_EMPLEO = value
            Me.DataGridViewTextBoxEXPFOR_OBTENER_EMPLEO.Visible = value
        End Set
    End Property

    Private _VerEXPFOR_TRABAJAR_CTA_PROPIA As Boolean = True
    <DefaultValue(True)> _
    Public Property VerEXPFOR_TRABAJAR_CTA_PROPIA() As Boolean
        Get
            Return Me._VerEXPFOR_TRABAJAR_CTA_PROPIA
        End Get
        Set(ByVal value As Boolean)
            Me._VerEXPFOR_TRABAJAR_CTA_PROPIA = value
            Me.DataGridViewTextBoxEXPFOR_TRABAJAR_CTA_PROPIA.Visible = value
        End Set
    End Property

    Private _VerEXPFOR_INGRESOS_EXTRAS As Boolean = True
    <DefaultValue(True)> _
    Public Property VerEXPFOR_INGRESOS_EXTRAS() As Boolean
        Get
            Return Me._VerEXPFOR_INGRESOS_EXTRAS
        End Get
        Set(ByVal value As Boolean)
            Me._VerEXPFOR_INGRESOS_EXTRAS = value
            Me.DataGridViewTextBoxEXPFOR_INGRESOS_EXTRAS.Visible = value
        End Set
    End Property

    Private _VerEXPFOR_OTRO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerEXPFOR_OTRO() As Boolean
        Get
            Return Me._VerEXPFOR_OTRO
        End Get
        Set(ByVal value As Boolean)
            Me._VerEXPFOR_OTRO = value
            Me.DataGridViewTextBoxEXPFOR_OTRO.Visible = value
        End Set
    End Property

    Private _VerINGRESO_MENSUAL_INDIVIDUAL As Boolean = True
    <DefaultValue(True)> _
    Public Property VerINGRESO_MENSUAL_INDIVIDUAL() As Boolean
        Get
            Return Me._VerINGRESO_MENSUAL_INDIVIDUAL
        End Get
        Set(ByVal value As Boolean)
            Me._VerINGRESO_MENSUAL_INDIVIDUAL = value
            Me.DataGridViewTextBoxINGRESO_MENSUAL_INDIVIDUAL.Visible = value
        End Set
    End Property

    Private _VerINGRESO_MENSUAL_FAMILIAR As Boolean = True
    <DefaultValue(True)> _
    Public Property VerINGRESO_MENSUAL_FAMILIAR() As Boolean
        Get
            Return Me._VerINGRESO_MENSUAL_FAMILIAR
        End Get
        Set(ByVal value As Boolean)
            Me._VerINGRESO_MENSUAL_FAMILIAR = value
            Me.DataGridViewTextBoxINGRESO_MENSUAL_FAMILIAR.Visible = value
        End Set
    End Property

    Private _VerMIEMBROS_GRUPO_FAMILIAR As Boolean = True
    <DefaultValue(True)> _
    Public Property VerMIEMBROS_GRUPO_FAMILIAR() As Boolean
        Get
            Return Me._VerMIEMBROS_GRUPO_FAMILIAR
        End Get
        Set(ByVal value As Boolean)
            Me._VerMIEMBROS_GRUPO_FAMILIAR = value
            Me.DataGridViewTextBoxMIEMBROS_GRUPO_FAMILIAR.Visible = value
        End Set
    End Property

    Private _VerSUGERENCIAS As Boolean = True
    <DefaultValue(True)> _
    Public Property VerSUGERENCIAS() As Boolean
        Get
            Return Me._VerSUGERENCIAS
        End Get
        Set(ByVal value As Boolean)
            Me._VerSUGERENCIAS = value
            Me.DataGridViewTextBoxSUGERENCIAS.Visible = value
        End Set
    End Property

    Private _VerLUGAR_PRESENTACION As Boolean = True
    <DefaultValue(True)> _
    Public Property VerLUGAR_PRESENTACION() As Boolean
        Get
            Return Me._VerLUGAR_PRESENTACION
        End Get
        Set(ByVal value As Boolean)
            Me._VerLUGAR_PRESENTACION = value
            Me.DataGridViewTextBoxLUGAR_PRESENTACION.Visible = value
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

    #End Region

    Public ReadOnly Property Current() As SOLICITUD_INSCRIPCION_AF
        Get
            Return CType(Me.ListaSOLICITUD_INSCRIPCION_AFBindingSource.Current, SOLICITUD_INSCRIPCION_AF)
        End Get
    End Property

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla SOLICITUD_INSCRIPCION_AF
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        _mListaSOLICITUD_INSCRIPCION_AF = Me.mComponente.ObtenerLista()
        If _mListaSOLICITUD_INSCRIPCION_AF Is Nothing Then Return -1
        Me.ListaSOLICITUD_INSCRIPCION_AFBindingSource.DataSource = _mListaSOLICITUD_INSCRIPCION_AF
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla SOLICITUD_INSCRIPCION_AF
    ''' filtrado por la tabla PARTICIPANTE
    ''' </summary>
    ''' <param name="ID_PARTICIPANTE"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorPARTICIPANTE(ByVal ID_PARTICIPANTE As Decimal) As Integer
        _mListaSOLICITUD_INSCRIPCION_AF = Me.mComponente.ObtenerListaPorPARTICIPANTE(ID_PARTICIPANTE)
        If _mListaSOLICITUD_INSCRIPCION_AF Is Nothing Then Return -1
        Me.ListaSOLICITUD_INSCRIPCION_AFBindingSource.DataSource = _mListaSOLICITUD_INSCRIPCION_AF
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla SOLICITUD_INSCRIPCION_AF
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
        _mListaSOLICITUD_INSCRIPCION_AF = Me.mComponente.ObtenerListaPorACCION_FORMATIVA(ID_ACCION_FORMATIVA)
        If _mListaSOLICITUD_INSCRIPCION_AF Is Nothing Then Return -1
        Me.ListaSOLICITUD_INSCRIPCION_AFBindingSource.DataSource = _mListaSOLICITUD_INSCRIPCION_AF
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla SOLICITUD_INSCRIPCION_AF
    ''' filtrado por la tabla ESTADO_SOLICITUD
    ''' </summary>
    ''' <param name="ID_ESTADO_SOLICITUD"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorESTADO_SOLICITUD(ByVal ID_ESTADO_SOLICITUD As Decimal) As Integer
        _mListaSOLICITUD_INSCRIPCION_AF = Me.mComponente.ObtenerListaPorESTADO_SOLICITUD(ID_ESTADO_SOLICITUD)
        If _mListaSOLICITUD_INSCRIPCION_AF Is Nothing Then Return -1
        Me.ListaSOLICITUD_INSCRIPCION_AFBindingSource.DataSource = _mListaSOLICITUD_INSCRIPCION_AF
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla SOLICITUD_INSCRIPCION_AF
    ''' filtrado por la tabla TIPO_SOLICITUD
    ''' </summary>
    ''' <param name="ID_TIPO_SOLICITUD"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorTIPO_SOLICITUD(ByVal ID_TIPO_SOLICITUD As Decimal) As Integer
        _mListaSOLICITUD_INSCRIPCION_AF = Me.mComponente.ObtenerListaPorTIPO_SOLICITUD(ID_TIPO_SOLICITUD)
        If _mListaSOLICITUD_INSCRIPCION_AF Is Nothing Then Return -1
        Me.ListaSOLICITUD_INSCRIPCION_AFBindingSource.DataSource = _mListaSOLICITUD_INSCRIPCION_AF
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla SOLICITUD_INSCRIPCION_AF
    ''' filtrado por la tabla NIVEL_ACADEMICO
    ''' </summary>
    ''' <param name="NIVEL_ACADEMICO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorNIVEL_ACADEMICO(ByVal NIVEL_ACADEMICO As String) As Integer
        _mListaSOLICITUD_INSCRIPCION_AF = Me.mComponente.ObtenerListaPorNIVEL_ACADEMICO(NIVEL_ACADEMICO)
        If _mListaSOLICITUD_INSCRIPCION_AF Is Nothing Then Return -1
        Me.ListaSOLICITUD_INSCRIPCION_AFBindingSource.DataSource = _mListaSOLICITUD_INSCRIPCION_AF
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
        If Not Me.ListaSOLICITUD_INSCRIPCION_AFBindingSource.Current Is Nothing Then
            If Me.Current.ID_SOLICITUD = 0 Then Return 0
        End If
        If MyBase.Eliminar() = 0 Then Return 0
        If Not Me.ListaSOLICITUD_INSCRIPCION_AFBindingSource.Current Is Nothing Then
            If mComponente.EliminarSOLICITUD_INSCRIPCION_AF( Me.Current.ID_SOLICITUD) <> 1 Then
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
        If Not Me.ListaSOLICITUD_INSCRIPCION_AFBindingSource.Current Is Nothing Then
            Me.ListaSOLICITUD_INSCRIPCION_AFBindingSource.EndEdit()
            If Not Me.Current.IsDirty Then Return 0
            Select Case mComponente.ActualizarSOLICITUD_INSCRIPCION_AF(Me.Current)
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

    Private Sub ListaSOLICITUD_INSCRIPCION_AFBindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles ListaSOLICITUD_INSCRIPCION_AFBindingSource.AddingNew
        Dim lEntidad As New SOLICITUD_INSCRIPCION_AF
        e.NewObject = lEntidad
    End Sub

    Private Sub ListaSOLICITUD_INSCRIPCION_AFBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaSOLICITUD_INSCRIPCION_AFBindingSource.PositionChanged
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
        Me.ListaSOLICITUD_INSCRIPCION_AFDataGridView.AllowUserToAddRows = Me.PermitirAgregar
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
        Me.ListaSOLICITUD_INSCRIPCION_AFDataGridView.AllowUserToDeleteRows = Me.PermitirEliminar
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
            Me.ListaSOLICITUD_INSCRIPCION_AFDataGridView.Dock = DockStyle.None
            Me.ListaSOLICITUD_INSCRIPCION_AFDataGridView.Size = New Size(Me.Size.Width, Me.Size.Height - Me.ListaBindingNavigator.Size.Height)
            Me.ListaSOLICITUD_INSCRIPCION_AFDataGridView.Location = New Point(1, Me.ListaBindingNavigator.Size.Height + 1)
        Else
            Me.ListaSOLICITUD_INSCRIPCION_AFDataGridView.Dock = DockStyle.Fill
        End If
    End Sub

End Class
