''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.TIPO_EMPLEO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row TIPO_EMPLEO en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	14/02/2011	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="TIPO_EMPLEO")> Public Class TIPO_EMPLEO
    Inherits entidadBase
    Implements IEquatable(Of TIPO_EMPLEO), IComparable(Of TIPO_EMPLEO)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_TIPO_EMPLEO As Decimal, aNOMBRE_TIPO_EMPLEO As String)
        Me._ID_TIPO_EMPLEO = aID_TIPO_EMPLEO
        Me._NOMBRE_TIPO_EMPLEO = aNOMBRE_TIPO_EMPLEO
    End Sub

    Public Function Equals1(ByVal other As TIPO_EMPLEO) As Boolean Implements System.IEquatable(Of TIPO_EMPLEO).Equals
        Return Me.ID_TIPO_EMPLEO = other.ID_TIPO_EMPLEO
    End Function

    Public Function CompareTo(ByVal other As TIPO_EMPLEO) As Integer Implements System.IComparable(Of TIPO_EMPLEO).CompareTo
        If Me.ID_TIPO_EMPLEO > other.ID_TIPO_EMPLEO Then Return 1
        If Me.ID_TIPO_EMPLEO < other.ID_TIPO_EMPLEO Then Return -1
        Return 0
    End Function


#Region " Properties "

    Private _ID_TIPO_EMPLEO As Decimal
    <Column(Name:="Id tipo empleo", Storage:="ID_TIPO_EMPLEO", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=2, Scale:=0)> _
    Public Property ID_TIPO_EMPLEO() As Decimal
        Get
            Return _ID_TIPO_EMPLEO
        End Get
        Set(ByVal Value As Decimal)
            _ID_TIPO_EMPLEO = Value
            OnPropertyChanged("ID_TIPO_EMPLEO")
        End Set
    End Property 

    Private _NOMBRE_TIPO_EMPLEO As String
    <Column(Name:="Nombre tipo empleo", Storage:="NOMBRE_TIPO_EMPLEO", DbType:="VARCHAR2(100) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 100)> _
    Public Property NOMBRE_TIPO_EMPLEO() As String
        Get
            Return _NOMBRE_TIPO_EMPLEO
        End Get
        Set(ByVal Value As String)
            _NOMBRE_TIPO_EMPLEO = Value
            OnPropertyChanged("NOMBRE_TIPO_EMPLEO")
        End Set
    End Property 

    Private _NOMBRE_TIPO_EMPLEOOld As String
    Public Property NOMBRE_TIPO_EMPLEOOld() As String
        Get
            Return _NOMBRE_TIPO_EMPLEOOld
        End Get
        Set(ByVal Value As String)
            _NOMBRE_TIPO_EMPLEOOld = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
