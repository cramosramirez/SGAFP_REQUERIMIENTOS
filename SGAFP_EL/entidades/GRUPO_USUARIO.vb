''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.GRUPO_USUARIO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite tener un registro de la tabla GRUPO_USUARIO en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="GRUPO_USUARIO")> Public Class GRUPO_USUARIO
    Inherits entidadBase
    Implements IEquatable(Of GRUPO_USUARIO), IComparable(Of GRUPO_USUARIO)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_GRUPO_USUARIO As Decimal, aROL_USUARIO As String, aNIVEL As Decimal, aNOTAS As String)
        Me._ID_GRUPO_USUARIO = aID_GRUPO_USUARIO
        Me._ROL_USUARIO = aROL_USUARIO
        Me._NIVEL = aNIVEL
        Me._NOTAS = aNOTAS
    End Sub

    Public Function Equals1(ByVal other As GRUPO_USUARIO) As Boolean Implements System.IEquatable(Of GRUPO_USUARIO).Equals
        Return Me.ID_GRUPO_USUARIO = other.ID_GRUPO_USUARIO
    End Function

    Public Function CompareTo(ByVal other As GRUPO_USUARIO) As Integer Implements System.IComparable(Of GRUPO_USUARIO).CompareTo
        If Me.ID_GRUPO_USUARIO > other.ID_GRUPO_USUARIO Then Return 1
        If Me.ID_GRUPO_USUARIO < other.ID_GRUPO_USUARIO Then Return -1
        Return 0
    End Function


#Region " Propiedades "

    Private _ID_GRUPO_USUARIO As Decimal
    <Column(Name:="Id grupo usuario", Storage:="ID_GRUPO_USUARIO", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_GRUPO_USUARIO() As Decimal
        Get
            Return _ID_GRUPO_USUARIO
        End Get
        Set(ByVal Value As Decimal)
            _ID_GRUPO_USUARIO = Value
            OnPropertyChanged("ID_GRUPO_USUARIO")
        End Set
    End Property 

    Private _ROL_USUARIO As String
    <Column(Name:="Rol usuario", Storage:="ROL_USUARIO", DbType:="VARCHAR2(40)", Id:=False), _
     DataObjectField(False, False, True, 40)> _
    Public Property ROL_USUARIO() As String
        Get
            Return _ROL_USUARIO
        End Get
        Set(ByVal Value As String)
            _ROL_USUARIO = Value
            OnPropertyChanged("ROL_USUARIO")
        End Set
    End Property 

    Private _ROL_USUARIOOld As String
    Public Property ROL_USUARIOOld() As String
        Get
            Return _ROL_USUARIOOld
        End Get
        Set(ByVal Value As String)
            _ROL_USUARIOOld = Value
        End Set
    End Property 

    Private _NIVEL As Decimal
    <Column(Name:="Nivel", Storage:="NIVEL", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=0, Scale:=0)> _
    Public Property NIVEL() As Decimal
        Get
            Return _NIVEL
        End Get
        Set(ByVal Value As Decimal)
            _NIVEL = Value
            OnPropertyChanged("NIVEL")
        End Set
    End Property 

    Private _NIVELOld As Decimal
    Public Property NIVELOld() As Decimal
        Get
            Return _NIVELOld
        End Get
        Set(ByVal Value As Decimal)
            _NIVELOld = Value
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
