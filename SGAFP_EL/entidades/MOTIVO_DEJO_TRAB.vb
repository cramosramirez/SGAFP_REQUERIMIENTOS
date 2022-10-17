''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.MOTIVO_DEJO_TRAB
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row MOTIVO_DEJO_TRAB en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	08/04/2019	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="MOTIVO_DEJO_TRAB")> Public Class MOTIVO_DEJO_TRAB
    Inherits entidadBase
    Implements IEquatable(Of MOTIVO_DEJO_TRAB), IComparable(Of MOTIVO_DEJO_TRAB)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_MOTIVO_DEJO_TRAB As Decimal, aNOMBRE_MOTIVO_DEJO_TRAB As String)
        Me._ID_MOTIVO_DEJO_TRAB = aID_MOTIVO_DEJO_TRAB
        Me._NOMBRE_MOTIVO_DEJO_TRAB = aNOMBRE_MOTIVO_DEJO_TRAB
    End Sub

    Public Function Equals1(ByVal other As MOTIVO_DEJO_TRAB) As Boolean Implements System.IEquatable(Of MOTIVO_DEJO_TRAB).Equals
        Return Me.ID_MOTIVO_DEJO_TRAB = other.ID_MOTIVO_DEJO_TRAB
    End Function

    Public Function CompareTo(ByVal other As MOTIVO_DEJO_TRAB) As Integer Implements System.IComparable(Of MOTIVO_DEJO_TRAB).CompareTo
        If Me.ID_MOTIVO_DEJO_TRAB > other.ID_MOTIVO_DEJO_TRAB Then Return 1
        If Me.ID_MOTIVO_DEJO_TRAB < other.ID_MOTIVO_DEJO_TRAB Then Return -1
        Return 0
    End Function


#Region " Properties "

    Private _ID_MOTIVO_DEJO_TRAB As Decimal
    <Column(Name:="Id motivo dejo trab", Storage:="ID_MOTIVO_DEJO_TRAB", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_MOTIVO_DEJO_TRAB() As Decimal
        Get
            Return _ID_MOTIVO_DEJO_TRAB
        End Get
        Set(ByVal Value As Decimal)
            _ID_MOTIVO_DEJO_TRAB = Value
            OnPropertyChanged("ID_MOTIVO_DEJO_TRAB")
        End Set
    End Property 

    Private _NOMBRE_MOTIVO_DEJO_TRAB As String
    <Column(Name:="Nombre motivo dejo trab", Storage:="NOMBRE_MOTIVO_DEJO_TRAB", DbType:="VARCHAR2(300) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 300)> _
    Public Property NOMBRE_MOTIVO_DEJO_TRAB() As String
        Get
            Return _NOMBRE_MOTIVO_DEJO_TRAB
        End Get
        Set(ByVal Value As String)
            _NOMBRE_MOTIVO_DEJO_TRAB = Value
            OnPropertyChanged("NOMBRE_MOTIVO_DEJO_TRAB")
        End Set
    End Property 

    Private _NOMBRE_MOTIVO_DEJO_TRABOld As String
    Public Property NOMBRE_MOTIVO_DEJO_TRABOld() As String
        Get
            Return _NOMBRE_MOTIVO_DEJO_TRABOld
        End Get
        Set(ByVal Value As String)
            _NOMBRE_MOTIVO_DEJO_TRABOld = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
