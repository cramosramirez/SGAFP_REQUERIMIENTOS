''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.ESTADO_CIVIL
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row ESTADO_CIVIL en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	19/01/2011	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="ESTADO_CIVIL")> Public Class ESTADO_CIVIL
    Inherits entidadBase
    Implements IEquatable(Of ESTADO_CIVIL), IComparable(Of ESTADO_CIVIL)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_ESTADO_CIVIL As Decimal, aNOMBRE_ESTADO_CIVIL As String)
        Me._ID_ESTADO_CIVIL = aID_ESTADO_CIVIL
        Me._NOMBRE_ESTADO_CIVIL = aNOMBRE_ESTADO_CIVIL
    End Sub

    Public Function Equals1(ByVal other As ESTADO_CIVIL) As Boolean Implements System.IEquatable(Of ESTADO_CIVIL).Equals
        Return Me.ID_ESTADO_CIVIL = other.ID_ESTADO_CIVIL
    End Function

    Public Function CompareTo(ByVal other As ESTADO_CIVIL) As Integer Implements System.IComparable(Of ESTADO_CIVIL).CompareTo
        If Me.ID_ESTADO_CIVIL > other.ID_ESTADO_CIVIL Then Return 1
        If Me.ID_ESTADO_CIVIL < other.ID_ESTADO_CIVIL Then Return -1
        Return 0
    End Function


#Region " Properties "

    Private _ID_ESTADO_CIVIL As Decimal
    <Column(Name:="Id estado civil", Storage:="ID_ESTADO_CIVIL", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=1, Scale:=0)> _
    Public Property ID_ESTADO_CIVIL() As Decimal
        Get
            Return _ID_ESTADO_CIVIL
        End Get
        Set(ByVal Value As Decimal)
            _ID_ESTADO_CIVIL = Value
            OnPropertyChanged("ID_ESTADO_CIVIL")
        End Set
    End Property 

    Private _NOMBRE_ESTADO_CIVIL As String
    <Column(Name:="Nombre estado civil", Storage:="NOMBRE_ESTADO_CIVIL", DbType:="VARCHAR2(30) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 30)> _
    Public Property NOMBRE_ESTADO_CIVIL() As String
        Get
            Return _NOMBRE_ESTADO_CIVIL
        End Get
        Set(ByVal Value As String)
            _NOMBRE_ESTADO_CIVIL = Value
            OnPropertyChanged("NOMBRE_ESTADO_CIVIL")
        End Set
    End Property 

    Private _NOMBRE_ESTADO_CIVILOld As String
    Public Property NOMBRE_ESTADO_CIVILOld() As String
        Get
            Return _NOMBRE_ESTADO_CIVILOld
        End Get
        Set(ByVal Value As String)
            _NOMBRE_ESTADO_CIVILOld = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
