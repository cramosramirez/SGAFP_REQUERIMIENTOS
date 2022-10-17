Imports System.ComponentModel

''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_WinUC
''' Class	 : WinUC.ddlPROYECTO_FORMACION
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista Desplegable Windows
''' de la tabla PROYECTO_FORMACION
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	05/10/2012	Created
''' </history>
''' -----------------------------------------------------------------------------
Public Class cbxPROYECTO_FORMACION
    Inherits cbxBase

    Private Sub RecuperarLista(ByVal agregarVacio As Boolean, ByVal agregarTodos As Boolean)
        Dim miComponente As New cPROYECTO_FORMACION
        Dim Lista As New listaPROYECTO_FORMACION

        Lista = miComponente.ObtenerLista(False, "NOMBRE_PROYECTO_FORMACION")
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
            Return
        End If

        If agregarVacio Then
            Dim lProyectoFormacion As New PROYECTO_FORMACION
            lProyectoFormacion.ID_PROYECTO_FORMACION = -1
            lProyectoFormacion.NOMBRE_PROYECTO_FORMACION = "[Vacio]"
            Lista.Insert(0, lProyectoFormacion)
        End If

        If agregarTodos Then
            Dim lProyectoFormacion As New PROYECTO_FORMACION
            lProyectoFormacion.ID_PROYECTO_FORMACION = -1
            lProyectoFormacion.NOMBRE_PROYECTO_FORMACION = "[Todos]"
            Lista.Insert(0, lProyectoFormacion)
        End If

        Me.DisplayMember = "NOMBRE_PROYECTO_FORMACION"
        Me.ValueMember = "ID_PROYECTO_FORMACION"
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
    '''     [cramos]    15/02/2012  Se modifica firma del método
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub Recuperar(Optional ByVal agregarVacio As Boolean = False, Optional ByVal agregarTodos As Boolean = False)
        RecuperarLista(agregarVacio, agregarTodos)
    End Sub

End Class
