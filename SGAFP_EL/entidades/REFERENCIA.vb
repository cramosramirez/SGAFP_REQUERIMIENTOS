''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.REFERENCIA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row REFERENCIA en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	19/01/2011	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="REFERENCIA")> Public Class REFERENCIA
    Inherits entidadBase
    Implements IEquatable(Of REFERENCIA), IComparable(Of REFERENCIA)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_REFERENCIA As Decimal, aNOMBRE_REFERENCIA As String)
        Me._ID_REFERENCIA = aID_REFERENCIA
        Me._NOMBRE_REFERENCIA = aNOMBRE_REFERENCIA
    End Sub

    Public Function Equals1(ByVal other As REFERENCIA) As Boolean Implements System.IEquatable(Of REFERENCIA).Equals
        Return Me.ID_REFERENCIA = other.ID_REFERENCIA
    End Function

    Public Function CompareTo(ByVal other As REFERENCIA) As Integer Implements System.IComparable(Of REFERENCIA).CompareTo
        If Me.ID_REFERENCIA > other.ID_REFERENCIA Then Return 1
        If Me.ID_REFERENCIA < other.ID_REFERENCIA Then Return -1
        Return 0
    End Function


#Region " Properties "

    Private _ID_REFERENCIA As Decimal
    <Column(Name:="Id referencia", Storage:="ID_REFERENCIA", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=3, Scale:=0)> _
    Public Property ID_REFERENCIA() As Decimal
        Get
            Return _ID_REFERENCIA
        End Get
        Set(ByVal Value As Decimal)
            _ID_REFERENCIA = Value
            OnPropertyChanged("ID_REFERENCIA")
        End Set
    End Property 

    Private _NOMBRE_REFERENCIA As String
    <Column(Name:="Nombre referencia", Storage:="NOMBRE_REFERENCIA", DbType:="VARCHAR2(30) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 30)> _
    Public Property NOMBRE_REFERENCIA() As String
        Get
            Return _NOMBRE_REFERENCIA
        End Get
        Set(ByVal Value As String)
            _NOMBRE_REFERENCIA = Value
            OnPropertyChanged("NOMBRE_REFERENCIA")
        End Set
    End Property 

    Private _NOMBRE_REFERENCIAOld As String
    Public Property NOMBRE_REFERENCIAOld() As String
        Get
            Return _NOMBRE_REFERENCIAOld
        End Get
        Set(ByVal Value As String)
            _NOMBRE_REFERENCIAOld = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
