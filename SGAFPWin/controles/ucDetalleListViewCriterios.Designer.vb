<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucDetalleListViewCriterios
    Inherits ucBaseWin

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.ColumnNameComboBox = New System.Windows.Forms.ComboBox
        Me.CriteriaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ColumnBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CompareComboBox = New System.Windows.Forms.ComboBox
        Me.StringBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataValueTextBox = New System.Windows.Forms.TextBox
        Me.QueryOperatorComboBox = New System.Windows.Forms.ComboBox
        Me.QueryOperatorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OtherBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DateTimeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button_Eliminar = New System.Windows.Forms.Button
        CType(Me.CriteriaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColumnBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StringBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QueryOperatorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OtherBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateTimeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ColumnNameComboBox
        '
        Me.ColumnNameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CriteriaBindingSource, "ColumnName", True))
        Me.ColumnNameComboBox.DataSource = Me.ColumnBindingSource
        Me.ColumnNameComboBox.DisplayMember = "FriendlyName"
        Me.ColumnNameComboBox.FormattingEnabled = True
        Me.ColumnNameComboBox.Location = New System.Drawing.Point(2, 0)
        Me.ColumnNameComboBox.Name = "ColumnNameComboBox"
        Me.ColumnNameComboBox.Size = New System.Drawing.Size(121, 21)
        Me.ColumnNameComboBox.TabIndex = 2
        Me.ColumnNameComboBox.ValueMember = "Name"
        '
        'CriteriaBindingSource
        '
        Me.CriteriaBindingSource.DataSource = GetType(SGAFP.EL.Criteria)
        '
        'ColumnBindingSource
        '
        Me.ColumnBindingSource.DataSource = GetType(SGAFP.WinUC.Column)
        '
        'CompareComboBox
        '
        Me.CompareComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CriteriaBindingSource, "Compare", True))
        Me.CompareComboBox.DataSource = Me.StringBindingSource
        Me.CompareComboBox.DisplayMember = "Text"
        Me.CompareComboBox.FormattingEnabled = True
        Me.CompareComboBox.Location = New System.Drawing.Point(126, 0)
        Me.CompareComboBox.Name = "CompareComboBox"
        Me.CompareComboBox.Size = New System.Drawing.Size(121, 21)
        Me.CompareComboBox.TabIndex = 3
        Me.CompareComboBox.ValueMember = "Value"
        '
        'StringBindingSource
        '
        Me.StringBindingSource.DataSource = GetType(SGAFP.WinUC.SelectCriteria)
        '
        'DataValueTextBox
        '
        Me.DataValueTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CriteriaBindingSource, "DataValue", True))
        Me.DataValueTextBox.Location = New System.Drawing.Point(250, 0)
        Me.DataValueTextBox.Name = "DataValueTextBox"
        Me.DataValueTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DataValueTextBox.TabIndex = 4
        '
        'QueryOperatorComboBox
        '
        Me.QueryOperatorComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CriteriaBindingSource, "QueryOperator", True))
        Me.QueryOperatorComboBox.DataSource = Me.QueryOperatorBindingSource
        Me.QueryOperatorComboBox.DisplayMember = "Text"
        Me.QueryOperatorComboBox.FormattingEnabled = True
        Me.QueryOperatorComboBox.Location = New System.Drawing.Point(351, 0)
        Me.QueryOperatorComboBox.Name = "QueryOperatorComboBox"
        Me.QueryOperatorComboBox.Size = New System.Drawing.Size(63, 21)
        Me.QueryOperatorComboBox.TabIndex = 5
        Me.QueryOperatorComboBox.ValueMember = "Value"
        '
        'QueryOperatorBindingSource
        '
        Me.QueryOperatorBindingSource.DataSource = GetType(SGAFP.WinUC.SelectCriteria)
        '
        'OtherBindingSource
        '
        Me.OtherBindingSource.DataSource = GetType(SGAFP.WinUC.SelectCriteria)
        '
        'DateTimeBindingSource
        '
        Me.DateTimeBindingSource.DataSource = GetType(SGAFP.WinUC.SelectCriteria)
        '
        'Button_Eliminar
        '
        Me.Button_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Eliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Eliminar.Location = New System.Drawing.Point(418, 0)
        Me.Button_Eliminar.Name = "Button_Eliminar"
        Me.Button_Eliminar.Size = New System.Drawing.Size(61, 21)
        Me.Button_Eliminar.TabIndex = 6
        Me.Button_Eliminar.Text = "Eliminar"
        Me.Button_Eliminar.UseVisualStyleBackColor = True
        '
        'ucDetalleListViewCriterios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Button_Eliminar)
        Me.Controls.Add(Me.QueryOperatorComboBox)
        Me.Controls.Add(Me.DataValueTextBox)
        Me.Controls.Add(Me.CompareComboBox)
        Me.Controls.Add(Me.ColumnNameComboBox)
        Me.Name = "ucDetalleListViewCriterios"
        Me.Size = New System.Drawing.Size(484, 22)
        CType(Me.CriteriaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColumnBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StringBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QueryOperatorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OtherBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateTimeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ColumnNameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CompareComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DataValueTextBox As System.Windows.Forms.TextBox
    Friend WithEvents QueryOperatorComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ColumnBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CriteriaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents QueryOperatorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OtherBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DateTimeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StringBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Button_Eliminar As System.Windows.Forms.Button

End Class
