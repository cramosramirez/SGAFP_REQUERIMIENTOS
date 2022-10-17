Imports System.ComponentModel
Imports System.Web.UI

''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_WebUC
''' Class	 : WebUC.ddlPAQUETE_INFORME_DET
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista Desplegable Web
''' de la tabla PAQUETE_INFORME_DET
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.6.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	26/08/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
<DefaultProperty("ID_INFORME_FINAL"), ToolboxData("<{0}:ddlPAQUETE_INFORME_DET runat=server></{0}:ddlPAQUETE_INFORME_DET>")> _
Public Class ddlPAQUETE_INFORME_DET
    Inherits ddlBase

    Private Sub RecuperarLista(ByVal ID_PAQUETE As Decimal)
        Dim miComponente As New cPAQUETE_INFORME_DET
        Dim Lista As New listaPAQUETE_INFORME_DET

        Lista = miComponente.ObtenerLista(ID_PAQUETE)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "LASTUPDATE"
        Me.DataValueField = "ID_INFORME_FINAL"

        Me.DataBind()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el DropDownList con los Datos de la Tabla PAQUETE_INFORME_DET.
    ''' </summary>
    ''' <param name="ID_PAQUETE"></param>
    ''' <remarks>
    ''' Si la tabla es de llave compuesta, recibe los parametros de la Tabla Padre
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	26/08/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub Recuperar(ByVal ID_PAQUETE As Decimal)
        RecuperarLista(ID_PAQUETE)
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla PAQUETE_INFORME .
    ''' </summary>
    ''' <param name="ID_PAQUETE"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	26/08/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorPAQUETE_INFORME(ByVal ID_PAQUETE As Decimal)
        Dim miComponente As New cPAQUETE_INFORME_DET
        Dim Lista As New listaPAQUETE_INFORME_DET

        Lista = miComponente.ObtenerListaPorPAQUETE_INFORME(ID_PAQUETE)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "LASTUPDATE"
        Me.DataValueField = "ID_INFORME_FINAL"

        Me.DataBind()

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla INFORME_FINAL_AF .
    ''' </summary>
    ''' <param name="ID_INFORME_FINAL"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	26/08/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorINFORME_FINAL_AF(ByVal ID_INFORME_FINAL As Decimal)
        Dim miComponente As New cPAQUETE_INFORME_DET
        Dim Lista As New listaPAQUETE_INFORME_DET

        Lista = miComponente.ObtenerListaPorINFORME_FINAL_AF(ID_INFORME_FINAL)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "LASTUPDATE"
        Me.DataValueField = "ID_INFORME_FINAL"

        Me.DataBind()

    End Sub

End Class
