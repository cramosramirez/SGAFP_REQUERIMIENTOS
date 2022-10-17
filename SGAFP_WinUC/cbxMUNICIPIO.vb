Imports System.ComponentModel

''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_WinUC
''' Class	 : WinUC.ddlMUNICIPIO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista Desplegable Windows
''' de la tabla MUNICIPIO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	23/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
Public Class cbxMUNICIPIO
    Inherits cbxBase

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el ComboBox filtrada por los parámetros de la Tabla Padre.
    ''' </summary>
    ''' <param name="ID_PROGRAMA_FORMACION"></param>
    ''' <param name="CODIGO_DEPARTAMENTO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	11/10/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarListaPorDepartamentoProgramaFormacion(ByVal ID_PROGRAMA_FORMACION As Decimal, ByVal CODIGO_DEPARTAMENTO As String, Optional ByVal agregarTodos As Boolean = False, Optional ByVal agregarVacio As Boolean = False)
        Dim miComponente As New cMUNICIPIO
        Dim Lista As New listaMUNICIPIO

        If ID_PROGRAMA_FORMACION = Enumeradores.ProgramasFormacion.PATI_BM Then
            Lista = miComponente.ObtenerListaParaPATIPorDEPARTAMENTO_FUENTE(Enumeradores.FuenteFinanciamientoPATI.PATI_BM, CODIGO_DEPARTAMENTO)
        ElseIf ID_PROGRAMA_FORMACION = Enumeradores.ProgramasFormacion.PATI_USAID Then
            Lista = miComponente.ObtenerListaParaPATIPorDEPARTAMENTO_FUENTE(Enumeradores.FuenteFinanciamientoPATI.PATI_USAID, CODIGO_DEPARTAMENTO)
        End If

        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
        End If

        If agregarVacio Then
            Dim lEntidad As New MUNICIPIO
            lEntidad.CODIGO_MUNICIPIO = ""
            lEntidad.NOMBRE = "[Vacio]"
            Lista.Insert(0, lEntidad)
        End If

        If agregarTodos Then
            Dim lEntidad As New MUNICIPIO
            lEntidad.CODIGO_MUNICIPIO = ""
            lEntidad.NOMBRE = "[Todos]"
            Lista.Insert(0, lEntidad)
        End If

        Me.DisplayMember = "NOMBRE"
        Me.ValueMember = "CODIGO_MUNICIPIO"
        Me.DataSource = Lista

    End Sub

    Private Sub RecuperarLista(ByVal CODIGO_DEPARTAMENTO As String, Optional ByVal agregarTodos As Boolean = False, Optional ByVal agregarVacio As Boolean = False)
        Dim miComponente As New cMUNICIPIO
        Dim Lista As New listaMUNICIPIO

        Lista = miComponente.ObtenerLista(CODIGO_DEPARTAMENTO, False, False, "NOMBRE")
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
        End If

        If agregarVacio Then
            Dim lEntidad As New MUNICIPIO
            lEntidad.CODIGO_MUNICIPIO = ""
            lEntidad.NOMBRE = "[Vacio]"
            Lista.Insert(0, lEntidad)
        End If

        If agregarTodos Then
            Dim lEntidad As New MUNICIPIO
            lEntidad.CODIGO_MUNICIPIO = ""
            lEntidad.NOMBRE = "[Todos]"
            Lista.Insert(0, lEntidad)
        End If

        Me.DisplayMember = "NOMBRE"
        Me.ValueMember = "CODIGO_MUNICIPIO"
        Me.DataSource = Lista

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el ComboBox filtrada por los parámetros de la Tabla Padre.
    ''' </summary>
    ''' <param name="CODIGO_DEPARTAMENTO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub Recuperar(ByVal CODIGO_DEPARTAMENTO As String, Optional ByVal agregarTodos As Boolean = False, Optional ByVal agregarVacio As Boolean = False)
        RecuperarLista(CODIGO_DEPARTAMENTO, agregarTodos, agregarVacio)
    End Sub


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el ComboBox filtrada por los parámetros de la Tabla DEPARTAMENTO .
    ''' </summary>
    ''' <param name="CODIGO_DEPARTAMENTO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorDEPARTAMENTO(ByVal CODIGO_DEPARTAMENTO As String)
        Dim miComponente As New cMUNICIPIO
        Dim Lista As New listaMUNICIPIO

        Lista = miComponente.ObtenerListaPorDEPARTAMENTO(CODIGO_DEPARTAMENTO, False, False, "NOMBRE")
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
            Return
        End If

        Me.DisplayMember = "NOMBRE"
        Me.ValueMember = "CODIGO_MUNICIPIO"
        Me.DataSource = Lista

    End Sub

End Class
