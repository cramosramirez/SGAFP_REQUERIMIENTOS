''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.EJERCICIO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite tener un registro de la tabla EJERCICIO en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="EJERCICIO")> Public Class EJERCICIO
    Inherits entidadBase
    Implements IEquatable(Of EJERCICIO), IComparable(Of EJERCICIO)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_EJERCICIO As String, aETIQUETA As String, aFECHA_INICIO As DateTime, aFECHA_FIN As DateTime, aNOTAS As String)
        Me._ID_EJERCICIO = aID_EJERCICIO
        Me._ETIQUETA = aETIQUETA
        Me._FECHA_INICIO = aFECHA_INICIO
        Me._FECHA_FIN = aFECHA_FIN
        Me._NOTAS = aNOTAS
    End Sub

    Public Function Equals1(ByVal other As EJERCICIO) As Boolean Implements System.IEquatable(Of EJERCICIO).Equals
        Return Me.ID_EJERCICIO = other.ID_EJERCICIO
    End Function

    Public Function CompareTo(ByVal other As EJERCICIO) As Integer Implements System.IComparable(Of EJERCICIO).CompareTo
        If Me.ID_EJERCICIO > other.ID_EJERCICIO Then Return 1
        If Me.ID_EJERCICIO < other.ID_EJERCICIO Then Return -1
        Return 0
    End Function


#Region " Propiedades "

    Private _ID_EJERCICIO As String
    <Column(Name:="Id ejercicio", Storage:="ID_EJERCICIO", DbType:="CHAR(4) NOT NULL", Id:=True), _
     DataObjectField(True, False, False, 4)> _
    Public Property ID_EJERCICIO() As String
        Get
            Return _ID_EJERCICIO
        End Get
        Set(ByVal Value As String)
            _ID_EJERCICIO = Value
            OnPropertyChanged("ID_EJERCICIO")
        End Set
    End Property 

    Private _ETIQUETA As String
    <Column(Name:="Etiqueta", Storage:="ETIQUETA", DbType:="VARCHAR2(20)", Id:=False), _
     DataObjectField(False, False, True, 20)> _
    Public Property ETIQUETA() As String
        Get
            Return _ETIQUETA
        End Get
        Set(ByVal Value As String)
            _ETIQUETA = Value
            OnPropertyChanged("ETIQUETA")
        End Set
    End Property 

    Private _ETIQUETAOld As String
    Public Property ETIQUETAOld() As String
        Get
            Return _ETIQUETAOld
        End Get
        Set(ByVal Value As String)
            _ETIQUETAOld = Value
        End Set
    End Property 

    Private _FECHA_INICIO As DateTime
    <Column(Name:="Fecha inicio", Storage:="FECHA_INICIO", DbType:="DATE", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property FECHA_INICIO() As DateTime
        Get
            Return _FECHA_INICIO
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_INICIO = Value
            OnPropertyChanged("FECHA_INICIO")
        End Set
    End Property 

    Private _FECHA_INICIOOld As DateTime
    Public Property FECHA_INICIOOld() As DateTime
        Get
            Return _FECHA_INICIOOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_INICIOOld = Value
        End Set
    End Property 

    Private _FECHA_FIN As DateTime
    <Column(Name:="Fecha fin", Storage:="FECHA_FIN", DbType:="DATE", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property FECHA_FIN() As DateTime
        Get
            Return _FECHA_FIN
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_FIN = Value
            OnPropertyChanged("FECHA_FIN")
        End Set
    End Property 

    Private _FECHA_FINOld As DateTime
    Public Property FECHA_FINOld() As DateTime
        Get
            Return _FECHA_FINOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_FINOld = Value
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
