''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.OFERTA_FORMATIVA_DEPTO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row OFERTA_FORMATIVA_DEPTO en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	04/12/2012	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="OFERTA_FORMATIVA_DEPTO")> Public Class OFERTA_FORMATIVA_DEPTO
    Inherits entidadBase
    Implements IEquatable(Of OFERTA_FORMATIVA_DEPTO), IComparable(Of OFERTA_FORMATIVA_DEPTO)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_OFERTA_FORMATIVA_DEPTO As Decimal, aID_OFERTA_FORMATIVA As Decimal, aID_PROVEEDOR_AF As Decimal, aCODIGO_DEPARTAMENTO As String, aPARTI_ADJUDICADA As Decimal, aMONTO_ADJUDICADO As Decimal, aUSERID As String, aLASTUPDATE As DateTime)
        Me._ID_OFERTA_FORMATIVA_DEPTO = aID_OFERTA_FORMATIVA_DEPTO
        Me._ID_OFERTA_FORMATIVA = aID_OFERTA_FORMATIVA
        Me._ID_PROVEEDOR_AF = aID_PROVEEDOR_AF
        Me._CODIGO_DEPARTAMENTO = aCODIGO_DEPARTAMENTO
        Me._PARTI_ADJUDICADA = aPARTI_ADJUDICADA
        Me._MONTO_ADJUDICADO = aMONTO_ADJUDICADO
        Me._USERID = aUSERID
        Me._LASTUPDATE = aLASTUPDATE
    End Sub

    Public Function Equals1(ByVal other As OFERTA_FORMATIVA_DEPTO) As Boolean Implements System.IEquatable(Of OFERTA_FORMATIVA_DEPTO).Equals
        Return Me.ID_OFERTA_FORMATIVA_DEPTO = other.ID_OFERTA_FORMATIVA_DEPTO
    End Function

    Public Function CompareTo(ByVal other As OFERTA_FORMATIVA_DEPTO) As Integer Implements System.IComparable(Of OFERTA_FORMATIVA_DEPTO).CompareTo
        If Me.ID_OFERTA_FORMATIVA_DEPTO > other.ID_OFERTA_FORMATIVA_DEPTO Then Return 1
        If Me.ID_OFERTA_FORMATIVA_DEPTO < other.ID_OFERTA_FORMATIVA_DEPTO Then Return -1
        Return 0
    End Function


#Region " Properties "

    Private _ID_OFERTA_FORMATIVA_DEPTO As Decimal
    <Column(Name:="Id oferta formativa depto", Storage:="ID_OFERTA_FORMATIVA_DEPTO", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_OFERTA_FORMATIVA_DEPTO() As Decimal
        Get
            Return _ID_OFERTA_FORMATIVA_DEPTO
        End Get
        Set(ByVal Value As Decimal)
            _ID_OFERTA_FORMATIVA_DEPTO = Value
            OnPropertyChanged("ID_OFERTA_FORMATIVA_DEPTO")
        End Set
    End Property 

    Private _ID_OFERTA_FORMATIVA As Decimal
    <Column(Name:="Id oferta formativa", Storage:="ID_OFERTA_FORMATIVA", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_OFERTA_FORMATIVA() As Decimal
        Get
            Return _ID_OFERTA_FORMATIVA
        End Get
        Set(ByVal Value As Decimal)
            _ID_OFERTA_FORMATIVA = Value
            OnPropertyChanged("ID_OFERTA_FORMATIVA")
        End Set
    End Property 

    Private _ID_OFERTA_FORMATIVAOld As Decimal
    Public Property ID_OFERTA_FORMATIVAOld() As Decimal
        Get
            Return _ID_OFERTA_FORMATIVAOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_OFERTA_FORMATIVAOld = Value
        End Set
    End Property 

    Private _fkID_OFERTA_FORMATIVA As OFERTA_FORMATIVA
    Public Property fkID_OFERTA_FORMATIVA() As OFERTA_FORMATIVA
        Get
            Return _fkID_OFERTA_FORMATIVA
        End Get
        Set(ByVal Value As OFERTA_FORMATIVA)
            _fkID_OFERTA_FORMATIVA = Value
        End Set
    End Property 

    Private _ID_PROVEEDOR_AF As Decimal
    <Column(Name:="Id proveedor af", Storage:="ID_PROVEEDOR_AF", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_PROVEEDOR_AF() As Decimal
        Get
            Return _ID_PROVEEDOR_AF
        End Get
        Set(ByVal Value As Decimal)
            _ID_PROVEEDOR_AF = Value
            OnPropertyChanged("ID_PROVEEDOR_AF")
        End Set
    End Property 

    Private _ID_PROVEEDOR_AFOld As Decimal
    Public Property ID_PROVEEDOR_AFOld() As Decimal
        Get
            Return _ID_PROVEEDOR_AFOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_PROVEEDOR_AFOld = Value
        End Set
    End Property 

    Private _fkID_PROVEEDOR_AF As PROVEEDOR_AF
    Public Property fkID_PROVEEDOR_AF() As PROVEEDOR_AF
        Get
            Return _fkID_PROVEEDOR_AF
        End Get
        Set(ByVal Value As PROVEEDOR_AF)
            _fkID_PROVEEDOR_AF = Value
        End Set
    End Property 

    Private _CODIGO_DEPARTAMENTO As String
    <Column(Name:="Codigo departamento", Storage:="CODIGO_DEPARTAMENTO", DbType:="VARCHAR2(2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 2)> _
    Public Property CODIGO_DEPARTAMENTO() As String
        Get
            Return _CODIGO_DEPARTAMENTO
        End Get
        Set(ByVal Value As String)
            _CODIGO_DEPARTAMENTO = Value
            OnPropertyChanged("CODIGO_DEPARTAMENTO")
        End Set
    End Property 

    Private _CODIGO_DEPARTAMENTOOld As String
    Public Property CODIGO_DEPARTAMENTOOld() As String
        Get
            Return _CODIGO_DEPARTAMENTOOld
        End Get
        Set(ByVal Value As String)
            _CODIGO_DEPARTAMENTOOld = Value
        End Set
    End Property 

    Private _fkCODIGO_DEPARTAMENTO As DEPARTAMENTO
    Public Property fkCODIGO_DEPARTAMENTO() As DEPARTAMENTO
        Get
            Return _fkCODIGO_DEPARTAMENTO
        End Get
        Set(ByVal Value As DEPARTAMENTO)
            _fkCODIGO_DEPARTAMENTO = Value
        End Set
    End Property 

    Private _PARTI_ADJUDICADA As Decimal
    <Column(Name:="Parti adjudicada", Storage:="PARTI_ADJUDICADA", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=8, Scale:=0)> _
    Public Property PARTI_ADJUDICADA() As Decimal
        Get
            Return _PARTI_ADJUDICADA
        End Get
        Set(ByVal Value As Decimal)
            _PARTI_ADJUDICADA = Value
            OnPropertyChanged("PARTI_ADJUDICADA")
        End Set
    End Property 

    Private _PARTI_ADJUDICADAOld As Decimal
    Public Property PARTI_ADJUDICADAOld() As Decimal
        Get
            Return _PARTI_ADJUDICADAOld
        End Get
        Set(ByVal Value As Decimal)
            _PARTI_ADJUDICADAOld = Value
        End Set
    End Property 

    Private _MONTO_ADJUDICADO As Decimal
    <Column(Name:="Monto adjudicado", Storage:="MONTO_ADJUDICADO", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=8, Scale:=0)> _
    Public Property MONTO_ADJUDICADO() As Decimal
        Get
            Return _MONTO_ADJUDICADO
        End Get
        Set(ByVal Value As Decimal)
            _MONTO_ADJUDICADO = Value
            OnPropertyChanged("MONTO_ADJUDICADO")
        End Set
    End Property 

    Private _MONTO_ADJUDICADOOld As Decimal
    Public Property MONTO_ADJUDICADOOld() As Decimal
        Get
            Return _MONTO_ADJUDICADOOld
        End Get
        Set(ByVal Value As Decimal)
            _MONTO_ADJUDICADOOld = Value
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
