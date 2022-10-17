''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.EVALUACION_AF
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite tener un registro de la tabla EVALUACION_AF en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="EVALUACION_AF")> Public Class EVALUACION_AF
    Inherits entidadBase
    Implements IEquatable(Of EVALUACION_AF), IComparable(Of EVALUACION_AF)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_EVALUACION_AF As Decimal, aID_ACCION_FORMATIVA As Decimal, aFECHA_EVALUACION As DateTime, aTEMA_EVALUACION As String, aNOTAS As String, aEVALUADOR As String, aTIPO_EVALUACION As String, aPORC_APROBACION As Decimal, aPORC_REPROBADOS As Decimal)
        Me._ID_EVALUACION_AF = aID_EVALUACION_AF
        Me._ID_ACCION_FORMATIVA = aID_ACCION_FORMATIVA
        Me._FECHA_EVALUACION = aFECHA_EVALUACION
        Me._TEMA_EVALUACION = aTEMA_EVALUACION
        Me._NOTAS = aNOTAS
        Me._EVALUADOR = aEVALUADOR
        Me._TIPO_EVALUACION = aTIPO_EVALUACION
        Me._PORC_APROBACION = aPORC_APROBACION
        Me._PORC_REPROBADOS = aPORC_REPROBADOS
    End Sub

    Public Function Equals1(ByVal other As EVALUACION_AF) As Boolean Implements System.IEquatable(Of EVALUACION_AF).Equals
        Return Me.ID_EVALUACION_AF = other.ID_EVALUACION_AF
    End Function

    Public Function CompareTo(ByVal other As EVALUACION_AF) As Integer Implements System.IComparable(Of EVALUACION_AF).CompareTo
        If Me.ID_EVALUACION_AF > other.ID_EVALUACION_AF Then Return 1
        If Me.ID_EVALUACION_AF < other.ID_EVALUACION_AF Then Return -1
        Return 0
    End Function


#Region " Propiedades "

    Private _ID_EVALUACION_AF As Decimal
    <Column(Name:="Id evaluacion af", Storage:="ID_EVALUACION_AF", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_EVALUACION_AF() As Decimal
        Get
            Return _ID_EVALUACION_AF
        End Get
        Set(ByVal Value As Decimal)
            _ID_EVALUACION_AF = Value
            OnPropertyChanged("ID_EVALUACION_AF")
        End Set
    End Property 

    Private _ID_ACCION_FORMATIVA As Decimal
    <Column(Name:="Id accion formativa", Storage:="ID_ACCION_FORMATIVA", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_ACCION_FORMATIVA() As Decimal
        Get
            Return _ID_ACCION_FORMATIVA
        End Get
        Set(ByVal Value As Decimal)
            _ID_ACCION_FORMATIVA = Value
            OnPropertyChanged("ID_ACCION_FORMATIVA")
        End Set
    End Property 

    Private _ID_ACCION_FORMATIVAOld As Decimal
    Public Property ID_ACCION_FORMATIVAOld() As Decimal
        Get
            Return _ID_ACCION_FORMATIVAOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_ACCION_FORMATIVAOld = Value
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

    Private _FECHA_EVALUACION As DateTime
    <Column(Name:="Fecha evaluacion", Storage:="FECHA_EVALUACION", DbType:="DATE", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property FECHA_EVALUACION() As DateTime
        Get
            Return _FECHA_EVALUACION
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_EVALUACION = Value
            OnPropertyChanged("FECHA_EVALUACION")
        End Set
    End Property 

    Private _FECHA_EVALUACIONOld As DateTime
    Public Property FECHA_EVALUACIONOld() As DateTime
        Get
            Return _FECHA_EVALUACIONOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_EVALUACIONOld = Value
        End Set
    End Property 

    Private _TEMA_EVALUACION As String
    <Column(Name:="Tema evaluacion", Storage:="TEMA_EVALUACION", DbType:="VARCHAR2(100)", Id:=False), _
     DataObjectField(False, False, True, 100)> _
    Public Property TEMA_EVALUACION() As String
        Get
            Return _TEMA_EVALUACION
        End Get
        Set(ByVal Value As String)
            _TEMA_EVALUACION = Value
            OnPropertyChanged("TEMA_EVALUACION")
        End Set
    End Property 

    Private _TEMA_EVALUACIONOld As String
    Public Property TEMA_EVALUACIONOld() As String
        Get
            Return _TEMA_EVALUACIONOld
        End Get
        Set(ByVal Value As String)
            _TEMA_EVALUACIONOld = Value
        End Set
    End Property 

    Private _NOTAS As String
    <Column(Name:="Notas", Storage:="NOTAS", DbType:="VARCHAR2(255)", Id:=False), _
     DataObjectField(False, False, True, 255)> _
    Public Property NOTAS() As String
        Get
            Return _NOTAS
        End Get
        Set(ByVal Value As String)
            _NOTAS = Value
            OnPropertyChanged("NOTAS")
        End Set
    End Property 

    Private _NOTASOld As String
    Public Property NOTASOld() As String
        Get
            Return _NOTASOld
        End Get
        Set(ByVal Value As String)
            _NOTASOld = Value
        End Set
    End Property 

    Private _EVALUADOR As String
    <Column(Name:="Evaluador", Storage:="EVALUADOR", DbType:="VARCHAR2(100)", Id:=False), _
     DataObjectField(False, False, True, 100)> _
    Public Property EVALUADOR() As String
        Get
            Return _EVALUADOR
        End Get
        Set(ByVal Value As String)
            _EVALUADOR = Value
            OnPropertyChanged("EVALUADOR")
        End Set
    End Property 

    Private _EVALUADOROld As String
    Public Property EVALUADOROld() As String
        Get
            Return _EVALUADOROld
        End Get
        Set(ByVal Value As String)
            _EVALUADOROld = Value
        End Set
    End Property 

    Private _TIPO_EVALUACION As String
    <Column(Name:="Tipo evaluacion", Storage:="TIPO_EVALUACION", DbType:="CHAR(1)", Id:=False), _
     DataObjectField(False, False, True, 1)> _
    Public Property TIPO_EVALUACION() As String
        Get
            Return _TIPO_EVALUACION
        End Get
        Set(ByVal Value As String)
            _TIPO_EVALUACION = Value
            OnPropertyChanged("TIPO_EVALUACION")
        End Set
    End Property 

    Private _TIPO_EVALUACIONOld As String
    Public Property TIPO_EVALUACIONOld() As String
        Get
            Return _TIPO_EVALUACIONOld
        End Get
        Set(ByVal Value As String)
            _TIPO_EVALUACIONOld = Value
        End Set
    End Property 

    Private _PORC_APROBACION As Decimal
    <Column(Name:="Porc aprobacion", Storage:="PORC_APROBACION", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=5, Scale:=2)> _
    Public Property PORC_APROBACION() As Decimal
        Get
            Return _PORC_APROBACION
        End Get
        Set(ByVal Value As Decimal)
            _PORC_APROBACION = Value
            OnPropertyChanged("PORC_APROBACION")
        End Set
    End Property 

    Private _PORC_APROBACIONOld As Decimal
    Public Property PORC_APROBACIONOld() As Decimal
        Get
            Return _PORC_APROBACIONOld
        End Get
        Set(ByVal Value As Decimal)
            _PORC_APROBACIONOld = Value
        End Set
    End Property 

    Private _PORC_REPROBADOS As Decimal
    <Column(Name:="Porc reprobados", Storage:="PORC_REPROBADOS", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=5, Scale:=2)> _
    Public Property PORC_REPROBADOS() As Decimal
        Get
            Return _PORC_REPROBADOS
        End Get
        Set(ByVal Value As Decimal)
            _PORC_REPROBADOS = Value
            OnPropertyChanged("PORC_REPROBADOS")
        End Set
    End Property 

    Private _PORC_REPROBADOSOld As Decimal
    Public Property PORC_REPROBADOSOld() As Decimal
        Get
            Return _PORC_REPROBADOSOld
        End Get
        Set(ByVal Value As Decimal)
            _PORC_REPROBADOSOld = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
