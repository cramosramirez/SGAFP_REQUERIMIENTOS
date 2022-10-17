Imports System.ComponentModel
Imports System.Web.UI

''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_WebUC
''' Class	 : WebUC.ddlPROGRAMA_FORMACION
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista Desplegable Web
''' de la tabla PROGRAMA_FORMACION
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	05/10/2012	Created
''' </history>
''' -----------------------------------------------------------------------------
<DefaultProperty("ID_PROGRAMA_FORMACION"), ToolboxData("<{0}:ddlPROGRAMA_FORMACION runat=server></{0}:ddlPROGRAMA_FORMACION>")> _
Public Class ddlPROGRAMA_FORMACION
    Inherits ddlBase

    Private Sub RecuperarLista()
        Dim miComponente As New cPROGRAMA_FORMACION
        Dim Lista As New ListaPROGRAMA_FORMACION

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "NOMBRE_PROGRAMA_FORMACION"
        Me.DataValueField = "ID_PROGRAMA_FORMACION"

        Me.DataBind()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el DropDownList con los Datos de la Tabla PROGRAMA_FORMACION.
    ''' </summary>
    ''' <remarks>
    ''' Si la tabla es de llave compuesta, recibe los parametros de la Tabla Padre
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
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla PROGRAMA_FORMACION_TIPOPAGO .
    ''' </summary>
    ''' <param name="ID_TIPO_PAGO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorPROGRAMA_FORMACION_TIPOPAGO(ByVal ID_TIPO_PAGO As Decimal)
        Dim miComponente As New cPROGRAMA_FORMACION
        Dim Lista As New ListaPROGRAMA_FORMACION

        Lista = miComponente.ObtenerListaPorPROGRAMA_FORMACION_TIPOPAGO(ID_TIPO_PAGO)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "NOMBRE_PROGRAMA_FORMACION"
        Me.DataValueField = "ID_PROGRAMA_FORMACION"

        Me.DataBind()

    End Sub

End Class
