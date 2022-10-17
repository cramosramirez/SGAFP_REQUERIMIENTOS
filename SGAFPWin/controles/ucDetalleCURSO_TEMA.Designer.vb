<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucDetalleCURSO_TEMA
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
        Dim ID_TEMA_CURSOLabel As System.Windows.Forms.Label
        Dim ID_AREA_FORMACIONLabel As System.Windows.Forms.Label
        Dim TEMA_CURSOLabel As System.Windows.Forms.Label
        Dim DURACION_HORASLabel As System.Windows.Forms.Label
        Dim FECHA_ACREDITACIONLabel As System.Windows.Forms.Label
        Dim NOTASLabel As System.Windows.Forms.Label
        Dim USERIDLabel As System.Windows.Forms.Label
        Dim LASTUPDATELabel As System.Windows.Forms.Label
        Me.ListaCURSO_TEMABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ID_TEMA_CURSOTextBox = New System.Windows.Forms.TextBox
        Me.ID_AREA_FORMACIONcbxAREA_FORMACION = New SGAFP.WinUC.cbxAREA_FORMACION
        Me.TEMA_CURSOTextBox = New System.Windows.Forms.TextBox
        Me.DURACION_HORASTextBox = New System.Windows.Forms.TextBox
        Me.FECHA_ACREDITACIONDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.NOTASTextBox = New System.Windows.Forms.TextBox
        Me.USERIDTextBox = New System.Windows.Forms.TextBox
        Me.LASTUPDATEDateTimePicker = New System.Windows.Forms.DateTimePicker
        ID_TEMA_CURSOLabel = New System.Windows.Forms.Label
        ID_AREA_FORMACIONLabel = New System.Windows.Forms.Label
        TEMA_CURSOLabel = New System.Windows.Forms.Label
        DURACION_HORASLabel = New System.Windows.Forms.Label
        FECHA_ACREDITACIONLabel = New System.Windows.Forms.Label
        NOTASLabel = New System.Windows.Forms.Label
        USERIDLabel = New System.Windows.Forms.Label
        LASTUPDATELabel = New System.Windows.Forms.Label
        CType(Me.ListaCURSO_TEMABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ID_TEMA_CURSOLabel
        '
        ID_TEMA_CURSOLabel.Location = New System.Drawing.Point(6, 14)
        ID_TEMA_CURSOLabel.Name = "ID_TEMA_CURSOLabel"
        ID_TEMA_CURSOLabel.Size = New System.Drawing.Size(135, 13)
        ID_TEMA_CURSOLabel.TabIndex = 0
        ID_TEMA_CURSOLabel.Text = "Id tema curso:"
        '
        'ID_AREA_FORMACIONLabel
        '
        ID_AREA_FORMACIONLabel.Location = New System.Drawing.Point(6, 40)
        ID_AREA_FORMACIONLabel.Name = "ID_AREA_FORMACIONLabel"
        ID_AREA_FORMACIONLabel.Size = New System.Drawing.Size(135, 13)
        ID_AREA_FORMACIONLabel.TabIndex = 2
        ID_AREA_FORMACIONLabel.Text = "Id area formacion:"
        '
        'TEMA_CURSOLabel
        '
        TEMA_CURSOLabel.Location = New System.Drawing.Point(6, 66)
        TEMA_CURSOLabel.Name = "TEMA_CURSOLabel"
        TEMA_CURSOLabel.Size = New System.Drawing.Size(135, 13)
        TEMA_CURSOLabel.TabIndex = 4
        TEMA_CURSOLabel.Text = "Tema curso:"
        '
        'DURACION_HORASLabel
        '
        DURACION_HORASLabel.Location = New System.Drawing.Point(6, 92)
        DURACION_HORASLabel.Name = "DURACION_HORASLabel"
        DURACION_HORASLabel.Size = New System.Drawing.Size(135, 13)
        DURACION_HORASLabel.TabIndex = 6
        DURACION_HORASLabel.Text = "Duracion horas:"
        '
        'FECHA_ACREDITACIONLabel
        '
        FECHA_ACREDITACIONLabel.Location = New System.Drawing.Point(6, 118)
        FECHA_ACREDITACIONLabel.Name = "FECHA_ACREDITACIONLabel"
        FECHA_ACREDITACIONLabel.Size = New System.Drawing.Size(135, 13)
        FECHA_ACREDITACIONLabel.TabIndex = 8
        FECHA_ACREDITACIONLabel.Text = "Fecha acreditacion:"
        '
        'NOTASLabel
        '
        NOTASLabel.Location = New System.Drawing.Point(6, 144)
        NOTASLabel.Name = "NOTASLabel"
        NOTASLabel.Size = New System.Drawing.Size(135, 13)
        NOTASLabel.TabIndex = 10
        NOTASLabel.Text = "Notas:"
        '
        'USERIDLabel
        '
        USERIDLabel.Location = New System.Drawing.Point(6, 170)
        USERIDLabel.Name = "USERIDLabel"
        USERIDLabel.Size = New System.Drawing.Size(135, 13)
        USERIDLabel.TabIndex = 12
        USERIDLabel.Text = "Userid:"
        '
        'LASTUPDATELabel
        '
        LASTUPDATELabel.Location = New System.Drawing.Point(6, 196)
        LASTUPDATELabel.Name = "LASTUPDATELabel"
        LASTUPDATELabel.Size = New System.Drawing.Size(135, 13)
        LASTUPDATELabel.TabIndex = 14
        LASTUPDATELabel.Text = "Lastupdate:"
        '
        'ListaCURSO_TEMABindingSource
        '
        Me.ListaCURSO_TEMABindingSource.DataSource = GetType(SGAFP.EL.CURSO_TEMA)
        '
        'ID_TEMA_CURSOTextBox
        '
        Me.ID_TEMA_CURSOTextBox.BackColor = System.Drawing.Color.Linen
        Me.ID_TEMA_CURSOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaCURSO_TEMABindingSource, "ID_TEMA_CURSO", True))
        Me.ID_TEMA_CURSOTextBox.Location = New System.Drawing.Point(144, 8)
        Me.ID_TEMA_CURSOTextBox.Name = "ID_TEMA_CURSOTextBox"
        Me.ID_TEMA_CURSOTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ID_TEMA_CURSOTextBox.TabIndex = 1
        Me.ID_TEMA_CURSOTextBox.ReadOnly = True
        '
        'ID_AREA_FORMACIONcbxAREA_FORMACION
        '
        Me.ID_AREA_FORMACIONcbxAREA_FORMACION.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ListaCURSO_TEMABindingSource, "ID_AREA_FORMACION", True))
        Me.ID_AREA_FORMACIONcbxAREA_FORMACION.Location = New System.Drawing.Point(144, 34)
        Me.ID_AREA_FORMACIONcbxAREA_FORMACION.Name = "ID_AREA_FORMACIONcbxAREA_FORMACION"
        Me.ID_AREA_FORMACIONcbxAREA_FORMACION.Size = New System.Drawing.Size(200, 20)
        Me.ID_AREA_FORMACIONcbxAREA_FORMACION.TabIndex = 3
        '
        'TEMA_CURSOTextBox
        '
        Me.TEMA_CURSOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaCURSO_TEMABindingSource, "TEMA_CURSO", True))
        Me.TEMA_CURSOTextBox.Location = New System.Drawing.Point(144, 60)
        Me.TEMA_CURSOTextBox.Name = "TEMA_CURSOTextBox"
        Me.TEMA_CURSOTextBox.Size = New System.Drawing.Size(200, 20)
        Me.TEMA_CURSOTextBox.TabIndex = 5
        Me.TEMA_CURSOTextBox.MaxLength = 150
        '
        'DURACION_HORASTextBox
        '
        Me.DURACION_HORASTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaCURSO_TEMABindingSource, "DURACION_HORAS", True))
        Me.DURACION_HORASTextBox.Location = New System.Drawing.Point(144, 86)
        Me.DURACION_HORASTextBox.Name = "DURACION_HORASTextBox"
        Me.DURACION_HORASTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DURACION_HORASTextBox.TabIndex = 7
        '
        'FECHA_ACREDITACIONDateTimePicker
        '
        Me.FECHA_ACREDITACIONDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ListaCURSO_TEMABindingSource, "FECHA_ACREDITACION", True))
        Me.FECHA_ACREDITACIONDateTimePicker.Location = New System.Drawing.Point(144, 112)
        Me.FECHA_ACREDITACIONDateTimePicker.Name = "FECHA_ACREDITACIONDateTimePicker"
        Me.FECHA_ACREDITACIONDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.FECHA_ACREDITACIONDateTimePicker.TabIndex = 9
        '
        'NOTASTextBox
        '
        Me.NOTASTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaCURSO_TEMABindingSource, "NOTAS", True))
        Me.NOTASTextBox.Location = New System.Drawing.Point(144, 138)
        Me.NOTASTextBox.Name = "NOTASTextBox"
        Me.NOTASTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NOTASTextBox.TabIndex = 11
        Me.NOTASTextBox.MaxLength = 255
        '
        'USERIDTextBox
        '
        Me.USERIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaCURSO_TEMABindingSource, "USERID", True))
        Me.USERIDTextBox.Location = New System.Drawing.Point(144, 164)
        Me.USERIDTextBox.Name = "USERIDTextBox"
        Me.USERIDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.USERIDTextBox.TabIndex = 13
        Me.USERIDTextBox.MaxLength = 16
        '
        'LASTUPDATEDateTimePicker
        '
        Me.LASTUPDATEDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ListaCURSO_TEMABindingSource, "LASTUPDATE", True))
        Me.LASTUPDATEDateTimePicker.Location = New System.Drawing.Point(144, 190)
        Me.LASTUPDATEDateTimePicker.Name = "LASTUPDATEDateTimePicker"
        Me.LASTUPDATEDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.LASTUPDATEDateTimePicker.TabIndex = 15
        '
        'ucDetalleCURSO_TEMA
        '
        Me.AutoScroll = True
        Me.Controls.Add(ID_TEMA_CURSOLabel)
        Me.Controls.Add(Me.ID_TEMA_CURSOTextBox)
        Me.Controls.Add(ID_AREA_FORMACIONLabel)
        Me.Controls.Add(Me.ID_AREA_FORMACIONcbxAREA_FORMACION)
        Me.Controls.Add(TEMA_CURSOLabel)
        Me.Controls.Add(Me.TEMA_CURSOTextBox)
        Me.Controls.Add(DURACION_HORASLabel)
        Me.Controls.Add(Me.DURACION_HORASTextBox)
        Me.Controls.Add(FECHA_ACREDITACIONLabel)
        Me.Controls.Add(Me.FECHA_ACREDITACIONDateTimePicker)
        Me.Controls.Add(NOTASLabel)
        Me.Controls.Add(Me.NOTASTextBox)
        Me.Controls.Add(USERIDLabel)
        Me.Controls.Add(Me.USERIDTextBox)
        Me.Controls.Add(LASTUPDATELabel)
        Me.Controls.Add(Me.LASTUPDATEDateTimePicker)
        Me.Name = "ucDetalleCURSO_TEMA"
        Me.Size = New System.Drawing.Size(382, 242)
        CType(Me.ListaCURSO_TEMABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaCURSO_TEMABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ID_TEMA_CURSOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ID_AREA_FORMACIONcbxAREA_FORMACION As SGAFP.WinUC.cbxAREA_FORMACION
    Friend WithEvents TEMA_CURSOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DURACION_HORASTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FECHA_ACREDITACIONDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents NOTASTextBox As System.Windows.Forms.TextBox
    Friend WithEvents USERIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LASTUPDATEDateTimePicker As System.Windows.Forms.DateTimePicker

End Class
