Imports System.ComponentModel

''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_WinUC
''' Class	 : WinUC.ddlINFORME_FINAL_AF
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista Desplegable Windows
''' de la tabla INFORME_FINAL_AF
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	23/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
Public Class cbxINFORME_FINAL_AF
    Inherits cbxBase

    Private Sub RecuperarLista()
        Dim miComponente As New cINFORME_FINAL_AF
        Dim Lista As New listaINFORME_FINAL_AF

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
            Return
        End If

        Me.DisplayMember = "FECHA_INFORME"
        Me.ValueMember = "ID_INFORME_FINAL"
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
    Public Sub Recuperar()
        RecuperarLista()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el ComboBox filtrada por los parámetros de la Tabla ACCION_FORMATIVA .
    ''' </summary>
    ''' <param name="ID_ACCION_FORMATIVA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorACCION_FORMATIVA(ByVal ID_ACCION_FORMATIVA As Decimal)
        Dim miComponente As New cINFORME_FINAL_AF
        Dim Lista As New listaINFORME_FINAL_AF

        Lista = miComponente.ObtenerListaPorACCION_FORMATIVA(ID_ACCION_FORMATIVA)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
            Return
        End If

        Me.DisplayMember = "FECHA_INFORME"
        Me.ValueMember = "ID_INFORME_FINAL"
        Me.DataSource = Lista

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el ComboBox filtrada por los parámetros de la Tabla PROVEEDOR_AF .
    ''' </summary>
    ''' <param name="ID_PROVEEDOR_AF"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorPROVEEDOR_AF(ByVal ID_PROVEEDOR_AF As Decimal)
        Dim miComponente As New cINFORME_FINAL_AF
        Dim Lista As New listaINFORME_FINAL_AF

        Lista = miComponente.ObtenerListaPorPROVEEDOR_AF(ID_PROVEEDOR_AF)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
            Return
        End If

        Me.DisplayMember = "FECHA_INFORME"
        Me.ValueMember = "ID_INFORME_FINAL"
        Me.DataSource = Lista

    End Sub

End Class
