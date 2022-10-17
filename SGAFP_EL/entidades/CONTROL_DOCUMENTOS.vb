''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.CONTROL_DOCUMENTOS
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite tener un registro de la tabla CONTROL_DOCUMENTOS en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="CONTROL_DOCUMENTOS")> Public Class CONTROL_DOCUMENTOS
    Inherits entidadBase
    Implements IEquatable(Of CONTROL_DOCUMENTOS), IComparable(Of CONTROL_DOCUMENTOS)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aNUMERO_DOCUMENTO As Decimal, aNUMERO_PATRONAL As String, aNUMERO_FOLIO As String, aID_TIPO_SOLICITUD As Decimal, aCODIGO_ETAPA As String, aCODIGO_PROCESO As String, aID_ESTADO_SOLICITUD As Decimal, aNIT As String, aPRESENTADO_POR As String, aFECHA_RECEPCION As DateTime, aRESPONSABLE_ACTUAL As String, aRESPONSABLE_ANTERIOR As String, aPRIORIDAD As String, aNO_DOCUMENTO_ORIGEN As Decimal, aNO_DOCUMENTO_PADRE As Decimal, aFECHA_REQUERIDA_FIN As DateTime, aNOTAS As String, aUSERID As String, aLASTUPDATE As DateTime)
        Me._NUMERO_DOCUMENTO = aNUMERO_DOCUMENTO
        Me._NUMERO_PATRONAL = aNUMERO_PATRONAL
        Me._NUMERO_FOLIO = aNUMERO_FOLIO
        Me._ID_TIPO_SOLICITUD = aID_TIPO_SOLICITUD
        Me._CODIGO_ETAPA = aCODIGO_ETAPA
        Me._CODIGO_PROCESO = aCODIGO_PROCESO
        Me._ID_ESTADO_SOLICITUD = aID_ESTADO_SOLICITUD
        Me._NIT = aNIT
        Me._PRESENTADO_POR = aPRESENTADO_POR
        Me._FECHA_RECEPCION = aFECHA_RECEPCION
        Me._RESPONSABLE_ACTUAL = aRESPONSABLE_ACTUAL
        Me._RESPONSABLE_ANTERIOR = aRESPONSABLE_ANTERIOR
        Me._PRIORIDAD = aPRIORIDAD
        Me._NO_DOCUMENTO_ORIGEN = aNO_DOCUMENTO_ORIGEN
        Me._NO_DOCUMENTO_PADRE = aNO_DOCUMENTO_PADRE
        Me._FECHA_REQUERIDA_FIN = aFECHA_REQUERIDA_FIN
        Me._NOTAS = aNOTAS
        Me._USERID = aUSERID
        Me._LASTUPDATE = aLASTUPDATE
    End Sub

    Public Function Equals1(ByVal other As CONTROL_DOCUMENTOS) As Boolean Implements System.IEquatable(Of CONTROL_DOCUMENTOS).Equals
        Return Me.NUMERO_DOCUMENTO = other.NUMERO_DOCUMENTO
    End Function

    Public Function CompareTo(ByVal other As CONTROL_DOCUMENTOS) As Integer Implements System.IComparable(Of CONTROL_DOCUMENTOS).CompareTo
        If Me.NUMERO_DOCUMENTO > other.NUMERO_DOCUMENTO Then Return 1
        If Me.NUMERO_DOCUMENTO < other.NUMERO_DOCUMENTO Then Return -1
        Return 0
    End Function


#Region " Propiedades "

    Private _NUMERO_DOCUMENTO As Decimal
    <Column(Name:="Numero documento", Storage:="NUMERO_DOCUMENTO", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=8, Scale:=0)> _
    Public Property NUMERO_DOCUMENTO() As Decimal
        Get
            Return _NUMERO_DOCUMENTO
        End Get
        Set(ByVal Value As Decimal)
            _NUMERO_DOCUMENTO = Value
            OnPropertyChanged("NUMERO_DOCUMENTO")
        End Set
    End Property 

    Private _NUMERO_PATRONAL As String
    <Column(Name:="Numero patronal", Storage:="NUMERO_PATRONAL", DbType:="CHAR(9)", Id:=False), _
     DataObjectField(False, False, True, 9)> _
    Public Property NUMERO_PATRONAL() As String
        Get
            Return _NUMERO_PATRONAL
        End Get
        Set(ByVal Value As String)
            _NUMERO_PATRONAL = Value
            OnPropertyChanged("NUMERO_PATRONAL")
        End Set
    End Property 

    Private _NUMERO_PATRONALOld As String
    Public Property NUMERO_PATRONALOld() As String
        Get
            Return _NUMERO_PATRONALOld
        End Get
        Set(ByVal Value As String)
            _NUMERO_PATRONALOld = Value
        End Set
    End Property 

    Private _NUMERO_FOLIO As String
    <Column(Name:="Numero folio", Storage:="NUMERO_FOLIO", DbType:="CHAR(14)", Id:=False), _
     DataObjectField(False, False, True, 14)> _
    Public Property NUMERO_FOLIO() As String
        Get
            Return _NUMERO_FOLIO
        End Get
        Set(ByVal Value As String)
            _NUMERO_FOLIO = Value
            OnPropertyChanged("NUMERO_FOLIO")
        End Set
    End Property 

    Private _NUMERO_FOLIOOld As String
    Public Property NUMERO_FOLIOOld() As String
        Get
            Return _NUMERO_FOLIOOld
        End Get
        Set(ByVal Value As String)
            _NUMERO_FOLIOOld = Value
        End Set
    End Property 

    Private _ID_TIPO_SOLICITUD As Decimal
    <Column(Name:="Id tipo solicitud", Storage:="ID_TIPO_SOLICITUD", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_TIPO_SOLICITUD() As Decimal
        Get
            Return _ID_TIPO_SOLICITUD
        End Get
        Set(ByVal Value As Decimal)
            _ID_TIPO_SOLICITUD = Value
            OnPropertyChanged("ID_TIPO_SOLICITUD")
        End Set
    End Property 

    Private _ID_TIPO_SOLICITUDOld As Decimal
    Public Property ID_TIPO_SOLICITUDOld() As Decimal
        Get
            Return _ID_TIPO_SOLICITUDOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_TIPO_SOLICITUDOld = Value
        End Set
    End Property 

    Private _fkID_TIPO_SOLICITUD As TIPO_SOLICITUD
    Public Property fkID_TIPO_SOLICITUD() As TIPO_SOLICITUD
        Get
            Return _fkID_TIPO_SOLICITUD
        End Get
        Set(ByVal Value As TIPO_SOLICITUD)
            _fkID_TIPO_SOLICITUD = Value
        End Set
    End Property 

    Private _CODIGO_ETAPA As String
    <Column(Name:="Codigo etapa", Storage:="CODIGO_ETAPA", DbType:="CHAR(2)", Id:=False), _
     DataObjectField(False, False, True, 2)> _
    Public Property CODIGO_ETAPA() As String
        Get
            Return _CODIGO_ETAPA
        End Get
        Set(ByVal Value As String)
            _CODIGO_ETAPA = Value
            OnPropertyChanged("CODIGO_ETAPA")
        End Set
    End Property 

    Private _CODIGO_ETAPAOld As String
    Public Property CODIGO_ETAPAOld() As String
        Get
            Return _CODIGO_ETAPAOld
        End Get
        Set(ByVal Value As String)
            _CODIGO_ETAPAOld = Value
        End Set
    End Property 

    Private _fkCODIGO_ETAPA As ETAPA
    Public Property fkCODIGO_ETAPA() As ETAPA
        Get
            Return _fkCODIGO_ETAPA
        End Get
        Set(ByVal Value As ETAPA)
            _fkCODIGO_ETAPA = Value
        End Set
    End Property 

    Private _CODIGO_PROCESO As String
    <Column(Name:="Codigo proceso", Storage:="CODIGO_PROCESO", DbType:="CHAR(2)", Id:=False), _
     DataObjectField(False, False, True, 2)> _
    Public Property CODIGO_PROCESO() As String
        Get
            Return _CODIGO_PROCESO
        End Get
        Set(ByVal Value As String)
            _CODIGO_PROCESO = Value
            OnPropertyChanged("CODIGO_PROCESO")
        End Set
    End Property 

    Private _CODIGO_PROCESOOld As String
    Public Property CODIGO_PROCESOOld() As String
        Get
            Return _CODIGO_PROCESOOld
        End Get
        Set(ByVal Value As String)
            _CODIGO_PROCESOOld = Value
        End Set
    End Property 

    Private _fkCODIGO_PROCESO As PROCESO
    Public Property fkCODIGO_PROCESO() As PROCESO
        Get
            Return _fkCODIGO_PROCESO
        End Get
        Set(ByVal Value As PROCESO)
            _fkCODIGO_PROCESO = Value
        End Set
    End Property 

    Private _ID_ESTADO_SOLICITUD As Decimal
    <Column(Name:="Id estado solicitud", Storage:="ID_ESTADO_SOLICITUD", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=2, Scale:=0)> _
    Public Property ID_ESTADO_SOLICITUD() As Decimal
        Get
            Return _ID_ESTADO_SOLICITUD
        End Get
        Set(ByVal Value As Decimal)
            _ID_ESTADO_SOLICITUD = Value
            OnPropertyChanged("ID_ESTADO_SOLICITUD")
        End Set
    End Property 

    Private _ID_ESTADO_SOLICITUDOld As Decimal
    Public Property ID_ESTADO_SOLICITUDOld() As Decimal
        Get
            Return _ID_ESTADO_SOLICITUDOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_ESTADO_SOLICITUDOld = Value
        End Set
    End Property 

    Private _fkID_ESTADO_SOLICITUD As ESTADO_SOLICITUD
    Public Property fkID_ESTADO_SOLICITUD() As ESTADO_SOLICITUD
        Get
            Return _fkID_ESTADO_SOLICITUD
        End Get
        Set(ByVal Value As ESTADO_SOLICITUD)
            _fkID_ESTADO_SOLICITUD = Value
        End Set
    End Property 

    Private _NIT As String
    <Column(Name:="Nit", Storage:="NIT", DbType:="CHAR(14)", Id:=False), _
     DataObjectField(False, False, True, 14)> _
    Public Property NIT() As String
        Get
            Return _NIT
        End Get
        Set(ByVal Value As String)
            _NIT = Value
            OnPropertyChanged("NIT")
        End Set
    End Property 

    Private _NITOld As String
    Public Property NITOld() As String
        Get
            Return _NITOld
        End Get
        Set(ByVal Value As String)
            _NITOld = Value
        End Set
    End Property 

    Private _PRESENTADO_POR As String
    <Column(Name:="Presentado por", Storage:="PRESENTADO_POR", DbType:="CHAR(60)", Id:=False), _
     DataObjectField(False, False, True, 60)> _
    Public Property PRESENTADO_POR() As String
        Get
            Return _PRESENTADO_POR
        End Get
        Set(ByVal Value As String)
            _PRESENTADO_POR = Value
            OnPropertyChanged("PRESENTADO_POR")
        End Set
    End Property 

    Private _PRESENTADO_POROld As String
    Public Property PRESENTADO_POROld() As String
        Get
            Return _PRESENTADO_POROld
        End Get
        Set(ByVal Value As String)
            _PRESENTADO_POROld = Value
        End Set
    End Property 

    Private _FECHA_RECEPCION As DateTime
    <Column(Name:="Fecha recepcion", Storage:="FECHA_RECEPCION", DbType:="DATE", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property FECHA_RECEPCION() As DateTime
        Get
            Return _FECHA_RECEPCION
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_RECEPCION = Value
            OnPropertyChanged("FECHA_RECEPCION")
        End Set
    End Property 

    Private _FECHA_RECEPCIONOld As DateTime
    Public Property FECHA_RECEPCIONOld() As DateTime
        Get
            Return _FECHA_RECEPCIONOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_RECEPCIONOld = Value
        End Set
    End Property 

    Private _RESPONSABLE_ACTUAL As String
    <Column(Name:="Responsable actual", Storage:="RESPONSABLE_ACTUAL", DbType:="CHAR(16)", Id:=False), _
     DataObjectField(False, False, True, 16)> _
    Public Property RESPONSABLE_ACTUAL() As String
        Get
            Return _RESPONSABLE_ACTUAL
        End Get
        Set(ByVal Value As String)
            _RESPONSABLE_ACTUAL = Value
            OnPropertyChanged("RESPONSABLE_ACTUAL")
        End Set
    End Property 

    Private _RESPONSABLE_ACTUALOld As String
    Public Property RESPONSABLE_ACTUALOld() As String
        Get
            Return _RESPONSABLE_ACTUALOld
        End Get
        Set(ByVal Value As String)
            _RESPONSABLE_ACTUALOld = Value
        End Set
    End Property 

    Private _RESPONSABLE_ANTERIOR As String
    <Column(Name:="Responsable anterior", Storage:="RESPONSABLE_ANTERIOR", DbType:="CHAR(16)", Id:=False), _
     DataObjectField(False, False, True, 16)> _
    Public Property RESPONSABLE_ANTERIOR() As String
        Get
            Return _RESPONSABLE_ANTERIOR
        End Get
        Set(ByVal Value As String)
            _RESPONSABLE_ANTERIOR = Value
            OnPropertyChanged("RESPONSABLE_ANTERIOR")
        End Set
    End Property 

    Private _RESPONSABLE_ANTERIOROld As String
    Public Property RESPONSABLE_ANTERIOROld() As String
        Get
            Return _RESPONSABLE_ANTERIOROld
        End Get
        Set(ByVal Value As String)
            _RESPONSABLE_ANTERIOROld = Value
        End Set
    End Property 

    Private _PRIORIDAD As String
    <Column(Name:="Prioridad", Storage:="PRIORIDAD", DbType:="CHAR(1)", Id:=False), _
     DataObjectField(False, False, True, 1)> _
    Public Property PRIORIDAD() As String
        Get
            Return _PRIORIDAD
        End Get
        Set(ByVal Value As String)
            _PRIORIDAD = Value
            OnPropertyChanged("PRIORIDAD")
        End Set
    End Property 

    Private _PRIORIDADOld As String
    Public Property PRIORIDADOld() As String
        Get
            Return _PRIORIDADOld
        End Get
        Set(ByVal Value As String)
            _PRIORIDADOld = Value
        End Set
    End Property 

    Private _NO_DOCUMENTO_ORIGEN As Decimal
    <Column(Name:="No documento origen", Storage:="NO_DOCUMENTO_ORIGEN", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=8, Scale:=0)> _
    Public Property NO_DOCUMENTO_ORIGEN() As Decimal
        Get
            Return _NO_DOCUMENTO_ORIGEN
        End Get
        Set(ByVal Value As Decimal)
            _NO_DOCUMENTO_ORIGEN = Value
            OnPropertyChanged("NO_DOCUMENTO_ORIGEN")
        End Set
    End Property 

    Private _NO_DOCUMENTO_ORIGENOld As Decimal
    Public Property NO_DOCUMENTO_ORIGENOld() As Decimal
        Get
            Return _NO_DOCUMENTO_ORIGENOld
        End Get
        Set(ByVal Value As Decimal)
            _NO_DOCUMENTO_ORIGENOld = Value
        End Set
    End Property 

    Private _NO_DOCUMENTO_PADRE As Decimal
    <Column(Name:="No documento padre", Storage:="NO_DOCUMENTO_PADRE", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=8, Scale:=0)> _
    Public Property NO_DOCUMENTO_PADRE() As Decimal
        Get
            Return _NO_DOCUMENTO_PADRE
        End Get
        Set(ByVal Value As Decimal)
            _NO_DOCUMENTO_PADRE = Value
            OnPropertyChanged("NO_DOCUMENTO_PADRE")
        End Set
    End Property 

    Private _NO_DOCUMENTO_PADREOld As Decimal
    Public Property NO_DOCUMENTO_PADREOld() As Decimal
        Get
            Return _NO_DOCUMENTO_PADREOld
        End Get
        Set(ByVal Value As Decimal)
            _NO_DOCUMENTO_PADREOld = Value
        End Set
    End Property 

    Private _FECHA_REQUERIDA_FIN As DateTime
    <Column(Name:="Fecha requerida fin", Storage:="FECHA_REQUERIDA_FIN", DbType:="DATE", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property FECHA_REQUERIDA_FIN() As DateTime
        Get
            Return _FECHA_REQUERIDA_FIN
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_REQUERIDA_FIN = Value
            OnPropertyChanged("FECHA_REQUERIDA_FIN")
        End Set
    End Property 

    Private _FECHA_REQUERIDA_FINOld As DateTime
    Public Property FECHA_REQUERIDA_FINOld() As DateTime
        Get
            Return _FECHA_REQUERIDA_FINOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_REQUERIDA_FINOld = Value
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
