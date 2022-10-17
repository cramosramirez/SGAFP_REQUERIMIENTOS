''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.CATCURSO_2
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite tener un registro de la tabla CATCURSO_2 en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="CATCURSO_2")> Public Class CATCURSO_2
    Inherits entidadBase
    Implements IEquatable(Of CATCURSO_2), IComparable(Of CATCURSO_2)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_CURSO As Decimal, aNOMBRE As String, aDURACION As Decimal)
        Me._ID_CURSO = aID_CURSO
        Me._NOMBRE = aNOMBRE
        Me._DURACION = aDURACION
    End Sub

    Public Function Equals1(ByVal other As CATCURSO_2) As Boolean Implements System.IEquatable(Of CATCURSO_2).Equals
        Return Me.ID_CURSO = other.ID_CURSO
    End Function

    Public Function CompareTo(ByVal other As CATCURSO_2) As Integer Implements System.IComparable(Of CATCURSO_2).CompareTo
        If Me.ID_CURSO > other.ID_CURSO Then Return 1
        If Me.ID_CURSO < other.ID_CURSO Then Return -1
        Return 0
    End Function


#Region " Propiedades "

    Private _ID_CURSO As Decimal
    <Column(Name:="Id curso", Storage:="ID_CURSO", DbType:="FLOAT", Id:=True), _
     DataObjectField(True, True, True), Precision(Precision:=126, Scale:=0)> _
    Public Property ID_CURSO() As Decimal
        Get
            Return _ID_CURSO
        End Get
        Set(ByVal Value As Decimal)
            _ID_CURSO = Value
            OnPropertyChanged("ID_CURSO")
        End Set
    End Property 

    Private _NOMBRE As String
    <Column(Name:="Nombre", Storage:="NOMBRE", DbType:="VARCHAR2(139)", Id:=False), _
     DataObjectField(False, False, True, 139)> _
    Public Property NOMBRE() As String
        Get
            Return _NOMBRE
        End Get
        Set(ByVal Value As String)
            _NOMBRE = Value
            OnPropertyChanged("NOMBRE")
        End Set
    End Property 

    Private _NOMBREOld As String
    Public Property NOMBREOld() As String
        Get
            Return _NOMBREOld
        End Get
        Set(ByVal Value As String)
            _NOMBREOld = Value
        End Set
    End Property 

    Private _DURACION As Decimal
    <Column(Name:="Duracion", Storage:="DURACION", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=5, Scale:=0)> _
    Public Property DURACION() As Decimal
        Get
            Return _DURACION
        End Get
        Set(ByVal Value As Decimal)
            _DURACION = Value
            OnPropertyChanged("DURACION")
        End Set
    End Property 

    Private _DURACIONOld As Decimal
    Public Property DURACIONOld() As Decimal
        Get
            Return _DURACIONOld
        End Get
        Set(ByVal Value As Decimal)
            _DURACIONOld = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
