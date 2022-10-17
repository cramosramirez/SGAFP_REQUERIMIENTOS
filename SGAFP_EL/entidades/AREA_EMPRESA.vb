''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.AREA_EMPRESA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row AREA_EMPRESA en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	08/04/2019	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="AREA_EMPRESA")> Public Class AREA_EMPRESA
    Inherits entidadBase
    Implements IEquatable(Of AREA_EMPRESA), IComparable(Of AREA_EMPRESA)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_AREA_EMPRESA As Decimal, aNOMBRE_AREA_EMPRESA As String)
        Me._ID_AREA_EMPRESA = aID_AREA_EMPRESA
        Me._NOMBRE_AREA_EMPRESA = aNOMBRE_AREA_EMPRESA
    End Sub

    Public Function Equals1(ByVal other As AREA_EMPRESA) As Boolean Implements System.IEquatable(Of AREA_EMPRESA).Equals
        Return Me.ID_AREA_EMPRESA = other.ID_AREA_EMPRESA
    End Function

    Public Function CompareTo(ByVal other As AREA_EMPRESA) As Integer Implements System.IComparable(Of AREA_EMPRESA).CompareTo
        If Me.ID_AREA_EMPRESA > other.ID_AREA_EMPRESA Then Return 1
        If Me.ID_AREA_EMPRESA < other.ID_AREA_EMPRESA Then Return -1
        Return 0
    End Function


#Region " Properties "

    Private _ID_AREA_EMPRESA As Decimal
    <Column(Name:="Id area empresa", Storage:="ID_AREA_EMPRESA", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_AREA_EMPRESA() As Decimal
        Get
            Return _ID_AREA_EMPRESA
        End Get
        Set(ByVal Value As Decimal)
            _ID_AREA_EMPRESA = Value
            OnPropertyChanged("ID_AREA_EMPRESA")
        End Set
    End Property 

    Private _NOMBRE_AREA_EMPRESA As String
    <Column(Name:="Nombre area empresa", Storage:="NOMBRE_AREA_EMPRESA", DbType:="VARCHAR2(300) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 300)> _
    Public Property NOMBRE_AREA_EMPRESA() As String
        Get
            Return _NOMBRE_AREA_EMPRESA
        End Get
        Set(ByVal Value As String)
            _NOMBRE_AREA_EMPRESA = Value
            OnPropertyChanged("NOMBRE_AREA_EMPRESA")
        End Set
    End Property 

    Private _NOMBRE_AREA_EMPRESAOld As String
    Public Property NOMBRE_AREA_EMPRESAOld() As String
        Get
            Return _NOMBRE_AREA_EMPRESAOld
        End Get
        Set(ByVal Value As String)
            _NOMBRE_AREA_EMPRESAOld = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
