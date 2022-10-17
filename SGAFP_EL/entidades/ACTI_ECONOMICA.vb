''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.ACTI_ECONOMICA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row ACTI_ECONOMICA en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	08/04/2019	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="ACTI_ECONOMICA")> Public Class ACTI_ECONOMICA
    Inherits entidadBase
    Implements IEquatable(Of ACTI_ECONOMICA), IComparable(Of ACTI_ECONOMICA)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_ACTI_ECONOMICA As Decimal, aNOMBRE_ACTI_ECONOMICA As String)
        Me._ID_ACTI_ECONOMICA = aID_ACTI_ECONOMICA
        Me._NOMBRE_ACTI_ECONOMICA = aNOMBRE_ACTI_ECONOMICA
    End Sub

    Public Function Equals1(ByVal other As ACTI_ECONOMICA) As Boolean Implements System.IEquatable(Of ACTI_ECONOMICA).Equals
        Return Me.ID_ACTI_ECONOMICA = other.ID_ACTI_ECONOMICA
    End Function

    Public Function CompareTo(ByVal other As ACTI_ECONOMICA) As Integer Implements System.IComparable(Of ACTI_ECONOMICA).CompareTo
        If Me.ID_ACTI_ECONOMICA > other.ID_ACTI_ECONOMICA Then Return 1
        If Me.ID_ACTI_ECONOMICA < other.ID_ACTI_ECONOMICA Then Return -1
        Return 0
    End Function


#Region " Properties "

    Private _ID_ACTI_ECONOMICA As Decimal
    <Column(Name:="Id acti economica", Storage:="ID_ACTI_ECONOMICA", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_ACTI_ECONOMICA() As Decimal
        Get
            Return _ID_ACTI_ECONOMICA
        End Get
        Set(ByVal Value As Decimal)
            _ID_ACTI_ECONOMICA = Value
            OnPropertyChanged("ID_ACTI_ECONOMICA")
        End Set
    End Property 

    Private _NOMBRE_ACTI_ECONOMICA As String
    <Column(Name:="Nombre acti economica", Storage:="NOMBRE_ACTI_ECONOMICA", DbType:="VARCHAR2(300) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 300)> _
    Public Property NOMBRE_ACTI_ECONOMICA() As String
        Get
            Return _NOMBRE_ACTI_ECONOMICA
        End Get
        Set(ByVal Value As String)
            _NOMBRE_ACTI_ECONOMICA = Value
            OnPropertyChanged("NOMBRE_ACTI_ECONOMICA")
        End Set
    End Property 

    Private _NOMBRE_ACTI_ECONOMICAOld As String
    Public Property NOMBRE_ACTI_ECONOMICAOld() As String
        Get
            Return _NOMBRE_ACTI_ECONOMICAOld
        End Get
        Set(ByVal Value As String)
            _NOMBRE_ACTI_ECONOMICAOld = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
