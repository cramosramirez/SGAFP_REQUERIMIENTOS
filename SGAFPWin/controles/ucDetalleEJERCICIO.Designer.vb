<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucDetalleEJERCICIO
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
        Dim ID_EJERCICIOLabel As System.Windows.Forms.Label
        Dim ETIQUETALabel As System.Windows.Forms.Label
        Dim FECHA_INICIOLabel As System.Windows.Forms.Label
        Dim FECHA_FINLabel As System.Windows.Forms.Label
        Dim NOTASLabel As System.Windows.Forms.Label
        Me.ListaEJERCICIOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ID_EJERCICIOTextBox = New System.Windows.Forms.TextBox
        Me.ETIQUETATextBox = New System.Windows.Forms.TextBox
        Me.FECHA_INICIODateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.FECHA_FINDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.NOTASTextBox = New System.Windows.Forms.TextBox
        ID_EJERCICIOLabel = New System.Windows.Forms.Label
        ETIQUETALabel = New System.Windows.Forms.Label
        FECHA_INICIOLabel = New System.Windows.Forms.Label
        FECHA_FINLabel = New System.Windows.Forms.Label
        NOTASLabel = New System.Windows.Forms.Label
        CType(Me.ListaEJERCICIOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ID_EJERCICIOLabel
        '
        ID_EJERCICIOLabel.Location = New System.Drawing.Point(6, 14)
        ID_EJERCICIOLabel.Name = "ID_EJERCICIOLabel"
        ID_EJERCICIOLabel.Size = New System.Drawing.Size(135, 13)
        ID_EJERCICIOLabel.TabIndex = 0
        ID_EJERCICIOLabel.Text = "Id ejercicio:"
        '
        'ETIQUETALabel
        '
        ETIQUETALabel.Location = New System.Drawing.Point(6, 40)
        ETIQUETALabel.Name = "ETIQUETALabel"
        ETIQUETALabel.Size = New System.Drawing.Size(135, 13)
        ETIQUETALabel.TabIndex = 2
        ETIQUETALabel.Text = "Etiqueta:"
        '
        'FECHA_INICIOLabel
        '
        FECHA_INICIOLabel.Location = New System.Drawing.Point(6, 66)
        FECHA_INICIOLabel.Name = "FECHA_INICIOLabel"
        FECHA_INICIOLabel.Size = New System.Drawing.Size(135, 13)
        FECHA_INICIOLabel.TabIndex = 4
        FECHA_INICIOLabel.Text = "Fecha inicio:"
        '
        'FECHA_FINLabel
        '
        FECHA_FINLabel.Location = New System.Drawing.Point(6, 92)
        FECHA_FINLabel.Name = "FECHA_FINLabel"
        FECHA_FINLabel.Size = New System.Drawing.Size(135, 13)
        FECHA_FINLabel.TabIndex = 6
        FECHA_FINLabel.Text = "Fecha fin:"
        '
        'NOTASLabel
        '
        NOTASLabel.Location = New System.Drawing.Point(6, 118)
        NOTASLabel.Name = "NOTASLabel"
        NOTASLabel.Size = New System.Drawing.Size(135, 13)
        NOTASLabel.TabIndex = 8
        NOTASLabel.Text = "Notas:"
        '
        'ListaEJERCICIOBindingSource
        '
        Me.ListaEJERCICIOBindingSource.DataSource = GetType(SGAFP.EL.EJERCICIO)
        '
        'ID_EJERCICIOTextBox
        '
        Me.ID_EJERCICIOTextBox.BackColor = System.Drawing.Color.Linen
        Me.ID_EJERCICIOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaEJERCICIOBindingSource, "ID_EJERCICIO", True))
        Me.ID_EJERCICIOTextBox.Location = New System.Drawing.Point(144, 8)
        Me.ID_EJERCICIOTextBox.Name = "ID_EJERCICIOTextBox"
        Me.ID_EJERCICIOTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ID_EJERCICIOTextBox.TabIndex = 1
        Me.ID_EJERCICIOTextBox.ReadOnly = True
        Me.ID_EJERCICIOTextBox.MaxLength = 4
        '
        'ETIQUETATextBox
        '
        Me.ETIQUETATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaEJERCICIOBindingSource, "ETIQUETA", True))
        Me.ETIQUETATextBox.Location = New System.Drawing.Point(144, 34)
        Me.ETIQUETATextBox.Name = "ETIQUETATextBox"
        Me.ETIQUETATextBox.Size = New System.Drawing.Size(200, 20)
        Me.ETIQUETATextBox.TabIndex = 3
        Me.ETIQUETATextBox.MaxLength = 20
        '
        'FECHA_INICIODateTimePicker
        '
        Me.FECHA_INICIODateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ListaEJERCICIOBindingSource, "FECHA_INICIO", True))
        Me.FECHA_INICIODateTimePicker.Location = New System.Drawing.Point(144, 60)
        Me.FECHA_INICIODateTimePicker.Name = "FECHA_INICIODateTimePicker"
        Me.FECHA_INICIODateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.FECHA_INICIODateTimePicker.TabIndex = 5
        '
        'FECHA_FINDateTimePicker
        '
        Me.FECHA_FINDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ListaEJERCICIOBindingSource, "FECHA_FIN", True))
        Me.FECHA_FINDateTimePicker.Location = New System.Drawing.Point(144, 86)
        Me.FECHA_FINDateTimePicker.Name = "FECHA_FINDateTimePicker"
        Me.FECHA_FINDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.FECHA_FINDateTimePicker.TabIndex = 7
        '
        'NOTASTextBox
        '
        Me.NOTASTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaEJERCICIOBindingSource, "NOTAS", True))
        Me.NOTASTextBox.Location = New System.Drawing.Point(144, 112)
        Me.NOTASTextBox.Name = "NOTASTextBox"
        Me.NOTASTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NOTASTextBox.TabIndex = 9
        Me.NOTASTextBox.MaxLength = 255
        '
        'ucDetalleEJERCICIO
        '
        Me.AutoScroll = True
        Me.Controls.Add(ID_EJERCICIOLabel)
        Me.Controls.Add(Me.ID_EJERCICIOTextBox)
        Me.Controls.Add(ETIQUETALabel)
        Me.Controls.Add(Me.ETIQUETATextBox)
        Me.Controls.Add(FECHA_INICIOLabel)
        Me.Controls.Add(Me.FECHA_INICIODateTimePicker)
        Me.Controls.Add(FECHA_FINLabel)
        Me.Controls.Add(Me.FECHA_FINDateTimePicker)
        Me.Controls.Add(NOTASLabel)
        Me.Controls.Add(Me.NOTASTextBox)
        Me.Name = "ucDetalleEJERCICIO"
        Me.Size = New System.Drawing.Size(382, 164)
        CType(Me.ListaEJERCICIOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaEJERCICIOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ID_EJERCICIOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ETIQUETATextBox As System.Windows.Forms.TextBox
    Friend WithEvents FECHA_INICIODateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents FECHA_FINDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents NOTASTextBox As System.Windows.Forms.TextBox

End Class
