Imports System.ComponentModel
Imports System.Web.UI

''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_WebUC
''' Class	 : WebUC.lbSOLICITUD_INSCRIPCION_AF
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista de Seleccion Web
''' de la tabla SOLICITUD_INSCRIPCION_AF
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	19/01/2011	Created
''' </history>
''' -----------------------------------------------------------------------------
<DefaultProperty("ID_SOLICITUD"), ToolboxData("<{0}:lbSOLICITUD_INSCRIPCION_AF runat=server></{0}:lbSOLICITUD_INSCRIPCION_AF>")> _
Public Class lbSOLICITUD_INSCRIPCION_AF
    Inherits lbBase

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el ListBox con los Datos de la Tabla SOLICITUD_INSCRIPCION_AF.
    ''' </summary>
    ''' <remarks>
    ''' Si la tabla es de llave compuesta, recibe los parametros de la Tabla Padre
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/01/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub Recuperar()
        Dim miComponente As New cSOLICITUD_INSCRIPCION_AF
        Dim Lista As New ListaSOLICITUD_INSCRIPCION_AF

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "FECHA_PRESENTACION"
        Me.DataValueField = "ID_SOLICITUD"

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
        Dim miComponente As New cSOLICITUD_INSCRIPCION_AF
        Dim Lista As New ListaSOLICITUD_INSCRIPCION_AF

        Lista = miComponente.ObtenerListaPorPARTICIPANTE(ID_PARTICIPANTE)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "FECHA_PRESENTACION"
        Me.DataValueField = "ID_SOLICITUD"

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
    ''' 	[GenApp]	19/01/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorACCION_FORMATIVA(ByVal ID_ACCION_FORMATIVA As Decimal)
        Dim miComponente As New cSOLICITUD_INSCRIPCION_AF
        Dim Lista As New ListaSOLICITUD_INSCRIPCION_AF

        Lista = miComponente.ObtenerListaPorACCION_FORMATIVA(ID_ACCION_FORMATIVA)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "FECHA_PRESENTACION"
        Me.DataValueField = "ID_SOLICITUD"

        Me.DataBind()

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla ESTADO_SOLICITUD .
    ''' </summary>
    ''' <param name="ID_ESTADO_SOLICITUD"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/01/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorESTADO_SOLICITUD(ByVal ID_ESTADO_SOLICITUD As Decimal)
        Dim miComponente As New cSOLICITUD_INSCRIPCION_AF
        Dim Lista As New ListaSOLICITUD_INSCRIPCION_AF

        Lista = miComponente.ObtenerListaPorESTADO_SOLICITUD(ID_ESTADO_SOLICITUD)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "FECHA_PRESENTACION"
        Me.DataValueField = "ID_SOLICITUD"

        Me.DataBind()

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla TIPO_SOLICITUD .
    ''' </summary>
    ''' <param name="ID_TIPO_SOLICITUD"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/01/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorTIPO_SOLICITUD(ByVal ID_TIPO_SOLICITUD As Decimal)
        Dim miComponente As New cSOLICITUD_INSCRIPCION_AF
        Dim Lista As New ListaSOLICITUD_INSCRIPCION_AF

        Lista = miComponente.ObtenerListaPorTIPO_SOLICITUD(ID_TIPO_SOLICITUD)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "FECHA_PRESENTACION"
        Me.DataValueField = "ID_SOLICITUD"

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
        Dim miComponente As New cSOLICITUD_INSCRIPCION_AF
        Dim Lista As New ListaSOLICITUD_INSCRIPCION_AF

        Lista = miComponente.ObtenerListaPorPAIS(ID_PAIS)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "FECHA_PRESENTACION"
        Me.DataValueField = "ID_SOLICITUD"

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
        Dim miComponente As New cSOLICITUD_INSCRIPCION_AF
        Dim Lista As New ListaSOLICITUD_INSCRIPCION_AF

        Lista = miComponente.ObtenerListaPorESTADO_CIVIL(ID_ESTADO_CIVIL)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "FECHA_PRESENTACION"
        Me.DataValueField = "ID_SOLICITUD"

        Me.DataBind()

    End Sub


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla EDUC_LEE_ESCRIBE .
    ''' </summary>
    ''' <param name="ID_LEE_ESCRIBE"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/01/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorEDUC_LEE_ESCRIBE(ByVal ID_LEE_ESCRIBE As Decimal)
        Dim miComponente As New cSOLICITUD_INSCRIPCION_AF
        Dim Lista As New ListaSOLICITUD_INSCRIPCION_AF

        Lista = miComponente.ObtenerListaPorEDUC_LEE_ESCRIBE(ID_LEE_ESCRIBE)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "FECHA_PRESENTACION"
        Me.DataValueField = "ID_SOLICITUD"

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
        Dim miComponente As New cSOLICITUD_INSCRIPCION_AF
        Dim Lista As New ListaSOLICITUD_INSCRIPCION_AF

        Lista = miComponente.ObtenerListaPorNIVEL_ACADEMICO(ID_NIVEL_ACADEMICO)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "FECHA_PRESENTACION"
        Me.DataValueField = "ID_SOLICITUD"

        Me.DataBind()

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla TIEMPO_DEJO_ESTUDIAR .
    ''' </summary>
    ''' <param name="ID_TIEMPO_DEJO_ESTUDIAR"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/01/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorTIEMPO_DEJO_ESTUDIAR(ByVal ID_TIEMPO_DEJO_ESTUDIAR As Decimal)
        Dim miComponente As New cSOLICITUD_INSCRIPCION_AF
        Dim Lista As New ListaSOLICITUD_INSCRIPCION_AF

        Lista = miComponente.ObtenerListaPorTIEMPO_DEJO_ESTUDIAR(ID_TIEMPO_DEJO_ESTUDIAR)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "FECHA_PRESENTACION"
        Me.DataValueField = "ID_SOLICITUD"

        Me.DataBind()

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla REFERENCIA .
    ''' </summary>
    ''' <param name="ID_REFERENCIA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/01/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorREFERENCIA(ByVal ID_REFERENCIA As Decimal)
        Dim miComponente As New cSOLICITUD_INSCRIPCION_AF
        Dim Lista As New ListaSOLICITUD_INSCRIPCION_AF

        Lista = miComponente.ObtenerListaPorREFERENCIA(ID_REFERENCIA)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "FECHA_PRESENTACION"
        Me.DataValueField = "ID_SOLICITUD"

        Me.DataBind()

    End Sub

End Class
