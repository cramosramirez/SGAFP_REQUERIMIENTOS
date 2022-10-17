''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.SIPU_GENERACION
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row SIPU_GENERACION en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	29/10/2013	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="SIPU_GENERACION")> Public Class SIPU_GENERACION
    Inherits entidadBase
    Implements IEquatable(Of SIPU_GENERACION), IComparable(Of SIPU_GENERACION)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_GENERACION As Decimal, aFECHA As DateTime, aFUENTE As Decimal, aNUMERO_CONVOCATORIA As Decimal, aUSUARIO_CREACION As String, aFECHA_CREACION As DateTime, aUSERID As String, aLASTUPDATE As DateTime, ByVal aNOMBRE_ARCHIVO As String)
        Me._ID_GENERACION = aID_GENERACION
        Me._FECHA = aFECHA
        Me._FUENTE = aFUENTE
        Me._NUMERO_CONVOCATORIA = aNUMERO_CONVOCATORIA
        Me._USUARIO_CREACION = aUSUARIO_CREACION
        Me._FECHA_CREACION = aFECHA_CREACION
        Me._USERID = aUSERID
        Me._LASTUPDATE = aLASTUPDATE
        Me._NOMBRE_ARCHIVO = aNOMBRE_ARCHIVO
    End Sub

    Public Function Equals1(ByVal other As SIPU_GENERACION) As Boolean Implements System.IEquatable(Of SIPU_GENERACION).Equals
        Return Me.ID_GENERACION = other.ID_GENERACION
    End Function

    Public Function CompareTo(ByVal other As SIPU_GENERACION) As Integer Implements System.IComparable(Of SIPU_GENERACION).CompareTo
        If Me.ID_GENERACION > other.ID_GENERACION Then Return 1
        If Me.ID_GENERACION < other.ID_GENERACION Then Return -1
        Return 0
    End Function


#Region " Properties "

    Private _ID_GENERACION As Decimal
    <Column(Name:="Id generacion", Storage:="ID_GENERACION", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_GENERACION() As Decimal
        Get
            Return _ID_GENERACION
        End Get
        Set(ByVal Value As Decimal)
            _ID_GENERACION = Value
            OnPropertyChanged("ID_GENERACION")
        End Set
    End Property 

    Private _FECHA As DateTime
    <Column(Name:="Fecha", Storage:="FECHA", DbType:="DATE NOT NULL", Id:=False), _
     DataObjectField(False, False, False)> _
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

    Private _FUENTE As Decimal
    <Column(Name:="Fuente", Storage:="FUENTE", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=3, Scale:=0)> _
    Public Property FUENTE() As Decimal
        Get
            Return _FUENTE
        End Get
        Set(ByVal Value As Decimal)
            _FUENTE = Value
            OnPropertyChanged("FUENTE")
        End Set
    End Property 

    Private _FUENTEOld As Decimal
    Public Property FUENTEOld() As Decimal
        Get
            Return _FUENTEOld
        End Get
        Set(ByVal Value As Decimal)
            _FUENTEOld = Value
        End Set
    End Property 

    Private _NUMERO_CONVOCATORIA As Decimal
    <Column(Name:="Numero convocatoria", Storage:="NUMERO_CONVOCATORIA", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=3, Scale:=0)> _
    Public Property NUMERO_CONVOCATORIA() As Decimal
        Get
            Return _NUMERO_CONVOCATORIA
        End Get
        Set(ByVal Value As Decimal)
            _NUMERO_CONVOCATORIA = Value
            OnPropertyChanged("NUMERO_CONVOCATORIA")
        End Set
    End Property 

    Private _NUMERO_CONVOCATORIAOld As Decimal
    Public Property NUMERO_CONVOCATORIAOld() As Decimal
        Get
            Return _NUMERO_CONVOCATORIAOld
        End Get
        Set(ByVal Value As Decimal)
            _NUMERO_CONVOCATORIAOld = Value
        End Set
    End Property 

    Private _USUARIO_CREACION As String
    <Column(Name:="Usuario creacion", Storage:="USUARIO_CREACION", DbType:="VARCHAR2(250) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 250)> _
    Public Property USUARIO_CREACION() As String
        Get
            Return _USUARIO_CREACION
        End Get
        Set(ByVal Value As String)
            _USUARIO_CREACION = Value
            OnPropertyChanged("USUARIO_CREACION")
        End Set
    End Property 

    Private _USUARIO_CREACIONOld As String
    Public Property USUARIO_CREACIONOld() As String
        Get
            Return _USUARIO_CREACIONOld
        End Get
        Set(ByVal Value As String)
            _USUARIO_CREACIONOld = Value
        End Set
    End Property 

    Private _FECHA_CREACION As DateTime
    <Column(Name:="Fecha creacion", Storage:="FECHA_CREACION", DbType:="DATE NOT NULL", Id:=False), _
     DataObjectField(False, False, False)> _
    Public Property FECHA_CREACION() As DateTime
        Get
            Return _FECHA_CREACION
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_CREACION = Value
            OnPropertyChanged("FECHA_CREACION")
        End Set
    End Property 

    Private _FECHA_CREACIONOld As DateTime
    Public Property FECHA_CREACIONOld() As DateTime
        Get
            Return _FECHA_CREACIONOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_CREACIONOld = Value
        End Set
    End Property 

    Private _USERID As String
    <Column(Name:="Userid", Storage:="USERID", DbType:="VARCHAR2(250) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 250)> _
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


    Private _NOMBRE_ARCHIVO As String
    <Column(Name:="Nombre archivo", Storage:="NOMBRE_ARCHIVO", DbType:="VARCHAR2(500) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 250)> _
    Public Property NOMBRE_ARCHIVO() As String
        Get
            Return _NOMBRE_ARCHIVO
        End Get
        Set(ByVal Value As String)
            _NOMBRE_ARCHIVO = Value
            OnPropertyChanged("NOMBRE_ARCHIVO")
        End Set
    End Property

    Private _NOMBRE_ARCHIVOOld As String
    Public Property NOMBRE_ARCHIVOOld() As String
        Get
            Return _NOMBRE_ARCHIVOOld
        End Get
        Set(ByVal Value As String)
            _NOMBRE_ARCHIVOOld = Value
        End Set
    End Property

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
