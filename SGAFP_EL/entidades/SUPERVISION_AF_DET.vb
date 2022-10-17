''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.SUPERVISION_AF_DET
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite tener un registro de la tabla SUPERVISION_AF_DET en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="SUPERVISION_AF_DET")> Public Class SUPERVISION_AF_DET
    Inherits entidadBase
    Implements IEquatable(Of SUPERVISION_AF_DET), IComparable(Of SUPERVISION_AF_DET)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_SUPERVISION_DET As Decimal, aID_LISTA_SUPERVISION As Decimal, aID_SUPERVISION_AF As Decimal, aCOMENTARIOS As String)
        Me._ID_SUPERVISION_DET = aID_SUPERVISION_DET
        Me._ID_LISTA_SUPERVISION = aID_LISTA_SUPERVISION
        Me._ID_SUPERVISION_AF = aID_SUPERVISION_AF
        Me._COMENTARIOS = aCOMENTARIOS
    End Sub

    Public Function Equals1(ByVal other As SUPERVISION_AF_DET) As Boolean Implements System.IEquatable(Of SUPERVISION_AF_DET).Equals
        Return Me.ID_SUPERVISION_DET = other.ID_SUPERVISION_DET
    End Function

    Public Function CompareTo(ByVal other As SUPERVISION_AF_DET) As Integer Implements System.IComparable(Of SUPERVISION_AF_DET).CompareTo
        If Me.ID_SUPERVISION_DET > other.ID_SUPERVISION_DET Then Return 1
        If Me.ID_SUPERVISION_DET < other.ID_SUPERVISION_DET Then Return -1
        Return 0
    End Function


#Region " Propiedades "

    Private _ID_SUPERVISION_DET As Decimal
    <Column(Name:="Id supervision det", Storage:="ID_SUPERVISION_DET", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_SUPERVISION_DET() As Decimal
        Get
            Return _ID_SUPERVISION_DET
        End Get
        Set(ByVal Value As Decimal)
            _ID_SUPERVISION_DET = Value
            OnPropertyChanged("ID_SUPERVISION_DET")
        End Set
    End Property 

    Private _ID_LISTA_SUPERVISION As Decimal
    <Column(Name:="Id lista supervision", Storage:="ID_LISTA_SUPERVISION", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_LISTA_SUPERVISION() As Decimal
        Get
            Return _ID_LISTA_SUPERVISION
        End Get
        Set(ByVal Value As Decimal)
            _ID_LISTA_SUPERVISION = Value
            OnPropertyChanged("ID_LISTA_SUPERVISION")
        End Set
    End Property 

    Private _ID_LISTA_SUPERVISIONOld As Decimal
    Public Property ID_LISTA_SUPERVISIONOld() As Decimal
        Get
            Return _ID_LISTA_SUPERVISIONOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_LISTA_SUPERVISIONOld = Value
        End Set
    End Property 

    Private _fkID_LISTA_SUPERVISION As LISTA_SUPERVISION_AF
    Public Property fkID_LISTA_SUPERVISION() As LISTA_SUPERVISION_AF
        Get
            Return _fkID_LISTA_SUPERVISION
        End Get
        Set(ByVal Value As LISTA_SUPERVISION_AF)
            _fkID_LISTA_SUPERVISION = Value
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

    Private _COMENTARIOS As String
    <Column(Name:="Comentarios", Storage:="COMENTARIOS", DbType:="VARCHAR2(200)", Id:=False), _
     DataObjectField(False, False, True, 200)> _
    Public Property COMENTARIOS() As String
        Get
            Return _COMENTARIOS
        End Get
        Set(ByVal Value As String)
            _COMENTARIOS = Value
            OnPropertyChanged("COMENTARIOS")
        End Set
    End Property 

    Private _COMENTARIOSOld As String
    Public Property COMENTARIOSOld() As String
        Get
            Return _COMENTARIOSOld
        End Get
        Set(ByVal Value As String)
            _COMENTARIOSOld = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
