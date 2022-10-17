''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.ETAPA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite tener un registro de la tabla ETAPA en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="ETAPA")> Public Class ETAPA
    Inherits entidadBase
    Implements IEquatable(Of ETAPA), IComparable(Of ETAPA)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aCODIGO_ETAPA As String, aCODIGO_PROCESO As String, aID_ESTADO_SOLICITUD As Decimal, aUNIDAD_DE_TIEMPO As String, aNOMBRE_ETAPA As String, aETAPA_ANT As String, aETAPA_SIG As String, aTIPO_ETAPA As String, aDURACION As Decimal, aORDEN_EJECUCION As Decimal, aUSERID As String, aLASTUPDATE As DateTime)
        Me._CODIGO_ETAPA = aCODIGO_ETAPA
        Me._CODIGO_PROCESO = aCODIGO_PROCESO
        Me._ID_ESTADO_SOLICITUD = aID_ESTADO_SOLICITUD
        Me._UNIDAD_DE_TIEMPO = aUNIDAD_DE_TIEMPO
        Me._NOMBRE_ETAPA = aNOMBRE_ETAPA
        Me._ETAPA_ANT = aETAPA_ANT
        Me._ETAPA_SIG = aETAPA_SIG
        Me._TIPO_ETAPA = aTIPO_ETAPA
        Me._DURACION = aDURACION
        Me._ORDEN_EJECUCION = aORDEN_EJECUCION
        Me._USERID = aUSERID
        Me._LASTUPDATE = aLASTUPDATE
    End Sub

    Public Function Equals1(ByVal other As ETAPA) As Boolean Implements System.IEquatable(Of ETAPA).Equals
        Return Me.CODIGO_ETAPA = other.CODIGO_ETAPA And Me.CODIGO_PROCESO = other.CODIGO_PROCESO
    End Function

    Public Function CompareTo(ByVal other As ETAPA) As Integer Implements System.IComparable(Of ETAPA).CompareTo
        If Me.CODIGO_ETAPA > other.CODIGO_ETAPA Then
            If Me.CODIGO_PROCESO > other.CODIGO_PROCESO Then Return 1
            If Me.CODIGO_PROCESO < other.CODIGO_PROCESO Then Return -1
        Else
            Return -1
        End If
        Return 0
    End Function


#Region " Propiedades "

    Private _CODIGO_ETAPA As String
    <Column(Name:="Codigo etapa", Storage:="CODIGO_ETAPA", DbType:="CHAR(2) NOT NULL", Id:=True), _
     DataObjectField(True, False, False, 2)> _
    Public Property CODIGO_ETAPA() As String
        Get
            Return _CODIGO_ETAPA
        End Get
        Set(ByVal Value As String)
            _CODIGO_ETAPA = Value
            OnPropertyChanged("CODIGO_ETAPA")
        End Set
    End Property 

    Private _CODIGO_PROCESO As String
    <Column(Name:="Codigo proceso", Storage:="CODIGO_PROCESO", DbType:="CHAR(2) NOT NULL", Id:=True), _
     DataObjectField(True, False, False, 2)> _
    Public Property CODIGO_PROCESO() As String
        Get
            Return _CODIGO_PROCESO
        End Get
        Set(ByVal Value As String)
            _CODIGO_PROCESO = Value
            OnPropertyChanged("CODIGO_PROCESO")
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

    Private _UNIDAD_DE_TIEMPO As String
    <Column(Name:="Unidad de tiempo", Storage:="UNIDAD_DE_TIEMPO", DbType:="CHAR(1)", Id:=False), _
     DataObjectField(False, False, True, 1)> _
    Public Property UNIDAD_DE_TIEMPO() As String
        Get
            Return _UNIDAD_DE_TIEMPO
        End Get
        Set(ByVal Value As String)
            _UNIDAD_DE_TIEMPO = Value
            OnPropertyChanged("UNIDAD_DE_TIEMPO")
        End Set
    End Property 

    Private _UNIDAD_DE_TIEMPOOld As String
    Public Property UNIDAD_DE_TIEMPOOld() As String
        Get
            Return _UNIDAD_DE_TIEMPOOld
        End Get
        Set(ByVal Value As String)
            _UNIDAD_DE_TIEMPOOld = Value
        End Set
    End Property 

    Private _NOMBRE_ETAPA As String
    <Column(Name:="Nombre etapa", Storage:="NOMBRE_ETAPA", DbType:="VARCHAR2(50)", Id:=False), _
     DataObjectField(False, False, True, 50)> _
    Public Property NOMBRE_ETAPA() As String
        Get
            Return _NOMBRE_ETAPA
        End Get
        Set(ByVal Value As String)
            _NOMBRE_ETAPA = Value
            OnPropertyChanged("NOMBRE_ETAPA")
        End Set
    End Property 

    Private _NOMBRE_ETAPAOld As String
    Public Property NOMBRE_ETAPAOld() As String
        Get
            Return _NOMBRE_ETAPAOld
        End Get
        Set(ByVal Value As String)
            _NOMBRE_ETAPAOld = Value
        End Set
    End Property 

    Private _ETAPA_ANT As String
    <Column(Name:="Etapa ant", Storage:="ETAPA_ANT", DbType:="CHAR(2)", Id:=False), _
     DataObjectField(False, False, True, 2)> _
    Public Property ETAPA_ANT() As String
        Get
            Return _ETAPA_ANT
        End Get
        Set(ByVal Value As String)
            _ETAPA_ANT = Value
            OnPropertyChanged("ETAPA_ANT")
        End Set
    End Property 

    Private _ETAPA_ANTOld As String
    Public Property ETAPA_ANTOld() As String
        Get
            Return _ETAPA_ANTOld
        End Get
        Set(ByVal Value As String)
            _ETAPA_ANTOld = Value
        End Set
    End Property 

    Private _ETAPA_SIG As String
    <Column(Name:="Etapa sig", Storage:="ETAPA_SIG", DbType:="CHAR(2)", Id:=False), _
     DataObjectField(False, False, True, 2)> _
    Public Property ETAPA_SIG() As String
        Get
            Return _ETAPA_SIG
        End Get
        Set(ByVal Value As String)
            _ETAPA_SIG = Value
            OnPropertyChanged("ETAPA_SIG")
        End Set
    End Property 

    Private _ETAPA_SIGOld As String
    Public Property ETAPA_SIGOld() As String
        Get
            Return _ETAPA_SIGOld
        End Get
        Set(ByVal Value As String)
            _ETAPA_SIGOld = Value
        End Set
    End Property 

    Private _TIPO_ETAPA As String
    <Column(Name:="Tipo etapa", Storage:="TIPO_ETAPA", DbType:="CHAR(1)", Id:=False), _
     DataObjectField(False, False, True, 1)> _
    Public Property TIPO_ETAPA() As String
        Get
            Return _TIPO_ETAPA
        End Get
        Set(ByVal Value As String)
            _TIPO_ETAPA = Value
            OnPropertyChanged("TIPO_ETAPA")
        End Set
    End Property 

    Private _TIPO_ETAPAOld As String
    Public Property TIPO_ETAPAOld() As String
        Get
            Return _TIPO_ETAPAOld
        End Get
        Set(ByVal Value As String)
            _TIPO_ETAPAOld = Value
        End Set
    End Property 

    Private _DURACION As Decimal
    <Column(Name:="Duracion", Storage:="DURACION", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=0, Scale:=0)> _
    Public Property DURACION() As Decimal
        Get
            Return _DURACION
        End Get
        Set(ByVal Value As Decimal)
            _DURACION = Value
            OnPropertyChanged("DURACION")
        End Set
    End Property 

    Private _DURACIONOld As Decimal
    Public Property DURACIONOld() As Decimal
        Get
            Return _DURACIONOld
        End Get
        Set(ByVal Value As Decimal)
            _DURACIONOld = Value
        End Set
    End Property 

    Private _ORDEN_EJECUCION As Decimal
    <Column(Name:="Orden ejecucion", Storage:="ORDEN_EJECUCION", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=0, Scale:=0)> _
    Public Property ORDEN_EJECUCION() As Decimal
        Get
            Return _ORDEN_EJECUCION
        End Get
        Set(ByVal Value As Decimal)
            _ORDEN_EJECUCION = Value
            OnPropertyChanged("ORDEN_EJECUCION")
        End Set
    End Property 

    Private _ORDEN_EJECUCIONOld As Decimal
    Public Property ORDEN_EJECUCIONOld() As Decimal
        Get
            Return _ORDEN_EJECUCIONOld
        End Get
        Set(ByVal Value As Decimal)
            _ORDEN_EJECUCIONOld = Value
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
    <Column(Name:="Lastupdate", Storage:="LASTUPDATE", DbType:="TIMESTAMP(6)(0,6)", Id:=False), _
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
