Imports SGAFP.BL
Imports SGAFP.EL
Imports System.Collections.Generic
Imports DevExpress.Web.ASPxEditors
Imports DevExpress.Web.ASPxGridView
Imports DevExpress.Web.ASPxCallbackPanel
Imports SQLMembershipProvider.BL

''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucListaUSUARIO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar un listado de la tabla USUARIO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.6.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	29/10/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucListaUSUARIO
    Inherits ucListaBase
 
    Private mComponente As New cUSUARIO
    Public Event Seleccionado(ByVal USUARIO As String) 
    Public Event Editando(ByVal USUARIO As String)
    Private ListaUsuarios As New List(Of String)
    Private ListaRoles() As String = {""}

#Region"Propiedades"

    Public Property MostrarFooter() As Boolean
        Get
            Return Me.dxgvLista.SettingsPager.Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.SettingsPager.Visible = Value
        End Set
    End Property

    Public Property PermitirPaginacion() As Boolean
        Get
            If Me.dxgvLista.SettingsPager.Mode = DevExpress.Web.ASPxGridView.GridViewPagerMode.ShowPager Then
                Return True
            End If
            Return False
        End Get
        Set(ByVal Value As Boolean)
            If Value Then
                Me.dxgvLista.SettingsPager.Mode = DevExpress.Web.ASPxGridView.GridViewPagerMode.ShowPager
            Else
                Me.dxgvLista.SettingsPager.Mode = DevExpress.Web.ASPxGridView.GridViewPagerMode.ShowAllRecords
            End If
        End Set
    End Property

    Private _PermitirEditar As Boolean = False
    Public Property PermitirEditar() As Boolean
        Get
            Return _PermitirEditar
        End Get
        Set(ByVal Value As Boolean)
            _PermitirEditar = Value
            If Not Me.ViewState("PermitirEditar") Is Nothing Then Me.ViewState.Remove("PermitirEditar")
            Me.ViewState.Add("PermitirEditar", Value)
        End Set
    End Property

    Private _PermitirSeleccionar As Boolean = False
    Public Property PermitirSeleccionar() As Boolean
        Get
            Return _PermitirSeleccionar
        End Get
        Set(ByVal Value As Boolean)
            _PermitirSeleccionar = Value
            If Not Me.ViewState("PermitirSeleccionar") Is Nothing Then Me.ViewState.Remove("PermitirSeleccionar")
            Me.ViewState.Add("PermitirSeleccionar", Value)
        End Set
    End Property

    Private _PermitirEliminar As Boolean = False
    Public Property PermitirEliminar() As Boolean
        Get
            Return _PermitirEliminar
        End Get
        Set(ByVal Value As Boolean)
            _PermitirEliminar = Value
            If Not Me.ViewState("PermitirEliminar") Is Nothing Then Me.ViewState.Remove("PermitirEliminar")
            Me.ViewState.Add("PermitirEliminar", Value)
        End Set
    End Property

    Public Property PermitirAgrupar() As Boolean
        Get
            Return Me.dxgvLista.Settings.ShowGroupPanel
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Settings.ShowGroupPanel = Value
        End Set
    End Property

    Public Property PermitirFilaDeFiltro() As Boolean
        Get
            Return Me.dxgvLista.Settings.ShowFilterRow
        End Get
        Set(ByVal value As Boolean)
            Me.dxgvLista.Settings.ShowFilterRow = value
        End Set
    End Property

    Public Property PermitirFiltroEnEncabezado() As Boolean
        Get
            Return Me.dxgvLista.Settings.ShowHeaderFilterButton
        End Get
        Set(ByVal value As Boolean)
            Me.dxgvLista.Settings.ShowHeaderFilterButton = value
        End Set
    End Property

    Public Property PermitirEditarInline() As Boolean
        Get
            Return Me.ViewState("PermitirEdicionInline")
        End Get
        Set(ByVal value As Boolean)
            Me.ViewState("PermitirEdicionInline") = value
        End Set
    End Property

    Public Property PermitirEliminarInline() As Boolean
        Get
            Return Me.ViewState("PermitirEliminacionInline")
        End Get
        Set(ByVal value As Boolean)
            Me.ViewState("PermitirEliminacionInline") = value
        End Set
    End Property

    Public Property PermitirAgregar() As Boolean
        Get
            Return Me.ViewState("PermitirAgregar")
        End Get
        Set(ByVal value As Boolean)
            Me.ViewState("PermitirAgregar") = value
        End Set
    End Property

    Public Property PermitirAgregarInline() As Boolean
        Get
            Return Me.ViewState("PermitirAgregarInline")
        End Get
        Set(ByVal value As Boolean)
            Me.ViewState("PermitirAgregarInline") = value
        End Set
    End Property

    Public Property PermitirRowHotTrack() As Boolean
        Get
            Return Me.dxgvLista.SettingsBehavior.EnableRowHotTrack
        End Get
        Set(ByVal value As Boolean)
            Me.dxgvLista.SettingsBehavior.EnableRowHotTrack = value
        End Set
    End Property

    Public Property PermitirFocoEnFilas() As Boolean
        Get
            Return Me.dxgvLista.SettingsBehavior.AllowFocusedRow
        End Get
        Set(ByVal value As Boolean)
            Me.dxgvLista.SettingsBehavior.AllowFocusedRow = value
        End Set
    End Property

    Public Property PermitirSeleccionParaCombo() As Boolean
        Get
            Return Me.ViewState("PermitirSeleccionParaCombo")
        End Get
        Set(ByVal value As Boolean)
            Me.ViewState("PermitirSeleccionParaCombo") = value
        End Set
    End Property

    Public Property NombreComboCliente() As String
        Get
            Return Me.ViewState("NombreComboCliente")
        End Get
        Set(ByVal value As String)
            Me.ViewState("NombreComboCliente") = value
        End Set
    End Property

    Private _TextoSeleccionar As String = "Seleccionar"
    Public Property TextoSeleccionar() As String
        Get
            Return _TextoSeleccionar
        End Get
        Set(ByVal Value As String)
            _TextoSeleccionar = Value
            If Not Me.ViewState("TextoSeleccionar") Is Nothing Then Me.ViewState.Remove("TextoSeleccionar")
            Me.ViewState.Add("TextoSeleccionar", Value)
        End Set
    End Property

    Private _ComandoSeleccionar As String = "Select"
    Public Property ComandoSeleccionar() As String
        Get
            Return _ComandoSeleccionar
        End Get
        Set(ByVal Value As String)
            _ComandoSeleccionar = Value
            If Not Me.ViewState("ComandoSeleccionar") Is Nothing Then Me.ViewState.Remove("ComandoSeleccionar")
            Me.ViewState.Add("ComandoSeleccionar", Value)
        End Set
    End Property

    Public Property TextoHeaderSeleccionar() As String
        Get
            Return Me.dxgvLista.Columns("Seleccionar").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("Seleccionar").Caption = Value
        End Set
    End Property

    Public Property NombreGridCliente() As String
        Get
            Return dxgvLista.ClientInstanceName
        End Get
        Set(ByVal value As String)
            dxgvLista.ClientInstanceName = value
        End Set
    End Property

    Public Property VerUSUARIO() As Boolean
        Get
            Return Me.dxgvLista.Columns("USUARIO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("USUARIO").Visible = Value
        End Set
    End Property

    Public Property VerID_PROVEEDOR_AF() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_PROVEEDOR_AF").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_PROVEEDOR_AF").Visible = Value
        End Set
    End Property

    Public Property VerID_SITIO_CAPACITACION() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_SITIO_CAPACITACION").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_SITIO_CAPACITACION").Visible = Value
        End Set
    End Property

    Public Property VerID_PARTICIPANTE() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_PARTICIPANTE").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_PARTICIPANTE").Visible = Value
        End Set
    End Property

    Public Property VerNOMBRE() As Boolean
        Get
            Return Me.dxgvLista.Columns("NOMBRE").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("NOMBRE").Visible = Value
        End Set
    End Property

    Public Property HeaderUSUARIO() As String
        Get
            Return Me.dxgvLista.Columns("USUARIO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("USUARIO").Caption = Value
        End Set
    End Property

    Public Property HeaderID_PROVEEDOR_AF() As String
        Get
            Return Me.dxgvLista.Columns("ID_PROVEEDOR_AF").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_PROVEEDOR_AF").Caption = Value
        End Set
    End Property

    Public Property HeaderID_SITIO_CAPACITACION() As String
        Get
            Return Me.dxgvLista.Columns("ID_SITIO_CAPACITACION").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_SITIO_CAPACITACION").Caption = Value
        End Set
    End Property

    Public Property HeaderID_PARTICIPANTE() As String
        Get
            Return Me.dxgvLista.Columns("ID_PARTICIPANTE").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_PARTICIPANTE").Caption = Value
        End Set
    End Property

    Public Property HeaderNOMBRE() As String
        Get
            Return Me.dxgvLista.Columns("NOMBRE").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("NOMBRE").Caption = Value
        End Set
    End Property

#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla USUARIO
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/10/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        Me.odsLista.SelectParameters("recuperarHijas").DefaultValue = "False"
        Me.odsLista.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsLista.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsLista.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsLista.DataBind()
        Me.dxgvLista.DataSourceID = "odsLista"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla USUARIO
    ''' filtrado por la tabla PROVEEDOR_AF
    ''' </summary>
    ''' <param name="ID_PROVEEDOR_AF"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/10/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorPROVEEDOR_AF(ByVal ID_PROVEEDOR_AF As Decimal) As Integer
        Me.odsListaPorPROVEEDOR_AF.SelectParameters("ID_PROVEEDOR_AF").DefaultValue = ID_PROVEEDOR_AF.ToString()
        Me.odsListaPorPROVEEDOR_AF.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorPROVEEDOR_AF.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorPROVEEDOR_AF.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorPROVEEDOR_AF.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorPROVEEDOR_AF"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla USUARIO
    ''' filtrado por la tabla SITIO_CAPACITACION
    ''' </summary>
    ''' <param name="ID_SITIO_CAPACITACION"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/10/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorSITIO_CAPACITACION(ByVal ID_SITIO_CAPACITACION As Decimal) As Integer
        Me.odsListaPorSITIO_CAPACITACION.SelectParameters("ID_SITIO_CAPACITACION").DefaultValue = ID_SITIO_CAPACITACION.ToString()
        Me.odsListaPorSITIO_CAPACITACION.SelectParameters("recuperarHijas").DefaultValue = "False"
        Me.odsListaPorSITIO_CAPACITACION.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorSITIO_CAPACITACION.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorSITIO_CAPACITACION.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorSITIO_CAPACITACION.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorSITIO_CAPACITACION"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla USUARIO
    ''' filtrado por la tabla PARTICIPANTE
    ''' </summary>
    ''' <param name="ID_PARTICIPANTE"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/10/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorPARTICIPANTE(ByVal ID_PARTICIPANTE As Decimal) As Integer
        Me.odsListaPorPARTICIPANTE.SelectParameters("ID_PARTICIPANTE").DefaultValue = ID_PARTICIPANTE.ToString()
        Me.odsListaPorPARTICIPANTE.SelectParameters("recuperarHijas").DefaultValue = "False"
        Me.odsListaPorPARTICIPANTE.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorPARTICIPANTE.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorPARTICIPANTE.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorPARTICIPANTE.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorPARTICIPANTE"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not Me.ViewState("PermitirEditar") Is Nothing Then Me._PermitirEditar = Me.ViewState("PermitirEditar")
        If Not Me.ViewState("PermitirSeleccionar") Is Nothing Then Me._PermitirSeleccionar = Me.ViewState("PermitirSeleccionar")
        If Not Me.ViewState("TextoSeleccionar") Is Nothing Then Me._TextoSeleccionar = Me.ViewState("TextoSeleccionar")
        If Not Me.ViewState("ComandoSeleccionar") Is Nothing Then Me._ComandoSeleccionar = Me.ViewState("ComandoSeleccionar")
    End Sub

    Protected Sub dxgvLista_CustomButtonInitialize(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewCustomButtonEventArgs) Handles dxgvLista.CustomButtonInitialize
        If e.CellType = GridViewTableCommandCellType.Data Then
            If e.ButtonID = "btnDesbloquear" Then
                If CType(dxgvLista.GetRowValues(e.VisibleIndex, "BLOQUEADO"), Boolean) Then
                    e.Visible = DevExpress.Utils.DefaultBoolean.True
                Else
                    e.Visible = DevExpress.Utils.DefaultBoolean.False
                End If
            End If
            If e.ButtonID = "btnEnviarClave" Then
                If CType(dxgvLista.GetRowValues(e.VisibleIndex, "ACTIVO"), Boolean) Then
                    e.Visible = DevExpress.Utils.DefaultBoolean.True
                Else
                    e.Visible = DevExpress.Utils.DefaultBoolean.False
                End If
            End If
        End If
    End Sub

    Protected Sub dxgvLista_CustomJSProperties(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewClientJSPropertiesEventArgs) Handles dxgvLista.CustomJSProperties
        If Me.PermitirSeleccionParaCombo Then
            Dim grid As DevExpress.Web.ASPxGridView.ASPxGridView = CType(sender, DevExpress.Web.ASPxGridView.ASPxGridView)
            Dim keyNames(grid.VisibleRowCount - 1) As Object
            Dim keyValues(grid.VisibleRowCount - 1) As Object
            For i As Integer = 0 To grid.VisibleRowCount - 1
                keyValues(i) = grid.GetRowValues(i, "USUARIO")
                keyNames(i) = grid.GetRowValues(i, "ID_PROVEEDOR_AF")
            Next i
            e.Properties("cpKeyValues") = keyValues
            e.Properties("cpKeyNames") = keyNames
            e.Properties("cpNombreComboCliente") = Me.NombreComboCliente
        End If
    End Sub

    Protected Sub dxgvLista_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles dxgvLista.Init
        If Me.PermitirSeleccionar And Me.ComandoSeleccionar = "Check" Then
            Me.dxgvLista.Columns("Seleccionar").Visible = True
            CType(Me.dxgvLista.Columns("Seleccionar"), DevExpress.Web.ASPxGridView.GridViewCommandColumn).ShowSelectCheckbox = True
        End If
        If Me.PermitirAgregar Or Me.PermitirEditar Or Me.PermitirEliminar Then
            Me.dxgvLista.Columns("Comandos").Visible = True
        End If
        CType(Me.dxgvLista.Columns("Comandos"), DevExpress.Web.ASPxGridView.GridViewCommandColumn).NewButton.Visible = Me.PermitirAgregar
        CType(Me.dxgvLista.Columns("Comandos"), DevExpress.Web.ASPxGridView.GridViewCommandColumn).EditButton.Visible = Me.PermitirEditar
        If Me.PermitirEliminar Then
            CType(Me.dxgvLista.Columns("Comandos"), DevExpress.Web.ASPxGridView.GridViewCommandColumn).CustomButtons("btnEliminar").Visibility = GridViewCustomButtonVisibility.BrowsableRow
        Else
            CType(Me.dxgvLista.Columns("Comandos"), DevExpress.Web.ASPxGridView.GridViewCommandColumn).CustomButtons("btnEliminar").Visibility = GridViewCustomButtonVisibility.Invisible
        End If

       
        If Me.NombreComboCliente = "" Then
            Me.dxgvLista.ClientSideEvents.RowClick = ""
        End If
    End Sub

    Protected Sub dxgvLista_RowCommand(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewRowCommandEventArgs) Handles dxgvLista.RowCommand
        If e.CommandArgs.CommandName = "Select" And ComandoSeleccionar <> "Check" Then
            Me.dxgvLista.Selection.UnselectAll()
            Me.dxgvLista.Selection.SelectRow(e.VisibleIndex)
            RaiseEvent Seleccionado(e.CommandArgs.CommandArgument)
        End If
        If e.CommandArgs.CommandName = "Editar" Then
            RaiseEvent Editando(e.CommandArgs.CommandArgument)
        End If
    End Sub

    Public Function DevolverSeleccionados() As listaUSUARIO
        Dim mLista As New listaUSUARIO
        For Each llave As String In Me.dxgvLista.GetSelectedFieldValues("USUARIO")
            Dim lEntidad As New USUARIO
            lEntidad.USUARIO = llave
            mLista.Add(lEntidad)
        Next
        Return mLista
    End Function

    Protected Sub dxgvLista_CustomButtonCallback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewCustomButtonCallbackEventArgs) Handles dxgvLista.CustomButtonCallback
        If e.ButtonID = "btnEliminar" Then
            Dim sUsuario As String = Me.dxgvLista.GetRowValues(e.VisibleIndex, "USUARIO")

            If Me.mComponente.EliminarUSUARIO(sUsuario) <> 1 Then
                'Si se cometio un error
                Me.dxgvLista.JSProperties("cpMensaje") = "Error al Eliminar Registro: " + mComponente.sError
                Me.AsignarMensaje("Error al Eliminar Registro: " + mComponente.sError, True, True)
            Else
                Dim blUsuario As New cUSUARIO
                blUsuario.EliminarUSUARIO_cmembershipProvider(sUsuario)
                Me.dxgvLista.DataBind()
            End If
        End If
        If e.ButtonID = "btnEnviarClave" Then
            Dim c As cmembershipProvider
            Dim UsuarioActual As cmembershipUser
            Dim UsuarioDestino As cmembershipUser
            Dim Cuerpo As New StringBuilder

            c = CType(Membership.Provider, cmembershipProvider)
            UsuarioActual = c.ObtenerUsuario(Me.ObtenerUsuario)
            UsuarioDestino = c.ObtenerUsuario(Me.dxgvLista.GetRowValues(e.VisibleIndex, "USUARIO"))

            If UsuarioActual IsNot Nothing AndAlso UsuarioDestino IsNot Nothing Then
                If UsuarioDestino.IsLockedOut Then UsuarioDestino.UnlockUser()
                Dim NuevaClave As String = c.ResetPassword(UsuarioDestino.UserName, "")

                Cuerpo.AppendLine(UsuarioDestino.Nombre)
                Cuerpo.Append("Su usuario es: ")
                Cuerpo.AppendLine(UsuarioDestino.UserName)
                Cuerpo.Append("Su nueva clave es: ")
                Cuerpo.AppendLine(NuevaClave)
                Cuerpo.AppendLine("")
                Cuerpo.AppendLine("Para cambiar esta clave ingrese al sistema, luego vaya al menu 'Seguridad' opcion 'Cambiar mi contrasena'.")
                Cuerpo.AppendLine("En la pantalla que se presenta digite en el primer campo la clave que se le envio y en los otros campos la clave que usted desea,")
                Cuerpo.AppendLine("finalmente haga clic en el boton Cambiar Contrasena.")

                If c.EnviarCorreo(UsuarioActual.Email, UsuarioDestino.Email, "INSAFORP - Nueva Clave para el SGAFP", Cuerpo.ToString) = 1 Then
                    Me.dxgvLista.JSProperties("cpMensaje") = "La nueva clave se ha enviado al usuario"
                    Me.AsignarMensaje("La nueva clave se ha enviado al usuario", False, True)
                Else
                    Me.dxgvLista.JSProperties("cpMensaje") = "Fallo al enviar clave al usuario"
                    Me.AsignarMensaje("Fallo al enviar clave al usuario", True, True)
                End If
            Else
                If UsuarioActual Is Nothing Then
                    Me.dxgvLista.JSProperties("cpMensaje") = "No se logro referenciar al usuario actual"
                    Me.AsignarMensaje("No se logro referenciar al usuario actual", True, True)
                Else
                    Me.dxgvLista.JSProperties("cpMensaje") = "No se logro referenciar al usuario"
                    Me.AsignarMensaje("No se logro referenciar al usuario", True, True)
                End If
            End If
        End If
        If e.ButtonID = "btnDesbloquear" Then
            Dim c As cmembershipProvider

            c = CType(Membership.Provider, cmembershipProvider)
            If c.UnlockUser(Me.dxgvLista.GetRowValues(e.VisibleIndex, "USUARIO")) Then
                Me.dxgvLista.JSProperties("cpMensaje") = "El usuario se ha desbloqueado"
                Me.AsignarMensaje("El usuario se ha desbloqueado", False, True)
                Me.dxgvLista.DataBind()
            Else
                Me.dxgvLista.JSProperties("cpMensaje") = "No se logró desbloquear el usuario"
                Me.AsignarMensaje("No se logró desbloquear el usuario", True, True)
            End If
        End If
    End Sub

    Protected Sub dxgvLista_CustomUnboundColumnData(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewColumnDataEventArgs) Handles dxgvLista.CustomUnboundColumnData
        Dim eProveedorAF As PROVEEDOR_AF
        Dim eSitioCapacitacion As SITIO_CAPACITACION
        Dim usuario As MembershipUser

        Select Case e.Column.FieldName
            Case "NOMBRE_PROVEEDOR"
                eProveedorAF = (New cPROVEEDOR_AF).ObtenerPROVEEDOR_AF(CDec(e.GetListSourceFieldValue("ID_PROVEEDOR_AF")))
                If eProveedorAF.ID_PROVEEDOR_AF > 0 Then e.Value = eProveedorAF.NOMBRE_PROVEEDOR

            Case "NOMBRE_SITIO"
                eSitioCapacitacion = (New cSITIO_CAPACITACION).ObtenerSITIO_CAPACITACION(CDec(e.GetListSourceFieldValue("ID_SITIO_CAPACITACION")))
                If eSitioCapacitacion.ID_SITIO_CAPACITACION > 0 Then e.Value = eSitioCapacitacion.NOMBRE_SITIO

            Case "EMAIL"
                usuario = Me.ObtenerMemberShipUser(e.GetListSourceFieldValue("USUARIO").ToString)
                If usuario IsNot Nothing Then e.Value = usuario.Email

            Case "EMAIL_ADICIONAL"
                Dim lUsuario As cmembershipUser = Me.ObtenerCustomMemberShipUser(e.GetListSourceFieldValue("USUARIO").ToString)
                If lUsuario IsNot Nothing AndAlso lUsuario.EmailsAdicionales.Count > 0 Then
                    Dim lCorreos As New StringBuilder
                    For i As Integer = 0 To lUsuario.EmailsAdicionales.Count - 1
                        If i = lUsuario.EmailsAdicionales.Count - 1 Then
                            lCorreos.Append(lUsuario.EmailsAdicionales(i))
                        Else
                            lCorreos.Append(lUsuario.EmailsAdicionales(i))
                            lCorreos.Append(";")
                        End If
                    Next
                    e.Value = lCorreos.ToString
                End If


            Case "ROL"
                Dim RolesAsignados() As String
                Dim sRoles As New StringBuilder

                RolesAsignados = Roles.GetRolesForUser(e.GetListSourceFieldValue("USUARIO").ToString)
                For i As Integer = 0 To RolesAsignados.Length - 1
                    sRoles.Append(RolesAsignados(i))
                    If i < (RolesAsignados.Length - 1) Then sRoles.Append(", ")
                Next
                If RolesAsignados.Length > 0 Then e.Value = sRoles.ToString

            Case "ACTIVO"
                usuario = Me.ObtenerMemberShipUser(e.GetListSourceFieldValue("USUARIO").ToString)
                If usuario IsNot Nothing Then e.Value = usuario.IsApproved

            Case "BLOQUEADO"
                usuario = Me.ObtenerMemberShipUser(e.GetListSourceFieldValue("USUARIO").ToString)
                If usuario IsNot Nothing Then e.Value = usuario.IsLockedOut

            Case "CREACION"
                usuario = Me.ObtenerMemberShipUser(e.GetListSourceFieldValue("USUARIO").ToString)
                If usuario IsNot Nothing Then e.Value = usuario.CreationDate

            Case "ULTIMO_ACCESO"
                usuario = Me.ObtenerMemberShipUser(e.GetListSourceFieldValue("USUARIO").ToString)
                If usuario IsNot Nothing Then e.Value = usuario.LastLoginDate
        End Select
    End Sub
    

#Region "Edit Template"

    Private Sub CargarRoles()
        Dim lbxRoles As ASPxListBox = CType(Me.dxgvLista.FindEditFormTemplateControl("lbxRoles"), ASPxListBox)
        Dim mRoles() As String = Roles.GetAllRoles

        Select Case True
            Case EstaEnRol(RolDeUsuario.Administrador)
                For i As Integer = 0 To mRoles.Length - 1
                    lbxRoles.Items.Add(mRoles(i), mRoles(i))
                Next

            Case EstaEnRol(RolDeUsuario.JefeHTP), EstaEnRol(RolDeUsuario.GerenteGFI)
                lbxRoles.Items.Add(RolDeUsuario.ProveedorPATI, RolDeUsuario.ProveedorPATI)
                lbxRoles.Items.Add(RolDeUsuario.Proveedor, RolDeUsuario.Proveedor)
                lbxRoles.Items.Add(RolDeUsuario.CentroCapacitador, RolDeUsuario.CentroCapacitador)

            Case EstaEnRol(RolDeUsuario.TecnicoCentroHTP)
                lbxRoles.Items.Add(RolDeUsuario.CentroCapacitador, RolDeUsuario.CentroCapacitador)
        End Select
    End Sub

    Private Sub SetearRoles(ByVal sUsuario As String)
        Dim mRoles As String() = Roles.GetRolesForUser(sUsuario)
        Dim lbxRoles As ASPxListBox = CType(Me.dxgvLista.FindEditFormTemplateControl("lbxRoles"), ASPxListBox)

        If mRoles IsNot Nothing Then
            For i As Integer = 0 To mRoles.Length - 1
                If lbxRoles.Items.FindByText(mRoles(i)) IsNot Nothing Then lbxRoles.Items.FindByText(mRoles(i)).Selected = True
            Next
        End If
    End Sub

    Private Sub SeleccionarRoles(ByVal sRolesSeleccionados As String)
        Dim RolesSeleccionados As String() = sRolesSeleccionados.Split("|")
        For i As Integer = 0 To RolesSeleccionados.Length - 1
            Dim valor As New StringBuilder
            For j As Integer = 0 To RolesSeleccionados(i).Length - 1
                If Not Char.IsNumber(RolesSeleccionados(i).Chars(j)) Then valor.Append(RolesSeleccionados(i).Chars(j))
            Next
            RolesSeleccionados(i) = valor.ToString
        Next

        Dim lbxRoles As ASPxListBox = CType(Me.dxgvLista.FindEditFormTemplateControl("lbxRoles"), ASPxListBox)
        For i As Integer = 0 To RolesSeleccionados.Length - 1
            If lbxRoles.Items.FindByText(RolesSeleccionados(i)) IsNot Nothing Then lbxRoles.Items.FindByText(RolesSeleccionados(i)).Selected = True
        Next

    End Sub

    Private Sub CargarProveedores()
        Dim mProveedores As ASPxComboBox = CType(Me.dxgvLista.FindEditFormTemplateControl("cbxProveedor"), ASPxComboBox)

        Select Case True
            Case EstaEnRol(RolDeUsuario.Administrador), EstaEnRol(RolDeUsuario.GerenteGFI), EstaEnRol(RolDeUsuario.JefeHTP)
                Me.odsProveedor.DataBind()
                mProveedores.DataSourceID = "odsProveedor"

            Case EstaEnRol(RolDeUsuario.TecnicoCentroHTP)
                Me.odsProveedoresPorTecnico.SelectParameters("USUARIO").DefaultValue = Me.ObtenerUsuario
                Me.odsProveedoresPorTecnico.DataBind()
                mProveedores.DataSourceID = "odsProveedoresPorTecnico"
        End Select
        mProveedores.DataBind()
        If EstaEnRol(RolDeUsuario.Administrador) Then mProveedores.Items.Add("", -1)
    End Sub

    Private Sub CargarCentros(ByVal ID_PROVEEDOR_AF As Decimal)
        Dim mCentroFormacion As ASPxComboBox = CType(Me.dxgvLista.FindEditFormTemplateControl("cbxCentroFormacion"), ASPxComboBox)

        Select Case True
            Case EstaEnRol(RolDeUsuario.Administrador), EstaEnRol(RolDeUsuario.GerenteGFI), EstaEnRol(RolDeUsuario.JefeHTP)
                Me.odsCentroFormacion.SelectParameters("ID_PROVEEDOR_AF").DefaultValue = ID_PROVEEDOR_AF
                Me.odsCentroFormacion.DataBind()
                mCentroFormacion.DataSourceID = "odsCentroFormacion"
                mCentroFormacion.DataBind()
                mCentroFormacion.Items.Add("", -1)

            Case EstaEnRol(RolDeUsuario.TecnicoCentroHTP)
                Me.odsCentroFormacionPorTecnico.SelectParameters("ID_PROVEEDOR_AF").DefaultValue = ID_PROVEEDOR_AF
                Me.odsCentroFormacionPorTecnico.SelectParameters("USUARIO").DefaultValue = Me.ObtenerUsuario
                Me.odsCentroFormacionPorTecnico.DataBind()
                mCentroFormacion.DataSourceID = "odsCentroFormacionPorTecnico"
                mCentroFormacion.DataBind()
        End Select
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla USUARIO
    ''' filtrado por la tabla PARTICIPANTE
    ''' </summary>
    ''' <param name="ID_PROVEEDOR_AF"></param>
    ''' <param name="ID_SITIO_CAPACITACION"></param>
    ''' <param name="USUARIO"></param>
    ''' <param name="CORREO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/10/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorCRITERIOS(ByVal ID_PROVEEDOR_AF As Decimal, ByVal ID_SITIO_CAPACITACION As Decimal, ByVal USUARIO As String, ByVal CORREO As String) As Integer
        Me.odsListaPorCRITERIOS.SelectParameters("ID_PROVEEDOR_AF").DefaultValue = ID_PROVEEDOR_AF.ToString()
        Me.odsListaPorCRITERIOS.SelectParameters("ID_SITIO_CAPACITACION").DefaultValue = ID_SITIO_CAPACITACION.ToString()

        Me.ListaUsuarios = New List(Of String)
        Dim Usuarios() As String
        Dim sResult As String
        Dim mp As cmembershipProvider
        mp = CType(Membership.Provider, cmembershipProvider)

        If USUARIO <> "" AndAlso CORREO <> "" Then
            sResult = mp.GetUserNameByEmail(CORREO)
            If sResult IsNot Nothing AndAlso (USUARIO = sResult) Then
                Me.ListaUsuarios.Add(USUARIO)
            Else
                Me.ListaUsuarios.Add("~")
            End If

        ElseIf USUARIO <> "" Then
            Me.ListaUsuarios.Add(USUARIO)

        ElseIf CORREO <> "" Then
            sResult = mp.GetUserNameByEmail(CORREO)
            If sResult IsNot Nothing Then
                Me.ListaUsuarios.Add(sResult)

            Else
                Me.ListaUsuarios.Add("~")
            End If
        Else
            If ID_PROVEEDOR_AF <> -1 Then
                For Each _eUsuario As USUARIO In (New cUSUARIO).ObtenerListaPorPROVEEDOR_AF(ID_PROVEEDOR_AF)
                    ListaUsuarios.Add(_eUsuario.USUARIO)
                Next
            End If
        End If

        Me.odsListaPorCRITERIOS.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorCRITERIOS"
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    Private Function ObtenerMemberShipUser(ByVal Usuario As String) As MembershipUser
        Dim mp As cmembershipProvider
        Dim User As MembershipUser

        mp = CType(Membership.Provider, cmembershipProvider)
        User = mp.GetUser(Usuario, False)

        Return User
    End Function

    Private Function ObtenerCustomMemberShipUser(ByVal Usuario As String) As cmembershipUser
        Dim mp As cmembershipProvider
        Dim User As cmembershipUser

        mp = CType(Membership.Provider, cmembershipProvider)
        User = mp.ObtenerUsuario(Usuario)

        Return User
    End Function


    Protected Sub odsListaPorCRITERIOS_Selecting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.ObjectDataSourceSelectingEventArgs) Handles odsListaPorCRITERIOS.Selecting
        e.InputParameters("USUARIOS") = Me.ListaUsuarios
    End Sub

    Protected Sub dxgvLista_HtmlEditFormCreated(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewEditFormEventArgs) Handles dxgvLista.HtmlEditFormCreated
        Dim mUsuario As ASPxTextBox = CType(Me.dxgvLista.FindEditFormTemplateControl("txtUsuario"), ASPxTextBox)
        Dim mNombre As ASPxTextBox = CType(Me.dxgvLista.FindEditFormTemplateControl("txtNombre"), ASPxTextBox)
        Dim mCorreo As ASPxTextBox = CType(Me.dxgvLista.FindEditFormTemplateControl("txtCorreo"), ASPxTextBox)
        Dim mRol As ASPxListBox = CType(Me.dxgvLista.FindEditFormTemplateControl("lbxRoles"), ASPxListBox)
        Dim mProveedor As ASPxComboBox = CType(Me.dxgvLista.FindEditFormTemplateControl("cbxProveedor"), ASPxComboBox)
        Dim mCentroFormacion As ASPxComboBox = CType(Me.dxgvLista.FindEditFormTemplateControl("cbxCentroFormacion"), ASPxComboBox)
        Dim mActivo As ASPxCheckBox = CType(Me.dxgvLista.FindEditFormTemplateControl("chkActivo"), ASPxCheckBox)
        Dim mlblPassword As ASPxLabel = CType(Me.dxgvLista.FindEditFormTemplateControl("lblPassword"), ASPxLabel)
        Dim mlblConfirmarPassword As ASPxLabel = CType(Me.dxgvLista.FindEditFormTemplateControl("lblConfirmarPassword"), ASPxLabel)
        Dim mPassword As ASPxTextBox = CType(Me.dxgvLista.FindEditFormTemplateControl("txtPassword"), ASPxTextBox)
        Dim mConfirmarPassword As ASPxTextBox = CType(Me.dxgvLista.FindEditFormTemplateControl("txtConfirmarPassword"), ASPxTextBox)
        Dim mCorreoComplementario As ASPxTextBox = CType(Me.dxgvLista.FindEditFormTemplateControl("txtCorreoAdicional"), ASPxTextBox)

        Me.CargarProveedores()
        Me.CargarRoles()
        Me.CargarDepartamentos()

        If dxgvLista.IsNewRowEditing Then
            mActivo.Visible = False
        Else

            Dim mDepartamentos As ASPxComboBox = CType(Me.dxgvLista.FindEditFormTemplateControl("cbxDepartamento"), ASPxComboBox)
            Dim mMunicipio As ASPxComboBox = CType(Me.dxgvLista.FindEditFormTemplateControl("cbxMunicipio"), ASPxComboBox)

            mUsuario.Enabled = False
            mlblPassword.Visible = False
            mlblConfirmarPassword.Visible = False
            mPassword.Visible = False
            mConfirmarPassword.Visible = False

            'Setear valores para edición
            mUsuario.Text = Me.dxgvLista.GetRowValues(Me.dxgvLista.EditingRowVisibleIndex, "USUARIO")
            mNombre.Text = Me.dxgvLista.GetRowValues(Me.dxgvLista.EditingRowVisibleIndex, "NOMBRE")
            mCorreo.Text = Me.dxgvLista.GetRowValues(Me.dxgvLista.EditingRowVisibleIndex, "EMAIL")
            mCorreoComplementario.Text = Me.dxgvLista.GetRowValues(Me.dxgvLista.EditingRowVisibleIndex, "EMAIL_ADICIONAL")
            If Request.Params(mRol.UniqueID) Is Nothing Then
                SetearRoles(Me.dxgvLista.GetRowValues(Me.dxgvLista.EditingRowVisibleIndex, "USUARIO"))
            Else
                SeleccionarRoles(Request.Params(mRol.UniqueID))
            End If
            mProveedor.SelectedItem = mProveedor.Items.FindByText(Me.dxgvLista.GetRowValues(Me.dxgvLista.EditingRowVisibleIndex, "NOMBRE_PROVEEDOR"))
            mCentroFormacion.Text = Me.dxgvLista.GetRowValues(Me.dxgvLista.EditingRowVisibleIndex, "NOMBRE_SITIO")
            mActivo.Checked = Me.dxgvLista.GetRowValues(Me.dxgvLista.EditingRowVisibleIndex, "ACTIVO")

            mDepartamentos.SelectedItem = mDepartamentos.Items.FindByValue(Me.dxgvLista.GetRowValues(Me.dxgvLista.EditingRowVisibleIndex, "DEPARTAMENTO_ALCALDIA"))
            If mDepartamentos.SelectedItem.Value <> "" Then
                Me.CargarMunicipios(mDepartamentos.SelectedItem.Value)
            End If
            mMunicipio.SelectedItem = mMunicipio.Items.FindByValue(Me.dxgvLista.GetRowValues(Me.dxgvLista.EditingRowVisibleIndex, "MUNICIPIO_ALCALDIA"))

        End If
    End Sub

    Protected Sub cbxCentroFormacion_Callback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxClasses.CallbackEventArgsBase)
        Me.CargarCentros(e.Parameter)
    End Sub

    Private Sub AddError(ByVal errors As Dictionary(Of GridViewColumn, String), ByVal column As GridViewColumn, ByVal errorText As String)
        If errors.ContainsKey(column) Then
            Return
        End If
        errors(column) = errorText
    End Sub

    Protected Sub dxgvLista_RowValidating(ByVal sender As Object, ByVal e As DevExpress.Web.Data.ASPxDataValidationEventArgs) Handles dxgvLista.RowValidating
        Dim ResumenErrores As New StringBuilder

        Dim mUsuario As ASPxTextBox = CType(Me.dxgvLista.FindEditFormTemplateControl("txtUsuario"), ASPxTextBox)
        Dim mNombre As ASPxTextBox = CType(Me.dxgvLista.FindEditFormTemplateControl("txtNombre"), ASPxTextBox)
        Dim mCorreo As ASPxTextBox = CType(Me.dxgvLista.FindEditFormTemplateControl("txtCorreo"), ASPxTextBox)
        Dim mRol As ASPxListBox = CType(Me.dxgvLista.FindEditFormTemplateControl("lbxRoles"), ASPxListBox)
        Dim mProveedor As ASPxComboBox = CType(Me.dxgvLista.FindEditFormTemplateControl("cbxProveedor"), ASPxComboBox)
        Dim mCentroFormacion As ASPxComboBox = CType(Me.dxgvLista.FindEditFormTemplateControl("cbxCentroFormacion"), ASPxComboBox)
        Dim mActivo As ASPxCheckBox = CType(Me.dxgvLista.FindEditFormTemplateControl("chkActivo"), ASPxCheckBox)
        Dim mlblPassword As ASPxLabel = CType(Me.dxgvLista.FindEditFormTemplateControl("lblPassword"), ASPxLabel)
        Dim mlblConfirmarPassword As ASPxLabel = CType(Me.dxgvLista.FindEditFormTemplateControl("lblConfirmarPassword"), ASPxLabel)
        Dim mPassword As ASPxTextBox = CType(Me.dxgvLista.FindEditFormTemplateControl("txtPassword"), ASPxTextBox)
        Dim mConfirmarPassword As ASPxTextBox = CType(Me.dxgvLista.FindEditFormTemplateControl("txtConfirmarPassword"), ASPxTextBox)

        mUsuario.Text = mUsuario.Text.Trim.ToLower
        mNombre.Text = Request.Params(mNombre.UniqueID).ToUpper
        mCorreo.Text = Request.Params(mCorreo.UniqueID).ToLower

        If mUsuario.Text = "" Then
            ResumenErrores.Append("Usuario no puede estar vacio.<br/>")
        ElseIf dxgvLista.IsNewRowEditing Then
            'Validar que no existe el usuario en el membership
            Dim c As cmembershipProvider
            c = CType(Membership.Provider, cmembershipProvider)
            If c.ObtenerUsuario(mUsuario.Text) IsNot Nothing Then
                ResumenErrores.Append("Ya existe un Usuario: " + mUsuario.Text + ".<br/>")
            End If
        End If

        If mNombre.Text = "" Then
            ResumenErrores.Append("Nombre no puede estar vacio.<br/>")
        End If

        If mCorreo.Text = "" Then
            ResumenErrores.Append("Email no puede estar vacio.<br/>")
        ElseIf dxgvLista.IsNewRowEditing Then
            'Validar que no existe el email en el membership
            Dim c As cmembershipProvider
            c = CType(Membership.Provider, cmembershipProvider)

            If c.GetUserNameByEmail(mCorreo.Text) <> String.Empty Then
                ResumenErrores.Append("Ya existe un Usuario con el Email: " + mCorreo.Text + ".<br/>")
            End If
        Else
            Dim c As cmembershipProvider
            Dim u As cmembershipUser
            Dim sUserName As String

            c = CType(Membership.Provider, cmembershipProvider)
            sUserName = c.GetUserNameByEmail(mCorreo.Text)

            If sUserName <> String.Empty Then
                u = c.ObtenerUsuario(sUserName)
                If u.UserName <> mUsuario.Text Then
                    ResumenErrores.Append("Ya existe un Usuario con el Email: " + mCorreo.Text + ".<br/>")
                End If
            End If
        End If

        SeleccionarRoles(Request.Params(mRol.UniqueID))
        If mRol.SelectedItems.Count = 0 Then
            ResumenErrores.Append("Debe seleccionar al menos un Rol.<br/>")
        Else
            Dim SeleccionProveedor As Boolean = False
            Dim SeleccionProveedorPATI As Boolean = False
            Dim SeleccionCentro As Boolean = False

            For i As Integer = 0 To mRol.SelectedItems.Count - 1
                If mRol.SelectedItems(i).Text = "Proveedor" Then
                    SeleccionProveedor = True
                End If
                If mRol.SelectedItems(i).Text = "ProveedorPATI" OrElse mRol.SelectedItems(i).Text = "ProveedorFacturacionPATI" Then
                    SeleccionProveedorPATI = True
                End If
                If mRol.SelectedItems(i).Text = "CentroCapacitador" Then
                    SeleccionCentro = True
                End If
            Next
            If (SeleccionProveedor Or SeleccionProveedorPATI Or SeleccionCentro) AndAlso Request.Params(mProveedor.UniqueID) = "" Then
                ResumenErrores.Append("Seleccione el Proveedor.<br/>")
            End If
            'If SeleccionCentro AndAlso Not SeleccionProveedor AndAlso Request.Params(mCentroFormacion.UniqueID) = "" Then
            '    ResumenErrores.Append("Seleccione el Centro de Formacion.<br/>")
            'End If            
            If Not SeleccionProveedor AndAlso Not SeleccionProveedorPATI AndAlso Not SeleccionCentro AndAlso Request.Params(mCentroFormacion.UniqueID) <> "" Then
                ResumenErrores.Append("No seleccione Proveedor.<br/>")
            End If
            If Not SeleccionCentro AndAlso Request.Params(mCentroFormacion.UniqueID) <> "" Then
                ResumenErrores.Append("No seleccione Centro de Formacion.<br/>")
            End If
        End If

        If Me.dxgvLista.IsNewRowEditing Then
            If mPassword.Text = "" Then
                ResumenErrores.Append("Password no puede estar vacio.<br/>")
            End If
            If mPassword.Text <> mConfirmarPassword.Text Then
                ResumenErrores.Append("Confirmacion de Password no valida.<br/>")
            End If
        End If
        If ResumenErrores.ToString <> "" Then
            ResumenErrores.Append("Por favor, corriga los errores.")
            e.RowError = ResumenErrores.ToString
        End If
    End Sub

    Protected Sub odsListaPorCRITERIOS_Inserting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.ObjectDataSourceMethodEventArgs) Handles odsListaPorCRITERIOS.Inserting
        Dim mUsuario As ASPxTextBox = CType(Me.dxgvLista.FindEditFormTemplateControl("txtUsuario"), ASPxTextBox)
        Dim mNombre As ASPxTextBox = CType(Me.dxgvLista.FindEditFormTemplateControl("txtNombre"), ASPxTextBox)
        Dim mCorreo As ASPxTextBox = CType(Me.dxgvLista.FindEditFormTemplateControl("txtCorreo"), ASPxTextBox)
        Dim mRol As ASPxListBox = CType(Me.dxgvLista.FindEditFormTemplateControl("lbxRoles"), ASPxListBox)
        Dim mProveedor As ASPxComboBox = CType(Me.dxgvLista.FindEditFormTemplateControl("cbxProveedor"), ASPxComboBox)
        Dim mCentroFormacion As ASPxComboBox = CType(Me.dxgvLista.FindEditFormTemplateControl("cbxCentroFormacion"), ASPxComboBox)
        Dim mActivo As ASPxCheckBox = CType(Me.dxgvLista.FindEditFormTemplateControl("chkActivo"), ASPxCheckBox)
        Dim mlblPassword As ASPxLabel = CType(Me.dxgvLista.FindEditFormTemplateControl("lblPassword"), ASPxLabel)
        Dim mlblConfirmarPassword As ASPxLabel = CType(Me.dxgvLista.FindEditFormTemplateControl("lblConfirmarPassword"), ASPxLabel)
        Dim mPassword As ASPxTextBox = CType(Me.dxgvLista.FindEditFormTemplateControl("txtPassword"), ASPxTextBox)
        Dim mConfirmarPassword As ASPxTextBox = CType(Me.dxgvLista.FindEditFormTemplateControl("txtConfirmarPassword"), ASPxTextBox)
        Dim mCorreoComplementario As ASPxTextBox = CType(Me.dxgvLista.FindEditFormTemplateControl("txtCorreoAdicional"), ASPxTextBox)

        Dim mDepartamentos As ASPxComboBox = CType(Me.dxgvLista.FindEditFormTemplateControl("cbxDepartamento"), ASPxComboBox)
        Dim mMunicipio As ASPxComboBox = CType(Me.dxgvLista.FindEditFormTemplateControl("cbxMunicipio"), ASPxComboBox)

        e.InputParameters("USUARIO") = mUsuario.Text
        e.InputParameters("NOMBRE") = mNombre.Text
        e.InputParameters("CLAVE") = mPassword.Text
        e.InputParameters("EMAIL") = mCorreo.Text
        e.InputParameters("CORREO_ADICIONAL") = mCorreoComplementario.Text

        If mProveedor.SelectedItem Is Nothing Then
            e.InputParameters("ID_PROVEEDOR_AF") = CDec(-1)
        Else
            e.InputParameters("ID_PROVEEDOR_AF") = CDec(mProveedor.SelectedItem.Value)
        End If
        If mCentroFormacion.Text = "" Then
            e.InputParameters("ID_SITIO_CAPACITACION") = CDec(-1)
        Else
            For Each eSitio As SITIO_CAPACITACION In (New cSITIO_CAPACITACION).ObtenerLista
                If eSitio.NOMBRE_SITIO = mCentroFormacion.Text Then
                    e.InputParameters("ID_SITIO_CAPACITACION") = CDec(eSitio.ID_SITIO_CAPACITACION)
                End If
            Next
        End If
        e.InputParameters("ID_PARTICIPANTE") = CDec(-1)

        Dim RolesAsignados As New List(Of String)
        For i As Integer = 0 To mRol.SelectedItems.Count - 1
            RolesAsignados.Add(mRol.SelectedItems(i).Text)
        Next
        e.InputParameters("ROLES") = RolesAsignados.ToArray

        If Not mDepartamentos.SelectedItem Is Nothing Then
            e.InputParameters("DEPARTAMENTO_ALCALDIA") = mDepartamentos.SelectedItem.Value

            If mMunicipio.SelectedItem Is Nothing Then
                Me.CargarMunicipios(mDepartamentos.SelectedItem.Value)
                mMunicipio.SelectedItem = mMunicipio.Items.FindByText(mMunicipio.Text)
            End If
            e.InputParameters("MUNICIPIO_ALCALDIA") = mMunicipio.SelectedItem.Value
        End If

        
    End Sub

    Protected Sub odsListaPorCRITERIOS_Updating(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.ObjectDataSourceMethodEventArgs) Handles odsListaPorCRITERIOS.Updating
        Dim mUsuario As ASPxTextBox = CType(Me.dxgvLista.FindEditFormTemplateControl("txtUsuario"), ASPxTextBox)
        Dim mNombre As ASPxTextBox = CType(Me.dxgvLista.FindEditFormTemplateControl("txtNombre"), ASPxTextBox)
        Dim mCorreo As ASPxTextBox = CType(Me.dxgvLista.FindEditFormTemplateControl("txtCorreo"), ASPxTextBox)
        Dim mRol As ASPxListBox = CType(Me.dxgvLista.FindEditFormTemplateControl("lbxRoles"), ASPxListBox)
        Dim mProveedor As ASPxComboBox = CType(Me.dxgvLista.FindEditFormTemplateControl("cbxProveedor"), ASPxComboBox)
        Dim mCentroFormacion As ASPxComboBox = CType(Me.dxgvLista.FindEditFormTemplateControl("cbxCentroFormacion"), ASPxComboBox)
        Dim mActivo As ASPxCheckBox = CType(Me.dxgvLista.FindEditFormTemplateControl("chkActivo"), ASPxCheckBox)
        Dim mlblPassword As ASPxLabel = CType(Me.dxgvLista.FindEditFormTemplateControl("lblPassword"), ASPxLabel)
        Dim mlblConfirmarPassword As ASPxLabel = CType(Me.dxgvLista.FindEditFormTemplateControl("lblConfirmarPassword"), ASPxLabel)
        Dim mPassword As ASPxTextBox = CType(Me.dxgvLista.FindEditFormTemplateControl("txtPassword"), ASPxTextBox)
        Dim mConfirmarPassword As ASPxTextBox = CType(Me.dxgvLista.FindEditFormTemplateControl("txtConfirmarPassword"), ASPxTextBox)
        Dim mCorreoComplementario As ASPxTextBox = CType(Me.dxgvLista.FindEditFormTemplateControl("txtCorreoAdicional"), ASPxTextBox)

        Dim mDepartamentos As ASPxComboBox = CType(Me.dxgvLista.FindEditFormTemplateControl("cbxDepartamento"), ASPxComboBox)
        Dim mMunicipio As ASPxComboBox = CType(Me.dxgvLista.FindEditFormTemplateControl("cbxMunicipio"), ASPxComboBox)

        e.InputParameters("USUARIO") = mUsuario.Text
        e.InputParameters("NOMBRE") = Request.Params(mNombre.UniqueID)
        e.InputParameters("EMAIL") = Request.Params(mCorreo.UniqueID)
        e.InputParameters("CORREO_ADICIONAL") = Request.Params(mCorreoComplementario.UniqueID)
        If Request.Params(mActivo.UniqueID) = "C" Then e.InputParameters("APROBADO") = True Else e.InputParameters("APROBADO") = False
        If Request.Params(mProveedor.UniqueID) = "" Then
            e.InputParameters("ID_PROVEEDOR_AF") = CDec(-1)
        Else
            For Each eProveedor As PROVEEDOR_AF In (New cPROVEEDOR_AF).ObtenerLista
                If eProveedor.NOMBRE_PROVEEDOR = Request.Params(mProveedor.UniqueID) Then
                    e.InputParameters("ID_PROVEEDOR_AF") = eProveedor.ID_PROVEEDOR_AF
                End If
            Next
        End If
        If Request.Params(mCentroFormacion.UniqueID) = "" Then
            e.InputParameters("ID_SITIO_CAPACITACION") = CDec(-1)
        Else
            For Each eSitio As SITIO_CAPACITACION In (New cSITIO_CAPACITACION).ObtenerLista
                If eSitio.NOMBRE_SITIO = Request.Params(mCentroFormacion.UniqueID) Then
                    e.InputParameters("ID_SITIO_CAPACITACION") = eSitio.ID_SITIO_CAPACITACION
                End If
            Next
        End If
        e.InputParameters("ID_PARTICIPANTE") = CDec(-1)

        Dim RolesAsignados(mRol.SelectedItems.Count - 1) As String
        Dim i As Integer = 0
        For Each _Rol As ListEditItem In mRol.SelectedItems
            RolesAsignados(i) = _Rol.Text
            i += 1
        Next
        e.InputParameters("ROLES") = RolesAsignados

        If Not mDepartamentos.SelectedItem Is Nothing Then
            mDepartamentos.SelectedItem = mDepartamentos.Items.FindByText(Request.Params(mDepartamentos.UniqueID))
            e.InputParameters("DEPARTAMENTO_ALCALDIA") = mDepartamentos.SelectedItem.Value
            Me.CargarMunicipios(mDepartamentos.SelectedItem.Value)
            mMunicipio.SelectedItem = mMunicipio.Items.FindByText(Request.Params(mMunicipio.UniqueID))
            e.InputParameters("MUNICIPIO_ALCALDIA") = mMunicipio.SelectedItem.Value
        End If

    End Sub

    Private Sub CargarDepartamentos()
        Dim mDepartamentos As ASPxComboBox = CType(Me.dxgvLista.FindEditFormTemplateControl("cbxDepartamento"), ASPxComboBox)
        Me.odsDepartamento.DataBind()
        mDepartamentos.DataSourceID = "odsDepartamento"
        mDepartamentos.DataBind()
        mDepartamentos.Items.Add("", "")
    End Sub

    Protected Sub cbxMunicipio_Callback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxClasses.CallbackEventArgsBase)
        Me.CargarMunicipios(e.Parameter)
    End Sub

    Private Sub CargarMunicipios(ByVal CODIGO_DEPARTAMENTO As String)

        Dim mMunicipio As ASPxComboBox = CType(Me.dxgvLista.FindEditFormTemplateControl("cbxMunicipio"), ASPxComboBox)

        Me.odsMunicipio.SelectParameters("CODIGO_DEPARTAMENTO").DefaultValue = CODIGO_DEPARTAMENTO
        Me.odsMunicipio.DataBind()
        mMunicipio.DataSourceID = "odsMunicipio"
        mMunicipio.DataBind()
        mMunicipio.Items.Add("", "")

    End Sub

#End Region

    Protected Sub dxgvLista_CustomCallback(sender As Object, e As ASPxGridViewCustomCallbackEventArgs) Handles dxgvLista.CustomCallback
        Dim sCorreo As String = e.Parameters
        Me.EnviarNuevaClave(Me.dxgvLista.GetRowValues(Me.dxgvLista.EditingRowVisibleIndex, "USUARIO"), sCorreo)
    End Sub

    Private Function EnviarNuevaClave(ByVal usuario As String, ByVal correo As String) As Int32
        Dim c As cmembershipProvider
        Dim UsuarioActual As cmembershipUser
        Dim UsuarioDestino As cmembershipUser
        Dim Cuerpo As New StringBuilder

        c = CType(Membership.Provider, cmembershipProvider)
        UsuarioActual = c.ObtenerUsuario(Me.ObtenerUsuario)
        UsuarioDestino = c.ObtenerUsuario(usuario)

        If UsuarioActual IsNot Nothing AndAlso UsuarioDestino IsNot Nothing Then
            If UsuarioDestino.IsLockedOut Then UsuarioDestino.UnlockUser()
            Dim NuevaClave As String = c.ResetPassword(UsuarioDestino.UserName, "")

            Cuerpo.AppendLine(UsuarioDestino.Nombre)
            Cuerpo.Append("Su usuario es: ")
            Cuerpo.AppendLine(UsuarioDestino.UserName)
            Cuerpo.Append("Su nueva clave es: ")
            Cuerpo.AppendLine(NuevaClave)
            Cuerpo.AppendLine("")
            Cuerpo.AppendLine("Para cambiar esta clave ingrese al sistema, luego vaya al menu 'Seguridad' opcion 'Cambiar mi contrasena'.")
            Cuerpo.AppendLine("En la pantalla que se presenta digite en el primer campo la clave que se le envio y en los otros campos la clave que usted desea,")
            Cuerpo.AppendLine("finalmente haga clic en el boton Cambiar Contrasena.")

            If c.EnviarCorreo(UsuarioActual.Email, correo, "INSAFORP - Nueva Clave para el SGAFP", Cuerpo.ToString) = 1 Then
                Me.dxgvLista.JSProperties("cpMensaje") = "La nueva clave se ha enviado al usuario"
                Me.AsignarMensaje("La nueva clave se ha enviado al usuario", False, True)
            Else
                Me.dxgvLista.JSProperties("cpMensaje") = "Fallo al enviar clave al usuario"
                Me.AsignarMensaje("Fallo al enviar clave al usuario", True, True)
            End If
        Else
            If UsuarioActual Is Nothing Then
                Me.dxgvLista.JSProperties("cpMensaje") = "No se logro referenciar al usuario actual"
                Me.AsignarMensaje("No se logro referenciar al usuario actual", True, True)
            Else
                Me.dxgvLista.JSProperties("cpMensaje") = "No se logro referenciar al usuario"
                Me.AsignarMensaje("No se logro referenciar al usuario", True, True)
            End If
        End If

        Return -1
    End Function
End Class
