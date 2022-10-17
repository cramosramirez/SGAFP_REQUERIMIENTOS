Public Class frmAsociacionGruposPATI

    Private _gruposSeleccionados As New List(Of Decimal)
    Private _accionesSeleccionadas As New List(Of Decimal)
    Private _idAccionContratada As Decimal
    Private _tipoOperacion As TipoOperacion

    Private Enum TipoOperacion
        Asociar = 1
        Desasociar = 2
        Habilitar = 3
    End Enum

    Public Property GruposSeleccionados() As List(Of Decimal)
        Get
            Return _gruposSeleccionados
        End Get
        Set(ByVal value As List(Of Decimal))
            _gruposSeleccionados = value
        End Set
    End Property

    Public Property AccionesSeleccionadas() As List(Of Decimal)
        Get
            Return _accionesSeleccionadas
        End Get
        Set(ByVal value As List(Of Decimal))
            _accionesSeleccionadas = value
        End Set
    End Property

    Public Sub CargarGruposDisponibles(ByVal ID_ACCION_CONTRATADA As Decimal, ByVal ID_FUENTE As Decimal, ByVal NO_CONVOCATORIA As Decimal, ByVal CODIGO_DEPARTAMENTO As String, ByVal CODIGO_MUNICIPIO As String)
        _idAccionContratada = ID_ACCION_CONTRATADA
        Dim bAccionContratada As New cACCION_CONTRATADA
        Me.ListaGRUPOS_PATIGridControl.DataMember = "Table"
        If CODIGO_DEPARTAMENTO = "" Then CODIGO_DEPARTAMENTO = "-"
        If CODIGO_MUNICIPIO = "" Then CODIGO_MUNICIPIO = "-"
        Me.ListaGRUPOS_PATIGridControl.DataSource = (New cACCION_CONTRATADA).ObtenerGruposCapacitacionPATIparaAsociar(ID_FUENTE, NO_CONVOCATORIA, CODIGO_DEPARTAMENTO, CODIGO_MUNICIPIO)
        Me.AceptarSimpleButton.Text = "Asociar"
        Me._tipoOperacion = TipoOperacion.Asociar
        Me.ListaGRUPOS_PATIGridView.Columns("HABILITADO").Visible = False
        Me._tipoOperacion = TipoOperacion.Asociar
    End Sub

    Public Sub CargarGruposPorDesasociar(ByVal ID_ACCION_CONTRATADA As Decimal)
        _idAccionContratada = ID_ACCION_CONTRATADA
        Dim bAccionContratada As New cACCION_CONTRATADA
        Me.ListaGRUPOS_PATIGridControl.DataMember = "Table"
        Me.ListaGRUPOS_PATIGridControl.DataSource = (New cACCION_CONTRATADA).ObtenerGruposCapacitacionPATIAsociados(ID_ACCION_CONTRATADA)
        Me.Text = "Desasociar Grupos"
        Me.AceptarSimpleButton.Text = "Desasociar"
        Me._tipoOperacion = TipoOperacion.Desasociar
    End Sub

    Public Sub CargarGruposPorHabilitar(ByVal ID_ACCION_CONTRATADA As Decimal)
        _idAccionContratada = ID_ACCION_CONTRATADA
        Dim bAccionContratada As New cACCION_CONTRATADA
        Me.ListaGRUPOS_PATIGridControl.DataMember = "Table"
        Me.ListaGRUPOS_PATIGridControl.DataSource = (New cACCION_CONTRATADA).ObtenerGruposCapacitacionPATIAsociados(ID_ACCION_CONTRATADA)
        Me.Text = "Habilitar Grupos asociados"
        Me.AceptarSimpleButton.Text = "Habilitar"
        Me._tipoOperacion = TipoOperacion.Habilitar
    End Sub

    Private Sub frmAsociacionGruposPATI_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If DialogResult = Windows.Forms.DialogResult.OK Then
            GruposSeleccionados.Clear()
            For Each dr As DataRow In CType(Me.ListaGRUPOS_PATIGridControl.DataSource, DataSet).Tables(0).Rows
                If CDec(dr("VALOR")) = 1 Then
                    GruposSeleccionados.Add(CDec(dr("ID_GRUPO_AF")))
                    If Not IsDBNull(dr("ID_GRUPO_ACCION")) Then AccionesSeleccionadas.Add(CDec(dr("ID_GRUPO_ACCION")))
                End If
            Next
            If Me.GruposSeleccionados.Count = 0 Then
                e.Cancel = True
                AsignarMensaje("Seleccione al menos un Grupo", True)
            Else
                'Verificar que la cantidad de grupos seleccionados más la cantidad de grupos asociados no exceda la cantidad de grupos contratados
                If _tipoOperacion = TipoOperacion.Asociar Then
                    Dim lListaGrupoAccionContra As listaGRUPO_ACCION_CONTRATADA
                    Dim lEntidadAccion As ACCION_CONTRATADA = (New cACCION_CONTRATADA).ObtenerACCION_CONTRATADA(_idAccionContratada)
                    lListaGrupoAccionContra = (New cGRUPO_ACCION_CONTRATADA).ObtenerListaPorACCION_CONTRATADA(_idAccionContratada)
                    If lListaGrupoAccionContra.Count + GruposSeleccionados.Count > lEntidadAccion.CANT_CURSOS Then
                        e.Cancel = True
                        AsignarMensaje("N° de Grupos seleccionados (" + GruposSeleccionados.Count.ToString + _
                                       ") más los Grupos ya asociados (" + lListaGrupoAccionContra.Count.ToString + ") " + _
                                       "suman: " + CStr(GruposSeleccionados.Count + lListaGrupoAccionContra.Count) + " y sobrepasan los cursos contratados (" + lEntidadAccion.CANT_CURSOS.ToString + ")", True)
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub RepositoryItemCheckEdit1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RepositoryItemCheckEdit1.CheckedChanged
        If _tipoOperacion = TipoOperacion.Desasociar OrElse _tipoOperacion = TipoOperacion.Habilitar Then
            Dim chkEdit As DevExpress.XtraEditors.CheckEdit = CType(sender, DevExpress.XtraEditors.CheckEdit)
            If chkEdit.Checked AndAlso CType(Me.ListaGRUPOS_PATIGridView.GetFocusedRow, System.Data.DataRowView)("HABILITADO") = 1 Then
                chkEdit.Checked = False
                AsignarMensaje("No se puede seleccionar un Grupo Habilitado", True)
            End If
        End If
    End Sub
End Class