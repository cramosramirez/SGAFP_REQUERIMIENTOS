''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.AREA_SUPERVISION
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite tener un registro de la tabla AREA_SUPERVISION en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="AREA_SUPERVISION")> Public Class AREA_SUPERVISION
    Inherits entidadBase
    Implements IEquatable(Of AREA_SUPERVISION), IComparable(Of AREA_SUPERVISION)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_AREA_SUPERVISION As Decimal, aAREA_SUPERVISION As String, aSANCIONATORIA As String, aMONTO_SANCION As Decimal, aTIEMPO_SANCION As Decimal, aNOTAS As String)
        Me._ID_AREA_SUPERVISION = aID_AREA_SUPERVISION
        Me._AREA_SUPERVISION = aAREA_SUPERVISION
        Me._SANCIONATORIA = aSANCIONATORIA
        Me._MONTO_SANCION = aMONTO_SANCION
        Me._TIEMPO_SANCION = aTIEMPO_SANCION
        Me._NOTAS = aNOTAS
    End Sub

    Public Function Equals1(ByVal other As AREA_SUPERVISION) As Boolean Implements System.IEquatable(Of AREA_SUPERVISION).Equals
        Return Me.ID_AREA_SUPERVISION = other.ID_AREA_SUPERVISION
    End Function

    Public Function CompareTo(ByVal other As AREA_SUPERVISION) As Integer Implements System.IComparable(Of AREA_SUPERVISION).CompareTo
        If Me.ID_AREA_SUPERVISION > other.ID_AREA_SUPERVISION Then Return 1
        If Me.ID_AREA_SUPERVISION < other.ID_AREA_SUPERVISION Then Return -1
        Return 0
    End Function


#Region " Propiedades "

    Private _ID_AREA_SUPERVISION As Decimal
    <Column(Name:="Id area supervision", Storage:="ID_AREA_SUPERVISION", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_AREA_SUPERVISION() As Decimal
        Get
            Return _ID_AREA_SUPERVISION
        End Get
        Set(ByVal Value As Decimal)
            _ID_AREA_SUPERVISION = Value
            OnPropertyChanged("ID_AREA_SUPERVISION")
        End Set
    End Property 

    Private _AREA_SUPERVISION As String
    <Column(Name:="Area supervision", Storage:="AREA_SUPERVISION", DbType:="VARCHAR2(60)", Id:=False), _
     DataObjectField(False, False, True, 60)> _
    Public Property AREA_SUPERVISION() As String
        Get
            Return _AREA_SUPERVISION
        End Get
        Set(ByVal Value As String)
            _AREA_SUPERVISION = Value
            OnPropertyChanged("AREA_SUPERVISION")
        End Set
    End Property 

    Private _AREA_SUPERVISIONOld As String
    Public Property AREA_SUPERVISIONOld() As String
        Get
            Return _AREA_SUPERVISIONOld
        End Get
        Set(ByVal Value As String)
            _AREA_SUPERVISIONOld = Value
        End Set
    End Property 

    Private _SANCIONATORIA As String
    <Column(Name:="Sancionatoria", Storage:="SANCIONATORIA", DbType:="CHAR(1)", Id:=False), _
     DataObjectField(False, False, True, 1)> _
    Public Property SANCIONATORIA() As String
        Get
            Return _SANCIONATORIA
        End Get
        Set(ByVal Value As String)
            _SANCIONATORIA = Value
            OnPropertyChanged("SANCIONATORIA")
        End Set
    End Property 

    Private _SANCIONATORIAOld As String
    Public Property SANCIONATORIAOld() As String
        Get
            Return _SANCIONATORIAOld
        End Get
        Set(ByVal Value As String)
            _SANCIONATORIAOld = Value
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

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
