Imports System.ComponentModel

''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_WinUC
''' Class	 : WinUC.ddlPROVEEDOR_AF
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista Desplegable Windows
''' de la tabla PROVEEDOR_AF
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	23/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
Public Class cbxPROVEEDOR_AF
    Inherits cbxBase

    Private Sub RecuperarLista(ByVal agregarVacio As Boolean, ByVal agregarTodos As Boolean)
        Dim miComponente As New cPROVEEDOR_AF
        Dim Lista As New listaPROVEEDOR_AF

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
            Return
        End If

        If agregarVacio Then
            Dim lProveedor As New PROVEEDOR_AF
            lProveedor.ID_PROVEEDOR_AF = -1
            lProveedor.NOMBRE_PROVEEDOR = "[Vacio]"
            Lista.Insert(0, lProveedor)
        End If

        If agregarTodos Then
            Dim lProveedor As New PROVEEDOR_AF
            lProveedor.ID_PROVEEDOR_AF = -1
            lProveedor.NOMBRE_PROVEEDOR = "[Todos]"
            Lista.Insert(0, lProveedor)
        End If

        Me.DisplayMember = "NOMBRE_PROVEEDOR"
        Me.ValueMember = "ID_PROVEEDOR_AF"
        Me.DataSource = Lista

    End Sub

    Public Sub RecuperarPorPROGRAMA_FORMACION(ByVal ID_PROGRAMA_FORMACION As Decimal, ByVal agregarVacio As Boolean, ByVal agregarTodos As Boolean)
        Dim miComponente As New cPROVEEDOR_AF
        Dim Lista As New listaPROVEEDOR_AF

        Lista = miComponente.ObtenerListaProveedoresPorProgramaFormacion(ID_PROGRAMA_FORMACION, "NOMBRE_PROVEEDOR")
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
            Return
        End If

        If agregarVacio Then
            Dim lProveedor As New PROVEEDOR_AF
            lProveedor.ID_PROVEEDOR_AF = -1
            lProveedor.NOMBRE_PROVEEDOR = "[Vacio]"
            Lista.Insert(0, lProveedor)
        End If

        If agregarTodos Then
            Dim lProveedor As New PROVEEDOR_AF
            lProveedor.ID_PROVEEDOR_AF = -1
            lProveedor.NOMBRE_PROVEEDOR = "[Todos]"
            Lista.Insert(0, lProveedor)
        End If

        Me.DisplayMember = "NOMBRE_PROVEEDOR"
        Me.ValueMember = "ID_PROVEEDOR_AF"
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
    Public Sub Recuperar(Optional ByVal agregarVacio As Boolean = False, Optional ByVal agregarTodos As Boolean = False)
        RecuperarLista(agregarVacio, agregarTodos)
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el ComboBox filtrada por los parámetros de la Tabla MUNICIPIO .
    ''' </summary>
    ''' <param name="CODIGO_MUNICIPIO"></param>
    ''' <param name="CODIGO_REGION"></param>
    ''' <param name="CODIGO_DEPARTAMENTO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorMUNICIPIO(ByVal CODIGO_MUNICIPIO As String, ByVal CODIGO_REGION As String, ByVal CODIGO_DEPARTAMENTO As String)
        Dim miComponente As New cPROVEEDOR_AF
        Dim Lista As New listaPROVEEDOR_AF

        Lista = miComponente.ObtenerListaPorMUNICIPIO(CODIGO_MUNICIPIO, CODIGO_REGION, CODIGO_DEPARTAMENTO)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
            Return
        End If

        Me.DisplayMember = "NOMBRE_PROVEEDOR"
        Me.ValueMember = "ID_PROVEEDOR_AF"
        Me.DataSource = Lista

    End Sub
   

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el ComboBox filtrada por los parámetros de la Tabla DEPARTAMENTO .
    ''' </summary>
    ''' <param name="CODIGO_REGION"></param>
    ''' <param name="CODIGO_DEPARTAMENTO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorDEPARTAMENTO(ByVal CODIGO_REGION As String, ByVal CODIGO_DEPARTAMENTO As String)
        Dim miComponente As New cPROVEEDOR_AF
        Dim Lista As New listaPROVEEDOR_AF

        Lista = miComponente.ObtenerListaPorDEPARTAMENTO(CODIGO_REGION, CODIGO_DEPARTAMENTO)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
            Return
        End If

        Me.DisplayMember = "NOMBRE_PROVEEDOR"
        Me.ValueMember = "ID_PROVEEDOR_AF"
        Me.DataSource = Lista

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el ComboBox filtrada por los parámetros de la Tabla TIPO_PERSONA .
    ''' </summary>
    ''' <param name="ID_TIPO_PERSONA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorTIPO_PERSONA(ByVal ID_TIPO_PERSONA As Decimal)
        Dim miComponente As New cPROVEEDOR_AF
        Dim Lista As New listaPROVEEDOR_AF

        Lista = miComponente.ObtenerListaPorTIPO_PERSONA(ID_TIPO_PERSONA)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
            Return
        End If

        Me.DisplayMember = "NOMBRE_PROVEEDOR"
        Me.ValueMember = "ID_PROVEEDOR_AF"
        Me.DataSource = Lista

    End Sub

End Class
