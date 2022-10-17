<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucDetalleHALLAZGO_SUPERVISION
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
        Dim ID_HALLAZGO_SUPERVISIONLabel As System.Windows.Forms.Label
        Dim ID_AREA_SUPERVISIONLabel As System.Windows.Forms.Label
        Dim ID_SUPERVISION_AFLabel As System.Windows.Forms.Label
        Dim HALLAZGO_SUPERVISIONLabel As System.Windows.Forms.Label
        Dim FECHALabel As System.Windows.Forms.Label
        Dim TIPO_SANCIONLabel As System.Windows.Forms.Label
        Dim TIEMPO_SANCIONLabel As System.Windows.Forms.Label
        Dim MONTO_SANCIONLabel As System.Windows.Forms.Label
        Dim TIEMPO_SUBSANACIONLabel As System.Windows.Forms.Label
        Me.ListaHALLAZGO_SUPERVISIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ID_HALLAZGO_SUPERVISIONTextBox = New System.Windows.Forms.TextBox
        Me.ID_AREA_SUPERVISIONcbxAREA_SUPERVISION = New SGAFP.WinUC.cbxAREA_SUPERVISION
        Me.ID_SUPERVISION_AFcbxSUPERVISION_AF = New SGAFP.WinUC.cbxSUPERVISION_AF
        Me.HALLAZGO_SUPERVISIONTextBox = New System.Windows.Forms.TextBox
        Me.FECHADateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.TIPO_SANCIONTextBox = New System.Windows.Forms.TextBox
        Me.TIEMPO_SANCIONTextBox = New System.Windows.Forms.TextBox
        Me.MONTO_SANCIONTextBox = New System.Windows.Forms.TextBox
        Me.TIEMPO_SUBSANACIONTextBox = New System.Windows.Forms.TextBox
        ID_HALLAZGO_SUPERVISIONLabel = New System.Windows.Forms.Label
        ID_AREA_SUPERVISIONLabel = New System.Windows.Forms.Label
        ID_SUPERVISION_AFLabel = New System.Windows.Forms.Label
        HALLAZGO_SUPERVISIONLabel = New System.Windows.Forms.Label
        FECHALabel = New System.Windows.Forms.Label
        TIPO_SANCIONLabel = New System.Windows.Forms.Label
        TIEMPO_SANCIONLabel = New System.Windows.Forms.Label
        MONTO_SANCIONLabel = New System.Windows.Forms.Label
        TIEMPO_SUBSANACIONLabel = New System.Windows.Forms.Label
        CType(Me.ListaHALLAZGO_SUPERVISIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ID_HALLAZGO_SUPERVISIONLabel
        '
        ID_HALLAZGO_SUPERVISIONLabel.Location = New System.Drawing.Point(6, 14)
        ID_HALLAZGO_SUPERVISIONLabel.Name = "ID_HALLAZGO_SUPERVISIONLabel"
        ID_HALLAZGO_SUPERVISIONLabel.Size = New System.Drawing.Size(135, 13)
        ID_HALLAZGO_SUPERVISIONLabel.TabIndex = 0
        ID_HALLAZGO_SUPERVISIONLabel.Text = "Id hallazgo supervision:"
        '
        'ID_AREA_SUPERVISIONLabel
        '
        ID_AREA_SUPERVISIONLabel.Location = New System.Drawing.Point(6, 40)
        ID_AREA_SUPERVISIONLabel.Name = "ID_AREA_SUPERVISIONLabel"
        ID_AREA_SUPERVISIONLabel.Size = New System.Drawing.Size(135, 13)
        ID_AREA_SUPERVISIONLabel.TabIndex = 2
        ID_AREA_SUPERVISIONLabel.Text = "Id area supervision:"
        '
        'ID_SUPERVISION_AFLabel
        '
        ID_SUPERVISION_AFLabel.Location = New System.Drawing.Point(6, 66)
        ID_SUPERVISION_AFLabel.Name = "ID_SUPERVISION_AFLabel"
        ID_SUPERVISION_AFLabel.Size = New System.Drawing.Size(135, 13)
        ID_SUPERVISION_AFLabel.TabIndex = 4
        ID_SUPERVISION_AFLabel.Text = "Id supervision af:"
        '
        'HALLAZGO_SUPERVISIONLabel
        '
        HALLAZGO_SUPERVISIONLabel.Location = New System.Drawing.Point(6, 92)
        HALLAZGO_SUPERVISIONLabel.Name = "HALLAZGO_SUPERVISIONLabel"
        HALLAZGO_SUPERVISIONLabel.Size = New System.Drawing.Size(135, 13)
        HALLAZGO_SUPERVISIONLabel.TabIndex = 6
        HALLAZGO_SUPERVISIONLabel.Text = "Hallazgo supervision:"
        '
        'FECHALabel
        '
        FECHALabel.Location = New System.Drawing.Point(6, 118)
        FECHALabel.Name = "FECHALabel"
        FECHALabel.Size = New System.Drawing.Size(135, 13)
        FECHALabel.TabIndex = 8
        FECHALabel.Text = "Fecha:"
        '
        'TIPO_SANCIONLabel
        '
        TIPO_SANCIONLabel.Location = New System.Drawing.Point(6, 144)
        TIPO_SANCIONLabel.Name = "TIPO_SANCIONLabel"
        TIPO_SANCIONLabel.Size = New System.Drawing.Size(135, 13)
        TIPO_SANCIONLabel.TabIndex = 10
        TIPO_SANCIONLabel.Text = "Tipo sancion:"
        '
        'TIEMPO_SANCIONLabel
        '
        TIEMPO_SANCIONLabel.Location = New System.Drawing.Point(6, 170)
        TIEMPO_SANCIONLabel.Name = "TIEMPO_SANCIONLabel"
        TIEMPO_SANCIONLabel.Size = New System.Drawing.Size(135, 13)
        TIEMPO_SANCIONLabel.TabIndex = 12
        TIEMPO_SANCIONLabel.Text = "Tiempo sancion:"
        '
        'MONTO_SANCIONLabel
        '
        MONTO_SANCIONLabel.Location = New System.Drawing.Point(6, 196)
        MONTO_SANCIONLabel.Name = "MONTO_SANCIONLabel"
        MONTO_SANCIONLabel.Size = New System.Drawing.Size(135, 13)
        MONTO_SANCIONLabel.TabIndex = 14
        MONTO_SANCIONLabel.Text = "Monto sancion:"
        '
        'TIEMPO_SUBSANACIONLabel
        '
        TIEMPO_SUBSANACIONLabel.Location = New System.Drawing.Point(6, 222)
        TIEMPO_SUBSANACIONLabel.Name = "TIEMPO_SUBSANACIONLabel"
        TIEMPO_SUBSANACIONLabel.Size = New System.Drawing.Size(135, 13)
        TIEMPO_SUBSANACIONLabel.TabIndex = 16
        TIEMPO_SUBSANACIONLabel.Text = "Tiempo subsanacion:"
        '
        'ListaHALLAZGO_SUPERVISIONBindingSource
        '
        Me.ListaHALLAZGO_SUPERVISIONBindingSource.DataSource = GetType(SGAFP.EL.HALLAZGO_SUPERVISION)
        '
        'ID_HALLAZGO_SUPERVISIONTextBox
        '
        Me.ID_HALLAZGO_SUPERVISIONTextBox.BackColor = System.Drawing.Color.Linen
        Me.ID_HALLAZGO_SUPERVISIONTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaHALLAZGO_SUPERVISIONBindingSource, "ID_HALLAZGO_SUPERVISION", True))
        Me.ID_HALLAZGO_SUPERVISIONTextBox.Location = New System.Drawing.Point(144, 8)
        Me.ID_HALLAZGO_SUPERVISIONTextBox.Name = "ID_HALLAZGO_SUPERVISIONTextBox"
        Me.ID_HALLAZGO_SUPERVISIONTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ID_HALLAZGO_SUPERVISIONTextBox.TabIndex = 1
        Me.ID_HALLAZGO_SUPERVISIONTextBox.ReadOnly = True
        '
        'ID_AREA_SUPERVISIONcbxAREA_SUPERVISION
        '
        Me.ID_AREA_SUPERVISIONcbxAREA_SUPERVISION.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ListaHALLAZGO_SUPERVISIONBindingSource, "ID_AREA_SUPERVISION", True))
        Me.ID_AREA_SUPERVISIONcbxAREA_SUPERVISION.Location = New System.Drawing.Point(144, 34)
        Me.ID_AREA_SUPERVISIONcbxAREA_SUPERVISION.Name = "ID_AREA_SUPERVISIONcbxAREA_SUPERVISION"
        Me.ID_AREA_SUPERVISIONcbxAREA_SUPERVISION.Size = New System.Drawing.Size(200, 20)
        Me.ID_AREA_SUPERVISIONcbxAREA_SUPERVISION.TabIndex = 3
        '
        'ID_SUPERVISION_AFcbxSUPERVISION_AF
        '
        Me.ID_SUPERVISION_AFcbxSUPERVISION_AF.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ListaHALLAZGO_SUPERVISIONBindingSource, "ID_SUPERVISION_AF", True))
        Me.ID_SUPERVISION_AFcbxSUPERVISION_AF.Location = New System.Drawing.Point(144, 60)
        Me.ID_SUPERVISION_AFcbxSUPERVISION_AF.Name = "ID_SUPERVISION_AFcbxSUPERVISION_AF"
        Me.ID_SUPERVISION_AFcbxSUPERVISION_AF.Size = New System.Drawing.Size(200, 20)
        Me.ID_SUPERVISION_AFcbxSUPERVISION_AF.TabIndex = 5
        '
        'HALLAZGO_SUPERVISIONTextBox
        '
        Me.HALLAZGO_SUPERVISIONTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaHALLAZGO_SUPERVISIONBindingSource, "HALLAZGO_SUPERVISION", True))
        Me.HALLAZGO_SUPERVISIONTextBox.Location = New System.Drawing.Point(144, 86)
        Me.HALLAZGO_SUPERVISIONTextBox.Name = "HALLAZGO_SUPERVISIONTextBox"
        Me.HALLAZGO_SUPERVISIONTextBox.Size = New System.Drawing.Size(200, 20)
        Me.HALLAZGO_SUPERVISIONTextBox.TabIndex = 7
        Me.HALLAZGO_SUPERVISIONTextBox.MaxLength = 255
        '
        'FECHADateTimePicker
        '
        Me.FECHADateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ListaHALLAZGO_SUPERVISIONBindingSource, "FECHA", True))
        Me.FECHADateTimePicker.Location = New System.Drawing.Point(144, 112)
        Me.FECHADateTimePicker.Name = "FECHADateTimePicker"
        Me.FECHADateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.FECHADateTimePicker.TabIndex = 9
        '
        'TIPO_SANCIONTextBox
        '
        Me.TIPO_SANCIONTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaHALLAZGO_SUPERVISIONBindingSource, "TIPO_SANCION", True))
        Me.TIPO_SANCIONTextBox.Location = New System.Drawing.Point(144, 138)
        Me.TIPO_SANCIONTextBox.Name = "TIPO_SANCIONTextBox"
        Me.TIPO_SANCIONTextBox.Size = New System.Drawing.Size(200, 20)
        Me.TIPO_SANCIONTextBox.TabIndex = 11
        Me.TIPO_SANCIONTextBox.MaxLength = 1
        '
        'TIEMPO_SANCIONTextBox
        '
        Me.TIEMPO_SANCIONTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaHALLAZGO_SUPERVISIONBindingSource, "TIEMPO_SANCION", True))
        Me.TIEMPO_SANCIONTextBox.Location = New System.Drawing.Point(144, 164)
        Me.TIEMPO_SANCIONTextBox.Name = "TIEMPO_SANCIONTextBox"
        Me.TIEMPO_SANCIONTextBox.Size = New System.Drawing.Size(200, 20)
        Me.TIEMPO_SANCIONTextBox.TabIndex = 13
        '
        'MONTO_SANCIONTextBox
        '
        Me.MONTO_SANCIONTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaHALLAZGO_SUPERVISIONBindingSource, "MONTO_SANCION", True))
        Me.MONTO_SANCIONTextBox.Location = New System.Drawing.Point(144, 190)
        Me.MONTO_SANCIONTextBox.Name = "MONTO_SANCIONTextBox"
        Me.MONTO_SANCIONTextBox.Size = New System.Drawing.Size(200, 20)
        Me.MONTO_SANCIONTextBox.TabIndex = 15
        '
        'TIEMPO_SUBSANACIONTextBox
        '
        Me.TIEMPO_SUBSANACIONTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaHALLAZGO_SUPERVISIONBindingSource, "TIEMPO_SUBSANACION", True))
        Me.TIEMPO_SUBSANACIONTextBox.Location = New System.Drawing.Point(144, 216)
        Me.TIEMPO_SUBSANACIONTextBox.Name = "TIEMPO_SUBSANACIONTextBox"
        Me.TIEMPO_SUBSANACIONTextBox.Size = New System.Drawing.Size(200, 20)
        Me.TIEMPO_SUBSANACIONTextBox.TabIndex = 17
        '
        'ucDetalleHALLAZGO_SUPERVISION
        '
        Me.AutoScroll = True
        Me.Controls.Add(ID_HALLAZGO_SUPERVISIONLabel)
        Me.Controls.Add(Me.ID_HALLAZGO_SUPERVISIONTextBox)
        Me.Controls.Add(ID_AREA_SUPERVISIONLabel)
        Me.Controls.Add(Me.ID_AREA_SUPERVISIONcbxAREA_SUPERVISION)
        Me.Controls.Add(ID_SUPERVISION_AFLabel)
        Me.Controls.Add(Me.ID_SUPERVISION_AFcbxSUPERVISION_AF)
        Me.Controls.Add(HALLAZGO_SUPERVISIONLabel)
        Me.Controls.Add(Me.HALLAZGO_SUPERVISIONTextBox)
        Me.Controls.Add(FECHALabel)
        Me.Controls.Add(Me.FECHADateTimePicker)
        Me.Controls.Add(TIPO_SANCIONLabel)
        Me.Controls.Add(Me.TIPO_SANCIONTextBox)
        Me.Controls.Add(TIEMPO_SANCIONLabel)
        Me.Controls.Add(Me.TIEMPO_SANCIONTextBox)
        Me.Controls.Add(MONTO_SANCIONLabel)
        Me.Controls.Add(Me.MONTO_SANCIONTextBox)
        Me.Controls.Add(TIEMPO_SUBSANACIONLabel)
        Me.Controls.Add(Me.TIEMPO_SUBSANACIONTextBox)
        Me.Name = "ucDetalleHALLAZGO_SUPERVISION"
        Me.Size = New System.Drawing.Size(382, 268)
        CType(Me.ListaHALLAZGO_SUPERVISIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaHALLAZGO_SUPERVISIONBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ID_HALLAZGO_SUPERVISIONTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ID_AREA_SUPERVISIONcbxAREA_SUPERVISION As SGAFP.WinUC.cbxAREA_SUPERVISION
    Friend WithEvents ID_SUPERVISION_AFcbxSUPERVISION_AF As SGAFP.WinUC.cbxSUPERVISION_AF
    Friend WithEvents HALLAZGO_SUPERVISIONTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FECHADateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents TIPO_SANCIONTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TIEMPO_SANCIONTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MONTO_SANCIONTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TIEMPO_SUBSANACIONTextBox As System.Windows.Forms.TextBox

End Class
