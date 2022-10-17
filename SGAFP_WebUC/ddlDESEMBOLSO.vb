Imports System.ComponentModel
Imports System.Web.UI

''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_WebUC
''' Class	 : WebUC.ddlDESEMBOLSO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista Desplegable Web
''' de la tabla DESEMBOLSO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	26/04/2012	Created
''' </history>
''' -----------------------------------------------------------------------------
<DefaultProperty("ID_DESEMBOLSO"), ToolboxData("<{0}:ddlDESEMBOLSO runat=server></{0}:ddlDESEMBOLSO>")> _
Public Class ddlDESEMBOLSO
    Inherits ddlBase

    Private Sub RecuperarLista()
        Dim miComponente As New cDESEMBOLSO
        Dim Lista As New ListaDESEMBOLSO

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "NO_CONVOCATORIA"
        Me.DataValueField = "ID_DESEMBOLSO"

        Me.DataBind()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el DropDownList con los Datos de la Tabla DESEMBOLSO.
    ''' </summary>
    ''' <remarks>
    ''' Si la tabla es de llave compuesta, recibe los parametros de la Tabla Padre
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	26/04/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub Recuperar()
        RecuperarLista()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla FUENTE_FINANCIAMIENTO .
    ''' </summary>
    ''' <param name="ID_FUENTE"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	26/04/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorFUENTE_FINANCIAMIENTO(ByVal ID_FUENTE As Decimal)
        Dim miComponente As New cDESEMBOLSO
        Dim Lista As New ListaDESEMBOLSO

        Lista = miComponente.ObtenerListaPorFUENTE_FINANCIAMIENTO(ID_FUENTE)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "NO_CONVOCATORIA"
        Me.DataValueField = "ID_DESEMBOLSO"

        Me.DataBind()

    End Sub

End Class
