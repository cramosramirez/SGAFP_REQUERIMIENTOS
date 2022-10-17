''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.SOLIC_CURSOS_RECIBIDOS
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row SOLIC_CURSOS_RECIBIDOS en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	19/01/2011	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="SOLIC_CURSOS_RECIBIDOS")> Public Class SOLIC_CURSOS_RECIBIDOS
    Inherits entidadBase
    Implements IEquatable(Of SOLIC_CURSOS_RECIBIDOS), IComparable(Of SOLIC_CURSOS_RECIBIDOS)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_CURSO_RECIBIDO As Decimal, aID_SOLICITUD As Decimal, aAPOYO_INSAFORP As Decimal, aANIO As Decimal, aNOMBRE_CURSO As String, aBENEFICIO_CURSO As Decimal)
        Me._ID_CURSO_RECIBIDO = aID_CURSO_RECIBIDO
        Me._ID_SOLICITUD = aID_SOLICITUD
        Me._APOYO_INSAFORP = aAPOYO_INSAFORP
        Me._ANIO = aANIO
        Me._NOMBRE_CURSO = aNOMBRE_CURSO
        Me._BENEFICIO_CURSO = aBENEFICIO_CURSO
    End Sub

    Public Function Equals1(ByVal other As SOLIC_CURSOS_RECIBIDOS) As Boolean Implements System.IEquatable(Of SOLIC_CURSOS_RECIBIDOS).Equals
        Return Me.ID_CURSO_RECIBIDO = other.ID_CURSO_RECIBIDO
    End Function

    Public Function CompareTo(ByVal other As SOLIC_CURSOS_RECIBIDOS) As Integer Implements System.IComparable(Of SOLIC_CURSOS_RECIBIDOS).CompareTo
        If Me.ID_CURSO_RECIBIDO > other.ID_CURSO_RECIBIDO Then Return 1
        If Me.ID_CURSO_RECIBIDO < other.ID_CURSO_RECIBIDO Then Return -1
        Return 0
    End Function


#Region " Properties "

    Private _ID_CURSO_RECIBIDO As Decimal
    <Column(Name:="Id curso recibido", Storage:="ID_CURSO_RECIBIDO", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_CURSO_RECIBIDO() As Decimal
        Get
            Return _ID_CURSO_RECIBIDO
        End Get
        Set(ByVal Value As Decimal)
            _ID_CURSO_RECIBIDO = Value
            OnPropertyChanged("ID_CURSO_RECIBIDO")
        End Set
    End Property 

    Private _ID_SOLICITUD As Decimal
    <Column(Name:="Id solicitud", Storage:="ID_SOLICITUD", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_SOLICITUD() As Decimal
        Get
            Return _ID_SOLICITUD
        End Get
        Set(ByVal Value As Decimal)
            _ID_SOLICITUD = Value
            OnPropertyChanged("ID_SOLICITUD")
        End Set
    End Property 

    Private _ID_SOLICITUDOld As Decimal
    Public Property ID_SOLICITUDOld() As Decimal
        Get
            Return _ID_SOLICITUDOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_SOLICITUDOld = Value
        End Set
    End Property 

    Private _fkID_SOLICITUD As SOLICITUD_INSCRIPCION_AF
    Public Property fkID_SOLICITUD() As SOLICITUD_INSCRIPCION_AF
        Get
            Return _fkID_SOLICITUD
        End Get
        Set(ByVal Value As SOLICITUD_INSCRIPCION_AF)
            _fkID_SOLICITUD = Value
        End Set
    End Property 

    Private _APOYO_INSAFORP As Decimal
    <Column(Name:="Apoyo insaforp", Storage:="APOYO_INSAFORP", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=1, Scale:=0)> _
    Public Property APOYO_INSAFORP() As Decimal
        Get
            Return _APOYO_INSAFORP
        End Get
        Set(ByVal Value As Decimal)
            _APOYO_INSAFORP = Value
            OnPropertyChanged("APOYO_INSAFORP")
        End Set
    End Property 

    Private _APOYO_INSAFORPOld As Decimal
    Public Property APOYO_INSAFORPOld() As Decimal
        Get
            Return _APOYO_INSAFORPOld
        End Get
        Set(ByVal Value As Decimal)
            _APOYO_INSAFORPOld = Value
        End Set
    End Property 

    Private _ANIO As Decimal
    <Column(Name:="Anio", Storage:="ANIO", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=4, Scale:=0)> _
    Public Property ANIO() As Decimal
        Get
            Return _ANIO
        End Get
        Set(ByVal Value As Decimal)
            _ANIO = Value
            OnPropertyChanged("ANIO")
        End Set
    End Property 

    Private _ANIOOld As Decimal
    Public Property ANIOOld() As Decimal
        Get
            Return _ANIOOld
        End Get
        Set(ByVal Value As Decimal)
            _ANIOOld = Value
        End Set
    End Property 

    Private _NOMBRE_CURSO As String
    <Column(Name:="Nombre curso", Storage:="NOMBRE_CURSO", DbType:="VARCHAR2(150)", Id:=False), _
     DataObjectField(False, False, True, 150)> _
    Public Property NOMBRE_CURSO() As String
        Get
            Return _NOMBRE_CURSO
        End Get
        Set(ByVal Value As String)
            _NOMBRE_CURSO = Value
            OnPropertyChanged("NOMBRE_CURSO")
        End Set
    End Property 

    Private _NOMBRE_CURSOOld As String
    Public Property NOMBRE_CURSOOld() As String
        Get
            Return _NOMBRE_CURSOOld
        End Get
        Set(ByVal Value As String)
            _NOMBRE_CURSOOld = Value
        End Set
    End Property 

    Private _BENEFICIO_CURSO As Decimal
    <Column(Name:="Beneficio curso", Storage:="BENEFICIO_CURSO", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=1, Scale:=0)> _
    Public Property BENEFICIO_CURSO() As Decimal
        Get
            Return _BENEFICIO_CURSO
        End Get
        Set(ByVal Value As Decimal)
            _BENEFICIO_CURSO = Value
            OnPropertyChanged("BENEFICIO_CURSO")
        End Set
    End Property 

    Private _BENEFICIO_CURSOOld As Decimal
    Public Property BENEFICIO_CURSOOld() As Decimal
        Get
            Return _BENEFICIO_CURSOOld
        End Get
        Set(ByVal Value As Decimal)
            _BENEFICIO_CURSOOld = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
