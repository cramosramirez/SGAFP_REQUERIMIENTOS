''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.AREA_FORMACION
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row AREA_FORMACION en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/12/2011	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="AREA_FORMACION")> Public Class AREA_FORMACION
    Inherits entidadBase
    Implements IEquatable(Of AREA_FORMACION), IComparable(Of AREA_FORMACION)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_AREA_FORMACION As Decimal, aAREA_FORMACION As String, aNOTAS As String, aCODIGO_AREA As String, aUSERID As String, aLASTUPDATE As DateTime)
        Me._ID_AREA_FORMACION = aID_AREA_FORMACION
        Me._AREA_FORMACION = aAREA_FORMACION
        Me._NOTAS = aNOTAS
        Me._CODIGO_AREA = aCODIGO_AREA
        Me._USERID = aUSERID
        Me._LASTUPDATE = aLASTUPDATE
    End Sub

    Public Function Equals1(ByVal other As AREA_FORMACION) As Boolean Implements System.IEquatable(Of AREA_FORMACION).Equals
        Return Me.ID_AREA_FORMACION = other.ID_AREA_FORMACION
    End Function

    Public Function CompareTo(ByVal other As AREA_FORMACION) As Integer Implements System.IComparable(Of AREA_FORMACION).CompareTo
        If Me.ID_AREA_FORMACION > other.ID_AREA_FORMACION Then Return 1
        If Me.ID_AREA_FORMACION < other.ID_AREA_FORMACION Then Return -1
        Return 0
    End Function


#Region " Properties "

    Private _ID_AREA_FORMACION As Decimal
    <Column(Name:="Id area formacion", Storage:="ID_AREA_FORMACION", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_AREA_FORMACION() As Decimal
        Get
            Return _ID_AREA_FORMACION
        End Get
        Set(ByVal Value As Decimal)
            _ID_AREA_FORMACION = Value
            OnPropertyChanged("ID_AREA_FORMACION")
        End Set
    End Property

    Private _AREA_FORMACION As String
    <Column(Name:="Area formacion", Storage:="AREA_FORMACION", DbType:="VARCHAR2(800)", Id:=False), _
     DataObjectField(False, False, True, 800)> _
    Public Property AREA_FORMACION() As String
        Get
            Return _AREA_FORMACION
        End Get
        Set(ByVal Value As String)
            _AREA_FORMACION = Value
            OnPropertyChanged("AREA_FORMACION")
        End Set
    End Property

    Private _AREA_FORMACIONOld As String
    Public Property AREA_FORMACIONOld() As String
        Get
            Return _AREA_FORMACIONOld
        End Get
        Set(ByVal Value As String)
            _AREA_FORMACIONOld = Value
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

    Private _CODIGO_AREA As String
    <Column(Name:="Codigo area", Storage:="CODIGO_AREA", DbType:="VARCHAR2(100)", Id:=False), _
     DataObjectField(False, False, True, 100)> _
    Public Property CODIGO_AREA() As String
        Get
            Return _CODIGO_AREA
        End Get
        Set(ByVal Value As String)
            _CODIGO_AREA = Value
            OnPropertyChanged("CODIGO_AREA")
        End Set
    End Property

    Private _CODIGO_AREAOld As String
    Public Property CODIGO_AREAOld() As String
        Get
            Return _CODIGO_AREAOld
        End Get
        Set(ByVal Value As String)
            _CODIGO_AREAOld = Value
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
