''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.GRUPO_SELECCION
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row GRUPO_SELECCION en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	28/03/2019	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="GRUPO_SELECCION")> Public Class GRUPO_SELECCION
    Inherits entidadBase
    Implements IEquatable(Of GRUPO_SELECCION), IComparable(Of GRUPO_SELECCION)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_GRUPO_SELEC As Decimal, aID_ACCION_CONTRATADA As Decimal, aFECHA_HABILITA As DateTime, aFECHA_INICIO As DateTime, aFECHA_FIN As DateTime, aNO_GRUPO As Decimal, aCODIGO As String, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aLUGAR_EJECUCION As String)
        Me._ID_GRUPO_SELEC = aID_GRUPO_SELEC
        Me._ID_ACCION_CONTRATADA = aID_ACCION_CONTRATADA
        Me._FECHA_HABILITA = aFECHA_HABILITA
        Me._FECHA_INICIO = aFECHA_INICIO
        Me._FECHA_FIN = aFECHA_FIN
        Me._NO_GRUPO = aNO_GRUPO
        Me._CODIGO = aCODIGO
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._LUGAR_EJECUCION = aLUGAR_EJECUCION
    End Sub

    Public Function Equals1(ByVal other As GRUPO_SELECCION) As Boolean Implements System.IEquatable(Of GRUPO_SELECCION).Equals
        Return Me.ID_GRUPO_SELEC = other.ID_GRUPO_SELEC
    End Function

    Public Function CompareTo(ByVal other As GRUPO_SELECCION) As Integer Implements System.IComparable(Of GRUPO_SELECCION).CompareTo
        If Me.ID_GRUPO_SELEC > other.ID_GRUPO_SELEC Then Return 1
        If Me.ID_GRUPO_SELEC < other.ID_GRUPO_SELEC Then Return -1
        Return 0
    End Function


#Region " Properties "

    Private _ID_GRUPO_SELEC As Decimal
    <Column(Name:="Id grupo selec", Storage:="ID_GRUPO_SELEC", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_GRUPO_SELEC() As Decimal
        Get
            Return _ID_GRUPO_SELEC
        End Get
        Set(ByVal Value As Decimal)
            _ID_GRUPO_SELEC = Value
            OnPropertyChanged("ID_GRUPO_SELEC")
        End Set
    End Property 

    Private _ID_ACCION_CONTRATADA As Decimal
    <Column(Name:="Id accion contratada", Storage:="ID_ACCION_CONTRATADA", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_ACCION_CONTRATADA() As Decimal
        Get
            Return _ID_ACCION_CONTRATADA
        End Get
        Set(ByVal Value As Decimal)
            _ID_ACCION_CONTRATADA = Value
            OnPropertyChanged("ID_ACCION_CONTRATADA")
        End Set
    End Property 

    Private _ID_ACCION_CONTRATADAOld As Decimal
    Public Property ID_ACCION_CONTRATADAOld() As Decimal
        Get
            Return _ID_ACCION_CONTRATADAOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_ACCION_CONTRATADAOld = Value
        End Set
    End Property 

    Private _fkID_ACCION_CONTRATADA As ACCION_CONTRATADA
    Public Property fkID_ACCION_CONTRATADA() As ACCION_CONTRATADA
        Get
            Return _fkID_ACCION_CONTRATADA
        End Get
        Set(ByVal Value As ACCION_CONTRATADA)
            _fkID_ACCION_CONTRATADA = Value
        End Set
    End Property 

    Private _FECHA_HABILITA As DateTime
    <Column(Name:="Fecha habilita", Storage:="FECHA_HABILITA", DbType:="DATE NOT NULL", Id:=False), _
     DataObjectField(False, False, False)> _
    Public Property FECHA_HABILITA() As DateTime
        Get
            Return _FECHA_HABILITA
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_HABILITA = Value
            OnPropertyChanged("FECHA_HABILITA")
        End Set
    End Property 

    Private _FECHA_HABILITAOld As DateTime
    Public Property FECHA_HABILITAOld() As DateTime
        Get
            Return _FECHA_HABILITAOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_HABILITAOld = Value
        End Set
    End Property 

    Private _FECHA_INICIO As DateTime
    <Column(Name:="Fecha inicio", Storage:="FECHA_INICIO", DbType:="DATE NOT NULL", Id:=False), _
     DataObjectField(False, False, False)> _
    Public Property FECHA_INICIO() As DateTime
        Get
            Return _FECHA_INICIO
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_INICIO = Value
            OnPropertyChanged("FECHA_INICIO")
        End Set
    End Property 

    Private _FECHA_INICIOOld As DateTime
    Public Property FECHA_INICIOOld() As DateTime
        Get
            Return _FECHA_INICIOOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_INICIOOld = Value
        End Set
    End Property 

    Private _FECHA_FIN As DateTime
    <Column(Name:="Fecha fin", Storage:="FECHA_FIN", DbType:="DATE NOT NULL", Id:=False), _
     DataObjectField(False, False, False)> _
    Public Property FECHA_FIN() As DateTime
        Get
            Return _FECHA_FIN
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_FIN = Value
            OnPropertyChanged("FECHA_FIN")
        End Set
    End Property 

    Private _FECHA_FINOld As DateTime
    Public Property FECHA_FINOld() As DateTime
        Get
            Return _FECHA_FINOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_FINOld = Value
        End Set
    End Property 

    Private _NO_GRUPO As Decimal
    <Column(Name:="No grupo", Storage:="NO_GRUPO", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=8, Scale:=0)> _
    Public Property NO_GRUPO() As Decimal
        Get
            Return _NO_GRUPO
        End Get
        Set(ByVal Value As Decimal)
            _NO_GRUPO = Value
            OnPropertyChanged("NO_GRUPO")
        End Set
    End Property 

    Private _NO_GRUPOOld As Decimal
    Public Property NO_GRUPOOld() As Decimal
        Get
            Return _NO_GRUPOOld
        End Get
        Set(ByVal Value As Decimal)
            _NO_GRUPOOld = Value
        End Set
    End Property 

    Private _CODIGO As String
    <Column(Name:="Codigo", Storage:="CODIGO", DbType:="VARCHAR2(100) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 100)> _
    Public Property CODIGO() As String
        Get
            Return _CODIGO
        End Get
        Set(ByVal Value As String)
            _CODIGO = Value
            OnPropertyChanged("CODIGO")
        End Set
    End Property 

    Private _CODIGOOld As String
    Public Property CODIGOOld() As String
        Get
            Return _CODIGOOld
        End Get
        Set(ByVal Value As String)
            _CODIGOOld = Value
        End Set
    End Property 

    Private _USUARIO_CREA As String
    <Column(Name:="Usuario crea", Storage:="USUARIO_CREA", DbType:="VARCHAR2(200) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 200)> _
    Public Property USUARIO_CREA() As String
        Get
            Return _USUARIO_CREA
        End Get
        Set(ByVal Value As String)
            _USUARIO_CREA = Value
            OnPropertyChanged("USUARIO_CREA")
        End Set
    End Property 

    Private _USUARIO_CREAOld As String
    Public Property USUARIO_CREAOld() As String
        Get
            Return _USUARIO_CREAOld
        End Get
        Set(ByVal Value As String)
            _USUARIO_CREAOld = Value
        End Set
    End Property 

    Private _FECHA_CREA As DateTime
    <Column(Name:="Fecha crea", Storage:="FECHA_CREA", DbType:="DATE NOT NULL", Id:=False), _
     DataObjectField(False, False, False)> _
    Public Property FECHA_CREA() As DateTime
        Get
            Return _FECHA_CREA
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_CREA = Value
            OnPropertyChanged("FECHA_CREA")
        End Set
    End Property 

    Private _FECHA_CREAOld As DateTime
    Public Property FECHA_CREAOld() As DateTime
        Get
            Return _FECHA_CREAOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_CREAOld = Value
        End Set
    End Property 

    Private _LUGAR_EJECUCION As String
    <Column(Name:="Lugar ejecucion", Storage:="LUGAR_EJECUCION", DbType:="VARCHAR2(255)", Id:=False), _
     DataObjectField(False, False, True, 255)> _
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
#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
