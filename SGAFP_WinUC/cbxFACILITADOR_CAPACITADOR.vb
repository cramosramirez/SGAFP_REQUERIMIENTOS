Imports System.ComponentModel

''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_WinUC
''' Class	 : WinUC.ddlFACILITADOR_CAPACITADOR
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista Desplegable Windows
''' de la tabla FACILITADOR_CAPACITADOR
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	23/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
Public Class cbxFACILITADOR_CAPACITADOR
    Inherits cbxBase

    Private Sub RecuperarLista()
        Dim miComponente As New cFACILITADOR_CAPACITADOR
        Dim Lista As New listaFACILITADOR_CAPACITADOR

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
            Return
        End If

        Me.DisplayMember = "NOMBRE_FACILITADOR"
        Me.ValueMember = "ID_FACILITADOR"
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
        Dim miComponente As New cFACILITADOR_CAPACITADOR
        Dim Lista As New listaFACILITADOR_CAPACITADOR

        Lista = miComponente.ObtenerListaPorTIPO_PERSONA(ID_TIPO_PERSONA)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
            Return
        End If

        Me.DisplayMember = "NOMBRE_FACILITADOR"
        Me.ValueMember = "ID_FACILITADOR"
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
        Dim miComponente As New cFACILITADOR_CAPACITADOR
        Dim Lista As New listaFACILITADOR_CAPACITADOR

        Lista = miComponente.ObtenerListaPorPROVEEDOR_AF(ID_PROVEEDOR_AF)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
            Return
        End If

        Me.DisplayMember = "NOMBRE_FACILITADOR"
        Me.ValueMember = "ID_FACILITADOR"
        Me.DataSource = Lista

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
        Dim miComponente As New cFACILITADOR_CAPACITADOR
        Dim Lista As New listaFACILITADOR_CAPACITADOR

        Lista = miComponente.ObtenerListaPorMUNICIPIO(CODIGO_MUNICIPIO, CODIGO_REGION, CODIGO_DEPARTAMENTO)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
            Return
        End If

        Me.DisplayMember = "NOMBRE_FACILITADOR"
        Me.ValueMember = "ID_FACILITADOR"
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
        Dim miComponente As New cFACILITADOR_CAPACITADOR
        Dim Lista As New listaFACILITADOR_CAPACITADOR

        Lista = miComponente.ObtenerListaPorDEPARTAMENTO(CODIGO_REGION, CODIGO_DEPARTAMENTO)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
            Return
        End If

        Me.DisplayMember = "NOMBRE_FACILITADOR"
        Me.ValueMember = "ID_FACILITADOR"
        Me.DataSource = Lista

    End Sub

End Class
