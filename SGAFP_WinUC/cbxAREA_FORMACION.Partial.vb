Partial Class cbxAREA_FORMACION

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el ComboBox con los Datos de la Tabla AREA_FORMACION
    ''' filtrada por Proveedor y Ejercicio, lo cual a su vez incorpora las Areas de Formacion 
    ''' que si tengan Oferta Formativa definida para el Proveedor y Ejercicio enviado de parametro.
    ''' </summary>
    ''' <remarks>
    ''' Si la tabla es de llave compuesta, recibe los parametros de la Tabla Padre
    ''' </remarks>
    ''' <history>
    ''' 	[ecarias]	24/06/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorProveedorEjercicio(ByVal ID_PROVEEDOR_AF As Decimal, ByVal ID_EJERCICIO As String, Optional ByVal agregarTodos As Boolean = False)
        Dim miComponente As New cAREA_FORMACION
        Dim Lista As New listaAREA_FORMACION

        Lista = miComponente.ObtenerListaPorProveedorEjercicio(ID_PROVEEDOR_AF, ID_EJERCICIO, False, "AREA_FORMACION")
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
        End If

        If agregarTodos Then
            Lista.Insert(0, New AREA_FORMACION(-1, "[Todas]", "", "", "", Nothing))
        End If

        Me.DisplayMember = "AREA_FORMACION"
        Me.ValueMember = "ID_AREA_FORMACION"
        Me.DataSource = Lista

    End Sub


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el ComboBox con los Datos de la Tabla AREA_FORMACION
    ''' filtrada por Proveedor, Sitio de Capacitación y Ejercicio, lo cual a su vez incorpora las Areas de Formacion 
    ''' que si tengan Oferta Formativa definida para el Proveedor, Sitio de Capacitación y Ejercicio enviado de parametro.
    ''' </summary>
    ''' <remarks>
    ''' Si la tabla es de llave compuesta, recibe los parametros de la Tabla Padre
    ''' </remarks>
    ''' <history>
    ''' 	[ecarias]	24/06/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorProveedorSitioEjercicio(ByVal ID_PROVEEDOR_AF As Decimal, ByVal ID_SITIO_CAPACITACION As Decimal, ByVal ID_EJERCICIO As String, Optional ByVal agregarTodos As Boolean = False)
        Dim miComponente As New cAREA_FORMACION
        Dim Lista As New listaAREA_FORMACION

        Lista = miComponente.ObtenerListaPorProveedorSitioEjercicio(ID_PROVEEDOR_AF, ID_SITIO_CAPACITACION, ID_EJERCICIO, False, "AREA_FORMACION")
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
            Return
        End If

        If agregarTodos Then
            Lista.Insert(0, New AREA_FORMACION(-1, "[Todas]", "", "", "", Nothing))
        End If

        Me.DisplayMember = "AREA_FORMACION"
        Me.ValueMember = "ID_AREA_FORMACION"
        Me.DataSource = Lista
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el ComboBox con los Datos de la Tabla AREA_FORMACION
    ''' filtrada por Proveedor, lo cual a su vez incorpora las Areas de Formacion 
    ''' que si tengan Oferta Formativa definida para el Proveedor y Ejercicio enviado de parametro.
    ''' </summary>
    ''' <remarks>
    ''' Si la tabla es de llave compuesta, recibe los parametros de la Tabla Padre
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	12/11/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorProveedor(ByVal ID_PROVEEDOR_AF As Decimal, Optional ByVal agregarTodos As Boolean = False)
        Dim miComponente As New cAREA_FORMACION
        Dim Lista As New listaAREA_FORMACION

        Lista = miComponente.ObtenerListaPorProveedor(ID_PROVEEDOR_AF, False, "AREA_FORMACION")
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
        End If

        If agregarTodos Then
            Lista.Insert(0, New AREA_FORMACION(-1, "[Todas]", "", "", "", Nothing))
        End If

        Me.DisplayMember = "AREA_FORMACION"
        Me.ValueMember = "ID_AREA_FORMACION"
        Me.DataSource = Lista

    End Sub

End Class
