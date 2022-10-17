''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.FACTURA_AF
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row FACTURA_AF en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	25/08/2011	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="FACTURA_AF")> Public Class FACTURA_AF
    Inherits entidadBase
    Implements IEquatable(Of FACTURA_AF), IComparable(Of FACTURA_AF)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(ByVal aID_FACTURA_AF As Decimal, ByVal aID_PROVEEDOR_AF As Decimal, ByVal aNUMERO_DOCUMENTO As String, ByVal aTIPO_DOCUMENTO As String, ByVal aFECHA_DOCUMENTO As DateTime, ByVal aNUMERO_QUEDAN As Decimal, ByVal aFECHA_QUEDAN As Date, ByVal aNUMERO_CHEQUE As String, ByVal aFECHA_CHEQUE As Date, ByVal aESTADO As String, ByVal aUSERID As String, ByVal aLASTUPDATE As DateTime, ByVal aOBSERVACION As String)
        Me._ID_FACTURA_AF = aID_FACTURA_AF
        Me._ID_PROVEEDOR_AF = aID_PROVEEDOR_AF
        Me._NUMERO_DOCUMENTO = aNUMERO_DOCUMENTO
        Me._TIPO_DOCUMENTO = aTIPO_DOCUMENTO
        Me._FECHA_DOCUMENTO = aFECHA_DOCUMENTO
        Me._NUMERO_QUEDAN = aNUMERO_QUEDAN
        Me._FECHA_QUEDAN = aFECHA_QUEDAN
        Me._NUMERO_CHEQUE = aNUMERO_CHEQUE
        Me._FECHA_CHEQUE = aFECHA_CHEQUE
        Me._ESTADO = aESTADO
        Me._USERID = aUSERID
        Me._LASTUPDATE = aLASTUPDATE
        Me._OBSERVACION = aOBSERVACION
    End Sub

    Public Function Equals1(ByVal other As FACTURA_AF) As Boolean Implements System.IEquatable(Of FACTURA_AF).Equals
        Return Me.ID_FACTURA_AF = other.ID_FACTURA_AF
    End Function

    Public Function CompareTo(ByVal other As FACTURA_AF) As Integer Implements System.IComparable(Of FACTURA_AF).CompareTo
        If Me.ID_FACTURA_AF > other.ID_FACTURA_AF Then Return 1
        If Me.ID_FACTURA_AF < other.ID_FACTURA_AF Then Return -1
        Return 0
    End Function


#Region " Properties "

    Private _ID_FACTURA_AF As Decimal
    <Column(Name:="Id factura af", Storage:="ID_FACTURA_AF", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_FACTURA_AF() As Decimal
        Get
            Return _ID_FACTURA_AF
        End Get
        Set(ByVal Value As Decimal)
            _ID_FACTURA_AF = Value
            OnPropertyChanged("ID_FACTURA_AF")
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

    Private _NUMERO_DOCUMENTO As String
    <Column(Name:="Numero documento", Storage:="NUMERO_DOCUMENTO", DbType:="CHAR(14) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 14)> _
    Public Property NUMERO_DOCUMENTO() As String
        Get
            Return _NUMERO_DOCUMENTO
        End Get
        Set(ByVal Value As String)
            _NUMERO_DOCUMENTO = Value
            OnPropertyChanged("NUMERO_DOCUMENTO")
        End Set
    End Property 

    Private _NUMERO_DOCUMENTOOld As String
    Public Property NUMERO_DOCUMENTOOld() As String
        Get
            Return _NUMERO_DOCUMENTOOld
        End Get
        Set(ByVal Value As String)
            _NUMERO_DOCUMENTOOld = Value
        End Set
    End Property 

    Private _TIPO_DOCUMENTO As String
    <Column(Name:="Tipo documento", Storage:="TIPO_DOCUMENTO", DbType:="CHAR(1) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 1)> _
    Public Property TIPO_DOCUMENTO() As String
        Get
            Return _TIPO_DOCUMENTO
        End Get
        Set(ByVal Value As String)
            _TIPO_DOCUMENTO = Value
            OnPropertyChanged("TIPO_DOCUMENTO")
        End Set
    End Property 

    Private _TIPO_DOCUMENTOOld As String
    Public Property TIPO_DOCUMENTOOld() As String
        Get
            Return _TIPO_DOCUMENTOOld
        End Get
        Set(ByVal Value As String)
            _TIPO_DOCUMENTOOld = Value
        End Set
    End Property 

    Private _FECHA_DOCUMENTO As DateTime
    <Column(Name:="Fecha documento", Storage:="FECHA_DOCUMENTO", DbType:="DATE NOT NULL", Id:=False), _
     DataObjectField(False, False, False)> _
    Public Property FECHA_DOCUMENTO() As DateTime
        Get
            Return _FECHA_DOCUMENTO
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_DOCUMENTO = Value
            OnPropertyChanged("FECHA_DOCUMENTO")
        End Set
    End Property 

    Private _FECHA_DOCUMENTOOld As DateTime
    Public Property FECHA_DOCUMENTOOld() As DateTime
        Get
            Return _FECHA_DOCUMENTOOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_DOCUMENTOOld = Value
        End Set
    End Property 

    Private _NUMERO_QUEDAN As Decimal
    <Column(Name:="Numero quedan", Storage:="NUMERO_QUEDAN", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=0, Scale:=0)> _
    Public Property NUMERO_QUEDAN() As Decimal
        Get
            Return _NUMERO_QUEDAN
        End Get
        Set(ByVal Value As Decimal)
            _NUMERO_QUEDAN = Value
            OnPropertyChanged("NUMERO_QUEDAN")
        End Set
    End Property 

    Private _NUMERO_QUEDANOld As Decimal
    Public Property NUMERO_QUEDANOld() As Decimal
        Get
            Return _NUMERO_QUEDANOld
        End Get
        Set(ByVal Value As Decimal)
            _NUMERO_QUEDANOld = Value
        End Set
    End Property

    Private _FECHA_QUEDAN As DateTime
    <Column(Name:="Fecha quedan", Storage:="FECHA_QUEDAN", DbType:="DATE", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property FECHA_QUEDAN() As DateTime
        Get
            Return _FECHA_QUEDAN
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_QUEDAN = Value
            OnPropertyChanged("FECHA_QUEDAN")
        End Set
    End Property

    Private _FECHA_QUEDANOld As DateTime
    Public Property FECHA_QUEDANOld() As DateTime
        Get
            Return _FECHA_QUEDANOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_QUEDANOld = Value
        End Set
    End Property

    Private _NUMERO_CHEQUE As String
    <Column(Name:="Numero cheque", Storage:="NUMERO_CHEQUE", DbType:="VARCHAR2(20)", Id:=False), _
     DataObjectField(False, False, True, 20)> _
    Public Property NUMERO_CHEQUE() As String
        Get
            Return _NUMERO_CHEQUE
        End Get
        Set(ByVal Value As String)
            _NUMERO_CHEQUE = Value
            OnPropertyChanged("NUMERO_CHEQUE")
        End Set
    End Property 

    Private _NUMERO_CHEQUEOld As String
    Public Property NUMERO_CHEQUEOld() As String
        Get
            Return _NUMERO_CHEQUEOld
        End Get
        Set(ByVal Value As String)
            _NUMERO_CHEQUEOld = Value
        End Set
    End Property

    Private _FECHA_CHEQUE As DateTime
    <Column(Name:="Fecha cheque", Storage:="FECHA_CHEQUE", DbType:="DATE", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property FECHA_CHEQUE() As DateTime
        Get
            Return _FECHA_CHEQUE
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_CHEQUE = Value
            OnPropertyChanged("FECHA_CHEQUE")
        End Set
    End Property

    Private _FECHA_CHEQUEOld As DateTime
    Public Property FECHA_CHEQUEOld() As DateTime
        Get
            Return _FECHA_CHEQUEOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_CHEQUEOld = Value
        End Set
    End Property

    Private _ESTADO As String
    <Column(Name:="Estado", Storage:="ESTADO", DbType:="CHAR(1)", Id:=False), _
     DataObjectField(False, False, True, 1)> _
    Public Property ESTADO() As String
        Get
            Return _ESTADO
        End Get
        Set(ByVal Value As String)
            _ESTADO = Value
            OnPropertyChanged("ESTADO")
        End Set
    End Property 

    Private _ESTADOOld As String
    Public Property ESTADOOld() As String
        Get
            Return _ESTADOOld
        End Get
        Set(ByVal Value As String)
            _ESTADOOld = Value
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


    Private _OBSERVACION As String
    <Column(Name:="Observacion", Storage:="OBSERVACION", DbType:="VARCHAR2(1000) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 1000)> _
    Public Property OBSERVACION() As String
        Get
            Return _OBSERVACION
        End Get
        Set(ByVal Value As String)
            _OBSERVACION = Value
            OnPropertyChanged("OBSERVACION")
        End Set
    End Property

    Private _OBSERVACIONOld As String
    Public Property OBSERVACIONOld() As String
        Get
            Return _OBSERVACIONOld
        End Get
        Set(ByVal Value As String)
            _OBSERVACIONOld = Value
        End Set
    End Property

#End Region


#End Region
End Class
