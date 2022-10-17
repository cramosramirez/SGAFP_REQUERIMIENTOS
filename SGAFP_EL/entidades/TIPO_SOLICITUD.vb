''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.TIPO_SOLICITUD
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite tener un registro de la tabla TIPO_SOLICITUD en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="TIPO_SOLICITUD")> Public Class TIPO_SOLICITUD
    Inherits entidadBase
    Implements IEquatable(Of TIPO_SOLICITUD), IComparable(Of TIPO_SOLICITUD)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_TIPO_SOLICITUD As Decimal, aCODIGO_PROCESO As String, aTIPO_SOLICITUD As String, aTABLA_RELACIONAL As String, aNOTAS As String, aUSERID As String, aLASTUPDATE As DateTime)
        Me._ID_TIPO_SOLICITUD = aID_TIPO_SOLICITUD
        Me._CODIGO_PROCESO = aCODIGO_PROCESO
        Me._TIPO_SOLICITUD = aTIPO_SOLICITUD
        Me._TABLA_RELACIONAL = aTABLA_RELACIONAL
        Me._NOTAS = aNOTAS
        Me._USERID = aUSERID
        Me._LASTUPDATE = aLASTUPDATE
    End Sub

    Public Function Equals1(ByVal other As TIPO_SOLICITUD) As Boolean Implements System.IEquatable(Of TIPO_SOLICITUD).Equals
        Return Me.ID_TIPO_SOLICITUD = other.ID_TIPO_SOLICITUD
    End Function

    Public Function CompareTo(ByVal other As TIPO_SOLICITUD) As Integer Implements System.IComparable(Of TIPO_SOLICITUD).CompareTo
        If Me.ID_TIPO_SOLICITUD > other.ID_TIPO_SOLICITUD Then Return 1
        If Me.ID_TIPO_SOLICITUD < other.ID_TIPO_SOLICITUD Then Return -1
        Return 0
    End Function


#Region " Propiedades "

    Private _ID_TIPO_SOLICITUD As Decimal
    <Column(Name:="Id tipo solicitud", Storage:="ID_TIPO_SOLICITUD", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=6, Scale:=0)> _
    Public Property ID_TIPO_SOLICITUD() As Decimal
        Get
            Return _ID_TIPO_SOLICITUD
        End Get
        Set(ByVal Value As Decimal)
            _ID_TIPO_SOLICITUD = Value
            OnPropertyChanged("ID_TIPO_SOLICITUD")
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

    Private _TIPO_SOLICITUD As String
    <Column(Name:="Tipo solicitud", Storage:="TIPO_SOLICITUD", DbType:="VARCHAR2(60)", Id:=False), _
     DataObjectField(False, False, True, 60)> _
    Public Property TIPO_SOLICITUD() As String
        Get
            Return _TIPO_SOLICITUD
        End Get
        Set(ByVal Value As String)
            _TIPO_SOLICITUD = Value
            OnPropertyChanged("TIPO_SOLICITUD")
        End Set
    End Property 

    Private _TIPO_SOLICITUDOld As String
    Public Property TIPO_SOLICITUDOld() As String
        Get
            Return _TIPO_SOLICITUDOld
        End Get
        Set(ByVal Value As String)
            _TIPO_SOLICITUDOld = Value
        End Set
    End Property 

    Private _TABLA_RELACIONAL As String
    <Column(Name:="Tabla relacional", Storage:="TABLA_RELACIONAL", DbType:="VARCHAR2(40)", Id:=False), _
     DataObjectField(False, False, True, 40)> _
    Public Property TABLA_RELACIONAL() As String
        Get
            Return _TABLA_RELACIONAL
        End Get
        Set(ByVal Value As String)
            _TABLA_RELACIONAL = Value
            OnPropertyChanged("TABLA_RELACIONAL")
        End Set
    End Property 

    Private _TABLA_RELACIONALOld As String
    Public Property TABLA_RELACIONALOld() As String
        Get
            Return _TABLA_RELACIONALOld
        End Get
        Set(ByVal Value As String)
            _TABLA_RELACIONALOld = Value
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
    <Column(Name:="Userid", Storage:="USERID", DbType:="CHAR(16)", Id:=False), _
     DataObjectField(False, False, True, 16)> _
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
