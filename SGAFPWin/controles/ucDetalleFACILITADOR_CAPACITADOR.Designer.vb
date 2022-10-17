<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucDetalleFACILITADOR_CAPACITADOR
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
        Dim ID_FACILITADORLabel As System.Windows.Forms.Label
        Dim ID_TIPO_PERSONALabel As System.Windows.Forms.Label
        Dim ID_PROVEEDOR_AFLabel As System.Windows.Forms.Label
        Dim CODIGO_MUNICIPIOLabel As System.Windows.Forms.Label
        Dim CODIGO_REGIONLabel As System.Windows.Forms.Label
        Dim CODIGO_DEPARTAMENTOLabel As System.Windows.Forms.Label
        Dim NOMBRE_FACILITADORLabel As System.Windows.Forms.Label
        Dim NITLabel As System.Windows.Forms.Label
        Dim DUILabel As System.Windows.Forms.Label
        Dim ISSSLabel As System.Windows.Forms.Label
        Dim FECHA_INGRESOLabel As System.Windows.Forms.Label
        Dim TELEFONOLabel As System.Windows.Forms.Label
        Dim EMAILLabel As System.Windows.Forms.Label
        Dim DIRECCIONLabel As System.Windows.Forms.Label
        Dim NOTASLabel As System.Windows.Forms.Label
        Dim USERIDLabel As System.Windows.Forms.Label
        Dim LASTUPDATELabel As System.Windows.Forms.Label
        Me.ListaFACILITADOR_CAPACITADORBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ID_FACILITADORTextBox = New System.Windows.Forms.TextBox
        Me.ID_TIPO_PERSONAcbxTIPO_PERSONA = New SGAFP.WinUC.cbxTIPO_PERSONA
        Me.ID_PROVEEDOR_AFcbxPROVEEDOR_AF = New SGAFP.WinUC.cbxPROVEEDOR_AF
        Me.CODIGO_MUNICIPIOcbxMUNICIPIO = New SGAFP.WinUC.cbxMUNICIPIO
        Me.CODIGO_REGIONcbxREGION = New SGAFP.WinUC.cbxREGION
        Me.CODIGO_DEPARTAMENTOcbxDEPARTAMENTO = New SGAFP.WinUC.cbxDEPARTAMENTO
        Me.NOMBRE_FACILITADORTextBox = New System.Windows.Forms.TextBox
        Me.NITTextBox = New System.Windows.Forms.TextBox
        Me.DUITextBox = New System.Windows.Forms.TextBox
        Me.ISSSTextBox = New System.Windows.Forms.TextBox
        Me.FECHA_INGRESODateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.TELEFONOTextBox = New System.Windows.Forms.TextBox
        Me.EMAILTextBox = New System.Windows.Forms.TextBox
        Me.DIRECCIONTextBox = New System.Windows.Forms.TextBox
        Me.NOTASTextBox = New System.Windows.Forms.TextBox
        Me.USERIDTextBox = New System.Windows.Forms.TextBox
        Me.LASTUPDATEDateTimePicker = New System.Windows.Forms.DateTimePicker
        ID_FACILITADORLabel = New System.Windows.Forms.Label
        ID_TIPO_PERSONALabel = New System.Windows.Forms.Label
        ID_PROVEEDOR_AFLabel = New System.Windows.Forms.Label
        CODIGO_MUNICIPIOLabel = New System.Windows.Forms.Label
        CODIGO_REGIONLabel = New System.Windows.Forms.Label
        CODIGO_DEPARTAMENTOLabel = New System.Windows.Forms.Label
        NOMBRE_FACILITADORLabel = New System.Windows.Forms.Label
        NITLabel = New System.Windows.Forms.Label
        DUILabel = New System.Windows.Forms.Label
        ISSSLabel = New System.Windows.Forms.Label
        FECHA_INGRESOLabel = New System.Windows.Forms.Label
        TELEFONOLabel = New System.Windows.Forms.Label
        EMAILLabel = New System.Windows.Forms.Label
        DIRECCIONLabel = New System.Windows.Forms.Label
        NOTASLabel = New System.Windows.Forms.Label
        USERIDLabel = New System.Windows.Forms.Label
        LASTUPDATELabel = New System.Windows.Forms.Label
        CType(Me.ListaFACILITADOR_CAPACITADORBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ID_FACILITADORLabel
        '
        ID_FACILITADORLabel.Location = New System.Drawing.Point(6, 14)
        ID_FACILITADORLabel.Name = "ID_FACILITADORLabel"
        ID_FACILITADORLabel.Size = New System.Drawing.Size(135, 13)
        ID_FACILITADORLabel.TabIndex = 0
        ID_FACILITADORLabel.Text = "Id facilitador:"
        '
        'ID_TIPO_PERSONALabel
        '
        ID_TIPO_PERSONALabel.Location = New System.Drawing.Point(6, 40)
        ID_TIPO_PERSONALabel.Name = "ID_TIPO_PERSONALabel"
        ID_TIPO_PERSONALabel.Size = New System.Drawing.Size(135, 13)
        ID_TIPO_PERSONALabel.TabIndex = 2
        ID_TIPO_PERSONALabel.Text = "Id tipo persona:"
        '
        'ID_PROVEEDOR_AFLabel
        '
        ID_PROVEEDOR_AFLabel.Location = New System.Drawing.Point(6, 66)
        ID_PROVEEDOR_AFLabel.Name = "ID_PROVEEDOR_AFLabel"
        ID_PROVEEDOR_AFLabel.Size = New System.Drawing.Size(135, 13)
        ID_PROVEEDOR_AFLabel.TabIndex = 4
        ID_PROVEEDOR_AFLabel.Text = "Id proveedor af:"
        '
        'CODIGO_MUNICIPIOLabel
        '
        CODIGO_MUNICIPIOLabel.Location = New System.Drawing.Point(6, 92)
        CODIGO_MUNICIPIOLabel.Name = "CODIGO_MUNICIPIOLabel"
        CODIGO_MUNICIPIOLabel.Size = New System.Drawing.Size(135, 13)
        CODIGO_MUNICIPIOLabel.TabIndex = 6
        CODIGO_MUNICIPIOLabel.Text = "Codigo municipio:"
        '
        'CODIGO_REGIONLabel
        '
        CODIGO_REGIONLabel.Location = New System.Drawing.Point(6, 118)
        CODIGO_REGIONLabel.Name = "CODIGO_REGIONLabel"
        CODIGO_REGIONLabel.Size = New System.Drawing.Size(135, 13)
        CODIGO_REGIONLabel.TabIndex = 8
        CODIGO_REGIONLabel.Text = "Codigo region:"
        '
        'CODIGO_DEPARTAMENTOLabel
        '
        CODIGO_DEPARTAMENTOLabel.Location = New System.Drawing.Point(6, 144)
        CODIGO_DEPARTAMENTOLabel.Name = "CODIGO_DEPARTAMENTOLabel"
        CODIGO_DEPARTAMENTOLabel.Size = New System.Drawing.Size(135, 13)
        CODIGO_DEPARTAMENTOLabel.TabIndex = 10
        CODIGO_DEPARTAMENTOLabel.Text = "Codigo departamento:"
        '
        'NOMBRE_FACILITADORLabel
        '
        NOMBRE_FACILITADORLabel.Location = New System.Drawing.Point(6, 170)
        NOMBRE_FACILITADORLabel.Name = "NOMBRE_FACILITADORLabel"
        NOMBRE_FACILITADORLabel.Size = New System.Drawing.Size(135, 13)
        NOMBRE_FACILITADORLabel.TabIndex = 12
        NOMBRE_FACILITADORLabel.Text = "Nombre facilitador:"
        '
        'NITLabel
        '
        NITLabel.Location = New System.Drawing.Point(6, 196)
        NITLabel.Name = "NITLabel"
        NITLabel.Size = New System.Drawing.Size(135, 13)
        NITLabel.TabIndex = 14
        NITLabel.Text = "Nit:"
        '
        'DUILabel
        '
        DUILabel.Location = New System.Drawing.Point(6, 222)
        DUILabel.Name = "DUILabel"
        DUILabel.Size = New System.Drawing.Size(135, 13)
        DUILabel.TabIndex = 16
        DUILabel.Text = "Dui:"
        '
        'ISSSLabel
        '
        ISSSLabel.Location = New System.Drawing.Point(6, 248)
        ISSSLabel.Name = "ISSSLabel"
        ISSSLabel.Size = New System.Drawing.Size(135, 13)
        ISSSLabel.TabIndex = 18
        ISSSLabel.Text = "Isss:"
        '
        'FECHA_INGRESOLabel
        '
        FECHA_INGRESOLabel.Location = New System.Drawing.Point(6, 274)
        FECHA_INGRESOLabel.Name = "FECHA_INGRESOLabel"
        FECHA_INGRESOLabel.Size = New System.Drawing.Size(135, 13)
        FECHA_INGRESOLabel.TabIndex = 20
        FECHA_INGRESOLabel.Text = "Fecha ingreso:"
        '
        'TELEFONOLabel
        '
        TELEFONOLabel.Location = New System.Drawing.Point(6, 300)
        TELEFONOLabel.Name = "TELEFONOLabel"
        TELEFONOLabel.Size = New System.Drawing.Size(135, 13)
        TELEFONOLabel.TabIndex = 22
        TELEFONOLabel.Text = "Telefono:"
        '
        'EMAILLabel
        '
        EMAILLabel.Location = New System.Drawing.Point(6, 326)
        EMAILLabel.Name = "EMAILLabel"
        EMAILLabel.Size = New System.Drawing.Size(135, 13)
        EMAILLabel.TabIndex = 24
        EMAILLabel.Text = "Email:"
        '
        'DIRECCIONLabel
        '
        DIRECCIONLabel.Location = New System.Drawing.Point(6, 352)
        DIRECCIONLabel.Name = "DIRECCIONLabel"
        DIRECCIONLabel.Size = New System.Drawing.Size(135, 13)
        DIRECCIONLabel.TabIndex = 26
        DIRECCIONLabel.Text = "Direccion:"
        '
        'NOTASLabel
        '
        NOTASLabel.Location = New System.Drawing.Point(6, 378)
        NOTASLabel.Name = "NOTASLabel"
        NOTASLabel.Size = New System.Drawing.Size(135, 13)
        NOTASLabel.TabIndex = 28
        NOTASLabel.Text = "Notas:"
        '
        'USERIDLabel
        '
        USERIDLabel.Location = New System.Drawing.Point(6, 404)
        USERIDLabel.Name = "USERIDLabel"
        USERIDLabel.Size = New System.Drawing.Size(135, 13)
        USERIDLabel.TabIndex = 30
        USERIDLabel.Text = "Userid:"
        '
        'LASTUPDATELabel
        '
        LASTUPDATELabel.Location = New System.Drawing.Point(6, 430)
        LASTUPDATELabel.Name = "LASTUPDATELabel"
        LASTUPDATELabel.Size = New System.Drawing.Size(135, 13)
        LASTUPDATELabel.TabIndex = 32
        LASTUPDATELabel.Text = "Lastupdate:"
        '
        'ListaFACILITADOR_CAPACITADORBindingSource
        '
        Me.ListaFACILITADOR_CAPACITADORBindingSource.DataSource = GetType(SGAFP.EL.FACILITADOR_CAPACITADOR)
        '
        'ID_FACILITADORTextBox
        '
        Me.ID_FACILITADORTextBox.BackColor = System.Drawing.Color.Linen
        Me.ID_FACILITADORTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaFACILITADOR_CAPACITADORBindingSource, "ID_FACILITADOR", True))
        Me.ID_FACILITADORTextBox.Location = New System.Drawing.Point(144, 8)
        Me.ID_FACILITADORTextBox.Name = "ID_FACILITADORTextBox"
        Me.ID_FACILITADORTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ID_FACILITADORTextBox.TabIndex = 1
        Me.ID_FACILITADORTextBox.ReadOnly = True
        '
        'ID_TIPO_PERSONAcbxTIPO_PERSONA
        '
        Me.ID_TIPO_PERSONAcbxTIPO_PERSONA.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ListaFACILITADOR_CAPACITADORBindingSource, "ID_TIPO_PERSONA", True))
        Me.ID_TIPO_PERSONAcbxTIPO_PERSONA.Location = New System.Drawing.Point(144, 34)
        Me.ID_TIPO_PERSONAcbxTIPO_PERSONA.Name = "ID_TIPO_PERSONAcbxTIPO_PERSONA"
        Me.ID_TIPO_PERSONAcbxTIPO_PERSONA.Size = New System.Drawing.Size(200, 20)
        Me.ID_TIPO_PERSONAcbxTIPO_PERSONA.TabIndex = 3
        '
        'ID_PROVEEDOR_AFcbxPROVEEDOR_AF
        '
        Me.ID_PROVEEDOR_AFcbxPROVEEDOR_AF.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ListaFACILITADOR_CAPACITADORBindingSource, "ID_PROVEEDOR_AF", True))
        Me.ID_PROVEEDOR_AFcbxPROVEEDOR_AF.Location = New System.Drawing.Point(144, 60)
        Me.ID_PROVEEDOR_AFcbxPROVEEDOR_AF.Name = "ID_PROVEEDOR_AFcbxPROVEEDOR_AF"
        Me.ID_PROVEEDOR_AFcbxPROVEEDOR_AF.Size = New System.Drawing.Size(200, 20)
        Me.ID_PROVEEDOR_AFcbxPROVEEDOR_AF.TabIndex = 5
        '
        'CODIGO_MUNICIPIOcbxMUNICIPIO
        '
        Me.CODIGO_MUNICIPIOcbxMUNICIPIO.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ListaFACILITADOR_CAPACITADORBindingSource, "CODIGO_MUNICIPIO", True))
        Me.CODIGO_MUNICIPIOcbxMUNICIPIO.Location = New System.Drawing.Point(144, 86)
        Me.CODIGO_MUNICIPIOcbxMUNICIPIO.Name = "CODIGO_MUNICIPIOcbxMUNICIPIO"
        Me.CODIGO_MUNICIPIOcbxMUNICIPIO.Size = New System.Drawing.Size(200, 20)
        Me.CODIGO_MUNICIPIOcbxMUNICIPIO.TabIndex = 7
        '
        'CODIGO_REGIONcbxREGION
        '
        Me.CODIGO_REGIONcbxREGION.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ListaFACILITADOR_CAPACITADORBindingSource, "CODIGO_REGION", True))
        Me.CODIGO_REGIONcbxREGION.Location = New System.Drawing.Point(144, 112)
        Me.CODIGO_REGIONcbxREGION.Name = "CODIGO_REGIONcbxREGION"
        Me.CODIGO_REGIONcbxREGION.Size = New System.Drawing.Size(200, 20)
        Me.CODIGO_REGIONcbxREGION.TabIndex = 9
        '
        'CODIGO_DEPARTAMENTOcbxDEPARTAMENTO
        '
        Me.CODIGO_DEPARTAMENTOcbxDEPARTAMENTO.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ListaFACILITADOR_CAPACITADORBindingSource, "CODIGO_DEPARTAMENTO", True))
        Me.CODIGO_DEPARTAMENTOcbxDEPARTAMENTO.Location = New System.Drawing.Point(144, 138)
        Me.CODIGO_DEPARTAMENTOcbxDEPARTAMENTO.Name = "CODIGO_DEPARTAMENTOcbxDEPARTAMENTO"
        Me.CODIGO_DEPARTAMENTOcbxDEPARTAMENTO.Size = New System.Drawing.Size(200, 20)
        Me.CODIGO_DEPARTAMENTOcbxDEPARTAMENTO.TabIndex = 11
        '
        'NOMBRE_FACILITADORTextBox
        '
        Me.NOMBRE_FACILITADORTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaFACILITADOR_CAPACITADORBindingSource, "NOMBRE_FACILITADOR", True))
        Me.NOMBRE_FACILITADORTextBox.Location = New System.Drawing.Point(144, 164)
        Me.NOMBRE_FACILITADORTextBox.Name = "NOMBRE_FACILITADORTextBox"
        Me.NOMBRE_FACILITADORTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NOMBRE_FACILITADORTextBox.TabIndex = 13
        Me.NOMBRE_FACILITADORTextBox.MaxLength = 100
        '
        'NITTextBox
        '
        Me.NITTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaFACILITADOR_CAPACITADORBindingSource, "NIT", True))
        Me.NITTextBox.Location = New System.Drawing.Point(144, 190)
        Me.NITTextBox.Name = "NITTextBox"
        Me.NITTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NITTextBox.TabIndex = 15
        Me.NITTextBox.MaxLength = 14
        '
        'DUITextBox
        '
        Me.DUITextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaFACILITADOR_CAPACITADORBindingSource, "DUI", True))
        Me.DUITextBox.Location = New System.Drawing.Point(144, 216)
        Me.DUITextBox.Name = "DUITextBox"
        Me.DUITextBox.Size = New System.Drawing.Size(200, 20)
        Me.DUITextBox.TabIndex = 17
        Me.DUITextBox.MaxLength = 9
        '
        'ISSSTextBox
        '
        Me.ISSSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaFACILITADOR_CAPACITADORBindingSource, "ISSS", True))
        Me.ISSSTextBox.Location = New System.Drawing.Point(144, 242)
        Me.ISSSTextBox.Name = "ISSSTextBox"
        Me.ISSSTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ISSSTextBox.TabIndex = 19
        Me.ISSSTextBox.MaxLength = 9
        '
        'FECHA_INGRESODateTimePicker
        '
        Me.FECHA_INGRESODateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ListaFACILITADOR_CAPACITADORBindingSource, "FECHA_INGRESO", True))
        Me.FECHA_INGRESODateTimePicker.Location = New System.Drawing.Point(144, 268)
        Me.FECHA_INGRESODateTimePicker.Name = "FECHA_INGRESODateTimePicker"
        Me.FECHA_INGRESODateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.FECHA_INGRESODateTimePicker.TabIndex = 21
        '
        'TELEFONOTextBox
        '
        Me.TELEFONOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaFACILITADOR_CAPACITADORBindingSource, "TELEFONO", True))
        Me.TELEFONOTextBox.Location = New System.Drawing.Point(144, 294)
        Me.TELEFONOTextBox.Name = "TELEFONOTextBox"
        Me.TELEFONOTextBox.Size = New System.Drawing.Size(200, 20)
        Me.TELEFONOTextBox.TabIndex = 23
        Me.TELEFONOTextBox.MaxLength = 8
        '
        'EMAILTextBox
        '
        Me.EMAILTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaFACILITADOR_CAPACITADORBindingSource, "EMAIL", True))
        Me.EMAILTextBox.Location = New System.Drawing.Point(144, 320)
        Me.EMAILTextBox.Name = "EMAILTextBox"
        Me.EMAILTextBox.Size = New System.Drawing.Size(200, 20)
        Me.EMAILTextBox.TabIndex = 25
        Me.EMAILTextBox.MaxLength = 50
        '
        'DIRECCIONTextBox
        '
        Me.DIRECCIONTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaFACILITADOR_CAPACITADORBindingSource, "DIRECCION", True))
        Me.DIRECCIONTextBox.Location = New System.Drawing.Point(144, 346)
        Me.DIRECCIONTextBox.Name = "DIRECCIONTextBox"
        Me.DIRECCIONTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DIRECCIONTextBox.TabIndex = 27
        Me.DIRECCIONTextBox.MaxLength = 150
        '
        'NOTASTextBox
        '
        Me.NOTASTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaFACILITADOR_CAPACITADORBindingSource, "NOTAS", True))
        Me.NOTASTextBox.Location = New System.Drawing.Point(144, 372)
        Me.NOTASTextBox.Name = "NOTASTextBox"
        Me.NOTASTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NOTASTextBox.TabIndex = 29
        Me.NOTASTextBox.MaxLength = 255
        '
        'USERIDTextBox
        '
        Me.USERIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaFACILITADOR_CAPACITADORBindingSource, "USERID", True))
        Me.USERIDTextBox.Location = New System.Drawing.Point(144, 398)
        Me.USERIDTextBox.Name = "USERIDTextBox"
        Me.USERIDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.USERIDTextBox.TabIndex = 31
        Me.USERIDTextBox.MaxLength = 16
        '
        'LASTUPDATEDateTimePicker
        '
        Me.LASTUPDATEDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ListaFACILITADOR_CAPACITADORBindingSource, "LASTUPDATE", True))
        Me.LASTUPDATEDateTimePicker.Location = New System.Drawing.Point(144, 424)
        Me.LASTUPDATEDateTimePicker.Name = "LASTUPDATEDateTimePicker"
        Me.LASTUPDATEDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.LASTUPDATEDateTimePicker.TabIndex = 33
        '
        'ucDetalleFACILITADOR_CAPACITADOR
        '
        Me.AutoScroll = True
        Me.Controls.Add(ID_FACILITADORLabel)
        Me.Controls.Add(Me.ID_FACILITADORTextBox)
        Me.Controls.Add(ID_TIPO_PERSONALabel)
        Me.Controls.Add(Me.ID_TIPO_PERSONAcbxTIPO_PERSONA)
        Me.Controls.Add(ID_PROVEEDOR_AFLabel)
        Me.Controls.Add(Me.ID_PROVEEDOR_AFcbxPROVEEDOR_AF)
        Me.Controls.Add(CODIGO_MUNICIPIOLabel)
        Me.Controls.Add(Me.CODIGO_MUNICIPIOcbxMUNICIPIO)
        Me.Controls.Add(CODIGO_REGIONLabel)
        Me.Controls.Add(Me.CODIGO_REGIONcbxREGION)
        Me.Controls.Add(CODIGO_DEPARTAMENTOLabel)
        Me.Controls.Add(Me.CODIGO_DEPARTAMENTOcbxDEPARTAMENTO)
        Me.Controls.Add(NOMBRE_FACILITADORLabel)
        Me.Controls.Add(Me.NOMBRE_FACILITADORTextBox)
        Me.Controls.Add(NITLabel)
        Me.Controls.Add(Me.NITTextBox)
        Me.Controls.Add(DUILabel)
        Me.Controls.Add(Me.DUITextBox)
        Me.Controls.Add(ISSSLabel)
        Me.Controls.Add(Me.ISSSTextBox)
        Me.Controls.Add(FECHA_INGRESOLabel)
        Me.Controls.Add(Me.FECHA_INGRESODateTimePicker)
        Me.Controls.Add(TELEFONOLabel)
        Me.Controls.Add(Me.TELEFONOTextBox)
        Me.Controls.Add(EMAILLabel)
        Me.Controls.Add(Me.EMAILTextBox)
        Me.Controls.Add(DIRECCIONLabel)
        Me.Controls.Add(Me.DIRECCIONTextBox)
        Me.Controls.Add(NOTASLabel)
        Me.Controls.Add(Me.NOTASTextBox)
        Me.Controls.Add(USERIDLabel)
        Me.Controls.Add(Me.USERIDTextBox)
        Me.Controls.Add(LASTUPDATELabel)
        Me.Controls.Add(Me.LASTUPDATEDateTimePicker)
        Me.Name = "ucDetalleFACILITADOR_CAPACITADOR"
        Me.Size = New System.Drawing.Size(382, 476)
        CType(Me.ListaFACILITADOR_CAPACITADORBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaFACILITADOR_CAPACITADORBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ID_FACILITADORTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ID_TIPO_PERSONAcbxTIPO_PERSONA As SGAFP.WinUC.cbxTIPO_PERSONA
    Friend WithEvents ID_PROVEEDOR_AFcbxPROVEEDOR_AF As SGAFP.WinUC.cbxPROVEEDOR_AF
    Friend WithEvents CODIGO_MUNICIPIOcbxMUNICIPIO As SGAFP.WinUC.cbxMUNICIPIO
    Friend WithEvents CODIGO_REGIONcbxREGION As SGAFP.WinUC.cbxREGION
    Friend WithEvents CODIGO_DEPARTAMENTOcbxDEPARTAMENTO As SGAFP.WinUC.cbxDEPARTAMENTO
    Friend WithEvents NOMBRE_FACILITADORTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NITTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DUITextBox As System.Windows.Forms.TextBox
    Friend WithEvents ISSSTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FECHA_INGRESODateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents TELEFONOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EMAILTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DIRECCIONTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NOTASTextBox As System.Windows.Forms.TextBox
    Friend WithEvents USERIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LASTUPDATEDateTimePicker As System.Windows.Forms.DateTimePicker

End Class
