''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.ASISTENCIA_AF
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite tener un registro de la tabla ASISTENCIA_AF en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' 	[ecarias]	07/04/2010	Se agregaron columnas de Auditoría USERID, LASTUPDATE
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="ASISTENCIA_AF")> Public Class ASISTENCIA_AF
    Inherits entidadBase
    Implements IEquatable(Of ASISTENCIA_AF), IComparable(Of ASISTENCIA_AF)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(ByVal aID_ASISTENCIA_AF As Decimal, ByVal aID_ACCION_FORMATIVA As Decimal, ByVal aFECHA As DateTime, ByVal aINSTRUCTOR As String, ByVal aNOTAS As String, ByVal aUSERID As String, ByVal aLASTUPDATE As DateTime, ByVal eCANTIDAD_HORAS As Decimal)
        Me._ID_ASISTENCIA_AF = aID_ASISTENCIA_AF
        Me._ID_ACCION_FORMATIVA = aID_ACCION_FORMATIVA
        Me._FECHA = aFECHA
        Me._INSTRUCTOR = aINSTRUCTOR
        Me._NOTAS = aNOTAS
        Me._USERID = aUSERID
        Me._LASTUPDATE = aLASTUPDATE
        Me._CANTIDAD_HORAS = eCANTIDAD_HORAS
    End Sub

    Public Function Equals1(ByVal other As ASISTENCIA_AF) As Boolean Implements System.IEquatable(Of ASISTENCIA_AF).Equals
        Return Me.ID_ASISTENCIA_AF = other.ID_ASISTENCIA_AF
    End Function

    Public Function CompareTo(ByVal other As ASISTENCIA_AF) As Integer Implements System.IComparable(Of ASISTENCIA_AF).CompareTo
        If Me.ID_ASISTENCIA_AF > other.ID_ASISTENCIA_AF Then Return 1
        If Me.ID_ASISTENCIA_AF < other.ID_ASISTENCIA_AF Then Return -1
        Return 0
    End Function


#Region " Propiedades "

    Private _ID_ASISTENCIA_AF As Decimal
    <Column(Name:="Id asistencia af", Storage:="ID_ASISTENCIA_AF", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_ASISTENCIA_AF() As Decimal
        Get
            Return _ID_ASISTENCIA_AF
        End Get
        Set(ByVal Value As Decimal)
            _ID_ASISTENCIA_AF = Value
            OnPropertyChanged("ID_ASISTENCIA_AF")
        End Set
    End Property

    Private _ID_ACCION_FORMATIVA As Decimal
    <Column(Name:="Id accion formativa", Storage:="ID_ACCION_FORMATIVA", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_ACCION_FORMATIVA() As Decimal
        Get
            Return _ID_ACCION_FORMATIVA
        End Get
        Set(ByVal Value As Decimal)
            _ID_ACCION_FORMATIVA = Value
            OnPropertyChanged("ID_ACCION_FORMATIVA")
        End Set
    End Property

    Private _ID_ACCION_FORMATIVAOld As Decimal
    Public Property ID_ACCION_FORMATIVAOld() As Decimal
        Get
            Return _ID_ACCION_FORMATIVAOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_ACCION_FORMATIVAOld = Value
        End Set
    End Property

    Private _fkID_ACCION_FORMATIVA As ACCION_FORMATIVA
    Public Property fkID_ACCION_FORMATIVA() As ACCION_FORMATIVA
        Get
            Return _fkID_ACCION_FORMATIVA
        End Get
        Set(ByVal Value As ACCION_FORMATIVA)
            _fkID_ACCION_FORMATIVA = Value
        End Set
    End Property

    Private _FECHA As DateTime
    <Column(Name:="Fecha", Storage:="FECHA", DbType:="DATE", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property FECHA() As DateTime
        Get
            Return _FECHA
        End Get
        Set(ByVal Value As DateTime)
            _FECHA = Value
            OnPropertyChanged("FECHA")
        End Set
    End Property

    Private _FECHAOld As DateTime
    Public Property FECHAOld() As DateTime
        Get
            Return _FECHAOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHAOld = Value
        End Set
    End Property

    Private _INSTRUCTOR As String
    <Column(Name:="Instructor", Storage:="INSTRUCTOR", DbType:="VARCHAR2(255)", Id:=False), _
     DataObjectField(False, False, True, 255)> _
    Public Property INSTRUCTOR() As String
        Get
            Return _INSTRUCTOR
        End Get
        Set(ByVal Value As String)
            _INSTRUCTOR = Value
            OnPropertyChanged("INSTRUCTOR")
        End Set
    End Property

    Private _INSTRUCTOROld As String
    Public Property INSTRUCTOROld() As String
        Get
            Return _INSTRUCTOROld
        End Get
        Set(ByVal Value As String)
            _INSTRUCTOROld = Value
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
