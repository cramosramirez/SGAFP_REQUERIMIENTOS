Public Class ucListViewCriterios
    Protected WithEvents _EditorEntidad As ucDetalleListViewCriterios
    Public mLista As New listaBase(Of Criteria)
    Public ColumnList As List(Of WinUC.Column)
    Public indexEditing As Integer = -1

#Region "Propiedades"

    Public ReadOnly Property EntidadSeleccionada() As Criteria
        Get
            If lvLista.SelectedItems.Count > 0 Then
                indexEditing = lvLista.SelectedItems.Item(0).Index
                Return mLista(mLista.FindByColum("ColumnName", lvLista.SelectedItems.Item(0).SubItems(0).Text))
                'Return mLista.BuscarPorId(CInt(lvLista.SelectedItems.Item(0).SubItems(0).Text))
            Else
                indexEditing = -1
                Return Nothing
            End If
        End Get
    End Property

#End Region

    Public Sub CargarDatos()

        If Not mLista.Count > 0 Then
            lvLista.BeginUpdate()
            lvLista.Items.Clear()
            lvLista.Controls.Clear()
            lvLista.EndUpdate()
            Return
        End If

        lvLista.BeginUpdate()
        lvLista.Items.Clear()
        lvLista.Controls.Clear()
        Dim Panel1 As New System.Windows.Forms.Panel
        Panel1.Location = New Point(1, 16)
        Panel1.Name = "Panel1"
        Panel1.Size = New System.Drawing.Size(lvLista.Width - 2, lvLista.Height - 16)
        Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Panel1.TabIndex = 7
        Panel1.AutoScroll = True
        Panel1.Controls.Clear()

        Dim topDetalle As Integer = 1
        Dim i As Integer = 0
        For Each mEntidad As Criteria In mLista
            Dim ucDetalleListViewCriterios1 As New ucDetalleListViewCriterios
            ucDetalleListViewCriterios1.IndiceRegistro = i
            ucDetalleListViewCriterios1.ColumnList = Me.ColumnList
            ucDetalleListViewCriterios1.Location = New Point(1, topDetalle)
            ucDetalleListViewCriterios1.Width = Panel1.Width - 8
            ucDetalleListViewCriterios1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            ucDetalleListViewCriterios1.CargarDatos(mEntidad)
            AddHandler ucDetalleListViewCriterios1.Eliminado, AddressOf Eliminado
            Panel1.Controls.Add(ucDetalleListViewCriterios1)
            topDetalle += ucDetalleListViewCriterios1.Height + 1
            i += 1
        Next
        lvLista.Controls.Add(Panel1)
        lvLista.EndUpdate()

    End Sub

    Public Sub ObtenerDatos()
        Dim i As Integer = 0
        If Me.lvLista.Controls.Count = 0 Then Return
        For Each lControl As ucDetalleListViewCriterios In Me.lvLista.Controls(0).Controls
            mLista(i) = lControl.Current
        Next
    End Sub

    Public Sub Eliminado(ByVal indice As Integer)
        Me.ObtenerDatos()
        Me.mLista.RemoveAt(indice)
        Me.CargarDatos()
        'Me.lvLista.Controls(0).Controls.Find(
    End Sub

    Public Function EditarEntidad(Optional ByVal Nuevo As Boolean = False, Optional ByVal Editar As Boolean = True) As Integer
        _EditorEntidad = New ucDetalleListViewCriterios
        _EditorEntidad.ColumnList = Me.ColumnList
        If Me.lvLista.Items.Count = 0 Then
            Me.lvLista.Items.Add("")
        End If
        _EditorEntidad.Location = New Point(1, Me.lvLista.Items(0).GetBounds(ItemBoundsPortion.Entire).Y - 2)
        _EditorEntidad.Width = lvLista.Width - 8
        If Nuevo Then
            _EditorEntidad.Nuevo()
            Dim lEntidad As Criteria
            lEntidad = Me.mLista(mLista.Count - 1)
            indexEditing = mLista.Count - 1
            _EditorEntidad.CargarDatos(lEntidad)
        Else
            If Me.EntidadSeleccionada Is Nothing Then
                Me.AsignarMensaje("Debe de seleccionar un registro para poder editarlo", True)
                Return -1
            End If
            _EditorEntidad.CargarDatos(Me.EntidadSeleccionada)
        End If
        'AsignarAcceso(_EditorEntidad)

        Me.lvLista.Items.Clear()
        Me.lvLista.Controls.Add(_EditorEntidad)
    End Function

    Public Function EliminarEntidad() As Integer

    End Function

    'Private Sub lvLista_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvLista.DoubleClick
    '    If Me.lvLista.SelectedItems.Count > 0 And PermitirEditar Then
    '        If Me.EditarEntidad() = 1 Then RaiseEvent Editando()
    '    ElseIf Me.lvLista.SelectedItems.Count > 0 And Not PermitirEditar Then
    '        If Me.EditarEntidad(False, False) = 1 Then RaiseEvent Consultando()
    '    End If
    'End Sub

End Class
