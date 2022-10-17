''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.DESEMBOLSO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row DESEMBOLSO en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	26/04/2012	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="DESEMBOLSO")> Public Class DESEMBOLSO
    Inherits entidadBase
    Implements IEquatable(Of DESEMBOLSO), IComparable(Of DESEMBOLSO)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_DESEMBOLSO As Decimal, aID_FUENTE As Decimal, aNO_CONVOCATORIA As Decimal, aNUM_DESEMBOLSO As Decimal, aFECHA_DESEMBOLSO As DateTime, aMONTO_AUTORIZADO As Decimal, aUSERID As String, aLASTUPDATE As DateTime)
        Me._ID_DESEMBOLSO = aID_DESEMBOLSO
        Me._ID_FUENTE = aID_FUENTE
        Me._NO_CONVOCATORIA = aNO_CONVOCATORIA
        Me._NUM_DESEMBOLSO = aNUM_DESEMBOLSO
        Me._FECHA_DESEMBOLSO = aFECHA_DESEMBOLSO
        Me._MONTO_AUTORIZADO = aMONTO_AUTORIZADO
        Me._USERID = aUSERID
        Me._LASTUPDATE = aLASTUPDATE
    End Sub

    Public Function Equals1(ByVal other As DESEMBOLSO) As Boolean Implements System.IEquatable(Of DESEMBOLSO).Equals
        Return Me.ID_DESEMBOLSO = other.ID_DESEMBOLSO
    End Function

    Public Function CompareTo(ByVal other As DESEMBOLSO) As Integer Implements System.IComparable(Of DESEMBOLSO).CompareTo
        If Me.ID_DESEMBOLSO > other.ID_DESEMBOLSO Then Return 1
        If Me.ID_DESEMBOLSO < other.ID_DESEMBOLSO Then Return -1
        Return 0
    End Function


#Region " Properties "

    Private _ID_DESEMBOLSO As Decimal
    <Column(Name:="Id desembolso", Storage:="ID_DESEMBOLSO", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_DESEMBOLSO() As Decimal
        Get
            Return _ID_DESEMBOLSO
        End Get
        Set(ByVal Value As Decimal)
            _ID_DESEMBOLSO = Value
            OnPropertyChanged("ID_DESEMBOLSO")
        End Set
    End Property 

    Private _ID_FUENTE As Decimal
    <Column(Name:="Id fuente", Storage:="ID_FUENTE", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_FUENTE() As Decimal
        Get
            Return _ID_FUENTE
        End Get
        Set(ByVal Value As Decimal)
            _ID_FUENTE = Value
            OnPropertyChanged("ID_FUENTE")
        End Set
    End Property 

    Private _ID_FUENTEOld As Decimal
    Public Property ID_FUENTEOld() As Decimal
        Get
            Return _ID_FUENTEOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_FUENTEOld = Value
        End Set
    End Property 

    Private _fkID_FUENTE As FUENTE_FINANCIAMIENTO
    Public Property fkID_FUENTE() As FUENTE_FINANCIAMIENTO
        Get
            Return _fkID_FUENTE
        End Get
        Set(ByVal Value As FUENTE_FINANCIAMIENTO)
            _fkID_FUENTE = Value
        End Set
    End Property 

    Private _NO_CONVOCATORIA As Decimal
    <Column(Name:="No convocatoria", Storage:="NO_CONVOCATORIA", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property NO_CONVOCATORIA() As Decimal
        Get
            Return _NO_CONVOCATORIA
        End Get
        Set(ByVal Value As Decimal)
            _NO_CONVOCATORIA = Value
            OnPropertyChanged("NO_CONVOCATORIA")
        End Set
    End Property 

    Private _NO_CONVOCATORIAOld As Decimal
    Public Property NO_CONVOCATORIAOld() As Decimal
        Get
            Return _NO_CONVOCATORIAOld
        End Get
        Set(ByVal Value As Decimal)
            _NO_CONVOCATORIAOld = Value
        End Set
    End Property 

    Private _NUM_DESEMBOLSO As Decimal
    <Column(Name:="Num desembolso", Storage:="NUM_DESEMBOLSO", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=2, Scale:=0)> _
    Public Property NUM_DESEMBOLSO() As Decimal
        Get
            Return _NUM_DESEMBOLSO
        End Get
        Set(ByVal Value As Decimal)
            _NUM_DESEMBOLSO = Value
            OnPropertyChanged("NUM_DESEMBOLSO")
        End Set
    End Property 

    Private _NUM_DESEMBOLSOOld As Decimal
    Public Property NUM_DESEMBOLSOOld() As Decimal
        Get
            Return _NUM_DESEMBOLSOOld
        End Get
        Set(ByVal Value As Decimal)
            _NUM_DESEMBOLSOOld = Value
        End Set
    End Property 

    Private _FECHA_DESEMBOLSO As DateTime
    <Column(Name:="Fecha desembolso", Storage:="FECHA_DESEMBOLSO", DbType:="DATE NOT NULL", Id:=False), _
     DataObjectField(False, False, False)> _
    Public Property FECHA_DESEMBOLSO() As DateTime
        Get
            Return _FECHA_DESEMBOLSO
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_DESEMBOLSO = Value
            OnPropertyChanged("FECHA_DESEMBOLSO")
        End Set
    End Property 

    Private _FECHA_DESEMBOLSOOld As DateTime
    Public Property FECHA_DESEMBOLSOOld() As DateTime
        Get
            Return _FECHA_DESEMBOLSOOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_DESEMBOLSOOld = Value
        End Set
    End Property 

    Private _MONTO_AUTORIZADO As Decimal
    <Column(Name:="Monto autorizado", Storage:="MONTO_AUTORIZADO", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=2)> _
    Public Property MONTO_AUTORIZADO() As Decimal
        Get
            Return _MONTO_AUTORIZADO
        End Get
        Set(ByVal Value As Decimal)
            _MONTO_AUTORIZADO = Value
            OnPropertyChanged("MONTO_AUTORIZADO")
        End Set
    End Property 

    Private _MONTO_AUTORIZADOOld As Decimal
    Public Property MONTO_AUTORIZADOOld() As Decimal
        Get
            Return _MONTO_AUTORIZADOOld
        End Get
        Set(ByVal Value As Decimal)
            _MONTO_AUTORIZADOOld = Value
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
