''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.CENTRO_RESPONSABILIDAD
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row CENTRO_RESPONSABILIDAD en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	05/10/2012	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="CENTRO_RESPONSABILIDAD")> Public Class CENTRO_RESPONSABILIDAD
    Inherits entidadBase
    Implements IEquatable(Of CENTRO_RESPONSABILIDAD), IComparable(Of CENTRO_RESPONSABILIDAD)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_CENTRO_RESPONSABILIDAD As Decimal, aID_CENTRO_RESPONSABILIDAD_PADR As Decimal, aCODIGO_CENTRO_RESPONSABILIDAD As String, aNOMBRE_CENTRO_RESPONSABILIDAD As String, aUSERID As String, aLASTUPDATE As DateTime)
        Me._ID_CENTRO_RESPONSABILIDAD = aID_CENTRO_RESPONSABILIDAD
        Me._ID_CENTRO_RESPONSABILIDAD_PADR = aID_CENTRO_RESPONSABILIDAD_PADR
        Me._CODIGO_CENTRO_RESPONSABILIDAD = aCODIGO_CENTRO_RESPONSABILIDAD
        Me._NOMBRE_CENTRO_RESPONSABILIDAD = aNOMBRE_CENTRO_RESPONSABILIDAD
        Me._USERID = aUSERID
        Me._LASTUPDATE = aLASTUPDATE
    End Sub

    Public Function Equals1(ByVal other As CENTRO_RESPONSABILIDAD) As Boolean Implements System.IEquatable(Of CENTRO_RESPONSABILIDAD).Equals
        Return Me.ID_CENTRO_RESPONSABILIDAD = other.ID_CENTRO_RESPONSABILIDAD
    End Function

    Public Function CompareTo(ByVal other As CENTRO_RESPONSABILIDAD) As Integer Implements System.IComparable(Of CENTRO_RESPONSABILIDAD).CompareTo
        If Me.ID_CENTRO_RESPONSABILIDAD > other.ID_CENTRO_RESPONSABILIDAD Then Return 1
        If Me.ID_CENTRO_RESPONSABILIDAD < other.ID_CENTRO_RESPONSABILIDAD Then Return -1
        Return 0
    End Function


#Region " Properties "

    Private _ID_CENTRO_RESPONSABILIDAD As Decimal
    <Column(Name:="Id centro responsabilidad", Storage:="ID_CENTRO_RESPONSABILIDAD", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_CENTRO_RESPONSABILIDAD() As Decimal
        Get
            Return _ID_CENTRO_RESPONSABILIDAD
        End Get
        Set(ByVal Value As Decimal)
            _ID_CENTRO_RESPONSABILIDAD = Value
            OnPropertyChanged("ID_CENTRO_RESPONSABILIDAD")
        End Set
    End Property 

    Private _ID_CENTRO_RESPONSABILIDAD_PADR As Decimal
    <Column(Name:="Id centro responsabilidad padr", Storage:="ID_CENTRO_RESPONSABILIDAD_PADR", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_CENTRO_RESPONSABILIDAD_PADR() As Decimal
        Get
            Return _ID_CENTRO_RESPONSABILIDAD_PADR
        End Get
        Set(ByVal Value As Decimal)
            _ID_CENTRO_RESPONSABILIDAD_PADR = Value
            OnPropertyChanged("ID_CENTRO_RESPONSABILIDAD_PADR")
        End Set
    End Property 

    Private _ID_CENTRO_RESPONSABILIDAD_PADROld As Decimal
    Public Property ID_CENTRO_RESPONSABILIDAD_PADROld() As Decimal
        Get
            Return _ID_CENTRO_RESPONSABILIDAD_PADROld
        End Get
        Set(ByVal Value As Decimal)
            _ID_CENTRO_RESPONSABILIDAD_PADROld = Value
        End Set
    End Property 

    Private _fkID_CENTRO_RESPONSABILIDAD_PADR As CENTRO_RESPONSABILIDAD
    Public Property fkID_CENTRO_RESPONSABILIDAD_PADR() As CENTRO_RESPONSABILIDAD
        Get
            Return _fkID_CENTRO_RESPONSABILIDAD_PADR
        End Get
        Set(ByVal Value As CENTRO_RESPONSABILIDAD)
            _fkID_CENTRO_RESPONSABILIDAD_PADR = Value
        End Set
    End Property 

    Private _CODIGO_CENTRO_RESPONSABILIDAD As String
    <Column(Name:="Codigo centro responsabilidad", Storage:="CODIGO_CENTRO_RESPONSABILIDAD", DbType:="VARCHAR2(10) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 10)> _
    Public Property CODIGO_CENTRO_RESPONSABILIDAD() As String
        Get
            Return _CODIGO_CENTRO_RESPONSABILIDAD
        End Get
        Set(ByVal Value As String)
            _CODIGO_CENTRO_RESPONSABILIDAD = Value
            OnPropertyChanged("CODIGO_CENTRO_RESPONSABILIDAD")
        End Set
    End Property 

    Private _CODIGO_CENTRO_RESPONSABILIDADOld As String
    Public Property CODIGO_CENTRO_RESPONSABILIDADOld() As String
        Get
            Return _CODIGO_CENTRO_RESPONSABILIDADOld
        End Get
        Set(ByVal Value As String)
            _CODIGO_CENTRO_RESPONSABILIDADOld = Value
        End Set
    End Property 

    Private _NOMBRE_CENTRO_RESPONSABILIDAD As String
    <Column(Name:="Nombre centro responsabilidad", Storage:="NOMBRE_CENTRO_RESPONSABILIDAD", DbType:="VARCHAR2(100) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 100)> _
    Public Property NOMBRE_CENTRO_RESPONSABILIDAD() As String
        Get
            Return _NOMBRE_CENTRO_RESPONSABILIDAD
        End Get
        Set(ByVal Value As String)
            _NOMBRE_CENTRO_RESPONSABILIDAD = Value
            OnPropertyChanged("NOMBRE_CENTRO_RESPONSABILIDAD")
        End Set
    End Property 

    Private _NOMBRE_CENTRO_RESPONSABILIDADOld As String
    Public Property NOMBRE_CENTRO_RESPONSABILIDADOld() As String
        Get
            Return _NOMBRE_CENTRO_RESPONSABILIDADOld
        End Get
        Set(ByVal Value As String)
            _NOMBRE_CENTRO_RESPONSABILIDADOld = Value
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
    Private _CENTRO_RESPONSABILIDAD_UNIDADCENTRO_RESPONSABILIDAD As ListaCENTRO_RESPONSABILIDAD_UNIDAD
    Public Property CENTRO_RESPONSABILIDAD_UNIDADCENTRO_RESPONSABILIDAD() As ListaCENTRO_RESPONSABILIDAD_UNIDAD
        Get
            Return _CENTRO_RESPONSABILIDAD_UNIDADCENTRO_RESPONSABILIDAD
        End Get
        Set(ByVal Value As ListaCENTRO_RESPONSABILIDAD_UNIDAD)
            _CENTRO_RESPONSABILIDAD_UNIDADCENTRO_RESPONSABILIDAD = Value
        End Set
    End Property 

#End Region
#End Region
End Class
