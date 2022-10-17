''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.SOLIC_PRESELE_EMPRE
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row SOLIC_PRESELE_EMPRE en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	09/04/2019	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="SOLIC_PRESELE_EMPRE")> Public Class SOLIC_PRESELE_EMPRE
    Inherits entidadBase
    Implements IEquatable(Of SOLIC_PRESELE_EMPRE), IComparable(Of SOLIC_PRESELE_EMPRE)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_EMPRESA As Decimal, aID_SOLIC_PRESELEC As Decimal, aNOMBRE_EMPRESA As String, aCARGO As String, aFUNCIONES As String, aDESDE_HASTA As String)
        Me._ID_EMPRESA = aID_EMPRESA
        Me._ID_SOLIC_PRESELEC = aID_SOLIC_PRESELEC
        Me._NOMBRE_EMPRESA = aNOMBRE_EMPRESA
        Me._CARGO = aCARGO
        Me._FUNCIONES = aFUNCIONES
        Me._DESDE_HASTA = aDESDE_HASTA
    End Sub

    Public Function Equals1(ByVal other As SOLIC_PRESELE_EMPRE) As Boolean Implements System.IEquatable(Of SOLIC_PRESELE_EMPRE).Equals
        Return Me.ID_EMPRESA = other.ID_EMPRESA
    End Function

    Public Function CompareTo(ByVal other As SOLIC_PRESELE_EMPRE) As Integer Implements System.IComparable(Of SOLIC_PRESELE_EMPRE).CompareTo
        If Me.ID_EMPRESA > other.ID_EMPRESA Then Return 1
        If Me.ID_EMPRESA < other.ID_EMPRESA Then Return -1
        Return 0
    End Function


#Region " Properties "

    Private _ID_EMPRESA As Decimal
    <Column(Name:="Id empresa", Storage:="ID_EMPRESA", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_EMPRESA() As Decimal
        Get
            Return _ID_EMPRESA
        End Get
        Set(ByVal Value As Decimal)
            _ID_EMPRESA = Value
            OnPropertyChanged("ID_EMPRESA")
        End Set
    End Property 

    Private _ID_SOLIC_PRESELEC As Decimal
    <Column(Name:="Id solic preselec", Storage:="ID_SOLIC_PRESELEC", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_SOLIC_PRESELEC() As Decimal
        Get
            Return _ID_SOLIC_PRESELEC
        End Get
        Set(ByVal Value As Decimal)
            _ID_SOLIC_PRESELEC = Value
            OnPropertyChanged("ID_SOLIC_PRESELEC")
        End Set
    End Property 

    Private _ID_SOLIC_PRESELECOld As Decimal
    Public Property ID_SOLIC_PRESELECOld() As Decimal
        Get
            Return _ID_SOLIC_PRESELECOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_SOLIC_PRESELECOld = Value
        End Set
    End Property 

    Private _fkID_SOLIC_PRESELEC As SOLICITUD_PRESELECCION_EC
    Public Property fkID_SOLIC_PRESELEC() As SOLICITUD_PRESELECCION_EC
        Get
            Return _fkID_SOLIC_PRESELEC
        End Get
        Set(ByVal Value As SOLICITUD_PRESELECCION_EC)
            _fkID_SOLIC_PRESELEC = Value
        End Set
    End Property 

    Private _NOMBRE_EMPRESA As String
    <Column(Name:="Nombre empresa", Storage:="NOMBRE_EMPRESA", DbType:="VARCHAR2(500) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 500)> _
    Public Property NOMBRE_EMPRESA() As String
        Get
            Return _NOMBRE_EMPRESA
        End Get
        Set(ByVal Value As String)
            _NOMBRE_EMPRESA = Value
            OnPropertyChanged("NOMBRE_EMPRESA")
        End Set
    End Property 

    Private _NOMBRE_EMPRESAOld As String
    Public Property NOMBRE_EMPRESAOld() As String
        Get
            Return _NOMBRE_EMPRESAOld
        End Get
        Set(ByVal Value As String)
            _NOMBRE_EMPRESAOld = Value
        End Set
    End Property 

    Private _CARGO As String
    <Column(Name:="Cargo", Storage:="CARGO", DbType:="VARCHAR2(200) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 200)> _
    Public Property CARGO() As String
        Get
            Return _CARGO
        End Get
        Set(ByVal Value As String)
            _CARGO = Value
            OnPropertyChanged("CARGO")
        End Set
    End Property 

    Private _CARGOOld As String
    Public Property CARGOOld() As String
        Get
            Return _CARGOOld
        End Get
        Set(ByVal Value As String)
            _CARGOOld = Value
        End Set
    End Property 

    Private _FUNCIONES As String
    <Column(Name:="Funciones", Storage:="FUNCIONES", DbType:="VARCHAR2(2000) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 2000)> _
    Public Property FUNCIONES() As String
        Get
            Return _FUNCIONES
        End Get
        Set(ByVal Value As String)
            _FUNCIONES = Value
            OnPropertyChanged("FUNCIONES")
        End Set
    End Property 

    Private _FUNCIONESOld As String
    Public Property FUNCIONESOld() As String
        Get
            Return _FUNCIONESOld
        End Get
        Set(ByVal Value As String)
            _FUNCIONESOld = Value
        End Set
    End Property 

    Private _DESDE_HASTA As String
    <Column(Name:="Desde hasta", Storage:="DESDE_HASTA", DbType:="VARCHAR2(2000) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 2000)> _
    Public Property DESDE_HASTA() As String
        Get
            Return _DESDE_HASTA
        End Get
        Set(ByVal Value As String)
            _DESDE_HASTA = Value
            OnPropertyChanged("DESDE_HASTA")
        End Set
    End Property 

    Private _DESDE_HASTAOld As String
    Public Property DESDE_HASTAOld() As String
        Get
            Return _DESDE_HASTAOld
        End Get
        Set(ByVal Value As String)
            _DESDE_HASTAOld = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
