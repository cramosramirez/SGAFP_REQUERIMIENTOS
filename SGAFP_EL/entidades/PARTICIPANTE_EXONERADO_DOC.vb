''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.PARTICIPANTE_EXONERADO_DOC
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row PARTICIPANTE_EXONERADO_DOC en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	19/11/2012	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="PARTICIPANTE_EXONERADO_DOC")> Public Class PARTICIPANTE_EXONERADO_DOC
    Inherits entidadBase
    Implements IEquatable(Of PARTICIPANTE_EXONERADO_DOC), IComparable(Of PARTICIPANTE_EXONERADO_DOC)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(ByVal aID_PARTICIPANTE As Decimal, ByVal aUSERID As String, ByVal aLASTUPDATE As DateTime, ByVal aID_PROVEEDOR_AF As Decimal, ByVal aID_SITIO_CAPACITACION As Decimal, ByVal aNOMBRES As String, ByVal aAPELLIDOS As String, ByVal aFECHA_NACIMIENTO As DateTime, ByVal aGENERO As String, ByVal aCODIGO_DEPARTAMENTO As String, ByVal aCODIGO_MUNICIPIO As String, ByVal aDEPARTAMENTO_NAC As String, ByVal aMUNICIPIO_NAC As String, ByVal aDIRECCION As String, ByVal aTELEFONO As String, ByVal aMOVIL As String, ByVal aCON_DISCAPACIDAD As Decimal, ByVal aEMAIL As String, ByVal aID_NIVEL_ACADEMICO As Decimal, ByVal aID_PAIS As Decimal, ByVal aID_ESTADO_CIVIL As Decimal, ByVal aFECHA_INGRESO As DateTime, ByVal aUSUARIO_EVALUA As String, ByVal aFECHA_EVALUA As DateTime, ByVal aESTADO As Decimal, ByVal aID_PARTICIPANTE_EXONERADO As Decimal)
        Me._ID_PARTICIPANTE = aID_PARTICIPANTE
        Me._USERID = aUSERID
        Me._LASTUPDATE = aLASTUPDATE
        Me._ID_PROVEEDOR_AF = aID_PROVEEDOR_AF
        Me._ID_SITIO_CAPACITACION = aID_SITIO_CAPACITACION
        Me._NOMBRES = aNOMBRES
        Me._APELLIDOS = aAPELLIDOS
        Me._FECHA_NACIMIENTO = aFECHA_NACIMIENTO
        Me._GENERO = aGENERO
        Me._CODIGO_DEPARTAMENTO = aCODIGO_DEPARTAMENTO
        Me._CODIGO_MUNICIPIO = aCODIGO_MUNICIPIO
        Me._DEPARTAMENTO_NAC = aDEPARTAMENTO_NAC
        Me._MUNICIPIO_NAC = aMUNICIPIO_NAC
        Me._DIRECCION = aDIRECCION
        Me._TELEFONO = aTELEFONO
        Me._MOVIL = aMOVIL
        Me._CON_DISCAPACIDAD = aCON_DISCAPACIDAD
        Me._EMAIL = aEMAIL
        Me._ID_NIVEL_ACADEMICO = aID_NIVEL_ACADEMICO
        Me._ID_PAIS = aID_PAIS
        Me._ID_ESTADO_CIVIL = aID_ESTADO_CIVIL
        Me._FECHA_INGRESO = aFECHA_INGRESO
        Me._USUARIO_EVALUA = aUSUARIO_EVALUA
        Me._FECHA_EVALUA = aFECHA_EVALUA
        Me.ESTADO = aESTADO
        Me.ID_PARTICIPANTE_EXONERADO = aID_PARTICIPANTE_EXONERADO
    End Sub

    Public Function Equals1(ByVal other As PARTICIPANTE_EXONERADO_DOC) As Boolean Implements System.IEquatable(Of PARTICIPANTE_EXONERADO_DOC).Equals
        Return Me.ID_PARTICIPANTE_EXONERADO = other.ID_PARTICIPANTE_EXONERADO
    End Function

    Public Function CompareTo(ByVal other As PARTICIPANTE_EXONERADO_DOC) As Integer Implements System.IComparable(Of PARTICIPANTE_EXONERADO_DOC).CompareTo
        If Me.ID_PARTICIPANTE_EXONERADO > other.ID_PARTICIPANTE_EXONERADO Then Return 1
        If Me.ID_PARTICIPANTE_EXONERADO < other.ID_PARTICIPANTE_EXONERADO Then Return -1
        Return 0
    End Function


#Region " Properties "
    Private _ID_PARTICIPANTE_EXONERADO As Decimal
    <Column(Name:="Id participante exonerado", Storage:="ID_PARTICIPANTE_EXONERADO", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_PARTICIPANTE_EXONERADO() As Decimal
        Get
            Return _ID_PARTICIPANTE_EXONERADO
        End Get
        Set(ByVal Value As Decimal)
            _ID_PARTICIPANTE_EXONERADO = Value
            OnPropertyChanged("ID_PARTICIPANTE_EXONERADO")
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

    Private _fkID_PARTICIPANTE As PARTICIPANTE
    Public Property fkID_PARTICIPANTE() As PARTICIPANTE
        Get
            Return _fkID_PARTICIPANTE
        End Get
        Set(ByVal Value As PARTICIPANTE)
            _fkID_PARTICIPANTE = Value
        End Set
    End Property 

    Private _USERID As String
    <Column(Name:="Userid", Storage:="USERID", DbType:="VARCHAR2(256) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 256)> _
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
    <Column(Name:="Lastupdate", Storage:="LASTUPDATE", DbType:="DATE NOT NULL", Id:=False), _
     DataObjectField(False, False, False)> _
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

    Private _fkID_PROVEEDOR_AF As PROVEEDOR_AF
    Public Property fkID_PROVEEDOR_AF() As PROVEEDOR_AF
        Get
            Return _fkID_PROVEEDOR_AF
        End Get
        Set(ByVal Value As PROVEEDOR_AF)
            _fkID_PROVEEDOR_AF = Value
        End Set
    End Property 

    Private _ID_SITIO_CAPACITACION As Decimal
    <Column(Name:="Id sitio capacitacion", Storage:="ID_SITIO_CAPACITACION", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_SITIO_CAPACITACION() As Decimal
        Get
            Return _ID_SITIO_CAPACITACION
        End Get
        Set(ByVal Value As Decimal)
            _ID_SITIO_CAPACITACION = Value
            OnPropertyChanged("ID_SITIO_CAPACITACION")
        End Set
    End Property 

    Private _ID_SITIO_CAPACITACIONOld As Decimal
    Public Property ID_SITIO_CAPACITACIONOld() As Decimal
        Get
            Return _ID_SITIO_CAPACITACIONOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_SITIO_CAPACITACIONOld = Value
        End Set
    End Property 

    Private _fkID_SITIO_CAPACITACION As SITIO_CAPACITACION
    Public Property fkID_SITIO_CAPACITACION() As SITIO_CAPACITACION
        Get
            Return _fkID_SITIO_CAPACITACION
        End Get
        Set(ByVal Value As SITIO_CAPACITACION)
            _fkID_SITIO_CAPACITACION = Value
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

    Private _FECHA_NACIMIENTO As DateTime
    <Column(Name:="Fecha nacimiento", Storage:="FECHA_NACIMIENTO", DbType:="DATE NOT NULL", Id:=False), _
     DataObjectField(False, False, False)> _
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

    Private _CODIGO_DEPARTAMENTO As String
    <Column(Name:="Codigo departamento", Storage:="CODIGO_DEPARTAMENTO", DbType:="VARCHAR2(2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 2)> _
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

    Private _CODIGO_MUNICIPIO As String
    <Column(Name:="Codigo municipio", Storage:="CODIGO_MUNICIPIO", DbType:="VARCHAR2(2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 2)> _
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

    Private _DEPARTAMENTO_NAC As String
    <Column(Name:="Departamento nac", Storage:="DEPARTAMENTO_NAC", DbType:="VARCHAR2(2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 2)> _
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
    <Column(Name:="Municipio nac", Storage:="MUNICIPIO_NAC", DbType:="VARCHAR2(2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 2)> _
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

    Private _DIRECCION As String
    <Column(Name:="Direccion", Storage:="DIRECCION", DbType:="VARCHAR2(150) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 150)> _
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

    Private _CON_DISCAPACIDAD As Decimal
    <Column(Name:="Con discapacidad", Storage:="CON_DISCAPACIDAD", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=1, Scale:=0)> _
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

    Private _ID_NIVEL_ACADEMICO As Decimal
    <Column(Name:="Id nivel academico", Storage:="ID_NIVEL_ACADEMICO", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=2, Scale:=0)> _
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

    Private _ID_PAIS As Decimal
    <Column(Name:="Id pais", Storage:="ID_PAIS", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=3, Scale:=0)> _
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

    Private _ID_ESTADO_CIVIL As Decimal
    <Column(Name:="Id estado civil", Storage:="ID_ESTADO_CIVIL", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=1, Scale:=0)> _
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

    Private _FECHA_INGRESO As DateTime
    <Column(Name:="Fecha ingreso", Storage:="FECHA_INGRESO", DbType:="DATE NOT NULL", Id:=False), _
     DataObjectField(False, False, False)> _
    Public Property FECHA_INGRESO() As DateTime
        Get
            Return _FECHA_INGRESO
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_INGRESO = Value
            OnPropertyChanged("FECHA_INGRESO")
        End Set
    End Property 

    Private _FECHA_INGRESOOld As DateTime
    Public Property FECHA_INGRESOOld() As DateTime
        Get
            Return _FECHA_INGRESOOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_INGRESOOld = Value
        End Set
    End Property 

    Private _USUARIO_EVALUA As String
    <Column(Name:="Usuario evalua", Storage:="USUARIO_EVALUA", DbType:="VARCHAR2(20)", Id:=False), _
     DataObjectField(False, False, True, 20)> _
    Public Property USUARIO_EVALUA() As String
        Get
            Return _USUARIO_EVALUA
        End Get
        Set(ByVal Value As String)
            _USUARIO_EVALUA = Value
            OnPropertyChanged("USUARIO_EVALUA")
        End Set
    End Property 

    Private _USUARIO_EVALUAOld As String
    Public Property USUARIO_EVALUAOld() As String
        Get
            Return _USUARIO_EVALUAOld
        End Get
        Set(ByVal Value As String)
            _USUARIO_EVALUAOld = Value
        End Set
    End Property 

    Private _FECHA_EVALUA As DateTime
    <Column(Name:="Fecha evalua", Storage:="FECHA_EVALUA", DbType:="DATE", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property FECHA_EVALUA() As DateTime
        Get
            Return _FECHA_EVALUA
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_EVALUA = Value
            OnPropertyChanged("FECHA_EVALUA")
        End Set
    End Property 

    Private _FECHA_EVALUAOld As DateTime
    Public Property FECHA_EVALUAOld() As DateTime
        Get
            Return _FECHA_EVALUAOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_EVALUAOld = Value
        End Set
    End Property 

    Private _ESTADO As Decimal
    <Column(Name:="Estado", Storage:="ESTADO", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=1, Scale:=0)> _
    Public Property ESTADO() As Decimal
        Get
            Return _ESTADO
        End Get
        Set(ByVal Value As Decimal)
            _ESTADO = Value
            OnPropertyChanged("ESTADO")
        End Set
    End Property

    Private _ESTADOOld As Decimal
    Public Property ESTADOOld() As Decimal
        Get
            Return _ESTADOOld
        End Get
        Set(ByVal Value As Decimal)
            _ESTADOOld = Value
        End Set
    End Property

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
