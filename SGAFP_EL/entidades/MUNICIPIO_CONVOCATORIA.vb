''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.MUNICIPIO_CONVOCATORIA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row MUNICIPIO_CONVOCATORIA en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	10/09/2011	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="MUNICIPIO_CONVOCATORIA")> Public Class MUNICIPIO_CONVOCATORIA
    Inherits entidadBase
    Implements IEquatable(Of MUNICIPIO_CONVOCATORIA), IComparable(Of MUNICIPIO_CONVOCATORIA)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(ByVal aNO_CONVOCATORIA As Decimal, ByVal aCODIGO_DEPARTAMENTO As String, ByVal aCODIGO_MUNICIPIO As String, ByVal aAPORTE_FISDL As Decimal, ByVal aMONTO_LIQUIDADO As Decimal, ByVal aASESOR_MUNICIPAL As String, ByVal aCODIGO_PROYECTO As String, ByVal aNOMBRE_PROYECTO As String, ByVal aNUMERO_CHEQUE_REINTEGRO As String, ByVal aFECHA_CHEQUE_REINTEGRO As Date, ByVal aUSERID As String, ByVal aLASTUPDATE As DateTime, ByVal aID_FUENTE As Decimal)
        Me._NO_CONVOCATORIA = aNO_CONVOCATORIA
        Me._CODIGO_DEPARTAMENTO = aCODIGO_DEPARTAMENTO
        Me._CODIGO_MUNICIPIO = aCODIGO_MUNICIPIO
        Me._APORTE_FISDL = aAPORTE_FISDL
        Me._MONTO_LIQUIDADO = aMONTO_LIQUIDADO
        Me._ASESOR_MUNICIPAL = aASESOR_MUNICIPAL
        Me._CODIGO_PROYECTO = aCODIGO_PROYECTO
        Me._NOMBRE_PROYECTO = aNOMBRE_PROYECTO
        Me._NUMERO_CHEQUE_REINTEGRO = aNUMERO_CHEQUE_REINTEGRO
        Me._FECHA_CHEQUE_REINTEGRO = aFECHA_CHEQUE_REINTEGRO
        Me._USERID = aUSERID
        Me._LASTUPDATE = aLASTUPDATE
        Me._ID_FUENTE = aID_FUENTE
    End Sub

    Public Function Equals1(ByVal other As MUNICIPIO_CONVOCATORIA) As Boolean Implements System.IEquatable(Of MUNICIPIO_CONVOCATORIA).Equals
        Return Me.NO_CONVOCATORIA = other.NO_CONVOCATORIA And Me.CODIGO_DEPARTAMENTO = other.CODIGO_DEPARTAMENTO And Me.CODIGO_MUNICIPIO = other.CODIGO_MUNICIPIO
    End Function

    Public Function CompareTo(ByVal other As MUNICIPIO_CONVOCATORIA) As Integer Implements System.IComparable(Of MUNICIPIO_CONVOCATORIA).CompareTo
        If Me.NO_CONVOCATORIA > other.NO_CONVOCATORIA Then
            If Me.CODIGO_DEPARTAMENTO > other.CODIGO_DEPARTAMENTO Then
                If Me.CODIGO_MUNICIPIO > other.CODIGO_MUNICIPIO Then Return 1
                If Me.CODIGO_MUNICIPIO < other.CODIGO_MUNICIPIO Then Return -1
            Else
                Return -1
            End If
        Else
            Return -1
        End If
        Return 0
    End Function


#Region " Properties "

    Private _ID_FUENTE As Decimal
    <Column(Name:="Id Fuente", Storage:="ID_FUENTE", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_FUENTE() As Decimal
        Get
            Return _ID_FUENTE
        End Get
        Set(ByVal Value As Decimal)
            _ID_FUENTE = Value
            OnPropertyChanged("ID_FUENTE")
        End Set
    End Property


    Private _NO_CONVOCATORIA As Decimal
    <Column(Name:="No convocatoria", Storage:="NO_CONVOCATORIA", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property NO_CONVOCATORIA() As Decimal
        Get
            Return _NO_CONVOCATORIA
        End Get
        Set(ByVal Value As Decimal)
            _NO_CONVOCATORIA = Value
            OnPropertyChanged("NO_CONVOCATORIA")
        End Set
    End Property

    Private _CODIGO_DEPARTAMENTO As String
    <Column(Name:="Codigo departamento", Storage:="CODIGO_DEPARTAMENTO", DbType:="VARCHAR2(2) NOT NULL", Id:=True), _
     DataObjectField(True, False, False, 2)> _
    Public Property CODIGO_DEPARTAMENTO() As String
        Get
            Return _CODIGO_DEPARTAMENTO
        End Get
        Set(ByVal Value As String)
            _CODIGO_DEPARTAMENTO = Value
            OnPropertyChanged("CODIGO_DEPARTAMENTO")
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

    Private _CODIGO_MUNICIPIO As String
    <Column(Name:="Codigo municipio", Storage:="CODIGO_MUNICIPIO", DbType:="VARCHAR2(2) NOT NULL", Id:=True), _
     DataObjectField(True, False, False, 2)> _
    Public Property CODIGO_MUNICIPIO() As String
        Get
            Return _CODIGO_MUNICIPIO
        End Get
        Set(ByVal Value As String)
            _CODIGO_MUNICIPIO = Value
            OnPropertyChanged("CODIGO_MUNICIPIO")
        End Set
    End Property

    Private _fkCODIGO_MUNICIPIO As MUNICIPIO
    Public Property fkCODIGO_MUNICIPIO() As MUNICIPIO
        Get
            Return _fkCODIGO_MUNICIPIO
        End Get
        Set(ByVal Value As MUNICIPIO)
            _fkCODIGO_MUNICIPIO = Value
        End Set
    End Property

    Private _APORTE_FISDL As Decimal
    <Column(Name:="Aporte fisdl", Storage:="APORTE_FISDL", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=2)> _
    Public Property APORTE_FISDL() As Decimal
        Get
            Return _APORTE_FISDL
        End Get
        Set(ByVal Value As Decimal)
            _APORTE_FISDL = Value
            OnPropertyChanged("APORTE_FISDL")
        End Set
    End Property

    Private _APORTE_FISDLOld As Decimal
    Public Property APORTE_FISDLOld() As Decimal
        Get
            Return _APORTE_FISDLOld
        End Get
        Set(ByVal Value As Decimal)
            _APORTE_FISDLOld = Value
        End Set
    End Property

    Private _MONTO_LIQUIDADO As Decimal
    <Column(Name:="Monto liquidado", Storage:="MONTO_LIQUIDADO", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=2)> _
    Public Property MONTO_LIQUIDADO() As Decimal
        Get
            Return _MONTO_LIQUIDADO
        End Get
        Set(ByVal Value As Decimal)
            _MONTO_LIQUIDADO = Value
            OnPropertyChanged("MONTO_LIQUIDADO")
        End Set
    End Property

    Private _MONTO_LIQUIDADOOld As Decimal
    Public Property MONTO_LIQUIDADOOld() As Decimal
        Get
            Return _MONTO_LIQUIDADOOld
        End Get
        Set(ByVal Value As Decimal)
            _MONTO_LIQUIDADOOld = Value
        End Set
    End Property

    Private _ASESOR_MUNICIPAL As String
    <Column(Name:="Asesor municipal", Storage:="ASESOR_MUNICIPAL", DbType:="VARCHAR2(100)", Id:=False), _
     DataObjectField(False, False, True, 100)> _
    Public Property ASESOR_MUNICIPAL() As String
        Get
            Return _ASESOR_MUNICIPAL
        End Get
        Set(ByVal Value As String)
            _ASESOR_MUNICIPAL = Value
            OnPropertyChanged("ASESOR_MUNICIPAL")
        End Set
    End Property

    Private _ASESOR_MUNICIPALOld As String
    Public Property ASESOR_MUNICIPALOld() As String
        Get
            Return _ASESOR_MUNICIPALOld
        End Get
        Set(ByVal Value As String)
            _ASESOR_MUNICIPALOld = Value
        End Set
    End Property

    Private _CODIGO_PROYECTO As String
    <Column(Name:="Codigo proyecto", Storage:="CODIGO_PROYECTO", DbType:="VARCHAR2(10)", Id:=False), _
     DataObjectField(False, False, True, 10)> _
    Public Property CODIGO_PROYECTO() As String
        Get
            Return _CODIGO_PROYECTO
        End Get
        Set(ByVal Value As String)
            _CODIGO_PROYECTO = Value
            OnPropertyChanged("CODIGO_PROYECTO")
        End Set
    End Property

    Private _CODIGO_PROYECTOOld As String
    Public Property CODIGO_PROYECTOOld() As String
        Get
            Return _CODIGO_PROYECTOOld
        End Get
        Set(ByVal Value As String)
            _CODIGO_PROYECTOOld = Value
        End Set
    End Property

    Private _NOMBRE_PROYECTO As String
    <Column(Name:="Nombre proyecto", Storage:="NOMBRE_PROYECTO", DbType:="VARCHAR2(200)", Id:=False), _
     DataObjectField(False, False, True, 200)> _
    Public Property NOMBRE_PROYECTO() As String
        Get
            Return _NOMBRE_PROYECTO
        End Get
        Set(ByVal Value As String)
            _NOMBRE_PROYECTO = Value
            OnPropertyChanged("NOMBRE_PROYECTO")
        End Set
    End Property

    Private _NOMBRE_PROYECTOOld As String
    Public Property NOMBRE_PROYECTOOld() As String
        Get
            Return _NOMBRE_PROYECTOOld
        End Get
        Set(ByVal Value As String)
            _NOMBRE_PROYECTOOld = Value
        End Set
    End Property

    Private _NUMERO_CHEQUE_REINTEGRO As String
    <Column(Name:="Numero cheque reintegro", Storage:="NUMERO_CHEQUE_REINTEGRO", DbType:="VARCHAR2(20)", Id:=False), _
     DataObjectField(False, False, True, 20)> _
    Public Property NUMERO_CHEQUE_REINTEGRO() As String
        Get
            Return _NUMERO_CHEQUE_REINTEGRO
        End Get
        Set(ByVal Value As String)
            _NUMERO_CHEQUE_REINTEGRO = Value
            OnPropertyChanged("NUMERO_CHEQUE_REINTEGRO")
        End Set
    End Property

    Private _NUMERO_CHEQUE_REINTEGROOld As String
    Public Property NUMERO_CHEQUE_REINTEGROOld() As String
        Get
            Return _NUMERO_CHEQUE_REINTEGROOld
        End Get
        Set(ByVal Value As String)
            _NUMERO_CHEQUE_REINTEGROOld = Value
        End Set
    End Property

    Private _FECHA_CHEQUE_REINTEGRO As DateTime
    <Column(Name:="Fecha cheque reintegro", Storage:="FECHA_CHEQUE_REINTEGRO", DbType:="DATE", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property FECHA_CHEQUE_REINTEGRO() As DateTime
        Get
            Return _FECHA_CHEQUE_REINTEGRO
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_CHEQUE_REINTEGRO = Value
            OnPropertyChanged("FECHA_CHEQUE_REINTEGRO")
        End Set
    End Property

    Private _FECHA_CHEQUE_REINTEGROOld As String
    Public Property FECHA_CHEQUE_REINTEGROOld() As String
        Get
            Return _FECHA_CHEQUE_REINTEGROOld
        End Get
        Set(ByVal Value As String)
            _FECHA_CHEQUE_REINTEGROOld = Value
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
