''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.ACCION_FORMATIVA_PATI
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row ACCION_FORMATIVA_PATI en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	06/12/2011	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="ACCION_FORMATIVA_PATI")> Public Class ACCION_FORMATIVA_PATI
    Inherits entidadBase
    Implements IEquatable(Of ACCION_FORMATIVA_PATI), IComparable(Of ACCION_FORMATIVA_PATI)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(ByVal aID_ACCION_FORMATIVA As Decimal, ByVal aID_FUENTE As Decimal, ByVal aCODIGO_DEPARTAMENTO As String, ByVal aCODIGO_MUNICIPIO As String, ByVal aNO_CONVOCATORIA As Decimal, ByVal aUSERID As String, ByVal aLASTUPDATE As Date)
        Me._ID_ACCION_FORMATIVA = aID_ACCION_FORMATIVA
        Me._ID_FUENTE = aID_FUENTE
        Me._CODIGO_DEPARTAMENTO = aCODIGO_DEPARTAMENTO
        Me._CODIGO_MUNICIPIO = aCODIGO_MUNICIPIO
        Me._NO_CONVOCATORIA = aNO_CONVOCATORIA
        Me._USERID = aUSERID
        Me._LASTUPDATE = aLASTUPDATE
    End Sub

    Public Function Equals1(ByVal other As ACCION_FORMATIVA_PATI) As Boolean Implements System.IEquatable(Of ACCION_FORMATIVA_PATI).Equals
        Return Me.ID_ACCION_FORMATIVA = other.ID_ACCION_FORMATIVA
    End Function

    Public Function CompareTo(ByVal other As ACCION_FORMATIVA_PATI) As Integer Implements System.IComparable(Of ACCION_FORMATIVA_PATI).CompareTo
        If Me.ID_ACCION_FORMATIVA > other.ID_ACCION_FORMATIVA Then Return 1
        If Me.ID_ACCION_FORMATIVA < other.ID_ACCION_FORMATIVA Then Return -1
        Return 0
    End Function


#Region " Properties "

    Private _ID_ACCION_FORMATIVA As Decimal
    <Column(Name:="Id accion formativa", Storage:="ID_ACCION_FORMATIVA", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_ACCION_FORMATIVA() As Decimal
        Get
            Return _ID_ACCION_FORMATIVA
        End Get
        Set(ByVal Value As Decimal)
            _ID_ACCION_FORMATIVA = Value
            OnPropertyChanged("ID_ACCION_FORMATIVA")
        End Set
    End Property 

    Private _fkID_ACCION_FORMATIVA As ACCION_FORMATIVA
    Public Property fkID_ACCION_FORMATIVA() As ACCION_FORMATIVA
        Get
            Return _fkID_ACCION_FORMATIVA
        End Get
        Set(ByVal Value As ACCION_FORMATIVA)
            _fkID_ACCION_FORMATIVA = Value
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

    Private _CODIGO_DEPARTAMENTO As String
    <Column(Name:="Codigo departamento", Storage:="CODIGO_DEPARTAMENTO", DbType:="VARCHAR2(2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 2)> _
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
    <Column(Name:="Codigo municipio", Storage:="CODIGO_MUNICIPIO", DbType:="VARCHAR2(2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 2)> _
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
