''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.ESTADO_SOLICITUD
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite tener un registro de la tabla ESTADO_SOLICITUD en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="ESTADO_SOLICITUD")> Public Class ESTADO_SOLICITUD
    Inherits entidadBase
    Implements IEquatable(Of ESTADO_SOLICITUD), IComparable(Of ESTADO_SOLICITUD)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_ESTADO_SOLICITUD As Decimal, aESTADO_SOLICITUD As String, aNOTAS As String)
        Me._ID_ESTADO_SOLICITUD = aID_ESTADO_SOLICITUD
        Me._ESTADO_SOLICITUD = aESTADO_SOLICITUD
        Me._NOTAS = aNOTAS
    End Sub

    Public Function Equals1(ByVal other As ESTADO_SOLICITUD) As Boolean Implements System.IEquatable(Of ESTADO_SOLICITUD).Equals
        Return Me.ID_ESTADO_SOLICITUD = other.ID_ESTADO_SOLICITUD
    End Function

    Public Function CompareTo(ByVal other As ESTADO_SOLICITUD) As Integer Implements System.IComparable(Of ESTADO_SOLICITUD).CompareTo
        If Me.ID_ESTADO_SOLICITUD > other.ID_ESTADO_SOLICITUD Then Return 1
        If Me.ID_ESTADO_SOLICITUD < other.ID_ESTADO_SOLICITUD Then Return -1
        Return 0
    End Function


#Region " Propiedades "

    Private _ID_ESTADO_SOLICITUD As Decimal
    <Column(Name:="Id estado solicitud", Storage:="ID_ESTADO_SOLICITUD", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=2, Scale:=0)> _
    Public Property ID_ESTADO_SOLICITUD() As Decimal
        Get
            Return _ID_ESTADO_SOLICITUD
        End Get
        Set(ByVal Value As Decimal)
            _ID_ESTADO_SOLICITUD = Value
            OnPropertyChanged("ID_ESTADO_SOLICITUD")
        End Set
    End Property 

    Private _ESTADO_SOLICITUD As String
    <Column(Name:="Estado solicitud", Storage:="ESTADO_SOLICITUD", DbType:="VARCHAR2(60)", Id:=False), _
     DataObjectField(False, False, True, 60)> _
    Public Property ESTADO_SOLICITUD() As String
        Get
            Return _ESTADO_SOLICITUD
        End Get
        Set(ByVal Value As String)
            _ESTADO_SOLICITUD = Value
            OnPropertyChanged("ESTADO_SOLICITUD")
        End Set
    End Property 

    Private _ESTADO_SOLICITUDOld As String
    Public Property ESTADO_SOLICITUDOld() As String
        Get
            Return _ESTADO_SOLICITUDOld
        End Get
        Set(ByVal Value As String)
            _ESTADO_SOLICITUDOld = Value
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
