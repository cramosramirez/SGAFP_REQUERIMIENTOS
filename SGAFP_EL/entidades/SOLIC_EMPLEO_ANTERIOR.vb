''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.SOLIC_EMPLEO_ANTERIOR
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row SOLIC_EMPLEO_ANTERIOR en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	19/01/2011	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="SOLIC_EMPLEO_ANTERIOR")> Public Class SOLIC_EMPLEO_ANTERIOR
    Inherits entidadBase
    Implements IEquatable(Of SOLIC_EMPLEO_ANTERIOR), IComparable(Of SOLIC_EMPLEO_ANTERIOR)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_EMPLEO_ANT As Decimal, aID_SOLICITUD As Decimal, aTIEMPO_NO_TRABAJA As Decimal)
        Me._ID_EMPLEO_ANT = aID_EMPLEO_ANT
        Me._ID_SOLICITUD = aID_SOLICITUD
        Me._TIEMPO_NO_TRABAJA = aTIEMPO_NO_TRABAJA
    End Sub

    Public Function Equals1(ByVal other As SOLIC_EMPLEO_ANTERIOR) As Boolean Implements System.IEquatable(Of SOLIC_EMPLEO_ANTERIOR).Equals
        Return Me.ID_EMPLEO_ANT = other.ID_EMPLEO_ANT
    End Function

    Public Function CompareTo(ByVal other As SOLIC_EMPLEO_ANTERIOR) As Integer Implements System.IComparable(Of SOLIC_EMPLEO_ANTERIOR).CompareTo
        If Me.ID_EMPLEO_ANT > other.ID_EMPLEO_ANT Then Return 1
        If Me.ID_EMPLEO_ANT < other.ID_EMPLEO_ANT Then Return -1
        Return 0
    End Function


#Region " Properties "

    Private _ID_EMPLEO_ANT As Decimal
    <Column(Name:="Id empleo ant", Storage:="ID_EMPLEO_ANT", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_EMPLEO_ANT() As Decimal
        Get
            Return _ID_EMPLEO_ANT
        End Get
        Set(ByVal Value As Decimal)
            _ID_EMPLEO_ANT = Value
            OnPropertyChanged("ID_EMPLEO_ANT")
        End Set
    End Property 

    Private _ID_SOLICITUD As Decimal
    <Column(Name:="Id solicitud", Storage:="ID_SOLICITUD", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=8, Scale:=0)> _
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

    Private _fkID_SOLICITUD As SOLICITUD_INSCRIPCION_AF
    Public Property fkID_SOLICITUD() As SOLICITUD_INSCRIPCION_AF
        Get
            Return _fkID_SOLICITUD
        End Get
        Set(ByVal Value As SOLICITUD_INSCRIPCION_AF)
            _fkID_SOLICITUD = Value
        End Set
    End Property 

    Private _TIEMPO_NO_TRABAJA As Decimal
    <Column(Name:="Tiempo no trabaja", Storage:="TIEMPO_NO_TRABAJA", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=1, Scale:=0)> _
    Public Property TIEMPO_NO_TRABAJA() As Decimal
        Get
            Return _TIEMPO_NO_TRABAJA
        End Get
        Set(ByVal Value As Decimal)
            _TIEMPO_NO_TRABAJA = Value
            OnPropertyChanged("TIEMPO_NO_TRABAJA")
        End Set
    End Property 

    Private _TIEMPO_NO_TRABAJAOld As Decimal
    Public Property TIEMPO_NO_TRABAJAOld() As Decimal
        Get
            Return _TIEMPO_NO_TRABAJAOld
        End Get
        Set(ByVal Value As Decimal)
            _TIEMPO_NO_TRABAJAOld = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
