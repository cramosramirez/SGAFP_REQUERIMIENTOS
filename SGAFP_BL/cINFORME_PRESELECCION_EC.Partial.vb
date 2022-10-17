Imports SGAFP.EL.Enumeradores

Partial Public Class cINFORME_PRESELECCION_EC

    Public Function GenerarInformePreseleccion(ByVal ID_GRUPO_SELEC As Decimal) As Integer

        Try

            Dim lGrupoSelec As GRUPO_SELECCION
            Dim lAspirantes As listaSOLICITUD_PRESELECCION_EC
            Dim lAccionContratada As ACCION_CONTRATADA
            Dim lInformePre As INFORME_PRESELECCION_EC
            Dim bInformePre As New cINFORME_PRESELECCION_EC
            Dim lstInformes As listaINFORME_PRESELECCION_EC
            Dim dCantPartiEval As Decimal = 0

            'Si ya existe informe salir
            lstInformes = bInformePre.ObtenerListaPorGRUPO_SELECCION(ID_GRUPO_SELEC)
            If lstInformes IsNot Nothing AndAlso lstInformes.Count > 0 Then
                sError = "Ya se ha generado el informe de avance de preseleccion"
                Return -1
            End If

            lGrupoSelec = (New cGRUPO_SELECCION).ObtenerGRUPO_SELECCION(ID_GRUPO_SELEC)

            If lGrupoSelec IsNot Nothing Then
                lAccionContratada = (New cACCION_CONTRATADA).ObtenerACCION_CONTRATADA(lGrupoSelec.ID_ACCION_CONTRATADA)
                lAspirantes = (New cSOLICITUD_PRESELECCION_EC).ObtenerListaPorGRUPO_SELECCION(ID_GRUPO_SELEC)

                If lAspirantes IsNot Nothing AndAlso lAspirantes.Count > 0 Then
                    For i As Integer = 0 To lAspirantes.Count - 1
                        If lAspirantes(i).ES_RECLUTA_INICIAL = 1 AndAlso lAspirantes(i).AUTORIZADO = 1 AndAlso _
                            (lAspirantes(i).ID_TIPO_SELECC = TipoSeleccionEC.Titular OrElse lAspirantes(i).ID_TIPO_SELECC = TipoSeleccionEC.Suplente) Then
                            dCantPartiEval += 1
                        End If
                    Next

                    lInformePre = New INFORME_PRESELECCION_EC
                    lInformePre.ID_INFORME_PRESE = 0
                    lInformePre.ID_GRUPO_SELEC = ID_GRUPO_SELEC
                    lInformePre.ID_CONTRATO = lAccionContratada.ID_CONTRATO
                    lInformePre.FECHA_REPORTE = Today
                    lInformePre.FECHA_INICIO = lGrupoSelec.FECHA_INICIO
                    lInformePre.FECHA_FINALIZACION = lGrupoSelec.FECHA_FIN
                    lInformePre.ELABORADO_POR = Utilerias.ObtenerUsuario
                    lInformePre.PARTI_EVALUADOS = dCantPartiEval
                    lInformePre.COSTO_X_PARTICIPANTE = lAccionContratada.COSTO_PARTICIPANTE
                    lInformePre.COSTO_X_HORA = lAccionContratada.COSTO_HORA
                    lInformePre.COSTO_X_VISITA = lAccionContratada.COSTO_VISITA
                    lInformePre.TOTAL_PAGAR = Math.Round(dCantPartiEval * lAccionContratada.COSTO_PARTICIPANTE, 2)
                    lInformePre.USUARIO_CREA = Utilerias.ObtenerUsuario
                    lInformePre.FECHA_CREA = Now
                    lInformePre.USUARIO_ACT = Utilerias.ObtenerUsuario
                    lInformePre.FECHA_ACT = Now

                    bInformePre.ActualizarINFORME_PRESELECCION_EC(lInformePre)
                End If
            End If

            Return 1

        Catch ex As Exception
            sError = ex.Message
            ExceptionManager.Publish(ex)
            Return -1

        End Try
    End Function

End Class
