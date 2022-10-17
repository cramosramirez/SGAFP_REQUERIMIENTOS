''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.ACCION_CONTRATADA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row ACCION_CONTRATADA en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	16/02/2022	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="ACCION_CONTRATADA")> Public Class ACCION_CONTRATADA
    Inherits entidadBase
    Implements IEquatable(Of ACCION_CONTRATADA), IComparable(Of ACCION_CONTRATADA)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_ACCION_CONTRATADA As Decimal, aID_CONTRATO As Decimal, aCODIGO_DEPARTAMENTO As String, aCODIGO_MUNICIPIO As String, aCODIGO_PROGRAMA As String, aDURACION As Decimal, aCANT_CURSOS As Decimal, aUSUARIO_CREACION As String, aFECHA_CREACION As DateTime, aUSERID As String, aLASTUPDATE As DateTime, aNUM_ITEM As Decimal, aMONTO As Decimal, aNO_CONVOCATORIA As Decimal, aCOSTO_PARTICIPANTE As Decimal, aNOMBRE_ACCION_FORMATIVA As String, aCOSTO_HORA As Decimal, aCOSTO_VISITA As Decimal, aCODIGO_CATEG As String, aNOMBRE_CATEG As String)
        Me._ID_ACCION_CONTRATADA = aID_ACCION_CONTRATADA
        Me._ID_CONTRATO = aID_CONTRATO
        Me._CODIGO_DEPARTAMENTO = aCODIGO_DEPARTAMENTO
        Me._CODIGO_MUNICIPIO = aCODIGO_MUNICIPIO
        Me._CODIGO_PROGRAMA = aCODIGO_PROGRAMA
        Me._DURACION = aDURACION
        Me._CANT_CURSOS = aCANT_CURSOS
        Me._USUARIO_CREACION = aUSUARIO_CREACION
        Me._FECHA_CREACION = aFECHA_CREACION
        Me._USERID = aUSERID
        Me._LASTUPDATE = aLASTUPDATE
        Me._NUM_ITEM = aNUM_ITEM
        Me._MONTO = aMONTO
        Me._NO_CONVOCATORIA = aNO_CONVOCATORIA
        Me._COSTO_PARTICIPANTE = aCOSTO_PARTICIPANTE
        Me._NOMBRE_ACCION_FORMATIVA = aNOMBRE_ACCION_FORMATIVA
        Me._COSTO_HORA = aCOSTO_HORA
        Me._COSTO_VISITA = aCOSTO_VISITA
        Me._CODIGO_CATEG = aCODIGO_CATEG
        Me._NOMBRE_CATEG = aNOMBRE_CATEG
    End Sub

    Public Function Equals1(ByVal other As ACCION_CONTRATADA) As Boolean Implements System.IEquatable(Of ACCION_CONTRATADA).Equals
        Return Me.ID_ACCION_CONTRATADA = other.ID_ACCION_CONTRATADA
    End Function

    Public Function CompareTo(ByVal other As ACCION_CONTRATADA) As Integer Implements System.IComparable(Of ACCION_CONTRATADA).CompareTo
        If Me.ID_ACCION_CONTRATADA > other.ID_ACCION_CONTRATADA Then Return 1
        If Me.ID_ACCION_CONTRATADA < other.ID_ACCION_CONTRATADA Then Return -1
        Return 0
    End Function


#Region " Properties "

    Private _ID_ACCION_CONTRATADA As Decimal
    <Column(Name:="Id accion contratada", Storage:="ID_ACCION_CONTRATADA", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=38, Scale:=0)> _
    Public Property ID_ACCION_CONTRATADA() As Decimal
        Get
            Return _ID_ACCION_CONTRATADA
        End Get
        Set(ByVal Value As Decimal)
            _ID_ACCION_CONTRATADA = Value
            OnPropertyChanged("ID_ACCION_CONTRATADA")
        End Set
    End Property 

    Private _ID_CONTRATO As Decimal
    <Column(Name:="Id contrato", Storage:="ID_CONTRATO", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=38, Scale:=0)> _
    Public Property ID_CONTRATO() As Decimal
        Get
            Return _ID_CONTRATO
        End Get
        Set(ByVal Value As Decimal)
            _ID_CONTRATO = Value
            OnPropertyChanged("ID_CONTRATO")
        End Set
    End Property 

    Private _ID_CONTRATOOld As Decimal
    Public Property ID_CONTRATOOld() As Decimal
        Get
            Return _ID_CONTRATOOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_CONTRATOOld = Value
        End Set
    End Property 

    Private _fkID_CONTRATO As CONTRATO_BOLPROS
    Public Property fkID_CONTRATO() As CONTRATO_BOLPROS
        Get
            Return _fkID_CONTRATO
        End Get
        Set(ByVal Value As CONTRATO_BOLPROS)
            _fkID_CONTRATO = Value
        End Set
    End Property 

    Private _CODIGO_DEPARTAMENTO As String
    <Column(Name:="Codigo departamento", Storage:="CODIGO_DEPARTAMENTO", DbType:="VARCHAR2(2)", Id:=False), _
     DataObjectField(False, False, True, 2)> _
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

    Private _CODIGO_MUNICIPIO As String
    <Column(Name:="Codigo municipio", Storage:="CODIGO_MUNICIPIO", DbType:="VARCHAR2(2)", Id:=False), _
     DataObjectField(False, False, True, 2)> _
    Public Property CODIGO_MUNICIPIO() As String
        Get
            Return _CODIGO_MUNICIPIO
        End Get
        Set(ByVal Value As String)
            _CODIGO_MUNICIPIO = Value
            OnPropertyChanged("CODIGO_MUNICIPIO")
        End Set
    End Property 

    Private _CODIGO_MUNICIPIOOld As String
    Public Property CODIGO_MUNICIPIOOld() As String
        Get
            Return _CODIGO_MUNICIPIOOld
        End Get
        Set(ByVal Value As String)
            _CODIGO_MUNICIPIOOld = Value
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

    Private _CODIGO_PROGRAMA As String
    <Column(Name:="Codigo programa", Storage:="CODIGO_PROGRAMA", DbType:="NVARCHAR2(0,0) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 20)> _
    Public Property CODIGO_PROGRAMA() As String
        Get
            Return _CODIGO_PROGRAMA
        End Get
        Set(ByVal Value As String)
            _CODIGO_PROGRAMA = Value
            OnPropertyChanged("CODIGO_PROGRAMA")
        End Set
    End Property 

    Private _CODIGO_PROGRAMAOld As String
    Public Property CODIGO_PROGRAMAOld() As String
        Get
            Return _CODIGO_PROGRAMAOld
        End Get
        Set(ByVal Value As String)
            _CODIGO_PROGRAMAOld = Value
        End Set
    End Property 

    Private _DURACION As Decimal
    <Column(Name:="Duracion", Storage:="DURACION", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=4, Scale:=0)> _
    Public Property DURACION() As Decimal
        Get
            Return _DURACION
        End Get
        Set(ByVal Value As Decimal)
            _DURACION = Value
            OnPropertyChanged("DURACION")
        End Set
    End Property 

    Private _DURACIONOld As Decimal
    Public Property DURACIONOld() As Decimal
        Get
            Return _DURACIONOld
        End Get
        Set(ByVal Value As Decimal)
            _DURACIONOld = Value
        End Set
    End Property 

    Private _CANT_CURSOS As Decimal
    <Column(Name:="Cant cursos", Storage:="CANT_CURSOS", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=3, Scale:=0)> _
    Public Property CANT_CURSOS() As Decimal
        Get
            Return _CANT_CURSOS
        End Get
        Set(ByVal Value As Decimal)
            _CANT_CURSOS = Value
            OnPropertyChanged("CANT_CURSOS")
        End Set
    End Property 

    Private _CANT_CURSOSOld As Decimal
    Public Property CANT_CURSOSOld() As Decimal
        Get
            Return _CANT_CURSOSOld
        End Get
        Set(ByVal Value As Decimal)
            _CANT_CURSOSOld = Value
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

    Private _NUM_ITEM As Decimal
    <Column(Name:="Num item", Storage:="NUM_ITEM", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=4, Scale:=0)> _
    Public Property NUM_ITEM() As Decimal
        Get
            Return _NUM_ITEM
        End Get
        Set(ByVal Value As Decimal)
            _NUM_ITEM = Value
            OnPropertyChanged("NUM_ITEM")
        End Set
    End Property 

    Private _NUM_ITEMOld As Decimal
    Public Property NUM_ITEMOld() As Decimal
        Get
            Return _NUM_ITEMOld
        End Get
        Set(ByVal Value As Decimal)
            _NUM_ITEMOld = Value
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

    Private _NO_CONVOCATORIA As Decimal
    <Column(Name:="No convocatoria", Storage:="NO_CONVOCATORIA", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=2, Scale:=0)> _
    Public Property NO_CONVOCATORIA() As Decimal
        Get
            Return _NO_CONVOCATORIA
        End Get
        Set(ByVal Value As Decimal)
            _NO_CONVOCATORIA = Value
            OnPropertyChanged("NO_CONVOCATORIA")
        End Set
    End Property 

    Private _NO_CONVOCATORIAOld As Decimal
    Public Property NO_CONVOCATORIAOld() As Decimal
        Get
            Return _NO_CONVOCATORIAOld
        End Get
        Set(ByVal Value As Decimal)
            _NO_CONVOCATORIAOld = Value
        End Set
    End Property 

    Private _COSTO_PARTICIPANTE As Decimal
    <Column(Name:="Costo participante", Storage:="COSTO_PARTICIPANTE", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=6)> _
    Public Property COSTO_PARTICIPANTE() As Decimal
        Get
            Return _COSTO_PARTICIPANTE
        End Get
        Set(ByVal Value As Decimal)
            _COSTO_PARTICIPANTE = Value
            OnPropertyChanged("COSTO_PARTICIPANTE")
        End Set
    End Property 

    Private _COSTO_PARTICIPANTEOld As Decimal
    Public Property COSTO_PARTICIPANTEOld() As Decimal
        Get
            Return _COSTO_PARTICIPANTEOld
        End Get
        Set(ByVal Value As Decimal)
            _COSTO_PARTICIPANTEOld = Value
        End Set
    End Property 

    Private _NOMBRE_ACCION_FORMATIVA As String
    <Column(Name:="Nombre accion formativa", Storage:="NOMBRE_ACCION_FORMATIVA", DbType:="VARCHAR2(150)", Id:=False), _
     DataObjectField(False, False, True, 150)> _
    Public Property NOMBRE_ACCION_FORMATIVA() As String
        Get
            Return _NOMBRE_ACCION_FORMATIVA
        End Get
        Set(ByVal Value As String)
            _NOMBRE_ACCION_FORMATIVA = Value
            OnPropertyChanged("NOMBRE_ACCION_FORMATIVA")
        End Set
    End Property 

    Private _NOMBRE_ACCION_FORMATIVAOld As String
    Public Property NOMBRE_ACCION_FORMATIVAOld() As String
        Get
            Return _NOMBRE_ACCION_FORMATIVAOld
        End Get
        Set(ByVal Value As String)
            _NOMBRE_ACCION_FORMATIVAOld = Value
        End Set
    End Property 

    Private _COSTO_HORA As Decimal
    <Column(Name:="Costo hora", Storage:="COSTO_HORA", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=6)> _
    Public Property COSTO_HORA() As Decimal
        Get
            Return _COSTO_HORA
        End Get
        Set(ByVal Value As Decimal)
            _COSTO_HORA = Value
            OnPropertyChanged("COSTO_HORA")
        End Set
    End Property 

    Private _COSTO_HORAOld As Decimal
    Public Property COSTO_HORAOld() As Decimal
        Get
            Return _COSTO_HORAOld
        End Get
        Set(ByVal Value As Decimal)
            _COSTO_HORAOld = Value
        End Set
    End Property 

    Private _COSTO_VISITA As Decimal
    <Column(Name:="Costo visita", Storage:="COSTO_VISITA", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=6)> _
    Public Property COSTO_VISITA() As Decimal
        Get
            Return _COSTO_VISITA
        End Get
        Set(ByVal Value As Decimal)
            _COSTO_VISITA = Value
            OnPropertyChanged("COSTO_VISITA")
        End Set
    End Property 

    Private _COSTO_VISITAOld As Decimal
    Public Property COSTO_VISITAOld() As Decimal
        Get
            Return _COSTO_VISITAOld
        End Get
        Set(ByVal Value As Decimal)
            _COSTO_VISITAOld = Value
        End Set
    End Property 

    Private _CODIGO_CATEG As String
    <Column(Name:="Codigo categ", Storage:="CODIGO_CATEG", DbType:="VARCHAR2(20)", Id:=False), _
     DataObjectField(False, False, True, 20)> _
    Public Property CODIGO_CATEG() As String
        Get
            Return _CODIGO_CATEG
        End Get
        Set(ByVal Value As String)
            _CODIGO_CATEG = Value
            OnPropertyChanged("CODIGO_CATEG")
        End Set
    End Property 

    Private _CODIGO_CATEGOld As String
    Public Property CODIGO_CATEGOld() As String
        Get
            Return _CODIGO_CATEGOld
        End Get
        Set(ByVal Value As String)
            _CODIGO_CATEGOld = Value
        End Set
    End Property 

    Private _NOMBRE_CATEG As String
    <Column(Name:="Nombre categ", Storage:="NOMBRE_CATEG", DbType:="VARCHAR2(200)", Id:=False), _
     DataObjectField(False, False, True, 200)> _
    Public Property NOMBRE_CATEG() As String
        Get
            Return _NOMBRE_CATEG
        End Get
        Set(ByVal Value As String)
            _NOMBRE_CATEG = Value
            OnPropertyChanged("NOMBRE_CATEG")
        End Set
    End Property 

    Private _NOMBRE_CATEGOld As String
    Public Property NOMBRE_CATEGOld() As String
        Get
            Return _NOMBRE_CATEGOld
        End Get
        Set(ByVal Value As String)
            _NOMBRE_CATEGOld = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
