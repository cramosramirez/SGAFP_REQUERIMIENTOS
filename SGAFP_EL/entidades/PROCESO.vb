''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.PROCESO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite tener un registro de la tabla PROCESO en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="PROCESO")> Public Class PROCESO
    Inherits entidadBase
    Implements IEquatable(Of PROCESO), IComparable(Of PROCESO)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aCODIGO_PROCESO As String, aNOMBRE_PROCESO As String, aDURACION As Decimal, aUNIDAD_DE_TIEMPO As String, aUSERID As String, aLASTUPDATE As DateTime)
        Me._CODIGO_PROCESO = aCODIGO_PROCESO
        Me._NOMBRE_PROCESO = aNOMBRE_PROCESO
        Me._DURACION = aDURACION
        Me._UNIDAD_DE_TIEMPO = aUNIDAD_DE_TIEMPO
        Me._USERID = aUSERID
        Me._LASTUPDATE = aLASTUPDATE
    End Sub

    Public Function Equals1(ByVal other As PROCESO) As Boolean Implements System.IEquatable(Of PROCESO).Equals
        Return Me.CODIGO_PROCESO = other.CODIGO_PROCESO
    End Function

    Public Function CompareTo(ByVal other As PROCESO) As Integer Implements System.IComparable(Of PROCESO).CompareTo
        If Me.CODIGO_PROCESO > other.CODIGO_PROCESO Then Return 1
        If Me.CODIGO_PROCESO < other.CODIGO_PROCESO Then Return -1
        Return 0
    End Function


#Region " Propiedades "

    Private _CODIGO_PROCESO As String
    <Column(Name:="Codigo proceso", Storage:="CODIGO_PROCESO", DbType:="CHAR(2) NOT NULL", Id:=True), _
     DataObjectField(True, False, False, 2)> _
    Public Property CODIGO_PROCESO() As String
        Get
            Return _CODIGO_PROCESO
        End Get
        Set(ByVal Value As String)
            _CODIGO_PROCESO = Value
            OnPropertyChanged("CODIGO_PROCESO")
        End Set
    End Property 

    Private _NOMBRE_PROCESO As String
    <Column(Name:="Nombre proceso", Storage:="NOMBRE_PROCESO", DbType:="CHAR(50)", Id:=False), _
     DataObjectField(False, False, True, 50)> _
    Public Property NOMBRE_PROCESO() As String
        Get
            Return _NOMBRE_PROCESO
        End Get
        Set(ByVal Value As String)
            _NOMBRE_PROCESO = Value
            OnPropertyChanged("NOMBRE_PROCESO")
        End Set
    End Property 

    Private _NOMBRE_PROCESOOld As String
    Public Property NOMBRE_PROCESOOld() As String
        Get
            Return _NOMBRE_PROCESOOld
        End Get
        Set(ByVal Value As String)
            _NOMBRE_PROCESOOld = Value
        End Set
    End Property 

    Private _DURACION As Decimal
    <Column(Name:="Duracion", Storage:="DURACION", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=0, Scale:=0)> _
    Public Property DURACION() As Decimal
        Get
            Return _DURACION
        End Get
        Set(ByVal Value As Decimal)
            _DURACION = Value
            OnPropertyChanged("DURACION")
        End Set
    End Property 

    Private _DURACIONOld As Decimal
    Public Property DURACIONOld() As Decimal
        Get
            Return _DURACIONOld
        End Get
        Set(ByVal Value As Decimal)
            _DURACIONOld = Value
        End Set
    End Property 

    Private _UNIDAD_DE_TIEMPO As String
    <Column(Name:="Unidad de tiempo", Storage:="UNIDAD_DE_TIEMPO", DbType:="CHAR(1)", Id:=False), _
     DataObjectField(False, False, True, 1)> _
    Public Property UNIDAD_DE_TIEMPO() As String
        Get
            Return _UNIDAD_DE_TIEMPO
        End Get
        Set(ByVal Value As String)
            _UNIDAD_DE_TIEMPO = Value
            OnPropertyChanged("UNIDAD_DE_TIEMPO")
        End Set
    End Property 

    Private _UNIDAD_DE_TIEMPOOld As String
    Public Property UNIDAD_DE_TIEMPOOld() As String
        Get
            Return _UNIDAD_DE_TIEMPOOld
        End Get
        Set(ByVal Value As String)
            _UNIDAD_DE_TIEMPOOld = Value
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
    <Column(Name:="Lastupdate", Storage:="LASTUPDATE", DbType:="TIMESTAMP(6)(0,6)", Id:=False), _
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
    Private _ETAPAPROCESO As ListaETAPA
    Public Property ETAPAPROCESO() As ListaETAPA
        Get
            Return _ETAPAPROCESO
        End Get
        Set(ByVal Value As ListaETAPA)
            _ETAPAPROCESO = Value
        End Set
    End Property 

#End Region
#End Region
End Class
