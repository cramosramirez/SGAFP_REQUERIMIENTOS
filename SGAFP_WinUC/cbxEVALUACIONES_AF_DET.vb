Imports System.ComponentModel

''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_WinUC
''' Class	 : WinUC.ddlEVALUACIONES_AF_DET
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista Desplegable Windows
''' de la tabla EVALUACIONES_AF_DET
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	23/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
Public Class cbxEVALUACIONES_AF_DET
    Inherits cbxBase

    Private Sub RecuperarLista()
        Dim miComponente As New cEVALUACIONES_AF_DET
        Dim Lista As New listaEVALUACIONES_AF_DET

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
            Return
        End If

        Me.DisplayMember = "NOTA_OBTENIDA"
        Me.ValueMember = "ID_EVALUACION_DET"
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
    ''' Función que Popula el ComboBox filtrada por los parámetros de la Tabla PARTICIPANTE .
    ''' </summary>
    ''' <param name="ID_PARTICIPANTE"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorPARTICIPANTE(ByVal ID_PARTICIPANTE As Decimal)
        Dim miComponente As New cEVALUACIONES_AF_DET
        Dim Lista As New listaEVALUACIONES_AF_DET

        Lista = miComponente.ObtenerListaPorPARTICIPANTE(ID_PARTICIPANTE)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
            Return
        End If

        Me.DisplayMember = "NOTA_OBTENIDA"
        Me.ValueMember = "ID_EVALUACION_DET"
        Me.DataSource = Lista

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el ComboBox filtrada por los parámetros de la Tabla EVALUACION_AF .
    ''' </summary>
    ''' <param name="ID_EVALUACION_AF"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorEVALUACION_AF(ByVal ID_EVALUACION_AF As Decimal)
        Dim miComponente As New cEVALUACIONES_AF_DET
        Dim Lista As New listaEVALUACIONES_AF_DET

        Lista = miComponente.ObtenerListaPorEVALUACION_AF(ID_EVALUACION_AF)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
            Return
        End If

        Me.DisplayMember = "NOTA_OBTENIDA"
        Me.ValueMember = "ID_EVALUACION_DET"
        Me.DataSource = Lista

    End Sub

End Class
