<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucDetalleSUPERVISION_AF_DET
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
        Dim ID_SUPERVISION_DETLabel As System.Windows.Forms.Label
        Dim ID_LISTA_SUPERVISIONLabel As System.Windows.Forms.Label
        Dim ID_SUPERVISION_AFLabel As System.Windows.Forms.Label
        Dim COMENTARIOSLabel As System.Windows.Forms.Label
        Me.ListaSUPERVISION_AF_DETBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ID_SUPERVISION_DETTextBox = New System.Windows.Forms.TextBox
        Me.ID_LISTA_SUPERVISIONcbxLISTA_SUPERVISION_AF = New SGAFP.WinUC.cbxLISTA_SUPERVISION_AF
        Me.ID_SUPERVISION_AFcbxSUPERVISION_AF = New SGAFP.WinUC.cbxSUPERVISION_AF
        Me.COMENTARIOSTextBox = New System.Windows.Forms.TextBox
        ID_SUPERVISION_DETLabel = New System.Windows.Forms.Label
        ID_LISTA_SUPERVISIONLabel = New System.Windows.Forms.Label
        ID_SUPERVISION_AFLabel = New System.Windows.Forms.Label
        COMENTARIOSLabel = New System.Windows.Forms.Label
        CType(Me.ListaSUPERVISION_AF_DETBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ID_SUPERVISION_DETLabel
        '
        ID_SUPERVISION_DETLabel.Location = New System.Drawing.Point(6, 14)
        ID_SUPERVISION_DETLabel.Name = "ID_SUPERVISION_DETLabel"
        ID_SUPERVISION_DETLabel.Size = New System.Drawing.Size(135, 13)
        ID_SUPERVISION_DETLabel.TabIndex = 0
        ID_SUPERVISION_DETLabel.Text = "Id supervision det:"
        '
        'ID_LISTA_SUPERVISIONLabel
        '
        ID_LISTA_SUPERVISIONLabel.Location = New System.Drawing.Point(6, 40)
        ID_LISTA_SUPERVISIONLabel.Name = "ID_LISTA_SUPERVISIONLabel"
        ID_LISTA_SUPERVISIONLabel.Size = New System.Drawing.Size(135, 13)
        ID_LISTA_SUPERVISIONLabel.TabIndex = 2
        ID_LISTA_SUPERVISIONLabel.Text = "Id lista supervision:"
        '
        'ID_SUPERVISION_AFLabel
        '
        ID_SUPERVISION_AFLabel.Location = New System.Drawing.Point(6, 66)
        ID_SUPERVISION_AFLabel.Name = "ID_SUPERVISION_AFLabel"
        ID_SUPERVISION_AFLabel.Size = New System.Drawing.Size(135, 13)
        ID_SUPERVISION_AFLabel.TabIndex = 4
        ID_SUPERVISION_AFLabel.Text = "Id supervision af:"
        '
        'COMENTARIOSLabel
        '
        COMENTARIOSLabel.Location = New System.Drawing.Point(6, 92)
        COMENTARIOSLabel.Name = "COMENTARIOSLabel"
        COMENTARIOSLabel.Size = New System.Drawing.Size(135, 13)
        COMENTARIOSLabel.TabIndex = 6
        COMENTARIOSLabel.Text = "Comentarios:"
        '
        'ListaSUPERVISION_AF_DETBindingSource
        '
        Me.ListaSUPERVISION_AF_DETBindingSource.DataSource = GetType(SGAFP.EL.SUPERVISION_AF_DET)
        '
        'ID_SUPERVISION_DETTextBox
        '
        Me.ID_SUPERVISION_DETTextBox.BackColor = System.Drawing.Color.Linen
        Me.ID_SUPERVISION_DETTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaSUPERVISION_AF_DETBindingSource, "ID_SUPERVISION_DET", True))
        Me.ID_SUPERVISION_DETTextBox.Location = New System.Drawing.Point(144, 8)
        Me.ID_SUPERVISION_DETTextBox.Name = "ID_SUPERVISION_DETTextBox"
        Me.ID_SUPERVISION_DETTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ID_SUPERVISION_DETTextBox.TabIndex = 1
        Me.ID_SUPERVISION_DETTextBox.ReadOnly = True
        '
        'ID_LISTA_SUPERVISIONcbxLISTA_SUPERVISION_AF
        '
        Me.ID_LISTA_SUPERVISIONcbxLISTA_SUPERVISION_AF.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ListaSUPERVISION_AF_DETBindingSource, "ID_LISTA_SUPERVISION", True))
        Me.ID_LISTA_SUPERVISIONcbxLISTA_SUPERVISION_AF.Location = New System.Drawing.Point(144, 34)
        Me.ID_LISTA_SUPERVISIONcbxLISTA_SUPERVISION_AF.Name = "ID_LISTA_SUPERVISIONcbxLISTA_SUPERVISION_AF"
        Me.ID_LISTA_SUPERVISIONcbxLISTA_SUPERVISION_AF.Size = New System.Drawing.Size(200, 20)
        Me.ID_LISTA_SUPERVISIONcbxLISTA_SUPERVISION_AF.TabIndex = 3
        '
        'ID_SUPERVISION_AFcbxSUPERVISION_AF
        '
        Me.ID_SUPERVISION_AFcbxSUPERVISION_AF.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ListaSUPERVISION_AF_DETBindingSource, "ID_SUPERVISION_AF", True))
        Me.ID_SUPERVISION_AFcbxSUPERVISION_AF.Location = New System.Drawing.Point(144, 60)
        Me.ID_SUPERVISION_AFcbxSUPERVISION_AF.Name = "ID_SUPERVISION_AFcbxSUPERVISION_AF"
        Me.ID_SUPERVISION_AFcbxSUPERVISION_AF.Size = New System.Drawing.Size(200, 20)
        Me.ID_SUPERVISION_AFcbxSUPERVISION_AF.TabIndex = 5
        '
        'COMENTARIOSTextBox
        '
        Me.COMENTARIOSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaSUPERVISION_AF_DETBindingSource, "COMENTARIOS", True))
        Me.COMENTARIOSTextBox.Location = New System.Drawing.Point(144, 86)
        Me.COMENTARIOSTextBox.Name = "COMENTARIOSTextBox"
        Me.COMENTARIOSTextBox.Size = New System.Drawing.Size(200, 20)
        Me.COMENTARIOSTextBox.TabIndex = 7
        Me.COMENTARIOSTextBox.MaxLength = 200
        '
        'ucDetalleSUPERVISION_AF_DET
        '
        Me.AutoScroll = True
        Me.Controls.Add(ID_SUPERVISION_DETLabel)
        Me.Controls.Add(Me.ID_SUPERVISION_DETTextBox)
        Me.Controls.Add(ID_LISTA_SUPERVISIONLabel)
        Me.Controls.Add(Me.ID_LISTA_SUPERVISIONcbxLISTA_SUPERVISION_AF)
        Me.Controls.Add(ID_SUPERVISION_AFLabel)
        Me.Controls.Add(Me.ID_SUPERVISION_AFcbxSUPERVISION_AF)
        Me.Controls.Add(COMENTARIOSLabel)
        Me.Controls.Add(Me.COMENTARIOSTextBox)
        Me.Name = "ucDetalleSUPERVISION_AF_DET"
        Me.Size = New System.Drawing.Size(382, 138)
        CType(Me.ListaSUPERVISION_AF_DETBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaSUPERVISION_AF_DETBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ID_SUPERVISION_DETTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ID_LISTA_SUPERVISIONcbxLISTA_SUPERVISION_AF As SGAFP.WinUC.cbxLISTA_SUPERVISION_AF
    Friend WithEvents ID_SUPERVISION_AFcbxSUPERVISION_AF As SGAFP.WinUC.cbxSUPERVISION_AF
    Friend WithEvents COMENTARIOSTextBox As System.Windows.Forms.TextBox

End Class
