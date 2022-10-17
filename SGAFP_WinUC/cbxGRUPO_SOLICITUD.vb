Imports System.ComponentModel

''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_WinUC
''' Class	 : WinUC.ddlGRUPO_SOLICITUD
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista Desplegable Windows
''' de la tabla GRUPO_SOLICITUD
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	05/10/2012	Created
''' </history>
''' -----------------------------------------------------------------------------
Public Class cbxGRUPO_SOLICITUD
    Inherits cbxBase

    Private Sub RecuperarLista()
        Dim miComponente As New cGRUPO_SOLICITUD
        Dim Lista As New listaGRUPO_SOLICITUD

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
            Return
        End If

        Me.DisplayMember = "CODIGO_PROGRAMA"
        Me.ValueMember = "ID_GRUPO_SOLICITUD"
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
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub Recuperar()
        RecuperarLista()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el ComboBox filtrada por los parámetros de la Tabla SOLICITUD_CAPACITACION .
    ''' </summary>
    ''' <param name="ID_SOLICITUD"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorSOLICITUD_CAPACITACION(ByVal ID_SOLICITUD As Decimal)
        Dim miComponente As New cGRUPO_SOLICITUD
        Dim Lista As New listaGRUPO_SOLICITUD

        Lista = miComponente.ObtenerListaPorSOLICITUD_CAPACITACION(ID_SOLICITUD)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
            Return
        End If

        Me.DisplayMember = "CODIGO_PROGRAMA"
        Me.ValueMember = "ID_GRUPO_SOLICITUD"
        Me.DataSource = Lista

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el ComboBox filtrada por los parámetros de la Tabla MODALIDAD_DE_FORMACION .
    ''' </summary>
    ''' <param name="ID_MODALIDAD_FORMACION"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorMODALIDAD_DE_FORMACION(ByVal ID_MODALIDAD_FORMACION As Decimal)
        Dim miComponente As New cGRUPO_SOLICITUD
        Dim Lista As New listaGRUPO_SOLICITUD

        Lista = miComponente.ObtenerListaPorMODALIDAD_DE_FORMACION(ID_MODALIDAD_FORMACION)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
            Return
        End If

        Me.DisplayMember = "CODIGO_PROGRAMA"
        Me.ValueMember = "ID_GRUPO_SOLICITUD"
        Me.DataSource = Lista

    End Sub

End Class
