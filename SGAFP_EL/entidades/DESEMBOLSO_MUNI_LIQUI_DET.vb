''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.DESEMBOLSO_MUNI_LIQUI_DET
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row DESEMBOLSO_MUNI_LIQUI_DET en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	26/04/2012	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="DESEMBOLSO_MUNI_LIQUI_DET")> Public Class DESEMBOLSO_MUNI_LIQUI_DET
    Inherits entidadBase
    Implements IEquatable(Of DESEMBOLSO_MUNI_LIQUI_DET), IComparable(Of DESEMBOLSO_MUNI_LIQUI_DET)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_DESEMBOLSO_MUNI As Decimal, aID_DESEMBOLSO As Decimal, aID_LIQUIDACION_DET As Decimal, aMONTO_DESEMBOLSO As Decimal, aUSERID As String, aLASTUPDATE As DateTime)
        Me._ID_DESEMBOLSO_MUNI = aID_DESEMBOLSO_MUNI
        Me._ID_DESEMBOLSO = aID_DESEMBOLSO
        Me._ID_LIQUIDACION_DET = aID_LIQUIDACION_DET
        Me._MONTO_DESEMBOLSO = aMONTO_DESEMBOLSO
        Me._USERID = aUSERID
        Me._LASTUPDATE = aLASTUPDATE
    End Sub

    Public Function Equals1(ByVal other As DESEMBOLSO_MUNI_LIQUI_DET) As Boolean Implements System.IEquatable(Of DESEMBOLSO_MUNI_LIQUI_DET).Equals
        Return Me.ID_DESEMBOLSO_MUNI = other.ID_DESEMBOLSO_MUNI
    End Function

    Public Function CompareTo(ByVal other As DESEMBOLSO_MUNI_LIQUI_DET) As Integer Implements System.IComparable(Of DESEMBOLSO_MUNI_LIQUI_DET).CompareTo
        If Me.ID_DESEMBOLSO_MUNI > other.ID_DESEMBOLSO_MUNI Then Return 1
        If Me.ID_DESEMBOLSO_MUNI < other.ID_DESEMBOLSO_MUNI Then Return -1
        Return 0
    End Function


#Region " Properties "

    Private _ID_DESEMBOLSO_MUNI As Decimal
    <Column(Name:="Id desembolso muni", Storage:="ID_DESEMBOLSO_MUNI", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_DESEMBOLSO_MUNI() As Decimal
        Get
            Return _ID_DESEMBOLSO_MUNI
        End Get
        Set(ByVal Value As Decimal)
            _ID_DESEMBOLSO_MUNI = Value
            OnPropertyChanged("ID_DESEMBOLSO_MUNI")
        End Set
    End Property 

    Private _ID_DESEMBOLSO As Decimal
    <Column(Name:="Id desembolso", Storage:="ID_DESEMBOLSO", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_DESEMBOLSO() As Decimal
        Get
            Return _ID_DESEMBOLSO
        End Get
        Set(ByVal Value As Decimal)
            _ID_DESEMBOLSO = Value
            OnPropertyChanged("ID_DESEMBOLSO")
        End Set
    End Property 

    Private _ID_DESEMBOLSOOld As Decimal
    Public Property ID_DESEMBOLSOOld() As Decimal
        Get
            Return _ID_DESEMBOLSOOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_DESEMBOLSOOld = Value
        End Set
    End Property 

    Private _fkID_DESEMBOLSO As DESEMBOLSO
    Public Property fkID_DESEMBOLSO() As DESEMBOLSO
        Get
            Return _fkID_DESEMBOLSO
        End Get
        Set(ByVal Value As DESEMBOLSO)
            _fkID_DESEMBOLSO = Value
        End Set
    End Property 

    Private _ID_LIQUIDACION_DET As Decimal
    <Column(Name:="Id liquidacion det", Storage:="ID_LIQUIDACION_DET", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_LIQUIDACION_DET() As Decimal
        Get
            Return _ID_LIQUIDACION_DET
        End Get
        Set(ByVal Value As Decimal)
            _ID_LIQUIDACION_DET = Value
            OnPropertyChanged("ID_LIQUIDACION_DET")
        End Set
    End Property 

    Private _ID_LIQUIDACION_DETOld As Decimal
    Public Property ID_LIQUIDACION_DETOld() As Decimal
        Get
            Return _ID_LIQUIDACION_DETOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_LIQUIDACION_DETOld = Value
        End Set
    End Property 

    Private _fkID_LIQUIDACION_DET As MUNICIPIO_LIQUIDACION_DET
    Public Property fkID_LIQUIDACION_DET() As MUNICIPIO_LIQUIDACION_DET
        Get
            Return _fkID_LIQUIDACION_DET
        End Get
        Set(ByVal Value As MUNICIPIO_LIQUIDACION_DET)
            _fkID_LIQUIDACION_DET = Value
        End Set
    End Property 

    Private _MONTO_DESEMBOLSO As Decimal
    <Column(Name:="Monto desembolso", Storage:="MONTO_DESEMBOLSO", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=2)> _
    Public Property MONTO_DESEMBOLSO() As Decimal
        Get
            Return _MONTO_DESEMBOLSO
        End Get
        Set(ByVal Value As Decimal)
            _MONTO_DESEMBOLSO = Value
            OnPropertyChanged("MONTO_DESEMBOLSO")
        End Set
    End Property 

    Private _MONTO_DESEMBOLSOOld As Decimal
    Public Property MONTO_DESEMBOLSOOld() As Decimal
        Get
            Return _MONTO_DESEMBOLSOOld
        End Get
        Set(ByVal Value As Decimal)
            _MONTO_DESEMBOLSOOld = Value
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

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
