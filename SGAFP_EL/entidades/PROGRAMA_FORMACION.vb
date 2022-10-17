''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.PROGRAMA_FORMACION
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row PROGRAMA_FORMACION en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	05/10/2012	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="PROGRAMA_FORMACION")> Public Class PROGRAMA_FORMACION
    Inherits entidadBase
    Implements IEquatable(Of PROGRAMA_FORMACION), IComparable(Of PROGRAMA_FORMACION)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_PROGRAMA_FORMACION As Decimal, aNOMBRE_PROGRAMA_FORMACION As String, aUSERID As String, aLASTUPDATE As DateTime, aPORC_ASISTENCIA_MINIMA As Decimal, aNOTA_MINIMA As Decimal, aID_TIPO_PAGO As Decimal)
        Me._ID_PROGRAMA_FORMACION = aID_PROGRAMA_FORMACION
        Me._NOMBRE_PROGRAMA_FORMACION = aNOMBRE_PROGRAMA_FORMACION
        Me._USERID = aUSERID
        Me._LASTUPDATE = aLASTUPDATE
        Me._PORC_ASISTENCIA_MINIMA = aPORC_ASISTENCIA_MINIMA
        Me._NOTA_MINIMA = aNOTA_MINIMA
        Me._ID_TIPO_PAGO = aID_TIPO_PAGO
    End Sub

    Public Function Equals1(ByVal other As PROGRAMA_FORMACION) As Boolean Implements System.IEquatable(Of PROGRAMA_FORMACION).Equals
        Return Me.ID_PROGRAMA_FORMACION = other.ID_PROGRAMA_FORMACION
    End Function

    Public Function CompareTo(ByVal other As PROGRAMA_FORMACION) As Integer Implements System.IComparable(Of PROGRAMA_FORMACION).CompareTo
        If Me.ID_PROGRAMA_FORMACION > other.ID_PROGRAMA_FORMACION Then Return 1
        If Me.ID_PROGRAMA_FORMACION < other.ID_PROGRAMA_FORMACION Then Return -1
        Return 0
    End Function


#Region " Properties "

    Private _ID_PROGRAMA_FORMACION As Decimal
    <Column(Name:="Id programa formacion", Storage:="ID_PROGRAMA_FORMACION", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_PROGRAMA_FORMACION() As Decimal
        Get
            Return _ID_PROGRAMA_FORMACION
        End Get
        Set(ByVal Value As Decimal)
            _ID_PROGRAMA_FORMACION = Value
            OnPropertyChanged("ID_PROGRAMA_FORMACION")
        End Set
    End Property 

    Private _NOMBRE_PROGRAMA_FORMACION As String
    <Column(Name:="Nombre programa formacion", Storage:="NOMBRE_PROGRAMA_FORMACION", DbType:="VARCHAR2(100)", Id:=False), _
     DataObjectField(False, False, True, 100)> _
    Public Property NOMBRE_PROGRAMA_FORMACION() As String
        Get
            Return _NOMBRE_PROGRAMA_FORMACION
        End Get
        Set(ByVal Value As String)
            _NOMBRE_PROGRAMA_FORMACION = Value
            OnPropertyChanged("NOMBRE_PROGRAMA_FORMACION")
        End Set
    End Property 

    Private _NOMBRE_PROGRAMA_FORMACIONOld As String
    Public Property NOMBRE_PROGRAMA_FORMACIONOld() As String
        Get
            Return _NOMBRE_PROGRAMA_FORMACIONOld
        End Get
        Set(ByVal Value As String)
            _NOMBRE_PROGRAMA_FORMACIONOld = Value
        End Set
    End Property 

    Private _USERID As String
    <Column(Name:="Userid", Storage:="USERID", DbType:="VARCHAR2(256)", Id:=False), _
     DataObjectField(False, False, True, 256)> _
    Public Property USERID() As String
        Get
            Return _USERID
        End Get
        Set(ByVal Value As String)
            _USERID = Value
            OnPropertyChanged("USERID")
        End Set
    End Property 

    Private _USERIDOld As String
    Public Property USERIDOld() As String
        Get
            Return _USERIDOld
        End Get
        Set(ByVal Value As String)
            _USERIDOld = Value
        End Set
    End Property 

    Private _LASTUPDATE As DateTime
    <Column(Name:="Lastupdate", Storage:="LASTUPDATE", DbType:="DATE", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property LASTUPDATE() As DateTime
        Get
            Return _LASTUPDATE
        End Get
        Set(ByVal Value As DateTime)
            _LASTUPDATE = Value
            OnPropertyChanged("LASTUPDATE")
        End Set
    End Property 

    Private _LASTUPDATEOld As DateTime
    Public Property LASTUPDATEOld() As DateTime
        Get
            Return _LASTUPDATEOld
        End Get
        Set(ByVal Value As DateTime)
            _LASTUPDATEOld = Value
        End Set
    End Property 

    Private _PORC_ASISTENCIA_MINIMA As Decimal
    <Column(Name:="Porc asistencia minima", Storage:="PORC_ASISTENCIA_MINIMA", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=5, Scale:=2)> _
    Public Property PORC_ASISTENCIA_MINIMA() As Decimal
        Get
            Return _PORC_ASISTENCIA_MINIMA
        End Get
        Set(ByVal Value As Decimal)
            _PORC_ASISTENCIA_MINIMA = Value
            OnPropertyChanged("PORC_ASISTENCIA_MINIMA")
        End Set
    End Property 

    Private _PORC_ASISTENCIA_MINIMAOld As Decimal
    Public Property PORC_ASISTENCIA_MINIMAOld() As Decimal
        Get
            Return _PORC_ASISTENCIA_MINIMAOld
        End Get
        Set(ByVal Value As Decimal)
            _PORC_ASISTENCIA_MINIMAOld = Value
        End Set
    End Property 

    Private _NOTA_MINIMA As Decimal
    <Column(Name:="Nota minima", Storage:="NOTA_MINIMA", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=5, Scale:=2)> _
    Public Property NOTA_MINIMA() As Decimal
        Get
            Return _NOTA_MINIMA
        End Get
        Set(ByVal Value As Decimal)
            _NOTA_MINIMA = Value
            OnPropertyChanged("NOTA_MINIMA")
        End Set
    End Property 

    Private _NOTA_MINIMAOld As Decimal
    Public Property NOTA_MINIMAOld() As Decimal
        Get
            Return _NOTA_MINIMAOld
        End Get
        Set(ByVal Value As Decimal)
            _NOTA_MINIMAOld = Value
        End Set
    End Property 

    Private _ID_TIPO_PAGO As Decimal
    <Column(Name:="Id tipo pago", Storage:="ID_TIPO_PAGO", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_TIPO_PAGO() As Decimal
        Get
            Return _ID_TIPO_PAGO
        End Get
        Set(ByVal Value As Decimal)
            _ID_TIPO_PAGO = Value
            OnPropertyChanged("ID_TIPO_PAGO")
        End Set
    End Property 

    Private _ID_TIPO_PAGOOld As Decimal
    Public Property ID_TIPO_PAGOOld() As Decimal
        Get
            Return _ID_TIPO_PAGOOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_TIPO_PAGOOld = Value
        End Set
    End Property 

    Private _fkID_TIPO_PAGO As PROGRAMA_FORMACION_TIPOPAGO
    Public Property fkID_TIPO_PAGO() As PROGRAMA_FORMACION_TIPOPAGO
        Get
            Return _fkID_TIPO_PAGO
        End Get
        Set(ByVal Value As PROGRAMA_FORMACION_TIPOPAGO)
            _fkID_TIPO_PAGO = Value
        End Set
    End Property

    Private _MONTO_APOYO_PARTI As Decimal
    <Column(Name:="Monto de apoyo participante", Storage:="MONTO_APOYO_PARTI", DBType:="NUMBER", Id:=False),
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=2)>
    Public Property MONTO_APOYO_PARTI() As Decimal
        Get
            Return _MONTO_APOYO_PARTI
        End Get
        Set(ByVal Value As Decimal)
            _MONTO_APOYO_PARTI = Value
            OnPropertyChanged("MONTO_APOYO_PARTI")
        End Set
    End Property

    Private _MONTO_APOYO_PARTIOld As Decimal
    Public Property MONTO_APOYO_PARTIOld() As Decimal
        Get
            Return _MONTO_APOYO_PARTIOld
        End Get
        Set(ByVal Value As Decimal)
            _MONTO_APOYO_PARTIOld = Value
        End Set
    End Property


#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
