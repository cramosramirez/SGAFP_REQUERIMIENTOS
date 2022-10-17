Imports System.Collections.Generic
Imports SGAFP.EL.Enumeradores

Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs)
        'If Not IsPostBack Then
        CargarAlerta()
        'End If
    End Sub

    Private Sub CargarAlerta()
        If Request.IsAuthenticated Then
            Dim lUsuario As USUARIO
            Dim listaRoles As New List(Of String)
            Dim listaIdEstadoInforme As New List(Of Decimal)
            Dim listaInformes As listaINFORME_FINAL_AF
            Dim bAccionPrograRetro As New cACCION_PROGRA_RETRO
            Dim c As SQLMembershipProvider.BL.cmembershipProvider

            'Obteniendo los Roles asignados al usuario actual
            lUsuario = (New cUSUARIO).ObtenerUSUARIO(Me.User.Identity.Name)
            c = CType(System.Web.Security.Membership.Provider, SQLMembershipProvider.BL.cmembershipProvider)
            listaRoles = c.ObtenerRoles(lUsuario.USUARIO)

            'Estableciendo los Estados de los Informes a Mostrar
            If lUsuario.ID_PROVEEDOR_AF > 0 Then
                listaIdEstadoInforme.Add(EstadoInformeFinal.InformeDevueltoConObservaciones)
                listaIdEstadoInforme.Add(EstadoInformeFinal.FacturaSolicitadaProveedor)
                Me.lblMensaje.Text = "IMPORTANTE: Informes que requieren la intervención del Proveedor / Centro de Formación. El Estado indica el proceso a solventar."
            ElseIf (Utilerias.EstaEnRol(RolDeUsuario.GerenteGFI) OrElse Utilerias.EstaEnRol(RolDeUsuario.TecnicoGFI) OrElse Utilerias.EstaEnRol(RolDeUsuario.SoporteGFI) OrElse Utilerias.EstaEnRol(RolDeUsuario.CoordinadorGFI)) Then
                listaIdEstadoInforme.Add(EstadoInformeFinal.InformeConObservacionesSolventadas)
                listaIdEstadoInforme.Add(EstadoInformeFinal.InformeDevueltoPorUACI)
                Me.lblMensaje.Text = "IMPORTANTE: Informes que requieren la intervención del Personal Técnico. El Estado indica el proceso a solventar."
            End If

            If listaIdEstadoInforme.Count > 0 Then
                listaInformes = (New cINFORME_FINAL_AF).ObtenerListaPorCriteriosRoles(lUsuario.ID_PROVEEDOR_AF, _
                                                                               lUsuario.ID_SITIO_CAPACITACION, "", "", _
                                                                               listaRoles, _
                                                                               listaIdEstadoInforme)
                If listaInformes IsNot Nothing AndAlso listaInformes.Count > 0 Then
                    Me.lblMensaje.Visible = True
                    Me.ucListaINFORME_FINAL_AF1.CargarListaPorCriteriosRoles(lUsuario.ID_PROVEEDOR_AF, _
                                                                            lUsuario.ID_SITIO_CAPACITACION, "", "", _
                                                                            listaRoles, _
                                                                            listaIdEstadoInforme)
                    Me.ucListaINFORME_FINAL_AF1.Visible = True
                End If
            End If
        End If
    End Sub
End Class
