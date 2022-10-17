''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.CIUU
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite tener un registro de la tabla CIUU en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="CIUU")> Public Class CIUU
    Inherits entidadBase
    Implements IEquatable(Of CIUU), IComparable(Of CIUU)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aCIUU As String, aDESCRIPCION_CIIU As String, aUSERID As String, aLASTUPDATE As DateTime)
        Me._CIUU = aCIUU
        Me._DESCRIPCION_CIIU = aDESCRIPCION_CIIU
        Me._USERID = aUSERID
        Me._LASTUPDATE = aLASTUPDATE
    End Sub

    Public Function Equals1(ByVal other As CIUU) As Boolean Implements System.IEquatable(Of CIUU).Equals
        Return Me.CIUU = other.CIUU
    End Function

    Public Function CompareTo(ByVal other As CIUU) As Integer Implements System.IComparable(Of CIUU).CompareTo
        If Me.CIUU > other.CIUU Then Return 1
        If Me.CIUU < other.CIUU Then Return -1
        Return 0
    End Function


#Region " Propiedades "

    Private _CIUU As String
    <Column(Name:="Ciuu", Storage:="CIUU", DbType:="VARCHAR2(14) NOT NULL", Id:=True), _
     DataObjectField(True, False, False, 14)> _
    Public Property CIUU() As String
        Get
            Return _CIUU
        End Get
        Set(ByVal Value As String)
            _CIUU = Value
            OnPropertyChanged("CIUU")
        End Set
    End Property 

    Private _DESCRIPCION_CIIU As String
    <Column(Name:="Descripcion ciiu", Storage:="DESCRIPCION_CIIU", DbType:="VARCHAR2(250)", Id:=False), _
     DataObjectField(False, False, True, 250)> _
    Public Property DESCRIPCION_CIIU() As String
        Get
            Return _DESCRIPCION_CIIU
        End Get
        Set(ByVal Value As String)
            _DESCRIPCION_CIIU = Value
            OnPropertyChanged("DESCRIPCION_CIIU")
        End Set
    End Property 

    Private _DESCRIPCION_CIIUOld As String
    Public Property DESCRIPCION_CIIUOld() As String
        Get
            Return _DESCRIPCION_CIIUOld
        End Get
        Set(ByVal Value As String)
            _DESCRIPCION_CIIUOld = Value
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
