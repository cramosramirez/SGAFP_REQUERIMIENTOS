Imports System.ComponentModel

''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_WinUC
''' Class	 : WinUC.ddlTERMINO_REFERENCIA_AF
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista Desplegable Windows
''' de la tabla TERMINO_REFERENCIA_AF
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	05/10/2012	Created
''' </history>
''' -----------------------------------------------------------------------------
Public Class cbxTERMINO_REFERENCIA_AF
    Inherits cbxBase

    Private Sub RecuperarLista()
        Dim miComponente As New cTERMINO_REFERENCIA_AF
        Dim Lista As New listaTERMINO_REFERENCIA_AF

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
            Return
        End If

        Me.DisplayMember = "RESOLUCION"
        Me.ValueMember = "ID_ACCION_FORMATIVA"
        Me.DataSource = Lista

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el ComboBox filtrada por los parámetros de la Tabla Padre.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub Recuperar()
        RecuperarLista()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el ComboBox filtrada por los parámetros de la Tabla ACCION_FORMATIVA .
    ''' </summary>
    ''' <param name="ID_ACCION_FORMATIVA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorACCION_FORMATIVA(ByVal ID_ACCION_FORMATIVA As Decimal)
        Dim miComponente As New cTERMINO_REFERENCIA_AF
        Dim Lista As New listaTERMINO_REFERENCIA_AF

        Lista = miComponente.ObtenerListaPorACCION_FORMATIVA(ID_ACCION_FORMATIVA)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
            Return
        End If

        Me.DisplayMember = "RESOLUCION"
        Me.ValueMember = "ID_ACCION_FORMATIVA"
        Me.DataSource = Lista

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el ComboBox filtrada por los parámetros de la Tabla SOLICITUD_CAPACITACION .
    ''' </summary>
    ''' <param name="ID_SOLICITUD"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorSOLICITUD_CAPACITACION(ByVal ID_SOLICITUD As Decimal)
        Dim miComponente As New cTERMINO_REFERENCIA_AF
        Dim Lista As New listaTERMINO_REFERENCIA_AF

        Lista = miComponente.ObtenerListaPorSOLICITUD_CAPACITACION(ID_SOLICITUD)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
            Return
        End If

        Me.DisplayMember = "RESOLUCION"
        Me.ValueMember = "ID_ACCION_FORMATIVA"
        Me.DataSource = Lista

    End Sub

End Class
