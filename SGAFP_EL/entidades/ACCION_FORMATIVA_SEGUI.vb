''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.ACCION_FORMATIVA_SEGUI
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row ACCION_FORMATIVA_SEGUI en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	20/02/2017	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="ACCION_FORMATIVA_SEGUI")> Public Class ACCION_FORMATIVA_SEGUI
    Inherits entidadBase
    Implements IEquatable(Of ACCION_FORMATIVA_SEGUI), IComparable(Of ACCION_FORMATIVA_SEGUI)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_ACCION_FORMATIVA_SEGUI As Decimal, aID_ACCION_FORMATIVA As Decimal, aFECHA_VISITA As DateTime, aOBSERVACION As String, aCOMENTARIO_ADMIN_PROGRA As String, aID_UNIDAD_ORGANIZATIVA As Decimal, aUSUARIO_CREACION As String, aFECHA_CREACION As DateTime)
        Me._ID_ACCION_FORMATIVA_SEGUI = aID_ACCION_FORMATIVA_SEGUI
        Me._ID_ACCION_FORMATIVA = aID_ACCION_FORMATIVA
        Me._FECHA_VISITA = aFECHA_VISITA
        Me._OBSERVACION = aOBSERVACION
        Me._COMENTARIO_ADMIN_PROGRA = aCOMENTARIO_ADMIN_PROGRA
        Me._ID_UNIDAD_ORGANIZATIVA = aID_UNIDAD_ORGANIZATIVA
        Me._USUARIO_CREACION = aUSUARIO_CREACION
        Me._FECHA_CREACION = aFECHA_CREACION
    End Sub

    Public Function Equals1(ByVal other As ACCION_FORMATIVA_SEGUI) As Boolean Implements System.IEquatable(Of ACCION_FORMATIVA_SEGUI).Equals
        Return Me.ID_ACCION_FORMATIVA_SEGUI = other.ID_ACCION_FORMATIVA_SEGUI
    End Function

    Public Function CompareTo(ByVal other As ACCION_FORMATIVA_SEGUI) As Integer Implements System.IComparable(Of ACCION_FORMATIVA_SEGUI).CompareTo
        If Me.ID_ACCION_FORMATIVA_SEGUI > other.ID_ACCION_FORMATIVA_SEGUI Then Return 1
        If Me.ID_ACCION_FORMATIVA_SEGUI < other.ID_ACCION_FORMATIVA_SEGUI Then Return -1
        Return 0
    End Function


#Region " Properties "

    Private _ID_ACCION_FORMATIVA_SEGUI As Decimal
    <Column(Name:="Id accion formativa segui", Storage:="ID_ACCION_FORMATIVA_SEGUI", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_ACCION_FORMATIVA_SEGUI() As Decimal
        Get
            Return _ID_ACCION_FORMATIVA_SEGUI
        End Get
        Set(ByVal Value As Decimal)
            _ID_ACCION_FORMATIVA_SEGUI = Value
            OnPropertyChanged("ID_ACCION_FORMATIVA_SEGUI")
        End Set
    End Property 

    Private _ID_ACCION_FORMATIVA As Decimal
    <Column(Name:="Id accion formativa", Storage:="ID_ACCION_FORMATIVA", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_ACCION_FORMATIVA() As Decimal
        Get
            Return _ID_ACCION_FORMATIVA
        End Get
        Set(ByVal Value As Decimal)
            _ID_ACCION_FORMATIVA = Value
            OnPropertyChanged("ID_ACCION_FORMATIVA")
        End Set
    End Property 

    Private _ID_ACCION_FORMATIVAOld As Decimal
    Public Property ID_ACCION_FORMATIVAOld() As Decimal
        Get
            Return _ID_ACCION_FORMATIVAOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_ACCION_FORMATIVAOld = Value
        End Set
    End Property 

    Private _fkID_ACCION_FORMATIVA As ACCION_FORMATIVA
    Public Property fkID_ACCION_FORMATIVA() As ACCION_FORMATIVA
        Get
            Return _fkID_ACCION_FORMATIVA
        End Get
        Set(ByVal Value As ACCION_FORMATIVA)
            _fkID_ACCION_FORMATIVA = Value
        End Set
    End Property 

    Private _FECHA_VISITA As DateTime
    <Column(Name:="Fecha visita", Storage:="FECHA_VISITA", DbType:="DATE NOT NULL", Id:=False), _
     DataObjectField(False, False, False)> _
    Public Property FECHA_VISITA() As DateTime
        Get
            Return _FECHA_VISITA
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_VISITA = Value
            OnPropertyChanged("FECHA_VISITA")
        End Set
    End Property 

    Private _FECHA_VISITAOld As DateTime
    Public Property FECHA_VISITAOld() As DateTime
        Get
            Return _FECHA_VISITAOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_VISITAOld = Value
        End Set
    End Property 

    Private _OBSERVACION As String
    <Column(Name:="Observacion", Storage:="OBSERVACION", DbType:="VARCHAR2(4000) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 4000)> _
    Public Property OBSERVACION() As String
        Get
            Return _OBSERVACION
        End Get
        Set(ByVal Value As String)
            _OBSERVACION = Value
            OnPropertyChanged("OBSERVACION")
        End Set
    End Property

    Private _OBSERVACIONOld As String
    Public Property OBSERVACIONOld() As String
        Get
            Return _OBSERVACIONOld
        End Get
        Set(ByVal Value As String)
            _OBSERVACIONOld = Value
        End Set
    End Property 

    Private _COMENTARIO_ADMIN_PROGRA As String
    <Column(Name:="Comentario admin progra", Storage:="COMENTARIO_ADMIN_PROGRA", DbType:="VARCHAR2(4000)", Id:=False), _
     DataObjectField(False, False, True, 4000)> _
    Public Property COMENTARIO_ADMIN_PROGRA() As String
        Get
            Return _COMENTARIO_ADMIN_PROGRA
        End Get
        Set(ByVal Value As String)
            _COMENTARIO_ADMIN_PROGRA = Value
            OnPropertyChanged("COMENTARIO_ADMIN_PROGRA")
        End Set
    End Property

    Private _COMENTARIO_ADMIN_PROGRAOld As String
    Public Property COMENTARIO_ADMIN_PROGRAOld() As String
        Get
            Return _COMENTARIO_ADMIN_PROGRAOld
        End Get
        Set(ByVal Value As String)
            _COMENTARIO_ADMIN_PROGRAOld = Value
        End Set
    End Property 

    Private _ID_UNIDAD_ORGANIZATIVA As Decimal
    <Column(Name:="Id unidad organizativa", Storage:="ID_UNIDAD_ORGANIZATIVA", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_UNIDAD_ORGANIZATIVA() As Decimal
        Get
            Return _ID_UNIDAD_ORGANIZATIVA
        End Get
        Set(ByVal Value As Decimal)
            _ID_UNIDAD_ORGANIZATIVA = Value
            OnPropertyChanged("ID_UNIDAD_ORGANIZATIVA")
        End Set
    End Property 

    Private _ID_UNIDAD_ORGANIZATIVAOld As Decimal
    Public Property ID_UNIDAD_ORGANIZATIVAOld() As Decimal
        Get
            Return _ID_UNIDAD_ORGANIZATIVAOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_UNIDAD_ORGANIZATIVAOld = Value
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

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
