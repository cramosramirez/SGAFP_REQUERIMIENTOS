''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.OPCION_GRUPO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite tener un registro de la tabla OPCION_GRUPO en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="OPCION_GRUPO")> Public Class OPCION_GRUPO
    Inherits entidadBase
    Implements IEquatable(Of OPCION_GRUPO), IComparable(Of OPCION_GRUPO)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_OPCION_GRUPO As Decimal, aID_OPCION_MENU As Decimal, aID_GRUPO_USUARIO As Decimal, aFECHA_INGRESO As DateTime, aESTADO As String, aUSERID As String, aLASTUPDATE As DateTime)
        Me._ID_OPCION_GRUPO = aID_OPCION_GRUPO
        Me._ID_OPCION_MENU = aID_OPCION_MENU
        Me._ID_GRUPO_USUARIO = aID_GRUPO_USUARIO
        Me._FECHA_INGRESO = aFECHA_INGRESO
        Me._ESTADO = aESTADO
        Me._USERID = aUSERID
        Me._LASTUPDATE = aLASTUPDATE
    End Sub

    Public Function Equals1(ByVal other As OPCION_GRUPO) As Boolean Implements System.IEquatable(Of OPCION_GRUPO).Equals
        Return Me.ID_OPCION_GRUPO = other.ID_OPCION_GRUPO
    End Function

    Public Function CompareTo(ByVal other As OPCION_GRUPO) As Integer Implements System.IComparable(Of OPCION_GRUPO).CompareTo
        If Me.ID_OPCION_GRUPO > other.ID_OPCION_GRUPO Then Return 1
        If Me.ID_OPCION_GRUPO < other.ID_OPCION_GRUPO Then Return -1
        Return 0
    End Function


#Region " Propiedades "

    Private _ID_OPCION_GRUPO As Decimal
    <Column(Name:="Id opcion grupo", Storage:="ID_OPCION_GRUPO", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_OPCION_GRUPO() As Decimal
        Get
            Return _ID_OPCION_GRUPO
        End Get
        Set(ByVal Value As Decimal)
            _ID_OPCION_GRUPO = Value
            OnPropertyChanged("ID_OPCION_GRUPO")
        End Set
    End Property 

    Private _ID_OPCION_MENU As Decimal
    <Column(Name:="Id opcion menu", Storage:="ID_OPCION_MENU", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_OPCION_MENU() As Decimal
        Get
            Return _ID_OPCION_MENU
        End Get
        Set(ByVal Value As Decimal)
            _ID_OPCION_MENU = Value
            OnPropertyChanged("ID_OPCION_MENU")
        End Set
    End Property 

    Private _ID_OPCION_MENUOld As Decimal
    Public Property ID_OPCION_MENUOld() As Decimal
        Get
            Return _ID_OPCION_MENUOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_OPCION_MENUOld = Value
        End Set
    End Property 

    Private _fkID_OPCION_MENU As OPCION_MENU
    Public Property fkID_OPCION_MENU() As OPCION_MENU
        Get
            Return _fkID_OPCION_MENU
        End Get
        Set(ByVal Value As OPCION_MENU)
            _fkID_OPCION_MENU = Value
        End Set
    End Property 

    Private _ID_GRUPO_USUARIO As Decimal
    <Column(Name:="Id grupo usuario", Storage:="ID_GRUPO_USUARIO", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_GRUPO_USUARIO() As Decimal
        Get
            Return _ID_GRUPO_USUARIO
        End Get
        Set(ByVal Value As Decimal)
            _ID_GRUPO_USUARIO = Value
            OnPropertyChanged("ID_GRUPO_USUARIO")
        End Set
    End Property 

    Private _ID_GRUPO_USUARIOOld As Decimal
    Public Property ID_GRUPO_USUARIOOld() As Decimal
        Get
            Return _ID_GRUPO_USUARIOOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_GRUPO_USUARIOOld = Value
        End Set
    End Property 

    Private _fkID_GRUPO_USUARIO As GRUPO_USUARIO
    Public Property fkID_GRUPO_USUARIO() As GRUPO_USUARIO
        Get
            Return _fkID_GRUPO_USUARIO
        End Get
        Set(ByVal Value As GRUPO_USUARIO)
            _fkID_GRUPO_USUARIO = Value
        End Set
    End Property 

    Private _FECHA_INGRESO As DateTime
    <Column(Name:="Fecha ingreso", Storage:="FECHA_INGRESO", DbType:="DATE", Id:=False), _
     DataObjectField(False, False, True)> _
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

    Private _ESTADO As String
    <Column(Name:="Estado", Storage:="ESTADO", DbType:="CHAR(1)", Id:=False), _
     DataObjectField(False, False, True, 1)> _
    Public Property ESTADO() As String
        Get
            Return _ESTADO
        End Get
        Set(ByVal Value As String)
            _ESTADO = Value
            OnPropertyChanged("ESTADO")
        End Set
    End Property 

    Private _ESTADOOld As String
    Public Property ESTADOOld() As String
        Get
            Return _ESTADOOld
        End Get
        Set(ByVal Value As String)
            _ESTADOOld = Value
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

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
