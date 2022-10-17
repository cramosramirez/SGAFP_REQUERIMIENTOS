''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.EDUC_LEE_ESCRIBE
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row EDUC_LEE_ESCRIBE en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	19/01/2011	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="EDUC_LEE_ESCRIBE")> Public Class EDUC_LEE_ESCRIBE
    Inherits entidadBase
    Implements IEquatable(Of EDUC_LEE_ESCRIBE), IComparable(Of EDUC_LEE_ESCRIBE)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_LEE_ESCRIBE As Decimal, aNOMBRE_LEE_ESCRIBE As String)
        Me._ID_LEE_ESCRIBE = aID_LEE_ESCRIBE
        Me._NOMBRE_LEE_ESCRIBE = aNOMBRE_LEE_ESCRIBE
    End Sub

    Public Function Equals1(ByVal other As EDUC_LEE_ESCRIBE) As Boolean Implements System.IEquatable(Of EDUC_LEE_ESCRIBE).Equals
        Return Me.ID_LEE_ESCRIBE = other.ID_LEE_ESCRIBE
    End Function

    Public Function CompareTo(ByVal other As EDUC_LEE_ESCRIBE) As Integer Implements System.IComparable(Of EDUC_LEE_ESCRIBE).CompareTo
        If Me.ID_LEE_ESCRIBE > other.ID_LEE_ESCRIBE Then Return 1
        If Me.ID_LEE_ESCRIBE < other.ID_LEE_ESCRIBE Then Return -1
        Return 0
    End Function


#Region " Properties "

    Private _ID_LEE_ESCRIBE As Decimal
    <Column(Name:="Id lee escribe", Storage:="ID_LEE_ESCRIBE", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=1, Scale:=0)> _
    Public Property ID_LEE_ESCRIBE() As Decimal
        Get
            Return _ID_LEE_ESCRIBE
        End Get
        Set(ByVal Value As Decimal)
            _ID_LEE_ESCRIBE = Value
            OnPropertyChanged("ID_LEE_ESCRIBE")
        End Set
    End Property 

    Private _NOMBRE_LEE_ESCRIBE As String
    <Column(Name:="Nombre lee escribe", Storage:="NOMBRE_LEE_ESCRIBE", DbType:="VARCHAR2(60) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 60)> _
    Public Property NOMBRE_LEE_ESCRIBE() As String
        Get
            Return _NOMBRE_LEE_ESCRIBE
        End Get
        Set(ByVal Value As String)
            _NOMBRE_LEE_ESCRIBE = Value
            OnPropertyChanged("NOMBRE_LEE_ESCRIBE")
        End Set
    End Property 

    Private _NOMBRE_LEE_ESCRIBEOld As String
    Public Property NOMBRE_LEE_ESCRIBEOld() As String
        Get
            Return _NOMBRE_LEE_ESCRIBEOld
        End Get
        Set(ByVal Value As String)
            _NOMBRE_LEE_ESCRIBEOld = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
