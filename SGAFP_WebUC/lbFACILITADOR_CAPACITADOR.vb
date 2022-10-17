Imports System.ComponentModel
Imports System.Web.UI

''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_WebUC
''' Class	 : WebUC.lbFACILITADOR_CAPACITADOR
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista de Seleccion Web
''' de la tabla FACILITADOR_CAPACITADOR
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	10/03/2011	Created
''' </history>
''' -----------------------------------------------------------------------------
<DefaultProperty("ID_FACILITADOR"), ToolboxData("<{0}:lbFACILITADOR_CAPACITADOR runat=server></{0}:lbFACILITADOR_CAPACITADOR>")> _
Public Class lbFACILITADOR_CAPACITADOR
    Inherits lbBase

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el ListBox con los Datos de la Tabla FACILITADOR_CAPACITADOR.
    ''' </summary>
    ''' <remarks>
    ''' Si la tabla es de llave compuesta, recibe los parametros de la Tabla Padre
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	10/03/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub Recuperar()
        Dim miComponente As New cFACILITADOR_CAPACITADOR
        Dim Lista As New ListaFACILITADOR_CAPACITADOR

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "NOMBRE_FACILITADOR"
        Me.DataValueField = "ID_FACILITADOR"

        Me.DataBind()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla TIPO_PERSONA .
    ''' </summary>
    ''' <param name="ID_TIPO_PERSONA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	10/03/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorTIPO_PERSONA(ByVal ID_TIPO_PERSONA As Decimal)
        Dim miComponente As New cFACILITADOR_CAPACITADOR
        Dim Lista As New ListaFACILITADOR_CAPACITADOR

        Lista = miComponente.ObtenerListaPorTIPO_PERSONA(ID_TIPO_PERSONA)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "NOMBRE_FACILITADOR"
        Me.DataValueField = "ID_FACILITADOR"

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
    ''' 	[GenApp]	10/03/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorPROVEEDOR_AF(ByVal ID_PROVEEDOR_AF As Decimal)
        Dim miComponente As New cFACILITADOR_CAPACITADOR
        Dim Lista As New ListaFACILITADOR_CAPACITADOR

        Lista = miComponente.ObtenerListaPorPROVEEDOR_AF(ID_PROVEEDOR_AF)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "NOMBRE_FACILITADOR"
        Me.DataValueField = "ID_FACILITADOR"

        Me.DataBind()

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
    ''' 	[GenApp]	10/03/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorMUNICIPIO(ByVal CODIGO_DEPARTAMENTO As String, ByVal CODIGO_MUNICIPIO As String)
        Dim miComponente As New cFACILITADOR_CAPACITADOR
        Dim Lista As New ListaFACILITADOR_CAPACITADOR

        Lista = miComponente.ObtenerListaPorMUNICIPIO(CODIGO_DEPARTAMENTO, CODIGO_MUNICIPIO)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "NOMBRE_FACILITADOR"
        Me.DataValueField = "ID_FACILITADOR"

        Me.DataBind()

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla DEPARTAMENTO .
    ''' </summary>
    ''' <param name="CODIGO_DEPARTAMENTO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	10/03/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorDEPARTAMENTO(ByVal CODIGO_DEPARTAMENTO As String)
        Dim miComponente As New cFACILITADOR_CAPACITADOR
        Dim Lista As New ListaFACILITADOR_CAPACITADOR

        Lista = miComponente.ObtenerListaPorDEPARTAMENTO(CODIGO_DEPARTAMENTO)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "NOMBRE_FACILITADOR"
        Me.DataValueField = "ID_FACILITADOR"

        Me.DataBind()

    End Sub

End Class
