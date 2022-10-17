''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.CONTRATO_PROVEEDOR_AF
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row CONTRATO_PROVEEDOR_AF en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	05/10/2012	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="CONTRATO_PROVEEDOR_AF")> Public Class CONTRATO_PROVEEDOR_AF
    Inherits entidadBase
    Implements IEquatable(Of CONTRATO_PROVEEDOR_AF), IComparable(Of CONTRATO_PROVEEDOR_AF)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_CONTRATO As Decimal, aNUM_CONTRATO As String, aID_PROVEEDOR_AF As Decimal, aID_EJERCICIO As String, aMONTO_ADJUDICADO As Decimal, aUSERID As String, aLASTUPDATE As DateTime, aNUM_LICITACION As String, aMONTO_DEVENGADO As Decimal, aID_PROGRAMA_FORMACION As Decimal, aPARTICIP_ADJUDICADA As Decimal, aFECHA_INICIO As DateTime, aFECHA_FIN As DateTime, aID_PROYECTO_FORMACION As Decimal)
        Me._ID_CONTRATO = aID_CONTRATO
        Me._NUM_CONTRATO = aNUM_CONTRATO
        Me._ID_PROVEEDOR_AF = aID_PROVEEDOR_AF
        Me._ID_EJERCICIO = aID_EJERCICIO
        Me._MONTO_ADJUDICADO = aMONTO_ADJUDICADO
        Me._USERID = aUSERID
        Me._LASTUPDATE = aLASTUPDATE
        Me._NUM_LICITACION = aNUM_LICITACION
        Me._MONTO_DEVENGADO = aMONTO_DEVENGADO
        Me._ID_PROGRAMA_FORMACION = aID_PROGRAMA_FORMACION
        Me._PARTICIP_ADJUDICADA = aPARTICIP_ADJUDICADA
        Me._FECHA_INICIO = aFECHA_INICIO
        Me._FECHA_FIN = aFECHA_FIN
        Me._ID_PROYECTO_FORMACION = aID_PROYECTO_FORMACION
    End Sub

    Public Function Equals1(ByVal other As CONTRATO_PROVEEDOR_AF) As Boolean Implements System.IEquatable(Of CONTRATO_PROVEEDOR_AF).Equals
        Return Me.ID_CONTRATO = other.ID_CONTRATO
    End Function

    Public Function CompareTo(ByVal other As CONTRATO_PROVEEDOR_AF) As Integer Implements System.IComparable(Of CONTRATO_PROVEEDOR_AF).CompareTo
        If Me.ID_CONTRATO > other.ID_CONTRATO Then Return 1
        If Me.ID_CONTRATO < other.ID_CONTRATO Then Return -1
        Return 0
    End Function


#Region " Properties "

    Private _ID_CONTRATO As Decimal
    <Column(Name:="Id contrato", Storage:="ID_CONTRATO", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_CONTRATO() As Decimal
        Get
            Return _ID_CONTRATO
        End Get
        Set(ByVal Value As Decimal)
            _ID_CONTRATO = Value
            OnPropertyChanged("ID_CONTRATO")
        End Set
    End Property 

    Private _NUM_CONTRATO As String
    <Column(Name:="Num contrato", Storage:="NUM_CONTRATO", DbType:="VARCHAR2(18) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 18)> _
    Public Property NUM_CONTRATO() As String
        Get
            Return _NUM_CONTRATO
        End Get
        Set(ByVal Value As String)
            _NUM_CONTRATO = Value
            OnPropertyChanged("NUM_CONTRATO")
        End Set
    End Property 

    Private _NUM_CONTRATOOld As String
    Public Property NUM_CONTRATOOld() As String
        Get
            Return _NUM_CONTRATOOld
        End Get
        Set(ByVal Value As String)
            _NUM_CONTRATOOld = Value
        End Set
    End Property 

    Private _ID_PROVEEDOR_AF As Decimal
    <Column(Name:="Id proveedor af", Storage:="ID_PROVEEDOR_AF", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=0, Scale:=0)> _
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

    Private _MONTO_ADJUDICADO As Decimal
    <Column(Name:="Monto adjudicado", Storage:="MONTO_ADJUDICADO", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=2)> _
    Public Property MONTO_ADJUDICADO() As Decimal
        Get
            Return _MONTO_ADJUDICADO
        End Get
        Set(ByVal Value As Decimal)
            _MONTO_ADJUDICADO = Value
            OnPropertyChanged("MONTO_ADJUDICADO")
        End Set
    End Property 

    Private _MONTO_ADJUDICADOOld As Decimal
    Public Property MONTO_ADJUDICADOOld() As Decimal
        Get
            Return _MONTO_ADJUDICADOOld
        End Get
        Set(ByVal Value As Decimal)
            _MONTO_ADJUDICADOOld = Value
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

    Private _NUM_LICITACION As String
    <Column(Name:="Num licitacion", Storage:="NUM_LICITACION", DbType:="VARCHAR2(15) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 15)> _
    Public Property NUM_LICITACION() As String
        Get
            Return _NUM_LICITACION
        End Get
        Set(ByVal Value As String)
            _NUM_LICITACION = Value
            OnPropertyChanged("NUM_LICITACION")
        End Set
    End Property 

    Private _NUM_LICITACIONOld As String
    Public Property NUM_LICITACIONOld() As String
        Get
            Return _NUM_LICITACIONOld
        End Get
        Set(ByVal Value As String)
            _NUM_LICITACIONOld = Value
        End Set
    End Property 

    Private _MONTO_DEVENGADO As Decimal
    <Column(Name:="Monto devengado", Storage:="MONTO_DEVENGADO", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=2)> _
    Public Property MONTO_DEVENGADO() As Decimal
        Get
            Return _MONTO_DEVENGADO
        End Get
        Set(ByVal Value As Decimal)
            _MONTO_DEVENGADO = Value
            OnPropertyChanged("MONTO_DEVENGADO")
        End Set
    End Property 

    Private _MONTO_DEVENGADOOld As Decimal
    Public Property MONTO_DEVENGADOOld() As Decimal
        Get
            Return _MONTO_DEVENGADOOld
        End Get
        Set(ByVal Value As Decimal)
            _MONTO_DEVENGADOOld = Value
        End Set
    End Property 

    Private _ID_PROGRAMA_FORMACION As Decimal
    <Column(Name:="Id programa formacion", Storage:="ID_PROGRAMA_FORMACION", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_PROGRAMA_FORMACION() As Decimal
        Get
            Return _ID_PROGRAMA_FORMACION
        End Get
        Set(ByVal Value As Decimal)
            _ID_PROGRAMA_FORMACION = Value
            OnPropertyChanged("ID_PROGRAMA_FORMACION")
        End Set
    End Property 

    Private _ID_PROGRAMA_FORMACIONOld As Decimal
    Public Property ID_PROGRAMA_FORMACIONOld() As Decimal
        Get
            Return _ID_PROGRAMA_FORMACIONOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_PROGRAMA_FORMACIONOld = Value
        End Set
    End Property 

    Private _fkID_PROGRAMA_FORMACION As PROGRAMA_FORMACION
    Public Property fkID_PROGRAMA_FORMACION() As PROGRAMA_FORMACION
        Get
            Return _fkID_PROGRAMA_FORMACION
        End Get
        Set(ByVal Value As PROGRAMA_FORMACION)
            _fkID_PROGRAMA_FORMACION = Value
        End Set
    End Property 

    Private _PARTICIP_ADJUDICADA As Decimal
    <Column(Name:="Particip adjudicada", Storage:="PARTICIP_ADJUDICADA", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=0, Scale:=0)> _
    Public Property PARTICIP_ADJUDICADA() As Decimal
        Get
            Return _PARTICIP_ADJUDICADA
        End Get
        Set(ByVal Value As Decimal)
            _PARTICIP_ADJUDICADA = Value
            OnPropertyChanged("PARTICIP_ADJUDICADA")
        End Set
    End Property 

    Private _PARTICIP_ADJUDICADAOld As Decimal
    Public Property PARTICIP_ADJUDICADAOld() As Decimal
        Get
            Return _PARTICIP_ADJUDICADAOld
        End Get
        Set(ByVal Value As Decimal)
            _PARTICIP_ADJUDICADAOld = Value
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

    Private _ID_PROYECTO_FORMACION As Decimal
    <Column(Name:="Id proyecto formacion", Storage:="ID_PROYECTO_FORMACION", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_PROYECTO_FORMACION() As Decimal
        Get
            Return _ID_PROYECTO_FORMACION
        End Get
        Set(ByVal Value As Decimal)
            _ID_PROYECTO_FORMACION = Value
            OnPropertyChanged("ID_PROYECTO_FORMACION")
        End Set
    End Property 

    Private _ID_PROYECTO_FORMACIONOld As Decimal
    Public Property ID_PROYECTO_FORMACIONOld() As Decimal
        Get
            Return _ID_PROYECTO_FORMACIONOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_PROYECTO_FORMACIONOld = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
    Private _CONTRATO_SUB_AREA_FORMACIONCONTRATO_PROVEEDOR_AF As ListaCONTRATO_SUB_AREA_FORMACION
    Public Property CONTRATO_SUB_AREA_FORMACIONCONTRATO_PROVEEDOR_AF() As ListaCONTRATO_SUB_AREA_FORMACION
        Get
            Return _CONTRATO_SUB_AREA_FORMACIONCONTRATO_PROVEEDOR_AF
        End Get
        Set(ByVal Value As ListaCONTRATO_SUB_AREA_FORMACION)
            _CONTRATO_SUB_AREA_FORMACIONCONTRATO_PROVEEDOR_AF = Value
        End Set
    End Property 

#End Region
#End Region
End Class
