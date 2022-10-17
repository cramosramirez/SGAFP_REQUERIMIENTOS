''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.MUNICIPIO_LIQUIDACION
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row MUNICIPIO_LIQUIDACION en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	10/09/2011	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="MUNICIPIO_LIQUIDACION")> Public Class MUNICIPIO_LIQUIDACION
    Inherits entidadBase
    Implements IEquatable(Of MUNICIPIO_LIQUIDACION), IComparable(Of MUNICIPIO_LIQUIDACION)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(ByVal aID_LIQUIDACION As Decimal, ByVal aNO_CONVOCATORIA As Decimal, ByVal aCODIGO_DEPARTAMENTO As String, ByVal aCODIGO_MUNICIPIO As String, ByVal aNO_LIQUIDACION As Decimal, ByVal aFECHA_ELABORACION As DateTime, ByVal aMONTO_LIQUIDADO As Decimal, ByVal aASESOR_MUNICIPAL As String, ByVal aUSERID As String, ByVal aLASTUPDATE As DateTime, ByVal aID_FUENTE As Decimal)
        Me._ID_LIQUIDACION = aID_LIQUIDACION
        Me._NO_CONVOCATORIA = aNO_CONVOCATORIA
        Me._CODIGO_DEPARTAMENTO = aCODIGO_DEPARTAMENTO
        Me._CODIGO_MUNICIPIO = aCODIGO_MUNICIPIO
        Me._NO_LIQUIDACION = aNO_LIQUIDACION
        Me._FECHA_ELABORACION = aFECHA_ELABORACION
        Me._MONTO_LIQUIDADO = aMONTO_LIQUIDADO
        Me._ASESOR_MUNICIPAL = aASESOR_MUNICIPAL
        Me._USERID = aUSERID
        Me._LASTUPDATE = aLASTUPDATE
        Me._ID_FUENTE = aID_FUENTE
    End Sub

    Public Function Equals1(ByVal other As MUNICIPIO_LIQUIDACION) As Boolean Implements System.IEquatable(Of MUNICIPIO_LIQUIDACION).Equals
        Return Me.ID_LIQUIDACION = other.ID_LIQUIDACION
    End Function

    Public Function CompareTo(ByVal other As MUNICIPIO_LIQUIDACION) As Integer Implements System.IComparable(Of MUNICIPIO_LIQUIDACION).CompareTo
        If Me.ID_LIQUIDACION > other.ID_LIQUIDACION Then Return 1
        If Me.ID_LIQUIDACION < other.ID_LIQUIDACION Then Return -1
        Return 0
    End Function


#Region " Properties "


    Private _ID_FUENTE As Decimal
    <Column(Name:="Id Fuente", Storage:="ID_FUENTE", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(True, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_FUENTE() As Decimal
        Get
            Return _ID_FUENTE
        End Get
        Set(ByVal Value As Decimal)
            _ID_FUENTE = Value
            OnPropertyChanged("ID_FUENTE")
        End Set
    End Property

    Private _ID_LIQUIDACION As Decimal
    <Column(Name:="Id liquidacion", Storage:="ID_LIQUIDACION", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_LIQUIDACION() As Decimal
        Get
            Return _ID_LIQUIDACION
        End Get
        Set(ByVal Value As Decimal)
            _ID_LIQUIDACION = Value
            OnPropertyChanged("ID_LIQUIDACION")
        End Set
    End Property 

    Private _NO_CONVOCATORIA As Decimal
    <Column(Name:="No convocatoria", Storage:="NO_CONVOCATORIA", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property NO_CONVOCATORIA() As Decimal
        Get
            Return _NO_CONVOCATORIA
        End Get
        Set(ByVal Value As Decimal)
            _NO_CONVOCATORIA = Value
            OnPropertyChanged("NO_CONVOCATORIA")
        End Set
    End Property 

    Private _NO_CONVOCATORIAOld As Decimal
    Public Property NO_CONVOCATORIAOld() As Decimal
        Get
            Return _NO_CONVOCATORIAOld
        End Get
        Set(ByVal Value As Decimal)
            _NO_CONVOCATORIAOld = Value
        End Set
    End Property 

    Private _fkNO_CONVOCATORIA As MUNICIPIO_CONVOCATORIA
    Public Property fkNO_CONVOCATORIA() As MUNICIPIO_CONVOCATORIA
        Get
            Return _fkNO_CONVOCATORIA
        End Get
        Set(ByVal Value As MUNICIPIO_CONVOCATORIA)
            _fkNO_CONVOCATORIA = Value
        End Set
    End Property 

    Private _CODIGO_DEPARTAMENTO As String
    <Column(Name:="Codigo departamento", Storage:="CODIGO_DEPARTAMENTO", DbType:="VARCHAR2(2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 2)> _
    Public Property CODIGO_DEPARTAMENTO() As String
        Get
            Return _CODIGO_DEPARTAMENTO
        End Get
        Set(ByVal Value As String)
            _CODIGO_DEPARTAMENTO = Value
            OnPropertyChanged("CODIGO_DEPARTAMENTO")
        End Set
    End Property 

    Private _CODIGO_DEPARTAMENTOOld As String
    Public Property CODIGO_DEPARTAMENTOOld() As String
        Get
            Return _CODIGO_DEPARTAMENTOOld
        End Get
        Set(ByVal Value As String)
            _CODIGO_DEPARTAMENTOOld = Value
        End Set
    End Property 

    Private _fkCODIGO_DEPARTAMENTO As DEPARTAMENTO
    Public Property fkCODIGO_DEPARTAMENTO() As DEPARTAMENTO
        Get
            Return _fkCODIGO_DEPARTAMENTO
        End Get
        Set(ByVal Value As DEPARTAMENTO)
            _fkCODIGO_DEPARTAMENTO = Value
        End Set
    End Property 

    Private _CODIGO_MUNICIPIO As String
    <Column(Name:="Codigo municipio", Storage:="CODIGO_MUNICIPIO", DbType:="VARCHAR2(2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 2)> _
    Public Property CODIGO_MUNICIPIO() As String
        Get
            Return _CODIGO_MUNICIPIO
        End Get
        Set(ByVal Value As String)
            _CODIGO_MUNICIPIO = Value
            OnPropertyChanged("CODIGO_MUNICIPIO")
        End Set
    End Property 

    Private _CODIGO_MUNICIPIOOld As String
    Public Property CODIGO_MUNICIPIOOld() As String
        Get
            Return _CODIGO_MUNICIPIOOld
        End Get
        Set(ByVal Value As String)
            _CODIGO_MUNICIPIOOld = Value
        End Set
    End Property 

    Private _fkCODIGO_MUNICIPIO As MUNICIPIO
    Public Property fkCODIGO_MUNICIPIO() As MUNICIPIO
        Get
            Return _fkCODIGO_MUNICIPIO
        End Get
        Set(ByVal Value As MUNICIPIO)
            _fkCODIGO_MUNICIPIO = Value
        End Set
    End Property 

    Private _NO_LIQUIDACION As Decimal
    <Column(Name:="No liquidacion", Storage:="NO_LIQUIDACION", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=2, Scale:=0)> _
    Public Property NO_LIQUIDACION() As Decimal
        Get
            Return _NO_LIQUIDACION
        End Get
        Set(ByVal Value As Decimal)
            _NO_LIQUIDACION = Value
            OnPropertyChanged("NO_LIQUIDACION")
        End Set
    End Property 

    Private _NO_LIQUIDACIONOld As Decimal
    Public Property NO_LIQUIDACIONOld() As Decimal
        Get
            Return _NO_LIQUIDACIONOld
        End Get
        Set(ByVal Value As Decimal)
            _NO_LIQUIDACIONOld = Value
        End Set
    End Property 

    Private _FECHA_ELABORACION As DateTime
    <Column(Name:="Fecha elaboracion", Storage:="FECHA_ELABORACION", DbType:="DATE NOT NULL", Id:=False), _
     DataObjectField(False, False, False)> _
    Public Property FECHA_ELABORACION() As DateTime
        Get
            Return _FECHA_ELABORACION
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_ELABORACION = Value
            OnPropertyChanged("FECHA_ELABORACION")
        End Set
    End Property 

    Private _FECHA_ELABORACIONOld As DateTime
    Public Property FECHA_ELABORACIONOld() As DateTime
        Get
            Return _FECHA_ELABORACIONOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_ELABORACIONOld = Value
        End Set
    End Property 

    Private _MONTO_LIQUIDADO As Decimal
    <Column(Name:="Monto liquidado", Storage:="MONTO_LIQUIDADO", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=2)> _
    Public Property MONTO_LIQUIDADO() As Decimal
        Get
            Return _MONTO_LIQUIDADO
        End Get
        Set(ByVal Value As Decimal)
            _MONTO_LIQUIDADO = Value
            OnPropertyChanged("MONTO_LIQUIDADO")
        End Set
    End Property 

    Private _MONTO_LIQUIDADOOld As Decimal
    Public Property MONTO_LIQUIDADOOld() As Decimal
        Get
            Return _MONTO_LIQUIDADOOld
        End Get
        Set(ByVal Value As Decimal)
            _MONTO_LIQUIDADOOld = Value
        End Set
    End Property

    Private _ASESOR_MUNICIPAL As String
    <Column(Name:="Asesor municipal", Storage:="ASESOR_MUNICIPAL", DbType:="VARCHAR2(100)", Id:=False), _
     DataObjectField(False, False, True, 100)> _
    Public Property ASESOR_MUNICIPAL() As String
        Get
            Return _ASESOR_MUNICIPAL
        End Get
        Set(ByVal Value As String)
            _ASESOR_MUNICIPAL = Value
            OnPropertyChanged("ASESOR_MUNICIPAL")
        End Set
    End Property

    Private _ASESOR_MUNICIPALOld As String
    Public Property ASESOR_MUNICIPALOld() As String
        Get
            Return _ASESOR_MUNICIPALOld
        End Get
        Set(ByVal Value As String)
            _ASESOR_MUNICIPALOld = Value
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
