Imports System.ComponentModel

''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_WinUC
''' Class	 : WinUC.ddlAREA_FORMACION
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista Desplegable Windows
''' de la tabla AREA_FORMACION
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	23/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
Public Class cbxAREA_FORMACION
    Inherits cbxBase

    Private Sub RecuperarLista(ByVal agregarTodos As Boolean)
        Dim miComponente As New cAREA_FORMACION
        Dim Lista As New listaAREA_FORMACION

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
            Return
        End If

        If agregarTodos Then
            Lista.Insert(0, New AREA_FORMACION(-1, "[Todas]", "", "", "", Nothing))
        End If

        Me.DisplayMember = "AREA_FORMACION"
        Me.ValueMember = "ID_AREA_FORMACION"
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
    Public Sub Recuperar(Optional ByVal agregarTodos As Boolean = False)
        RecuperarLista(agregarTodos)
    End Sub

End Class
