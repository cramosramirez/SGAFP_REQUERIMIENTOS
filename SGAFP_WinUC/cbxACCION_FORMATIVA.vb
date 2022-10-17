Imports System.ComponentModel

''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_WinUC
''' Class	 : WinUC.ddlACCION_FORMATIVA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista Desplegable Windows
''' de la tabla ACCION_FORMATIVA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	23/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
Public Class cbxACCION_FORMATIVA
    Inherits cbxBase

    Private Sub RecuperarLista()
        Dim miComponente As New cACCION_FORMATIVA
        Dim Lista As New listaACCION_FORMATIVA

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
            Return
        End If

        Me.DisplayMember = "NOMBRE_ACCION_FORMATIVA"
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
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub Recuperar()
        RecuperarLista()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el ComboBox filtrada por los parámetros de la Tabla OFERTA_FORMATIVA .
    ''' </summary>
    ''' <param name="ID_OFERTA_FORMATIVA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorOFERTA_FORMATIVA(ByVal ID_OFERTA_FORMATIVA As Decimal)
        Dim miComponente As New cACCION_FORMATIVA
        Dim Lista As New listaACCION_FORMATIVA

        Lista = miComponente.ObtenerListaPorOFERTA_FORMATIVA(ID_OFERTA_FORMATIVA)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
            Return
        End If

        Me.DisplayMember = "NOMBRE_ACCION_FORMATIVA"
        Me.ValueMember = "ID_ACCION_FORMATIVA"
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
        Dim miComponente As New cACCION_FORMATIVA
        Dim Lista As New listaACCION_FORMATIVA

        Lista = miComponente.ObtenerListaPorSITIO_CAPACITACION(ID_SITIO_CAPACITACION)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
            Return
        End If

        Me.DisplayMember = "NOMBRE_ACCION_FORMATIVA"
        Me.ValueMember = "ID_ACCION_FORMATIVA"
        Me.DataSource = Lista

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
        Dim miComponente As New cACCION_FORMATIVA
        Dim Lista As New listaACCION_FORMATIVA

        Lista = miComponente.ObtenerListaPorPROVEEDOR_AF(ID_PROVEEDOR_AF)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
            Return
        End If

        Me.DisplayMember = "NOMBRE_ACCION_FORMATIVA"
        Me.ValueMember = "ID_ACCION_FORMATIVA"
        Me.DataSource = Lista

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el ComboBox filtrada por los parámetros de la Tabla CURSO_TEMA .
    ''' </summary>
    ''' <param name="ID_TEMA_CURSO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorCURSO_TEMA(ByVal ID_TEMA_CURSO As Decimal)
        Dim miComponente As New cACCION_FORMATIVA
        Dim Lista As New listaACCION_FORMATIVA

        Lista = miComponente.ObtenerListaPorCURSO_TEMA(ID_TEMA_CURSO)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
            Return
        End If

        Me.DisplayMember = "NOMBRE_ACCION_FORMATIVA"
        Me.ValueMember = "ID_ACCION_FORMATIVA"
        Me.DataSource = Lista

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el ComboBox filtrada por los parámetros de la Tabla EJERCICIO .
    ''' </summary>
    ''' <param name="ID_EJERCICIO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorEJERCICIO(ByVal ID_EJERCICIO As String)
        Dim miComponente As New cACCION_FORMATIVA
        Dim Lista As New listaACCION_FORMATIVA

        Lista = miComponente.ObtenerListaPorEJERCICIO(ID_EJERCICIO)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
            Return
        End If

        Me.DisplayMember = "NOMBRE_ACCION_FORMATIVA"
        Me.ValueMember = "ID_ACCION_FORMATIVA"
        Me.DataSource = Lista

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el ComboBox filtrada por los parámetros de la Tabla ESTADO_ACCION_FORMATIVA .
    ''' </summary>
    ''' <param name="CODIGO_ESTADO_AF"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorESTADO_ACCION_FORMATIVA(ByVal CODIGO_ESTADO_AF As String)
        Dim miComponente As New cACCION_FORMATIVA
        Dim Lista As New listaACCION_FORMATIVA

        Lista = miComponente.ObtenerListaPorESTADO_ACCION_FORMATIVA(CODIGO_ESTADO_AF)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
            Return
        End If

        Me.DisplayMember = "NOMBRE_ACCION_FORMATIVA"
        Me.ValueMember = "ID_ACCION_FORMATIVA"
        Me.DataSource = Lista

    End Sub

End Class
