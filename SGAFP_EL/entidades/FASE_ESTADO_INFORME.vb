''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.FASE_ESTADO_INFORME
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row FASE_ESTADO_INFORME en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	20/07/2012	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="FASE_ESTADO_INFORME")> Public Class FASE_ESTADO_INFORME
    Inherits entidadBase
    Implements IEquatable(Of FASE_ESTADO_INFORME), IComparable(Of FASE_ESTADO_INFORME)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_FASE_ESTADO As Decimal, aNOMBRE_FASE_ESTADO As String, aUSERID As String, aLASTUPDATE As DateTime)
        Me._ID_FASE_ESTADO = aID_FASE_ESTADO
        Me._NOMBRE_FASE_ESTADO = aNOMBRE_FASE_ESTADO
        Me._USERID = aUSERID
        Me._LASTUPDATE = aLASTUPDATE
    End Sub

    Public Function Equals1(ByVal other As FASE_ESTADO_INFORME) As Boolean Implements System.IEquatable(Of FASE_ESTADO_INFORME).Equals
        Return Me.ID_FASE_ESTADO = other.ID_FASE_ESTADO
    End Function

    Public Function CompareTo(ByVal other As FASE_ESTADO_INFORME) As Integer Implements System.IComparable(Of FASE_ESTADO_INFORME).CompareTo
        If Me.ID_FASE_ESTADO > other.ID_FASE_ESTADO Then Return 1
        If Me.ID_FASE_ESTADO < other.ID_FASE_ESTADO Then Return -1
        Return 0
    End Function


#Region " Properties "

    Private _ID_FASE_ESTADO As Decimal
    <Column(Name:="Id fase estado", Storage:="ID_FASE_ESTADO", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=2, Scale:=0)> _
    Public Property ID_FASE_ESTADO() As Decimal
        Get
            Return _ID_FASE_ESTADO
        End Get
        Set(ByVal Value As Decimal)
            _ID_FASE_ESTADO = Value
            OnPropertyChanged("ID_FASE_ESTADO")
        End Set
    End Property 

    Private _NOMBRE_FASE_ESTADO As String
    <Column(Name:="Nombre fase estado", Storage:="NOMBRE_FASE_ESTADO", DbType:="VARCHAR2(256) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 256)> _
    Public Property NOMBRE_FASE_ESTADO() As String
        Get
            Return _NOMBRE_FASE_ESTADO
        End Get
        Set(ByVal Value As String)
            _NOMBRE_FASE_ESTADO = Value
            OnPropertyChanged("NOMBRE_FASE_ESTADO")
        End Set
    End Property 

    Private _NOMBRE_FASE_ESTADOOld As String
    Public Property NOMBRE_FASE_ESTADOOld() As String
        Get
            Return _NOMBRE_FASE_ESTADOOld
        End Get
        Set(ByVal Value As String)
            _NOMBRE_FASE_ESTADOOld = Value
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
