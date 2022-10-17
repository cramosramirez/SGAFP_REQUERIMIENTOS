''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.ESTADO_INFORME_AF
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row ESTADO_INFORME_AF en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	20/07/2012	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="ESTADO_INFORME_AF")> Public Class ESTADO_INFORME_AF
    Inherits entidadBase
    Implements IEquatable(Of ESTADO_INFORME_AF), IComparable(Of ESTADO_INFORME_AF)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_ESTADO_INFORME As Decimal, aID_FASE_ESTADO As Decimal, aNOMBRE_ESTADO_INFORME As String, aDESCRIPCION_ESTADO As String, aUSERID As String, aLASTUPDATE As DateTime)
        Me._ID_ESTADO_INFORME = aID_ESTADO_INFORME
        Me._ID_FASE_ESTADO = aID_FASE_ESTADO
        Me._NOMBRE_ESTADO_INFORME = aNOMBRE_ESTADO_INFORME
        Me._DESCRIPCION_ESTADO = aDESCRIPCION_ESTADO
        Me._USERID = aUSERID
        Me._LASTUPDATE = aLASTUPDATE
    End Sub

    Public Function Equals1(ByVal other As ESTADO_INFORME_AF) As Boolean Implements System.IEquatable(Of ESTADO_INFORME_AF).Equals
        Return Me.ID_ESTADO_INFORME = other.ID_ESTADO_INFORME
    End Function

    Public Function CompareTo(ByVal other As ESTADO_INFORME_AF) As Integer Implements System.IComparable(Of ESTADO_INFORME_AF).CompareTo
        If Me.ID_ESTADO_INFORME > other.ID_ESTADO_INFORME Then Return 1
        If Me.ID_ESTADO_INFORME < other.ID_ESTADO_INFORME Then Return -1
        Return 0
    End Function


#Region " Properties "

    Private _ID_ESTADO_INFORME As Decimal
    <Column(Name:="Id estado informe", Storage:="ID_ESTADO_INFORME", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=2, Scale:=0)> _
    Public Property ID_ESTADO_INFORME() As Decimal
        Get
            Return _ID_ESTADO_INFORME
        End Get
        Set(ByVal Value As Decimal)
            _ID_ESTADO_INFORME = Value
            OnPropertyChanged("ID_ESTADO_INFORME")
        End Set
    End Property 

    Private _ID_FASE_ESTADO As Decimal
    <Column(Name:="Id fase estado", Storage:="ID_FASE_ESTADO", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=2, Scale:=0)> _
    Public Property ID_FASE_ESTADO() As Decimal
        Get
            Return _ID_FASE_ESTADO
        End Get
        Set(ByVal Value As Decimal)
            _ID_FASE_ESTADO = Value
            OnPropertyChanged("ID_FASE_ESTADO")
        End Set
    End Property 

    Private _ID_FASE_ESTADOOld As Decimal
    Public Property ID_FASE_ESTADOOld() As Decimal
        Get
            Return _ID_FASE_ESTADOOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_FASE_ESTADOOld = Value
        End Set
    End Property 

    Private _fkID_FASE_ESTADO As FASE_ESTADO_INFORME
    Public Property fkID_FASE_ESTADO() As FASE_ESTADO_INFORME
        Get
            Return _fkID_FASE_ESTADO
        End Get
        Set(ByVal Value As FASE_ESTADO_INFORME)
            _fkID_FASE_ESTADO = Value
        End Set
    End Property 

    Private _NOMBRE_ESTADO_INFORME As String
    <Column(Name:="Nombre estado informe", Storage:="NOMBRE_ESTADO_INFORME", DbType:="VARCHAR2(200) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 200)> _
    Public Property NOMBRE_ESTADO_INFORME() As String
        Get
            Return _NOMBRE_ESTADO_INFORME
        End Get
        Set(ByVal Value As String)
            _NOMBRE_ESTADO_INFORME = Value
            OnPropertyChanged("NOMBRE_ESTADO_INFORME")
        End Set
    End Property

    Private _NOMBRE_ESTADO_INFORMEOld As String
    Public Property NOMBRE_ESTADO_INFORMEOld() As String
        Get
            Return _NOMBRE_ESTADO_INFORMEOld
        End Get
        Set(ByVal Value As String)
            _NOMBRE_ESTADO_INFORMEOld = Value
        End Set
    End Property 

    Private _DESCRIPCION_ESTADO As String
    <Column(Name:="Descripcion estado", Storage:="DESCRIPCION_ESTADO", DbType:="VARCHAR2(256) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 256)> _
    Public Property DESCRIPCION_ESTADO() As String
        Get
            Return _DESCRIPCION_ESTADO
        End Get
        Set(ByVal Value As String)
            _DESCRIPCION_ESTADO = Value
            OnPropertyChanged("DESCRIPCION_ESTADO")
        End Set
    End Property 

    Private _DESCRIPCION_ESTADOOld As String
    Public Property DESCRIPCION_ESTADOOld() As String
        Get
            Return _DESCRIPCION_ESTADOOld
        End Get
        Set(ByVal Value As String)
            _DESCRIPCION_ESTADOOld = Value
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
