''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.UNIDAD_ORGANIZATIVA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row UNIDAD_ORGANIZATIVA en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	05/10/2012	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="UNIDAD_ORGANIZATIVA")> Public Class UNIDAD_ORGANIZATIVA
    Inherits entidadBase
    Implements IEquatable(Of UNIDAD_ORGANIZATIVA), IComparable(Of UNIDAD_ORGANIZATIVA)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_UNIDAD_ORGANIZATIVA As Decimal, aNOMBRE_UNIDAD As String, aCODIGO_UNIDAD As String, aID_UNIDAD_PADRE As Decimal, aESTADO As Decimal, aUSERID As String, aLASTUPDATE As DateTime)
        Me._ID_UNIDAD_ORGANIZATIVA = aID_UNIDAD_ORGANIZATIVA
        Me._NOMBRE_UNIDAD = aNOMBRE_UNIDAD
        Me._CODIGO_UNIDAD = aCODIGO_UNIDAD
        Me._ID_UNIDAD_PADRE = aID_UNIDAD_PADRE
        Me._ESTADO = aESTADO
        Me._USERID = aUSERID
        Me._LASTUPDATE = aLASTUPDATE
    End Sub

    Public Function Equals1(ByVal other As UNIDAD_ORGANIZATIVA) As Boolean Implements System.IEquatable(Of UNIDAD_ORGANIZATIVA).Equals
        Return Me.ID_UNIDAD_ORGANIZATIVA = other.ID_UNIDAD_ORGANIZATIVA
    End Function

    Public Function CompareTo(ByVal other As UNIDAD_ORGANIZATIVA) As Integer Implements System.IComparable(Of UNIDAD_ORGANIZATIVA).CompareTo
        If Me.ID_UNIDAD_ORGANIZATIVA > other.ID_UNIDAD_ORGANIZATIVA Then Return 1
        If Me.ID_UNIDAD_ORGANIZATIVA < other.ID_UNIDAD_ORGANIZATIVA Then Return -1
        Return 0
    End Function


#Region " Properties "

    Private _ID_UNIDAD_ORGANIZATIVA As Decimal
    <Column(Name:="Id unidad organizativa", Storage:="ID_UNIDAD_ORGANIZATIVA", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_UNIDAD_ORGANIZATIVA() As Decimal
        Get
            Return _ID_UNIDAD_ORGANIZATIVA
        End Get
        Set(ByVal Value As Decimal)
            _ID_UNIDAD_ORGANIZATIVA = Value
            OnPropertyChanged("ID_UNIDAD_ORGANIZATIVA")
        End Set
    End Property 

    Private _NOMBRE_UNIDAD As String
    <Column(Name:="Nombre unidad", Storage:="NOMBRE_UNIDAD", DbType:="VARCHAR2(75) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 75)> _
    Public Property NOMBRE_UNIDAD() As String
        Get
            Return _NOMBRE_UNIDAD
        End Get
        Set(ByVal Value As String)
            _NOMBRE_UNIDAD = Value
            OnPropertyChanged("NOMBRE_UNIDAD")
        End Set
    End Property 

    Private _NOMBRE_UNIDADOld As String
    Public Property NOMBRE_UNIDADOld() As String
        Get
            Return _NOMBRE_UNIDADOld
        End Get
        Set(ByVal Value As String)
            _NOMBRE_UNIDADOld = Value
        End Set
    End Property 

    Private _CODIGO_UNIDAD As String
    <Column(Name:="Codigo unidad", Storage:="CODIGO_UNIDAD", DbType:="VARCHAR2(6) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 6)> _
    Public Property CODIGO_UNIDAD() As String
        Get
            Return _CODIGO_UNIDAD
        End Get
        Set(ByVal Value As String)
            _CODIGO_UNIDAD = Value
            OnPropertyChanged("CODIGO_UNIDAD")
        End Set
    End Property 

    Private _CODIGO_UNIDADOld As String
    Public Property CODIGO_UNIDADOld() As String
        Get
            Return _CODIGO_UNIDADOld
        End Get
        Set(ByVal Value As String)
            _CODIGO_UNIDADOld = Value
        End Set
    End Property 

    Private _ID_UNIDAD_PADRE As Decimal
    <Column(Name:="Id unidad padre", Storage:="ID_UNIDAD_PADRE", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_UNIDAD_PADRE() As Decimal
        Get
            Return _ID_UNIDAD_PADRE
        End Get
        Set(ByVal Value As Decimal)
            _ID_UNIDAD_PADRE = Value
            OnPropertyChanged("ID_UNIDAD_PADRE")
        End Set
    End Property 

    Private _ID_UNIDAD_PADREOld As Decimal
    Public Property ID_UNIDAD_PADREOld() As Decimal
        Get
            Return _ID_UNIDAD_PADREOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_UNIDAD_PADREOld = Value
        End Set
    End Property 

    Private _fkID_UNIDAD_PADRE As UNIDAD_ORGANIZATIVA
    Public Property fkID_UNIDAD_PADRE() As UNIDAD_ORGANIZATIVA
        Get
            Return _fkID_UNIDAD_PADRE
        End Get
        Set(ByVal Value As UNIDAD_ORGANIZATIVA)
            _fkID_UNIDAD_PADRE = Value
        End Set
    End Property 

    Private _ESTADO As Decimal
    <Column(Name:="Estado", Storage:="ESTADO", DbType:="CHAR(1)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=0, Scale:=0)> _
    Public Property ESTADO() As Decimal
        Get
            Return _ESTADO
        End Get
        Set(ByVal Value As Decimal)
            _ESTADO = Value
            OnPropertyChanged("ESTADO")
        End Set
    End Property 

    Private _ESTADOOld As Decimal
    Public Property ESTADOOld() As Decimal
        Get
            Return _ESTADOOld
        End Get
        Set(ByVal Value As Decimal)
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
