''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.MODALIDAD_DE_FORMACION
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row MODALIDAD_DE_FORMACION en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	05/10/2012	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="MODALIDAD_DE_FORMACION")> Public Class MODALIDAD_DE_FORMACION
    Inherits entidadBase
    Implements IEquatable(Of MODALIDAD_DE_FORMACION), IComparable(Of MODALIDAD_DE_FORMACION)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_MODALIDAD_FORMACION As Decimal, aMODALIDAD_FORMACION As String, aNOTAS As String)
        Me._ID_MODALIDAD_FORMACION = aID_MODALIDAD_FORMACION
        Me._MODALIDAD_FORMACION = aMODALIDAD_FORMACION
        Me._NOTAS = aNOTAS
    End Sub

    Public Function Equals1(ByVal other As MODALIDAD_DE_FORMACION) As Boolean Implements System.IEquatable(Of MODALIDAD_DE_FORMACION).Equals
        Return Me.ID_MODALIDAD_FORMACION = other.ID_MODALIDAD_FORMACION
    End Function

    Public Function CompareTo(ByVal other As MODALIDAD_DE_FORMACION) As Integer Implements System.IComparable(Of MODALIDAD_DE_FORMACION).CompareTo
        If Me.ID_MODALIDAD_FORMACION > other.ID_MODALIDAD_FORMACION Then Return 1
        If Me.ID_MODALIDAD_FORMACION < other.ID_MODALIDAD_FORMACION Then Return -1
        Return 0
    End Function


#Region " Properties "

    Private _ID_MODALIDAD_FORMACION As Decimal
    <Column(Name:="Id modalidad formacion", Storage:="ID_MODALIDAD_FORMACION", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_MODALIDAD_FORMACION() As Decimal
        Get
            Return _ID_MODALIDAD_FORMACION
        End Get
        Set(ByVal Value As Decimal)
            _ID_MODALIDAD_FORMACION = Value
            OnPropertyChanged("ID_MODALIDAD_FORMACION")
        End Set
    End Property 

    Private _MODALIDAD_FORMACION As String
    <Column(Name:="Modalidad formacion", Storage:="MODALIDAD_FORMACION", DbType:="VARCHAR2(100)", Id:=False), _
     DataObjectField(False, False, True, 100)> _
    Public Property MODALIDAD_FORMACION() As String
        Get
            Return _MODALIDAD_FORMACION
        End Get
        Set(ByVal Value As String)
            _MODALIDAD_FORMACION = Value
            OnPropertyChanged("MODALIDAD_FORMACION")
        End Set
    End Property 

    Private _MODALIDAD_FORMACIONOld As String
    Public Property MODALIDAD_FORMACIONOld() As String
        Get
            Return _MODALIDAD_FORMACIONOld
        End Get
        Set(ByVal Value As String)
            _MODALIDAD_FORMACIONOld = Value
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
