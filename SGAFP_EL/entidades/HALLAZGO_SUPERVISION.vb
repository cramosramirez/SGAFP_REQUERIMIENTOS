''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.HALLAZGO_SUPERVISION
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite tener un registro de la tabla HALLAZGO_SUPERVISION en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="HALLAZGO_SUPERVISION")> Public Class HALLAZGO_SUPERVISION
    Inherits entidadBase
    Implements IEquatable(Of HALLAZGO_SUPERVISION), IComparable(Of HALLAZGO_SUPERVISION)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_HALLAZGO_SUPERVISION As Decimal, aID_AREA_SUPERVISION As Decimal, aID_SUPERVISION_AF As Decimal, aHALLAZGO_SUPERVISION As String, aFECHA As DateTime, aTIPO_SANCION As String, aTIEMPO_SANCION As Decimal, aMONTO_SANCION As Decimal, aTIEMPO_SUBSANACION As Decimal)
        Me._ID_HALLAZGO_SUPERVISION = aID_HALLAZGO_SUPERVISION
        Me._ID_AREA_SUPERVISION = aID_AREA_SUPERVISION
        Me._ID_SUPERVISION_AF = aID_SUPERVISION_AF
        Me._HALLAZGO_SUPERVISION = aHALLAZGO_SUPERVISION
        Me._FECHA = aFECHA
        Me._TIPO_SANCION = aTIPO_SANCION
        Me._TIEMPO_SANCION = aTIEMPO_SANCION
        Me._MONTO_SANCION = aMONTO_SANCION
        Me._TIEMPO_SUBSANACION = aTIEMPO_SUBSANACION
    End Sub

    Public Function Equals1(ByVal other As HALLAZGO_SUPERVISION) As Boolean Implements System.IEquatable(Of HALLAZGO_SUPERVISION).Equals
        Return Me.ID_HALLAZGO_SUPERVISION = other.ID_HALLAZGO_SUPERVISION
    End Function

    Public Function CompareTo(ByVal other As HALLAZGO_SUPERVISION) As Integer Implements System.IComparable(Of HALLAZGO_SUPERVISION).CompareTo
        If Me.ID_HALLAZGO_SUPERVISION > other.ID_HALLAZGO_SUPERVISION Then Return 1
        If Me.ID_HALLAZGO_SUPERVISION < other.ID_HALLAZGO_SUPERVISION Then Return -1
        Return 0
    End Function


#Region " Propiedades "

    Private _ID_HALLAZGO_SUPERVISION As Decimal
    <Column(Name:="Id hallazgo supervision", Storage:="ID_HALLAZGO_SUPERVISION", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_HALLAZGO_SUPERVISION() As Decimal
        Get
            Return _ID_HALLAZGO_SUPERVISION
        End Get
        Set(ByVal Value As Decimal)
            _ID_HALLAZGO_SUPERVISION = Value
            OnPropertyChanged("ID_HALLAZGO_SUPERVISION")
        End Set
    End Property 

    Private _ID_AREA_SUPERVISION As Decimal
    <Column(Name:="Id area supervision", Storage:="ID_AREA_SUPERVISION", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_AREA_SUPERVISION() As Decimal
        Get
            Return _ID_AREA_SUPERVISION
        End Get
        Set(ByVal Value As Decimal)
            _ID_AREA_SUPERVISION = Value
            OnPropertyChanged("ID_AREA_SUPERVISION")
        End Set
    End Property 

    Private _ID_AREA_SUPERVISIONOld As Decimal
    Public Property ID_AREA_SUPERVISIONOld() As Decimal
        Get
            Return _ID_AREA_SUPERVISIONOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_AREA_SUPERVISIONOld = Value
        End Set
    End Property 

    Private _fkID_AREA_SUPERVISION As AREA_SUPERVISION
    Public Property fkID_AREA_SUPERVISION() As AREA_SUPERVISION
        Get
            Return _fkID_AREA_SUPERVISION
        End Get
        Set(ByVal Value As AREA_SUPERVISION)
            _fkID_AREA_SUPERVISION = Value
        End Set
    End Property 

    Private _ID_SUPERVISION_AF As Decimal
    <Column(Name:="Id supervision af", Storage:="ID_SUPERVISION_AF", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_SUPERVISION_AF() As Decimal
        Get
            Return _ID_SUPERVISION_AF
        End Get
        Set(ByVal Value As Decimal)
            _ID_SUPERVISION_AF = Value
            OnPropertyChanged("ID_SUPERVISION_AF")
        End Set
    End Property 

    Private _ID_SUPERVISION_AFOld As Decimal
    Public Property ID_SUPERVISION_AFOld() As Decimal
        Get
            Return _ID_SUPERVISION_AFOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_SUPERVISION_AFOld = Value
        End Set
    End Property 

    Private _fkID_SUPERVISION_AF As SUPERVISION_AF
    Public Property fkID_SUPERVISION_AF() As SUPERVISION_AF
        Get
            Return _fkID_SUPERVISION_AF
        End Get
        Set(ByVal Value As SUPERVISION_AF)
            _fkID_SUPERVISION_AF = Value
        End Set
    End Property 

    Private _HALLAZGO_SUPERVISION As String
    <Column(Name:="Hallazgo supervision", Storage:="HALLAZGO_SUPERVISION", DbType:="VARCHAR2(255)", Id:=False), _
     DataObjectField(False, False, True, 255)> _
    Public Property HALLAZGO_SUPERVISION() As String
        Get
            Return _HALLAZGO_SUPERVISION
        End Get
        Set(ByVal Value As String)
            _HALLAZGO_SUPERVISION = Value
            OnPropertyChanged("HALLAZGO_SUPERVISION")
        End Set
    End Property 

    Private _HALLAZGO_SUPERVISIONOld As String
    Public Property HALLAZGO_SUPERVISIONOld() As String
        Get
            Return _HALLAZGO_SUPERVISIONOld
        End Get
        Set(ByVal Value As String)
            _HALLAZGO_SUPERVISIONOld = Value
        End Set
    End Property 

    Private _FECHA As DateTime
    <Column(Name:="Fecha", Storage:="FECHA", DbType:="DATE", Id:=False), _
     DataObjectField(False, False, True)> _
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

    Private _TIPO_SANCION As String
    <Column(Name:="Tipo sancion", Storage:="TIPO_SANCION", DbType:="CHAR(1)", Id:=False), _
     DataObjectField(False, False, True, 1)> _
    Public Property TIPO_SANCION() As String
        Get
            Return _TIPO_SANCION
        End Get
        Set(ByVal Value As String)
            _TIPO_SANCION = Value
            OnPropertyChanged("TIPO_SANCION")
        End Set
    End Property 

    Private _TIPO_SANCIONOld As String
    Public Property TIPO_SANCIONOld() As String
        Get
            Return _TIPO_SANCIONOld
        End Get
        Set(ByVal Value As String)
            _TIPO_SANCIONOld = Value
        End Set
    End Property 

    Private _TIEMPO_SANCION As Decimal
    <Column(Name:="Tiempo sancion", Storage:="TIEMPO_SANCION", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=0, Scale:=0)> _
    Public Property TIEMPO_SANCION() As Decimal
        Get
            Return _TIEMPO_SANCION
        End Get
        Set(ByVal Value As Decimal)
            _TIEMPO_SANCION = Value
            OnPropertyChanged("TIEMPO_SANCION")
        End Set
    End Property 

    Private _TIEMPO_SANCIONOld As Decimal
    Public Property TIEMPO_SANCIONOld() As Decimal
        Get
            Return _TIEMPO_SANCIONOld
        End Get
        Set(ByVal Value As Decimal)
            _TIEMPO_SANCIONOld = Value
        End Set
    End Property 

    Private _MONTO_SANCION As Decimal
    <Column(Name:="Monto sancion", Storage:="MONTO_SANCION", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=12, Scale:=2)> _
    Public Property MONTO_SANCION() As Decimal
        Get
            Return _MONTO_SANCION
        End Get
        Set(ByVal Value As Decimal)
            _MONTO_SANCION = Value
            OnPropertyChanged("MONTO_SANCION")
        End Set
    End Property 

    Private _MONTO_SANCIONOld As Decimal
    Public Property MONTO_SANCIONOld() As Decimal
        Get
            Return _MONTO_SANCIONOld
        End Get
        Set(ByVal Value As Decimal)
            _MONTO_SANCIONOld = Value
        End Set
    End Property 

    Private _TIEMPO_SUBSANACION As Decimal
    <Column(Name:="Tiempo subsanacion", Storage:="TIEMPO_SUBSANACION", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=0, Scale:=0)> _
    Public Property TIEMPO_SUBSANACION() As Decimal
        Get
            Return _TIEMPO_SUBSANACION
        End Get
        Set(ByVal Value As Decimal)
            _TIEMPO_SUBSANACION = Value
            OnPropertyChanged("TIEMPO_SUBSANACION")
        End Set
    End Property 

    Private _TIEMPO_SUBSANACIONOld As Decimal
    Public Property TIEMPO_SUBSANACIONOld() As Decimal
        Get
            Return _TIEMPO_SUBSANACIONOld
        End Get
        Set(ByVal Value As Decimal)
            _TIEMPO_SUBSANACIONOld = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
