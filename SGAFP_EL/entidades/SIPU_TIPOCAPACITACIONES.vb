''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.SIPU_TIPOCAPACITACIONES
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row SIPU_TIPOCAPACITACIONES en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	29/10/2013	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="SIPU_TIPOCAPACITACIONES")> Public Class SIPU_TIPOCAPACITACIONES
    Inherits entidadBase
    Implements IEquatable(Of SIPU_TIPOCAPACITACIONES), IComparable(Of SIPU_TIPOCAPACITACIONES)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aIDTIPOCAPACITACION As Decimal, aDESCRIPCION As String)
        Me._IDTIPOCAPACITACION = aIDTIPOCAPACITACION
        Me._DESCRIPCION = aDESCRIPCION
    End Sub

    Public Function Equals1(ByVal other As SIPU_TIPOCAPACITACIONES) As Boolean Implements System.IEquatable(Of SIPU_TIPOCAPACITACIONES).Equals
        Return Me.IDTIPOCAPACITACION = other.IDTIPOCAPACITACION
    End Function

    Public Function CompareTo(ByVal other As SIPU_TIPOCAPACITACIONES) As Integer Implements System.IComparable(Of SIPU_TIPOCAPACITACIONES).CompareTo
        If Me.IDTIPOCAPACITACION > other.IDTIPOCAPACITACION Then Return 1
        If Me.IDTIPOCAPACITACION < other.IDTIPOCAPACITACION Then Return -1
        Return 0
    End Function


#Region " Properties "

    Private _IDTIPOCAPACITACION As Decimal
    <Column(Name:="Idtipocapacitacion", Storage:="IDTIPOCAPACITACION", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property IDTIPOCAPACITACION() As Decimal
        Get
            Return _IDTIPOCAPACITACION
        End Get
        Set(ByVal Value As Decimal)
            _IDTIPOCAPACITACION = Value
            OnPropertyChanged("IDTIPOCAPACITACION")
        End Set
    End Property 

    Private _DESCRIPCION As String
    <Column(Name:="Descripcion", Storage:="DESCRIPCION", DbType:="VARCHAR2(50)", Id:=False), _
     DataObjectField(False, False, True, 50)> _
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

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
