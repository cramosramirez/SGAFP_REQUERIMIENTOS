''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.ROL_PROGRAMA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row ROL_PROGRAMA en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	17/12/2012	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="ROL_PROGRAMA")> Public Class ROL_PROGRAMA
    Inherits entidadBase
    Implements IEquatable(Of ROL_PROGRAMA), IComparable(Of ROL_PROGRAMA)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_ROL_PROGRAMA As Decimal, aROL_USUARIO As String, aID_PROGRAMA_FORMACION As Decimal, aUSERID As String, aLASTUPDATE As DateTime)
        Me._ID_ROL_PROGRAMA = aID_ROL_PROGRAMA
        Me._ROL_USUARIO = aROL_USUARIO
        Me._ID_PROGRAMA_FORMACION = aID_PROGRAMA_FORMACION
        Me._USERID = aUSERID
        Me._LASTUPDATE = aLASTUPDATE
    End Sub

    Public Function Equals1(ByVal other As ROL_PROGRAMA) As Boolean Implements System.IEquatable(Of ROL_PROGRAMA).Equals
        Return Me.ID_ROL_PROGRAMA = other.ID_ROL_PROGRAMA
    End Function

    Public Function CompareTo(ByVal other As ROL_PROGRAMA) As Integer Implements System.IComparable(Of ROL_PROGRAMA).CompareTo
        If Me.ID_ROL_PROGRAMA > other.ID_ROL_PROGRAMA Then Return 1
        If Me.ID_ROL_PROGRAMA < other.ID_ROL_PROGRAMA Then Return -1
        Return 0
    End Function


#Region " Properties "

    Private _ID_ROL_PROGRAMA As Decimal
    <Column(Name:="Id rol programa", Storage:="ID_ROL_PROGRAMA", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_ROL_PROGRAMA() As Decimal
        Get
            Return _ID_ROL_PROGRAMA
        End Get
        Set(ByVal Value As Decimal)
            _ID_ROL_PROGRAMA = Value
            OnPropertyChanged("ID_ROL_PROGRAMA")
        End Set
    End Property 

    Private _ROL_USUARIO As String
    <Column(Name:="Rol usuario", Storage:="ROL_USUARIO", DbType:="VARCHAR2(200) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 200)> _
    Public Property ROL_USUARIO() As String
        Get
            Return _ROL_USUARIO
        End Get
        Set(ByVal Value As String)
            _ROL_USUARIO = Value
            OnPropertyChanged("ROL_USUARIO")
        End Set
    End Property 

    Private _ROL_USUARIOOld As String
    Public Property ROL_USUARIOOld() As String
        Get
            Return _ROL_USUARIOOld
        End Get
        Set(ByVal Value As String)
            _ROL_USUARIOOld = Value
        End Set
    End Property 

    Private _ID_PROGRAMA_FORMACION As Decimal
    <Column(Name:="Id programa formacion", Storage:="ID_PROGRAMA_FORMACION", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_PROGRAMA_FORMACION() As Decimal
        Get
            Return _ID_PROGRAMA_FORMACION
        End Get
        Set(ByVal Value As Decimal)
            _ID_PROGRAMA_FORMACION = Value
            OnPropertyChanged("ID_PROGRAMA_FORMACION")
        End Set
    End Property 

    Private _ID_PROGRAMA_FORMACIONOld As Decimal
    Public Property ID_PROGRAMA_FORMACIONOld() As Decimal
        Get
            Return _ID_PROGRAMA_FORMACIONOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_PROGRAMA_FORMACIONOld = Value
        End Set
    End Property 

    Private _fkID_PROGRAMA_FORMACION As PROGRAMA_FORMACION
    Public Property fkID_PROGRAMA_FORMACION() As PROGRAMA_FORMACION
        Get
            Return _fkID_PROGRAMA_FORMACION
        End Get
        Set(ByVal Value As PROGRAMA_FORMACION)
            _fkID_PROGRAMA_FORMACION = Value
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
