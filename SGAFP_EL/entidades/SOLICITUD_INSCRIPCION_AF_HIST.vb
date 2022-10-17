''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.SOLICITUD_INSCRIPCION_AF_HIST
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite tener un registro de la tabla SOLICITUD_INSCRIPCION_AF_HIST en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.6.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	21/09/2010	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="SOLICITUD_INSCRIPCION_AF_HIST")> Public Class SOLICITUD_INSCRIPCION_AF_HIST
    Inherits entidadBase
    Implements IEquatable(Of SOLICITUD_INSCRIPCION_AF_HIST), IComparable(Of SOLICITUD_INSCRIPCION_AF_HIST)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_SOLICITUD_HIST As Decimal, aID_SOLICITUD As Decimal, aFECHA_PRESENTACION As DateTime, aID_PARTICIPANTE As Decimal, aID_ACCION_FORMATIVA As Decimal, aID_ESTADO_SOLICITUD As Decimal, aNUMERO_DOCUMENTO As Decimal, aID_TIPO_SOLICITUD As Decimal, aNIT_EMPRESA As String, aNOMBRE_EMPRESA As String, aCARGO As String, aNUMERO_PATRONAL As String, aNOMBRES As String, aAPELLIDOS As String, aLUGAR_NACIMIENTO As String, aCODIGO_MUNICIPIO As String, aCODIGO_DEPARTAMENTO As String, aCODIGO_REGION As String, aZONA As String, aTELEFONO As String, aMOVIL As String, aFAX As String, aEMAIL As String, aNIT As String, aISSS As String, aCIUO As String, aEDAD As Decimal, aDEPARTAMENTO_NAC As String, aMUNICIPIO_NAC As String, aFECHA_NACIMIENTO As DateTime, aDUI As String, aGENERO As String, aDIRECCION As String, aPROFESION_OFICIO As String, aESTADO_CIVIL As String, aNOMBRE_FAMILIAR As String, aPARENTESCO As String, aDIRECCION_FAMILIAR As String, aTELEFONO_FAMILIAR As String, aOCUACT_TRABAJA As Decimal, aOCUACT_ESTUDIA As Decimal, aOCUACT_DESOCUPADO As Decimal, aOCUACT_OFICIO_HOGAR As Decimal, aTIPTRA_EMPLEADO_EMPRESA As Decimal, aTIPTRA_EMPRESA_PROPIA As Decimal, aTIPTRA_EVENTUAL As Decimal, aTIPTRA_MEDIO_TIEMPO As Decimal, aTIPTRA_INDEPENDIENTE As Decimal, aRTC_OCUPACION_EMPRESA As Decimal, aRTC_PROPIA_EMPRESA As Decimal, aRTC_TRABAJO_EVENTUAL As Decimal, aRTC_TRABAJO_MEDIO_TIEMPO As Decimal, aRTC_INDEPENDIENTE As Decimal, aRTC_NO_OCUPACION_EMPRESA As Decimal, aRTC_NO_PROPIA_EMPRESA As Decimal, aRTC_NO_TRABAJO_EVENTUAL As Decimal, aRTC_NO_TRABAJO_MEDIO_TIEMPO As Decimal, aRTC_NO_INDEPENDIENTE As Decimal, aNIVEL_ACADEMICO As String, aTITULO_CERTIFICADO_OBTENIDO As String, aTIEMPO_DEJO_ESTUDIAR As String, aRECIBIO_CURSO_ANTERIOR As String, aOBTUVO_BENEFICIOS_CURSO As String, aBENEF_PROM_EMP_ACT As Decimal, aBENEF_OBT_EMPLEO As Decimal, aBENEF_OBT_ING_EXTRA As Decimal, aBENEF_CAMB_EMP_X_CURSO As Decimal, aBENEF_TRAB_CTA_PROPIA As Decimal, aBENEF_OTRO As String, aRAZON_NO_BENEFICIO As String, aTRABAJA_ACTUALMENTE As String, aTRABAJO_ANTERIOR As String, aEXPFOR_PROMOCION_EMPLEO As Decimal, aEXPFOR_CAMBIAR_EMPLEO As Decimal, aEXPFOR_OBTENER_EMPLEO As Decimal, aEXPFOR_TRABAJAR_CTA_PROPIA As Decimal, aEXPFOR_INGRESOS_EXTRAS As Decimal, aEXPFOR_OTRO As String, aINGRESO_MENSUAL_INDIVIDUAL As String, aINGRESO_MENSUAL_FAMILIAR As String, aMIEMBROS_GRUPO_FAMILIAR As Decimal, aSUGERENCIAS As String, aLUGAR_PRESENTACION As String, aID_PROVEEDOR_AF As Decimal, aUSERID_HIST As String, aLASTUPDATE_HIST As DateTime, aUSERID As String, aLASTUPDATE As DateTime)
        Me._ID_SOLICITUD_HIST = aID_SOLICITUD_HIST
        Me._ID_SOLICITUD = aID_SOLICITUD
        Me._FECHA_PRESENTACION = aFECHA_PRESENTACION
        Me._ID_PARTICIPANTE = aID_PARTICIPANTE
        Me._ID_ACCION_FORMATIVA = aID_ACCION_FORMATIVA
        Me._ID_ESTADO_SOLICITUD = aID_ESTADO_SOLICITUD
        Me._NUMERO_DOCUMENTO = aNUMERO_DOCUMENTO
        Me._ID_TIPO_SOLICITUD = aID_TIPO_SOLICITUD
        Me._NIT_EMPRESA = aNIT_EMPRESA
        Me._NOMBRE_EMPRESA = aNOMBRE_EMPRESA
        Me._CARGO = aCARGO
        Me._NUMERO_PATRONAL = aNUMERO_PATRONAL
        Me._NOMBRES = aNOMBRES
        Me._APELLIDOS = aAPELLIDOS
        Me._LUGAR_NACIMIENTO = aLUGAR_NACIMIENTO
        Me._CODIGO_MUNICIPIO = aCODIGO_MUNICIPIO
        Me._CODIGO_DEPARTAMENTO = aCODIGO_DEPARTAMENTO
        Me._CODIGO_REGION = aCODIGO_REGION
        Me._ZONA = aZONA
        Me._TELEFONO = aTELEFONO
        Me._MOVIL = aMOVIL
        Me._FAX = aFAX
        Me._EMAIL = aEMAIL
        Me._NIT = aNIT
        Me._ISSS = aISSS
        Me._CIUO = aCIUO
        Me._EDAD = aEDAD
        Me._DEPARTAMENTO_NAC = aDEPARTAMENTO_NAC
        Me._MUNICIPIO_NAC = aMUNICIPIO_NAC
        Me._FECHA_NACIMIENTO = aFECHA_NACIMIENTO
        Me._DUI = aDUI
        Me._GENERO = aGENERO
        Me._DIRECCION = aDIRECCION
        Me._PROFESION_OFICIO = aPROFESION_OFICIO
        Me._ESTADO_CIVIL = aESTADO_CIVIL
        Me._NOMBRE_FAMILIAR = aNOMBRE_FAMILIAR
        Me._PARENTESCO = aPARENTESCO
        Me._DIRECCION_FAMILIAR = aDIRECCION_FAMILIAR
        Me._TELEFONO_FAMILIAR = aTELEFONO_FAMILIAR
        Me._OCUACT_TRABAJA = aOCUACT_TRABAJA
        Me._OCUACT_ESTUDIA = aOCUACT_ESTUDIA
        Me._OCUACT_DESOCUPADO = aOCUACT_DESOCUPADO
        Me._OCUACT_OFICIO_HOGAR = aOCUACT_OFICIO_HOGAR
        Me._TIPTRA_EMPLEADO_EMPRESA = aTIPTRA_EMPLEADO_EMPRESA
        Me._TIPTRA_EMPRESA_PROPIA = aTIPTRA_EMPRESA_PROPIA
        Me._TIPTRA_EVENTUAL = aTIPTRA_EVENTUAL
        Me._TIPTRA_MEDIO_TIEMPO = aTIPTRA_MEDIO_TIEMPO
        Me._TIPTRA_INDEPENDIENTE = aTIPTRA_INDEPENDIENTE
        Me._RTC_OCUPACION_EMPRESA = aRTC_OCUPACION_EMPRESA
        Me._RTC_PROPIA_EMPRESA = aRTC_PROPIA_EMPRESA
        Me._RTC_TRABAJO_EVENTUAL = aRTC_TRABAJO_EVENTUAL
        Me._RTC_TRABAJO_MEDIO_TIEMPO = aRTC_TRABAJO_MEDIO_TIEMPO
        Me._RTC_INDEPENDIENTE = aRTC_INDEPENDIENTE
        Me._RTC_NO_OCUPACION_EMPRESA = aRTC_NO_OCUPACION_EMPRESA
        Me._RTC_NO_PROPIA_EMPRESA = aRTC_NO_PROPIA_EMPRESA
        Me._RTC_NO_TRABAJO_EVENTUAL = aRTC_NO_TRABAJO_EVENTUAL
        Me._RTC_NO_TRABAJO_MEDIO_TIEMPO = aRTC_NO_TRABAJO_MEDIO_TIEMPO
        Me._RTC_NO_INDEPENDIENTE = aRTC_NO_INDEPENDIENTE
        Me._NIVEL_ACADEMICO = aNIVEL_ACADEMICO
        Me._TITULO_CERTIFICADO_OBTENIDO = aTITULO_CERTIFICADO_OBTENIDO
        Me._TIEMPO_DEJO_ESTUDIAR = aTIEMPO_DEJO_ESTUDIAR
        Me._RECIBIO_CURSO_ANTERIOR = aRECIBIO_CURSO_ANTERIOR
        Me._OBTUVO_BENEFICIOS_CURSO = aOBTUVO_BENEFICIOS_CURSO
        Me._BENEF_PROM_EMP_ACT = aBENEF_PROM_EMP_ACT
        Me._BENEF_OBT_EMPLEO = aBENEF_OBT_EMPLEO
        Me._BENEF_OBT_ING_EXTRA = aBENEF_OBT_ING_EXTRA
        Me._BENEF_CAMB_EMP_X_CURSO = aBENEF_CAMB_EMP_X_CURSO
        Me._BENEF_TRAB_CTA_PROPIA = aBENEF_TRAB_CTA_PROPIA
        Me._BENEF_OTRO = aBENEF_OTRO
        Me._RAZON_NO_BENEFICIO = aRAZON_NO_BENEFICIO
        Me._TRABAJA_ACTUALMENTE = aTRABAJA_ACTUALMENTE
        Me._TRABAJO_ANTERIOR = aTRABAJO_ANTERIOR
        Me._EXPFOR_PROMOCION_EMPLEO = aEXPFOR_PROMOCION_EMPLEO
        Me._EXPFOR_CAMBIAR_EMPLEO = aEXPFOR_CAMBIAR_EMPLEO
        Me._EXPFOR_OBTENER_EMPLEO = aEXPFOR_OBTENER_EMPLEO
        Me._EXPFOR_TRABAJAR_CTA_PROPIA = aEXPFOR_TRABAJAR_CTA_PROPIA
        Me._EXPFOR_INGRESOS_EXTRAS = aEXPFOR_INGRESOS_EXTRAS
        Me._EXPFOR_OTRO = aEXPFOR_OTRO
        Me._INGRESO_MENSUAL_INDIVIDUAL = aINGRESO_MENSUAL_INDIVIDUAL
        Me._INGRESO_MENSUAL_FAMILIAR = aINGRESO_MENSUAL_FAMILIAR
        Me._MIEMBROS_GRUPO_FAMILIAR = aMIEMBROS_GRUPO_FAMILIAR
        Me._SUGERENCIAS = aSUGERENCIAS
        Me._LUGAR_PRESENTACION = aLUGAR_PRESENTACION
        Me._ID_PROVEEDOR_AF = aID_PROVEEDOR_AF
        Me._USERID_HIST = aUSERID_HIST
        Me._LASTUPDATE_HIST = aLASTUPDATE_HIST
        Me._USERID = aUSERID
        Me._LASTUPDATE = aLASTUPDATE
    End Sub

    Public Function Equals1(ByVal other As SOLICITUD_INSCRIPCION_AF_HIST) As Boolean Implements System.IEquatable(Of SOLICITUD_INSCRIPCION_AF_HIST).Equals
        Return Me.ID_SOLICITUD_HIST = other.ID_SOLICITUD_HIST
    End Function

    Public Function CompareTo(ByVal other As SOLICITUD_INSCRIPCION_AF_HIST) As Integer Implements System.IComparable(Of SOLICITUD_INSCRIPCION_AF_HIST).CompareTo
        If Me.ID_SOLICITUD_HIST > other.ID_SOLICITUD_HIST Then Return 1
        If Me.ID_SOLICITUD_HIST < other.ID_SOLICITUD_HIST Then Return -1
        Return 0
    End Function


#Region " Propiedades "

    Private _ID_SOLICITUD_HIST As Decimal
    <Column(Name:="Id solicitud hist", Storage:="ID_SOLICITUD_HIST", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_SOLICITUD_HIST() As Decimal
        Get
            Return _ID_SOLICITUD_HIST
        End Get
        Set(ByVal Value As Decimal)
            _ID_SOLICITUD_HIST = Value
            OnPropertyChanged("ID_SOLICITUD_HIST")
        End Set
    End Property 

    Private _ID_SOLICITUD As Decimal
    <Column(Name:="Id solicitud", Storage:="ID_SOLICITUD", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_SOLICITUD() As Decimal
        Get
            Return _ID_SOLICITUD
        End Get
        Set(ByVal Value As Decimal)
            _ID_SOLICITUD = Value
            OnPropertyChanged("ID_SOLICITUD")
        End Set
    End Property 

    Private _ID_SOLICITUDOld As Decimal
    Public Property ID_SOLICITUDOld() As Decimal
        Get
            Return _ID_SOLICITUDOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_SOLICITUDOld = Value
        End Set
    End Property 

    Private _FECHA_PRESENTACION As DateTime
    <Column(Name:="Fecha presentacion", Storage:="FECHA_PRESENTACION", DbType:="DATE", Id:=False), _
     DataObjectField(False, False, True)> _
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
    <Column(Name:="Id participante", Storage:="ID_PARTICIPANTE", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=8, Scale:=0)> _
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

    Private _ID_ACCION_FORMATIVA As Decimal
    <Column(Name:="Id accion formativa", Storage:="ID_ACCION_FORMATIVA", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_ACCION_FORMATIVA() As Decimal
        Get
            Return _ID_ACCION_FORMATIVA
        End Get
        Set(ByVal Value As Decimal)
            _ID_ACCION_FORMATIVA = Value
            OnPropertyChanged("ID_ACCION_FORMATIVA")
        End Set
    End Property 

    Private _ID_ACCION_FORMATIVAOld As Decimal
    Public Property ID_ACCION_FORMATIVAOld() As Decimal
        Get
            Return _ID_ACCION_FORMATIVAOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_ACCION_FORMATIVAOld = Value
        End Set
    End Property 

    Private _fkID_ACCION_FORMATIVA As ACCION_FORMATIVA
    Public Property fkID_ACCION_FORMATIVA() As ACCION_FORMATIVA
        Get
            Return _fkID_ACCION_FORMATIVA
        End Get
        Set(ByVal Value As ACCION_FORMATIVA)
            _fkID_ACCION_FORMATIVA = Value
        End Set
    End Property 

    Private _ID_ESTADO_SOLICITUD As Decimal
    <Column(Name:="Id estado solicitud", Storage:="ID_ESTADO_SOLICITUD", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=2, Scale:=0)> _
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

    Private _NUMERO_DOCUMENTO As Decimal
    <Column(Name:="Numero documento", Storage:="NUMERO_DOCUMENTO", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=8, Scale:=0)> _
    Public Property NUMERO_DOCUMENTO() As Decimal
        Get
            Return _NUMERO_DOCUMENTO
        End Get
        Set(ByVal Value As Decimal)
            _NUMERO_DOCUMENTO = Value
            OnPropertyChanged("NUMERO_DOCUMENTO")
        End Set
    End Property 

    Private _NUMERO_DOCUMENTOOld As Decimal
    Public Property NUMERO_DOCUMENTOOld() As Decimal
        Get
            Return _NUMERO_DOCUMENTOOld
        End Get
        Set(ByVal Value As Decimal)
            _NUMERO_DOCUMENTOOld = Value
        End Set
    End Property 

    Private _fkNUMERO_DOCUMENTO As CONTROL_DOCUMENTOS
    Public Property fkNUMERO_DOCUMENTO() As CONTROL_DOCUMENTOS
        Get
            Return _fkNUMERO_DOCUMENTO
        End Get
        Set(ByVal Value As CONTROL_DOCUMENTOS)
            _fkNUMERO_DOCUMENTO = Value
        End Set
    End Property 

    Private _ID_TIPO_SOLICITUD As Decimal
    <Column(Name:="Id tipo solicitud", Storage:="ID_TIPO_SOLICITUD", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_TIPO_SOLICITUD() As Decimal
        Get
            Return _ID_TIPO_SOLICITUD
        End Get
        Set(ByVal Value As Decimal)
            _ID_TIPO_SOLICITUD = Value
            OnPropertyChanged("ID_TIPO_SOLICITUD")
        End Set
    End Property 

    Private _ID_TIPO_SOLICITUDOld As Decimal
    Public Property ID_TIPO_SOLICITUDOld() As Decimal
        Get
            Return _ID_TIPO_SOLICITUDOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_TIPO_SOLICITUDOld = Value
        End Set
    End Property 

    Private _fkID_TIPO_SOLICITUD As TIPO_SOLICITUD
    Public Property fkID_TIPO_SOLICITUD() As TIPO_SOLICITUD
        Get
            Return _fkID_TIPO_SOLICITUD
        End Get
        Set(ByVal Value As TIPO_SOLICITUD)
            _fkID_TIPO_SOLICITUD = Value
        End Set
    End Property 

    Private _NIT_EMPRESA As String
    <Column(Name:="Nit empresa", Storage:="NIT_EMPRESA", DbType:="CHAR(14)", Id:=False), _
     DataObjectField(False, False, True, 14)> _
    Public Property NIT_EMPRESA() As String
        Get
            Return _NIT_EMPRESA
        End Get
        Set(ByVal Value As String)
            _NIT_EMPRESA = Value
            OnPropertyChanged("NIT_EMPRESA")
        End Set
    End Property 

    Private _NIT_EMPRESAOld As String
    Public Property NIT_EMPRESAOld() As String
        Get
            Return _NIT_EMPRESAOld
        End Get
        Set(ByVal Value As String)
            _NIT_EMPRESAOld = Value
        End Set
    End Property 

    Private _NOMBRE_EMPRESA As String
    <Column(Name:="Nombre empresa", Storage:="NOMBRE_EMPRESA", DbType:="VARCHAR2(100)", Id:=False), _
     DataObjectField(False, False, True, 100)> _
    Public Property NOMBRE_EMPRESA() As String
        Get
            Return _NOMBRE_EMPRESA
        End Get
        Set(ByVal Value As String)
            _NOMBRE_EMPRESA = Value
            OnPropertyChanged("NOMBRE_EMPRESA")
        End Set
    End Property 

    Private _NOMBRE_EMPRESAOld As String
    Public Property NOMBRE_EMPRESAOld() As String
        Get
            Return _NOMBRE_EMPRESAOld
        End Get
        Set(ByVal Value As String)
            _NOMBRE_EMPRESAOld = Value
        End Set
    End Property 

    Private _CARGO As String
    <Column(Name:="Cargo", Storage:="CARGO", DbType:="VARCHAR2(60)", Id:=False), _
     DataObjectField(False, False, True, 60)> _
    Public Property CARGO() As String
        Get
            Return _CARGO
        End Get
        Set(ByVal Value As String)
            _CARGO = Value
            OnPropertyChanged("CARGO")
        End Set
    End Property 

    Private _CARGOOld As String
    Public Property CARGOOld() As String
        Get
            Return _CARGOOld
        End Get
        Set(ByVal Value As String)
            _CARGOOld = Value
        End Set
    End Property 

    Private _NUMERO_PATRONAL As String
    <Column(Name:="Numero patronal", Storage:="NUMERO_PATRONAL", DbType:="CHAR(9)", Id:=False), _
     DataObjectField(False, False, True, 9)> _
    Public Property NUMERO_PATRONAL() As String
        Get
            Return _NUMERO_PATRONAL
        End Get
        Set(ByVal Value As String)
            _NUMERO_PATRONAL = Value
            OnPropertyChanged("NUMERO_PATRONAL")
        End Set
    End Property 

    Private _NUMERO_PATRONALOld As String
    Public Property NUMERO_PATRONALOld() As String
        Get
            Return _NUMERO_PATRONALOld
        End Get
        Set(ByVal Value As String)
            _NUMERO_PATRONALOld = Value
        End Set
    End Property 

    Private _fkNUMERO_PATRONAL As EMPRESAS
    Public Property fkNUMERO_PATRONAL() As EMPRESAS
        Get
            Return _fkNUMERO_PATRONAL
        End Get
        Set(ByVal Value As EMPRESAS)
            _fkNUMERO_PATRONAL = Value
        End Set
    End Property 

    Private _NOMBRES As String
    <Column(Name:="Nombres", Storage:="NOMBRES", DbType:="VARCHAR2(50)", Id:=False), _
     DataObjectField(False, False, True, 50)> _
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
    <Column(Name:="Apellidos", Storage:="APELLIDOS", DbType:="VARCHAR2(50)", Id:=False), _
     DataObjectField(False, False, True, 50)> _
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

    Private _LUGAR_NACIMIENTO As String
    <Column(Name:="Lugar nacimiento", Storage:="LUGAR_NACIMIENTO", DbType:="VARCHAR2(100)", Id:=False), _
     DataObjectField(False, False, True, 100)> _
    Public Property LUGAR_NACIMIENTO() As String
        Get
            Return _LUGAR_NACIMIENTO
        End Get
        Set(ByVal Value As String)
            _LUGAR_NACIMIENTO = Value
            OnPropertyChanged("LUGAR_NACIMIENTO")
        End Set
    End Property 

    Private _LUGAR_NACIMIENTOOld As String
    Public Property LUGAR_NACIMIENTOOld() As String
        Get
            Return _LUGAR_NACIMIENTOOld
        End Get
        Set(ByVal Value As String)
            _LUGAR_NACIMIENTOOld = Value
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

    Private _CODIGO_REGION As String
    <Column(Name:="Codigo region", Storage:="CODIGO_REGION", DbType:="VARCHAR2(2)", Id:=False), _
     DataObjectField(False, False, True, 2)> _
    Public Property CODIGO_REGION() As String
        Get
            Return _CODIGO_REGION
        End Get
        Set(ByVal Value As String)
            _CODIGO_REGION = Value
            OnPropertyChanged("CODIGO_REGION")
        End Set
    End Property 

    Private _CODIGO_REGIONOld As String
    Public Property CODIGO_REGIONOld() As String
        Get
            Return _CODIGO_REGIONOld
        End Get
        Set(ByVal Value As String)
            _CODIGO_REGIONOld = Value
        End Set
    End Property 

    Private _fkCODIGO_REGION As REGION
    Public Property fkCODIGO_REGION() As REGION
        Get
            Return _fkCODIGO_REGION
        End Get
        Set(ByVal Value As REGION)
            _fkCODIGO_REGION = Value
        End Set
    End Property 

    Private _ZONA As String
    <Column(Name:="Zona", Storage:="ZONA", DbType:="CHAR(1)", Id:=False), _
     DataObjectField(False, False, True, 1)> _
    Public Property ZONA() As String
        Get
            Return _ZONA
        End Get
        Set(ByVal Value As String)
            _ZONA = Value
            OnPropertyChanged("ZONA")
        End Set
    End Property 

    Private _ZONAOld As String
    Public Property ZONAOld() As String
        Get
            Return _ZONAOld
        End Get
        Set(ByVal Value As String)
            _ZONAOld = Value
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

    Private _FAX As String
    <Column(Name:="Fax", Storage:="FAX", DbType:="VARCHAR2(40)", Id:=False), _
     DataObjectField(False, False, True, 40)> _
    Public Property FAX() As String
        Get
            Return _FAX
        End Get
        Set(ByVal Value As String)
            _FAX = Value
            OnPropertyChanged("FAX")
        End Set
    End Property 

    Private _FAXOld As String
    Public Property FAXOld() As String
        Get
            Return _FAXOld
        End Get
        Set(ByVal Value As String)
            _FAXOld = Value
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

    Private _CIUO As String
    <Column(Name:="Ciuo", Storage:="CIUO", DbType:="VARCHAR2(14)", Id:=False), _
     DataObjectField(False, False, True, 14)> _
    Public Property CIUO() As String
        Get
            Return _CIUO
        End Get
        Set(ByVal Value As String)
            _CIUO = Value
            OnPropertyChanged("CIUO")
        End Set
    End Property 

    Private _CIUOOld As String
    Public Property CIUOOld() As String
        Get
            Return _CIUOOld
        End Get
        Set(ByVal Value As String)
            _CIUOOld = Value
        End Set
    End Property 

    Private _fkCIUO As CIUO
    Public Property fkCIUO() As CIUO
        Get
            Return _fkCIUO
        End Get
        Set(ByVal Value As CIUO)
            _fkCIUO = Value
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

    Private _ESTADO_CIVIL As String
    <Column(Name:="Estado civil", Storage:="ESTADO_CIVIL", DbType:="CHAR(1)", Id:=False), _
     DataObjectField(False, False, True, 1)> _
    Public Property ESTADO_CIVIL() As String
        Get
            Return _ESTADO_CIVIL
        End Get
        Set(ByVal Value As String)
            _ESTADO_CIVIL = Value
            OnPropertyChanged("ESTADO_CIVIL")
        End Set
    End Property 

    Private _ESTADO_CIVILOld As String
    Public Property ESTADO_CIVILOld() As String
        Get
            Return _ESTADO_CIVILOld
        End Get
        Set(ByVal Value As String)
            _ESTADO_CIVILOld = Value
        End Set
    End Property 

    Private _NOMBRE_FAMILIAR As String
    <Column(Name:="Nombre familiar", Storage:="NOMBRE_FAMILIAR", DbType:="VARCHAR2(80)", Id:=False), _
     DataObjectField(False, False, True, 80)> _
    Public Property NOMBRE_FAMILIAR() As String
        Get
            Return _NOMBRE_FAMILIAR
        End Get
        Set(ByVal Value As String)
            _NOMBRE_FAMILIAR = Value
            OnPropertyChanged("NOMBRE_FAMILIAR")
        End Set
    End Property 

    Private _NOMBRE_FAMILIAROld As String
    Public Property NOMBRE_FAMILIAROld() As String
        Get
            Return _NOMBRE_FAMILIAROld
        End Get
        Set(ByVal Value As String)
            _NOMBRE_FAMILIAROld = Value
        End Set
    End Property 

    Private _PARENTESCO As String
    <Column(Name:="Parentesco", Storage:="PARENTESCO", DbType:="VARCHAR2(40)", Id:=False), _
     DataObjectField(False, False, True, 40)> _
    Public Property PARENTESCO() As String
        Get
            Return _PARENTESCO
        End Get
        Set(ByVal Value As String)
            _PARENTESCO = Value
            OnPropertyChanged("PARENTESCO")
        End Set
    End Property 

    Private _PARENTESCOOld As String
    Public Property PARENTESCOOld() As String
        Get
            Return _PARENTESCOOld
        End Get
        Set(ByVal Value As String)
            _PARENTESCOOld = Value
        End Set
    End Property 

    Private _DIRECCION_FAMILIAR As String
    <Column(Name:="Direccion familiar", Storage:="DIRECCION_FAMILIAR", DbType:="VARCHAR2(100)", Id:=False), _
     DataObjectField(False, False, True, 100)> _
    Public Property DIRECCION_FAMILIAR() As String
        Get
            Return _DIRECCION_FAMILIAR
        End Get
        Set(ByVal Value As String)
            _DIRECCION_FAMILIAR = Value
            OnPropertyChanged("DIRECCION_FAMILIAR")
        End Set
    End Property 

    Private _DIRECCION_FAMILIAROld As String
    Public Property DIRECCION_FAMILIAROld() As String
        Get
            Return _DIRECCION_FAMILIAROld
        End Get
        Set(ByVal Value As String)
            _DIRECCION_FAMILIAROld = Value
        End Set
    End Property 

    Private _TELEFONO_FAMILIAR As String
    <Column(Name:="Telefono familiar", Storage:="TELEFONO_FAMILIAR", DbType:="CHAR(8)", Id:=False), _
     DataObjectField(False, False, True, 8)> _
    Public Property TELEFONO_FAMILIAR() As String
        Get
            Return _TELEFONO_FAMILIAR
        End Get
        Set(ByVal Value As String)
            _TELEFONO_FAMILIAR = Value
            OnPropertyChanged("TELEFONO_FAMILIAR")
        End Set
    End Property 

    Private _TELEFONO_FAMILIAROld As String
    Public Property TELEFONO_FAMILIAROld() As String
        Get
            Return _TELEFONO_FAMILIAROld
        End Get
        Set(ByVal Value As String)
            _TELEFONO_FAMILIAROld = Value
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

    Private _OCUACT_DESOCUPADO As Decimal
    <Column(Name:="Ocuact desocupado", Storage:="OCUACT_DESOCUPADO", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=1, Scale:=0)> _
    Public Property OCUACT_DESOCUPADO() As Decimal
        Get
            Return _OCUACT_DESOCUPADO
        End Get
        Set(ByVal Value As Decimal)
            _OCUACT_DESOCUPADO = Value
            OnPropertyChanged("OCUACT_DESOCUPADO")
        End Set
    End Property 

    Private _OCUACT_DESOCUPADOOld As Decimal
    Public Property OCUACT_DESOCUPADOOld() As Decimal
        Get
            Return _OCUACT_DESOCUPADOOld
        End Get
        Set(ByVal Value As Decimal)
            _OCUACT_DESOCUPADOOld = Value
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

    Private _TIPTRA_EMPLEADO_EMPRESA As Decimal
    <Column(Name:="Tiptra empleado empresa", Storage:="TIPTRA_EMPLEADO_EMPRESA", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=1, Scale:=0)> _
    Public Property TIPTRA_EMPLEADO_EMPRESA() As Decimal
        Get
            Return _TIPTRA_EMPLEADO_EMPRESA
        End Get
        Set(ByVal Value As Decimal)
            _TIPTRA_EMPLEADO_EMPRESA = Value
            OnPropertyChanged("TIPTRA_EMPLEADO_EMPRESA")
        End Set
    End Property 

    Private _TIPTRA_EMPLEADO_EMPRESAOld As Decimal
    Public Property TIPTRA_EMPLEADO_EMPRESAOld() As Decimal
        Get
            Return _TIPTRA_EMPLEADO_EMPRESAOld
        End Get
        Set(ByVal Value As Decimal)
            _TIPTRA_EMPLEADO_EMPRESAOld = Value
        End Set
    End Property 

    Private _TIPTRA_EMPRESA_PROPIA As Decimal
    <Column(Name:="Tiptra empresa propia", Storage:="TIPTRA_EMPRESA_PROPIA", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=1, Scale:=0)> _
    Public Property TIPTRA_EMPRESA_PROPIA() As Decimal
        Get
            Return _TIPTRA_EMPRESA_PROPIA
        End Get
        Set(ByVal Value As Decimal)
            _TIPTRA_EMPRESA_PROPIA = Value
            OnPropertyChanged("TIPTRA_EMPRESA_PROPIA")
        End Set
    End Property 

    Private _TIPTRA_EMPRESA_PROPIAOld As Decimal
    Public Property TIPTRA_EMPRESA_PROPIAOld() As Decimal
        Get
            Return _TIPTRA_EMPRESA_PROPIAOld
        End Get
        Set(ByVal Value As Decimal)
            _TIPTRA_EMPRESA_PROPIAOld = Value
        End Set
    End Property 

    Private _TIPTRA_EVENTUAL As Decimal
    <Column(Name:="Tiptra eventual", Storage:="TIPTRA_EVENTUAL", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=1, Scale:=0)> _
    Public Property TIPTRA_EVENTUAL() As Decimal
        Get
            Return _TIPTRA_EVENTUAL
        End Get
        Set(ByVal Value As Decimal)
            _TIPTRA_EVENTUAL = Value
            OnPropertyChanged("TIPTRA_EVENTUAL")
        End Set
    End Property 

    Private _TIPTRA_EVENTUALOld As Decimal
    Public Property TIPTRA_EVENTUALOld() As Decimal
        Get
            Return _TIPTRA_EVENTUALOld
        End Get
        Set(ByVal Value As Decimal)
            _TIPTRA_EVENTUALOld = Value
        End Set
    End Property 

    Private _TIPTRA_MEDIO_TIEMPO As Decimal
    <Column(Name:="Tiptra medio tiempo", Storage:="TIPTRA_MEDIO_TIEMPO", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=1, Scale:=0)> _
    Public Property TIPTRA_MEDIO_TIEMPO() As Decimal
        Get
            Return _TIPTRA_MEDIO_TIEMPO
        End Get
        Set(ByVal Value As Decimal)
            _TIPTRA_MEDIO_TIEMPO = Value
            OnPropertyChanged("TIPTRA_MEDIO_TIEMPO")
        End Set
    End Property 

    Private _TIPTRA_MEDIO_TIEMPOOld As Decimal
    Public Property TIPTRA_MEDIO_TIEMPOOld() As Decimal
        Get
            Return _TIPTRA_MEDIO_TIEMPOOld
        End Get
        Set(ByVal Value As Decimal)
            _TIPTRA_MEDIO_TIEMPOOld = Value
        End Set
    End Property 

    Private _TIPTRA_INDEPENDIENTE As Decimal
    <Column(Name:="Tiptra independiente", Storage:="TIPTRA_INDEPENDIENTE", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=1, Scale:=0)> _
    Public Property TIPTRA_INDEPENDIENTE() As Decimal
        Get
            Return _TIPTRA_INDEPENDIENTE
        End Get
        Set(ByVal Value As Decimal)
            _TIPTRA_INDEPENDIENTE = Value
            OnPropertyChanged("TIPTRA_INDEPENDIENTE")
        End Set
    End Property 

    Private _TIPTRA_INDEPENDIENTEOld As Decimal
    Public Property TIPTRA_INDEPENDIENTEOld() As Decimal
        Get
            Return _TIPTRA_INDEPENDIENTEOld
        End Get
        Set(ByVal Value As Decimal)
            _TIPTRA_INDEPENDIENTEOld = Value
        End Set
    End Property 

    Private _RTC_OCUPACION_EMPRESA As Decimal
    <Column(Name:="Rtc ocupacion empresa", Storage:="RTC_OCUPACION_EMPRESA", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=1, Scale:=0)> _
    Public Property RTC_OCUPACION_EMPRESA() As Decimal
        Get
            Return _RTC_OCUPACION_EMPRESA
        End Get
        Set(ByVal Value As Decimal)
            _RTC_OCUPACION_EMPRESA = Value
            OnPropertyChanged("RTC_OCUPACION_EMPRESA")
        End Set
    End Property 

    Private _RTC_OCUPACION_EMPRESAOld As Decimal
    Public Property RTC_OCUPACION_EMPRESAOld() As Decimal
        Get
            Return _RTC_OCUPACION_EMPRESAOld
        End Get
        Set(ByVal Value As Decimal)
            _RTC_OCUPACION_EMPRESAOld = Value
        End Set
    End Property 

    Private _RTC_PROPIA_EMPRESA As Decimal
    <Column(Name:="Rtc propia empresa", Storage:="RTC_PROPIA_EMPRESA", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=1, Scale:=0)> _
    Public Property RTC_PROPIA_EMPRESA() As Decimal
        Get
            Return _RTC_PROPIA_EMPRESA
        End Get
        Set(ByVal Value As Decimal)
            _RTC_PROPIA_EMPRESA = Value
            OnPropertyChanged("RTC_PROPIA_EMPRESA")
        End Set
    End Property 

    Private _RTC_PROPIA_EMPRESAOld As Decimal
    Public Property RTC_PROPIA_EMPRESAOld() As Decimal
        Get
            Return _RTC_PROPIA_EMPRESAOld
        End Get
        Set(ByVal Value As Decimal)
            _RTC_PROPIA_EMPRESAOld = Value
        End Set
    End Property 

    Private _RTC_TRABAJO_EVENTUAL As Decimal
    <Column(Name:="Rtc trabajo eventual", Storage:="RTC_TRABAJO_EVENTUAL", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=1, Scale:=0)> _
    Public Property RTC_TRABAJO_EVENTUAL() As Decimal
        Get
            Return _RTC_TRABAJO_EVENTUAL
        End Get
        Set(ByVal Value As Decimal)
            _RTC_TRABAJO_EVENTUAL = Value
            OnPropertyChanged("RTC_TRABAJO_EVENTUAL")
        End Set
    End Property 

    Private _RTC_TRABAJO_EVENTUALOld As Decimal
    Public Property RTC_TRABAJO_EVENTUALOld() As Decimal
        Get
            Return _RTC_TRABAJO_EVENTUALOld
        End Get
        Set(ByVal Value As Decimal)
            _RTC_TRABAJO_EVENTUALOld = Value
        End Set
    End Property 

    Private _RTC_TRABAJO_MEDIO_TIEMPO As Decimal
    <Column(Name:="Rtc trabajo medio tiempo", Storage:="RTC_TRABAJO_MEDIO_TIEMPO", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=1, Scale:=0)> _
    Public Property RTC_TRABAJO_MEDIO_TIEMPO() As Decimal
        Get
            Return _RTC_TRABAJO_MEDIO_TIEMPO
        End Get
        Set(ByVal Value As Decimal)
            _RTC_TRABAJO_MEDIO_TIEMPO = Value
            OnPropertyChanged("RTC_TRABAJO_MEDIO_TIEMPO")
        End Set
    End Property 

    Private _RTC_TRABAJO_MEDIO_TIEMPOOld As Decimal
    Public Property RTC_TRABAJO_MEDIO_TIEMPOOld() As Decimal
        Get
            Return _RTC_TRABAJO_MEDIO_TIEMPOOld
        End Get
        Set(ByVal Value As Decimal)
            _RTC_TRABAJO_MEDIO_TIEMPOOld = Value
        End Set
    End Property 

    Private _RTC_INDEPENDIENTE As Decimal
    <Column(Name:="Rtc independiente", Storage:="RTC_INDEPENDIENTE", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=1, Scale:=0)> _
    Public Property RTC_INDEPENDIENTE() As Decimal
        Get
            Return _RTC_INDEPENDIENTE
        End Get
        Set(ByVal Value As Decimal)
            _RTC_INDEPENDIENTE = Value
            OnPropertyChanged("RTC_INDEPENDIENTE")
        End Set
    End Property 

    Private _RTC_INDEPENDIENTEOld As Decimal
    Public Property RTC_INDEPENDIENTEOld() As Decimal
        Get
            Return _RTC_INDEPENDIENTEOld
        End Get
        Set(ByVal Value As Decimal)
            _RTC_INDEPENDIENTEOld = Value
        End Set
    End Property 

    Private _RTC_NO_OCUPACION_EMPRESA As Decimal
    <Column(Name:="Rtc no ocupacion empresa", Storage:="RTC_NO_OCUPACION_EMPRESA", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=1, Scale:=0)> _
    Public Property RTC_NO_OCUPACION_EMPRESA() As Decimal
        Get
            Return _RTC_NO_OCUPACION_EMPRESA
        End Get
        Set(ByVal Value As Decimal)
            _RTC_NO_OCUPACION_EMPRESA = Value
            OnPropertyChanged("RTC_NO_OCUPACION_EMPRESA")
        End Set
    End Property 

    Private _RTC_NO_OCUPACION_EMPRESAOld As Decimal
    Public Property RTC_NO_OCUPACION_EMPRESAOld() As Decimal
        Get
            Return _RTC_NO_OCUPACION_EMPRESAOld
        End Get
        Set(ByVal Value As Decimal)
            _RTC_NO_OCUPACION_EMPRESAOld = Value
        End Set
    End Property 

    Private _RTC_NO_PROPIA_EMPRESA As Decimal
    <Column(Name:="Rtc no propia empresa", Storage:="RTC_NO_PROPIA_EMPRESA", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=1, Scale:=0)> _
    Public Property RTC_NO_PROPIA_EMPRESA() As Decimal
        Get
            Return _RTC_NO_PROPIA_EMPRESA
        End Get
        Set(ByVal Value As Decimal)
            _RTC_NO_PROPIA_EMPRESA = Value
            OnPropertyChanged("RTC_NO_PROPIA_EMPRESA")
        End Set
    End Property 

    Private _RTC_NO_PROPIA_EMPRESAOld As Decimal
    Public Property RTC_NO_PROPIA_EMPRESAOld() As Decimal
        Get
            Return _RTC_NO_PROPIA_EMPRESAOld
        End Get
        Set(ByVal Value As Decimal)
            _RTC_NO_PROPIA_EMPRESAOld = Value
        End Set
    End Property 

    Private _RTC_NO_TRABAJO_EVENTUAL As Decimal
    <Column(Name:="Rtc no trabajo eventual", Storage:="RTC_NO_TRABAJO_EVENTUAL", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=1, Scale:=0)> _
    Public Property RTC_NO_TRABAJO_EVENTUAL() As Decimal
        Get
            Return _RTC_NO_TRABAJO_EVENTUAL
        End Get
        Set(ByVal Value As Decimal)
            _RTC_NO_TRABAJO_EVENTUAL = Value
            OnPropertyChanged("RTC_NO_TRABAJO_EVENTUAL")
        End Set
    End Property 

    Private _RTC_NO_TRABAJO_EVENTUALOld As Decimal
    Public Property RTC_NO_TRABAJO_EVENTUALOld() As Decimal
        Get
            Return _RTC_NO_TRABAJO_EVENTUALOld
        End Get
        Set(ByVal Value As Decimal)
            _RTC_NO_TRABAJO_EVENTUALOld = Value
        End Set
    End Property 

    Private _RTC_NO_TRABAJO_MEDIO_TIEMPO As Decimal
    <Column(Name:="Rtc no trabajo medio tiempo", Storage:="RTC_NO_TRABAJO_MEDIO_TIEMPO", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=1, Scale:=0)> _
    Public Property RTC_NO_TRABAJO_MEDIO_TIEMPO() As Decimal
        Get
            Return _RTC_NO_TRABAJO_MEDIO_TIEMPO
        End Get
        Set(ByVal Value As Decimal)
            _RTC_NO_TRABAJO_MEDIO_TIEMPO = Value
            OnPropertyChanged("RTC_NO_TRABAJO_MEDIO_TIEMPO")
        End Set
    End Property 

    Private _RTC_NO_TRABAJO_MEDIO_TIEMPOOld As Decimal
    Public Property RTC_NO_TRABAJO_MEDIO_TIEMPOOld() As Decimal
        Get
            Return _RTC_NO_TRABAJO_MEDIO_TIEMPOOld
        End Get
        Set(ByVal Value As Decimal)
            _RTC_NO_TRABAJO_MEDIO_TIEMPOOld = Value
        End Set
    End Property 

    Private _RTC_NO_INDEPENDIENTE As Decimal
    <Column(Name:="Rtc no independiente", Storage:="RTC_NO_INDEPENDIENTE", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=1, Scale:=0)> _
    Public Property RTC_NO_INDEPENDIENTE() As Decimal
        Get
            Return _RTC_NO_INDEPENDIENTE
        End Get
        Set(ByVal Value As Decimal)
            _RTC_NO_INDEPENDIENTE = Value
            OnPropertyChanged("RTC_NO_INDEPENDIENTE")
        End Set
    End Property 

    Private _RTC_NO_INDEPENDIENTEOld As Decimal
    Public Property RTC_NO_INDEPENDIENTEOld() As Decimal
        Get
            Return _RTC_NO_INDEPENDIENTEOld
        End Get
        Set(ByVal Value As Decimal)
            _RTC_NO_INDEPENDIENTEOld = Value
        End Set
    End Property 

    Private _NIVEL_ACADEMICO As String
    <Column(Name:="Nivel academico", Storage:="NIVEL_ACADEMICO", DbType:="VARCHAR2(5)", Id:=False), _
     DataObjectField(False, False, True, 5)> _
    Public Property NIVEL_ACADEMICO() As String
        Get
            Return _NIVEL_ACADEMICO
        End Get
        Set(ByVal Value As String)
            _NIVEL_ACADEMICO = Value
            OnPropertyChanged("NIVEL_ACADEMICO")
        End Set
    End Property 

    Private _NIVEL_ACADEMICOOld As String
    Public Property NIVEL_ACADEMICOOld() As String
        Get
            Return _NIVEL_ACADEMICOOld
        End Get
        Set(ByVal Value As String)
            _NIVEL_ACADEMICOOld = Value
        End Set
    End Property 

    Private _fkNIVEL_ACADEMICO As NIVEL_ACADEMICO
    Public Property fkNIVEL_ACADEMICO() As NIVEL_ACADEMICO
        Get
            Return _fkNIVEL_ACADEMICO
        End Get
        Set(ByVal Value As NIVEL_ACADEMICO)
            _fkNIVEL_ACADEMICO = Value
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

    Private _TIEMPO_DEJO_ESTUDIAR As String
    <Column(Name:="Tiempo dejo estudiar", Storage:="TIEMPO_DEJO_ESTUDIAR", DbType:="CHAR(1)", Id:=False), _
     DataObjectField(False, False, True, 1)> _
    Public Property TIEMPO_DEJO_ESTUDIAR() As String
        Get
            Return _TIEMPO_DEJO_ESTUDIAR
        End Get
        Set(ByVal Value As String)
            _TIEMPO_DEJO_ESTUDIAR = Value
            OnPropertyChanged("TIEMPO_DEJO_ESTUDIAR")
        End Set
    End Property 

    Private _TIEMPO_DEJO_ESTUDIAROld As String
    Public Property TIEMPO_DEJO_ESTUDIAROld() As String
        Get
            Return _TIEMPO_DEJO_ESTUDIAROld
        End Get
        Set(ByVal Value As String)
            _TIEMPO_DEJO_ESTUDIAROld = Value
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

    Private _OBTUVO_BENEFICIOS_CURSO As String
    <Column(Name:="Obtuvo beneficios curso", Storage:="OBTUVO_BENEFICIOS_CURSO", DbType:="CHAR(1)", Id:=False), _
     DataObjectField(False, False, True, 1)> _
    Public Property OBTUVO_BENEFICIOS_CURSO() As String
        Get
            Return _OBTUVO_BENEFICIOS_CURSO
        End Get
        Set(ByVal Value As String)
            _OBTUVO_BENEFICIOS_CURSO = Value
            OnPropertyChanged("OBTUVO_BENEFICIOS_CURSO")
        End Set
    End Property 

    Private _OBTUVO_BENEFICIOS_CURSOOld As String
    Public Property OBTUVO_BENEFICIOS_CURSOOld() As String
        Get
            Return _OBTUVO_BENEFICIOS_CURSOOld
        End Get
        Set(ByVal Value As String)
            _OBTUVO_BENEFICIOS_CURSOOld = Value
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

    Private _TRABAJA_ACTUALMENTE As String
    <Column(Name:="Trabaja actualmente", Storage:="TRABAJA_ACTUALMENTE", DbType:="CHAR(1)", Id:=False), _
     DataObjectField(False, False, True, 1)> _
    Public Property TRABAJA_ACTUALMENTE() As String
        Get
            Return _TRABAJA_ACTUALMENTE
        End Get
        Set(ByVal Value As String)
            _TRABAJA_ACTUALMENTE = Value
            OnPropertyChanged("TRABAJA_ACTUALMENTE")
        End Set
    End Property 

    Private _TRABAJA_ACTUALMENTEOld As String
    Public Property TRABAJA_ACTUALMENTEOld() As String
        Get
            Return _TRABAJA_ACTUALMENTEOld
        End Get
        Set(ByVal Value As String)
            _TRABAJA_ACTUALMENTEOld = Value
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

    Private _EXPFOR_PROMOCION_EMPLEO As Decimal
    <Column(Name:="Expfor promocion empleo", Storage:="EXPFOR_PROMOCION_EMPLEO", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=1, Scale:=0)> _
    Public Property EXPFOR_PROMOCION_EMPLEO() As Decimal
        Get
            Return _EXPFOR_PROMOCION_EMPLEO
        End Get
        Set(ByVal Value As Decimal)
            _EXPFOR_PROMOCION_EMPLEO = Value
            OnPropertyChanged("EXPFOR_PROMOCION_EMPLEO")
        End Set
    End Property 

    Private _EXPFOR_PROMOCION_EMPLEOOld As Decimal
    Public Property EXPFOR_PROMOCION_EMPLEOOld() As Decimal
        Get
            Return _EXPFOR_PROMOCION_EMPLEOOld
        End Get
        Set(ByVal Value As Decimal)
            _EXPFOR_PROMOCION_EMPLEOOld = Value
        End Set
    End Property 

    Private _EXPFOR_CAMBIAR_EMPLEO As Decimal
    <Column(Name:="Expfor cambiar empleo", Storage:="EXPFOR_CAMBIAR_EMPLEO", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=1, Scale:=0)> _
    Public Property EXPFOR_CAMBIAR_EMPLEO() As Decimal
        Get
            Return _EXPFOR_CAMBIAR_EMPLEO
        End Get
        Set(ByVal Value As Decimal)
            _EXPFOR_CAMBIAR_EMPLEO = Value
            OnPropertyChanged("EXPFOR_CAMBIAR_EMPLEO")
        End Set
    End Property 

    Private _EXPFOR_CAMBIAR_EMPLEOOld As Decimal
    Public Property EXPFOR_CAMBIAR_EMPLEOOld() As Decimal
        Get
            Return _EXPFOR_CAMBIAR_EMPLEOOld
        End Get
        Set(ByVal Value As Decimal)
            _EXPFOR_CAMBIAR_EMPLEOOld = Value
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

    Private _INGRESO_MENSUAL_INDIVIDUAL As String
    <Column(Name:="Ingreso mensual individual", Storage:="INGRESO_MENSUAL_INDIVIDUAL", DbType:="CHAR(1)", Id:=False), _
     DataObjectField(False, False, True, 1)> _
    Public Property INGRESO_MENSUAL_INDIVIDUAL() As String
        Get
            Return _INGRESO_MENSUAL_INDIVIDUAL
        End Get
        Set(ByVal Value As String)
            _INGRESO_MENSUAL_INDIVIDUAL = Value
            OnPropertyChanged("INGRESO_MENSUAL_INDIVIDUAL")
        End Set
    End Property 

    Private _INGRESO_MENSUAL_INDIVIDUALOld As String
    Public Property INGRESO_MENSUAL_INDIVIDUALOld() As String
        Get
            Return _INGRESO_MENSUAL_INDIVIDUALOld
        End Get
        Set(ByVal Value As String)
            _INGRESO_MENSUAL_INDIVIDUALOld = Value
        End Set
    End Property 

    Private _INGRESO_MENSUAL_FAMILIAR As String
    <Column(Name:="Ingreso mensual familiar", Storage:="INGRESO_MENSUAL_FAMILIAR", DbType:="CHAR(1)", Id:=False), _
     DataObjectField(False, False, True, 1)> _
    Public Property INGRESO_MENSUAL_FAMILIAR() As String
        Get
            Return _INGRESO_MENSUAL_FAMILIAR
        End Get
        Set(ByVal Value As String)
            _INGRESO_MENSUAL_FAMILIAR = Value
            OnPropertyChanged("INGRESO_MENSUAL_FAMILIAR")
        End Set
    End Property 

    Private _INGRESO_MENSUAL_FAMILIAROld As String
    Public Property INGRESO_MENSUAL_FAMILIAROld() As String
        Get
            Return _INGRESO_MENSUAL_FAMILIAROld
        End Get
        Set(ByVal Value As String)
            _INGRESO_MENSUAL_FAMILIAROld = Value
        End Set
    End Property 

    Private _MIEMBROS_GRUPO_FAMILIAR As Decimal
    <Column(Name:="Miembros grupo familiar", Storage:="MIEMBROS_GRUPO_FAMILIAR", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=0, Scale:=0)> _
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

    Private _LUGAR_PRESENTACION As String
    <Column(Name:="Lugar presentacion", Storage:="LUGAR_PRESENTACION", DbType:="VARCHAR2(50)", Id:=False), _
     DataObjectField(False, False, True, 50)> _
    Public Property LUGAR_PRESENTACION() As String
        Get
            Return _LUGAR_PRESENTACION
        End Get
        Set(ByVal Value As String)
            _LUGAR_PRESENTACION = Value
            OnPropertyChanged("LUGAR_PRESENTACION")
        End Set
    End Property 

    Private _LUGAR_PRESENTACIONOld As String
    Public Property LUGAR_PRESENTACIONOld() As String
        Get
            Return _LUGAR_PRESENTACIONOld
        End Get
        Set(ByVal Value As String)
            _LUGAR_PRESENTACIONOld = Value
        End Set
    End Property 

    Private _ID_PROVEEDOR_AF As Decimal
    <Column(Name:="Id proveedor af", Storage:="ID_PROVEEDOR_AF", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_PROVEEDOR_AF() As Decimal
        Get
            Return _ID_PROVEEDOR_AF
        End Get
        Set(ByVal Value As Decimal)
            _ID_PROVEEDOR_AF = Value
            OnPropertyChanged("ID_PROVEEDOR_AF")
        End Set
    End Property 

    Private _ID_PROVEEDOR_AFOld As Decimal
    Public Property ID_PROVEEDOR_AFOld() As Decimal
        Get
            Return _ID_PROVEEDOR_AFOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_PROVEEDOR_AFOld = Value
        End Set
    End Property 

    Private _USERID_HIST As String
    <Column(Name:="Userid hist", Storage:="USERID_HIST", DbType:="VARCHAR2(256) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 256)> _
    Public Property USERID_HIST() As String
        Get
            Return _USERID_HIST
        End Get
        Set(ByVal Value As String)
            _USERID_HIST = Value
            OnPropertyChanged("USERID_HIST")
        End Set
    End Property 

    Private _USERID_HISTOld As String
    Public Property USERID_HISTOld() As String
        Get
            Return _USERID_HISTOld
        End Get
        Set(ByVal Value As String)
            _USERID_HISTOld = Value
        End Set
    End Property 

    Private _LASTUPDATE_HIST As DateTime
    <Column(Name:="Lastupdate hist", Storage:="LASTUPDATE_HIST", DbType:="DATE NOT NULL", Id:=False), _
     DataObjectField(False, False, False)> _
    Public Property LASTUPDATE_HIST() As DateTime
        Get
            Return _LASTUPDATE_HIST
        End Get
        Set(ByVal Value As DateTime)
            _LASTUPDATE_HIST = Value
            OnPropertyChanged("LASTUPDATE_HIST")
        End Set
    End Property 

    Private _LASTUPDATE_HISTOld As DateTime
    Public Property LASTUPDATE_HISTOld() As DateTime
        Get
            Return _LASTUPDATE_HISTOld
        End Get
        Set(ByVal Value As DateTime)
            _LASTUPDATE_HISTOld = Value
        End Set
    End Property 

    Private _USERID As String
    <Column(Name:="Userid", Storage:="USERID", DbType:="VARCHAR2(256)", Id:=False), _
     DataObjectField(False, False, True, 256)> _
    Public Property USERID() As String
        Get
            Return _USERID
        End Get
        Set(ByVal Value As String)
            _USERID = Value
            OnPropertyChanged("USERID")
        End Set
    End Property 

    Private _USERIDOld As String
    Public Property USERIDOld() As String
        Get
            Return _USERIDOld
        End Get
        Set(ByVal Value As String)
            _USERIDOld = Value
        End Set
    End Property 

    Private _LASTUPDATE As DateTime
    <Column(Name:="Lastupdate", Storage:="LASTUPDATE", DbType:="DATE", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property LASTUPDATE() As DateTime
        Get
            Return _LASTUPDATE
        End Get
        Set(ByVal Value As DateTime)
            _LASTUPDATE = Value
            OnPropertyChanged("LASTUPDATE")
        End Set
    End Property 

    Private _LASTUPDATEOld As DateTime
    Public Property LASTUPDATEOld() As DateTime
        Get
            Return _LASTUPDATEOld
        End Get
        Set(ByVal Value As DateTime)
            _LASTUPDATEOld = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
