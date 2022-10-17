''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.ASISTENCIA_AF_HORARIO_REPROG
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row ASISTENCIA_AF_HORARIO_REPROG en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	04/03/2011	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="ASISTENCIA_AF_HORARIO_REPROG")> Public Class ASISTENCIA_AF_HORARIO_REPROG
    Inherits entidadBase
    Implements IEquatable(Of ASISTENCIA_AF_HORARIO_REPROG), IComparable(Of ASISTENCIA_AF_HORARIO_REPROG)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_ASISTENCIA_AF As Decimal, aID_ASISTENCIA_AF_HORARIO As Decimal, aHORA_INICIO As DateTime, aHORA_FIN As DateTime, aCANTIDAD_MINUTOS As Decimal)
        Me._ID_ASISTENCIA_AF = aID_ASISTENCIA_AF
        Me._ID_ASISTENCIA_AF_HORARIO = aID_ASISTENCIA_AF_HORARIO
        Me._HORA_INICIO = aHORA_INICIO
        Me._HORA_FIN = aHORA_FIN
        Me._CANTIDAD_MINUTOS = aCANTIDAD_MINUTOS
    End Sub

    Public Function Equals1(ByVal other As ASISTENCIA_AF_HORARIO_REPROG) As Boolean Implements System.IEquatable(Of ASISTENCIA_AF_HORARIO_REPROG).Equals
        Return Me.ID_ASISTENCIA_AF = other.ID_ASISTENCIA_AF And Me.ID_ASISTENCIA_AF_HORARIO = other.ID_ASISTENCIA_AF_HORARIO
    End Function

    Public Function CompareTo(ByVal other As ASISTENCIA_AF_HORARIO_REPROG) As Integer Implements System.IComparable(Of ASISTENCIA_AF_HORARIO_REPROG).CompareTo
        If Me.ID_ASISTENCIA_AF > other.ID_ASISTENCIA_AF Then
            If Me.ID_ASISTENCIA_AF_HORARIO > other.ID_ASISTENCIA_AF_HORARIO Then Return 1
            If Me.ID_ASISTENCIA_AF_HORARIO < other.ID_ASISTENCIA_AF_HORARIO Then Return -1
        Else
            Return -1
        End If
        Return 0
    End Function


#Region " Properties "

    Private _ID_ASISTENCIA_AF As Decimal
    <Column(Name:="Id asistencia af", Storage:="ID_ASISTENCIA_AF", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_ASISTENCIA_AF() As Decimal
        Get
            Return _ID_ASISTENCIA_AF
        End Get
        Set(ByVal Value As Decimal)
            _ID_ASISTENCIA_AF = Value
            OnPropertyChanged("ID_ASISTENCIA_AF")
        End Set
    End Property 

    Private _fkID_ASISTENCIA_AF As ASISTENCIA_AF_REPROG
    Public Property fkID_ASISTENCIA_AF() As ASISTENCIA_AF_REPROG
        Get
            Return _fkID_ASISTENCIA_AF
        End Get
        Set(ByVal Value As ASISTENCIA_AF_REPROG)
            _fkID_ASISTENCIA_AF = Value
        End Set
    End Property 

    Private _ID_ASISTENCIA_AF_HORARIO As Decimal
    <Column(Name:="Id asistencia af horario", Storage:="ID_ASISTENCIA_AF_HORARIO", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_ASISTENCIA_AF_HORARIO() As Decimal
        Get
            Return _ID_ASISTENCIA_AF_HORARIO
        End Get
        Set(ByVal Value As Decimal)
            _ID_ASISTENCIA_AF_HORARIO = Value
            OnPropertyChanged("ID_ASISTENCIA_AF_HORARIO")
        End Set
    End Property 

    Private _HORA_INICIO As DateTime
    <Column(Name:="Hora inicio", Storage:="HORA_INICIO", DbType:="DATE NOT NULL", Id:=False), _
     DataObjectField(False, False, False)> _
    Public Property HORA_INICIO() As DateTime
        Get
            Return _HORA_INICIO
        End Get
        Set(ByVal Value As DateTime)
            _HORA_INICIO = Value
            OnPropertyChanged("HORA_INICIO")
        End Set
    End Property 

    Private _HORA_INICIOOld As DateTime
    Public Property HORA_INICIOOld() As DateTime
        Get
            Return _HORA_INICIOOld
        End Get
        Set(ByVal Value As DateTime)
            _HORA_INICIOOld = Value
        End Set
    End Property 

    Private _HORA_FIN As DateTime
    <Column(Name:="Hora fin", Storage:="HORA_FIN", DbType:="DATE NOT NULL", Id:=False), _
     DataObjectField(False, False, False)> _
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

    Private _CANTIDAD_MINUTOS As Decimal
    <Column(Name:="Cantidad minutos", Storage:="CANTIDAD_MINUTOS", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property CANTIDAD_MINUTOS() As Decimal
        Get
            Return _CANTIDAD_MINUTOS
        End Get
        Set(ByVal Value As Decimal)
            _CANTIDAD_MINUTOS = Value
            OnPropertyChanged("CANTIDAD_MINUTOS")
        End Set
    End Property 

    Private _CANTIDAD_MINUTOSOld As Decimal
    Public Property CANTIDAD_MINUTOSOld() As Decimal
        Get
            Return _CANTIDAD_MINUTOSOld
        End Get
        Set(ByVal Value As Decimal)
            _CANTIDAD_MINUTOSOld = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
