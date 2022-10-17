Imports SGAFP.BL
Imports SGAFP.EL
Imports System.Collections.Generic
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucListaPAQUETE_INFORME_DET
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar un listado de la tabla PAQUETE_INFORME_DET
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.6.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	26/08/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucListaPAQUETE_INFORME_DET
    Inherits ucListaBase
 
    Private mComponente As New cPAQUETE_INFORME_DET
    Public Event Seleccionado(ByVal ID_PAQUETE As Decimal, ByVal ID_INFORME_FINAL As Decimal) 
    Public Event Editando(ByVal ID_PAQUETE As Decimal, ByVal ID_INFORME_FINAL As Decimal) 

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

    Private _PermitirEditar As Boolean = True
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

    Public Property PermitirFiltrarEnFila() As Boolean
        Get
            Return Me.dxgvLista.Settings.ShowFilterRow
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Settings.ShowFilterRow = Value
        End Set
    End Property

    Public Property PermitirFiltrarEnEncabezadoColumna() As Boolean
        Get
            Return Me.dxgvLista.Settings.ShowHeaderFilterButton
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Settings.ShowHeaderFilterButton = Value
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

    Public Property PermitirEliminar() As Boolean
        Get
            Return Me.dxgvLista.Columns("Eliminar").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("Eliminar").Visible = Value
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

    Public Property PermitirMarcar() As Boolean
        Get
            Return Me.dxgvLista.Columns("#").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("#").Visible = Value
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

    Private _ID_PAQUETE As Decimal
    Public Property ID_PAQUETE() As Decimal
        Get
            Return _ID_PAQUETE
        End Get
        Set(ByVal Value As Decimal)
            _ID_PAQUETE = Value 
            If Not Me.ViewState("ID_PAQUETE") Is Nothing Then Me.ViewState.Remove("ID_PAQUETE")
            Me.ViewState.Add("ID_PAQUETE", Value)
        End Set
    End Property

    Public Property VerID_PAQUETE() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_PAQUETE").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_PAQUETE").Visible = Value
        End Set
    End Property

    Public Property VerID_INFORME_FINAL() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_INFORME_FINAL").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_INFORME_FINAL").Visible = Value
        End Set
    End Property

    Public Property VerLASTUPDATE() As Boolean
        Get
            Return Me.dxgvLista.Columns("LASTUPDATE").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("LASTUPDATE").Visible = Value
        End Set
    End Property

    Public Property VerUSERID() As Boolean
        Get
            Return Me.dxgvLista.Columns("USERID").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("USERID").Visible = Value
        End Set
    End Property

    Public Property HeaderID_PAQUETE() As String
        Get
            Return Me.dxgvLista.Columns("ID_PAQUETE").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_PAQUETE").Caption = Value
        End Set
    End Property

    Public Property HeaderID_INFORME_FINAL() As String
        Get
            Return Me.dxgvLista.Columns("ID_INFORME_FINAL").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_INFORME_FINAL").Caption = Value
        End Set
    End Property

    Public Property HeaderLASTUPDATE() As String
        Get
            Return Me.dxgvLista.Columns("LASTUPDATE").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("LASTUPDATE").Caption = Value
        End Set
    End Property

    Public Property HeaderUSERID() As String
        Get
            Return Me.dxgvLista.Columns("USERID").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("USERID").Caption = Value
        End Set
    End Property

#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla PAQUETE_INFORME_DET
    ''' filtrado por la tabla PAQUETE_INFORME
    ''' </summary>
    ''' <param name="ID_PAQUETE"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	26/08/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorPAQUETE_INFORME(ByVal ID_PAQUETE As Decimal) As Integer
        Me.odsListaPorPAQUETE_INFORME.SelectParameters("ID_PAQUETE").DefaultValue = ID_PAQUETE.ToString()
        Me.odsListaPorPAQUETE_INFORME.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorPAQUETE_INFORME"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla PAQUETE_INFORME_DET
    ''' filtrado por la tabla INFORME_FINAL_AF
    ''' </summary>
    ''' <param name="ID_ESTADO_INFORME"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	26/08/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorESTADO_ACCION_FORMATIVA_USUARIO(ByVal ID_ESTADO_INFORME As Decimal, ByVal USUARIO As String) As Integer
        Me.odsListaPorESTADO_ACCION_FORMATIVA_USUARIO.SelectParameters("ID_ESTADO_INFORME").DefaultValue = ID_ESTADO_INFORME.ToString()
        Me.odsListaPorESTADO_ACCION_FORMATIVA_USUARIO.SelectParameters("USUARIO").DefaultValue = USUARIO.ToString()
        Me.odsListaPorESTADO_ACCION_FORMATIVA_USUARIO.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorESTADO_ACCION_FORMATIVA_USUARIO"
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
        If Not Me.ViewState("ID_PAQUETE") Is Nothing Then Me._ID_PAQUETE = Me.ViewState("ID_PAQUETE")
    End Sub

    Protected Sub dxgvLista_CustomUnboundColumnData(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewColumnDataEventArgs) Handles dxgvLista.CustomUnboundColumnData
        e.Value = e.ListSourceRowIndex + 1
    End Sub


    Protected Sub dxgvLista_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles dxgvLista.Init
        If Me.PermitirSeleccionar And Me.ComandoSeleccionar = "Check" Then
            Me.dxgvLista.Columns("Seleccionar").Visible = True
            CType(Me.dxgvLista.Columns("Seleccionar"), DevExpress.Web.ASPxGridView.GridViewCommandColumn).ShowSelectCheckbox = True
        End If
    End Sub

    Protected Sub dxgvLista_RowCommand(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewRowCommandEventArgs) Handles dxgvLista.RowCommand
        If e.CommandArgs.CommandName = "Select" And ComandoSeleccionar <> "Check" Then
            Me.dxgvLista.Selection.UnselectAll()
            Me.dxgvLista.Selection.SelectRow(e.VisibleIndex)
            RaiseEvent Seleccionado(ID_PAQUETE, e.CommandArgs.CommandArgument)
        End If
        If e.CommandArgs.CommandName = "Editar" Then
            RaiseEvent Editando(ID_PAQUETE, e.CommandArgs.CommandArgument)
        End If
    End Sub

    Protected Sub dxgvLista_HtmlRowCreated(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewTableRowEventArgs) Handles dxgvLista.HtmlRowCreated
        If e.RowType = DevExpress.Web.ASPxGridView.GridViewRowType.Data Then
            If Not Me.PermitirEditar Then
                Dim lbDetalle As LinkButton
                lbDetalle = Me.dxgvLista.FindRowCellTemplateControl(e.VisibleIndex, Nothing, "lbtnEditar")
                lbDetalle.Visible = False
            End If
            If Me.PermitirSeleccionar Then
                Dim lbSeleccionar As LinkButton
                lbSeleccionar = Me.dxgvLista.FindRowCellTemplateControl(e.VisibleIndex, Nothing, "lbtnSeleccionar")
                lbSeleccionar.Visible = True
                lbSeleccionar.Text = Me.TextoSeleccionar
                lbSeleccionar.CommandName = Me.ComandoSeleccionar
                If lbSeleccionar.CommandName = "Check" Then
                    lbSeleccionar.Visible = False
                End If
            End If
        End If
    End Sub

    Public Function DevolverSeleccionados() As listaPAQUETE_INFORME_DET
        Dim mLista As New listaPAQUETE_INFORME_DET
        For Each llave As Decimal In Me.dxgvLista.GetSelectedFieldValues("ID_INFORME_FINAL")
            Dim lEntidad As New PAQUETE_INFORME_DET
            lEntidad.ID_PAQUETE = Me.ID_PAQUETE
            lEntidad.ID_INFORME_FINAL = llave
            mLista.Add(lEntidad)
        Next
        Return mLista
    End Function

    Protected Sub dxgvLista_CustomButtonCallback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewCustomButtonCallbackEventArgs) Handles dxgvLista.CustomButtonCallback
        If e.ButtonID = "btnEliminar" Then
            Dim lEntidad As PAQUETE_INFORME_DET = CType(Me.dxgvLista.GetRow(e.VisibleIndex), PAQUETE_INFORME_DET)

            If Me.mComponente.EliminarPAQUETE_INFORME_DET(ID_PAQUETE, lEntidad.ID_INFORME_FINAL) <> 1 Then
                'Si se cometio un error
                Me.AsignarMensaje("Error al Eliminar Registro", True, True)
            Else
                Me.dxgvLista.DataBind()
            End If
        End If
    End Sub

    Protected Sub dxgvLista_CustomButtonInitialize(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewCustomButtonEventArgs) Handles dxgvLista.CustomButtonInitialize
        If e.ButtonID = "btnEliminar" Then
            e.Text = "<img src='imagenes/Eliminar.gif' style='border-style:none;border-width:0px;height:18px;width:18px;' alt='Eliminar' onclick='if(!window.confirm(" + """" + "Esta seguro de Eliminar el Registro?"")){return false;}'/>"
        End If
    End Sub

    Public ReadOnly Property ExisteSeleccion() As Boolean
        Get
            Return (dxgvLista.GetSelectedFieldValues("ID_INFORME_FINAL").Count > 0)
        End Get
    End Property

    Public Function Actualizar(ByVal IdPaquete As Decimal) As String
        Dim PaqueteDet As New cPAQUETE_INFORME_DET
        Dim ePaqueteDet As New PAQUETE_INFORME_DET
        Dim filas As List(Of Object) = dxgvLista.GetSelectedFieldValues("ID_INFORME_FINAL")

        For i As Integer = 0 To filas.Count - 1
            Dim ID_INFORME_FINAL As Integer = CInt(filas(i))

            If EstaEnRol(RolDeUsuario.TecnicoCentroHTP) Then
                If PaqueteDet.ObtenerPAQUETE_INFORME_DET(IdPaquete, ID_INFORME_FINAL, False) Is Nothing Then
                    PaqueteDet.AgregarPAQUETE_INFORME_DET(IdPaquete, ID_INFORME_FINAL, Now, Me.ObtenerUsuario)
                End If

            ElseIf EstaEnRol(RolDeUsuario.JefeHTP) Then
                Dim bInformeFinal As New cINFORME_FINAL_AF
                Dim lInformeFinal As INFORME_FINAL_AF

                lInformeFinal = bInformeFinal.ObtenerINFORME_FINAL_AF(ID_INFORME_FINAL)
                lInformeFinal.ID_ESTADO_INFORME = EstadoInformeFinal.InformeValidadoCoordinador
                lInformeFinal.USERID = Me.ObtenerUsuario
                lInformeFinal.LASTUPDATE = Now
                If bInformeFinal.ActualizarINFORME_FINAL_AF(lInformeFinal, TipoConcurrencia.Pesimistica, False, True, False) < 1 Then
                    Me.AsignarMensaje("Error al Actualizar el Informe", True, True)
                    Return "Error al Guardar registro."
                End If

            ElseIf EstaEnRol(RolDeUsuario.GerenteGFI) Then
                Dim bInformeFinal As New cINFORME_FINAL_AF
                Dim lInformeFinal As INFORME_FINAL_AF

                lInformeFinal = bInformeFinal.ObtenerINFORME_FINAL_AF(ID_INFORME_FINAL)
                lInformeFinal.ID_ESTADO_INFORME = EstadoInformeFinal.InformeEnRevisionUACI
                lInformeFinal.USERID = Me.ObtenerUsuario
                lInformeFinal.LASTUPDATE = Now
                If bInformeFinal.ActualizarINFORME_FINAL_AF(lInformeFinal, TipoConcurrencia.Pesimistica, False, True, False) < 1 Then
                    Me.AsignarMensaje("Error al Actualizar el Informe", True, True)
                    Return "Error al Guardar registro."
                End If
            End If
        Next

        'Eliminar informes que no se seleccionaron
        If EstaEnRol(RolDeUsuario.JefeHTP) OrElse EstaEnRol(RolDeUsuario.GerenteGFI) Then
            Dim lPaqueteDet As listaPAQUETE_INFORME_DET = PaqueteDet.ObtenerLista(IdPaquete)

            For Each p As PAQUETE_INFORME_DET In lPaqueteDet
                Dim bInformeFinal As New cINFORME_FINAL_AF
                Dim lInformeFinal As INFORME_FINAL_AF

                lInformeFinal = bInformeFinal.ObtenerINFORME_FINAL_AF(p.ID_INFORME_FINAL)

                If EstaEnRol(RolDeUsuario.JefeHTP) AndAlso lInformeFinal.ID_ESTADO_INFORME = EstadoInformeFinal.InformeValidadoTecnico Then
                    lInformeFinal.ID_ESTADO_INFORME = EstadoInformeFinal.InformeEnRevision
                    lInformeFinal.USERID = Me.ObtenerUsuario
                    lInformeFinal.LASTUPDATE = Now
                    If bInformeFinal.ActualizarINFORME_FINAL_AF(lInformeFinal, TipoConcurrencia.Pesimistica, False, True, False) < 1 Then
                        If PaqueteDet.EliminarPAQUETE_INFORME_DET(p, TipoConcurrencia.Pesimistica) < 1 Then
                            Me.AsignarMensaje("Error al Eliminar el Informe del Paquete", True, True)
                            Return "Error al Guardar registro."
                        End If
                    Else
                        Me.AsignarMensaje("Error al Actualizar el Informe", True, True)
                        Return "Error al Guardar registro."
                    End If

                ElseIf EstaEnRol(RolDeUsuario.GerenteGFI) AndAlso lInformeFinal.ID_ESTADO_INFORME = EstadoInformeFinal.InformeValidadoCoordinador Then
                    lInformeFinal.ID_ESTADO_INFORME = EstadoInformeFinal.InformeEnRevision
                    lInformeFinal.USERID = Me.ObtenerUsuario
                    lInformeFinal.LASTUPDATE = Now
                    If bInformeFinal.ActualizarINFORME_FINAL_AF(lInformeFinal, TipoConcurrencia.Pesimistica, False, True, False) = 1 Then
                        If PaqueteDet.EliminarPAQUETE_INFORME_DET(p, TipoConcurrencia.Pesimistica) < 1 Then
                            Me.AsignarMensaje("Error al Eliminar el Informe del Paquete", True, True)
                            Return "Error al Guardar registro."
                        End If
                    Else
                        Me.AsignarMensaje("Error al Actualizar el Informe", True, True)
                        Return "Error al Guardar registro."
                    End If
                End If
            Next
        End If

        Return ""
    End Function
End Class
