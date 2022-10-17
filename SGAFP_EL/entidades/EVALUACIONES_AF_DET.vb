''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.EVALUACIONES_AF_DET
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite tener un registro de la tabla EVALUACIONES_AF_DET en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="EVALUACIONES_AF_DET")> Public Class EVALUACIONES_AF_DET
    Inherits entidadBase
    Implements IEquatable(Of EVALUACIONES_AF_DET), IComparable(Of EVALUACIONES_AF_DET)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_EVALUACION_DET As Decimal, aID_PARTICIPANTE As Decimal, aID_EVALUACION_AF As Decimal, aNOTA_OBTENIDA As Decimal, aNOTAS As String)
        Me._ID_EVALUACION_DET = aID_EVALUACION_DET
        Me._ID_PARTICIPANTE = aID_PARTICIPANTE
        Me._ID_EVALUACION_AF = aID_EVALUACION_AF
        Me._NOTA_OBTENIDA = aNOTA_OBTENIDA
        Me._NOTAS = aNOTAS
    End Sub

    Public Function Equals1(ByVal other As EVALUACIONES_AF_DET) As Boolean Implements System.IEquatable(Of EVALUACIONES_AF_DET).Equals
        Return Me.ID_EVALUACION_DET = other.ID_EVALUACION_DET
    End Function

    Public Function CompareTo(ByVal other As EVALUACIONES_AF_DET) As Integer Implements System.IComparable(Of EVALUACIONES_AF_DET).CompareTo
        If Me.ID_EVALUACION_DET > other.ID_EVALUACION_DET Then Return 1
        If Me.ID_EVALUACION_DET < other.ID_EVALUACION_DET Then Return -1
        Return 0
    End Function


#Region " Propiedades "

    Private _ID_EVALUACION_DET As Decimal
    <Column(Name:="Id evaluacion det", Storage:="ID_EVALUACION_DET", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_EVALUACION_DET() As Decimal
        Get
            Return _ID_EVALUACION_DET
        End Get
        Set(ByVal Value As Decimal)
            _ID_EVALUACION_DET = Value
            OnPropertyChanged("ID_EVALUACION_DET")
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

    Private _ID_EVALUACION_AF As Decimal
    <Column(Name:="Id evaluacion af", Storage:="ID_EVALUACION_AF", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_EVALUACION_AF() As Decimal
        Get
            Return _ID_EVALUACION_AF
        End Get
        Set(ByVal Value As Decimal)
            _ID_EVALUACION_AF = Value
            OnPropertyChanged("ID_EVALUACION_AF")
        End Set
    End Property 

    Private _ID_EVALUACION_AFOld As Decimal
    Public Property ID_EVALUACION_AFOld() As Decimal
        Get
            Return _ID_EVALUACION_AFOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_EVALUACION_AFOld = Value
        End Set
    End Property 

    Private _fkID_EVALUACION_AF As EVALUACION_AF
    Public Property fkID_EVALUACION_AF() As EVALUACION_AF
        Get
            Return _fkID_EVALUACION_AF
        End Get
        Set(ByVal Value As EVALUACION_AF)
            _fkID_EVALUACION_AF = Value
        End Set
    End Property 

    Private _NOTA_OBTENIDA As Decimal
    <Column(Name:="Nota obtenida", Storage:="NOTA_OBTENIDA", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=4, Scale:=2)> _
    Public Property NOTA_OBTENIDA() As Decimal
        Get
            Return _NOTA_OBTENIDA
        End Get
        Set(ByVal Value As Decimal)
            _NOTA_OBTENIDA = Value
            OnPropertyChanged("NOTA_OBTENIDA")
        End Set
    End Property 

    Private _NOTA_OBTENIDAOld As Decimal
    Public Property NOTA_OBTENIDAOld() As Decimal
        Get
            Return _NOTA_OBTENIDAOld
        End Get
        Set(ByVal Value As Decimal)
            _NOTA_OBTENIDAOld = Value
        End Set
    End Property 

    Private _NOTAS As String
    <Column(Name:="Notas", Storage:="NOTAS", DbType:="VARCHAR2(100)", Id:=False), _
     DataObjectField(False, False, True, 100)> _
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

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
