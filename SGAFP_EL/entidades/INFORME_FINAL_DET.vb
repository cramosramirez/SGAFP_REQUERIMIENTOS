''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.INFORME_FINAL_DET
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite tener un registro de la tabla INFORME_FINAL_DET en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	01/06/2010	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="INFORME_FINAL_DET")> Public Class INFORME_FINAL_DET
    Inherits entidadBase
    Implements IEquatable(Of INFORME_FINAL_DET), IComparable(Of INFORME_FINAL_DET)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_INFORME_FINAL_DET As Decimal, aID_INFORME_FINAL As Decimal, aID_PARTICIPANTE As Decimal, aID_ACCION_FORMATIVA As Decimal, aNOTA_OBTENIDA As Decimal, aPORC_ASISTENCIA As Decimal, aMONTO_SOLICITADO As Decimal, aMONTO_APROBADO As Decimal, aESTADO As String, aNOTAS As String, aUSERID As String, aLASTUPDATE As DateTime, aNOTA_TEORICA As Decimal, aNOTA_PRACTICA As Decimal)
        Me._ID_INFORME_FINAL_DET = aID_INFORME_FINAL_DET
        Me._ID_INFORME_FINAL = aID_INFORME_FINAL
        Me._ID_PARTICIPANTE = aID_PARTICIPANTE
        Me._ID_ACCION_FORMATIVA = aID_ACCION_FORMATIVA
        Me._NOTA_OBTENIDA = aNOTA_OBTENIDA
        Me._PORC_ASISTENCIA = aPORC_ASISTENCIA
        Me._MONTO_SOLICITADO = aMONTO_SOLICITADO
        Me._MONTO_APROBADO = aMONTO_APROBADO
        Me._ESTADO = aESTADO
        Me._NOTAS = aNOTAS
        Me._USERID = aUSERID
        Me._LASTUPDATE = aLASTUPDATE
        Me._NOTA_TEORICA = aNOTA_TEORICA
        Me._NOTA_PRACTICA = aNOTA_PRACTICA
    End Sub

    Public Function Equals1(ByVal other As INFORME_FINAL_DET) As Boolean Implements System.IEquatable(Of INFORME_FINAL_DET).Equals
        Return Me.ID_INFORME_FINAL_DET = other.ID_INFORME_FINAL_DET
    End Function

    Public Function CompareTo(ByVal other As INFORME_FINAL_DET) As Integer Implements System.IComparable(Of INFORME_FINAL_DET).CompareTo
        If Me.ID_INFORME_FINAL_DET > other.ID_INFORME_FINAL_DET Then Return 1
        If Me.ID_INFORME_FINAL_DET < other.ID_INFORME_FINAL_DET Then Return -1
        Return 0
    End Function


#Region " Propiedades "

    Private _ID_INFORME_FINAL_DET As Decimal
    <Column(Name:="Id informe final det", Storage:="ID_INFORME_FINAL_DET", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_INFORME_FINAL_DET() As Decimal
        Get
            Return _ID_INFORME_FINAL_DET
        End Get
        Set(ByVal Value As Decimal)
            _ID_INFORME_FINAL_DET = Value
            OnPropertyChanged("ID_INFORME_FINAL_DET")
        End Set
    End Property 

    Private _ID_INFORME_FINAL As Decimal
    <Column(Name:="Id informe final", Storage:="ID_INFORME_FINAL", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_INFORME_FINAL() As Decimal
        Get
            Return _ID_INFORME_FINAL
        End Get
        Set(ByVal Value As Decimal)
            _ID_INFORME_FINAL = Value
            OnPropertyChanged("ID_INFORME_FINAL")
        End Set
    End Property 

    Private _ID_INFORME_FINALOld As Decimal
    Public Property ID_INFORME_FINALOld() As Decimal
        Get
            Return _ID_INFORME_FINALOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_INFORME_FINALOld = Value
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

    Private _ID_PARTICIPANTE As Decimal
    <Column(Name:="Id participante", Storage:="ID_PARTICIPANTE", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_PARTICIPANTE() As Decimal
        Get
            Return _ID_PARTICIPANTE
        End Get
        Set(ByVal Value As Decimal)
            _ID_PARTICIPANTE = Value
            OnPropertyChanged("ID_PARTICIPANTE")
        End Set
    End Property 

    Private _ID_PARTICIPANTEOld As Decimal
    Public Property ID_PARTICIPANTEOld() As Decimal
        Get
            Return _ID_PARTICIPANTEOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_PARTICIPANTEOld = Value
        End Set
    End Property 

    Private _fkID_PARTICIPANTE As PARTICIPANTE
    Public Property fkID_PARTICIPANTE() As PARTICIPANTE
        Get
            Return _fkID_PARTICIPANTE
        End Get
        Set(ByVal Value As PARTICIPANTE)
            _fkID_PARTICIPANTE = Value
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

    Private _NOTA_OBTENIDA As Decimal
    <Column(Name:="Nota obtenida", Storage:="NOTA_OBTENIDA", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=4, Scale:=2)> _
    Public Property NOTA_OBTENIDA() As Decimal
        Get
            Return _NOTA_OBTENIDA
        End Get
        Set(ByVal Value As Decimal)
            _NOTA_OBTENIDA = Value
            OnPropertyChanged("NOTA_OBTENIDA")
        End Set
    End Property 

    Private _NOTA_OBTENIDAOld As Decimal
    Public Property NOTA_OBTENIDAOld() As Decimal
        Get
            Return _NOTA_OBTENIDAOld
        End Get
        Set(ByVal Value As Decimal)
            _NOTA_OBTENIDAOld = Value
        End Set
    End Property 

    Private _PORC_ASISTENCIA As Decimal
    <Column(Name:="Porc asistencia", Storage:="PORC_ASISTENCIA", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=5, Scale:=2)> _
    Public Property PORC_ASISTENCIA() As Decimal
        Get
            Return _PORC_ASISTENCIA
        End Get
        Set(ByVal Value As Decimal)
            _PORC_ASISTENCIA = Value
            OnPropertyChanged("PORC_ASISTENCIA")
        End Set
    End Property 

    Private _PORC_ASISTENCIAOld As Decimal
    Public Property PORC_ASISTENCIAOld() As Decimal
        Get
            Return _PORC_ASISTENCIAOld
        End Get
        Set(ByVal Value As Decimal)
            _PORC_ASISTENCIAOld = Value
        End Set
    End Property 

    Private _MONTO_SOLICITADO As Decimal
    <Column(Name:="Monto solicitado", Storage:="MONTO_SOLICITADO", DBType:="NUMBER", Id:=False),
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=6)>
    Public Property MONTO_SOLICITADO() As Decimal
        Get
            Return _MONTO_SOLICITADO
        End Get
        Set(ByVal Value As Decimal)
            _MONTO_SOLICITADO = Value
            OnPropertyChanged("MONTO_SOLICITADO")
        End Set
    End Property 

    Private _MONTO_SOLICITADOOld As Decimal
    Public Property MONTO_SOLICITADOOld() As Decimal
        Get
            Return _MONTO_SOLICITADOOld
        End Get
        Set(ByVal Value As Decimal)
            _MONTO_SOLICITADOOld = Value
        End Set
    End Property 

    Private _MONTO_APROBADO As Decimal
    <Column(Name:="Monto aprobado", Storage:="MONTO_APROBADO", DBType:="NUMBER", Id:=False),
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=6)>
    Public Property MONTO_APROBADO() As Decimal
        Get
            Return _MONTO_APROBADO
        End Get
        Set(ByVal Value As Decimal)
            _MONTO_APROBADO = Value
            OnPropertyChanged("MONTO_APROBADO")
        End Set
    End Property 

    Private _MONTO_APROBADOOld As Decimal
    Public Property MONTO_APROBADOOld() As Decimal
        Get
            Return _MONTO_APROBADOOld
        End Get
        Set(ByVal Value As Decimal)
            _MONTO_APROBADOOld = Value
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

    Private _NOTA_TEORICA As Decimal
    <Column(Name:="Nota teorica", Storage:="NOTA_TEORICA", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=4, Scale:=2)> _
    Public Property NOTA_TEORICA() As Decimal
        Get
            Return _NOTA_TEORICA
        End Get
        Set(ByVal Value As Decimal)
            _NOTA_TEORICA = Value
            OnPropertyChanged("NOTA_TEORICA")
        End Set
    End Property 

    Private _NOTA_TEORICAOld As Decimal
    Public Property NOTA_TEORICAOld() As Decimal
        Get
            Return _NOTA_TEORICAOld
        End Get
        Set(ByVal Value As Decimal)
            _NOTA_TEORICAOld = Value
        End Set
    End Property 

    Private _NOTA_PRACTICA As Decimal
    <Column(Name:="Nota practica", Storage:="NOTA_PRACTICA", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=4, Scale:=2)> _
    Public Property NOTA_PRACTICA() As Decimal
        Get
            Return _NOTA_PRACTICA
        End Get
        Set(ByVal Value As Decimal)
            _NOTA_PRACTICA = Value
            OnPropertyChanged("NOTA_PRACTICA")
        End Set
    End Property 

    Private _NOTA_PRACTICAOld As Decimal
    Public Property NOTA_PRACTICAOld() As Decimal
        Get
            Return _NOTA_PRACTICAOld
        End Get
        Set(ByVal Value As Decimal)
            _NOTA_PRACTICAOld = Value
        End Set
    End Property

    Private _PORC_PAGO As Decimal
    <Column(Name:="Porc pago", Storage:="PORC_PAGO", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=5, Scale:=2)> _
    Public Property PORC_PAGO() As Decimal
        Get
            Return _PORC_PAGO
        End Get
        Set(ByVal Value As Decimal)
            _PORC_PAGO = Value
            OnPropertyChanged("PORC_PAGO")
        End Set
    End Property

    Private _PORC_PAGOOld As Decimal
    Public Property PORC_PAGOOld() As Decimal
        Get
            Return _PORC_PAGOOld
        End Get
        Set(ByVal Value As Decimal)
            _PORC_PAGOOld = Value
        End Set
    End Property

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
