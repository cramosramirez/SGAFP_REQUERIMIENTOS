Partial Class ddlAREA_FORMACION

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el DropDownList con los Datos de la Tabla AREA_FORMACION
    ''' filtrada por Proveedor y Ejercicio, lo cual a su vez incorpora las Areas de Formacion 
    ''' que si tengan Oferta Formativa definida para el Proveedor y Ejercicio enviado de parametro.
    ''' </summary>
    ''' <remarks>
    ''' Si la tabla es de llave compuesta, recibe los parametros de la Tabla Padre
    ''' </remarks>
    ''' <history>
    ''' 	[ecarias]	20/04/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorProveedorEjercicio(ByVal ID_PROVEEDOR_AF As Decimal, ByVal ID_EJERCICIO As String)
        Dim miComponente As New cAREA_FORMACION
        Dim Lista As New listaAREA_FORMACION

        Lista = miComponente.ObtenerListaPorProveedorEjercicio(ID_PROVEEDOR_AF, ID_EJERCICIO, "AREA_FORMACION")
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "AREA_FORMACION"
        Me.DataValueField = "ID_AREA_FORMACION"

        Me.DataBind()
    End Sub


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el DropDownList con los Datos de la Tabla AREA_FORMACION
    ''' filtrada por Proveedor, Sitio de Capacitación y Ejercicio, lo cual a su vez incorpora las Areas de Formacion 
    ''' que si tengan Oferta Formativa definida para el Proveedor, Sitio de Capacitación y Ejercicio enviado de parametro.
    ''' </summary>
    ''' <remarks>
    ''' Si la tabla es de llave compuesta, recibe los parametros de la Tabla Padre
    ''' </remarks>
    ''' <history>
    ''' 	[ecarias]	23/04/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorProveedorSitioEjercicio(ByVal ID_PROVEEDOR_AF As Decimal, ByVal ID_SITIO_CAPACITACION As Decimal, ByVal ID_EJERCICIO As String)
        Dim miComponente As New cAREA_FORMACION
        Dim Lista As New listaAREA_FORMACION

        Lista = miComponente.ObtenerListaPorProveedorSitioEjercicio(ID_PROVEEDOR_AF, ID_SITIO_CAPACITACION, ID_EJERCICIO, False, "AREA_FORMACION")
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "AREA_FORMACION"
        Me.DataValueField = "ID_AREA_FORMACION"

        Me.DataBind()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el DropDownList con los Datos de la Tabla AREA_FORMACION
    ''' filtrada por una OFERTA_FORMATIVA específica
    ''' </summary>
    ''' <remarks>
    ''' Si la tabla es de llave compuesta, recibe los parametros de la Tabla Padre
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	03/01/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorOFERTA_FORMATIVA(ByVal ID_OFERTA_FORMATIVA As Decimal)
        Dim miComponente As New cAREA_FORMACION
        Dim Lista As New listaAREA_FORMACION
        Dim lEntidadOferta As OFERTA_FORMATIVA

        lEntidadOferta = (New cOFERTA_FORMATIVA).ObtenerOFERTA_FORMATIVA(ID_OFERTA_FORMATIVA, False, True)
        Lista.Add(miComponente.ObtenerAREA_FORMACION(lEntidadOferta.fkID_TEMA_CURSO.ID_AREA_FORMACION))
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "AREA_FORMACION"
        Me.DataValueField = "ID_AREA_FORMACION"

        Me.DataBind()
    End Sub


End Class
