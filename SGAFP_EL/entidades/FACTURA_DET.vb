''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.FACTURA_DET
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row FACTURA_DET en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	25/08/2011	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="FACTURA_DET")> Public Class FACTURA_DET
    Inherits entidadBase
    Implements IEquatable(Of FACTURA_DET), IComparable(Of FACTURA_DET)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(ByVal aID_FACTURA_DET As Decimal, ByVal aID_FACTURA_AF As Decimal, ByVal aID_INFORME_FINAL As Decimal, ByVal aUSERID As String, ByVal aLASTUPDATE As DateTime)
        Me._ID_FACTURA_DET = aID_FACTURA_DET
        Me._ID_FACTURA_AF = aID_FACTURA_AF
        Me._ID_INFORME_FINAL = aID_INFORME_FINAL
        Me._USERID = aUSERID
        Me._LASTUPDATE = aLASTUPDATE
    End Sub

    Public Function Equals1(ByVal other As FACTURA_DET) As Boolean Implements System.IEquatable(Of FACTURA_DET).Equals
        Return Me.ID_FACTURA_DET = other.ID_FACTURA_DET
    End Function

    Public Function CompareTo(ByVal other As FACTURA_DET) As Integer Implements System.IComparable(Of FACTURA_DET).CompareTo
        If Me.ID_FACTURA_DET > other.ID_FACTURA_DET Then Return 1
        If Me.ID_FACTURA_DET < other.ID_FACTURA_DET Then Return -1
        Return 0
    End Function


#Region " Properties "

    Private _ID_FACTURA_DET As Decimal
    <Column(Name:="Id factura det", Storage:="ID_FACTURA_DET", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_FACTURA_DET() As Decimal
        Get
            Return _ID_FACTURA_DET
        End Get
        Set(ByVal Value As Decimal)
            _ID_FACTURA_DET = Value
            OnPropertyChanged("ID_FACTURA_DET")
        End Set
    End Property 

    Private _ID_FACTURA_AF As Decimal
    <Column(Name:="Id factura af", Storage:="ID_FACTURA_AF", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_FACTURA_AF() As Decimal
        Get
            Return _ID_FACTURA_AF
        End Get
        Set(ByVal Value As Decimal)
            _ID_FACTURA_AF = Value
            OnPropertyChanged("ID_FACTURA_AF")
        End Set
    End Property 

    Private _ID_FACTURA_AFOld As Decimal
    Public Property ID_FACTURA_AFOld() As Decimal
        Get
            Return _ID_FACTURA_AFOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_FACTURA_AFOld = Value
        End Set
    End Property 

    Private _fkID_FACTURA_AF As FACTURA_AF
    Public Property fkID_FACTURA_AF() As FACTURA_AF
        Get
            Return _fkID_FACTURA_AF
        End Get
        Set(ByVal Value As FACTURA_AF)
            _fkID_FACTURA_AF = Value
        End Set
    End Property 

    Private _ID_INFORME_FINAL As Decimal
    <Column(Name:="Id accion formativa", Storage:="ID_INFORME_FINAL", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_INFORME_FINAL() As Decimal
        Get
            Return _ID_INFORME_FINAL
        End Get
        Set(ByVal Value As Decimal)
            _ID_INFORME_FINAL = Value
            OnPropertyChanged("ID_INFORME_FINAL")
        End Set
    End Property

    Private _ID_INFORME_FINALOld As Decimal
    Public Property ID_INFORME_FINALOld() As Decimal
        Get
            Return _ID_INFORME_FINALOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_INFORME_FINALOld = Value
        End Set
    End Property

    Private _fkID_INFORME_FINAL As INFORME_FINAL_AF
    Public Property fkID_INFORME_FINAL() As INFORME_FINAL_AF
        Get
            Return _fkID_INFORME_FINAL
        End Get
        Set(ByVal Value As INFORME_FINAL_AF)
            _fkID_INFORME_FINAL = Value
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

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
