''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.ESTADO_ACCION_FORMATIVA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite tener un registro de la tabla ESTADO_ACCION_FORMATIVA en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="ESTADO_ACCION_FORMATIVA")> Public Class ESTADO_ACCION_FORMATIVA
    Inherits entidadBase
    Implements IEquatable(Of ESTADO_ACCION_FORMATIVA), IComparable(Of ESTADO_ACCION_FORMATIVA)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aCODIGO_ESTADO_AF As String, aNOMBRE_ESTADO_AF As String, aESTADO_INICIAL As Decimal, aPERMITE_INSCRIPCION As Decimal, aESTADO_FINAL As Decimal, aNOTAS As String)
        Me._CODIGO_ESTADO_AF = aCODIGO_ESTADO_AF
        Me._NOMBRE_ESTADO_AF = aNOMBRE_ESTADO_AF
        Me._ESTADO_INICIAL = aESTADO_INICIAL
        Me._PERMITE_INSCRIPCION = aPERMITE_INSCRIPCION
        Me._ESTADO_FINAL = aESTADO_FINAL
        Me._NOTAS = aNOTAS
    End Sub

    Public Function Equals1(ByVal other As ESTADO_ACCION_FORMATIVA) As Boolean Implements System.IEquatable(Of ESTADO_ACCION_FORMATIVA).Equals
        Return Me.CODIGO_ESTADO_AF = other.CODIGO_ESTADO_AF
    End Function

    Public Function CompareTo(ByVal other As ESTADO_ACCION_FORMATIVA) As Integer Implements System.IComparable(Of ESTADO_ACCION_FORMATIVA).CompareTo
        If Me.CODIGO_ESTADO_AF > other.CODIGO_ESTADO_AF Then Return 1
        If Me.CODIGO_ESTADO_AF < other.CODIGO_ESTADO_AF Then Return -1
        Return 0
    End Function


#Region " Propiedades "

    Private _CODIGO_ESTADO_AF As String
    <Column(Name:="Codigo estado af", Storage:="CODIGO_ESTADO_AF", DbType:="CHAR(2) NOT NULL", Id:=True), _
     DataObjectField(True, False, False, 2)> _
    Public Property CODIGO_ESTADO_AF() As String
        Get
            Return _CODIGO_ESTADO_AF
        End Get
        Set(ByVal Value As String)
            _CODIGO_ESTADO_AF = Value
            OnPropertyChanged("CODIGO_ESTADO_AF")
        End Set
    End Property 

    Private _NOMBRE_ESTADO_AF As String
    <Column(Name:="Nombre estado af", Storage:="NOMBRE_ESTADO_AF", DbType:="VARCHAR2(40)", Id:=False), _
     DataObjectField(False, False, True, 40)> _
    Public Property NOMBRE_ESTADO_AF() As String
        Get
            Return _NOMBRE_ESTADO_AF
        End Get
        Set(ByVal Value As String)
            _NOMBRE_ESTADO_AF = Value
            OnPropertyChanged("NOMBRE_ESTADO_AF")
        End Set
    End Property 

    Private _NOMBRE_ESTADO_AFOld As String
    Public Property NOMBRE_ESTADO_AFOld() As String
        Get
            Return _NOMBRE_ESTADO_AFOld
        End Get
        Set(ByVal Value As String)
            _NOMBRE_ESTADO_AFOld = Value
        End Set
    End Property 

    Private _ESTADO_INICIAL As Decimal
    <Column(Name:="Estado inicial", Storage:="ESTADO_INICIAL", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=1, Scale:=0)> _
    Public Property ESTADO_INICIAL() As Decimal
        Get
            Return _ESTADO_INICIAL
        End Get
        Set(ByVal Value As Decimal)
            _ESTADO_INICIAL = Value
            OnPropertyChanged("ESTADO_INICIAL")
        End Set
    End Property 

    Private _ESTADO_INICIALOld As Decimal
    Public Property ESTADO_INICIALOld() As Decimal
        Get
            Return _ESTADO_INICIALOld
        End Get
        Set(ByVal Value As Decimal)
            _ESTADO_INICIALOld = Value
        End Set
    End Property 

    Private _PERMITE_INSCRIPCION As Decimal
    <Column(Name:="Permite inscripcion", Storage:="PERMITE_INSCRIPCION", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=1, Scale:=0)> _
    Public Property PERMITE_INSCRIPCION() As Decimal
        Get
            Return _PERMITE_INSCRIPCION
        End Get
        Set(ByVal Value As Decimal)
            _PERMITE_INSCRIPCION = Value
            OnPropertyChanged("PERMITE_INSCRIPCION")
        End Set
    End Property 

    Private _PERMITE_INSCRIPCIONOld As Decimal
    Public Property PERMITE_INSCRIPCIONOld() As Decimal
        Get
            Return _PERMITE_INSCRIPCIONOld
        End Get
        Set(ByVal Value As Decimal)
            _PERMITE_INSCRIPCIONOld = Value
        End Set
    End Property 

    Private _ESTADO_FINAL As Decimal
    <Column(Name:="Estado final", Storage:="ESTADO_FINAL", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=1, Scale:=0)> _
    Public Property ESTADO_FINAL() As Decimal
        Get
            Return _ESTADO_FINAL
        End Get
        Set(ByVal Value As Decimal)
            _ESTADO_FINAL = Value
            OnPropertyChanged("ESTADO_FINAL")
        End Set
    End Property 

    Private _ESTADO_FINALOld As Decimal
    Public Property ESTADO_FINALOld() As Decimal
        Get
            Return _ESTADO_FINALOld
        End Get
        Set(ByVal Value As Decimal)
            _ESTADO_FINALOld = Value
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

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
