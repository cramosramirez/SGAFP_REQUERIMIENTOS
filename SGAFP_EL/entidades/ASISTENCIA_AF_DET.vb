''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.ASISTENCIA_AF_DET
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite tener un registro de la tabla ASISTENCIA_AF_DET en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' 	[ecarias]	07/04/2010	Se agregaron columnas de Auditoría USERID, LASTUPDATE
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="ASISTENCIA_AF_DET")> Public Class ASISTENCIA_AF_DET
    Inherits entidadBase
    Implements IEquatable(Of ASISTENCIA_AF_DET), IComparable(Of ASISTENCIA_AF_DET)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(ByVal aID_ASISTENCIA_DET As Decimal, ByVal aID_ASISTENCIA_AF As Decimal, ByVal aID_PARTICIPANTE As Decimal, ByVal aASISTIO As String, ByVal aPRESENTA_JUSTIFICACION As String, ByVal aJUSTIFICACION As String, ByVal aUSERID As String, ByVal aLASTUPDATE As DateTime, ByVal aHORAS_ASISTENCIA As Decimal)
        Me._ID_ASISTENCIA_DET = aID_ASISTENCIA_DET
        Me._ID_ASISTENCIA_AF = aID_ASISTENCIA_AF
        Me._ID_PARTICIPANTE = aID_PARTICIPANTE
        Me._ASISTIO = aASISTIO
        Me._PRESENTA_JUSTIFICACION = aPRESENTA_JUSTIFICACION
        Me._JUSTIFICACION = aJUSTIFICACION
        Me._USERID = aUSERID
        Me._LASTUPDATE = aLASTUPDATE
        Me._HORAS_ASISTENCIA = aHORAS_ASISTENCIA
    End Sub

    Public Function Equals1(ByVal other As ASISTENCIA_AF_DET) As Boolean Implements System.IEquatable(Of ASISTENCIA_AF_DET).Equals
        Return Me.ID_ASISTENCIA_DET = other.ID_ASISTENCIA_DET
    End Function

    Public Function CompareTo(ByVal other As ASISTENCIA_AF_DET) As Integer Implements System.IComparable(Of ASISTENCIA_AF_DET).CompareTo
        If Me.ID_ASISTENCIA_DET > other.ID_ASISTENCIA_DET Then Return 1
        If Me.ID_ASISTENCIA_DET < other.ID_ASISTENCIA_DET Then Return -1
        Return 0
    End Function


#Region " Propiedades "

    Private _ID_ASISTENCIA_DET As Decimal
    <Column(Name:="Id asistencia det", Storage:="ID_ASISTENCIA_DET", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_ASISTENCIA_DET() As Decimal
        Get
            Return _ID_ASISTENCIA_DET
        End Get
        Set(ByVal Value As Decimal)
            _ID_ASISTENCIA_DET = Value
            OnPropertyChanged("ID_ASISTENCIA_DET")
        End Set
    End Property

    Private _ID_ASISTENCIA_AF As Decimal
    <Column(Name:="Id asistencia af", Storage:="ID_ASISTENCIA_AF", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_ASISTENCIA_AF() As Decimal
        Get
            Return _ID_ASISTENCIA_AF
        End Get
        Set(ByVal Value As Decimal)
            _ID_ASISTENCIA_AF = Value
            OnPropertyChanged("ID_ASISTENCIA_AF")
        End Set
    End Property

    Private _ID_ASISTENCIA_AFOld As Decimal
    Public Property ID_ASISTENCIA_AFOld() As Decimal
        Get
            Return _ID_ASISTENCIA_AFOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_ASISTENCIA_AFOld = Value
        End Set
    End Property

    Private _fkID_ASISTENCIA_AF As ASISTENCIA_AF
    Public Property fkID_ASISTENCIA_AF() As ASISTENCIA_AF
        Get
            Return _fkID_ASISTENCIA_AF
        End Get
        Set(ByVal Value As ASISTENCIA_AF)
            _fkID_ASISTENCIA_AF = Value
        End Set
    End Property

    Private _ID_PARTICIPANTE As Decimal
    <Column(Name:="Id participante", Storage:="ID_PARTICIPANTE", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_PARTICIPANTE() As Decimal
        Get
            Return _ID_PARTICIPANTE
        End Get
        Set(ByVal Value As Decimal)
            _ID_PARTICIPANTE = Value
            OnPropertyChanged("ID_PARTICIPANTE")
        End Set
    End Property

    Private _ID_PARTICIPANTEOld As Decimal
    Public Property ID_PARTICIPANTEOld() As Decimal
        Get
            Return _ID_PARTICIPANTEOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_PARTICIPANTEOld = Value
        End Set
    End Property

    Private _fkID_PARTICIPANTE As PARTICIPANTE
    Public Property fkID_PARTICIPANTE() As PARTICIPANTE
        Get
            Return _fkID_PARTICIPANTE
        End Get
        Set(ByVal Value As PARTICIPANTE)
            _fkID_PARTICIPANTE = Value
        End Set
    End Property

    Private _ASISTIO As String
    <Column(Name:="Asistio", Storage:="ASISTIO", DbType:="CHAR(1)", Id:=False), _
     DataObjectField(False, False, True, 1)> _
    Public Property ASISTIO() As String
        Get
            Return _ASISTIO
        End Get
        Set(ByVal Value As String)
            _ASISTIO = Value
            OnPropertyChanged("ASISTIO")
        End Set
    End Property

    Private _ASISTIOOld As String
    Public Property ASISTIOOld() As String
        Get
            Return _ASISTIOOld
        End Get
        Set(ByVal Value As String)
            _ASISTIOOld = Value
        End Set
    End Property

    Private _PRESENTA_JUSTIFICACION As String
    <Column(Name:="Presenta justificacion", Storage:="PRESENTA_JUSTIFICACION", DbType:="CHAR(1)", Id:=False), _
     DataObjectField(False, False, True, 1)> _
    Public Property PRESENTA_JUSTIFICACION() As String
        Get
            Return _PRESENTA_JUSTIFICACION
        End Get
        Set(ByVal Value As String)
            _PRESENTA_JUSTIFICACION = Value
            OnPropertyChanged("PRESENTA_JUSTIFICACION")
        End Set
    End Property

    Private _PRESENTA_JUSTIFICACIONOld As String
    Public Property PRESENTA_JUSTIFICACIONOld() As String
        Get
            Return _PRESENTA_JUSTIFICACIONOld
        End Get
        Set(ByVal Value As String)
            _PRESENTA_JUSTIFICACIONOld = Value
        End Set
    End Property

    Private _JUSTIFICACION As String
    <Column(Name:="Justificacion", Storage:="JUSTIFICACION", DbType:="VARCHAR2(80)", Id:=False), _
     DataObjectField(False, False, True, 80)> _
    Public Property JUSTIFICACION() As String
        Get
            Return _JUSTIFICACION
        End Get
        Set(ByVal Value As String)
            _JUSTIFICACION = Value
            OnPropertyChanged("JUSTIFICACION")
        End Set
    End Property

    Private _JUSTIFICACIONOld As String
    Public Property JUSTIFICACIONOld() As String
        Get
            Return _JUSTIFICACIONOld
        End Get
        Set(ByVal Value As String)
            _JUSTIFICACIONOld = Value
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
