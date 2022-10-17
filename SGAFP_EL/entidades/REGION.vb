''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.REGION
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite tener un registro de la tabla REGION en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="REGION")> Public Class REGION
    Inherits entidadBase
    Implements IEquatable(Of REGION), IComparable(Of REGION)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aCODIGO_REGION As String, aNOMBRE As String, aUSERID As String, aLASTUPDATE As DateTime)
        Me._CODIGO_REGION = aCODIGO_REGION
        Me._NOMBRE = aNOMBRE
        Me._USERID = aUSERID
        Me._LASTUPDATE = aLASTUPDATE
    End Sub

    Public Function Equals1(ByVal other As REGION) As Boolean Implements System.IEquatable(Of REGION).Equals
        Return Me.CODIGO_REGION = other.CODIGO_REGION
    End Function

    Public Function CompareTo(ByVal other As REGION) As Integer Implements System.IComparable(Of REGION).CompareTo
        If Me.CODIGO_REGION > other.CODIGO_REGION Then Return 1
        If Me.CODIGO_REGION < other.CODIGO_REGION Then Return -1
        Return 0
    End Function


#Region " Propiedades "

    Private _CODIGO_REGION As String
    <Column(Name:="Codigo region", Storage:="CODIGO_REGION", DbType:="VARCHAR2(2) NOT NULL", Id:=True), _
     DataObjectField(True, False, False, 2)> _
    Public Property CODIGO_REGION() As String
        Get
            Return _CODIGO_REGION
        End Get
        Set(ByVal Value As String)
            _CODIGO_REGION = Value
            OnPropertyChanged("CODIGO_REGION")
        End Set
    End Property 

    Private _NOMBRE As String
    <Column(Name:="Nombre", Storage:="NOMBRE", DbType:="VARCHAR2(20)", Id:=False), _
     DataObjectField(False, False, True, 20)> _
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

#End Region

#Region " Relaciones "
    Private _DEPARTAMENTOREGION As ListaDEPARTAMENTO
    Public Property DEPARTAMENTOREGION() As ListaDEPARTAMENTO
        Get
            Return _DEPARTAMENTOREGION
        End Get
        Set(ByVal Value As ListaDEPARTAMENTO)
            _DEPARTAMENTOREGION = Value
        End Set
    End Property 

#End Region
#End Region
End Class
