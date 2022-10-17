''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.PROYECTO_FORMACION
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row PROYECTO_FORMACION en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	05/10/2012	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="PROYECTO_FORMACION")> Public Class PROYECTO_FORMACION
    Inherits entidadBase
    Implements IEquatable(Of PROYECTO_FORMACION), IComparable(Of PROYECTO_FORMACION)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_PROYECTO_FORMACION As Decimal, aNOMBRE_PROYECTO_FORMACION As String, aUSERID As String, aLASTUPDATE As DateTime)
        Me._ID_PROYECTO_FORMACION = aID_PROYECTO_FORMACION
        Me._NOMBRE_PROYECTO_FORMACION = aNOMBRE_PROYECTO_FORMACION
        Me._USERID = aUSERID
        Me._LASTUPDATE = aLASTUPDATE
    End Sub

    Public Function Equals1(ByVal other As PROYECTO_FORMACION) As Boolean Implements System.IEquatable(Of PROYECTO_FORMACION).Equals
        Return Me.ID_PROYECTO_FORMACION = other.ID_PROYECTO_FORMACION
    End Function

    Public Function CompareTo(ByVal other As PROYECTO_FORMACION) As Integer Implements System.IComparable(Of PROYECTO_FORMACION).CompareTo
        If Me.ID_PROYECTO_FORMACION > other.ID_PROYECTO_FORMACION Then Return 1
        If Me.ID_PROYECTO_FORMACION < other.ID_PROYECTO_FORMACION Then Return -1
        Return 0
    End Function


#Region " Properties "

    Private _ID_PROYECTO_FORMACION As Decimal
    <Column(Name:="Id proyecto formacion", Storage:="ID_PROYECTO_FORMACION", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_PROYECTO_FORMACION() As Decimal
        Get
            Return _ID_PROYECTO_FORMACION
        End Get
        Set(ByVal Value As Decimal)
            _ID_PROYECTO_FORMACION = Value
            OnPropertyChanged("ID_PROYECTO_FORMACION")
        End Set
    End Property 

    Private _NOMBRE_PROYECTO_FORMACION As String
    <Column(Name:="Nombre proyecto formacion", Storage:="NOMBRE_PROYECTO_FORMACION", DbType:="VARCHAR2(255) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 255)> _
    Public Property NOMBRE_PROYECTO_FORMACION() As String
        Get
            Return _NOMBRE_PROYECTO_FORMACION
        End Get
        Set(ByVal Value As String)
            _NOMBRE_PROYECTO_FORMACION = Value
            OnPropertyChanged("NOMBRE_PROYECTO_FORMACION")
        End Set
    End Property 

    Private _NOMBRE_PROYECTO_FORMACIONOld As String
    Public Property NOMBRE_PROYECTO_FORMACIONOld() As String
        Get
            Return _NOMBRE_PROYECTO_FORMACIONOld
        End Get
        Set(ByVal Value As String)
            _NOMBRE_PROYECTO_FORMACIONOld = Value
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

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
