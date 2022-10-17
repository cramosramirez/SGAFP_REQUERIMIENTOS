''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.CONTRATO_COMPRA_PGOACTIVOS
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row CONTRATO_COMPRA_PGOACTIVOS en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/09/2019	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="CONTRATO_COMPRA_PGOACTIVOS")> Public Class CONTRATO_COMPRA_PGOACTIVOS
    Inherits entidadBase
    Implements IEquatable(Of CONTRATO_COMPRA_PGOACTIVOS), IComparable(Of CONTRATO_COMPRA_PGOACTIVOS)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_PAGO As Decimal, aID_CONTRATO_COMPRA As Decimal, aNO_ACTIVOS As Decimal, aPORC_RECONOCIMIENTO As Decimal, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime)
        Me._ID_PAGO = aID_PAGO
        Me._ID_CONTRATO_COMPRA = aID_CONTRATO_COMPRA
        Me._NO_ACTIVOS = aNO_ACTIVOS
        Me._PORC_RECONOCIMIENTO = aPORC_RECONOCIMIENTO
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
    End Sub

    Public Function Equals1(ByVal other As CONTRATO_COMPRA_PGOACTIVOS) As Boolean Implements System.IEquatable(Of CONTRATO_COMPRA_PGOACTIVOS).Equals
        Return Me.ID_PAGO = other.ID_PAGO
    End Function

    Public Function CompareTo(ByVal other As CONTRATO_COMPRA_PGOACTIVOS) As Integer Implements System.IComparable(Of CONTRATO_COMPRA_PGOACTIVOS).CompareTo
        If Me.ID_PAGO > other.ID_PAGO Then Return 1
        If Me.ID_PAGO < other.ID_PAGO Then Return -1
        Return 0
    End Function


#Region " Properties "

    Private _ID_PAGO As Decimal
    <Column(Name:="Id pago", Storage:="ID_PAGO", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_PAGO() As Decimal
        Get
            Return _ID_PAGO
        End Get
        Set(ByVal Value As Decimal)
            _ID_PAGO = Value
            OnPropertyChanged("ID_PAGO")
        End Set
    End Property 

    Private _ID_CONTRATO_COMPRA As Decimal
    <Column(Name:="Id contrato compra", Storage:="ID_CONTRATO_COMPRA", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=0, Scale:=0)> _
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

    Private _NO_ACTIVOS As Decimal
    <Column(Name:="No activos", Storage:="NO_ACTIVOS", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=0, Scale:=0)> _
    Public Property NO_ACTIVOS() As Decimal
        Get
            Return _NO_ACTIVOS
        End Get
        Set(ByVal Value As Decimal)
            _NO_ACTIVOS = Value
            OnPropertyChanged("NO_ACTIVOS")
        End Set
    End Property 

    Private _NO_ACTIVOSOld As Decimal
    Public Property NO_ACTIVOSOld() As Decimal
        Get
            Return _NO_ACTIVOSOld
        End Get
        Set(ByVal Value As Decimal)
            _NO_ACTIVOSOld = Value
        End Set
    End Property 

    Private _PORC_RECONOCIMIENTO As Decimal
    <Column(Name:="Porc reconocimiento", Storage:="PORC_RECONOCIMIENTO", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=5, Scale:=2)> _
    Public Property PORC_RECONOCIMIENTO() As Decimal
        Get
            Return _PORC_RECONOCIMIENTO
        End Get
        Set(ByVal Value As Decimal)
            _PORC_RECONOCIMIENTO = Value
            OnPropertyChanged("PORC_RECONOCIMIENTO")
        End Set
    End Property 

    Private _PORC_RECONOCIMIENTOOld As Decimal
    Public Property PORC_RECONOCIMIENTOOld() As Decimal
        Get
            Return _PORC_RECONOCIMIENTOOld
        End Get
        Set(ByVal Value As Decimal)
            _PORC_RECONOCIMIENTOOld = Value
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

    Private _USUARIO_ACT As String
    <Column(Name:="Usuario act", Storage:="USUARIO_ACT", DbType:="VARCHAR2(200) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 200)> _
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
