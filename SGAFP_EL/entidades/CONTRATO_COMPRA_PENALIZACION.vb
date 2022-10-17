''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.CONTRATO_COMPRA_PENALIZACION
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row CONTRATO_COMPRA_PENALIZACION en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	27/10/2021	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="CONTRATO_COMPRA_PENALIZACION")> Public Class CONTRATO_COMPRA_PENALIZACION
    Inherits entidadBase
    Implements IEquatable(Of CONTRATO_COMPRA_PENALIZACION), IComparable(Of CONTRATO_COMPRA_PENALIZACION)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_CONTRA_PENA As Decimal, aID_CONTRATO_COMPRA As Decimal, aID_TIPO_PENA As Decimal, aRANGO_INI As Decimal, aRANGO_FIN As Decimal, aPORC_PENA As Decimal, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime)
        Me._ID_CONTRA_PENA = aID_CONTRA_PENA
        Me._ID_CONTRATO_COMPRA = aID_CONTRATO_COMPRA
        Me._ID_TIPO_PENA = aID_TIPO_PENA
        Me._RANGO_INI = aRANGO_INI
        Me._RANGO_FIN = aRANGO_FIN
        Me._PORC_PENA = aPORC_PENA
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
    End Sub

    Public Function Equals1(ByVal other As CONTRATO_COMPRA_PENALIZACION) As Boolean Implements System.IEquatable(Of CONTRATO_COMPRA_PENALIZACION).Equals
        Return Me.ID_CONTRA_PENA = other.ID_CONTRA_PENA
    End Function

    Public Function CompareTo(ByVal other As CONTRATO_COMPRA_PENALIZACION) As Integer Implements System.IComparable(Of CONTRATO_COMPRA_PENALIZACION).CompareTo
        If Me.ID_CONTRA_PENA > other.ID_CONTRA_PENA Then Return 1
        If Me.ID_CONTRA_PENA < other.ID_CONTRA_PENA Then Return -1
        Return 0
    End Function


#Region " Properties "

    Private _ID_CONTRA_PENA As Decimal
    <Column(Name:="Id contra pena", Storage:="ID_CONTRA_PENA", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_CONTRA_PENA() As Decimal
        Get
            Return _ID_CONTRA_PENA
        End Get
        Set(ByVal Value As Decimal)
            _ID_CONTRA_PENA = Value
            OnPropertyChanged("ID_CONTRA_PENA")
        End Set
    End Property 

    Private _ID_CONTRATO_COMPRA As Decimal
    <Column(Name:="Id contrato compra", Storage:="ID_CONTRATO_COMPRA", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_CONTRATO_COMPRA() As Decimal
        Get
            Return _ID_CONTRATO_COMPRA
        End Get
        Set(ByVal Value As Decimal)
            _ID_CONTRATO_COMPRA = Value
            OnPropertyChanged("ID_CONTRATO_COMPRA")
        End Set
    End Property 

    Private _ID_CONTRATO_COMPRAOld As Decimal
    Public Property ID_CONTRATO_COMPRAOld() As Decimal
        Get
            Return _ID_CONTRATO_COMPRAOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_CONTRATO_COMPRAOld = Value
        End Set
    End Property 

    Private _fkID_CONTRATO_COMPRA As CONTRATO_COMPRA
    Public Property fkID_CONTRATO_COMPRA() As CONTRATO_COMPRA
        Get
            Return _fkID_CONTRATO_COMPRA
        End Get
        Set(ByVal Value As CONTRATO_COMPRA)
            _fkID_CONTRATO_COMPRA = Value
        End Set
    End Property 

    Private _ID_TIPO_PENA As Decimal
    <Column(Name:="Id tipo pena", Storage:="ID_TIPO_PENA", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_TIPO_PENA() As Decimal
        Get
            Return _ID_TIPO_PENA
        End Get
        Set(ByVal Value As Decimal)
            _ID_TIPO_PENA = Value
            OnPropertyChanged("ID_TIPO_PENA")
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

    Private _fkID_TIPO_PENA As TIPO_PENALIZA
    Public Property fkID_TIPO_PENA() As TIPO_PENALIZA
        Get
            Return _fkID_TIPO_PENA
        End Get
        Set(ByVal Value As TIPO_PENALIZA)
            _fkID_TIPO_PENA = Value
        End Set
    End Property 

    Private _RANGO_INI As Decimal
    <Column(Name:="Rango ini", Storage:="RANGO_INI", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property RANGO_INI() As Decimal
        Get
            Return _RANGO_INI
        End Get
        Set(ByVal Value As Decimal)
            _RANGO_INI = Value
            OnPropertyChanged("RANGO_INI")
        End Set
    End Property 

    Private _RANGO_INIOld As Decimal
    Public Property RANGO_INIOld() As Decimal
        Get
            Return _RANGO_INIOld
        End Get
        Set(ByVal Value As Decimal)
            _RANGO_INIOld = Value
        End Set
    End Property 

    Private _RANGO_FIN As Decimal
    <Column(Name:="Rango fin", Storage:="RANGO_FIN", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property RANGO_FIN() As Decimal
        Get
            Return _RANGO_FIN
        End Get
        Set(ByVal Value As Decimal)
            _RANGO_FIN = Value
            OnPropertyChanged("RANGO_FIN")
        End Set
    End Property 

    Private _RANGO_FINOld As Decimal
    Public Property RANGO_FINOld() As Decimal
        Get
            Return _RANGO_FINOld
        End Get
        Set(ByVal Value As Decimal)
            _RANGO_FINOld = Value
        End Set
    End Property 

    Private _PORC_PENA As Decimal
    <Column(Name:="Porc pena", Storage:="PORC_PENA", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=5, Scale:=2)> _
    Public Property PORC_PENA() As Decimal
        Get
            Return _PORC_PENA
        End Get
        Set(ByVal Value As Decimal)
            _PORC_PENA = Value
            OnPropertyChanged("PORC_PENA")
        End Set
    End Property 

    Private _PORC_PENAOld As Decimal
    Public Property PORC_PENAOld() As Decimal
        Get
            Return _PORC_PENAOld
        End Get
        Set(ByVal Value As Decimal)
            _PORC_PENAOld = Value
        End Set
    End Property 

    Private _USUARIO_CREA As String
    <Column(Name:="Usuario crea", Storage:="USUARIO_CREA", DbType:="VARCHAR2(100) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 100)> _
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

    Private _USUARIO_ACT As String
    <Column(Name:="Usuario act", Storage:="USUARIO_ACT", DbType:="VARCHAR2(100) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 100)> _
    Public Property USUARIO_ACT() As String
        Get
            Return _USUARIO_ACT
        End Get
        Set(ByVal Value As String)
            _USUARIO_ACT = Value
            OnPropertyChanged("USUARIO_ACT")
        End Set
    End Property 

    Private _USUARIO_ACTOld As String
    Public Property USUARIO_ACTOld() As String
        Get
            Return _USUARIO_ACTOld
        End Get
        Set(ByVal Value As String)
            _USUARIO_ACTOld = Value
        End Set
    End Property 

    Private _FECHA_ACT As DateTime
    <Column(Name:="Fecha act", Storage:="FECHA_ACT", DbType:="DATE NOT NULL", Id:=False), _
     DataObjectField(False, False, False)> _
    Public Property FECHA_ACT() As DateTime
        Get
            Return _FECHA_ACT
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_ACT = Value
            OnPropertyChanged("FECHA_ACT")
        End Set
    End Property 

    Private _FECHA_ACTOld As DateTime
    Public Property FECHA_ACTOld() As DateTime
        Get
            Return _FECHA_ACTOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_ACTOld = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
