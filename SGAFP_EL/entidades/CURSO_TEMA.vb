''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.CURSO_TEMA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row CURSO_TEMA en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/12/2011	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="CURSO_TEMA")> Public Class CURSO_TEMA
    Inherits entidadBase
    Implements IEquatable(Of CURSO_TEMA), IComparable(Of CURSO_TEMA)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(ByVal aID_TEMA_CURSO As Decimal, ByVal aID_SUBAREA_FORMACION As Decimal, ByVal aTEMA_CURSO As String, ByVal aDURACION_HORAS As Decimal, ByVal aFECHA_ACREDITACION As DateTime, ByVal aNOTAS As String, ByVal aCODIGO_PROGRAMA As String, ByVal aREF_ID_TEMA_CURSO As Decimal, ByVal aID_AREA_FORMACION As Decimal, ByVal aUSERID As String, ByVal aLASTUPDATE As DateTime)
        Me._ID_TEMA_CURSO = aID_TEMA_CURSO
        Me._ID_SUBAREA_FORMACION = aID_SUBAREA_FORMACION
        Me._TEMA_CURSO = aTEMA_CURSO
        Me._DURACION_HORAS = aDURACION_HORAS
        Me._FECHA_ACREDITACION = aFECHA_ACREDITACION
        Me._NOTAS = aNOTAS
        Me._CODIGO_PROGRAMA = aCODIGO_PROGRAMA
        Me._REF_ID_TEMA_CURSO = aREF_ID_TEMA_CURSO
        Me._ID_AREA_FORMACION = aID_AREA_FORMACION
        Me._USERID = aUSERID
        Me._LASTUPDATE = aLASTUPDATE
    End Sub

    Public Function Equals1(ByVal other As CURSO_TEMA) As Boolean Implements System.IEquatable(Of CURSO_TEMA).Equals
        Return Me.ID_TEMA_CURSO = other.ID_TEMA_CURSO
    End Function

    Public Function CompareTo(ByVal other As CURSO_TEMA) As Integer Implements System.IComparable(Of CURSO_TEMA).CompareTo
        If Me.ID_TEMA_CURSO > other.ID_TEMA_CURSO Then Return 1
        If Me.ID_TEMA_CURSO < other.ID_TEMA_CURSO Then Return -1
        Return 0
    End Function


#Region " Properties "

    Private _ID_TEMA_CURSO As Decimal
    <Column(Name:="Id tema curso", Storage:="ID_TEMA_CURSO", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_TEMA_CURSO() As Decimal
        Get
            Return _ID_TEMA_CURSO
        End Get
        Set(ByVal Value As Decimal)
            _ID_TEMA_CURSO = Value
            OnPropertyChanged("ID_TEMA_CURSO")
        End Set
    End Property 

    Private _ID_SUBAREA_FORMACION As Decimal
    <Column(Name:="Id subarea formacion", Storage:="ID_SUBAREA_FORMACION", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_SUBAREA_FORMACION() As Decimal
        Get
            Return _ID_SUBAREA_FORMACION
        End Get
        Set(ByVal Value As Decimal)
            _ID_SUBAREA_FORMACION = Value
            OnPropertyChanged("ID_SUBAREA_FORMACION")
        End Set
    End Property 

    Private _ID_SUBAREA_FORMACIONOld As Decimal
    Public Property ID_SUBAREA_FORMACIONOld() As Decimal
        Get
            Return _ID_SUBAREA_FORMACIONOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_SUBAREA_FORMACIONOld = Value
        End Set
    End Property 

    Private _fkID_SUBAREA_FORMACION As SUB_AREA_FORMACION
    Public Property fkID_SUBAREA_FORMACION() As SUB_AREA_FORMACION
        Get
            Return _fkID_SUBAREA_FORMACION
        End Get
        Set(ByVal Value As SUB_AREA_FORMACION)
            _fkID_SUBAREA_FORMACION = Value
        End Set
    End Property 

    Private _TEMA_CURSO As String
    <Column(Name:="Tema curso", Storage:="TEMA_CURSO", DbType:="VARCHAR2(150)", Id:=False), _
     DataObjectField(False, False, True, 150)> _
    Public Property TEMA_CURSO() As String
        Get
            Return _TEMA_CURSO
        End Get
        Set(ByVal Value As String)
            _TEMA_CURSO = Value
            OnPropertyChanged("TEMA_CURSO")
        End Set
    End Property 

    Private _TEMA_CURSOOld As String
    Public Property TEMA_CURSOOld() As String
        Get
            Return _TEMA_CURSOOld
        End Get
        Set(ByVal Value As String)
            _TEMA_CURSOOld = Value
        End Set
    End Property 

    Private _DURACION_HORAS As Decimal
    <Column(Name:="Duracion horas", Storage:="DURACION_HORAS", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=0, Scale:=0)> _
    Public Property DURACION_HORAS() As Decimal
        Get
            Return _DURACION_HORAS
        End Get
        Set(ByVal Value As Decimal)
            _DURACION_HORAS = Value
            OnPropertyChanged("DURACION_HORAS")
        End Set
    End Property 

    Private _DURACION_HORASOld As Decimal
    Public Property DURACION_HORASOld() As Decimal
        Get
            Return _DURACION_HORASOld
        End Get
        Set(ByVal Value As Decimal)
            _DURACION_HORASOld = Value
        End Set
    End Property 

    Private _FECHA_ACREDITACION As DateTime
    <Column(Name:="Fecha acreditacion", Storage:="FECHA_ACREDITACION", DbType:="DATE", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property FECHA_ACREDITACION() As DateTime
        Get
            Return _FECHA_ACREDITACION
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_ACREDITACION = Value
            OnPropertyChanged("FECHA_ACREDITACION")
        End Set
    End Property 

    Private _FECHA_ACREDITACIONOld As DateTime
    Public Property FECHA_ACREDITACIONOld() As DateTime
        Get
            Return _FECHA_ACREDITACIONOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_ACREDITACIONOld = Value
        End Set
    End Property 

    Private _NOTAS As String
    <Column(Name:="Notas", Storage:="NOTAS", DbType:="VARCHAR2(255)", Id:=False), _
     DataObjectField(False, False, True, 255)> _
    Public Property NOTAS() As String
        Get
            Return _NOTAS
        End Get
        Set(ByVal Value As String)
            _NOTAS = Value
            OnPropertyChanged("NOTAS")
        End Set
    End Property 

    Private _NOTASOld As String
    Public Property NOTASOld() As String
        Get
            Return _NOTASOld
        End Get
        Set(ByVal Value As String)
            _NOTASOld = Value
        End Set
    End Property 

    Private _CODIGO_PROGRAMA As String
    <Column(Name:="Codigo programa", Storage:="CODIGO_PROGRAMA", DbType:="VARCHAR(30)", Id:=False), _
     DataObjectField(False, False, True, 30)> _
    Public Property CODIGO_PROGRAMA() As String
        Get
            Return _CODIGO_PROGRAMA
        End Get
        Set(ByVal Value As String)
            _CODIGO_PROGRAMA = Value
            OnPropertyChanged("CODIGO_PROGRAMA")
        End Set
    End Property

    Private _CODIGO_PROGRAMAOld As String
    Public Property CODIGO_PROGRAMAOld() As String
        Get
            Return _CODIGO_PROGRAMAOld
        End Get
        Set(ByVal Value As String)
            _CODIGO_PROGRAMAOld = Value
        End Set
    End Property 

    Private _REF_ID_TEMA_CURSO As Decimal
    <Column(Name:="Ref id tema curso", Storage:="REF_ID_TEMA_CURSO", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=8, Scale:=0)> _
    Public Property REF_ID_TEMA_CURSO() As Decimal
        Get
            Return _REF_ID_TEMA_CURSO
        End Get
        Set(ByVal Value As Decimal)
            _REF_ID_TEMA_CURSO = Value
            OnPropertyChanged("REF_ID_TEMA_CURSO")
        End Set
    End Property 

    Private _REF_ID_TEMA_CURSOOld As Decimal
    Public Property REF_ID_TEMA_CURSOOld() As Decimal
        Get
            Return _REF_ID_TEMA_CURSOOld
        End Get
        Set(ByVal Value As Decimal)
            _REF_ID_TEMA_CURSOOld = Value
        End Set
    End Property

    Private _ID_AREA_FORMACION As Decimal
    <Column(Name:="Id area formacion", Storage:="ID_AREA_FORMACION", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=0, Scale:=0)> _
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

    Private _fkREF_ID_TEMA_CURSO As CURSO_TEMA
    Public Property fkREF_ID_TEMA_CURSO() As CURSO_TEMA
        Get
            Return _fkREF_ID_TEMA_CURSO
        End Get
        Set(ByVal Value As CURSO_TEMA)
            _fkREF_ID_TEMA_CURSO = Value
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
