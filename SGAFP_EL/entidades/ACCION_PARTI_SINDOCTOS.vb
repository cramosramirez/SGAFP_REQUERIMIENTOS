''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.ACCION_PARTI_SINDOCTOS
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row ACCION_PARTI_SINDOCTOS en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	06/05/2013	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="ACCION_PARTI_SINDOCTOS")> Public Class ACCION_PARTI_SINDOCTOS
    Inherits entidadBase
    Implements IEquatable(Of ACCION_PARTI_SINDOCTOS), IComparable(Of ACCION_PARTI_SINDOCTOS)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_ACCION_PARTI As Decimal, aID_ACCION_FORMATIVA As Decimal, aCANT_PARTICIPANTES As Decimal, aES_ACTIVA As Decimal, aUSUARIO_CREACION As String, aFECHA_CREACION As DateTime, aUSERID As String, aLASTUPDATE As DateTime, aTIPO_AUTORIZACION As String)
        Me._ID_ACCION_PARTI = aID_ACCION_PARTI
        Me._ID_ACCION_FORMATIVA = aID_ACCION_FORMATIVA
        Me._CANT_PARTICIPANTES = aCANT_PARTICIPANTES
        Me._ES_ACTIVA = aES_ACTIVA
        Me._USUARIO_CREACION = aUSUARIO_CREACION
        Me._FECHA_CREACION = aFECHA_CREACION
        Me._USERID = aUSERID
        Me._LASTUPDATE = aLASTUPDATE
        Me._TIPO_AUTORIZACION = aTIPO_AUTORIZACION
    End Sub

    Public Function Equals1(ByVal other As ACCION_PARTI_SINDOCTOS) As Boolean Implements System.IEquatable(Of ACCION_PARTI_SINDOCTOS).Equals
        Return Me.ID_ACCION_PARTI = other.ID_ACCION_PARTI
    End Function

    Public Function CompareTo(ByVal other As ACCION_PARTI_SINDOCTOS) As Integer Implements System.IComparable(Of ACCION_PARTI_SINDOCTOS).CompareTo
        If Me.ID_ACCION_PARTI > other.ID_ACCION_PARTI Then Return 1
        If Me.ID_ACCION_PARTI < other.ID_ACCION_PARTI Then Return -1
        Return 0
    End Function


#Region " Properties "

    Private _ID_ACCION_PARTI As Decimal
    <Column(Name:="Id accion parti", Storage:="ID_ACCION_PARTI", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_ACCION_PARTI() As Decimal
        Get
            Return _ID_ACCION_PARTI
        End Get
        Set(ByVal Value As Decimal)
            _ID_ACCION_PARTI = Value
            OnPropertyChanged("ID_ACCION_PARTI")
        End Set
    End Property 

    Private _ID_ACCION_FORMATIVA As Decimal
    <Column(Name:="Id accion formativa", Storage:="ID_ACCION_FORMATIVA", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=8, Scale:=0)> _
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

    Private _CANT_PARTICIPANTES As Decimal
    <Column(Name:="Cant participantes", Storage:="CANT_PARTICIPANTES", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=3, Scale:=0)> _
    Public Property CANT_PARTICIPANTES() As Decimal
        Get
            Return _CANT_PARTICIPANTES
        End Get
        Set(ByVal Value As Decimal)
            _CANT_PARTICIPANTES = Value
            OnPropertyChanged("CANT_PARTICIPANTES")
        End Set
    End Property 

    Private _CANT_PARTICIPANTESOld As Decimal
    Public Property CANT_PARTICIPANTESOld() As Decimal
        Get
            Return _CANT_PARTICIPANTESOld
        End Get
        Set(ByVal Value As Decimal)
            _CANT_PARTICIPANTESOld = Value
        End Set
    End Property 

    Private _ES_ACTIVA As Decimal
    <Column(Name:="Es activa", Storage:="ES_ACTIVA", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=1, Scale:=0)> _
    Public Property ES_ACTIVA() As Decimal
        Get
            Return _ES_ACTIVA
        End Get
        Set(ByVal Value As Decimal)
            _ES_ACTIVA = Value
            OnPropertyChanged("ES_ACTIVA")
        End Set
    End Property 

    Private _ES_ACTIVAOld As Decimal
    Public Property ES_ACTIVAOld() As Decimal
        Get
            Return _ES_ACTIVAOld
        End Get
        Set(ByVal Value As Decimal)
            _ES_ACTIVAOld = Value
        End Set
    End Property 

    Private _USUARIO_CREACION As String
    <Column(Name:="Usuario creacion", Storage:="USUARIO_CREACION", DbType:="VARCHAR2(255) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 255)> _
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
    <Column(Name:="Userid", Storage:="USERID", DbType:="VARCHAR2(255) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 255)> _
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


    Private _TIPO_AUTORIZACION As String
    <Column(Name:="Tipo autorizacion", Storage:="TIPO_AUTORIZACION", DbType:="VARCHAR2(4) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 4)> _
    Public Property TIPO_AUTORIZACION() As String
        Get
            Return _TIPO_AUTORIZACION
        End Get
        Set(ByVal Value As String)
            _TIPO_AUTORIZACION = Value
            OnPropertyChanged("TIPO_AUTORIZACION")
        End Set
    End Property

    Private _TIPO_AUTORIZACIONOld As String
    Public Property TIPO_AUTORIZACIONOld() As String
        Get
            Return _TIPO_AUTORIZACIONOld
        End Get
        Set(ByVal Value As String)
            _TIPO_AUTORIZACIONOld = Value
        End Set
    End Property

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
