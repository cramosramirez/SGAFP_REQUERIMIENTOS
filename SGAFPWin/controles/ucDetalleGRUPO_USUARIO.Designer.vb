<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucDetalleGRUPO_USUARIO
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
        Dim ID_GRUPO_USUARIOLabel As System.Windows.Forms.Label
        Dim ROL_USUARIOLabel As System.Windows.Forms.Label
        Dim NIVELLabel As System.Windows.Forms.Label
        Dim NOTASLabel As System.Windows.Forms.Label
        Me.ListaGRUPO_USUARIOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ID_GRUPO_USUARIOTextBox = New System.Windows.Forms.TextBox
        Me.ROL_USUARIOTextBox = New System.Windows.Forms.TextBox
        Me.NIVELTextBox = New System.Windows.Forms.TextBox
        Me.NOTASTextBox = New System.Windows.Forms.TextBox
        ID_GRUPO_USUARIOLabel = New System.Windows.Forms.Label
        ROL_USUARIOLabel = New System.Windows.Forms.Label
        NIVELLabel = New System.Windows.Forms.Label
        NOTASLabel = New System.Windows.Forms.Label
        CType(Me.ListaGRUPO_USUARIOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ID_GRUPO_USUARIOLabel
        '
        ID_GRUPO_USUARIOLabel.Location = New System.Drawing.Point(6, 14)
        ID_GRUPO_USUARIOLabel.Name = "ID_GRUPO_USUARIOLabel"
        ID_GRUPO_USUARIOLabel.Size = New System.Drawing.Size(135, 13)
        ID_GRUPO_USUARIOLabel.TabIndex = 0
        ID_GRUPO_USUARIOLabel.Text = "Id grupo usuario:"
        '
        'ROL_USUARIOLabel
        '
        ROL_USUARIOLabel.Location = New System.Drawing.Point(6, 40)
        ROL_USUARIOLabel.Name = "ROL_USUARIOLabel"
        ROL_USUARIOLabel.Size = New System.Drawing.Size(135, 13)
        ROL_USUARIOLabel.TabIndex = 2
        ROL_USUARIOLabel.Text = "Rol usuario:"
        '
        'NIVELLabel
        '
        NIVELLabel.Location = New System.Drawing.Point(6, 66)
        NIVELLabel.Name = "NIVELLabel"
        NIVELLabel.Size = New System.Drawing.Size(135, 13)
        NIVELLabel.TabIndex = 4
        NIVELLabel.Text = "Nivel:"
        '
        'NOTASLabel
        '
        NOTASLabel.Location = New System.Drawing.Point(6, 92)
        NOTASLabel.Name = "NOTASLabel"
        NOTASLabel.Size = New System.Drawing.Size(135, 13)
        NOTASLabel.TabIndex = 6
        NOTASLabel.Text = "Notas:"
        '
        'ListaGRUPO_USUARIOBindingSource
        '
        Me.ListaGRUPO_USUARIOBindingSource.DataSource = GetType(SGAFP.EL.GRUPO_USUARIO)
        '
        'ID_GRUPO_USUARIOTextBox
        '
        Me.ID_GRUPO_USUARIOTextBox.BackColor = System.Drawing.Color.Linen
        Me.ID_GRUPO_USUARIOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaGRUPO_USUARIOBindingSource, "ID_GRUPO_USUARIO", True))
        Me.ID_GRUPO_USUARIOTextBox.Location = New System.Drawing.Point(144, 8)
        Me.ID_GRUPO_USUARIOTextBox.Name = "ID_GRUPO_USUARIOTextBox"
        Me.ID_GRUPO_USUARIOTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ID_GRUPO_USUARIOTextBox.TabIndex = 1
        Me.ID_GRUPO_USUARIOTextBox.ReadOnly = True
        '
        'ROL_USUARIOTextBox
        '
        Me.ROL_USUARIOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaGRUPO_USUARIOBindingSource, "ROL_USUARIO", True))
        Me.ROL_USUARIOTextBox.Location = New System.Drawing.Point(144, 34)
        Me.ROL_USUARIOTextBox.Name = "ROL_USUARIOTextBox"
        Me.ROL_USUARIOTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ROL_USUARIOTextBox.TabIndex = 3
        Me.ROL_USUARIOTextBox.MaxLength = 40
        '
        'NIVELTextBox
        '
        Me.NIVELTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaGRUPO_USUARIOBindingSource, "NIVEL", True))
        Me.NIVELTextBox.Location = New System.Drawing.Point(144, 60)
        Me.NIVELTextBox.Name = "NIVELTextBox"
        Me.NIVELTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NIVELTextBox.TabIndex = 5
        '
        'NOTASTextBox
        '
        Me.NOTASTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaGRUPO_USUARIOBindingSource, "NOTAS", True))
        Me.NOTASTextBox.Location = New System.Drawing.Point(144, 86)
        Me.NOTASTextBox.Name = "NOTASTextBox"
        Me.NOTASTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NOTASTextBox.TabIndex = 7
        Me.NOTASTextBox.MaxLength = 255
        '
        'ucDetalleGRUPO_USUARIO
        '
        Me.AutoScroll = True
        Me.Controls.Add(ID_GRUPO_USUARIOLabel)
        Me.Controls.Add(Me.ID_GRUPO_USUARIOTextBox)
        Me.Controls.Add(ROL_USUARIOLabel)
        Me.Controls.Add(Me.ROL_USUARIOTextBox)
        Me.Controls.Add(NIVELLabel)
        Me.Controls.Add(Me.NIVELTextBox)
        Me.Controls.Add(NOTASLabel)
        Me.Controls.Add(Me.NOTASTextBox)
        Me.Name = "ucDetalleGRUPO_USUARIO"
        Me.Size = New System.Drawing.Size(382, 138)
        CType(Me.ListaGRUPO_USUARIOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaGRUPO_USUARIOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ID_GRUPO_USUARIOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ROL_USUARIOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NIVELTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NOTASTextBox As System.Windows.Forms.TextBox

End Class
