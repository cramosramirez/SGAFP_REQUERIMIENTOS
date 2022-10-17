''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.ACCION_FORMATIVA_HIST
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite tener un registro de la tabla ACCION_FORMATIVA_HIST en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	13/05/2010	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="ACCION_FORMATIVA_HIST")> Public Class ACCION_FORMATIVA_HIST
    Inherits entidadBase
    Implements IEquatable(Of ACCION_FORMATIVA_HIST), IComparable(Of ACCION_FORMATIVA_HIST)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(ByVal aID_ACCION_FORMATIVA_HIST As Decimal, ByVal aID_ACCION_FORMATIVA As Decimal, ByVal aID_OFERTA_FORMATIVA As Decimal, ByVal aID_SITIO_CAPACITACION As Decimal, ByVal aID_PROVEEDOR_AF As Decimal, ByVal aID_TEMA_CURSO As Decimal, ByVal aID_EJERCICIO As String, ByVal aNOMBRE_ACCION_FORMATIVA As String, ByVal aCODIGO_GRUPO As String, ByVal aNUMERO_PARTICIPANTES As Decimal, ByVal aPARTICIPANTES_INSCRITOS As Decimal, ByVal aFECHA_INICIO As DateTime, ByVal aFECHA_FIN As DateTime, ByVal aHORARIO As String, ByVal aNOTAS As String, ByVal aCODIGO_ESTADO_AF As String, ByVal aDURACION_HORAS As Decimal, ByVal aCOSTO_X_PARTICIPANTE As Decimal, ByVal aLASTUPDATE As DateTime, ByVal aUSERID As String, ByVal aFECHA_INICIO_REAL As DateTime, ByVal aFECHA_FIN_REAL As DateTime, ByVal aOBSERVACIONES As String, ByVal aID_ACCION_CONTRATADA As Decimal, ByVal aCODI_FORMADOR As String, ByVal aNOMBRE_FORMADOR As String)
        Me._ID_ACCION_FORMATIVA_HIST = aID_ACCION_FORMATIVA_HIST
        Me._ID_ACCION_FORMATIVA = aID_ACCION_FORMATIVA
        Me._ID_OFERTA_FORMATIVA = aID_OFERTA_FORMATIVA
        Me._ID_SITIO_CAPACITACION = aID_SITIO_CAPACITACION
        Me._ID_PROVEEDOR_AF = aID_PROVEEDOR_AF
        Me._ID_TEMA_CURSO = aID_TEMA_CURSO
        Me._ID_EJERCICIO = aID_EJERCICIO
        Me._NOMBRE_ACCION_FORMATIVA = aNOMBRE_ACCION_FORMATIVA
        Me._CODIGO_GRUPO = aCODIGO_GRUPO
        Me._NUMERO_PARTICIPANTES = aNUMERO_PARTICIPANTES
        Me._PARTICIPANTES_INSCRITOS = aPARTICIPANTES_INSCRITOS
        Me._HORARIO = aHORARIO
        Me._NOTAS = aNOTAS
        Me._CODIGO_ESTADO_AF = aCODIGO_ESTADO_AF
        Me._DURACION_HORAS = aDURACION_HORAS
        Me._COSTO_X_PARTICIPANTE = aCOSTO_X_PARTICIPANTE
        Me._LASTUPDATE = aLASTUPDATE
        Me._USERID = aUSERID
        Me._FECHA_INICIO_REAL = aFECHA_INICIO_REAL
        Me._FECHA_FIN_REAL = aFECHA_FIN_REAL
        Me._OBSERVACIONES = aOBSERVACIONES
        Me._ID_ACCION_CONTRATADA = aID_ACCION_CONTRATADA
        Me._CODI_FORMADOR = aCODI_FORMADOR
        Me._NOMBRE_FORMADOR = aNOMBRE_FORMADOR
    End Sub

    Public Function Equals1(ByVal other As ACCION_FORMATIVA_HIST) As Boolean Implements System.IEquatable(Of ACCION_FORMATIVA_HIST).Equals
        Return Me.ID_ACCION_FORMATIVA_HIST = other.ID_ACCION_FORMATIVA_HIST
    End Function

    Public Function CompareTo(ByVal other As ACCION_FORMATIVA_HIST) As Integer Implements System.IComparable(Of ACCION_FORMATIVA_HIST).CompareTo
        If Me.ID_ACCION_FORMATIVA_HIST > other.ID_ACCION_FORMATIVA_HIST Then Return 1
        If Me.ID_ACCION_FORMATIVA_HIST < other.ID_ACCION_FORMATIVA_HIST Then Return -1
        Return 0
    End Function

    Private _ID_ACCION_CONTRATADA As Decimal
    <Column(Name:="Id accion contratada", Storage:="ID_ACCION_CONTRATADA", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=38, Scale:=0), DataMember()> _
    Public Property ID_ACCION_CONTRATADA() As Decimal
        Get
            Return _ID_ACCION_CONTRATADA
        End Get
        Set(ByVal Value As Decimal)
            _ID_ACCION_CONTRATADA = Value
            OnPropertyChanged("ID_ACCION_CONTRATADA")
        End Set
    End Property

    Private _ID_ACCION_CONTRATADAOld As Decimal
    <DataMember()> _
    Public Property ID_ACCION_CONTRATADAOld() As Decimal
        Get
            Return _ID_ACCION_CONTRATADAOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_ACCION_CONTRATADAOld = Value
        End Set
    End Property


    Private _CODI_FORMADOR As String
    <Column(Name:="Codi Formador", Storage:="CODI_FORMADOR", DbType:="VARCHAR2(20)", Id:=False), _
     DataObjectField(False, False, True, 20), DataMember()> _
    Public Property CODI_FORMADOR() As String
        Get
            Return _CODI_FORMADOR
        End Get
        Set(ByVal Value As String)
            _CODI_FORMADOR = Value
            OnPropertyChanged("CODI_FORMADOR")
        End Set
    End Property

    Private _CODI_FORMADOROld As String
    <DataMember()> _
    Public Property CODI_FORMADOROld() As String
        Get
            Return _CODI_FORMADOROld
        End Get
        Set(ByVal Value As String)
            _CODI_FORMADOROld = Value
        End Set
    End Property

    Private _NOMBRE_FORMADOR As String
    <Column(Name:="Nombre Formador", Storage:="NOMBRE_FORMADOR", DbType:="VARCHAR2(150)", Id:=False), _
     DataObjectField(False, False, True, 150), DataMember()> _
    Public Property NOMBRE_FORMADOR() As String
        Get
            Return _NOMBRE_FORMADOR
        End Get
        Set(ByVal Value As String)
            _NOMBRE_FORMADOR = Value
            OnPropertyChanged("NOMBRE_FORMADOR")
        End Set
    End Property

    Private _NOMBRE_FORMADOROld As String
    <DataMember()> _
    Public Property NOMBRE_FORMADOROld() As String
        Get
            Return _NOMBRE_FORMADOROld
        End Get
        Set(ByVal Value As String)
            _NOMBRE_FORMADOROld = Value
        End Set
    End Property



#Region " Propiedades "

    Private _ID_ACCION_FORMATIVA_HIST As Decimal
    <Column(Name:="Id accion formativa hist", Storage:="ID_ACCION_FORMATIVA_HIST", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_ACCION_FORMATIVA_HIST() As Decimal
        Get
            Return _ID_ACCION_FORMATIVA_HIST
        End Get
        Set(ByVal Value As Decimal)
            _ID_ACCION_FORMATIVA_HIST = Value
            OnPropertyChanged("ID_ACCION_FORMATIVA_HIST")
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

    Private _ID_OFERTA_FORMATIVA As Decimal
    <Column(Name:="Id oferta formativa", Storage:="ID_OFERTA_FORMATIVA", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=8, Scale:=0)> _
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

    Private _ID_SITIO_CAPACITACION As Decimal
    <Column(Name:="Id sitio capacitacion", Storage:="ID_SITIO_CAPACITACION", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_SITIO_CAPACITACION() As Decimal
        Get
            Return _ID_SITIO_CAPACITACION
        End Get
        Set(ByVal Value As Decimal)
            _ID_SITIO_CAPACITACION = Value
            OnPropertyChanged("ID_SITIO_CAPACITACION")
        End Set
    End Property

    Private _ID_SITIO_CAPACITACIONOld As Decimal
    Public Property ID_SITIO_CAPACITACIONOld() As Decimal
        Get
            Return _ID_SITIO_CAPACITACIONOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_SITIO_CAPACITACIONOld = Value
        End Set
    End Property

    Private _ID_PROVEEDOR_AF As Decimal
    <Column(Name:="Id proveedor af", Storage:="ID_PROVEEDOR_AF", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=0, Scale:=0)> _
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

    Private _ID_TEMA_CURSO As Decimal
    <Column(Name:="Id tema curso", Storage:="ID_TEMA_CURSO", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_TEMA_CURSO() As Decimal
        Get
            Return _ID_TEMA_CURSO
        End Get
        Set(ByVal Value As Decimal)
            _ID_TEMA_CURSO = Value
            OnPropertyChanged("ID_TEMA_CURSO")
        End Set
    End Property

    Private _ID_TEMA_CURSOOld As Decimal
    Public Property ID_TEMA_CURSOOld() As Decimal
        Get
            Return _ID_TEMA_CURSOOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_TEMA_CURSOOld = Value
        End Set
    End Property

    Private _ID_EJERCICIO As String
    <Column(Name:="Id ejercicio", Storage:="ID_EJERCICIO", DbType:="CHAR(4)", Id:=False), _
     DataObjectField(False, False, True, 4)> _
    Public Property ID_EJERCICIO() As String
        Get
            Return _ID_EJERCICIO
        End Get
        Set(ByVal Value As String)
            _ID_EJERCICIO = Value
            OnPropertyChanged("ID_EJERCICIO")
        End Set
    End Property

    Private _ID_EJERCICIOOld As String
    Public Property ID_EJERCICIOOld() As String
        Get
            Return _ID_EJERCICIOOld
        End Get
        Set(ByVal Value As String)
            _ID_EJERCICIOOld = Value
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

    Private _CODIGO_GRUPO As String
    <Column(Name:="Codigo grupo", Storage:="CODIGO_GRUPO", DbType:="VARCHAR2(40)", Id:=False), _
     DataObjectField(False, False, True, 40)> _
    Public Property CODIGO_GRUPO() As String
        Get
            Return _CODIGO_GRUPO
        End Get
        Set(ByVal Value As String)
            _CODIGO_GRUPO = Value
            OnPropertyChanged("CODIGO_GRUPO")
        End Set
    End Property

    Private _CODIGO_GRUPOOld As String
    Public Property CODIGO_GRUPOOld() As String
        Get
            Return _CODIGO_GRUPOOld
        End Get
        Set(ByVal Value As String)
            _CODIGO_GRUPOOld = Value
        End Set
    End Property

    Private _NUMERO_PARTICIPANTES As Decimal
    <Column(Name:="Numero participantes", Storage:="NUMERO_PARTICIPANTES", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=0, Scale:=0)> _
    Public Property NUMERO_PARTICIPANTES() As Decimal
        Get
            Return _NUMERO_PARTICIPANTES
        End Get
        Set(ByVal Value As Decimal)
            _NUMERO_PARTICIPANTES = Value
            OnPropertyChanged("NUMERO_PARTICIPANTES")
        End Set
    End Property

    Private _NUMERO_PARTICIPANTESOld As Decimal
    Public Property NUMERO_PARTICIPANTESOld() As Decimal
        Get
            Return _NUMERO_PARTICIPANTESOld
        End Get
        Set(ByVal Value As Decimal)
            _NUMERO_PARTICIPANTESOld = Value
        End Set
    End Property

    Private _PARTICIPANTES_INSCRITOS As Decimal
    <Column(Name:="Participantes inscritos", Storage:="PARTICIPANTES_INSCRITOS", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=0, Scale:=0)> _
    Public Property PARTICIPANTES_INSCRITOS() As Decimal
        Get
            Return _PARTICIPANTES_INSCRITOS
        End Get
        Set(ByVal Value As Decimal)
            _PARTICIPANTES_INSCRITOS = Value
            OnPropertyChanged("PARTICIPANTES_INSCRITOS")
        End Set
    End Property

    Private _PARTICIPANTES_INSCRITOSOld As Decimal
    Public Property PARTICIPANTES_INSCRITOSOld() As Decimal
        Get
            Return _PARTICIPANTES_INSCRITOSOld
        End Get
        Set(ByVal Value As Decimal)
            _PARTICIPANTES_INSCRITOSOld = Value
        End Set
    End Property
   

    Private _HORARIO As String
    <Column(Name:="Horario", Storage:="HORARIO", DbType:="VARCHAR2(600)", Id:=False), _
     DataObjectField(False, False, True, 600)> _
    Public Property HORARIO() As String
        Get
            Return _HORARIO
        End Get
        Set(ByVal Value As String)
            _HORARIO = Value
            OnPropertyChanged("HORARIO")
        End Set
    End Property

    Private _HORARIOOld As String
    Public Property HORARIOOld() As String
        Get
            Return _HORARIOOld
        End Get
        Set(ByVal Value As String)
            _HORARIOOld = Value
        End Set
    End Property

    Private _NOTAS As String
    <Column(Name:="Notas", Storage:="NOTAS", DbType:="VARCHAR2(255)", Id:=False), _
     DataObjectField(False, False, True, 255)> _
    Public Property NOTAS() As String
        Get
            Return _NOTAS
        End Get
        Set(ByVal Value As String)
            _NOTAS = Value
            OnPropertyChanged("NOTAS")
        End Set
    End Property

    Private _NOTASOld As String
    Public Property NOTASOld() As String
        Get
            Return _NOTASOld
        End Get
        Set(ByVal Value As String)
            _NOTASOld = Value
        End Set
    End Property

    Private _CODIGO_ESTADO_AF As String
    <Column(Name:="Codigo estado af", Storage:="CODIGO_ESTADO_AF", DbType:="CHAR(2)", Id:=False), _
     DataObjectField(False, False, True, 2)> _
    Public Property CODIGO_ESTADO_AF() As String
        Get
            Return _CODIGO_ESTADO_AF
        End Get
        Set(ByVal Value As String)
            _CODIGO_ESTADO_AF = Value
            OnPropertyChanged("CODIGO_ESTADO_AF")
        End Set
    End Property

    Private _CODIGO_ESTADO_AFOld As String
    Public Property CODIGO_ESTADO_AFOld() As String
        Get
            Return _CODIGO_ESTADO_AFOld
        End Get
        Set(ByVal Value As String)
            _CODIGO_ESTADO_AFOld = Value
        End Set
    End Property

    Private _DURACION_HORAS As Decimal
    <Column(Name:="Duracion horas", Storage:="DURACION_HORAS", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=0, Scale:=0)> _
    Public Property DURACION_HORAS() As Decimal
        Get
            Return _DURACION_HORAS
        End Get
        Set(ByVal Value As Decimal)
            _DURACION_HORAS = Value
            OnPropertyChanged("DURACION_HORAS")
        End Set
    End Property

    Private _DURACION_HORASOld As Decimal
    Public Property DURACION_HORASOld() As Decimal
        Get
            Return _DURACION_HORASOld
        End Get
        Set(ByVal Value As Decimal)
            _DURACION_HORASOld = Value
        End Set
    End Property

    Private _COSTO_X_PARTICIPANTE As Decimal
    <Column(Name:="Costo x participante", Storage:="COSTO_X_PARTICIPANTE", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=2)> _
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

    Private _FECHA_INICIO_REAL As DateTime
    <Column(Name:="Fecha inicio real", Storage:="FECHA_INICIO_REAL", DbType:="DATE", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property FECHA_INICIO_REAL() As DateTime
        Get
            Return _FECHA_INICIO_REAL
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_INICIO_REAL = Value
            OnPropertyChanged("FECHA_INICIO_REAL")
        End Set
    End Property

    Private _FECHA_INICIO_REALOld As DateTime
    Public Property FECHA_INICIO_REALOld() As DateTime
        Get
            Return _FECHA_INICIO_REALOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_INICIO_REALOld = Value
        End Set
    End Property

    Private _FECHA_FIN_REAL As DateTime
    <Column(Name:="Fecha fin real", Storage:="FECHA_FIN_REAL", DbType:="DATE", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property FECHA_FIN_REAL() As DateTime
        Get
            Return _FECHA_FIN_REAL
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_FIN_REAL = Value
            OnPropertyChanged("FECHA_FIN_REAL")
        End Set
    End Property

    Private _FECHA_FIN_REALOld As DateTime
    Public Property FECHA_FIN_REALOld() As DateTime
        Get
            Return _FECHA_FIN_REALOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_FIN_REALOld = Value
        End Set
    End Property

    Private _OBSERVACIONES As String
    <Column(Name:="Observaciones", Storage:="OBSERVACIONES", DbType:="VARCHAR2(1000)", Id:=False), _
     DataObjectField(False, False, True, 1000)> _
    Public Property OBSERVACIONES() As String
        Get
            Return _OBSERVACIONES
        End Get
        Set(ByVal Value As String)
            _OBSERVACIONES = Value
            OnPropertyChanged("OBSERVACIONES")
        End Set
    End Property
#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
