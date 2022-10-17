''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.SIPU_MUNICIPIO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row SIPU_MUNICIPIO en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	29/10/2013	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="SIPU_MUNICIPIO")> Public Class SIPU_MUNICIPIO
    Inherits entidadBase
    Implements IEquatable(Of SIPU_MUNICIPIO), IComparable(Of SIPU_MUNICIPIO)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aIDMUNICIPIO As Decimal, aDESCRIPCION As String, aIDDEPARTAMENTO As Decimal, aCODMUNICIPIOFIS As Decimal, aCODIGO_DEPTO_INSAFORP As String, aCODIGO_MUNI_INSAFORP As String)
        Me._IDMUNICIPIO = aIDMUNICIPIO
        Me._DESCRIPCION = aDESCRIPCION
        Me._IDDEPARTAMENTO = aIDDEPARTAMENTO
        Me._CODMUNICIPIOFIS = aCODMUNICIPIOFIS
        Me._CODIGO_DEPTO_INSAFORP = aCODIGO_DEPTO_INSAFORP
        Me._CODIGO_MUNI_INSAFORP = aCODIGO_MUNI_INSAFORP
    End Sub

    Public Function Equals1(ByVal other As SIPU_MUNICIPIO) As Boolean Implements System.IEquatable(Of SIPU_MUNICIPIO).Equals
        Return Me.IDMUNICIPIO = other.IDMUNICIPIO
    End Function

    Public Function CompareTo(ByVal other As SIPU_MUNICIPIO) As Integer Implements System.IComparable(Of SIPU_MUNICIPIO).CompareTo
        If Me.IDMUNICIPIO > other.IDMUNICIPIO Then Return 1
        If Me.IDMUNICIPIO < other.IDMUNICIPIO Then Return -1
        Return 0
    End Function


#Region " Properties "

    Private _IDMUNICIPIO As Decimal
    <Column(Name:="Idmunicipio", Storage:="IDMUNICIPIO", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property IDMUNICIPIO() As Decimal
        Get
            Return _IDMUNICIPIO
        End Get
        Set(ByVal Value As Decimal)
            _IDMUNICIPIO = Value
            OnPropertyChanged("IDMUNICIPIO")
        End Set
    End Property 

    Private _DESCRIPCION As String
    <Column(Name:="Descripcion", Storage:="DESCRIPCION", DbType:="VARCHAR2(150) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 150)> _
    Public Property DESCRIPCION() As String
        Get
            Return _DESCRIPCION
        End Get
        Set(ByVal Value As String)
            _DESCRIPCION = Value
            OnPropertyChanged("DESCRIPCION")
        End Set
    End Property 

    Private _DESCRIPCIONOld As String
    Public Property DESCRIPCIONOld() As String
        Get
            Return _DESCRIPCIONOld
        End Get
        Set(ByVal Value As String)
            _DESCRIPCIONOld = Value
        End Set
    End Property 

    Private _IDDEPARTAMENTO As Decimal
    <Column(Name:="Iddepartamento", Storage:="IDDEPARTAMENTO", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property IDDEPARTAMENTO() As Decimal
        Get
            Return _IDDEPARTAMENTO
        End Get
        Set(ByVal Value As Decimal)
            _IDDEPARTAMENTO = Value
            OnPropertyChanged("IDDEPARTAMENTO")
        End Set
    End Property 

    Private _IDDEPARTAMENTOOld As Decimal
    Public Property IDDEPARTAMENTOOld() As Decimal
        Get
            Return _IDDEPARTAMENTOOld
        End Get
        Set(ByVal Value As Decimal)
            _IDDEPARTAMENTOOld = Value
        End Set
    End Property 

    Private _CODMUNICIPIOFIS As Decimal
    <Column(Name:="Codmunicipiofis", Storage:="CODMUNICIPIOFIS", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property CODMUNICIPIOFIS() As Decimal
        Get
            Return _CODMUNICIPIOFIS
        End Get
        Set(ByVal Value As Decimal)
            _CODMUNICIPIOFIS = Value
            OnPropertyChanged("CODMUNICIPIOFIS")
        End Set
    End Property 

    Private _CODMUNICIPIOFISOld As Decimal
    Public Property CODMUNICIPIOFISOld() As Decimal
        Get
            Return _CODMUNICIPIOFISOld
        End Get
        Set(ByVal Value As Decimal)
            _CODMUNICIPIOFISOld = Value
        End Set
    End Property 

    Private _CODIGO_DEPTO_INSAFORP As String
    <Column(Name:="Codigo depto insaforp", Storage:="CODIGO_DEPTO_INSAFORP", DbType:="VARCHAR2(2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 2)> _
    Public Property CODIGO_DEPTO_INSAFORP() As String
        Get
            Return _CODIGO_DEPTO_INSAFORP
        End Get
        Set(ByVal Value As String)
            _CODIGO_DEPTO_INSAFORP = Value
            OnPropertyChanged("CODIGO_DEPTO_INSAFORP")
        End Set
    End Property 

    Private _CODIGO_DEPTO_INSAFORPOld As String
    Public Property CODIGO_DEPTO_INSAFORPOld() As String
        Get
            Return _CODIGO_DEPTO_INSAFORPOld
        End Get
        Set(ByVal Value As String)
            _CODIGO_DEPTO_INSAFORPOld = Value
        End Set
    End Property 

    Private _CODIGO_MUNI_INSAFORP As String
    <Column(Name:="Codigo muni insaforp", Storage:="CODIGO_MUNI_INSAFORP", DbType:="VARCHAR2(2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 2)> _
    Public Property CODIGO_MUNI_INSAFORP() As String
        Get
            Return _CODIGO_MUNI_INSAFORP
        End Get
        Set(ByVal Value As String)
            _CODIGO_MUNI_INSAFORP = Value
            OnPropertyChanged("CODIGO_MUNI_INSAFORP")
        End Set
    End Property 

    Private _CODIGO_MUNI_INSAFORPOld As String
    Public Property CODIGO_MUNI_INSAFORPOld() As String
        Get
            Return _CODIGO_MUNI_INSAFORPOld
        End Get
        Set(ByVal Value As String)
            _CODIGO_MUNI_INSAFORPOld = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
