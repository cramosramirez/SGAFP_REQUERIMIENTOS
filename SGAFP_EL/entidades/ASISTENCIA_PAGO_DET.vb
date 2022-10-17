''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.ASISTENCIA_PAGO_DET
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row ASISTENCIA_PAGO_DET en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	30/01/2022	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="ASISTENCIA_PAGO_DET")> Public Class ASISTENCIA_PAGO_DET
    Inherits entidadBase
    Implements IEquatable(Of ASISTENCIA_PAGO_DET), IComparable(Of ASISTENCIA_PAGO_DET)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_ASISTE_PAGO_DET As Decimal, aID_ASISTE_PAGO As Decimal, aID_MODALIDAD_FORMACION As Decimal, aPORC_ASISTE_INI As Decimal, aPORC_ASISTE_FIN As Decimal, aPORC_PAGO_COSTO_PARTI As Decimal, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime)
        Me._ID_ASISTE_PAGO_DET = aID_ASISTE_PAGO_DET
        Me._ID_ASISTE_PAGO = aID_ASISTE_PAGO
        Me._ID_MODALIDAD_FORMACION = aID_MODALIDAD_FORMACION
        Me._PORC_ASISTE_INI = aPORC_ASISTE_INI
        Me._PORC_ASISTE_FIN = aPORC_ASISTE_FIN
        Me._PORC_PAGO_COSTO_PARTI = aPORC_PAGO_COSTO_PARTI
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
    End Sub

    Public Function Equals1(ByVal other As ASISTENCIA_PAGO_DET) As Boolean Implements System.IEquatable(Of ASISTENCIA_PAGO_DET).Equals
        Return Me.ID_ASISTE_PAGO_DET = other.ID_ASISTE_PAGO_DET
    End Function

    Public Function CompareTo(ByVal other As ASISTENCIA_PAGO_DET) As Integer Implements System.IComparable(Of ASISTENCIA_PAGO_DET).CompareTo
        If Me.ID_ASISTE_PAGO_DET > other.ID_ASISTE_PAGO_DET Then Return 1
        If Me.ID_ASISTE_PAGO_DET < other.ID_ASISTE_PAGO_DET Then Return -1
        Return 0
    End Function


#Region " Properties "

    Private _ID_ASISTE_PAGO_DET As Decimal
    <Column(Name:="Id asiste pago det", Storage:="ID_ASISTE_PAGO_DET", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_ASISTE_PAGO_DET() As Decimal
        Get
            Return _ID_ASISTE_PAGO_DET
        End Get
        Set(ByVal Value As Decimal)
            _ID_ASISTE_PAGO_DET = Value
            OnPropertyChanged("ID_ASISTE_PAGO_DET")
        End Set
    End Property 

    Private _ID_ASISTE_PAGO As Decimal
    <Column(Name:="Id asiste pago", Storage:="ID_ASISTE_PAGO", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_ASISTE_PAGO() As Decimal
        Get
            Return _ID_ASISTE_PAGO
        End Get
        Set(ByVal Value As Decimal)
            _ID_ASISTE_PAGO = Value
            OnPropertyChanged("ID_ASISTE_PAGO")
        End Set
    End Property 

    Private _ID_ASISTE_PAGOOld As Decimal
    Public Property ID_ASISTE_PAGOOld() As Decimal
        Get
            Return _ID_ASISTE_PAGOOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_ASISTE_PAGOOld = Value
        End Set
    End Property 

    Private _fkID_ASISTE_PAGO As ASISTENCIA_PAGO
    Public Property fkID_ASISTE_PAGO() As ASISTENCIA_PAGO
        Get
            Return _fkID_ASISTE_PAGO
        End Get
        Set(ByVal Value As ASISTENCIA_PAGO)
            _fkID_ASISTE_PAGO = Value
        End Set
    End Property 

    Private _ID_MODALIDAD_FORMACION As Decimal
    <Column(Name:="Id modalidad formacion", Storage:="ID_MODALIDAD_FORMACION", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_MODALIDAD_FORMACION() As Decimal
        Get
            Return _ID_MODALIDAD_FORMACION
        End Get
        Set(ByVal Value As Decimal)
            _ID_MODALIDAD_FORMACION = Value
            OnPropertyChanged("ID_MODALIDAD_FORMACION")
        End Set
    End Property 

    Private _ID_MODALIDAD_FORMACIONOld As Decimal
    Public Property ID_MODALIDAD_FORMACIONOld() As Decimal
        Get
            Return _ID_MODALIDAD_FORMACIONOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_MODALIDAD_FORMACIONOld = Value
        End Set
    End Property 

    Private _fkID_MODALIDAD_FORMACION As MODALIDAD_DE_FORMACION
    Public Property fkID_MODALIDAD_FORMACION() As MODALIDAD_DE_FORMACION
        Get
            Return _fkID_MODALIDAD_FORMACION
        End Get
        Set(ByVal Value As MODALIDAD_DE_FORMACION)
            _fkID_MODALIDAD_FORMACION = Value
        End Set
    End Property 

    Private _PORC_ASISTE_INI As Decimal
    <Column(Name:="Porc asiste ini", Storage:="PORC_ASISTE_INI", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=5, Scale:=2)> _
    Public Property PORC_ASISTE_INI() As Decimal
        Get
            Return _PORC_ASISTE_INI
        End Get
        Set(ByVal Value As Decimal)
            _PORC_ASISTE_INI = Value
            OnPropertyChanged("PORC_ASISTE_INI")
        End Set
    End Property 

    Private _PORC_ASISTE_INIOld As Decimal
    Public Property PORC_ASISTE_INIOld() As Decimal
        Get
            Return _PORC_ASISTE_INIOld
        End Get
        Set(ByVal Value As Decimal)
            _PORC_ASISTE_INIOld = Value
        End Set
    End Property 

    Private _PORC_ASISTE_FIN As Decimal
    <Column(Name:="Porc asiste fin", Storage:="PORC_ASISTE_FIN", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=5, Scale:=2)> _
    Public Property PORC_ASISTE_FIN() As Decimal
        Get
            Return _PORC_ASISTE_FIN
        End Get
        Set(ByVal Value As Decimal)
            _PORC_ASISTE_FIN = Value
            OnPropertyChanged("PORC_ASISTE_FIN")
        End Set
    End Property 

    Private _PORC_ASISTE_FINOld As Decimal
    Public Property PORC_ASISTE_FINOld() As Decimal
        Get
            Return _PORC_ASISTE_FINOld
        End Get
        Set(ByVal Value As Decimal)
            _PORC_ASISTE_FINOld = Value
        End Set
    End Property 

    Private _PORC_PAGO_COSTO_PARTI As Decimal
    <Column(Name:="Porc pago costo parti", Storage:="PORC_PAGO_COSTO_PARTI", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=5, Scale:=2)> _
    Public Property PORC_PAGO_COSTO_PARTI() As Decimal
        Get
            Return _PORC_PAGO_COSTO_PARTI
        End Get
        Set(ByVal Value As Decimal)
            _PORC_PAGO_COSTO_PARTI = Value
            OnPropertyChanged("PORC_PAGO_COSTO_PARTI")
        End Set
    End Property 

    Private _PORC_PAGO_COSTO_PARTIOld As Decimal
    Public Property PORC_PAGO_COSTO_PARTIOld() As Decimal
        Get
            Return _PORC_PAGO_COSTO_PARTIOld
        End Get
        Set(ByVal Value As Decimal)
            _PORC_PAGO_COSTO_PARTIOld = Value
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

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
