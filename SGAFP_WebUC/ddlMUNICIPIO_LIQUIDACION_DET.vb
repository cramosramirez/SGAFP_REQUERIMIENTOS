Imports System.ComponentModel
Imports System.Web.UI

''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_WebUC
''' Class	 : WebUC.ddlMUNICIPIO_LIQUIDACION_DET
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista Desplegable Web
''' de la tabla MUNICIPIO_LIQUIDACION_DET
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	19/01/2011	Created
''' </history>
''' ---------------
''' 
Public Class ddlMUNICIPIO_LIQUIDACION_DET
    Inherits ddlBase

    Private Sub RecuperarLista()
        Dim miComponente As New cMUNICIPIO_LIQUIDACION_DET
        Dim Lista As New listaMUNICIPIO_LIQUIDACION_DET

        Lista = miComponente.ObtenerLista
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "ID_LIQUIDACION"
        Me.DataValueField = "ID_LIQUIDACION_DET"

        Me.DataBind()
    End Sub

    Private Sub RecuperarLista(ByVal ID_LIQUIDACION As Decimal)
        Dim miComponente As New cMUNICIPIO_LIQUIDACION_DET
        Dim Lista As New listaMUNICIPIO_LIQUIDACION_DET

        Lista = miComponente.ObtenerListaPorMUNICIPIO_LIQUIDACION(ID_LIQUIDACION)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "ID_LIQUIDACION"
        Me.DataValueField = "ID_LIQUIDACION_DET"

        Me.DataBind()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el DropDownList con los Datos de la Tabla MUNICIPIO.
    ''' </summary>
    ''' <param name="ID_LIQUIDACION"></param>
    ''' <remarks>
    ''' Si la tabla es de llave compuesta, recibe los parametros de la Tabla Padre
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/01/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub Recuperar(ByVal ID_LIQUIDACION As Decimal)
        RecuperarLista(ID_LIQUIDACION)
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el DropDownList 
    ''' </summary>
    ''' <remarks>
    ''' Si la tabla es de llave compuesta, recibe los parametros de la Tabla Padre
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/01/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub Recuperar()
        RecuperarLista()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla ACCION_FORMATIVA .
    ''' </summary>
    ''' <param name="ID_ACCION_FORMATIVA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/01/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorACCION_FORMATIVA(ByVal ID_ACCION_FORMATIVA As String)
        Dim miComponente As New cMUNICIPIO_LIQUIDACION_DET
        Dim Lista As New listaMUNICIPIO_LIQUIDACION_DET

        Lista = miComponente.ObtenerListaPorACCION_FORMATIVA(ID_ACCION_FORMATIVA)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "ID_ACCION_FORMATIVA"
        Me.DataValueField = "ID_LIQUIDACION_DET"

        Me.DataBind()

    End Sub
End Class
