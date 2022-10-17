Imports System.ComponentModel

''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_WinUC
''' Class	 : WinUC.ddlSIPU_DETALLECAPACITACIONES
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista Desplegable Windows
''' de la tabla SIPU_DETALLECAPACITACIONES
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	29/10/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
Public Class cbxSIPU_DETALLECAPACITACIONES
    Inherits cbxBase

    Private Sub RecuperarLista()
        Dim miComponente As New cSIPU_DETALLECAPACITADO
        Dim Lista As New ListaSIPU_DETALLECAPACITADO

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
            Return
        End If

        Me.DisplayMember = "CONVENIO"
        Me.ValueMember = "IDDETALLECAPACITACION"
        Me.DataSource = Lista

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el ComboBox filtrada por los parámetros de la Tabla Padre.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub Recuperar()
        RecuperarLista()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el ComboBox filtrada por los parámetros de la Tabla SIPU_CAPACITACIONES .
    ''' </summary>
    ''' <param name="IDCAPACITACION"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorSIPU_CAPACITACIONES(ByVal IDCAPACITACION As Decimal)
        Dim miComponente As New cSIPU_DETALLECAPACITADO
        Dim Lista As New ListaSIPU_DETALLECAPACITADO

        Lista = miComponente.ObtenerListaPorSIPU_CAPACITACIONES(IDCAPACITACION)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
            Return
        End If

        Me.DisplayMember = "CONVENIO"
        Me.ValueMember = "IDDETALLECAPACITACION"
        Me.DataSource = Lista

    End Sub

End Class
