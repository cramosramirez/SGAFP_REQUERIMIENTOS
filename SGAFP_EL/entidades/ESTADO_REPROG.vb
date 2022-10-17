''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.ESTADO_REPROG
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite tener un registro de la tabla ESTADO_REPROG en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	01/06/2010	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="ESTADO_REPROG")> Public Class ESTADO_REPROG
    Inherits entidadBase
    Implements IEquatable(Of ESTADO_REPROG), IComparable(Of ESTADO_REPROG)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_ESTADO_REPROG As Decimal, aESTADO_REPROG As String, aNOTAS As String)
        Me._ID_ESTADO_REPROG = aID_ESTADO_REPROG
        Me._ESTADO_REPROG = aESTADO_REPROG
        Me._NOTAS = aNOTAS
    End Sub

    Public Function Equals1(ByVal other As ESTADO_REPROG) As Boolean Implements System.IEquatable(Of ESTADO_REPROG).Equals
        Return Me.ID_ESTADO_REPROG = other.ID_ESTADO_REPROG
    End Function

    Public Function CompareTo(ByVal other As ESTADO_REPROG) As Integer Implements System.IComparable(Of ESTADO_REPROG).CompareTo
        If Me.ID_ESTADO_REPROG > other.ID_ESTADO_REPROG Then Return 1
        If Me.ID_ESTADO_REPROG < other.ID_ESTADO_REPROG Then Return -1
        Return 0
    End Function


#Region " Propiedades "

    Private _ID_ESTADO_REPROG As Decimal
    <Column(Name:="Id estado reprog", Storage:="ID_ESTADO_REPROG", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_ESTADO_REPROG() As Decimal
        Get
            Return _ID_ESTADO_REPROG
        End Get
        Set(ByVal Value As Decimal)
            _ID_ESTADO_REPROG = Value
            OnPropertyChanged("ID_ESTADO_REPROG")
        End Set
    End Property 

    Private _ESTADO_REPROG As String
    <Column(Name:="Estado reprog", Storage:="ESTADO_REPROG", DbType:="VARCHAR2(100) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 100)> _
    Public Property ESTADO_REPROG() As String
        Get
            Return _ESTADO_REPROG
        End Get
        Set(ByVal Value As String)
            _ESTADO_REPROG = Value
            OnPropertyChanged("ESTADO_REPROG")
        End Set
    End Property 

    Private _ESTADO_REPROGOld As String
    Public Property ESTADO_REPROGOld() As String
        Get
            Return _ESTADO_REPROGOld
        End Get
        Set(ByVal Value As String)
            _ESTADO_REPROGOld = Value
        End Set
    End Property 

    Private _NOTAS As String
    <Column(Name:="Notas", Storage:="NOTAS", DbType:="VARCHAR2(255)", Id:=False), _
     DataObjectField(False, False, True, 255)> _
    Public Property NOTAS() As String
        Get
            Return _NOTAS
        End Get
        Set(ByVal Value As String)
            _NOTAS = Value
            OnPropertyChanged("NOTAS")
        End Set
    End Property 

    Private _NOTASOld As String
    Public Property NOTASOld() As String
        Get
            Return _NOTASOld
        End Get
        Set(ByVal Value As String)
            _NOTASOld = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
