Imports DevExpress.Web.ASPxPivotGrid
Imports DevExpress.Web.ASPxClasses.Internal

Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls

Partial Class controles_ucConsultaEjecucionOferta
    Inherits ucBase

    Private Sub MostrarCampoEnColumnArea(ByRef campo As PivotGridField)
        campo.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        campo.Visible = True
    End Sub

    Private Sub MostrarCampoEnDataArea(ByRef campo As PivotGridField)
        campo.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        campo.Visible = True
    End Sub

    Private Sub MostrarCampoEnRowArea(ByRef campo As PivotGridField)
        campo.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        campo.Visible = True
    End Sub

    Private Sub MostrarCampoEnFilterArea(ByRef campo As PivotGridField)
        campo.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        campo.Visible = True
    End Sub

    Public Sub CargarPerfil()
        Me.pgLista.Fields("NOMBRE_PROVEEDOR").Visible = False
        Me.pgLista.Fields("NOMBRE_SITIO").Visible = False
        Me.pgLista.Fields("AREA_FORMACION").Visible = False
        Me.pgLista.Fields("ID").Visible = False
        Me.pgLista.Fields("NOMBRE_ACCION_FORMATIVA").Visible = False
        Me.pgLista.Fields("CODIGO_GRUPO").Visible = False
        Me.pgLista.Fields("HORARIO").Visible = False
        Me.pgLista.Fields("Inicio").Visible = False
        Me.pgLista.Fields("FECHA_FIN_REAL").Visible = False
        Me.pgLista.Fields("COSTO_X_PARTICIPANTE").Visible = False
        Me.pgLista.Fields("DURACION_HORAS").Visible = False
        Me.pgLista.Fields("DIRECCION").Visible = False
        Me.pgLista.Fields("ENCARGADO").Visible = False
        Me.pgLista.Fields("TELEFONO_ENCARGADO").Visible = False
        Me.pgLista.Fields("PORCENTAJEEJEC").Visible = False
        Me.pgLista.Fields("NOMBRE_ESTADO_AF").Visible = False

        Me.pgLista.Fields("N° Cursos").Visible = False
        Me.pgLista.Fields("Inscritos").Visible = False
        Me.pgLista.Fields("Costo").Visible = False

        Me.pgLista.Fields("Ejercicio").Visible = False
        Me.pgLista.Fields("Genero").Visible = False

        Select Case True
            Case Me.EstaEnRol(RolDeUsuario.CentroCapacitador), Me.EstaEnRol(RolDeUsuario.Proveedor)
                Me.MostrarCampoEnRowArea(Me.pgLista.Fields("NOMBRE_PROVEEDOR"))
                Me.MostrarCampoEnRowArea(Me.pgLista.Fields("NOMBRE_SITIO"))
                Me.MostrarCampoEnRowArea(Me.pgLista.Fields("NOMBRE_ACCION_FORMATIVA"))
                Me.MostrarCampoEnRowArea(Me.pgLista.Fields("CODIGO_GRUPO"))
                Me.MostrarCampoEnRowArea(Me.pgLista.Fields("HORARIO"))
                Me.MostrarCampoEnRowArea(Me.pgLista.Fields("Inicio"))
                Me.MostrarCampoEnRowArea(Me.pgLista.Fields("FECHA_FIN_REAL"))
                Me.MostrarCampoEnRowArea(Me.pgLista.Fields("NOMBRE_ESTADO_AF"))

                Me.MostrarCampoEnColumnArea(Me.pgLista.Fields("Ejercicio"))

                Me.MostrarCampoEnDataArea(Me.pgLista.Fields("Inscritos"))
                Me.MostrarCampoEnDataArea(Me.pgLista.Fields("Costo"))

                Me.MostrarCampoEnFilterArea(Me.pgLista.Fields("AREA_FORMACION"))
                Me.MostrarCampoEnFilterArea(Me.pgLista.Fields("COSTO_X_PARTICIPANTE"))
                Me.MostrarCampoEnFilterArea(Me.pgLista.Fields("DURACION_HORAS"))


            Case Me.EstaEnRol(RolDeUsuario.TecnicoCentroHTP), Me.EstaEnRol(RolDeUsuario.JefeHTP), _
                    Me.EstaEnRol(RolDeUsuario.GerenteGFI), Me.EstaEnRol(RolDeUsuario.Administrador)
                Me.MostrarCampoEnRowArea(Me.pgLista.Fields("NOMBRE_PROVEEDOR"))
                Me.MostrarCampoEnRowArea(Me.pgLista.Fields("NOMBRE_SITIO"))
                Me.MostrarCampoEnRowArea(Me.pgLista.Fields("ID"))
                Me.MostrarCampoEnRowArea(Me.pgLista.Fields("NOMBRE_ACCION_FORMATIVA"))
                Me.MostrarCampoEnRowArea(Me.pgLista.Fields("CODIGO_GRUPO"))
                Me.MostrarCampoEnRowArea(Me.pgLista.Fields("HORARIO"))
                Me.MostrarCampoEnRowArea(Me.pgLista.Fields("Inicio"))
                Me.MostrarCampoEnRowArea(Me.pgLista.Fields("FECHA_FIN_REAL"))
                Me.MostrarCampoEnRowArea(Me.pgLista.Fields("NOMBRE_ESTADO_AF"))

                Me.MostrarCampoEnColumnArea(Me.pgLista.Fields("Ejercicio"))
                Me.MostrarCampoEnColumnArea(Me.pgLista.Fields("Genero"))

                Me.MostrarCampoEnDataArea(Me.pgLista.Fields("Inscritos"))
                Me.MostrarCampoEnDataArea(Me.pgLista.Fields("Costo"))

                Me.MostrarCampoEnFilterArea(Me.pgLista.Fields("AREA_FORMACION"))
                Me.MostrarCampoEnFilterArea(Me.pgLista.Fields("COSTO_X_PARTICIPANTE"))
                Me.MostrarCampoEnFilterArea(Me.pgLista.Fields("DURACION_HORAS"))
                Me.MostrarCampoEnFilterArea(Me.pgLista.Fields("DIRECCION"))
                Me.MostrarCampoEnFilterArea(Me.pgLista.Fields("ENCARGADO"))
                Me.MostrarCampoEnFilterArea(Me.pgLista.Fields("TELEFONO_ENCARGADO"))
        End Select
    End Sub

    Public Function CargarEjecucionOfertaFormativa() As Integer
        If Decimal.Parse(Me.hfParametros("IdEjecucion")) <> -1 AndAlso CBool(Me.hfParametros("Actualizar")) Then
            Me.odsEjecucionOfertaFormativa.SelectParameters("TIPO_CONSULTA").DefaultValue = CInt(Me.hfParametros("IdEjecucion"))
            Me.odsEjecucionOfertaFormativa.SelectParameters("ID_EJERCICIO").DefaultValue = CStr(Me.hfParametros("IdEjercicio"))
            Me.odsEjecucionOfertaFormativa.SelectParameters("ID_PROVEEDOR_AF").DefaultValue = Decimal.Parse(Me.hfParametros("IdProveedor"))
            Me.odsEjecucionOfertaFormativa.SelectParameters("ID_SITIO_CAPACITACION").DefaultValue = Decimal.Parse(Me.hfParametros("IdCentroFormacion"))
            If Me.hfParametros("CodigoGrupo") IsNot Nothing Then
                Me.odsEjecucionOfertaFormativa.SelectParameters("CODIGO_GRUPO").DefaultValue = Me.hfParametros("CodigoGrupo")
            Else
                Me.odsEjecucionOfertaFormativa.SelectParameters("CODIGO_GRUPO").DefaultValue = ""
            End If

            Me.pgLista.DataSourceID = "odsEjecucionOfertaFormativa"
            Me.pgLista.DataBind()
        End If
        Return 1
    End Function

    Private Sub InicializarParametros()
        Me.hfParametros("Actualizar") = False
        Me.hfParametros("IdEjecucion") = -1
        Me.hfParametros("IdEjercicio") = String.Empty
        Me.hfParametros("IdProveedor") = -1
        Me.hfParametros("IdCentroFormacion") = -1
        Me.hfParametros("CodigoGrupo") = ""
        Me.hfParametros.SyncWithServer = True
    End Sub
    
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Me.CargarPerfil()
            Me.InicializarParametros()
            Me.Page.ClientScript.RegisterStartupScript(Me.Page.GetType(), "FuncionMostrarHistoricoAF", GenerarFuncionJSMostrarHistoricoAF, True)
        Else
            Me.CargarEjecucionOfertaFormativa()
        End If
    End Sub

    Protected Sub CallbackPanel_Callback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxClasses.CallbackEventArgsBase) Handles CallbackPanel.Callback
        Dim sParametros() As String
        sParametros = e.Parameter.Split(";")

        Me.hfParametros("Actualizar") = True
        Me.hfParametros("IdEjecucion") = Decimal.Parse(sParametros(0))
        Me.hfParametros("IdEjercicio") = sParametros(1)
        Me.hfParametros("IdProveedor") = Decimal.Parse(sParametros(2))
        Me.hfParametros("IdCentroFormacion") = Decimal.Parse(sParametros(3))
        If sParametros(4) <> "null" Then
            Me.hfParametros("CodigoGrupo") = sParametros(4).Trim.ToUpper
        Else
            Me.hfParametros("CodigoGrupo") = ""
        End If

        Me.CargarEjecucionOfertaFormativa()
    End Sub

    Protected Sub pgLista_CustomUnboundFieldData(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxPivotGrid.CustomFieldDataEventArgs) Handles pgLista.CustomUnboundFieldData
        If Object.ReferenceEquals(e.Field, Me.pgLista.Fields("ID")) Then
            If e.GetListSourceColumnValue("ID_ACCION_FORMATIVA") IsNot Nothing Then
                e.Value = String.Format("<a href=""javascript:MostrarHistoricoAF('{0}');"">{0}</a>", e.GetListSourceColumnValue("ID_ACCION_FORMATIVA").ToString)
            End If
        End If
    End Sub

    Protected Function GenerarFuncionJSMostrarHistoricoAF() As String
        Dim script As New StringBuilder

        script.Append("var postponedCallbackValuePopup = null; ")
        script.Append("function MostrarHistoricoAF(IdAccionFormativaAF) { ")
        script.Append(" if(CallbackPanelPopup.InCallback()) {")
        script.Append("     postponedCallbackValuePopup = IdAccionFormativaAF; ")
        script.Append(" } ")
        script.Append(" else { ")
        script.Append("     parametros = IdAccionFormativaAF; ")
        script.Append("     hfucListaACCION_FORMATIVA_HIST.Set('IdAccionFormativa',IdAccionFormativaAF); ")
        script.Append("     CallbackPanelPopup.PerformCallback(parametros); ")
        script.Append(" } ")
        script.Append("} ")

        Return script.ToString
    End Function

    Protected Sub CallbackPanelPopup_Callback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxClasses.CallbackEventArgsBase) Handles CallbackPanelPopup.Callback
        Dim parametros() As String
        parametros = e.Parameter.Split(";")
        Me.ucListaACCION_FORMATIVA_HIST1.CargarDatosPorID_ACCION_FORMATIVA(parametros(0))
    End Sub
End Class
