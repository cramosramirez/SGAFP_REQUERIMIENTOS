''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.INFORME_FINAL_AF
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row INFORME_FINAL_AF en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	20/07/2012	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="INFORME_FINAL_AF")> Public Class INFORME_FINAL_AF
    Inherits entidadBase
    Implements IEquatable(Of INFORME_FINAL_AF), IComparable(Of INFORME_FINAL_AF)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(ByVal aID_INFORME_FINAL As Decimal, ByVal aID_ACCION_FORMATIVA As Decimal, ByVal aID_PROVEEDOR_AF As Decimal, ByVal aFECHA_INFORME As DateTime, ByVal aNUMERO_FACTURA As String, ByVal aELABORADO_POR As String, ByVal aMONTO_FACTURA As Decimal, ByVal aMONTO_APROBADO As Decimal, ByVal aPARTICIPANTES_INSCRITOS As Decimal, ByVal aPARTICIPANTES_FINALES As Decimal, ByVal aPORC_PROM_ASISTENCIA As Decimal, ByVal aNOTA_PROMEDIO As Decimal, ByVal aCOMENTARIOS As String, ByVal aUSUARIO_APROBACION As String, ByVal aLASTUPDATE As DateTime, ByVal aUSERID As String, ByVal aID_ESTADO_INFORME As Decimal, ByVal aHORAS_DESARROLLADAS As Decimal, ByVal aFECHA_INICIAL As DateTime, ByVal aFECHA_FINAL As DateTime, ByVal aHORARIO As String)
        Me._ID_INFORME_FINAL = aID_INFORME_FINAL
        Me._ID_ACCION_FORMATIVA = aID_ACCION_FORMATIVA
        Me._ID_PROVEEDOR_AF = aID_PROVEEDOR_AF
        Me._FECHA_INFORME = aFECHA_INFORME
        Me._NUMERO_FACTURA = aNUMERO_FACTURA
        Me._ELABORADO_POR = aELABORADO_POR
        Me._MONTO_FACTURA = aMONTO_FACTURA
        Me._MONTO_APROBADO = aMONTO_APROBADO
        Me._PARTICIPANTES_INSCRITOS = aPARTICIPANTES_INSCRITOS
        Me._PARTICIPANTES_FINALES = aPARTICIPANTES_FINALES
        Me._PORC_PROM_ASISTENCIA = aPORC_PROM_ASISTENCIA
        Me._NOTA_PROMEDIO = aNOTA_PROMEDIO
        Me._COMENTARIOS = aCOMENTARIOS
        Me._USUARIO_APROBACION = aUSUARIO_APROBACION
        Me._LASTUPDATE = aLASTUPDATE
        Me._USERID = aUSERID
        Me._ID_ESTADO_INFORME = aID_ESTADO_INFORME
        Me._HORAS_DESARROLLADAS = aHORAS_DESARROLLADAS
        Me._FECHA_INICIAL = aFECHA_INICIAL
        Me._FECHA_FINAL = aFECHA_FINAL
        Me._HORARIO = aHORARIO
    End Sub

    Public Function Equals1(ByVal other As INFORME_FINAL_AF) As Boolean Implements System.IEquatable(Of INFORME_FINAL_AF).Equals
        Return Me.ID_INFORME_FINAL = other.ID_INFORME_FINAL
    End Function

    Public Function CompareTo(ByVal other As INFORME_FINAL_AF) As Integer Implements System.IComparable(Of INFORME_FINAL_AF).CompareTo
        If Me.ID_INFORME_FINAL > other.ID_INFORME_FINAL Then Return 1
        If Me.ID_INFORME_FINAL < other.ID_INFORME_FINAL Then Return -1
        Return 0
    End Function


#Region " Properties "

    Private _ID_INFORME_FINAL As Decimal
    <Column(Name:="Id informe final", Storage:="ID_INFORME_FINAL", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_INFORME_FINAL() As Decimal
        Get
            Return _ID_INFORME_FINAL
        End Get
        Set(ByVal Value As Decimal)
            _ID_INFORME_FINAL = Value
            OnPropertyChanged("ID_INFORME_FINAL")
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

    Private _ID_PROVEEDOR_AF As Decimal
    <Column(Name:="Id proveedor af", Storage:="ID_PROVEEDOR_AF", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=8, Scale:=0)> _
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

    Private _FECHA_INFORME As DateTime
    <Column(Name:="Fecha informe", Storage:="FECHA_INFORME", DbType:="DATE", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property FECHA_INFORME() As DateTime
        Get
            Return _FECHA_INFORME
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_INFORME = Value
            OnPropertyChanged("FECHA_INFORME")
        End Set
    End Property 

    Private _FECHA_INFORMEOld As DateTime
    Public Property FECHA_INFORMEOld() As DateTime
        Get
            Return _FECHA_INFORMEOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_INFORMEOld = Value
        End Set
    End Property 

    Private _NUMERO_FACTURA As String
    <Column(Name:="Numero factura", Storage:="NUMERO_FACTURA", DbType:="VARCHAR2(20)", Id:=False), _
     DataObjectField(False, False, True, 20)> _
    Public Property NUMERO_FACTURA() As String
        Get
            Return _NUMERO_FACTURA
        End Get
        Set(ByVal Value As String)
            _NUMERO_FACTURA = Value
            OnPropertyChanged("NUMERO_FACTURA")
        End Set
    End Property 

    Private _NUMERO_FACTURAOld As String
    Public Property NUMERO_FACTURAOld() As String
        Get
            Return _NUMERO_FACTURAOld
        End Get
        Set(ByVal Value As String)
            _NUMERO_FACTURAOld = Value
        End Set
    End Property 

    Private _ELABORADO_POR As String
    <Column(Name:="Elaborado por", Storage:="ELABORADO_POR", DbType:="VARCHAR2(70)", Id:=False), _
     DataObjectField(False, False, True, 70)> _
    Public Property ELABORADO_POR() As String
        Get
            Return _ELABORADO_POR
        End Get
        Set(ByVal Value As String)
            _ELABORADO_POR = Value
            OnPropertyChanged("ELABORADO_POR")
        End Set
    End Property 

    Private _ELABORADO_POROld As String
    Public Property ELABORADO_POROld() As String
        Get
            Return _ELABORADO_POROld
        End Get
        Set(ByVal Value As String)
            _ELABORADO_POROld = Value
        End Set
    End Property 

    Private _MONTO_FACTURA As Decimal
    <Column(Name:="Monto factura", Storage:="MONTO_FACTURA", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=12, Scale:=2)> _
    Public Property MONTO_FACTURA() As Decimal
        Get
            Return _MONTO_FACTURA
        End Get
        Set(ByVal Value As Decimal)
            _MONTO_FACTURA = Value
            OnPropertyChanged("MONTO_FACTURA")
        End Set
    End Property 

    Private _MONTO_FACTURAOld As Decimal
    Public Property MONTO_FACTURAOld() As Decimal
        Get
            Return _MONTO_FACTURAOld
        End Get
        Set(ByVal Value As Decimal)
            _MONTO_FACTURAOld = Value
        End Set
    End Property 

    Private _MONTO_APROBADO As Decimal
    <Column(Name:="Monto aprobado", Storage:="MONTO_APROBADO", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=12, Scale:=2)> _
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

    Private _PARTICIPANTES_FINALES As Decimal
    <Column(Name:="Participantes finales", Storage:="PARTICIPANTES_FINALES", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=0, Scale:=0)> _
    Public Property PARTICIPANTES_FINALES() As Decimal
        Get
            Return _PARTICIPANTES_FINALES
        End Get
        Set(ByVal Value As Decimal)
            _PARTICIPANTES_FINALES = Value
            OnPropertyChanged("PARTICIPANTES_FINALES")
        End Set
    End Property 

    Private _PARTICIPANTES_FINALESOld As Decimal
    Public Property PARTICIPANTES_FINALESOld() As Decimal
        Get
            Return _PARTICIPANTES_FINALESOld
        End Get
        Set(ByVal Value As Decimal)
            _PARTICIPANTES_FINALESOld = Value
        End Set
    End Property 

    Private _PORC_PROM_ASISTENCIA As Decimal
    <Column(Name:="Porc prom asistencia", Storage:="PORC_PROM_ASISTENCIA", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=5, Scale:=2)> _
    Public Property PORC_PROM_ASISTENCIA() As Decimal
        Get
            Return _PORC_PROM_ASISTENCIA
        End Get
        Set(ByVal Value As Decimal)
            _PORC_PROM_ASISTENCIA = Value
            OnPropertyChanged("PORC_PROM_ASISTENCIA")
        End Set
    End Property 

    Private _PORC_PROM_ASISTENCIAOld As Decimal
    Public Property PORC_PROM_ASISTENCIAOld() As Decimal
        Get
            Return _PORC_PROM_ASISTENCIAOld
        End Get
        Set(ByVal Value As Decimal)
            _PORC_PROM_ASISTENCIAOld = Value
        End Set
    End Property 

    Private _NOTA_PROMEDIO As Decimal
    <Column(Name:="Nota promedio", Storage:="NOTA_PROMEDIO", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=4, Scale:=2)> _
    Public Property NOTA_PROMEDIO() As Decimal
        Get
            Return _NOTA_PROMEDIO
        End Get
        Set(ByVal Value As Decimal)
            _NOTA_PROMEDIO = Value
            OnPropertyChanged("NOTA_PROMEDIO")
        End Set
    End Property 

    Private _NOTA_PROMEDIOOld As Decimal
    Public Property NOTA_PROMEDIOOld() As Decimal
        Get
            Return _NOTA_PROMEDIOOld
        End Get
        Set(ByVal Value As Decimal)
            _NOTA_PROMEDIOOld = Value
        End Set
    End Property

    Private _COMENTARIOS As String
    <Column(Name:="Comentarios", Storage:="COMENTARIOS", DbType:="VARCHAR2(1000)", Id:=False), _
     DataObjectField(False, False, True, 1000)> _
    Public Property COMENTARIOS() As String
        Get
            Return _COMENTARIOS
        End Get
        Set(ByVal Value As String)
            _COMENTARIOS = Value
            OnPropertyChanged("COMENTARIOS")
        End Set
    End Property

    Private _COMENTARIOSOld As String
    Public Property COMENTARIOSOld() As String
        Get
            Return _COMENTARIOSOld
        End Get
        Set(ByVal Value As String)
            _COMENTARIOSOld = Value
        End Set
    End Property 

    Private _USUARIO_APROBACION As String
    <Column(Name:="Usuario aprobacion", Storage:="USUARIO_APROBACION", DbType:="VARCHAR2(16)", Id:=False), _
     DataObjectField(False, False, True, 16)> _
    Public Property USUARIO_APROBACION() As String
        Get
            Return _USUARIO_APROBACION
        End Get
        Set(ByVal Value As String)
            _USUARIO_APROBACION = Value
            OnPropertyChanged("USUARIO_APROBACION")
        End Set
    End Property 

    Private _USUARIO_APROBACIONOld As String
    Public Property USUARIO_APROBACIONOld() As String
        Get
            Return _USUARIO_APROBACIONOld
        End Get
        Set(ByVal Value As String)
            _USUARIO_APROBACIONOld = Value
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

    Private _ID_ESTADO_INFORME As Decimal
    <Column(Name:="Id estado informe", Storage:="ID_ESTADO_INFORME", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=2, Scale:=0)> _
    Public Property ID_ESTADO_INFORME() As Decimal
        Get
            Return _ID_ESTADO_INFORME
        End Get
        Set(ByVal Value As Decimal)
            _ID_ESTADO_INFORME = Value
            OnPropertyChanged("ID_ESTADO_INFORME")
        End Set
    End Property 

    Private _ID_ESTADO_INFORMEOld As Decimal
    Public Property ID_ESTADO_INFORMEOld() As Decimal
        Get
            Return _ID_ESTADO_INFORMEOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_ESTADO_INFORMEOld = Value
        End Set
    End Property 

    Private _fkID_ESTADO_INFORME As ESTADO_INFORME_AF
    Public Property fkID_ESTADO_INFORME() As ESTADO_INFORME_AF
        Get
            Return _fkID_ESTADO_INFORME
        End Get
        Set(ByVal Value As ESTADO_INFORME_AF)
            _fkID_ESTADO_INFORME = Value
        End Set
    End Property 

    Private _HORAS_DESARROLLADAS As Decimal
    <Column(Name:="Horas desarrolladas", Storage:="HORAS_DESARROLLADAS", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=0, Scale:=0)> _
    Public Property HORAS_DESARROLLADAS() As Decimal
        Get
            Return _HORAS_DESARROLLADAS
        End Get
        Set(ByVal Value As Decimal)
            _HORAS_DESARROLLADAS = Value
            OnPropertyChanged("HORAS_DESARROLLADAS")
        End Set
    End Property 

    Private _HORAS_DESARROLLADASOld As Decimal
    Public Property HORAS_DESARROLLADASOld() As Decimal
        Get
            Return _HORAS_DESARROLLADASOld
        End Get
        Set(ByVal Value As Decimal)
            _HORAS_DESARROLLADASOld = Value
        End Set
    End Property 

    Private _FECHA_INICIAL As DateTime
    <Column(Name:="Fecha inicial", Storage:="FECHA_INICIAL", DbType:="DATE", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property FECHA_INICIAL() As DateTime
        Get
            Return _FECHA_INICIAL
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_INICIAL = Value
            OnPropertyChanged("FECHA_INICIAL")
        End Set
    End Property 

    Private _FECHA_INICIALOld As DateTime
    Public Property FECHA_INICIALOld() As DateTime
        Get
            Return _FECHA_INICIALOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_INICIALOld = Value
        End Set
    End Property 

    Private _FECHA_FINAL As DateTime
    <Column(Name:="Fecha final", Storage:="FECHA_FINAL", DbType:="DATE", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property FECHA_FINAL() As DateTime
        Get
            Return _FECHA_FINAL
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_FINAL = Value
            OnPropertyChanged("FECHA_FINAL")
        End Set
    End Property 

    Private _FECHA_FINALOld As DateTime
    Public Property FECHA_FINALOld() As DateTime
        Get
            Return _FECHA_FINALOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_FINALOld = Value
        End Set
    End Property 

    Private _HORARIO As String
    <Column(Name:="Horario", Storage:="horario", DbType:="VARCHAR2(800) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 800)> _
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


    Private _COSTO_X_HORA As Decimal
    <Column(Name:="Costo por hora", Storage:="COSTO_X_HORA", DbType:="NUMBER", Id:=False), _
    DataObjectField(False, False, True), Precision(Precision:=10, Scale:=4)> _
   Public Property COSTO_X_HORA() As Decimal
        Get
            Return _COSTO_X_HORA
        End Get
        Set(ByVal value As Decimal)
            _COSTO_X_HORA = value
        End Set
    End Property

    Private _COSTO_X_HORAOld As Decimal
    Public Property COSTO_X_HORAOld() As Decimal
        Get
            Return _COSTO_X_HORAOld
        End Get
        Set(ByVal Value As Decimal)
            _COSTO_X_HORAOld = Value
        End Set
    End Property

    Private _MONTO_PAGO_INICIAL As Decimal
    <Column(Name:="Monto pago inicial", Storage:="MONTO_PAGO_INICIAL", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=12, Scale:=2)> _
    Public Property MONTO_PAGO_INICIAL() As Decimal
        Get
            Return _MONTO_PAGO_INICIAL
        End Get
        Set(ByVal Value As Decimal)
            _MONTO_PAGO_INICIAL = Value
            OnPropertyChanged("MONTO_PAGO_INICIAL")
        End Set
    End Property

    Private _MONTO_PAGO_INICIALOld As Decimal
    Public Property MONTO_PAGO_INICIALOld() As Decimal
        Get
            Return _MONTO_PAGO_INICIALOld
        End Get
        Set(ByVal Value As Decimal)
            _MONTO_PAGO_INICIALOld = Value
        End Set
    End Property


    Private _USUARIO_ASIGNADO As String
    <Column(Name:="Usuario asignado", Storage:="USUARIO_ASIGNADO", DbType:="VARCHAR2(256)", Id:=False), _
     DataObjectField(False, False, True, 256)> _
    Public Property USUARIO_ASIGNADO() As String
        Get
            Return _USUARIO_ASIGNADO
        End Get
        Set(ByVal Value As String)
            _USUARIO_ASIGNADO = Value
            OnPropertyChanged("USUARIO_ASIGNADO")
        End Set
    End Property

    Private _USUARIO_ASIGNADOOld As String
    Public Property USUARIO_ASIGNADOOld() As String
        Get
            Return _USUARIO_ASIGNADOOld
        End Get
        Set(ByVal Value As String)
            _USUARIO_ASIGNADOOld = Value
        End Set
    End Property

#End Region


#Region " Relaciones "
    Private _INFORME_FINAL_DET_INFORME_FINAL As listaINFORME_FINAL_DET
    <DataMember()> _
    Public Property INFORME_FINAL_DET_INFORME_FINAL() As listaINFORME_FINAL_DET
        Get
            Return _INFORME_FINAL_DET_INFORME_FINAL
        End Get
        Set(ByVal Value As listaINFORME_FINAL_DET)
            _INFORME_FINAL_DET_INFORME_FINAL = Value
        End Set
    End Property
#End Region
#End Region
End Class
