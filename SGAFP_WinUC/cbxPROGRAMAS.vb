Imports System.ComponentModel
Imports SIFP.BL
Imports SIFP.EL

''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_WinUC
''' Class	 : WinUC.ddlPROGRAMA_FORMACION
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista Desplegable Windows
''' de la tabla PROGRAMA_FORMACION
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	05/10/2012	Created
''' </history>
''' -----------------------------------------------------------------------------
Public Class cbxPROGRAMAS
    Inherits cbxBase

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el ComboBox filtrada por los parámetros de la Tabla Padre.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	09/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub Recuperar(Optional ByVal agregarVacio As Boolean = False, Optional ByVal agregarTodos As Boolean = False)
        RecuperarLista(agregarVacio, agregarTodos)
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el ComboBox filtrada por los parámetros de la Tabla Padre.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	18/01/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorId(ByVal CODIGO_PROGRAMA As String)
        Dim miComponente As New cProgramas
        Dim Lista As New listaProgramas
        Dim lEntidad As Programas

        lEntidad = miComponente.ObtenerProgramas(CODIGO_PROGRAMA)
        If lEntidad Is Nothing Then
            Me.DataSource = Nothing
            Return
        End If
        Lista.Add(lEntidad)

        Me.DisplayMember = "NOMBRE_PROGRAMA"
        Me.ValueMember = "CODIGO_PROGRAMA"
        Me.DataSource = Lista
    End Sub

    Private Sub RecuperarLista()
        Dim miComponente As New cProgramas
        Dim Lista As New listaProgramas

        Lista = miComponente.ObtenerListaActivos("NOMBRE_PROGRAMA")
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
            Return
        End If

        Me.DisplayMember = "NOMBRE_PROGRAMA"
        Me.ValueMember = "CODIGO_PROGRAMA"
        Me.DataSource = Lista
    End Sub

    Public Sub RecuperarListaAID(ByVal agregarVacio As Boolean, ByVal agregarTodos As Boolean)
        Dim miComponente As New cProgramas
        Dim Lista As New listaProgramas

        Lista = miComponente.ObtenerListaActivosPATI_AID("NOMBRE_PROGRAMA")
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
            Return
        End If

        If agregarVacio Then
            Dim lProgramaFormacion As New Programas
            lProgramaFormacion.codigo_programa = -1
            lProgramaFormacion.nombre_programa = "[Vacio]"
            Lista.Insert(0, lProgramaFormacion)
        End If

        If agregarTodos Then
            Dim lProgramaFormacion As New Programas
            lProgramaFormacion.codigo_programa = -1
            lProgramaFormacion.nombre_programa = "[Todos]"
            Lista.Insert(0, lProgramaFormacion)
        End If

        Me.DisplayMember = "NOMBRE_PROGRAMA"
        Me.ValueMember = "CODIGO_PROGRAMA"
        Me.DataSource = Lista
    End Sub

    Public Sub RecuperarListaBM(ByVal agregarVacio As Boolean, ByVal agregarTodos As Boolean)
        Dim miComponente As New cProgramas
        Dim Lista As New listaProgramas

        Lista = miComponente.ObtenerListaActivosPATI_BM("NOMBRE_PROGRAMA")
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
            Return
        End If

        If agregarVacio Then
            Dim lProgramaFormacion As New Programas
            lProgramaFormacion.codigo_programa = -1
            lProgramaFormacion.nombre_programa = "[Vacio]"
            Lista.Insert(0, lProgramaFormacion)
        End If

        If agregarTodos Then
            Dim lProgramaFormacion As New Programas
            lProgramaFormacion.codigo_programa = -1
            lProgramaFormacion.nombre_programa = "[Todos]"
            Lista.Insert(0, lProgramaFormacion)
        End If

        Me.DisplayMember = "NOMBRE_PROGRAMA"
        Me.ValueMember = "CODIGO_PROGRAMA"
        Me.DataSource = Lista
    End Sub

    Private Sub RecuperarLista(ByVal agregarVacio As Boolean, ByVal agregarTodos As Boolean)
        Dim miComponente As New cProgramas
        Dim Lista As New listaProgramas

        Lista = miComponente.ObtenerListaActivos("NOMBRE_PROGRAMA")
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
            Return
        End If

        If agregarVacio Then
            Dim lProgramaFormacion As New Programas
            lProgramaFormacion.codigo_programa = -1
            lProgramaFormacion.nombre_programa = "[Vacio]"
            Lista.Insert(0, lProgramaFormacion)
        End If

        If agregarTodos Then
            Dim lProgramaFormacion As New Programas
            lProgramaFormacion.codigo_programa = -1
            lProgramaFormacion.nombre_programa = "[Todos]"
            Lista.Insert(0, lProgramaFormacion)
        End If

        Me.DisplayMember = "NOMBRE_PROGRAMA"
        Me.ValueMember = "CODIGO_PROGRAMA"
        Me.DataSource = Lista
    End Sub
   
End Class
