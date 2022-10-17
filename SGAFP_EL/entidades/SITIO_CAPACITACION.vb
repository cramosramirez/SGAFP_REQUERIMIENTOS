''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.SITIO_CAPACITACION
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row SITIO_CAPACITACION en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	14/02/2011	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="SITIO_CAPACITACION")> Public Class SITIO_CAPACITACION
    Inherits entidadBase
    Implements IEquatable(Of SITIO_CAPACITACION), IComparable(Of SITIO_CAPACITACION)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(ByVal aID_SITIO_CAPACITACION As Decimal, ByVal aCODIGO_MUNICIPIO As String, ByVal aCODIGO_DEPARTAMENTO As String, ByVal aID_PROVEEDOR_AF As Decimal, ByVal aNOMBRE_SITIO As String, ByVal aFORMATO_CODIGO_CURSO As String, ByVal aDIRECCION As String, ByVal aTELEFONO As String, ByVal aFAX As String, ByVal aEMAIL As String, ByVal aNUMERO_AULAS As Decimal, ByVal aFECHA_REGISTRO As DateTime, ByVal aENCARGADO As String, ByVal aTELEFONO_ENCARGADO As String, ByVal aEMAIL_ENCARGADO As String, ByVal aCARGO_ENCARGADO As String, ByVal aUSERID As String, ByVal aLASTUPDATE As DateTime, ByVal aLATITUD As String, ByVal aLONGITUD As String)
        Me._ID_SITIO_CAPACITACION = aID_SITIO_CAPACITACION
        Me._CODIGO_MUNICIPIO = aCODIGO_MUNICIPIO
        Me._CODIGO_DEPARTAMENTO = aCODIGO_DEPARTAMENTO
        Me._ID_PROVEEDOR_AF = aID_PROVEEDOR_AF
        Me._NOMBRE_SITIO = aNOMBRE_SITIO
        Me._FORMATO_CODIGO_CURSO = aFORMATO_CODIGO_CURSO
        Me._DIRECCION = aDIRECCION
        Me._TELEFONO = aTELEFONO
        Me._FAX = aFAX
        Me._EMAIL = aEMAIL
        Me._NUMERO_AULAS = aNUMERO_AULAS
        Me._FECHA_REGISTRO = aFECHA_REGISTRO
        Me._ENCARGADO = aENCARGADO
        Me._TELEFONO_ENCARGADO = aTELEFONO_ENCARGADO
        Me._EMAIL_ENCARGADO = aEMAIL_ENCARGADO
        Me._CARGO_ENCARGADO = aCARGO_ENCARGADO
        Me._USERID = aUSERID
        Me._LASTUPDATE = aLASTUPDATE
        Me._LATITUD = aLATITUD
        Me._LONGITUD = aLONGITUD
    End Sub

    Public Function Equals1(ByVal other As SITIO_CAPACITACION) As Boolean Implements System.IEquatable(Of SITIO_CAPACITACION).Equals
        Return Me.ID_SITIO_CAPACITACION = other.ID_SITIO_CAPACITACION
    End Function

    Public Function CompareTo(ByVal other As SITIO_CAPACITACION) As Integer Implements System.IComparable(Of SITIO_CAPACITACION).CompareTo
        If Me.ID_SITIO_CAPACITACION > other.ID_SITIO_CAPACITACION Then Return 1
        If Me.ID_SITIO_CAPACITACION < other.ID_SITIO_CAPACITACION Then Return -1
        Return 0
    End Function


#Region " Properties "

    Private _ID_SITIO_CAPACITACION As Decimal
    <Column(Name:="Id sitio capacitacion", Storage:="ID_SITIO_CAPACITACION", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_SITIO_CAPACITACION() As Decimal
        Get
            Return _ID_SITIO_CAPACITACION
        End Get
        Set(ByVal Value As Decimal)
            _ID_SITIO_CAPACITACION = Value
            OnPropertyChanged("ID_SITIO_CAPACITACION")
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

    Private _ID_PROVEEDOR_AF As Decimal
    <Column(Name:="Id proveedor af", Storage:="ID_PROVEEDOR_AF", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=8, Scale:=0)> _
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

    Private _NOMBRE_SITIO As String
    <Column(Name:="Nombre sitio", Storage:="NOMBRE_SITIO", DbType:="VARCHAR2(100)", Id:=False), _
     DataObjectField(False, False, True, 100)> _
    Public Property NOMBRE_SITIO() As String
        Get
            Return _NOMBRE_SITIO
        End Get
        Set(ByVal Value As String)
            _NOMBRE_SITIO = Value
            OnPropertyChanged("NOMBRE_SITIO")
        End Set
    End Property 

    Private _NOMBRE_SITIOOld As String
    Public Property NOMBRE_SITIOOld() As String
        Get
            Return _NOMBRE_SITIOOld
        End Get
        Set(ByVal Value As String)
            _NOMBRE_SITIOOld = Value
        End Set
    End Property 

    Private _FORMATO_CODIGO_CURSO As String
    <Column(Name:="Formato codigo curso", Storage:="FORMATO_CODIGO_CURSO", DbType:="VARCHAR2(50)", Id:=False), _
     DataObjectField(False, False, True, 50)> _
    Public Property FORMATO_CODIGO_CURSO() As String
        Get
            Return _FORMATO_CODIGO_CURSO
        End Get
        Set(ByVal Value As String)
            _FORMATO_CODIGO_CURSO = Value
            OnPropertyChanged("FORMATO_CODIGO_CURSO")
        End Set
    End Property 

    Private _FORMATO_CODIGO_CURSOOld As String
    Public Property FORMATO_CODIGO_CURSOOld() As String
        Get
            Return _FORMATO_CODIGO_CURSOOld
        End Get
        Set(ByVal Value As String)
            _FORMATO_CODIGO_CURSOOld = Value
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

    Private _EMAIL As String
    <Column(Name:="Email", Storage:="EMAIL", DbType:="VARCHAR2(50)", Id:=False), _
     DataObjectField(False, False, True, 50)> _
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

    Private _NUMERO_AULAS As Decimal
    <Column(Name:="Numero aulas", Storage:="NUMERO_AULAS", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=0, Scale:=0)> _
    Public Property NUMERO_AULAS() As Decimal
        Get
            Return _NUMERO_AULAS
        End Get
        Set(ByVal Value As Decimal)
            _NUMERO_AULAS = Value
            OnPropertyChanged("NUMERO_AULAS")
        End Set
    End Property 

    Private _NUMERO_AULASOld As Decimal
    Public Property NUMERO_AULASOld() As Decimal
        Get
            Return _NUMERO_AULASOld
        End Get
        Set(ByVal Value As Decimal)
            _NUMERO_AULASOld = Value
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

    Private _ENCARGADO As String
    <Column(Name:="Encargado", Storage:="ENCARGADO", DbType:="VARCHAR2(60)", Id:=False), _
     DataObjectField(False, False, True, 60)> _
    Public Property ENCARGADO() As String
        Get
            Return _ENCARGADO
        End Get
        Set(ByVal Value As String)
            _ENCARGADO = Value
            OnPropertyChanged("ENCARGADO")
        End Set
    End Property 

    Private _ENCARGADOOld As String
    Public Property ENCARGADOOld() As String
        Get
            Return _ENCARGADOOld
        End Get
        Set(ByVal Value As String)
            _ENCARGADOOld = Value
        End Set
    End Property 

    Private _TELEFONO_ENCARGADO As String
    <Column(Name:="Telefono encargado", Storage:="TELEFONO_ENCARGADO", DbType:="CHAR(8)", Id:=False), _
     DataObjectField(False, False, True, 8)> _
    Public Property TELEFONO_ENCARGADO() As String
        Get
            Return _TELEFONO_ENCARGADO
        End Get
        Set(ByVal Value As String)
            _TELEFONO_ENCARGADO = Value
            OnPropertyChanged("TELEFONO_ENCARGADO")
        End Set
    End Property 

    Private _TELEFONO_ENCARGADOOld As String
    Public Property TELEFONO_ENCARGADOOld() As String
        Get
            Return _TELEFONO_ENCARGADOOld
        End Get
        Set(ByVal Value As String)
            _TELEFONO_ENCARGADOOld = Value
        End Set
    End Property 

    Private _EMAIL_ENCARGADO As String
    <Column(Name:="Email encargado", Storage:="EMAIL_ENCARGADO", DbType:="VARCHAR2(50)", Id:=False), _
     DataObjectField(False, False, True, 50)> _
    Public Property EMAIL_ENCARGADO() As String
        Get
            Return _EMAIL_ENCARGADO
        End Get
        Set(ByVal Value As String)
            _EMAIL_ENCARGADO = Value
            OnPropertyChanged("EMAIL_ENCARGADO")
        End Set
    End Property 

    Private _EMAIL_ENCARGADOOld As String
    Public Property EMAIL_ENCARGADOOld() As String
        Get
            Return _EMAIL_ENCARGADOOld
        End Get
        Set(ByVal Value As String)
            _EMAIL_ENCARGADOOld = Value
        End Set
    End Property 

    Private _CARGO_ENCARGADO As String
    <Column(Name:="Cargo encargado", Storage:="CARGO_ENCARGADO", DbType:="VARCHAR2(60)", Id:=False), _
     DataObjectField(False, False, True, 60)> _
    Public Property CARGO_ENCARGADO() As String
        Get
            Return _CARGO_ENCARGADO
        End Get
        Set(ByVal Value As String)
            _CARGO_ENCARGADO = Value
            OnPropertyChanged("CARGO_ENCARGADO")
        End Set
    End Property 

    Private _CARGO_ENCARGADOOld As String
    Public Property CARGO_ENCARGADOOld() As String
        Get
            Return _CARGO_ENCARGADOOld
        End Get
        Set(ByVal Value As String)
            _CARGO_ENCARGADOOld = Value
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

    Private _LATITUD As String
    <Column(Name:="Latitud", Storage:="LATITUD", DbType:="VARCHAR2(30)", Id:=False), _
     DataObjectField(False, False, True, 30)> _
    Public Property LATITUD() As String
        Get
            Return _LATITUD
        End Get
        Set(ByVal Value As String)
            _LATITUD = Value
            OnPropertyChanged("LATITUD")
        End Set
    End Property

    Private _LATITUDOld As String
    Public Property LATITUDOld() As String
        Get
            Return _LATITUDOld
        End Get
        Set(ByVal Value As String)
            _LATITUDOld = Value
        End Set
    End Property

    Private _LONGITUD As String
    <Column(Name:="Longitud", Storage:="LONGITUD", DbType:="VARCHAR2(30)", Id:=False), _
     DataObjectField(False, False, True, 30)> _
    Public Property LONGITUD() As String
        Get
            Return _LONGITUD
        End Get
        Set(ByVal Value As String)
            _LONGITUD = Value
            OnPropertyChanged("LONGITUD")
        End Set
    End Property

    Private _LONGITUDOld As String
    Public Property LONGITUDOld() As String
        Get
            Return _LONGITUDOld
        End Get
        Set(ByVal Value As String)
            _LONGITUDOld = Value
        End Set
    End Property

#End Region

#Region " Relaciones "
    Private _TECNICOS_SITIOS_ASIGSITIO_CAPACITACION As ListaTECNICOS_SITIOS_ASIG
    Public Property TECNICOS_SITIOS_ASIGSITIO_CAPACITACION() As ListaTECNICOS_SITIOS_ASIG
        Get
            Return _TECNICOS_SITIOS_ASIGSITIO_CAPACITACION
        End Get
        Set(ByVal Value As ListaTECNICOS_SITIOS_ASIG)
            _TECNICOS_SITIOS_ASIGSITIO_CAPACITACION = Value
        End Set
    End Property 

#End Region
#End Region
End Class
