<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucDetalleOPCION_GRUPO
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
        Dim ID_OPCION_GRUPOLabel As System.Windows.Forms.Label
        Dim ID_OPCION_MENULabel As System.Windows.Forms.Label
        Dim ID_GRUPO_USUARIOLabel As System.Windows.Forms.Label
        Dim FECHA_INGRESOLabel As System.Windows.Forms.Label
        Dim ESTADOLabel As System.Windows.Forms.Label
        Dim USERIDLabel As System.Windows.Forms.Label
        Dim LASTUPDATELabel As System.Windows.Forms.Label
        Me.ListaOPCION_GRUPOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ID_OPCION_GRUPOTextBox = New System.Windows.Forms.TextBox
        Me.ID_OPCION_MENUcbxOPCION_MENU = New SGAFP.WinUC.cbxOPCION_MENU
        Me.ID_GRUPO_USUARIOcbxGRUPO_USUARIO = New SGAFP.WinUC.cbxGRUPO_USUARIO
        Me.FECHA_INGRESODateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.ESTADOTextBox = New System.Windows.Forms.TextBox
        Me.USERIDTextBox = New System.Windows.Forms.TextBox
        Me.LASTUPDATEDateTimePicker = New System.Windows.Forms.DateTimePicker
        ID_OPCION_GRUPOLabel = New System.Windows.Forms.Label
        ID_OPCION_MENULabel = New System.Windows.Forms.Label
        ID_GRUPO_USUARIOLabel = New System.Windows.Forms.Label
        FECHA_INGRESOLabel = New System.Windows.Forms.Label
        ESTADOLabel = New System.Windows.Forms.Label
        USERIDLabel = New System.Windows.Forms.Label
        LASTUPDATELabel = New System.Windows.Forms.Label
        CType(Me.ListaOPCION_GRUPOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ID_OPCION_GRUPOLabel
        '
        ID_OPCION_GRUPOLabel.Location = New System.Drawing.Point(6, 14)
        ID_OPCION_GRUPOLabel.Name = "ID_OPCION_GRUPOLabel"
        ID_OPCION_GRUPOLabel.Size = New System.Drawing.Size(135, 13)
        ID_OPCION_GRUPOLabel.TabIndex = 0
        ID_OPCION_GRUPOLabel.Text = "Id opcion grupo:"
        '
        'ID_OPCION_MENULabel
        '
        ID_OPCION_MENULabel.Location = New System.Drawing.Point(6, 40)
        ID_OPCION_MENULabel.Name = "ID_OPCION_MENULabel"
        ID_OPCION_MENULabel.Size = New System.Drawing.Size(135, 13)
        ID_OPCION_MENULabel.TabIndex = 2
        ID_OPCION_MENULabel.Text = "Id opcion menu:"
        '
        'ID_GRUPO_USUARIOLabel
        '
        ID_GRUPO_USUARIOLabel.Location = New System.Drawing.Point(6, 66)
        ID_GRUPO_USUARIOLabel.Name = "ID_GRUPO_USUARIOLabel"
        ID_GRUPO_USUARIOLabel.Size = New System.Drawing.Size(135, 13)
        ID_GRUPO_USUARIOLabel.TabIndex = 4
        ID_GRUPO_USUARIOLabel.Text = "Id grupo usuario:"
        '
        'FECHA_INGRESOLabel
        '
        FECHA_INGRESOLabel.Location = New System.Drawing.Point(6, 92)
        FECHA_INGRESOLabel.Name = "FECHA_INGRESOLabel"
        FECHA_INGRESOLabel.Size = New System.Drawing.Size(135, 13)
        FECHA_INGRESOLabel.TabIndex = 6
        FECHA_INGRESOLabel.Text = "Fecha ingreso:"
        '
        'ESTADOLabel
        '
        ESTADOLabel.Location = New System.Drawing.Point(6, 118)
        ESTADOLabel.Name = "ESTADOLabel"
        ESTADOLabel.Size = New System.Drawing.Size(135, 13)
        ESTADOLabel.TabIndex = 8
        ESTADOLabel.Text = "Estado:"
        '
        'USERIDLabel
        '
        USERIDLabel.Location = New System.Drawing.Point(6, 144)
        USERIDLabel.Name = "USERIDLabel"
        USERIDLabel.Size = New System.Drawing.Size(135, 13)
        USERIDLabel.TabIndex = 10
        USERIDLabel.Text = "Userid:"
        '
        'LASTUPDATELabel
        '
        LASTUPDATELabel.Location = New System.Drawing.Point(6, 170)
        LASTUPDATELabel.Name = "LASTUPDATELabel"
        LASTUPDATELabel.Size = New System.Drawing.Size(135, 13)
        LASTUPDATELabel.TabIndex = 12
        LASTUPDATELabel.Text = "Lastupdate:"
        '
        'ListaOPCION_GRUPOBindingSource
        '
        Me.ListaOPCION_GRUPOBindingSource.DataSource = GetType(SGAFP.EL.OPCION_GRUPO)
        '
        'ID_OPCION_GRUPOTextBox
        '
        Me.ID_OPCION_GRUPOTextBox.BackColor = System.Drawing.Color.Linen
        Me.ID_OPCION_GRUPOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaOPCION_GRUPOBindingSource, "ID_OPCION_GRUPO", True))
        Me.ID_OPCION_GRUPOTextBox.Location = New System.Drawing.Point(144, 8)
        Me.ID_OPCION_GRUPOTextBox.Name = "ID_OPCION_GRUPOTextBox"
        Me.ID_OPCION_GRUPOTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ID_OPCION_GRUPOTextBox.TabIndex = 1
        Me.ID_OPCION_GRUPOTextBox.ReadOnly = True
        '
        'ID_OPCION_MENUcbxOPCION_MENU
        '
        Me.ID_OPCION_MENUcbxOPCION_MENU.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ListaOPCION_GRUPOBindingSource, "ID_OPCION_MENU", True))
        Me.ID_OPCION_MENUcbxOPCION_MENU.Location = New System.Drawing.Point(144, 34)
        Me.ID_OPCION_MENUcbxOPCION_MENU.Name = "ID_OPCION_MENUcbxOPCION_MENU"
        Me.ID_OPCION_MENUcbxOPCION_MENU.Size = New System.Drawing.Size(200, 20)
        Me.ID_OPCION_MENUcbxOPCION_MENU.TabIndex = 3
        '
        'ID_GRUPO_USUARIOcbxGRUPO_USUARIO
        '
        Me.ID_GRUPO_USUARIOcbxGRUPO_USUARIO.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ListaOPCION_GRUPOBindingSource, "ID_GRUPO_USUARIO", True))
        Me.ID_GRUPO_USUARIOcbxGRUPO_USUARIO.Location = New System.Drawing.Point(144, 60)
        Me.ID_GRUPO_USUARIOcbxGRUPO_USUARIO.Name = "ID_GRUPO_USUARIOcbxGRUPO_USUARIO"
        Me.ID_GRUPO_USUARIOcbxGRUPO_USUARIO.Size = New System.Drawing.Size(200, 20)
        Me.ID_GRUPO_USUARIOcbxGRUPO_USUARIO.TabIndex = 5
        '
        'FECHA_INGRESODateTimePicker
        '
        Me.FECHA_INGRESODateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ListaOPCION_GRUPOBindingSource, "FECHA_INGRESO", True))
        Me.FECHA_INGRESODateTimePicker.Location = New System.Drawing.Point(144, 86)
        Me.FECHA_INGRESODateTimePicker.Name = "FECHA_INGRESODateTimePicker"
        Me.FECHA_INGRESODateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.FECHA_INGRESODateTimePicker.TabIndex = 7
        '
        'ESTADOTextBox
        '
        Me.ESTADOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaOPCION_GRUPOBindingSource, "ESTADO", True))
        Me.ESTADOTextBox.Location = New System.Drawing.Point(144, 112)
        Me.ESTADOTextBox.Name = "ESTADOTextBox"
        Me.ESTADOTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ESTADOTextBox.TabIndex = 9
        Me.ESTADOTextBox.MaxLength = 1
        '
        'USERIDTextBox
        '
        Me.USERIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaOPCION_GRUPOBindingSource, "USERID", True))
        Me.USERIDTextBox.Location = New System.Drawing.Point(144, 138)
        Me.USERIDTextBox.Name = "USERIDTextBox"
        Me.USERIDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.USERIDTextBox.TabIndex = 11
        Me.USERIDTextBox.MaxLength = 16
        '
        'LASTUPDATEDateTimePicker
        '
        Me.LASTUPDATEDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ListaOPCION_GRUPOBindingSource, "LASTUPDATE", True))
        Me.LASTUPDATEDateTimePicker.Location = New System.Drawing.Point(144, 164)
        Me.LASTUPDATEDateTimePicker.Name = "LASTUPDATEDateTimePicker"
        Me.LASTUPDATEDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.LASTUPDATEDateTimePicker.TabIndex = 13
        '
        'ucDetalleOPCION_GRUPO
        '
        Me.AutoScroll = True
        Me.Controls.Add(ID_OPCION_GRUPOLabel)
        Me.Controls.Add(Me.ID_OPCION_GRUPOTextBox)
        Me.Controls.Add(ID_OPCION_MENULabel)
        Me.Controls.Add(Me.ID_OPCION_MENUcbxOPCION_MENU)
        Me.Controls.Add(ID_GRUPO_USUARIOLabel)
        Me.Controls.Add(Me.ID_GRUPO_USUARIOcbxGRUPO_USUARIO)
        Me.Controls.Add(FECHA_INGRESOLabel)
        Me.Controls.Add(Me.FECHA_INGRESODateTimePicker)
        Me.Controls.Add(ESTADOLabel)
        Me.Controls.Add(Me.ESTADOTextBox)
        Me.Controls.Add(USERIDLabel)
        Me.Controls.Add(Me.USERIDTextBox)
        Me.Controls.Add(LASTUPDATELabel)
        Me.Controls.Add(Me.LASTUPDATEDateTimePicker)
        Me.Name = "ucDetalleOPCION_GRUPO"
        Me.Size = New System.Drawing.Size(382, 216)
        CType(Me.ListaOPCION_GRUPOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaOPCION_GRUPOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ID_OPCION_GRUPOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ID_OPCION_MENUcbxOPCION_MENU As SGAFP.WinUC.cbxOPCION_MENU
    Friend WithEvents ID_GRUPO_USUARIOcbxGRUPO_USUARIO As SGAFP.WinUC.cbxGRUPO_USUARIO
    Friend WithEvents FECHA_INGRESODateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ESTADOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents USERIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LASTUPDATEDateTimePicker As System.Windows.Forms.DateTimePicker

End Class
