''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.OFERTA_FORMATIVA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite tener un registro de la tabla OFERTA_FORMATIVA en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="OFERTA_FORMATIVA")> Public Class OFERTA_FORMATIVA
    Inherits entidadBase
    Implements IEquatable(Of OFERTA_FORMATIVA), IComparable(Of OFERTA_FORMATIVA)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(ByVal aID_OFERTA_FORMATIVA As Decimal, ByVal aID_EJERCICIO As String, ByVal aID_TEMA_CURSO As Decimal, ByVal aID_PROVEEDOR_AF As Decimal, ByVal aDURACION_HORAS As Decimal, ByVal aCOSTO_X_PARTICIPANTE As Decimal, ByVal aFECHA_INICIO As DateTime, ByVal aFECHA_FIN As DateTime, ByVal aNOTAS As String, ByVal aESTADO As String, ByVal aFECHA_APROBACION As DateTime, ByVal aUSUARIO_APROBACION As String, ByVal aUSERID As String, ByVal aLASTUPDATE As DateTime, ByVal aID_CONTRATO As Decimal)
        Me._ID_OFERTA_FORMATIVA = aID_OFERTA_FORMATIVA
        Me._ID_EJERCICIO = aID_EJERCICIO
        Me._ID_TEMA_CURSO = aID_TEMA_CURSO
        Me._ID_PROVEEDOR_AF = aID_PROVEEDOR_AF
        Me._DURACION_HORAS = aDURACION_HORAS
        Me._COSTO_X_PARTICIPANTE = aCOSTO_X_PARTICIPANTE
        Me._FECHA_INICIO = aFECHA_INICIO
        Me._FECHA_FIN = aFECHA_FIN
        Me._NOTAS = aNOTAS
        Me._ESTADO = aESTADO
        Me._FECHA_APROBACION = aFECHA_APROBACION
        Me._USUARIO_APROBACION = aUSUARIO_APROBACION
        Me._USERID = aUSERID
        Me._LASTUPDATE = aLASTUPDATE
        Me._ID_CONTRATO = aID_CONTRATO
    End Sub

    Public Function Equals1(ByVal other As OFERTA_FORMATIVA) As Boolean Implements System.IEquatable(Of OFERTA_FORMATIVA).Equals
        Return Me.ID_OFERTA_FORMATIVA = other.ID_OFERTA_FORMATIVA
    End Function

    Public Function CompareTo(ByVal other As OFERTA_FORMATIVA) As Integer Implements System.IComparable(Of OFERTA_FORMATIVA).CompareTo
        If Me.ID_OFERTA_FORMATIVA > other.ID_OFERTA_FORMATIVA Then Return 1
        If Me.ID_OFERTA_FORMATIVA < other.ID_OFERTA_FORMATIVA Then Return -1
        Return 0
    End Function


#Region " Propiedades "

    Private _ID_OFERTA_FORMATIVA As Decimal
    <Column(Name:="Id oferta formativa", Storage:="ID_OFERTA_FORMATIVA", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_OFERTA_FORMATIVA() As Decimal
        Get
            Return _ID_OFERTA_FORMATIVA
        End Get
        Set(ByVal Value As Decimal)
            _ID_OFERTA_FORMATIVA = Value
            OnPropertyChanged("ID_OFERTA_FORMATIVA")
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

    Private _ID_TEMA_CURSO As Decimal
    <Column(Name:="Id tema curso", Storage:="ID_TEMA_CURSO", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_TEMA_CURSO() As Decimal
        Get
            Return _ID_TEMA_CURSO
        End Get
        Set(ByVal Value As Decimal)
            _ID_TEMA_CURSO = Value
            OnPropertyChanged("ID_TEMA_CURSO")
        End Set
    End Property 

    Private _ID_TEMA_CURSOOld As Decimal
    Public Property ID_TEMA_CURSOOld() As Decimal
        Get
            Return _ID_TEMA_CURSOOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_TEMA_CURSOOld = Value
        End Set
    End Property 

    Private _fkID_TEMA_CURSO As CURSO_TEMA
    Public Property fkID_TEMA_CURSO() As CURSO_TEMA
        Get
            Return _fkID_TEMA_CURSO
        End Get
        Set(ByVal Value As CURSO_TEMA)
            _fkID_TEMA_CURSO = Value
        End Set
    End Property 

    Private _ID_PROVEEDOR_AF As Decimal
    <Column(Name:="Id proveedor af", Storage:="ID_PROVEEDOR_AF", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=8, Scale:=0)> _
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

    Private _DURACION_HORAS As Decimal
    <Column(Name:="Duracion horas", Storage:="DURACION_HORAS", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=0, Scale:=0)> _
    Public Property DURACION_HORAS() As Decimal
        Get
            Return _DURACION_HORAS
        End Get
        Set(ByVal Value As Decimal)
            _DURACION_HORAS = Value
            OnPropertyChanged("DURACION_HORAS")
        End Set
    End Property 

    Private _DURACION_HORASOld As Decimal
    Public Property DURACION_HORASOld() As Decimal
        Get
            Return _DURACION_HORASOld
        End Get
        Set(ByVal Value As Decimal)
            _DURACION_HORASOld = Value
        End Set
    End Property 

    Private _COSTO_X_PARTICIPANTE As Decimal
    <Column(Name:="Costo x participante", Storage:="COSTO_X_PARTICIPANTE", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=2)> _
    Public Property COSTO_X_PARTICIPANTE() As Decimal
        Get
            Return _COSTO_X_PARTICIPANTE
        End Get
        Set(ByVal Value As Decimal)
            _COSTO_X_PARTICIPANTE = Value
            OnPropertyChanged("COSTO_X_PARTICIPANTE")
        End Set
    End Property 

    Private _COSTO_X_PARTICIPANTEOld As Decimal
    Public Property COSTO_X_PARTICIPANTEOld() As Decimal
        Get
            Return _COSTO_X_PARTICIPANTEOld
        End Get
        Set(ByVal Value As Decimal)
            _COSTO_X_PARTICIPANTEOld = Value
        End Set
    End Property 

    Private _FECHA_INICIO As DateTime
    <Column(Name:="Fecha inicio", Storage:="FECHA_INICIO", DbType:="DATE", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property FECHA_INICIO() As DateTime
        Get
            Return _FECHA_INICIO
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_INICIO = Value
            OnPropertyChanged("FECHA_INICIO")
        End Set
    End Property 

    Private _FECHA_INICIOOld As DateTime
    Public Property FECHA_INICIOOld() As DateTime
        Get
            Return _FECHA_INICIOOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_INICIOOld = Value
        End Set
    End Property 

    Private _FECHA_FIN As DateTime
    <Column(Name:="Fecha fin", Storage:="FECHA_FIN", DbType:="DATE", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property FECHA_FIN() As DateTime
        Get
            Return _FECHA_FIN
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_FIN = Value
            OnPropertyChanged("FECHA_FIN")
        End Set
    End Property 

    Private _FECHA_FINOld As DateTime
    Public Property FECHA_FINOld() As DateTime
        Get
            Return _FECHA_FINOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_FINOld = Value
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

    Private _FECHA_APROBACION As DateTime
    <Column(Name:="Fecha aprobacion", Storage:="FECHA_APROBACION", DbType:="DATE", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property FECHA_APROBACION() As DateTime
        Get
            Return _FECHA_APROBACION
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_APROBACION = Value
            OnPropertyChanged("FECHA_APROBACION")
        End Set
    End Property 

    Private _FECHA_APROBACIONOld As DateTime
    Public Property FECHA_APROBACIONOld() As DateTime
        Get
            Return _FECHA_APROBACIONOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_APROBACIONOld = Value
        End Set
    End Property 

    Private _USUARIO_APROBACION As String
    <Column(Name:="Usuario aprobacion", Storage:="USUARIO_APROBACION", DbType:="CHAR(16)", Id:=False), _
     DataObjectField(False, False, True, 16)> _
    Public Property USUARIO_APROBACION() As String
        Get
            Return _USUARIO_APROBACION
        End Get
        Set(ByVal Value As String)
            _USUARIO_APROBACION = Value
            OnPropertyChanged("USUARIO_APROBACION")
        End Set
    End Property

    Private _USUARIO_APROBACIONOld As String
    Public Property USUARIO_APROBACIONOld() As String
        Get
            Return _USUARIO_APROBACIONOld
        End Get
        Set(ByVal Value As String)
            _USUARIO_APROBACIONOld = Value
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

    Private _ID_CONTRATO As Decimal
    <Column(Name:="Id contrato", Storage:="ID_CONTRATO", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_CONTRATO() As Decimal
        Get
            Return _ID_CONTRATO
        End Get
        Set(ByVal Value As Decimal)
            _ID_CONTRATO = Value
            OnPropertyChanged("ID_CONTRATO")
        End Set
    End Property

    Private _ID_CONTRATOOld As Decimal
    Public Property ID_CONTRATOOld() As Decimal
        Get
            Return _ID_CONTRATOOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_CONTRATOOld = Value
        End Set
    End Property

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
