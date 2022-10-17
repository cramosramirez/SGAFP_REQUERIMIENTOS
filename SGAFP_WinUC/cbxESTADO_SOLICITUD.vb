Imports System.ComponentModel

''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_WinUC
''' Class	 : WinUC.ddlESTADO_SOLICITUD
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista Desplegable Windows
''' de la tabla ESTADO_SOLICITUD
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	23/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
Public Class cbxESTADO_SOLICITUD
    Inherits cbxBase

    Private Sub RecuperarLista(Optional ByVal agregarTodos As Boolean = False, Optional ByVal agregarVacio As Boolean = False)
        Dim miComponente As New cESTADO_SOLICITUD
        Dim Lista As New listaESTADO_SOLICITUD

        Lista = miComponente.ObtenerLista()
        If Not agregarTodos AndAlso (Lista Is Nothing OrElse Not Lista.Count > 0) Then
            Me.DataSource = Nothing
            Return
        End If

        If agregarVacio Then
            Dim lEntidad As New ESTADO_SOLICITUD
            lEntidad.ID_ESTADO_SOLICITUD = -1
            lEntidad.ESTADO_SOLICITUD = "[Vacio]"
            Lista.Insert(0, lEntidad)
        End If

        If agregarTodos Then
            Dim lEntidad As New ESTADO_SOLICITUD
            lEntidad.ID_ESTADO_SOLICITUD = -1
            lEntidad.ESTADO_SOLICITUD = "[Todos]"
            Lista.Insert(0, lEntidad)
        End If

        Me.DisplayMember = "ESTADO_SOLICITUD"
        Me.ValueMember = "ID_ESTADO_SOLICITUD"
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
