Imports System.ComponentModel
Imports System.Web.UI

''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_WebUC
''' Class	 : WebUC.ddlASISTENCIA_AF_DET
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista Desplegable Web
''' de la tabla ASISTENCIA_AF_DET
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
<DefaultProperty("ID_ASISTENCIA_DET"), ToolboxData("<{0}:ddlASISTENCIA_AF_DET runat=server></{0}:ddlASISTENCIA_AF_DET>")> _
Public Class ddlASISTENCIA_AF_DET
    Inherits ddlBase

    Private Sub RecuperarLista()
        Dim miComponente As New cASISTENCIA_AF_DET
        Dim Lista As New listaASISTENCIA_AF_DET

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "ASISTIO"
        Me.DataValueField = "ID_ASISTENCIA_DET"

        Me.DataBind()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el DropDownList con los Datos de la Tabla ASISTENCIA_AF_DET.
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
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla ASISTENCIA_AF .
    ''' </summary>
    ''' <param name="ID_ASISTENCIA_AF"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorASISTENCIA_AF(ByVal ID_ASISTENCIA_AF As Decimal)
        Dim miComponente As New cASISTENCIA_AF_DET
        Dim Lista As New listaASISTENCIA_AF_DET

        Lista = miComponente.ObtenerListaPorASISTENCIA_AF(ID_ASISTENCIA_AF)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "ASISTIO"
        Me.DataValueField = "ID_ASISTENCIA_DET"

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
        Dim miComponente As New cASISTENCIA_AF_DET
        Dim Lista As New listaASISTENCIA_AF_DET

        Lista = miComponente.ObtenerListaPorPARTICIPANTE(ID_PARTICIPANTE)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "ASISTIO"
        Me.DataValueField = "ID_ASISTENCIA_DET"

        Me.DataBind()

    End Sub

End Class
