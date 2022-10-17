''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.FASE
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite tener un registro de la tabla FASE en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	08/07/2010	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="FASE")> Public Class FASE
    Inherits entidadBase
    Implements IEquatable(Of FASE), IComparable(Of FASE)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_FASE As Decimal, aNOMBRE_FASE As String)
        Me._ID_FASE = aID_FASE
        Me._NOMBRE_FASE = aNOMBRE_FASE
    End Sub

    Public Function Equals1(ByVal other As FASE) As Boolean Implements System.IEquatable(Of FASE).Equals
        Return Me.ID_FASE = other.ID_FASE
    End Function

    Public Function CompareTo(ByVal other As FASE) As Integer Implements System.IComparable(Of FASE).CompareTo
        If Me.ID_FASE > other.ID_FASE Then Return 1
        If Me.ID_FASE < other.ID_FASE Then Return -1
        Return 0
    End Function


#Region " Propiedades "

    Private _ID_FASE As Decimal
    <Column(Name:="Id fase", Storage:="ID_FASE", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_FASE() As Decimal
        Get
            Return _ID_FASE
        End Get
        Set(ByVal Value As Decimal)
            _ID_FASE = Value
            OnPropertyChanged("ID_FASE")
        End Set
    End Property 

    Private _NOMBRE_FASE As String
    <Column(Name:="Nombre fase", Storage:="NOMBRE_FASE", DbType:="VARCHAR2(250)", Id:=False), _
     DataObjectField(False, False, True, 250)> _
    Public Property NOMBRE_FASE() As String
        Get
            Return _NOMBRE_FASE
        End Get
        Set(ByVal Value As String)
            _NOMBRE_FASE = Value
            OnPropertyChanged("NOMBRE_FASE")
        End Set
    End Property 

    Private _NOMBRE_FASEOld As String
    Public Property NOMBRE_FASEOld() As String
        Get
            Return _NOMBRE_FASEOld
        End Get
        Set(ByVal Value As String)
            _NOMBRE_FASEOld = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
