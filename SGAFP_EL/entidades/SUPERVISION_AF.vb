''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.SUPERVISION_AF
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite tener un registro de la tabla SUPERVISION_AF en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="SUPERVISION_AF")> Public Class SUPERVISION_AF
    Inherits entidadBase
    Implements IEquatable(Of SUPERVISION_AF), IComparable(Of SUPERVISION_AF)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_SUPERVISION_AF As Decimal, aID_MODALIDAD_FORMACION As Decimal, aID_ACCION_FORMATIVA As Decimal, aFECHA As DateTime, aNOMBRE_AF As String, aCENTRO_FORMACION As String, aOPCION As String, aGRUPO As String, aHORARIO As String, aCODIGO As String, aCOORDINADOR_CFP As String, aDIRECTOR_CFP As String, aPARTICIPANTES_PRESENTES As Decimal, aPARTICIPANTES_AUSENTES As Decimal, aPARTICIPANTES_INSCRITOS As Decimal, aPARTICIPANTES_DESERTADOS As Decimal, aPARTICIPANTES_SUPLENTES As Decimal, aOBJETIVO_VISITA As String, aNOTAS As String, aDURACION_VISITA As Decimal)
        Me._ID_SUPERVISION_AF = aID_SUPERVISION_AF
        Me._ID_MODALIDAD_FORMACION = aID_MODALIDAD_FORMACION
        Me._ID_ACCION_FORMATIVA = aID_ACCION_FORMATIVA
        Me._FECHA = aFECHA
        Me._NOMBRE_AF = aNOMBRE_AF
        Me._CENTRO_FORMACION = aCENTRO_FORMACION
        Me._OPCION = aOPCION
        Me._GRUPO = aGRUPO
        Me._HORARIO = aHORARIO
        Me._CODIGO = aCODIGO
        Me._COORDINADOR_CFP = aCOORDINADOR_CFP
        Me._DIRECTOR_CFP = aDIRECTOR_CFP
        Me._PARTICIPANTES_PRESENTES = aPARTICIPANTES_PRESENTES
        Me._PARTICIPANTES_AUSENTES = aPARTICIPANTES_AUSENTES
        Me._PARTICIPANTES_INSCRITOS = aPARTICIPANTES_INSCRITOS
        Me._PARTICIPANTES_DESERTADOS = aPARTICIPANTES_DESERTADOS
        Me._PARTICIPANTES_SUPLENTES = aPARTICIPANTES_SUPLENTES
        Me._OBJETIVO_VISITA = aOBJETIVO_VISITA
        Me._NOTAS = aNOTAS
        Me._DURACION_VISITA = aDURACION_VISITA
    End Sub

    Public Function Equals1(ByVal other As SUPERVISION_AF) As Boolean Implements System.IEquatable(Of SUPERVISION_AF).Equals
        Return Me.ID_SUPERVISION_AF = other.ID_SUPERVISION_AF
    End Function

    Public Function CompareTo(ByVal other As SUPERVISION_AF) As Integer Implements System.IComparable(Of SUPERVISION_AF).CompareTo
        If Me.ID_SUPERVISION_AF > other.ID_SUPERVISION_AF Then Return 1
        If Me.ID_SUPERVISION_AF < other.ID_SUPERVISION_AF Then Return -1
        Return 0
    End Function


#Region " Propiedades "

    Private _ID_SUPERVISION_AF As Decimal
    <Column(Name:="Id supervision af", Storage:="ID_SUPERVISION_AF", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_SUPERVISION_AF() As Decimal
        Get
            Return _ID_SUPERVISION_AF
        End Get
        Set(ByVal Value As Decimal)
            _ID_SUPERVISION_AF = Value
            OnPropertyChanged("ID_SUPERVISION_AF")
        End Set
    End Property 

    Private _ID_MODALIDAD_FORMACION As Decimal
    <Column(Name:="Id modalidad formacion", Storage:="ID_MODALIDAD_FORMACION", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_MODALIDAD_FORMACION() As Decimal
        Get
            Return _ID_MODALIDAD_FORMACION
        End Get
        Set(ByVal Value As Decimal)
            _ID_MODALIDAD_FORMACION = Value
            OnPropertyChanged("ID_MODALIDAD_FORMACION")
        End Set
    End Property 

    Private _ID_MODALIDAD_FORMACIONOld As Decimal
    Public Property ID_MODALIDAD_FORMACIONOld() As Decimal
        Get
            Return _ID_MODALIDAD_FORMACIONOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_MODALIDAD_FORMACIONOld = Value
        End Set
    End Property 

    Private _fkID_MODALIDAD_FORMACION As MODALIDAD_DE_FORMACION
    Public Property fkID_MODALIDAD_FORMACION() As MODALIDAD_DE_FORMACION
        Get
            Return _fkID_MODALIDAD_FORMACION
        End Get
        Set(ByVal Value As MODALIDAD_DE_FORMACION)
            _fkID_MODALIDAD_FORMACION = Value
        End Set
    End Property 

    Private _ID_ACCION_FORMATIVA As Decimal
    <Column(Name:="Id accion formativa", Storage:="ID_ACCION_FORMATIVA", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=8, Scale:=0)> _
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

    Private _fkID_ACCION_FORMATIVA As ACCION_FORMATIVA
    Public Property fkID_ACCION_FORMATIVA() As ACCION_FORMATIVA
        Get
            Return _fkID_ACCION_FORMATIVA
        End Get
        Set(ByVal Value As ACCION_FORMATIVA)
            _fkID_ACCION_FORMATIVA = Value
        End Set
    End Property 

    Private _FECHA As DateTime
    <Column(Name:="Fecha", Storage:="FECHA", DbType:="DATE", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property FECHA() As DateTime
        Get
            Return _FECHA
        End Get
        Set(ByVal Value As DateTime)
            _FECHA = Value
            OnPropertyChanged("FECHA")
        End Set
    End Property 

    Private _FECHAOld As DateTime
    Public Property FECHAOld() As DateTime
        Get
            Return _FECHAOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHAOld = Value
        End Set
    End Property 

    Private _NOMBRE_AF As String
    <Column(Name:="Nombre af", Storage:="NOMBRE_AF", DbType:="VARCHAR2(150)", Id:=False), _
     DataObjectField(False, False, True, 150)> _
    Public Property NOMBRE_AF() As String
        Get
            Return _NOMBRE_AF
        End Get
        Set(ByVal Value As String)
            _NOMBRE_AF = Value
            OnPropertyChanged("NOMBRE_AF")
        End Set
    End Property 

    Private _NOMBRE_AFOld As String
    Public Property NOMBRE_AFOld() As String
        Get
            Return _NOMBRE_AFOld
        End Get
        Set(ByVal Value As String)
            _NOMBRE_AFOld = Value
        End Set
    End Property 

    Private _CENTRO_FORMACION As String
    <Column(Name:="Centro formacion", Storage:="CENTRO_FORMACION", DbType:="VARCHAR2(100)", Id:=False), _
     DataObjectField(False, False, True, 100)> _
    Public Property CENTRO_FORMACION() As String
        Get
            Return _CENTRO_FORMACION
        End Get
        Set(ByVal Value As String)
            _CENTRO_FORMACION = Value
            OnPropertyChanged("CENTRO_FORMACION")
        End Set
    End Property 

    Private _CENTRO_FORMACIONOld As String
    Public Property CENTRO_FORMACIONOld() As String
        Get
            Return _CENTRO_FORMACIONOld
        End Get
        Set(ByVal Value As String)
            _CENTRO_FORMACIONOld = Value
        End Set
    End Property 

    Private _OPCION As String
    <Column(Name:="Opcion", Storage:="OPCION", DbType:="CHAR(1)", Id:=False), _
     DataObjectField(False, False, True, 1)> _
    Public Property OPCION() As String
        Get
            Return _OPCION
        End Get
        Set(ByVal Value As String)
            _OPCION = Value
            OnPropertyChanged("OPCION")
        End Set
    End Property 

    Private _OPCIONOld As String
    Public Property OPCIONOld() As String
        Get
            Return _OPCIONOld
        End Get
        Set(ByVal Value As String)
            _OPCIONOld = Value
        End Set
    End Property 

    Private _GRUPO As String
    <Column(Name:="Grupo", Storage:="GRUPO", DbType:="VARCHAR2(30)", Id:=False), _
     DataObjectField(False, False, True, 30)> _
    Public Property GRUPO() As String
        Get
            Return _GRUPO
        End Get
        Set(ByVal Value As String)
            _GRUPO = Value
            OnPropertyChanged("GRUPO")
        End Set
    End Property 

    Private _GRUPOOld As String
    Public Property GRUPOOld() As String
        Get
            Return _GRUPOOld
        End Get
        Set(ByVal Value As String)
            _GRUPOOld = Value
        End Set
    End Property 

    Private _HORARIO As String
    <Column(Name:="Horario", Storage:="HORARIO", DbType:="VARCHAR2(255)", Id:=False), _
     DataObjectField(False, False, True, 255)> _
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

    Private _CODIGO As String
    <Column(Name:="Codigo", Storage:="CODIGO", DbType:="VARCHAR2(20)", Id:=False), _
     DataObjectField(False, False, True, 20)> _
    Public Property CODIGO() As String
        Get
            Return _CODIGO
        End Get
        Set(ByVal Value As String)
            _CODIGO = Value
            OnPropertyChanged("CODIGO")
        End Set
    End Property 

    Private _CODIGOOld As String
    Public Property CODIGOOld() As String
        Get
            Return _CODIGOOld
        End Get
        Set(ByVal Value As String)
            _CODIGOOld = Value
        End Set
    End Property 

    Private _COORDINADOR_CFP As String
    <Column(Name:="Coordinador cfp", Storage:="COORDINADOR_CFP", DbType:="VARCHAR2(60)", Id:=False), _
     DataObjectField(False, False, True, 60)> _
    Public Property COORDINADOR_CFP() As String
        Get
            Return _COORDINADOR_CFP
        End Get
        Set(ByVal Value As String)
            _COORDINADOR_CFP = Value
            OnPropertyChanged("COORDINADOR_CFP")
        End Set
    End Property 

    Private _COORDINADOR_CFPOld As String
    Public Property COORDINADOR_CFPOld() As String
        Get
            Return _COORDINADOR_CFPOld
        End Get
        Set(ByVal Value As String)
            _COORDINADOR_CFPOld = Value
        End Set
    End Property 

    Private _DIRECTOR_CFP As String
    <Column(Name:="Director cfp", Storage:="DIRECTOR_CFP", DbType:="VARCHAR2(60)", Id:=False), _
     DataObjectField(False, False, True, 60)> _
    Public Property DIRECTOR_CFP() As String
        Get
            Return _DIRECTOR_CFP
        End Get
        Set(ByVal Value As String)
            _DIRECTOR_CFP = Value
            OnPropertyChanged("DIRECTOR_CFP")
        End Set
    End Property 

    Private _DIRECTOR_CFPOld As String
    Public Property DIRECTOR_CFPOld() As String
        Get
            Return _DIRECTOR_CFPOld
        End Get
        Set(ByVal Value As String)
            _DIRECTOR_CFPOld = Value
        End Set
    End Property 

    Private _PARTICIPANTES_PRESENTES As Decimal
    <Column(Name:="Participantes presentes", Storage:="PARTICIPANTES_PRESENTES", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=0, Scale:=0)> _
    Public Property PARTICIPANTES_PRESENTES() As Decimal
        Get
            Return _PARTICIPANTES_PRESENTES
        End Get
        Set(ByVal Value As Decimal)
            _PARTICIPANTES_PRESENTES = Value
            OnPropertyChanged("PARTICIPANTES_PRESENTES")
        End Set
    End Property 

    Private _PARTICIPANTES_PRESENTESOld As Decimal
    Public Property PARTICIPANTES_PRESENTESOld() As Decimal
        Get
            Return _PARTICIPANTES_PRESENTESOld
        End Get
        Set(ByVal Value As Decimal)
            _PARTICIPANTES_PRESENTESOld = Value
        End Set
    End Property 

    Private _PARTICIPANTES_AUSENTES As Decimal
    <Column(Name:="Participantes ausentes", Storage:="PARTICIPANTES_AUSENTES", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=0, Scale:=0)> _
    Public Property PARTICIPANTES_AUSENTES() As Decimal
        Get
            Return _PARTICIPANTES_AUSENTES
        End Get
        Set(ByVal Value As Decimal)
            _PARTICIPANTES_AUSENTES = Value
            OnPropertyChanged("PARTICIPANTES_AUSENTES")
        End Set
    End Property 

    Private _PARTICIPANTES_AUSENTESOld As Decimal
    Public Property PARTICIPANTES_AUSENTESOld() As Decimal
        Get
            Return _PARTICIPANTES_AUSENTESOld
        End Get
        Set(ByVal Value As Decimal)
            _PARTICIPANTES_AUSENTESOld = Value
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

    Private _PARTICIPANTES_DESERTADOS As Decimal
    <Column(Name:="Participantes desertados", Storage:="PARTICIPANTES_DESERTADOS", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=0, Scale:=0)> _
    Public Property PARTICIPANTES_DESERTADOS() As Decimal
        Get
            Return _PARTICIPANTES_DESERTADOS
        End Get
        Set(ByVal Value As Decimal)
            _PARTICIPANTES_DESERTADOS = Value
            OnPropertyChanged("PARTICIPANTES_DESERTADOS")
        End Set
    End Property 

    Private _PARTICIPANTES_DESERTADOSOld As Decimal
    Public Property PARTICIPANTES_DESERTADOSOld() As Decimal
        Get
            Return _PARTICIPANTES_DESERTADOSOld
        End Get
        Set(ByVal Value As Decimal)
            _PARTICIPANTES_DESERTADOSOld = Value
        End Set
    End Property 

    Private _PARTICIPANTES_SUPLENTES As Decimal
    <Column(Name:="Participantes suplentes", Storage:="PARTICIPANTES_SUPLENTES", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=0, Scale:=0)> _
    Public Property PARTICIPANTES_SUPLENTES() As Decimal
        Get
            Return _PARTICIPANTES_SUPLENTES
        End Get
        Set(ByVal Value As Decimal)
            _PARTICIPANTES_SUPLENTES = Value
            OnPropertyChanged("PARTICIPANTES_SUPLENTES")
        End Set
    End Property 

    Private _PARTICIPANTES_SUPLENTESOld As Decimal
    Public Property PARTICIPANTES_SUPLENTESOld() As Decimal
        Get
            Return _PARTICIPANTES_SUPLENTESOld
        End Get
        Set(ByVal Value As Decimal)
            _PARTICIPANTES_SUPLENTESOld = Value
        End Set
    End Property 

    Private _OBJETIVO_VISITA As String
    <Column(Name:="Objetivo visita", Storage:="OBJETIVO_VISITA", DbType:="VARCHAR2(255)", Id:=False), _
     DataObjectField(False, False, True, 255)> _
    Public Property OBJETIVO_VISITA() As String
        Get
            Return _OBJETIVO_VISITA
        End Get
        Set(ByVal Value As String)
            _OBJETIVO_VISITA = Value
            OnPropertyChanged("OBJETIVO_VISITA")
        End Set
    End Property 

    Private _OBJETIVO_VISITAOld As String
    Public Property OBJETIVO_VISITAOld() As String
        Get
            Return _OBJETIVO_VISITAOld
        End Get
        Set(ByVal Value As String)
            _OBJETIVO_VISITAOld = Value
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

    Private _DURACION_VISITA As Decimal
    <Column(Name:="Duracion visita", Storage:="DURACION_VISITA", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=0, Scale:=0)> _
    Public Property DURACION_VISITA() As Decimal
        Get
            Return _DURACION_VISITA
        End Get
        Set(ByVal Value As Decimal)
            _DURACION_VISITA = Value
            OnPropertyChanged("DURACION_VISITA")
        End Set
    End Property 

    Private _DURACION_VISITAOld As Decimal
    Public Property DURACION_VISITAOld() As Decimal
        Get
            Return _DURACION_VISITAOld
        End Get
        Set(ByVal Value As Decimal)
            _DURACION_VISITAOld = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
