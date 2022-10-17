''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.CONTRATO_COMPRA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row CONTRATO_COMPRA en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	30/06/2016	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="CONTRATO_COMPRA")> Public Class CONTRATO_COMPRA
    Inherits entidadBase
    Implements IEquatable(Of CONTRATO_COMPRA), IComparable(Of CONTRATO_COMPRA)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_CONTRATO_COMPRA As Decimal, aNO_CONTRATO_COMPRA As String, aFECHA_INGRESO As DateTime, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime, aFECHA_INI_EJEC As DateTime, aFECHA_FIN_EJEC As DateTime, aPORC_ASISTENCIA_MIN As Decimal, aPAGO_POR_PARTICIPACION As Decimal, aBASE_PARTI As Decimal, aULTFECHA_CALENDARIZA As Date, ByVal aID_UNIDAD_ORGANIZATIVA As Decimal)
        Me._ID_CONTRATO_COMPRA = aID_CONTRATO_COMPRA
        Me._NO_CONTRATO_COMPRA = aNO_CONTRATO_COMPRA
        Me._FECHA_INGRESO = aFECHA_INGRESO
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
        Me._FECHA_INI_EJEC = aFECHA_INI_EJEC
        Me._FECHA_FIN_EJEC = aFECHA_FIN_EJEC
        Me._PORC_ASISTENCIA_MIN = aPORC_ASISTENCIA_MIN
        Me._PAGO_POR_PARTICIPACION = aPAGO_POR_PARTICIPACION
        Me._BASE_PARTI = aBASE_PARTI
        Me._ULTFECHA_CALENDARIZA = aULTFECHA_CALENDARIZA
        Me._ID_UNIDAD_ORGANIZATIVA = aID_UNIDAD_ORGANIZATIVA
    End Sub

    Public Function Equals1(ByVal other As CONTRATO_COMPRA) As Boolean Implements System.IEquatable(Of CONTRATO_COMPRA).Equals
        Return Me.ID_CONTRATO_COMPRA = other.ID_CONTRATO_COMPRA
    End Function

    Public Function CompareTo(ByVal other As CONTRATO_COMPRA) As Integer Implements System.IComparable(Of CONTRATO_COMPRA).CompareTo
        If Me.ID_CONTRATO_COMPRA > other.ID_CONTRATO_COMPRA Then Return 1
        If Me.ID_CONTRATO_COMPRA < other.ID_CONTRATO_COMPRA Then Return -1
        Return 0
    End Function


#Region " Properties "

    Private _ID_CONTRATO_COMPRA As Decimal
    <Column(Name:="Id contrato compra", Storage:="ID_CONTRATO_COMPRA", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_CONTRATO_COMPRA() As Decimal
        Get
            Return _ID_CONTRATO_COMPRA
        End Get
        Set(ByVal Value As Decimal)
            _ID_CONTRATO_COMPRA = Value
            OnPropertyChanged("ID_CONTRATO_COMPRA")
        End Set
    End Property 

    Private _NO_CONTRATO_COMPRA As String
    <Column(Name:="No contrato compra", Storage:="NO_CONTRATO_COMPRA", DbType:="VARCHAR2(10) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 10)> _
    Public Property NO_CONTRATO_COMPRA() As String
        Get
            Return _NO_CONTRATO_COMPRA
        End Get
        Set(ByVal Value As String)
            _NO_CONTRATO_COMPRA = Value
            OnPropertyChanged("NO_CONTRATO_COMPRA")
        End Set
    End Property 

    Private _NO_CONTRATO_COMPRAOld As String
    Public Property NO_CONTRATO_COMPRAOld() As String
        Get
            Return _NO_CONTRATO_COMPRAOld
        End Get
        Set(ByVal Value As String)
            _NO_CONTRATO_COMPRAOld = Value
        End Set
    End Property 

    Private _FECHA_INGRESO As DateTime
    <Column(Name:="Fecha ingreso", Storage:="FECHA_INGRESO", DbType:="DATE NOT NULL", Id:=False), _
     DataObjectField(False, False, False)> _
    Public Property FECHA_INGRESO() As DateTime
        Get
            Return _FECHA_INGRESO
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_INGRESO = Value
            OnPropertyChanged("FECHA_INGRESO")
        End Set
    End Property 

    Private _FECHA_INGRESOOld As DateTime
    Public Property FECHA_INGRESOOld() As DateTime
        Get
            Return _FECHA_INGRESOOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_INGRESOOld = Value
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

    Private _FECHA_INI_EJEC As DateTime
    <Column(Name:="Fecha ini ejec", Storage:="FECHA_INI_EJEC", DbType:="DATE", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property FECHA_INI_EJEC() As DateTime
        Get
            Return _FECHA_INI_EJEC
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_INI_EJEC = Value
            OnPropertyChanged("FECHA_INI_EJEC")
        End Set
    End Property 

    Private _FECHA_INI_EJECOld As DateTime
    Public Property FECHA_INI_EJECOld() As DateTime
        Get
            Return _FECHA_INI_EJECOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_INI_EJECOld = Value
        End Set
    End Property 

    Private _FECHA_FIN_EJEC As DateTime
    <Column(Name:="Fecha fin ejec", Storage:="FECHA_FIN_EJEC", DbType:="DATE", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property FECHA_FIN_EJEC() As DateTime
        Get
            Return _FECHA_FIN_EJEC
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_FIN_EJEC = Value
            OnPropertyChanged("FECHA_FIN_EJEC")
        End Set
    End Property 

    Private _FECHA_FIN_EJECOld As DateTime
    Public Property FECHA_FIN_EJECOld() As DateTime
        Get
            Return _FECHA_FIN_EJECOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_FIN_EJECOld = Value
        End Set
    End Property

    Private _PORC_ASISTENCIA_MIN As Decimal
    <Column(Name:="Porc asistencia min", Storage:="PORC_ASISTENCIA_MIN", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=5, Scale:=2)> _
    Public Property PORC_ASISTENCIA_MIN() As Decimal
        Get
            Return _PORC_ASISTENCIA_MIN
        End Get
        Set(ByVal Value As Decimal)
            _PORC_ASISTENCIA_MIN = Value
            OnPropertyChanged("PORC_ASISTENCIA_MIN")
        End Set
    End Property

    Private _PORC_ASISTENCIA_MINOld As Decimal
    Public Property PORC_ASISTENCIA_MINOld() As Decimal
        Get
            Return _PORC_ASISTENCIA_MINOld
        End Get
        Set(ByVal Value As Decimal)
            _PORC_ASISTENCIA_MINOld = Value
        End Set
    End Property

    Private _PAGO_POR_PARTICIPACION As Decimal
    <Column(Name:="Pago por participacion", Storage:="PAGO_POR_PARTICIPACION", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=2, Scale:=0)> _
    Public Property PAGO_POR_PARTICIPACION() As Decimal
        Get
            Return _PAGO_POR_PARTICIPACION
        End Get
        Set(ByVal Value As Decimal)
            _PAGO_POR_PARTICIPACION = Value
            OnPropertyChanged("PAGO_POR_PARTICIPACION")
        End Set
    End Property

    Private _PAGO_POR_PARTICIPACIONOld As Decimal
    Public Property PAGO_POR_PARTICIPACIONOld() As Decimal
        Get
            Return _PAGO_POR_PARTICIPACIONOld
        End Get
        Set(ByVal Value As Decimal)
            _PAGO_POR_PARTICIPACIONOld = Value
        End Set
    End Property

    Private _BASE_PARTI As Decimal
    <Column(Name:="Base parti", Storage:="BASE_PARTI", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=0, Scale:=0)> _
    Public Property BASE_PARTI() As Decimal
        Get
            Return _BASE_PARTI
        End Get
        Set(ByVal Value As Decimal)
            _BASE_PARTI = Value
            OnPropertyChanged("BASE_PARTI")
        End Set
    End Property

    Private _BASE_PARTIOld As Decimal
    Public Property BASE_PARTIOld() As Decimal
        Get
            Return _BASE_PARTIOld
        End Get
        Set(ByVal Value As Decimal)
            _BASE_PARTIOld = Value
        End Set
    End Property


    Private _ULTFECHA_CALENDARIZA As DateTime
    <Column(Name:="Fecha crea", Storage:="ULTFECHA_CALENDARIZA", DbType:="DATE NULL", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property ULTFECHA_CALENDARIZA() As DateTime
        Get
            Return _ULTFECHA_CALENDARIZA
        End Get
        Set(ByVal Value As DateTime)
            _ULTFECHA_CALENDARIZA = Value
            OnPropertyChanged("ULTFECHA_CALENDARIZA")
        End Set
    End Property

    Private _ULTFECHA_CALENDARIZAOld As DateTime
    Public Property ULTFECHA_CALENDARIZAOld() As DateTime
        Get
            Return _ULTFECHA_CALENDARIZAOld
        End Get
        Set(ByVal Value As DateTime)
            _ULTFECHA_CALENDARIZAOld = Value
        End Set
    End Property

    Private _ID_UNIDAD_ORGANIZATIVA As Decimal
    <Column(Name:="ID_UNIDAD_ORGANIZATIVA", Storage:="ID_UNIDAD_ORGANIZATIVA", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_UNIDAD_ORGANIZATIVA() As Decimal
        Get
            Return _ID_UNIDAD_ORGANIZATIVA
        End Get
        Set(ByVal Value As Decimal)
            If Value = 0 Then
                _ID_UNIDAD_ORGANIZATIVA = -1
            Else
                _ID_UNIDAD_ORGANIZATIVA = Value
            End If
            OnPropertyChanged("ID_UNIDAD_ORGANIZATIVA")
        End Set
    End Property

    Private _ID_UNIDAD_ORGANIZATIVAOld As Decimal
    Public Property ID_UNIDAD_ORGANIZATIVAOld() As Decimal
        Get
            Return _ID_UNIDAD_ORGANIZATIVAOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_UNIDAD_ORGANIZATIVAOld = Value
        End Set
    End Property

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
