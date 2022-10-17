''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.DISCAPACIDAD
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row DISCAPACIDAD en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	19/01/2011	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="DISCAPACIDAD")> Public Class DISCAPACIDAD
    Inherits entidadBase
    Implements IEquatable(Of DISCAPACIDAD), IComparable(Of DISCAPACIDAD)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_DISCAPACIDAD As Decimal, aNOMBRE_DISCAPACIDAD As String, aUSERID As String, aLASTUPDATE As DateTime)
        Me._ID_DISCAPACIDAD = aID_DISCAPACIDAD
        Me._NOMBRE_DISCAPACIDAD = aNOMBRE_DISCAPACIDAD
        Me._USERID = aUSERID
        Me._LASTUPDATE = aLASTUPDATE
    End Sub

    Public Function Equals1(ByVal other As DISCAPACIDAD) As Boolean Implements System.IEquatable(Of DISCAPACIDAD).Equals
        Return Me.ID_DISCAPACIDAD = other.ID_DISCAPACIDAD
    End Function

    Public Function CompareTo(ByVal other As DISCAPACIDAD) As Integer Implements System.IComparable(Of DISCAPACIDAD).CompareTo
        If Me.ID_DISCAPACIDAD > other.ID_DISCAPACIDAD Then Return 1
        If Me.ID_DISCAPACIDAD < other.ID_DISCAPACIDAD Then Return -1
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

    Private _NOMBRE_DISCAPACIDAD As String
    <Column(Name:="Nombre discapacidad", Storage:="NOMBRE_DISCAPACIDAD", DbType:="VARCHAR2(100) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 100)> _
    Public Property NOMBRE_DISCAPACIDAD() As String
        Get
            Return _NOMBRE_DISCAPACIDAD
        End Get
        Set(ByVal Value As String)
            _NOMBRE_DISCAPACIDAD = Value
            OnPropertyChanged("NOMBRE_DISCAPACIDAD")
        End Set
    End Property 

    Private _NOMBRE_DISCAPACIDADOld As String
    Public Property NOMBRE_DISCAPACIDADOld() As String
        Get
            Return _NOMBRE_DISCAPACIDADOld
        End Get
        Set(ByVal Value As String)
            _NOMBRE_DISCAPACIDADOld = Value
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
    Private _DISCA_POR_SOLICITUDDISCAPACIDAD As ListaDISCA_POR_SOLICITUD
    Public Property DISCA_POR_SOLICITUDDISCAPACIDAD() As ListaDISCA_POR_SOLICITUD
        Get
            Return _DISCA_POR_SOLICITUDDISCAPACIDAD
        End Get
        Set(ByVal Value As ListaDISCA_POR_SOLICITUD)
            _DISCA_POR_SOLICITUDDISCAPACIDAD = Value
        End Set
    End Property 

    Private _DISCA_POR_PARTICIPANTEDISCAPACIDAD As ListaDISCA_POR_PARTICIPANTE
    Public Property DISCA_POR_PARTICIPANTEDISCAPACIDAD() As ListaDISCA_POR_PARTICIPANTE
        Get
            Return _DISCA_POR_PARTICIPANTEDISCAPACIDAD
        End Get
        Set(ByVal Value As ListaDISCA_POR_PARTICIPANTE)
            _DISCA_POR_PARTICIPANTEDISCAPACIDAD = Value
        End Set
    End Property 

#End Region
#End Region
End Class
