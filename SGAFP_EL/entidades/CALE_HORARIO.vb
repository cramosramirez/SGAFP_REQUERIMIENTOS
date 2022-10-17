''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.CALE_HORARIO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row CALE_HORARIO en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	21/05/2019	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="CALE_HORARIO")> Public Class CALE_HORARIO
    Inherits entidadBase
    Implements IEquatable(Of CALE_HORARIO), IComparable(Of CALE_HORARIO)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_HORA As Decimal, aID_CALE As Decimal, aHORA_INI As DateTime, aHORA_FIN As DateTime, aMINUTOS As Decimal)
        Me._ID_HORA = aID_HORA
        Me._ID_CALE = aID_CALE
        Me._HORA_INI = aHORA_INI
        Me._HORA_FIN = aHORA_FIN
        Me._MINUTOS = aMINUTOS
    End Sub

    Public Function Equals1(ByVal other As CALE_HORARIO) As Boolean Implements System.IEquatable(Of CALE_HORARIO).Equals
        Return Me.ID_HORA = other.ID_HORA
    End Function

    Public Function CompareTo(ByVal other As CALE_HORARIO) As Integer Implements System.IComparable(Of CALE_HORARIO).CompareTo
        If Me.ID_HORA > other.ID_HORA Then Return 1
        If Me.ID_HORA < other.ID_HORA Then Return -1
        Return 0
    End Function


#Region " Properties "

    Private _ID_HORA As Decimal
    <Column(Name:="Id hora", Storage:="ID_HORA", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_HORA() As Decimal
        Get
            Return _ID_HORA
        End Get
        Set(ByVal Value As Decimal)
            _ID_HORA = Value
            OnPropertyChanged("ID_HORA")
        End Set
    End Property 

    Private _ID_CALE As Decimal
    <Column(Name:="Id cale", Storage:="ID_CALE", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_CALE() As Decimal
        Get
            Return _ID_CALE
        End Get
        Set(ByVal Value As Decimal)
            _ID_CALE = Value
            OnPropertyChanged("ID_CALE")
        End Set
    End Property 

    Private _ID_CALEOld As Decimal
    Public Property ID_CALEOld() As Decimal
        Get
            Return _ID_CALEOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_CALEOld = Value
        End Set
    End Property 

    Private _fkID_CALE As CALE_FECHA
    Public Property fkID_CALE() As CALE_FECHA
        Get
            Return _fkID_CALE
        End Get
        Set(ByVal Value As CALE_FECHA)
            _fkID_CALE = Value
        End Set
    End Property 

    Private _HORA_INI As DateTime
    <Column(Name:="Hora ini", Storage:="HORA_INI", DbType:="DATE", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property HORA_INI() As DateTime
        Get
            Return _HORA_INI
        End Get
        Set(ByVal Value As DateTime)
            _HORA_INI = Value
            OnPropertyChanged("HORA_INI")
        End Set
    End Property 

    Private _HORA_INIOld As DateTime
    Public Property HORA_INIOld() As DateTime
        Get
            Return _HORA_INIOld
        End Get
        Set(ByVal Value As DateTime)
            _HORA_INIOld = Value
        End Set
    End Property 

    Private _HORA_FIN As DateTime
    <Column(Name:="Hora fin", Storage:="HORA_FIN", DbType:="DATE", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property HORA_FIN() As DateTime
        Get
            Return _HORA_FIN
        End Get
        Set(ByVal Value As DateTime)
            _HORA_FIN = Value
            OnPropertyChanged("HORA_FIN")
        End Set
    End Property 

    Private _HORA_FINOld As DateTime
    Public Property HORA_FINOld() As DateTime
        Get
            Return _HORA_FINOld
        End Get
        Set(ByVal Value As DateTime)
            _HORA_FINOld = Value
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
