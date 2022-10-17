''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.TIPO_CONTRATACION
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row TIPO_CONTRATACION en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	11/09/2013	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="TIPO_CONTRATACION")> Public Class TIPO_CONTRATACION
    Inherits entidadBase
    Implements IEquatable(Of TIPO_CONTRATACION), IComparable(Of TIPO_CONTRATACION)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_TIPO_CONTRA As Decimal, aNOM_TIPO_CONTRA As String, aUSUARIO_CREACION As String, aFECHA_CREACION As DateTime, aUSERID As String, aLASTUPDATE As DateTime)
        Me._ID_TIPO_CONTRA = aID_TIPO_CONTRA
        Me._NOM_TIPO_CONTRA = aNOM_TIPO_CONTRA
        Me._USUARIO_CREACION = aUSUARIO_CREACION
        Me._FECHA_CREACION = aFECHA_CREACION
        Me._USERID = aUSERID
        Me._LASTUPDATE = aLASTUPDATE
    End Sub

    Public Function Equals1(ByVal other As TIPO_CONTRATACION) As Boolean Implements System.IEquatable(Of TIPO_CONTRATACION).Equals
        Return Me.ID_TIPO_CONTRA = other.ID_TIPO_CONTRA
    End Function

    Public Function CompareTo(ByVal other As TIPO_CONTRATACION) As Integer Implements System.IComparable(Of TIPO_CONTRATACION).CompareTo
        If Me.ID_TIPO_CONTRA > other.ID_TIPO_CONTRA Then Return 1
        If Me.ID_TIPO_CONTRA < other.ID_TIPO_CONTRA Then Return -1
        Return 0
    End Function


#Region " Properties "

    Private _ID_TIPO_CONTRA As Decimal
    <Column(Name:="Id tipo contra", Storage:="ID_TIPO_CONTRA", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=2, Scale:=0)> _
    Public Property ID_TIPO_CONTRA() As Decimal
        Get
            Return _ID_TIPO_CONTRA
        End Get
        Set(ByVal Value As Decimal)
            _ID_TIPO_CONTRA = Value
            OnPropertyChanged("ID_TIPO_CONTRA")
        End Set
    End Property 

    Private _NOM_TIPO_CONTRA As String
    <Column(Name:="Nom tipo contra", Storage:="NOM_TIPO_CONTRA", DbType:="VARCHAR2(30) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 30)> _
    Public Property NOM_TIPO_CONTRA() As String
        Get
            Return _NOM_TIPO_CONTRA
        End Get
        Set(ByVal Value As String)
            _NOM_TIPO_CONTRA = Value
            OnPropertyChanged("NOM_TIPO_CONTRA")
        End Set
    End Property 

    Private _NOM_TIPO_CONTRAOld As String
    Public Property NOM_TIPO_CONTRAOld() As String
        Get
            Return _NOM_TIPO_CONTRAOld
        End Get
        Set(ByVal Value As String)
            _NOM_TIPO_CONTRAOld = Value
        End Set
    End Property 

    Private _USUARIO_CREACION As String
    <Column(Name:="Usuario creacion", Storage:="USUARIO_CREACION", DbType:="VARCHAR2(255) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 255)> _
    Public Property USUARIO_CREACION() As String
        Get
            Return _USUARIO_CREACION
        End Get
        Set(ByVal Value As String)
            _USUARIO_CREACION = Value
            OnPropertyChanged("USUARIO_CREACION")
        End Set
    End Property 

    Private _USUARIO_CREACIONOld As String
    Public Property USUARIO_CREACIONOld() As String
        Get
            Return _USUARIO_CREACIONOld
        End Get
        Set(ByVal Value As String)
            _USUARIO_CREACIONOld = Value
        End Set
    End Property 

    Private _FECHA_CREACION As DateTime
    <Column(Name:="Fecha creacion", Storage:="FECHA_CREACION", DbType:="DATE NOT NULL", Id:=False), _
     DataObjectField(False, False, False)> _
    Public Property FECHA_CREACION() As DateTime
        Get
            Return _FECHA_CREACION
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_CREACION = Value
            OnPropertyChanged("FECHA_CREACION")
        End Set
    End Property 

    Private _FECHA_CREACIONOld As DateTime
    Public Property FECHA_CREACIONOld() As DateTime
        Get
            Return _FECHA_CREACIONOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_CREACIONOld = Value
        End Set
    End Property 

    Private _USERID As String
    <Column(Name:="Userid", Storage:="USERID", DbType:="VARCHAR2(255) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 255)> _
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
