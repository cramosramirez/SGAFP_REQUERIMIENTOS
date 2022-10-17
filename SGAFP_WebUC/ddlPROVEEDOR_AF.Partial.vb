Partial Class ddlPROVEEDOR_AF
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por TECNICO .
    ''' </summary>
    ''' <param name="USUARIO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorTECNICO(ByVal USUARIO As String)
        Dim miComponente As New cPROVEEDOR_AF
        Dim Lista As New listaPROVEEDOR_AF

        Lista = miComponente.ObtenerListaPorTecnico(USUARIO)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "NOMBRE_PROVEEDOR"
        Me.DataValueField = "ID_PROVEEDOR_AF"

        Me.DataBind()

    End Sub


    Public Sub RecuperarPorDEPARTAMENTO_PRESENCIA_SITIO(ByVal CODIGO_REGION As String, ByVal CODIGO_DEPARTAMENTO As String)
        Dim miComponente As New cPROVEEDOR_AF
        Dim Lista As New listaPROVEEDOR_AF

        Lista = miComponente.ObtenerListaPorDepartamento_Presencia_Sitio(CODIGO_REGION, CODIGO_DEPARTAMENTO)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "NOMBRE_PROVEEDOR"
        Me.DataValueField = "ID_PROVEEDOR_AF"

        Me.DataBind()

    End Sub


    Public Sub RecuperarPorSITIO_CAPACITACION(ByVal ID_SITIO_CAPACITACION As Decimal)
        Dim miComponente As New cPROVEEDOR_AF
        Dim Lista As New listaPROVEEDOR_AF

        Lista = miComponente.ObtenerListaPorSitio_Capacitacion(ID_SITIO_CAPACITACION)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "NOMBRE_PROVEEDOR"
        Me.DataValueField = "ID_PROVEEDOR_AF"

        Me.DataBind()

    End Sub

    Public Sub RecuperarPorPROVEEDOR_HTP()
        Dim miComponente As New cPROVEEDOR_AF
        Dim Lista As New listaPROVEEDOR_AF

        Lista = miComponente.ObtenerListaProveedoresHTP("", "NOMBRE_PROVEEDOR")
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "NOMBRE_PROVEEDOR"
        Me.DataValueField = "ID_PROVEEDOR_AF"

        Me.DataBind()

    End Sub

End Class
