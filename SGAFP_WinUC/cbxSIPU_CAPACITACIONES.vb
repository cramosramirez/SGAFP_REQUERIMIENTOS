Imports System.ComponentModel

''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_WinUC
''' Class	 : WinUC.ddlSIPU_CAPACITACIONES
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista Desplegable Windows
''' de la tabla SIPU_CAPACITACIONES
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	29/10/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
Public Class cbxSIPU_CAPACITACIONES
    Inherits cbxBase

    Private Sub RecuperarLista()
        Dim miComponente As New cSIPU_CAPACITACIONES
        Dim Lista As New listaSIPU_CAPACITACIONES

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
            Return
        End If

        Me.DisplayMember = "DESCRIPCION"
        Me.ValueMember = "IDCAPACITACION"
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
    ''' Función que Popula el ComboBox filtrada por los parámetros de la Tabla SIPU_TIPOCAPACITACIONES .
    ''' </summary>
    ''' <param name="IDTIPOCAPACITACION"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorSIPU_TIPOCAPACITACIONES(ByVal IDTIPOCAPACITACION As Decimal)
        Dim miComponente As New cSIPU_CAPACITACIONES
        Dim Lista As New listaSIPU_CAPACITACIONES

        Lista = miComponente.ObtenerListaPorSIPU_TIPOCAPACITACIONES(IDTIPOCAPACITACION)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
            Return
        End If

        Me.DisplayMember = "DESCRIPCION"
        Me.ValueMember = "IDCAPACITACION"
        Me.DataSource = Lista

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el ComboBox filtrada por los parámetros de la Tabla SIPU_MUNICIPIO .
    ''' </summary>
    ''' <param name="IDMUNICIPIO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorSIPU_MUNICIPIO(ByVal IDMUNICIPIO As Decimal)
        Dim miComponente As New cSIPU_CAPACITACIONES
        Dim Lista As New listaSIPU_CAPACITACIONES

        Lista = miComponente.ObtenerListaPorSIPU_MUNICIPIO(IDMUNICIPIO)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
            Return
        End If

        Me.DisplayMember = "DESCRIPCION"
        Me.ValueMember = "IDCAPACITACION"
        Me.DataSource = Lista

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el ComboBox filtrada por los parámetros de la Tabla SIPU_GENERACION .
    ''' </summary>
    ''' <param name="ID_GENERACION"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorSIPU_GENERACION(ByVal ID_GENERACION As Decimal)
        Dim miComponente As New cSIPU_CAPACITACIONES
        Dim Lista As New listaSIPU_CAPACITACIONES

        Lista = miComponente.ObtenerListaPorSIPU_GENERACION(ID_GENERACION)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
            Return
        End If

        Me.DisplayMember = "DESCRIPCION"
        Me.ValueMember = "IDCAPACITACION"
        Me.DataSource = Lista

    End Sub

End Class
