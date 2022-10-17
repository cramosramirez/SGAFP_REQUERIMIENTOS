''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.SOLICITUD_INSCRIPCION_EC
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row SOLICITUD_INSCRIPCION_EC en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	23/07/2019	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="SOLICITUD_INSCRIPCION_EC")> Public Class SOLICITUD_INSCRIPCION_EC
    Inherits entidadBase
    Implements IEquatable(Of SOLICITUD_INSCRIPCION_EC), IComparable(Of SOLICITUD_INSCRIPCION_EC)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_SOLICITUD As Decimal, aID_SOLIC_PRESELEC As Decimal, aID_ACTI_ECONOMICA As Decimal, aID_AREA_EMPRESA As Decimal, aID_GRUPO_SELEC As Decimal, aID_INGRESO_MES As Decimal, aID_MOTIVO_DEJO_ESTU As Decimal, aID_MOTIVO_DEJO_TRAB As Decimal, aID_TIEMPO_NOTRAB As Decimal, aID_TIPO_SELECC As Decimal, aID_ULT_SALARIO_MES As Decimal, aMANERA_OBT_ING_BECA As String, aMOTIVO_ELIGIO_CARRERA As String, aOCUACT_ESTU_TRAB As Decimal, aOTRO_MOTIVO_DEJO_ESTU As String, aUSUARIO_CREA As String, aUSUARIO_ACT As String, aFECHA_ACT As DateTime, aFECHA_CREACION As DateTime)
        Me._ID_SOLICITUD = aID_SOLICITUD
        Me._ID_SOLIC_PRESELEC = aID_SOLIC_PRESELEC
        Me._ID_ACTI_ECONOMICA = aID_ACTI_ECONOMICA
        Me._ID_AREA_EMPRESA = aID_AREA_EMPRESA
        Me._ID_GRUPO_SELEC = aID_GRUPO_SELEC
        Me._ID_INGRESO_MES = aID_INGRESO_MES
        Me._ID_MOTIVO_DEJO_ESTU = aID_MOTIVO_DEJO_ESTU
        Me._ID_MOTIVO_DEJO_TRAB = aID_MOTIVO_DEJO_TRAB
        Me._ID_TIEMPO_NOTRAB = aID_TIEMPO_NOTRAB
        Me._ID_TIPO_SELECC = aID_TIPO_SELECC
        Me._ID_ULT_SALARIO_MES = aID_ULT_SALARIO_MES
        Me._MANERA_OBT_ING_BECA = aMANERA_OBT_ING_BECA
        Me._MOTIVO_ELIGIO_CARRERA = aMOTIVO_ELIGIO_CARRERA
        Me._OCUACT_ESTU_TRAB = aOCUACT_ESTU_TRAB
        Me._OTRO_MOTIVO_DEJO_ESTU = aOTRO_MOTIVO_DEJO_ESTU
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
        Me._FECHA_CREACION = aFECHA_CREACION
    End Sub

    Public Function Equals1(ByVal other As SOLICITUD_INSCRIPCION_EC) As Boolean Implements System.IEquatable(Of SOLICITUD_INSCRIPCION_EC).Equals
        Return Me.ID_SOLICITUD = other.ID_SOLICITUD
    End Function

    Public Function CompareTo(ByVal other As SOLICITUD_INSCRIPCION_EC) As Integer Implements System.IComparable(Of SOLICITUD_INSCRIPCION_EC).CompareTo
        If Me.ID_SOLICITUD > other.ID_SOLICITUD Then Return 1
        If Me.ID_SOLICITUD < other.ID_SOLICITUD Then Return -1
        Return 0
    End Function


#Region " Properties "

    Private _ID_SOLICITUD As Decimal
    <Column(Name:="Id solicitud", Storage:="ID_SOLICITUD", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_SOLICITUD() As Decimal
        Get
            Return _ID_SOLICITUD
        End Get
        Set(ByVal Value As Decimal)
            _ID_SOLICITUD = Value
            OnPropertyChanged("ID_SOLICITUD")
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

    Private _ID_SOLIC_PRESELEC As Decimal
    <Column(Name:="Id solic preselec", Storage:="ID_SOLIC_PRESELEC", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_SOLIC_PRESELEC() As Decimal
        Get
            Return _ID_SOLIC_PRESELEC
        End Get
        Set(ByVal Value As Decimal)
            _ID_SOLIC_PRESELEC = Value
            OnPropertyChanged("ID_SOLIC_PRESELEC")
        End Set
    End Property 

    Private _ID_SOLIC_PRESELECOld As Decimal
    Public Property ID_SOLIC_PRESELECOld() As Decimal
        Get
            Return _ID_SOLIC_PRESELECOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_SOLIC_PRESELECOld = Value
        End Set
    End Property 

    Private _fkID_SOLIC_PRESELEC As SOLICITUD_PRESELECCION_EC
    Public Property fkID_SOLIC_PRESELEC() As SOLICITUD_PRESELECCION_EC
        Get
            Return _fkID_SOLIC_PRESELEC
        End Get
        Set(ByVal Value As SOLICITUD_PRESELECCION_EC)
            _fkID_SOLIC_PRESELEC = Value
        End Set
    End Property 

    Private _ID_ACTI_ECONOMICA As Decimal
    <Column(Name:="Id acti economica", Storage:="ID_ACTI_ECONOMICA", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_ACTI_ECONOMICA() As Decimal
        Get
            Return _ID_ACTI_ECONOMICA
        End Get
        Set(ByVal Value As Decimal)
            _ID_ACTI_ECONOMICA = Value
            OnPropertyChanged("ID_ACTI_ECONOMICA")
        End Set
    End Property 

    Private _ID_ACTI_ECONOMICAOld As Decimal
    Public Property ID_ACTI_ECONOMICAOld() As Decimal
        Get
            Return _ID_ACTI_ECONOMICAOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_ACTI_ECONOMICAOld = Value
        End Set
    End Property 

    Private _fkID_ACTI_ECONOMICA As ACTI_ECONOMICA
    Public Property fkID_ACTI_ECONOMICA() As ACTI_ECONOMICA
        Get
            Return _fkID_ACTI_ECONOMICA
        End Get
        Set(ByVal Value As ACTI_ECONOMICA)
            _fkID_ACTI_ECONOMICA = Value
        End Set
    End Property 

    Private _ID_AREA_EMPRESA As Decimal
    <Column(Name:="Id area empresa", Storage:="ID_AREA_EMPRESA", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_AREA_EMPRESA() As Decimal
        Get
            Return _ID_AREA_EMPRESA
        End Get
        Set(ByVal Value As Decimal)
            _ID_AREA_EMPRESA = Value
            OnPropertyChanged("ID_AREA_EMPRESA")
        End Set
    End Property 

    Private _ID_AREA_EMPRESAOld As Decimal
    Public Property ID_AREA_EMPRESAOld() As Decimal
        Get
            Return _ID_AREA_EMPRESAOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_AREA_EMPRESAOld = Value
        End Set
    End Property 

    Private _fkID_AREA_EMPRESA As AREA_EMPRESA
    Public Property fkID_AREA_EMPRESA() As AREA_EMPRESA
        Get
            Return _fkID_AREA_EMPRESA
        End Get
        Set(ByVal Value As AREA_EMPRESA)
            _fkID_AREA_EMPRESA = Value
        End Set
    End Property 

    Private _ID_GRUPO_SELEC As Decimal
    <Column(Name:="Id grupo selec", Storage:="ID_GRUPO_SELEC", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_GRUPO_SELEC() As Decimal
        Get
            Return _ID_GRUPO_SELEC
        End Get
        Set(ByVal Value As Decimal)
            _ID_GRUPO_SELEC = Value
            OnPropertyChanged("ID_GRUPO_SELEC")
        End Set
    End Property 

    Private _ID_GRUPO_SELECOld As Decimal
    Public Property ID_GRUPO_SELECOld() As Decimal
        Get
            Return _ID_GRUPO_SELECOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_GRUPO_SELECOld = Value
        End Set
    End Property 

    Private _fkID_GRUPO_SELEC As GRUPO_SELECCION
    Public Property fkID_GRUPO_SELEC() As GRUPO_SELECCION
        Get
            Return _fkID_GRUPO_SELEC
        End Get
        Set(ByVal Value As GRUPO_SELECCION)
            _fkID_GRUPO_SELEC = Value
        End Set
    End Property 

    Private _ID_INGRESO_MES As Decimal
    <Column(Name:="Id ingreso mes", Storage:="ID_INGRESO_MES", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_INGRESO_MES() As Decimal
        Get
            Return _ID_INGRESO_MES
        End Get
        Set(ByVal Value As Decimal)
            _ID_INGRESO_MES = Value
            OnPropertyChanged("ID_INGRESO_MES")
        End Set
    End Property 

    Private _ID_INGRESO_MESOld As Decimal
    Public Property ID_INGRESO_MESOld() As Decimal
        Get
            Return _ID_INGRESO_MESOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_INGRESO_MESOld = Value
        End Set
    End Property 

    Private _fkID_INGRESO_MES As INGRESO_MES
    Public Property fkID_INGRESO_MES() As INGRESO_MES
        Get
            Return _fkID_INGRESO_MES
        End Get
        Set(ByVal Value As INGRESO_MES)
            _fkID_INGRESO_MES = Value
        End Set
    End Property 

    Private _ID_MOTIVO_DEJO_ESTU As Decimal
    <Column(Name:="Id motivo dejo estu", Storage:="ID_MOTIVO_DEJO_ESTU", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_MOTIVO_DEJO_ESTU() As Decimal
        Get
            Return _ID_MOTIVO_DEJO_ESTU
        End Get
        Set(ByVal Value As Decimal)
            _ID_MOTIVO_DEJO_ESTU = Value
            OnPropertyChanged("ID_MOTIVO_DEJO_ESTU")
        End Set
    End Property 

    Private _ID_MOTIVO_DEJO_ESTUOld As Decimal
    Public Property ID_MOTIVO_DEJO_ESTUOld() As Decimal
        Get
            Return _ID_MOTIVO_DEJO_ESTUOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_MOTIVO_DEJO_ESTUOld = Value
        End Set
    End Property 

    Private _fkID_MOTIVO_DEJO_ESTU As MOTIVO_DEJO_ESTU
    Public Property fkID_MOTIVO_DEJO_ESTU() As MOTIVO_DEJO_ESTU
        Get
            Return _fkID_MOTIVO_DEJO_ESTU
        End Get
        Set(ByVal Value As MOTIVO_DEJO_ESTU)
            _fkID_MOTIVO_DEJO_ESTU = Value
        End Set
    End Property 

    Private _ID_MOTIVO_DEJO_TRAB As Decimal
    <Column(Name:="Id motivo dejo trab", Storage:="ID_MOTIVO_DEJO_TRAB", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_MOTIVO_DEJO_TRAB() As Decimal
        Get
            Return _ID_MOTIVO_DEJO_TRAB
        End Get
        Set(ByVal Value As Decimal)
            _ID_MOTIVO_DEJO_TRAB = Value
            OnPropertyChanged("ID_MOTIVO_DEJO_TRAB")
        End Set
    End Property 

    Private _ID_MOTIVO_DEJO_TRABOld As Decimal
    Public Property ID_MOTIVO_DEJO_TRABOld() As Decimal
        Get
            Return _ID_MOTIVO_DEJO_TRABOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_MOTIVO_DEJO_TRABOld = Value
        End Set
    End Property 

    Private _fkID_MOTIVO_DEJO_TRAB As MOTIVO_DEJO_TRAB
    Public Property fkID_MOTIVO_DEJO_TRAB() As MOTIVO_DEJO_TRAB
        Get
            Return _fkID_MOTIVO_DEJO_TRAB
        End Get
        Set(ByVal Value As MOTIVO_DEJO_TRAB)
            _fkID_MOTIVO_DEJO_TRAB = Value
        End Set
    End Property 

    Private _ID_TIEMPO_NOTRAB As Decimal
    <Column(Name:="Id tiempo notrab", Storage:="ID_TIEMPO_NOTRAB", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_TIEMPO_NOTRAB() As Decimal
        Get
            Return _ID_TIEMPO_NOTRAB
        End Get
        Set(ByVal Value As Decimal)
            _ID_TIEMPO_NOTRAB = Value
            OnPropertyChanged("ID_TIEMPO_NOTRAB")
        End Set
    End Property 

    Private _ID_TIEMPO_NOTRABOld As Decimal
    Public Property ID_TIEMPO_NOTRABOld() As Decimal
        Get
            Return _ID_TIEMPO_NOTRABOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_TIEMPO_NOTRABOld = Value
        End Set
    End Property 

    Private _fkID_TIEMPO_NOTRAB As TIEMPO_NOTRAB
    Public Property fkID_TIEMPO_NOTRAB() As TIEMPO_NOTRAB
        Get
            Return _fkID_TIEMPO_NOTRAB
        End Get
        Set(ByVal Value As TIEMPO_NOTRAB)
            _fkID_TIEMPO_NOTRAB = Value
        End Set
    End Property 

    Private _ID_TIPO_SELECC As Decimal
    <Column(Name:="Id tipo selecc", Storage:="ID_TIPO_SELECC", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_TIPO_SELECC() As Decimal
        Get
            Return _ID_TIPO_SELECC
        End Get
        Set(ByVal Value As Decimal)
            _ID_TIPO_SELECC = Value
            OnPropertyChanged("ID_TIPO_SELECC")
        End Set
    End Property 

    Private _ID_TIPO_SELECCOld As Decimal
    Public Property ID_TIPO_SELECCOld() As Decimal
        Get
            Return _ID_TIPO_SELECCOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_TIPO_SELECCOld = Value
        End Set
    End Property 

    Private _fkID_TIPO_SELECC As TIPO_SELECC
    Public Property fkID_TIPO_SELECC() As TIPO_SELECC
        Get
            Return _fkID_TIPO_SELECC
        End Get
        Set(ByVal Value As TIPO_SELECC)
            _fkID_TIPO_SELECC = Value
        End Set
    End Property 

    Private _ID_ULT_SALARIO_MES As Decimal
    <Column(Name:="Id ult salario mes", Storage:="ID_ULT_SALARIO_MES", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_ULT_SALARIO_MES() As Decimal
        Get
            Return _ID_ULT_SALARIO_MES
        End Get
        Set(ByVal Value As Decimal)
            _ID_ULT_SALARIO_MES = Value
            OnPropertyChanged("ID_ULT_SALARIO_MES")
        End Set
    End Property 

    Private _ID_ULT_SALARIO_MESOld As Decimal
    Public Property ID_ULT_SALARIO_MESOld() As Decimal
        Get
            Return _ID_ULT_SALARIO_MESOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_ULT_SALARIO_MESOld = Value
        End Set
    End Property 

    Private _fkID_ULT_SALARIO_MES As INGRESO_MES
    Public Property fkID_ULT_SALARIO_MES() As INGRESO_MES
        Get
            Return _fkID_ULT_SALARIO_MES
        End Get
        Set(ByVal Value As INGRESO_MES)
            _fkID_ULT_SALARIO_MES = Value
        End Set
    End Property 

    Private _MANERA_OBT_ING_BECA As String
    <Column(Name:="Manera obt ing beca", Storage:="MANERA_OBT_ING_BECA", DbType:="VARCHAR2(300)", Id:=False), _
     DataObjectField(False, False, True, 300)> _
    Public Property MANERA_OBT_ING_BECA() As String
        Get
            Return _MANERA_OBT_ING_BECA
        End Get
        Set(ByVal Value As String)
            _MANERA_OBT_ING_BECA = Value
            OnPropertyChanged("MANERA_OBT_ING_BECA")
        End Set
    End Property 

    Private _MANERA_OBT_ING_BECAOld As String
    Public Property MANERA_OBT_ING_BECAOld() As String
        Get
            Return _MANERA_OBT_ING_BECAOld
        End Get
        Set(ByVal Value As String)
            _MANERA_OBT_ING_BECAOld = Value
        End Set
    End Property 

    Private _MOTIVO_ELIGIO_CARRERA As String
    <Column(Name:="Motivo eligio carrera", Storage:="MOTIVO_ELIGIO_CARRERA", DbType:="VARCHAR2(300)", Id:=False), _
     DataObjectField(False, False, True, 300)> _
    Public Property MOTIVO_ELIGIO_CARRERA() As String
        Get
            Return _MOTIVO_ELIGIO_CARRERA
        End Get
        Set(ByVal Value As String)
            _MOTIVO_ELIGIO_CARRERA = Value
            OnPropertyChanged("MOTIVO_ELIGIO_CARRERA")
        End Set
    End Property 

    Private _MOTIVO_ELIGIO_CARRERAOld As String
    Public Property MOTIVO_ELIGIO_CARRERAOld() As String
        Get
            Return _MOTIVO_ELIGIO_CARRERAOld
        End Get
        Set(ByVal Value As String)
            _MOTIVO_ELIGIO_CARRERAOld = Value
        End Set
    End Property 

    Private _OCUACT_ESTU_TRAB As Decimal
    <Column(Name:="Ocuact estu trab", Storage:="OCUACT_ESTU_TRAB", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=1, Scale:=0)> _
    Public Property OCUACT_ESTU_TRAB() As Decimal
        Get
            Return _OCUACT_ESTU_TRAB
        End Get
        Set(ByVal Value As Decimal)
            _OCUACT_ESTU_TRAB = Value
            OnPropertyChanged("OCUACT_ESTU_TRAB")
        End Set
    End Property 

    Private _OCUACT_ESTU_TRABOld As Decimal
    Public Property OCUACT_ESTU_TRABOld() As Decimal
        Get
            Return _OCUACT_ESTU_TRABOld
        End Get
        Set(ByVal Value As Decimal)
            _OCUACT_ESTU_TRABOld = Value
        End Set
    End Property 

    Private _OTRO_MOTIVO_DEJO_ESTU As String
    <Column(Name:="Otro motivo dejo estu", Storage:="OTRO_MOTIVO_DEJO_ESTU", DbType:="VARCHAR2(300)", Id:=False), _
     DataObjectField(False, False, True, 300)> _
    Public Property OTRO_MOTIVO_DEJO_ESTU() As String
        Get
            Return _OTRO_MOTIVO_DEJO_ESTU
        End Get
        Set(ByVal Value As String)
            _OTRO_MOTIVO_DEJO_ESTU = Value
            OnPropertyChanged("OTRO_MOTIVO_DEJO_ESTU")
        End Set
    End Property 

    Private _OTRO_MOTIVO_DEJO_ESTUOld As String
    Public Property OTRO_MOTIVO_DEJO_ESTUOld() As String
        Get
            Return _OTRO_MOTIVO_DEJO_ESTUOld
        End Get
        Set(ByVal Value As String)
            _OTRO_MOTIVO_DEJO_ESTUOld = Value
        End Set
    End Property 

    Private _USUARIO_CREA As String
    <Column(Name:="Usuario crea", Storage:="USUARIO_CREA", DbType:="VARCHAR2(200)", Id:=False), _
     DataObjectField(False, False, True, 200)> _
    Public Property USUARIO_CREA() As String
        Get
            Return _USUARIO_CREA
        End Get
        Set(ByVal Value As String)
            _USUARIO_CREA = Value
            OnPropertyChanged("USUARIO_CREA")
        End Set
    End Property 

    Private _USUARIO_CREAOld As String
    Public Property USUARIO_CREAOld() As String
        Get
            Return _USUARIO_CREAOld
        End Get
        Set(ByVal Value As String)
            _USUARIO_CREAOld = Value
        End Set
    End Property 

    Private _USUARIO_ACT As String
    <Column(Name:="Usuario act", Storage:="USUARIO_ACT", DbType:="VARCHAR2(200)", Id:=False), _
     DataObjectField(False, False, True, 200)> _
    Public Property USUARIO_ACT() As String
        Get
            Return _USUARIO_ACT
        End Get
        Set(ByVal Value As String)
            _USUARIO_ACT = Value
            OnPropertyChanged("USUARIO_ACT")
        End Set
    End Property 

    Private _USUARIO_ACTOld As String
    Public Property USUARIO_ACTOld() As String
        Get
            Return _USUARIO_ACTOld
        End Get
        Set(ByVal Value As String)
            _USUARIO_ACTOld = Value
        End Set
    End Property 

    Private _FECHA_ACT As DateTime
    <Column(Name:="Fecha act", Storage:="FECHA_ACT", DbType:="DATE", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property FECHA_ACT() As DateTime
        Get
            Return _FECHA_ACT
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_ACT = Value
            OnPropertyChanged("FECHA_ACT")
        End Set
    End Property 

    Private _FECHA_ACTOld As DateTime
    Public Property FECHA_ACTOld() As DateTime
        Get
            Return _FECHA_ACTOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_ACTOld = Value
        End Set
    End Property 

    Private _FECHA_CREACION As DateTime
    <Column(Name:="Fecha creacion", Storage:="FECHA_CREACION", DbType:="DATE", Id:=False), _
     DataObjectField(False, False, True)> _
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
#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
