Public Class frmConsultarCursos

    Private Sub frmConsultarCursos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.CargarDatos()
    End Sub

    Private Sub CargarDatos()
        Me.CbxPROVEEDOR_AF1.Recuperar(False, True)
        Me.CbxSITIO_CAPACITACION1.RecuperarPorPROVEEDOR_AF(Me.CbxPROVEEDOR_AF1.SelectedValue, True)
        Me.CbxAREA_FORMACION1.Recuperar(True)
        Me.CbxEJERCICIO1.Recuperar(True)
        Me.CbxEJERCICIO1.SelectedValue = "2010"
        Me.CbxESTADO_ACCION_FORMATIVA1.Recuperar(True)

        Me.AgregarOpcion("Recuperar", "Buscar Cursos", My.Resources.view, True)
        Me.AgregarOpcion("Imprimir", "Imprimir Inscritos", My.Resources.print, True)
        Me.AgregarOpcion("ImprimirInscritos", "Vista Previa Inscritos", My.Resources.print_preview, True)
        Me.AgregarOpcion("ImprimirAnexo1", "Vista Previa Anexo1", My.Resources.print_preview, True)
        Me.AgregarOpcion("ImprimirAnexo2", "Vista Previa Anexo2", My.Resources.print_preview, True)
        Me.AgregarOpcion("RecibirInforme", "Recibir Informe", My.Resources.ok, True)
    End Sub

    Public Overrides Sub EjecutarOpcion(ByVal asComando As String)
        If asComando = "Recuperar" Then
            Recuperar()
        End If
        If asComando = "ImprimirInscritos" Then
            ImprimirInscritos()
        End If
        If asComando = "ImprimirAnexo1" Then
            ImprimirAnexo1()
        End If
        If asComando = "ImprimirAnexo2" Then
            ImprimirAnexo2()
        End If
        If asComando = "RecibirInforme" Then
            RecibirInforme()
        End If
        If asComando = "Imprimir" Then
            Imprimir()
        End If
    End Sub

    Private Sub RecibirInforme()
        If Me.UcListaACCION_FORMATIVA1.Current Is Nothing Then
            Me.AsignarMensaje("Debe de elegir un curso para poder Recibirlo", True)
            Return
        End If

        Dim lEntidad As ACCION_FORMATIVA = (New cACCION_FORMATIVA).ObtenerACCION_FORMATIVA(Me.UcListaACCION_FORMATIVA1.Current.ID_ACCION_FORMATIVA)

        If lEntidad.CODIGO_ESTADO_AF <> Enumeradores.EstadoAccionFormativa.Finalizada Then 'AndAlso _
            'lEntidad.CODIGO_ESTADO_AF <> Enumeradores.EstadoAccionFormativa.DevueltoConObservaciones Then
            Me.AsignarMensaje("Curso no se puede recibir porque se encuentra en estado " + _
                (New cESTADO_ACCION_FORMATIVA).ObtenerESTADO_ACCION_FORMATIVA(lEntidad.CODIGO_ESTADO_AF).NOMBRE_ESTADO_AF, True)
            Return
        End If

        If (New cASISTENCIA_AF).ObtenerListaPorACCION_FORMATIVA(lEntidad.ID_ACCION_FORMATIVA).Count = 0 Then
            Me.AsignarMensaje("Curso no se puede recibir porque no existe Ingreso de Asistencia al mismo. Por favor verifique.", True)
            Return
        End If

        If (New cEVALUACION_AF).ObtenerListaPorACCION_FORMATIVA(lEntidad.ID_ACCION_FORMATIVA).Count = 0 Then
            Me.AsignarMensaje("Curso no se puede recibir porque no existen Ingreso de Evaluaciones/Notas al mismo. Por favor verifique.", True)
            Return
        End If

        'lEntidad.CODIGO_ESTADO_AF = Enumeradores.EstadoAccionFormativa.RecibidoEnINSAFORP
        If (New cACCION_FORMATIVA).ActualizarACCION_FORMATIVA(lEntidad) < 1 Then
            Me.AsignarMensaje("Curso no se pudo Recibir", True)
            Return
        End If

        Me.AsignarMensaje("Curso se Recibio Satisfactoriamente", True)
    End Sub


    Private Sub Recuperar()
        Dim lista As listaACCION_FORMATIVA = (New cACCION_FORMATIVA).ObtenerListaPorCriteriosPeriodoEstado(Me.CbxPROVEEDOR_AF1.SelectedValue, Me.CbxSITIO_CAPACITACION1.SelectedValue, Me.CbxAREA_FORMACION1.SelectedValue, "", txtCodigoGrupo.Text, Me.CbxESTADO_ACCION_FORMATIVA1.SelectedValue, Me.CbxEJERCICIO1.SelectedValue, "")
        Me.UcListaACCION_FORMATIVA1.CargarDatosPorLista(lista)
    End Sub

    Private Sub ImprimirAnexo1()
        If Me.UcListaACCION_FORMATIVA1.Current Is Nothing Then
            Me.AsignarMensaje("Debe de elegir un curso para ver el reporte de Informe Final - Anexo1", True)
            Return
        End If
        Dim reporte As New RL.xrInformeFinalAnexo1
        'reporte.CargarDatosPorAccionFormativa(Me.UcListaACCION_FORMATIVA1.Current.ID_ACCION_FORMATIVA)
        reporte.ShowPreview()
    End Sub

    Private Sub ImprimirAnexo2()
        If Me.UcListaACCION_FORMATIVA1.Current Is Nothing Then
            Me.AsignarMensaje("Debe de elegir un curso para ver el reporte de Informe Final - Anexo2", True)
            Return
        End If
        Dim reporte As New RL.xrInformeFinalAnexo2
        'reporte.CargarDatosPorAccionFormativa(Me.UcListaACCION_FORMATIVA1.Current.ID_ACCION_FORMATIVA)
        reporte.ShowPreview()
    End Sub

    Private Sub ImprimirInscritos()
        If Me.UcListaACCION_FORMATIVA1.Current Is Nothing Then
            Me.AsignarMensaje("Debe de elegir un curso para ver el reporte de Inscritos", True)
            Return
        End If
        Dim reporte As New RL.xrParticipantesInscritos
        reporte.CargarDatosPorCurso(Me.UcListaACCION_FORMATIVA1.Current.ID_ACCION_FORMATIVA)
        reporte.ShowPreview()
    End Sub

    Private Sub Imprimir()
        If Me.UcListaACCION_FORMATIVA1.Current Is Nothing Then
            Me.AsignarMensaje("Debe de elegir un curso para imprimir el reporte de Inscritos", True)
            Return
        End If
        Dim reporte As New RL.xrParticipantesInscritos
        reporte.CargarDatosPorCurso(Me.UcListaACCION_FORMATIVA1.Current.ID_ACCION_FORMATIVA)
        reporte.Print()
    End Sub

    Private Sub CbxPROVEEDOR_AF1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbxPROVEEDOR_AF1.SelectedIndexChanged
        Me.CbxSITIO_CAPACITACION1.RecuperarPorPROVEEDOR_AF(Me.CbxPROVEEDOR_AF1.SelectedValue, True)
    End Sub
End Class