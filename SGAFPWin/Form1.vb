Public Class Form1

    Private Sub btnRepetidosPorDUI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRepetidosPorDUI.Click
        ListaPARTICIPANTEBindingSource.DataSource = (New cPARTICIPANTE).ObtenerListaRepetidosPorDUI()
    End Sub

    Private Sub btnRepetidosPorNIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRepetidosPorNIT.Click
        ListaPARTICIPANTEBindingSource.DataSource = (New cPARTICIPANTE).ObtenerListaRepetidosPorNIT()
    End Sub

    Private Sub btnRepetidosPorNombres_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRepetidosPorNombres.Click
        ListaPARTICIPANTEBindingSource.DataSource = (New cPARTICIPANTE).ObtenerListaRepetidosPorNombres()
    End Sub

    Private Sub btnProcesarCambios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesarCambios.Click
        'Dim duiAnterior As Decimal = 0
        'Dim nitAnterior As Decimal = 0
        Dim lParticipanteAnterior = New PARTICIPANTE
        Dim cParticipante As New cPARTICIPANTE

        For i As Integer = 0 To ListaPARTICIPANTEBindingSource.DataSource.Count - 1

            Dim lParticipanteActual As PARTICIPANTE = ListaPARTICIPANTEBindingSource.DataSource(i)

            Dim duiAnterior As Decimal = Decimal.Parse(IIf(lParticipanteAnterior.DUI Is Nothing, 0, lParticipanteAnterior.DUI))
            Dim nitAnterior As Decimal = Decimal.Parse(IIf(lParticipanteAnterior.NIT Is Nothing, 0, lParticipanteAnterior.NIT))

            Dim duiActual As Decimal = Decimal.Parse(IIf(lParticipanteActual.DUI Is Nothing, 0, lParticipanteActual.DUI))
            Dim nitActual As Decimal = Decimal.Parse(IIf(lParticipanteActual.NIT Is Nothing, 0, lParticipanteActual.NIT))

            If duiActual = duiAnterior Or nitActual = nitAnterior Then
                If duiActual = duiAnterior _
                    And nitActual = nitAnterior _
                    And lParticipanteActual.GENERO = lParticipanteAnterior.GENERO _
                    And lParticipanteActual.FECHA_NACIMIENTO = lParticipanteAnterior.FECHA_NACIMIENTO Then
                    cParticipante.CorregirDatosParticipante(lParticipanteAnterior, lParticipanteActual.ID_PARTICIPANTE)
                ElseIf duiActual = duiAnterior _
                    And lParticipanteActual.GENERO = lParticipanteAnterior.GENERO _
                    And lParticipanteActual.FECHA_NACIMIENTO = lParticipanteAnterior.FECHA_NACIMIENTO Then
                    cParticipante.CorregirDatosParticipante(lParticipanteAnterior, lParticipanteActual.ID_PARTICIPANTE)
                ElseIf nitActual = nitActual _
                    And lParticipanteActual.GENERO = lParticipanteAnterior.GENERO _
                    And lParticipanteActual.FECHA_NACIMIENTO = lParticipanteAnterior.FECHA_NACIMIENTO Then
                    cParticipante.CorregirDatosParticipante(lParticipanteAnterior, lParticipanteActual.ID_PARTICIPANTE)
                ElseIf duiActual = duiAnterior _
                    And nitActual = nitAnterior _
                    And lParticipanteActual.GENERO = lParticipanteAnterior.GENERO Then
                    cParticipante.CorregirDatosParticipante(lParticipanteAnterior, lParticipanteActual.ID_PARTICIPANTE)
                ElseIf duiActual = duiAnterior _
                    And nitActual = nitAnterior _
                    And lParticipanteActual.FECHA_NACIMIENTO = lParticipanteAnterior.FECHA_NACIMIENTO Then
                    cParticipante.CorregirDatosParticipante(lParticipanteAnterior, lParticipanteActual.ID_PARTICIPANTE)
                ElseIf duiActual = duiAnterior _
                    And nitActual = nitAnterior _
                    And lParticipanteActual.GENERO = lParticipanteAnterior.GENERO _
                    And lParticipanteActual.FECHA_NACIMIENTO <> lParticipanteAnterior.FECHA_NACIMIENTO Then
                    cParticipante.CorregirDatosParticipante(lParticipanteAnterior, lParticipanteActual.ID_PARTICIPANTE)
                ElseIf duiActual = duiAnterior _
                    And lParticipanteActual.GENERO = lParticipanteAnterior.GENERO _
                    And lParticipanteActual.FECHA_NACIMIENTO <> lParticipanteAnterior.FECHA_NACIMIENTO Then
                    ListaPARTICIPANTEBindingSource.Position = i
                    If MessageBox.Show("Cambia FechaNac y NIT - Procesar Anterior:" + lParticipanteAnterior.NOMBRES + "," + lParticipanteAnterior.APELLIDOS + " y Actual: " + lParticipanteActual.NOMBRES + "," + lParticipanteActual.APELLIDOS, "Procesar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        cParticipante.CorregirDatosParticipante(lParticipanteAnterior, lParticipanteActual.ID_PARTICIPANTE)
                    End If
                ElseIf nitActual = nitAnterior _
                    And lParticipanteActual.GENERO = lParticipanteAnterior.GENERO _
                    And lParticipanteActual.FECHA_NACIMIENTO <> lParticipanteAnterior.FECHA_NACIMIENTO Then
                    ListaPARTICIPANTEBindingSource.Position = i
                    If MessageBox.Show("Cambia FechaNac y DUI - Procesar Anterior:" + lParticipanteAnterior.NOMBRES + "," + lParticipanteAnterior.APELLIDOS + " y Actual: " + lParticipanteActual.NOMBRES + "," + lParticipanteActual.APELLIDOS, "Procesar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        cParticipante.CorregirDatosParticipante(lParticipanteAnterior, lParticipanteActual.ID_PARTICIPANTE)
                    End If
                ElseIf duiActual = duiAnterior _
                    And nitActual = nitAnterior _
                    And lParticipanteActual.GENERO <> lParticipanteAnterior.GENERO _
                    And lParticipanteActual.FECHA_NACIMIENTO = lParticipanteAnterior.FECHA_NACIMIENTO Then
                    cParticipante.CorregirDatosParticipante(lParticipanteAnterior, lParticipanteActual.ID_PARTICIPANTE)
                ElseIf duiActual = duiAnterior _
                    And lParticipanteActual.GENERO <> lParticipanteAnterior.GENERO _
                    And lParticipanteActual.FECHA_NACIMIENTO = lParticipanteAnterior.FECHA_NACIMIENTO Then
                    ListaPARTICIPANTEBindingSource.Position = i
                    If MessageBox.Show("Cambia GENERO y NIT - Procesar Anterior:" + lParticipanteAnterior.NOMBRES + "," + lParticipanteAnterior.APELLIDOS + " y Actual: " + lParticipanteActual.NOMBRES + "," + lParticipanteActual.APELLIDOS, "Procesar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        cParticipante.CorregirDatosParticipante(lParticipanteAnterior, lParticipanteActual.ID_PARTICIPANTE)
                    End If
                ElseIf nitActual = nitAnterior _
                    And lParticipanteActual.GENERO <> lParticipanteAnterior.GENERO _
                    And lParticipanteActual.FECHA_NACIMIENTO = lParticipanteAnterior.FECHA_NACIMIENTO Then
                    ListaPARTICIPANTEBindingSource.Position = i
                    If MessageBox.Show("Cambia GENERO y DUI - Procesar Anterior:" + lParticipanteAnterior.NOMBRES + "," + lParticipanteAnterior.APELLIDOS + " y Actual: " + lParticipanteActual.NOMBRES + "," + lParticipanteActual.APELLIDOS, "Procesar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        cParticipante.CorregirDatosParticipante(lParticipanteAnterior, lParticipanteActual.ID_PARTICIPANTE)
                    End If
                ElseIf duiActual = duiAnterior _
                    And nitActual = nitAnterior _
                    And lParticipanteActual.GENERO <> lParticipanteAnterior.GENERO _
                    And lParticipanteActual.FECHA_NACIMIENTO <> lParticipanteAnterior.FECHA_NACIMIENTO Then
                    ListaPARTICIPANTEBindingSource.Position = i
                    If MessageBox.Show("Cambia GENERO y Fecha Nacimiento - Procesar Anterior:" + lParticipanteAnterior.NOMBRES + "," + lParticipanteAnterior.APELLIDOS + " y Actual: " + lParticipanteActual.NOMBRES + "," + lParticipanteActual.APELLIDOS, "Procesar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        cParticipante.CorregirDatosParticipante(lParticipanteAnterior, lParticipanteActual.ID_PARTICIPANTE)
                    End If
                ElseIf duiActual <> duiAnterior _
                    And nitActual = nitAnterior _
                    And lParticipanteActual.GENERO <> lParticipanteAnterior.GENERO _
                    And lParticipanteActual.FECHA_NACIMIENTO <> lParticipanteAnterior.FECHA_NACIMIENTO Then
                    ListaPARTICIPANTEBindingSource.Position = i
                    If MessageBox.Show("Cambia GENERO, Fecha Nacimiento y DUI - Procesar Anterior:" + lParticipanteAnterior.NOMBRES + "," + lParticipanteAnterior.APELLIDOS + " y Actual: " + lParticipanteActual.NOMBRES + "," + lParticipanteActual.APELLIDOS, "Procesar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        cParticipante.CorregirDatosParticipante(lParticipanteAnterior, lParticipanteActual.ID_PARTICIPANTE)
                    End If
                ElseIf duiActual = duiAnterior _
                    And nitActual <> nitAnterior _
                    And lParticipanteActual.GENERO <> lParticipanteAnterior.GENERO _
                    And lParticipanteActual.FECHA_NACIMIENTO <> lParticipanteAnterior.FECHA_NACIMIENTO Then
                    ListaPARTICIPANTEBindingSource.Position = i
                    If MessageBox.Show("Cambia GENERO, Fecha Nacimiento y NIT - Procesar Anterior:" + lParticipanteAnterior.NOMBRES + "," + lParticipanteAnterior.APELLIDOS + " y Actual: " + lParticipanteActual.NOMBRES + "," + lParticipanteActual.APELLIDOS, "Procesar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        cParticipante.CorregirDatosParticipante(lParticipanteAnterior, lParticipanteActual.ID_PARTICIPANTE)
                    End If
                Else
                End If
                'MessageBox.Show("Repetido")
                'lParticipanteAnterior.
                'Recuperar las SOlicitudes de ese participante
            End If

            lParticipanteAnterior = lParticipanteActual
        Next
    End Sub

    Private Sub btnProcesarSeleccionados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesarSeleccionados.Click
        If Me.ListaPARTICIPANTEDataGridView.SelectedRows.Count < 2 Then
            MessageBox.Show("Se deben de seleccionar 2 Registros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If Me.ListaPARTICIPANTEDataGridView.SelectedRows.Count > 2 Then
            MessageBox.Show("Se deben de seleccionar solamente 2 Registros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim index1, index2 As Integer
        index1 = Me.ListaPARTICIPANTEDataGridView.SelectedRows(1).Index
        index2 = Me.ListaPARTICIPANTEDataGridView.SelectedRows(0).Index
        If index1 > index2 Then
            Dim temp As Integer = index2
            index2 = index1
            index1 = temp
        End If
        Dim lParticipanteAnterior As PARTICIPANTE = ListaPARTICIPANTEBindingSource.DataSource(index1)
        Dim lParticipanteActual As PARTICIPANTE = ListaPARTICIPANTEBindingSource.DataSource(index2)

        Dim duiAnterior As Decimal = Decimal.Parse(IIf(lParticipanteAnterior.DUI Is Nothing, 0, lParticipanteAnterior.DUI))
        Dim nitAnterior As Decimal = Decimal.Parse(IIf(lParticipanteAnterior.NIT Is Nothing, 0, lParticipanteAnterior.NIT))

        Dim duiActual As Decimal = Decimal.Parse(IIf(lParticipanteActual.DUI Is Nothing, 0, lParticipanteActual.DUI))
        Dim nitActual As Decimal = Decimal.Parse(IIf(lParticipanteActual.NIT Is Nothing, 0, lParticipanteActual.NIT))

        Dim cParticipante As New cPARTICIPANTE

        cParticipante.CorregirDatosParticipante(lParticipanteAnterior, lParticipanteActual.ID_PARTICIPANTE)


    End Sub
End Class
