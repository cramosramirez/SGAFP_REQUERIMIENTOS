''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.TIEMPO_NOTRAB
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row TIEMPO_NOTRAB en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	08/04/2019	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="TIEMPO_NOTRAB")> Public Class TIEMPO_NOTRAB
    Inherits entidadBase
    Implements IEquatable(Of TIEMPO_NOTRAB), IComparable(Of TIEMPO_NOTRAB)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_TIEMPO_NOTRAB As Decimal, aNOMBRE_TIEMPO_NOTRAB As String)
        Me._ID_TIEMPO_NOTRAB = aID_TIEMPO_NOTRAB
        Me._NOMBRE_TIEMPO_NOTRAB = aNOMBRE_TIEMPO_NOTRAB
    End Sub

    Public Function Equals1(ByVal other As TIEMPO_NOTRAB) As Boolean Implements System.IEquatable(Of TIEMPO_NOTRAB).Equals
        Return Me.ID_TIEMPO_NOTRAB = other.ID_TIEMPO_NOTRAB
    End Function

    Public Function CompareTo(ByVal other As TIEMPO_NOTRAB) As Integer Implements System.IComparable(Of TIEMPO_NOTRAB).CompareTo
        If Me.ID_TIEMPO_NOTRAB > other.ID_TIEMPO_NOTRAB Then Return 1
        If Me.ID_TIEMPO_NOTRAB < other.ID_TIEMPO_NOTRAB Then Return -1
        Return 0
    End Function


#Region " Properties "

    Private _ID_TIEMPO_NOTRAB As Decimal
    <Column(Name:="Id tiempo notrab", Storage:="ID_TIEMPO_NOTRAB", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_TIEMPO_NOTRAB() As Decimal
        Get
            Return _ID_TIEMPO_NOTRAB
        End Get
        Set(ByVal Value As Decimal)
            _ID_TIEMPO_NOTRAB = Value
            OnPropertyChanged("ID_TIEMPO_NOTRAB")
        End Set
    End Property 

    Private _NOMBRE_TIEMPO_NOTRAB As String
    <Column(Name:="Nombre tiempo notrab", Storage:="NOMBRE_TIEMPO_NOTRAB", DbType:="VARCHAR2(100) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 100)> _
    Public Property NOMBRE_TIEMPO_NOTRAB() As String
        Get
            Return _NOMBRE_TIEMPO_NOTRAB
        End Get
        Set(ByVal Value As String)
            _NOMBRE_TIEMPO_NOTRAB = Value
            OnPropertyChanged("NOMBRE_TIEMPO_NOTRAB")
        End Set
    End Property 

    Private _NOMBRE_TIEMPO_NOTRABOld As String
    Public Property NOMBRE_TIEMPO_NOTRABOld() As String
        Get
            Return _NOMBRE_TIEMPO_NOTRABOld
        End Get
        Set(ByVal Value As String)
            _NOMBRE_TIEMPO_NOTRABOld = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
