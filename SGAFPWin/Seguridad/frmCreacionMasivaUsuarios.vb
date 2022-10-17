Public Class frmCreacionMasivaUsuarios

    Private Sub ButtonEdit1_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles ButtonEdit1.ButtonClick
        Me.OpenFileDialog1.FileName = ""
        Me.OpenFileDialog1.InitialDirectory = System.Environment.SpecialFolder.MyDocuments
        Me.OpenFileDialog1.Filter = "Archivo Excel |*.xls"
        If Not Me.OpenFileDialog1.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Return
        End If
        Me.ButtonEdit1.Text = Me.OpenFileDialog1.FileName
    End Sub

    Private Sub ProcesarArchivo(ByVal aFile As String)
        Dim xlsApp As Microsoft.Office.Interop.Excel.Application
        Dim xlsWB As Microsoft.Office.Interop.Excel.Workbook
        Dim xlsSheet As Microsoft.Office.Interop.Excel.Worksheet

        xlsApp = New Microsoft.Office.Interop.Excel.Application
        xlsApp.Visible = False
        xlsWB = xlsApp.Workbooks.Open(aFile)

        xlsSheet = xlsWB.Worksheets(1)

        Dim i As Integer = 2

        Dim cParticipante As New cPARTICIPANTE
        Dim idProveedor, idSitioCapacitacion, idParticipante As Decimal

        idParticipante = -1

        Dim rol As String

        idProveedor = Me.CbxPROVEEDOR_AF1.SelectedValue

        If idProveedor = -1 And idSitioCapacitacion = -1 And idParticipante <> -1 Then
            rol = "Participante"
        ElseIf idProveedor <> -1 And idSitioCapacitacion = -1 And idParticipante = -1 Then
            rol = "Proveedor"
        ElseIf idProveedor <> -1 And idSitioCapacitacion <> -1 And idParticipante = -1 Then
            rol = "CentroCapacitador"
        Else
            rol = "Participante"
        End If

        Do

            i += 1
        Loop While Not xlsSheet.Cells(i, 2).Value Is Nothing

        Me.ProgressBarControl1.Properties.Maximum = i - 2

        i = 2

        Do
            Dim nombreUsuario, clave, preguntaSeguridad, respuestaSeguridad, perfil As String
            nombreUsuario = xlsSheet.Cells(i, 2).Value
            clave = xlsSheet.Cells(i, 3).Value
            preguntaSeguridad = xlsSheet.Cells(i, 4).Value
            respuestaSeguridad = xlsSheet.Cells(i, 5).Value
            idSitioCapacitacion = xlsSheet.Cells(i, 7).Value

            Select Case xlsSheet.Cells(i, 6).Value
                Case "P"
                    perfil = "Proveedor"
                Case "C"
                    perfil = "CentroCapacitador"
                Case Else
                    perfil = "Participante"
            End Select

            Try
                cParticipante.CrearCuenta(nombreUsuario, clave, nombreUsuario, preguntaSeguridad, respuestaSeguridad, perfil)

                'If (New cUSUARIO).AgregarUSUARIO(nombreUsuario, idProveedor, idSitioCapacitacion, idParticipante) < 1 Then

                'End If
            Catch ex1 As Exception
                Me.AsignarMensaje("Error al crear el usuario:" + nombreUsuario, True)
            End Try

            i += 1
            Me.ProgressBarControl1.Increment(1)

        Loop While Not xlsSheet.Cells(i, 2).Value Is Nothing

        xlsWB.Close(False)
        xlsApp.Quit()
        xlsApp = Nothing
        xlsWB = Nothing
        xlsSheet = Nothing

    End Sub

    Private Sub frmCreacionMasivaUsuarios_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.CbxPROVEEDOR_AF1.Recuperar(False, True)
        Me.CbxPROVEEDOR_AF1.SelectedValue = -1
        Me.CbxSITIO_CAPACITACION1.RecuperarPorPROVEEDOR_AF(Me.CbxPROVEEDOR_AF1.SelectedValue, True)
    End Sub

    Private Sub CbxPROVEEDOR_AF1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbxPROVEEDOR_AF1.SelectedIndexChanged
        Me.CbxSITIO_CAPACITACION1.RecuperarPorPROVEEDOR_AF(Me.CbxPROVEEDOR_AF1.SelectedValue, True)
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        If Me.ButtonEdit1.Text = "" Then
            Me.AsignarMensaje("Elija el archivo a procesar antes de Procesarlo", True)
            Return
        End If
        Me.ProcesarArchivo(Me.OpenFileDialog1.FileName)
    End Sub
End Class
