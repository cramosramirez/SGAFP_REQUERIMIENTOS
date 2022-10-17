Imports System.ComponentModel
Imports System.Web.UI

''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_WebUC
''' Class	 : WebUC.lbCENTRO_RESPONSABILIDAD_UNIDAD
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista de Seleccion Web
''' de la tabla CENTRO_RESPONSABILIDAD_UNIDAD
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	05/10/2012	Created
''' </history>
''' -----------------------------------------------------------------------------
<DefaultProperty("ID_CENTRO_RESPONSABILIDAD"), ToolboxData("<{0}:lbCENTRO_RESPONSABILIDAD_UNIDAD runat=server></{0}:lbCENTRO_RESPONSABILIDAD_UNIDAD>")> _
Public Class lbCENTRO_RESPONSABILIDAD_UNIDAD
    Inherits lbBase

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el ListBox con los Datos de la Tabla CENTRO_RESPONSABILIDAD_UNIDAD.
    ''' </summary>
    ''' <param name="ID_UNIDAD_ORGANIZATIVA"></param>
    ''' <remarks>
    ''' Si la tabla es de llave compuesta, recibe los parametros de la Tabla Padre
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub Recuperar(ByVal ID_UNIDAD_ORGANIZATIVA As Decimal)
        Dim miComponente As New cCENTRO_RESPONSABILIDAD_UNIDAD
        Dim Lista As New ListaCENTRO_RESPONSABILIDAD_UNIDAD

        Lista = miComponente.ObtenerLista(ID_UNIDAD_ORGANIZATIVA)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "USERID"
        Me.DataValueField = "ID_CENTRO_RESPONSABILIDAD"

        Me.DataBind()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla CENTRO_RESPONSABILIDAD .
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
        Dim Lista As New ListaCENTRO_RESPONSABILIDAD_UNIDAD

        Lista = miComponente.ObtenerListaPorCENTRO_RESPONSABILIDAD(ID_CENTRO_RESPONSABILIDAD)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "USERID"
        Me.DataValueField = "ID_CENTRO_RESPONSABILIDAD"

        Me.DataBind()

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla UNIDAD_ORGANIZATIVA .
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
        Dim Lista As New ListaCENTRO_RESPONSABILIDAD_UNIDAD

        Lista = miComponente.ObtenerListaPorUNIDAD_ORGANIZATIVA(ID_UNIDAD_ORGANIZATIVA)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "USERID"
        Me.DataValueField = "ID_CENTRO_RESPONSABILIDAD"

        Me.DataBind()

    End Sub

End Class
