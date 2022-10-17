Imports SIFP

Public Class xrInformeAvanceAspirantesEC

    Public Sub CargarAspirantesSeleccionados(ByVal ID_GRUPO_SELEC As Integer)
        Dim lGrupo As GRUPO_SELECCION = (New cGRUPO_SELECCION).ObtenerGRUPO_SELECCION(ID_GRUPO_SELEC)
        Dim lAccion As ACCION_CONTRATADA

        If lGrupo IsNot Nothing Then
            lAccion = (New cACCION_CONTRATADA).ObtenerACCION_CONTRATADA(lGrupo.ID_ACCION_CONTRATADA)

            If lAccion IsNot Nothing Then
                Dim lContrato As CONTRATO_BOLPROS = (New cCONTRATO_BOLPROS).ObtenerCONTRATO_BOLPROS(lAccion.ID_CONTRATO)
                Dim lPrograma As SIFP.EL.Programas = (New SIFP.BL.cProgramas).ObtenerProgramas(lAccion.CODIGO_PROGRAMA)

                If lPrograma IsNot Nothing Then
                    Me.xrPrograma.Text = "PROGRAMA: " + lPrograma.nombre_programa.ToUpper + ", G-" + lGrupo.NO_GRUPO.ToString + ", CONTRATO: " + lContrato.NUM_CONTRATO
                End If
            End If
        End If

        Me.DS_DL1.Clear()

        Me.xrTitulo.Text = "INFORME DE INICIO, PROGRAMA EMPRESA CENTRO"
        Me.INFORME_INICIO_PECENTROTableAdapter1.FillInformePreseleccionAspirantes(Me.DS_DL1.INFORME_INICIO_PECENTRO, ID_GRUPO_SELEC)

    End Sub

    Public Sub CargarReclutamientoExtraordinario(ByVal ID_GRUPO_SELEC As Integer)
        Dim lGrupo As GRUPO_SELECCION = (New cGRUPO_SELECCION).ObtenerGRUPO_SELECCION(ID_GRUPO_SELEC)
        Dim lAccion As ACCION_CONTRATADA

        If lGrupo IsNot Nothing Then
            lAccion = (New cACCION_CONTRATADA).ObtenerACCION_CONTRATADA(lGrupo.ID_ACCION_CONTRATADA)

            If lAccion IsNot Nothing Then
                Dim lContrato As CONTRATO_BOLPROS = (New cCONTRATO_BOLPROS).ObtenerCONTRATO_BOLPROS(lAccion.ID_CONTRATO)
                Dim lPrograma As SIFP.EL.Programas = (New SIFP.BL.cProgramas).ObtenerProgramas(lAccion.CODIGO_PROGRAMA)

                If lPrograma IsNot Nothing Then
                    Me.xrPrograma.Text = "PROGRAMA: " + lPrograma.nombre_programa.ToUpper + ", G-" + lGrupo.NO_GRUPO.ToString + ", CONTRATO: " + lContrato.NUM_CONTRATO
                End If
            End If
        End If

        Me.DS_DL1.Clear()

        Me.xrTitulo.Text = "INFORME DE RECLUTAMIENTO EXTRAORDINARIO DE ASPIRANTES, PROGRAMA EMPRESA CENTRO"
        Me.INFORME_INICIO_PECENTROTableAdapter1.FillReclutamientoExtemporaneo(Me.DS_DL1.INFORME_INICIO_PECENTRO, ID_GRUPO_SELEC)

    End Sub


End Class