''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.ACCION_FORMATIVA_PENA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row ACCION_FORMATIVA_PENA en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	20/02/2017	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="ACCION_FORMATIVA_PENA")> Public Class ACCION_FORMATIVA_PENA
    Inherits entidadBase
    Implements IEquatable(Of ACCION_FORMATIVA_PENA), IComparable(Of ACCION_FORMATIVA_PENA)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_ACCION_FORMATIVA_PENA As Decimal, aID_ACCION_FORMATIVA As Decimal, aPORC_PENALIZACION As Decimal, aMOTIVO As String, aUSUARIO_CREACION As String, aFECHA_CREACION As DateTime)
        Me._ID_ACCION_FORMATIVA_PENA = aID_ACCION_FORMATIVA_PENA
        Me._ID_ACCION_FORMATIVA = aID_ACCION_FORMATIVA
        Me._PORC_PENALIZACION = aPORC_PENALIZACION
        Me._MOTIVO = aMOTIVO
        Me._USUARIO_CREACION = aUSUARIO_CREACION
        Me._FECHA_CREACION = aFECHA_CREACION
    End Sub

    Public Function Equals1(ByVal other As ACCION_FORMATIVA_PENA) As Boolean Implements System.IEquatable(Of ACCION_FORMATIVA_PENA).Equals
        Return Me.ID_ACCION_FORMATIVA_PENA = other.ID_ACCION_FORMATIVA_PENA
    End Function

    Public Function CompareTo(ByVal other As ACCION_FORMATIVA_PENA) As Integer Implements System.IComparable(Of ACCION_FORMATIVA_PENA).CompareTo
        If Me.ID_ACCION_FORMATIVA_PENA > other.ID_ACCION_FORMATIVA_PENA Then Return 1
        If Me.ID_ACCION_FORMATIVA_PENA < other.ID_ACCION_FORMATIVA_PENA Then Return -1
        Return 0
    End Function


#Region " Properties "

    Private _ID_ACCION_FORMATIVA_PENA As Decimal
    <Column(Name:="Id accion formativa pena", Storage:="ID_ACCION_FORMATIVA_PENA", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_ACCION_FORMATIVA_PENA() As Decimal
        Get
            Return _ID_ACCION_FORMATIVA_PENA
        End Get
        Set(ByVal Value As Decimal)
            _ID_ACCION_FORMATIVA_PENA = Value
            OnPropertyChanged("ID_ACCION_FORMATIVA_PENA")
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

    Private _PORC_PENALIZACION As Decimal
    <Column(Name:="Porc penalizacion", Storage:="PORC_PENALIZACION", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=6, Scale:=2)> _
    Public Property PORC_PENALIZACION() As Decimal
        Get
            Return _PORC_PENALIZACION
        End Get
        Set(ByVal Value As Decimal)
            _PORC_PENALIZACION = Value
            OnPropertyChanged("PORC_PENALIZACION")
        End Set
    End Property 

    Private _PORC_PENALIZACIONOld As Decimal
    Public Property PORC_PENALIZACIONOld() As Decimal
        Get
            Return _PORC_PENALIZACIONOld
        End Get
        Set(ByVal Value As Decimal)
            _PORC_PENALIZACIONOld = Value
        End Set
    End Property 

    Private _MOTIVO As String
    <Column(Name:="Motivo", Storage:="MOTIVO", DbType:="VARCHAR2(1000) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 1000)> _
    Public Property MOTIVO() As String
        Get
            Return _MOTIVO
        End Get
        Set(ByVal Value As String)
            _MOTIVO = Value
            OnPropertyChanged("MOTIVO")
        End Set
    End Property 

    Private _MOTIVOOld As String
    Public Property MOTIVOOld() As String
        Get
            Return _MOTIVOOld
        End Get
        Set(ByVal Value As String)
            _MOTIVOOld = Value
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


    Private _ID_TIPO_PENA As Decimal
    <Column(Name:="Id tipo pena", Storage:="ID_TIPO_PENA", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_TIPO_PENA() As Decimal
        Get
            Return _ID_TIPO_PENA
        End Get
        Set(ByVal Value As Decimal)
            _ID_TIPO_PENA = Value
            OnPropertyChanged("ID_TIPO_PENA ")
        End Set
    End Property

    Private _ID_TIPO_PENAOld As Decimal
    Public Property ID_TIPO_PENAOld() As Decimal
        Get
            Return _ID_TIPO_PENAOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_TIPO_PENAOld = Value
        End Set
    End Property
#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
