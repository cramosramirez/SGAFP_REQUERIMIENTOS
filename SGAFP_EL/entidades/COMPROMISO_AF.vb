''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.COMPROMISO_AF
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row COMPROMISO_AF en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	07/03/2012	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="COMPROMISO_AF")> Public Class COMPROMISO_AF
    Inherits entidadBase
    Implements IEquatable(Of COMPROMISO_AF), IComparable(Of COMPROMISO_AF)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(ByVal aID_COMPROMISO As Decimal, ByVal aID_INFORME_FINAL_AF As Decimal, ByVal aMONTO_DEVENGADO As Decimal, ByVal aUSERID As String, ByVal aLASTUPDATE As DateTime)
        Me._ID_COMPROMISO = aID_COMPROMISO
        Me._ID_INFORME_FINAL = aID_INFORME_FINAL_AF
        Me._MONTO_DEVENGADO = aMONTO_DEVENGADO
        Me._USERID = aUSERID
        Me._LASTUPDATE = aLASTUPDATE
    End Sub

    Public Function Equals1(ByVal other As COMPROMISO_AF) As Boolean Implements System.IEquatable(Of COMPROMISO_AF).Equals
        Return Me.ID_COMPROMISO = other.ID_COMPROMISO And Me.ID_INFORME_FINAL = other.ID_INFORME_FINAL
    End Function

    Public Function CompareTo(ByVal other As COMPROMISO_AF) As Integer Implements System.IComparable(Of COMPROMISO_AF).CompareTo
        If Me.ID_COMPROMISO > other.ID_COMPROMISO Then
            If Me.ID_INFORME_FINAL > other.ID_INFORME_FINAL Then Return 1
            If Me.ID_INFORME_FINAL < other.ID_INFORME_FINAL Then Return -1
        Else
            Return -1
        End If
        Return 0
    End Function


#Region " Properties "

    Private _ID_COMPROMISO As Decimal
    <Column(Name:="Id compromiso", Storage:="ID_COMPROMISO", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_COMPROMISO() As Decimal
        Get
            Return _ID_COMPROMISO
        End Get
        Set(ByVal Value As Decimal)
            _ID_COMPROMISO = Value
            OnPropertyChanged("ID_COMPROMISO")
        End Set
    End Property 

    Private _fkID_COMPROMISO As COMPROMISO_CONTRATO
    Public Property fkID_COMPROMISO() As COMPROMISO_CONTRATO
        Get
            Return _fkID_COMPROMISO
        End Get
        Set(ByVal Value As COMPROMISO_CONTRATO)
            _fkID_COMPROMISO = Value
        End Set
    End Property 

    Private _ID_INFORME_FINAL As Decimal
    <Column(Name:="Id Informe Final", Storage:="ID_INFORME_FINAL", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_INFORME_FINAL() As Decimal
        Get
            Return _ID_INFORME_FINAL
        End Get
        Set(ByVal Value As Decimal)
            _ID_INFORME_FINAL = Value
            OnPropertyChanged("ID_INFORME_FINAL")
        End Set
    End Property

    Private _MONTO_DEVENGADO As Decimal
    <Column(Name:="Monto devengado", Storage:="MONTO_DEVENGADO", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=2)> _
    Public Property MONTO_DEVENGADO() As Decimal
        Get
            Return _MONTO_DEVENGADO
        End Get
        Set(ByVal Value As Decimal)
            _MONTO_DEVENGADO = Value
            OnPropertyChanged("MONTO_DEVENGADO")
        End Set
    End Property 

    Private _MONTO_DEVENGADOOld As Decimal
    Public Property MONTO_DEVENGADOOld() As Decimal
        Get
            Return _MONTO_DEVENGADOOld
        End Get
        Set(ByVal Value As Decimal)
            _MONTO_DEVENGADOOld = Value
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
