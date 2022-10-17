''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.PAIS
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row PAIS en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	19/01/2011	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="PAIS")> Public Class PAIS
    Inherits entidadBase
    Implements IEquatable(Of PAIS), IComparable(Of PAIS)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_PAIS As Decimal, aNOMBRE_PAIS As String)
        Me._ID_PAIS = aID_PAIS
        Me._NOMBRE_PAIS = aNOMBRE_PAIS
    End Sub

    Public Function Equals1(ByVal other As PAIS) As Boolean Implements System.IEquatable(Of PAIS).Equals
        Return Me.ID_PAIS = other.ID_PAIS
    End Function

    Public Function CompareTo(ByVal other As PAIS) As Integer Implements System.IComparable(Of PAIS).CompareTo
        If Me.ID_PAIS > other.ID_PAIS Then Return 1
        If Me.ID_PAIS < other.ID_PAIS Then Return -1
        Return 0
    End Function


#Region " Properties "

    Private _ID_PAIS As Decimal
    <Column(Name:="Id pais", Storage:="ID_PAIS", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=3, Scale:=0)> _
    Public Property ID_PAIS() As Decimal
        Get
            Return _ID_PAIS
        End Get
        Set(ByVal Value As Decimal)
            _ID_PAIS = Value
            OnPropertyChanged("ID_PAIS")
        End Set
    End Property 

    Private _NOMBRE_PAIS As String
    <Column(Name:="Nombre pais", Storage:="NOMBRE_PAIS", DbType:="VARCHAR2(70) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 70)> _
    Public Property NOMBRE_PAIS() As String
        Get
            Return _NOMBRE_PAIS
        End Get
        Set(ByVal Value As String)
            _NOMBRE_PAIS = Value
            OnPropertyChanged("NOMBRE_PAIS")
        End Set
    End Property 

    Private _NOMBRE_PAISOld As String
    Public Property NOMBRE_PAISOld() As String
        Get
            Return _NOMBRE_PAISOld
        End Get
        Set(ByVal Value As String)
            _NOMBRE_PAISOld = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
