''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.CONTRATO_BOLPROS
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row CONTRATO_BOLPROS en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/04/2019	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="CONTRATO_BOLPROS")> Public Class CONTRATO_BOLPROS
    Inherits entidadBase
    Implements IEquatable(Of CONTRATO_BOLPROS), IComparable(Of CONTRATO_BOLPROS)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_CONTRATO As Decimal, aID_PROVEEDOR_AF As Decimal, aID_PROGRAMA_FORMACION As Decimal, aID_FUENTE As Decimal, aNUM_CONTRATO As String, aMONTO As Decimal, aLOTE As String, aSUB_LOTE As String, aUSUARIO_CREACION As String, aFECHA_CREACION As DateTime, aUSERID As String, aLASTUPDATE As DateTime, aID_TIPO_CONTRA As Decimal, aID_OFERTA_COMPRA As Decimal, aID_CONTRATO_COMPRA As Decimal, aFECHA_INI_EJEC As DateTime, aFECHA_FIN_EJEC As DateTime, aES_PAGO_PARTICIPANTE As Decimal, aID_TIPO_ADJ As Decimal, aCOSTO_X_PARTICIPANTE As Decimal, aPARTICIPACIONES As Decimal, aES_INCREMENTO As Decimal, aNO_PRODUCTO As Decimal)
        Me._ID_CONTRATO = aID_CONTRATO
        Me._ID_PROVEEDOR_AF = aID_PROVEEDOR_AF
        Me._ID_PROGRAMA_FORMACION = aID_PROGRAMA_FORMACION
        Me._ID_FUENTE = aID_FUENTE
        Me._NUM_CONTRATO = aNUM_CONTRATO
        Me._MONTO = aMONTO
        Me._LOTE = aLOTE
        Me._SUB_LOTE = aSUB_LOTE
        Me._USUARIO_CREACION = aUSUARIO_CREACION
        Me._FECHA_CREACION = aFECHA_CREACION
        Me._USERID = aUSERID
        Me._LASTUPDATE = aLASTUPDATE
        Me._ID_TIPO_CONTRA = aID_TIPO_CONTRA
        Me._ID_OFERTA_COMPRA = aID_OFERTA_COMPRA
        Me._ID_CONTRATO_COMPRA = aID_CONTRATO_COMPRA
        Me._FECHA_INI_EJEC = aFECHA_INI_EJEC
        Me._FECHA_FIN_EJEC = aFECHA_FIN_EJEC
        Me._ES_PAGO_PARTICIPANTE = aES_PAGO_PARTICIPANTE
        Me._ID_TIPO_ADJ = aID_TIPO_ADJ
        Me._COSTO_X_PARTICIPANTE = aCOSTO_X_PARTICIPANTE
        Me._PARTICIPACIONES = aPARTICIPACIONES
        Me._ES_INCREMENTO = aES_INCREMENTO
        Me._NO_PRODUCTO = aNO_PRODUCTO
    End Sub

    Public Function Equals1(ByVal other As CONTRATO_BOLPROS) As Boolean Implements System.IEquatable(Of CONTRATO_BOLPROS).Equals
        Return Me.ID_CONTRATO = other.ID_CONTRATO
    End Function

    Public Function CompareTo(ByVal other As CONTRATO_BOLPROS) As Integer Implements System.IComparable(Of CONTRATO_BOLPROS).CompareTo
        If Me.ID_CONTRATO > other.ID_CONTRATO Then Return 1
        If Me.ID_CONTRATO < other.ID_CONTRATO Then Return -1
        Return 0
    End Function


#Region " Properties "

    Private _ID_CONTRATO As Decimal
    <Column(Name:="Id contrato", Storage:="ID_CONTRATO", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=38, Scale:=0)> _
    Public Property ID_CONTRATO() As Decimal
        Get
            Return _ID_CONTRATO
        End Get
        Set(ByVal Value As Decimal)
            _ID_CONTRATO = Value
            OnPropertyChanged("ID_CONTRATO")
        End Set
    End Property 

    Private _ID_PROVEEDOR_AF As Decimal
    <Column(Name:="Id proveedor af", Storage:="ID_PROVEEDOR_AF", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=38, Scale:=0)> _
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

    Private _ID_PROGRAMA_FORMACION As Decimal
    <Column(Name:="Id programa formacion", Storage:="ID_PROGRAMA_FORMACION", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_PROGRAMA_FORMACION() As Decimal
        Get
            Return _ID_PROGRAMA_FORMACION
        End Get
        Set(ByVal Value As Decimal)
            _ID_PROGRAMA_FORMACION = Value
            OnPropertyChanged("ID_PROGRAMA_FORMACION")
        End Set
    End Property 

    Private _ID_PROGRAMA_FORMACIONOld As Decimal
    Public Property ID_PROGRAMA_FORMACIONOld() As Decimal
        Get
            Return _ID_PROGRAMA_FORMACIONOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_PROGRAMA_FORMACIONOld = Value
        End Set
    End Property 

    Private _fkID_PROGRAMA_FORMACION As PROGRAMA_FORMACION
    Public Property fkID_PROGRAMA_FORMACION() As PROGRAMA_FORMACION
        Get
            Return _fkID_PROGRAMA_FORMACION
        End Get
        Set(ByVal Value As PROGRAMA_FORMACION)
            _fkID_PROGRAMA_FORMACION = Value
        End Set
    End Property 

    Private _ID_FUENTE As Decimal
    <Column(Name:="Id fuente", Storage:="ID_FUENTE", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_FUENTE() As Decimal
        Get
            Return _ID_FUENTE
        End Get
        Set(ByVal Value As Decimal)
            _ID_FUENTE = Value
            OnPropertyChanged("ID_FUENTE")
        End Set
    End Property 

    Private _ID_FUENTEOld As Decimal
    Public Property ID_FUENTEOld() As Decimal
        Get
            Return _ID_FUENTEOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_FUENTEOld = Value
        End Set
    End Property 

    Private _fkID_FUENTE As FUENTE_FINANCIAMIENTO
    Public Property fkID_FUENTE() As FUENTE_FINANCIAMIENTO
        Get
            Return _fkID_FUENTE
        End Get
        Set(ByVal Value As FUENTE_FINANCIAMIENTO)
            _fkID_FUENTE = Value
        End Set
    End Property 

    Private _NUM_CONTRATO As String
    <Column(Name:="Num contrato", Storage:="NUM_CONTRATO", DbType:="VARCHAR2(15) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 15)> _
    Public Property NUM_CONTRATO() As String
        Get
            Return _NUM_CONTRATO
        End Get
        Set(ByVal Value As String)
            _NUM_CONTRATO = Value
            OnPropertyChanged("NUM_CONTRATO")
        End Set
    End Property

    Private _NUM_CONTRATOOld As String
    Public Property NUM_CONTRATOOld() As String
        Get
            Return _NUM_CONTRATOOld
        End Get
        Set(ByVal Value As String)
            _NUM_CONTRATOOld = Value
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

    Private _LOTE As String
    <Column(Name:="Lote", Storage:="LOTE", DbType:="VARCHAR2(5)", Id:=False), _
     DataObjectField(False, False, True, 5)> _
    Public Property LOTE() As String
        Get
            Return _LOTE
        End Get
        Set(ByVal Value As String)
            _LOTE = Value
            OnPropertyChanged("LOTE")
        End Set
    End Property 

    Private _LOTEOld As String
    Public Property LOTEOld() As String
        Get
            Return _LOTEOld
        End Get
        Set(ByVal Value As String)
            _LOTEOld = Value
        End Set
    End Property 

    Private _SUB_LOTE As String
    <Column(Name:="Sub lote", Storage:="SUB_LOTE", DbType:="VARCHAR2(5)", Id:=False), _
     DataObjectField(False, False, True, 5)> _
    Public Property SUB_LOTE() As String
        Get
            Return _SUB_LOTE
        End Get
        Set(ByVal Value As String)
            _SUB_LOTE = Value
            OnPropertyChanged("SUB_LOTE")
        End Set
    End Property 

    Private _SUB_LOTEOld As String
    Public Property SUB_LOTEOld() As String
        Get
            Return _SUB_LOTEOld
        End Get
        Set(ByVal Value As String)
            _SUB_LOTEOld = Value
        End Set
    End Property 

    Private _USUARIO_CREACION As String
    <Column(Name:="Usuario creacion", Storage:="USUARIO_CREACION", DbType:="VARCHAR2(255) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 255)> _
    Public Property USUARIO_CREACION() As String
        Get
            Return _USUARIO_CREACION
        End Get
        Set(ByVal Value As String)
            _USUARIO_CREACION = Value
            OnPropertyChanged("USUARIO_CREACION")
        End Set
    End Property 

    Private _USUARIO_CREACIONOld As String
    Public Property USUARIO_CREACIONOld() As String
        Get
            Return _USUARIO_CREACIONOld
        End Get
        Set(ByVal Value As String)
            _USUARIO_CREACIONOld = Value
        End Set
    End Property 

    Private _FECHA_CREACION As DateTime
    <Column(Name:="Fecha creacion", Storage:="FECHA_CREACION", DbType:="DATE NOT NULL", Id:=False), _
     DataObjectField(False, False, False)> _
    Public Property FECHA_CREACION() As DateTime
        Get
            Return _FECHA_CREACION
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_CREACION = Value
            OnPropertyChanged("FECHA_CREACION")
        End Set
    End Property 

    Private _FECHA_CREACIONOld As DateTime
    Public Property FECHA_CREACIONOld() As DateTime
        Get
            Return _FECHA_CREACIONOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_CREACIONOld = Value
        End Set
    End Property 

    Private _USERID As String
    <Column(Name:="Userid", Storage:="USERID", DbType:="VARCHAR2(255) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 255)> _
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

    Private _ID_TIPO_CONTRA As Decimal
    <Column(Name:="Id tipo contra", Storage:="ID_TIPO_CONTRA", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=2, Scale:=0)> _
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

    Private _ID_OFERTA_COMPRA As Decimal
    <Column(Name:="Id oferta compra", Storage:="ID_OFERTA_COMPRA", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_OFERTA_COMPRA() As Decimal
        Get
            Return _ID_OFERTA_COMPRA
        End Get
        Set(ByVal Value As Decimal)
            _ID_OFERTA_COMPRA = Value
            OnPropertyChanged("ID_OFERTA_COMPRA")
        End Set
    End Property 

    Private _ID_OFERTA_COMPRAOld As Decimal
    Public Property ID_OFERTA_COMPRAOld() As Decimal
        Get
            Return _ID_OFERTA_COMPRAOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_OFERTA_COMPRAOld = Value
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

    Private _FECHA_INI_EJEC As DateTime
    <Column(Name:="Fecha ini ejec", Storage:="FECHA_INI_EJEC", DbType:="DATE", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property FECHA_INI_EJEC() As DateTime
        Get
            Return _FECHA_INI_EJEC
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_INI_EJEC = Value
            OnPropertyChanged("FECHA_INI_EJEC")
        End Set
    End Property 

    Private _FECHA_INI_EJECOld As DateTime
    Public Property FECHA_INI_EJECOld() As DateTime
        Get
            Return _FECHA_INI_EJECOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_INI_EJECOld = Value
        End Set
    End Property 

    Private _FECHA_FIN_EJEC As DateTime
    <Column(Name:="Fecha fin ejec", Storage:="FECHA_FIN_EJEC", DbType:="DATE", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property FECHA_FIN_EJEC() As DateTime
        Get
            Return _FECHA_FIN_EJEC
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_FIN_EJEC = Value
            OnPropertyChanged("FECHA_FIN_EJEC")
        End Set
    End Property 

    Private _FECHA_FIN_EJECOld As DateTime
    Public Property FECHA_FIN_EJECOld() As DateTime
        Get
            Return _FECHA_FIN_EJECOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_FIN_EJECOld = Value
        End Set
    End Property 

    Private _ES_PAGO_PARTICIPANTE As Decimal
    <Column(Name:="Es pago participante", Storage:="ES_PAGO_PARTICIPANTE", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=1, Scale:=0)> _
    Public Property ES_PAGO_PARTICIPANTE() As Decimal
        Get
            Return _ES_PAGO_PARTICIPANTE
        End Get
        Set(ByVal Value As Decimal)
            _ES_PAGO_PARTICIPANTE = Value
            OnPropertyChanged("ES_PAGO_PARTICIPANTE")
        End Set
    End Property 

    Private _ES_PAGO_PARTICIPANTEOld As Decimal
    Public Property ES_PAGO_PARTICIPANTEOld() As Decimal
        Get
            Return _ES_PAGO_PARTICIPANTEOld
        End Get
        Set(ByVal Value As Decimal)
            _ES_PAGO_PARTICIPANTEOld = Value
        End Set
    End Property 

    Private _ID_TIPO_ADJ As Decimal
    <Column(Name:="Id tipo adj", Storage:="ID_TIPO_ADJ", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_TIPO_ADJ() As Decimal
        Get
            Return _ID_TIPO_ADJ
        End Get
        Set(ByVal Value As Decimal)
            _ID_TIPO_ADJ = Value
            OnPropertyChanged("ID_TIPO_ADJ")
        End Set
    End Property 

    Private _ID_TIPO_ADJOld As Decimal
    Public Property ID_TIPO_ADJOld() As Decimal
        Get
            Return _ID_TIPO_ADJOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_TIPO_ADJOld = Value
        End Set
    End Property 

    Private _fkID_TIPO_ADJ As TIPO_ADJUDICACION
    Public Property fkID_TIPO_ADJ() As TIPO_ADJUDICACION
        Get
            Return _fkID_TIPO_ADJ
        End Get
        Set(ByVal Value As TIPO_ADJUDICACION)
            _fkID_TIPO_ADJ = Value
        End Set
    End Property 

    Private _COSTO_X_PARTICIPANTE As Decimal
    <Column(Name:="Costo x participante", Storage:="COSTO_X_PARTICIPANTE", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=6)> _
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

    Private _PARTICIPACIONES As Decimal
    <Column(Name:="Participaciones", Storage:="PARTICIPACIONES", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=0, Scale:=0)> _
    Public Property PARTICIPACIONES() As Decimal
        Get
            Return _PARTICIPACIONES
        End Get
        Set(ByVal Value As Decimal)
            _PARTICIPACIONES = Value
            OnPropertyChanged("PARTICIPACIONES")
        End Set
    End Property 

    Private _PARTICIPACIONESOld As Decimal
    Public Property PARTICIPACIONESOld() As Decimal
        Get
            Return _PARTICIPACIONESOld
        End Get
        Set(ByVal Value As Decimal)
            _PARTICIPACIONESOld = Value
        End Set
    End Property



    Private _ES_INCREMENTO As Decimal
    <Column(Name:="ES_INCREMENTO", Storage:="ES_INCREMENTO", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=0, Scale:=0)> _
    Public Property ES_INCREMENTO() As Decimal
        Get
            Return _ES_INCREMENTO
        End Get
        Set(ByVal Value As Decimal)
            _ES_INCREMENTO = Value
            OnPropertyChanged("ES_INCREMENTO")
        End Set
    End Property

    Private _ES_INCREMENTOOld As Decimal
    Public Property ES_INCREMENTOOld() As Decimal
        Get
            Return _ES_INCREMENTOOld
        End Get
        Set(ByVal Value As Decimal)
            _ES_INCREMENTOOld = Value
        End Set
    End Property


    Private _NO_PRODUCTO As Decimal
    <Column(Name:="NO_PRODUCTO", Storage:="NO_PRODUCTO", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=0, Scale:=0)> _
    Public Property NO_PRODUCTO() As Decimal
        Get
            Return _NO_PRODUCTO
        End Get
        Set(ByVal Value As Decimal)
            _NO_PRODUCTO = Value
            OnPropertyChanged("NO_PRODUCTO")
        End Set
    End Property

    Private _NO_PRODUCTOOld As Decimal
    Public Property NO_PRODUCTOOld() As Decimal
        Get
            Return _NO_PRODUCTOOld
        End Get
        Set(ByVal Value As Decimal)
            _NO_PRODUCTOOld = Value
        End Set
    End Property

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
