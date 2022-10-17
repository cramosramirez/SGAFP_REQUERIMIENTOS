''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.USUARIO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row USUARIO en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/05/2011	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="USUARIO")> Public Class USUARIO
    Inherits entidadBase
    Implements IEquatable(Of USUARIO), IComparable(Of USUARIO)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aUSUARIO As String, aID_PROVEEDOR_AF As Decimal, aID_SITIO_CAPACITACION As Decimal, aID_PARTICIPANTE As Decimal, aNOMBRE As String, aDEPARTAMENTO_ALCALDIA As String, aMUNICIPIO_ALCALDIA As String)
        Me._USUARIO = aUSUARIO
        Me._ID_PROVEEDOR_AF = aID_PROVEEDOR_AF
        Me._ID_SITIO_CAPACITACION = aID_SITIO_CAPACITACION
        Me._ID_PARTICIPANTE = aID_PARTICIPANTE
        Me._NOMBRE = aNOMBRE
        Me._DEPARTAMENTO_ALCALDIA = aDEPARTAMENTO_ALCALDIA
        Me._MUNICIPIO_ALCALDIA = aMUNICIPIO_ALCALDIA
    End Sub

    Public Function Equals1(ByVal other As USUARIO) As Boolean Implements System.IEquatable(Of USUARIO).Equals
        Return Me.USUARIO = other.USUARIO
    End Function

    Public Function CompareTo(ByVal other As USUARIO) As Integer Implements System.IComparable(Of USUARIO).CompareTo
        If Me.USUARIO > other.USUARIO Then Return 1
        If Me.USUARIO < other.USUARIO Then Return -1
        Return 0
    End Function


#Region " Properties "

    Private _USUARIO As String
    <Column(Name:="Usuario", Storage:="USUARIO", DbType:="VARCHAR2(256) NOT NULL", Id:=True), _
     DataObjectField(True, False, False, 256)> _
    Public Property USUARIO() As String
        Get
            Return _USUARIO
        End Get
        Set(ByVal Value As String)
            _USUARIO = Value
            OnPropertyChanged("USUARIO")
        End Set
    End Property 

    Private _ID_PROVEEDOR_AF As Decimal
    <Column(Name:="Id proveedor af", Storage:="ID_PROVEEDOR_AF", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_PROVEEDOR_AF() As Decimal
        Get
            Return _ID_PROVEEDOR_AF
        End Get
        Set(ByVal Value As Decimal)
            _ID_PROVEEDOR_AF = Value
            OnPropertyChanged("ID_PROVEEDOR_AF")
        End Set
    End Property 

    Private _ID_PROVEEDOR_AFOld As Decimal
    Public Property ID_PROVEEDOR_AFOld() As Decimal
        Get
            Return _ID_PROVEEDOR_AFOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_PROVEEDOR_AFOld = Value
        End Set
    End Property 

    Private _fkID_PROVEEDOR_AF As PROVEEDOR_AF
    Public Property fkID_PROVEEDOR_AF() As PROVEEDOR_AF
        Get
            Return _fkID_PROVEEDOR_AF
        End Get
        Set(ByVal Value As PROVEEDOR_AF)
            _fkID_PROVEEDOR_AF = Value
        End Set
    End Property 

    Private _ID_SITIO_CAPACITACION As Decimal
    <Column(Name:="Id sitio capacitacion", Storage:="ID_SITIO_CAPACITACION", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_SITIO_CAPACITACION() As Decimal
        Get
            Return _ID_SITIO_CAPACITACION
        End Get
        Set(ByVal Value As Decimal)
            _ID_SITIO_CAPACITACION = Value
            OnPropertyChanged("ID_SITIO_CAPACITACION")
        End Set
    End Property 

    Private _ID_SITIO_CAPACITACIONOld As Decimal
    Public Property ID_SITIO_CAPACITACIONOld() As Decimal
        Get
            Return _ID_SITIO_CAPACITACIONOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_SITIO_CAPACITACIONOld = Value
        End Set
    End Property 

    Private _fkID_SITIO_CAPACITACION As SITIO_CAPACITACION
    Public Property fkID_SITIO_CAPACITACION() As SITIO_CAPACITACION
        Get
            Return _fkID_SITIO_CAPACITACION
        End Get
        Set(ByVal Value As SITIO_CAPACITACION)
            _fkID_SITIO_CAPACITACION = Value
        End Set
    End Property 

    Private _ID_PARTICIPANTE As Decimal
    <Column(Name:="Id participante", Storage:="ID_PARTICIPANTE", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_PARTICIPANTE() As Decimal
        Get
            Return _ID_PARTICIPANTE
        End Get
        Set(ByVal Value As Decimal)
            _ID_PARTICIPANTE = Value
            OnPropertyChanged("ID_PARTICIPANTE")
        End Set
    End Property 

    Private _ID_PARTICIPANTEOld As Decimal
    Public Property ID_PARTICIPANTEOld() As Decimal
        Get
            Return _ID_PARTICIPANTEOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_PARTICIPANTEOld = Value
        End Set
    End Property 

    Private _fkID_PARTICIPANTE As PARTICIPANTE
    Public Property fkID_PARTICIPANTE() As PARTICIPANTE
        Get
            Return _fkID_PARTICIPANTE
        End Get
        Set(ByVal Value As PARTICIPANTE)
            _fkID_PARTICIPANTE = Value
        End Set
    End Property 

    Private _NOMBRE As String
    <Column(Name:="Nombre", Storage:="NOMBRE", DbType:="VARCHAR2(256)", Id:=False), _
     DataObjectField(False, False, True, 256)> _
    Public Property NOMBRE() As String
        Get
            Return _NOMBRE
        End Get
        Set(ByVal Value As String)
            _NOMBRE = Value
            OnPropertyChanged("NOMBRE")
        End Set
    End Property 

    Private _NOMBREOld As String
    Public Property NOMBREOld() As String
        Get
            Return _NOMBREOld
        End Get
        Set(ByVal Value As String)
            _NOMBREOld = Value
        End Set
    End Property 

    Private _DEPARTAMENTO_ALCALDIA As String
    <Column(Name:="Departamento alcaldia", Storage:="DEPARTAMENTO_ALCALDIA", DbType:="VARCHAR2(2)", Id:=False), _
     DataObjectField(False, False, True, 2)> _
    Public Property DEPARTAMENTO_ALCALDIA() As String
        Get
            Return _DEPARTAMENTO_ALCALDIA
        End Get
        Set(ByVal Value As String)
            _DEPARTAMENTO_ALCALDIA = Value
            OnPropertyChanged("DEPARTAMENTO_ALCALDIA")
        End Set
    End Property 

    Private _DEPARTAMENTO_ALCALDIAOld As String
    Public Property DEPARTAMENTO_ALCALDIAOld() As String
        Get
            Return _DEPARTAMENTO_ALCALDIAOld
        End Get
        Set(ByVal Value As String)
            _DEPARTAMENTO_ALCALDIAOld = Value
        End Set
    End Property 

    Private _MUNICIPIO_ALCALDIA As String
    <Column(Name:="Municipio alcaldia", Storage:="MUNICIPIO_ALCALDIA", DbType:="VARCHAR2(2)", Id:=False), _
     DataObjectField(False, False, True, 2)> _
    Public Property MUNICIPIO_ALCALDIA() As String
        Get
            Return _MUNICIPIO_ALCALDIA
        End Get
        Set(ByVal Value As String)
            _MUNICIPIO_ALCALDIA = Value
            OnPropertyChanged("MUNICIPIO_ALCALDIA")
        End Set
    End Property 

    Private _MUNICIPIO_ALCALDIAOld As String
    Public Property MUNICIPIO_ALCALDIAOld() As String
        Get
            Return _MUNICIPIO_ALCALDIAOld
        End Get
        Set(ByVal Value As String)
            _MUNICIPIO_ALCALDIAOld = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
    Private _TECNICOS_SITIOS_ASIGUSUARIO As ListaTECNICOS_SITIOS_ASIG
    Public Property TECNICOS_SITIOS_ASIGUSUARIO() As ListaTECNICOS_SITIOS_ASIG
        Get
            Return _TECNICOS_SITIOS_ASIGUSUARIO
        End Get
        Set(ByVal Value As ListaTECNICOS_SITIOS_ASIG)
            _TECNICOS_SITIOS_ASIGUSUARIO = Value
        End Set
    End Property 

#End Region
#End Region
End Class
