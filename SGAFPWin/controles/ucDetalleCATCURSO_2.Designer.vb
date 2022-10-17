<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucDetalleCATCURSO_2
    Inherits SGAFP.ucBaseDetalleMant

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
        Dim ID_CURSOLabel As System.Windows.Forms.Label
        Dim NOMBRELabel As System.Windows.Forms.Label
        Dim DURACIONLabel As System.Windows.Forms.Label
        Me.ListaCATCURSO_2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ID_CURSOTextBox = New System.Windows.Forms.TextBox
        Me.NOMBRETextBox = New System.Windows.Forms.TextBox
        Me.DURACIONTextBox = New System.Windows.Forms.TextBox
        ID_CURSOLabel = New System.Windows.Forms.Label
        NOMBRELabel = New System.Windows.Forms.Label
        DURACIONLabel = New System.Windows.Forms.Label
        CType(Me.ListaCATCURSO_2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ID_CURSOLabel
        '
        ID_CURSOLabel.Location = New System.Drawing.Point(6, 14)
        ID_CURSOLabel.Name = "ID_CURSOLabel"
        ID_CURSOLabel.Size = New System.Drawing.Size(135, 13)
        ID_CURSOLabel.TabIndex = 0
        ID_CURSOLabel.Text = "Id curso:"
        '
        'NOMBRELabel
        '
        NOMBRELabel.Location = New System.Drawing.Point(6, 40)
        NOMBRELabel.Name = "NOMBRELabel"
        NOMBRELabel.Size = New System.Drawing.Size(135, 13)
        NOMBRELabel.TabIndex = 2
        NOMBRELabel.Text = "Nombre:"
        '
        'DURACIONLabel
        '
        DURACIONLabel.Location = New System.Drawing.Point(6, 66)
        DURACIONLabel.Name = "DURACIONLabel"
        DURACIONLabel.Size = New System.Drawing.Size(135, 13)
        DURACIONLabel.TabIndex = 4
        DURACIONLabel.Text = "Duracion:"
        '
        'ListaCATCURSO_2BindingSource
        '
        Me.ListaCATCURSO_2BindingSource.DataSource = GetType(SGAFP.EL.CATCURSO_2)
        '
        'ID_CURSOTextBox
        '
        Me.ID_CURSOTextBox.BackColor = System.Drawing.Color.Linen
        Me.ID_CURSOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaCATCURSO_2BindingSource, "ID_CURSO", True))
        Me.ID_CURSOTextBox.Location = New System.Drawing.Point(144, 8)
        Me.ID_CURSOTextBox.Name = "ID_CURSOTextBox"
        Me.ID_CURSOTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ID_CURSOTextBox.TabIndex = 1
        Me.ID_CURSOTextBox.ReadOnly = True
        '
        'NOMBRETextBox
        '
        Me.NOMBRETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaCATCURSO_2BindingSource, "NOMBRE", True))
        Me.NOMBRETextBox.Location = New System.Drawing.Point(144, 34)
        Me.NOMBRETextBox.Name = "NOMBRETextBox"
        Me.NOMBRETextBox.Size = New System.Drawing.Size(200, 20)
        Me.NOMBRETextBox.TabIndex = 3
        Me.NOMBRETextBox.MaxLength = 139
        '
        'DURACIONTextBox
        '
        Me.DURACIONTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaCATCURSO_2BindingSource, "DURACION", True))
        Me.DURACIONTextBox.Location = New System.Drawing.Point(144, 60)
        Me.DURACIONTextBox.Name = "DURACIONTextBox"
        Me.DURACIONTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DURACIONTextBox.TabIndex = 5
        '
        'ucDetalleCATCURSO_2
        '
        Me.AutoScroll = True
        Me.Controls.Add(ID_CURSOLabel)
        Me.Controls.Add(Me.ID_CURSOTextBox)
        Me.Controls.Add(NOMBRELabel)
        Me.Controls.Add(Me.NOMBRETextBox)
        Me.Controls.Add(DURACIONLabel)
        Me.Controls.Add(Me.DURACIONTextBox)
        Me.Name = "ucDetalleCATCURSO_2"
        Me.Size = New System.Drawing.Size(382, 112)
        CType(Me.ListaCATCURSO_2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaCATCURSO_2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ID_CURSOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NOMBRETextBox As System.Windows.Forms.TextBox
    Friend WithEvents DURACIONTextBox As System.Windows.Forms.TextBox

End Class
