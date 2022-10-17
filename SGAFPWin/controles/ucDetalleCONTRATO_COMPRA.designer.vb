<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucDetalleCONTRATO_COMPRA
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
        Me.components = New System.ComponentModel.Container()
        Me.ID_CONTRATO_COMPRALabel = New System.Windows.Forms.Label()
        Me.NO_CONTRATO_COMPRALabel = New System.Windows.Forms.Label()
        Me.FECHA_INGRESOLabel = New System.Windows.Forms.Label()
        Me.ListaCONTRATO_COMPRABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ID_CONTRATO_COMPRATextBox = New System.Windows.Forms.TextBox()
        Me.NO_CONTRATO_COMPRATextBox = New System.Windows.Forms.TextBox()
        Me.FECHA_INGRESODateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FECHA_INI_EJECDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FECHA_FIN_EJECDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PORC_ASISTENCIA_MINtxt = New System.Windows.Forms.TextBox()
        Me.btnRecalculoPagoInformes = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chkPAGO_EN_BASE_A = New System.Windows.Forms.CheckedListBox()
        Me.txtBaseParti = New System.Windows.Forms.TextBox()
        Me.lblBaseParti = New System.Windows.Forms.Label()
        Me.ID_UNIDAD_ORGANIZATIVALabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.ID_UNIDAD_ORGANIZATIVAcbxUNIDAD_ORGANIZATIVA = New SGAFP.WinUC.cbxUNIDAD_ORGANIZATIVA()
        CType(Me.ListaCONTRATO_COMPRABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ID_CONTRATO_COMPRALabel
        '
        Me.ID_CONTRATO_COMPRALabel.Location = New System.Drawing.Point(6, 14)
        Me.ID_CONTRATO_COMPRALabel.Name = "ID_CONTRATO_COMPRALabel"
        Me.ID_CONTRATO_COMPRALabel.Size = New System.Drawing.Size(135, 13)
        Me.ID_CONTRATO_COMPRALabel.TabIndex = 0
        Me.ID_CONTRATO_COMPRALabel.Text = "Id Oferta Compra"
        '
        'NO_CONTRATO_COMPRALabel
        '
        Me.NO_CONTRATO_COMPRALabel.Location = New System.Drawing.Point(6, 40)
        Me.NO_CONTRATO_COMPRALabel.Name = "NO_CONTRATO_COMPRALabel"
        Me.NO_CONTRATO_COMPRALabel.Size = New System.Drawing.Size(135, 13)
        Me.NO_CONTRATO_COMPRALabel.TabIndex = 2
        Me.NO_CONTRATO_COMPRALabel.Text = "Número Oferta Compra:"
        '
        'FECHA_INGRESOLabel
        '
        Me.FECHA_INGRESOLabel.Location = New System.Drawing.Point(6, 95)
        Me.FECHA_INGRESOLabel.Name = "FECHA_INGRESOLabel"
        Me.FECHA_INGRESOLabel.Size = New System.Drawing.Size(135, 13)
        Me.FECHA_INGRESOLabel.TabIndex = 4
        Me.FECHA_INGRESOLabel.Text = "Fecha Ingreso:"
        '
        'ListaCONTRATO_COMPRABindingSource
        '
        Me.ListaCONTRATO_COMPRABindingSource.DataSource = GetType(SGAFP.EL.CONTRATO_COMPRA)
        '
        'ID_CONTRATO_COMPRATextBox
        '
        Me.ID_CONTRATO_COMPRATextBox.BackColor = System.Drawing.Color.Linen
        Me.ID_CONTRATO_COMPRATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaCONTRATO_COMPRABindingSource, "ID_CONTRATO_COMPRA", True))
        Me.ID_CONTRATO_COMPRATextBox.Location = New System.Drawing.Point(144, 8)
        Me.ID_CONTRATO_COMPRATextBox.Name = "ID_CONTRATO_COMPRATextBox"
        Me.ID_CONTRATO_COMPRATextBox.ReadOnly = True
        Me.ID_CONTRATO_COMPRATextBox.Size = New System.Drawing.Size(162, 21)
        Me.ID_CONTRATO_COMPRATextBox.TabIndex = 1
        '
        'NO_CONTRATO_COMPRATextBox
        '
        Me.NO_CONTRATO_COMPRATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaCONTRATO_COMPRABindingSource, "NO_CONTRATO_COMPRA", True))
        Me.NO_CONTRATO_COMPRATextBox.Location = New System.Drawing.Point(144, 34)
        Me.NO_CONTRATO_COMPRATextBox.MaxLength = 10
        Me.NO_CONTRATO_COMPRATextBox.Name = "NO_CONTRATO_COMPRATextBox"
        Me.NO_CONTRATO_COMPRATextBox.Size = New System.Drawing.Size(162, 21)
        Me.NO_CONTRATO_COMPRATextBox.TabIndex = 3
        '
        'FECHA_INGRESODateTimePicker
        '
        Me.FECHA_INGRESODateTimePicker.CustomFormat = "dd/MM/yyyy"
        Me.FECHA_INGRESODateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ListaCONTRATO_COMPRABindingSource, "FECHA_INGRESO", True))
        Me.FECHA_INGRESODateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FECHA_INGRESODateTimePicker.Location = New System.Drawing.Point(144, 89)
        Me.FECHA_INGRESODateTimePicker.Name = "FECHA_INGRESODateTimePicker"
        Me.FECHA_INGRESODateTimePicker.Size = New System.Drawing.Size(162, 21)
        Me.FECHA_INGRESODateTimePicker.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(6, 150)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Del:"
        '
        'FECHA_INI_EJECDateTimePicker
        '
        Me.FECHA_INI_EJECDateTimePicker.CustomFormat = "dd/MM/yyyy"
        Me.FECHA_INI_EJECDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ListaCONTRATO_COMPRABindingSource, "FECHA_INGRESO", True))
        Me.FECHA_INI_EJECDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FECHA_INI_EJECDateTimePicker.Location = New System.Drawing.Point(144, 144)
        Me.FECHA_INI_EJECDateTimePicker.Name = "FECHA_INI_EJECDateTimePicker"
        Me.FECHA_INI_EJECDateTimePicker.Size = New System.Drawing.Size(162, 21)
        Me.FECHA_INI_EJECDateTimePicker.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(6, 177)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Al:"
        '
        'FECHA_FIN_EJECDateTimePicker
        '
        Me.FECHA_FIN_EJECDateTimePicker.CustomFormat = "dd/MM/yyyy"
        Me.FECHA_FIN_EJECDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ListaCONTRATO_COMPRABindingSource, "FECHA_INGRESO", True))
        Me.FECHA_FIN_EJECDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FECHA_FIN_EJECDateTimePicker.Location = New System.Drawing.Point(144, 171)
        Me.FECHA_FIN_EJECDateTimePicker.Name = "FECHA_FIN_EJECDateTimePicker"
        Me.FECHA_FIN_EJECDateTimePicker.Size = New System.Drawing.Size(162, 21)
        Me.FECHA_FIN_EJECDateTimePicker.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Período de Validez"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 208)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Condiciones para pago"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(6, 236)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(251, 18)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Porcentaje mínimo de asistencia del participante:"
        '
        'PORC_ASISTENCIA_MINtxt
        '
        Me.PORC_ASISTENCIA_MINtxt.Location = New System.Drawing.Point(248, 233)
        Me.PORC_ASISTENCIA_MINtxt.Name = "PORC_ASISTENCIA_MINtxt"
        Me.PORC_ASISTENCIA_MINtxt.Size = New System.Drawing.Size(58, 21)
        Me.PORC_ASISTENCIA_MINtxt.TabIndex = 13
        '
        'btnRecalculoPagoInformes
        '
        Me.btnRecalculoPagoInformes.Location = New System.Drawing.Point(9, 381)
        Me.btnRecalculoPagoInformes.Name = "btnRecalculoPagoInformes"
        Me.btnRecalculoPagoInformes.Size = New System.Drawing.Size(232, 25)
        Me.btnRecalculoPagoInformes.TabIndex = 15
        Me.btnRecalculoPagoInformes.Text = "Recalcular el monto a pagar en Informes"
        Me.btnRecalculoPagoInformes.UseVisualStyleBackColor = True
        Me.btnRecalculoPagoInformes.Visible = False
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(6, 267)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 18)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Pagar en base a:"
        '
        'chkPAGO_EN_BASE_A
        '
        Me.chkPAGO_EN_BASE_A.CheckOnClick = True
        Me.chkPAGO_EN_BASE_A.FormattingEnabled = True
        Me.chkPAGO_EN_BASE_A.Items.AddRange(New Object() {"Pago por curso, independiente de capacitados", "Pago por participante capacitado con base a:", "Pago en base a participantes inscritos"})
        Me.chkPAGO_EN_BASE_A.Location = New System.Drawing.Point(9, 288)
        Me.chkPAGO_EN_BASE_A.Name = "chkPAGO_EN_BASE_A"
        Me.chkPAGO_EN_BASE_A.Size = New System.Drawing.Size(248, 68)
        Me.chkPAGO_EN_BASE_A.TabIndex = 17
        '
        'txtBaseParti
        '
        Me.txtBaseParti.Location = New System.Drawing.Point(263, 304)
        Me.txtBaseParti.Name = "txtBaseParti"
        Me.txtBaseParti.Size = New System.Drawing.Size(43, 21)
        Me.txtBaseParti.TabIndex = 18
        '
        'lblBaseParti
        '
        Me.lblBaseParti.Location = New System.Drawing.Point(310, 307)
        Me.lblBaseParti.Name = "lblBaseParti"
        Me.lblBaseParti.Size = New System.Drawing.Size(125, 18)
        Me.lblBaseParti.TabIndex = 19
        Me.lblBaseParti.Text = "(Cantidad base a pagar)"
        '
        'ID_UNIDAD_ORGANIZATIVALabelControl
        '
        Me.ID_UNIDAD_ORGANIZATIVALabelControl.Appearance.ForeColor = System.Drawing.Color.Black
        Me.ID_UNIDAD_ORGANIZATIVALabelControl.Location = New System.Drawing.Point(6, 67)
        Me.ID_UNIDAD_ORGANIZATIVALabelControl.Name = "ID_UNIDAD_ORGANIZATIVALabelControl"
        Me.ID_UNIDAD_ORGANIZATIVALabelControl.Size = New System.Drawing.Size(101, 13)
        Me.ID_UNIDAD_ORGANIZATIVALabelControl.TabIndex = 20
        Me.ID_UNIDAD_ORGANIZATIVALabelControl.Text = "Unidad Organizativa:"
        '
        'ID_UNIDAD_ORGANIZATIVAcbxUNIDAD_ORGANIZATIVA
        '
        Me.ID_UNIDAD_ORGANIZATIVAcbxUNIDAD_ORGANIZATIVA.AllowFindEntityType = Nothing
        Me.ID_UNIDAD_ORGANIZATIVAcbxUNIDAD_ORGANIZATIVA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ID_UNIDAD_ORGANIZATIVAcbxUNIDAD_ORGANIZATIVA.Location = New System.Drawing.Point(144, 61)
        Me.ID_UNIDAD_ORGANIZATIVAcbxUNIDAD_ORGANIZATIVA.Name = "ID_UNIDAD_ORGANIZATIVAcbxUNIDAD_ORGANIZATIVA"
        Me.ID_UNIDAD_ORGANIZATIVAcbxUNIDAD_ORGANIZATIVA.Size = New System.Drawing.Size(334, 21)
        Me.ID_UNIDAD_ORGANIZATIVAcbxUNIDAD_ORGANIZATIVA.TabIndex = 21
        '
        'ucDetalleCONTRATO_COMPRA
        '
        Me.AutoScroll = True
        Me.Controls.Add(Me.ID_UNIDAD_ORGANIZATIVALabelControl)
        Me.Controls.Add(Me.ID_UNIDAD_ORGANIZATIVAcbxUNIDAD_ORGANIZATIVA)
        Me.Controls.Add(Me.lblBaseParti)
        Me.Controls.Add(Me.txtBaseParti)
        Me.Controls.Add(Me.chkPAGO_EN_BASE_A)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnRecalculoPagoInformes)
        Me.Controls.Add(Me.PORC_ASISTENCIA_MINtxt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.FECHA_FIN_EJECDateTimePicker)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FECHA_INI_EJECDateTimePicker)
        Me.Controls.Add(Me.ID_CONTRATO_COMPRALabel)
        Me.Controls.Add(Me.ID_CONTRATO_COMPRATextBox)
        Me.Controls.Add(Me.NO_CONTRATO_COMPRALabel)
        Me.Controls.Add(Me.NO_CONTRATO_COMPRATextBox)
        Me.Controls.Add(Me.FECHA_INGRESOLabel)
        Me.Controls.Add(Me.FECHA_INGRESODateTimePicker)
        Me.Name = "ucDetalleCONTRATO_COMPRA"
        Me.Size = New System.Drawing.Size(518, 447)
        CType(Me.ListaCONTRATO_COMPRABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaCONTRATO_COMPRABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ID_CONTRATO_COMPRATextBox As System.Windows.Forms.TextBox
    Friend WithEvents NO_CONTRATO_COMPRATextBox As System.Windows.Forms.TextBox
    Friend WithEvents FECHA_INGRESODateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ID_CONTRATO_COMPRALabel As System.Windows.Forms.Label
    Friend WithEvents NO_CONTRATO_COMPRALabel As System.Windows.Forms.Label
    Friend WithEvents FECHA_INGRESOLabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FECHA_INI_EJECDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents FECHA_FIN_EJECDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PORC_ASISTENCIA_MINtxt As System.Windows.Forms.TextBox
    Friend WithEvents btnRecalculoPagoInformes As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents chkPAGO_EN_BASE_A As System.Windows.Forms.CheckedListBox
    Friend WithEvents txtBaseParti As System.Windows.Forms.TextBox
    Friend WithEvents lblBaseParti As System.Windows.Forms.Label
    Friend WithEvents ID_UNIDAD_ORGANIZATIVALabelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ID_UNIDAD_ORGANIZATIVAcbxUNIDAD_ORGANIZATIVA As SGAFP.WinUC.cbxUNIDAD_ORGANIZATIVA

End Class
