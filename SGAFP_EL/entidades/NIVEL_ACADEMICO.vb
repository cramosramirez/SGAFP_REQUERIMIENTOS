''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.NIVEL_ACADEMICO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row NIVEL_ACADEMICO en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	19/01/2011	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="NIVEL_ACADEMICO")> Public Class NIVEL_ACADEMICO
    Inherits entidadBase
    Implements IEquatable(Of NIVEL_ACADEMICO), IComparable(Of NIVEL_ACADEMICO)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_NIVEL_ACADEMICO As Decimal, aNOMBRE_NIVEL_ACADEMICO As String, aUSERID As String, aLASTUPDATE As DateTime)
        Me._ID_NIVEL_ACADEMICO = aID_NIVEL_ACADEMICO
        Me._NOMBRE_NIVEL_ACADEMICO = aNOMBRE_NIVEL_ACADEMICO
        Me._USERID = aUSERID
        Me._LASTUPDATE = aLASTUPDATE
    End Sub

    Public Function Equals1(ByVal other As NIVEL_ACADEMICO) As Boolean Implements System.IEquatable(Of NIVEL_ACADEMICO).Equals
        Return Me.ID_NIVEL_ACADEMICO = other.ID_NIVEL_ACADEMICO
    End Function

    Public Function CompareTo(ByVal other As NIVEL_ACADEMICO) As Integer Implements System.IComparable(Of NIVEL_ACADEMICO).CompareTo
        If Me.ID_NIVEL_ACADEMICO > other.ID_NIVEL_ACADEMICO Then Return 1
        If Me.ID_NIVEL_ACADEMICO < other.ID_NIVEL_ACADEMICO Then Return -1
        Return 0
    End Function


#Region " Properties "

    Private _ID_NIVEL_ACADEMICO As Decimal
    <Column(Name:="Id nivel academico", Storage:="ID_NIVEL_ACADEMICO", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=2, Scale:=0)> _
    Public Property ID_NIVEL_ACADEMICO() As Decimal
        Get
            Return _ID_NIVEL_ACADEMICO
        End Get
        Set(ByVal Value As Decimal)
            _ID_NIVEL_ACADEMICO = Value
            OnPropertyChanged("ID_NIVEL_ACADEMICO")
        End Set
    End Property 

    Private _NOMBRE_NIVEL_ACADEMICO As String
    <Column(Name:="Nombre nivel academico", Storage:="NOMBRE_NIVEL_ACADEMICO", DbType:="VARCHAR2(50)", Id:=False), _
     DataObjectField(False, False, True, 50)> _
    Public Property NOMBRE_NIVEL_ACADEMICO() As String
        Get
            Return _NOMBRE_NIVEL_ACADEMICO
        End Get
        Set(ByVal Value As String)
            _NOMBRE_NIVEL_ACADEMICO = Value
            OnPropertyChanged("NOMBRE_NIVEL_ACADEMICO")
        End Set
    End Property 

    Private _NOMBRE_NIVEL_ACADEMICOOld As String
    Public Property NOMBRE_NIVEL_ACADEMICOOld() As String
        Get
            Return _NOMBRE_NIVEL_ACADEMICOOld
        End Get
        Set(ByVal Value As String)
            _NOMBRE_NIVEL_ACADEMICOOld = Value
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
