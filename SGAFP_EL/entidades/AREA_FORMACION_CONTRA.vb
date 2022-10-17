''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.AREA_FORMACION_CONTRA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row AREA_FORMACION_CONTRA en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	26/06/2018	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="AREA_FORMACION_CONTRA")> Public Class AREA_FORMACION_CONTRA
    Inherits entidadBase
    Implements IEquatable(Of AREA_FORMACION_CONTRA), IComparable(Of AREA_FORMACION_CONTRA)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_AREA_CONTRA As Decimal, aID_CONTRATO As Decimal, aID_AREA_FORMACION As Decimal, aMONTO As Decimal, aPARTICIPACION As Decimal, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime)
        Me._ID_AREA_CONTRA = aID_AREA_CONTRA
        Me._ID_CONTRATO = aID_CONTRATO
        Me._ID_AREA_FORMACION = aID_AREA_FORMACION
        Me._MONTO = aMONTO
        Me._PARTICIPACION = aPARTICIPACION
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
    End Sub

    Public Function Equals1(ByVal other As AREA_FORMACION_CONTRA) As Boolean Implements System.IEquatable(Of AREA_FORMACION_CONTRA).Equals
        Return Me.ID_AREA_CONTRA = other.ID_AREA_CONTRA
    End Function

    Public Function CompareTo(ByVal other As AREA_FORMACION_CONTRA) As Integer Implements System.IComparable(Of AREA_FORMACION_CONTRA).CompareTo
        If Me.ID_AREA_CONTRA > other.ID_AREA_CONTRA Then Return 1
        If Me.ID_AREA_CONTRA < other.ID_AREA_CONTRA Then Return -1
        Return 0
    End Function


#Region " Properties "

    Private _ID_AREA_CONTRA As Decimal
    <Column(Name:="Id area contra", Storage:="ID_AREA_CONTRA", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_AREA_CONTRA() As Decimal
        Get
            Return _ID_AREA_CONTRA
        End Get
        Set(ByVal Value As Decimal)
            _ID_AREA_CONTRA = Value
            OnPropertyChanged("ID_AREA_CONTRA")
        End Set
    End Property 

    Private _ID_CONTRATO As Decimal
    <Column(Name:="Id contrato", Storage:="ID_CONTRATO", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_CONTRATO() As Decimal
        Get
            Return _ID_CONTRATO
        End Get
        Set(ByVal Value As Decimal)
            _ID_CONTRATO = Value
            OnPropertyChanged("ID_CONTRATO")
        End Set
    End Property 

    Private _ID_CONTRATOOld As Decimal
    Public Property ID_CONTRATOOld() As Decimal
        Get
            Return _ID_CONTRATOOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_CONTRATOOld = Value
        End Set
    End Property 

    Private _fkID_CONTRATO As CONTRATO_PROVEEDOR_AF
    Public Property fkID_CONTRATO() As CONTRATO_PROVEEDOR_AF
        Get
            Return _fkID_CONTRATO
        End Get
        Set(ByVal Value As CONTRATO_PROVEEDOR_AF)
            _fkID_CONTRATO = Value
        End Set
    End Property 

    Private _ID_AREA_FORMACION As Decimal
    <Column(Name:="Id area formacion", Storage:="ID_AREA_FORMACION", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_AREA_FORMACION() As Decimal
        Get
            Return _ID_AREA_FORMACION
        End Get
        Set(ByVal Value As Decimal)
            _ID_AREA_FORMACION = Value
            OnPropertyChanged("ID_AREA_FORMACION")
        End Set
    End Property 

    Private _ID_AREA_FORMACIONOld As Decimal
    Public Property ID_AREA_FORMACIONOld() As Decimal
        Get
            Return _ID_AREA_FORMACIONOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_AREA_FORMACIONOld = Value
        End Set
    End Property 

    Private _fkID_AREA_FORMACION As AREA_FORMACION
    Public Property fkID_AREA_FORMACION() As AREA_FORMACION
        Get
            Return _fkID_AREA_FORMACION
        End Get
        Set(ByVal Value As AREA_FORMACION)
            _fkID_AREA_FORMACION = Value
        End Set
    End Property 

    Private _MONTO As Decimal
    <Column(Name:="Monto", Storage:="MONTO", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=2)> _
    Public Property MONTO() As Decimal
        Get
            Return _MONTO
        End Get
        Set(ByVal Value As Decimal)
            _MONTO = Value
            OnPropertyChanged("MONTO")
        End Set
    End Property 

    Private _MONTOOld As Decimal
    Public Property MONTOOld() As Decimal
        Get
            Return _MONTOOld
        End Get
        Set(ByVal Value As Decimal)
            _MONTOOld = Value
        End Set
    End Property 

    Private _PARTICIPACION As Decimal
    <Column(Name:="Participacion", Storage:="PARTICIPACION", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=0)> _
    Public Property PARTICIPACION() As Decimal
        Get
            Return _PARTICIPACION
        End Get
        Set(ByVal Value As Decimal)
            _PARTICIPACION = Value
            OnPropertyChanged("PARTICIPACION")
        End Set
    End Property 

    Private _PARTICIPACIONOld As Decimal
    Public Property PARTICIPACIONOld() As Decimal
        Get
            Return _PARTICIPACIONOld
        End Get
        Set(ByVal Value As Decimal)
            _PARTICIPACIONOld = Value
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
