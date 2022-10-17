Imports System.ComponentModel
Imports System.Web.UI

''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_WebUC
''' Class	 : WebUC.ddlCONTRATO_PROVEEDOR_AF
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista Desplegable Web
''' de la tabla CONTRATO_PROVEEDOR_AF
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	05/10/2012	Created
''' </history>
''' -----------------------------------------------------------------------------
<DefaultProperty("ID_CONTRATO"), ToolboxData("<{0}:ddlCONTRATO_BOLPROS runat=server></{0}:ddlCONTRATO_BOLPROS>")> _
Public Class ddlCONTRATO_BOLPROS
    Inherits ddlBase

    Private Sub RecuperarLista()
        Dim miComponente As New cCONTRATO_PROVEEDOR_AF
        Dim Lista As New listaCONTRATO_PROVEEDOR_AF

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
    ''' Función que Recupera el DropDownList con los Datos de la Tabla CONTRATO_PROVEEDOR_AF.
    ''' </summary>
    ''' <remarks>
    ''' Si la tabla es de llave compuesta, recibe los parametros de la Tabla Padre
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub Recuperar()
        RecuperarLista()
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
    Public Sub RecuperarPorPROVEEDOR_AF_PAGO_PARTICIPANTE(ByVal ID_PROVEEDOR_AF As Decimal, ByVal ES_PAGO_PARTICIPANTE As Decimal)
        Dim miComponente As New cCONTRATO_BOLPROS
        Dim Lista As New listaCONTRATO_BOLPROS
        Dim lContratoEmpty As New CONTRATO_BOLPROS

        Lista = miComponente.ObtenerListaPorPROVEEDOR_AF_PAGO_PARTICIPANTE(ID_PROVEEDOR_AF, ES_PAGO_PARTICIPANTE, "FECHA_FIN_EJEC DESC, NUM_CONTRATO ASC, LOTE", "ASC")
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        Else
            lContratoEmpty.ID_CONTRATO = -1
            lContratoEmpty.NUM_CONTRATO = ""
            Lista.Insert(0, lContratoEmpty)
        End If



        Me.DataSource = Lista
        Me.DataTextField = "DESCRIPCION_CONTRATO"
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
    Public Sub RecuperarPorPROVEEDOR_PROGRAMA_FORMACION(ByVal ID_PROVEEDOR_AF As Decimal, ByVal ID_PROGRAMA_FORMACION As Decimal)
        Dim miComponente As New cCONTRATO_BOLPROS
        Dim Lista As New listaCONTRATO_BOLPROS
        Dim lContratoEmpty As New CONTRATO_BOLPROS

        Lista = miComponente.ObtenerListaPorCriterios(ID_PROVEEDOR_AF, ID_PROGRAMA_FORMACION, "", -1, "", "NUM_CONTRATO")
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        Else
            lContratoEmpty.ID_CONTRATO = -1
            lContratoEmpty.NUM_CONTRATO = ""
            Lista.Insert(0, lContratoEmpty)
        End If



        Me.DataSource = Lista
        Me.DataTextField = "DESCRIPCION_CONTRATO"
        Me.DataValueField = "ID_CONTRATO"

        Me.DataBind()

    End Sub

    

End Class

