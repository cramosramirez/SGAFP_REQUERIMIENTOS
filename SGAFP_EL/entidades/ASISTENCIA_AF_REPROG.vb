''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.ASISTENCIA_AF_REPROG
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row ASISTENCIA_AF_REPROG en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	04/03/2011	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="ASISTENCIA_AF_REPROG")> Public Class ASISTENCIA_AF_REPROG
    Inherits entidadBase
    Implements IEquatable(Of ASISTENCIA_AF_REPROG), IComparable(Of ASISTENCIA_AF_REPROG)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_ASISTENCIA_AF As Decimal, aID_ACCION_FORMATIVA_REPROG As Decimal, aFECHA As DateTime, aCANTIDAD_HORAS As Decimal, aINSTRUCTOR As String, aNOTAS As String, aUSERID As String, aLASTUPDATE As DateTime)
        Me._ID_ASISTENCIA_AF = aID_ASISTENCIA_AF
        Me._ID_ACCION_FORMATIVA_REPROG = aID_ACCION_FORMATIVA_REPROG
        Me._FECHA = aFECHA
        Me._CANTIDAD_HORAS = aCANTIDAD_HORAS
        Me._INSTRUCTOR = aINSTRUCTOR
        Me._NOTAS = aNOTAS
        Me._USERID = aUSERID
        Me._LASTUPDATE = aLASTUPDATE
    End Sub

    Public Function Equals1(ByVal other As ASISTENCIA_AF_REPROG) As Boolean Implements System.IEquatable(Of ASISTENCIA_AF_REPROG).Equals
        Return Me.ID_ASISTENCIA_AF = other.ID_ASISTENCIA_AF
    End Function

    Public Function CompareTo(ByVal other As ASISTENCIA_AF_REPROG) As Integer Implements System.IComparable(Of ASISTENCIA_AF_REPROG).CompareTo
        If Me.ID_ASISTENCIA_AF > other.ID_ASISTENCIA_AF Then Return 1
        If Me.ID_ASISTENCIA_AF < other.ID_ASISTENCIA_AF Then Return -1
        Return 0
    End Function


#Region " Properties "

    Private _ID_ASISTENCIA_AF As Decimal
    <Column(Name:="Id asistencia af", Storage:="ID_ASISTENCIA_AF", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_ASISTENCIA_AF() As Decimal
        Get
            Return _ID_ASISTENCIA_AF
        End Get
        Set(ByVal Value As Decimal)
            _ID_ASISTENCIA_AF = Value
            OnPropertyChanged("ID_ASISTENCIA_AF")
        End Set
    End Property 

    Private _ID_ACCION_FORMATIVA_REPROG As Decimal
    <Column(Name:="Id accion formativa reprog", Storage:="ID_ACCION_FORMATIVA_REPROG", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_ACCION_FORMATIVA_REPROG() As Decimal
        Get
            Return _ID_ACCION_FORMATIVA_REPROG
        End Get
        Set(ByVal Value As Decimal)
            _ID_ACCION_FORMATIVA_REPROG = Value
            OnPropertyChanged("ID_ACCION_FORMATIVA_REPROG")
        End Set
    End Property 

    Private _ID_ACCION_FORMATIVA_REPROGOld As Decimal
    Public Property ID_ACCION_FORMATIVA_REPROGOld() As Decimal
        Get
            Return _ID_ACCION_FORMATIVA_REPROGOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_ACCION_FORMATIVA_REPROGOld = Value
        End Set
    End Property 

    Private _fkID_ACCION_FORMATIVA_REPROG As ACCION_FORMATIVA_REPROG
    Public Property fkID_ACCION_FORMATIVA_REPROG() As ACCION_FORMATIVA_REPROG
        Get
            Return _fkID_ACCION_FORMATIVA_REPROG
        End Get
        Set(ByVal Value As ACCION_FORMATIVA_REPROG)
            _fkID_ACCION_FORMATIVA_REPROG = Value
        End Set
    End Property 

    Private _FECHA As DateTime
    <Column(Name:="Fecha", Storage:="FECHA", DbType:="DATE", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property FECHA() As DateTime
        Get
            Return _FECHA
        End Get
        Set(ByVal Value As DateTime)
            _FECHA = Value
            OnPropertyChanged("FECHA")
        End Set
    End Property 

    Private _FECHAOld As DateTime
    Public Property FECHAOld() As DateTime
        Get
            Return _FECHAOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHAOld = Value
        End Set
    End Property 

    Private _CANTIDAD_HORAS As Decimal
    <Column(Name:="Cantidad horas", Storage:="CANTIDAD_HORAS", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=4, Scale:=0)> _
    Public Property CANTIDAD_HORAS() As Decimal
        Get
            Return _CANTIDAD_HORAS
        End Get
        Set(ByVal Value As Decimal)
            _CANTIDAD_HORAS = Value
            OnPropertyChanged("CANTIDAD_HORAS")
        End Set
    End Property 

    Private _CANTIDAD_HORASOld As Decimal
    Public Property CANTIDAD_HORASOld() As Decimal
        Get
            Return _CANTIDAD_HORASOld
        End Get
        Set(ByVal Value As Decimal)
            _CANTIDAD_HORASOld = Value
        End Set
    End Property 

    Private _INSTRUCTOR As String
    <Column(Name:="Instructor", Storage:="INSTRUCTOR", DbType:="VARCHAR2(255)", Id:=False), _
     DataObjectField(False, False, True, 255)> _
    Public Property INSTRUCTOR() As String
        Get
            Return _INSTRUCTOR
        End Get
        Set(ByVal Value As String)
            _INSTRUCTOR = Value
            OnPropertyChanged("INSTRUCTOR")
        End Set
    End Property 

    Private _INSTRUCTOROld As String
    Public Property INSTRUCTOROld() As String
        Get
            Return _INSTRUCTOROld
        End Get
        Set(ByVal Value As String)
            _INSTRUCTOROld = Value
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

    Private _USERID As String
    <Column(Name:="Userid", Storage:="USERID", DbType:="VARCHAR2(256)", Id:=False), _
     DataObjectField(False, False, True, 256)> _
    Public Property USERID() As String
        Get
            Return _USERID
        End Get
        Set(ByVal Value As String)
            _USERID = Value
            OnPropertyChanged("USERID")
        End Set
    End Property 

    Private _USERIDOld As String
    Public Property USERIDOld() As String
        Get
            Return _USERIDOld
        End Get
        Set(ByVal Value As String)
            _USERIDOld = Value
        End Set
    End Property 

    Private _LASTUPDATE As DateTime
    <Column(Name:="Lastupdate", Storage:="LASTUPDATE", DbType:="DATE", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property LASTUPDATE() As DateTime
        Get
            Return _LASTUPDATE
        End Get
        Set(ByVal Value As DateTime)
            _LASTUPDATE = Value
            OnPropertyChanged("LASTUPDATE")
        End Set
    End Property 

    Private _LASTUPDATEOld As DateTime
    Public Property LASTUPDATEOld() As DateTime
        Get
            Return _LASTUPDATEOld
        End Get
        Set(ByVal Value As DateTime)
            _LASTUPDATEOld = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
    Private _ASISTENCIA_AF_HORARIO_REPROGASISTENCIA_AF_REPROG As ListaASISTENCIA_AF_HORARIO_REPROG
    Public Property ASISTENCIA_AF_HORARIO_REPROGASISTENCIA_AF_REPROG() As ListaASISTENCIA_AF_HORARIO_REPROG
        Get
            Return _ASISTENCIA_AF_HORARIO_REPROGASISTENCIA_AF_REPROG
        End Get
        Set(ByVal Value As ListaASISTENCIA_AF_HORARIO_REPROG)
            _ASISTENCIA_AF_HORARIO_REPROGASISTENCIA_AF_REPROG = Value
        End Set
    End Property 

#End Region
#End Region
End Class
