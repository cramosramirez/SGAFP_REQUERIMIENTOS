''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.PARTICIPANTE_AF
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite tener un registro de la tabla PARTICIPANTE_AF en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' 	[ecarias]	07/04/2010	Se agregaron columnas de Auditoría USERID, LASTUPDATE
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="PARTICIPANTE_AF")> Public Class PARTICIPANTE_AF
    Inherits entidadBase
    Implements IEquatable(Of PARTICIPANTE_AF), IComparable(Of PARTICIPANTE_AF)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(ByVal aID_PARTICIPANTE As Decimal, ByVal aID_ACCION_FORMATIVA As Decimal, ByVal aID_SOLICITUD As Decimal, ByVal aESTADO As String, ByVal aFECHA_INSCRIPCION As DateTime, ByVal aNOTA_FINAL As Decimal, ByVal aPORC_ASISTENCIA As Decimal, ByVal aENTREGA_DIPLOMA As String, ByVal aNOTAS As String, ByVal aUSERID As String, ByVal aLASTUPDATE As DateTime)
        Me._ID_PARTICIPANTE = aID_PARTICIPANTE
        Me._ID_ACCION_FORMATIVA = aID_ACCION_FORMATIVA
        Me._ID_SOLICITUD = aID_SOLICITUD
        Me._ESTADO = aESTADO
        Me._FECHA_INSCRIPCION = aFECHA_INSCRIPCION
        Me._NOTA_FINAL = aNOTA_FINAL
        Me._PORC_ASISTENCIA = aPORC_ASISTENCIA
        Me._ENTREGA_DIPLOMA = aENTREGA_DIPLOMA
        Me._NOTAS = aNOTAS
        Me._USERID = aUSERID
        Me._LASTUPDATE = aLASTUPDATE
    End Sub

    Public Function Equals1(ByVal other As PARTICIPANTE_AF) As Boolean Implements System.IEquatable(Of PARTICIPANTE_AF).Equals
        Return Me.ID_PARTICIPANTE = other.ID_PARTICIPANTE And Me.ID_ACCION_FORMATIVA = other.ID_ACCION_FORMATIVA
    End Function

    Public Function CompareTo(ByVal other As PARTICIPANTE_AF) As Integer Implements System.IComparable(Of PARTICIPANTE_AF).CompareTo
        If Me.ID_PARTICIPANTE > other.ID_PARTICIPANTE Then
            If Me.ID_ACCION_FORMATIVA > other.ID_ACCION_FORMATIVA Then Return 1
            If Me.ID_ACCION_FORMATIVA < other.ID_ACCION_FORMATIVA Then Return -1
        Else
            Return -1
        End If
        Return 0
    End Function


#Region " Propiedades "

    Private _ID_PARTICIPANTE As Decimal
    <Column(Name:="Id participante", Storage:="ID_PARTICIPANTE", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_PARTICIPANTE() As Decimal
        Get
            Return _ID_PARTICIPANTE
        End Get
        Set(ByVal Value As Decimal)
            _ID_PARTICIPANTE = Value
            OnPropertyChanged("ID_PARTICIPANTE")
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

    Private _ID_ACCION_FORMATIVA As Decimal
    <Column(Name:="Id accion formativa", Storage:="ID_ACCION_FORMATIVA", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_ACCION_FORMATIVA() As Decimal
        Get
            Return _ID_ACCION_FORMATIVA
        End Get
        Set(ByVal Value As Decimal)
            _ID_ACCION_FORMATIVA = Value
            OnPropertyChanged("ID_ACCION_FORMATIVA")
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

    Private _ID_SOLICITUD As Decimal
    <Column(Name:="Id solicitud", Storage:="ID_SOLICITUD", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_SOLICITUD() As Decimal
        Get
            Return _ID_SOLICITUD
        End Get
        Set(ByVal Value As Decimal)
            _ID_SOLICITUD = Value
            OnPropertyChanged("ID_SOLICITUD")
        End Set
    End Property

    Private _ID_SOLICITUDOld As Decimal
    Public Property ID_SOLICITUDOld() As Decimal
        Get
            Return _ID_SOLICITUDOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_SOLICITUDOld = Value
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

    Private _ESTADO As String
    <Column(Name:="Estado", Storage:="ESTADO", DbType:="CHAR(1)", Id:=False), _
     DataObjectField(False, False, True, 1)> _
    Public Property ESTADO() As String
        Get
            Return _ESTADO
        End Get
        Set(ByVal Value As String)
            _ESTADO = Value
            OnPropertyChanged("ESTADO")
        End Set
    End Property

    Private _ESTADOOld As String
    Public Property ESTADOOld() As String
        Get
            Return _ESTADOOld
        End Get
        Set(ByVal Value As String)
            _ESTADOOld = Value
        End Set
    End Property

    Private _FECHA_INSCRIPCION As DateTime
    <Column(Name:="Fecha inscripcion", Storage:="FECHA_INSCRIPCION", DbType:="DATE", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property FECHA_INSCRIPCION() As DateTime
        Get
            Return _FECHA_INSCRIPCION
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_INSCRIPCION = Value
            OnPropertyChanged("FECHA_INSCRIPCION")
        End Set
    End Property

    Private _FECHA_INSCRIPCIONOld As DateTime
    Public Property FECHA_INSCRIPCIONOld() As DateTime
        Get
            Return _FECHA_INSCRIPCIONOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_INSCRIPCIONOld = Value
        End Set
    End Property

    Private _NOTA_FINAL As Decimal
    <Column(Name:="Nota final", Storage:="NOTA_FINAL", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=4, Scale:=2)> _
    Public Property NOTA_FINAL() As Decimal
        Get
            Return _NOTA_FINAL
        End Get
        Set(ByVal Value As Decimal)
            _NOTA_FINAL = Value
            OnPropertyChanged("NOTA_FINAL")
        End Set
    End Property

    Private _NOTA_FINALOld As Decimal
    Public Property NOTA_FINALOld() As Decimal
        Get
            Return _NOTA_FINALOld
        End Get
        Set(ByVal Value As Decimal)
            _NOTA_FINALOld = Value
        End Set
    End Property

    Private _PORC_ASISTENCIA As Decimal
    <Column(Name:="Porc asistencia", Storage:="PORC_ASISTENCIA", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=5, Scale:=2)> _
    Public Property PORC_ASISTENCIA() As Decimal
        Get
            Return _PORC_ASISTENCIA
        End Get
        Set(ByVal Value As Decimal)
            _PORC_ASISTENCIA = Value
            OnPropertyChanged("PORC_ASISTENCIA")
        End Set
    End Property

    Private _PORC_ASISTENCIAOld As Decimal
    Public Property PORC_ASISTENCIAOld() As Decimal
        Get
            Return _PORC_ASISTENCIAOld
        End Get
        Set(ByVal Value As Decimal)
            _PORC_ASISTENCIAOld = Value
        End Set
    End Property

    Private _ENTREGA_DIPLOMA As String
    <Column(Name:="Entrega diploma", Storage:="ENTREGA_DIPLOMA", DbType:="CHAR(1)", Id:=False), _
     DataObjectField(False, False, True, 1)> _
    Public Property ENTREGA_DIPLOMA() As String
        Get
            Return _ENTREGA_DIPLOMA
        End Get
        Set(ByVal Value As String)
            _ENTREGA_DIPLOMA = Value
            OnPropertyChanged("ENTREGA_DIPLOMA")
        End Set
    End Property

    Private _ENTREGA_DIPLOMAOld As String
    Public Property ENTREGA_DIPLOMAOld() As String
        Get
            Return _ENTREGA_DIPLOMAOld
        End Get
        Set(ByVal Value As String)
            _ENTREGA_DIPLOMAOld = Value
        End Set
    End Property

    Private _NOTAS As String
    <Column(Name:="Notas", Storage:="NOTAS", DbType:="VARCHAR2(600)", Id:=False), _
     DataObjectField(False, False, True, 600)> _
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


    Private _ES_CAPACITADO As Decimal
    <Column(Name:="ES_CAPACITADO", Storage:="ES_CAPACITADO", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=8, Scale:=0)> _
    Public Property ES_CAPACITADO() As Decimal
        Get
            Return _ES_CAPACITADO
        End Get
        Set(ByVal Value As Decimal)
            _ES_CAPACITADO = Value
            OnPropertyChanged("ES_CAPACITADO")
        End Set
    End Property

    Private _ES_CAPACITADOOld As Decimal
    Public Property ES_CAPACITADOOld() As Decimal
        Get
            Return _ES_CAPACITADOOld
        End Get
        Set(ByVal Value As Decimal)
            _ES_CAPACITADOOld = Value
        End Set
    End Property

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
