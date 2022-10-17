<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucDetalleOFERTA_FORMATIVA
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
        Dim ID_OFERTA_FORMATIVALabel As System.Windows.Forms.Label
        Dim ID_EJERCICIOLabel As System.Windows.Forms.Label
        Dim ID_TEMA_CURSOLabel As System.Windows.Forms.Label
        Dim ID_PROVEEDOR_AFLabel As System.Windows.Forms.Label
        Dim DURACION_HORASLabel As System.Windows.Forms.Label
        Dim COSTO_X_PARTICIPANTELabel As System.Windows.Forms.Label
        Dim FECHA_INICIOLabel As System.Windows.Forms.Label
        Dim FECHA_FINLabel As System.Windows.Forms.Label
        Dim NOTASLabel As System.Windows.Forms.Label
        Dim ESTADOLabel As System.Windows.Forms.Label
        Dim FECHA_APROBACIONLabel As System.Windows.Forms.Label
        Dim USUARIO_APROBACIONLabel As System.Windows.Forms.Label
        Dim USERIDLabel As System.Windows.Forms.Label
        Dim LASTUPDATELabel As System.Windows.Forms.Label
        Me.ListaOFERTA_FORMATIVABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ID_OFERTA_FORMATIVATextBox = New System.Windows.Forms.TextBox
        Me.ID_EJERCICIOcbxEJERCICIO = New SGAFP.WinUC.cbxEJERCICIO
        Me.ID_TEMA_CURSOcbxCURSO_TEMA = New SGAFP.WinUC.cbxCURSO_TEMA
        Me.ID_PROVEEDOR_AFcbxPROVEEDOR_AF = New SGAFP.WinUC.cbxPROVEEDOR_AF
        Me.DURACION_HORASTextBox = New System.Windows.Forms.TextBox
        Me.COSTO_X_PARTICIPANTETextBox = New System.Windows.Forms.TextBox
        Me.FECHA_INICIODateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.FECHA_FINDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.NOTASTextBox = New System.Windows.Forms.TextBox
        Me.ESTADOTextBox = New System.Windows.Forms.TextBox
        Me.FECHA_APROBACIONDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.USUARIO_APROBACIONTextBox = New System.Windows.Forms.TextBox
        Me.USERIDTextBox = New System.Windows.Forms.TextBox
        Me.LASTUPDATEDateTimePicker = New System.Windows.Forms.DateTimePicker
        ID_OFERTA_FORMATIVALabel = New System.Windows.Forms.Label
        ID_EJERCICIOLabel = New System.Windows.Forms.Label
        ID_TEMA_CURSOLabel = New System.Windows.Forms.Label
        ID_PROVEEDOR_AFLabel = New System.Windows.Forms.Label
        DURACION_HORASLabel = New System.Windows.Forms.Label
        COSTO_X_PARTICIPANTELabel = New System.Windows.Forms.Label
        FECHA_INICIOLabel = New System.Windows.Forms.Label
        FECHA_FINLabel = New System.Windows.Forms.Label
        NOTASLabel = New System.Windows.Forms.Label
        ESTADOLabel = New System.Windows.Forms.Label
        FECHA_APROBACIONLabel = New System.Windows.Forms.Label
        USUARIO_APROBACIONLabel = New System.Windows.Forms.Label
        USERIDLabel = New System.Windows.Forms.Label
        LASTUPDATELabel = New System.Windows.Forms.Label
        CType(Me.ListaOFERTA_FORMATIVABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ID_OFERTA_FORMATIVALabel
        '
        ID_OFERTA_FORMATIVALabel.Location = New System.Drawing.Point(6, 14)
        ID_OFERTA_FORMATIVALabel.Name = "ID_OFERTA_FORMATIVALabel"
        ID_OFERTA_FORMATIVALabel.Size = New System.Drawing.Size(135, 13)
        ID_OFERTA_FORMATIVALabel.TabIndex = 0
        ID_OFERTA_FORMATIVALabel.Text = "Id oferta formativa:"
        '
        'ID_EJERCICIOLabel
        '
        ID_EJERCICIOLabel.Location = New System.Drawing.Point(6, 40)
        ID_EJERCICIOLabel.Name = "ID_EJERCICIOLabel"
        ID_EJERCICIOLabel.Size = New System.Drawing.Size(135, 13)
        ID_EJERCICIOLabel.TabIndex = 2
        ID_EJERCICIOLabel.Text = "Id ejercicio:"
        '
        'ID_TEMA_CURSOLabel
        '
        ID_TEMA_CURSOLabel.Location = New System.Drawing.Point(6, 66)
        ID_TEMA_CURSOLabel.Name = "ID_TEMA_CURSOLabel"
        ID_TEMA_CURSOLabel.Size = New System.Drawing.Size(135, 13)
        ID_TEMA_CURSOLabel.TabIndex = 4
        ID_TEMA_CURSOLabel.Text = "Id tema curso:"
        '
        'ID_PROVEEDOR_AFLabel
        '
        ID_PROVEEDOR_AFLabel.Location = New System.Drawing.Point(6, 92)
        ID_PROVEEDOR_AFLabel.Name = "ID_PROVEEDOR_AFLabel"
        ID_PROVEEDOR_AFLabel.Size = New System.Drawing.Size(135, 13)
        ID_PROVEEDOR_AFLabel.TabIndex = 6
        ID_PROVEEDOR_AFLabel.Text = "Id proveedor af:"
        '
        'DURACION_HORASLabel
        '
        DURACION_HORASLabel.Location = New System.Drawing.Point(6, 118)
        DURACION_HORASLabel.Name = "DURACION_HORASLabel"
        DURACION_HORASLabel.Size = New System.Drawing.Size(135, 13)
        DURACION_HORASLabel.TabIndex = 8
        DURACION_HORASLabel.Text = "Duracion horas:"
        '
        'COSTO_X_PARTICIPANTELabel
        '
        COSTO_X_PARTICIPANTELabel.Location = New System.Drawing.Point(6, 144)
        COSTO_X_PARTICIPANTELabel.Name = "COSTO_X_PARTICIPANTELabel"
        COSTO_X_PARTICIPANTELabel.Size = New System.Drawing.Size(135, 13)
        COSTO_X_PARTICIPANTELabel.TabIndex = 10
        COSTO_X_PARTICIPANTELabel.Text = "Costo x participante:"
        '
        'FECHA_INICIOLabel
        '
        FECHA_INICIOLabel.Location = New System.Drawing.Point(6, 170)
        FECHA_INICIOLabel.Name = "FECHA_INICIOLabel"
        FECHA_INICIOLabel.Size = New System.Drawing.Size(135, 13)
        FECHA_INICIOLabel.TabIndex = 12
        FECHA_INICIOLabel.Text = "Fecha inicio:"
        '
        'FECHA_FINLabel
        '
        FECHA_FINLabel.Location = New System.Drawing.Point(6, 196)
        FECHA_FINLabel.Name = "FECHA_FINLabel"
        FECHA_FINLabel.Size = New System.Drawing.Size(135, 13)
        FECHA_FINLabel.TabIndex = 14
        FECHA_FINLabel.Text = "Fecha fin:"
        '
        'NOTASLabel
        '
        NOTASLabel.Location = New System.Drawing.Point(6, 222)
        NOTASLabel.Name = "NOTASLabel"
        NOTASLabel.Size = New System.Drawing.Size(135, 13)
        NOTASLabel.TabIndex = 16
        NOTASLabel.Text = "Notas:"
        '
        'ESTADOLabel
        '
        ESTADOLabel.Location = New System.Drawing.Point(6, 248)
        ESTADOLabel.Name = "ESTADOLabel"
        ESTADOLabel.Size = New System.Drawing.Size(135, 13)
        ESTADOLabel.TabIndex = 18
        ESTADOLabel.Text = "Estado:"
        '
        'FECHA_APROBACIONLabel
        '
        FECHA_APROBACIONLabel.Location = New System.Drawing.Point(6, 274)
        FECHA_APROBACIONLabel.Name = "FECHA_APROBACIONLabel"
        FECHA_APROBACIONLabel.Size = New System.Drawing.Size(135, 13)
        FECHA_APROBACIONLabel.TabIndex = 20
        FECHA_APROBACIONLabel.Text = "Fecha aprobacion:"
        '
        'USUARIO_APROBACIONLabel
        '
        USUARIO_APROBACIONLabel.Location = New System.Drawing.Point(6, 300)
        USUARIO_APROBACIONLabel.Name = "USUARIO_APROBACIONLabel"
        USUARIO_APROBACIONLabel.Size = New System.Drawing.Size(135, 13)
        USUARIO_APROBACIONLabel.TabIndex = 22
        USUARIO_APROBACIONLabel.Text = "Usuario aprobacion:"
        '
        'USERIDLabel
        '
        USERIDLabel.Location = New System.Drawing.Point(6, 326)
        USERIDLabel.Name = "USERIDLabel"
        USERIDLabel.Size = New System.Drawing.Size(135, 13)
        USERIDLabel.TabIndex = 24
        USERIDLabel.Text = "Userid:"
        '
        'LASTUPDATELabel
        '
        LASTUPDATELabel.Location = New System.Drawing.Point(6, 352)
        LASTUPDATELabel.Name = "LASTUPDATELabel"
        LASTUPDATELabel.Size = New System.Drawing.Size(135, 13)
        LASTUPDATELabel.TabIndex = 26
        LASTUPDATELabel.Text = "Lastupdate:"
        '
        'ListaOFERTA_FORMATIVABindingSource
        '
        Me.ListaOFERTA_FORMATIVABindingSource.DataSource = GetType(SGAFP.EL.OFERTA_FORMATIVA)
        '
        'ID_OFERTA_FORMATIVATextBox
        '
        Me.ID_OFERTA_FORMATIVATextBox.BackColor = System.Drawing.Color.Linen
        Me.ID_OFERTA_FORMATIVATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaOFERTA_FORMATIVABindingSource, "ID_OFERTA_FORMATIVA", True))
        Me.ID_OFERTA_FORMATIVATextBox.Location = New System.Drawing.Point(144, 8)
        Me.ID_OFERTA_FORMATIVATextBox.Name = "ID_OFERTA_FORMATIVATextBox"
        Me.ID_OFERTA_FORMATIVATextBox.Size = New System.Drawing.Size(200, 20)
        Me.ID_OFERTA_FORMATIVATextBox.TabIndex = 1
        Me.ID_OFERTA_FORMATIVATextBox.ReadOnly = True
        '
        'ID_EJERCICIOcbxEJERCICIO
        '
        Me.ID_EJERCICIOcbxEJERCICIO.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ListaOFERTA_FORMATIVABindingSource, "ID_EJERCICIO", True))
        Me.ID_EJERCICIOcbxEJERCICIO.Location = New System.Drawing.Point(144, 34)
        Me.ID_EJERCICIOcbxEJERCICIO.Name = "ID_EJERCICIOcbxEJERCICIO"
        Me.ID_EJERCICIOcbxEJERCICIO.Size = New System.Drawing.Size(200, 20)
        Me.ID_EJERCICIOcbxEJERCICIO.TabIndex = 3
        '
        'ID_TEMA_CURSOcbxCURSO_TEMA
        '
        Me.ID_TEMA_CURSOcbxCURSO_TEMA.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ListaOFERTA_FORMATIVABindingSource, "ID_TEMA_CURSO", True))
        Me.ID_TEMA_CURSOcbxCURSO_TEMA.Location = New System.Drawing.Point(144, 60)
        Me.ID_TEMA_CURSOcbxCURSO_TEMA.Name = "ID_TEMA_CURSOcbxCURSO_TEMA"
        Me.ID_TEMA_CURSOcbxCURSO_TEMA.Size = New System.Drawing.Size(200, 20)
        Me.ID_TEMA_CURSOcbxCURSO_TEMA.TabIndex = 5
        '
        'ID_PROVEEDOR_AFcbxPROVEEDOR_AF
        '
        Me.ID_PROVEEDOR_AFcbxPROVEEDOR_AF.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ListaOFERTA_FORMATIVABindingSource, "ID_PROVEEDOR_AF", True))
        Me.ID_PROVEEDOR_AFcbxPROVEEDOR_AF.Location = New System.Drawing.Point(144, 86)
        Me.ID_PROVEEDOR_AFcbxPROVEEDOR_AF.Name = "ID_PROVEEDOR_AFcbxPROVEEDOR_AF"
        Me.ID_PROVEEDOR_AFcbxPROVEEDOR_AF.Size = New System.Drawing.Size(200, 20)
        Me.ID_PROVEEDOR_AFcbxPROVEEDOR_AF.TabIndex = 7
        '
        'DURACION_HORASTextBox
        '
        Me.DURACION_HORASTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaOFERTA_FORMATIVABindingSource, "DURACION_HORAS", True))
        Me.DURACION_HORASTextBox.Location = New System.Drawing.Point(144, 112)
        Me.DURACION_HORASTextBox.Name = "DURACION_HORASTextBox"
        Me.DURACION_HORASTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DURACION_HORASTextBox.TabIndex = 9
        '
        'COSTO_X_PARTICIPANTETextBox
        '
        Me.COSTO_X_PARTICIPANTETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaOFERTA_FORMATIVABindingSource, "COSTO_X_PARTICIPANTE", True))
        Me.COSTO_X_PARTICIPANTETextBox.Location = New System.Drawing.Point(144, 138)
        Me.COSTO_X_PARTICIPANTETextBox.Name = "COSTO_X_PARTICIPANTETextBox"
        Me.COSTO_X_PARTICIPANTETextBox.Size = New System.Drawing.Size(200, 20)
        Me.COSTO_X_PARTICIPANTETextBox.TabIndex = 11
        '
        'FECHA_INICIODateTimePicker
        '
        Me.FECHA_INICIODateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ListaOFERTA_FORMATIVABindingSource, "FECHA_INICIO", True))
        Me.FECHA_INICIODateTimePicker.Location = New System.Drawing.Point(144, 164)
        Me.FECHA_INICIODateTimePicker.Name = "FECHA_INICIODateTimePicker"
        Me.FECHA_INICIODateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.FECHA_INICIODateTimePicker.TabIndex = 13
        '
        'FECHA_FINDateTimePicker
        '
        Me.FECHA_FINDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ListaOFERTA_FORMATIVABindingSource, "FECHA_FIN", True))
        Me.FECHA_FINDateTimePicker.Location = New System.Drawing.Point(144, 190)
        Me.FECHA_FINDateTimePicker.Name = "FECHA_FINDateTimePicker"
        Me.FECHA_FINDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.FECHA_FINDateTimePicker.TabIndex = 15
        '
        'NOTASTextBox
        '
        Me.NOTASTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaOFERTA_FORMATIVABindingSource, "NOTAS", True))
        Me.NOTASTextBox.Location = New System.Drawing.Point(144, 216)
        Me.NOTASTextBox.Name = "NOTASTextBox"
        Me.NOTASTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NOTASTextBox.TabIndex = 17
        Me.NOTASTextBox.MaxLength = 255
        '
        'ESTADOTextBox
        '
        Me.ESTADOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaOFERTA_FORMATIVABindingSource, "ESTADO", True))
        Me.ESTADOTextBox.Location = New System.Drawing.Point(144, 242)
        Me.ESTADOTextBox.Name = "ESTADOTextBox"
        Me.ESTADOTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ESTADOTextBox.TabIndex = 19
        Me.ESTADOTextBox.MaxLength = 1
        '
        'FECHA_APROBACIONDateTimePicker
        '
        Me.FECHA_APROBACIONDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ListaOFERTA_FORMATIVABindingSource, "FECHA_APROBACION", True))
        Me.FECHA_APROBACIONDateTimePicker.Location = New System.Drawing.Point(144, 268)
        Me.FECHA_APROBACIONDateTimePicker.Name = "FECHA_APROBACIONDateTimePicker"
        Me.FECHA_APROBACIONDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.FECHA_APROBACIONDateTimePicker.TabIndex = 21
        '
        'USUARIO_APROBACIONTextBox
        '
        Me.USUARIO_APROBACIONTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaOFERTA_FORMATIVABindingSource, "USUARIO_APROBACION", True))
        Me.USUARIO_APROBACIONTextBox.Location = New System.Drawing.Point(144, 294)
        Me.USUARIO_APROBACIONTextBox.Name = "USUARIO_APROBACIONTextBox"
        Me.USUARIO_APROBACIONTextBox.Size = New System.Drawing.Size(200, 20)
        Me.USUARIO_APROBACIONTextBox.TabIndex = 23
        Me.USUARIO_APROBACIONTextBox.MaxLength = 16
        '
        'USERIDTextBox
        '
        Me.USERIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaOFERTA_FORMATIVABindingSource, "USERID", True))
        Me.USERIDTextBox.Location = New System.Drawing.Point(144, 320)
        Me.USERIDTextBox.Name = "USERIDTextBox"
        Me.USERIDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.USERIDTextBox.TabIndex = 25
        Me.USERIDTextBox.MaxLength = 16
        '
        'LASTUPDATEDateTimePicker
        '
        Me.LASTUPDATEDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ListaOFERTA_FORMATIVABindingSource, "LASTUPDATE", True))
        Me.LASTUPDATEDateTimePicker.Location = New System.Drawing.Point(144, 346)
        Me.LASTUPDATEDateTimePicker.Name = "LASTUPDATEDateTimePicker"
        Me.LASTUPDATEDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.LASTUPDATEDateTimePicker.TabIndex = 27
        '
        'ucDetalleOFERTA_FORMATIVA
        '
        Me.AutoScroll = True
        Me.Controls.Add(ID_OFERTA_FORMATIVALabel)
        Me.Controls.Add(Me.ID_OFERTA_FORMATIVATextBox)
        Me.Controls.Add(ID_EJERCICIOLabel)
        Me.Controls.Add(Me.ID_EJERCICIOcbxEJERCICIO)
        Me.Controls.Add(ID_TEMA_CURSOLabel)
        Me.Controls.Add(Me.ID_TEMA_CURSOcbxCURSO_TEMA)
        Me.Controls.Add(ID_PROVEEDOR_AFLabel)
        Me.Controls.Add(Me.ID_PROVEEDOR_AFcbxPROVEEDOR_AF)
        Me.Controls.Add(DURACION_HORASLabel)
        Me.Controls.Add(Me.DURACION_HORASTextBox)
        Me.Controls.Add(COSTO_X_PARTICIPANTELabel)
        Me.Controls.Add(Me.COSTO_X_PARTICIPANTETextBox)
        Me.Controls.Add(FECHA_INICIOLabel)
        Me.Controls.Add(Me.FECHA_INICIODateTimePicker)
        Me.Controls.Add(FECHA_FINLabel)
        Me.Controls.Add(Me.FECHA_FINDateTimePicker)
        Me.Controls.Add(NOTASLabel)
        Me.Controls.Add(Me.NOTASTextBox)
        Me.Controls.Add(ESTADOLabel)
        Me.Controls.Add(Me.ESTADOTextBox)
        Me.Controls.Add(FECHA_APROBACIONLabel)
        Me.Controls.Add(Me.FECHA_APROBACIONDateTimePicker)
        Me.Controls.Add(USUARIO_APROBACIONLabel)
        Me.Controls.Add(Me.USUARIO_APROBACIONTextBox)
        Me.Controls.Add(USERIDLabel)
        Me.Controls.Add(Me.USERIDTextBox)
        Me.Controls.Add(LASTUPDATELabel)
        Me.Controls.Add(Me.LASTUPDATEDateTimePicker)
        Me.Name = "ucDetalleOFERTA_FORMATIVA"
        Me.Size = New System.Drawing.Size(382, 398)
        CType(Me.ListaOFERTA_FORMATIVABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaOFERTA_FORMATIVABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ID_OFERTA_FORMATIVATextBox As System.Windows.Forms.TextBox
    Friend WithEvents ID_EJERCICIOcbxEJERCICIO As SGAFP.WinUC.cbxEJERCICIO
    Friend WithEvents ID_TEMA_CURSOcbxCURSO_TEMA As SGAFP.WinUC.cbxCURSO_TEMA
    Friend WithEvents ID_PROVEEDOR_AFcbxPROVEEDOR_AF As SGAFP.WinUC.cbxPROVEEDOR_AF
    Friend WithEvents DURACION_HORASTextBox As System.Windows.Forms.TextBox
    Friend WithEvents COSTO_X_PARTICIPANTETextBox As System.Windows.Forms.TextBox
    Friend WithEvents FECHA_INICIODateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents FECHA_FINDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents NOTASTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ESTADOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FECHA_APROBACIONDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents USUARIO_APROBACIONTextBox As System.Windows.Forms.TextBox
    Friend WithEvents USERIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LASTUPDATEDateTimePicker As System.Windows.Forms.DateTimePicker

End Class
