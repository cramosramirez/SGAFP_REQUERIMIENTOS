<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucListaEJERCICIO
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
        Me.ListaEJERCICIOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListaEJERCICIODataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxID_EJERCICIO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxETIQUETA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxFECHA_INICIO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxFECHA_FIN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxNOTAS = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.ListaEJERCICIOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaEJERCICIODataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListaEJERCICIOBindingSource
        '
        Me.ListaEJERCICIOBindingSource.DataSource = GetType(SGAFP.EL.EJERCICIO)
        '
        'ListaEJERCICIODataGridView
        '
        Me.ListaEJERCICIODataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListaEJERCICIODataGridView.AutoGenerateColumns = False
        Me.ListaEJERCICIODataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxID_EJERCICIO, Me.DataGridViewTextBoxETIQUETA, Me.DataGridViewTextBoxFECHA_INICIO, Me.DataGridViewTextBoxFECHA_FIN, Me.DataGridViewTextBoxNOTAS})
        Me.ListaEJERCICIODataGridView.DataSource = Me.ListaEJERCICIOBindingSource
        Me.ListaEJERCICIODataGridView.Location = New System.Drawing.Point(3, 28)
        Me.ListaEJERCICIODataGridView.Name = "ListaEJERCICIODataGridView"
        Me.ListaEJERCICIODataGridView.Size = New System.Drawing.Size(523, 323)
        Me.ListaEJERCICIODataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxID_EJERCICIO
        '
        Me.DataGridViewTextBoxID_EJERCICIO.DataPropertyName = "ID_EJERCICIO"
        Me.DataGridViewTextBoxID_EJERCICIO.HeaderText = "Id ejercicio"
        Me.DataGridViewTextBoxID_EJERCICIO.Name = "DataGridViewTextBoxID_EJERCICIO"
        '
        'DataGridViewTextBoxETIQUETA
        '
        Me.DataGridViewTextBoxETIQUETA.DataPropertyName = "ETIQUETA"
        Me.DataGridViewTextBoxETIQUETA.HeaderText = "Etiqueta"
        Me.DataGridViewTextBoxETIQUETA.Name = "DataGridViewTextBoxETIQUETA"
        '
        'DataGridViewTextBoxFECHA_INICIO
        '
        Me.DataGridViewTextBoxFECHA_INICIO.DataPropertyName = "FECHA_INICIO"
        Me.DataGridViewTextBoxFECHA_INICIO.HeaderText = "Fecha inicio"
        Me.DataGridViewTextBoxFECHA_INICIO.Name = "DataGridViewTextBoxFECHA_INICIO"
        '
        'DataGridViewTextBoxFECHA_FIN
        '
        Me.DataGridViewTextBoxFECHA_FIN.DataPropertyName = "FECHA_FIN"
        Me.DataGridViewTextBoxFECHA_FIN.HeaderText = "Fecha fin"
        Me.DataGridViewTextBoxFECHA_FIN.Name = "DataGridViewTextBoxFECHA_FIN"
        '
        'DataGridViewTextBoxNOTAS
        '
        Me.DataGridViewTextBoxNOTAS.DataPropertyName = "NOTAS"
        Me.DataGridViewTextBoxNOTAS.HeaderText = "Notas"
        Me.DataGridViewTextBoxNOTAS.Name = "DataGridViewTextBoxNOTAS"
        '
        'ucListaEJERCICIO
        '
        Me.Controls.Add(Me.ListaEJERCICIODataGridView)
        Me.Name = "ucListaEJERCICIO"
        Me.Size = New System.Drawing.Size(529, 354)
        Me.Controls.SetChildIndex(Me.ListaEJERCICIODataGridView, 0)
        CType(Me.ListaEJERCICIOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaEJERCICIODataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaEJERCICIOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListaEJERCICIODataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxID_EJERCICIO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxETIQUETA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxFECHA_INICIO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxFECHA_FIN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxNOTAS As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
