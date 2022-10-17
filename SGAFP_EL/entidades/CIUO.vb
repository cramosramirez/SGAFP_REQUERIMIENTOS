''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.CIUO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite tener un registro de la tabla CIUO en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="CIUO")> Public Class CIUO
    Inherits entidadBase
    Implements IEquatable(Of CIUO), IComparable(Of CIUO)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aCIUO As String, aDESCRIPCION As String, aDESCRIPCION_NACIONAL As String, aUSERID As String, aLASTUPDATE As DateTime)
        Me._CIUO = aCIUO
        Me._DESCRIPCION = aDESCRIPCION
        Me._DESCRIPCION_NACIONAL = aDESCRIPCION_NACIONAL
        Me._USERID = aUSERID
        Me._LASTUPDATE = aLASTUPDATE
    End Sub

    Public Function Equals1(ByVal other As CIUO) As Boolean Implements System.IEquatable(Of CIUO).Equals
        Return Me.CIUO = other.CIUO
    End Function

    Public Function CompareTo(ByVal other As CIUO) As Integer Implements System.IComparable(Of CIUO).CompareTo
        If Me.CIUO > other.CIUO Then Return 1
        If Me.CIUO < other.CIUO Then Return -1
        Return 0
    End Function


#Region " Propiedades "

    Private _CIUO As String
    <Column(Name:="Ciuo", Storage:="CIUO", DbType:="VARCHAR2(14) NOT NULL", Id:=True), _
     DataObjectField(True, False, False, 14)> _
    Public Property CIUO() As String
        Get
            Return _CIUO
        End Get
        Set(ByVal Value As String)
            _CIUO = Value
            OnPropertyChanged("CIUO")
        End Set
    End Property 

    Private _DESCRIPCION As String
    <Column(Name:="Descripcion", Storage:="DESCRIPCION", DbType:="VARCHAR2(200)", Id:=False), _
     DataObjectField(False, False, True, 200)> _
    Public Property DESCRIPCION() As String
        Get
            Return _DESCRIPCION
        End Get
        Set(ByVal Value As String)
            _DESCRIPCION = Value
            OnPropertyChanged("DESCRIPCION")
        End Set
    End Property 

    Private _DESCRIPCIONOld As String
    Public Property DESCRIPCIONOld() As String
        Get
            Return _DESCRIPCIONOld
        End Get
        Set(ByVal Value As String)
            _DESCRIPCIONOld = Value
        End Set
    End Property 

    Private _DESCRIPCION_NACIONAL As String
    <Column(Name:="Descripcion nacional", Storage:="DESCRIPCION_NACIONAL", DbType:="VARCHAR2(200)", Id:=False), _
     DataObjectField(False, False, True, 200)> _
    Public Property DESCRIPCION_NACIONAL() As String
        Get
            Return _DESCRIPCION_NACIONAL
        End Get
        Set(ByVal Value As String)
            _DESCRIPCION_NACIONAL = Value
            OnPropertyChanged("DESCRIPCION_NACIONAL")
        End Set
    End Property 

    Private _DESCRIPCION_NACIONALOld As String
    Public Property DESCRIPCION_NACIONALOld() As String
        Get
            Return _DESCRIPCION_NACIONALOld
        End Get
        Set(ByVal Value As String)
            _DESCRIPCION_NACIONALOld = Value
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
