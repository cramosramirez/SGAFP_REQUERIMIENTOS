''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.OPCION_MENU
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite tener un registro de la tabla OPCION_MENU en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="OPCION_MENU")> Public Class OPCION_MENU
    Inherits entidadBase
    Implements IEquatable(Of OPCION_MENU), IComparable(Of OPCION_MENU)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_OPCION_MENU As Decimal, aOPCION_MENU As String, aOPCION_SISTEMA As String, aURL As String, aPAGINA_HTML As String, aOBJETO_USUARIO As String, aNOTAS As String)
        Me._ID_OPCION_MENU = aID_OPCION_MENU
        Me._OPCION_MENU = aOPCION_MENU
        Me._OPCION_SISTEMA = aOPCION_SISTEMA
        Me._URL = aURL
        Me._PAGINA_HTML = aPAGINA_HTML
        Me._OBJETO_USUARIO = aOBJETO_USUARIO
        Me._NOTAS = aNOTAS
    End Sub

    Public Function Equals1(ByVal other As OPCION_MENU) As Boolean Implements System.IEquatable(Of OPCION_MENU).Equals
        Return Me.ID_OPCION_MENU = other.ID_OPCION_MENU
    End Function

    Public Function CompareTo(ByVal other As OPCION_MENU) As Integer Implements System.IComparable(Of OPCION_MENU).CompareTo
        If Me.ID_OPCION_MENU > other.ID_OPCION_MENU Then Return 1
        If Me.ID_OPCION_MENU < other.ID_OPCION_MENU Then Return -1
        Return 0
    End Function


#Region " Propiedades "

    Private _ID_OPCION_MENU As Decimal
    <Column(Name:="Id opcion menu", Storage:="ID_OPCION_MENU", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_OPCION_MENU() As Decimal
        Get
            Return _ID_OPCION_MENU
        End Get
        Set(ByVal Value As Decimal)
            _ID_OPCION_MENU = Value
            OnPropertyChanged("ID_OPCION_MENU")
        End Set
    End Property 

    Private _OPCION_MENU As String
    <Column(Name:="Opcion menu", Storage:="OPCION_MENU", DbType:="VARCHAR2(60)", Id:=False), _
     DataObjectField(False, False, True, 60)> _
    Public Property OPCION_MENU() As String
        Get
            Return _OPCION_MENU
        End Get
        Set(ByVal Value As String)
            _OPCION_MENU = Value
            OnPropertyChanged("OPCION_MENU")
        End Set
    End Property 

    Private _OPCION_MENUOld As String
    Public Property OPCION_MENUOld() As String
        Get
            Return _OPCION_MENUOld
        End Get
        Set(ByVal Value As String)
            _OPCION_MENUOld = Value
        End Set
    End Property 

    Private _OPCION_SISTEMA As String
    <Column(Name:="Opcion sistema", Storage:="OPCION_SISTEMA", DbType:="CHAR(1)", Id:=False), _
     DataObjectField(False, False, True, 1)> _
    Public Property OPCION_SISTEMA() As String
        Get
            Return _OPCION_SISTEMA
        End Get
        Set(ByVal Value As String)
            _OPCION_SISTEMA = Value
            OnPropertyChanged("OPCION_SISTEMA")
        End Set
    End Property 

    Private _OPCION_SISTEMAOld As String
    Public Property OPCION_SISTEMAOld() As String
        Get
            Return _OPCION_SISTEMAOld
        End Get
        Set(ByVal Value As String)
            _OPCION_SISTEMAOld = Value
        End Set
    End Property 

    Private _URL As String
    <Column(Name:="Url", Storage:="URL", DbType:="VARCHAR2(200)", Id:=False), _
     DataObjectField(False, False, True, 200)> _
    Public Property URL() As String
        Get
            Return _URL
        End Get
        Set(ByVal Value As String)
            _URL = Value
            OnPropertyChanged("URL")
        End Set
    End Property 

    Private _URLOld As String
    Public Property URLOld() As String
        Get
            Return _URLOld
        End Get
        Set(ByVal Value As String)
            _URLOld = Value
        End Set
    End Property 

    Private _PAGINA_HTML As String
    <Column(Name:="Pagina html", Storage:="PAGINA_HTML", DbType:="VARCHAR2(200)", Id:=False), _
     DataObjectField(False, False, True, 200)> _
    Public Property PAGINA_HTML() As String
        Get
            Return _PAGINA_HTML
        End Get
        Set(ByVal Value As String)
            _PAGINA_HTML = Value
            OnPropertyChanged("PAGINA_HTML")
        End Set
    End Property 

    Private _PAGINA_HTMLOld As String
    Public Property PAGINA_HTMLOld() As String
        Get
            Return _PAGINA_HTMLOld
        End Get
        Set(ByVal Value As String)
            _PAGINA_HTMLOld = Value
        End Set
    End Property 

    Private _OBJETO_USUARIO As String
    <Column(Name:="Objeto usuario", Storage:="OBJETO_USUARIO", DbType:="VARCHAR2(200)", Id:=False), _
     DataObjectField(False, False, True, 200)> _
    Public Property OBJETO_USUARIO() As String
        Get
            Return _OBJETO_USUARIO
        End Get
        Set(ByVal Value As String)
            _OBJETO_USUARIO = Value
            OnPropertyChanged("OBJETO_USUARIO")
        End Set
    End Property 

    Private _OBJETO_USUARIOOld As String
    Public Property OBJETO_USUARIOOld() As String
        Get
            Return _OBJETO_USUARIOOld
        End Get
        Set(ByVal Value As String)
            _OBJETO_USUARIOOld = Value
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
