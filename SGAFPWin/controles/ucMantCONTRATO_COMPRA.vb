Imports SGAFP.EL
Imports System.Data.OleDb
Imports System.Text
Imports SGAFP.EL.Enumeradores

Public Class ucMantCONTRATO_COMPRA

    Private mListaCONTRATO_COMPRA As listaCONTRATO_COMPRA

    Private _EsConsulta As Boolean = False
    <DefaultValue(False)> _
    Public Property EsConsulta() As Boolean
        Get
            Return Me._EsConsulta
        End Get
        Set(ByVal value As Boolean)
            Me._EsConsulta = value
            Me.UcListaCONTRATO_COMPRA1.EsConsulta = value
            Me.UcDetalleCONTRATO_COMPRA1.EsConsulta = value
        End Set
    End Property


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla CONTRATO_COMPRA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	17/05/2016	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub CargarDatos()
        Try
            Me.UcListaCONTRATO_COMPRA1.CargarDatos()
        Catch ex As Exception
            Me.AsignarMensaje("No se pudo recuperar los datos")
        End Try
    End Sub

    Private Sub UcListaCONTRATO_BOLPROS1_CambioRegistro() Handles UcListaCONTRATO_COMPRA1.CambioRegistro
        If Not Me.UcListaCONTRATO_COMPRA1.Current Is Nothing Then
            Me.ToolStripButtonEditar.Visible = True
        End If
    End Sub

    Sub Inicializar()
        Me.OpenFileDialog1.FileName = "*.xlsx"
        Me.OpenFileDialog1.Filter = "Excel Worksheets|*.xlsx"
        Me.UcListaCONTRATO_COMPRA1.EsConsulta = True
        Me.SplitContainer2.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1
        Me.ConfigurarMenu("Iniciar")
        Me.CargarDatos()
    End Sub

    Private Sub ConfigurarMenu(ByVal opcion As String)
        Select Case opcion
            Case "Agregar", "Editar"
                Me.ToolStripButtonBuscar.Visible = False
                Me.ToolStripButtonAgregar.Visible = False
                Me.ToolStripButtonEditar.Visible = False
                Me.ToolStripButtonGuardar.Visible = True
                Me.ToolStripButtonCancelar.Visible = True
                Me.ToolStripButtonEliminar.Visible = False
                Me.ToolStripButtonCargarContratos.Visible = (opcion = "Editar")
                Me.ToolStripButtonCargarCursos.Visible = (opcion = "Editar")
            Case "Guardar", "Cancelar"
                Me.ToolStripButtonBuscar.Visible = True
                Me.ToolStripButtonAgregar.Visible = True
                Me.ToolStripButtonGuardar.Visible = False
                Me.ToolStripButtonCancelar.Visible = False
                Me.ToolStripButtonEliminar.Visible = True
                Me.ToolStripButtonCargarContratos.Visible = False
                Me.ToolStripButtonCargarCursos.Visible = False
                If Not Me.UcListaCONTRATO_COMPRA1.Current Is Nothing Then
                    Me.ToolStripButtonEditar.Visible = True
                End If
            Case "Eliminar"
                If Not Me.UcListaCONTRATO_COMPRA1.Current Is Nothing Then
                    Me.ToolStripButtonEditar.Visible = True
                End If
            Case "Cargar contratos"
                If Not Me.UcListaCONTRATO_COMPRA1.Current Is Nothing Then
                    Me.ToolStripButtonCargarContratos.Visible = True
                End If
            Case "Cargar cursos"
                If Not Me.UcListaCONTRATO_COMPRA1.Current Is Nothing Then
                    Me.ToolStripButtonCargarCursos.Visible = True
                End If

            Case Else
                Me.ToolStripButtonBuscar.Visible = True
                Me.ToolStripButtonAgregar.Visible = True
                Me.ToolStripButtonGuardar.Visible = False
                Me.ToolStripButtonCancelar.Visible = False
                Me.ToolStripButtonEliminar.Visible = True
                Me.ToolStripButtonCargarContratos.Visible = False
                Me.ToolStripButtonCargarCursos.Visible = False
        End Select
    End Sub


    Private Sub ToolStripMantto_ItemClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStripMantto.ItemClicked
        Select Case e.ClickedItem.Text
            Case "Agregar"
                Me.UcDetalleCONTRATO_COMPRA1.CONTRATO_COMPRA = New CONTRATO_COMPRA
                Me.SplitContainer2.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2
            Case "Editar"
                If Me.UcListaCONTRATO_COMPRA1.Current IsNot Nothing Then
                    Me.UcDetalleCONTRATO_COMPRA1.CONTRATO_COMPRA = (New cCONTRATO_COMPRA).ObtenerCONTRATO_COMPRA(Me.UcListaCONTRATO_COMPRA1.Current.ID_CONTRATO_COMPRA)
                    Me.SplitContainer2.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2
                Else
                    AsignarMensaje("Seleccione un registro", True)
                    Return
                End If
            Case "Buscar"
                Me.UcListaCONTRATO_COMPRA1.CargarDatos()
            Case "Guardar"
                If Me.UcDetalleCONTRATO_COMPRA1.Actualizar() <> 1 Then Exit Sub
                Me.UcListaCONTRATO_COMPRA1.CargarDatos()
                Me.SplitContainer2.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1
            Case "Cancelar"
                Me.SplitContainer2.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1
            Case "Eliminar"
                Me.UcListaCONTRATO_COMPRA1.Eliminar()
                Me.UcListaCONTRATO_COMPRA1.CargarDatos()
            Case "Cargar contratos"
                Dim lRet As String = ""

                If Me.UcListaCONTRATO_COMPRA1.Current IsNot Nothing Then
                    OpenFileDialog1.Filter = "Archivo de Excel (.xlsx)|*.xlsx"
                    OpenFileDialog1.FileName = ""
                    OpenFileDialog1.ShowDialog()
                    If OpenFileDialog1.FileName <> "" Then
                        lRet = CargarPlantillaContratos(Me.UcListaCONTRATO_COMPRA1.Current.ID_CONTRATO_COMPRA, OpenFileDialog1.FileName)
                        If lRet <> "" Then
                            Dim f As New frmMensajeBox("Inconsistencias de la plantilla de Contratos", lRet)
                            f.ShowDialog()
                            Return
                        Else
                            MsgBox("Se ha realizado la carga de la plantilla de Contratos", vbExclamation, "Información")
                        End If
                    End If
                Else
                    AsignarMensaje("Seleccione un registro", True)
                    Return
                End If

            Case "Cargar cursos"
                Dim lRet As String = ""

                If Me.UcListaCONTRATO_COMPRA1.Current IsNot Nothing Then
                    OpenFileDialog1.Filter = "Archivo de Excel (.xlsx)|*.xlsx"
                    OpenFileDialog1.FileName = ""
                    OpenFileDialog1.ShowDialog()
                    If OpenFileDialog1.FileName <> "" Then
                        lRet = CargarPlantillaCursos(Me.UcListaCONTRATO_COMPRA1.Current.ID_CONTRATO_COMPRA, OpenFileDialog1.FileName)
                        If lRet <> "" Then
                            Dim f As New frmMensajeBox("Inconsistencias de la plantilla de Cursos", lRet)
                            f.ShowDialog()
                            Return
                        Else
                            MsgBox("Se ha realizado la carga de la plantilla de Cursos", vbExclamation, "Información")
                        End If
                    End If
                Else
                    AsignarMensaje("Seleccione un registro", True)
                    Return
                End If

        End Select
        ConfigurarMenu(e.ClickedItem.Text)
    End Sub


    Private Sub ucMantCONTRATO_COMPRA_Load(sender As Object, e As EventArgs) Handles Me.Load
        Inicializar()
    End Sub


    Private Function CargarPlantillaContratos(ByVal ID_CONTRATO_COMPRA As Integer, ByVal rutaArchivoPlantilla As String) As String
        Dim continuar As Boolean = True
        Dim lContratoCompra As CONTRATO_COMPRA = (New cCONTRATO_COMPRA).ObtenerCONTRATO_COMPRA(ID_CONTRATO_COMPRA)
        Dim bContrato As New cCONTRATO_BOLPROS
        Dim exApp As New Microsoft.Office.Interop.Excel.Application
        Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
        Dim exHojaCon As Microsoft.Office.Interop.Excel.Worksheet
        Dim exHojaTipo As Microsoft.Office.Interop.Excel.Worksheet
        Dim esONLINE As Boolean = False
        Dim fila As Int32
        Dim numHojas As Integer = 0
        Dim lote As String = ""
        Dim sTIPO_PLANTILLA As String = ""

        Try
            If lContratoCompra Is Nothing Then
                Return "Seleccione la Oferta de compra en la que cargara los contratos"
            End If

            exLibro = exApp.Workbooks.Open(rutaArchivoPlantilla, False, False)

            'Validar que existen las hojas: CONTRATO, CURSOS POR CONTRATO y TIPO_PLANTILLA
            For Each Sht In exLibro.Worksheets
                If exApp.Proper(Sht.Name) = exApp.Proper("CONTRATOS") OrElse exApp.Proper(Sht.Name) = exApp.Proper("CURSOS POR CONTRATO") OrElse exApp.Proper(Sht.Name) = exApp.Proper("TIPO_PLANTILLA") Then
                    numHojas += 1
                End If
            Next Sht
            If numHojas < 3 Then
                Return "La estructura de la plantilla no es válida debido a que faltan hojas"
            End If

            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            exHojaCon = exLibro.Worksheets("CONTRATOS")
            exHojaTipo = exLibro.Worksheets("TIPO_PLANTILLA")
            exApp.DisplayAlerts = False

            ' Determinar tipo de plantilla
            sTIPO_PLANTILLA = exHojaTipo.Cells(2, 1).Text
            If exHojaTipo.Cells(2, 2).Text <> "" Then
                Return exHojaTipo.Cells(2, 2).Text
            End If

            'Verificar las columnas de la hoja            
            Dim sInconsistencias As New StringBuilder
            Dim seguir = True
            Dim esNegativo As Boolean = False
            fila = 3

            If (sTIPO_PLANTILLA = TipoPlantilla.ONLINE AndAlso exHojaCon.Cells(fila, 2).Value2.ToString.Contains("N° DE CONTRATO") AndAlso exHojaCon.Cells(fila, 3).Value2.ToString.Contains("NIT DEL PROVEEDOR (SIN GUIONES)") AndAlso _
                exHojaCon.Cells(fila, 4).Value2.ToString.Contains("NOMBRE DEL PROVEEDOR") AndAlso exHojaCon.Cells(fila, 5).Value2.ToString.Contains("MONTO DEL CONTRATO") AndAlso _
                 exHojaCon.Cells(fila, 6).Value2.ToString.Contains("LOTE") AndAlso exHojaCon.Cells(fila, 7).Value2.ToString.Contains("FECHA INICIO DE EJECUCION EN FORMATO: AÑO-MES-DIA") AndAlso _
                 exHojaCon.Cells(fila, 8).Value2.ToString.Contains("FECHA FIN EJECUCION EN FORMATO: AÑO-MES-DIA")) OrElse _
             (sTIPO_PLANTILLA = TipoPlantilla.PRESENCIAL AndAlso exHojaCon.Cells(fila, 2).Value2.ToString.Contains("N° DE CONTRATO") AndAlso exHojaCon.Cells(fila, 3).Value2.ToString.Contains("NIT DEL PROVEEDOR (SIN GUIONES)") AndAlso _
                exHojaCon.Cells(fila, 4).Value2.ToString.Contains("NOMBRE DEL PROVEEDOR") AndAlso exHojaCon.Cells(fila, 5).Value2.ToString.Contains("MONTO DEL CONTRATO") AndAlso _
                 exHojaCon.Cells(fila, 6).Value2.ToString.Contains("LOTE") AndAlso exHojaCon.Cells(fila, 7).Value2.ToString.Contains("FECHA INICIO DE EJECUCION EN FORMATO: AÑO-MES-DIA") AndAlso _
                 exHojaCon.Cells(fila, 8).Value2.ToString.Contains("FECHA FIN EJECUCION EN FORMATO: AÑO-MES-DIA") AndAlso _
                 exHojaCon.Cells(fila, 9).Value2.ToString.Contains("COSTO POR PARTICIPANTE") AndAlso _
                 exHojaCon.Cells(fila, 10).Value2.ToString.Contains("CANTIDAD DE PARTICIPACIONES")) OrElse _
             (sTIPO_PLANTILLA = TipoPlantilla.CURSO AndAlso exHojaCon.Cells(fila, 2).Value2.ToString.Contains("N° DE CONTRATO") AndAlso exHojaCon.Cells(fila, 3).Value2.ToString.Contains("NIT DEL PROVEEDOR (SIN GUIONES)") AndAlso _
                exHojaCon.Cells(fila, 4).Value2.ToString.Contains("NOMBRE DEL PROVEEDOR") AndAlso exHojaCon.Cells(fila, 5).Value2.ToString.Contains("MONTO DEL CONTRATO") AndAlso _
                 exHojaCon.Cells(fila, 6).Value2.ToString.Contains("LOTE") AndAlso exHojaCon.Cells(fila, 7).Value2.ToString.Contains("FECHA INICIO DE EJECUCION EN FORMATO: AÑO-MES-DIA") AndAlso _
                 exHojaCon.Cells(fila, 8).Value2.ToString.Contains("FECHA FIN EJECUCION EN FORMATO: AÑO-MES-DIA")) Then


                sInconsistencias = New StringBuilder

                ' ********************************************************************
                'Validar que los números de contrato no existan en la oferta de compra
                fila = 4
                seguir = True
                While seguir
                    exHojaCon.Cells(fila, 2).Interior.ColorIndex = 0
                    If exHojaCon.Cells(fila, 2).Value2 <> Nothing Then
                        If exHojaCon.Cells(fila, 6).Value2 <> Nothing Then lote = exHojaCon.Cells(fila, 6).ToString
                        Dim lstContratos As listaCONTRATO_BOLPROS = bContrato.ObtenerListaPorCriterios(-1, -1, exHojaCon.Cells(fila, 2).Value2, lContratoCompra.ID_CONTRATO_COMPRA, lote)
                        If lstContratos IsNot Nothing AndAlso lstContratos.Count > 0 AndAlso lstContratos(0).LOTE = exHojaCon.Cells(fila, 6).ToString Then
                            exHojaCon.Cells(fila, 2).Interior.Color = System.Drawing.ColorTranslator.ToOle(Color.Yellow)
                            sInconsistencias.AppendLine("Contrato N° " & exHojaCon.Cells(fila, 2).Text & " y lote N° " & exHojaCon.Cells(fila, 6).ToString & " ya existe en la Oferta de Compra " + lContratoCompra.NO_CONTRATO_COMPRA)
                        End If
                    Else
                        exHojaCon.Cells(fila, 2).Interior.Color = System.Drawing.ColorTranslator.ToOle(Color.Yellow)
                        sInconsistencias.AppendLine("No existe número de contrato en la fila " & fila.ToString)
                    End If

                    fila += 1

                    If exHojaCon.Cells(fila, 2).Value2 = Nothing Then seguir = False
                End While

                ' ********************************************************************
                'Validar que los NIT existan en la base de proveedores
                fila = 4
                seguir = True
                While seguir
                    exHojaCon.Cells(fila, 3).Interior.ColorIndex = 0
                    If exHojaCon.Cells(fila, 3).Value2 <> Nothing Then
                        Dim lstProveedor As listaPROVEEDOR_AF = (New cPROVEEDOR_AF).ObtenerListaPorCriterios(exHojaCon.Cells(fila, 3).Value2.ToString)
                        If lstProveedor Is Nothing OrElse lstProveedor.Count = 0 Then
                            exHojaCon.Cells(fila, 3).Interior.Color = System.Drawing.ColorTranslator.ToOle(Color.Yellow)
                            sInconsistencias.AppendLine("Proveedor " & exHojaCon.Cells(fila, 4).Text & " con NIT " & exHojaCon.Cells(fila, 3).Text & " no esta registrado en el sistema")
                        End If
                    Else
                        exHojaCon.Cells(fila, 3).Interior.Color = System.Drawing.ColorTranslator.ToOle(Color.Yellow)
                        sInconsistencias.AppendLine("No existe número de NIT en la fila " & fila.ToString)
                    End If
                    fila += 1

                    If exHojaCon.Cells(fila, 2).Value2 = Nothing Then seguir = False
                End While

                ' ********************************************************************
                'Validar que los montos sean valores numericos
                fila = 4
                seguir = True
                While seguir
                    exHojaCon.Cells(fila, 5).Interior.ColorIndex = 0
                    If Not IsNumeric(exHojaCon.Cells(fila, 5).Value2) Then
                        exHojaCon.Cells(fila, 5).Interior.Color = System.Drawing.ColorTranslator.ToOle(Color.Yellow)
                        sInconsistencias.AppendLine("El monto del contrato " & exHojaCon.Cells(fila, 2).Text & " no es un valor numerico")
                    End If
                    fila += 1

                    If exHojaCon.Cells(fila, 2).Value2 = Nothing Then seguir = False
                End While

                ' ********************************************************************
                'Validar que el período de ejecución sean fechas
                fila = 4
                seguir = True
                While seguir
                    exHojaCon.Cells(fila, 7).Interior.ColorIndex = 0
                    exHojaCon.Cells(fila, 8).Interior.ColorIndex = 0
                    If Not (IsDate(exHojaCon.Cells(fila, 7).Text) AndAlso IsDate(exHojaCon.Cells(fila, 8).Text)) Then
                        exHojaCon.Cells(fila, 7).Interior.Color = System.Drawing.ColorTranslator.ToOle(Color.Yellow)
                        exHojaCon.Cells(fila, 8).Interior.Color = System.Drawing.ColorTranslator.ToOle(Color.Yellow)
                        sInconsistencias.AppendLine("Una o las dos fechas del contrato " & exHojaCon.Cells(fila, 2).Text & " no es una fecha valida")
                    End If
                    fila += 1

                    If exHojaCon.Cells(fila, 2).Value2 = Nothing Then seguir = False
                End While


                If sTIPO_PLANTILLA = TipoPlantilla.PRESENCIAL Then
                    ' ********************************************************************
                    'Validar que costos por participante sean valores numericos
                    fila = 4
                    seguir = True
                    While seguir
                        exHojaCon.Cells(fila, 9).Interior.ColorIndex = 0
                        If Not IsNumeric(exHojaCon.Cells(fila, 9).Value2) Then
                            exHojaCon.Cells(fila, 9).Interior.Color = System.Drawing.ColorTranslator.ToOle(Color.Yellow)
                            sInconsistencias.AppendLine("El costo por participante en la fila " & fila.ToString & " no es un valor numerico")
                        End If
                        fila += 1

                        If exHojaCon.Cells(fila, 2).Value2 = Nothing Then seguir = False
                    End While

                    ' ********************************************************************
                    'Validar que cantidad de participaciones sean valores numericos
                    fila = 4
                    seguir = True
                    While seguir
                        exHojaCon.Cells(fila, 10).Interior.ColorIndex = 0
                        If Not IsNumeric(exHojaCon.Cells(fila, 10).Value2) Then
                            exHojaCon.Cells(fila, 10).Interior.Color = System.Drawing.ColorTranslator.ToOle(Color.Yellow)
                            sInconsistencias.AppendLine("La cantidad de participantes en la fila " & fila.ToString & " no es un valor numerico")
                        End If
                        fila += 1

                        If exHojaCon.Cells(fila, 2).Value2 = Nothing Then seguir = False
                    End While
                End If


                If sInconsistencias.ToString <> "" Then
                    exLibro.Save()
                    exLibro.Close()
                    exApp.DisplayAlerts = True
                    exHojaCon = Nothing
                    exLibro = Nothing
                    exApp = Nothing
                    Me.Cursor = System.Windows.Forms.Cursors.Default
                    Return sInconsistencias.ToString
                End If


                ' CARGAR INFORMACION
                fila = 4
                seguir = True
                While seguir
                    Dim lContrato As New CONTRATO_BOLPROS
                    Dim lstProveedor As listaPROVEEDOR_AF = (New cPROVEEDOR_AF).ObtenerListaPorCriterios(exHojaCon.Cells(fila, 3).Text)

                    lContrato.ID_CONTRATO = 0
                    If lstProveedor IsNot Nothing AndAlso lstProveedor.Count > 0 Then
                        lContrato.ID_PROVEEDOR_AF = lstProveedor(0).ID_PROVEEDOR_AF
                    End If
                    lContrato.ID_PROGRAMA_FORMACION = ProgramasFormacion.PROYECTO_ESPECIAL
                    lContrato.ID_FUENTE = -1
                    lContrato.NUM_CONTRATO = exHojaCon.Cells(fila, 2).Value2.ToString.Trim
                    lContrato.MONTO = Math.Round(exHojaCon.Cells(fila, 5).Value2, 2)
                    lContrato.LOTE = exHojaCon.Cells(fila, 6).Text
                    lContrato.SUB_LOTE = ""
                    lContrato.USUARIO_CREACION = Utilerias.ObtenerUsuario
                    lContrato.FECHA_CREACION = Now
                    lContrato.USERID = Utilerias.ObtenerUsuario
                    lContrato.LASTUPDATE = Now
                    lContrato.ID_TIPO_CONTRA = TipoContratacion.BOLPROS
                    lContrato.ID_OFERTA_COMPRA = 0
                    lContrato.ID_CONTRATO_COMPRA = lContratoCompra.ID_CONTRATO_COMPRA
                    lContrato.FECHA_INI_EJEC = CDate(exHojaCon.Cells(fila, 7).Text)
                    lContrato.FECHA_FIN_EJEC = CDate(exHojaCon.Cells(fila, 8).Text)
                    lContrato.ES_PAGO_PARTICIPANTE = 1
                    If sTIPO_PLANTILLA = TipoPlantilla.ONLINE Then
                        lContrato.ID_TIPO_ADJ = TipoAdjudicacionBolpros.AdjudicacionPorCurso_CostoParticipante_Online
                        lContrato.COSTO_X_PARTICIPANTE = -1
                        lContrato.PARTICIPACIONES = exHojaCon.Cells(fila, 9).Value2
                    ElseIf sTIPO_PLANTILLA = TipoPlantilla.PRESENCIAL Then
                        lContrato.ID_TIPO_ADJ = TipoAdjudicacionBolpros.AdjudicacionPorParticipaciones_CostoParticipante
                        lContrato.COSTO_X_PARTICIPANTE = exHojaCon.Cells(fila, 9).Value2
                        lContrato.PARTICIPACIONES = exHojaCon.Cells(fila, 10).Value2
                    ElseIf sTIPO_PLANTILLA = TipoPlantilla.CURSO Then
                        lContrato.ID_TIPO_ADJ = TipoAdjudicacionBolpros.AdjudicacionPorCurso
                        lContrato.COSTO_X_PARTICIPANTE = -1
                        lContrato.PARTICIPACIONES = -1
                    End If
                    lContrato.ES_INCREMENTO = -1
                    lContrato.NO_PRODUCTO = -1
                    bContrato.ActualizarCONTRATO_BOLPROS(lContrato)

                    fila += 1

                    If exHojaCon.Cells(fila, 2).Value2 = Nothing Then seguir = False
                End While

                exHojaTipo.Cells(2, 2) = "La plantilla de contratos ha sido cargada al sistema el " & Format(Now, "dd/MM/yyyy HH:mm") & " por el usuario " & Utilerias.ObtenerUsuario
                exLibro.Save()
                exLibro.Close()
                exApp.DisplayAlerts = True
                exHojaCon = Nothing
                exLibro = Nothing
                exApp = Nothing
            Else
                Me.Cursor = System.Windows.Forms.Cursors.Default
                Return "Se ha detectado que las columnas de la plantilla no son los esperados"
            End If

            Me.Cursor = System.Windows.Forms.Cursors.Default
            Return ""

        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Return "Error al generar"

        Finally
            If exLibro IsNot Nothing Then
                exLibro.Save()
                exLibro.Close()
                exApp.DisplayAlerts = True
                exHojaCon = Nothing
                exLibro = Nothing
                exApp = Nothing
            End If
        End Try
    End Function


    Private Function CargarPlantillaCursos(ByVal ID_CONTRATO_COMPRA As Integer, ByVal rutaArchivoPlantilla As String) As String
        Dim continuar As Boolean = True
        Dim lContratoCompra As CONTRATO_COMPRA = (New cCONTRATO_COMPRA).ObtenerCONTRATO_COMPRA(ID_CONTRATO_COMPRA)
        Dim bContrato As New cCONTRATO_BOLPROS
        Dim bAccionContra As New cACCION_CONTRATADA
        Dim exApp As New Microsoft.Office.Interop.Excel.Application
        Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
        Dim exHojaCurso As Microsoft.Office.Interop.Excel.Worksheet
        Dim exHojaTipo As Microsoft.Office.Interop.Excel.Worksheet
        Dim esONLINE As Boolean = False
        Dim fila As Int32
        Dim numHojas As Integer = 0
        Dim sTIPO_PLANTILLA As String = ""

        Try
            If lContratoCompra Is Nothing Then
                Return "Seleccione la Oferta de compra en la que cargara los contratos"
            End If

            exLibro = exApp.Workbooks.Open(rutaArchivoPlantilla, False, False)

            'Validar que existen las hojas: CONTRATO, CURSOS POR CONTRATO y TIPO_PLANTILLA
            For Each Sht In exLibro.Worksheets
                If exApp.Proper(Sht.Name) = exApp.Proper("CONTRATOS") OrElse exApp.Proper(Sht.Name) = exApp.Proper("CURSOS POR CONTRATO") OrElse exApp.Proper(Sht.Name) = exApp.Proper("TIPO_PLANTILLA") Then
                    numHojas += 1
                End If
            Next Sht
            If numHojas < 3 Then
                Return "La estructura de la plantilla no es válida debido a que faltan hojas"
            End If

            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            exHojaCurso = exLibro.Worksheets("CURSOS POR CONTRATO")
            exHojaTipo = exLibro.Worksheets("TIPO_PLANTILLA")
            exApp.DisplayAlerts = False

            ' Determinar tipo de plantilla
            sTIPO_PLANTILLA = exHojaTipo.Cells(2, 1).Text
            'If exHojaTipo.Cells(2, 1).Text = "ONLINE" Then
            '    esONLINE = True
            'Else
            '    esONLINE = False
            'End If
            If exHojaTipo.Cells(2, 3).Text <> "" Then
                Return exHojaTipo.Cells(2, 3).Text
            End If

            'Verificar las columnas de la hoja            
            Dim sInconsistencias As New StringBuilder
            Dim seguir = True
            Dim esNegativo As Boolean = False
            fila = 3

            If (sTIPO_PLANTILLA = TipoPlantilla.ONLINE AndAlso exHojaCurso.Cells(fila, 1).Value2.ToString.Contains("N° DE CONTRATO") AndAlso exHojaCurso.Cells(fila, 2).Value2.ToString.Contains("DEPARTAMENTO") AndAlso _
                exHojaCurso.Cells(fila, 3).Value2.ToString.Contains("MUNICIPIO") AndAlso exHojaCurso.Cells(fila, 4).Value2.ToString.Contains("CODIGO PROGRAMA SIFP") AndAlso _
                 exHojaCurso.Cells(fila, 5).Value2.ToString.Contains("DURACION (HORAS)") AndAlso exHojaCurso.Cells(fila, 7).Value2.ToString.Contains("N° ITEM") AndAlso _
                 exHojaCurso.Cells(fila, 8).Value2.ToString.Contains("NOMBRE PROGRAMA SIFP") AndAlso exHojaCurso.Cells(fila, 9).Value2.ToString.Contains("NOMBRE CURSO A EJECUTAR") AndAlso _
                 exHojaCurso.Cells(fila, 10).Value2.ToString.Contains("COSTO POR PARTICIPANTE")) OrElse _
               (sTIPO_PLANTILLA = TipoPlantilla.PRESENCIAL AndAlso exHojaCurso.Cells(fila, 1).Value2.ToString.Contains("N° DE CONTRATO") AndAlso exHojaCurso.Cells(fila, 2).Value2.ToString.Contains("DEPARTAMENTO") AndAlso _
                exHojaCurso.Cells(fila, 3).Value2.ToString.Contains("MUNICIPIO") AndAlso exHojaCurso.Cells(fila, 4).Value2.ToString.Contains("CODIGO PROGRAMA SIFP") AndAlso _
                 exHojaCurso.Cells(fila, 5).Value2.ToString.Contains("DURACION (HORAS)") AndAlso exHojaCurso.Cells(fila, 6).Value2.ToString.Contains("LOTE") AndAlso _
                 exHojaCurso.Cells(fila, 7).Value2.ToString.Contains("N° ITEM") AndAlso _
                 exHojaCurso.Cells(fila, 8).Value2.ToString.Contains("NOMBRE PROGRAMA SIFP") AndAlso exHojaCurso.Cells(fila, 9).Value2.ToString.Contains("NOMBRE CURSO A EJECUTAR")) OrElse _
             (sTIPO_PLANTILLA = TipoPlantilla.CURSO AndAlso exHojaCurso.Cells(fila, 1).Value2.ToString.Contains("N° DE CONTRATO") AndAlso exHojaCurso.Cells(fila, 2).Value2.ToString.Contains("DEPARTAMENTO") AndAlso _
                exHojaCurso.Cells(fila, 3).Value2.ToString.Contains("MUNICIPIO") AndAlso exHojaCurso.Cells(fila, 4).Value2.ToString.Contains("CODIGO PROGRAMA SIFP") AndAlso _
                 exHojaCurso.Cells(fila, 5).Value2.ToString.Contains("DURACION (HORAS)") AndAlso exHojaCurso.Cells(fila, 6).Value2.ToString.Contains("LOTE") AndAlso _
                 exHojaCurso.Cells(fila, 7).Value2.ToString.Contains("N° ITEM") AndAlso _
                 exHojaCurso.Cells(fila, 8).Value2.ToString.Contains("NOMBRE PROGRAMA SIFP") AndAlso exHojaCurso.Cells(fila, 9).Value2.ToString.Contains("NOMBRE CURSO A EJECUTAR") AndAlso _
                 exHojaCurso.Cells(fila, 10).Value2.ToString.Contains("MONTO TOTAL DE CURSOS") AndAlso exHojaCurso.Cells(fila, 11).Value2.ToString.Contains("CANTIDAD DE CURSOS")) Then


                sInconsistencias = New StringBuilder

                ' ********************************************************************
                'Validar que los números de contrato existan en la oferta de compra
                fila = 4
                seguir = True
                While seguir
                    exHojaCurso.Cells(fila, 1).Interior.ColorIndex = 0
                    If exHojaCurso.Cells(fila, 1).Value2 <> Nothing Then
                        Dim lstContratos As listaCONTRATO_BOLPROS = bContrato.ObtenerListaPorCriterios(-1, -1, Trim(exHojaCurso.Cells(fila, 1).Text), lContratoCompra.ID_CONTRATO_COMPRA, exHojaCurso.Cells(fila, 6).Text)
                        If lstContratos Is Nothing OrElse lstContratos.Count = 0 Then
                            exHojaCurso.Cells(fila, 1).Interior.Color = System.Drawing.ColorTranslator.ToOle(Color.Yellow)
                            sInconsistencias.AppendLine("Contrato N° " & exHojaCurso.Cells(fila, 1).Text & " con Lote " & exHojaCurso.Cells(fila, 6).Text & " no existe en la oferta de Compra " + lContratoCompra.NO_CONTRATO_COMPRA)
                        End If
                    Else
                        exHojaCurso.Cells(fila, 1).Interior.Color = System.Drawing.ColorTranslator.ToOle(Color.Yellow)
                        sInconsistencias.AppendLine("No existe número de contrato en la fila " & fila.ToString)
                    End If

                    fila += 1

                    If exHojaCurso.Cells(fila, 1).Value2 = Nothing Then seguir = False
                End While

                ' ********************************************************************
                'Validar que departamento y municipio existan
                fila = 4
                seguir = True
                While seguir
                    exHojaCurso.Cells(fila, 2).Interior.ColorIndex = 0
                    exHojaCurso.Cells(fila, 3).Interior.ColorIndex = 0
                    If exHojaCurso.Cells(fila, 2).Text <> "" AndAlso exHojaCurso.Cells(fila, 3).Text <> "" Then
                        Dim lMunicipio As MUNICIPIO = (New cMUNICIPIO).ObtenerMUNICIPIOPorNOMBRE_NOMBRE_DEPTO(Trim(exHojaCurso.Cells(fila, 2).Text).ToUpper, Trim(exHojaCurso.Cells(fila, 3).Text).ToUpper)
                        If lMunicipio Is Nothing Then
                            exHojaCurso.Cells(fila, 2).Interior.Color = System.Drawing.ColorTranslator.ToOle(Color.Yellow)
                            exHojaCurso.Cells(fila, 3).Interior.Color = System.Drawing.ColorTranslator.ToOle(Color.Yellow)
                            sInconsistencias.AppendLine("Departamento y municipio " & exHojaCurso.Cells(fila, 2).Text & ", " & exHojaCurso.Cells(fila, 3).Text & " en la fila " & fila.ToString & " no es valido")
                        End If
                    Else
                        exHojaCurso.Cells(fila, 2).Interior.Color = System.Drawing.ColorTranslator.ToOle(Color.Yellow)
                        exHojaCurso.Cells(fila, 3).Interior.Color = System.Drawing.ColorTranslator.ToOle(Color.Yellow)
                        sInconsistencias.AppendLine("Falta departamento y/o municipio en la fila " & fila.ToString)
                    End If
                    fila += 1
                    Console.WriteLine(fila)

                    If exHojaCurso.Cells(fila, 1).Value2 = Nothing Then seguir = False
                End While

                ' ********************************************************************
                'Validar que los códigos de programa existan
                fila = 4
                seguir = True
                While seguir
                    exHojaCurso.Cells(fila, 4).Interior.ColorIndex = 0
                    If exHojaCurso.Cells(fila, 4).Text <> "" Then
                        Dim bPrograma As New SIFP.BL.cProgramas
                        Dim lPrograma As SIFP.EL.Programas

                        lPrograma = bPrograma.ObtenerProgramas(exHojaCurso.Cells(fila, 4).Text)
                        If lPrograma Is Nothing OrElse lPrograma.codigo_programa = "" Then
                            exHojaCurso.Cells(fila, 4).Interior.Color = System.Drawing.ColorTranslator.ToOle(Color.Yellow)
                            sInconsistencias.AppendLine("Código de programa " & exHojaCurso.Cells(fila, 4).Text & " en la fila " & fila.ToString & " no es válido")
                        End If
                    Else
                        exHojaCurso.Cells(fila, 4).Interior.Color = System.Drawing.ColorTranslator.ToOle(Color.Yellow)
                        sInconsistencias.AppendLine("Falta el código de programa en la fila " & fila.ToString)
                    End If
                    fila += 1

                    If exHojaCurso.Cells(fila, 1).Value2 = Nothing Then seguir = False
                End While

                ' ********************************************************************
                'Validar que la duración sea un número válido
                fila = 4
                seguir = True
                While seguir
                    exHojaCurso.Cells(fila, 5).Interior.ColorIndex = 0
                    If exHojaCurso.Cells(fila, 5).Text <> "" Then
                        If Not IsNumeric(exHojaCurso.Cells(fila, 5).Text) Then
                            exHojaCurso.Cells(fila, 5).Interior.Color = System.Drawing.ColorTranslator.ToOle(Color.Yellow)
                            sInconsistencias.AppendLine("La duración debe ser un número en la fila " & fila.ToString)
                        End If
                    Else
                        exHojaCurso.Cells(fila, 5).Interior.Color = System.Drawing.ColorTranslator.ToOle(Color.Yellow)
                        sInconsistencias.AppendLine("Falta la duración en la fila " & fila.ToString)
                    End If
                    fila += 1

                    If exHojaCurso.Cells(fila, 1).Value2 = Nothing Then seguir = False
                End While

                ' ********************************************************************
                'Validar que nombre del curso a ejecutar no esté en blanco
                fila = 4
                seguir = True
                While seguir
                    exHojaCurso.Cells(fila, 9).Interior.ColorIndex = 0
                    If Trim(exHojaCurso.Cells(fila, 9).Text) = "" Then
                        exHojaCurso.Cells(fila, 9).Interior.Color = System.Drawing.ColorTranslator.ToOle(Color.Yellow)
                        sInconsistencias.AppendLine("Falta el nombre de curso a ejecutar en la fila " & fila.ToString)
                    End If
                    fila += 1

                    If exHojaCurso.Cells(fila, 1).Value2 = Nothing Then seguir = False
                End While

                ' ********************************************************************
                'Validar que el código de categoría no esté en blanco
                fila = 4
                seguir = True
                While seguir
                    Dim columna As Integer = 0
                    Select Case sTIPO_PLANTILLA
                        Case TipoPlantilla.ONLINE
                            columna = 11
                        Case TipoPlantilla.PRESENCIAL
                            columna = 10
                        Case TipoPlantilla.CURSO
                            columna = 12
                    End Select
                    exHojaCurso.Cells(fila, columna).Interior.ColorIndex = 0
                    If Trim(exHojaCurso.Cells(fila, columna).Text) = "" Then
                        exHojaCurso.Cells(fila, columna).Interior.Color = System.Drawing.ColorTranslator.ToOle(Color.Yellow)
                        sInconsistencias.AppendLine("Falta el código de categoría a ejecutar en la fila " & fila.ToString)
                    End If
                    fila += 1

                    If exHojaCurso.Cells(fila, 1).Value2 = Nothing Then seguir = False
                End While

                ' ********************************************************************
                'Validar que el nombre de categoría no esté en blanco
                fila = 4
                seguir = True
                While seguir
                    Dim columna As Integer = 0
                    Select Case sTIPO_PLANTILLA
                        Case TipoPlantilla.ONLINE
                            columna = 11
                        Case TipoPlantilla.PRESENCIAL
                            columna = 10
                        Case TipoPlantilla.CURSO
                            columna = 12
                    End Select
                    exHojaCurso.Cells(fila, columna).Interior.ColorIndex = 0
                    If Trim(exHojaCurso.Cells(fila, columna).Text) = "" Then
                        exHojaCurso.Cells(fila, columna).Interior.Color = System.Drawing.ColorTranslator.ToOle(Color.Yellow)
                        sInconsistencias.AppendLine("Falta el nombre de categoría a ejecutar en la fila " & fila.ToString)
                    End If
                    fila += 1

                    If exHojaCurso.Cells(fila, 1).Value2 = Nothing Then seguir = False
                End While


                If sInconsistencias.ToString <> "" Then
                    exLibro.Save()
                    exLibro.Close()
                    exApp.DisplayAlerts = True
                    exHojaCurso = Nothing
                    exLibro = Nothing
                    exApp = Nothing
                    Me.Cursor = System.Windows.Forms.Cursors.Default
                    Return sInconsistencias.ToString
                End If

                ' CARGAR INFORMACION
                fila = 4
                seguir = True
                While seguir
                    Dim lAccionContra As New ACCION_CONTRATADA
                    Dim lstContrato As listaCONTRATO_BOLPROS
                    Dim lMunicipio As MUNICIPIO


                    lAccionContra.ID_ACCION_CONTRATADA = 0
                    lstContrato = bContrato.ObtenerListaPorCriterios(-1, -1, exHojaCurso.Cells(fila, 1).Text, lContratoCompra.ID_CONTRATO_COMPRA, exHojaCurso.Cells(fila, 6).Text)
                    If lstContrato IsNot Nothing AndAlso lstContrato.Count > 0 Then
                        lAccionContra.ID_CONTRATO = lstContrato(0).ID_CONTRATO
                    End If
                    lMunicipio = (New cMUNICIPIO).ObtenerMUNICIPIOPorNOMBRE_NOMBRE_DEPTO(Trim(exHojaCurso.Cells(fila, 2).Text).ToUpper, Trim(exHojaCurso.Cells(fila, 3).Text).ToUpper)
                    If lMunicipio IsNot Nothing AndAlso lMunicipio.CODIGO_MUNICIPIO <> "" Then
                        lAccionContra.CODIGO_DEPARTAMENTO = lMunicipio.CODIGO_DEPARTAMENTO
                        lAccionContra.CODIGO_MUNICIPIO = lMunicipio.CODIGO_MUNICIPIO
                    End If
                    lAccionContra.CODIGO_PROGRAMA = Trim(exHojaCurso.Cells(fila, 4).Text)
                    lAccionContra.DURACION = exHojaCurso.Cells(fila, 5).Value2
                    lAccionContra.USUARIO_CREACION = Utilerias.ObtenerUsuario
                    lAccionContra.FECHA_CREACION = Now
                    lAccionContra.USERID = Utilerias.ObtenerUsuario
                    lAccionContra.LASTUPDATE = Now
                    lAccionContra.NUM_ITEM = exHojaCurso.Cells(fila, 7).Text
                    lAccionContra.MONTO = 0
                    lAccionContra.NO_CONVOCATORIA = -1
                    If sTIPO_PLANTILLA = TipoPlantilla.ONLINE Then
                        lAccionContra.COSTO_PARTICIPANTE = exHojaCurso.Cells(fila, 10).Value2
                        lAccionContra.CANT_CURSOS = 0
                        lAccionContra.CODIGO_CATEG = exHojaCurso.Cells(fila, 11).Text.ToString.ToUpper
                        lAccionContra.NOMBRE_CATEG = exHojaCurso.Cells(fila, 12).Text.ToString.ToUpper
                    ElseIf sTIPO_PLANTILLA = TipoPlantilla.PRESENCIAL Then
                        lAccionContra.COSTO_PARTICIPANTE = lstContrato(0).COSTO_X_PARTICIPANTE
                        lAccionContra.CANT_CURSOS = 0
                        lAccionContra.CODIGO_CATEG = exHojaCurso.Cells(fila, 10).Text.ToString.ToUpper
                        lAccionContra.NOMBRE_CATEG = exHojaCurso.Cells(fila, 11).Text.ToString.ToUpper
                    ElseIf sTIPO_PLANTILLA = TipoPlantilla.CURSO Then
                        lAccionContra.COSTO_PARTICIPANTE = 0
                        lAccionContra.MONTO = exHojaCurso.Cells(fila, 10).Value2
                        lAccionContra.CANT_CURSOS = exHojaCurso.Cells(fila, 11).Value2
                        lAccionContra.CODIGO_CATEG = exHojaCurso.Cells(fila, 12).Text.ToString.ToUpper
                        lAccionContra.NOMBRE_CATEG = exHojaCurso.Cells(fila, 13).Text.ToString.ToUpper
                    End If
                    lAccionContra.NOMBRE_ACCION_FORMATIVA = Utilerias.QuitarAcentoEspaciosMinusculas(exHojaCurso.Cells(fila, 9).Text)
                    lAccionContra.COSTO_HORA = -1
                    lAccionContra.COSTO_VISITA = -1

                    bAccionContra.ActualizarACCION_CONTRATADA(lAccionContra)

                    fila += 1

                    If exHojaCurso.Cells(fila, 1).Value2 = Nothing Then seguir = False
                End While

                exHojaTipo.Cells(2, 3) = "La plantilla de cursos ha sido cargada al sistema el " & Format(Now, "dd/MM/yyyy HH:mm") & " por el usuario " & Utilerias.ObtenerUsuario
                exLibro.Save()
                exLibro.Close()
                exApp.DisplayAlerts = True
                exHojaCurso = Nothing
                exLibro = Nothing
                exApp = Nothing
            Else
                Me.Cursor = System.Windows.Forms.Cursors.Default
                Return "Se ha detectado que las columnas de la plantilla no son los esperados"
            End If
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Return ""


        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Return "Error al generar"

        Finally
            If exLibro IsNot Nothing Then
                exLibro.Save()
                exLibro.Close()
                exApp.DisplayAlerts = True
                exHojaCurso = Nothing
                exLibro = Nothing
                exApp = Nothing
            End If
        End Try
    End Function
End Class

