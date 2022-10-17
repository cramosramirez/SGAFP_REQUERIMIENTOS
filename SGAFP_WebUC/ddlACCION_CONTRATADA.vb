Imports System.ComponentModel
Imports System.Web.UI

<DefaultProperty("ID_ACCION_CONTRATADA"), ToolboxData("<{0}:ddlACCION_CONTRATADA runat=server></{0}:ddlACCION_CONTRATADA>")> _
Public Class ddlACCION_CONTRATADA
    Inherits ddlBase

    Public Sub RecuperarPorCONTRATO_BOLPROS(ByVal ID_CONTRATO As Decimal)
        Dim miComponente As New cACCION_CONTRATADA
        Dim Lista As New listaACCION_CONTRATADA

        Lista = miComponente.ObtenerListaPorCONTRATO_BOLPROS(ID_CONTRATO)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "NOMBRE_ACCION_FORMATIVA"
        Me.DataValueField = "ID_ACCION_CONTRATADA"

        Me.DataBind()

    End Sub
End Class
