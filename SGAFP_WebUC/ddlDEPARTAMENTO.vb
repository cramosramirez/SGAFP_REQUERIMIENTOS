Imports System.ComponentModel
Imports System.Web.UI

''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_WebUC
''' Class	 : WebUC.ddlDEPARTAMENTO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista Desplegable Web
''' de la tabla DEPARTAMENTO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	19/01/2011	Created
''' </history>
''' -----------------------------------------------------------------------------
<DefaultProperty("CODIGO_DEPARTAMENTO"), ToolboxData("<{0}:ddlDEPARTAMENTO runat=server></{0}:ddlDEPARTAMENTO>")> _
Public Class ddlDEPARTAMENTO
    Inherits ddlBase

    Private Sub RecuperarLista()
        Dim miComponente As New cDEPARTAMENTO
        Dim Lista As New ListaDEPARTAMENTO

        Lista = miComponente.ObtenerLista(False, False, "NOMBRE")
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "NOMBRE"
        Me.DataValueField = "CODIGO_DEPARTAMENTO"

        Me.DataBind()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el DropDownList con los Datos de la Tabla DEPARTAMENTO.
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
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla REGION .
    ''' </summary>
    ''' <param name="CODIGO_REGION"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/01/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorREGION(ByVal CODIGO_REGION As String)
        Dim miComponente As New cDEPARTAMENTO
        Dim Lista As New ListaDEPARTAMENTO

        Lista = miComponente.ObtenerListaPorREGION(CODIGO_REGION)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "NOMBRE"
        Me.DataValueField = "CODIGO_DEPARTAMENTO"

        Me.DataBind()

    End Sub

End Class
