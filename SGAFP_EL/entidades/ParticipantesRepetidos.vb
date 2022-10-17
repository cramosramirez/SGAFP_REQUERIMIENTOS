<Serializable(), Table(Name:="PARTICIPANTES_REPETIDOS")> Public Class PARTICIPANTES_REPETIDOS
    Inherits entidadBase
    Implements IEquatable(Of PARTICIPANTES_REPETIDOS), IComparable(Of PARTICIPANTES_REPETIDOS)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(ByVal aID_PARTICIPANTE As Decimal, ByVal aNOMBRES As String, ByVal aAPELLIDOS As String, ByVal aGENERO As String, ByVal aID_PAIS As Decimal, ByVal aFECHA_NACIMIENTO As DateTime, ByVal aDIRECCION As String, ByVal aDUI As String, ByVal aNIT As String, ByVal aISSS As String, ByVal aTIPO_DOCTO As Decimal, ByVal aNUM_DOCTO As String, ByVal aTELEFONO As String, ByVal aMOVIL As String, ByVal aEMAIL As String, ByVal aID_ESTADO_CIVIL As Decimal, ByVal aPROFESION_OFICIO As String, ByVal aOCUPACION_ACTUAL As String, ByVal aTITULO_CERTIFICADO_OBTENIDO As String, ByVal aDEPARTAMENTO_NAC As String, ByVal aMUNICIPIO_NAC As String, ByVal aCODIGO_DEPARTAMENTO As String, ByVal aCODIGO_MUNICIPIO As String, ByVal aID_NIVEL_ACADEMICO As Decimal, ByVal aOTRA_EDUCACION_FORMAL As String, ByVal aCON_DISCAPACIDAD As Decimal, ByVal aDISC_OTRA As String, ByVal aLASTUPDATE As DateTime, ByVal aUSERID As String)
        Me._ID_PARTICIPANTE = aID_PARTICIPANTE
        Me._NOMBRES = aNOMBRES
        Me._APELLIDOS = aAPELLIDOS
        Me._GENERO = aGENERO
        Me._ID_PAIS = aID_PAIS
        Me._FECHA_NACIMIENTO = aFECHA_NACIMIENTO
        Me._DIRECCION = aDIRECCION
        Me._DUI = aDUI
        Me._NIT = aNIT
        Me._ISSS = aISSS
        Me._TIPO_DOCTO = aTIPO_DOCTO
        Me._NUM_DOCTO = aNUM_DOCTO
        Me._TELEFONO = aTELEFONO
        Me._MOVIL = aMOVIL
        Me._EMAIL = aEMAIL
        Me._ID_ESTADO_CIVIL = aID_ESTADO_CIVIL
        Me._PROFESION_OFICIO = aPROFESION_OFICIO
        Me._OCUPACION_ACTUAL = aOCUPACION_ACTUAL
        Me._TITULO_CERTIFICADO_OBTENIDO = aTITULO_CERTIFICADO_OBTENIDO
        Me._DEPARTAMENTO_NAC = aDEPARTAMENTO_NAC
        Me._MUNICIPIO_NAC = aMUNICIPIO_NAC
        Me._CODIGO_DEPARTAMENTO = aCODIGO_DEPARTAMENTO
        Me._CODIGO_MUNICIPIO = aCODIGO_MUNICIPIO
        Me._ID_NIVEL_ACADEMICO = aID_NIVEL_ACADEMICO
        Me._OTRA_EDUCACION_FORMAL = aOTRA_EDUCACION_FORMAL
        Me._CON_DISCAPACIDAD = aCON_DISCAPACIDAD
        Me._DISC_OTRA = aDISC_OTRA
        Me._LASTUPDATE = aLASTUPDATE
        Me._USERID = aUSERID
    End Sub

    Public Function Equals1(ByVal other As PARTICIPANTES_REPETIDOS) As Boolean Implements System.IEquatable(Of PARTICIPANTES_REPETIDOS).Equals
        Return Me.ID_PARTICIPANTE = other.ID_PARTICIPANTE
    End Function

    Public Function CompareTo(ByVal other As PARTICIPANTES_REPETIDOS) As Integer Implements System.IComparable(Of PARTICIPANTES_REPETIDOS).CompareTo
        If Me.ID_PARTICIPANTE > other.ID_PARTICIPANTE Then Return 1
        If Me.ID_PARTICIPANTE < other.ID_PARTICIPANTE Then Return -1
        Return 0
    End Function


#Region " Propiedades "

    Private _ID_PARTICIPANTE As Decimal
    <Column(Name:="Id participante", Storage:="ID_PARTICIPANTE", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_PARTICIPANTE() As Decimal
        Get
            Return _ID_PARTICIPANTE
        End Get
        Set(ByVal Value As Decimal)
            _ID_PARTICIPANTE = Value
            OnPropertyChanged("ID_PARTICIPANTE")
        End Set
    End Property

    Private _NOMBRES As String
    <Column(Name:="Nombres", Storage:="NOMBRES", DbType:="VARCHAR2(60) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 60)> _
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
    <Column(Name:="Apellidos", Storage:="APELLIDOS", DbType:="VARCHAR2(60) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 60)> _
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

    Private _GENERO As String
    <Column(Name:="Genero", Storage:="GENERO", DbType:="CHAR(1) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 1)> _
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

    Private _OCUPACION_ACTUAL As String
    <Column(Name:="Ocupacion actual", Storage:="OCUPACION_ACTUAL", DbType:="VARCHAR2(60)", Id:=False), _
     DataObjectField(False, False, True, 60)> _
    Public Property OCUPACION_ACTUAL() As String
        Get
            Return _OCUPACION_ACTUAL
        End Get
        Set(ByVal Value As String)
            _OCUPACION_ACTUAL = Value
            OnPropertyChanged("OCUPACION_ACTUAL")
        End Set
    End Property

    Private _OCUPACION_ACTUALOld As String
    Public Property OCUPACION_ACTUALOld() As String
        Get
            Return _OCUPACION_ACTUALOld
        End Get
        Set(ByVal Value As String)
            _OCUPACION_ACTUALOld = Value
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
    Private _ID_PARTICIPANTE_NUEVO As Decimal
    <Column(Name:="Id participante", Storage:="ID_PARTICIPANTE_NUEVO", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_PARTICIPANTE_NUEVO() As Decimal
        Get
            Return _ID_PARTICIPANTE_NUEVO
        End Get
        Set(ByVal Value As Decimal)
            _ID_PARTICIPANTE_NUEVO = Value
            OnPropertyChanged("ID_PARTICIPANTE_NUEVO")
        End Set
    End Property

#End Region

#Region " Relaciones "

#End Region
#End Region
End Class