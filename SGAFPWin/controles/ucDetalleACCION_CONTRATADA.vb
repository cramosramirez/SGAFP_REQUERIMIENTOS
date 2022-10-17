Imports SGAFP.EL
Imports System.Web.Security.Membership
Imports SQLMembershipProvider.BL
Imports SGAFP.EL.Enumeradores

''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucDetalleACCION_CONTRATADA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	12/04/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
Public Class ucDetalleACCION_CONTRATADA
    Private _AccionContratada As New ACCION_CONTRATADA
    Private _EsConsulta As Boolean = False
    <DefaultValue(False)> _
    Public Property EsConsulta() As Boolean
        Get
            Return Me._EsConsulta
        End Get
        Set(ByVal value As Boolean)
            Me._EsConsulta = value
            Me.HabilitarEdicion(Not value)
        End Set
    End Property

    Public Property ACCION_CONTRATADA() As ACCION_CONTRATADA
        Get
            Return _AccionContratada
        End Get
        Set(ByVal value As ACCION_CONTRATADA)
            _AccionContratada = value
            Me.CargarDatos()
        End Set
    End Property

    Public Sub InicializarConParametros(ByVal ID_PROVEEDOR_AF As Decimal, ByVal ID_PROGRAMA_FORMACION As Decimal, ByVal NUM_CONTRATO As String)
        _AccionContratada = New ACCION_CONTRATADA
        Dim lListaContratos As listaCONTRATO_BOLPROS
        Dim lContrato As New CONTRATO_BOLPROS
        Dim bContrato As New cCONTRATO_BOLPROS
        Dim lCriterios As New List(Of Criteria)

        Inicializar()
        ID_PROVEEDOR_AFCbxPROVEEDOR_AF.SelectedValue = ID_PROVEEDOR_AF
        ID_PROGRAMA_FORMACIONCbxPROGRAMA_FORMACION.SelectedValue = ID_PROGRAMA_FORMACION

        lCriterios.Add(New Criteria("ID_PROVEEDOR_AF", "=", ID_PROVEEDOR_AF.ToString, "AND"))
        lCriterios.Add(New Criteria("ID_PROGRAMA_FORMACION", "=", ID_PROGRAMA_FORMACION.ToString, "AND"))
        lCriterios.Add(New Criteria("NUM_CONTRATO", "=", NUM_CONTRATO, ""))
        lListaContratos = bContrato.ObtenerListaPorBusqueda(lContrato, lCriterios.ToArray, "ID_CONTRATO", "")
        If lListaContratos IsNot Nothing AndAlso lListaContratos.Count > 0 Then
            ID_CONTRATOCbxCONTRATO_BOLPROS.SelectedValue = lListaContratos(0).ID_CONTRATO
            If lListaContratos(0).ID_TIPO_ADJ = Enumeradores.TipoAdjudicacionBolpros.AdjudicacionPorParticipaciones_CostoParticipante Then
                Me.CANT_CURSOSSpinEdit.Value = 1
                Me.CANT_CURSOSSpinEdit.Enabled = False
                Me.NUM_ITEMSpinEdit.Text = 1
                Me.NUM_ITEMSpinEdit.Enabled = False
                Me.MONTOSpinEdit.Enabled = False
                Me.COSTO_PARTICIPANTESpinEdit.Value = lListaContratos(0).COSTO_X_PARTICIPANTE
                Me.COSTO_PARTICIPANTESpinEdit.Enabled = False
                Me.txtCODIGO_CATEG.Enabled = True
                Me.txtNOMBRE_CATEG.Enabled = True
            ElseIf lListaContratos(0).ID_TIPO_ADJ = Enumeradores.TipoAdjudicacionBolpros.AdjudicacionPorCurso_CostoParticipante_Online Then
                Me.CANT_CURSOSSpinEdit.Value = 1
                Me.CANT_CURSOSSpinEdit.Enabled = False
                Me.NUM_ITEMSpinEdit.Text = 1
                Me.NUM_ITEMSpinEdit.Enabled = False
                Me.MONTOSpinEdit.Value = 0
                Me.MONTOSpinEdit.Enabled = False
                Me.COSTO_PARTICIPANTESpinEdit.Enabled = True
                Me.txtCODIGO_CATEG.Enabled = True
                Me.txtNOMBRE_CATEG.Enabled = True
            End If
        End If
    End Sub

    Public Sub InicializarConParametros(ByVal ID_CONTRATO As Decimal)
        Dim lContrato As CONTRATO_BOLPROS = (New cCONTRATO_BOLPROS).ObtenerCONTRATO_BOLPROS(ID_CONTRATO)

        Inicializar()

        If lContrato IsNot Nothing Then
            ID_PROVEEDOR_AFCbxPROVEEDOR_AF.SelectedValue = lContrato.ID_PROVEEDOR_AF
            ID_PROGRAMA_FORMACIONCbxPROGRAMA_FORMACION.SelectedValue = lContrato.ID_PROGRAMA_FORMACION
            ID_CONTRATOCbxCONTRATO_BOLPROS.SelectedValue = lContrato.ID_CONTRATO
            If lContrato.ID_TIPO_ADJ = Enumeradores.TipoAdjudicacionBolpros.AdjudicacionPorParticipaciones_CostoParticipante Then
                Me.CANT_CURSOSSpinEdit.Value = 1
                Me.CANT_CURSOSSpinEdit.Enabled = False
                Me.NUM_ITEMSpinEdit.Text = 1
                Me.NUM_ITEMSpinEdit.Enabled = False
                Me.MONTOSpinEdit.Enabled = False
                Me.COSTO_PARTICIPANTESpinEdit.Value = lContrato.COSTO_X_PARTICIPANTE
                Me.COSTO_PARTICIPANTESpinEdit.Enabled = False
            ElseIf lContrato.ID_TIPO_ADJ = Enumeradores.TipoAdjudicacionBolpros.AdjudicacionPorCurso_CostoParticipante_Online Then
                Me.CANT_CURSOSSpinEdit.Value = 1
                Me.CANT_CURSOSSpinEdit.Enabled = False
                Me.NUM_ITEMSpinEdit.Text = 1
                Me.NUM_ITEMSpinEdit.Enabled = False
                Me.MONTOSpinEdit.Value = 0
                Me.MONTOSpinEdit.Enabled = False
                Me.COSTO_PARTICIPANTESpinEdit.Enabled = True
            End If
        End If
    End Sub


    Public ReadOnly Property Current() As ACCION_CONTRATADA
        Get
            Return CType(Me.ListaACCION_CONTRATADABindingSource.Current, ACCION_CONTRATADA)
        End Get
    End Property

    Private Sub CargarProgramasCursos()
        Select Case Utilerias.ObtenerFuentePorProgramaFormacion(ID_PROGRAMA_FORMACIONCbxPROGRAMA_FORMACION.SelectedValue)
            Case Enumeradores.FuenteFinanciamientoPATI.PATI_BM
                Me.ListaPROGRAMASBindingSource.DataSource = (New SIFP.BL.cProgramas).ObtenerListaActivosPATI_BM("nombre_programa")
            Case Enumeradores.FuenteFinanciamientoPATI.PATI_USAID, Enumeradores.FuenteFinanciamientoPATI.PATI_GOES
                Me.ListaPROGRAMASBindingSource.DataSource = (New SIFP.BL.cProgramas).ObtenerListaActivosPATI_AID("nombre_programa")
            Case Else
                Me.ListaPROGRAMASBindingSource.DataSource = (New SIFP.BL.cProgramas).ObtenerListaActivos("nombre_programa")
        End Select
        CODIGO_PROGRAMACbxPROGRAMAS.EditValue = Nothing
    End Sub

    Private Sub CargarDatos()
        Inicializar()
        If _AccionContratada IsNot Nothing AndAlso _AccionContratada.ID_CONTRATO > 0 Then
            Dim lEntidadContrato As CONTRATO_BOLPROS = (New cCONTRATO_BOLPROS).ObtenerCONTRATO_BOLPROS(_AccionContratada.ID_CONTRATO)
            ID_ACCION_CONTRATADATextEdit.Text = _AccionContratada.ID_ACCION_CONTRATADA
            ID_PROVEEDOR_AFCbxPROVEEDOR_AF.SelectedValue = lEntidadContrato.ID_PROVEEDOR_AF
            ID_PROGRAMA_FORMACIONCbxPROGRAMA_FORMACION.SelectedValue = lEntidadContrato.ID_PROGRAMA_FORMACION
            ID_CONTRATOCbxCONTRATO_BOLPROS.RecuperarPorCriterios(lEntidadContrato.ID_PROVEEDOR_AF, lEntidadContrato.ID_PROGRAMA_FORMACION, "", False, False, "NUM_CONTRATO", "ASC", True)
            ID_CONTRATOCbxCONTRATO_BOLPROS.SelectedValue = lEntidadContrato.ID_CONTRATO
            If lEntidadContrato.ID_FUENTE = -1 Then
                Me.NO_CONVOCATORIASpinEdit.Value = 0
            Else
                Me.NO_CONVOCATORIASpinEdit.Value = _AccionContratada.NO_CONVOCATORIA
            End If
            NUM_ITEMSpinEdit.Value = _AccionContratada.NUM_ITEM
            CODIGO_DEPARTAMENTOcbxDEPARTAMENTO.SelectedValue = _AccionContratada.CODIGO_DEPARTAMENTO
            CODIGO_MUNICIPIOcbxMUNICIPIO.RecuperarPorDEPARTAMENTO(_AccionContratada.CODIGO_DEPARTAMENTO)
            CODIGO_MUNICIPIOcbxMUNICIPIO.SelectedValue = _AccionContratada.CODIGO_MUNICIPIO
            CargarProgramasCursos()
            CODIGO_PROGRAMACbxPROGRAMAS.EditValue = _AccionContratada.CODIGO_PROGRAMA
            txtNOMBRE_ACCION_FORMATIVA.Text = _AccionContratada.NOMBRE_ACCION_FORMATIVA
            DURACIONSpinEdit.Value = _AccionContratada.DURACION
            CANT_CURSOSSpinEdit.Value = _AccionContratada.CANT_CURSOS
            MONTOSpinEdit.Value = _AccionContratada.MONTO
            COSTO_PARTICIPANTESpinEdit.Value = _AccionContratada.COSTO_PARTICIPANTE
            USUARIO_CREACIONTextEdit.Text = _AccionContratada.USUARIO_CREACION
            FECHA_CREACIONDateEdit.DateTime = _AccionContratada.FECHA_CREACION
            USERIDTextEdit.Text = _AccionContratada.USERID
            LASTUPDATEDateEdit.DateTime = _AccionContratada.LASTUPDATE
            Me.speCostoxHora.Value = If(_AccionContratada.COSTO_HORA = -1, Nothing, _AccionContratada.COSTO_HORA)
            Me.speCostoxVisita.Value = If(_AccionContratada.COSTO_VISITA = -1, Nothing, _AccionContratada.COSTO_VISITA)
            Me.txtCODIGO_CATEG.Text = _AccionContratada.CODIGO_CATEG
            Me.txtNOMBRE_CATEG.Text = _AccionContratada.NOMBRE_CATEG
        Else
            ID_ACCION_CONTRATADATextEdit.Text = "0"
        End If
    End Sub

    Private Sub Inicializar()
        Dim c As cmembershipProvider
        c = CType(Provider, cmembershipProvider)

        Me.ID_ACCION_CONTRATADATextEdit.Enabled = False
        ID_PROVEEDOR_AFCbxPROVEEDOR_AF.Recuperar(False, False)
        ID_PROVEEDOR_AFCbxPROVEEDOR_AF.SelectedIndex = -1
        ID_PROGRAMA_FORMACIONCbxPROGRAMA_FORMACION.RecuperarPorRoles(c.ObtenerRoles(Utilerias.ObtenerUsuario))
        ID_PROGRAMA_FORMACIONCbxPROGRAMA_FORMACION.SelectedIndex = -1
        ID_CONTRATOCbxCONTRATO_BOLPROS.RecuperarPorPROVEEDOR_AF(-1)
        NUM_ITEMSpinEdit.Value = 0
        NO_CONVOCATORIASpinEdit.Value = 0
        NO_CONVOCATORIASpinEdit.Enabled = False
        CODIGO_DEPARTAMENTOcbxDEPARTAMENTO.Recuperar(False, False)
        CODIGO_DEPARTAMENTOcbxDEPARTAMENTO.SelectedIndex = -1
        CODIGO_MUNICIPIOcbxMUNICIPIO.RecuperarPorDEPARTAMENTO("")
        CargarProgramasCursos()
        DURACIONSpinEdit.Value = 0
        CANT_CURSOSSpinEdit.Value = 0
        MONTOSpinEdit.Value = 0
        COSTO_PARTICIPANTESpinEdit.Value = 0
        USUARIO_CREACIONTextEdit.Text = Utilerias.ObtenerUsuario
        FECHA_CREACIONDateEdit.DateTime = Now
        USERIDTextEdit.Text = Utilerias.ObtenerUsuario
        LASTUPDATEDateEdit.DateTime = Now
        Me.CANT_CURSOSSpinEdit.Enabled = True
        Me.NUM_ITEMSpinEdit.Enabled = True
        Me.MONTOSpinEdit.Enabled = True
        Me.COSTO_PARTICIPANTESpinEdit.Enabled = False
        Me.txtNOMBRE_ACCION_FORMATIVA.Text = ""
        If Utilerias.ObtenerFuentePorProgramaFormacion(ID_PROGRAMA_FORMACIONCbxPROGRAMA_FORMACION.SelectedValue) > -1 Then
            Me.NO_CONVOCATORIASpinEdit.Enabled = True
        End If

        Me.speCostoxHora.Value = Nothing
        Me.speCostoxVisita.Value = Nothing
        Me.txtCODIGO_CATEG.Text = ""
        Me.txtNOMBRE_CATEG.Text = ""

        If ID_PROGRAMA_FORMACIONCbxPROGRAMA_FORMACION.SelectedValue IsNot Nothing AndAlso _
            ID_PROGRAMA_FORMACIONCbxPROGRAMA_FORMACION.SelectedValue = ProgramasFormacion.EMPRESA_CENTRO Then
            Me.COSTO_PARTICIPANTESpinEdit.Enabled = True
            Me.speCostoxHora.Enabled = True
            Me.speCostoxVisita.Enabled = True
        Else
            Me.speCostoxHora.Value = Nothing
            Me.speCostoxVisita.Value = Nothing
            Me.COSTO_PARTICIPANTESpinEdit.Value = Nothing

            Me.COSTO_PARTICIPANTESpinEdit.Enabled = False
            Me.speCostoxHora.Enabled = False
            Me.speCostoxVisita.Enabled = False
        End If
    End Sub

    Public Overrides Property DataSource() As System.Windows.Forms.BindingSource
        Get
            Return Me.ListaACCION_CONTRATADABindingSource
        End Get
        Set(ByVal value As System.Windows.Forms.BindingSource)
            Me.ListaACCION_CONTRATADABindingSource = value
        End Set
    End Property

    Private Sub ListaACCION_CONTRATADABindingSource_CurrentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaACCION_CONTRATADABindingSource.CurrentChanged
        Me.ID_CONTRATOCbxCONTRATO_BOLPROS.Recuperar()
        Me.ID_CONTRATOCbxCONTRATO_BOLPROS.SelectedValue = Me.Current.ID_CONTRATO
        Me.CODIGO_DEPARTAMENTOcbxDEPARTAMENTO.Recuperar()
        Me.CODIGO_DEPARTAMENTOcbxDEPARTAMENTO.SelectedValue = Me.Current.CODIGO_DEPARTAMENTO
        Me.CODIGO_MUNICIPIOcbxMUNICIPIO.Recuperar(Me.CODIGO_DEPARTAMENTOcbxDEPARTAMENTO.SelectedValue)
        Me.CODIGO_MUNICIPIOcbxMUNICIPIO.SelectedValue = Me.Current.CODIGO_MUNICIPIO
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que sobreescribe y realiza la acción de Guardar en la Base de Datos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	12/04/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Actualizar() As Integer
        Dim mControl As New cACCION_CONTRATADA
        Dim totalAcciones As Decimal = 0
        Dim lContrato As CONTRATO_BOLPROS

        If Not (_AccionContratada IsNot Nothing AndAlso _AccionContratada.ID_ACCION_CONTRATADA > 0) Then
            If ID_PROVEEDOR_AFCbxPROVEEDOR_AF.SelectedValue Is Nothing OrElse Me.ID_PROVEEDOR_AFCbxPROVEEDOR_AF.SelectedValue = -1 Then
                Me.AsignarMensaje("Seleccione el proveedor", True)
                Return -1
            End If
            If ID_PROGRAMA_FORMACIONCbxPROGRAMA_FORMACION.SelectedValue Is Nothing OrElse Me.ID_PROGRAMA_FORMACIONCbxPROGRAMA_FORMACION.SelectedValue = -1 Then
                Me.AsignarMensaje("Seleccione el programa de formación", True)
                Return -1
            End If
            If Utilerias.ObtenerFuentePorProgramaFormacion(ID_PROGRAMA_FORMACIONCbxPROGRAMA_FORMACION.SelectedValue) > -1 AndAlso Me.NO_CONVOCATORIASpinEdit.Value <= 0 Then
                Me.AsignarMensaje("Ingrese la Convocatoria", True)
                Return -1
            End If
            If ID_CONTRATOCbxCONTRATO_BOLPROS.SelectedValue Is Nothing OrElse ID_CONTRATOCbxCONTRATO_BOLPROS.SelectedValue = -1 Then
                Me.AsignarMensaje("Seleccione el contrato", True)
                Return -1
            End If
            If NUM_ITEMSpinEdit.Value <= 0 Then
                Me.AsignarMensaje("Ingrese el número de item", True)
                Return -1
            End If
            If DURACIONSpinEdit.Value <= 0 Then
                Me.AsignarMensaje("La Duración debe ser mayor que cero", True)
                DURACIONSpinEdit.Focus()
                Return -1
            End If
            If MONTOSpinEdit.Value <> 0 AndAlso COSTO_PARTICIPANTESpinEdit.Value <> 0 Then
                Me.AsignarMensaje("No puede ingresar Monto total por Cursos y Costo por Participante al mismo tiempo", True)
                MONTOSpinEdit.Focus()
                Return -1
            End If
            If Not Utilerias.EsProgramaPATI(Convert.ToInt32(ID_PROGRAMA_FORMACIONCbxPROGRAMA_FORMACION.SelectedValue)) AndAlso CODIGO_DEPARTAMENTOcbxDEPARTAMENTO.SelectedValue Is Nothing OrElse CODIGO_DEPARTAMENTOcbxDEPARTAMENTO.SelectedValue = "" Then
                Me.AsignarMensaje("Seleccione el departamento", True)
                Return -1
            End If
            If Not Utilerias.EsProgramaPATI(Convert.ToInt32(ID_PROGRAMA_FORMACIONCbxPROGRAMA_FORMACION.SelectedValue)) AndAlso CODIGO_MUNICIPIOcbxMUNICIPIO.SelectedValue Is Nothing OrElse CODIGO_MUNICIPIOcbxMUNICIPIO.SelectedValue = "" Then
                Me.AsignarMensaje("Seleccione el municipio", True)
                Return -1
            End If
            If CODIGO_PROGRAMACbxPROGRAMAS.EditValue Is Nothing OrElse CODIGO_PROGRAMACbxPROGRAMAS.EditValue.ToString.Trim = "" Then
                Me.AsignarMensaje("Seleccione el curso de capacitación", True)
                Return -1
            End If
            If Me.txtNOMBRE_ACCION_FORMATIVA.Visible AndAlso Me.txtNOMBRE_ACCION_FORMATIVA.Text.Trim = "" Then
                Me.AsignarMensaje("Ingrese el nombre del curso", True)
                Return -1
            End If
            If DURACIONSpinEdit.Value <= 0 Then
                Me.AsignarMensaje("Ingrese la duración del curso", True)
                Return -1
            End If
            If Me.ID_PROGRAMA_FORMACIONCbxPROGRAMA_FORMACION.SelectedValue = ProgramasFormacion.EMPRESA_CENTRO AndAlso _
               Me.speCostoxHora.Value = 0 Then
                Me.AsignarMensaje("Ingrese el costo hora", True)
                Return -1
            End If
            If Me.ID_PROGRAMA_FORMACIONCbxPROGRAMA_FORMACION.SelectedValue = ProgramasFormacion.EMPRESA_CENTRO AndAlso _
                Me.speCostoxVisita.Value = 0 Then
                Me.AsignarMensaje("Ingrese el costo por visita", True)
                Return -1
            End If
            If Me.txtCODIGO_CATEG.Text = "" Then
                Me.AsignarMensaje("Ingrese el código de categoría formativa", True)
                Return -1
            End If
            If Me.txtNOMBRE_CATEG.Text = "" Then
                Me.AsignarMensaje("Ingrese el nombre de categoría formativa", True)
                Return -1
            End If

        End If

        lContrato = (New cCONTRATO_BOLPROS).ObtenerCONTRATO_BOLPROS(ID_CONTRATOCbxCONTRATO_BOLPROS.SelectedValue)
        If lContrato IsNot Nothing Then
            If lContrato.ID_TIPO_ADJ <> TipoAdjudicacionBolpros.AdjudicacionPorParticipaciones_CostoParticipante AndAlso CANT_CURSOSSpinEdit.Value <= 0 Then
                Me.AsignarMensaje("La Cantidad de Cursos debe ser mayor que cero", True)
                CANT_CURSOSSpinEdit.Focus()
                Return -1
            End If
            If (lContrato.ID_TIPO_ADJ = TipoAdjudicacionBolpros.AdjudicacionPorCurso_CostoParticipante_Online OrElse _
                lContrato.ID_TIPO_ADJ = TipoAdjudicacionBolpros.AdjudicacionPorParticipaciones_CostoParticipante) AndAlso COSTO_PARTICIPANTESpinEdit.Value <= 0 Then
                MONTOSpinEdit.Value = 0
                Me.AsignarMensaje("Ingrese Costo por Participante", True)
                COSTO_PARTICIPANTESpinEdit.Focus()
                Return -1
            ElseIf lContrato.ID_TIPO_ADJ = TipoAdjudicacionBolpros.AdjudicacionPorCurso AndAlso MONTOSpinEdit.Value <= 0 Then
                COSTO_PARTICIPANTESpinEdit.Value = 0
                Me.AsignarMensaje("Ingrese el Monto total por Cursos", True)
                MONTOSpinEdit.Focus()
                Return -1
            End If
            If lContrato.ID_TIPO_ADJ <> TipoAdjudicacionBolpros.AdjudicacionPorCurso Then
                If _AccionContratada IsNot Nothing AndAlso _AccionContratada.ID_ACCION_CONTRATADA > 0 Then

                    'Validar si el nombre de la accion ha cambiado, si es así y existen cursos entonces no permitir el cambio
                    Dim listaGrupos As listaGRUPO_ACCION_CONTRATADA = (New cGRUPO_ACCION_CONTRATADA).ObtenerListaPorACCION_CONTRATADA(_AccionContratada.ID_ACCION_CONTRATADA)
                    If listaGrupos IsNot Nothing AndAlso listaGrupos.Count > 0 AndAlso _AccionContratada.NOMBRE_ACCION_FORMATIVA <> txtNOMBRE_ACCION_FORMATIVA.Text.Trim.ToUpper Then
                        Me.AsignarMensaje("No puede cambiar el Nombre de la Accion formativa debido a que se han creado cursos de capacitación", True)
                        Return -1
                    End If
                End If
            End If
        End If

        _AccionContratada.ID_CONTRATO = ID_CONTRATOCbxCONTRATO_BOLPROS.SelectedValue
        _AccionContratada.CODIGO_DEPARTAMENTO = CODIGO_DEPARTAMENTOcbxDEPARTAMENTO.SelectedValue
        _AccionContratada.CODIGO_MUNICIPIO = CODIGO_MUNICIPIOcbxMUNICIPIO.SelectedValue
        _AccionContratada.CODIGO_PROGRAMA = CODIGO_PROGRAMACbxPROGRAMAS.EditValue.ToString.TrimEnd
        If Me.NO_CONVOCATORIASpinEdit.Value = 0 Then
            _AccionContratada.NO_CONVOCATORIA = -1
        Else
            _AccionContratada.NO_CONVOCATORIA = Me.NO_CONVOCATORIASpinEdit.Value
        End If
        _AccionContratada.DURACION = DURACIONSpinEdit.Value
        _AccionContratada.CANT_CURSOS = CANT_CURSOSSpinEdit.Value
        _AccionContratada.MONTO = MONTOSpinEdit.Value
        _AccionContratada.USUARIO_CREACION = USUARIO_CREACIONTextEdit.Text
        _AccionContratada.FECHA_CREACION = FECHA_CREACIONDateEdit.DateTime
        _AccionContratada.USERID = USERIDTextEdit.Text
        _AccionContratada.LASTUPDATE = LASTUPDATEDateEdit.DateTime
        _AccionContratada.NUM_ITEM = NUM_ITEMSpinEdit.Value
        _AccionContratada.COSTO_PARTICIPANTE = COSTO_PARTICIPANTESpinEdit.Value
        _AccionContratada.NOMBRE_ACCION_FORMATIVA = txtNOMBRE_ACCION_FORMATIVA.Text.Trim.ToUpper
        _AccionContratada.COSTO_HORA = If(Me.ID_PROGRAMA_FORMACIONCbxPROGRAMA_FORMACION.SelectedValue = ProgramasFormacion.EMPRESA_CENTRO, Me.speCostoxHora.Value, -1)
        _AccionContratada.COSTO_VISITA = If(Me.ID_PROGRAMA_FORMACIONCbxPROGRAMA_FORMACION.SelectedValue = ProgramasFormacion.EMPRESA_CENTRO, Me.speCostoxVisita.Value, -1)
        _AccionContratada.CODIGO_CATEG = Utilerias.QuitarAcentos(Me.txtCODIGO_CATEG.Text.ToUpper)
        _AccionContratada.NOMBRE_CATEG = Utilerias.QuitarAcentos(Me.txtNOMBRE_CATEG.Text.ToUpper)

        Dim lPrograma As SIFP.EL.Programas = (New SIFP.BL.cProgramas).ObtenerProgramas(_AccionContratada.CODIGO_PROGRAMA)
        If lPrograma IsNot Nothing AndAlso txtNOMBRE_ACCION_FORMATIVA.Text.Trim.ToUpper = "" Then
            _AccionContratada.NOMBRE_ACCION_FORMATIVA = lPrograma.nombre_programa.ToUpper
        End If

        If mControl.ActualizarACCION_CONTRATADA(_AccionContratada, TipoConcurrencia.Pesimistica) < 1 Then
            Me.AsignarMensaje(mControl.sError, True)
            Return -1
        End If
        Me.ID_ACCION_CONTRATADATextEdit.Text = _AccionContratada.ID_ACCION_CONTRATADA.ToString()
        Return 1
    End Function


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que permite Habilitar/Deshabilitar el uso de los controles contenidos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	12/04/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.ID_CONTRATOCbxCONTRATO_BOLPROS.Enabled = edicion
        Me.CODIGO_DEPARTAMENTOcbxDEPARTAMENTO.Enabled = edicion
        Me.CODIGO_MUNICIPIOcbxMUNICIPIO.Enabled = edicion
        Me.CODIGO_PROGRAMACbxPROGRAMAS.Enabled = edicion
        Me.NO_CONVOCATORIASpinEdit.Enabled = edicion
        Me.DURACIONSpinEdit.Enabled = edicion
        Me.CANT_CURSOSSpinEdit.Enabled = edicion
        Me.MONTOSpinEdit.Enabled = edicion
        Me.COSTO_PARTICIPANTESpinEdit.Enabled = edicion
        Me.USUARIO_CREACIONTextEdit.Enabled = edicion
        Me.FECHA_CREACIONDateEdit.Enabled = edicion
        Me.USERIDTextEdit.Enabled = edicion
        Me.LASTUPDATEDateEdit.Enabled = edicion
        Me.speCostoxHora.Enabled = False
        Me.speCostoxVisita.Enabled = False
        Me.txtCODIGO_CATEG.Enabled = edicion
        Me.txtNOMBRE_CATEG.Enabled = edicion
    End Sub

    Private Sub ID_PROGRAMA_FORMACIONCbxPROGRAMA_FORMACION_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ID_PROGRAMA_FORMACIONCbxPROGRAMA_FORMACION.SelectedIndexChanged
        If ID_PROGRAMA_FORMACIONCbxPROGRAMA_FORMACION.SelectedValue IsNot Nothing AndAlso _
            ID_PROGRAMA_FORMACIONCbxPROGRAMA_FORMACION.SelectedValue <> -1 Then
            If Utilerias.ObtenerFuentePorProgramaFormacion(ID_PROGRAMA_FORMACIONCbxPROGRAMA_FORMACION.SelectedValue) > -1 Then
                Me.NO_CONVOCATORIASpinEdit.Enabled = True
                Return
            End If
        End If
        Me.NO_CONVOCATORIASpinEdit.Value = 0
        Me.NO_CONVOCATORIASpinEdit.Enabled = False
        ConfigurarContrato()
        CargarProgramasCursos()

        If ID_PROGRAMA_FORMACIONCbxPROGRAMA_FORMACION.SelectedValue IsNot Nothing AndAlso _
            ID_PROGRAMA_FORMACIONCbxPROGRAMA_FORMACION.SelectedValue = ProgramasFormacion.EMPRESA_CENTRO Then
            Me.COSTO_PARTICIPANTESpinEdit.Enabled = True
            Me.speCostoxHora.Enabled = True
            Me.speCostoxVisita.Enabled = True
        Else
            Me.speCostoxHora.Value = Nothing
            Me.speCostoxVisita.Value = Nothing

            Me.COSTO_PARTICIPANTESpinEdit.Enabled = False
            Me.speCostoxHora.Enabled = False
            Me.speCostoxVisita.Enabled = False
        End If
    End Sub

    Private Sub ConfigurarContrato()
        Dim idProveedor As Integer = 0
        Dim idPrograma As Integer = 0

        If ID_PROVEEDOR_AFCbxPROVEEDOR_AF.SelectedValue IsNot Nothing AndAlso ID_PROVEEDOR_AFCbxPROVEEDOR_AF.SelectedValue > -1 Then
            idProveedor = ID_PROVEEDOR_AFCbxPROVEEDOR_AF.SelectedValue
        End If
        If ID_PROGRAMA_FORMACIONCbxPROGRAMA_FORMACION.SelectedValue IsNot Nothing AndAlso ID_PROGRAMA_FORMACIONCbxPROGRAMA_FORMACION.SelectedValue > -1 Then
            idPrograma = ID_PROGRAMA_FORMACIONCbxPROGRAMA_FORMACION.SelectedValue
        End If

        ID_CONTRATOCbxCONTRATO_BOLPROS.RecuperarPorCriterios(idProveedor, idPrograma, "", True, False, "NUM_CONTRATO, LOTE", "ASC", True)
    End Sub

    Private Sub ID_PROVEEDOR_AFCbxPROVEEDOR_AF_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ID_PROVEEDOR_AFCbxPROVEEDOR_AF.SelectedIndexChanged
        ConfigurarContrato()
    End Sub

    Private Sub CODIGO_DEPARTAMENTOcbxDEPARTAMENTO_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CODIGO_DEPARTAMENTOcbxDEPARTAMENTO.SelectedIndexChanged
        CODIGO_MUNICIPIOcbxMUNICIPIO.RecuperarPorDEPARTAMENTO(CODIGO_DEPARTAMENTOcbxDEPARTAMENTO.SelectedValue)
    End Sub

    Private Sub ID_CONTRATOCbxCONTRATO_BOLPROS_SelectedValueChanged(sender As Object, e As EventArgs) Handles ID_CONTRATOCbxCONTRATO_BOLPROS.SelectedValueChanged
        If ID_CONTRATOCbxCONTRATO_BOLPROS.SelectedValue IsNot Nothing Then
            Dim lContrato As CONTRATO_BOLPROS = (New cCONTRATO_BOLPROS).ObtenerCONTRATO_BOLPROS(ID_CONTRATOCbxCONTRATO_BOLPROS.SelectedValue)
            If lContrato IsNot Nothing AndAlso lContrato.ID_TIPO_ADJ = TipoAdjudicacionBolpros.AdjudicacionPorParticipaciones_CostoParticipante Then
                Me.DURACIONSpinEdit.Enabled = True
                Me.CANT_CURSOSSpinEdit.Enabled = False
                Me.NUM_ITEMSpinEdit.Enabled = True
                Me.MONTOSpinEdit.Value = 0
                Me.MONTOSpinEdit.Enabled = False
                Me.COSTO_PARTICIPANTESpinEdit.Enabled = True
                Me.lblNOMBRE_ACCION_FORMATIVA.Visible = True
                Me.txtNOMBRE_ACCION_FORMATIVA.Visible = True
            ElseIf lContrato IsNot Nothing AndAlso lContrato.ID_TIPO_ADJ <> TipoAdjudicacionBolpros.AdjudicacionPorCurso Then
                Me.CANT_CURSOSSpinEdit.Value = 1
                Me.CANT_CURSOSSpinEdit.Enabled = False
                Me.NUM_ITEMSpinEdit.Text = 1
                Me.NUM_ITEMSpinEdit.Enabled = False
                Me.MONTOSpinEdit.Value = 0
                Me.MONTOSpinEdit.Enabled = False
                Me.COSTO_PARTICIPANTESpinEdit.Enabled = (lContrato.ID_TIPO_ADJ = TipoAdjudicacionBolpros.AdjudicacionPorCurso_CostoParticipante_Online)
                Me.lblNOMBRE_ACCION_FORMATIVA.Visible = True
                Me.txtNOMBRE_ACCION_FORMATIVA.Visible = True
            ElseIf lContrato IsNot Nothing AndAlso lContrato.ID_TIPO_ADJ = TipoAdjudicacionBolpros.AdjudicacionPorCurso Then
                Me.CANT_CURSOSSpinEdit.Value = 0
                Me.CANT_CURSOSSpinEdit.Enabled = True
                Me.NUM_ITEMSpinEdit.Value = 0
                Me.NUM_ITEMSpinEdit.Enabled = True
                Me.MONTOSpinEdit.Enabled = True
                Me.COSTO_PARTICIPANTESpinEdit.Value = 0
                Me.COSTO_PARTICIPANTESpinEdit.Enabled = False
                Me.lblNOMBRE_ACCION_FORMATIVA.Visible = False
                Me.txtNOMBRE_ACCION_FORMATIVA.Visible = False
            End If
        End If

    End Sub


End Class
