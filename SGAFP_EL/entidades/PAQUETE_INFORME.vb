''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.PAQUETE_INFORME
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite tener un registro de la tabla PAQUETE_INFORME en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.6.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	26/08/2010	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="PAQUETE_INFORME")> Public Class PAQUETE_INFORME
    Inherits entidadBase
    Implements IEquatable(Of PAQUETE_INFORME), IComparable(Of PAQUETE_INFORME)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(ByVal aID_PAQUETE As Decimal, ByVal aFECHA As DateTime, ByVal aCOMENTARIOS As String, ByVal aLASTUPDATE As DateTime, ByVal aUSERID As String, ByVal aUSUARIO_TECNICO As String)
        Me._ID_PAQUETE = aID_PAQUETE
        Me._FECHA = aFECHA
        Me._COMENTARIOS = aCOMENTARIOS
        Me._LASTUPDATE = aLASTUPDATE
        Me._USERID = aUSERID
        Me._USUARIO_TECNICO = aUSUARIO_TECNICO
    End Sub

    Public Function Equals1(ByVal other As PAQUETE_INFORME) As Boolean Implements System.IEquatable(Of PAQUETE_INFORME).Equals
        Return Me.ID_PAQUETE = other.ID_PAQUETE
    End Function

    Public Function CompareTo(ByVal other As PAQUETE_INFORME) As Integer Implements System.IComparable(Of PAQUETE_INFORME).CompareTo
        If Me.ID_PAQUETE > other.ID_PAQUETE Then Return 1
        If Me.ID_PAQUETE < other.ID_PAQUETE Then Return -1
        Return 0
    End Function


#Region " Propiedades "

    Private _ID_PAQUETE As Decimal
    <Column(Name:="Id paquete", Storage:="ID_PAQUETE", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_PAQUETE() As Decimal
        Get
            Return _ID_PAQUETE
        End Get
        Set(ByVal Value As Decimal)
            _ID_PAQUETE = Value
            OnPropertyChanged("ID_PAQUETE")
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

    Private _COMENTARIOS As String
    <Column(Name:="Comentarios", Storage:="COMENTARIOS", DbType:="VARCHAR2(255)", Id:=False), _
     DataObjectField(False, False, True, 255)> _
    Public Property COMENTARIOS() As String
        Get
            Return _COMENTARIOS
        End Get
        Set(ByVal Value As String)
            _COMENTARIOS = Value
            OnPropertyChanged("COMENTARIOS")
        End Set
    End Property 

    Private _COMENTARIOSOld As String
    Public Property COMENTARIOSOld() As String
        Get
            Return _COMENTARIOSOld
        End Get
        Set(ByVal Value As String)
            _COMENTARIOSOld = Value
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


    Private _USUARIO_TECNICO As String
    <Column(Name:="Usuario_Tecnico", Storage:="USUARIO_TECNICO", DbType:="VARCHAR2(256)", Id:=False), _
     DataObjectField(False, False, True, 256)> _
    Public Property USUARIO_TECNICO() As String
        Get
            Return _USUARIO_TECNICO
        End Get
        Set(ByVal Value As String)
            _USUARIO_TECNICO = Value
            OnPropertyChanged("USUARIO_TECNICO")
        End Set
    End Property

    Private _USUARIO_TECNICOOld As String
    Public Property USUARIO_TECNICOOld() As String
        Get
            Return _USUARIO_TECNICOOld
        End Get
        Set(ByVal Value As String)
            _USUARIO_TECNICOOld = Value
        End Set
    End Property
#End Region

#Region " Relaciones "
    Private _PAQUETE_INFORME_DETPAQUETE_INFORME As ListaPAQUETE_INFORME_DET
    Public Property PAQUETE_INFORME_DETPAQUETE_INFORME() As ListaPAQUETE_INFORME_DET
        Get
            Return _PAQUETE_INFORME_DETPAQUETE_INFORME
        End Get
        Set(ByVal Value As ListaPAQUETE_INFORME_DET)
            _PAQUETE_INFORME_DETPAQUETE_INFORME = Value
        End Set
    End Property 

#End Region
#End Region
End Class
