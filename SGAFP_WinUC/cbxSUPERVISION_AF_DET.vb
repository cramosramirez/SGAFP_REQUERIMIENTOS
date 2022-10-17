Imports System.ComponentModel

''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_WinUC
''' Class	 : WinUC.ddlSUPERVISION_AF_DET
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista Desplegable Windows
''' de la tabla SUPERVISION_AF_DET
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	23/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
Public Class cbxSUPERVISION_AF_DET
    Inherits cbxBase

    Private Sub RecuperarLista()
        Dim miComponente As New cSUPERVISION_AF_DET
        Dim Lista As New listaSUPERVISION_AF_DET

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
            Return
        End If

        Me.DisplayMember = "COMENTARIOS"
        Me.ValueMember = "ID_SUPERVISION_DET"
        Me.DataSource = Lista

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el ComboBox filtrada por los parámetros de la Tabla Padre.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub Recuperar()
        RecuperarLista()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el ComboBox filtrada por los parámetros de la Tabla LISTA_SUPERVISION_AF .
    ''' </summary>
    ''' <param name="ID_LISTA_SUPERVISION"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorLISTA_SUPERVISION_AF(ByVal ID_LISTA_SUPERVISION As Decimal)
        Dim miComponente As New cSUPERVISION_AF_DET
        Dim Lista As New listaSUPERVISION_AF_DET

        Lista = miComponente.ObtenerListaPorLISTA_SUPERVISION_AF(ID_LISTA_SUPERVISION)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
            Return
        End If

        Me.DisplayMember = "COMENTARIOS"
        Me.ValueMember = "ID_SUPERVISION_DET"
        Me.DataSource = Lista

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el ComboBox filtrada por los parámetros de la Tabla SUPERVISION_AF .
    ''' </summary>
    ''' <param name="ID_SUPERVISION_AF"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorSUPERVISION_AF(ByVal ID_SUPERVISION_AF As Decimal)
        Dim miComponente As New cSUPERVISION_AF_DET
        Dim Lista As New listaSUPERVISION_AF_DET

        Lista = miComponente.ObtenerListaPorSUPERVISION_AF(ID_SUPERVISION_AF)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
            Return
        End If

        Me.DisplayMember = "COMENTARIOS"
        Me.ValueMember = "ID_SUPERVISION_DET"
        Me.DataSource = Lista

    End Sub

End Class
