Imports DevExpress.Web.ASPxEditors
Imports SQLMembershipProvider.EL
Imports SQLMembershipProvider.BL

Partial Class controles_ucGestionOpciones
    Inherits ucBase

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Me.CargarDatos()
        End If
    End Sub

    Private Sub CargarDatos()

        ConfigurarOpcionMenu(39)

        'Me.AsignarTituloOpcion("Gestionar Opciones", "~/imagenes/pro.png")
        'Me.CrearOpcion("Agregar", "Agregar", False, "~/imagenes/Agregar.gif", "onclick", "if(cbSistemas.GetValue()!=null){tlOpciones.StartEditNewNode();}else{AsignarMensaje('Debe de seleccionar un Sistema');}e.processOnServer=false;")
        'Me.CargarOpciones()
        Me.odsOpcionesMenu.DataBind()
    End Sub

    Public Overrides Sub EjecutarOpcion(ByVal CommandName As String)
        If CommandName = "Sincronizar" Then
            Me.Sincronizar()
        End If
    End Sub

    Private Sub Sincronizar()

    End Sub

    Protected Sub tlOpciones_CustomCallback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxTreeList.TreeListCustomCallbackEventArgs) Handles tlOpciones.CustomCallback
        Dim argumentos() As String = e.Argument.Split(";")
        If argumentos.Length > 0 Then
            If argumentos(0) = "Recuperar" Then
                tlOpciones.DataBind()
            End If
        End If
    End Sub

    Protected Sub tlOpciones_HtmlRowPrepared(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxTreeList.TreeListHtmlRowEventArgs) Handles tlOpciones.HtmlRowPrepared
        If e.RowKind = DevExpress.Web.ASPxTreeList.TreeListRowKind.EditForm Then
            Dim cbTipoOpcion As ASPxComboBox = tlOpciones.FindEditFormTemplateControl("cbTipoOpcion")
            Dim cbOpcionPadre As ASPxComboBox = tlOpciones.FindEditFormTemplateControl("cbOpcionPadre")
            Dim seOrden As ASPxSpinEdit = tlOpciones.FindEditFormTemplateControl("seOrden")
            Dim txtIdOpcionMenu As ASPxTextBox = tlOpciones.FindEditFormTemplateControl("txtIdOpcionMenu")
            Dim chkbxCausaValidacion As ASPxCheckBox = tlOpciones.FindEditFormTemplateControl("chkbxCausaValidacion")
            Dim txtAtributoKey As ASPxTextBox = tlOpciones.FindEditFormTemplateControl("txtAtributoKey")
            Dim txtAtributoValue As ASPxTextBox = tlOpciones.FindEditFormTemplateControl("txtAtributoValue")
            Dim lblCausaValidacion As ASPxLabel = tlOpciones.FindEditFormTemplateControl("lblCausaValidacion")
            Dim lblAtributoKey As ASPxLabel = tlOpciones.FindEditFormTemplateControl("lblAtributoKey")
            Dim lblAtributoValue As ASPxLabel = tlOpciones.FindEditFormTemplateControl("lblAtributoValue")

            If e.NodeKey Is Nothing Then
                cbTipoOpcion.SelectedIndex = 0
                cbOpcionPadre.SelectedIndex = -1
                seOrden.Value = 0
                txtIdOpcionMenu.Text = "0"
                chkbxCausaValidacion.Checked = False
                txtAtributoKey.Text = ""
                txtAtributoValue.Text = ""

                chkbxCausaValidacion.ClientVisible = False
                txtAtributoKey.ClientVisible = False
                txtAtributoValue.ClientVisible = False

                lblCausaValidacion.ClientVisible = False
                lblAtributoKey.ClientVisible = False
                lblAtributoValue.ClientVisible = False
            Else
                Dim lOpcion As OpcionesMenu = (New cOpcionesMenu).ObtenerOpcionesMenu(e.NodeKey)
                cbTipoOpcion.Value = lOpcion.TipoOpcion
                If lOpcion.IdPadre = 0 Then
                    cbOpcionPadre.SelectedIndex = -1
                Else
                    cbOpcionPadre.Value = lOpcion.IdPadre
                End If
                If lOpcion.TipoOpcion = "A" Then

                End If
                seOrden.Value = lOpcion.OrdenOpcionMenu

                chkbxCausaValidacion.ClientVisible = (lOpcion.TipoOpcion = "A")
                txtAtributoKey.ClientVisible = (lOpcion.TipoOpcion = "A")
                txtAtributoValue.ClientVisible = (lOpcion.TipoOpcion = "A")

                lblCausaValidacion.ClientVisible = (lOpcion.TipoOpcion = "A")
                lblAtributoKey.ClientVisible = (lOpcion.TipoOpcion = "A")
                lblAtributoValue.ClientVisible = (lOpcion.TipoOpcion = "A")

                'chkbxCausaValidacion.Checked = lOpcion.CausaValidacion
                'txtAtributoKey.Text = lOpcion.AtributoKey
                'txtAtributoValue.Text = lOpcion.AtributoValue
            End If

        End If
    End Sub

    Protected Sub tlOpciones_NodeInserting(ByVal sender As Object, ByVal e As DevExpress.Web.Data.ASPxDataInsertingEventArgs) Handles tlOpciones.NodeInserting

        e.NewValues("IdOpcionMenu") = 0

        Dim cbTipoOpcion As ASPxComboBox = tlOpciones.FindEditFormTemplateControl("cbTipoOpcion")
        Dim cbOpcionPadre As ASPxComboBox = tlOpciones.FindEditFormTemplateControl("cbOpcionPadre")
        Dim seOrden As ASPxSpinEdit = tlOpciones.FindEditFormTemplateControl("seOrden")
        e.NewValues("TipoOpcion") = cbTipoOpcion.Value
        If cbOpcionPadre.SelectedIndex = -1 Then
            e.NewValues("IdPadre") = 0
        Else
            e.NewValues("IdPadre") = cbOpcionPadre.Value
        End If
        e.NewValues("OrdenOpcionMenu") = seOrden.Value
        e.NewValues("IdSistema") = cbSistemas.Value
    End Sub

    Protected Sub tlOpciones_NodeUpdating(ByVal sender As Object, ByVal e As DevExpress.Web.Data.ASPxDataUpdatingEventArgs) Handles tlOpciones.NodeUpdating
        Dim cbTipoOpcion As ASPxComboBox = tlOpciones.FindEditFormTemplateControl("cbTipoOpcion")
        Dim cbOpcionPadre As ASPxComboBox = tlOpciones.FindEditFormTemplateControl("cbOpcionPadre")
        Dim seOrden As ASPxSpinEdit = tlOpciones.FindEditFormTemplateControl("seOrden")
        If cbTipoOpcion.Value Is Nothing Then
            e.NewValues("TipoOpcion") = e.OldValues("TipoOpcion")
            e.NewValues("IdSistema") = e.OldValues("IdSistema")
        Else
            e.NewValues("TipoOpcion") = cbTipoOpcion.Value
            If cbOpcionPadre.SelectedIndex = -1 Then
                e.NewValues("IdPadre") = 0
            Else
                e.NewValues("IdPadre") = cbOpcionPadre.Value
            End If
            e.NewValues("OrdenOpcionMenu") = seOrden.Value
            e.NewValues("IdSistema") = cbSistemas.Value
        End If
    

    End Sub

    Protected Sub callSync_Callback(ByVal source As Object, ByVal e As DevExpress.Web.ASPxCallback.CallbackEventArgs) Handles callSync.Callback
        Dim opciones() As String = e.Parameter.Split(",")
        'Dim cOpcionesDesa As New cOpcionesMenu
        'Dim cOpcionesProd As New cOpcionesMenu("LocalSqlServerProd")
        'For Each lOpcion As String In opciones
        '    Dim lOpcionMenu As OpcionesMenu = cOpcionesDesa.ObtenerOpcionesMenu(CInt(lOpcion))
        '    Dim lOpcionMenuProd As OpcionesMenu = cOpcionesProd.ObtenerOpcionesMenu(lOpcionMenu.IdOpcionMenu)
        '    If lOpcionMenuProd Is Nothing Then
        '        If cOpcionesProd.AgregarOpcionesMenu(lOpcionMenu) < 0 Then

        '        End If
        '    Else
        '        If cOpcionesProd.ActualizarOpcionesMenu(lOpcionMenu) < 0 Then

        '        End If
        '    End If
        'Next
        e.Result = "Opcion(es) sincronizada(s) satisfactoriamente."
    End Sub

End Class
