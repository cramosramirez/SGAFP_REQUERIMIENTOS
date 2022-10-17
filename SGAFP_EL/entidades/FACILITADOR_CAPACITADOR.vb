''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.FACILITADOR_CAPACITADOR
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row FACILITADOR_CAPACITADOR en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	10/03/2011	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="FACILITADOR_CAPACITADOR")> Public Class FACILITADOR_CAPACITADOR
    Inherits entidadBase
    Implements IEquatable(Of FACILITADOR_CAPACITADOR), IComparable(Of FACILITADOR_CAPACITADOR)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_FACILITADOR As Decimal, aID_TIPO_PERSONA As Decimal, aID_PROVEEDOR_AF As Decimal, aCODIGO_MUNICIPIO As String, aCODIGO_DEPARTAMENTO As String, aNOMBRE_FACILITADOR As String, aNIT As String, aDUI As String, aISSS As String, aFECHA_INGRESO As DateTime, aTELEFONO As String, aEMAIL As String, aDIRECCION As String, aNOTAS As String, aUSERID As String, aLASTUPDATE As DateTime)
        Me._ID_FACILITADOR = aID_FACILITADOR
        Me._ID_TIPO_PERSONA = aID_TIPO_PERSONA
        Me._ID_PROVEEDOR_AF = aID_PROVEEDOR_AF
        Me._CODIGO_MUNICIPIO = aCODIGO_MUNICIPIO
        Me._CODIGO_DEPARTAMENTO = aCODIGO_DEPARTAMENTO
        Me._NOMBRE_FACILITADOR = aNOMBRE_FACILITADOR
        Me._NIT = aNIT
        Me._DUI = aDUI
        Me._ISSS = aISSS
        Me._FECHA_INGRESO = aFECHA_INGRESO
        Me._TELEFONO = aTELEFONO
        Me._EMAIL = aEMAIL
        Me._DIRECCION = aDIRECCION
        Me._NOTAS = aNOTAS
        Me._USERID = aUSERID
        Me._LASTUPDATE = aLASTUPDATE
    End Sub

    Public Function Equals1(ByVal other As FACILITADOR_CAPACITADOR) As Boolean Implements System.IEquatable(Of FACILITADOR_CAPACITADOR).Equals
        Return Me.ID_FACILITADOR = other.ID_FACILITADOR
    End Function

    Public Function CompareTo(ByVal other As FACILITADOR_CAPACITADOR) As Integer Implements System.IComparable(Of FACILITADOR_CAPACITADOR).CompareTo
        If Me.ID_FACILITADOR > other.ID_FACILITADOR Then Return 1
        If Me.ID_FACILITADOR < other.ID_FACILITADOR Then Return -1
        Return 0
    End Function


#Region " Properties "

    Private _ID_FACILITADOR As Decimal
    <Column(Name:="Id facilitador", Storage:="ID_FACILITADOR", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_FACILITADOR() As Decimal
        Get
            Return _ID_FACILITADOR
        End Get
        Set(ByVal Value As Decimal)
            _ID_FACILITADOR = Value
            OnPropertyChanged("ID_FACILITADOR")
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

    Private _NOMBRE_FACILITADOR As String
    <Column(Name:="Nombre facilitador", Storage:="NOMBRE_FACILITADOR", DbType:="VARCHAR2(100)", Id:=False), _
     DataObjectField(False, False, True, 100)> _
    Public Property NOMBRE_FACILITADOR() As String
        Get
            Return _NOMBRE_FACILITADOR
        End Get
        Set(ByVal Value As String)
            _NOMBRE_FACILITADOR = Value
            OnPropertyChanged("NOMBRE_FACILITADOR")
        End Set
    End Property 

    Private _NOMBRE_FACILITADOROld As String
    Public Property NOMBRE_FACILITADOROld() As String
        Get
            Return _NOMBRE_FACILITADOROld
        End Get
        Set(ByVal Value As String)
            _NOMBRE_FACILITADOROld = Value
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

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
