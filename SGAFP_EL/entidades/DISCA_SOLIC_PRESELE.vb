''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.DISCA_SOLIC_PRESELE
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row DISCA_SOLIC_PRESELE en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	09/04/2019	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="DISCA_SOLIC_PRESELE")> Public Class DISCA_SOLIC_PRESELE
    Inherits entidadBase
    Implements IEquatable(Of DISCA_SOLIC_PRESELE), IComparable(Of DISCA_SOLIC_PRESELE)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_DISCA_SOLIC As Decimal, aID_DISCAPACIDAD As Decimal, aID_SOLIC_PRESELEC As Decimal)
        Me._ID_DISCA_SOLIC = aID_DISCA_SOLIC
        Me._ID_DISCAPACIDAD = aID_DISCAPACIDAD
        Me._ID_SOLIC_PRESELEC = aID_SOLIC_PRESELEC
    End Sub

    Public Function Equals1(ByVal other As DISCA_SOLIC_PRESELE) As Boolean Implements System.IEquatable(Of DISCA_SOLIC_PRESELE).Equals
        Return Me.ID_DISCA_SOLIC = other.ID_DISCA_SOLIC
    End Function

    Public Function CompareTo(ByVal other As DISCA_SOLIC_PRESELE) As Integer Implements System.IComparable(Of DISCA_SOLIC_PRESELE).CompareTo
        If Me.ID_DISCA_SOLIC > other.ID_DISCA_SOLIC Then Return 1
        If Me.ID_DISCA_SOLIC < other.ID_DISCA_SOLIC Then Return -1
        Return 0
    End Function


#Region " Properties "

    Private _ID_DISCA_SOLIC As Decimal
    <Column(Name:="Id disca solic", Storage:="ID_DISCA_SOLIC", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_DISCA_SOLIC() As Decimal
        Get
            Return _ID_DISCA_SOLIC
        End Get
        Set(ByVal Value As Decimal)
            _ID_DISCA_SOLIC = Value
            OnPropertyChanged("ID_DISCA_SOLIC")
        End Set
    End Property 

    Private _ID_DISCAPACIDAD As Decimal
    <Column(Name:="Id discapacidad", Storage:="ID_DISCAPACIDAD", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=2, Scale:=0)> _
    Public Property ID_DISCAPACIDAD() As Decimal
        Get
            Return _ID_DISCAPACIDAD
        End Get
        Set(ByVal Value As Decimal)
            _ID_DISCAPACIDAD = Value
            OnPropertyChanged("ID_DISCAPACIDAD")
        End Set
    End Property 

    Private _ID_DISCAPACIDADOld As Decimal
    Public Property ID_DISCAPACIDADOld() As Decimal
        Get
            Return _ID_DISCAPACIDADOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_DISCAPACIDADOld = Value
        End Set
    End Property 

    Private _fkID_DISCAPACIDAD As DISCAPACIDAD
    Public Property fkID_DISCAPACIDAD() As DISCAPACIDAD
        Get
            Return _fkID_DISCAPACIDAD
        End Get
        Set(ByVal Value As DISCAPACIDAD)
            _fkID_DISCAPACIDAD = Value
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

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
