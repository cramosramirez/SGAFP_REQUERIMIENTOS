Imports System.ComponentModel

''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_WinUC
''' Class	 : WinUC.ddlCENTRO_RESPONSABILIDAD_UNIDAD
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista Desplegable Windows
''' de la tabla CENTRO_RESPONSABILIDAD_UNIDAD
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	05/10/2012	Created
''' </history>
''' -----------------------------------------------------------------------------
Public Class cbxCENTRO_RESPONSABILIDAD_UNIDAD
    Inherits cbxBase

    Private Sub RecuperarLista(ByVal ID_UNIDAD_ORGANIZATIVA As Decimal)
        Dim miComponente As New cCENTRO_RESPONSABILIDAD_UNIDAD
        Dim Lista As New listaCENTRO_RESPONSABILIDAD_UNIDAD

        Lista = miComponente.ObtenerLista(ID_UNIDAD_ORGANIZATIVA)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
            Return
        End If

        Me.DisplayMember = "USERID"
        Me.ValueMember = "ID_CENTRO_RESPONSABILIDAD"
        Me.DataSource = Lista

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el ComboBox filtrada por los parámetros de la Tabla Padre.
    ''' </summary>
    ''' <param name="ID_UNIDAD_ORGANIZATIVA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub Recuperar(ByVal ID_UNIDAD_ORGANIZATIVA As Decimal)
        RecuperarLista(ID_UNIDAD_ORGANIZATIVA)
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el ComboBox filtrada por los parámetros de la Tabla CENTRO_RESPONSABILIDAD .
    ''' </summary>
    ''' <param name="ID_CENTRO_RESPONSABILIDAD"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorCENTRO_RESPONSABILIDAD(ByVal ID_CENTRO_RESPONSABILIDAD As Decimal)
        Dim miComponente As New cCENTRO_RESPONSABILIDAD_UNIDAD
        Dim Lista As New listaCENTRO_RESPONSABILIDAD_UNIDAD

        Lista = miComponente.ObtenerListaPorCENTRO_RESPONSABILIDAD(ID_CENTRO_RESPONSABILIDAD)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
            Return
        End If

        Me.DisplayMember = "USERID"
        Me.ValueMember = "ID_CENTRO_RESPONSABILIDAD"
        Me.DataSource = Lista

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el ComboBox filtrada por los parámetros de la Tabla UNIDAD_ORGANIZATIVA .
    ''' </summary>
    ''' <param name="ID_UNIDAD_ORGANIZATIVA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorUNIDAD_ORGANIZATIVA(ByVal ID_UNIDAD_ORGANIZATIVA As Decimal)
        Dim miComponente As New cCENTRO_RESPONSABILIDAD_UNIDAD
        Dim Lista As New listaCENTRO_RESPONSABILIDAD_UNIDAD

        Lista = miComponente.ObtenerListaPorUNIDAD_ORGANIZATIVA(ID_UNIDAD_ORGANIZATIVA)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
            Return
        End If

        Me.DisplayMember = "USERID"
        Me.ValueMember = "ID_CENTRO_RESPONSABILIDAD"
        Me.DataSource = Lista

    End Sub

End Class
