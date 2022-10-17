Imports System.ComponentModel

''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_WinUC
''' Class	 : WinUC.ddlHALLAZGO_SUPERVISION
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista Desplegable Windows
''' de la tabla HALLAZGO_SUPERVISION
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	23/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
Public Class cbxHALLAZGO_SUPERVISION
    Inherits cbxBase

    Private Sub RecuperarLista()
        Dim miComponente As New cHALLAZGO_SUPERVISION
        Dim Lista As New listaHALLAZGO_SUPERVISION

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
            Return
        End If

        Me.DisplayMember = "HALLAZGO_SUPERVISION"
        Me.ValueMember = "ID_HALLAZGO_SUPERVISION"
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
    ''' Función que Popula el ComboBox filtrada por los parámetros de la Tabla AREA_SUPERVISION .
    ''' </summary>
    ''' <param name="ID_AREA_SUPERVISION"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorAREA_SUPERVISION(ByVal ID_AREA_SUPERVISION As Decimal)
        Dim miComponente As New cHALLAZGO_SUPERVISION
        Dim Lista As New listaHALLAZGO_SUPERVISION

        Lista = miComponente.ObtenerListaPorAREA_SUPERVISION(ID_AREA_SUPERVISION)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
            Return
        End If

        Me.DisplayMember = "HALLAZGO_SUPERVISION"
        Me.ValueMember = "ID_HALLAZGO_SUPERVISION"
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
        Dim miComponente As New cHALLAZGO_SUPERVISION
        Dim Lista As New listaHALLAZGO_SUPERVISION

        Lista = miComponente.ObtenerListaPorSUPERVISION_AF(ID_SUPERVISION_AF)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
            Return
        End If

        Me.DisplayMember = "HALLAZGO_SUPERVISION"
        Me.ValueMember = "ID_HALLAZGO_SUPERVISION"
        Me.DataSource = Lista

    End Sub

End Class
