''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.INGRESO_MES
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row INGRESO_MES en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	08/04/2019	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="INGRESO_MES")> Public Class INGRESO_MES
    Inherits entidadBase
    Implements IEquatable(Of INGRESO_MES), IComparable(Of INGRESO_MES)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_INGRESO_MES As Decimal, aNOMBRE_ING As String)
        Me._ID_INGRESO_MES = aID_INGRESO_MES
        Me._NOMBRE_ING = aNOMBRE_ING
    End Sub

    Public Function Equals1(ByVal other As INGRESO_MES) As Boolean Implements System.IEquatable(Of INGRESO_MES).Equals
        Return Me.ID_INGRESO_MES = other.ID_INGRESO_MES
    End Function

    Public Function CompareTo(ByVal other As INGRESO_MES) As Integer Implements System.IComparable(Of INGRESO_MES).CompareTo
        If Me.ID_INGRESO_MES > other.ID_INGRESO_MES Then Return 1
        If Me.ID_INGRESO_MES < other.ID_INGRESO_MES Then Return -1
        Return 0
    End Function


#Region " Properties "

    Private _ID_INGRESO_MES As Decimal
    <Column(Name:="Id ingreso mes", Storage:="ID_INGRESO_MES", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_INGRESO_MES() As Decimal
        Get
            Return _ID_INGRESO_MES
        End Get
        Set(ByVal Value As Decimal)
            _ID_INGRESO_MES = Value
            OnPropertyChanged("ID_INGRESO_MES")
        End Set
    End Property 

    Private _NOMBRE_ING As String
    <Column(Name:="Nombre ing", Storage:="NOMBRE_ING", DbType:="VARCHAR2(100) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 100)> _
    Public Property NOMBRE_ING() As String
        Get
            Return _NOMBRE_ING
        End Get
        Set(ByVal Value As String)
            _NOMBRE_ING = Value
            OnPropertyChanged("NOMBRE_ING")
        End Set
    End Property 

    Private _NOMBRE_INGOld As String
    Public Property NOMBRE_INGOld() As String
        Get
            Return _NOMBRE_INGOld
        End Get
        Set(ByVal Value As String)
            _NOMBRE_INGOld = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
