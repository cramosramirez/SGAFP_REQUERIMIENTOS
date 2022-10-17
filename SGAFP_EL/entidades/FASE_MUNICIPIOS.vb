''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.FASE_MUNICIPIOS
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row FASE_MUNICIPIOS en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	10/03/2011	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="FASE_MUNICIPIOS")> Public Class FASE_MUNICIPIOS
    Inherits entidadBase
    Implements IEquatable(Of FASE_MUNICIPIOS), IComparable(Of FASE_MUNICIPIOS)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_FASE_MUNICIPIO As Decimal, aID_FUENTE As Decimal, aID_FASE As Decimal, aCODIGO_MUNICIPIO As String, aCODIGO_DEPARTAMENTO As String, aNUM_AUP As Decimal, aNUMERO_PARTICIPANTES As Decimal)
        Me._ID_FASE_MUNICIPIO = aID_FASE_MUNICIPIO
        Me._ID_FUENTE = aID_FUENTE
        Me._ID_FASE = aID_FASE
        Me._CODIGO_MUNICIPIO = aCODIGO_MUNICIPIO
        Me._CODIGO_DEPARTAMENTO = aCODIGO_DEPARTAMENTO
        Me._NUM_AUP = aNUM_AUP
        Me._NUMERO_PARTICIPANTES = aNUMERO_PARTICIPANTES
    End Sub

    Public Function Equals1(ByVal other As FASE_MUNICIPIOS) As Boolean Implements System.IEquatable(Of FASE_MUNICIPIOS).Equals
        Return Me.ID_FASE_MUNICIPIO = other.ID_FASE_MUNICIPIO
    End Function

    Public Function CompareTo(ByVal other As FASE_MUNICIPIOS) As Integer Implements System.IComparable(Of FASE_MUNICIPIOS).CompareTo
        If Me.ID_FASE_MUNICIPIO > other.ID_FASE_MUNICIPIO Then Return 1
        If Me.ID_FASE_MUNICIPIO < other.ID_FASE_MUNICIPIO Then Return -1
        Return 0
    End Function


#Region " Properties "

    Private _ID_FASE_MUNICIPIO As Decimal
    <Column(Name:="Id fase municipio", Storage:="ID_FASE_MUNICIPIO", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_FASE_MUNICIPIO() As Decimal
        Get
            Return _ID_FASE_MUNICIPIO
        End Get
        Set(ByVal Value As Decimal)
            _ID_FASE_MUNICIPIO = Value
            OnPropertyChanged("ID_FASE_MUNICIPIO")
        End Set
    End Property 

    Private _ID_FUENTE As Decimal
    <Column(Name:="Id fuente", Storage:="ID_FUENTE", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=0, Scale:=0)> _
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

    Private _ID_FASE As Decimal
    <Column(Name:="Id fase", Storage:="ID_FASE", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_FASE() As Decimal
        Get
            Return _ID_FASE
        End Get
        Set(ByVal Value As Decimal)
            _ID_FASE = Value
            OnPropertyChanged("ID_FASE")
        End Set
    End Property 

    Private _ID_FASEOld As Decimal
    Public Property ID_FASEOld() As Decimal
        Get
            Return _ID_FASEOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_FASEOld = Value
        End Set
    End Property 

    Private _fkID_FASE As FASE
    Public Property fkID_FASE() As FASE
        Get
            Return _fkID_FASE
        End Get
        Set(ByVal Value As FASE)
            _fkID_FASE = Value
        End Set
    End Property 

    Private _CODIGO_MUNICIPIO As String
    <Column(Name:="Codigo municipio", Storage:="CODIGO_MUNICIPIO", DbType:="VARCHAR2(2)", Id:=False), _
     DataObjectField(False, False, True, 2)> _
    Public Property CODIGO_MUNICIPIO() As String
        Get
            Return _CODIGO_MUNICIPIO
        End Get
        Set(ByVal Value As String)
            _CODIGO_MUNICIPIO = Value
            OnPropertyChanged("CODIGO_MUNICIPIO")
        End Set
    End Property 

    Private _CODIGO_MUNICIPIOOld As String
    Public Property CODIGO_MUNICIPIOOld() As String
        Get
            Return _CODIGO_MUNICIPIOOld
        End Get
        Set(ByVal Value As String)
            _CODIGO_MUNICIPIOOld = Value
        End Set
    End Property 

    Private _fkCODIGO_MUNICIPIO As MUNICIPIO
    Public Property fkCODIGO_MUNICIPIO() As MUNICIPIO
        Get
            Return _fkCODIGO_MUNICIPIO
        End Get
        Set(ByVal Value As MUNICIPIO)
            _fkCODIGO_MUNICIPIO = Value
        End Set
    End Property 

    Private _CODIGO_DEPARTAMENTO As String
    <Column(Name:="Codigo departamento", Storage:="CODIGO_DEPARTAMENTO", DbType:="VARCHAR2(2)", Id:=False), _
     DataObjectField(False, False, True, 2)> _
    Public Property CODIGO_DEPARTAMENTO() As String
        Get
            Return _CODIGO_DEPARTAMENTO
        End Get
        Set(ByVal Value As String)
            _CODIGO_DEPARTAMENTO = Value
            OnPropertyChanged("CODIGO_DEPARTAMENTO")
        End Set
    End Property 

    Private _CODIGO_DEPARTAMENTOOld As String
    Public Property CODIGO_DEPARTAMENTOOld() As String
        Get
            Return _CODIGO_DEPARTAMENTOOld
        End Get
        Set(ByVal Value As String)
            _CODIGO_DEPARTAMENTOOld = Value
        End Set
    End Property 

    Private _fkCODIGO_DEPARTAMENTO As DEPARTAMENTO
    Public Property fkCODIGO_DEPARTAMENTO() As DEPARTAMENTO
        Get
            Return _fkCODIGO_DEPARTAMENTO
        End Get
        Set(ByVal Value As DEPARTAMENTO)
            _fkCODIGO_DEPARTAMENTO = Value
        End Set
    End Property 

    Private _NUM_AUP As Decimal
    <Column(Name:="Num aup", Storage:="NUM_AUP", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=0, Scale:=0)> _
    Public Property NUM_AUP() As Decimal
        Get
            Return _NUM_AUP
        End Get
        Set(ByVal Value As Decimal)
            _NUM_AUP = Value
            OnPropertyChanged("NUM_AUP")
        End Set
    End Property 

    Private _NUM_AUPOld As Decimal
    Public Property NUM_AUPOld() As Decimal
        Get
            Return _NUM_AUPOld
        End Get
        Set(ByVal Value As Decimal)
            _NUM_AUPOld = Value
        End Set
    End Property 

    Private _NUMERO_PARTICIPANTES As Decimal
    <Column(Name:="Numero participantes", Storage:="NUMERO_PARTICIPANTES", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=0, Scale:=0)> _
    Public Property NUMERO_PARTICIPANTES() As Decimal
        Get
            Return _NUMERO_PARTICIPANTES
        End Get
        Set(ByVal Value As Decimal)
            _NUMERO_PARTICIPANTES = Value
            OnPropertyChanged("NUMERO_PARTICIPANTES")
        End Set
    End Property 

    Private _NUMERO_PARTICIPANTESOld As Decimal
    Public Property NUMERO_PARTICIPANTESOld() As Decimal
        Get
            Return _NUMERO_PARTICIPANTESOld
        End Get
        Set(ByVal Value As Decimal)
            _NUMERO_PARTICIPANTESOld = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
