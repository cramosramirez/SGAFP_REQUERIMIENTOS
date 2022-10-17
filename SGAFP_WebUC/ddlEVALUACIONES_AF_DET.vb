Imports System.ComponentModel
Imports System.Web.UI

''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_WebUC
''' Class	 : WebUC.ddlEVALUACIONES_AF_DET
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista Desplegable Web
''' de la tabla EVALUACIONES_AF_DET
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
<DefaultProperty("ID_EVALUACION_DET"), ToolboxData("<{0}:ddlEVALUACIONES_AF_DET runat=server></{0}:ddlEVALUACIONES_AF_DET>")> _
Public Class ddlEVALUACIONES_AF_DET
    Inherits ddlBase

    Private Sub RecuperarLista()
        Dim miComponente As New cEVALUACIONES_AF_DET
        Dim Lista As New listaEVALUACIONES_AF_DET

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "NOTA_OBTENIDA"
        Me.DataValueField = "ID_EVALUACION_DET"

        Me.DataBind()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el DropDownList con los Datos de la Tabla EVALUACIONES_AF_DET.
    ''' </summary>
    ''' <remarks>
    ''' Si la tabla es de llave compuesta, recibe los parametros de la Tabla Padre
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub Recuperar()
        RecuperarLista()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla PARTICIPANTE .
    ''' </summary>
    ''' <param name="ID_PARTICIPANTE"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorPARTICIPANTE(ByVal ID_PARTICIPANTE As Decimal)
        Dim miComponente As New cEVALUACIONES_AF_DET
        Dim Lista As New listaEVALUACIONES_AF_DET

        Lista = miComponente.ObtenerListaPorPARTICIPANTE(ID_PARTICIPANTE)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "NOTA_OBTENIDA"
        Me.DataValueField = "ID_EVALUACION_DET"

        Me.DataBind()

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla EVALUACION_AF .
    ''' </summary>
    ''' <param name="ID_EVALUACION_AF"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorEVALUACION_AF(ByVal ID_EVALUACION_AF As Decimal)
        Dim miComponente As New cEVALUACIONES_AF_DET
        Dim Lista As New listaEVALUACIONES_AF_DET

        Lista = miComponente.ObtenerListaPorEVALUACION_AF(ID_EVALUACION_AF)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "NOTA_OBTENIDA"
        Me.DataValueField = "ID_EVALUACION_DET"

        Me.DataBind()

    End Sub

End Class
