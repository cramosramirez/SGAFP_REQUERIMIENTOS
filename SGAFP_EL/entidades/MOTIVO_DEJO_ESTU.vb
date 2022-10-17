''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.MOTIVO_DEJO_ESTU
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row MOTIVO_DEJO_ESTU en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	08/04/2019	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="MOTIVO_DEJO_ESTU")> Public Class MOTIVO_DEJO_ESTU
    Inherits entidadBase
    Implements IEquatable(Of MOTIVO_DEJO_ESTU), IComparable(Of MOTIVO_DEJO_ESTU)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_MOTIVO_DEJO_ESTU As Decimal, aNOMBRE_MOTIVO As String)
        Me._ID_MOTIVO_DEJO_ESTU = aID_MOTIVO_DEJO_ESTU
        Me._NOMBRE_MOTIVO = aNOMBRE_MOTIVO
    End Sub

    Public Function Equals1(ByVal other As MOTIVO_DEJO_ESTU) As Boolean Implements System.IEquatable(Of MOTIVO_DEJO_ESTU).Equals
        Return Me.ID_MOTIVO_DEJO_ESTU = other.ID_MOTIVO_DEJO_ESTU
    End Function

    Public Function CompareTo(ByVal other As MOTIVO_DEJO_ESTU) As Integer Implements System.IComparable(Of MOTIVO_DEJO_ESTU).CompareTo
        If Me.ID_MOTIVO_DEJO_ESTU > other.ID_MOTIVO_DEJO_ESTU Then Return 1
        If Me.ID_MOTIVO_DEJO_ESTU < other.ID_MOTIVO_DEJO_ESTU Then Return -1
        Return 0
    End Function


#Region " Properties "

    Private _ID_MOTIVO_DEJO_ESTU As Decimal
    <Column(Name:="Id motivo dejo estu", Storage:="ID_MOTIVO_DEJO_ESTU", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_MOTIVO_DEJO_ESTU() As Decimal
        Get
            Return _ID_MOTIVO_DEJO_ESTU
        End Get
        Set(ByVal Value As Decimal)
            _ID_MOTIVO_DEJO_ESTU = Value
            OnPropertyChanged("ID_MOTIVO_DEJO_ESTU")
        End Set
    End Property 

    Private _NOMBRE_MOTIVO As String
    <Column(Name:="Nombre motivo", Storage:="NOMBRE_MOTIVO", DbType:="VARCHAR2(100) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 100)> _
    Public Property NOMBRE_MOTIVO() As String
        Get
            Return _NOMBRE_MOTIVO
        End Get
        Set(ByVal Value As String)
            _NOMBRE_MOTIVO = Value
            OnPropertyChanged("NOMBRE_MOTIVO")
        End Set
    End Property 

    Private _NOMBRE_MOTIVOOld As String
    Public Property NOMBRE_MOTIVOOld() As String
        Get
            Return _NOMBRE_MOTIVOOld
        End Get
        Set(ByVal Value As String)
            _NOMBRE_MOTIVOOld = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
