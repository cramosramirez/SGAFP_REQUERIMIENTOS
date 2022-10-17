<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucDetalleASISTENCIA_AF_DET
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
        Dim ID_ASISTENCIA_DETLabel As System.Windows.Forms.Label
        Dim ID_ASISTENCIA_AFLabel As System.Windows.Forms.Label
        Dim ID_PARTICIPANTELabel As System.Windows.Forms.Label
        Dim ASISTIOLabel As System.Windows.Forms.Label
        Dim PRESENTA_JUSTIFICACIONLabel As System.Windows.Forms.Label
        Dim JUSTIFICACIONLabel As System.Windows.Forms.Label
        Me.ListaASISTENCIA_AF_DETBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ID_ASISTENCIA_DETTextBox = New System.Windows.Forms.TextBox
        Me.ID_ASISTENCIA_AFcbxASISTENCIA_AF = New SGAFP.WinUC.cbxASISTENCIA_AF
        Me.ID_PARTICIPANTEcbxPARTICIPANTE = New SGAFP.WinUC.cbxPARTICIPANTE
        Me.ASISTIOTextBox = New System.Windows.Forms.TextBox
        Me.PRESENTA_JUSTIFICACIONTextBox = New System.Windows.Forms.TextBox
        Me.JUSTIFICACIONTextBox = New System.Windows.Forms.TextBox
        ID_ASISTENCIA_DETLabel = New System.Windows.Forms.Label
        ID_ASISTENCIA_AFLabel = New System.Windows.Forms.Label
        ID_PARTICIPANTELabel = New System.Windows.Forms.Label
        ASISTIOLabel = New System.Windows.Forms.Label
        PRESENTA_JUSTIFICACIONLabel = New System.Windows.Forms.Label
        JUSTIFICACIONLabel = New System.Windows.Forms.Label
        CType(Me.ListaASISTENCIA_AF_DETBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ID_ASISTENCIA_DETLabel
        '
        ID_ASISTENCIA_DETLabel.Location = New System.Drawing.Point(6, 14)
        ID_ASISTENCIA_DETLabel.Name = "ID_ASISTENCIA_DETLabel"
        ID_ASISTENCIA_DETLabel.Size = New System.Drawing.Size(135, 13)
        ID_ASISTENCIA_DETLabel.TabIndex = 0
        ID_ASISTENCIA_DETLabel.Text = "Id asistencia det:"
        '
        'ID_ASISTENCIA_AFLabel
        '
        ID_ASISTENCIA_AFLabel.Location = New System.Drawing.Point(6, 40)
        ID_ASISTENCIA_AFLabel.Name = "ID_ASISTENCIA_AFLabel"
        ID_ASISTENCIA_AFLabel.Size = New System.Drawing.Size(135, 13)
        ID_ASISTENCIA_AFLabel.TabIndex = 2
        ID_ASISTENCIA_AFLabel.Text = "Id asistencia af:"
        '
        'ID_PARTICIPANTELabel
        '
        ID_PARTICIPANTELabel.Location = New System.Drawing.Point(6, 66)
        ID_PARTICIPANTELabel.Name = "ID_PARTICIPANTELabel"
        ID_PARTICIPANTELabel.Size = New System.Drawing.Size(135, 13)
        ID_PARTICIPANTELabel.TabIndex = 4
        ID_PARTICIPANTELabel.Text = "Id participante:"
        '
        'ASISTIOLabel
        '
        ASISTIOLabel.Location = New System.Drawing.Point(6, 92)
        ASISTIOLabel.Name = "ASISTIOLabel"
        ASISTIOLabel.Size = New System.Drawing.Size(135, 13)
        ASISTIOLabel.TabIndex = 6
        ASISTIOLabel.Text = "Asistio:"
        '
        'PRESENTA_JUSTIFICACIONLabel
        '
        PRESENTA_JUSTIFICACIONLabel.Location = New System.Drawing.Point(6, 118)
        PRESENTA_JUSTIFICACIONLabel.Name = "PRESENTA_JUSTIFICACIONLabel"
        PRESENTA_JUSTIFICACIONLabel.Size = New System.Drawing.Size(135, 13)
        PRESENTA_JUSTIFICACIONLabel.TabIndex = 8
        PRESENTA_JUSTIFICACIONLabel.Text = "Presenta justificacion:"
        '
        'JUSTIFICACIONLabel
        '
        JUSTIFICACIONLabel.Location = New System.Drawing.Point(6, 144)
        JUSTIFICACIONLabel.Name = "JUSTIFICACIONLabel"
        JUSTIFICACIONLabel.Size = New System.Drawing.Size(135, 13)
        JUSTIFICACIONLabel.TabIndex = 10
        JUSTIFICACIONLabel.Text = "Justificacion:"
        '
        'ListaASISTENCIA_AF_DETBindingSource
        '
        Me.ListaASISTENCIA_AF_DETBindingSource.DataSource = GetType(SGAFP.EL.ASISTENCIA_AF_DET)
        '
        'ID_ASISTENCIA_DETTextBox
        '
        Me.ID_ASISTENCIA_DETTextBox.BackColor = System.Drawing.Color.Linen
        Me.ID_ASISTENCIA_DETTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaASISTENCIA_AF_DETBindingSource, "ID_ASISTENCIA_DET", True))
        Me.ID_ASISTENCIA_DETTextBox.Location = New System.Drawing.Point(144, 8)
        Me.ID_ASISTENCIA_DETTextBox.Name = "ID_ASISTENCIA_DETTextBox"
        Me.ID_ASISTENCIA_DETTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ID_ASISTENCIA_DETTextBox.TabIndex = 1
        Me.ID_ASISTENCIA_DETTextBox.ReadOnly = True
        '
        'ID_ASISTENCIA_AFcbxASISTENCIA_AF
        '
        Me.ID_ASISTENCIA_AFcbxASISTENCIA_AF.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ListaASISTENCIA_AF_DETBindingSource, "ID_ASISTENCIA_AF", True))
        Me.ID_ASISTENCIA_AFcbxASISTENCIA_AF.Location = New System.Drawing.Point(144, 34)
        Me.ID_ASISTENCIA_AFcbxASISTENCIA_AF.Name = "ID_ASISTENCIA_AFcbxASISTENCIA_AF"
        Me.ID_ASISTENCIA_AFcbxASISTENCIA_AF.Size = New System.Drawing.Size(200, 20)
        Me.ID_ASISTENCIA_AFcbxASISTENCIA_AF.TabIndex = 3
        '
        'ID_PARTICIPANTEcbxPARTICIPANTE
        '
        Me.ID_PARTICIPANTEcbxPARTICIPANTE.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ListaASISTENCIA_AF_DETBindingSource, "ID_PARTICIPANTE", True))
        Me.ID_PARTICIPANTEcbxPARTICIPANTE.Location = New System.Drawing.Point(144, 60)
        Me.ID_PARTICIPANTEcbxPARTICIPANTE.Name = "ID_PARTICIPANTEcbxPARTICIPANTE"
        Me.ID_PARTICIPANTEcbxPARTICIPANTE.Size = New System.Drawing.Size(200, 20)
        Me.ID_PARTICIPANTEcbxPARTICIPANTE.TabIndex = 5
        '
        'ASISTIOTextBox
        '
        Me.ASISTIOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaASISTENCIA_AF_DETBindingSource, "ASISTIO", True))
        Me.ASISTIOTextBox.Location = New System.Drawing.Point(144, 86)
        Me.ASISTIOTextBox.Name = "ASISTIOTextBox"
        Me.ASISTIOTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ASISTIOTextBox.TabIndex = 7
        Me.ASISTIOTextBox.MaxLength = 1
        '
        'PRESENTA_JUSTIFICACIONTextBox
        '
        Me.PRESENTA_JUSTIFICACIONTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaASISTENCIA_AF_DETBindingSource, "PRESENTA_JUSTIFICACION", True))
        Me.PRESENTA_JUSTIFICACIONTextBox.Location = New System.Drawing.Point(144, 112)
        Me.PRESENTA_JUSTIFICACIONTextBox.Name = "PRESENTA_JUSTIFICACIONTextBox"
        Me.PRESENTA_JUSTIFICACIONTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PRESENTA_JUSTIFICACIONTextBox.TabIndex = 9
        Me.PRESENTA_JUSTIFICACIONTextBox.MaxLength = 1
        '
        'JUSTIFICACIONTextBox
        '
        Me.JUSTIFICACIONTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaASISTENCIA_AF_DETBindingSource, "JUSTIFICACION", True))
        Me.JUSTIFICACIONTextBox.Location = New System.Drawing.Point(144, 138)
        Me.JUSTIFICACIONTextBox.Name = "JUSTIFICACIONTextBox"
        Me.JUSTIFICACIONTextBox.Size = New System.Drawing.Size(200, 20)
        Me.JUSTIFICACIONTextBox.TabIndex = 11
        Me.JUSTIFICACIONTextBox.MaxLength = 80
        '
        'ucDetalleASISTENCIA_AF_DET
        '
        Me.AutoScroll = True
        Me.Controls.Add(ID_ASISTENCIA_DETLabel)
        Me.Controls.Add(Me.ID_ASISTENCIA_DETTextBox)
        Me.Controls.Add(ID_ASISTENCIA_AFLabel)
        Me.Controls.Add(Me.ID_ASISTENCIA_AFcbxASISTENCIA_AF)
        Me.Controls.Add(ID_PARTICIPANTELabel)
        Me.Controls.Add(Me.ID_PARTICIPANTEcbxPARTICIPANTE)
        Me.Controls.Add(ASISTIOLabel)
        Me.Controls.Add(Me.ASISTIOTextBox)
        Me.Controls.Add(PRESENTA_JUSTIFICACIONLabel)
        Me.Controls.Add(Me.PRESENTA_JUSTIFICACIONTextBox)
        Me.Controls.Add(JUSTIFICACIONLabel)
        Me.Controls.Add(Me.JUSTIFICACIONTextBox)
        Me.Name = "ucDetalleASISTENCIA_AF_DET"
        Me.Size = New System.Drawing.Size(382, 190)
        CType(Me.ListaASISTENCIA_AF_DETBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaASISTENCIA_AF_DETBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ID_ASISTENCIA_DETTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ID_ASISTENCIA_AFcbxASISTENCIA_AF As SGAFP.WinUC.cbxASISTENCIA_AF
    Friend WithEvents ID_PARTICIPANTEcbxPARTICIPANTE As SGAFP.WinUC.cbxPARTICIPANTE
    Friend WithEvents ASISTIOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PRESENTA_JUSTIFICACIONTextBox As System.Windows.Forms.TextBox
    Friend WithEvents JUSTIFICACIONTextBox As System.Windows.Forms.TextBox

End Class
