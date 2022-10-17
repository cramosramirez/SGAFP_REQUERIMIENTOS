Imports System.ComponentModel
Imports System.Web.UI

''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_WebUC
''' Class	 : WebUC.ddlDISCA_POR_PARTICIPANTE
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista Desplegable Web
''' de la tabla DISCA_POR_PARTICIPANTE
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	19/01/2011	Created
''' </history>
''' -----------------------------------------------------------------------------
<DefaultProperty("ID_DISCAPACIDAD"), ToolboxData("<{0}:ddlDISCA_POR_PARTICIPANTE runat=server></{0}:ddlDISCA_POR_PARTICIPANTE>")> _
Public Class ddlDISCA_POR_PARTICIPANTE
    Inherits ddlBase

    Private Sub RecuperarLista(ByVal ID_PARTICIPANTE As Decimal)
        Dim miComponente As New cDISCA_POR_PARTICIPANTE
        Dim Lista As New ListaDISCA_POR_PARTICIPANTE

        Lista = miComponente.ObtenerLista(ID_PARTICIPANTE)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "USERID"
        Me.DataValueField = "ID_DISCAPACIDAD"

        Me.DataBind()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el DropDownList con los Datos de la Tabla DISCA_POR_PARTICIPANTE.
    ''' </summary>
    ''' <param name="ID_PARTICIPANTE"></param>
    ''' <remarks>
    ''' Si la tabla es de llave compuesta, recibe los parametros de la Tabla Padre
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/01/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub Recuperar(ByVal ID_PARTICIPANTE As Decimal)
        RecuperarLista(ID_PARTICIPANTE)
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla DISCAPACIDAD .
    ''' </summary>
    ''' <param name="ID_DISCAPACIDAD"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/01/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorDISCAPACIDAD(ByVal ID_DISCAPACIDAD As Decimal)
        Dim miComponente As New cDISCA_POR_PARTICIPANTE
        Dim Lista As New ListaDISCA_POR_PARTICIPANTE

        Lista = miComponente.ObtenerListaPorDISCAPACIDAD(ID_DISCAPACIDAD)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "USERID"
        Me.DataValueField = "ID_DISCAPACIDAD"

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
    ''' 	[GenApp]	19/01/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorPARTICIPANTE(ByVal ID_PARTICIPANTE As Decimal)
        Dim miComponente As New cDISCA_POR_PARTICIPANTE
        Dim Lista As New ListaDISCA_POR_PARTICIPANTE

        Lista = miComponente.ObtenerListaPorPARTICIPANTE(ID_PARTICIPANTE)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "USERID"
        Me.DataValueField = "ID_DISCAPACIDAD"

        Me.DataBind()

    End Sub

End Class
