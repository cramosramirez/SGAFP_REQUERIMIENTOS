''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.SITIO_CAPACITACION_EJERCICIO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row SITIO_CAPACITACION_EJERCICIO en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	25/09/2012	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="SITIO_CAPACITACION_EJERCICIO")> Public Class SITIO_CAPACITACION_EJERCICIO
    Inherits entidadBase
    Implements IEquatable(Of SITIO_CAPACITACION_EJERCICIO), IComparable(Of SITIO_CAPACITACION_EJERCICIO)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_SITIO_CAPACITACION As Decimal, aID_EJERCICIO As String)
        Me._ID_SITIO_CAPACITACION = aID_SITIO_CAPACITACION
        Me._ID_EJERCICIO = aID_EJERCICIO
    End Sub

    Public Function Equals1(ByVal other As SITIO_CAPACITACION_EJERCICIO) As Boolean Implements System.IEquatable(Of SITIO_CAPACITACION_EJERCICIO).Equals
        Return Me.ID_SITIO_CAPACITACION = other.ID_SITIO_CAPACITACION And Me.ID_EJERCICIO = other.ID_EJERCICIO
    End Function

    Public Function CompareTo(ByVal other As SITIO_CAPACITACION_EJERCICIO) As Integer Implements System.IComparable(Of SITIO_CAPACITACION_EJERCICIO).CompareTo
        If Me.ID_SITIO_CAPACITACION > other.ID_SITIO_CAPACITACION Then
            If Me.ID_EJERCICIO > other.ID_EJERCICIO Then Return 1
            If Me.ID_EJERCICIO < other.ID_EJERCICIO Then Return -1
        Else
            Return -1
        End If
        Return 0
    End Function


#Region " Properties "

    Private _ID_SITIO_CAPACITACION As Decimal
    <Column(Name:="Id sitio capacitacion", Storage:="ID_SITIO_CAPACITACION", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_SITIO_CAPACITACION() As Decimal
        Get
            Return _ID_SITIO_CAPACITACION
        End Get
        Set(ByVal Value As Decimal)
            _ID_SITIO_CAPACITACION = Value
            OnPropertyChanged("ID_SITIO_CAPACITACION")
        End Set
    End Property 

    Private _fkID_SITIO_CAPACITACION As SITIO_CAPACITACION
    Public Property fkID_SITIO_CAPACITACION() As SITIO_CAPACITACION
        Get
            Return _fkID_SITIO_CAPACITACION
        End Get
        Set(ByVal Value As SITIO_CAPACITACION)
            _fkID_SITIO_CAPACITACION = Value
        End Set
    End Property 

    Private _ID_EJERCICIO As String
    <Column(Name:="Id ejercicio", Storage:="ID_EJERCICIO", DbType:="CHAR(4) NOT NULL", Id:=True), _
     DataObjectField(True, False, False, 4)> _
    Public Property ID_EJERCICIO() As String
        Get
            Return _ID_EJERCICIO
        End Get
        Set(ByVal Value As String)
            _ID_EJERCICIO = Value
            OnPropertyChanged("ID_EJERCICIO")
        End Set
    End Property 

#End Region

#Region " Relaciones "
    Private _OFERTA_FORMATIVA_SITIOSITIO_CAPACITACION_EJERCICIO As ListaOFERTA_FORMATIVA_SITIO
    Public Property OFERTA_FORMATIVA_SITIOSITIO_CAPACITACION_EJERCICIO() As ListaOFERTA_FORMATIVA_SITIO
        Get
            Return _OFERTA_FORMATIVA_SITIOSITIO_CAPACITACION_EJERCICIO
        End Get
        Set(ByVal Value As ListaOFERTA_FORMATIVA_SITIO)
            _OFERTA_FORMATIVA_SITIOSITIO_CAPACITACION_EJERCICIO = Value
        End Set
    End Property 

#End Region
#End Region
End Class
