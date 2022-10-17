Imports SGAFP.WinUC

Public Class ucDetalleListViewCriterios

    Public Event Seleccionado(ByVal indice As Integer)
    Public Event Eliminado(ByVal indice As Integer)

    Public IndiceRegistro As Integer
    Public ColumnList As List(Of WinUC.Column)
    Private lPredicado As New PredicateColumn

    Protected Sub InicializarListaControles()
        Me.StringBindingSource.DataSource = Me.ListStringComparator
        Me.DateTimeBindingSource.DataSource = Me.ListDateTimeComparator
        Me.OtherBindingSource.DataSource = Me.ListOtherComparator
        Me.QueryOperatorBindingSource.DataSource = Me.ListQueryOperator
        Me.ColumnBindingSource.DataSource = Me.ColumnList
    End Sub

    Private Function ListStringComparator() As List(Of SelectCriteria)
        Dim lSelectCriteria As New List(Of SelectCriteria)
        lSelectCriteria.Add(New SelectCriteria("Es Igual a", "="))
        lSelectCriteria.Add(New SelectCriteria("Contiene a", "%*%"))
        lSelectCriteria.Add(New SelectCriteria("Empieza con", "*%"))
        lSelectCriteria.Add(New SelectCriteria("Termina con", "%*"))
        lSelectCriteria.Add(New SelectCriteria("Es Diferente de", "<>"))
        Return lSelectCriteria
    End Function

    Private Function ListDateTimeComparator() As List(Of SelectCriteria)
        Dim lSelectCriteria As New List(Of SelectCriteria)
        lSelectCriteria.Add(New SelectCriteria("Es Igual a", "="))
        lSelectCriteria.Add(New SelectCriteria("Es Mayor a", ">"))
        lSelectCriteria.Add(New SelectCriteria("Es mayor o Igual a", ">="))
        lSelectCriteria.Add(New SelectCriteria("Es Menor a", "<"))
        lSelectCriteria.Add(New SelectCriteria("Es Menor o Igual a", "<="))
        lSelectCriteria.Add(New SelectCriteria("Es Diferente de", "<>"))
        Return lSelectCriteria
    End Function

    Private Function ListOtherComparator() As List(Of SelectCriteria)
        Dim lSelectCriteria As New List(Of SelectCriteria)
        lSelectCriteria.Add(New SelectCriteria("Es Igual a", "="))
        lSelectCriteria.Add(New SelectCriteria("Es Mayor a", ">"))
        lSelectCriteria.Add(New SelectCriteria("Es Mayor o Igual a", ">="))
        lSelectCriteria.Add(New SelectCriteria("Es Menor a", "<"))
        lSelectCriteria.Add(New SelectCriteria("Es Menor o Igual a", "<="))
        lSelectCriteria.Add(New SelectCriteria("Es Diferente de", "<>"))
        Return lSelectCriteria
    End Function

    Private Function ListQueryOperator() As List(Of SelectCriteria)
        Dim lSelectCriteria As New List(Of SelectCriteria)
        lSelectCriteria.Add(New SelectCriteria("Y", "AND"))
        lSelectCriteria.Add(New SelectCriteria("O", "OR"))
        Return lSelectCriteria
    End Function

    Private Sub EstablecerModoEdicion(ByVal edicion As Boolean)
        Me.ColumnNameComboBox.Enabled = edicion
        Me.CompareComboBox.Enabled = edicion
        Me.DataValueTextBox.Enabled = edicion
        Me.QueryOperatorComboBox.Enabled = edicion
    End Sub

    Public ReadOnly Property Current() As Criteria
        Get
            Me.CriteriaBindingSource.EndEdit()
            If Me.CriteriaBindingSource.Current Is Nothing Then Return Nothing
            Return CType(Me.CriteriaBindingSource.Current, Criteria)
        End Get
    End Property

    Public Sub CargarDatos(ByVal aEntidad As Criteria)
        InicializarListaControles()
        Me.CriteriaBindingSource.Add(aEntidad)
    End Sub

    Public Sub Nuevo()
        InicializarListaControles()
    End Sub

    Private Sub ColumnNameComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColumnNameComboBox.SelectedIndexChanged
        Dim cbxColumn1 As ComboBox = CType(sender, ComboBox)
        lPredicado.Name = cbxColumn1.SelectedValue.ToString()
        Me.CambioColumna()
    End Sub

    Private Sub CambioColumna()
        If Not Me.ColumnList Is Nothing AndAlso Not Me.ColumnList.Find(AddressOf lPredicado.ExistColumn) Is Nothing Then
            Select Case Me.ColumnList.Find(AddressOf lPredicado.ExistColumn).DataType
                Case "String"
                    Me.CompareComboBox.DataSource = Me.StringBindingSource
                Case "DateTime", "Date"
                    Me.CompareComboBox.DataSource = Me.DateTimeBindingSource
                Case Else
                    Me.CompareComboBox.DataSource = Me.OtherBindingSource
            End Select
        End If
    End Sub

    Private Sub ucDetalleListViewCriterios_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
        If Me.BackColor = System.Drawing.SystemColors.Control Then
            Me.BackColor = System.Drawing.SystemColors.Highlight
        Else
            Me.BackColor = System.Drawing.SystemColors.Control
        End If
        RaiseEvent Seleccionado(Me.IndiceRegistro)
    End Sub

    Private Sub Button_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Eliminar.Click
        RaiseEvent Eliminado(Me.IndiceRegistro)
    End Sub

End Class
