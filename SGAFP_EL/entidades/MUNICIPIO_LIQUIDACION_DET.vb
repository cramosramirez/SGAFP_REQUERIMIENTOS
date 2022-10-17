''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.MUNICIPIO_LIQUIDACION_DET
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row MUNICIPIO_LIQUIDACION_DET en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	10/09/2011	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="MUNICIPIO_LIQUIDACION_DET")> Public Class MUNICIPIO_LIQUIDACION_DET
    Inherits entidadBase
    Implements IEquatable(Of MUNICIPIO_LIQUIDACION_DET), IComparable(Of MUNICIPIO_LIQUIDACION_DET)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_LIQUIDACION_DET As Decimal, aID_LIQUIDACION As Decimal, aID_ACCION_FORMATIVA As Decimal, aCOSTO_X_PARTICIPANTE As Decimal, aTOTAL_PAGAR As Decimal, aUSERID As String, aLASTUPDATE As DateTime)
        Me._ID_LIQUIDACION_DET = aID_LIQUIDACION_DET
        Me._ID_LIQUIDACION = aID_LIQUIDACION
        Me._ID_ACCION_FORMATIVA = aID_ACCION_FORMATIVA
        Me._COSTO_X_PARTICIPANTE = aCOSTO_X_PARTICIPANTE
        Me._TOTAL_PAGAR = aTOTAL_PAGAR
        Me._USERID = aUSERID
        Me._LASTUPDATE = aLASTUPDATE
    End Sub

    Public Function Equals1(ByVal other As MUNICIPIO_LIQUIDACION_DET) As Boolean Implements System.IEquatable(Of MUNICIPIO_LIQUIDACION_DET).Equals
        Return Me.ID_LIQUIDACION_DET = other.ID_LIQUIDACION_DET
    End Function

    Public Function CompareTo(ByVal other As MUNICIPIO_LIQUIDACION_DET) As Integer Implements System.IComparable(Of MUNICIPIO_LIQUIDACION_DET).CompareTo
        If Me.ID_LIQUIDACION_DET > other.ID_LIQUIDACION_DET Then Return 1
        If Me.ID_LIQUIDACION_DET < other.ID_LIQUIDACION_DET Then Return -1
        Return 0
    End Function


#Region " Properties "

    Private _ID_LIQUIDACION_DET As Decimal
    <Column(Name:="Id liquidacion det", Storage:="ID_LIQUIDACION_DET", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_LIQUIDACION_DET() As Decimal
        Get
            Return _ID_LIQUIDACION_DET
        End Get
        Set(ByVal Value As Decimal)
            _ID_LIQUIDACION_DET = Value
            OnPropertyChanged("ID_LIQUIDACION_DET")
        End Set
    End Property 

    Private _ID_LIQUIDACION As Decimal
    <Column(Name:="Id liquidacion", Storage:="ID_LIQUIDACION", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_LIQUIDACION() As Decimal
        Get
            Return _ID_LIQUIDACION
        End Get
        Set(ByVal Value As Decimal)
            _ID_LIQUIDACION = Value
            OnPropertyChanged("ID_LIQUIDACION")
        End Set
    End Property 

    Private _ID_LIQUIDACIONOld As Decimal
    Public Property ID_LIQUIDACIONOld() As Decimal
        Get
            Return _ID_LIQUIDACIONOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_LIQUIDACIONOld = Value
        End Set
    End Property 

    Private _fkID_LIQUIDACION As MUNICIPIO_LIQUIDACION
    Public Property fkID_LIQUIDACION() As MUNICIPIO_LIQUIDACION
        Get
            Return _fkID_LIQUIDACION
        End Get
        Set(ByVal Value As MUNICIPIO_LIQUIDACION)
            _fkID_LIQUIDACION = Value
        End Set
    End Property 

    Private _ID_ACCION_FORMATIVA As Decimal
    <Column(Name:="Id accion formativa", Storage:="ID_ACCION_FORMATIVA", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=8, Scale:=0)> _
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

    Private _COSTO_X_PARTICIPANTE As Decimal
    <Column(Name:="Costo x participante", Storage:="COSTO_X_PARTICIPANTE", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=5, Scale:=2)> _
    Public Property COSTO_X_PARTICIPANTE() As Decimal
        Get
            Return _COSTO_X_PARTICIPANTE
        End Get
        Set(ByVal Value As Decimal)
            _COSTO_X_PARTICIPANTE = Value
            OnPropertyChanged("COSTO_X_PARTICIPANTE")
        End Set
    End Property 

    Private _COSTO_X_PARTICIPANTEOld As Decimal
    Public Property COSTO_X_PARTICIPANTEOld() As Decimal
        Get
            Return _COSTO_X_PARTICIPANTEOld
        End Get
        Set(ByVal Value As Decimal)
            _COSTO_X_PARTICIPANTEOld = Value
        End Set
    End Property 

    Private _TOTAL_PAGAR As Decimal
    <Column(Name:="Total pagar", Storage:="TOTAL_PAGAR", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=2)> _
    Public Property TOTAL_PAGAR() As Decimal
        Get
            Return _TOTAL_PAGAR
        End Get
        Set(ByVal Value As Decimal)
            _TOTAL_PAGAR = Value
            OnPropertyChanged("TOTAL_PAGAR")
        End Set
    End Property 

    Private _TOTAL_PAGAROld As Decimal
    Public Property TOTAL_PAGAROld() As Decimal
        Get
            Return _TOTAL_PAGAROld
        End Get
        Set(ByVal Value As Decimal)
            _TOTAL_PAGAROld = Value
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

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
