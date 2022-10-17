''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.FUENTE_FINANCIAMIENTO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite tener un registro de la tabla FUENTE_FINANCIAMIENTO en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	08/07/2010	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="FUENTE_FINANCIAMIENTO")> Public Class FUENTE_FINANCIAMIENTO
    Inherits entidadBase
    Implements IEquatable(Of FUENTE_FINANCIAMIENTO), IComparable(Of FUENTE_FINANCIAMIENTO)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(ByVal aID_FUENTE As Decimal, ByVal aNOMBRE_FUENTE As String, ByVal aNOMBRE_BANCO_LIQ As String, ByVal aNO_CTA_LIQ As String, ByVal aNOMBRE_CTA_LIQ As String, ByVal aCODIGO_FINANCIAMIENTO As String, ByVal aCOSTO_X_PARTICIPANTE As Decimal, ByVal aUSERID As String, ByVal aLASTUPDATE As DateTime, ByVal aNOMBRE_BANCO_DESEMBOLSO As String, ByVal aNO_CTA_DESEMBOLSO As String, ByVal aNOMBRE_CTA_DESEMBOLSO As String)
        Me._ID_FUENTE = aID_FUENTE
        Me._NOMBRE_FUENTE = aNOMBRE_FUENTE
        Me._NOMBRE_BANCO_LIQ = aNOMBRE_BANCO_LIQ
        Me._NO_CTA_LIQ = aNO_CTA_LIQ
        Me._NOMBRE_CTA_LIQ = aNOMBRE_CTA_LIQ
        Me._CODIGO_FINANCIAMIENTO = aCODIGO_FINANCIAMIENTO
        Me._COSTO_X_PARTICIPANTE = aCOSTO_X_PARTICIPANTE
        Me._USERID = aUSERID
        Me._LASTUPDATE = aLASTUPDATE
        Me._NOMBRE_BANCO_DESEMBOLSO = aNOMBRE_BANCO_DESEMBOLSO
        Me._NO_CTA_DESEMBOLSO = aNO_CTA_DESEMBOLSO
        Me._NOMBRE_CTA_DESEMBOLSO = aNOMBRE_CTA_DESEMBOLSO
    End Sub

    Public Function Equals1(ByVal other As FUENTE_FINANCIAMIENTO) As Boolean Implements System.IEquatable(Of FUENTE_FINANCIAMIENTO).Equals
        Return Me.ID_FUENTE = other.ID_FUENTE
    End Function

    Public Function CompareTo(ByVal other As FUENTE_FINANCIAMIENTO) As Integer Implements System.IComparable(Of FUENTE_FINANCIAMIENTO).CompareTo
        If Me.ID_FUENTE > other.ID_FUENTE Then Return 1
        If Me.ID_FUENTE < other.ID_FUENTE Then Return -1
        Return 0
    End Function


#Region " Properties "

    Private _ID_FUENTE As Decimal
    <Column(Name:="Id fuente", Storage:="ID_FUENTE", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_FUENTE() As Decimal
        Get
            Return _ID_FUENTE
        End Get
        Set(ByVal Value As Decimal)
            _ID_FUENTE = Value
            OnPropertyChanged("ID_FUENTE")
        End Set
    End Property

    Private _NOMBRE_FUENTE As String
    <Column(Name:="Nombre fuente", Storage:="NOMBRE_FUENTE", DbType:="VARCHAR2(250)", Id:=False), _
     DataObjectField(False, False, True, 250)> _
    Public Property NOMBRE_FUENTE() As String
        Get
            Return _NOMBRE_FUENTE
        End Get
        Set(ByVal Value As String)
            _NOMBRE_FUENTE = Value
            OnPropertyChanged("NOMBRE_FUENTE")
        End Set
    End Property

    Private _NOMBRE_FUENTEOld As String
    Public Property NOMBRE_FUENTEOld() As String
        Get
            Return _NOMBRE_FUENTEOld
        End Get
        Set(ByVal Value As String)
            _NOMBRE_FUENTEOld = Value
        End Set
    End Property

    Private _NOMBRE_BANCO_LIQ As String
    <Column(Name:="Nombre banco liq", Storage:="NOMBRE_BANCO_LIQ", DbType:="VARCHAR2(20)", Id:=False), _
     DataObjectField(False, False, True, 20)> _
    Public Property NOMBRE_BANCO_LIQ() As String
        Get
            Return _NOMBRE_BANCO_LIQ
        End Get
        Set(ByVal Value As String)
            _NOMBRE_BANCO_LIQ = Value
            OnPropertyChanged("NOMBRE_BANCO_LIQ")
        End Set
    End Property

    Private _NOMBRE_BANCO_LIQOld As String
    Public Property NOMBRE_BANCO_LIQOld() As String
        Get
            Return _NOMBRE_BANCO_LIQOld
        End Get
        Set(ByVal Value As String)
            _NOMBRE_BANCO_LIQOld = Value
        End Set
    End Property

    Private _NO_CTA_LIQ As String
    <Column(Name:="No cta liq", Storage:="NO_CTA_LIQ", DbType:="VARCHAR2(20)", Id:=False), _
     DataObjectField(False, False, True, 20)> _
    Public Property NO_CTA_LIQ() As String
        Get
            Return _NO_CTA_LIQ
        End Get
        Set(ByVal Value As String)
            _NO_CTA_LIQ = Value
            OnPropertyChanged("NO_CTA_LIQ")
        End Set
    End Property

    Private _NO_CTA_LIQOld As String
    Public Property NO_CTA_LIQOld() As String
        Get
            Return _NO_CTA_LIQOld
        End Get
        Set(ByVal Value As String)
            _NO_CTA_LIQOld = Value
        End Set
    End Property

    Private _NOMBRE_CTA_LIQ As String
    <Column(Name:="Nombre cta liq", Storage:="NOMBRE_CTA_LIQ", DbType:="VARCHAR2(150)", Id:=False), _
     DataObjectField(False, False, True, 150)> _
    Public Property NOMBRE_CTA_LIQ() As String
        Get
            Return _NOMBRE_CTA_LIQ
        End Get
        Set(ByVal Value As String)
            _NOMBRE_CTA_LIQ = Value
            OnPropertyChanged("NOMBRE_CTA_LIQ")
        End Set
    End Property

    Private _NOMBRE_CTA_LIQOld As String
    Public Property NOMBRE_CTA_LIQOld() As String
        Get
            Return _NOMBRE_CTA_LIQOld
        End Get
        Set(ByVal Value As String)
            _NOMBRE_CTA_LIQOld = Value
        End Set
    End Property

    Private _CODIGO_FINANCIAMIENTO As String
    <Column(Name:="Codigo financiamiento", Storage:="CODIGO_FINANCIAMIENTO", DbType:="VARCHAR2(20)", Id:=False), _
     DataObjectField(False, False, True, 20)> _
    Public Property CODIGO_FINANCIAMIENTO() As String
        Get
            Return _CODIGO_FINANCIAMIENTO
        End Get
        Set(ByVal Value As String)
            _CODIGO_FINANCIAMIENTO = Value
            OnPropertyChanged("CODIGO_FINANCIAMIENTO")
        End Set
    End Property

    Private _CODIGO_FINANCIAMIENTOOld As String
    Public Property CODIGO_FINANCIAMIENTOOld() As String
        Get
            Return _CODIGO_FINANCIAMIENTOOld
        End Get
        Set(ByVal Value As String)
            _CODIGO_FINANCIAMIENTOOld = Value
        End Set
    End Property

    Private _COSTO_X_PARTICIPANTE As Decimal
    <Column(Name:="Costo x participante", Storage:="COSTO_X_PARTICIPANTE", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=2)> _
    Public Property COSTO_X_PARTICIPANTE() As Decimal
        Get
            Return _COSTO_X_PARTICIPANTE
        End Get
        Set(ByVal Value As Decimal)
            _COSTO_X_PARTICIPANTE = Value
            OnPropertyChanged("COSTO_X_PARTICIPANTE")
        End Set
    End Property

    Private _COSTO_X_PARTICIPANTEOld As Decimal
    Public Property COSTO_X_PARTICIPANTEOld() As Decimal
        Get
            Return _COSTO_X_PARTICIPANTEOld
        End Get
        Set(ByVal Value As Decimal)
            _COSTO_X_PARTICIPANTEOld = Value
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



    Private _NOMBRE_BANCO_DESEMBOLSO As String
    <Column(Name:="Nombre banco desembolso", Storage:="NOMBRE_BANCO_DESEMBOLSO", DbType:="VARCHAR2(20)", Id:=False), _
     DataObjectField(False, False, True, 20)> _
    Public Property NOMBRE_BANCO_DESEMBOLSO() As String
        Get
            Return _NOMBRE_BANCO_DESEMBOLSO
        End Get
        Set(ByVal Value As String)
            _NOMBRE_BANCO_DESEMBOLSO = Value
            OnPropertyChanged("NOMBRE_BANCO_DESEMBOLSO")
        End Set
    End Property

    Private _NOMBRE_BANCO_DESEMBOLSOOld As String
    Public Property NOMBRE_BANCO_DESEMBOLSOOld() As String
        Get
            Return _NOMBRE_BANCO_DESEMBOLSOOld
        End Get
        Set(ByVal Value As String)
            _NOMBRE_BANCO_DESEMBOLSOOld = Value
        End Set
    End Property

    Private _NO_CTA_DESEMBOLSO As String
    <Column(Name:="No cta desembolso", Storage:="NO_CTA_DESEMBOLSO", DbType:="VARCHAR2(20)", Id:=False), _
     DataObjectField(False, False, True, 20)> _
    Public Property NO_CTA_DESEMBOLSO() As String
        Get
            Return _NO_CTA_DESEMBOLSO
        End Get
        Set(ByVal Value As String)
            _NO_CTA_DESEMBOLSO = Value
            OnPropertyChanged("NO_CTA_DESEMBOLSO")
        End Set
    End Property

    Private _NO_CTA_DESEMBOLSOOld As String
    Public Property NO_CTA_DESEMBOLSOOld() As String
        Get
            Return _NO_CTA_DESEMBOLSOOld
        End Get
        Set(ByVal Value As String)
            _NO_CTA_DESEMBOLSOOld = Value
        End Set
    End Property

    Private _NOMBRE_CTA_DESEMBOLSO As String
    <Column(Name:="Nombre cta desembolso", Storage:="NOMBRE_CTA_DESEMBOLSO", DbType:="VARCHAR2(150)", Id:=False), _
     DataObjectField(False, False, True, 150)> _
    Public Property NOMBRE_CTA_DESEMBOLSO() As String
        Get
            Return _NOMBRE_CTA_DESEMBOLSO
        End Get
        Set(ByVal Value As String)
            _NOMBRE_CTA_DESEMBOLSO = Value
            OnPropertyChanged("NOMBRE_CTA_DESEMBOLSO")
        End Set
    End Property

    Private _NOMBRE_CTA_DESEMBOLSOOld As String
    Public Property NOMBRE_CTA_DESEMBOLSOOld() As String
        Get
            Return _NOMBRE_CTA_DESEMBOLSOOld
        End Get
        Set(ByVal Value As String)
            _NOMBRE_CTA_DESEMBOLSOOld = Value
        End Set
    End Property


#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
