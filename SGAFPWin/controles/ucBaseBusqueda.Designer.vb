<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucBaseBusqueda
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
        Me.ToolStripBusqueda = New System.Windows.Forms.ToolStrip
        Me.AgregarToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.BuscarToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.UcListViewCriterios1 = New SGAFP.ucListViewCriterios
        Me.CriteriaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingSourceCriterios = New System.Windows.Forms.BindingSource(Me.components)
        Me.ColumnBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StringBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DateTimeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OtherBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QueryOperatorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStripBusqueda.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.CriteriaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSourceCriterios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColumnBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StringBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateTimeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OtherBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QueryOperatorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStripBusqueda
        '
        Me.ToolStripBusqueda.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarToolStripButton, Me.BuscarToolStripButton})
        Me.ToolStripBusqueda.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripBusqueda.Name = "ToolStripBusqueda"
        Me.ToolStripBusqueda.Size = New System.Drawing.Size(469, 25)
        Me.ToolStripBusqueda.TabIndex = 0
        Me.ToolStripBusqueda.Text = "ToolStrip1"
        '
        'AgregarToolStripButton
        '
        Me.AgregarToolStripButton.Image = Global.SGAFP.My.Resources.Resources.add
        Me.AgregarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AgregarToolStripButton.Name = "AgregarToolStripButton"
        Me.AgregarToolStripButton.Size = New System.Drawing.Size(66, 22)
        Me.AgregarToolStripButton.Text = "Agregar"
        Me.AgregarToolStripButton.ToolTipText = "Agregar Criterio"
        '
        'BuscarToolStripButton
        '
        Me.BuscarToolStripButton.Image = Global.SGAFP.My.Resources.Resources.view
        Me.BuscarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BuscarToolStripButton.Name = "BuscarToolStripButton"
        Me.BuscarToolStripButton.Size = New System.Drawing.Size(59, 22)
        Me.BuscarToolStripButton.Text = "Buscar"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 25)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.UcListViewCriterios1)
        Me.SplitContainer1.Size = New System.Drawing.Size(469, 312)
        Me.SplitContainer1.SplitterDistance = 160
        Me.SplitContainer1.TabIndex = 1
        '
        'UcListViewCriterios1
        '
        Me.UcListViewCriterios1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcListViewCriterios1.Location = New System.Drawing.Point(3, 3)
        Me.UcListViewCriterios1.Name = "UcListViewCriterios1"
        Me.UcListViewCriterios1.Size = New System.Drawing.Size(463, 154)
        Me.UcListViewCriterios1.TabIndex = 3
        '
        'CriteriaBindingSource
        '
        Me.CriteriaBindingSource.DataSource = GetType(SGAFP.EL.Criteria)
        '
        'BindingSourceCriterios
        '
        '
        'ucBaseBusqueda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ToolStripBusqueda)
        Me.Name = "ucBaseBusqueda"
        Me.Size = New System.Drawing.Size(469, 337)
        Me.ToolStripBusqueda.ResumeLayout(False)
        Me.ToolStripBusqueda.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.CriteriaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSourceCriterios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColumnBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StringBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateTimeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OtherBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QueryOperatorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStripBusqueda As System.Windows.Forms.ToolStrip
    Friend WithEvents AgregarToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents BuscarToolStripButton As System.Windows.Forms.ToolStripButton
    Public WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents BindingSourceCriterios As System.Windows.Forms.BindingSource
    Friend WithEvents ColumnBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StringBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DateTimeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OtherBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents QueryOperatorBindingSource As System.Windows.Forms.BindingSource

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.BindingSourceCriterios.DataSource = Me.CriteriaList
    End Sub
    Friend WithEvents CriteriaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UcListViewCriterios1 As SGAFP.ucListViewCriterios
End Class
