''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.PAQUETE_INFORME_DET
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite tener un registro de la tabla PAQUETE_INFORME_DET en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.6.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	26/08/2010	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="PAQUETE_INFORME_DET")> Public Class PAQUETE_INFORME_DET
    Inherits entidadBase
    Implements IEquatable(Of PAQUETE_INFORME_DET), IComparable(Of PAQUETE_INFORME_DET)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_PAQUETE As Decimal, aID_INFORME_FINAL As Decimal, aLASTUPDATE As DateTime, aUSERID As String)
        Me._ID_PAQUETE = aID_PAQUETE
        Me._ID_INFORME_FINAL = aID_INFORME_FINAL
        Me._LASTUPDATE = aLASTUPDATE
        Me._USERID = aUSERID
    End Sub

    Public Function Equals1(ByVal other As PAQUETE_INFORME_DET) As Boolean Implements System.IEquatable(Of PAQUETE_INFORME_DET).Equals
        Return Me.ID_PAQUETE = other.ID_PAQUETE And Me.ID_INFORME_FINAL = other.ID_INFORME_FINAL
    End Function

    Public Function CompareTo(ByVal other As PAQUETE_INFORME_DET) As Integer Implements System.IComparable(Of PAQUETE_INFORME_DET).CompareTo
        If Me.ID_PAQUETE > other.ID_PAQUETE Then
            If Me.ID_INFORME_FINAL > other.ID_INFORME_FINAL Then Return 1
            If Me.ID_INFORME_FINAL < other.ID_INFORME_FINAL Then Return -1
        Else
            Return -1
        End If
        Return 0
    End Function


#Region " Propiedades "

    Private _ID_PAQUETE As Decimal
    <Column(Name:="Id paquete", Storage:="ID_PAQUETE", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_PAQUETE() As Decimal
        Get
            Return _ID_PAQUETE
        End Get
        Set(ByVal Value As Decimal)
            _ID_PAQUETE = Value
            OnPropertyChanged("ID_PAQUETE")
        End Set
    End Property 

    Private _fkID_PAQUETE As PAQUETE_INFORME
    Public Property fkID_PAQUETE() As PAQUETE_INFORME
        Get
            Return _fkID_PAQUETE
        End Get
        Set(ByVal Value As PAQUETE_INFORME)
            _fkID_PAQUETE = Value
        End Set
    End Property 

    Private _ID_INFORME_FINAL As Decimal
    <Column(Name:="Id informe final", Storage:="ID_INFORME_FINAL", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_INFORME_FINAL() As Decimal
        Get
            Return _ID_INFORME_FINAL
        End Get
        Set(ByVal Value As Decimal)
            _ID_INFORME_FINAL = Value
            OnPropertyChanged("ID_INFORME_FINAL")
        End Set
    End Property 

    Private _fkID_INFORME_FINAL As INFORME_FINAL_AF
    Public Property fkID_INFORME_FINAL() As INFORME_FINAL_AF
        Get
            Return _fkID_INFORME_FINAL
        End Get
        Set(ByVal Value As INFORME_FINAL_AF)
            _fkID_INFORME_FINAL = Value
        End Set
    End Property 

    Private _LASTUPDATE As DateTime
    <Column(Name:="Lastupdate", Storage:="LASTUPDATE", DbType:="DATE", Id:=False), _
     DataObjectField(False, False, True)> _
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

    Private _USERID As String
    <Column(Name:="Userid", Storage:="USERID", DbType:="VARCHAR2(256)", Id:=False), _
     DataObjectField(False, False, True, 256)> _
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

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
