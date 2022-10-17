
Imports System.ComponentModel

''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_WinUC
''' Class	 : WinUC.ddlFUENTE_FINANCIAMIENTO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista Desplegable Windows
''' de la tabla FUENTE_FINANCIAMIENTO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	09/10/2012	Created
''' </history>
''' -----------------------------------------------------------------------------
Public Class cbxFUENTE_FINANCIAMIENTO
    Inherits cbxBase

    Private Sub RecuperarLista(ByVal agregarVacio As Boolean, ByVal agregarTodos As Boolean)
        Dim miComponente As New cFUENTE_FINANCIAMIENTO
        Dim Lista As New listaFUENTE_FINANCIAMIENTO

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
            Return
        End If

        If agregarVacio Then
            Dim lFuenteFinanciamiento As New FUENTE_FINANCIAMIENTO
            lFuenteFinanciamiento.ID_FUENTE = -1
            lFuenteFinanciamiento.NOMBRE_FUENTE = "[Vacio]"
            Lista.Insert(0, lFuenteFinanciamiento)
        End If

        If agregarTodos Then
            Dim lFuenteFinanciamiento As New FUENTE_FINANCIAMIENTO
            lFuenteFinanciamiento.ID_FUENTE = -1
            lFuenteFinanciamiento.NOMBRE_FUENTE = "[Todos]"
            Lista.Insert(0, lFuenteFinanciamiento)
        End If

        Me.DisplayMember = "NOMBRE_FUENTE"
        Me.ValueMember = "ID_FUENTE"
        Me.DataSource = Lista

    End Sub

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
End Class
