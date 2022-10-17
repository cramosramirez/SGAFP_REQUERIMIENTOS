''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.COMPRA_EX_PAGO_ASISTE
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row COMPRA_EX_PAGO_ASISTE en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	07/04/2022	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="COMPRA_EX_PAGO_ASISTE")> Public Class COMPRA_EX_PAGO_ASISTE
    Inherits entidadBase
    Implements IEquatable(Of COMPRA_EX_PAGO_ASISTE), IComparable(Of COMPRA_EX_PAGO_ASISTE)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_CONTRATACION_EX As Decimal, aREFERENCIA As String, aID_TIPO_CONTRA As Decimal)
        Me._ID_CONTRATACION_EX = aID_CONTRATACION_EX
        Me._REFERENCIA = aREFERENCIA
        Me._ID_TIPO_CONTRA = aID_TIPO_CONTRA
    End Sub

    Public Function Equals1(ByVal other As COMPRA_EX_PAGO_ASISTE) As Boolean Implements System.IEquatable(Of COMPRA_EX_PAGO_ASISTE).Equals
        Return Me.ID_CONTRATACION_EX = other.ID_CONTRATACION_EX
    End Function

    Public Function CompareTo(ByVal other As COMPRA_EX_PAGO_ASISTE) As Integer Implements System.IComparable(Of COMPRA_EX_PAGO_ASISTE).CompareTo
        If Me.ID_CONTRATACION_EX > other.ID_CONTRATACION_EX Then Return 1
        If Me.ID_CONTRATACION_EX < other.ID_CONTRATACION_EX Then Return -1
        Return 0
    End Function


#Region " Properties "

    Private _ID_CONTRATACION_EX As Decimal
    <Column(Name:="Id contratacion ex", Storage:="ID_CONTRATACION_EX", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_CONTRATACION_EX() As Decimal
        Get
            Return _ID_CONTRATACION_EX
        End Get
        Set(ByVal Value As Decimal)
            _ID_CONTRATACION_EX = Value
            OnPropertyChanged("ID_CONTRATACION_EX")
        End Set
    End Property 

    Private _REFERENCIA As String
    <Column(Name:="Referencia", Storage:="REFERENCIA", DbType:="VARCHAR2(100) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 100)> _
    Public Property REFERENCIA() As String
        Get
            Return _REFERENCIA
        End Get
        Set(ByVal Value As String)
            _REFERENCIA = Value
            OnPropertyChanged("REFERENCIA")
        End Set
    End Property 

    Private _REFERENCIAOld As String
    Public Property REFERENCIAOld() As String
        Get
            Return _REFERENCIAOld
        End Get
        Set(ByVal Value As String)
            _REFERENCIAOld = Value
        End Set
    End Property 

    Private _ID_TIPO_CONTRA As Decimal
    <Column(Name:="Id tipo contra", Storage:="ID_TIPO_CONTRA", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_TIPO_CONTRA() As Decimal
        Get
            Return _ID_TIPO_CONTRA
        End Get
        Set(ByVal Value As Decimal)
            _ID_TIPO_CONTRA = Value
            OnPropertyChanged("ID_TIPO_CONTRA")
        End Set
    End Property 

    Private _ID_TIPO_CONTRAOld As Decimal
    Public Property ID_TIPO_CONTRAOld() As Decimal
        Get
            Return _ID_TIPO_CONTRAOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_TIPO_CONTRAOld = Value
        End Set
    End Property 

    Private _fkID_TIPO_CONTRA As TIPO_CONTRATACION
    Public Property fkID_TIPO_CONTRA() As TIPO_CONTRATACION
        Get
            Return _fkID_TIPO_CONTRA
        End Get
        Set(ByVal Value As TIPO_CONTRATACION)
            _fkID_TIPO_CONTRA = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
