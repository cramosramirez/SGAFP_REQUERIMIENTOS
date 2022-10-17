Partial Public Class ddlOFERTA_FORMATIVA

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla PROVEEDOR_AF .
    ''' </summary>
    ''' <param name="ID_AREA_FORMACION"></param>
    ''' <param name="ID_EJERCICIO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorAREA_FORMACION_PROVEEDOR_SITIO_EJERCICIO(ByVal ID_AREA_FORMACION As Decimal, ByVal ID_PROVEEDOR_AF As Decimal, ByVal ID_SITIO_CAPACITACION As Decimal, ByVal ID_EJERCICIO As String)
        Dim miComponente As New cOFERTA_FORMATIVA
        Dim Lista As New listaOFERTA_FORMATIVA

        Lista = miComponente.ObtenerOfertaFormativaPorAreaFormacion_Proveedor_Sitio_Ejercicio(ID_AREA_FORMACION, ID_PROVEEDOR_AF, ID_SITIO_CAPACITACION, ID_EJERCICIO)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "TEMA_CURSO"
        Me.DataValueField = "ID_OFERTA_FORMATIVA"

        Me.DataBind()

    End Sub

    Public Sub RecuperarPorCRITERIOS(ByVal ID_PROVEEDOR_AF As Decimal, ByVal ID_EJERCICIO As String, ByVal ID_AREA_FORMACION As Decimal)
        Dim miComponente As New cOFERTA_FORMATIVA
        Dim Lista As New listaOFERTA_FORMATIVA

        Lista = miComponente.ObtenerOfertaFormativaPorCriterios(ID_PROVEEDOR_AF, ID_EJERCICIO, ID_AREA_FORMACION)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "TEMA_CURSO"
        Me.DataValueField = "ID_OFERTA_FORMATIVA"

        Me.DataBind()

    End Sub

End Class
