''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.TIEMPO_DEJO_ESTUDIAR
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row TIEMPO_DEJO_ESTUDIAR en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	19/01/2011	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="TIEMPO_DEJO_ESTUDIAR")> Public Class TIEMPO_DEJO_ESTUDIAR
    Inherits entidadBase
    Implements IEquatable(Of TIEMPO_DEJO_ESTUDIAR), IComparable(Of TIEMPO_DEJO_ESTUDIAR)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_TIEMPO_DEJO_ESTUDIAR As Decimal, aNOMBRE_TIEMPO_DEJO_ESTUDIAR As String)
        Me._ID_TIEMPO_DEJO_ESTUDIAR = aID_TIEMPO_DEJO_ESTUDIAR
        Me._NOMBRE_TIEMPO_DEJO_ESTUDIAR = aNOMBRE_TIEMPO_DEJO_ESTUDIAR
    End Sub

    Public Function Equals1(ByVal other As TIEMPO_DEJO_ESTUDIAR) As Boolean Implements System.IEquatable(Of TIEMPO_DEJO_ESTUDIAR).Equals
        Return Me.ID_TIEMPO_DEJO_ESTUDIAR = other.ID_TIEMPO_DEJO_ESTUDIAR
    End Function

    Public Function CompareTo(ByVal other As TIEMPO_DEJO_ESTUDIAR) As Integer Implements System.IComparable(Of TIEMPO_DEJO_ESTUDIAR).CompareTo
        If Me.ID_TIEMPO_DEJO_ESTUDIAR > other.ID_TIEMPO_DEJO_ESTUDIAR Then Return 1
        If Me.ID_TIEMPO_DEJO_ESTUDIAR < other.ID_TIEMPO_DEJO_ESTUDIAR Then Return -1
        Return 0
    End Function


#Region " Properties "

    Private _ID_TIEMPO_DEJO_ESTUDIAR As Decimal
    <Column(Name:="Id tiempo dejo estudiar", Storage:="ID_TIEMPO_DEJO_ESTUDIAR", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=2, Scale:=0)> _
    Public Property ID_TIEMPO_DEJO_ESTUDIAR() As Decimal
        Get
            Return _ID_TIEMPO_DEJO_ESTUDIAR
        End Get
        Set(ByVal Value As Decimal)
            _ID_TIEMPO_DEJO_ESTUDIAR = Value
            OnPropertyChanged("ID_TIEMPO_DEJO_ESTUDIAR")
        End Set
    End Property 

    Private _NOMBRE_TIEMPO_DEJO_ESTUDIAR As String
    <Column(Name:="Nombre tiempo dejo estudiar", Storage:="NOMBRE_TIEMPO_DEJO_ESTUDIAR", DbType:="VARCHAR2(20) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 20)> _
    Public Property NOMBRE_TIEMPO_DEJO_ESTUDIAR() As String
        Get
            Return _NOMBRE_TIEMPO_DEJO_ESTUDIAR
        End Get
        Set(ByVal Value As String)
            _NOMBRE_TIEMPO_DEJO_ESTUDIAR = Value
            OnPropertyChanged("NOMBRE_TIEMPO_DEJO_ESTUDIAR")
        End Set
    End Property 

    Private _NOMBRE_TIEMPO_DEJO_ESTUDIAROld As String
    Public Property NOMBRE_TIEMPO_DEJO_ESTUDIAROld() As String
        Get
            Return _NOMBRE_TIEMPO_DEJO_ESTUDIAROld
        End Get
        Set(ByVal Value As String)
            _NOMBRE_TIEMPO_DEJO_ESTUDIAROld = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
