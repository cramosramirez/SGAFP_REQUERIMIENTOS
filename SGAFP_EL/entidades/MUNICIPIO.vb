''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.MUNICIPIO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row MUNICIPIO en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	19/01/2011	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="MUNICIPIO")> Public Class MUNICIPIO
    Inherits entidadBase
    Implements IEquatable(Of MUNICIPIO), IComparable(Of MUNICIPIO)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aCODIGO_DEPARTAMENTO As String, aCODIGO_MUNICIPIO As String, aNOMBRE As String, aUSERID As String, aLASTUPDATE As DateTime, aLATITUD As Decimal, aLONGITUD As Decimal)
        Me._CODIGO_DEPARTAMENTO = aCODIGO_DEPARTAMENTO
        Me._CODIGO_MUNICIPIO = aCODIGO_MUNICIPIO
        Me._NOMBRE = aNOMBRE
        Me._USERID = aUSERID
        Me._LASTUPDATE = aLASTUPDATE
        Me._LATITUD = aLATITUD
        Me._LONGITUD = aLONGITUD
    End Sub

    Public Function Equals1(ByVal other As MUNICIPIO) As Boolean Implements System.IEquatable(Of MUNICIPIO).Equals
        Return Me.CODIGO_DEPARTAMENTO = other.CODIGO_DEPARTAMENTO And Me.CODIGO_MUNICIPIO = other.CODIGO_MUNICIPIO
    End Function

    Public Function CompareTo(ByVal other As MUNICIPIO) As Integer Implements System.IComparable(Of MUNICIPIO).CompareTo
        If Me.CODIGO_DEPARTAMENTO > other.CODIGO_DEPARTAMENTO Then
            If Me.CODIGO_MUNICIPIO > other.CODIGO_MUNICIPIO Then Return 1
            If Me.CODIGO_MUNICIPIO < other.CODIGO_MUNICIPIO Then Return -1
        Else
            Return -1
        End If
        Return 0
    End Function


#Region " Properties "

    Private _CODIGO_DEPARTAMENTO As String
    <Column(Name:="Codigo departamento", Storage:="CODIGO_DEPARTAMENTO", DbType:="VARCHAR2(2) NOT NULL", Id:=True), _
     DataObjectField(True, False, False, 2)> _
    Public Property CODIGO_DEPARTAMENTO() As String
        Get
            Return _CODIGO_DEPARTAMENTO
        End Get
        Set(ByVal Value As String)
            _CODIGO_DEPARTAMENTO = Value
            OnPropertyChanged("CODIGO_DEPARTAMENTO")
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
    <Column(Name:="Codigo municipio", Storage:="CODIGO_MUNICIPIO", DbType:="VARCHAR2(2) NOT NULL", Id:=True), _
     DataObjectField(True, False, False, 2)> _
    Public Property CODIGO_MUNICIPIO() As String
        Get
            Return _CODIGO_MUNICIPIO
        End Get
        Set(ByVal Value As String)
            _CODIGO_MUNICIPIO = Value
            OnPropertyChanged("CODIGO_MUNICIPIO")
        End Set
    End Property 

    Private _NOMBRE As String
    <Column(Name:="Nombre", Storage:="NOMBRE", DbType:="VARCHAR2(60) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 60)> _
    Public Property NOMBRE() As String
        Get
            Return _NOMBRE
        End Get
        Set(ByVal Value As String)
            _NOMBRE = Value
            OnPropertyChanged("NOMBRE")
        End Set
    End Property 

    Private _NOMBREOld As String
    Public Property NOMBREOld() As String
        Get
            Return _NOMBREOld
        End Get
        Set(ByVal Value As String)
            _NOMBREOld = Value
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

    Private _LATITUD As Decimal
    <Column(Name:="Latitud", Storage:="LATITUD", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=0, Scale:=0)> _
    Public Property LATITUD() As Decimal
        Get
            Return _LATITUD
        End Get
        Set(ByVal Value As Decimal)
            _LATITUD = Value
            OnPropertyChanged("LATITUD")
        End Set
    End Property 

    Private _LATITUDOld As Decimal
    Public Property LATITUDOld() As Decimal
        Get
            Return _LATITUDOld
        End Get
        Set(ByVal Value As Decimal)
            _LATITUDOld = Value
        End Set
    End Property 

    Private _LONGITUD As Decimal
    <Column(Name:="Longitud", Storage:="LONGITUD", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=0, Scale:=0)> _
    Public Property LONGITUD() As Decimal
        Get
            Return _LONGITUD
        End Get
        Set(ByVal Value As Decimal)
            _LONGITUD = Value
            OnPropertyChanged("LONGITUD")
        End Set
    End Property 

    Private _LONGITUDOld As Decimal
    Public Property LONGITUDOld() As Decimal
        Get
            Return _LONGITUDOld
        End Get
        Set(ByVal Value As Decimal)
            _LONGITUDOld = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
