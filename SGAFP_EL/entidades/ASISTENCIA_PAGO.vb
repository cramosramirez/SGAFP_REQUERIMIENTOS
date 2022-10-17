''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.ASISTENCIA_PAGO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row ASISTENCIA_PAGO en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	30/01/2022	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="ASISTENCIA_PAGO")> Public Class ASISTENCIA_PAGO
    Inherits entidadBase
    Implements IEquatable(Of ASISTENCIA_PAGO), IComparable(Of ASISTENCIA_PAGO)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_ASISTE_PAGO As Decimal, aDESCRIPCION As String, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime)
        Me._ID_ASISTE_PAGO = aID_ASISTE_PAGO
        Me._DESCRIPCION = aDESCRIPCION
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
    End Sub

    Public Function Equals1(ByVal other As ASISTENCIA_PAGO) As Boolean Implements System.IEquatable(Of ASISTENCIA_PAGO).Equals
        Return Me.ID_ASISTE_PAGO = other.ID_ASISTE_PAGO
    End Function

    Public Function CompareTo(ByVal other As ASISTENCIA_PAGO) As Integer Implements System.IComparable(Of ASISTENCIA_PAGO).CompareTo
        If Me.ID_ASISTE_PAGO > other.ID_ASISTE_PAGO Then Return 1
        If Me.ID_ASISTE_PAGO < other.ID_ASISTE_PAGO Then Return -1
        Return 0
    End Function


#Region " Properties "

    Private _ID_ASISTE_PAGO As Decimal
    <Column(Name:="Id asiste pago", Storage:="ID_ASISTE_PAGO", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_ASISTE_PAGO() As Decimal
        Get
            Return _ID_ASISTE_PAGO
        End Get
        Set(ByVal Value As Decimal)
            _ID_ASISTE_PAGO = Value
            OnPropertyChanged("ID_ASISTE_PAGO")
        End Set
    End Property 

    Private _DESCRIPCION As String
    <Column(Name:="Descripcion", Storage:="DESCRIPCION", DbType:="VARCHAR2(200) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 200)> _
    Public Property DESCRIPCION() As String
        Get
            Return _DESCRIPCION
        End Get
        Set(ByVal Value As String)
            _DESCRIPCION = Value
            OnPropertyChanged("DESCRIPCION")
        End Set
    End Property 

    Private _DESCRIPCIONOld As String
    Public Property DESCRIPCIONOld() As String
        Get
            Return _DESCRIPCIONOld
        End Get
        Set(ByVal Value As String)
            _DESCRIPCIONOld = Value
        End Set
    End Property 

    Private _USUARIO_CREA As String
    <Column(Name:="Usuario crea", Storage:="USUARIO_CREA", DbType:="VARCHAR2(100) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 100)> _
    Public Property USUARIO_CREA() As String
        Get
            Return _USUARIO_CREA
        End Get
        Set(ByVal Value As String)
            _USUARIO_CREA = Value
            OnPropertyChanged("USUARIO_CREA")
        End Set
    End Property 

    Private _USUARIO_CREAOld As String
    Public Property USUARIO_CREAOld() As String
        Get
            Return _USUARIO_CREAOld
        End Get
        Set(ByVal Value As String)
            _USUARIO_CREAOld = Value
        End Set
    End Property 

    Private _FECHA_CREA As DateTime
    <Column(Name:="Fecha crea", Storage:="FECHA_CREA", DbType:="DATE NOT NULL", Id:=False), _
     DataObjectField(False, False, False)> _
    Public Property FECHA_CREA() As DateTime
        Get
            Return _FECHA_CREA
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_CREA = Value
            OnPropertyChanged("FECHA_CREA")
        End Set
    End Property 

    Private _FECHA_CREAOld As DateTime
    Public Property FECHA_CREAOld() As DateTime
        Get
            Return _FECHA_CREAOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_CREAOld = Value
        End Set
    End Property 

    Private _USUARIO_ACT As String
    <Column(Name:="Usuario act", Storage:="USUARIO_ACT", DbType:="VARCHAR2(100) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 100)> _
    Public Property USUARIO_ACT() As String
        Get
            Return _USUARIO_ACT
        End Get
        Set(ByVal Value As String)
            _USUARIO_ACT = Value
            OnPropertyChanged("USUARIO_ACT")
        End Set
    End Property 

    Private _USUARIO_ACTOld As String
    Public Property USUARIO_ACTOld() As String
        Get
            Return _USUARIO_ACTOld
        End Get
        Set(ByVal Value As String)
            _USUARIO_ACTOld = Value
        End Set
    End Property 

    Private _FECHA_ACT As DateTime
    <Column(Name:="Fecha act", Storage:="FECHA_ACT", DbType:="DATE NOT NULL", Id:=False), _
     DataObjectField(False, False, False)> _
    Public Property FECHA_ACT() As DateTime
        Get
            Return _FECHA_ACT
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_ACT = Value
            OnPropertyChanged("FECHA_ACT")
        End Set
    End Property 

    Private _FECHA_ACTOld As DateTime
    Public Property FECHA_ACTOld() As DateTime
        Get
            Return _FECHA_ACTOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_ACTOld = Value
        End Set
    End Property

    Private _ID_EJERCICIO As String
    <Column(Name:="Id ejercicio", Storage:="ID_EJERCICIO", DbType:="CHAR(4)", Id:=False), _
     DataObjectField(False, False, True, 4), DataMember()> _
    Public Property ID_EJERCICIO() As String
        Get
            Return _ID_EJERCICIO
        End Get
        Set(ByVal Value As String)
            _ID_EJERCICIO = Value
            OnPropertyChanged("ID_EJERCICIO")
        End Set
    End Property

    Private _ID_EJERCICIOOld As String
    <DataMember()> _
    Public Property ID_EJERCICIOOld() As String
        Get
            Return _ID_EJERCICIOOld
        End Get
        Set(ByVal Value As String)
            _ID_EJERCICIOOld = Value
        End Set
    End Property


#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
