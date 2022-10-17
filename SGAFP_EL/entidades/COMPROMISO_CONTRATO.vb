''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.COMPROMISO_CONTRATO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row COMPROMISO_CONTRATO en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	07/03/2012	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="COMPROMISO_CONTRATO")> Public Class COMPROMISO_CONTRATO
    Inherits entidadBase
    Implements IEquatable(Of COMPROMISO_CONTRATO), IComparable(Of COMPROMISO_CONTRATO)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_COMPROMISO As Decimal, aID_CONTRATO As Decimal, aNUM_COMPROMISO As String, aFECHA_INICIAL As DateTime, aFECHA_FINAL As DateTime, aMONTO_COMPROMETIDO As Decimal, aMONTO_PROVISIONADO As Decimal, aMONTO_DEVENGADO As Decimal, aUSERID As String, aLASTUPDATE As DateTime)
        Me._ID_COMPROMISO = aID_COMPROMISO
        Me._ID_CONTRATO = aID_CONTRATO
        Me._NUM_COMPROMISO = aNUM_COMPROMISO
        Me._FECHA_INICIAL = aFECHA_INICIAL
        Me._FECHA_FINAL = aFECHA_FINAL
        Me._MONTO_COMPROMETIDO = aMONTO_COMPROMETIDO
        Me._MONTO_PROVISIONADO = aMONTO_PROVISIONADO
        Me._MONTO_DEVENGADO = aMONTO_DEVENGADO
        Me._USERID = aUSERID
        Me._LASTUPDATE = aLASTUPDATE
    End Sub

    Public Function Equals1(ByVal other As COMPROMISO_CONTRATO) As Boolean Implements System.IEquatable(Of COMPROMISO_CONTRATO).Equals
        Return Me.ID_COMPROMISO = other.ID_COMPROMISO
    End Function

    Public Function CompareTo(ByVal other As COMPROMISO_CONTRATO) As Integer Implements System.IComparable(Of COMPROMISO_CONTRATO).CompareTo
        If Me.ID_COMPROMISO > other.ID_COMPROMISO Then Return 1
        If Me.ID_COMPROMISO < other.ID_COMPROMISO Then Return -1
        Return 0
    End Function


#Region " Properties "

    Private _ID_COMPROMISO As Decimal
    <Column(Name:="Id compromiso", Storage:="ID_COMPROMISO", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_COMPROMISO() As Decimal
        Get
            Return _ID_COMPROMISO
        End Get
        Set(ByVal Value As Decimal)
            _ID_COMPROMISO = Value
            OnPropertyChanged("ID_COMPROMISO")
        End Set
    End Property 

    Private _ID_CONTRATO As Decimal
    <Column(Name:="Id contrato", Storage:="ID_CONTRATO", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_CONTRATO() As Decimal
        Get
            Return _ID_CONTRATO
        End Get
        Set(ByVal Value As Decimal)
            _ID_CONTRATO = Value
            OnPropertyChanged("ID_CONTRATO")
        End Set
    End Property 

    Private _ID_CONTRATOOld As Decimal
    Public Property ID_CONTRATOOld() As Decimal
        Get
            Return _ID_CONTRATOOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_CONTRATOOld = Value
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

    Private _NUM_COMPROMISO As String
    <Column(Name:="Num compromiso", Storage:="NUM_COMPROMISO", DbType:="VARCHAR2(10) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 10)> _
    Public Property NUM_COMPROMISO() As String
        Get
            Return _NUM_COMPROMISO
        End Get
        Set(ByVal Value As String)
            _NUM_COMPROMISO = Value
            OnPropertyChanged("NUM_COMPROMISO")
        End Set
    End Property

    Private _NUM_COMPROMISOOld As String
    Public Property NUM_COMPROMISOOld() As String
        Get
            Return _NUM_COMPROMISOOld
        End Get
        Set(ByVal Value As String)
            _NUM_COMPROMISOOld = Value
        End Set
    End Property 

    Private _FECHA_INICIAL As DateTime
    <Column(Name:="Fecha inicial", Storage:="FECHA_INICIAL", DbType:="DATE NOT NULL", Id:=False), _
     DataObjectField(False, False, False)> _
    Public Property FECHA_INICIAL() As DateTime
        Get
            Return _FECHA_INICIAL
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_INICIAL = Value
            OnPropertyChanged("FECHA_INICIAL")
        End Set
    End Property 

    Private _FECHA_INICIALOld As DateTime
    Public Property FECHA_INICIALOld() As DateTime
        Get
            Return _FECHA_INICIALOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_INICIALOld = Value
        End Set
    End Property 

    Private _FECHA_FINAL As DateTime
    <Column(Name:="Fecha final", Storage:="FECHA_FINAL", DbType:="DATE NOT NULL", Id:=False), _
     DataObjectField(False, False, False)> _
    Public Property FECHA_FINAL() As DateTime
        Get
            Return _FECHA_FINAL
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_FINAL = Value
            OnPropertyChanged("FECHA_FINAL")
        End Set
    End Property 

    Private _FECHA_FINALOld As DateTime
    Public Property FECHA_FINALOld() As DateTime
        Get
            Return _FECHA_FINALOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_FINALOld = Value
        End Set
    End Property 

    Private _MONTO_COMPROMETIDO As Decimal
    <Column(Name:="Monto comprometido", Storage:="MONTO_COMPROMETIDO", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=2)> _
    Public Property MONTO_COMPROMETIDO() As Decimal
        Get
            Return _MONTO_COMPROMETIDO
        End Get
        Set(ByVal Value As Decimal)
            _MONTO_COMPROMETIDO = Value
            OnPropertyChanged("MONTO_COMPROMETIDO")
        End Set
    End Property 

    Private _MONTO_COMPROMETIDOOld As Decimal
    Public Property MONTO_COMPROMETIDOOld() As Decimal
        Get
            Return _MONTO_COMPROMETIDOOld
        End Get
        Set(ByVal Value As Decimal)
            _MONTO_COMPROMETIDOOld = Value
        End Set
    End Property 

    Private _MONTO_PROVISIONADO As Decimal
    <Column(Name:="Monto provisionado", Storage:="MONTO_PROVISIONADO", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=2)> _
    Public Property MONTO_PROVISIONADO() As Decimal
        Get
            Return _MONTO_PROVISIONADO
        End Get
        Set(ByVal Value As Decimal)
            _MONTO_PROVISIONADO = Value
            OnPropertyChanged("MONTO_PROVISIONADO")
        End Set
    End Property 

    Private _MONTO_PROVISIONADOOld As Decimal
    Public Property MONTO_PROVISIONADOOld() As Decimal
        Get
            Return _MONTO_PROVISIONADOOld
        End Get
        Set(ByVal Value As Decimal)
            _MONTO_PROVISIONADOOld = Value
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
    Private _COMPROMISO_AFCOMPROMISO_CONTRATO As ListaCOMPROMISO_AF
    Public Property COMPROMISO_AFCOMPROMISO_CONTRATO() As ListaCOMPROMISO_AF
        Get
            Return _COMPROMISO_AFCOMPROMISO_CONTRATO
        End Get
        Set(ByVal Value As ListaCOMPROMISO_AF)
            _COMPROMISO_AFCOMPROMISO_CONTRATO = Value
        End Set
    End Property 

#End Region
#End Region
End Class
