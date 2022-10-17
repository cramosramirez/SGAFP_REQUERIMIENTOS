Imports DevExpress.Web

Partial Class controles_ucCriteriosConsultaEjecucion
    Inherits ucBase

#Region " Propiedades "
    Public Property ucIDClientInstanceCallbackPanel() As String
        Get
            If Me.ViewState("IdClientCallback") Is Nothing Then Return "CallbackPanel"
            Return Me.ViewState("IdClientCallback")
        End Get
        Set(ByVal value As String)
            Me.ViewState("IdClientCallback") = value
        End Set
    End Property

    Public Property VerProveedor() As Boolean
        Get
            Return Me.trProveedor.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trProveedor.Visible = value
        End Set
    End Property

    Public Property VerPrograma() As Boolean
        Get
            Return Me.trPrograma.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trPrograma.Visible = value
        End Set
    End Property

    Public Property VerCentroFormacion() As Boolean
        Get
            Return Me.trCentroFormacion.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trCentroFormacion.Visible = value
        End Set
    End Property

    Public Property VerEjercicio() As Boolean
        Get
            Return Me.trEjercicio.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trEjercicio.Visible = value
        End Set
    End Property

    Public Property VerAreaFormacion() As Boolean
        Get
            Return Me.trAreaFormacion.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trAreaFormacion.Visible = value
        End Set
    End Property

    Public Property VerCodigoGrupo() As Boolean
        Get
            Return Me.trCodigoGrupo.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trCodigoGrupo.Visible = value
        End Set
    End Property

    Public Property VerClasificacionCursos() As Boolean
        Get
            Return Me.trClasificacionCursos.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trClasificacionCursos.Visible = value
        End Set
    End Property

    Public Property VerBotonMostrar() As Boolean
        Get
            Return Me.trMostrar.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trMostrar.Visible = value
        End Set
    End Property

    Private Sub SetClickPerformCallback()
        Dim scriptClick As New StringBuilder
        Dim Criterios As New StringBuilder

        'Definir los parámetros a enviar al método PerformCallback de CallbackPanel
        If Me.trPrograma.Visible Then
            If Criterios.Length > 0 Then Criterios.Append(" + ';' + ")
            Criterios.Append(Me.cbxTipoSolicitud.ClientInstanceName + ".GetValue()")
        End If
        If Me.trProveedor.Visible Then
            If Criterios.Length > 0 Then Criterios.Append(" + ';' + ")
            Criterios.Append(Me.cbxProveedor.ClientInstanceName + ".GetValue()")
        End If
        If Me.trCentroFormacion.Visible Then
            If Criterios.Length > 0 Then Criterios.Append(" + ';' + ")
            Criterios.Append(Me.cbxCentroFormacion.ClientInstanceName + ".GetValue()")
        End If
        If Me.trEjercicio.Visible Then
            If Criterios.Length > 0 Then Criterios.Append(" + ';' + ")
            Criterios.Append(Me.cbxEjercicio.ClientInstanceName + ".GetValue()")
        End If
        If Me.trAreaFormacion.Visible Then
            If Criterios.Length > 0 Then Criterios.Append(" + ';' + ")
            Criterios.Append(Me.cbxAreaFormacion.ClientInstanceName + ".GetValue()")
        End If
        If Me.trCodigoGrupo.Visible Then
            If Criterios.Length > 0 Then Criterios.Append(" + ';' + ")
            Criterios.Append(Me.txtCodigoGrupo.ClientInstanceName + ".GetValue()")
        End If
        If Me.trClasificacionCursos.Visible Then
            If Criterios.Length > 0 Then Criterios.Append(" + ';' + ")
            Criterios.Append(Me.cbxEjecucion.ClientInstanceName + ".GetValue()")
        End If

        'Implementando el evento click
        scriptClick.Append("  function(s, e){ ")
        scriptClick.Append(Me.ucIDClientInstanceCallbackPanel + ".PerformCallback(")
        scriptClick.Append(Criterios.ToString)
        scriptClick.Append(");")
        scriptClick.Append("  } ")

        Me.btnMostrar.ClientSideEvents.Click = scriptClick.ToString
    End Sub

#End Region
    Private Sub CargarTipoSolicitud()
        Me.cbxTipoSolicitud.DataBind()
        Me.cbxTipoSolicitud.SelectedItem = Me.cbxTipoSolicitud.Items.FindByValue(hf("selTipoSolicitud"))
        If Not Me.EstaEnRol(RolDeUsuario.ProveedorPATI) AndAlso (Me.EstaEnRol(RolDeUsuario.Proveedor) Or Me.EstaEnRol(RolDeUsuario.CentroCapacitador)) Then
            Me.cbxTipoSolicitud.ClientEnabled = False
        ElseIf Me.EstaEnRol(RolDeUsuario.ProveedorPATI) AndAlso Not Me.EstaEnRol(RolDeUsuario.Proveedor) AndAlso Not Me.EstaEnRol(RolDeUsuario.CentroCapacitador) Then
            Me.cbxTipoSolicitud.ClientEnabled = False
        End If
    End Sub

    Private Sub CargarProveedores(ByVal ID_TIPO_SOLICITUD As Integer)
        Me.odsProveedor.SelectParameters("ID_TIPO_SOLICITUD").DefaultValue = ID_TIPO_SOLICITUD
        Me.cbxProveedor.DataBind()
        Me.cbxProveedor.Items.Add(New ASPxEditors.ListEditItem("[Todos]", -1))

        Me.cbxProveedor.SelectedItem = Me.cbxProveedor.Items.FindByValue(CInt(hf("selProveedor")))
        If Me.EstaEnRol(RolDeUsuario.Proveedor) Or Me.EstaEnRol(RolDeUsuario.CentroCapacitador) Then
            Me.cbxProveedor.ClientEnabled = False
            Me.CargarCentros(Me.ObtenerIdProveedorAF)
        Else
            Me.CargarCentros(hf("selProveedor"))
        End If
    End Sub

    Private Sub CargarCentros(ByVal ID_PROVEEDOR_AF As Decimal)
        Me.odsCentroFormacion.SelectParameters("ID_PROVEEDOR_AF").DefaultValue = ID_PROVEEDOR_AF
        Me.cbxCentroFormacion.DataBind()
        Me.cbxCentroFormacion.Items.Add(New ASPxEditors.ListEditItem("[Todos]", -1))

        Me.cbxCentroFormacion.SelectedItem = Me.cbxCentroFormacion.Items.FindByValue(CInt(hf("selCentro")))
        If Me.EstaEnRol(RolDeUsuario.CentroCapacitador) Then
            Me.cbxCentroFormacion.ClientEnabled = False
        End If
    End Sub

    Private Sub CargarAreasFormacion()
        Me.cbxAreaFormacion.DataBind()
        Me.cbxAreaFormacion.Items.Add(New ASPxEditors.ListEditItem("[Todos]", "-1"))
    End Sub

    Private Sub SetearCampos()
        Me.cbxAreaFormacion.Text = "[Todos]"
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack And Not Page.IsCallback Then
            If Not Me.EstaEnRol(RolDeUsuario.ProveedorPATI) AndAlso (Me.EstaEnRol(RolDeUsuario.Proveedor) Or Me.EstaEnRol(RolDeUsuario.CentroCapacitador)) Then
                Me.hf.Add("selTipoSolicitud", 1)
            ElseIf Me.EstaEnRol(RolDeUsuario.ProveedorPATI) AndAlso Not Me.EstaEnRol(RolDeUsuario.Proveedor) AndAlso Not Me.EstaEnRol(RolDeUsuario.CentroCapacitador) Then
                Me.hf.Add("selTipoSolicitud", 2)
            Else
                Me.hf.Add("selTipoSolicitud", 1)
            End If
            If Me.EstaEnRol(RolDeUsuario.Proveedor) OrElse Me.EstaEnRol(RolDeUsuario.ProveedorPATI) OrElse Me.EstaEnRol(RolDeUsuario.CentroCapacitador) Then
                Me.hf.Add("selProveedor", Me.ObtenerIdProveedorAF)
            Else
                Me.hf.Add("selProveedor", -1)
            End If
            If Me.EstaEnRol(RolDeUsuario.CentroCapacitador) Then
                Me.hf.Add("selCentro", Me.ObtenerIdSitioCapacitacion)
            Else
                Me.hf.Add("selCentro", -1)
            End If
        End If
        CargarInformacion()
    End Sub

    Private Sub CargarInformacion()
        Me.CargarTipoSolicitud()
        Me.CargarProveedores(Me.hf("selTipoSolicitud"))
        Me.CargarCentros(Me.hf("selProveedor"))
        Me.CargarAreasFormacion()
        Me.SetearCampos()
        Me.SetClickPerformCallback()
        Me.cbxEjercicio.Value = Today.ToString("yyyy")
    End Sub

    Protected Sub cbxCentroFormacion_Callback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxClasses.CallbackEventArgsBase) Handles cbxCentroFormacion.Callback
        Me.hf("selProveedor") = CInt(e.Parameter)
        Me.hf("selCentro") = -1
        Me.CargarCentros(e.Parameter)
    End Sub

    Protected Sub cbxProveedor_Callback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxClasses.CallbackEventArgsBase) Handles cbxProveedor.Callback
        Me.hf("selTipoSolicitud") = CInt(e.Parameter)
        Me.hf("selProveedor") = -1
        Me.hf("selCentro") = -1
        Me.CargarProveedores(e.Parameter)
    End Sub
End Class
