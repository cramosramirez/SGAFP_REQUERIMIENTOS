''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.TIPO_SELECC
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row TIPO_SELECC en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	08/04/2019	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="TIPO_SELECC")> Public Class TIPO_SELECC
    Inherits entidadBase
    Implements IEquatable(Of TIPO_SELECC), IComparable(Of TIPO_SELECC)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_TIPO_SELECC As Decimal, aNOMBRE As String)
        Me._ID_TIPO_SELECC = aID_TIPO_SELECC
        Me._NOMBRE = aNOMBRE
    End Sub

    Public Function Equals1(ByVal other As TIPO_SELECC) As Boolean Implements System.IEquatable(Of TIPO_SELECC).Equals
        Return Me.ID_TIPO_SELECC = other.ID_TIPO_SELECC
    End Function

    Public Function CompareTo(ByVal other As TIPO_SELECC) As Integer Implements System.IComparable(Of TIPO_SELECC).CompareTo
        If Me.ID_TIPO_SELECC > other.ID_TIPO_SELECC Then Return 1
        If Me.ID_TIPO_SELECC < other.ID_TIPO_SELECC Then Return -1
        Return 0
    End Function


#Region " Properties "

    Private _ID_TIPO_SELECC As Decimal
    <Column(Name:="Id tipo selecc", Storage:="ID_TIPO_SELECC", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_TIPO_SELECC() As Decimal
        Get
            Return _ID_TIPO_SELECC
        End Get
        Set(ByVal Value As Decimal)
            _ID_TIPO_SELECC = Value
            OnPropertyChanged("ID_TIPO_SELECC")
        End Set
    End Property 

    Private _NOMBRE As String
    <Column(Name:="Nombre", Storage:="NOMBRE", DbType:="VARCHAR2(50)", Id:=False), _
     DataObjectField(False, False, True, 50)> _
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
