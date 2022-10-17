''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.CALE_FECHA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row CALE_FECHA en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	21/05/2019	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="CALE_FECHA")> Public Class CALE_FECHA
    Inherits entidadBase
    Implements IEquatable(Of CALE_FECHA), IComparable(Of CALE_FECHA)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_CALE As Decimal, aFECHA As DateTime, aHORARIO As String, aMINUTOS As Decimal)
        Me._ID_CALE = aID_CALE
        Me._FECHA = aFECHA
        Me._HORARIO = aHORARIO
        Me._MINUTOS = aMINUTOS
    End Sub

    Public Function Equals1(ByVal other As CALE_FECHA) As Boolean Implements System.IEquatable(Of CALE_FECHA).Equals
        Return Me.ID_CALE = other.ID_CALE
    End Function

    Public Function CompareTo(ByVal other As CALE_FECHA) As Integer Implements System.IComparable(Of CALE_FECHA).CompareTo
        If Me.ID_CALE > other.ID_CALE Then Return 1
        If Me.ID_CALE < other.ID_CALE Then Return -1
        Return 0
    End Function


#Region " Properties "

    Private _ID_CALE As Decimal
    <Column(Name:="Id cale", Storage:="ID_CALE", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_CALE() As Decimal
        Get
            Return _ID_CALE
        End Get
        Set(ByVal Value As Decimal)
            _ID_CALE = Value
            OnPropertyChanged("ID_CALE")
        End Set
    End Property 

    Private _FECHA As DateTime
    <Column(Name:="Fecha", Storage:="FECHA", DbType:="DATE", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property FECHA() As DateTime
        Get
            Return _FECHA
        End Get
        Set(ByVal Value As DateTime)
            _FECHA = Value
            OnPropertyChanged("FECHA")
        End Set
    End Property 

    Private _FECHAOld As DateTime
    Public Property FECHAOld() As DateTime
        Get
            Return _FECHAOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHAOld = Value
        End Set
    End Property 

    Private _HORARIO As String
    <Column(Name:="Horario", Storage:="HORARIO", DbType:="VARCHAR2(500)", Id:=False), _
     DataObjectField(False, False, True, 500)> _
    Public Property HORARIO() As String
        Get
            Return _HORARIO
        End Get
        Set(ByVal Value As String)
            _HORARIO = Value
            OnPropertyChanged("HORARIO")
        End Set
    End Property 

    Private _HORARIOOld As String
    Public Property HORARIOOld() As String
        Get
            Return _HORARIOOld
        End Get
        Set(ByVal Value As String)
            _HORARIOOld = Value
        End Set
    End Property 

    Private _MINUTOS As Decimal
    <Column(Name:="Minutos", Storage:="MINUTOS", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=0, Scale:=0)> _
    Public Property MINUTOS() As Decimal
        Get
            Return _MINUTOS
        End Get
        Set(ByVal Value As Decimal)
            _MINUTOS = Value
            OnPropertyChanged("MINUTOS")
        End Set
    End Property 

    Private _MINUTOSOld As Decimal
    Public Property MINUTOSOld() As Decimal
        Get
            Return _MINUTOSOld
        End Get
        Set(ByVal Value As Decimal)
            _MINUTOSOld = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
