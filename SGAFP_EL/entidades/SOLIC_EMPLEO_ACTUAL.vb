''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.SOLIC_EMPLEO_ACTUAL
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row SOLIC_EMPLEO_ACTUAL en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	19/01/2011	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="SOLIC_EMPLEO_ACTUAL")> Public Class SOLIC_EMPLEO_ACTUAL
    Inherits entidadBase
    Implements IEquatable(Of SOLIC_EMPLEO_ACTUAL), IComparable(Of SOLIC_EMPLEO_ACTUAL)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_EMPLEO_ACTUAL As Decimal, aID_SOLICITUD As Decimal, aNOMBRE_EMPRESA As String, aDIRECCION As String, aCODIGO_DEPARTAMENTO As String, aCODIGO_MUNICIPIO As String, aTELEFONOS As String, aTIEMPO_TRABAJO As Decimal, aAREA_TRABAJO As Decimal, aAREA_OTRO As String)
        Me._ID_EMPLEO_ACTUAL = aID_EMPLEO_ACTUAL
        Me._ID_SOLICITUD = aID_SOLICITUD
        Me._NOMBRE_EMPRESA = aNOMBRE_EMPRESA
        Me._DIRECCION = aDIRECCION
        Me._CODIGO_DEPARTAMENTO = aCODIGO_DEPARTAMENTO
        Me._CODIGO_MUNICIPIO = aCODIGO_MUNICIPIO
        Me._TELEFONOS = aTELEFONOS
        Me._TIEMPO_TRABAJO = aTIEMPO_TRABAJO
        Me._AREA_TRABAJO = aAREA_TRABAJO
        Me._AREA_OTRO = aAREA_OTRO
    End Sub

    Public Function Equals1(ByVal other As SOLIC_EMPLEO_ACTUAL) As Boolean Implements System.IEquatable(Of SOLIC_EMPLEO_ACTUAL).Equals
        Return Me.ID_EMPLEO_ACTUAL = other.ID_EMPLEO_ACTUAL
    End Function

    Public Function CompareTo(ByVal other As SOLIC_EMPLEO_ACTUAL) As Integer Implements System.IComparable(Of SOLIC_EMPLEO_ACTUAL).CompareTo
        If Me.ID_EMPLEO_ACTUAL > other.ID_EMPLEO_ACTUAL Then Return 1
        If Me.ID_EMPLEO_ACTUAL < other.ID_EMPLEO_ACTUAL Then Return -1
        Return 0
    End Function


#Region " Properties "

    Private _ID_EMPLEO_ACTUAL As Decimal
    <Column(Name:="Id empleo actual", Storage:="ID_EMPLEO_ACTUAL", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_EMPLEO_ACTUAL() As Decimal
        Get
            Return _ID_EMPLEO_ACTUAL
        End Get
        Set(ByVal Value As Decimal)
            _ID_EMPLEO_ACTUAL = Value
            OnPropertyChanged("ID_EMPLEO_ACTUAL")
        End Set
    End Property 

    Private _ID_SOLICITUD As Decimal
    <Column(Name:="Id solicitud", Storage:="ID_SOLICITUD", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_SOLICITUD() As Decimal
        Get
            Return _ID_SOLICITUD
        End Get
        Set(ByVal Value As Decimal)
            _ID_SOLICITUD = Value
            OnPropertyChanged("ID_SOLICITUD")
        End Set
    End Property 

    Private _ID_SOLICITUDOld As Decimal
    Public Property ID_SOLICITUDOld() As Decimal
        Get
            Return _ID_SOLICITUDOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_SOLICITUDOld = Value
        End Set
    End Property 

    Private _fkID_SOLICITUD As SOLICITUD_INSCRIPCION_AF
    Public Property fkID_SOLICITUD() As SOLICITUD_INSCRIPCION_AF
        Get
            Return _fkID_SOLICITUD
        End Get
        Set(ByVal Value As SOLICITUD_INSCRIPCION_AF)
            _fkID_SOLICITUD = Value
        End Set
    End Property 

    Private _NOMBRE_EMPRESA As String
    <Column(Name:="Nombre empresa", Storage:="NOMBRE_EMPRESA", DbType:="VARCHAR2(100)", Id:=False), _
     DataObjectField(False, False, True, 100)> _
    Public Property NOMBRE_EMPRESA() As String
        Get
            Return _NOMBRE_EMPRESA
        End Get
        Set(ByVal Value As String)
            _NOMBRE_EMPRESA = Value
            OnPropertyChanged("NOMBRE_EMPRESA")
        End Set
    End Property 

    Private _NOMBRE_EMPRESAOld As String
    Public Property NOMBRE_EMPRESAOld() As String
        Get
            Return _NOMBRE_EMPRESAOld
        End Get
        Set(ByVal Value As String)
            _NOMBRE_EMPRESAOld = Value
        End Set
    End Property 

    Private _DIRECCION As String
    <Column(Name:="Direccion", Storage:="DIRECCION", DbType:="VARCHAR2(150)", Id:=False), _
     DataObjectField(False, False, True, 150)> _
    Public Property DIRECCION() As String
        Get
            Return _DIRECCION
        End Get
        Set(ByVal Value As String)
            _DIRECCION = Value
            OnPropertyChanged("DIRECCION")
        End Set
    End Property 

    Private _DIRECCIONOld As String
    Public Property DIRECCIONOld() As String
        Get
            Return _DIRECCIONOld
        End Get
        Set(ByVal Value As String)
            _DIRECCIONOld = Value
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

    Private _TELEFONOS As String
    <Column(Name:="Telefonos", Storage:="TELEFONOS", DbType:="VARCHAR2(40)", Id:=False), _
     DataObjectField(False, False, True, 40)> _
    Public Property TELEFONOS() As String
        Get
            Return _TELEFONOS
        End Get
        Set(ByVal Value As String)
            _TELEFONOS = Value
            OnPropertyChanged("TELEFONOS")
        End Set
    End Property 

    Private _TELEFONOSOld As String
    Public Property TELEFONOSOld() As String
        Get
            Return _TELEFONOSOld
        End Get
        Set(ByVal Value As String)
            _TELEFONOSOld = Value
        End Set
    End Property 

    Private _TIEMPO_TRABAJO As Decimal
    <Column(Name:="Tiempo trabajo", Storage:="TIEMPO_TRABAJO", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=1, Scale:=0)> _
    Public Property TIEMPO_TRABAJO() As Decimal
        Get
            Return _TIEMPO_TRABAJO
        End Get
        Set(ByVal Value As Decimal)
            _TIEMPO_TRABAJO = Value
            OnPropertyChanged("TIEMPO_TRABAJO")
        End Set
    End Property 

    Private _TIEMPO_TRABAJOOld As Decimal
    Public Property TIEMPO_TRABAJOOld() As Decimal
        Get
            Return _TIEMPO_TRABAJOOld
        End Get
        Set(ByVal Value As Decimal)
            _TIEMPO_TRABAJOOld = Value
        End Set
    End Property 

    Private _AREA_TRABAJO As Decimal
    <Column(Name:="Area trabajo", Storage:="AREA_TRABAJO", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=1, Scale:=0)> _
    Public Property AREA_TRABAJO() As Decimal
        Get
            Return _AREA_TRABAJO
        End Get
        Set(ByVal Value As Decimal)
            _AREA_TRABAJO = Value
            OnPropertyChanged("AREA_TRABAJO")
        End Set
    End Property 

    Private _AREA_TRABAJOOld As Decimal
    Public Property AREA_TRABAJOOld() As Decimal
        Get
            Return _AREA_TRABAJOOld
        End Get
        Set(ByVal Value As Decimal)
            _AREA_TRABAJOOld = Value
        End Set
    End Property 

    Private _AREA_OTRO As String
    <Column(Name:="Area otro", Storage:="AREA_OTRO", DbType:="VARCHAR2(60)", Id:=False), _
     DataObjectField(False, False, True, 60)> _
    Public Property AREA_OTRO() As String
        Get
            Return _AREA_OTRO
        End Get
        Set(ByVal Value As String)
            _AREA_OTRO = Value
            OnPropertyChanged("AREA_OTRO")
        End Set
    End Property 

    Private _AREA_OTROOld As String
    Public Property AREA_OTROOld() As String
        Get
            Return _AREA_OTROOld
        End Get
        Set(ByVal Value As String)
            _AREA_OTROOld = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
