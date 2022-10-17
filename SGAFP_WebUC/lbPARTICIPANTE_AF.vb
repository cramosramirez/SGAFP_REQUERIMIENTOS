Imports System.ComponentModel
Imports System.Web.UI

''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_WebUC
''' Class	 : WebUC.lbPARTICIPANTE_AF
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista de Seleccion Web
''' de la tabla PARTICIPANTE_AF
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
<DefaultProperty("ID_PARTICIPANTE"), ToolboxData("<{0}:lbPARTICIPANTE_AF runat=server></{0}:lbPARTICIPANTE_AF>")> _
Public Class lbPARTICIPANTE_AF
    Inherits lbBase

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el ListBox con los Datos de la Tabla PARTICIPANTE_AF.
    ''' </summary>
    ''' <param name="ID_ACCION_FORMATIVA"></param>
    ''' <remarks>
    ''' Si la tabla es de llave compuesta, recibe los parametros de la Tabla Padre
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub Recuperar(ByVal ID_ACCION_FORMATIVA As Decimal)
        Dim miComponente As New cPARTICIPANTE_AF
        Dim Lista As New listaPARTICIPANTE_AF

        Lista = miComponente.ObtenerLista(ID_ACCION_FORMATIVA)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "ESTADO"
        Me.DataValueField = "ID_PARTICIPANTE"

        Me.DataBind()
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
        Dim miComponente As New cPARTICIPANTE_AF
        Dim Lista As New listaPARTICIPANTE_AF

        Lista = miComponente.ObtenerListaPorPARTICIPANTE(ID_PARTICIPANTE)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "ESTADO"
        Me.DataValueField = "ID_PARTICIPANTE"

        Me.DataBind()

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla ACCION_FORMATIVA .
    ''' </summary>
    ''' <param name="ID_ACCION_FORMATIVA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorACCION_FORMATIVA(ByVal ID_ACCION_FORMATIVA As Decimal)
        Dim miComponente As New cPARTICIPANTE_AF
        Dim Lista As New listaPARTICIPANTE_AF

        Lista = miComponente.ObtenerListaPorACCION_FORMATIVA(ID_ACCION_FORMATIVA)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "ESTADO"
        Me.DataValueField = "ID_PARTICIPANTE"

        Me.DataBind()

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla SOLICITUD_INSCRIPCION_AF .
    ''' </summary>
    ''' <param name="ID_SOLICITUD"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorSOLICITUD_INSCRIPCION_AF(ByVal ID_SOLICITUD As Decimal)
        Dim miComponente As New cPARTICIPANTE_AF
        Dim Lista As New listaPARTICIPANTE_AF

        Lista = miComponente.ObtenerListaPorSOLICITUD_INSCRIPCION_AF(ID_SOLICITUD)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "ESTADO"
        Me.DataValueField = "ID_PARTICIPANTE"

        Me.DataBind()

    End Sub

End Class
