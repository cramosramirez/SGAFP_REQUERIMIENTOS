Imports System.ComponentModel

''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_WinUC
''' Class	 : WinUC.ddlOPCION_GRUPO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista Desplegable Windows
''' de la tabla OPCION_GRUPO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	23/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
Public Class cbxOPCION_GRUPO
    Inherits cbxBase

    Private Sub RecuperarLista()
        Dim miComponente As New cOPCION_GRUPO
        Dim Lista As New listaOPCION_GRUPO

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
            Return
        End If

        Me.DisplayMember = "FECHA_INGRESO"
        Me.ValueMember = "ID_OPCION_GRUPO"
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
    ''' Función que Popula el ComboBox filtrada por los parámetros de la Tabla OPCION_MENU .
    ''' </summary>
    ''' <param name="ID_OPCION_MENU"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorOPCION_MENU(ByVal ID_OPCION_MENU As Decimal)
        Dim miComponente As New cOPCION_GRUPO
        Dim Lista As New listaOPCION_GRUPO

        Lista = miComponente.ObtenerListaPorOPCION_MENU(ID_OPCION_MENU)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
            Return
        End If

        Me.DisplayMember = "FECHA_INGRESO"
        Me.ValueMember = "ID_OPCION_GRUPO"
        Me.DataSource = Lista

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el ComboBox filtrada por los parámetros de la Tabla GRUPO_USUARIO .
    ''' </summary>
    ''' <param name="ID_GRUPO_USUARIO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorGRUPO_USUARIO(ByVal ID_GRUPO_USUARIO As Decimal)
        Dim miComponente As New cOPCION_GRUPO
        Dim Lista As New listaOPCION_GRUPO

        Lista = miComponente.ObtenerListaPorGRUPO_USUARIO(ID_GRUPO_USUARIO)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
            Return
        End If

        Me.DisplayMember = "FECHA_INGRESO"
        Me.ValueMember = "ID_OPCION_GRUPO"
        Me.DataSource = Lista

    End Sub

End Class
