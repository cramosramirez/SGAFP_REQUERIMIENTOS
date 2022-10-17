''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.GRUPO_SOLICITUD
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row GRUPO_SOLICITUD en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	05/10/2012	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="GRUPO_SOLICITUD")> Public Class GRUPO_SOLICITUD
    Inherits entidadBase
    Implements IEquatable(Of GRUPO_SOLICITUD), IComparable(Of GRUPO_SOLICITUD)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(ByVal aID_GRUPO_SOLICITUD As Decimal, ByVal aID_SOLICITUD As Decimal, ByVal aID_MODALIDAD_FORMACION As Decimal, ByVal aCODIGO_PROGRAMA As String, ByVal aDURACION_HORAS As Decimal, ByVal aNUM_PARTICIPANTES As Decimal, ByVal aTDR As String, ByVal aUSERID As String, ByVal aLASTUPDATE As DateTime, ByVal aUSUARIO_CREACION As String, ByVal aFECHA_CREACION As DateTime, ByVal aCODIGO_DEPARTAMENTO As String, ByVal aCODIGO_MUNICIPIO As String, ByVal aLUGAR_EJECUCION As String, ByVal aNOMBRE_ACCION_FORMATIVA As String)
        Me._ID_GRUPO_SOLICITUD = aID_GRUPO_SOLICITUD
        Me._ID_SOLICITUD = aID_SOLICITUD
        Me._ID_MODALIDAD_FORMACION = aID_MODALIDAD_FORMACION
        Me._CODIGO_PROGRAMA = aCODIGO_PROGRAMA
        Me._DURACION_HORAS = aDURACION_HORAS
        Me._NUM_PARTICIPANTES = aNUM_PARTICIPANTES
        Me._TDR = aTDR
        Me._USERID = aUSERID
        Me._LASTUPDATE = aLASTUPDATE
        Me._USUARIO_CREACION = aUSUARIO_CREACION
        Me._FECHA_CREACION = aFECHA_CREACION
        Me._CODIGO_DEPARTAMENTO = aCODIGO_DEPARTAMENTO
        Me._CODIGO_MUNICIPIO = aCODIGO_MUNICIPIO
        Me._LUGAR_EJECUCION = aLUGAR_EJECUCION
        Me._NOMBRE_ACCION_FORMATIVA = aNOMBRE_ACCION_FORMATIVA
    End Sub

    Public Function Equals1(ByVal other As GRUPO_SOLICITUD) As Boolean Implements System.IEquatable(Of GRUPO_SOLICITUD).Equals
        Return Me.ID_GRUPO_SOLICITUD = other.ID_GRUPO_SOLICITUD
    End Function

    Public Function CompareTo(ByVal other As GRUPO_SOLICITUD) As Integer Implements System.IComparable(Of GRUPO_SOLICITUD).CompareTo
        If Me.ID_GRUPO_SOLICITUD > other.ID_GRUPO_SOLICITUD Then Return 1
        If Me.ID_GRUPO_SOLICITUD < other.ID_GRUPO_SOLICITUD Then Return -1
        Return 0
    End Function


#Region " Properties "

    Private _ID_GRUPO_SOLICITUD As Decimal
    <Column(Name:="Id grupo solicitud", Storage:="ID_GRUPO_SOLICITUD", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_GRUPO_SOLICITUD() As Decimal
        Get
            Return _ID_GRUPO_SOLICITUD
        End Get
        Set(ByVal Value As Decimal)
            _ID_GRUPO_SOLICITUD = Value
            OnPropertyChanged("ID_GRUPO_SOLICITUD")
        End Set
    End Property

    Private _ID_SOLICITUD As Decimal
    <Column(Name:="Id solicitud", Storage:="ID_SOLICITUD", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=0, Scale:=0)> _
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

    Private _fkID_SOLICITUD As SOLICITUD_CAPACITACION
    Public Property fkID_SOLICITUD() As SOLICITUD_CAPACITACION
        Get
            Return _fkID_SOLICITUD
        End Get
        Set(ByVal Value As SOLICITUD_CAPACITACION)
            _fkID_SOLICITUD = Value
        End Set
    End Property

    Private _ID_MODALIDAD_FORMACION As Decimal
    <Column(Name:="Id modalidad formacion", Storage:="ID_MODALIDAD_FORMACION", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_MODALIDAD_FORMACION() As Decimal
        Get
            Return _ID_MODALIDAD_FORMACION
        End Get
        Set(ByVal Value As Decimal)
            _ID_MODALIDAD_FORMACION = Value
            OnPropertyChanged("ID_MODALIDAD_FORMACION")
        End Set
    End Property

    Private _ID_MODALIDAD_FORMACIONOld As Decimal
    Public Property ID_MODALIDAD_FORMACIONOld() As Decimal
        Get
            Return _ID_MODALIDAD_FORMACIONOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_MODALIDAD_FORMACIONOld = Value
        End Set
    End Property

    Private _fkID_MODALIDAD_FORMACION As MODALIDAD_DE_FORMACION
    Public Property fkID_MODALIDAD_FORMACION() As MODALIDAD_DE_FORMACION
        Get
            Return _fkID_MODALIDAD_FORMACION
        End Get
        Set(ByVal Value As MODALIDAD_DE_FORMACION)
            _fkID_MODALIDAD_FORMACION = Value
        End Set
    End Property

    Private _CODIGO_PROGRAMA As String
    <Column(Name:="Codigo programa", Storage:="CODIGO_PROGRAMA", DbType:="CHAR(10) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 10)> _
    Public Property CODIGO_PROGRAMA() As String
        Get
            Return _CODIGO_PROGRAMA
        End Get
        Set(ByVal Value As String)
            _CODIGO_PROGRAMA = Value
            OnPropertyChanged("CODIGO_PROGRAMA")
        End Set
    End Property

    Private _CODIGO_PROGRAMAOld As String
    Public Property CODIGO_PROGRAMAOld() As String
        Get
            Return _CODIGO_PROGRAMAOld
        End Get
        Set(ByVal Value As String)
            _CODIGO_PROGRAMAOld = Value
        End Set
    End Property

    Private _DURACION_HORAS As Decimal
    <Column(Name:="Duracion horas", Storage:="DURACION_HORAS", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=8, Scale:=0)> _
    Public Property DURACION_HORAS() As Decimal
        Get
            Return _DURACION_HORAS
        End Get
        Set(ByVal Value As Decimal)
            _DURACION_HORAS = Value
            OnPropertyChanged("DURACION_HORAS")
        End Set
    End Property

    Private _DURACION_HORASOld As Decimal
    Public Property DURACION_HORASOld() As Decimal
        Get
            Return _DURACION_HORASOld
        End Get
        Set(ByVal Value As Decimal)
            _DURACION_HORASOld = Value
        End Set
    End Property

    Private _NUM_PARTICIPANTES As Decimal
    <Column(Name:="Num participantes", Storage:="NUM_PARTICIPANTES", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=8, Scale:=0)> _
    Public Property NUM_PARTICIPANTES() As Decimal
        Get
            Return _NUM_PARTICIPANTES
        End Get
        Set(ByVal Value As Decimal)
            _NUM_PARTICIPANTES = Value
            OnPropertyChanged("NUM_PARTICIPANTES")
        End Set
    End Property

    Private _NUM_PARTICIPANTESOld As Decimal
    Public Property NUM_PARTICIPANTESOld() As Decimal
        Get
            Return _NUM_PARTICIPANTESOld
        End Get
        Set(ByVal Value As Decimal)
            _NUM_PARTICIPANTESOld = Value
        End Set
    End Property

    Private _TDR As String
    <Column(Name:="Tdr", Storage:="TDR", DbType:="CHAR(20)", Id:=False), _
     DataObjectField(False, False, True, 20)> _
    Public Property TDR() As String
        Get
            Return _TDR
        End Get
        Set(ByVal Value As String)
            _TDR = Value
            OnPropertyChanged("TDR")
        End Set
    End Property

    Private _TDROld As String
    Public Property TDROld() As String
        Get
            Return _TDROld
        End Get
        Set(ByVal Value As String)
            _TDROld = Value
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

    Private _USUARIO_CREACION As String
    <Column(Name:="Usuario creacion", Storage:="USUARIO_CREACION", DbType:="VARCHAR2(256) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 256)> _
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

    Private _CODIGO_DEPARTAMENTO As String
    <Column(Name:="Codigo departamento", Storage:="CODIGO_DEPARTAMENTO", DbType:="VARCHAR2(2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 2)> _
    Public Property CODIGO_DEPARTAMENTO() As String
        Get
            Return _CODIGO_DEPARTAMENTO
        End Get
        Set(ByVal Value As String)
            _CODIGO_DEPARTAMENTO = Value
            OnPropertyChanged("CODIGO_DEPARTAMENTO")
        End Set
    End Property

    Private _CODIGO_DEPARTAMENTOOld As String
    Public Property CODIGO_DEPARTAMENTOOld() As String
        Get
            Return _CODIGO_DEPARTAMENTOOld
        End Get
        Set(ByVal Value As String)
            _CODIGO_DEPARTAMENTOOld = Value
        End Set
    End Property

    Private _CODIGO_MUNICIPIO As String
    <Column(Name:="Codigo municipio", Storage:="CODIGO_MUNICIPIO", DbType:="VARCHAR2(2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 2)> _
    Public Property CODIGO_MUNICIPIO() As String
        Get
            Return _CODIGO_MUNICIPIO
        End Get
        Set(ByVal Value As String)
            _CODIGO_MUNICIPIO = Value
            OnPropertyChanged("CODIGO_MUNICIPIO")
        End Set
    End Property

    Private _CODIGO_MUNICIPIOOld As String
    Public Property CODIGO_MUNICIPIOOld() As String
        Get
            Return _CODIGO_MUNICIPIOOld
        End Get
        Set(ByVal Value As String)
            _CODIGO_MUNICIPIOOld = Value
        End Set
    End Property

    Private _LUGAR_EJECUCION As String
    <Column(Name:="Lugar ejecución", Storage:="LUGAR_EJECUCION", DbType:="VARCHAR2(300) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 300)> _
    Public Property LUGAR_EJECUCION() As String
        Get
            Return _LUGAR_EJECUCION
        End Get
        Set(ByVal Value As String)
            _LUGAR_EJECUCION = Value
            OnPropertyChanged("LUGAR_EJECUCION")
        End Set
    End Property

    Private _LUGAR_EJECUCIONOld As String
    Public Property LUGAR_EJECUCIONOld() As String
        Get
            Return _LUGAR_EJECUCIONOld
        End Get
        Set(ByVal Value As String)
            _LUGAR_EJECUCIONOld = Value
        End Set
    End Property

    Private _NOMBRE_ACCION_FORMATIVA As String
    <Column(Name:="Nombre accion formativa", Storage:="NOMBRE_ACCION_FORMATIVA", DbType:="VARCHAR2(150) NOT NULL", Id:=False), _
     DataObjectField(False, False, True, 150)> _
    Public Property NOMBRE_ACCION_FORMATIVA() As String
        Get
            Return _NOMBRE_ACCION_FORMATIVA
        End Get
        Set(ByVal Value As String)
            _NOMBRE_ACCION_FORMATIVA = Value
            OnPropertyChanged("NOMBRE_ACCION_FORMATIVA")
        End Set
    End Property

    Private _NOMBRE_ACCION_FORMATIVAOld As String
    Public Property NOMBRE_ACCION_FORMATIVAOld() As String
        Get
            Return _NOMBRE_ACCION_FORMATIVAOld
        End Get
        Set(ByVal Value As String)
            _NOMBRE_ACCION_FORMATIVAOld = Value
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

    Private _CORRELATIVO_GRUPO As Decimal
    <Column(Name:="Correlativo grupo", Storage:="CORRELATIVO_GRUPO", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=38, Scale:=0)> _
    Public Property CORRELATIVO_GRUPO() As Decimal
        Get
            Return _CORRELATIVO_GRUPO
        End Get
        Set(ByVal Value As Decimal)
            _CORRELATIVO_GRUPO = Value
            OnPropertyChanged("CORRELATIVO_GRUPO")
        End Set
    End Property

    Private _CORRELATIVO_GRUPOOld As Decimal
    Public Property CORRELATIVO_GRUPOOld() As Decimal
        Get
            Return _CORRELATIVO_GRUPOOld
        End Get
        Set(ByVal Value As Decimal)
            _CORRELATIVO_GRUPOOld = Value
        End Set
    End Property

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
