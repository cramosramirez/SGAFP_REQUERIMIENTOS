''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.LISTA_SUPERVISION_AF
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite tener un registro de la tabla LISTA_SUPERVISION_AF en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="LISTA_SUPERVISION_AF")> Public Class LISTA_SUPERVISION_AF
    Inherits entidadBase
    Implements IEquatable(Of LISTA_SUPERVISION_AF), IComparable(Of LISTA_SUPERVISION_AF)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_LISTA_SUPERVISION As Decimal, aLISTA_SUPERVISION As String, aNOTAS As String)
        Me._ID_LISTA_SUPERVISION = aID_LISTA_SUPERVISION
        Me._LISTA_SUPERVISION = aLISTA_SUPERVISION
        Me._NOTAS = aNOTAS
    End Sub

    Public Function Equals1(ByVal other As LISTA_SUPERVISION_AF) As Boolean Implements System.IEquatable(Of LISTA_SUPERVISION_AF).Equals
        Return Me.ID_LISTA_SUPERVISION = other.ID_LISTA_SUPERVISION
    End Function

    Public Function CompareTo(ByVal other As LISTA_SUPERVISION_AF) As Integer Implements System.IComparable(Of LISTA_SUPERVISION_AF).CompareTo
        If Me.ID_LISTA_SUPERVISION > other.ID_LISTA_SUPERVISION Then Return 1
        If Me.ID_LISTA_SUPERVISION < other.ID_LISTA_SUPERVISION Then Return -1
        Return 0
    End Function


#Region " Propiedades "

    Private _ID_LISTA_SUPERVISION As Decimal
    <Column(Name:="Id lista supervision", Storage:="ID_LISTA_SUPERVISION", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_LISTA_SUPERVISION() As Decimal
        Get
            Return _ID_LISTA_SUPERVISION
        End Get
        Set(ByVal Value As Decimal)
            _ID_LISTA_SUPERVISION = Value
            OnPropertyChanged("ID_LISTA_SUPERVISION")
        End Set
    End Property 

    Private _LISTA_SUPERVISION As String
    <Column(Name:="Lista supervision", Storage:="LISTA_SUPERVISION", DbType:="VARCHAR2(100)", Id:=False), _
     DataObjectField(False, False, True, 100)> _
    Public Property LISTA_SUPERVISION() As String
        Get
            Return _LISTA_SUPERVISION
        End Get
        Set(ByVal Value As String)
            _LISTA_SUPERVISION = Value
            OnPropertyChanged("LISTA_SUPERVISION")
        End Set
    End Property 

    Private _LISTA_SUPERVISIONOld As String
    Public Property LISTA_SUPERVISIONOld() As String
        Get
            Return _LISTA_SUPERVISIONOld
        End Get
        Set(ByVal Value As String)
            _LISTA_SUPERVISIONOld = Value
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
