Imports System.ComponentModel
Imports System.Web.UI

''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_WebUC
''' Class	 : WebUC.lbCONTRATO_PROVEEDOR_AF
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista de Seleccion Web
''' de la tabla CONTRATO_PROVEEDOR_AF
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	05/10/2012	Created
''' </history>
''' -----------------------------------------------------------------------------
<DefaultProperty("ID_CONTRATO"), ToolboxData("<{0}:lbCONTRATO_PROVEEDOR_AF runat=server></{0}:lbCONTRATO_PROVEEDOR_AF>")> _
Public Class lbCONTRATO_PROVEEDOR_AF
    Inherits lbBase

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el ListBox con los Datos de la Tabla CONTRATO_PROVEEDOR_AF.
    ''' </summary>
    ''' <remarks>
    ''' Si la tabla es de llave compuesta, recibe los parametros de la Tabla Padre
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub Recuperar()
        Dim miComponente As New cCONTRATO_PROVEEDOR_AF
        Dim Lista As New ListaCONTRATO_PROVEEDOR_AF

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "NUM_CONTRATO"
        Me.DataValueField = "ID_CONTRATO"

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
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorPROVEEDOR_AF(ByVal ID_PROVEEDOR_AF As Decimal)
        Dim miComponente As New cCONTRATO_PROVEEDOR_AF
        Dim Lista As New ListaCONTRATO_PROVEEDOR_AF

        Lista = miComponente.ObtenerListaPorPROVEEDOR_AF(ID_PROVEEDOR_AF)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "NUM_CONTRATO"
        Me.DataValueField = "ID_CONTRATO"

        Me.DataBind()

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla EJERCICIO .
    ''' </summary>
    ''' <param name="ID_EJERCICIO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorEJERCICIO(ByVal ID_EJERCICIO As String)
        Dim miComponente As New cCONTRATO_PROVEEDOR_AF
        Dim Lista As New ListaCONTRATO_PROVEEDOR_AF

        Lista = miComponente.ObtenerListaPorEJERCICIO(ID_EJERCICIO)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "NUM_CONTRATO"
        Me.DataValueField = "ID_CONTRATO"

        Me.DataBind()

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla PROGRAMA_FORMACION .
    ''' </summary>
    ''' <param name="ID_PROGRAMA_FORMACION"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorPROGRAMA_FORMACION(ByVal ID_PROGRAMA_FORMACION As Decimal)
        Dim miComponente As New cCONTRATO_PROVEEDOR_AF
        Dim Lista As New ListaCONTRATO_PROVEEDOR_AF

        Lista = miComponente.ObtenerListaPorPROGRAMA_FORMACION(ID_PROGRAMA_FORMACION)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "NUM_CONTRATO"
        Me.DataValueField = "ID_CONTRATO"

        Me.DataBind()

    End Sub

End Class
