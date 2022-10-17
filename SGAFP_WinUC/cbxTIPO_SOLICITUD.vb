Imports System.ComponentModel

''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_WinUC
''' Class	 : WinUC.ddlTIPO_SOLICITUD
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista Desplegable Windows
''' de la tabla TIPO_SOLICITUD
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	23/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
Public Class cbxTIPO_SOLICITUD
    Inherits cbxBase

    Private Sub RecuperarLista()
        Dim miComponente As New cTIPO_SOLICITUD
        Dim Lista As New listaTIPO_SOLICITUD

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
            Return
        End If

        Me.DisplayMember = "TIPO_SOLICITUD"
        Me.ValueMember = "ID_TIPO_SOLICITUD"
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
    ''' Función que Popula el ComboBox filtrada por los parámetros de la Tabla PROCESO .
    ''' </summary>
    ''' <param name="CODIGO_PROCESO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorPROCESO(ByVal CODIGO_PROCESO As String)
        Dim miComponente As New cTIPO_SOLICITUD
        Dim Lista As New listaTIPO_SOLICITUD

        Lista = miComponente.ObtenerListaPorPROCESO(CODIGO_PROCESO)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
            Return
        End If

        Me.DisplayMember = "TIPO_SOLICITUD"
        Me.ValueMember = "ID_TIPO_SOLICITUD"
        Me.DataSource = Lista
    End Sub

End Class
