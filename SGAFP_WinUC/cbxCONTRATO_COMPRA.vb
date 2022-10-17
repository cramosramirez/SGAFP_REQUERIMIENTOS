Imports System.ComponentModel

''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_WinUC
''' Class	 : WinUC.ddlCONTRATO_BOLPROS
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista Desplegable Windows
''' de la tabla CONTRATO_BOLPROS
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	11/09/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
Public Class cbxCONTRATO_COMPRA
    Inherits cbxBase

    Private Sub RecuperarLista(Optional ByVal agregarVacio As Boolean = False, Optional ByVal agregarTodos As Boolean = False)
        Dim miComponente As New cCONTRATO_COMPRA
        Dim Lista As New listaCONTRATO_COMPRA

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
            Return
        End If

        If agregarVacio Then
            Dim lContrato As New CONTRATO_COMPRA
            lContrato.ID_CONTRATO_COMPRA = -1
            lContrato.NO_CONTRATO_COMPRA = "[Vacio]"
            Lista.Insert(0, lContrato)
        End If

        If agregarTodos Then
            Dim lContrato As New CONTRATO_COMPRA
            lContrato.ID_CONTRATO_COMPRA = -1
            lContrato.NO_CONTRATO_COMPRA = "[Todos]"
            Lista.Insert(0, lContrato)
        End If

        Me.DisplayMember = "NO_CONTRATO_COMPRA"
        Me.ValueMember = "ID_CONTRATO_COMPRA"
        Me.DataSource = Lista

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el ComboBox filtrada por los parámetros de la Tabla Padre.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	11/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub Recuperar(Optional ByVal agregarVacio As Boolean = False, Optional ByVal agregarTodos As Boolean = False)
        RecuperarLista(agregarVacio, agregarTodos)
    End Sub

   
End Class
