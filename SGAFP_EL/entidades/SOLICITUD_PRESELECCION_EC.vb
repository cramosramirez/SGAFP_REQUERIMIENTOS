''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.SOLICITUD_PRESELECCION_EC
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row SOLICITUD_PRESELECCION_EC en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	21/08/2019	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="SOLICITUD_PRESELECCION_EC")> Public Class SOLICITUD_PRESELECCION_EC
    Inherits entidadBase
    Implements IEquatable(Of SOLICITUD_PRESELECCION_EC), IComparable(Of SOLICITUD_PRESELECCION_EC)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_SOLIC_PRESELEC As Decimal, aFECHA_PRESENTACION As DateTime, aID_PARTICIPANTE As Decimal, aID_ESTADO_SOLICITUD As Decimal, aID_GRUPO_SELEC As Decimal, aID_TIPO_SELECC As Decimal, aNOMBRES As String, aAPELLIDOS As String, aDUI As String, aTIPO_DOCTO As Decimal, aNUM_DOCTO As String, aNIT As String, aISSS As String, aID_PAIS As Decimal, aDEPARTAMENTO_NAC As String, aMUNICIPIO_NAC As String, aFECHA_NACIMIENTO As DateTime, aGENERO As String, aEDAD As Decimal, aMIEMBROS_GRUPO_FAMILIAR As Decimal, aID_ESTADO_CIVIL As Decimal, aES_JEFE_HOGAR As Decimal, aTIENE_HIJOS As Decimal, aNO_DE_HIJOS As Decimal, aSE_DEDICA_ALGUNA_PROFESION As Decimal, aPROFESION_OFICIO As String, aDIRECCION As String, aCODIGO_DEPARTAMENTO As String, aCODIGO_MUNICIPIO As String, aTELEFONO As String, aMOVIL As String, aEMAIL As String, aCON_DISCAPACIDAD As Decimal, aDISC_OTRA As String, aID_NIVEL_ACADEMICO As Decimal, aOTRA_EDUCACION_FORMAL As String, aTITULO_CERTIFICADO_OBTENIDO As String, aESTUDIA_ACTUALMENTE As Decimal, aID_TIEMPO_DEJO_ESTUDIAR As Decimal, aID_MOTIVO_DEJO_ESTU As Decimal, aOTRO_MOTIVO_DEJO_ESTU As String, aRECIBIO_CURSO_ANTERIOR As String, aBENEF_PROM_EMP_ACT As Decimal, aBENEF_OBT_EMPLEO As Decimal, aBENEF_OBT_ING_EXTRA As Decimal, aBENEF_CAMB_EMP_X_CURSO As Decimal, aBENEF_TRAB_CTA_PROPIA As Decimal, aBENEF_OTRO As String, aRAZON_NO_BENEFICIO As String, aOCUACT_TRABAJA As Decimal, aOCUACT_ESTUDIA As Decimal, aOCUACT_ESTU_TRAB As Decimal, aOCUACT_OFICIO_HOGAR As Decimal, aOCUACT_BUSCA_TRAB As Decimal, aOCUACT_OTRA As String, aRECIBE_INGRESOS As Decimal, aMANERA_OBT_ING_TRABAJO As Decimal, aMANERA_OBT_ING_BECA As Decimal, aMANERA_OBT_ING_AYUDA_FAM As Decimal, aMANERA_OBT_ING_REMESA As Decimal, aMANERA_OBT_ING_OTRO As String, aID_INGRESO_MES As Decimal, aID_TIEMPO_NOTRAB As Decimal, aID_ACTI_ECONOMICA As Decimal, aID_AREA_EMPRESA As Decimal, aID_MOTIVO_DEJO_TRAB As Decimal, aEXPFOR_OBTENER_EMPLEO As Decimal, aEXPFOR_INGRESOS_EXTRAS As Decimal, aEXPFOR_TRABAJAR_CTA_PROPIA As Decimal, aEXPFOR_OTRO As String, aMOTIVO_ELIGIO_CARRERA As String, aNOMBRE_REFERENCIA As String, aID_REFERENCIA As Decimal, aDIRECCION_REFERENCIA As String, aDEPARTAMENTO_REFERENCIA As String, aMUNICIPIO_REFERENCIA As String, aTELEFONO_REFERENCIA As String, aMOVIL_REFERENCIA As String, aEMAIL_REFERENCIA As String, aSUGERENCIAS As String, aUSUARIO_CREA As String, aFECHA_CREACION As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime, aTIPO_EMPLEO_OTRO As String, aTRABAJO_ANTERIOR As String, aPUESTO_DESEMPENO As String, aID_ULT_SALARIO_MES As Decimal, aES_RECLUTA_INICIAL As Decimal, aES_RECLUTA_EXTRA As Decimal, aREQUI_AUTORIZACION As Decimal, aOBSERVACION_AURIZACION As String, aAUTORIZADO As Decimal, aMOTIVO_AUTORIZADO As String, aUSUARIO_AUTORIZO As String, aFECHA_AITORIZA As DateTime)
        Me._ID_SOLIC_PRESELEC = aID_SOLIC_PRESELEC
        Me._FECHA_PRESENTACION = aFECHA_PRESENTACION
        Me._ID_PARTICIPANTE = aID_PARTICIPANTE
        Me._ID_ESTADO_SOLICITUD = aID_ESTADO_SOLICITUD
        Me._ID_GRUPO_SELEC = aID_GRUPO_SELEC
        Me._ID_TIPO_SELECC = aID_TIPO_SELECC
        Me._NOMBRES = aNOMBRES
        Me._APELLIDOS = aAPELLIDOS
        Me._DUI = aDUI
        Me._TIPO_DOCTO = aTIPO_DOCTO
        Me._NUM_DOCTO = aNUM_DOCTO
        Me._NIT = aNIT
        Me._ISSS = aISSS
        Me._ID_PAIS = aID_PAIS
        Me._DEPARTAMENTO_NAC = aDEPARTAMENTO_NAC
        Me._MUNICIPIO_NAC = aMUNICIPIO_NAC
        Me._FECHA_NACIMIENTO = aFECHA_NACIMIENTO
        Me._GENERO = aGENERO
        Me._EDAD = aEDAD
        Me._MIEMBROS_GRUPO_FAMILIAR = aMIEMBROS_GRUPO_FAMILIAR
        Me._ID_ESTADO_CIVIL = aID_ESTADO_CIVIL
        Me._ES_JEFE_HOGAR = aES_JEFE_HOGAR
        Me._TIENE_HIJOS = aTIENE_HIJOS
        Me._NO_DE_HIJOS = aNO_DE_HIJOS
        Me._SE_DEDICA_ALGUNA_PROFESION = aSE_DEDICA_ALGUNA_PROFESION
        Me._PROFESION_OFICIO = aPROFESION_OFICIO
        Me._DIRECCION = aDIRECCION
        Me._CODIGO_DEPARTAMENTO = aCODIGO_DEPARTAMENTO
        Me._CODIGO_MUNICIPIO = aCODIGO_MUNICIPIO
        Me._TELEFONO = aTELEFONO
        Me._MOVIL = aMOVIL
        Me._EMAIL = aEMAIL
        Me._CON_DISCAPACIDAD = aCON_DISCAPACIDAD
        Me._DISC_OTRA = aDISC_OTRA
        Me._ID_NIVEL_ACADEMICO = aID_NIVEL_ACADEMICO
        Me._OTRA_EDUCACION_FORMAL = aOTRA_EDUCACION_FORMAL
        Me._TITULO_CERTIFICADO_OBTENIDO = aTITULO_CERTIFICADO_OBTENIDO
        Me._ESTUDIA_ACTUALMENTE = aESTUDIA_ACTUALMENTE
        Me._ID_TIEMPO_DEJO_ESTUDIAR = aID_TIEMPO_DEJO_ESTUDIAR
        Me._ID_MOTIVO_DEJO_ESTU = aID_MOTIVO_DEJO_ESTU
        Me._OTRO_MOTIVO_DEJO_ESTU = aOTRO_MOTIVO_DEJO_ESTU
        Me._RECIBIO_CURSO_ANTERIOR = aRECIBIO_CURSO_ANTERIOR
        Me._BENEF_PROM_EMP_ACT = aBENEF_PROM_EMP_ACT
        Me._BENEF_OBT_EMPLEO = aBENEF_OBT_EMPLEO
        Me._BENEF_OBT_ING_EXTRA = aBENEF_OBT_ING_EXTRA
        Me._BENEF_CAMB_EMP_X_CURSO = aBENEF_CAMB_EMP_X_CURSO
        Me._BENEF_TRAB_CTA_PROPIA = aBENEF_TRAB_CTA_PROPIA
        Me._BENEF_OTRO = aBENEF_OTRO
        Me._RAZON_NO_BENEFICIO = aRAZON_NO_BENEFICIO
        Me._OCUACT_TRABAJA = aOCUACT_TRABAJA
        Me._OCUACT_ESTUDIA = aOCUACT_ESTUDIA
        Me._OCUACT_ESTU_TRAB = aOCUACT_ESTU_TRAB
        Me._OCUACT_OFICIO_HOGAR = aOCUACT_OFICIO_HOGAR
        Me._OCUACT_BUSCA_TRAB = aOCUACT_BUSCA_TRAB
        Me._OCUACT_OTRA = aOCUACT_OTRA
        Me._RECIBE_INGRESOS = aRECIBE_INGRESOS
        Me._MANERA_OBT_ING_TRABAJO = aMANERA_OBT_ING_TRABAJO
        Me._MANERA_OBT_ING_BECA = aMANERA_OBT_ING_BECA
        Me._MANERA_OBT_ING_AYUDA_FAM = aMANERA_OBT_ING_AYUDA_FAM
        Me._MANERA_OBT_ING_REMESA = aMANERA_OBT_ING_REMESA
        Me._MANERA_OBT_ING_OTRO = aMANERA_OBT_ING_OTRO
        Me._ID_INGRESO_MES = aID_INGRESO_MES
        Me._ID_TIEMPO_NOTRAB = aID_TIEMPO_NOTRAB
        Me._ID_ACTI_ECONOMICA = aID_ACTI_ECONOMICA
        Me._ID_AREA_EMPRESA = aID_AREA_EMPRESA
        Me._ID_MOTIVO_DEJO_TRAB = aID_MOTIVO_DEJO_TRAB
        Me._EXPFOR_OBTENER_EMPLEO = aEXPFOR_OBTENER_EMPLEO
        Me._EXPFOR_INGRESOS_EXTRAS = aEXPFOR_INGRESOS_EXTRAS
        Me._EXPFOR_TRABAJAR_CTA_PROPIA = aEXPFOR_TRABAJAR_CTA_PROPIA
        Me._EXPFOR_OTRO = aEXPFOR_OTRO
        Me._MOTIVO_ELIGIO_CARRERA = aMOTIVO_ELIGIO_CARRERA
        Me._NOMBRE_REFERENCIA = aNOMBRE_REFERENCIA
        Me._ID_REFERENCIA = aID_REFERENCIA
        Me._DIRECCION_REFERENCIA = aDIRECCION_REFERENCIA
        Me._DEPARTAMENTO_REFERENCIA = aDEPARTAMENTO_REFERENCIA
        Me._MUNICIPIO_REFERENCIA = aMUNICIPIO_REFERENCIA
        Me._TELEFONO_REFERENCIA = aTELEFONO_REFERENCIA
        Me._MOVIL_REFERENCIA = aMOVIL_REFERENCIA
        Me._EMAIL_REFERENCIA = aEMAIL_REFERENCIA
        Me._SUGERENCIAS = aSUGERENCIAS
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREACION = aFECHA_CREACION
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
        Me._TIPO_EMPLEO_OTRO = aTIPO_EMPLEO_OTRO
        Me._TRABAJO_ANTERIOR = aTRABAJO_ANTERIOR
        Me._PUESTO_DESEMPENO = aPUESTO_DESEMPENO
        Me._ID_ULT_SALARIO_MES = aID_ULT_SALARIO_MES
        Me._ES_RECLUTA_INICIAL = aES_RECLUTA_INICIAL
        Me._ES_RECLUTA_EXTRA = aES_RECLUTA_EXTRA
        Me._REQUI_AUTORIZACION = aREQUI_AUTORIZACION
        Me._OBSERVACION_AURIZACION = aOBSERVACION_AURIZACION
        Me._AUTORIZADO = aAUTORIZADO
        Me._MOTIVO_AUTORIZADO = aMOTIVO_AUTORIZADO
        Me._USUARIO_AUTORIZO = aUSUARIO_AUTORIZO
        Me._FECHA_AITORIZA = aFECHA_AITORIZA
    End Sub

    Public Function Equals1(ByVal other As SOLICITUD_PRESELECCION_EC) As Boolean Implements System.IEquatable(Of SOLICITUD_PRESELECCION_EC).Equals
        Return Me.ID_SOLIC_PRESELEC = other.ID_SOLIC_PRESELEC
    End Function

    Public Function CompareTo(ByVal other As SOLICITUD_PRESELECCION_EC) As Integer Implements System.IComparable(Of SOLICITUD_PRESELECCION_EC).CompareTo
        If Me.ID_SOLIC_PRESELEC > other.ID_SOLIC_PRESELEC Then Return 1
        If Me.ID_SOLIC_PRESELEC < other.ID_SOLIC_PRESELEC Then Return -1
        Return 0
    End Function


#Region " Properties "

    Private _ID_SOLIC_PRESELEC As Decimal
    <Column(Name:="Id solic preselec", Storage:="ID_SOLIC_PRESELEC", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_SOLIC_PRESELEC() As Decimal
        Get
            Return _ID_SOLIC_PRESELEC
        End Get
        Set(ByVal Value As Decimal)
            _ID_SOLIC_PRESELEC = Value
            OnPropertyChanged("ID_SOLIC_PRESELEC")
        End Set
    End Property 

    Private _FECHA_PRESENTACION As DateTime
    <Column(Name:="Fecha presentacion", Storage:="FECHA_PRESENTACION", DbType:="DATE NOT NULL", Id:=False), _
     DataObjectField(False, False, False)> _
    Public Property FECHA_PRESENTACION() As DateTime
        Get
            Return _FECHA_PRESENTACION
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_PRESENTACION = Value
            OnPropertyChanged("FECHA_PRESENTACION")
        End Set
    End Property 

    Private _FECHA_PRESENTACIONOld As DateTime
    Public Property FECHA_PRESENTACIONOld() As DateTime
        Get
            Return _FECHA_PRESENTACIONOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_PRESENTACIONOld = Value
        End Set
    End Property 

    Private _ID_PARTICIPANTE As Decimal
    <Column(Name:="Id participante", Storage:="ID_PARTICIPANTE", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_PARTICIPANTE() As Decimal
        Get
            Return _ID_PARTICIPANTE
        End Get
        Set(ByVal Value As Decimal)
            _ID_PARTICIPANTE = Value
            OnPropertyChanged("ID_PARTICIPANTE")
        End Set
    End Property 

    Private _ID_PARTICIPANTEOld As Decimal
    Public Property ID_PARTICIPANTEOld() As Decimal
        Get
            Return _ID_PARTICIPANTEOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_PARTICIPANTEOld = Value
        End Set
    End Property 

    Private _fkID_PARTICIPANTE As PARTICIPANTE
    Public Property fkID_PARTICIPANTE() As PARTICIPANTE
        Get
            Return _fkID_PARTICIPANTE
        End Get
        Set(ByVal Value As PARTICIPANTE)
            _fkID_PARTICIPANTE = Value
        End Set
    End Property 

    Private _ID_ESTADO_SOLICITUD As Decimal
    <Column(Name:="Id estado solicitud", Storage:="ID_ESTADO_SOLICITUD", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=2, Scale:=0)> _
    Public Property ID_ESTADO_SOLICITUD() As Decimal
        Get
            Return _ID_ESTADO_SOLICITUD
        End Get
        Set(ByVal Value As Decimal)
            _ID_ESTADO_SOLICITUD = Value
            OnPropertyChanged("ID_ESTADO_SOLICITUD")
        End Set
    End Property 

    Private _ID_ESTADO_SOLICITUDOld As Decimal
    Public Property ID_ESTADO_SOLICITUDOld() As Decimal
        Get
            Return _ID_ESTADO_SOLICITUDOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_ESTADO_SOLICITUDOld = Value
        End Set
    End Property 

    Private _fkID_ESTADO_SOLICITUD As ESTADO_SOLICITUD
    Public Property fkID_ESTADO_SOLICITUD() As ESTADO_SOLICITUD
        Get
            Return _fkID_ESTADO_SOLICITUD
        End Get
        Set(ByVal Value As ESTADO_SOLICITUD)
            _fkID_ESTADO_SOLICITUD = Value
        End Set
    End Property 

    Private _ID_GRUPO_SELEC As Decimal
    <Column(Name:="Id grupo selec", Storage:="ID_GRUPO_SELEC", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_GRUPO_SELEC() As Decimal
        Get
            Return _ID_GRUPO_SELEC
        End Get
        Set(ByVal Value As Decimal)
            _ID_GRUPO_SELEC = Value
            OnPropertyChanged("ID_GRUPO_SELEC")
        End Set
    End Property 

    Private _ID_GRUPO_SELECOld As Decimal
    Public Property ID_GRUPO_SELECOld() As Decimal
        Get
            Return _ID_GRUPO_SELECOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_GRUPO_SELECOld = Value
        End Set
    End Property 

    Private _fkID_GRUPO_SELEC As GRUPO_SELECCION
    Public Property fkID_GRUPO_SELEC() As GRUPO_SELECCION
        Get
            Return _fkID_GRUPO_SELEC
        End Get
        Set(ByVal Value As GRUPO_SELECCION)
            _fkID_GRUPO_SELEC = Value
        End Set
    End Property 

    Private _ID_TIPO_SELECC As Decimal
    <Column(Name:="Id tipo selecc", Storage:="ID_TIPO_SELECC", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_TIPO_SELECC() As Decimal
        Get
            Return _ID_TIPO_SELECC
        End Get
        Set(ByVal Value As Decimal)
            _ID_TIPO_SELECC = Value
            OnPropertyChanged("ID_TIPO_SELECC")
        End Set
    End Property 

    Private _ID_TIPO_SELECCOld As Decimal
    Public Property ID_TIPO_SELECCOld() As Decimal
        Get
            Return _ID_TIPO_SELECCOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_TIPO_SELECCOld = Value
        End Set
    End Property 

    Private _fkID_TIPO_SELECC As TIPO_SELECC
    Public Property fkID_TIPO_SELECC() As TIPO_SELECC
        Get
            Return _fkID_TIPO_SELECC
        End Get
        Set(ByVal Value As TIPO_SELECC)
            _fkID_TIPO_SELECC = Value
        End Set
    End Property 

    Private _NOMBRES As String
    <Column(Name:="Nombres", Storage:="NOMBRES", DbType:="VARCHAR2(50) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 50)> _
    Public Property NOMBRES() As String
        Get
            Return _NOMBRES
        End Get
        Set(ByVal Value As String)
            _NOMBRES = Value
            OnPropertyChanged("NOMBRES")
        End Set
    End Property 

    Private _NOMBRESOld As String
    Public Property NOMBRESOld() As String
        Get
            Return _NOMBRESOld
        End Get
        Set(ByVal Value As String)
            _NOMBRESOld = Value
        End Set
    End Property 

    Private _APELLIDOS As String
    <Column(Name:="Apellidos", Storage:="APELLIDOS", DbType:="VARCHAR2(50) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 50)> _
    Public Property APELLIDOS() As String
        Get
            Return _APELLIDOS
        End Get
        Set(ByVal Value As String)
            _APELLIDOS = Value
            OnPropertyChanged("APELLIDOS")
        End Set
    End Property 

    Private _APELLIDOSOld As String
    Public Property APELLIDOSOld() As String
        Get
            Return _APELLIDOSOld
        End Get
        Set(ByVal Value As String)
            _APELLIDOSOld = Value
        End Set
    End Property 

    Private _DUI As String
    <Column(Name:="Dui", Storage:="DUI", DbType:="CHAR(9)", Id:=False), _
     DataObjectField(False, False, True, 9)> _
    Public Property DUI() As String
        Get
            Return _DUI
        End Get
        Set(ByVal Value As String)
            _DUI = Value
            OnPropertyChanged("DUI")
        End Set
    End Property 

    Private _DUIOld As String
    Public Property DUIOld() As String
        Get
            Return _DUIOld
        End Get
        Set(ByVal Value As String)
            _DUIOld = Value
        End Set
    End Property 

    Private _TIPO_DOCTO As Decimal
    <Column(Name:="Tipo docto", Storage:="TIPO_DOCTO", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=1, Scale:=0)> _
    Public Property TIPO_DOCTO() As Decimal
        Get
            Return _TIPO_DOCTO
        End Get
        Set(ByVal Value As Decimal)
            _TIPO_DOCTO = Value
            OnPropertyChanged("TIPO_DOCTO")
        End Set
    End Property 

    Private _TIPO_DOCTOOld As Decimal
    Public Property TIPO_DOCTOOld() As Decimal
        Get
            Return _TIPO_DOCTOOld
        End Get
        Set(ByVal Value As Decimal)
            _TIPO_DOCTOOld = Value
        End Set
    End Property 

    Private _NUM_DOCTO As String
    <Column(Name:="Num docto", Storage:="NUM_DOCTO", DbType:="VARCHAR2(25)", Id:=False), _
     DataObjectField(False, False, True, 25)> _
    Public Property NUM_DOCTO() As String
        Get
            Return _NUM_DOCTO
        End Get
        Set(ByVal Value As String)
            _NUM_DOCTO = Value
            OnPropertyChanged("NUM_DOCTO")
        End Set
    End Property 

    Private _NUM_DOCTOOld As String
    Public Property NUM_DOCTOOld() As String
        Get
            Return _NUM_DOCTOOld
        End Get
        Set(ByVal Value As String)
            _NUM_DOCTOOld = Value
        End Set
    End Property 

    Private _NIT As String
    <Column(Name:="Nit", Storage:="NIT", DbType:="CHAR(14)", Id:=False), _
     DataObjectField(False, False, True, 14)> _
    Public Property NIT() As String
        Get
            Return _NIT
        End Get
        Set(ByVal Value As String)
            _NIT = Value
            OnPropertyChanged("NIT")
        End Set
    End Property 

    Private _NITOld As String
    Public Property NITOld() As String
        Get
            Return _NITOld
        End Get
        Set(ByVal Value As String)
            _NITOld = Value
        End Set
    End Property 

    Private _ISSS As String
    <Column(Name:="Isss", Storage:="ISSS", DbType:="CHAR(9)", Id:=False), _
     DataObjectField(False, False, True, 9)> _
    Public Property ISSS() As String
        Get
            Return _ISSS
        End Get
        Set(ByVal Value As String)
            _ISSS = Value
            OnPropertyChanged("ISSS")
        End Set
    End Property 

    Private _ISSSOld As String
    Public Property ISSSOld() As String
        Get
            Return _ISSSOld
        End Get
        Set(ByVal Value As String)
            _ISSSOld = Value
        End Set
    End Property 

    Private _ID_PAIS As Decimal
    <Column(Name:="Id pais", Storage:="ID_PAIS", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=3, Scale:=0)> _
    Public Property ID_PAIS() As Decimal
        Get
            Return _ID_PAIS
        End Get
        Set(ByVal Value As Decimal)
            _ID_PAIS = Value
            OnPropertyChanged("ID_PAIS")
        End Set
    End Property 

    Private _ID_PAISOld As Decimal
    Public Property ID_PAISOld() As Decimal
        Get
            Return _ID_PAISOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_PAISOld = Value
        End Set
    End Property 

    Private _fkID_PAIS As PAIS
    Public Property fkID_PAIS() As PAIS
        Get
            Return _fkID_PAIS
        End Get
        Set(ByVal Value As PAIS)
            _fkID_PAIS = Value
        End Set
    End Property 

    Private _DEPARTAMENTO_NAC As String
    <Column(Name:="Departamento nac", Storage:="DEPARTAMENTO_NAC", DbType:="VARCHAR2(2)", Id:=False), _
     DataObjectField(False, False, True, 2)> _
    Public Property DEPARTAMENTO_NAC() As String
        Get
            Return _DEPARTAMENTO_NAC
        End Get
        Set(ByVal Value As String)
            _DEPARTAMENTO_NAC = Value
            OnPropertyChanged("DEPARTAMENTO_NAC")
        End Set
    End Property 

    Private _DEPARTAMENTO_NACOld As String
    Public Property DEPARTAMENTO_NACOld() As String
        Get
            Return _DEPARTAMENTO_NACOld
        End Get
        Set(ByVal Value As String)
            _DEPARTAMENTO_NACOld = Value
        End Set
    End Property 

    Private _MUNICIPIO_NAC As String
    <Column(Name:="Municipio nac", Storage:="MUNICIPIO_NAC", DbType:="VARCHAR2(2)", Id:=False), _
     DataObjectField(False, False, True, 2)> _
    Public Property MUNICIPIO_NAC() As String
        Get
            Return _MUNICIPIO_NAC
        End Get
        Set(ByVal Value As String)
            _MUNICIPIO_NAC = Value
            OnPropertyChanged("MUNICIPIO_NAC")
        End Set
    End Property 

    Private _MUNICIPIO_NACOld As String
    Public Property MUNICIPIO_NACOld() As String
        Get
            Return _MUNICIPIO_NACOld
        End Get
        Set(ByVal Value As String)
            _MUNICIPIO_NACOld = Value
        End Set
    End Property 

    Private _FECHA_NACIMIENTO As DateTime
    <Column(Name:="Fecha nacimiento", Storage:="FECHA_NACIMIENTO", DbType:="DATE", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property FECHA_NACIMIENTO() As DateTime
        Get
            Return _FECHA_NACIMIENTO
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_NACIMIENTO = Value
            OnPropertyChanged("FECHA_NACIMIENTO")
        End Set
    End Property 

    Private _FECHA_NACIMIENTOOld As DateTime
    Public Property FECHA_NACIMIENTOOld() As DateTime
        Get
            Return _FECHA_NACIMIENTOOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_NACIMIENTOOld = Value
        End Set
    End Property 

    Private _GENERO As String
    <Column(Name:="Genero", Storage:="GENERO", DbType:="CHAR(1)", Id:=False), _
     DataObjectField(False, False, True, 1)> _
    Public Property GENERO() As String
        Get
            Return _GENERO
        End Get
        Set(ByVal Value As String)
            _GENERO = Value
            OnPropertyChanged("GENERO")
        End Set
    End Property 

    Private _GENEROOld As String
    Public Property GENEROOld() As String
        Get
            Return _GENEROOld
        End Get
        Set(ByVal Value As String)
            _GENEROOld = Value
        End Set
    End Property 

    Private _EDAD As Decimal
    <Column(Name:="Edad", Storage:="EDAD", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=3, Scale:=0)> _
    Public Property EDAD() As Decimal
        Get
            Return _EDAD
        End Get
        Set(ByVal Value As Decimal)
            _EDAD = Value
            OnPropertyChanged("EDAD")
        End Set
    End Property 

    Private _EDADOld As Decimal
    Public Property EDADOld() As Decimal
        Get
            Return _EDADOld
        End Get
        Set(ByVal Value As Decimal)
            _EDADOld = Value
        End Set
    End Property 

    Private _MIEMBROS_GRUPO_FAMILIAR As Decimal
    <Column(Name:="Miembros grupo familiar", Storage:="MIEMBROS_GRUPO_FAMILIAR", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=2, Scale:=0)> _
    Public Property MIEMBROS_GRUPO_FAMILIAR() As Decimal
        Get
            Return _MIEMBROS_GRUPO_FAMILIAR
        End Get
        Set(ByVal Value As Decimal)
            _MIEMBROS_GRUPO_FAMILIAR = Value
            OnPropertyChanged("MIEMBROS_GRUPO_FAMILIAR")
        End Set
    End Property 

    Private _MIEMBROS_GRUPO_FAMILIAROld As Decimal
    Public Property MIEMBROS_GRUPO_FAMILIAROld() As Decimal
        Get
            Return _MIEMBROS_GRUPO_FAMILIAROld
        End Get
        Set(ByVal Value As Decimal)
            _MIEMBROS_GRUPO_FAMILIAROld = Value
        End Set
    End Property 

    Private _ID_ESTADO_CIVIL As Decimal
    <Column(Name:="Id estado civil", Storage:="ID_ESTADO_CIVIL", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=1, Scale:=0)> _
    Public Property ID_ESTADO_CIVIL() As Decimal
        Get
            Return _ID_ESTADO_CIVIL
        End Get
        Set(ByVal Value As Decimal)
            _ID_ESTADO_CIVIL = Value
            OnPropertyChanged("ID_ESTADO_CIVIL")
        End Set
    End Property 

    Private _ID_ESTADO_CIVILOld As Decimal
    Public Property ID_ESTADO_CIVILOld() As Decimal
        Get
            Return _ID_ESTADO_CIVILOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_ESTADO_CIVILOld = Value
        End Set
    End Property 

    Private _fkID_ESTADO_CIVIL As ESTADO_CIVIL
    Public Property fkID_ESTADO_CIVIL() As ESTADO_CIVIL
        Get
            Return _fkID_ESTADO_CIVIL
        End Get
        Set(ByVal Value As ESTADO_CIVIL)
            _fkID_ESTADO_CIVIL = Value
        End Set
    End Property 

    Private _ES_JEFE_HOGAR As Decimal
    <Column(Name:="Es jefe hogar", Storage:="ES_JEFE_HOGAR", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=1, Scale:=0)> _
    Public Property ES_JEFE_HOGAR() As Decimal
        Get
            Return _ES_JEFE_HOGAR
        End Get
        Set(ByVal Value As Decimal)
            _ES_JEFE_HOGAR = Value
            OnPropertyChanged("ES_JEFE_HOGAR")
        End Set
    End Property 

    Private _ES_JEFE_HOGAROld As Decimal
    Public Property ES_JEFE_HOGAROld() As Decimal
        Get
            Return _ES_JEFE_HOGAROld
        End Get
        Set(ByVal Value As Decimal)
            _ES_JEFE_HOGAROld = Value
        End Set
    End Property 

    Private _TIENE_HIJOS As Decimal
    <Column(Name:="Tiene hijos", Storage:="TIENE_HIJOS", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=1, Scale:=0)> _
    Public Property TIENE_HIJOS() As Decimal
        Get
            Return _TIENE_HIJOS
        End Get
        Set(ByVal Value As Decimal)
            _TIENE_HIJOS = Value
            OnPropertyChanged("TIENE_HIJOS")
        End Set
    End Property 

    Private _TIENE_HIJOSOld As Decimal
    Public Property TIENE_HIJOSOld() As Decimal
        Get
            Return _TIENE_HIJOSOld
        End Get
        Set(ByVal Value As Decimal)
            _TIENE_HIJOSOld = Value
        End Set
    End Property 

    Private _NO_DE_HIJOS As Decimal
    <Column(Name:="No de hijos", Storage:="NO_DE_HIJOS", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=2, Scale:=0)> _
    Public Property NO_DE_HIJOS() As Decimal
        Get
            Return _NO_DE_HIJOS
        End Get
        Set(ByVal Value As Decimal)
            _NO_DE_HIJOS = Value
            OnPropertyChanged("NO_DE_HIJOS")
        End Set
    End Property 

    Private _NO_DE_HIJOSOld As Decimal
    Public Property NO_DE_HIJOSOld() As Decimal
        Get
            Return _NO_DE_HIJOSOld
        End Get
        Set(ByVal Value As Decimal)
            _NO_DE_HIJOSOld = Value
        End Set
    End Property 

    Private _SE_DEDICA_ALGUNA_PROFESION As Decimal
    <Column(Name:="Se dedica alguna profesion", Storage:="SE_DEDICA_ALGUNA_PROFESION", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=1, Scale:=0)> _
    Public Property SE_DEDICA_ALGUNA_PROFESION() As Decimal
        Get
            Return _SE_DEDICA_ALGUNA_PROFESION
        End Get
        Set(ByVal Value As Decimal)
            _SE_DEDICA_ALGUNA_PROFESION = Value
            OnPropertyChanged("SE_DEDICA_ALGUNA_PROFESION")
        End Set
    End Property 

    Private _SE_DEDICA_ALGUNA_PROFESIONOld As Decimal
    Public Property SE_DEDICA_ALGUNA_PROFESIONOld() As Decimal
        Get
            Return _SE_DEDICA_ALGUNA_PROFESIONOld
        End Get
        Set(ByVal Value As Decimal)
            _SE_DEDICA_ALGUNA_PROFESIONOld = Value
        End Set
    End Property 

    Private _PROFESION_OFICIO As String
    <Column(Name:="Profesion oficio", Storage:="PROFESION_OFICIO", DbType:="VARCHAR2(60)", Id:=False), _
     DataObjectField(False, False, True, 60)> _
    Public Property PROFESION_OFICIO() As String
        Get
            Return _PROFESION_OFICIO
        End Get
        Set(ByVal Value As String)
            _PROFESION_OFICIO = Value
            OnPropertyChanged("PROFESION_OFICIO")
        End Set
    End Property 

    Private _PROFESION_OFICIOOld As String
    Public Property PROFESION_OFICIOOld() As String
        Get
            Return _PROFESION_OFICIOOld
        End Get
        Set(ByVal Value As String)
            _PROFESION_OFICIOOld = Value
        End Set
    End Property 

    Private _DIRECCION As String
    <Column(Name:="Direccion", Storage:="DIRECCION", DbType:="VARCHAR2(150)", Id:=False), _
     DataObjectField(False, False, True, 150)> _
    Public Property DIRECCION() As String
        Get
            Return _DIRECCION
        End Get
        Set(ByVal Value As String)
            _DIRECCION = Value
            OnPropertyChanged("DIRECCION")
        End Set
    End Property 

    Private _DIRECCIONOld As String
    Public Property DIRECCIONOld() As String
        Get
            Return _DIRECCIONOld
        End Get
        Set(ByVal Value As String)
            _DIRECCIONOld = Value
        End Set
    End Property 

    Private _CODIGO_DEPARTAMENTO As String
    <Column(Name:="Codigo departamento", Storage:="CODIGO_DEPARTAMENTO", DbType:="VARCHAR2(2)", Id:=False), _
     DataObjectField(False, False, True, 2)> _
    Public Property CODIGO_DEPARTAMENTO() As String
        Get
            Return _CODIGO_DEPARTAMENTO
        End Get
        Set(ByVal Value As String)
            _CODIGO_DEPARTAMENTO = Value
            OnPropertyChanged("CODIGO_DEPARTAMENTO")
        End Set
    End Property 

    Private _CODIGO_DEPARTAMENTOOld As String
    Public Property CODIGO_DEPARTAMENTOOld() As String
        Get
            Return _CODIGO_DEPARTAMENTOOld
        End Get
        Set(ByVal Value As String)
            _CODIGO_DEPARTAMENTOOld = Value
        End Set
    End Property 

    Private _fkCODIGO_DEPARTAMENTO As DEPARTAMENTO
    Public Property fkCODIGO_DEPARTAMENTO() As DEPARTAMENTO
        Get
            Return _fkCODIGO_DEPARTAMENTO
        End Get
        Set(ByVal Value As DEPARTAMENTO)
            _fkCODIGO_DEPARTAMENTO = Value
        End Set
    End Property 

    Private _CODIGO_MUNICIPIO As String
    <Column(Name:="Codigo municipio", Storage:="CODIGO_MUNICIPIO", DbType:="VARCHAR2(2)", Id:=False), _
     DataObjectField(False, False, True, 2)> _
    Public Property CODIGO_MUNICIPIO() As String
        Get
            Return _CODIGO_MUNICIPIO
        End Get
        Set(ByVal Value As String)
            _CODIGO_MUNICIPIO = Value
            OnPropertyChanged("CODIGO_MUNICIPIO")
        End Set
    End Property 

    Private _CODIGO_MUNICIPIOOld As String
    Public Property CODIGO_MUNICIPIOOld() As String
        Get
            Return _CODIGO_MUNICIPIOOld
        End Get
        Set(ByVal Value As String)
            _CODIGO_MUNICIPIOOld = Value
        End Set
    End Property 

    Private _fkCODIGO_MUNICIPIO As MUNICIPIO
    Public Property fkCODIGO_MUNICIPIO() As MUNICIPIO
        Get
            Return _fkCODIGO_MUNICIPIO
        End Get
        Set(ByVal Value As MUNICIPIO)
            _fkCODIGO_MUNICIPIO = Value
        End Set
    End Property 

    Private _TELEFONO As String
    <Column(Name:="Telefono", Storage:="TELEFONO", DbType:="VARCHAR2(40)", Id:=False), _
     DataObjectField(False, False, True, 40)> _
    Public Property TELEFONO() As String
        Get
            Return _TELEFONO
        End Get
        Set(ByVal Value As String)
            _TELEFONO = Value
            OnPropertyChanged("TELEFONO")
        End Set
    End Property 

    Private _TELEFONOOld As String
    Public Property TELEFONOOld() As String
        Get
            Return _TELEFONOOld
        End Get
        Set(ByVal Value As String)
            _TELEFONOOld = Value
        End Set
    End Property 

    Private _MOVIL As String
    <Column(Name:="Movil", Storage:="MOVIL", DbType:="VARCHAR2(40)", Id:=False), _
     DataObjectField(False, False, True, 40)> _
    Public Property MOVIL() As String
        Get
            Return _MOVIL
        End Get
        Set(ByVal Value As String)
            _MOVIL = Value
            OnPropertyChanged("MOVIL")
        End Set
    End Property 

    Private _MOVILOld As String
    Public Property MOVILOld() As String
        Get
            Return _MOVILOld
        End Get
        Set(ByVal Value As String)
            _MOVILOld = Value
        End Set
    End Property 

    Private _EMAIL As String
    <Column(Name:="Email", Storage:="EMAIL", DbType:="VARCHAR2(100)", Id:=False), _
     DataObjectField(False, False, True, 100)> _
    Public Property EMAIL() As String
        Get
            Return _EMAIL
        End Get
        Set(ByVal Value As String)
            _EMAIL = Value
            OnPropertyChanged("EMAIL")
        End Set
    End Property 

    Private _EMAILOld As String
    Public Property EMAILOld() As String
        Get
            Return _EMAILOld
        End Get
        Set(ByVal Value As String)
            _EMAILOld = Value
        End Set
    End Property 

    Private _CON_DISCAPACIDAD As Decimal
    <Column(Name:="Con discapacidad", Storage:="CON_DISCAPACIDAD", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=1, Scale:=0)> _
    Public Property CON_DISCAPACIDAD() As Decimal
        Get
            Return _CON_DISCAPACIDAD
        End Get
        Set(ByVal Value As Decimal)
            _CON_DISCAPACIDAD = Value
            OnPropertyChanged("CON_DISCAPACIDAD")
        End Set
    End Property 

    Private _CON_DISCAPACIDADOld As Decimal
    Public Property CON_DISCAPACIDADOld() As Decimal
        Get
            Return _CON_DISCAPACIDADOld
        End Get
        Set(ByVal Value As Decimal)
            _CON_DISCAPACIDADOld = Value
        End Set
    End Property 

    Private _DISC_OTRA As String
    <Column(Name:="Disc otra", Storage:="DISC_OTRA", DbType:="VARCHAR2(60)", Id:=False), _
     DataObjectField(False, False, True, 60)> _
    Public Property DISC_OTRA() As String
        Get
            Return _DISC_OTRA
        End Get
        Set(ByVal Value As String)
            _DISC_OTRA = Value
            OnPropertyChanged("DISC_OTRA")
        End Set
    End Property 

    Private _DISC_OTRAOld As String
    Public Property DISC_OTRAOld() As String
        Get
            Return _DISC_OTRAOld
        End Get
        Set(ByVal Value As String)
            _DISC_OTRAOld = Value
        End Set
    End Property 

    Private _ID_NIVEL_ACADEMICO As Decimal
    <Column(Name:="Id nivel academico", Storage:="ID_NIVEL_ACADEMICO", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=2, Scale:=0)> _
    Public Property ID_NIVEL_ACADEMICO() As Decimal
        Get
            Return _ID_NIVEL_ACADEMICO
        End Get
        Set(ByVal Value As Decimal)
            _ID_NIVEL_ACADEMICO = Value
            OnPropertyChanged("ID_NIVEL_ACADEMICO")
        End Set
    End Property 

    Private _ID_NIVEL_ACADEMICOOld As Decimal
    Public Property ID_NIVEL_ACADEMICOOld() As Decimal
        Get
            Return _ID_NIVEL_ACADEMICOOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_NIVEL_ACADEMICOOld = Value
        End Set
    End Property 

    Private _fkID_NIVEL_ACADEMICO As NIVEL_ACADEMICO
    Public Property fkID_NIVEL_ACADEMICO() As NIVEL_ACADEMICO
        Get
            Return _fkID_NIVEL_ACADEMICO
        End Get
        Set(ByVal Value As NIVEL_ACADEMICO)
            _fkID_NIVEL_ACADEMICO = Value
        End Set
    End Property 

    Private _OTRA_EDUCACION_FORMAL As String
    <Column(Name:="Otra educacion formal", Storage:="OTRA_EDUCACION_FORMAL", DbType:="VARCHAR2(60)", Id:=False), _
     DataObjectField(False, False, True, 60)> _
    Public Property OTRA_EDUCACION_FORMAL() As String
        Get
            Return _OTRA_EDUCACION_FORMAL
        End Get
        Set(ByVal Value As String)
            _OTRA_EDUCACION_FORMAL = Value
            OnPropertyChanged("OTRA_EDUCACION_FORMAL")
        End Set
    End Property 

    Private _OTRA_EDUCACION_FORMALOld As String
    Public Property OTRA_EDUCACION_FORMALOld() As String
        Get
            Return _OTRA_EDUCACION_FORMALOld
        End Get
        Set(ByVal Value As String)
            _OTRA_EDUCACION_FORMALOld = Value
        End Set
    End Property 

    Private _TITULO_CERTIFICADO_OBTENIDO As String
    <Column(Name:="Titulo certificado obtenido", Storage:="TITULO_CERTIFICADO_OBTENIDO", DbType:="VARCHAR2(60)", Id:=False), _
     DataObjectField(False, False, True, 60)> _
    Public Property TITULO_CERTIFICADO_OBTENIDO() As String
        Get
            Return _TITULO_CERTIFICADO_OBTENIDO
        End Get
        Set(ByVal Value As String)
            _TITULO_CERTIFICADO_OBTENIDO = Value
            OnPropertyChanged("TITULO_CERTIFICADO_OBTENIDO")
        End Set
    End Property 

    Private _TITULO_CERTIFICADO_OBTENIDOOld As String
    Public Property TITULO_CERTIFICADO_OBTENIDOOld() As String
        Get
            Return _TITULO_CERTIFICADO_OBTENIDOOld
        End Get
        Set(ByVal Value As String)
            _TITULO_CERTIFICADO_OBTENIDOOld = Value
        End Set
    End Property 

    Private _ESTUDIA_ACTUALMENTE As Decimal
    <Column(Name:="Estudia actualmente", Storage:="ESTUDIA_ACTUALMENTE", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=1, Scale:=0)> _
    Public Property ESTUDIA_ACTUALMENTE() As Decimal
        Get
            Return _ESTUDIA_ACTUALMENTE
        End Get
        Set(ByVal Value As Decimal)
            _ESTUDIA_ACTUALMENTE = Value
            OnPropertyChanged("ESTUDIA_ACTUALMENTE")
        End Set
    End Property 

    Private _ESTUDIA_ACTUALMENTEOld As Decimal
    Public Property ESTUDIA_ACTUALMENTEOld() As Decimal
        Get
            Return _ESTUDIA_ACTUALMENTEOld
        End Get
        Set(ByVal Value As Decimal)
            _ESTUDIA_ACTUALMENTEOld = Value
        End Set
    End Property 

    Private _ID_TIEMPO_DEJO_ESTUDIAR As Decimal
    <Column(Name:="Id tiempo dejo estudiar", Storage:="ID_TIEMPO_DEJO_ESTUDIAR", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=2, Scale:=0)> _
    Public Property ID_TIEMPO_DEJO_ESTUDIAR() As Decimal
        Get
            Return _ID_TIEMPO_DEJO_ESTUDIAR
        End Get
        Set(ByVal Value As Decimal)
            _ID_TIEMPO_DEJO_ESTUDIAR = Value
            OnPropertyChanged("ID_TIEMPO_DEJO_ESTUDIAR")
        End Set
    End Property 

    Private _ID_TIEMPO_DEJO_ESTUDIAROld As Decimal
    Public Property ID_TIEMPO_DEJO_ESTUDIAROld() As Decimal
        Get
            Return _ID_TIEMPO_DEJO_ESTUDIAROld
        End Get
        Set(ByVal Value As Decimal)
            _ID_TIEMPO_DEJO_ESTUDIAROld = Value
        End Set
    End Property 

    Private _fkID_TIEMPO_DEJO_ESTUDIAR As TIEMPO_DEJO_ESTUDIAR
    Public Property fkID_TIEMPO_DEJO_ESTUDIAR() As TIEMPO_DEJO_ESTUDIAR
        Get
            Return _fkID_TIEMPO_DEJO_ESTUDIAR
        End Get
        Set(ByVal Value As TIEMPO_DEJO_ESTUDIAR)
            _fkID_TIEMPO_DEJO_ESTUDIAR = Value
        End Set
    End Property 

    Private _ID_MOTIVO_DEJO_ESTU As Decimal
    <Column(Name:="Id motivo dejo estu", Storage:="ID_MOTIVO_DEJO_ESTU", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_MOTIVO_DEJO_ESTU() As Decimal
        Get
            Return _ID_MOTIVO_DEJO_ESTU
        End Get
        Set(ByVal Value As Decimal)
            _ID_MOTIVO_DEJO_ESTU = Value
            OnPropertyChanged("ID_MOTIVO_DEJO_ESTU")
        End Set
    End Property 

    Private _ID_MOTIVO_DEJO_ESTUOld As Decimal
    Public Property ID_MOTIVO_DEJO_ESTUOld() As Decimal
        Get
            Return _ID_MOTIVO_DEJO_ESTUOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_MOTIVO_DEJO_ESTUOld = Value
        End Set
    End Property 

    Private _fkID_MOTIVO_DEJO_ESTU As MOTIVO_DEJO_ESTU
    Public Property fkID_MOTIVO_DEJO_ESTU() As MOTIVO_DEJO_ESTU
        Get
            Return _fkID_MOTIVO_DEJO_ESTU
        End Get
        Set(ByVal Value As MOTIVO_DEJO_ESTU)
            _fkID_MOTIVO_DEJO_ESTU = Value
        End Set
    End Property 

    Private _OTRO_MOTIVO_DEJO_ESTU As String
    <Column(Name:="Otro motivo dejo estu", Storage:="OTRO_MOTIVO_DEJO_ESTU", DbType:="VARCHAR2(200)", Id:=False), _
     DataObjectField(False, False, True, 200)> _
    Public Property OTRO_MOTIVO_DEJO_ESTU() As String
        Get
            Return _OTRO_MOTIVO_DEJO_ESTU
        End Get
        Set(ByVal Value As String)
            _OTRO_MOTIVO_DEJO_ESTU = Value
            OnPropertyChanged("OTRO_MOTIVO_DEJO_ESTU")
        End Set
    End Property 

    Private _OTRO_MOTIVO_DEJO_ESTUOld As String
    Public Property OTRO_MOTIVO_DEJO_ESTUOld() As String
        Get
            Return _OTRO_MOTIVO_DEJO_ESTUOld
        End Get
        Set(ByVal Value As String)
            _OTRO_MOTIVO_DEJO_ESTUOld = Value
        End Set
    End Property 

    Private _RECIBIO_CURSO_ANTERIOR As String
    <Column(Name:="Recibio curso anterior", Storage:="RECIBIO_CURSO_ANTERIOR", DbType:="CHAR(1)", Id:=False), _
     DataObjectField(False, False, True, 1)> _
    Public Property RECIBIO_CURSO_ANTERIOR() As String
        Get
            Return _RECIBIO_CURSO_ANTERIOR
        End Get
        Set(ByVal Value As String)
            _RECIBIO_CURSO_ANTERIOR = Value
            OnPropertyChanged("RECIBIO_CURSO_ANTERIOR")
        End Set
    End Property 

    Private _RECIBIO_CURSO_ANTERIOROld As String
    Public Property RECIBIO_CURSO_ANTERIOROld() As String
        Get
            Return _RECIBIO_CURSO_ANTERIOROld
        End Get
        Set(ByVal Value As String)
            _RECIBIO_CURSO_ANTERIOROld = Value
        End Set
    End Property 

    Private _BENEF_PROM_EMP_ACT As Decimal
    <Column(Name:="Benef prom emp act", Storage:="BENEF_PROM_EMP_ACT", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=1, Scale:=0)> _
    Public Property BENEF_PROM_EMP_ACT() As Decimal
        Get
            Return _BENEF_PROM_EMP_ACT
        End Get
        Set(ByVal Value As Decimal)
            _BENEF_PROM_EMP_ACT = Value
            OnPropertyChanged("BENEF_PROM_EMP_ACT")
        End Set
    End Property 

    Private _BENEF_PROM_EMP_ACTOld As Decimal
    Public Property BENEF_PROM_EMP_ACTOld() As Decimal
        Get
            Return _BENEF_PROM_EMP_ACTOld
        End Get
        Set(ByVal Value As Decimal)
            _BENEF_PROM_EMP_ACTOld = Value
        End Set
    End Property 

    Private _BENEF_OBT_EMPLEO As Decimal
    <Column(Name:="Benef obt empleo", Storage:="BENEF_OBT_EMPLEO", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=1, Scale:=0)> _
    Public Property BENEF_OBT_EMPLEO() As Decimal
        Get
            Return _BENEF_OBT_EMPLEO
        End Get
        Set(ByVal Value As Decimal)
            _BENEF_OBT_EMPLEO = Value
            OnPropertyChanged("BENEF_OBT_EMPLEO")
        End Set
    End Property 

    Private _BENEF_OBT_EMPLEOOld As Decimal
    Public Property BENEF_OBT_EMPLEOOld() As Decimal
        Get
            Return _BENEF_OBT_EMPLEOOld
        End Get
        Set(ByVal Value As Decimal)
            _BENEF_OBT_EMPLEOOld = Value
        End Set
    End Property 

    Private _BENEF_OBT_ING_EXTRA As Decimal
    <Column(Name:="Benef obt ing extra", Storage:="BENEF_OBT_ING_EXTRA", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=1, Scale:=0)> _
    Public Property BENEF_OBT_ING_EXTRA() As Decimal
        Get
            Return _BENEF_OBT_ING_EXTRA
        End Get
        Set(ByVal Value As Decimal)
            _BENEF_OBT_ING_EXTRA = Value
            OnPropertyChanged("BENEF_OBT_ING_EXTRA")
        End Set
    End Property 

    Private _BENEF_OBT_ING_EXTRAOld As Decimal
    Public Property BENEF_OBT_ING_EXTRAOld() As Decimal
        Get
            Return _BENEF_OBT_ING_EXTRAOld
        End Get
        Set(ByVal Value As Decimal)
            _BENEF_OBT_ING_EXTRAOld = Value
        End Set
    End Property 

    Private _BENEF_CAMB_EMP_X_CURSO As Decimal
    <Column(Name:="Benef camb emp x curso", Storage:="BENEF_CAMB_EMP_X_CURSO", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=1, Scale:=0)> _
    Public Property BENEF_CAMB_EMP_X_CURSO() As Decimal
        Get
            Return _BENEF_CAMB_EMP_X_CURSO
        End Get
        Set(ByVal Value As Decimal)
            _BENEF_CAMB_EMP_X_CURSO = Value
            OnPropertyChanged("BENEF_CAMB_EMP_X_CURSO")
        End Set
    End Property 

    Private _BENEF_CAMB_EMP_X_CURSOOld As Decimal
    Public Property BENEF_CAMB_EMP_X_CURSOOld() As Decimal
        Get
            Return _BENEF_CAMB_EMP_X_CURSOOld
        End Get
        Set(ByVal Value As Decimal)
            _BENEF_CAMB_EMP_X_CURSOOld = Value
        End Set
    End Property 

    Private _BENEF_TRAB_CTA_PROPIA As Decimal
    <Column(Name:="Benef trab cta propia", Storage:="BENEF_TRAB_CTA_PROPIA", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=1, Scale:=0)> _
    Public Property BENEF_TRAB_CTA_PROPIA() As Decimal
        Get
            Return _BENEF_TRAB_CTA_PROPIA
        End Get
        Set(ByVal Value As Decimal)
            _BENEF_TRAB_CTA_PROPIA = Value
            OnPropertyChanged("BENEF_TRAB_CTA_PROPIA")
        End Set
    End Property 

    Private _BENEF_TRAB_CTA_PROPIAOld As Decimal
    Public Property BENEF_TRAB_CTA_PROPIAOld() As Decimal
        Get
            Return _BENEF_TRAB_CTA_PROPIAOld
        End Get
        Set(ByVal Value As Decimal)
            _BENEF_TRAB_CTA_PROPIAOld = Value
        End Set
    End Property 

    Private _BENEF_OTRO As String
    <Column(Name:="Benef otro", Storage:="BENEF_OTRO", DbType:="VARCHAR2(100)", Id:=False), _
     DataObjectField(False, False, True, 100)> _
    Public Property BENEF_OTRO() As String
        Get
            Return _BENEF_OTRO
        End Get
        Set(ByVal Value As String)
            _BENEF_OTRO = Value
            OnPropertyChanged("BENEF_OTRO")
        End Set
    End Property 

    Private _BENEF_OTROOld As String
    Public Property BENEF_OTROOld() As String
        Get
            Return _BENEF_OTROOld
        End Get
        Set(ByVal Value As String)
            _BENEF_OTROOld = Value
        End Set
    End Property 

    Private _RAZON_NO_BENEFICIO As String
    <Column(Name:="Razon no beneficio", Storage:="RAZON_NO_BENEFICIO", DbType:="VARCHAR2(100)", Id:=False), _
     DataObjectField(False, False, True, 100)> _
    Public Property RAZON_NO_BENEFICIO() As String
        Get
            Return _RAZON_NO_BENEFICIO
        End Get
        Set(ByVal Value As String)
            _RAZON_NO_BENEFICIO = Value
            OnPropertyChanged("RAZON_NO_BENEFICIO")
        End Set
    End Property 

    Private _RAZON_NO_BENEFICIOOld As String
    Public Property RAZON_NO_BENEFICIOOld() As String
        Get
            Return _RAZON_NO_BENEFICIOOld
        End Get
        Set(ByVal Value As String)
            _RAZON_NO_BENEFICIOOld = Value
        End Set
    End Property 

    Private _OCUACT_TRABAJA As Decimal
    <Column(Name:="Ocuact trabaja", Storage:="OCUACT_TRABAJA", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=1, Scale:=0)> _
    Public Property OCUACT_TRABAJA() As Decimal
        Get
            Return _OCUACT_TRABAJA
        End Get
        Set(ByVal Value As Decimal)
            _OCUACT_TRABAJA = Value
            OnPropertyChanged("OCUACT_TRABAJA")
        End Set
    End Property 

    Private _OCUACT_TRABAJAOld As Decimal
    Public Property OCUACT_TRABAJAOld() As Decimal
        Get
            Return _OCUACT_TRABAJAOld
        End Get
        Set(ByVal Value As Decimal)
            _OCUACT_TRABAJAOld = Value
        End Set
    End Property 

    Private _OCUACT_ESTUDIA As Decimal
    <Column(Name:="Ocuact estudia", Storage:="OCUACT_ESTUDIA", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=1, Scale:=0)> _
    Public Property OCUACT_ESTUDIA() As Decimal
        Get
            Return _OCUACT_ESTUDIA
        End Get
        Set(ByVal Value As Decimal)
            _OCUACT_ESTUDIA = Value
            OnPropertyChanged("OCUACT_ESTUDIA")
        End Set
    End Property 

    Private _OCUACT_ESTUDIAOld As Decimal
    Public Property OCUACT_ESTUDIAOld() As Decimal
        Get
            Return _OCUACT_ESTUDIAOld
        End Get
        Set(ByVal Value As Decimal)
            _OCUACT_ESTUDIAOld = Value
        End Set
    End Property 

    Private _OCUACT_ESTU_TRAB As Decimal
    <Column(Name:="Ocuact estu trab", Storage:="OCUACT_ESTU_TRAB", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=1, Scale:=0)> _
    Public Property OCUACT_ESTU_TRAB() As Decimal
        Get
            Return _OCUACT_ESTU_TRAB
        End Get
        Set(ByVal Value As Decimal)
            _OCUACT_ESTU_TRAB = Value
            OnPropertyChanged("OCUACT_ESTU_TRAB")
        End Set
    End Property 

    Private _OCUACT_ESTU_TRABOld As Decimal
    Public Property OCUACT_ESTU_TRABOld() As Decimal
        Get
            Return _OCUACT_ESTU_TRABOld
        End Get
        Set(ByVal Value As Decimal)
            _OCUACT_ESTU_TRABOld = Value
        End Set
    End Property 

    Private _OCUACT_OFICIO_HOGAR As Decimal
    <Column(Name:="Ocuact oficio hogar", Storage:="OCUACT_OFICIO_HOGAR", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=1, Scale:=0)> _
    Public Property OCUACT_OFICIO_HOGAR() As Decimal
        Get
            Return _OCUACT_OFICIO_HOGAR
        End Get
        Set(ByVal Value As Decimal)
            _OCUACT_OFICIO_HOGAR = Value
            OnPropertyChanged("OCUACT_OFICIO_HOGAR")
        End Set
    End Property 

    Private _OCUACT_OFICIO_HOGAROld As Decimal
    Public Property OCUACT_OFICIO_HOGAROld() As Decimal
        Get
            Return _OCUACT_OFICIO_HOGAROld
        End Get
        Set(ByVal Value As Decimal)
            _OCUACT_OFICIO_HOGAROld = Value
        End Set
    End Property 

    Private _OCUACT_BUSCA_TRAB As Decimal
    <Column(Name:="Ocuact busca trab", Storage:="OCUACT_BUSCA_TRAB", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=1, Scale:=0)> _
    Public Property OCUACT_BUSCA_TRAB() As Decimal
        Get
            Return _OCUACT_BUSCA_TRAB
        End Get
        Set(ByVal Value As Decimal)
            _OCUACT_BUSCA_TRAB = Value
            OnPropertyChanged("OCUACT_BUSCA_TRAB")
        End Set
    End Property 

    Private _OCUACT_BUSCA_TRABOld As Decimal
    Public Property OCUACT_BUSCA_TRABOld() As Decimal
        Get
            Return _OCUACT_BUSCA_TRABOld
        End Get
        Set(ByVal Value As Decimal)
            _OCUACT_BUSCA_TRABOld = Value
        End Set
    End Property 

    Private _OCUACT_OTRA As String
    <Column(Name:="Ocuact otra", Storage:="OCUACT_OTRA", DbType:="VARCHAR2(100)", Id:=False), _
     DataObjectField(False, False, True, 100)> _
    Public Property OCUACT_OTRA() As String
        Get
            Return _OCUACT_OTRA
        End Get
        Set(ByVal Value As String)
            _OCUACT_OTRA = Value
            OnPropertyChanged("OCUACT_OTRA")
        End Set
    End Property 

    Private _OCUACT_OTRAOld As String
    Public Property OCUACT_OTRAOld() As String
        Get
            Return _OCUACT_OTRAOld
        End Get
        Set(ByVal Value As String)
            _OCUACT_OTRAOld = Value
        End Set
    End Property 

    Private _RECIBE_INGRESOS As Decimal
    <Column(Name:="Recibe ingresos", Storage:="RECIBE_INGRESOS", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=1, Scale:=0)> _
    Public Property RECIBE_INGRESOS() As Decimal
        Get
            Return _RECIBE_INGRESOS
        End Get
        Set(ByVal Value As Decimal)
            _RECIBE_INGRESOS = Value
            OnPropertyChanged("RECIBE_INGRESOS")
        End Set
    End Property 

    Private _RECIBE_INGRESOSOld As Decimal
    Public Property RECIBE_INGRESOSOld() As Decimal
        Get
            Return _RECIBE_INGRESOSOld
        End Get
        Set(ByVal Value As Decimal)
            _RECIBE_INGRESOSOld = Value
        End Set
    End Property 

    Private _MANERA_OBT_ING_TRABAJO As Decimal
    <Column(Name:="Manera obt ing trabajo", Storage:="MANERA_OBT_ING_TRABAJO", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=1, Scale:=0)> _
    Public Property MANERA_OBT_ING_TRABAJO() As Decimal
        Get
            Return _MANERA_OBT_ING_TRABAJO
        End Get
        Set(ByVal Value As Decimal)
            _MANERA_OBT_ING_TRABAJO = Value
            OnPropertyChanged("MANERA_OBT_ING_TRABAJO")
        End Set
    End Property 

    Private _MANERA_OBT_ING_TRABAJOOld As Decimal
    Public Property MANERA_OBT_ING_TRABAJOOld() As Decimal
        Get
            Return _MANERA_OBT_ING_TRABAJOOld
        End Get
        Set(ByVal Value As Decimal)
            _MANERA_OBT_ING_TRABAJOOld = Value
        End Set
    End Property 

    Private _MANERA_OBT_ING_BECA As Decimal
    <Column(Name:="Manera obt ing beca", Storage:="MANERA_OBT_ING_BECA", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=1, Scale:=0)> _
    Public Property MANERA_OBT_ING_BECA() As Decimal
        Get
            Return _MANERA_OBT_ING_BECA
        End Get
        Set(ByVal Value As Decimal)
            _MANERA_OBT_ING_BECA = Value
            OnPropertyChanged("MANERA_OBT_ING_BECA")
        End Set
    End Property 

    Private _MANERA_OBT_ING_BECAOld As Decimal
    Public Property MANERA_OBT_ING_BECAOld() As Decimal
        Get
            Return _MANERA_OBT_ING_BECAOld
        End Get
        Set(ByVal Value As Decimal)
            _MANERA_OBT_ING_BECAOld = Value
        End Set
    End Property 

    Private _MANERA_OBT_ING_AYUDA_FAM As Decimal
    <Column(Name:="Manera obt ing ayuda fam", Storage:="MANERA_OBT_ING_AYUDA_FAM", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=1, Scale:=0)> _
    Public Property MANERA_OBT_ING_AYUDA_FAM() As Decimal
        Get
            Return _MANERA_OBT_ING_AYUDA_FAM
        End Get
        Set(ByVal Value As Decimal)
            _MANERA_OBT_ING_AYUDA_FAM = Value
            OnPropertyChanged("MANERA_OBT_ING_AYUDA_FAM")
        End Set
    End Property 

    Private _MANERA_OBT_ING_AYUDA_FAMOld As Decimal
    Public Property MANERA_OBT_ING_AYUDA_FAMOld() As Decimal
        Get
            Return _MANERA_OBT_ING_AYUDA_FAMOld
        End Get
        Set(ByVal Value As Decimal)
            _MANERA_OBT_ING_AYUDA_FAMOld = Value
        End Set
    End Property 

    Private _MANERA_OBT_ING_REMESA As Decimal
    <Column(Name:="Manera obt ing remesa", Storage:="MANERA_OBT_ING_REMESA", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=1, Scale:=0)> _
    Public Property MANERA_OBT_ING_REMESA() As Decimal
        Get
            Return _MANERA_OBT_ING_REMESA
        End Get
        Set(ByVal Value As Decimal)
            _MANERA_OBT_ING_REMESA = Value
            OnPropertyChanged("MANERA_OBT_ING_REMESA")
        End Set
    End Property 

    Private _MANERA_OBT_ING_REMESAOld As Decimal
    Public Property MANERA_OBT_ING_REMESAOld() As Decimal
        Get
            Return _MANERA_OBT_ING_REMESAOld
        End Get
        Set(ByVal Value As Decimal)
            _MANERA_OBT_ING_REMESAOld = Value
        End Set
    End Property 

    Private _MANERA_OBT_ING_OTRO As String
    <Column(Name:="Manera obt ing otro", Storage:="MANERA_OBT_ING_OTRO", DbType:="VARCHAR2(60)", Id:=False), _
     DataObjectField(False, False, True, 60)> _
    Public Property MANERA_OBT_ING_OTRO() As String
        Get
            Return _MANERA_OBT_ING_OTRO
        End Get
        Set(ByVal Value As String)
            _MANERA_OBT_ING_OTRO = Value
            OnPropertyChanged("MANERA_OBT_ING_OTRO")
        End Set
    End Property 

    Private _MANERA_OBT_ING_OTROOld As String
    Public Property MANERA_OBT_ING_OTROOld() As String
        Get
            Return _MANERA_OBT_ING_OTROOld
        End Get
        Set(ByVal Value As String)
            _MANERA_OBT_ING_OTROOld = Value
        End Set
    End Property 

    Private _ID_INGRESO_MES As Decimal
    <Column(Name:="Id ingreso mes", Storage:="ID_INGRESO_MES", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_INGRESO_MES() As Decimal
        Get
            Return _ID_INGRESO_MES
        End Get
        Set(ByVal Value As Decimal)
            _ID_INGRESO_MES = Value
            OnPropertyChanged("ID_INGRESO_MES")
        End Set
    End Property 

    Private _ID_INGRESO_MESOld As Decimal
    Public Property ID_INGRESO_MESOld() As Decimal
        Get
            Return _ID_INGRESO_MESOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_INGRESO_MESOld = Value
        End Set
    End Property 

    Private _fkID_INGRESO_MES As INGRESO_MES
    Public Property fkID_INGRESO_MES() As INGRESO_MES
        Get
            Return _fkID_INGRESO_MES
        End Get
        Set(ByVal Value As INGRESO_MES)
            _fkID_INGRESO_MES = Value
        End Set
    End Property 

    Private _ID_TIEMPO_NOTRAB As Decimal
    <Column(Name:="Id tiempo notrab", Storage:="ID_TIEMPO_NOTRAB", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_TIEMPO_NOTRAB() As Decimal
        Get
            Return _ID_TIEMPO_NOTRAB
        End Get
        Set(ByVal Value As Decimal)
            _ID_TIEMPO_NOTRAB = Value
            OnPropertyChanged("ID_TIEMPO_NOTRAB")
        End Set
    End Property 

    Private _ID_TIEMPO_NOTRABOld As Decimal
    Public Property ID_TIEMPO_NOTRABOld() As Decimal
        Get
            Return _ID_TIEMPO_NOTRABOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_TIEMPO_NOTRABOld = Value
        End Set
    End Property 

    Private _fkID_TIEMPO_NOTRAB As TIEMPO_NOTRAB
    Public Property fkID_TIEMPO_NOTRAB() As TIEMPO_NOTRAB
        Get
            Return _fkID_TIEMPO_NOTRAB
        End Get
        Set(ByVal Value As TIEMPO_NOTRAB)
            _fkID_TIEMPO_NOTRAB = Value
        End Set
    End Property 

    Private _ID_ACTI_ECONOMICA As Decimal
    <Column(Name:="Id acti economica", Storage:="ID_ACTI_ECONOMICA", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_ACTI_ECONOMICA() As Decimal
        Get
            Return _ID_ACTI_ECONOMICA
        End Get
        Set(ByVal Value As Decimal)
            _ID_ACTI_ECONOMICA = Value
            OnPropertyChanged("ID_ACTI_ECONOMICA")
        End Set
    End Property 

    Private _ID_ACTI_ECONOMICAOld As Decimal
    Public Property ID_ACTI_ECONOMICAOld() As Decimal
        Get
            Return _ID_ACTI_ECONOMICAOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_ACTI_ECONOMICAOld = Value
        End Set
    End Property 

    Private _fkID_ACTI_ECONOMICA As ACTI_ECONOMICA
    Public Property fkID_ACTI_ECONOMICA() As ACTI_ECONOMICA
        Get
            Return _fkID_ACTI_ECONOMICA
        End Get
        Set(ByVal Value As ACTI_ECONOMICA)
            _fkID_ACTI_ECONOMICA = Value
        End Set
    End Property 

    Private _ID_AREA_EMPRESA As Decimal
    <Column(Name:="Id area empresa", Storage:="ID_AREA_EMPRESA", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_AREA_EMPRESA() As Decimal
        Get
            Return _ID_AREA_EMPRESA
        End Get
        Set(ByVal Value As Decimal)
            _ID_AREA_EMPRESA = Value
            OnPropertyChanged("ID_AREA_EMPRESA")
        End Set
    End Property 

    Private _ID_AREA_EMPRESAOld As Decimal
    Public Property ID_AREA_EMPRESAOld() As Decimal
        Get
            Return _ID_AREA_EMPRESAOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_AREA_EMPRESAOld = Value
        End Set
    End Property 

    Private _fkID_AREA_EMPRESA As AREA_EMPRESA
    Public Property fkID_AREA_EMPRESA() As AREA_EMPRESA
        Get
            Return _fkID_AREA_EMPRESA
        End Get
        Set(ByVal Value As AREA_EMPRESA)
            _fkID_AREA_EMPRESA = Value
        End Set
    End Property 

    Private _ID_MOTIVO_DEJO_TRAB As Decimal
    <Column(Name:="Id motivo dejo trab", Storage:="ID_MOTIVO_DEJO_TRAB", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_MOTIVO_DEJO_TRAB() As Decimal
        Get
            Return _ID_MOTIVO_DEJO_TRAB
        End Get
        Set(ByVal Value As Decimal)
            _ID_MOTIVO_DEJO_TRAB = Value
            OnPropertyChanged("ID_MOTIVO_DEJO_TRAB")
        End Set
    End Property 

    Private _ID_MOTIVO_DEJO_TRABOld As Decimal
    Public Property ID_MOTIVO_DEJO_TRABOld() As Decimal
        Get
            Return _ID_MOTIVO_DEJO_TRABOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_MOTIVO_DEJO_TRABOld = Value
        End Set
    End Property 

    Private _fkID_MOTIVO_DEJO_TRAB As MOTIVO_DEJO_TRAB
    Public Property fkID_MOTIVO_DEJO_TRAB() As MOTIVO_DEJO_TRAB
        Get
            Return _fkID_MOTIVO_DEJO_TRAB
        End Get
        Set(ByVal Value As MOTIVO_DEJO_TRAB)
            _fkID_MOTIVO_DEJO_TRAB = Value
        End Set
    End Property 

    Private _EXPFOR_OBTENER_EMPLEO As Decimal
    <Column(Name:="Expfor obtener empleo", Storage:="EXPFOR_OBTENER_EMPLEO", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=1, Scale:=0)> _
    Public Property EXPFOR_OBTENER_EMPLEO() As Decimal
        Get
            Return _EXPFOR_OBTENER_EMPLEO
        End Get
        Set(ByVal Value As Decimal)
            _EXPFOR_OBTENER_EMPLEO = Value
            OnPropertyChanged("EXPFOR_OBTENER_EMPLEO")
        End Set
    End Property 

    Private _EXPFOR_OBTENER_EMPLEOOld As Decimal
    Public Property EXPFOR_OBTENER_EMPLEOOld() As Decimal
        Get
            Return _EXPFOR_OBTENER_EMPLEOOld
        End Get
        Set(ByVal Value As Decimal)
            _EXPFOR_OBTENER_EMPLEOOld = Value
        End Set
    End Property 

    Private _EXPFOR_INGRESOS_EXTRAS As Decimal
    <Column(Name:="Expfor ingresos extras", Storage:="EXPFOR_INGRESOS_EXTRAS", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=1, Scale:=0)> _
    Public Property EXPFOR_INGRESOS_EXTRAS() As Decimal
        Get
            Return _EXPFOR_INGRESOS_EXTRAS
        End Get
        Set(ByVal Value As Decimal)
            _EXPFOR_INGRESOS_EXTRAS = Value
            OnPropertyChanged("EXPFOR_INGRESOS_EXTRAS")
        End Set
    End Property 

    Private _EXPFOR_INGRESOS_EXTRASOld As Decimal
    Public Property EXPFOR_INGRESOS_EXTRASOld() As Decimal
        Get
            Return _EXPFOR_INGRESOS_EXTRASOld
        End Get
        Set(ByVal Value As Decimal)
            _EXPFOR_INGRESOS_EXTRASOld = Value
        End Set
    End Property 

    Private _EXPFOR_TRABAJAR_CTA_PROPIA As Decimal
    <Column(Name:="Expfor trabajar cta propia", Storage:="EXPFOR_TRABAJAR_CTA_PROPIA", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=1, Scale:=0)> _
    Public Property EXPFOR_TRABAJAR_CTA_PROPIA() As Decimal
        Get
            Return _EXPFOR_TRABAJAR_CTA_PROPIA
        End Get
        Set(ByVal Value As Decimal)
            _EXPFOR_TRABAJAR_CTA_PROPIA = Value
            OnPropertyChanged("EXPFOR_TRABAJAR_CTA_PROPIA")
        End Set
    End Property 

    Private _EXPFOR_TRABAJAR_CTA_PROPIAOld As Decimal
    Public Property EXPFOR_TRABAJAR_CTA_PROPIAOld() As Decimal
        Get
            Return _EXPFOR_TRABAJAR_CTA_PROPIAOld
        End Get
        Set(ByVal Value As Decimal)
            _EXPFOR_TRABAJAR_CTA_PROPIAOld = Value
        End Set
    End Property 

    Private _EXPFOR_OTRO As String
    <Column(Name:="Expfor otro", Storage:="EXPFOR_OTRO", DbType:="VARCHAR2(100)", Id:=False), _
     DataObjectField(False, False, True, 100)> _
    Public Property EXPFOR_OTRO() As String
        Get
            Return _EXPFOR_OTRO
        End Get
        Set(ByVal Value As String)
            _EXPFOR_OTRO = Value
            OnPropertyChanged("EXPFOR_OTRO")
        End Set
    End Property 

    Private _EXPFOR_OTROOld As String
    Public Property EXPFOR_OTROOld() As String
        Get
            Return _EXPFOR_OTROOld
        End Get
        Set(ByVal Value As String)
            _EXPFOR_OTROOld = Value
        End Set
    End Property 

    Private _MOTIVO_ELIGIO_CARRERA As String
    <Column(Name:="Motivo eligio carrera", Storage:="MOTIVO_ELIGIO_CARRERA", DbType:="VARCHAR2(2000) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 2000)> _
    Public Property MOTIVO_ELIGIO_CARRERA() As String
        Get
            Return _MOTIVO_ELIGIO_CARRERA
        End Get
        Set(ByVal Value As String)
            _MOTIVO_ELIGIO_CARRERA = Value
            OnPropertyChanged("MOTIVO_ELIGIO_CARRERA")
        End Set
    End Property 

    Private _MOTIVO_ELIGIO_CARRERAOld As String
    Public Property MOTIVO_ELIGIO_CARRERAOld() As String
        Get
            Return _MOTIVO_ELIGIO_CARRERAOld
        End Get
        Set(ByVal Value As String)
            _MOTIVO_ELIGIO_CARRERAOld = Value
        End Set
    End Property 

    Private _NOMBRE_REFERENCIA As String
    <Column(Name:="Nombre referencia", Storage:="NOMBRE_REFERENCIA", DbType:="VARCHAR2(80)", Id:=False), _
     DataObjectField(False, False, True, 80)> _
    Public Property NOMBRE_REFERENCIA() As String
        Get
            Return _NOMBRE_REFERENCIA
        End Get
        Set(ByVal Value As String)
            _NOMBRE_REFERENCIA = Value
            OnPropertyChanged("NOMBRE_REFERENCIA")
        End Set
    End Property 

    Private _NOMBRE_REFERENCIAOld As String
    Public Property NOMBRE_REFERENCIAOld() As String
        Get
            Return _NOMBRE_REFERENCIAOld
        End Get
        Set(ByVal Value As String)
            _NOMBRE_REFERENCIAOld = Value
        End Set
    End Property 

    Private _ID_REFERENCIA As Decimal
    <Column(Name:="Id referencia", Storage:="ID_REFERENCIA", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=3, Scale:=0)> _
    Public Property ID_REFERENCIA() As Decimal
        Get
            Return _ID_REFERENCIA
        End Get
        Set(ByVal Value As Decimal)
            _ID_REFERENCIA = Value
            OnPropertyChanged("ID_REFERENCIA")
        End Set
    End Property 

    Private _ID_REFERENCIAOld As Decimal
    Public Property ID_REFERENCIAOld() As Decimal
        Get
            Return _ID_REFERENCIAOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_REFERENCIAOld = Value
        End Set
    End Property 

    Private _fkID_REFERENCIA As REFERENCIA
    Public Property fkID_REFERENCIA() As REFERENCIA
        Get
            Return _fkID_REFERENCIA
        End Get
        Set(ByVal Value As REFERENCIA)
            _fkID_REFERENCIA = Value
        End Set
    End Property 

    Private _DIRECCION_REFERENCIA As String
    <Column(Name:="Direccion referencia", Storage:="DIRECCION_REFERENCIA", DbType:="VARCHAR2(100)", Id:=False), _
     DataObjectField(False, False, True, 100)> _
    Public Property DIRECCION_REFERENCIA() As String
        Get
            Return _DIRECCION_REFERENCIA
        End Get
        Set(ByVal Value As String)
            _DIRECCION_REFERENCIA = Value
            OnPropertyChanged("DIRECCION_REFERENCIA")
        End Set
    End Property 

    Private _DIRECCION_REFERENCIAOld As String
    Public Property DIRECCION_REFERENCIAOld() As String
        Get
            Return _DIRECCION_REFERENCIAOld
        End Get
        Set(ByVal Value As String)
            _DIRECCION_REFERENCIAOld = Value
        End Set
    End Property 

    Private _DEPARTAMENTO_REFERENCIA As String
    <Column(Name:="Departamento referencia", Storage:="DEPARTAMENTO_REFERENCIA", DbType:="VARCHAR2(2)", Id:=False), _
     DataObjectField(False, False, True, 2)> _
    Public Property DEPARTAMENTO_REFERENCIA() As String
        Get
            Return _DEPARTAMENTO_REFERENCIA
        End Get
        Set(ByVal Value As String)
            _DEPARTAMENTO_REFERENCIA = Value
            OnPropertyChanged("DEPARTAMENTO_REFERENCIA")
        End Set
    End Property 

    Private _DEPARTAMENTO_REFERENCIAOld As String
    Public Property DEPARTAMENTO_REFERENCIAOld() As String
        Get
            Return _DEPARTAMENTO_REFERENCIAOld
        End Get
        Set(ByVal Value As String)
            _DEPARTAMENTO_REFERENCIAOld = Value
        End Set
    End Property 

    Private _MUNICIPIO_REFERENCIA As String
    <Column(Name:="Municipio referencia", Storage:="MUNICIPIO_REFERENCIA", DbType:="VARCHAR2(2)", Id:=False), _
     DataObjectField(False, False, True, 2)> _
    Public Property MUNICIPIO_REFERENCIA() As String
        Get
            Return _MUNICIPIO_REFERENCIA
        End Get
        Set(ByVal Value As String)
            _MUNICIPIO_REFERENCIA = Value
            OnPropertyChanged("MUNICIPIO_REFERENCIA")
        End Set
    End Property 

    Private _MUNICIPIO_REFERENCIAOld As String
    Public Property MUNICIPIO_REFERENCIAOld() As String
        Get
            Return _MUNICIPIO_REFERENCIAOld
        End Get
        Set(ByVal Value As String)
            _MUNICIPIO_REFERENCIAOld = Value
        End Set
    End Property 

    Private _TELEFONO_REFERENCIA As String
    <Column(Name:="Telefono referencia", Storage:="TELEFONO_REFERENCIA", DbType:="VARCHAR2(40)", Id:=False), _
     DataObjectField(False, False, True, 40)> _
    Public Property TELEFONO_REFERENCIA() As String
        Get
            Return _TELEFONO_REFERENCIA
        End Get
        Set(ByVal Value As String)
            _TELEFONO_REFERENCIA = Value
            OnPropertyChanged("TELEFONO_REFERENCIA")
        End Set
    End Property 

    Private _TELEFONO_REFERENCIAOld As String
    Public Property TELEFONO_REFERENCIAOld() As String
        Get
            Return _TELEFONO_REFERENCIAOld
        End Get
        Set(ByVal Value As String)
            _TELEFONO_REFERENCIAOld = Value
        End Set
    End Property 

    Private _MOVIL_REFERENCIA As String
    <Column(Name:="Movil referencia", Storage:="MOVIL_REFERENCIA", DbType:="VARCHAR2(40)", Id:=False), _
     DataObjectField(False, False, True, 40)> _
    Public Property MOVIL_REFERENCIA() As String
        Get
            Return _MOVIL_REFERENCIA
        End Get
        Set(ByVal Value As String)
            _MOVIL_REFERENCIA = Value
            OnPropertyChanged("MOVIL_REFERENCIA")
        End Set
    End Property 

    Private _MOVIL_REFERENCIAOld As String
    Public Property MOVIL_REFERENCIAOld() As String
        Get
            Return _MOVIL_REFERENCIAOld
        End Get
        Set(ByVal Value As String)
            _MOVIL_REFERENCIAOld = Value
        End Set
    End Property 

    Private _EMAIL_REFERENCIA As String
    <Column(Name:="Email referencia", Storage:="EMAIL_REFERENCIA", DbType:="VARCHAR2(100)", Id:=False), _
     DataObjectField(False, False, True, 100)> _
    Public Property EMAIL_REFERENCIA() As String
        Get
            Return _EMAIL_REFERENCIA
        End Get
        Set(ByVal Value As String)
            _EMAIL_REFERENCIA = Value
            OnPropertyChanged("EMAIL_REFERENCIA")
        End Set
    End Property 

    Private _EMAIL_REFERENCIAOld As String
    Public Property EMAIL_REFERENCIAOld() As String
        Get
            Return _EMAIL_REFERENCIAOld
        End Get
        Set(ByVal Value As String)
            _EMAIL_REFERENCIAOld = Value
        End Set
    End Property 

    Private _SUGERENCIAS As String
    <Column(Name:="Sugerencias", Storage:="SUGERENCIAS", DbType:="VARCHAR2(600)", Id:=False), _
     DataObjectField(False, False, True, 600)> _
    Public Property SUGERENCIAS() As String
        Get
            Return _SUGERENCIAS
        End Get
        Set(ByVal Value As String)
            _SUGERENCIAS = Value
            OnPropertyChanged("SUGERENCIAS")
        End Set
    End Property 

    Private _SUGERENCIASOld As String
    Public Property SUGERENCIASOld() As String
        Get
            Return _SUGERENCIASOld
        End Get
        Set(ByVal Value As String)
            _SUGERENCIASOld = Value
        End Set
    End Property 

    Private _USUARIO_CREA As String
    <Column(Name:="Usuario crea", Storage:="USUARIO_CREA", DbType:="VARCHAR2(256)", Id:=False), _
     DataObjectField(False, False, True, 256)> _
    Public Property USUARIO_CREA() As String
        Get
            Return _USUARIO_CREA
        End Get
        Set(ByVal Value As String)
            _USUARIO_CREA = Value
            OnPropertyChanged("USUARIO_CREA")
        End Set
    End Property 

    Private _USUARIO_CREAOld As String
    Public Property USUARIO_CREAOld() As String
        Get
            Return _USUARIO_CREAOld
        End Get
        Set(ByVal Value As String)
            _USUARIO_CREAOld = Value
        End Set
    End Property 

    Private _FECHA_CREACION As DateTime
    <Column(Name:="Fecha creacion", Storage:="FECHA_CREACION", DbType:="DATE", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property FECHA_CREACION() As DateTime
        Get
            Return _FECHA_CREACION
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_CREACION = Value
            OnPropertyChanged("FECHA_CREACION")
        End Set
    End Property 

    Private _FECHA_CREACIONOld As DateTime
    Public Property FECHA_CREACIONOld() As DateTime
        Get
            Return _FECHA_CREACIONOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_CREACIONOld = Value
        End Set
    End Property 

    Private _USUARIO_ACT As String
    <Column(Name:="Usuario act", Storage:="USUARIO_ACT", DbType:="VARCHAR2(256)", Id:=False), _
     DataObjectField(False, False, True, 256)> _
    Public Property USUARIO_ACT() As String
        Get
            Return _USUARIO_ACT
        End Get
        Set(ByVal Value As String)
            _USUARIO_ACT = Value
            OnPropertyChanged("USUARIO_ACT")
        End Set
    End Property 

    Private _USUARIO_ACTOld As String
    Public Property USUARIO_ACTOld() As String
        Get
            Return _USUARIO_ACTOld
        End Get
        Set(ByVal Value As String)
            _USUARIO_ACTOld = Value
        End Set
    End Property 

    Private _FECHA_ACT As DateTime
    <Column(Name:="Fecha act", Storage:="FECHA_ACT", DbType:="DATE", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property FECHA_ACT() As DateTime
        Get
            Return _FECHA_ACT
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_ACT = Value
            OnPropertyChanged("FECHA_ACT")
        End Set
    End Property 

    Private _FECHA_ACTOld As DateTime
    Public Property FECHA_ACTOld() As DateTime
        Get
            Return _FECHA_ACTOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_ACTOld = Value
        End Set
    End Property 

    Private _TIPO_EMPLEO_OTRO As String
    <Column(Name:="Tipo empleo otro", Storage:="TIPO_EMPLEO_OTRO", DbType:="VARCHAR2(100)", Id:=False), _
     DataObjectField(False, False, True, 100)> _
    Public Property TIPO_EMPLEO_OTRO() As String
        Get
            Return _TIPO_EMPLEO_OTRO
        End Get
        Set(ByVal Value As String)
            _TIPO_EMPLEO_OTRO = Value
            OnPropertyChanged("TIPO_EMPLEO_OTRO")
        End Set
    End Property 

    Private _TIPO_EMPLEO_OTROOld As String
    Public Property TIPO_EMPLEO_OTROOld() As String
        Get
            Return _TIPO_EMPLEO_OTROOld
        End Get
        Set(ByVal Value As String)
            _TIPO_EMPLEO_OTROOld = Value
        End Set
    End Property 

    Private _TRABAJO_ANTERIOR As String
    <Column(Name:="Trabajo anterior", Storage:="TRABAJO_ANTERIOR", DbType:="CHAR(1)", Id:=False), _
     DataObjectField(False, False, True, 1)> _
    Public Property TRABAJO_ANTERIOR() As String
        Get
            Return _TRABAJO_ANTERIOR
        End Get
        Set(ByVal Value As String)
            _TRABAJO_ANTERIOR = Value
            OnPropertyChanged("TRABAJO_ANTERIOR")
        End Set
    End Property 

    Private _TRABAJO_ANTERIOROld As String
    Public Property TRABAJO_ANTERIOROld() As String
        Get
            Return _TRABAJO_ANTERIOROld
        End Get
        Set(ByVal Value As String)
            _TRABAJO_ANTERIOROld = Value
        End Set
    End Property 

    Private _PUESTO_DESEMPENO As String
    <Column(Name:="Puesto desempeno", Storage:="PUESTO_DESEMPENO", DbType:="VARCHAR2(200)", Id:=False), _
     DataObjectField(False, False, True, 200)> _
    Public Property PUESTO_DESEMPENO() As String
        Get
            Return _PUESTO_DESEMPENO
        End Get
        Set(ByVal Value As String)
            _PUESTO_DESEMPENO = Value
            OnPropertyChanged("PUESTO_DESEMPENO")
        End Set
    End Property 

    Private _PUESTO_DESEMPENOOld As String
    Public Property PUESTO_DESEMPENOOld() As String
        Get
            Return _PUESTO_DESEMPENOOld
        End Get
        Set(ByVal Value As String)
            _PUESTO_DESEMPENOOld = Value
        End Set
    End Property 

    Private _ID_ULT_SALARIO_MES As Decimal
    <Column(Name:="Id ult salario mes", Storage:="ID_ULT_SALARIO_MES", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_ULT_SALARIO_MES() As Decimal
        Get
            Return _ID_ULT_SALARIO_MES
        End Get
        Set(ByVal Value As Decimal)
            _ID_ULT_SALARIO_MES = Value
            OnPropertyChanged("ID_ULT_SALARIO_MES")
        End Set
    End Property 

    Private _ID_ULT_SALARIO_MESOld As Decimal
    Public Property ID_ULT_SALARIO_MESOld() As Decimal
        Get
            Return _ID_ULT_SALARIO_MESOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_ULT_SALARIO_MESOld = Value
        End Set
    End Property 

    Private _fkID_ULT_SALARIO_MES As INGRESO_MES
    Public Property fkID_ULT_SALARIO_MES() As INGRESO_MES
        Get
            Return _fkID_ULT_SALARIO_MES
        End Get
        Set(ByVal Value As INGRESO_MES)
            _fkID_ULT_SALARIO_MES = Value
        End Set
    End Property 

    Private _ES_RECLUTA_INICIAL As Decimal
    <Column(Name:="Es recluta inicial", Storage:="ES_RECLUTA_INICIAL", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=1, Scale:=0)> _
    Public Property ES_RECLUTA_INICIAL() As Decimal
        Get
            Return _ES_RECLUTA_INICIAL
        End Get
        Set(ByVal Value As Decimal)
            _ES_RECLUTA_INICIAL = Value
            OnPropertyChanged("ES_RECLUTA_INICIAL")
        End Set
    End Property 

    Private _ES_RECLUTA_INICIALOld As Decimal
    Public Property ES_RECLUTA_INICIALOld() As Decimal
        Get
            Return _ES_RECLUTA_INICIALOld
        End Get
        Set(ByVal Value As Decimal)
            _ES_RECLUTA_INICIALOld = Value
        End Set
    End Property 

    Private _ES_RECLUTA_EXTRA As Decimal
    <Column(Name:="Es recluta extra", Storage:="ES_RECLUTA_EXTRA", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=1, Scale:=0)> _
    Public Property ES_RECLUTA_EXTRA() As Decimal
        Get
            Return _ES_RECLUTA_EXTRA
        End Get
        Set(ByVal Value As Decimal)
            _ES_RECLUTA_EXTRA = Value
            OnPropertyChanged("ES_RECLUTA_EXTRA")
        End Set
    End Property 

    Private _ES_RECLUTA_EXTRAOld As Decimal
    Public Property ES_RECLUTA_EXTRAOld() As Decimal
        Get
            Return _ES_RECLUTA_EXTRAOld
        End Get
        Set(ByVal Value As Decimal)
            _ES_RECLUTA_EXTRAOld = Value
        End Set
    End Property 

    Private _REQUI_AUTORIZACION As Decimal
    <Column(Name:="Requi autorizacion", Storage:="REQUI_AUTORIZACION", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=1, Scale:=0)> _
    Public Property REQUI_AUTORIZACION() As Decimal
        Get
            Return _REQUI_AUTORIZACION
        End Get
        Set(ByVal Value As Decimal)
            _REQUI_AUTORIZACION = Value
            OnPropertyChanged("REQUI_AUTORIZACION")
        End Set
    End Property 

    Private _REQUI_AUTORIZACIONOld As Decimal
    Public Property REQUI_AUTORIZACIONOld() As Decimal
        Get
            Return _REQUI_AUTORIZACIONOld
        End Get
        Set(ByVal Value As Decimal)
            _REQUI_AUTORIZACIONOld = Value
        End Set
    End Property 

    Private _OBSERVACION_AURIZACION As String
    <Column(Name:="Observacion aurizacion", Storage:="OBSERVACION_AURIZACION", DbType:="VARCHAR2(500)", Id:=False), _
     DataObjectField(False, False, True, 500)> _
    Public Property OBSERVACION_AURIZACION() As String
        Get
            Return _OBSERVACION_AURIZACION
        End Get
        Set(ByVal Value As String)
            _OBSERVACION_AURIZACION = Value
            OnPropertyChanged("OBSERVACION_AURIZACION")
        End Set
    End Property 

    Private _OBSERVACION_AURIZACIONOld As String
    Public Property OBSERVACION_AURIZACIONOld() As String
        Get
            Return _OBSERVACION_AURIZACIONOld
        End Get
        Set(ByVal Value As String)
            _OBSERVACION_AURIZACIONOld = Value
        End Set
    End Property 

    Private _AUTORIZADO As Decimal
    <Column(Name:="Autorizado", Storage:="AUTORIZADO", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=1, Scale:=0)> _
    Public Property AUTORIZADO() As Decimal
        Get
            Return _AUTORIZADO
        End Get
        Set(ByVal Value As Decimal)
            _AUTORIZADO = Value
            OnPropertyChanged("AUTORIZADO")
        End Set
    End Property 

    Private _AUTORIZADOOld As Decimal
    Public Property AUTORIZADOOld() As Decimal
        Get
            Return _AUTORIZADOOld
        End Get
        Set(ByVal Value As Decimal)
            _AUTORIZADOOld = Value
        End Set
    End Property 

    Private _MOTIVO_AUTORIZADO As String
    <Column(Name:="Motivo autorizado", Storage:="MOTIVO_AUTORIZADO", DbType:="VARCHAR2(500)", Id:=False), _
     DataObjectField(False, False, True, 500)> _
    Public Property MOTIVO_AUTORIZADO() As String
        Get
            Return _MOTIVO_AUTORIZADO
        End Get
        Set(ByVal Value As String)
            _MOTIVO_AUTORIZADO = Value
            OnPropertyChanged("MOTIVO_AUTORIZADO")
        End Set
    End Property 

    Private _MOTIVO_AUTORIZADOOld As String
    Public Property MOTIVO_AUTORIZADOOld() As String
        Get
            Return _MOTIVO_AUTORIZADOOld
        End Get
        Set(ByVal Value As String)
            _MOTIVO_AUTORIZADOOld = Value
        End Set
    End Property 

    Private _USUARIO_AUTORIZO As String
    <Column(Name:="Usuario autorizo", Storage:="USUARIO_AUTORIZO", DbType:="VARCHAR2(100)", Id:=False), _
     DataObjectField(False, False, True, 100)> _
    Public Property USUARIO_AUTORIZO() As String
        Get
            Return _USUARIO_AUTORIZO
        End Get
        Set(ByVal Value As String)
            _USUARIO_AUTORIZO = Value
            OnPropertyChanged("USUARIO_AUTORIZO")
        End Set
    End Property 

    Private _USUARIO_AUTORIZOOld As String
    Public Property USUARIO_AUTORIZOOld() As String
        Get
            Return _USUARIO_AUTORIZOOld
        End Get
        Set(ByVal Value As String)
            _USUARIO_AUTORIZOOld = Value
        End Set
    End Property 

    Private _FECHA_AITORIZA As DateTime
    <Column(Name:="Fecha aitoriza", Storage:="FECHA_AITORIZA", DbType:="DATE", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property FECHA_AITORIZA() As DateTime
        Get
            Return _FECHA_AITORIZA
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_AITORIZA = Value
            OnPropertyChanged("FECHA_AITORIZA")
        End Set
    End Property 

    Private _FECHA_AITORIZAOld As DateTime
    Public Property FECHA_AITORIZAOld() As DateTime
        Get
            Return _FECHA_AITORIZAOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_AITORIZAOld = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
