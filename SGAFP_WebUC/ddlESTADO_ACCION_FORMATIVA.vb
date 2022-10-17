Imports System.ComponentModel
Imports System.Web.UI

''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_WebUC
''' Class	 : WebUC.ddlESTADO_ACCION_FORMATIVA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista Desplegable Web
''' de la tabla ESTADO_ACCION_FORMATIVA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
<DefaultProperty("CODIGO_ESTADO_AF"), ToolboxData("<{0}:ddlESTADO_ACCION_FORMATIVA runat=server></{0}:ddlESTADO_ACCION_FORMATIVA>")> _
Public Class ddlESTADO_ACCION_FORMATIVA
    Inherits ddlBase

    Private Sub RecuperarLista()
        Dim miComponente As New cESTADO_ACCION_FORMATIVA
        Dim Lista As New listaESTADO_ACCION_FORMATIVA

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "NOMBRE_ESTADO_AF"
        Me.DataValueField = "CODIGO_ESTADO_AF"

        Me.DataBind()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el DropDownList con los Datos de la Tabla ESTADO_ACCION_FORMATIVA.
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
    ''' Función que Recupera el DropDownList con los Estados posibles para la Calendarizacion de Cursos.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[ecarias]	03/06/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarParaCalendarizacion()
        Dim Lista As New listaESTADO_ACCION_FORMATIVA
        Lista.Add(New ESTADO_ACCION_FORMATIVA(Enumeradores.EstadoAccionFormativa.Ingresada, "INGRESADO", 0, 0, 0, ""))
        Lista.Add(New ESTADO_ACCION_FORMATIVA(Enumeradores.EstadoAccionFormativa.EnMatricula, "EN MATRICULA", 0, 0, 0, ""))
        Lista.Add(New ESTADO_ACCION_FORMATIVA(Enumeradores.EstadoAccionFormativa.Iniciada, "INICIADO", 0, 0, 0, ""))
        Lista.Add(New ESTADO_ACCION_FORMATIVA(Enumeradores.EstadoAccionFormativa.EnSolicitudDeReprogramacion, "EN SOLICITUD DE REPROGRAMACION", 0, 0, 0, ""))
        Lista.Add(New ESTADO_ACCION_FORMATIVA(Enumeradores.EstadoAccionFormativa.Finalizada, "FINALIZADO", 0, 0, 0, ""))

        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "NOMBRE_ESTADO_AF"
        Me.DataValueField = "CODIGO_ESTADO_AF"

        Me.DataBind()
    End Sub

End Class
