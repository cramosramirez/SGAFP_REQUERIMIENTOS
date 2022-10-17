''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.TIPO_ADJUDICACION
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row TIPO_ADJUDICACION en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	26/01/2018	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="TIPO_ADJUDICACION")> Public Class TIPO_ADJUDICACION
    Inherits entidadBase
    Implements IEquatable(Of TIPO_ADJUDICACION), IComparable(Of TIPO_ADJUDICACION)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_TIPO_ADJ As Decimal, aNOMBRE_ADJ As String)
        Me._ID_TIPO_ADJ = aID_TIPO_ADJ
        Me._NOMBRE_ADJ = aNOMBRE_ADJ
    End Sub

    Public Function Equals1(ByVal other As TIPO_ADJUDICACION) As Boolean Implements System.IEquatable(Of TIPO_ADJUDICACION).Equals
        Return Me.ID_TIPO_ADJ = other.ID_TIPO_ADJ
    End Function

    Public Function CompareTo(ByVal other As TIPO_ADJUDICACION) As Integer Implements System.IComparable(Of TIPO_ADJUDICACION).CompareTo
        If Me.ID_TIPO_ADJ > other.ID_TIPO_ADJ Then Return 1
        If Me.ID_TIPO_ADJ < other.ID_TIPO_ADJ Then Return -1
        Return 0
    End Function


#Region " Properties "

    Private _ID_TIPO_ADJ As Decimal
    <Column(Name:="Id tipo adj", Storage:="ID_TIPO_ADJ", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_TIPO_ADJ() As Decimal
        Get
            Return _ID_TIPO_ADJ
        End Get
        Set(ByVal Value As Decimal)
            _ID_TIPO_ADJ = Value
            OnPropertyChanged("ID_TIPO_ADJ")
        End Set
    End Property 

    Private _NOMBRE_ADJ As String
    <Column(Name:="Nombre adj", Storage:="NOMBRE_ADJ", DbType:="VARCHAR2(200) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 200)> _
    Public Property NOMBRE_ADJ() As String
        Get
            Return _NOMBRE_ADJ
        End Get
        Set(ByVal Value As String)
            _NOMBRE_ADJ = Value
            OnPropertyChanged("NOMBRE_ADJ")
        End Set
    End Property 

    Private _NOMBRE_ADJOld As String
    Public Property NOMBRE_ADJOld() As String
        Get
            Return _NOMBRE_ADJOld
        End Get
        Set(ByVal Value As String)
            _NOMBRE_ADJOld = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
