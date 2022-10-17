Imports System.Configuration.ConfigurationManager
Imports System.Reflection
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.configuracion
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de configuración que sirve para proveer datos generales a todo el aplicativo
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' En esta clase se emulan las variables Globales mediante el uso de propiedades
''' estáticas, asi como también de funcionalidad genérica para el aplicativo.
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
Public Class configuracion

    Private Shared _usuarioActualiza As String
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Propiedad que representa el Usuario que esta conectado a la aplicación
    ''' </summary>
    ''' <value>Rerotna el Usuario conectado al aplicativo.</value>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/02/2010	Created
    ''' 	[ecarias]	28/03/2011	Se agrego que si esta vacio asigne Utilerias.ObtenerUsuario()
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Shared Property usuarioActualiza() As String
        Get
            If _usuarioActualiza = "" Then
                _usuarioActualiza = Utilerias.ObtenerUsuario()
            End If
            Return _usuarioActualiza
        End Get
        Set(ByVal Value As String)
            _usuarioActualiza = Value
        End Set
    End Property

    Private Shared _tituloAplicacion As String = AppSettings("TituloAplicacion")
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Propiedad que retorna el Titulo del Aplicativo
    ''' </summary>
    ''' <value>Devuelve el Titulo del Aplicativo configurado en App.config</value>
    ''' <remarks>
    ''' 
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Shared ReadOnly Property tituloAplicacion() As String
        Get
            Return _tituloAplicacion
        End Get
    End Property

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Permite Copiar todos los valores de las propiedades de la Clase "origen" 
    ''' a la clase "destino"
    ''' </summary>
    ''' <param name="origen">Objeto que contiene valores a ser duplicados</param>
    ''' <param name="destino">Objeto donde serán copiados los valores de las 
    ''' propiedades del Objeto "origen"</param>
    ''' <remarks>
    ''' Es importante hacer notar que si la clase "origen" o "destino" trae el valor 
    ''' Nothing no reliza ninguna operación.
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Shared Sub MapearClase(ByVal origen As Object, ByRef destino As Object)

        If origen Is Nothing Or destino Is Nothing Then Return

        Dim tipoOrigen As Type = origen.GetType()
        Dim tipoDestino As Type = destino.GetType()

        If Not Equals(tipoOrigen, tipoDestino) Then Return

        For Each PropiedadOrigen As PropertyInfo In tipoOrigen.GetProperties()
            Dim PropiedadDestino As PropertyInfo = tipoDestino.GetProperty(PropiedadOrigen.Name)

            If Not PropiedadDestino Is Nothing Then
                PropiedadDestino.SetValue(destino, PropiedadOrigen.GetValue(origen, Nothing), Nothing)
            End If
        Next

    End Sub

End Class

Public Enum TipoConcurrencia As Integer
    Optimistica = 1
    Pesimistica = 2
End Enum

<Serializable()> Public Class Criteria
    Inherits entidadBase

    Private _ColumnName As String
    Public Property ColumnName() As String
        Get
            Return _ColumnName
        End Get
        Set(ByVal Value As String)
            _ColumnName = Value
        End Set
    End Property

    Private _Compare As String
    Public Property Compare() As String
        Get
            Return _Compare
        End Get
        Set(ByVal Value As String)
            _Compare = Value
        End Set
    End Property

    Private _DataValue As String
    Public Property DataValue() As String
        Get
            Return _DataValue
        End Get
        Set(ByVal Value As String)
            _DataValue = Value
        End Set
    End Property

    Private _QueryOperator As String
    Public Property QueryOperator() As String
        Get
            Return _QueryOperator
        End Get
        Set(ByVal Value As String)
            _QueryOperator = Value
        End Set
    End Property

    Private _TableAlias As String
    Public Property TableAlias() As String
        Get
            Return _TableAlias
        End Get
        Set(ByVal Value As String)
            _TableAlias = Value
        End Set
    End Property

    Public Sub New(ByVal asColumnName As String, ByVal asCompare As String, ByVal asDataValue As String, ByVal asQueryOperator As String)
        Me._ColumnName = asColumnName
        Me._Compare = asCompare
        Me._DataValue = asDataValue
        Me._QueryOperator = asQueryOperator
    End Sub

    Public Sub New(ByVal asColumnName As String, ByVal asTableAlias As String, ByVal asCompare As String, ByVal asDataValue As String, ByVal asQueryOperator As String)
        Me._ColumnName = asColumnName
        Me._Compare = asCompare
        Me._DataValue = asDataValue
        Me._QueryOperator = asQueryOperator
        Me._TableAlias = asTableAlias
    End Sub

End Class

''' -----------------------------------------------------------------------------
''' <summary>
''' Enumeración para Tipos de Ordenamiento
''' </summary>
''' <remarks>
''' Ascending : Ordenamiento Ascendente
''' Descending : Ordenamiento Descendente
''' None : No se aplica Ordenamiento
''' </remarks>
''' <history>
''' 	[ecarias]	20/09/2007	Created
''' </history>
''' -----------------------------------------------------------------------------
Public Enum SortOrder As Integer
    Ascending = 1
    Descending = 2
    None = 0
End Enum

''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de uso exclusivo de Busquedas y Ordenamiento
''' </summary>
''' <remarks>
''' </remarks>
''' <history>
''' 	[ecarias]	20/09/2007	Created
''' </history>
''' -----------------------------------------------------------------------------
Public Class Comparador
    Implements IComparer

    Private _propiedadOrdenamiento As String
    Private _tipoOrdenamiento As SortOrder

    Private _propertyToSearch As String

    Public Sub New(ByVal propiedadOrdenamiento As String)
        Me.new(propiedadOrdenamiento, SortOrder.Ascending)
    End Sub

    Public Sub New(ByVal propiedadOrdenamiento As String, ByVal tipoOrdenamiento As SortOrder)
        MyBase.new()
        _propiedadOrdenamiento = propiedadOrdenamiento
        _tipoOrdenamiento = tipoOrdenamiento
    End Sub

    Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer Implements System.Collections.IComparer.Compare
        Dim prop As Reflection.PropertyInfo = x.GetType.GetProperty(Me.PropiedadOrdenamiento)
        If Me.TipoOrdenamiento = SortOrder.None OrElse prop.GetValue(x, Nothing).Equals(prop.GetValue(y, Nothing)) Then
            Return 0
        Else
            If prop.GetValue(x, Nothing) > prop.GetValue(y, Nothing) Then
                If Me.TipoOrdenamiento = SortOrder.Ascending Then
                    Return 1
                Else
                    Return -1
                End If
            Else
                If Me.TipoOrdenamiento = SortOrder.Ascending Then
                    Return -1
                Else
                    Return 1
                End If
            End If
        End If
    End Function

    Public Property TipoOrdenamiento() As SortOrder
        Get
            Return _tipoOrdenamiento
        End Get
        Set(ByVal Value As SortOrder)
            _tipoOrdenamiento = Value
        End Set
    End Property

    Public Property PropiedadOrdenamiento() As String
        Get
            Return _propiedadOrdenamiento
        End Get
        Set(ByVal Value As String)
            _propiedadOrdenamiento = Value
        End Set
    End Property
End Class

Namespace Enumeradores
    Public Enum EstadoSolicitud As Integer
        Ingresada = 1
        EnEsperaDeAprobacion = 2
        Aprobada = 3
        Finalizada = 4
        Rechazada = 5
        EnEsperaDeCupo = 6
        Anulada = 7
        CambioDeCurso = 8
        CambioDeCursoPorSistema = 9
        Desercion = 10
        [Todos] = -1
    End Enum

    Public Class UnidadOrganizativa
        Public Const GerenciaFormacionInicial As String = "0400"
        Public Const GerenciaFormacionContinua As String = "0300"
        Public Const CentroFormacionSanBartolo As String = "1100"
        Public Const UnidadFormacionDistancia As String = "249"
        Public Const GerenciaTecnica As String = "0200"
    End Class

    Public Enum EstadoParticipanteExonerado As Integer
        PendienteEvaluacion = 0
        Aprobado = 1
        Rechazado = 2
    End Enum

    Public Enum TipoPagoPrograma As Integer
        Por_Horas_Desarrolladas = 1
        Por_Participacion_CostoParticipanteFijo = 2
        Por_Participacion_CostoParticipanteVariable = 3
        Por_Participacion_VisitasSeguimiento = 4
    End Enum

    Public Enum TipoPenalizacion As Integer
        FinalizacionExtemporaneaCurso = 1
        EntregaExtemporaneaInforme = 2
        NoDefinida = 3
    End Enum

    Public Enum FormaPagoPrograma As Integer
        PorHoras = 1
        PorParticipacionCostoFijo = 2
        PorParticipacionCostoVariable = 2
    End Enum

    Public Enum TipoSolicitud As Integer
        HabilTecnicoPermanente = 1
        PATI_USAID = 2
        PATI_BM = 3
        PROYECTO_ESPECIAL = 4
        PATI_2 = 5
        EMPRESA_CENTRO = 6
    End Enum

    Public Enum TipoSeleccionEC As Integer
        Titular = 1
        Suplente = 2
        NoSeleccionado = 3
        Desertado = 4
    End Enum

    Public Enum FuenteFinanciamientoPATI As Integer
        PATI_BM = 1
        PATI_USAID = 2
        PATI_GOES = 3
    End Enum

    Public Enum TipoAdjudicacionBolpros As Integer
        AdjudicacionPorCurso = 1
        AdjudicacionPorCurso_CostoParticipante_Online = 2
        AdjudicacionPorParticipaciones_CostoParticipante = 3
    End Enum

    Public Enum ProgramasFormacion As Integer
        HABIL_TECNICO_PERMANENTE = 1
        PATI_USAID = 2
        PATI_BM = 3
        PROYECTO_ESPECIAL = 4
        PATI_2 = 5
        EMPRESA_CENTRO = 6
    End Enum

    Public Enum GerenciaUnidad As Integer
        CENTRO_FORMACION_SAN_BARTOLO = 18
        GERENCIA_FORMACION_INICIAL = 9
        GERENCIA_FORMACION_CONTINUA = 8
        UNIDAD_FORMACION_DISTANCIA = 22
        GERENCIA_TECNICA = 7
    End Enum

    Public Enum TipoContratacion As Integer
        BOLPROS = 1
        LICITACION = 2
        TERMINO_DE_REFERENCIA = 3
    End Enum

    Public Class EstadoAccionFormativa
        Public Const Ingresada As String = "01"
        Public Const EnMatricula As String = "02"
        Public Const Iniciada As String = "03"
        Public Const Finalizada As String = "04"
        Public Const EnSolicitudDeReprogramacion As String = "09"
        Public Const ReprogramacionAprobada As String = "14"
        Public Const ReprogramacionRechazada As String = "15"
    End Class

    Public Class AutorizacionExcepcion
        Public Const InscripcionExtemporaneaParticipantes As String = "02"
        Public Const FinalizacionExtemporaneaCurso As String = "04"
        Public Const ProgramacionRetroactiva As String = "09"
        Public Const HorarioSimultaneoInstructor As String = "90"
        Public Const HorarioSimultaneoParticipante As String = "91"
        Public Const AplicarMontoLiquidacionContrato As String = "92"
        Public Const InicioCursoPosteriorUltimaFechaInicioOferta As String = "93"
        Public Const EliminarAccionFormativa As String = "94"
    End Class


    Public Class EstadoInformeFinal
        Public Const Emitido As Decimal = 1
        Public Const InformeRecibido As Decimal = 2
        Public Const InformeEnRevision As Decimal = 3
        Public Const InformeValidadoTecnico As Decimal = 4
        Public Const InformeValidadoCoordinador As Decimal = 5
        Public Const InformeDevueltoPorUACI As Decimal = 6
        Public Const InformeDevueltoConObservaciones As Decimal = 7
        Public Const InformeConObservacionesSolventadas As Decimal = 8
        Public Const InformeEnRevisionUACI As Decimal = 9
        Public Const FacturaSolicitadaProveedor As Decimal = 10
        Public Const EnTramiteDePago As Decimal = 11
        Public Const Pagado As Decimal = 12
        Public Const NoPagado As Decimal = 13
        Public Const InformeEnProcesoBolpros As Decimal = 14
        Public Const SeguimientoGFI As Decimal = 15
        Public Const OrdenEntregaRecibida As Decimal = 16
        Public Const FacturaRecibida As Decimal = 17
        Public Const OrdenEntregaObservada As Decimal = 18
        Public Const OrdenEntregaValidada As Decimal = 19
        Public Const FacturaValidada As Decimal = 20
        Public Const FacturaObservada As Decimal = 21
        Public Const InformeDevueltoaCA As Decimal = 22
        Public Const OrdenEntregaEnRevision As Decimal = 23
        Public Const FacturaEnRevision As Decimal = 24
        Public Const InformeRecepcionObservaciones As Decimal = 25
        Public Const RecalculoMontoPagar As Decimal = 26
    End Class

    Public Class FasesInformeFinal
        Public Const EMISION As Decimal = 1
        Public Const RECEPCION As Decimal = 2
        Public Const VALIDACION As Decimal = 3
        Public Const OBSERVACIONES As Decimal = 4
        Public Const AUTORIZACIÓN As Decimal = 5
        Public Const PAGO As Decimal = 6
        Public Const SINPAGO As Decimal = 7
    End Class

    Public Class EstadoFactura
        Public Const Emitida As String = "E"
        Public Const Aprobada As String = "P"
        Public Const Anulada As String = "A"
    End Class

    Public Class EstadoParticipanteEnCurso
        Public Const Inscrito As String = "I"
        Public Const Rechazado As String = "R"
        Public Const EnEsperaDeCupo As String = "E"
        Public Const InscripcionAnulada As String = "A"
        Public Const SolicitudAnulada As String = "S"
        Public Const Evaluado As String = "V"
        Public Const CambioDeCurso As String = "C"
        Public Const CambioDeCursoPorSistema As String = "G"
        Public Const Desertado As String = "D"
    End Class

    Public Enum EstadoReprogramaciones As Integer
        Solicitada = 1
        Aprobada = 2
        Rechazada = 3
    End Enum

    Public Class TipoPlantilla
        Public Const ONLINE As String = "ONLINE"
        Public Const PRESENCIAL As String = "PRESENCIAL"
        Public Const CURSO As String = "CURSO"
    End Class

    Public Enum CompraBasePago As Integer
        PagoCursoIndependienteCapacitados = 0
        PagoBaseDefinida = 1
        PagoBaseInscritos = 2
    End Enum

    Public Enum ModalidadFormacion As Integer
        CentroFijo = 1
        AccionMovil = 2
        CursoConHerramientasTecnologicas = 3
    End Enum

    Public Class RolDeUsuario
        Public Const Administrador As String = "Administrador"
        Public Const Auditor As String = "Auditor"
        Public Const AuditorUMEFP As String = "AuditorUMEFP"
        Public Const Proveedor As String = "Proveedor"
        Public Const CentroCapacitador As String = "CentroCapacitador"
        Public Const Participante As String = "Participante"
        Public Const TecnicoCentroHTP As String = "TecnicoCentroHTP"
        Public Const JefeHTP As String = "JefeHTP"
        Public Const AsistenteGFI As String = "AsistenteGFI"
        Public Const GerenteGFI As String = "GerenteGFI"
        Public Const GerenteUFI As String = "GerenteUFI"
        Public Const TecnicoGFIPATI As String = "TecnicoGFIPATI"
        Public Const TecnicoPROYESPECIAL As String = "TecnicoPROYESPECIAL"
        Public Const ProveedorPATI As String = "ProveedorPATI"
        Public Const DigitadorFichasPATI As String = "DigitadorFichasPATI"
        Public Const ColaboradorUACIHTP As String = "ColaboradorUACIHTP"
        Public Const ColaboradorUACIPATI As String = "ColaboradorUACIPATI"
        Public Const ColaboradorUACIPROYESPECIAL As String = "ColaboradorUACIPROYESPECIAL"
        Public Const ProveedorFacturacionPATI As String = "ProveedorFacturacionPATI"
        Public Const ProveedorFacturacionHTP As String = "ProveedorFacturacionHTP"
        Public Const CoordinadorPATI As String = "CoordinadorPATI"
        Public Const AuditorExterno As String = "AuditorExterno"
        Public Const ProveedorPROYESPECIAL As String = "ProveedorPROYESPECIAL"
        Public Const ProveedorFacturacionPROYESPECIAL As String = "ProveedorFacturacionPROYESPECIAL"
        Public Const AutorizarParticipantesSinDoctos As String = "AutorizarParticipantesSinDoctos"
        Public Const Bolproes As String = "Bolproes"

        Public Const SoporteGFI As String = "SoporteGFI"
        Public Const CoordinadorGFI As String = "CoordinadorGFI"
        Public Const TecnicoGFI As String = "TecnicoGFI"

        Public Const CAGestion As String = "CAGestion"
        Public Const CARecepcion As String = "CARecepcion"
        Public Const CARevision As String = "CARevision"

        Public Const CoordinadorECentro As String = "CoordinadorECentro"
        Public Const AplicarRecalculoMontoPagarInforme As String = "AplicarRecalculoMontoPagarInforme"
    End Class

End Namespace
