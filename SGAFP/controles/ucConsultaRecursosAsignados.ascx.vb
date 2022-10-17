
Partial Class controles_ucConsultaRecursosAsignados
    Inherits ucBase


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros del ConsultaEjecucionOfertaTableAdapter.GetDataByCursosEnEjecucion
    ''' filtrado por el Ejercicio
    ''' </summary>
    ''' <param name="ID_EJERCICIO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	06/09/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorEjercicio(ByVal ID_EJERCICIO As String) As Integer
        If Me.Session("ucConsultaRecursosAsignados_Ejercicio") Is Nothing Then Me.Session("ucConsultaRecursosAsignados_Ejercicio") = ID_EJERCICIO

        Select Case True
            Case Me.EstaEnRol(RolDeUsuario.Proveedor)
                Me.odsRecursosAsignadosProveedor.SelectParameters("ID_EJERCICIO").DefaultValue = ID_EJERCICIO
                Me.odsRecursosAsignados.SelectParameters("ID_PROVEEDOR_AF").DefaultValue = Me.ObtenerIdProveedorAF
                Me.pgRecursos.DataSourceID = "odsRecursosAsignadosProveedor"

            Case Me.EstaEnRol(RolDeUsuario.TecnicoCentroHTP), Me.EstaEnRol(RolDeUsuario.JefeHTP), _
                    Me.EstaEnRol(RolDeUsuario.GerenteGFI), Me.EstaEnRol(RolDeUsuario.Administrador)

                Me.odsRecursosAsignados.SelectParameters("ID_EJERCICIO").DefaultValue = ID_EJERCICIO
                Me.pgRecursos.DataSourceID = "odsRecursosAsignados"

            Case Else
                Me.AsignarMensaje("No se logró recuperar la información para el Rol del Usuario Actual", True, True)
                Return -1
        End Select

        Me.pgRecursos.DataBind()
        Return 1
    End Function

    Protected Sub pgRecursos_CustomCallback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxPivotGrid.PivotGridCustomCallbackEventArgs) Handles pgRecursos.CustomCallback
        Me.Session("ucConsultaRecursosAsignados_Ejercicio") = e.Parameters
        Me.CargarDatosPorEjercicio(e.Parameters)
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsCallback Then
            Me.Session("ucConsultaRecursosAsignados_Ejercicio") = Nothing
        Else
            If Not Me.Session("ucConsultaRecursosAsignados_Ejercicio") Is Nothing Then
                Me.CargarDatosPorEjercicio(Me.Session("ucConsultaRecursosAsignados_Ejercicio"))
            End If
        End If
    End Sub

    Protected Sub pgRecursos_CustomUnboundFieldData(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxPivotGrid.CustomFieldDataEventArgs) Handles pgRecursos.CustomUnboundFieldData
        If Object.ReferenceEquals(e.Field, Me.pgRecursos.Fields("fieldTOTAL")) Then
            e.Value = Convert.ToDecimal(e.GetListSourceColumnValue("RECURSOS")) - _
                    Convert.ToDecimal(e.GetListSourceColumnValue("EJECUCION")) - _
                    Convert.ToDecimal(e.GetListSourceColumnValue("FINALIZADO"))
        End If
    End Sub
End Class
