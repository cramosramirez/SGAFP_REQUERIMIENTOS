''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.ACCION_FORMATIVA_REPROG
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite tener un registro de la tabla ACCION_FORMATIVA_REPROG en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	01/06/2010	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="ACCION_FORMATIVA_REPROG")> Public Class ACCION_FORMATIVA_REPROG
    Inherits entidadBase
    Implements IEquatable(Of ACCION_FORMATIVA_REPROG), IComparable(Of ACCION_FORMATIVA_REPROG)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_ACCION_FORMATIVA_REPROG As Decimal, aID_ESTADO_REPROG As Decimal, aID_ACCION_FORMATIVA As Decimal, aID_OFERTA_FORMATIVA As Decimal, aID_SITIO_CAPACITACION As Decimal, aID_PROVEEDOR_AF As Decimal, aID_TEMA_CURSO As Decimal, aID_EJERCICIO As String, aNOMBRE_ACCION_FORMATIVA As String, aCODIGO_GRUPO As String, aNUMERO_PARTICIPANTES As Decimal, aPARTICIPANTES_INSCRITOS As Decimal, aHORARIO As String, aNOTAS As String, aCODIGO_ESTADO_AF As String, aDURACION_HORAS As Decimal, aCOSTO_X_PARTICIPANTE As Decimal, aLASTUPDATE As DateTime, aUSERID As String, aFECHA_INICIO_REAL As DateTime, aFECHA_FIN_REAL As DateTime, ByVal aCODI_FORMADOR As String, ByVal aNOMBRE_FORMADOR As String)
        Me._ID_ACCION_FORMATIVA_REPROG = aID_ACCION_FORMATIVA_REPROG
        Me._ID_ESTADO_REPROG = aID_ESTADO_REPROG
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
        Me._CODI_FORMADOR = aCODI_FORMADOR
        Me._NOMBRE_FORMADOR = aNOMBRE_FORMADOR
    End Sub

    Public Function Equals1(ByVal other As ACCION_FORMATIVA_REPROG) As Boolean Implements System.IEquatable(Of ACCION_FORMATIVA_REPROG).Equals
        Return Me.ID_ACCION_FORMATIVA_REPROG = other.ID_ACCION_FORMATIVA_REPROG
    End Function

    Public Function CompareTo(ByVal other As ACCION_FORMATIVA_REPROG) As Integer Implements System.IComparable(Of ACCION_FORMATIVA_REPROG).CompareTo
        If Me.ID_ACCION_FORMATIVA_REPROG > other.ID_ACCION_FORMATIVA_REPROG Then Return 1
        If Me.ID_ACCION_FORMATIVA_REPROG < other.ID_ACCION_FORMATIVA_REPROG Then Return -1
        Return 0
    End Function


#Region " Propiedades "

    Private _ID_ACCION_FORMATIVA_REPROG As Decimal
    <Column(Name:="Id accion formativa reprog", Storage:="ID_ACCION_FORMATIVA_REPROG", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_ACCION_FORMATIVA_REPROG() As Decimal
        Get
            Return _ID_ACCION_FORMATIVA_REPROG
        End Get
        Set(ByVal Value As Decimal)
            _ID_ACCION_FORMATIVA_REPROG = Value
            OnPropertyChanged("ID_ACCION_FORMATIVA_REPROG")
        End Set
    End Property 

    Private _ID_ESTADO_REPROG As Decimal
    <Column(Name:="Id estado reprog", Storage:="ID_ESTADO_REPROG", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_ESTADO_REPROG() As Decimal
        Get
            Return _ID_ESTADO_REPROG
        End Get
        Set(ByVal Value As Decimal)
            _ID_ESTADO_REPROG = Value
            OnPropertyChanged("ID_ESTADO_REPROG")
        End Set
    End Property 

    Private _ID_ESTADO_REPROGOld As Decimal
    Public Property ID_ESTADO_REPROGOld() As Decimal
        Get
            Return _ID_ESTADO_REPROGOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_ESTADO_REPROGOld = Value
        End Set
    End Property 

    Private _fkID_ESTADO_REPROG As ESTADO_REPROG
    Public Property fkID_ESTADO_REPROG() As ESTADO_REPROG
        Get
            Return _fkID_ESTADO_REPROG
        End Get
        Set(ByVal Value As ESTADO_REPROG)
            _fkID_ESTADO_REPROG = Value
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

    Private _fkID_OFERTA_FORMATIVA As OFERTA_FORMATIVA
    Public Property fkID_OFERTA_FORMATIVA() As OFERTA_FORMATIVA
        Get
            Return _fkID_OFERTA_FORMATIVA
        End Get
        Set(ByVal Value As OFERTA_FORMATIVA)
            _fkID_OFERTA_FORMATIVA = Value
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

    Private _fkID_SITIO_CAPACITACION As SITIO_CAPACITACION
    Public Property fkID_SITIO_CAPACITACION() As SITIO_CAPACITACION
        Get
            Return _fkID_SITIO_CAPACITACION
        End Get
        Set(ByVal Value As SITIO_CAPACITACION)
            _fkID_SITIO_CAPACITACION = Value
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

    Private _fkID_PROVEEDOR_AF As PROVEEDOR_AF
    Public Property fkID_PROVEEDOR_AF() As PROVEEDOR_AF
        Get
            Return _fkID_PROVEEDOR_AF
        End Get
        Set(ByVal Value As PROVEEDOR_AF)
            _fkID_PROVEEDOR_AF = Value
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

    Private _fkCODIGO_ESTADO_AF As ESTADO_ACCION_FORMATIVA
    Public Property fkCODIGO_ESTADO_AF() As ESTADO_ACCION_FORMATIVA
        Get
            Return _fkCODIGO_ESTADO_AF
        End Get
        Set(ByVal Value As ESTADO_ACCION_FORMATIVA)
            _fkCODIGO_ESTADO_AF = Value
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

    Private _MOTIVOREPROG As String
    <Column(Name:="MOTIVOREPROG", Storage:="MOTIVOREPROG", DbType:="VARCHAR2(500)", Id:=False), _
     DataObjectField(False, False, True, 500)> _
    Public Property MOTIVOREPROG() As String
        Get
            Return _MOTIVOREPROG
        End Get
        Set(ByVal Value As String)
            _MOTIVOREPROG = Value
            OnPropertyChanged("MOTIVOREPROG")
        End Set
    End Property

    Private _MOTIVOREPROGOld As String
    Public Property MOTIVOREPROGOld() As String
        Get
            Return _MOTIVOREPROGOld
        End Get
        Set(ByVal Value As String)
            _MOTIVOREPROGOld = Value
        End Set
    End Property


    Private _MOTIVORECHAZO As String
    <Column(Name:="MOTIVORECHAZO", Storage:="MOTIVORECHAZO", DbType:="VARCHAR2(500)", Id:=False), _
     DataObjectField(False, False, True, 500)> _
    Public Property MOTIVORECHAZO() As String
        Get
            Return _MOTIVORECHAZO
        End Get
        Set(ByVal Value As String)
            _MOTIVORECHAZO = Value
            OnPropertyChanged("MOTIVORECHAZO")
        End Set
    End Property

    Private _MOTIVORECHAZOOld As String
    Public Property MOTIVORECHAZOOld() As String
        Get
            Return _MOTIVORECHAZOOld
        End Get
        Set(ByVal Value As String)
            _MOTIVORECHAZOOld = Value
        End Set
    End Property

    Private _FECHA_SOLIC_REPROG As DateTime
    <Column(Name:="FECHA_SOLIC_REPROG", Storage:="FECHA_SOLIC_REPROG", DbType:="DATE", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property FECHA_SOLIC_REPROG() As DateTime
        Get
            Return _FECHA_SOLIC_REPROG
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_SOLIC_REPROG = Value
            OnPropertyChanged("FECHA_SOLIC_REPROG")
        End Set
    End Property

    Private _FECHA_SOLIC_REPROGOld As DateTime
    Public Property FECHA_SOLIC_REPROGOld() As DateTime
        Get
            Return _FECHA_SOLIC_REPROGOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_SOLIC_REPROGOld = Value
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

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
