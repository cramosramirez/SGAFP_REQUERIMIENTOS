''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.SUB_AREA_FORMACION
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row SUB_AREA_FORMACION en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	07/03/2012	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="SUB_AREA_FORMACION")> Public Class SUB_AREA_FORMACION
    Inherits entidadBase
    Implements IEquatable(Of SUB_AREA_FORMACION), IComparable(Of SUB_AREA_FORMACION)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_SUBAREA_FORMACION As Decimal, aID_AREA_FORMACION As Decimal, aNOMBRE_SUBAREA As String, aUSERID As String, aLASTUPDATE As DateTime)
        Me._ID_SUBAREA_FORMACION = aID_SUBAREA_FORMACION
        Me._ID_AREA_FORMACION = aID_AREA_FORMACION
        Me._NOMBRE_SUBAREA = aNOMBRE_SUBAREA
        Me._USERID = aUSERID
        Me._LASTUPDATE = aLASTUPDATE
    End Sub

    Public Function Equals1(ByVal other As SUB_AREA_FORMACION) As Boolean Implements System.IEquatable(Of SUB_AREA_FORMACION).Equals
        Return Me.ID_SUBAREA_FORMACION = other.ID_SUBAREA_FORMACION
    End Function

    Public Function CompareTo(ByVal other As SUB_AREA_FORMACION) As Integer Implements System.IComparable(Of SUB_AREA_FORMACION).CompareTo
        If Me.ID_SUBAREA_FORMACION > other.ID_SUBAREA_FORMACION Then Return 1
        If Me.ID_SUBAREA_FORMACION < other.ID_SUBAREA_FORMACION Then Return -1
        Return 0
    End Function


#Region " Properties "

    Private _ID_SUBAREA_FORMACION As Decimal
    <Column(Name:="Id subarea formacion", Storage:="ID_SUBAREA_FORMACION", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_SUBAREA_FORMACION() As Decimal
        Get
            Return _ID_SUBAREA_FORMACION
        End Get
        Set(ByVal Value As Decimal)
            _ID_SUBAREA_FORMACION = Value
            OnPropertyChanged("ID_SUBAREA_FORMACION")
        End Set
    End Property 

    Private _ID_AREA_FORMACION As Decimal
    <Column(Name:="Id area formacion", Storage:="ID_AREA_FORMACION", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_AREA_FORMACION() As Decimal
        Get
            Return _ID_AREA_FORMACION
        End Get
        Set(ByVal Value As Decimal)
            _ID_AREA_FORMACION = Value
            OnPropertyChanged("ID_AREA_FORMACION")
        End Set
    End Property 

    Private _ID_AREA_FORMACIONOld As Decimal
    Public Property ID_AREA_FORMACIONOld() As Decimal
        Get
            Return _ID_AREA_FORMACIONOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_AREA_FORMACIONOld = Value
        End Set
    End Property 

    Private _fkID_AREA_FORMACION As AREA_FORMACION
    Public Property fkID_AREA_FORMACION() As AREA_FORMACION
        Get
            Return _fkID_AREA_FORMACION
        End Get
        Set(ByVal Value As AREA_FORMACION)
            _fkID_AREA_FORMACION = Value
        End Set
    End Property 

    Private _NOMBRE_SUBAREA As String
    <Column(Name:="Nombre subarea", Storage:="NOMBRE_SUBAREA", DbType:="VARCHAR2(75) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 75)> _
    Public Property NOMBRE_SUBAREA() As String
        Get
            Return _NOMBRE_SUBAREA
        End Get
        Set(ByVal Value As String)
            _NOMBRE_SUBAREA = Value
            OnPropertyChanged("NOMBRE_SUBAREA")
        End Set
    End Property 

    Private _NOMBRE_SUBAREAOld As String
    Public Property NOMBRE_SUBAREAOld() As String
        Get
            Return _NOMBRE_SUBAREAOld
        End Get
        Set(ByVal Value As String)
            _NOMBRE_SUBAREAOld = Value
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
    Private _CONTRATO_SUB_AREA_FORMACIONSUB_AREA_FORMACION As ListaCONTRATO_SUB_AREA_FORMACION
    Public Property CONTRATO_SUB_AREA_FORMACIONSUB_AREA_FORMACION() As ListaCONTRATO_SUB_AREA_FORMACION
        Get
            Return _CONTRATO_SUB_AREA_FORMACIONSUB_AREA_FORMACION
        End Get
        Set(ByVal Value As ListaCONTRATO_SUB_AREA_FORMACION)
            _CONTRATO_SUB_AREA_FORMACIONSUB_AREA_FORMACION = Value
        End Set
    End Property 

#End Region
#End Region
End Class
