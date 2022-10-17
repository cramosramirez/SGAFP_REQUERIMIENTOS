''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.TIPO_PENALIZA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row TIPO_PENALIZA en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	16/07/2018	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="TIPO_PENALIZA")> Public Class TIPO_PENALIZA
    Inherits entidadBase
    Implements IEquatable(Of TIPO_PENALIZA), IComparable(Of TIPO_PENALIZA)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_TIPO_PENA As Decimal, aNOMBRE As String)
        Me._ID_TIPO_PENA = aID_TIPO_PENA
        Me._NOMBRE = aNOMBRE
    End Sub

    Public Function Equals1(ByVal other As TIPO_PENALIZA) As Boolean Implements System.IEquatable(Of TIPO_PENALIZA).Equals
        Return Me.ID_TIPO_PENA = other.ID_TIPO_PENA
    End Function

    Public Function CompareTo(ByVal other As TIPO_PENALIZA) As Integer Implements System.IComparable(Of TIPO_PENALIZA).CompareTo
        If Me.ID_TIPO_PENA > other.ID_TIPO_PENA Then Return 1
        If Me.ID_TIPO_PENA < other.ID_TIPO_PENA Then Return -1
        Return 0
    End Function


#Region " Properties "

    Private _ID_TIPO_PENA As Decimal
    <Column(Name:="Id tipo pena", Storage:="ID_TIPO_PENA", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_TIPO_PENA() As Decimal
        Get
            Return _ID_TIPO_PENA
        End Get
        Set(ByVal Value As Decimal)
            _ID_TIPO_PENA = Value
            OnPropertyChanged("ID_TIPO_PENA")
        End Set
    End Property 

    Private _NOMBRE As String
    <Column(Name:="Nombre", Storage:="NOMBRE", DbType:="VARCHAR2(100) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 100)> _
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

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
