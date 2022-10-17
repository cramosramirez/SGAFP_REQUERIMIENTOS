''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.METODO_EVALUACION
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite tener un registro de la tabla METODO_EVALUACION en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="METODO_EVALUACION")> Public Class METODO_EVALUACION
    Inherits entidadBase
    Implements IEquatable(Of METODO_EVALUACION), IComparable(Of METODO_EVALUACION)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_METODO_EVALUACION As Decimal, aMETODO_EVALUACION As String, aNOTAS As String)
        Me._ID_METODO_EVALUACION = aID_METODO_EVALUACION
        Me._METODO_EVALUACION = aMETODO_EVALUACION
        Me._NOTAS = aNOTAS
    End Sub

    Public Function Equals1(ByVal other As METODO_EVALUACION) As Boolean Implements System.IEquatable(Of METODO_EVALUACION).Equals
        Return Me.ID_METODO_EVALUACION = other.ID_METODO_EVALUACION
    End Function

    Public Function CompareTo(ByVal other As METODO_EVALUACION) As Integer Implements System.IComparable(Of METODO_EVALUACION).CompareTo
        If Me.ID_METODO_EVALUACION > other.ID_METODO_EVALUACION Then Return 1
        If Me.ID_METODO_EVALUACION < other.ID_METODO_EVALUACION Then Return -1
        Return 0
    End Function


#Region " Propiedades "

    Private _ID_METODO_EVALUACION As Decimal
    <Column(Name:="Id metodo evaluacion", Storage:="ID_METODO_EVALUACION", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_METODO_EVALUACION() As Decimal
        Get
            Return _ID_METODO_EVALUACION
        End Get
        Set(ByVal Value As Decimal)
            _ID_METODO_EVALUACION = Value
            OnPropertyChanged("ID_METODO_EVALUACION")
        End Set
    End Property 

    Private _METODO_EVALUACION As String
    <Column(Name:="Metodo evaluacion", Storage:="METODO_EVALUACION", DbType:="VARCHAR2(100)", Id:=False), _
     DataObjectField(False, False, True, 100)> _
    Public Property METODO_EVALUACION() As String
        Get
            Return _METODO_EVALUACION
        End Get
        Set(ByVal Value As String)
            _METODO_EVALUACION = Value
            OnPropertyChanged("METODO_EVALUACION")
        End Set
    End Property 

    Private _METODO_EVALUACIONOld As String
    Public Property METODO_EVALUACIONOld() As String
        Get
            Return _METODO_EVALUACIONOld
        End Get
        Set(ByVal Value As String)
            _METODO_EVALUACIONOld = Value
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
