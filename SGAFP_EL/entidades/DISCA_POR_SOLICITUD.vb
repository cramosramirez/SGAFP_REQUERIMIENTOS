''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.DISCA_POR_SOLICITUD
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row DISCA_POR_SOLICITUD en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	19/01/2011	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="DISCA_POR_SOLICITUD")> Public Class DISCA_POR_SOLICITUD
    Inherits entidadBase
    Implements IEquatable(Of DISCA_POR_SOLICITUD), IComparable(Of DISCA_POR_SOLICITUD)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_DISCAPACIDAD As Decimal, aID_SOLICITUD As Decimal, aUSERID As String, aLASTUPDATE As DateTime)
        Me._ID_DISCAPACIDAD = aID_DISCAPACIDAD
        Me._ID_SOLICITUD = aID_SOLICITUD
        Me._USERID = aUSERID
        Me._LASTUPDATE = aLASTUPDATE
    End Sub

    Public Function Equals1(ByVal other As DISCA_POR_SOLICITUD) As Boolean Implements System.IEquatable(Of DISCA_POR_SOLICITUD).Equals
        Return Me.ID_DISCAPACIDAD = other.ID_DISCAPACIDAD And Me.ID_SOLICITUD = other.ID_SOLICITUD
    End Function

    Public Function CompareTo(ByVal other As DISCA_POR_SOLICITUD) As Integer Implements System.IComparable(Of DISCA_POR_SOLICITUD).CompareTo
        If Me.ID_DISCAPACIDAD > other.ID_DISCAPACIDAD Then
            If Me.ID_SOLICITUD > other.ID_SOLICITUD Then Return 1
            If Me.ID_SOLICITUD < other.ID_SOLICITUD Then Return -1
        Else
            Return -1
        End If
        Return 0
    End Function


#Region " Properties "

    Private _ID_DISCAPACIDAD As Decimal
    <Column(Name:="Id discapacidad", Storage:="ID_DISCAPACIDAD", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=2, Scale:=0)> _
    Public Property ID_DISCAPACIDAD() As Decimal
        Get
            Return _ID_DISCAPACIDAD
        End Get
        Set(ByVal Value As Decimal)
            _ID_DISCAPACIDAD = Value
            OnPropertyChanged("ID_DISCAPACIDAD")
        End Set
    End Property 

    Private _fkID_DISCAPACIDAD As DISCAPACIDAD
    Public Property fkID_DISCAPACIDAD() As DISCAPACIDAD
        Get
            Return _fkID_DISCAPACIDAD
        End Get
        Set(ByVal Value As DISCAPACIDAD)
            _fkID_DISCAPACIDAD = Value
        End Set
    End Property 

    Private _ID_SOLICITUD As Decimal
    <Column(Name:="Id solicitud", Storage:="ID_SOLICITUD", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_SOLICITUD() As Decimal
        Get
            Return _ID_SOLICITUD
        End Get
        Set(ByVal Value As Decimal)
            _ID_SOLICITUD = Value
            OnPropertyChanged("ID_SOLICITUD")
        End Set
    End Property 

    Private _fkID_SOLICITUD As SOLICITUD_INSCRIPCION_AF
    Public Property fkID_SOLICITUD() As SOLICITUD_INSCRIPCION_AF
        Get
            Return _fkID_SOLICITUD
        End Get
        Set(ByVal Value As SOLICITUD_INSCRIPCION_AF)
            _fkID_SOLICITUD = Value
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
