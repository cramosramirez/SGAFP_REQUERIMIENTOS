''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.ACCION_PROGRA_RETRO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row ACCION_PROGRA_RETRO en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	10/02/2017	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="ACCION_PROGRA_RETRO")> Public Class ACCION_PROGRA_RETRO
    Inherits entidadBase
    Implements IEquatable(Of ACCION_PROGRA_RETRO), IComparable(Of ACCION_PROGRA_RETRO)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_ACCION_PROGRA_RETRO As Decimal, aID_PROVEEDOR_AF As Decimal, aID_EJERCICIO As String, aID_ACCION_FORMATIVA As Decimal, aNOMBRE_ACCION_FORMATIVA As String, aCODIGO_GRUPO As String, aFECHA_EXPIRA As DateTime, aMOTIVO As String, aACTIVO As Decimal, aUSUARIO_CREACION As String, aFECHA_CREACION As DateTime, aUSUARIO_PROGRAMO As String, aFECHA_PROGRAMO As DateTime, aUSERID As String, aLASTUPDATE As DateTime, aCODIGO_ESTADO_AF_PROP As String)
        Me._ID_ACCION_PROGRA_RETRO = aID_ACCION_PROGRA_RETRO
        Me._ID_PROVEEDOR_AF = aID_PROVEEDOR_AF
        Me._ID_EJERCICIO = aID_EJERCICIO
        Me._ID_ACCION_FORMATIVA = aID_ACCION_FORMATIVA
        Me._NOMBRE_ACCION_FORMATIVA = aNOMBRE_ACCION_FORMATIVA
        Me._CODIGO_GRUPO = aCODIGO_GRUPO
        Me._FECHA_EXPIRA = aFECHA_EXPIRA
        Me._MOTIVO = aMOTIVO
        Me._ACTIVO = aACTIVO
        Me._USUARIO_CREACION = aUSUARIO_CREACION
        Me._FECHA_CREACION = aFECHA_CREACION
        Me._USUARIO_PROGRAMO = aUSUARIO_PROGRAMO
        Me._FECHA_PROGRAMO = aFECHA_PROGRAMO
        Me._USERID = aUSERID
        Me._LASTUPDATE = aLASTUPDATE
        Me._CODIGO_ESTADO_AF_PROP = aCODIGO_ESTADO_AF_PROP
    End Sub

    Public Function Equals1(ByVal other As ACCION_PROGRA_RETRO) As Boolean Implements System.IEquatable(Of ACCION_PROGRA_RETRO).Equals
        Return Me.ID_ACCION_PROGRA_RETRO = other.ID_ACCION_PROGRA_RETRO
    End Function

    Public Function CompareTo(ByVal other As ACCION_PROGRA_RETRO) As Integer Implements System.IComparable(Of ACCION_PROGRA_RETRO).CompareTo
        If Me.ID_ACCION_PROGRA_RETRO > other.ID_ACCION_PROGRA_RETRO Then Return 1
        If Me.ID_ACCION_PROGRA_RETRO < other.ID_ACCION_PROGRA_RETRO Then Return -1
        Return 0
    End Function


#Region " Properties "

    Private _ID_ACCION_PROGRA_RETRO As Decimal
    <Column(Name:="Id accion progra retro", Storage:="ID_ACCION_PROGRA_RETRO", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_ACCION_PROGRA_RETRO() As Decimal
        Get
            Return _ID_ACCION_PROGRA_RETRO
        End Get
        Set(ByVal Value As Decimal)
            _ID_ACCION_PROGRA_RETRO = Value
            OnPropertyChanged("ID_ACCION_PROGRA_RETRO")
        End Set
    End Property 

    Private _ID_PROVEEDOR_AF As Decimal
    <Column(Name:="Id proveedor af", Storage:="ID_PROVEEDOR_AF", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=38, Scale:=0)> _
    Public Property ID_PROVEEDOR_AF() As Decimal
        Get
            Return _ID_PROVEEDOR_AF
        End Get
        Set(ByVal Value As Decimal)
            _ID_PROVEEDOR_AF = Value
            OnPropertyChanged("ID_PROVEEDOR_AF")
        End Set
    End Property 

    Private _ID_PROVEEDOR_AFOld As Decimal
    Public Property ID_PROVEEDOR_AFOld() As Decimal
        Get
            Return _ID_PROVEEDOR_AFOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_PROVEEDOR_AFOld = Value
        End Set
    End Property 

    Private _fkID_PROVEEDOR_AF As PROVEEDOR_AF
    Public Property fkID_PROVEEDOR_AF() As PROVEEDOR_AF
        Get
            Return _fkID_PROVEEDOR_AF
        End Get
        Set(ByVal Value As PROVEEDOR_AF)
            _fkID_PROVEEDOR_AF = Value
        End Set
    End Property 

    Private _ID_EJERCICIO As String
    <Column(Name:="Id ejercicio", Storage:="ID_EJERCICIO", DbType:="CHAR(4) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 4)> _
    Public Property ID_EJERCICIO() As String
        Get
            Return _ID_EJERCICIO
        End Get
        Set(ByVal Value As String)
            _ID_EJERCICIO = Value
            OnPropertyChanged("ID_EJERCICIO")
        End Set
    End Property 

    Private _ID_EJERCICIOOld As String
    Public Property ID_EJERCICIOOld() As String
        Get
            Return _ID_EJERCICIOOld
        End Get
        Set(ByVal Value As String)
            _ID_EJERCICIOOld = Value
        End Set
    End Property 

    Private _fkID_EJERCICIO As EJERCICIO
    Public Property fkID_EJERCICIO() As EJERCICIO
        Get
            Return _fkID_EJERCICIO
        End Get
        Set(ByVal Value As EJERCICIO)
            _fkID_EJERCICIO = Value
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

    Private _NOMBRE_ACCION_FORMATIVA As String
    <Column(Name:="Nombre accion formativa", Storage:="NOMBRE_ACCION_FORMATIVA", DbType:="VARCHAR2(150) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 150)> _
    Public Property NOMBRE_ACCION_FORMATIVA() As String
        Get
            Return _NOMBRE_ACCION_FORMATIVA
        End Get
        Set(ByVal Value As String)
            _NOMBRE_ACCION_FORMATIVA = Value
            OnPropertyChanged("NOMBRE_ACCION_FORMATIVA")
        End Set
    End Property 

    Private _NOMBRE_ACCION_FORMATIVAOld As String
    Public Property NOMBRE_ACCION_FORMATIVAOld() As String
        Get
            Return _NOMBRE_ACCION_FORMATIVAOld
        End Get
        Set(ByVal Value As String)
            _NOMBRE_ACCION_FORMATIVAOld = Value
        End Set
    End Property 

    Private _CODIGO_GRUPO As String
    <Column(Name:="Codigo grupo", Storage:="CODIGO_GRUPO", DbType:="VARCHAR2(40) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 40)> _
    Public Property CODIGO_GRUPO() As String
        Get
            Return _CODIGO_GRUPO
        End Get
        Set(ByVal Value As String)
            _CODIGO_GRUPO = Value
            OnPropertyChanged("CODIGO_GRUPO")
        End Set
    End Property 

    Private _CODIGO_GRUPOOld As String
    Public Property CODIGO_GRUPOOld() As String
        Get
            Return _CODIGO_GRUPOOld
        End Get
        Set(ByVal Value As String)
            _CODIGO_GRUPOOld = Value
        End Set
    End Property 

    Private _FECHA_EXPIRA As DateTime
    <Column(Name:="Fecha expira", Storage:="FECHA_EXPIRA", DbType:="DATE NOT NULL", Id:=False), _
     DataObjectField(False, False, False)> _
    Public Property FECHA_EXPIRA() As DateTime
        Get
            Return _FECHA_EXPIRA
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_EXPIRA = Value
            OnPropertyChanged("FECHA_EXPIRA")
        End Set
    End Property 

    Private _FECHA_EXPIRAOld As DateTime
    Public Property FECHA_EXPIRAOld() As DateTime
        Get
            Return _FECHA_EXPIRAOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_EXPIRAOld = Value
        End Set
    End Property 

    Private _MOTIVO As String
    <Column(Name:="Motivo", Storage:="MOTIVO", DbType:="VARCHAR2(1000) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 1000)> _
    Public Property MOTIVO() As String
        Get
            Return _MOTIVO
        End Get
        Set(ByVal Value As String)
            _MOTIVO = Value
            OnPropertyChanged("MOTIVO")
        End Set
    End Property 

    Private _MOTIVOOld As String
    Public Property MOTIVOOld() As String
        Get
            Return _MOTIVOOld
        End Get
        Set(ByVal Value As String)
            _MOTIVOOld = Value
        End Set
    End Property 

    Private _ACTIVO As Decimal
    <Column(Name:="Activo", Storage:="ACTIVO", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=1, Scale:=0)> _
    Public Property ACTIVO() As Decimal
        Get
            Return _ACTIVO
        End Get
        Set(ByVal Value As Decimal)
            _ACTIVO = Value
            OnPropertyChanged("ACTIVO")
        End Set
    End Property 

    Private _ACTIVOOld As Decimal
    Public Property ACTIVOOld() As Decimal
        Get
            Return _ACTIVOOld
        End Get
        Set(ByVal Value As Decimal)
            _ACTIVOOld = Value
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

    Private _USUARIO_PROGRAMO As String
    <Column(Name:="Usuario programo", Storage:="USUARIO_PROGRAMO", DbType:="VARCHAR2(255)", Id:=False), _
     DataObjectField(False, False, True, 255)> _
    Public Property USUARIO_PROGRAMO() As String
        Get
            Return _USUARIO_PROGRAMO
        End Get
        Set(ByVal Value As String)
            _USUARIO_PROGRAMO = Value
            OnPropertyChanged("USUARIO_PROGRAMO")
        End Set
    End Property 

    Private _USUARIO_PROGRAMOOld As String
    Public Property USUARIO_PROGRAMOOld() As String
        Get
            Return _USUARIO_PROGRAMOOld
        End Get
        Set(ByVal Value As String)
            _USUARIO_PROGRAMOOld = Value
        End Set
    End Property 

    Private _FECHA_PROGRAMO As DateTime
    <Column(Name:="Fecha programo", Storage:="FECHA_PROGRAMO", DbType:="DATE", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property FECHA_PROGRAMO() As DateTime
        Get
            Return _FECHA_PROGRAMO
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_PROGRAMO = Value
            OnPropertyChanged("FECHA_PROGRAMO")
        End Set
    End Property 

    Private _FECHA_PROGRAMOOld As DateTime
    Public Property FECHA_PROGRAMOOld() As DateTime
        Get
            Return _FECHA_PROGRAMOOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_PROGRAMOOld = Value
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

    Private _CODIGO_ESTADO_AF_PROP As String
    <Column(Name:="Codigo estado af prop", Storage:="CODIGO_ESTADO_AF_PROP", DbType:="CHAR(2)", Id:=False), _
     DataObjectField(False, False, True, 2)> _
    Public Property CODIGO_ESTADO_AF_PROP() As String
        Get
            Return _CODIGO_ESTADO_AF_PROP
        End Get
        Set(ByVal Value As String)
            _CODIGO_ESTADO_AF_PROP = Value
            OnPropertyChanged("CODIGO_ESTADO_AF_PROP")
        End Set
    End Property 

    Private _CODIGO_ESTADO_AF_PROPOld As String
    Public Property CODIGO_ESTADO_AF_PROPOld() As String
        Get
            Return _CODIGO_ESTADO_AF_PROPOld
        End Get
        Set(ByVal Value As String)
            _CODIGO_ESTADO_AF_PROPOld = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
