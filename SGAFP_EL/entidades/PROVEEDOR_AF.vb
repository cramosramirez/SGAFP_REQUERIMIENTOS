''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.PROVEEDOR_AF
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row PROVEEDOR_AF en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	10/03/2011	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="PROVEEDOR_AF")> Public Class PROVEEDOR_AF
    Inherits entidadBase
    Implements IEquatable(Of PROVEEDOR_AF), IComparable(Of PROVEEDOR_AF)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_PROVEEDOR_AF As Decimal, aCODIGO_MUNICIPIO As String, aCODIGO_DEPARTAMENTO As String, aID_TIPO_PERSONA As Decimal, aNOMBRE_PROVEEDOR As String, aRAZON_SOCIAL As String, aNIT As String, aDUI As String, aNRC As String, aISSS As String, aFECHA_INGRESO As DateTime, aFECHA_ACREDITACION As DateTime, aDIRECCION As String, aEMAIL As String, aTELEFONO As String, aFAX As String, aURL As String, aCONTACTO As String, aTELEFONO_CONTACTO As String, aEMAIL_CONTACTO As String, aCARGO_CONTACTO As String, aESTADO As String, aNOTAS As String, aUSERID As String, aLASTUPDATE As DateTime, aFECHA_CREACION As Date, aUSUARIO_CREACION As String)
        Me._ID_PROVEEDOR_AF = aID_PROVEEDOR_AF
        Me._CODIGO_MUNICIPIO = aCODIGO_MUNICIPIO
        Me._CODIGO_DEPARTAMENTO = aCODIGO_DEPARTAMENTO
        Me._ID_TIPO_PERSONA = aID_TIPO_PERSONA
        Me._NOMBRE_PROVEEDOR = aNOMBRE_PROVEEDOR
        Me._RAZON_SOCIAL = aRAZON_SOCIAL
        Me._NIT = aNIT
        Me._DUI = aDUI
        Me._NRC = aNRC
        Me._ISSS = aISSS
        Me._FECHA_INGRESO = aFECHA_INGRESO
        Me._FECHA_ACREDITACION = aFECHA_ACREDITACION
        Me._DIRECCION = aDIRECCION
        Me._EMAIL = aEMAIL
        Me._TELEFONO = aTELEFONO
        Me._FAX = aFAX
        Me._URL = aURL
        Me._CONTACTO = aCONTACTO
        Me._TELEFONO_CONTACTO = aTELEFONO_CONTACTO
        Me._EMAIL_CONTACTO = aEMAIL_CONTACTO
        Me._CARGO_CONTACTO = aCARGO_CONTACTO
        Me._ESTADO = aESTADO
        Me._NOTAS = aNOTAS
        Me._USERID = aUSERID
        Me._LASTUPDATE = aLASTUPDATE
        Me._FECHA_CREACION = aFECHA_CREACION
        Me._USUARIO_CREACION = aUSUARIO_CREACION
    End Sub

    Public Function Equals1(ByVal other As PROVEEDOR_AF) As Boolean Implements System.IEquatable(Of PROVEEDOR_AF).Equals
        Return Me.ID_PROVEEDOR_AF = other.ID_PROVEEDOR_AF
    End Function

    Public Function CompareTo(ByVal other As PROVEEDOR_AF) As Integer Implements System.IComparable(Of PROVEEDOR_AF).CompareTo
        If Me.ID_PROVEEDOR_AF > other.ID_PROVEEDOR_AF Then Return 1
        If Me.ID_PROVEEDOR_AF < other.ID_PROVEEDOR_AF Then Return -1
        Return 0
    End Function


#Region " Properties "

    Private _ID_PROVEEDOR_AF As Decimal
    <Column(Name:="Id proveedor af", Storage:="ID_PROVEEDOR_AF", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_PROVEEDOR_AF() As Decimal
        Get
            Return _ID_PROVEEDOR_AF
        End Get
        Set(ByVal Value As Decimal)
            _ID_PROVEEDOR_AF = Value
            OnPropertyChanged("ID_PROVEEDOR_AF")
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

    Private _ID_TIPO_PERSONA As Decimal
    <Column(Name:="Id tipo persona", Storage:="ID_TIPO_PERSONA", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_TIPO_PERSONA() As Decimal
        Get
            Return _ID_TIPO_PERSONA
        End Get
        Set(ByVal Value As Decimal)
            _ID_TIPO_PERSONA = Value
            OnPropertyChanged("ID_TIPO_PERSONA")
        End Set
    End Property 

    Private _ID_TIPO_PERSONAOld As Decimal
    Public Property ID_TIPO_PERSONAOld() As Decimal
        Get
            Return _ID_TIPO_PERSONAOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_TIPO_PERSONAOld = Value
        End Set
    End Property 

    Private _fkID_TIPO_PERSONA As TIPO_PERSONA
    Public Property fkID_TIPO_PERSONA() As TIPO_PERSONA
        Get
            Return _fkID_TIPO_PERSONA
        End Get
        Set(ByVal Value As TIPO_PERSONA)
            _fkID_TIPO_PERSONA = Value
        End Set
    End Property 

    Private _NOMBRE_PROVEEDOR As String
    <Column(Name:="Nombre proveedor", Storage:="NOMBRE_PROVEEDOR", DbType:="VARCHAR2(150)", Id:=False), _
     DataObjectField(False, False, True, 150)> _
    Public Property NOMBRE_PROVEEDOR() As String
        Get
            Return _NOMBRE_PROVEEDOR
        End Get
        Set(ByVal Value As String)
            _NOMBRE_PROVEEDOR = Value
            OnPropertyChanged("NOMBRE_PROVEEDOR")
        End Set
    End Property

    Private _NOMBRE_PROVEEDOROld As String
    Public Property NOMBRE_PROVEEDOROld() As String
        Get
            Return _NOMBRE_PROVEEDOROld
        End Get
        Set(ByVal Value As String)
            _NOMBRE_PROVEEDOROld = Value
        End Set
    End Property 

    Private _RAZON_SOCIAL As String
    <Column(Name:="Razon social", Storage:="RAZON_SOCIAL", DbType:="VARCHAR2(150)", Id:=False), _
     DataObjectField(False, False, True, 150)> _
    Public Property RAZON_SOCIAL() As String
        Get
            Return _RAZON_SOCIAL
        End Get
        Set(ByVal Value As String)
            _RAZON_SOCIAL = Value
            OnPropertyChanged("RAZON_SOCIAL")
        End Set
    End Property 

    Private _RAZON_SOCIALOld As String
    Public Property RAZON_SOCIALOld() As String
        Get
            Return _RAZON_SOCIALOld
        End Get
        Set(ByVal Value As String)
            _RAZON_SOCIALOld = Value
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

    Private _NRC As String
    <Column(Name:="Nrc", Storage:="NRC", DbType:="VARCHAR2(20)", Id:=False), _
     DataObjectField(False, False, True, 20)> _
    Public Property NRC() As String
        Get
            Return _NRC
        End Get
        Set(ByVal Value As String)
            _NRC = Value
            OnPropertyChanged("NRC")
        End Set
    End Property 

    Private _NRCOld As String
    Public Property NRCOld() As String
        Get
            Return _NRCOld
        End Get
        Set(ByVal Value As String)
            _NRCOld = Value
        End Set
    End Property 

    Private _ISSS As String
    <Column(Name:="Isss", Storage:="ISSS", DbType:="VARCHAR2(9)", Id:=False), _
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

    Private _FECHA_INGRESO As DateTime
    <Column(Name:="Fecha ingreso", Storage:="FECHA_INGRESO", DbType:="DATE", Id:=False), _
     DataObjectField(False, False, True)> _
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

    Private _FECHA_ACREDITACION As DateTime
    <Column(Name:="Fecha acreditacion", Storage:="FECHA_ACREDITACION", DbType:="DATE", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property FECHA_ACREDITACION() As DateTime
        Get
            Return _FECHA_ACREDITACION
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_ACREDITACION = Value
            OnPropertyChanged("FECHA_ACREDITACION")
        End Set
    End Property 

    Private _FECHA_ACREDITACIONOld As DateTime
    Public Property FECHA_ACREDITACIONOld() As DateTime
        Get
            Return _FECHA_ACREDITACIONOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_ACREDITACIONOld = Value
        End Set
    End Property 

    Private _DIRECCION As String
    <Column(Name:="Direccion", Storage:="DIRECCION", DbType:="VARCHAR2(200)", Id:=False), _
     DataObjectField(False, False, True, 200)> _
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

    Private _EMAIL As String
    <Column(Name:="Email", Storage:="EMAIL", DbType:="VARCHAR2(250)", Id:=False), _
     DataObjectField(False, False, True, 250)> _
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

    Private _TELEFONO As String
    <Column(Name:="Telefono", Storage:="TELEFONO", DbType:="CHAR(8)", Id:=False), _
     DataObjectField(False, False, True, 8)> _
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

    Private _FAX As String
    <Column(Name:="Fax", Storage:="FAX", DbType:="CHAR(8)", Id:=False), _
     DataObjectField(False, False, True, 8)> _
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

    Private _URL As String
    <Column(Name:="Url", Storage:="URL", DbType:="VARCHAR2(255)", Id:=False), _
     DataObjectField(False, False, True, 255)> _
    Public Property URL() As String
        Get
            Return _URL
        End Get
        Set(ByVal Value As String)
            _URL = Value
            OnPropertyChanged("URL")
        End Set
    End Property 

    Private _URLOld As String
    Public Property URLOld() As String
        Get
            Return _URLOld
        End Get
        Set(ByVal Value As String)
            _URLOld = Value
        End Set
    End Property 

    Private _CONTACTO As String
    <Column(Name:="Contacto", Storage:="CONTACTO", DbType:="VARCHAR2(80)", Id:=False), _
     DataObjectField(False, False, True, 80)> _
    Public Property CONTACTO() As String
        Get
            Return _CONTACTO
        End Get
        Set(ByVal Value As String)
            _CONTACTO = Value
            OnPropertyChanged("CONTACTO")
        End Set
    End Property 

    Private _CONTACTOOld As String
    Public Property CONTACTOOld() As String
        Get
            Return _CONTACTOOld
        End Get
        Set(ByVal Value As String)
            _CONTACTOOld = Value
        End Set
    End Property 

    Private _TELEFONO_CONTACTO As String
    <Column(Name:="Telefono contacto", Storage:="TELEFONO_CONTACTO", DbType:="VARCHAR2(8)", Id:=False), _
     DataObjectField(False, False, True, 8)> _
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

    Private _EMAIL_CONTACTO As String
    <Column(Name:="Email contacto", Storage:="EMAIL_CONTACTO", DbType:="VARCHAR2(50)", Id:=False), _
     DataObjectField(False, False, True, 50)> _
    Public Property EMAIL_CONTACTO() As String
        Get
            Return _EMAIL_CONTACTO
        End Get
        Set(ByVal Value As String)
            _EMAIL_CONTACTO = Value
            OnPropertyChanged("EMAIL_CONTACTO")
        End Set
    End Property 

    Private _EMAIL_CONTACTOOld As String
    Public Property EMAIL_CONTACTOOld() As String
        Get
            Return _EMAIL_CONTACTOOld
        End Get
        Set(ByVal Value As String)
            _EMAIL_CONTACTOOld = Value
        End Set
    End Property 

    Private _CARGO_CONTACTO As String
    <Column(Name:="Cargo contacto", Storage:="CARGO_CONTACTO", DbType:="VARCHAR2(80)", Id:=False), _
     DataObjectField(False, False, True, 80)> _
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

    Private _ESTADO As String
    <Column(Name:="Estado", Storage:="ESTADO", DbType:="CHAR(1)", Id:=False), _
     DataObjectField(False, False, True, 1)> _
    Public Property ESTADO() As String
        Get
            Return _ESTADO
        End Get
        Set(ByVal Value As String)
            _ESTADO = Value
            OnPropertyChanged("ESTADO")
        End Set
    End Property 

    Private _ESTADOOld As String
    Public Property ESTADOOld() As String
        Get
            Return _ESTADOOld
        End Get
        Set(ByVal Value As String)
            _ESTADOOld = Value
        End Set
    End Property 

    Private _NOTAS As String
    <Column(Name:="Notas", Storage:="NOTAS", DbType:="VARCHAR2(255)", Id:=False), _
     DataObjectField(False, False, True, 255)> _
    Public Property NOTAS() As String
        Get
            Return _NOTAS
        End Get
        Set(ByVal Value As String)
            _NOTAS = Value
            OnPropertyChanged("NOTAS")
        End Set
    End Property 

    Private _NOTASOld As String
    Public Property NOTASOld() As String
        Get
            Return _NOTASOld
        End Get
        Set(ByVal Value As String)
            _NOTASOld = Value
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


    Private _USUARIO_CREACION As String
    <Column(Name:="Usuario creacion", Storage:="USUARIO_CREACION", DbType:="VARCHAR2(255)", Id:=False), _
     DataObjectField(False, False, True, 255)> _
    Public Property USUARIO_CREACION() As String
        Get
            Return _USUARIO_CREACION
        End Get
        Set(ByVal Value As String)
            _USUARIO_CREACION = Value
            OnPropertyChanged("USUARIO_CREACION")
        End Set
    End Property

    Private _USUARIO_CREACIONOld As String
    Public Property USUARIO_CREACIONOld() As String
        Get
            Return _USUARIO_CREACIONOld
        End Get
        Set(ByVal Value As String)
            _USUARIO_CREACIONOld = Value
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

#End Region

#Region " Relaciones "

    'Private _OFERTA_FORMATIVA_SITIOPROVEEDOR_AF As ListaOFERTA_FORMATIVA_SITIO
    'Public Property OFERTA_FORMATIVA_SITIOPROVEEDOR_AF() As ListaOFERTA_FORMATIVA_SITIO
    '    Get
    '        Return _OFERTA_FORMATIVA_SITIOPROVEEDOR_AF
    '    End Get
    '    Set(ByVal Value As ListaOFERTA_FORMATIVA_SITIO)
    '        _OFERTA_FORMATIVA_SITIOPROVEEDOR_AF = Value
    '    End Set
    'End Property 

    Private _TECNICOS_SITIOS_ASIGPROVEEDOR_AF As listaTECNICOS_SITIOS_ASIG
    Public Property TECNICOS_SITIOS_ASIGPROVEEDOR_AF() As listaTECNICOS_SITIOS_ASIG
        Get
            Return _TECNICOS_SITIOS_ASIGPROVEEDOR_AF
        End Get
        Set(ByVal Value As listaTECNICOS_SITIOS_ASIG)
            _TECNICOS_SITIOS_ASIGPROVEEDOR_AF = Value
        End Set
    End Property

#End Region
#End Region
End Class
