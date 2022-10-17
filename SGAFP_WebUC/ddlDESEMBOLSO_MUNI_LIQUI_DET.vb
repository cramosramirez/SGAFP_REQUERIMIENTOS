Imports System.ComponentModel
Imports System.Web.UI

''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_WebUC
''' Class	 : WebUC.ddlDESEMBOLSO_MUNI_LIQUI_DET
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista Desplegable Web
''' de la tabla DESEMBOLSO_MUNI_LIQUI_DET
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	26/04/2012	Created
''' </history>
''' -----------------------------------------------------------------------------
<DefaultProperty("ID_DESEMBOLSO_MUNI"), ToolboxData("<{0}:ddlDESEMBOLSO_MUNI_LIQUI_DET runat=server></{0}:ddlDESEMBOLSO_MUNI_LIQUI_DET>")> _
Public Class ddlDESEMBOLSO_MUNI_LIQUI_DET
    Inherits ddlBase

    Private Sub RecuperarLista()
        Dim miComponente As New cDESEMBOLSO_MUNI_LIQUI_DET
        Dim Lista As New ListaDESEMBOLSO_MUNI_LIQUI_DET

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "MONTO_DESEMBOLSO"
        Me.DataValueField = "ID_DESEMBOLSO_MUNI"

        Me.DataBind()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el DropDownList con los Datos de la Tabla DESEMBOLSO_MUNI_LIQUI_DET.
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
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla DESEMBOLSO .
    ''' </summary>
    ''' <param name="ID_DESEMBOLSO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	26/04/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorDESEMBOLSO(ByVal ID_DESEMBOLSO As Decimal)
        Dim miComponente As New cDESEMBOLSO_MUNI_LIQUI_DET
        Dim Lista As New ListaDESEMBOLSO_MUNI_LIQUI_DET

        Lista = miComponente.ObtenerListaPorDESEMBOLSO(ID_DESEMBOLSO)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "MONTO_DESEMBOLSO"
        Me.DataValueField = "ID_DESEMBOLSO_MUNI"

        Me.DataBind()

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla MUNICIPIO_LIQUIDACION_DET .
    ''' </summary>
    ''' <param name="ID_LIQUIDACION_DET"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	26/04/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorMUNICIPIO_LIQUIDACION_DET(ByVal ID_LIQUIDACION_DET As Decimal)
        Dim miComponente As New cDESEMBOLSO_MUNI_LIQUI_DET
        Dim Lista As New ListaDESEMBOLSO_MUNI_LIQUI_DET

        Lista = miComponente.ObtenerListaPorMUNICIPIO_LIQUIDACION_DET(ID_LIQUIDACION_DET)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "MONTO_DESEMBOLSO"
        Me.DataValueField = "ID_DESEMBOLSO_MUNI"

        Me.DataBind()

    End Sub

End Class
