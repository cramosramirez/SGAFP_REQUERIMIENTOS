Imports System.ComponentModel

''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_WinUC
''' Class	 : WinUC.ddlEJERCICIO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista Desplegable Windows
''' de la tabla EJERCICIO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	23/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
Public Class cbxEJERCICIO
    Inherits cbxBase

    Private Sub RecuperarLista(Optional ByVal agregarTodos As Boolean = False, Optional ByVal agregarVacio As Boolean = False)
        Dim miComponente As New cEJERCICIO
        Dim Lista As New listaEJERCICIO

        Lista = miComponente.ObtenerLista()
        If Not agregarTodos AndAlso (Lista Is Nothing OrElse Not Lista.Count > 0) Then
            Me.DataSource = Nothing
            Return
        End If

        If agregarVacio Then
            Dim lEntidad As New EJERCICIO
            lEntidad.ID_EJERCICIO = ""
            lEntidad.ETIQUETA = "[Vacio]"
            Lista.Insert(0, lEntidad)
        End If

        If agregarTodos Then
            Dim lEntidad As New EJERCICIO
            lEntidad.ID_EJERCICIO = ""
            lEntidad.ETIQUETA = "[Todos]"
            Lista.Insert(0, lEntidad)
        End If

        Me.DisplayMember = "ETIQUETA"
        Me.ValueMember = "ID_EJERCICIO"
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
    ''' 	[ecarias]	08/06/2010	Se agrego AgregarTodos y AgregarVacio
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub Recuperar(Optional ByVal agregarTodos As Boolean = False, Optional ByVal agregarVacio As Boolean = False)
        RecuperarLista(agregarTodos, agregarVacio)
    End Sub

End Class
