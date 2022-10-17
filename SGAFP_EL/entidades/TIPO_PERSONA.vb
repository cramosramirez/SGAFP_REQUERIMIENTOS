''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.TIPO_PERSONA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite tener un registro de la tabla TIPO_PERSONA en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="TIPO_PERSONA")> Public Class TIPO_PERSONA
    Inherits entidadBase
    Implements IEquatable(Of TIPO_PERSONA), IComparable(Of TIPO_PERSONA)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_TIPO_PERSONA As Decimal, aTIPO_PERSONA As String, aNOTAS As String)
        Me._ID_TIPO_PERSONA = aID_TIPO_PERSONA
        Me._TIPO_PERSONA = aTIPO_PERSONA
        Me._NOTAS = aNOTAS
    End Sub

    Public Function Equals1(ByVal other As TIPO_PERSONA) As Boolean Implements System.IEquatable(Of TIPO_PERSONA).Equals
        Return Me.ID_TIPO_PERSONA = other.ID_TIPO_PERSONA
    End Function

    Public Function CompareTo(ByVal other As TIPO_PERSONA) As Integer Implements System.IComparable(Of TIPO_PERSONA).CompareTo
        If Me.ID_TIPO_PERSONA > other.ID_TIPO_PERSONA Then Return 1
        If Me.ID_TIPO_PERSONA < other.ID_TIPO_PERSONA Then Return -1
        Return 0
    End Function


#Region " Propiedades "

    Private _ID_TIPO_PERSONA As Decimal
    <Column(Name:="Id tipo persona", Storage:="ID_TIPO_PERSONA", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_TIPO_PERSONA() As Decimal
        Get
            Return _ID_TIPO_PERSONA
        End Get
        Set(ByVal Value As Decimal)
            _ID_TIPO_PERSONA = Value
            OnPropertyChanged("ID_TIPO_PERSONA")
        End Set
    End Property 

    Private _TIPO_PERSONA As String
    <Column(Name:="Tipo persona", Storage:="TIPO_PERSONA", DbType:="VARCHAR2(40)", Id:=False), _
     DataObjectField(False, False, True, 40)> _
    Public Property TIPO_PERSONA() As String
        Get
            Return _TIPO_PERSONA
        End Get
        Set(ByVal Value As String)
            _TIPO_PERSONA = Value
            OnPropertyChanged("TIPO_PERSONA")
        End Set
    End Property 

    Private _TIPO_PERSONAOld As String
    Public Property TIPO_PERSONAOld() As String
        Get
            Return _TIPO_PERSONAOld
        End Get
        Set(ByVal Value As String)
            _TIPO_PERSONAOld = Value
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
