''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.EMPRESAS
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite tener un registro de la tabla EMPRESAS en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="EMPRESAS")> Public Class EMPRESAS
    Inherits entidadBase
    Implements IEquatable(Of EMPRESAS), IComparable(Of EMPRESAS)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aNUMERO_PATRONAL As String, aNIT_EMPRESA As String, aCIUU As String, aSECTOR_PRODUCTIVO As String, aCODIGO_ASESOR As String, aCODIGO_MUNICIPIO As String, aCODIGO_DEPARTAMENTO As String, aCODIGO_REGION As String, aNOMBRE_EMPRESA As String, aTIPO_EMPRESA As String, aCONTACTO_EMPRESA As String, aTELEFONO_CONTACTO As String, aCARGO_CONTACTO As String, aDIRECCION_EMPRESA As String, aTELEFONO_EMPRESA As String, aFAX_EMPRESA As String, aEMAIL_EMPRESA As String, aESPECIALIDAD_EMPRESA As String, aTOTAL_PERSONA As Decimal, aTOTAL_PLANILLA As Decimal, aREPRESENTANTE_LEGAL As String, aFECHA_REGISTRO As DateTime, aTOTAL_TRABAJADORES As Decimal, aFEMENINOS As Decimal, aMASCULINOS As Decimal, aTAMANO_EMPRESA As String, aCON_MANDO As Decimal, aSIN_MANDO As Decimal, aADMINISTRATIVOS As Decimal, aMANDOS_MEDIOS As Decimal, aOPERATIVOS As Decimal, aGERENCIAL As Decimal, aSIGLAS As String, aUSERID As String, aLASTUPDATE As DateTime, aOBSERVACION As String, aNUM_PAT_ISSS As String, aTIPOPERSON As String, aNUM As Decimal, aREPRESENTANTE_PROFESION As String, aCONTACTO_EMAIL As String, aAPORTE_INSAFORP As Decimal, aZONA As Decimal)
        Me._NUMERO_PATRONAL = aNUMERO_PATRONAL
        Me._NIT_EMPRESA = aNIT_EMPRESA
        Me._CIUU = aCIUU
        Me._SECTOR_PRODUCTIVO = aSECTOR_PRODUCTIVO
        Me._CODIGO_ASESOR = aCODIGO_ASESOR
        Me._CODIGO_MUNICIPIO = aCODIGO_MUNICIPIO
        Me._CODIGO_DEPARTAMENTO = aCODIGO_DEPARTAMENTO
        Me._CODIGO_REGION = aCODIGO_REGION
        Me._NOMBRE_EMPRESA = aNOMBRE_EMPRESA
        Me._TIPO_EMPRESA = aTIPO_EMPRESA
        Me._CONTACTO_EMPRESA = aCONTACTO_EMPRESA
        Me._TELEFONO_CONTACTO = aTELEFONO_CONTACTO
        Me._CARGO_CONTACTO = aCARGO_CONTACTO
        Me._DIRECCION_EMPRESA = aDIRECCION_EMPRESA
        Me._TELEFONO_EMPRESA = aTELEFONO_EMPRESA
        Me._FAX_EMPRESA = aFAX_EMPRESA
        Me._EMAIL_EMPRESA = aEMAIL_EMPRESA
        Me._ESPECIALIDAD_EMPRESA = aESPECIALIDAD_EMPRESA
        Me._TOTAL_PERSONA = aTOTAL_PERSONA
        Me._TOTAL_PLANILLA = aTOTAL_PLANILLA
        Me._REPRESENTANTE_LEGAL = aREPRESENTANTE_LEGAL
        Me._FECHA_REGISTRO = aFECHA_REGISTRO
        Me._TOTAL_TRABAJADORES = aTOTAL_TRABAJADORES
        Me._FEMENINOS = aFEMENINOS
        Me._MASCULINOS = aMASCULINOS
        Me._TAMANO_EMPRESA = aTAMANO_EMPRESA
        Me._CON_MANDO = aCON_MANDO
        Me._SIN_MANDO = aSIN_MANDO
        Me._ADMINISTRATIVOS = aADMINISTRATIVOS
        Me._MANDOS_MEDIOS = aMANDOS_MEDIOS
        Me._OPERATIVOS = aOPERATIVOS
        Me._GERENCIAL = aGERENCIAL
        Me._SIGLAS = aSIGLAS
        Me._USERID = aUSERID
        Me._LASTUPDATE = aLASTUPDATE
        Me._OBSERVACION = aOBSERVACION
        Me._NUM_PAT_ISSS = aNUM_PAT_ISSS
        Me._TIPOPERSON = aTIPOPERSON
        Me._NUM = aNUM
        Me._REPRESENTANTE_PROFESION = aREPRESENTANTE_PROFESION
        Me._CONTACTO_EMAIL = aCONTACTO_EMAIL
        Me._APORTE_INSAFORP = aAPORTE_INSAFORP
        Me._ZONA = aZONA
    End Sub

    Public Function Equals1(ByVal other As EMPRESAS) As Boolean Implements System.IEquatable(Of EMPRESAS).Equals
        Return Me.NUMERO_PATRONAL = other.NUMERO_PATRONAL
    End Function

    Public Function CompareTo(ByVal other As EMPRESAS) As Integer Implements System.IComparable(Of EMPRESAS).CompareTo
        If Me.NUMERO_PATRONAL > other.NUMERO_PATRONAL Then Return 1
        If Me.NUMERO_PATRONAL < other.NUMERO_PATRONAL Then Return -1
        Return 0
    End Function


#Region " Propiedades "

    Private _NUMERO_PATRONAL As String
    <Column(Name:="Numero patronal", Storage:="NUMERO_PATRONAL", DbType:="CHAR(9) NOT NULL", Id:=True), _
     DataObjectField(True, False, False, 9)> _
    Public Property NUMERO_PATRONAL() As String
        Get
            Return _NUMERO_PATRONAL
        End Get
        Set(ByVal Value As String)
            _NUMERO_PATRONAL = Value
            OnPropertyChanged("NUMERO_PATRONAL")
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

    Private _CIUU As String
    <Column(Name:="Ciuu", Storage:="CIUU", DbType:="VARCHAR2(14)", Id:=False), _
     DataObjectField(False, False, True, 14)> _
    Public Property CIUU() As String
        Get
            Return _CIUU
        End Get
        Set(ByVal Value As String)
            _CIUU = Value
            OnPropertyChanged("CIUU")
        End Set
    End Property 

    Private _CIUUOld As String
    Public Property CIUUOld() As String
        Get
            Return _CIUUOld
        End Get
        Set(ByVal Value As String)
            _CIUUOld = Value
        End Set
    End Property 

    Private _SECTOR_PRODUCTIVO As String
    <Column(Name:="Sector productivo", Storage:="SECTOR_PRODUCTIVO", DbType:="CHAR(3)", Id:=False), _
     DataObjectField(False, False, True, 3)> _
    Public Property SECTOR_PRODUCTIVO() As String
        Get
            Return _SECTOR_PRODUCTIVO
        End Get
        Set(ByVal Value As String)
            _SECTOR_PRODUCTIVO = Value
            OnPropertyChanged("SECTOR_PRODUCTIVO")
        End Set
    End Property 

    Private _SECTOR_PRODUCTIVOOld As String
    Public Property SECTOR_PRODUCTIVOOld() As String
        Get
            Return _SECTOR_PRODUCTIVOOld
        End Get
        Set(ByVal Value As String)
            _SECTOR_PRODUCTIVOOld = Value
        End Set
    End Property 

    Private _CODIGO_ASESOR As String
    <Column(Name:="Codigo asesor", Storage:="CODIGO_ASESOR", DbType:="CHAR(5)", Id:=False), _
     DataObjectField(False, False, True, 5)> _
    Public Property CODIGO_ASESOR() As String
        Get
            Return _CODIGO_ASESOR
        End Get
        Set(ByVal Value As String)
            _CODIGO_ASESOR = Value
            OnPropertyChanged("CODIGO_ASESOR")
        End Set
    End Property 

    Private _CODIGO_ASESOROld As String
    Public Property CODIGO_ASESOROld() As String
        Get
            Return _CODIGO_ASESOROld
        End Get
        Set(ByVal Value As String)
            _CODIGO_ASESOROld = Value
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

    Private _TIPO_EMPRESA As String
    <Column(Name:="Tipo empresa", Storage:="TIPO_EMPRESA", DbType:="VARCHAR2(1)", Id:=False), _
     DataObjectField(False, False, True, 1)> _
    Public Property TIPO_EMPRESA() As String
        Get
            Return _TIPO_EMPRESA
        End Get
        Set(ByVal Value As String)
            _TIPO_EMPRESA = Value
            OnPropertyChanged("TIPO_EMPRESA")
        End Set
    End Property 

    Private _TIPO_EMPRESAOld As String
    Public Property TIPO_EMPRESAOld() As String
        Get
            Return _TIPO_EMPRESAOld
        End Get
        Set(ByVal Value As String)
            _TIPO_EMPRESAOld = Value
        End Set
    End Property 

    Private _CONTACTO_EMPRESA As String
    <Column(Name:="Contacto empresa", Storage:="CONTACTO_EMPRESA", DbType:="VARCHAR2(250)", Id:=False), _
     DataObjectField(False, False, True, 250)> _
    Public Property CONTACTO_EMPRESA() As String
        Get
            Return _CONTACTO_EMPRESA
        End Get
        Set(ByVal Value As String)
            _CONTACTO_EMPRESA = Value
            OnPropertyChanged("CONTACTO_EMPRESA")
        End Set
    End Property 

    Private _CONTACTO_EMPRESAOld As String
    Public Property CONTACTO_EMPRESAOld() As String
        Get
            Return _CONTACTO_EMPRESAOld
        End Get
        Set(ByVal Value As String)
            _CONTACTO_EMPRESAOld = Value
        End Set
    End Property 

    Private _TELEFONO_CONTACTO As String
    <Column(Name:="Telefono contacto", Storage:="TELEFONO_CONTACTO", DbType:="VARCHAR2(10)", Id:=False), _
     DataObjectField(False, False, True, 10)> _
    Public Property TELEFONO_CONTACTO() As String
        Get
            Return _TELEFONO_CONTACTO
        End Get
        Set(ByVal Value As String)
            _TELEFONO_CONTACTO = Value
            OnPropertyChanged("TELEFONO_CONTACTO")
        End Set
    End Property 

    Private _TELEFONO_CONTACTOOld As String
    Public Property TELEFONO_CONTACTOOld() As String
        Get
            Return _TELEFONO_CONTACTOOld
        End Get
        Set(ByVal Value As String)
            _TELEFONO_CONTACTOOld = Value
        End Set
    End Property 

    Private _CARGO_CONTACTO As String
    <Column(Name:="Cargo contacto", Storage:="CARGO_CONTACTO", DbType:="VARCHAR2(250)", Id:=False), _
     DataObjectField(False, False, True, 250)> _
    Public Property CARGO_CONTACTO() As String
        Get
            Return _CARGO_CONTACTO
        End Get
        Set(ByVal Value As String)
            _CARGO_CONTACTO = Value
            OnPropertyChanged("CARGO_CONTACTO")
        End Set
    End Property 

    Private _CARGO_CONTACTOOld As String
    Public Property CARGO_CONTACTOOld() As String
        Get
            Return _CARGO_CONTACTOOld
        End Get
        Set(ByVal Value As String)
            _CARGO_CONTACTOOld = Value
        End Set
    End Property 

    Private _DIRECCION_EMPRESA As String
    <Column(Name:="Direccion empresa", Storage:="DIRECCION_EMPRESA", DbType:="VARCHAR2(1)", Id:=False), _
     DataObjectField(False, False, True, 1)> _
    Public Property DIRECCION_EMPRESA() As String
        Get
            Return _DIRECCION_EMPRESA
        End Get
        Set(ByVal Value As String)
            _DIRECCION_EMPRESA = Value
            OnPropertyChanged("DIRECCION_EMPRESA")
        End Set
    End Property 

    Private _DIRECCION_EMPRESAOld As String
    Public Property DIRECCION_EMPRESAOld() As String
        Get
            Return _DIRECCION_EMPRESAOld
        End Get
        Set(ByVal Value As String)
            _DIRECCION_EMPRESAOld = Value
        End Set
    End Property 

    Private _TELEFONO_EMPRESA As String
    <Column(Name:="Telefono empresa", Storage:="TELEFONO_EMPRESA", DbType:="VARCHAR2(10)", Id:=False), _
     DataObjectField(False, False, True, 10)> _
    Public Property TELEFONO_EMPRESA() As String
        Get
            Return _TELEFONO_EMPRESA
        End Get
        Set(ByVal Value As String)
            _TELEFONO_EMPRESA = Value
            OnPropertyChanged("TELEFONO_EMPRESA")
        End Set
    End Property 

    Private _TELEFONO_EMPRESAOld As String
    Public Property TELEFONO_EMPRESAOld() As String
        Get
            Return _TELEFONO_EMPRESAOld
        End Get
        Set(ByVal Value As String)
            _TELEFONO_EMPRESAOld = Value
        End Set
    End Property 

    Private _FAX_EMPRESA As String
    <Column(Name:="Fax empresa", Storage:="FAX_EMPRESA", DbType:="VARCHAR2(10)", Id:=False), _
     DataObjectField(False, False, True, 10)> _
    Public Property FAX_EMPRESA() As String
        Get
            Return _FAX_EMPRESA
        End Get
        Set(ByVal Value As String)
            _FAX_EMPRESA = Value
            OnPropertyChanged("FAX_EMPRESA")
        End Set
    End Property 

    Private _FAX_EMPRESAOld As String
    Public Property FAX_EMPRESAOld() As String
        Get
            Return _FAX_EMPRESAOld
        End Get
        Set(ByVal Value As String)
            _FAX_EMPRESAOld = Value
        End Set
    End Property 

    Private _EMAIL_EMPRESA As String
    <Column(Name:="Email empresa", Storage:="EMAIL_EMPRESA", DbType:="VARCHAR2(250)", Id:=False), _
     DataObjectField(False, False, True, 250)> _
    Public Property EMAIL_EMPRESA() As String
        Get
            Return _EMAIL_EMPRESA
        End Get
        Set(ByVal Value As String)
            _EMAIL_EMPRESA = Value
            OnPropertyChanged("EMAIL_EMPRESA")
        End Set
    End Property 

    Private _EMAIL_EMPRESAOld As String
    Public Property EMAIL_EMPRESAOld() As String
        Get
            Return _EMAIL_EMPRESAOld
        End Get
        Set(ByVal Value As String)
            _EMAIL_EMPRESAOld = Value
        End Set
    End Property 

    Private _ESPECIALIDAD_EMPRESA As String
    <Column(Name:="Especialidad empresa", Storage:="ESPECIALIDAD_EMPRESA", DbType:="VARCHAR2(100)", Id:=False), _
     DataObjectField(False, False, True, 100)> _
    Public Property ESPECIALIDAD_EMPRESA() As String
        Get
            Return _ESPECIALIDAD_EMPRESA
        End Get
        Set(ByVal Value As String)
            _ESPECIALIDAD_EMPRESA = Value
            OnPropertyChanged("ESPECIALIDAD_EMPRESA")
        End Set
    End Property 

    Private _ESPECIALIDAD_EMPRESAOld As String
    Public Property ESPECIALIDAD_EMPRESAOld() As String
        Get
            Return _ESPECIALIDAD_EMPRESAOld
        End Get
        Set(ByVal Value As String)
            _ESPECIALIDAD_EMPRESAOld = Value
        End Set
    End Property 

    Private _TOTAL_PERSONA As Decimal
    <Column(Name:="Total persona", Storage:="TOTAL_PERSONA", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=5, Scale:=0)> _
    Public Property TOTAL_PERSONA() As Decimal
        Get
            Return _TOTAL_PERSONA
        End Get
        Set(ByVal Value As Decimal)
            _TOTAL_PERSONA = Value
            OnPropertyChanged("TOTAL_PERSONA")
        End Set
    End Property 

    Private _TOTAL_PERSONAOld As Decimal
    Public Property TOTAL_PERSONAOld() As Decimal
        Get
            Return _TOTAL_PERSONAOld
        End Get
        Set(ByVal Value As Decimal)
            _TOTAL_PERSONAOld = Value
        End Set
    End Property 

    Private _TOTAL_PLANILLA As Decimal
    <Column(Name:="Total planilla", Storage:="TOTAL_PLANILLA", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=2)> _
    Public Property TOTAL_PLANILLA() As Decimal
        Get
            Return _TOTAL_PLANILLA
        End Get
        Set(ByVal Value As Decimal)
            _TOTAL_PLANILLA = Value
            OnPropertyChanged("TOTAL_PLANILLA")
        End Set
    End Property 

    Private _TOTAL_PLANILLAOld As Decimal
    Public Property TOTAL_PLANILLAOld() As Decimal
        Get
            Return _TOTAL_PLANILLAOld
        End Get
        Set(ByVal Value As Decimal)
            _TOTAL_PLANILLAOld = Value
        End Set
    End Property 

    Private _REPRESENTANTE_LEGAL As String
    <Column(Name:="Representante legal", Storage:="REPRESENTANTE_LEGAL", DbType:="VARCHAR2(60)", Id:=False), _
     DataObjectField(False, False, True, 60)> _
    Public Property REPRESENTANTE_LEGAL() As String
        Get
            Return _REPRESENTANTE_LEGAL
        End Get
        Set(ByVal Value As String)
            _REPRESENTANTE_LEGAL = Value
            OnPropertyChanged("REPRESENTANTE_LEGAL")
        End Set
    End Property 

    Private _REPRESENTANTE_LEGALOld As String
    Public Property REPRESENTANTE_LEGALOld() As String
        Get
            Return _REPRESENTANTE_LEGALOld
        End Get
        Set(ByVal Value As String)
            _REPRESENTANTE_LEGALOld = Value
        End Set
    End Property 

    Private _FECHA_REGISTRO As DateTime
    <Column(Name:="Fecha registro", Storage:="FECHA_REGISTRO", DbType:="DATE", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property FECHA_REGISTRO() As DateTime
        Get
            Return _FECHA_REGISTRO
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_REGISTRO = Value
            OnPropertyChanged("FECHA_REGISTRO")
        End Set
    End Property 

    Private _FECHA_REGISTROOld As DateTime
    Public Property FECHA_REGISTROOld() As DateTime
        Get
            Return _FECHA_REGISTROOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_REGISTROOld = Value
        End Set
    End Property 

    Private _TOTAL_TRABAJADORES As Decimal
    <Column(Name:="Total trabajadores", Storage:="TOTAL_TRABAJADORES", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=0, Scale:=0)> _
    Public Property TOTAL_TRABAJADORES() As Decimal
        Get
            Return _TOTAL_TRABAJADORES
        End Get
        Set(ByVal Value As Decimal)
            _TOTAL_TRABAJADORES = Value
            OnPropertyChanged("TOTAL_TRABAJADORES")
        End Set
    End Property 

    Private _TOTAL_TRABAJADORESOld As Decimal
    Public Property TOTAL_TRABAJADORESOld() As Decimal
        Get
            Return _TOTAL_TRABAJADORESOld
        End Get
        Set(ByVal Value As Decimal)
            _TOTAL_TRABAJADORESOld = Value
        End Set
    End Property 

    Private _FEMENINOS As Decimal
    <Column(Name:="Femeninos", Storage:="FEMENINOS", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=0, Scale:=0)> _
    Public Property FEMENINOS() As Decimal
        Get
            Return _FEMENINOS
        End Get
        Set(ByVal Value As Decimal)
            _FEMENINOS = Value
            OnPropertyChanged("FEMENINOS")
        End Set
    End Property 

    Private _FEMENINOSOld As Decimal
    Public Property FEMENINOSOld() As Decimal
        Get
            Return _FEMENINOSOld
        End Get
        Set(ByVal Value As Decimal)
            _FEMENINOSOld = Value
        End Set
    End Property 

    Private _MASCULINOS As Decimal
    <Column(Name:="Masculinos", Storage:="MASCULINOS", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=0, Scale:=0)> _
    Public Property MASCULINOS() As Decimal
        Get
            Return _MASCULINOS
        End Get
        Set(ByVal Value As Decimal)
            _MASCULINOS = Value
            OnPropertyChanged("MASCULINOS")
        End Set
    End Property 

    Private _MASCULINOSOld As Decimal
    Public Property MASCULINOSOld() As Decimal
        Get
            Return _MASCULINOSOld
        End Get
        Set(ByVal Value As Decimal)
            _MASCULINOSOld = Value
        End Set
    End Property 

    Private _TAMANO_EMPRESA As String
    <Column(Name:="Tamano empresa", Storage:="TAMANO_EMPRESA", DbType:="CHAR(1)", Id:=False), _
     DataObjectField(False, False, True, 1)> _
    Public Property TAMANO_EMPRESA() As String
        Get
            Return _TAMANO_EMPRESA
        End Get
        Set(ByVal Value As String)
            _TAMANO_EMPRESA = Value
            OnPropertyChanged("TAMANO_EMPRESA")
        End Set
    End Property 

    Private _TAMANO_EMPRESAOld As String
    Public Property TAMANO_EMPRESAOld() As String
        Get
            Return _TAMANO_EMPRESAOld
        End Get
        Set(ByVal Value As String)
            _TAMANO_EMPRESAOld = Value
        End Set
    End Property 

    Private _CON_MANDO As Decimal
    <Column(Name:="Con mando", Storage:="CON_MANDO", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=0, Scale:=0)> _
    Public Property CON_MANDO() As Decimal
        Get
            Return _CON_MANDO
        End Get
        Set(ByVal Value As Decimal)
            _CON_MANDO = Value
            OnPropertyChanged("CON_MANDO")
        End Set
    End Property 

    Private _CON_MANDOOld As Decimal
    Public Property CON_MANDOOld() As Decimal
        Get
            Return _CON_MANDOOld
        End Get
        Set(ByVal Value As Decimal)
            _CON_MANDOOld = Value
        End Set
    End Property 

    Private _SIN_MANDO As Decimal
    <Column(Name:="Sin mando", Storage:="SIN_MANDO", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=0, Scale:=0)> _
    Public Property SIN_MANDO() As Decimal
        Get
            Return _SIN_MANDO
        End Get
        Set(ByVal Value As Decimal)
            _SIN_MANDO = Value
            OnPropertyChanged("SIN_MANDO")
        End Set
    End Property 

    Private _SIN_MANDOOld As Decimal
    Public Property SIN_MANDOOld() As Decimal
        Get
            Return _SIN_MANDOOld
        End Get
        Set(ByVal Value As Decimal)
            _SIN_MANDOOld = Value
        End Set
    End Property 

    Private _ADMINISTRATIVOS As Decimal
    <Column(Name:="Administrativos", Storage:="ADMINISTRATIVOS", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=0, Scale:=0)> _
    Public Property ADMINISTRATIVOS() As Decimal
        Get
            Return _ADMINISTRATIVOS
        End Get
        Set(ByVal Value As Decimal)
            _ADMINISTRATIVOS = Value
            OnPropertyChanged("ADMINISTRATIVOS")
        End Set
    End Property 

    Private _ADMINISTRATIVOSOld As Decimal
    Public Property ADMINISTRATIVOSOld() As Decimal
        Get
            Return _ADMINISTRATIVOSOld
        End Get
        Set(ByVal Value As Decimal)
            _ADMINISTRATIVOSOld = Value
        End Set
    End Property 

    Private _MANDOS_MEDIOS As Decimal
    <Column(Name:="Mandos medios", Storage:="MANDOS_MEDIOS", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=0, Scale:=0)> _
    Public Property MANDOS_MEDIOS() As Decimal
        Get
            Return _MANDOS_MEDIOS
        End Get
        Set(ByVal Value As Decimal)
            _MANDOS_MEDIOS = Value
            OnPropertyChanged("MANDOS_MEDIOS")
        End Set
    End Property 

    Private _MANDOS_MEDIOSOld As Decimal
    Public Property MANDOS_MEDIOSOld() As Decimal
        Get
            Return _MANDOS_MEDIOSOld
        End Get
        Set(ByVal Value As Decimal)
            _MANDOS_MEDIOSOld = Value
        End Set
    End Property 

    Private _OPERATIVOS As Decimal
    <Column(Name:="Operativos", Storage:="OPERATIVOS", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=0, Scale:=0)> _
    Public Property OPERATIVOS() As Decimal
        Get
            Return _OPERATIVOS
        End Get
        Set(ByVal Value As Decimal)
            _OPERATIVOS = Value
            OnPropertyChanged("OPERATIVOS")
        End Set
    End Property 

    Private _OPERATIVOSOld As Decimal
    Public Property OPERATIVOSOld() As Decimal
        Get
            Return _OPERATIVOSOld
        End Get
        Set(ByVal Value As Decimal)
            _OPERATIVOSOld = Value
        End Set
    End Property 

    Private _GERENCIAL As Decimal
    <Column(Name:="Gerencial", Storage:="GERENCIAL", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=0, Scale:=0)> _
    Public Property GERENCIAL() As Decimal
        Get
            Return _GERENCIAL
        End Get
        Set(ByVal Value As Decimal)
            _GERENCIAL = Value
            OnPropertyChanged("GERENCIAL")
        End Set
    End Property 

    Private _GERENCIALOld As Decimal
    Public Property GERENCIALOld() As Decimal
        Get
            Return _GERENCIALOld
        End Get
        Set(ByVal Value As Decimal)
            _GERENCIALOld = Value
        End Set
    End Property 

    Private _SIGLAS As String
    <Column(Name:="Siglas", Storage:="SIGLAS", DbType:="VARCHAR2(25)", Id:=False), _
     DataObjectField(False, False, True, 25)> _
    Public Property SIGLAS() As String
        Get
            Return _SIGLAS
        End Get
        Set(ByVal Value As String)
            _SIGLAS = Value
            OnPropertyChanged("SIGLAS")
        End Set
    End Property 

    Private _SIGLASOld As String
    Public Property SIGLASOld() As String
        Get
            Return _SIGLASOld
        End Get
        Set(ByVal Value As String)
            _SIGLASOld = Value
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

    Private _OBSERVACION As String
    <Column(Name:="Observacion", Storage:="OBSERVACION", DbType:="VARCHAR2(1)", Id:=False), _
     DataObjectField(False, False, True, 1)> _
    Public Property OBSERVACION() As String
        Get
            Return _OBSERVACION
        End Get
        Set(ByVal Value As String)
            _OBSERVACION = Value
            OnPropertyChanged("OBSERVACION")
        End Set
    End Property 

    Private _OBSERVACIONOld As String
    Public Property OBSERVACIONOld() As String
        Get
            Return _OBSERVACIONOld
        End Get
        Set(ByVal Value As String)
            _OBSERVACIONOld = Value
        End Set
    End Property 

    Private _NUM_PAT_ISSS As String
    <Column(Name:="Num pat isss", Storage:="NUM_PAT_ISSS", DbType:="CHAR(9)", Id:=False), _
     DataObjectField(False, False, True, 9)> _
    Public Property NUM_PAT_ISSS() As String
        Get
            Return _NUM_PAT_ISSS
        End Get
        Set(ByVal Value As String)
            _NUM_PAT_ISSS = Value
            OnPropertyChanged("NUM_PAT_ISSS")
        End Set
    End Property 

    Private _NUM_PAT_ISSSOld As String
    Public Property NUM_PAT_ISSSOld() As String
        Get
            Return _NUM_PAT_ISSSOld
        End Get
        Set(ByVal Value As String)
            _NUM_PAT_ISSSOld = Value
        End Set
    End Property 

    Private _TIPOPERSON As String
    <Column(Name:="Tipoperson", Storage:="TIPOPERSON", DbType:="CHAR(2)", Id:=False), _
     DataObjectField(False, False, True, 2)> _
    Public Property TIPOPERSON() As String
        Get
            Return _TIPOPERSON
        End Get
        Set(ByVal Value As String)
            _TIPOPERSON = Value
            OnPropertyChanged("TIPOPERSON")
        End Set
    End Property 

    Private _TIPOPERSONOld As String
    Public Property TIPOPERSONOld() As String
        Get
            Return _TIPOPERSONOld
        End Get
        Set(ByVal Value As String)
            _TIPOPERSONOld = Value
        End Set
    End Property 

    Private _NUM As Decimal
    <Column(Name:="Num", Storage:="NUM", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=0, Scale:=0)> _
    Public Property NUM() As Decimal
        Get
            Return _NUM
        End Get
        Set(ByVal Value As Decimal)
            _NUM = Value
            OnPropertyChanged("NUM")
        End Set
    End Property 

    Private _NUMOld As Decimal
    Public Property NUMOld() As Decimal
        Get
            Return _NUMOld
        End Get
        Set(ByVal Value As Decimal)
            _NUMOld = Value
        End Set
    End Property 

    Private _REPRESENTANTE_PROFESION As String
    <Column(Name:="Representante profesion", Storage:="REPRESENTANTE_PROFESION", DbType:="VARCHAR2(255)", Id:=False), _
     DataObjectField(False, False, True, 255)> _
    Public Property REPRESENTANTE_PROFESION() As String
        Get
            Return _REPRESENTANTE_PROFESION
        End Get
        Set(ByVal Value As String)
            _REPRESENTANTE_PROFESION = Value
            OnPropertyChanged("REPRESENTANTE_PROFESION")
        End Set
    End Property 

    Private _REPRESENTANTE_PROFESIONOld As String
    Public Property REPRESENTANTE_PROFESIONOld() As String
        Get
            Return _REPRESENTANTE_PROFESIONOld
        End Get
        Set(ByVal Value As String)
            _REPRESENTANTE_PROFESIONOld = Value
        End Set
    End Property 

    Private _CONTACTO_EMAIL As String
    <Column(Name:="Contacto email", Storage:="CONTACTO_EMAIL", DbType:="VARCHAR2(255)", Id:=False), _
     DataObjectField(False, False, True, 255)> _
    Public Property CONTACTO_EMAIL() As String
        Get
            Return _CONTACTO_EMAIL
        End Get
        Set(ByVal Value As String)
            _CONTACTO_EMAIL = Value
            OnPropertyChanged("CONTACTO_EMAIL")
        End Set
    End Property 

    Private _CONTACTO_EMAILOld As String
    Public Property CONTACTO_EMAILOld() As String
        Get
            Return _CONTACTO_EMAILOld
        End Get
        Set(ByVal Value As String)
            _CONTACTO_EMAILOld = Value
        End Set
    End Property 

    Private _APORTE_INSAFORP As Decimal
    <Column(Name:="Aporte insaforp", Storage:="APORTE_INSAFORP", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=14, Scale:=2)> _
    Public Property APORTE_INSAFORP() As Decimal
        Get
            Return _APORTE_INSAFORP
        End Get
        Set(ByVal Value As Decimal)
            _APORTE_INSAFORP = Value
            OnPropertyChanged("APORTE_INSAFORP")
        End Set
    End Property 

    Private _APORTE_INSAFORPOld As Decimal
    Public Property APORTE_INSAFORPOld() As Decimal
        Get
            Return _APORTE_INSAFORPOld
        End Get
        Set(ByVal Value As Decimal)
            _APORTE_INSAFORPOld = Value
        End Set
    End Property 

    Private _ZONA As Decimal
    <Column(Name:="Zona", Storage:="ZONA", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=0, Scale:=0)> _
    Public Property ZONA() As Decimal
        Get
            Return _ZONA
        End Get
        Set(ByVal Value As Decimal)
            _ZONA = Value
            OnPropertyChanged("ZONA")
        End Set
    End Property 

    Private _ZONAOld As Decimal
    Public Property ZONAOld() As Decimal
        Get
            Return _ZONAOld
        End Get
        Set(ByVal Value As Decimal)
            _ZONAOld = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
