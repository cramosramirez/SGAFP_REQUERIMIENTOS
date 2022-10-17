Imports System.ComponentModel

''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_WinUC
''' Class	 : WinUC.ddlACCION_FORMATIVA_DETALLE
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista Desplegable Windows
''' de la tabla ACCION_FORMATIVA_DETALLE
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	05/10/2012	Created
''' </history>
''' -----------------------------------------------------------------------------
Public Class cbxACCION_FORMATIVA_DETALLE
    Inherits cbxBase

    Private Sub RecuperarLista()
        Dim miComponente As New cACCION_FORMATIVA_DETALLE
        Dim Lista As New listaACCION_FORMATIVA_DETALLE

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
            Return
        End If

        Me.DisplayMember = "NO_CONVOCATORIA"
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
        Dim miComponente As New cACCION_FORMATIVA_DETALLE
        Dim Lista As New listaACCION_FORMATIVA_DETALLE

        Lista = miComponente.ObtenerListaPorACCION_FORMATIVA(ID_ACCION_FORMATIVA)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
            Return
        End If

        Me.DisplayMember = "NO_CONVOCATORIA"
        Me.ValueMember = "ID_ACCION_FORMATIVA"
        Me.DataSource = Lista

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el ComboBox filtrada por los parámetros de la Tabla PROGRAMA_FORMACION .
    ''' </summary>
    ''' <param name="ID_PROGRAMA_FORMACION"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorPROGRAMA_FORMACION(ByVal ID_PROGRAMA_FORMACION As Decimal)
        Dim miComponente As New cACCION_FORMATIVA_DETALLE
        Dim Lista As New listaACCION_FORMATIVA_DETALLE

        Lista = miComponente.ObtenerListaPorPROGRAMA_FORMACION(ID_PROGRAMA_FORMACION)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
            Return
        End If

        Me.DisplayMember = "NO_CONVOCATORIA"
        Me.ValueMember = "ID_ACCION_FORMATIVA"
        Me.DataSource = Lista

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el ComboBox filtrada por los parámetros de la Tabla MODALIDAD_DE_FORMACION .
    ''' </summary>
    ''' <param name="ID_MODALIDAD_FORMACION"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorMODALIDAD_DE_FORMACION(ByVal ID_MODALIDAD_FORMACION As Decimal)
        Dim miComponente As New cACCION_FORMATIVA_DETALLE
        Dim Lista As New listaACCION_FORMATIVA_DETALLE

        Lista = miComponente.ObtenerListaPorMODALIDAD_DE_FORMACION(ID_MODALIDAD_FORMACION)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
            Return
        End If

        Me.DisplayMember = "NO_CONVOCATORIA"
        Me.ValueMember = "ID_ACCION_FORMATIVA"
        Me.DataSource = Lista

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el ComboBox filtrada por los parámetros de la Tabla CONTRATO_PROVEEDOR_AF .
    ''' </summary>
    ''' <param name="ID_CONTRATO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorCONTRATO_PROVEEDOR_AF(ByVal ID_CONTRATO As Decimal)
        Dim miComponente As New cACCION_FORMATIVA_DETALLE
        Dim Lista As New listaACCION_FORMATIVA_DETALLE

        Lista = miComponente.ObtenerListaPorCONTRATO_PROVEEDOR_AF(ID_CONTRATO)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
            Return
        End If

        Me.DisplayMember = "NO_CONVOCATORIA"
        Me.ValueMember = "ID_ACCION_FORMATIVA"
        Me.DataSource = Lista

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el ComboBox filtrada por los parámetros de la Tabla FUENTE_FINANCIAMIENTO .
    ''' </summary>
    ''' <param name="ID_FUENTE"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorFUENTE_FINANCIAMIENTO(ByVal ID_FUENTE As Decimal)
        Dim miComponente As New cACCION_FORMATIVA_DETALLE
        Dim Lista As New listaACCION_FORMATIVA_DETALLE

        Lista = miComponente.ObtenerListaPorFUENTE_FINANCIAMIENTO(ID_FUENTE)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
            Return
        End If

        Me.DisplayMember = "NO_CONVOCATORIA"
        Me.ValueMember = "ID_ACCION_FORMATIVA"
        Me.DataSource = Lista

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el ComboBox filtrada por los parámetros de la Tabla DEPARTAMENTO .
    ''' </summary>
    ''' <param name="CODIGO_DEPARTAMENTO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorDEPARTAMENTO(ByVal CODIGO_DEPARTAMENTO As String)
        Dim miComponente As New cACCION_FORMATIVA_DETALLE
        Dim Lista As New listaACCION_FORMATIVA_DETALLE

        Lista = miComponente.ObtenerListaPorDEPARTAMENTO(CODIGO_DEPARTAMENTO)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
            Return
        End If

        Me.DisplayMember = "NO_CONVOCATORIA"
        Me.ValueMember = "ID_ACCION_FORMATIVA"
        Me.DataSource = Lista

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el ComboBox filtrada por los parámetros de la Tabla MUNICIPIO .
    ''' </summary>
    ''' <param name="CODIGO_DEPARTAMENTO"></param>
    ''' <param name="CODIGO_MUNICIPIO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorMUNICIPIO(ByVal CODIGO_DEPARTAMENTO As String, ByVal CODIGO_MUNICIPIO As String)
        Dim miComponente As New cACCION_FORMATIVA_DETALLE
        Dim Lista As New listaACCION_FORMATIVA_DETALLE

        Lista = miComponente.ObtenerListaPorMUNICIPIO(CODIGO_DEPARTAMENTO, CODIGO_MUNICIPIO)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
            Return
        End If

        Me.DisplayMember = "NO_CONVOCATORIA"
        Me.ValueMember = "ID_ACCION_FORMATIVA"
        Me.DataSource = Lista

    End Sub

End Class
