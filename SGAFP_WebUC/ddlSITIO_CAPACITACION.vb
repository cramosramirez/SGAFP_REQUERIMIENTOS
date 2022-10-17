Imports System.ComponentModel
Imports System.Web.UI

''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_WebUC
''' Class	 : WebUC.ddlSITIO_CAPACITACION
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista Desplegable Web
''' de la tabla SITIO_CAPACITACION
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	14/02/2011	Created
''' </history>
''' -----------------------------------------------------------------------------
<DefaultProperty("ID_SITIO_CAPACITACION"), ToolboxData("<{0}:ddlSITIO_CAPACITACION runat=server></{0}:ddlSITIO_CAPACITACION>")> _
Public Class ddlSITIO_CAPACITACION
    Inherits ddlBase

    Private Sub RecuperarLista()
        Dim miComponente As New cSITIO_CAPACITACION
        Dim Lista As New ListaSITIO_CAPACITACION

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "NOMBRE_SITIO"
        Me.DataValueField = "ID_SITIO_CAPACITACION"

        Me.DataBind()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el DropDownList con los Datos de la Tabla SITIO_CAPACITACION.
    ''' </summary>
    ''' <remarks>
    ''' Si la tabla es de llave compuesta, recibe los parametros de la Tabla Padre
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	14/02/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub Recuperar()
        RecuperarLista()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla MUNICIPIO .
    ''' </summary>
    ''' <param name="CODIGO_DEPARTAMENTO"></param>
    ''' <param name="CODIGO_MUNICIPIO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	14/02/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorMUNICIPIO(ByVal CODIGO_DEPARTAMENTO As String, ByVal CODIGO_MUNICIPIO As String)
        Dim miComponente As New cSITIO_CAPACITACION
        Dim Lista As New ListaSITIO_CAPACITACION

        Lista = miComponente.ObtenerListaPorMUNICIPIO(CODIGO_DEPARTAMENTO, CODIGO_MUNICIPIO)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "NOMBRE_SITIO"
        Me.DataValueField = "ID_SITIO_CAPACITACION"

        Me.DataBind()

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla DEPARTAMENTO .
    ''' </summary>
    ''' <param name="CODIGO_DEPARTAMENTO"></param>
    ''' <param name="CODIGO_REGION"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	14/02/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorDEPARTAMENTO(ByVal CODIGO_DEPARTAMENTO As String, ByVal CODIGO_REGION As String)
        Dim miComponente As New cSITIO_CAPACITACION
        Dim Lista As New ListaSITIO_CAPACITACION

        Lista = miComponente.ObtenerListaPorDEPARTAMENTO(CODIGO_DEPARTAMENTO, CODIGO_REGION)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "NOMBRE_SITIO"
        Me.DataValueField = "ID_SITIO_CAPACITACION"

        Me.DataBind()

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla PROVEEDOR_AF .
    ''' </summary>
    ''' <param name="ID_PROVEEDOR_AF"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	14/02/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorPROVEEDOR_AF(ByVal ID_PROVEEDOR_AF As Decimal)
        Dim miComponente As New cSITIO_CAPACITACION
        Dim Lista As New ListaSITIO_CAPACITACION

        Lista = miComponente.ObtenerListaPorPROVEEDOR_AF(ID_PROVEEDOR_AF)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "NOMBRE_SITIO"
        Me.DataValueField = "ID_SITIO_CAPACITACION"

        Me.DataBind()

    End Sub

End Class
