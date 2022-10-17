''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.SIPU_DETALLECAPACITACIONES
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row SIPU_DETALLECAPACITACIONES en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	29/10/2013	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="SIPU_DETALLECAPACITADO")> Public Class SIPU_DETALLECAPACITADO
    Inherits entidadBase
    Implements IEquatable(Of SIPU_DETALLECAPACITADO), IComparable(Of SIPU_DETALLECAPACITADO)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aIDDETALLECAPACITADO As Decimal, aID_CAPACITACION As Decimal, aCONVENIO As Decimal, aESTADO As String)
        Me._IDDETALLECAPACITADO = aIDDETALLECAPACITADO
        Me._ID_CAPACITACION = aID_CAPACITACION
        Me._CONVENIO = aCONVENIO
        Me._ESTADO = aESTADO
    End Sub

    Public Function Equals1(ByVal other As SIPU_DETALLECAPACITADO) As Boolean Implements System.IEquatable(Of SIPU_DETALLECAPACITADO).Equals
        Return Me.IDDETALLECAPACITADO = other.IDDETALLECAPACITADO
    End Function

    Public Function CompareTo(ByVal other As SIPU_DETALLECAPACITADO) As Integer Implements System.IComparable(Of SIPU_DETALLECAPACITADO).CompareTo
        If Me.IDDETALLECAPACITADO > other.IDDETALLECAPACITADO Then Return 1
        If Me.IDDETALLECAPACITADO < other.IDDETALLECAPACITADO Then Return -1
        Return 0
    End Function


#Region " Properties "

    Private _IDDETALLECAPACITADO As Decimal
    <Column(Name:="Iddetallecapacitado", Storage:="IDDETALLECAPACITADO", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=8, Scale:=0)> _
    Public Property IDDETALLECAPACITADO() As Decimal
        Get
            Return _IDDETALLECAPACITADO
        End Get
        Set(ByVal Value As Decimal)
            _IDDETALLECAPACITADO = Value
            OnPropertyChanged("IDDETALLECAPACITADO")
        End Set
    End Property

    Private _ID_CAPACITACION As Decimal
    <Column(Name:="Id capacitacion", Storage:="ID_CAPACITACION", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_CAPACITACION() As Decimal
        Get
            Return _ID_CAPACITACION
        End Get
        Set(ByVal Value As Decimal)
            _ID_CAPACITACION = Value
            OnPropertyChanged("ID_CAPACITACION")
        End Set
    End Property

    Private _ID_CAPACITACIONOld As Decimal
    Public Property ID_CAPACITACIONOld() As Decimal
        Get
            Return _ID_CAPACITACIONOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_CAPACITACIONOld = Value
        End Set
    End Property

    Private _fkID_CAPACITACION As SIPU_CAPACITACIONES
    Public Property fkID_CAPACITACION() As SIPU_CAPACITACIONES
        Get
            Return _fkID_CAPACITACION
        End Get
        Set(ByVal Value As SIPU_CAPACITACIONES)
            _fkID_CAPACITACION = Value
        End Set
    End Property

    Private _CONVENIO As Decimal
    <Column(Name:="Convenio", Storage:="CONVENIO", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property CONVENIO() As Decimal
        Get
            Return _CONVENIO
        End Get
        Set(ByVal Value As Decimal)
            _CONVENIO = Value
            OnPropertyChanged("CONVENIO")
        End Set
    End Property

    Private _CONVENIOOld As Decimal
    Public Property CONVENIOOld() As Decimal
        Get
            Return _CONVENIOOld
        End Get
        Set(ByVal Value As Decimal)
            _CONVENIOOld = Value
        End Set
    End Property

    Private _ESTADO As String
    <Column(Name:="Estado", Storage:="ESTADO", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 1)> _
    Public Property ESTADO() As Decimal
        Get
            Return _ESTADO
        End Get
        Set(ByVal Value As Decimal)
            _ESTADO = Value
            OnPropertyChanged("ESTADO")
        End Set
    End Property

    Private _ESTADOOld As Decimal
    Public Property ESTADOOld() As Decimal
        Get
            Return _ESTADOOld
        End Get
        Set(ByVal Value As Decimal)
            _ESTADOOld = Value
        End Set
    End Property

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
