Partial Class ddlSITIO_CAPACITACION
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla PROVEEDOR_AF y la Tabla TECNICOS_SITIOS_ASIG.
    ''' </summary>
    ''' <param name="USUARIO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	01/06/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorTECNICO(ByVal ID_PROVEEDOR_AF As Decimal, ByVal USUARIO As String)
        Dim miComponente As New cSITIO_CAPACITACION
        Dim Lista As New listaSITIO_CAPACITACION

        Lista = miComponente.ObtenerListaPorTECNICO(ID_PROVEEDOR_AF, USUARIO)
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
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla PROVEEDOR_AF y la Tabla DEPARTAMENTO.
    ''' </summary>
    ''' <param name="ID_PROVEEDOR_AF"></param>
    ''' <param name="CODIGO_DEPARTAMENTO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	07/07/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorPROVEEDOR_AF_DEPARTAMENTO(ByVal ID_PROVEEDOR_AF As Decimal, ByVal CODIGO_DEPARTAMENTO As String)
        Dim miComponente As New cSITIO_CAPACITACION
        Dim Lista As New listaSITIO_CAPACITACION

        Lista = miComponente.ObtenerListaPorPROVEEDOR_AF_DEPARTAMENTO(ID_PROVEEDOR_AF, CODIGO_DEPARTAMENTO)
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
