Imports System.ComponentModel
Imports System.Web.UI

''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_WebUC
''' Class	 : WebUC.lbPARTICIPANTE
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista de Seleccion Web
''' de la tabla PARTICIPANTE
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	19/01/2011	Created
''' </history>
''' -----------------------------------------------------------------------------
<DefaultProperty("ID_PARTICIPANTE"), ToolboxData("<{0}:lbPARTICIPANTE runat=server></{0}:lbPARTICIPANTE>")> _
Public Class lbPARTICIPANTE
    Inherits lbBase

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el ListBox con los Datos de la Tabla PARTICIPANTE.
    ''' </summary>
    ''' <remarks>
    ''' Si la tabla es de llave compuesta, recibe los parametros de la Tabla Padre
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/01/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub Recuperar()
        Dim miComponente As New cPARTICIPANTE
        Dim Lista As New ListaPARTICIPANTE

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "NOMBRES"
        Me.DataValueField = "ID_PARTICIPANTE"

        Me.DataBind()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla PAIS .
    ''' </summary>
    ''' <param name="ID_PAIS"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/01/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorPAIS(ByVal ID_PAIS As Decimal)
        Dim miComponente As New cPARTICIPANTE
        Dim Lista As New ListaPARTICIPANTE

        Lista = miComponente.ObtenerListaPorPAIS(ID_PAIS)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "NOMBRES"
        Me.DataValueField = "ID_PARTICIPANTE"

        Me.DataBind()

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla ESTADO_CIVIL .
    ''' </summary>
    ''' <param name="ID_ESTADO_CIVIL"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/01/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorESTADO_CIVIL(ByVal ID_ESTADO_CIVIL As Decimal)
        Dim miComponente As New cPARTICIPANTE
        Dim Lista As New ListaPARTICIPANTE

        Lista = miComponente.ObtenerListaPorESTADO_CIVIL(ID_ESTADO_CIVIL)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "NOMBRES"
        Me.DataValueField = "ID_PARTICIPANTE"

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
    ''' 	[GenApp]	19/01/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorDEPARTAMENTO(ByVal CODIGO_DEPARTAMENTO As String)
        Dim miComponente As New cPARTICIPANTE
        Dim Lista As New ListaPARTICIPANTE

        Lista = miComponente.ObtenerListaPorDEPARTAMENTO(CODIGO_DEPARTAMENTO)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "NOMBRES"
        Me.DataValueField = "ID_PARTICIPANTE"

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
    ''' 	[GenApp]	19/01/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorMUNICIPIO(ByVal CODIGO_DEPARTAMENTO As String, ByVal CODIGO_MUNICIPIO As String)
        Dim miComponente As New cPARTICIPANTE
        Dim Lista As New ListaPARTICIPANTE

        Lista = miComponente.ObtenerListaPorMUNICIPIO(CODIGO_DEPARTAMENTO, CODIGO_MUNICIPIO)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "NOMBRES"
        Me.DataValueField = "ID_PARTICIPANTE"

        Me.DataBind()

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla NIVEL_ACADEMICO .
    ''' </summary>
    ''' <param name="ID_NIVEL_ACADEMICO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/01/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorNIVEL_ACADEMICO(ByVal ID_NIVEL_ACADEMICO As Decimal)
        Dim miComponente As New cPARTICIPANTE
        Dim Lista As New ListaPARTICIPANTE

        Lista = miComponente.ObtenerListaPorNIVEL_ACADEMICO(ID_NIVEL_ACADEMICO)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "NOMBRES"
        Me.DataValueField = "ID_PARTICIPANTE"

        Me.DataBind()

    End Sub

End Class
