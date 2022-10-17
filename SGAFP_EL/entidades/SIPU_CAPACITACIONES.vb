''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.SIPU_CAPACITACIONES
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row SIPU_CAPACITACIONES en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	29/10/2013	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="SIPU_CAPACITACIONES")> Public Class SIPU_CAPACITACIONES
    Inherits entidadBase
    Implements IEquatable(Of SIPU_CAPACITACIONES), IComparable(Of SIPU_CAPACITACIONES)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aIDCAPACITACION As Decimal, aDESCRIPCION As String, aIDTIPOCAPACITACION As Decimal, aIDESTADO As Decimal, aFECHAINICIO As DateTime, aFECHAFIN As DateTime, aIDMUNICIPIO As Decimal, aID_GENERACION As Decimal)
        Me._IDCAPACITACION = aIDCAPACITACION
        Me._DESCRIPCION = aDESCRIPCION
        Me._IDTIPOCAPACITACION = aIDTIPOCAPACITACION
        Me._IDESTADO = aIDESTADO
        Me._FECHAINICIO = aFECHAINICIO
        Me._FECHAFIN = aFECHAFIN
        Me._IDMUNICIPIO = aIDMUNICIPIO
        Me._ID_GENERACION = aID_GENERACION
    End Sub

    Public Function Equals1(ByVal other As SIPU_CAPACITACIONES) As Boolean Implements System.IEquatable(Of SIPU_CAPACITACIONES).Equals
        Return Me.IDCAPACITACION = other.IDCAPACITACION
    End Function

    Public Function CompareTo(ByVal other As SIPU_CAPACITACIONES) As Integer Implements System.IComparable(Of SIPU_CAPACITACIONES).CompareTo
        If Me.IDCAPACITACION > other.IDCAPACITACION Then Return 1
        If Me.IDCAPACITACION < other.IDCAPACITACION Then Return -1
        Return 0
    End Function


#Region " Properties "

    Private _IDCAPACITACION As Decimal
    <Column(Name:="Idcapacitacion", Storage:="IDCAPACITACION", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=8, Scale:=0)> _
    Public Property IDCAPACITACION() As Decimal
        Get
            Return _IDCAPACITACION
        End Get
        Set(ByVal Value As Decimal)
            _IDCAPACITACION = Value
            OnPropertyChanged("IDCAPACITACION")
        End Set
    End Property 

    Private _DESCRIPCION As String
    <Column(Name:="Descripcion", Storage:="DESCRIPCION", DbType:="VARCHAR2(400) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 400)> _
    Public Property DESCRIPCION() As String
        Get
            Return _DESCRIPCION
        End Get
        Set(ByVal Value As String)
            _DESCRIPCION = Value
            OnPropertyChanged("DESCRIPCION")
        End Set
    End Property 

    Private _DESCRIPCIONOld As String
    Public Property DESCRIPCIONOld() As String
        Get
            Return _DESCRIPCIONOld
        End Get
        Set(ByVal Value As String)
            _DESCRIPCIONOld = Value
        End Set
    End Property 

    Private _IDTIPOCAPACITACION As Decimal
    <Column(Name:="Idtipocapacitacion", Storage:="IDTIPOCAPACITACION", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=0, Scale:=0)> _
    Public Property IDTIPOCAPACITACION() As Decimal
        Get
            Return _IDTIPOCAPACITACION
        End Get
        Set(ByVal Value As Decimal)
            _IDTIPOCAPACITACION = Value
            OnPropertyChanged("IDTIPOCAPACITACION")
        End Set
    End Property 

    Private _IDTIPOCAPACITACIONOld As Decimal
    Public Property IDTIPOCAPACITACIONOld() As Decimal
        Get
            Return _IDTIPOCAPACITACIONOld
        End Get
        Set(ByVal Value As Decimal)
            _IDTIPOCAPACITACIONOld = Value
        End Set
    End Property 

    Private _fkIDTIPOCAPACITACION As SIPU_TIPOCAPACITACIONES
    Public Property fkIDTIPOCAPACITACION() As SIPU_TIPOCAPACITACIONES
        Get
            Return _fkIDTIPOCAPACITACION
        End Get
        Set(ByVal Value As SIPU_TIPOCAPACITACIONES)
            _fkIDTIPOCAPACITACION = Value
        End Set
    End Property 

    Private _IDESTADO As Decimal
    <Column(Name:="Idestado", Storage:="IDESTADO", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=0, Scale:=0)> _
    Public Property IDESTADO() As Decimal
        Get
            Return _IDESTADO
        End Get
        Set(ByVal Value As Decimal)
            _IDESTADO = Value
            OnPropertyChanged("IDESTADO")
        End Set
    End Property 

    Private _IDESTADOOld As Decimal
    Public Property IDESTADOOld() As Decimal
        Get
            Return _IDESTADOOld
        End Get
        Set(ByVal Value As Decimal)
            _IDESTADOOld = Value
        End Set
    End Property 

    Private _FECHAINICIO As DateTime
    <Column(Name:="Fechainicio", Storage:="FECHAINICIO", DbType:="DATE NOT NULL", Id:=False), _
     DataObjectField(False, False, False)> _
    Public Property FECHAINICIO() As DateTime
        Get
            Return _FECHAINICIO
        End Get
        Set(ByVal Value As DateTime)
            _FECHAINICIO = Value
            OnPropertyChanged("FECHAINICIO")
        End Set
    End Property 

    Private _FECHAINICIOOld As DateTime
    Public Property FECHAINICIOOld() As DateTime
        Get
            Return _FECHAINICIOOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHAINICIOOld = Value
        End Set
    End Property 

    Private _FECHAFIN As DateTime
    <Column(Name:="Fechafin", Storage:="FECHAFIN", DbType:="DATE NOT NULL", Id:=False), _
     DataObjectField(False, False, False)> _
    Public Property FECHAFIN() As DateTime
        Get
            Return _FECHAFIN
        End Get
        Set(ByVal Value As DateTime)
            _FECHAFIN = Value
            OnPropertyChanged("FECHAFIN")
        End Set
    End Property 

    Private _FECHAFINOld As DateTime
    Public Property FECHAFINOld() As DateTime
        Get
            Return _FECHAFINOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHAFINOld = Value
        End Set
    End Property 

    Private _IDMUNICIPIO As Decimal
    <Column(Name:="Idmunicipio", Storage:="IDMUNICIPIO", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property IDMUNICIPIO() As Decimal
        Get
            Return _IDMUNICIPIO
        End Get
        Set(ByVal Value As Decimal)
            _IDMUNICIPIO = Value
            OnPropertyChanged("IDMUNICIPIO")
        End Set
    End Property 

    Private _IDMUNICIPIOOld As Decimal
    Public Property IDMUNICIPIOOld() As Decimal
        Get
            Return _IDMUNICIPIOOld
        End Get
        Set(ByVal Value As Decimal)
            _IDMUNICIPIOOld = Value
        End Set
    End Property 

    Private _fkIDMUNICIPIO As SIPU_MUNICIPIO
    Public Property fkIDMUNICIPIO() As SIPU_MUNICIPIO
        Get
            Return _fkIDMUNICIPIO
        End Get
        Set(ByVal Value As SIPU_MUNICIPIO)
            _fkIDMUNICIPIO = Value
        End Set
    End Property 

    Private _ID_GENERACION As Decimal
    <Column(Name:="Id generacion", Storage:="ID_GENERACION", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_GENERACION() As Decimal
        Get
            Return _ID_GENERACION
        End Get
        Set(ByVal Value As Decimal)
            _ID_GENERACION = Value
            OnPropertyChanged("ID_GENERACION")
        End Set
    End Property 

    Private _ID_GENERACIONOld As Decimal
    Public Property ID_GENERACIONOld() As Decimal
        Get
            Return _ID_GENERACIONOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_GENERACIONOld = Value
        End Set
    End Property 

    Private _fkID_GENERACION As SIPU_GENERACION
    Public Property fkID_GENERACION() As SIPU_GENERACION
        Get
            Return _fkID_GENERACION
        End Get
        Set(ByVal Value As SIPU_GENERACION)
            _fkID_GENERACION = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
