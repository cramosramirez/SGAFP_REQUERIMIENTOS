<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucListaAREA_FORMACION
    Inherits SGAFP.ucBaseLista

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.ListaAREA_FORMACIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListaAREA_FORMACIONDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxID_AREA_FORMACION = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxAREA_FORMACION = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxNOTAS = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.ListaAREA_FORMACIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaAREA_FORMACIONDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListaAREA_FORMACIONBindingSource
        '
        Me.ListaAREA_FORMACIONBindingSource.DataSource = GetType(SGAFP.EL.AREA_FORMACION)
        '
        'ListaAREA_FORMACIONDataGridView
        '
        Me.ListaAREA_FORMACIONDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListaAREA_FORMACIONDataGridView.AutoGenerateColumns = False
        Me.ListaAREA_FORMACIONDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxID_AREA_FORMACION, Me.DataGridViewTextBoxAREA_FORMACION, Me.DataGridViewTextBoxNOTAS})
        Me.ListaAREA_FORMACIONDataGridView.DataSource = Me.ListaAREA_FORMACIONBindingSource
        Me.ListaAREA_FORMACIONDataGridView.Location = New System.Drawing.Point(3, 28)
        Me.ListaAREA_FORMACIONDataGridView.Name = "ListaAREA_FORMACIONDataGridView"
        Me.ListaAREA_FORMACIONDataGridView.Size = New System.Drawing.Size(523, 323)
        Me.ListaAREA_FORMACIONDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxID_AREA_FORMACION
        '
        Me.DataGridViewTextBoxID_AREA_FORMACION.DataPropertyName = "ID_AREA_FORMACION"
        Me.DataGridViewTextBoxID_AREA_FORMACION.HeaderText = "Id area formacion"
        Me.DataGridViewTextBoxID_AREA_FORMACION.Name = "DataGridViewTextBoxID_AREA_FORMACION"
        '
        'DataGridViewTextBoxAREA_FORMACION
        '
        Me.DataGridViewTextBoxAREA_FORMACION.DataPropertyName = "AREA_FORMACION"
        Me.DataGridViewTextBoxAREA_FORMACION.HeaderText = "Area formacion"
        Me.DataGridViewTextBoxAREA_FORMACION.Name = "DataGridViewTextBoxAREA_FORMACION"
        '
        'DataGridViewTextBoxNOTAS
        '
        Me.DataGridViewTextBoxNOTAS.DataPropertyName = "NOTAS"
        Me.DataGridViewTextBoxNOTAS.HeaderText = "Notas"
        Me.DataGridViewTextBoxNOTAS.Name = "DataGridViewTextBoxNOTAS"
        '
        'ucListaAREA_FORMACION
        '
        Me.Controls.Add(Me.ListaAREA_FORMACIONDataGridView)
        Me.Name = "ucListaAREA_FORMACION"
        Me.Size = New System.Drawing.Size(529, 354)
        Me.Controls.SetChildIndex(Me.ListaAREA_FORMACIONDataGridView, 0)
        CType(Me.ListaAREA_FORMACIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaAREA_FORMACIONDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaAREA_FORMACIONBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListaAREA_FORMACIONDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxID_AREA_FORMACION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxAREA_FORMACION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxNOTAS As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
