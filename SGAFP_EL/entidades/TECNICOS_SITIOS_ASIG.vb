''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.TECNICOS_SITIOS_ASIG
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite tener un registro de la tabla TECNICOS_SITIOS_ASIG en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	01/06/2010	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="TECNICOS_SITIOS_ASIG")> Public Class TECNICOS_SITIOS_ASIG
    Inherits entidadBase
    Implements IEquatable(Of TECNICOS_SITIOS_ASIG), IComparable(Of TECNICOS_SITIOS_ASIG)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aUSUARIO As String, aID_PROVEEDOR_AF As Decimal, aID_SITIO_CAPACITACION As Decimal, aUSERID As String, aLASTUPDATE As DateTime)
        Me._USUARIO = aUSUARIO
        Me._ID_PROVEEDOR_AF = aID_PROVEEDOR_AF
        Me._ID_SITIO_CAPACITACION = aID_SITIO_CAPACITACION
        Me._USERID = aUSERID
        Me._LASTUPDATE = aLASTUPDATE
    End Sub

    Public Function Equals1(ByVal other As TECNICOS_SITIOS_ASIG) As Boolean Implements System.IEquatable(Of TECNICOS_SITIOS_ASIG).Equals
        Return Me.USUARIO = other.USUARIO And Me.ID_PROVEEDOR_AF = other.ID_PROVEEDOR_AF And Me.ID_SITIO_CAPACITACION = other.ID_SITIO_CAPACITACION
    End Function

    Public Function CompareTo(ByVal other As TECNICOS_SITIOS_ASIG) As Integer Implements System.IComparable(Of TECNICOS_SITIOS_ASIG).CompareTo
        If Me.USUARIO > other.USUARIO Then
            If Me.ID_PROVEEDOR_AF > other.ID_PROVEEDOR_AF Then
                If Me.ID_SITIO_CAPACITACION > other.ID_SITIO_CAPACITACION Then Return 1
                If Me.ID_SITIO_CAPACITACION < other.ID_SITIO_CAPACITACION Then Return -1
            Else
                Return -1
            End If
        Else
            Return -1
        End If
        Return 0
    End Function


#Region " Propiedades "

    Private _USUARIO As String
    <Column(Name:="Usuario", Storage:="USUARIO", DbType:="VARCHAR2(100) NOT NULL", Id:=True), _
     DataObjectField(True, False, False, 100)> _
    Public Property USUARIO() As String
        Get
            Return _USUARIO
        End Get
        Set(ByVal Value As String)
            _USUARIO = Value
            OnPropertyChanged("USUARIO")
        End Set
    End Property 

    Private _fkUSUARIO As USUARIO
    Public Property fkUSUARIO() As USUARIO
        Get
            Return _fkUSUARIO
        End Get
        Set(ByVal Value As USUARIO)
            _fkUSUARIO = Value
        End Set
    End Property 

    Private _ID_PROVEEDOR_AF As Decimal
    <Column(Name:="Id proveedor af", Storage:="ID_PROVEEDOR_AF", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_PROVEEDOR_AF() As Decimal
        Get
            Return _ID_PROVEEDOR_AF
        End Get
        Set(ByVal Value As Decimal)
            _ID_PROVEEDOR_AF = Value
            OnPropertyChanged("ID_PROVEEDOR_AF")
        End Set
    End Property 

    Private _fkID_PROVEEDOR_AF As PROVEEDOR_AF
    Public Property fkID_PROVEEDOR_AF() As PROVEEDOR_AF
        Get
            Return _fkID_PROVEEDOR_AF
        End Get
        Set(ByVal Value As PROVEEDOR_AF)
            _fkID_PROVEEDOR_AF = Value
        End Set
    End Property 

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
