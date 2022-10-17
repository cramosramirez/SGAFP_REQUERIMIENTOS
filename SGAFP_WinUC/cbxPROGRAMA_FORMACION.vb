Imports System.ComponentModel

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
Public Class cbxPROGRAMA_FORMACION
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
    Public Sub RecuperarPorId(ByVal ID_PROGRAMA_FORMACION As Decimal)
        Dim miComponente As New cPROGRAMA_FORMACION
        Dim Lista As New listaPROGRAMA_FORMACION
        Dim lEntidad As PROGRAMA_FORMACION

        lEntidad = miComponente.ObtenerPROGRAMA_FORMACION(ID_PROGRAMA_FORMACION)
        If lEntidad Is Nothing Then
            Me.DataSource = Nothing
            Return
        End If
        Lista.Add(lEntidad)

        Me.DisplayMember = "NOMBRE_PROGRAMA_FORMACION"
        Me.ValueMember = "ID_PROGRAMA_FORMACION"
        Me.DataSource = Lista
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
    Public Sub RecuperarProveedor_Programaormacion(ByVal ID_PROVEEDOR_AF As Decimal, ByVal ID_PROGRAMA_FORMACION As Decimal, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC")
        Dim miComponente As New cPROGRAMA_FORMACION
        Dim Lista As New listaPROGRAMA_FORMACION
        Dim lEntidad As PROGRAMA_FORMACION

        lEntidad = miComponente.ObtenerListaPATI(ID_PROGRAMA_FORMACION)
        If lEntidad Is Nothing Then
            Me.DataSource = Nothing
            Return
        End If
        Lista.Add(lEntidad)

        Me.DisplayMember = "NOMBRE_PROGRAMA_FORMACION"
        Me.ValueMember = "ID_PROGRAMA_FORMACION"
        Me.DataSource = Lista
    End Sub


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el ComboBox filtrada por los parámetros de la Tabla Padre.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	25/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorRoles(ByVal listaRoles As List(Of String), Optional agregarTodos As Boolean = False)
        RecuperarListaPorRoles(listaRoles, agregarTodos)
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el ComboBox por los programas PATI.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	25/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarListaPATI()
        RecuperarPorListaPATI()
    End Sub

    Private Sub RecuperarPorListaPATI()
        Dim miComponente As New cPROGRAMA_FORMACION
        Dim Lista As New listaPROGRAMA_FORMACION
        Dim lEntidad As New PROGRAMA_FORMACION

        Lista = miComponente.ObtenerListaPATI()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
            Return
        End If

        lEntidad.ID_PROGRAMA_FORMACION = -1
        lEntidad.NOMBRE_PROGRAMA_FORMACION = "[Todos]"
        Lista.Add(lEntidad)

        Me.DisplayMember = "NOMBRE_PROGRAMA_FORMACION"
        Me.ValueMember = "ID_PROGRAMA_FORMACION"
        Me.DataSource = Lista

    End Sub


    Private Sub RecuperarListaPorRoles(ByVal listaRoles As List(Of String), Optional agregarTodos As Boolean = False)
        Dim miComponente As New cPROGRAMA_FORMACION
        Dim lista As listaPROGRAMA_FORMACION

        lista = miComponente.ObtenerListaPorROLES(listaRoles)
        If lista Is Nothing OrElse Not lista.Count > 0 Then
            Me.DataSource = Nothing
            Return
        End If

        If agregarTodos Then
            Dim lEntidad As New PROGRAMA_FORMACION
            lEntidad.ID_PROGRAMA_FORMACION = -1
            lEntidad.NOMBRE_PROGRAMA_FORMACION = "[Todos]"
            lista.Insert(0, lEntidad)
        End If

        Me.DisplayMember = "NOMBRE_PROGRAMA_FORMACION"
        Me.ValueMember = "ID_PROGRAMA_FORMACION"
        Me.DataSource = lista
    End Sub

    Private Sub RecuperarLista()
        Dim miComponente As New cPROGRAMA_FORMACION
        Dim Lista As New listaPROGRAMA_FORMACION

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
            Return
        End If

        Me.DisplayMember = "NOMBRE_PROGRAMA_FORMACION"
        Me.ValueMember = "ID_PROGRAMA_FORMACION"
        Me.DataSource = Lista

    End Sub

    Private Sub RecuperarLista(ByVal agregarVacio As Boolean, ByVal agregarTodos As Boolean)
        Dim miComponente As New cPROGRAMA_FORMACION
        Dim Lista As New listaPROGRAMA_FORMACION

        Lista = miComponente.ObtenerLista(False, False, "NOMBRE_PROGRAMA_FORMACION")
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
            Return
        End If

        If agregarVacio Then
            Dim lProgramaFormacion As New PROGRAMA_FORMACION
            lProgramaFormacion.ID_PROGRAMA_FORMACION = -1
            lProgramaFormacion.NOMBRE_PROGRAMA_FORMACION = "[Vacio]"
            Lista.Insert(0, lProgramaFormacion)
        End If

        If agregarTodos Then
            Dim lProgramaFormacion As New PROGRAMA_FORMACION
            lProgramaFormacion.ID_PROGRAMA_FORMACION = -1
            lProgramaFormacion.NOMBRE_PROGRAMA_FORMACION = "[Todos]"
            Lista.Insert(0, lProgramaFormacion)
        End If

        Me.DisplayMember = "NOMBRE_PROGRAMA_FORMACION"
        Me.ValueMember = "ID_PROGRAMA_FORMACION"
        Me.DataSource = Lista

    End Sub

   

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el ComboBox filtrada por los parámetros de la Tabla PROGRAMA_FORMACION_TIPOPAGO .
    ''' </summary>
    ''' <param name="ID_TIPO_PAGO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorPROGRAMA_FORMACION_TIPOPAGO(ByVal ID_TIPO_PAGO As Decimal)
        Dim miComponente As New cPROGRAMA_FORMACION
        Dim Lista As New listaPROGRAMA_FORMACION

        Lista = miComponente.ObtenerListaPorPROGRAMA_FORMACION_TIPOPAGO(ID_TIPO_PAGO)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
            Return
        End If

        Me.DisplayMember = "NOMBRE_PROGRAMA_FORMACION"
        Me.ValueMember = "ID_PROGRAMA_FORMACION"
        Me.DataSource = Lista

    End Sub

End Class
