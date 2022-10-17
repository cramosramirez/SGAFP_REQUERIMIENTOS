''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.TERMINO_REFERENCIA_AF
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row TERMINO_REFERENCIA_AF en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	05/10/2012	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="TERMINO_REFERENCIA_AF")> Public Class TERMINO_REFERENCIA_AF
    Inherits entidadBase
    Implements IEquatable(Of TERMINO_REFERENCIA_AF), IComparable(Of TERMINO_REFERENCIA_AF)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_ACCION_FORMATIVA As Decimal, aRESOLUCION As String, aTDR As String, aMONTO_ADJUDICADO As Decimal, aUSERID As String, aLASTUPDATE As DateTime, aCORRELATIVO_GRUPO As Decimal, aID_SOLICITUD As Decimal)
        Me._ID_ACCION_FORMATIVA = aID_ACCION_FORMATIVA
        Me._RESOLUCION = aRESOLUCION
        Me._TDR = aTDR
        Me._MONTO_ADJUDICADO = aMONTO_ADJUDICADO
        Me._USERID = aUSERID
        Me._LASTUPDATE = aLASTUPDATE
        Me._CORRELATIVO_GRUPO = aCORRELATIVO_GRUPO
        Me._ID_SOLICITUD = aID_SOLICITUD
    End Sub

    Public Function Equals1(ByVal other As TERMINO_REFERENCIA_AF) As Boolean Implements System.IEquatable(Of TERMINO_REFERENCIA_AF).Equals
        Return Me.ID_ACCION_FORMATIVA = other.ID_ACCION_FORMATIVA
    End Function

    Public Function CompareTo(ByVal other As TERMINO_REFERENCIA_AF) As Integer Implements System.IComparable(Of TERMINO_REFERENCIA_AF).CompareTo
        If Me.ID_ACCION_FORMATIVA > other.ID_ACCION_FORMATIVA Then Return 1
        If Me.ID_ACCION_FORMATIVA < other.ID_ACCION_FORMATIVA Then Return -1
        Return 0
    End Function


#Region " Properties "

    Private _ID_ACCION_FORMATIVA As Decimal
    <Column(Name:="Id accion formativa", Storage:="ID_ACCION_FORMATIVA", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_ACCION_FORMATIVA() As Decimal
        Get
            Return _ID_ACCION_FORMATIVA
        End Get
        Set(ByVal Value As Decimal)
            _ID_ACCION_FORMATIVA = Value
            OnPropertyChanged("ID_ACCION_FORMATIVA")
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

    Private _RESOLUCION As String
    <Column(Name:="Resolucion", Storage:="RESOLUCION", DbType:="CHAR(18)", Id:=False), _
     DataObjectField(False, False, True, 18)> _
    Public Property RESOLUCION() As String
        Get
            Return _RESOLUCION
        End Get
        Set(ByVal Value As String)
            _RESOLUCION = Value
            OnPropertyChanged("RESOLUCION")
        End Set
    End Property 

    Private _RESOLUCIONOld As String
    Public Property RESOLUCIONOld() As String
        Get
            Return _RESOLUCIONOld
        End Get
        Set(ByVal Value As String)
            _RESOLUCIONOld = Value
        End Set
    End Property 

    Private _TDR As String
    <Column(Name:="Tdr", Storage:="TDR", DbType:="CHAR(20) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 20)> _
    Public Property TDR() As String
        Get
            Return _TDR
        End Get
        Set(ByVal Value As String)
            _TDR = Value
            OnPropertyChanged("TDR")
        End Set
    End Property 

    Private _TDROld As String
    Public Property TDROld() As String
        Get
            Return _TDROld
        End Get
        Set(ByVal Value As String)
            _TDROld = Value
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

    Private _CORRELATIVO_GRUPO As Decimal
    <Column(Name:="Correlativo grupo", Storage:="CORRELATIVO_GRUPO", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=0, Scale:=0)> _
    Public Property CORRELATIVO_GRUPO() As Decimal
        Get
            Return _CORRELATIVO_GRUPO
        End Get
        Set(ByVal Value As Decimal)
            _CORRELATIVO_GRUPO = Value
            OnPropertyChanged("CORRELATIVO_GRUPO")
        End Set
    End Property 

    Private _CORRELATIVO_GRUPOOld As Decimal
    Public Property CORRELATIVO_GRUPOOld() As Decimal
        Get
            Return _CORRELATIVO_GRUPOOld
        End Get
        Set(ByVal Value As Decimal)
            _CORRELATIVO_GRUPOOld = Value
        End Set
    End Property 

    Private _ID_SOLICITUD As Decimal
    <Column(Name:="Id solicitud", Storage:="ID_SOLICITUD", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_SOLICITUD() As Decimal
        Get
            Return _ID_SOLICITUD
        End Get
        Set(ByVal Value As Decimal)
            _ID_SOLICITUD = Value
            OnPropertyChanged("ID_SOLICITUD")
        End Set
    End Property 

    Private _ID_SOLICITUDOld As Decimal
    Public Property ID_SOLICITUDOld() As Decimal
        Get
            Return _ID_SOLICITUDOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_SOLICITUDOld = Value
        End Set
    End Property 

    Private _fkID_SOLICITUD As SOLICITUD_CAPACITACION
    Public Property fkID_SOLICITUD() As SOLICITUD_CAPACITACION
        Get
            Return _fkID_SOLICITUD
        End Get
        Set(ByVal Value As SOLICITUD_CAPACITACION)
            _fkID_SOLICITUD = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
