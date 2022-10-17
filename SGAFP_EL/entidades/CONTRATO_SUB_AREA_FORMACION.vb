''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.CONTRATO_SUB_AREA_FORMACION
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row CONTRATO_SUB_AREA_FORMACION en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	07/03/2012	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="CONTRATO_SUB_AREA_FORMACION")> Public Class CONTRATO_SUB_AREA_FORMACION
    Inherits entidadBase
    Implements IEquatable(Of CONTRATO_SUB_AREA_FORMACION), IComparable(Of CONTRATO_SUB_AREA_FORMACION)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_CONTRATO As Decimal, aID_SUBAREA_FORMACION As Decimal, aMONTO_ADJUDICADO As Decimal, aPARTICIP_ADJUDICADA As Decimal, aUSERID As String, aLASTUPDATE As DateTime, aMONTO_DEVENGADO As Decimal)
        Me._ID_CONTRATO = aID_CONTRATO
        Me._ID_SUBAREA_FORMACION = aID_SUBAREA_FORMACION
        Me._MONTO_ADJUDICADO = aMONTO_ADJUDICADO
        Me._PARTICIP_ADJUDICADA = aPARTICIP_ADJUDICADA
        Me._USERID = aUSERID
        Me._LASTUPDATE = aLASTUPDATE
        Me._MONTO_DEVENGADO = aMONTO_DEVENGADO
    End Sub

    Public Function Equals1(ByVal other As CONTRATO_SUB_AREA_FORMACION) As Boolean Implements System.IEquatable(Of CONTRATO_SUB_AREA_FORMACION).Equals
        Return Me.ID_CONTRATO = other.ID_CONTRATO And Me.ID_SUBAREA_FORMACION = other.ID_SUBAREA_FORMACION
    End Function

    Public Function CompareTo(ByVal other As CONTRATO_SUB_AREA_FORMACION) As Integer Implements System.IComparable(Of CONTRATO_SUB_AREA_FORMACION).CompareTo
        If Me.ID_CONTRATO > other.ID_CONTRATO Then
            If Me.ID_SUBAREA_FORMACION > other.ID_SUBAREA_FORMACION Then Return 1
            If Me.ID_SUBAREA_FORMACION < other.ID_SUBAREA_FORMACION Then Return -1
        Else
            Return -1
        End If
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

    Private _fkID_CONTRATO As CONTRATO_PROVEEDOR_AF
    Public Property fkID_CONTRATO() As CONTRATO_PROVEEDOR_AF
        Get
            Return _fkID_CONTRATO
        End Get
        Set(ByVal Value As CONTRATO_PROVEEDOR_AF)
            _fkID_CONTRATO = Value
        End Set
    End Property 

    Private _ID_SUBAREA_FORMACION As Decimal
    <Column(Name:="Id subarea formacion", Storage:="ID_SUBAREA_FORMACION", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_SUBAREA_FORMACION() As Decimal
        Get
            Return _ID_SUBAREA_FORMACION
        End Get
        Set(ByVal Value As Decimal)
            _ID_SUBAREA_FORMACION = Value
            OnPropertyChanged("ID_SUBAREA_FORMACION")
        End Set
    End Property 

    Private _fkID_SUBAREA_FORMACION As SUB_AREA_FORMACION
    Public Property fkID_SUBAREA_FORMACION() As SUB_AREA_FORMACION
        Get
            Return _fkID_SUBAREA_FORMACION
        End Get
        Set(ByVal Value As SUB_AREA_FORMACION)
            _fkID_SUBAREA_FORMACION = Value
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

    Private _PARTICIP_ADJUDICADA As Decimal
    <Column(Name:="Particip adjudicada", Storage:="PARTICIP_ADJUDICADA", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=0)> _
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

    Private _MONTO_DEVENGADO As Decimal
    <Column(Name:="Monto devengado", Storage:="MONTO_DEVENGADO", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=2)> _
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

#End Region

#Region " Relaciones "
    Private _CONTRATO_SUB_AREA_FORMACION_ACCION_FORMATIVA As listaACCION_FORMATIVA
    <DataMember()> _
    Public Property CONTRATO_SUB_AREA_FORMACION_ACCION_FORMATIVA() As listaACCION_FORMATIVA
        Get
            Return _CONTRATO_SUB_AREA_FORMACION_ACCION_FORMATIVA
        End Get
        Set(ByVal Value As listaACCION_FORMATIVA)
            _CONTRATO_SUB_AREA_FORMACION_ACCION_FORMATIVA = Value
        End Set
    End Property
#End Region
#End Region
End Class
