''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.PROGRAMA_FORMACION_TIPOPAGO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row PROGRAMA_FORMACION_TIPOPAGO en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	05/10/2012	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="PROGRAMA_FORMACION_TIPOPAGO")> Public Class PROGRAMA_FORMACION_TIPOPAGO
    Inherits entidadBase
    Implements IEquatable(Of PROGRAMA_FORMACION_TIPOPAGO), IComparable(Of PROGRAMA_FORMACION_TIPOPAGO)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_TIPO_PAGO As Decimal, aNOMBRE_TIPO_PAGO As String, aUSERID As String, aLASTUPDATE As DateTime)
        Me._ID_TIPO_PAGO = aID_TIPO_PAGO
        Me._NOMBRE_TIPO_PAGO = aNOMBRE_TIPO_PAGO
        Me._USERID = aUSERID
        Me._LASTUPDATE = aLASTUPDATE
    End Sub

    Public Function Equals1(ByVal other As PROGRAMA_FORMACION_TIPOPAGO) As Boolean Implements System.IEquatable(Of PROGRAMA_FORMACION_TIPOPAGO).Equals
        Return Me.ID_TIPO_PAGO = other.ID_TIPO_PAGO
    End Function

    Public Function CompareTo(ByVal other As PROGRAMA_FORMACION_TIPOPAGO) As Integer Implements System.IComparable(Of PROGRAMA_FORMACION_TIPOPAGO).CompareTo
        If Me.ID_TIPO_PAGO > other.ID_TIPO_PAGO Then Return 1
        If Me.ID_TIPO_PAGO < other.ID_TIPO_PAGO Then Return -1
        Return 0
    End Function


#Region " Properties "

    Private _ID_TIPO_PAGO As Decimal
    <Column(Name:="Id tipo pago", Storage:="ID_TIPO_PAGO", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_TIPO_PAGO() As Decimal
        Get
            Return _ID_TIPO_PAGO
        End Get
        Set(ByVal Value As Decimal)
            _ID_TIPO_PAGO = Value
            OnPropertyChanged("ID_TIPO_PAGO")
        End Set
    End Property 

    Private _NOMBRE_TIPO_PAGO As String
    <Column(Name:="Nombre tipo pago", Storage:="NOMBRE_TIPO_PAGO", DbType:="VARCHAR2(100) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 100)> _
    Public Property NOMBRE_TIPO_PAGO() As String
        Get
            Return _NOMBRE_TIPO_PAGO
        End Get
        Set(ByVal Value As String)
            _NOMBRE_TIPO_PAGO = Value
            OnPropertyChanged("NOMBRE_TIPO_PAGO")
        End Set
    End Property 

    Private _NOMBRE_TIPO_PAGOOld As String
    Public Property NOMBRE_TIPO_PAGOOld() As String
        Get
            Return _NOMBRE_TIPO_PAGOOld
        End Get
        Set(ByVal Value As String)
            _NOMBRE_TIPO_PAGOOld = Value
        End Set
    End Property 

    Private _USERID As String
    <Column(Name:="Userid", Storage:="USERID", DbType:="VARCHAR2(256) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 256)> _
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
    <Column(Name:="Lastupdate", Storage:="LASTUPDATE", DbType:="DATE NOT NULL", Id:=False), _
     DataObjectField(False, False, False)> _
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

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
