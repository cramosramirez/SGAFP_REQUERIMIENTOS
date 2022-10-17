''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.SOLIC_PRESELE_CURREC
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row SOLIC_PRESELE_CURREC en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	09/04/2019	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="SOLIC_PRESELE_CURREC")> Public Class SOLIC_PRESELE_CURREC
    Inherits entidadBase
    Implements IEquatable(Of SOLIC_PRESELE_CURREC), IComparable(Of SOLIC_PRESELE_CURREC)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_PRESELE_CURREC As Decimal, aID_SOLIC_PRESELEC As Decimal, aAPOYO_INSAFORP As Decimal, aANIO As Decimal, aNOMBRE_CURSO As String)
        Me._ID_PRESELE_CURREC = aID_PRESELE_CURREC
        Me._ID_SOLIC_PRESELEC = aID_SOLIC_PRESELEC
        Me._APOYO_INSAFORP = aAPOYO_INSAFORP
        Me._ANIO = aANIO
        Me._NOMBRE_CURSO = aNOMBRE_CURSO
    End Sub

    Public Function Equals1(ByVal other As SOLIC_PRESELE_CURREC) As Boolean Implements System.IEquatable(Of SOLIC_PRESELE_CURREC).Equals
        Return Me.ID_PRESELE_CURREC = other.ID_PRESELE_CURREC
    End Function

    Public Function CompareTo(ByVal other As SOLIC_PRESELE_CURREC) As Integer Implements System.IComparable(Of SOLIC_PRESELE_CURREC).CompareTo
        If Me.ID_PRESELE_CURREC > other.ID_PRESELE_CURREC Then Return 1
        If Me.ID_PRESELE_CURREC < other.ID_PRESELE_CURREC Then Return -1
        Return 0
    End Function


#Region " Properties "

    Private _ID_PRESELE_CURREC As Decimal
    <Column(Name:="Id presele currec", Storage:="ID_PRESELE_CURREC", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_PRESELE_CURREC() As Decimal
        Get
            Return _ID_PRESELE_CURREC
        End Get
        Set(ByVal Value As Decimal)
            _ID_PRESELE_CURREC = Value
            OnPropertyChanged("ID_PRESELE_CURREC")
        End Set
    End Property 

    Private _ID_SOLIC_PRESELEC As Decimal
    <Column(Name:="Id solic preselec", Storage:="ID_SOLIC_PRESELEC", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_SOLIC_PRESELEC() As Decimal
        Get
            Return _ID_SOLIC_PRESELEC
        End Get
        Set(ByVal Value As Decimal)
            _ID_SOLIC_PRESELEC = Value
            OnPropertyChanged("ID_SOLIC_PRESELEC")
        End Set
    End Property 

    Private _ID_SOLIC_PRESELECOld As Decimal
    Public Property ID_SOLIC_PRESELECOld() As Decimal
        Get
            Return _ID_SOLIC_PRESELECOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_SOLIC_PRESELECOld = Value
        End Set
    End Property 

    Private _fkID_SOLIC_PRESELEC As SOLICITUD_PRESELECCION_EC
    Public Property fkID_SOLIC_PRESELEC() As SOLICITUD_PRESELECCION_EC
        Get
            Return _fkID_SOLIC_PRESELEC
        End Get
        Set(ByVal Value As SOLICITUD_PRESELECCION_EC)
            _fkID_SOLIC_PRESELEC = Value
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

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
