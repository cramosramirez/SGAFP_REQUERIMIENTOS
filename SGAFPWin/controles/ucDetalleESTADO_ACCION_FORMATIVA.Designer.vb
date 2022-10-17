<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucDetalleESTADO_ACCION_FORMATIVA
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
        Dim CODIGO_ESTADO_AFLabel As System.Windows.Forms.Label
        Dim NOMBRE_ESTADO_AFLabel As System.Windows.Forms.Label
        Dim ESTADO_INICIALLabel As System.Windows.Forms.Label
        Dim PERMITE_INSCRIPCIONLabel As System.Windows.Forms.Label
        Dim ESTADO_FINALLabel As System.Windows.Forms.Label
        Dim NOTASLabel As System.Windows.Forms.Label
        Me.ListaESTADO_ACCION_FORMATIVABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CODIGO_ESTADO_AFTextBox = New System.Windows.Forms.TextBox
        Me.NOMBRE_ESTADO_AFTextBox = New System.Windows.Forms.TextBox
        Me.ESTADO_INICIALTextBox = New System.Windows.Forms.TextBox
        Me.PERMITE_INSCRIPCIONTextBox = New System.Windows.Forms.TextBox
        Me.ESTADO_FINALTextBox = New System.Windows.Forms.TextBox
        Me.NOTASTextBox = New System.Windows.Forms.TextBox
        CODIGO_ESTADO_AFLabel = New System.Windows.Forms.Label
        NOMBRE_ESTADO_AFLabel = New System.Windows.Forms.Label
        ESTADO_INICIALLabel = New System.Windows.Forms.Label
        PERMITE_INSCRIPCIONLabel = New System.Windows.Forms.Label
        ESTADO_FINALLabel = New System.Windows.Forms.Label
        NOTASLabel = New System.Windows.Forms.Label
        CType(Me.ListaESTADO_ACCION_FORMATIVABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CODIGO_ESTADO_AFLabel
        '
        CODIGO_ESTADO_AFLabel.Location = New System.Drawing.Point(6, 14)
        CODIGO_ESTADO_AFLabel.Name = "CODIGO_ESTADO_AFLabel"
        CODIGO_ESTADO_AFLabel.Size = New System.Drawing.Size(135, 13)
        CODIGO_ESTADO_AFLabel.TabIndex = 0
        CODIGO_ESTADO_AFLabel.Text = "Codigo estado af:"
        '
        'NOMBRE_ESTADO_AFLabel
        '
        NOMBRE_ESTADO_AFLabel.Location = New System.Drawing.Point(6, 40)
        NOMBRE_ESTADO_AFLabel.Name = "NOMBRE_ESTADO_AFLabel"
        NOMBRE_ESTADO_AFLabel.Size = New System.Drawing.Size(135, 13)
        NOMBRE_ESTADO_AFLabel.TabIndex = 2
        NOMBRE_ESTADO_AFLabel.Text = "Nombre estado af:"
        '
        'ESTADO_INICIALLabel
        '
        ESTADO_INICIALLabel.Location = New System.Drawing.Point(6, 66)
        ESTADO_INICIALLabel.Name = "ESTADO_INICIALLabel"
        ESTADO_INICIALLabel.Size = New System.Drawing.Size(135, 13)
        ESTADO_INICIALLabel.TabIndex = 4
        ESTADO_INICIALLabel.Text = "Estado inicial:"
        '
        'PERMITE_INSCRIPCIONLabel
        '
        PERMITE_INSCRIPCIONLabel.Location = New System.Drawing.Point(6, 92)
        PERMITE_INSCRIPCIONLabel.Name = "PERMITE_INSCRIPCIONLabel"
        PERMITE_INSCRIPCIONLabel.Size = New System.Drawing.Size(135, 13)
        PERMITE_INSCRIPCIONLabel.TabIndex = 6
        PERMITE_INSCRIPCIONLabel.Text = "Permite inscripcion:"
        '
        'ESTADO_FINALLabel
        '
        ESTADO_FINALLabel.Location = New System.Drawing.Point(6, 118)
        ESTADO_FINALLabel.Name = "ESTADO_FINALLabel"
        ESTADO_FINALLabel.Size = New System.Drawing.Size(135, 13)
        ESTADO_FINALLabel.TabIndex = 8
        ESTADO_FINALLabel.Text = "Estado final:"
        '
        'NOTASLabel
        '
        NOTASLabel.Location = New System.Drawing.Point(6, 144)
        NOTASLabel.Name = "NOTASLabel"
        NOTASLabel.Size = New System.Drawing.Size(135, 13)
        NOTASLabel.TabIndex = 10
        NOTASLabel.Text = "Notas:"
        '
        'ListaESTADO_ACCION_FORMATIVABindingSource
        '
        Me.ListaESTADO_ACCION_FORMATIVABindingSource.DataSource = GetType(SGAFP.EL.ESTADO_ACCION_FORMATIVA)
        '
        'CODIGO_ESTADO_AFTextBox
        '
        Me.CODIGO_ESTADO_AFTextBox.BackColor = System.Drawing.Color.Linen
        Me.CODIGO_ESTADO_AFTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaESTADO_ACCION_FORMATIVABindingSource, "CODIGO_ESTADO_AF", True))
        Me.CODIGO_ESTADO_AFTextBox.Location = New System.Drawing.Point(144, 8)
        Me.CODIGO_ESTADO_AFTextBox.Name = "CODIGO_ESTADO_AFTextBox"
        Me.CODIGO_ESTADO_AFTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CODIGO_ESTADO_AFTextBox.TabIndex = 1
        Me.CODIGO_ESTADO_AFTextBox.ReadOnly = True
        Me.CODIGO_ESTADO_AFTextBox.MaxLength = 2
        '
        'NOMBRE_ESTADO_AFTextBox
        '
        Me.NOMBRE_ESTADO_AFTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaESTADO_ACCION_FORMATIVABindingSource, "NOMBRE_ESTADO_AF", True))
        Me.NOMBRE_ESTADO_AFTextBox.Location = New System.Drawing.Point(144, 34)
        Me.NOMBRE_ESTADO_AFTextBox.Name = "NOMBRE_ESTADO_AFTextBox"
        Me.NOMBRE_ESTADO_AFTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NOMBRE_ESTADO_AFTextBox.TabIndex = 3
        Me.NOMBRE_ESTADO_AFTextBox.MaxLength = 40
        '
        'ESTADO_INICIALTextBox
        '
        Me.ESTADO_INICIALTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaESTADO_ACCION_FORMATIVABindingSource, "ESTADO_INICIAL", True))
        Me.ESTADO_INICIALTextBox.Location = New System.Drawing.Point(144, 60)
        Me.ESTADO_INICIALTextBox.Name = "ESTADO_INICIALTextBox"
        Me.ESTADO_INICIALTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ESTADO_INICIALTextBox.TabIndex = 5
        '
        'PERMITE_INSCRIPCIONTextBox
        '
        Me.PERMITE_INSCRIPCIONTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaESTADO_ACCION_FORMATIVABindingSource, "PERMITE_INSCRIPCION", True))
        Me.PERMITE_INSCRIPCIONTextBox.Location = New System.Drawing.Point(144, 86)
        Me.PERMITE_INSCRIPCIONTextBox.Name = "PERMITE_INSCRIPCIONTextBox"
        Me.PERMITE_INSCRIPCIONTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PERMITE_INSCRIPCIONTextBox.TabIndex = 7
        '
        'ESTADO_FINALTextBox
        '
        Me.ESTADO_FINALTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaESTADO_ACCION_FORMATIVABindingSource, "ESTADO_FINAL", True))
        Me.ESTADO_FINALTextBox.Location = New System.Drawing.Point(144, 112)
        Me.ESTADO_FINALTextBox.Name = "ESTADO_FINALTextBox"
        Me.ESTADO_FINALTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ESTADO_FINALTextBox.TabIndex = 9
        '
        'NOTASTextBox
        '
        Me.NOTASTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaESTADO_ACCION_FORMATIVABindingSource, "NOTAS", True))
        Me.NOTASTextBox.Location = New System.Drawing.Point(144, 138)
        Me.NOTASTextBox.Name = "NOTASTextBox"
        Me.NOTASTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NOTASTextBox.TabIndex = 11
        Me.NOTASTextBox.MaxLength = 255
        '
        'ucDetalleESTADO_ACCION_FORMATIVA
        '
        Me.AutoScroll = True
        Me.Controls.Add(CODIGO_ESTADO_AFLabel)
        Me.Controls.Add(Me.CODIGO_ESTADO_AFTextBox)
        Me.Controls.Add(NOMBRE_ESTADO_AFLabel)
        Me.Controls.Add(Me.NOMBRE_ESTADO_AFTextBox)
        Me.Controls.Add(ESTADO_INICIALLabel)
        Me.Controls.Add(Me.ESTADO_INICIALTextBox)
        Me.Controls.Add(PERMITE_INSCRIPCIONLabel)
        Me.Controls.Add(Me.PERMITE_INSCRIPCIONTextBox)
        Me.Controls.Add(ESTADO_FINALLabel)
        Me.Controls.Add(Me.ESTADO_FINALTextBox)
        Me.Controls.Add(NOTASLabel)
        Me.Controls.Add(Me.NOTASTextBox)
        Me.Name = "ucDetalleESTADO_ACCION_FORMATIVA"
        Me.Size = New System.Drawing.Size(382, 190)
        CType(Me.ListaESTADO_ACCION_FORMATIVABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaESTADO_ACCION_FORMATIVABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CODIGO_ESTADO_AFTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NOMBRE_ESTADO_AFTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ESTADO_INICIALTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PERMITE_INSCRIPCIONTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ESTADO_FINALTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NOTASTextBox As System.Windows.Forms.TextBox

End Class
