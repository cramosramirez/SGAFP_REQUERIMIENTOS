Imports System.ComponentModel

''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_WinUC
''' Class	 : WinUC.ddlETAPA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista Desplegable Windows
''' de la tabla ETAPA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	23/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
Public Class cbxETAPA
    Inherits cbxBase

    Private Sub RecuperarLista(ByVal CODIGO_PROCESO As String)
        Dim miComponente As New cETAPA
        Dim Lista As New listaETAPA

        Lista = miComponente.ObtenerLista(CODIGO_PROCESO)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
            Return
        End If

        Me.DisplayMember = "UNIDAD_DE_TIEMPO"
        Me.ValueMember = "CODIGO_ETAPA"
        Me.DataSource = Lista

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el ComboBox filtrada por los parámetros de la Tabla Padre.
    ''' </summary>
    ''' <param name="CODIGO_PROCESO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub Recuperar(ByVal CODIGO_PROCESO As String)
        RecuperarLista(CODIGO_PROCESO)
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
        Dim miComponente As New cETAPA
        Dim Lista As New listaETAPA

        Lista = miComponente.ObtenerListaPorPROCESO(CODIGO_PROCESO)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
            Return
        End If

        Me.DisplayMember = "UNIDAD_DE_TIEMPO"
        Me.ValueMember = "CODIGO_ETAPA"
        Me.DataSource = Lista

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el ComboBox filtrada por los parámetros de la Tabla ESTADO_SOLICITUD .
    ''' </summary>
    ''' <param name="ID_ESTADO_SOLICITUD"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorESTADO_SOLICITUD(ByVal ID_ESTADO_SOLICITUD As Decimal)
        Dim miComponente As New cETAPA
        Dim Lista As New listaETAPA

        Lista = miComponente.ObtenerListaPorESTADO_SOLICITUD(ID_ESTADO_SOLICITUD)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
            Return
        End If

        Me.DisplayMember = "UNIDAD_DE_TIEMPO"
        Me.ValueMember = "CODIGO_ETAPA"
        Me.DataSource = Lista

    End Sub

End Class
