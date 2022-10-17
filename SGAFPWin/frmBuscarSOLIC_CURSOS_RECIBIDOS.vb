Public Class frmBuscarSOLIC_CURSOS_RECIBIDOS

    Public Event Seleccionado(ByVal ID_CURSO_RECIBIDO As Decimal) 

    Private Sub UcBuscarSOLIC_CURSOS_RECIBIDOS1_Seleccionado(ByVal ID_CURSO_RECIBIDO As Decimal) Handles UcBuscarSOLIC_CURSOS_RECIBIDOS1.Seleccionado
        RaiseEvent Seleccionado(ID_CURSO_RECIBIDO)
    End Sub

End Class
