''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.GRUPO_ACCION_CONTRATADA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row GRUPO_ACCION_CONTRATADA en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	12/04/2013	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="GRUPO_ACCION_CONTRATADA")> Public Class GRUPO_ACCION_CONTRATADA
    Inherits entidadBase
    Implements IEquatable(Of GRUPO_ACCION_CONTRATADA), IComparable(Of GRUPO_ACCION_CONTRATADA)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(ByVal aID_GRUPO_ACCION As Decimal, ByVal aID_ACCION_CONTRATADA As Decimal, ByVal aID_GRUPO_AF As Decimal, ByVal aID_ACCION_FORMATIVA As Decimal, ByVal aUSUARIO_CREACION As String, ByVal aFECHA_CREACION As DateTime, ByVal aUSERID As String, ByVal aLASTUPDATE As DateTime, ByVal aMONTO As Decimal, ByVal aHABILITADO As Decimal)
        Me._ID_GRUPO_ACCION = aID_GRUPO_ACCION
        Me._ID_ACCION_CONTRATADA = aID_ACCION_CONTRATADA
        Me._ID_GRUPO_AF = aID_GRUPO_AF
        Me._ID_ACCION_FORMATIVA = aID_ACCION_FORMATIVA
        Me._USUARIO_CREACION = aUSUARIO_CREACION
        Me._FECHA_CREACION = aFECHA_CREACION
        Me._USERID = aUSERID
        Me._LASTUPDATE = aLASTUPDATE
        Me._MONTO = aMONTO
        Me._HABILITADO = aHABILITADO
    End Sub

    Public Function Equals1(ByVal other As GRUPO_ACCION_CONTRATADA) As Boolean Implements System.IEquatable(Of GRUPO_ACCION_CONTRATADA).Equals
        Return Me.ID_GRUPO_ACCION = other.ID_GRUPO_ACCION
    End Function

    Public Function CompareTo(ByVal other As GRUPO_ACCION_CONTRATADA) As Integer Implements System.IComparable(Of GRUPO_ACCION_CONTRATADA).CompareTo
        If Me.ID_GRUPO_ACCION > other.ID_GRUPO_ACCION Then Return 1
        If Me.ID_GRUPO_ACCION < other.ID_GRUPO_ACCION Then Return -1
        Return 0
    End Function


#Region " Properties "

    Private _ID_GRUPO_ACCION As Decimal
    <Column(Name:="Id grupo accion", Storage:="ID_GRUPO_ACCION", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=38, Scale:=0)> _
    Public Property ID_GRUPO_ACCION() As Decimal
        Get
            Return _ID_GRUPO_ACCION
        End Get
        Set(ByVal Value As Decimal)
            _ID_GRUPO_ACCION = Value
            OnPropertyChanged("ID_GRUPO_ACCION")
        End Set
    End Property 

    Private _ID_ACCION_CONTRATADA As Decimal
    <Column(Name:="Id accion contratada", Storage:="ID_ACCION_CONTRATADA", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=38, Scale:=0)> _
    Public Property ID_ACCION_CONTRATADA() As Decimal
        Get
            Return _ID_ACCION_CONTRATADA
        End Get
        Set(ByVal Value As Decimal)
            _ID_ACCION_CONTRATADA = Value
            OnPropertyChanged("ID_ACCION_CONTRATADA")
        End Set
    End Property 

    Private _ID_ACCION_CONTRATADAOld As Decimal
    Public Property ID_ACCION_CONTRATADAOld() As Decimal
        Get
            Return _ID_ACCION_CONTRATADAOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_ACCION_CONTRATADAOld = Value
        End Set
    End Property 

    Private _fkID_ACCION_CONTRATADA As ACCION_CONTRATADA
    Public Property fkID_ACCION_CONTRATADA() As ACCION_CONTRATADA
        Get
            Return _fkID_ACCION_CONTRATADA
        End Get
        Set(ByVal Value As ACCION_CONTRATADA)
            _fkID_ACCION_CONTRATADA = Value
        End Set
    End Property 

    Private _ID_GRUPO_AF As Decimal
    <Column(Name:="Id grupo af", Storage:="ID_GRUPO_AF", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=38, Scale:=0)> _
    Public Property ID_GRUPO_AF() As Decimal
        Get
            Return _ID_GRUPO_AF
        End Get
        Set(ByVal Value As Decimal)
            _ID_GRUPO_AF = Value
            OnPropertyChanged("ID_GRUPO_AF")
        End Set
    End Property 

    Private _ID_GRUPO_AFOld As Decimal
    Public Property ID_GRUPO_AFOld() As Decimal
        Get
            Return _ID_GRUPO_AFOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_GRUPO_AFOld = Value
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

    Private _MONTO As Decimal
    <Column(Name:="Monto", Storage:="MONTO", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=2)> _
    Public Property MONTO() As Decimal
        Get
            Return _MONTO
        End Get
        Set(ByVal Value As Decimal)
            _MONTO = Value
            OnPropertyChanged("MONTO")
        End Set
    End Property

    Private _MONTOOld As Decimal
    Public Property MONTOOld() As Decimal
        Get
            Return _MONTOOld
        End Get
        Set(ByVal Value As Decimal)
            _MONTOOld = Value
        End Set
    End Property

    Private _HABILITADO As Decimal
    <Column(Name:="Habilitado", Storage:="HABILITADO", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=1)> _
    Public Property HABILITADO() As Decimal
        Get
            Return _HABILITADO
        End Get
        Set(ByVal Value As Decimal)
            _HABILITADO = Value
            OnPropertyChanged("HABILITADO")
        End Set
    End Property

    Private _HABILITADOOld As Decimal
    Public Property HABILITADOOld() As Decimal
        Get
            Return _HABILITADOOld
        End Get
        Set(ByVal Value As Decimal)
            _HABILITADOOld = Value
        End Set
    End Property

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
