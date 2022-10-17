Imports System.ComponentModel

''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_WinUC
''' Class	 : WinUC.ddlUSUARIO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista Desplegable Windows
''' de la tabla USUARIO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	23/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
Public Class cbxUSUARIO
    Inherits cbxBase

    Private Sub RecuperarLista()
        Dim miComponente As New cUSUARIO
        Dim Lista As New listaUSUARIO

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
            Return
        End If

        Me.DisplayMember = "USUARIO"
        Me.ValueMember = "USUARIO"
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
    ''' Función que Popula el ComboBox filtrada por los parámetros de la Tabla PROVEEDOR_AF .
    ''' </summary>
    ''' <param name="ID_PROVEEDOR_AF"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorPROVEEDOR_AF(ByVal ID_PROVEEDOR_AF As Decimal)
        Dim miComponente As New cUSUARIO
        Dim Lista As New listaUSUARIO

        Lista = miComponente.ObtenerListaPorPROVEEDOR_AF(ID_PROVEEDOR_AF)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
            Return
        End If

        Me.DisplayMember = "USUARIO"
        Me.ValueMember = "USUARIO"
        Me.DataSource = Lista

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el ComboBox filtrada por los parámetros de la Tabla SITIO_CAPACITACION .
    ''' </summary>
    ''' <param name="ID_SITIO_CAPACITACION"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorSITIO_CAPACITACION(ByVal ID_SITIO_CAPACITACION As Decimal)
        Dim miComponente As New cUSUARIO
        Dim Lista As New listaUSUARIO

        Lista = miComponente.ObtenerListaPorSITIO_CAPACITACION(ID_SITIO_CAPACITACION)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
            Return
        End If

        Me.DisplayMember = "USUARIO"
        Me.ValueMember = "USUARIO"
        Me.DataSource = Lista

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
        Dim miComponente As New cUSUARIO
        Dim Lista As New listaUSUARIO

        Lista = miComponente.ObtenerListaPorPARTICIPANTE(ID_PARTICIPANTE)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
            Return
        End If

        Me.DisplayMember = "USUARIO"
        Me.ValueMember = "USUARIO"
        Me.DataSource = Lista

    End Sub

End Class
