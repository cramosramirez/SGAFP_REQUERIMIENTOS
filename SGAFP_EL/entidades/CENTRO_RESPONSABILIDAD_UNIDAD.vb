''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.CENTRO_RESPONSABILIDAD_UNIDAD
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row CENTRO_RESPONSABILIDAD_UNIDAD en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	05/10/2012	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="CENTRO_RESPONSABILIDAD_UNIDAD")> Public Class CENTRO_RESPONSABILIDAD_UNIDAD
    Inherits entidadBase
    Implements IEquatable(Of CENTRO_RESPONSABILIDAD_UNIDAD), IComparable(Of CENTRO_RESPONSABILIDAD_UNIDAD)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_CENTRO_RESPONSABILIDAD As Decimal, aID_UNIDAD_ORGANIZATIVA As Decimal, aUSERID As String, aLASTUPDATE As DateTime)
        Me._ID_CENTRO_RESPONSABILIDAD = aID_CENTRO_RESPONSABILIDAD
        Me._ID_UNIDAD_ORGANIZATIVA = aID_UNIDAD_ORGANIZATIVA
        Me._USERID = aUSERID
        Me._LASTUPDATE = aLASTUPDATE
    End Sub

    Public Function Equals1(ByVal other As CENTRO_RESPONSABILIDAD_UNIDAD) As Boolean Implements System.IEquatable(Of CENTRO_RESPONSABILIDAD_UNIDAD).Equals
        Return Me.ID_CENTRO_RESPONSABILIDAD = other.ID_CENTRO_RESPONSABILIDAD And Me.ID_UNIDAD_ORGANIZATIVA = other.ID_UNIDAD_ORGANIZATIVA
    End Function

    Public Function CompareTo(ByVal other As CENTRO_RESPONSABILIDAD_UNIDAD) As Integer Implements System.IComparable(Of CENTRO_RESPONSABILIDAD_UNIDAD).CompareTo
        If Me.ID_CENTRO_RESPONSABILIDAD > other.ID_CENTRO_RESPONSABILIDAD Then
            If Me.ID_UNIDAD_ORGANIZATIVA > other.ID_UNIDAD_ORGANIZATIVA Then Return 1
            If Me.ID_UNIDAD_ORGANIZATIVA < other.ID_UNIDAD_ORGANIZATIVA Then Return -1
        Else
            Return -1
        End If
        Return 0
    End Function


#Region " Properties "

    Private _ID_CENTRO_RESPONSABILIDAD As Decimal
    <Column(Name:="Id centro responsabilidad", Storage:="ID_CENTRO_RESPONSABILIDAD", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_CENTRO_RESPONSABILIDAD() As Decimal
        Get
            Return _ID_CENTRO_RESPONSABILIDAD
        End Get
        Set(ByVal Value As Decimal)
            _ID_CENTRO_RESPONSABILIDAD = Value
            OnPropertyChanged("ID_CENTRO_RESPONSABILIDAD")
        End Set
    End Property 

    Private _fkID_CENTRO_RESPONSABILIDAD As CENTRO_RESPONSABILIDAD
    Public Property fkID_CENTRO_RESPONSABILIDAD() As CENTRO_RESPONSABILIDAD
        Get
            Return _fkID_CENTRO_RESPONSABILIDAD
        End Get
        Set(ByVal Value As CENTRO_RESPONSABILIDAD)
            _fkID_CENTRO_RESPONSABILIDAD = Value
        End Set
    End Property 

    Private _ID_UNIDAD_ORGANIZATIVA As Decimal
    <Column(Name:="Id unidad organizativa", Storage:="ID_UNIDAD_ORGANIZATIVA", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_UNIDAD_ORGANIZATIVA() As Decimal
        Get
            Return _ID_UNIDAD_ORGANIZATIVA
        End Get
        Set(ByVal Value As Decimal)
            _ID_UNIDAD_ORGANIZATIVA = Value
            OnPropertyChanged("ID_UNIDAD_ORGANIZATIVA")
        End Set
    End Property 

    Private _fkID_UNIDAD_ORGANIZATIVA As UNIDAD_ORGANIZATIVA
    Public Property fkID_UNIDAD_ORGANIZATIVA() As UNIDAD_ORGANIZATIVA
        Get
            Return _fkID_UNIDAD_ORGANIZATIVA
        End Get
        Set(ByVal Value As UNIDAD_ORGANIZATIVA)
            _fkID_UNIDAD_ORGANIZATIVA = Value
        End Set
    End Property 

    Private _USERID As String
    <Column(Name:="Userid", Storage:="USERID", DbType:="VARCHAR2(256) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 256)> _
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
    <Column(Name:="Lastupdate", Storage:="LASTUPDATE", DbType:="DATE NOT NULL", Id:=False), _
     DataObjectField(False, False, False)> _
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
#End Region
#End Region
End Class
