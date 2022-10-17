Imports System.Web.Security
Imports SQLMembershipProvider.BL

Public Class frmAsignacionCentro_Tecnico
    Dim listaTecnicosAsigEliminada As New listaTECNICOS_SITIOS_ASIG

    Private Sub frmAsignacionCentro_Tecnico_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CargarDatos()
        Dim listaTecnicos As New listaUSUARIO
        Dim _p As New cmembershipProvider
        _p = CType(Membership.Provider, cmembershipProvider)
        For Each lUsuario In (New cUSUARIO).ObtenerLista()
            Dim listaRoles As List(Of String) = _p.ObtenerRoles(lUsuario.USUARIO)
            If listaRoles IsNot Nothing AndAlso listaRoles.Contains(Enumeradores.RolDeUsuario.TecnicoCentroHTP) Then
                listaTecnicos.Add(lUsuario)
            End If
        Next
        Me.bsCriteriaUSUARIO.DataSource = listaTecnicos
        Me.bsCriteriaSITIO_CAPACITACION.DataSource = (New cSITIO_CAPACITACION).ObtenerLista()
    End Sub

    Sub CargarDatos()
        Me.bsTECNICOS_SITIOS_ASIG.DataSource = (New cTECNICOS_SITIOS_ASIG).ObtenerLista("USUARIO", "ASC")
    End Sub

    Private Sub bsTECNICOS_SITIOS_ASIG_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles bsTECNICOS_SITIOS_ASIG.AddingNew
        Dim lEntidad As New TECNICOS_SITIOS_ASIG
        lEntidad.LASTUPDATE = Now
        lEntidad.USERID = Utilerias.ObtenerUsuario
        lEntidad.ID_PROVEEDOR_AF = -1
        lEntidad.ID_SITIO_CAPACITACION = -1
        lEntidad.USUARIO = ""
        e.NewObject = lEntidad
    End Sub

    Private Sub TECNICOS_SITIOS_ASIGBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TECNICOS_SITIOS_ASIGBindingNavigatorSaveItem.Click
        Me.bsTECNICOS_SITIOS_ASIG.EndEdit()
        Dim bTecnicoSitio As New cTECNICOS_SITIOS_ASIG

        For Each lEntidad As TECNICOS_SITIOS_ASIG In Me.listaTecnicosAsigEliminada
            bTecnicoSitio.EliminarTECNICOS_SITIOS_ASIG(lEntidad, TipoConcurrencia.Pesimistica)
        Next
        For Each lEntidad As TECNICOS_SITIOS_ASIG In Me.bsTECNICOS_SITIOS_ASIG.DataSource
            If lEntidad.USUARIO = "" Then
                Me.AsignarMensaje("Para el Origen de Datos seleccionado debe ingresar un usuario", True)
                Return
            End If
            If lEntidad.ID_SITIO_CAPACITACION = -1 Then
                Me.AsignarMensaje("Para el Origen de Datos seleccionado debe ingresar un Centro de Formación", True)
                Return
            End If
            If lEntidad.ID_PROVEEDOR_AF = -1 Then
                lEntidad.ID_PROVEEDOR_AF = (New cSITIO_CAPACITACION).ObtenerSITIO_CAPACITACION(lEntidad.ID_SITIO_CAPACITACION).ID_PROVEEDOR_AF
            End If

            If bTecnicoSitio.ActualizarTECNICOS_SITIOS_ASIG(lEntidad) <> 1 Then
                Me.AsignarMensaje("Error al guardar registro " + lEntidad.USUARIO, True)
                Return
            End If
        Next
        Me.AsignarMensaje("Se han guardado los cambios")
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click
        Dim lEntidad As New TECNICOS_SITIOS_ASIG
        lEntidad = bsTECNICOS_SITIOS_ASIG.Current
        Me.listaTecnicosAsigEliminada.Add(lEntidad)
    End Sub
End Class