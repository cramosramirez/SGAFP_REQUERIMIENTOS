Imports System.ComponentModel

Public Class cbxTIPO_ADJUDICACION
    Inherits cbxBase

    Private Sub RecuperarLista()
        Dim miComponente As New cTIPO_ADJUDICACION
        Dim Lista As New listaTIPO_ADJUDICACION

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
            Return
        End If

        Me.DisplayMember = "NOMBRE_ADJ"
        Me.ValueMember = "ID_TIPO_ADJ"
        Me.DataSource = Lista

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el ComboBox filtrada por los parámetros de la Tabla Padre.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	11/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub Recuperar()
        RecuperarLista()
    End Sub

End Class
