Imports System.ComponentModel

''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_WinUC
''' Class	 : WinUC.ddlDEPARTAMENTO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista Desplegable Windows
''' de la tabla DEPARTAMENTO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	23/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
Public Class cbxDEPARTAMENTO
    Inherits cbxBase

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el ComboBox filtrada por los parámetros de la Tabla Padre.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	11/10/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarListaPorProgramaFormacion(ByVal ID_PROGRAMA_FORMACION As Decimal, Optional ByVal agregarTodos As Boolean = False, Optional ByVal agregarVacio As Boolean = False)
        Dim miComponente As New cDEPARTAMENTO
        Dim Lista As New listaDEPARTAMENTO

        If ID_PROGRAMA_FORMACION = Enumeradores.ProgramasFormacion.PATI_BM Then
            Lista = miComponente.ObtenerListaParaPATIPorFuente(Enumeradores.FuenteFinanciamientoPATI.PATI_BM)
        ElseIf ID_PROGRAMA_FORMACION = Enumeradores.ProgramasFormacion.PATI_USAID Then
            Lista = miComponente.ObtenerListaParaPATIPorFuente(Enumeradores.FuenteFinanciamientoPATI.PATI_USAID)
        End If
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
        End If

        If agregarVacio Then
            Dim lEntidad As New DEPARTAMENTO
            lEntidad.CODIGO_DEPARTAMENTO = ""
            lEntidad.NOMBRE = "[Vacio]"
            Lista.Insert(0, lEntidad)
        End If

        If agregarTodos Then
            Dim lEntidad As New DEPARTAMENTO
            lEntidad.CODIGO_DEPARTAMENTO = ""
            lEntidad.NOMBRE = "[Todos]"
            Lista.Insert(0, lEntidad)
        End If

        Me.DisplayMember = "NOMBRE"
        Me.ValueMember = "CODIGO_DEPARTAMENTO"
        Me.DataSource = Lista

    End Sub

    Private Sub RecuperarLista(Optional ByVal agregarTodos As Boolean = False, Optional ByVal agregarVacio As Boolean = False)
        Dim miComponente As New cDEPARTAMENTO
        Dim Lista As New listaDEPARTAMENTO

        Lista = miComponente.ObtenerLista(False, False, "NOMBRE")
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
        End If

        If agregarVacio Then
            Dim lEntidad As New DEPARTAMENTO
            lEntidad.CODIGO_DEPARTAMENTO = ""
            lEntidad.NOMBRE = "[Vacio]"
            Lista.Insert(0, lEntidad)
        End If

        If agregarTodos Then
            Dim lEntidad As New DEPARTAMENTO
            lEntidad.CODIGO_DEPARTAMENTO = ""
            lEntidad.NOMBRE = "[Todos]"
            Lista.Insert(0, lEntidad)
        End If

        Me.DisplayMember = "NOMBRE"
        Me.ValueMember = "CODIGO_DEPARTAMENTO"
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
    Public Sub Recuperar(Optional ByVal agregarTodos As Boolean = False, Optional ByVal agregarVacio As Boolean = False)
        RecuperarLista(agregarTodos, agregarVacio)
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el ComboBox filtrada por los parámetros de la Tabla REGION .
    ''' </summary>
    ''' <param name="CODIGO_REGION"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorREGION(ByVal CODIGO_REGION As String)
        Dim miComponente As New cDEPARTAMENTO
        Dim Lista As New listaDEPARTAMENTO

        Lista = miComponente.ObtenerListaPorREGION(CODIGO_REGION)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
            Return
        End If

        Me.DisplayMember = "NOMBRE"
        Me.ValueMember = "CODIGO_DEPARTAMENTO"
        Me.DataSource = Lista

    End Sub

End Class
