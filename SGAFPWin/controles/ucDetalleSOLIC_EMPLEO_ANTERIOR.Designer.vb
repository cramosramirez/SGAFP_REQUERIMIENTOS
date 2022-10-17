<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucDetalleSOLIC_EMPLEO_ANTERIOR
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
        Dim ID_EMPLEO_ANTLabel As System.Windows.Forms.Label
        Dim ID_SOLICITUDLabel As System.Windows.Forms.Label
        Dim NOMBRE_EMPRESALabel As System.Windows.Forms.Label
        Dim DIRECCIONLabel As System.Windows.Forms.Label
        Dim ZONALabel As System.Windows.Forms.Label
        Dim TELEFONOLabel As System.Windows.Forms.Label
        Dim FAXLabel As System.Windows.Forms.Label
        Dim EMAILLabel As System.Windows.Forms.Label
        Dim ISSSLabel As System.Windows.Forms.Label
        Dim JEFE_INMEDIATOLabel As System.Windows.Forms.Label
        Dim ACTIVIDAD_ECONOMICALabel As System.Windows.Forms.Label
        Dim PUESTO_CONTRATADOLabel As System.Windows.Forms.Label
        Dim PUESTO_ACTUALLabel As System.Windows.Forms.Label
        Dim TIEMPO_TRABAJOLabel As System.Windows.Forms.Label
        Dim AREA_TRABAJOLabel As System.Windows.Forms.Label
        Dim AREA_OTROLabel As System.Windows.Forms.Label
        Dim CODIGO_MUNICIPIOLabel As System.Windows.Forms.Label
        Dim CODIGO_REGIONLabel As System.Windows.Forms.Label
        Dim CODIGO_DEPARTAMENTOLabel As System.Windows.Forms.Label
        Me.ListaSOLIC_EMPLEO_ANTERIORBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ID_EMPLEO_ANTTextBox = New System.Windows.Forms.TextBox
        Me.ID_SOLICITUDcbxSOLICITUD_INSCRIPCION_AF = New SGAFP.WinUC.cbxSOLICITUD_INSCRIPCION_AF
        Me.NOMBRE_EMPRESATextBox = New System.Windows.Forms.TextBox
        Me.DIRECCIONTextBox = New System.Windows.Forms.TextBox
        Me.ZONATextBox = New System.Windows.Forms.TextBox
        Me.TELEFONOTextBox = New System.Windows.Forms.TextBox
        Me.FAXTextBox = New System.Windows.Forms.TextBox
        Me.EMAILTextBox = New System.Windows.Forms.TextBox
        Me.ISSSTextBox = New System.Windows.Forms.TextBox
        Me.JEFE_INMEDIATOTextBox = New System.Windows.Forms.TextBox
        Me.ACTIVIDAD_ECONOMICAcbxCIUU = New SGAFP.WinUC.cbxCIUU
        Me.PUESTO_CONTRATADOTextBox = New System.Windows.Forms.TextBox
        Me.PUESTO_ACTUALTextBox = New System.Windows.Forms.TextBox
        Me.TIEMPO_TRABAJOTextBox = New System.Windows.Forms.TextBox
        Me.AREA_TRABAJOTextBox = New System.Windows.Forms.TextBox
        Me.AREA_OTROTextBox = New System.Windows.Forms.TextBox
        Me.CODIGO_MUNICIPIOcbxMUNICIPIO = New SGAFP.WinUC.cbxMUNICIPIO
        Me.CODIGO_REGIONcbxREGION = New SGAFP.WinUC.cbxREGION
        Me.CODIGO_DEPARTAMENTOcbxDEPARTAMENTO = New SGAFP.WinUC.cbxDEPARTAMENTO
        ID_EMPLEO_ANTLabel = New System.Windows.Forms.Label
        ID_SOLICITUDLabel = New System.Windows.Forms.Label
        NOMBRE_EMPRESALabel = New System.Windows.Forms.Label
        DIRECCIONLabel = New System.Windows.Forms.Label
        ZONALabel = New System.Windows.Forms.Label
        TELEFONOLabel = New System.Windows.Forms.Label
        FAXLabel = New System.Windows.Forms.Label
        EMAILLabel = New System.Windows.Forms.Label
        ISSSLabel = New System.Windows.Forms.Label
        JEFE_INMEDIATOLabel = New System.Windows.Forms.Label
        ACTIVIDAD_ECONOMICALabel = New System.Windows.Forms.Label
        PUESTO_CONTRATADOLabel = New System.Windows.Forms.Label
        PUESTO_ACTUALLabel = New System.Windows.Forms.Label
        TIEMPO_TRABAJOLabel = New System.Windows.Forms.Label
        AREA_TRABAJOLabel = New System.Windows.Forms.Label
        AREA_OTROLabel = New System.Windows.Forms.Label
        CODIGO_MUNICIPIOLabel = New System.Windows.Forms.Label
        CODIGO_REGIONLabel = New System.Windows.Forms.Label
        CODIGO_DEPARTAMENTOLabel = New System.Windows.Forms.Label
        CType(Me.ListaSOLIC_EMPLEO_ANTERIORBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ID_EMPLEO_ANTLabel
        '
        ID_EMPLEO_ANTLabel.Location = New System.Drawing.Point(6, 14)
        ID_EMPLEO_ANTLabel.Name = "ID_EMPLEO_ANTLabel"
        ID_EMPLEO_ANTLabel.Size = New System.Drawing.Size(135, 13)
        ID_EMPLEO_ANTLabel.TabIndex = 0
        ID_EMPLEO_ANTLabel.Text = "Id empleo ant:"
        '
        'ID_SOLICITUDLabel
        '
        ID_SOLICITUDLabel.Location = New System.Drawing.Point(6, 40)
        ID_SOLICITUDLabel.Name = "ID_SOLICITUDLabel"
        ID_SOLICITUDLabel.Size = New System.Drawing.Size(135, 13)
        ID_SOLICITUDLabel.TabIndex = 2
        ID_SOLICITUDLabel.Text = "Id solicitud:"
        '
        'NOMBRE_EMPRESALabel
        '
        NOMBRE_EMPRESALabel.Location = New System.Drawing.Point(6, 66)
        NOMBRE_EMPRESALabel.Name = "NOMBRE_EMPRESALabel"
        NOMBRE_EMPRESALabel.Size = New System.Drawing.Size(135, 13)
        NOMBRE_EMPRESALabel.TabIndex = 4
        NOMBRE_EMPRESALabel.Text = "Nombre empresa:"
        '
        'DIRECCIONLabel
        '
        DIRECCIONLabel.Location = New System.Drawing.Point(6, 92)
        DIRECCIONLabel.Name = "DIRECCIONLabel"
        DIRECCIONLabel.Size = New System.Drawing.Size(135, 13)
        DIRECCIONLabel.TabIndex = 6
        DIRECCIONLabel.Text = "Direccion:"
        '
        'ZONALabel
        '
        ZONALabel.Location = New System.Drawing.Point(6, 118)
        ZONALabel.Name = "ZONALabel"
        ZONALabel.Size = New System.Drawing.Size(135, 13)
        ZONALabel.TabIndex = 8
        ZONALabel.Text = "Zona:"
        '
        'TELEFONOLabel
        '
        TELEFONOLabel.Location = New System.Drawing.Point(6, 144)
        TELEFONOLabel.Name = "TELEFONOLabel"
        TELEFONOLabel.Size = New System.Drawing.Size(135, 13)
        TELEFONOLabel.TabIndex = 10
        TELEFONOLabel.Text = "Telefono:"
        '
        'FAXLabel
        '
        FAXLabel.Location = New System.Drawing.Point(6, 170)
        FAXLabel.Name = "FAXLabel"
        FAXLabel.Size = New System.Drawing.Size(135, 13)
        FAXLabel.TabIndex = 12
        FAXLabel.Text = "Fax:"
        '
        'EMAILLabel
        '
        EMAILLabel.Location = New System.Drawing.Point(6, 196)
        EMAILLabel.Name = "EMAILLabel"
        EMAILLabel.Size = New System.Drawing.Size(135, 13)
        EMAILLabel.TabIndex = 14
        EMAILLabel.Text = "Email:"
        '
        'ISSSLabel
        '
        ISSSLabel.Location = New System.Drawing.Point(6, 222)
        ISSSLabel.Name = "ISSSLabel"
        ISSSLabel.Size = New System.Drawing.Size(135, 13)
        ISSSLabel.TabIndex = 16
        ISSSLabel.Text = "Isss:"
        '
        'JEFE_INMEDIATOLabel
        '
        JEFE_INMEDIATOLabel.Location = New System.Drawing.Point(6, 248)
        JEFE_INMEDIATOLabel.Name = "JEFE_INMEDIATOLabel"
        JEFE_INMEDIATOLabel.Size = New System.Drawing.Size(135, 13)
        JEFE_INMEDIATOLabel.TabIndex = 18
        JEFE_INMEDIATOLabel.Text = "Jefe inmediato:"
        '
        'ACTIVIDAD_ECONOMICALabel
        '
        ACTIVIDAD_ECONOMICALabel.Location = New System.Drawing.Point(6, 274)
        ACTIVIDAD_ECONOMICALabel.Name = "ACTIVIDAD_ECONOMICALabel"
        ACTIVIDAD_ECONOMICALabel.Size = New System.Drawing.Size(135, 13)
        ACTIVIDAD_ECONOMICALabel.TabIndex = 20
        ACTIVIDAD_ECONOMICALabel.Text = "Actividad economica:"
        '
        'PUESTO_CONTRATADOLabel
        '
        PUESTO_CONTRATADOLabel.Location = New System.Drawing.Point(6, 300)
        PUESTO_CONTRATADOLabel.Name = "PUESTO_CONTRATADOLabel"
        PUESTO_CONTRATADOLabel.Size = New System.Drawing.Size(135, 13)
        PUESTO_CONTRATADOLabel.TabIndex = 22
        PUESTO_CONTRATADOLabel.Text = "Puesto contratado:"
        '
        'PUESTO_ACTUALLabel
        '
        PUESTO_ACTUALLabel.Location = New System.Drawing.Point(6, 326)
        PUESTO_ACTUALLabel.Name = "PUESTO_ACTUALLabel"
        PUESTO_ACTUALLabel.Size = New System.Drawing.Size(135, 13)
        PUESTO_ACTUALLabel.TabIndex = 24
        PUESTO_ACTUALLabel.Text = "Puesto actual:"
        '
        'TIEMPO_TRABAJOLabel
        '
        TIEMPO_TRABAJOLabel.Location = New System.Drawing.Point(6, 352)
        TIEMPO_TRABAJOLabel.Name = "TIEMPO_TRABAJOLabel"
        TIEMPO_TRABAJOLabel.Size = New System.Drawing.Size(135, 13)
        TIEMPO_TRABAJOLabel.TabIndex = 26
        TIEMPO_TRABAJOLabel.Text = "Tiempo trabajo:"
        '
        'AREA_TRABAJOLabel
        '
        AREA_TRABAJOLabel.Location = New System.Drawing.Point(6, 378)
        AREA_TRABAJOLabel.Name = "AREA_TRABAJOLabel"
        AREA_TRABAJOLabel.Size = New System.Drawing.Size(135, 13)
        AREA_TRABAJOLabel.TabIndex = 28
        AREA_TRABAJOLabel.Text = "Area trabajo:"
        '
        'AREA_OTROLabel
        '
        AREA_OTROLabel.Location = New System.Drawing.Point(6, 404)
        AREA_OTROLabel.Name = "AREA_OTROLabel"
        AREA_OTROLabel.Size = New System.Drawing.Size(135, 13)
        AREA_OTROLabel.TabIndex = 30
        AREA_OTROLabel.Text = "Area otro:"
        '
        'CODIGO_MUNICIPIOLabel
        '
        CODIGO_MUNICIPIOLabel.Location = New System.Drawing.Point(6, 430)
        CODIGO_MUNICIPIOLabel.Name = "CODIGO_MUNICIPIOLabel"
        CODIGO_MUNICIPIOLabel.Size = New System.Drawing.Size(135, 13)
        CODIGO_MUNICIPIOLabel.TabIndex = 32
        CODIGO_MUNICIPIOLabel.Text = "Codigo municipio:"
        '
        'CODIGO_REGIONLabel
        '
        CODIGO_REGIONLabel.Location = New System.Drawing.Point(6, 456)
        CODIGO_REGIONLabel.Name = "CODIGO_REGIONLabel"
        CODIGO_REGIONLabel.Size = New System.Drawing.Size(135, 13)
        CODIGO_REGIONLabel.TabIndex = 34
        CODIGO_REGIONLabel.Text = "Codigo region:"
        '
        'CODIGO_DEPARTAMENTOLabel
        '
        CODIGO_DEPARTAMENTOLabel.Location = New System.Drawing.Point(6, 482)
        CODIGO_DEPARTAMENTOLabel.Name = "CODIGO_DEPARTAMENTOLabel"
        CODIGO_DEPARTAMENTOLabel.Size = New System.Drawing.Size(135, 13)
        CODIGO_DEPARTAMENTOLabel.TabIndex = 36
        CODIGO_DEPARTAMENTOLabel.Text = "Codigo departamento:"
        '
        'ListaSOLIC_EMPLEO_ANTERIORBindingSource
        '
        Me.ListaSOLIC_EMPLEO_ANTERIORBindingSource.DataSource = GetType(SGAFP.EL.SOLIC_EMPLEO_ANTERIOR)
        '
        'ID_EMPLEO_ANTTextBox
        '
        Me.ID_EMPLEO_ANTTextBox.BackColor = System.Drawing.Color.Linen
        Me.ID_EMPLEO_ANTTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaSOLIC_EMPLEO_ANTERIORBindingSource, "ID_EMPLEO_ANT", True))
        Me.ID_EMPLEO_ANTTextBox.Location = New System.Drawing.Point(144, 8)
        Me.ID_EMPLEO_ANTTextBox.Name = "ID_EMPLEO_ANTTextBox"
        Me.ID_EMPLEO_ANTTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ID_EMPLEO_ANTTextBox.TabIndex = 1
        Me.ID_EMPLEO_ANTTextBox.ReadOnly = True
        '
        'ID_SOLICITUDcbxSOLICITUD_INSCRIPCION_AF
        '
        Me.ID_SOLICITUDcbxSOLICITUD_INSCRIPCION_AF.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ListaSOLIC_EMPLEO_ANTERIORBindingSource, "ID_SOLICITUD", True))
        Me.ID_SOLICITUDcbxSOLICITUD_INSCRIPCION_AF.Location = New System.Drawing.Point(144, 34)
        Me.ID_SOLICITUDcbxSOLICITUD_INSCRIPCION_AF.Name = "ID_SOLICITUDcbxSOLICITUD_INSCRIPCION_AF"
        Me.ID_SOLICITUDcbxSOLICITUD_INSCRIPCION_AF.Size = New System.Drawing.Size(200, 20)
        Me.ID_SOLICITUDcbxSOLICITUD_INSCRIPCION_AF.TabIndex = 3
        '
        'NOMBRE_EMPRESATextBox
        '
        Me.NOMBRE_EMPRESATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaSOLIC_EMPLEO_ANTERIORBindingSource, "NOMBRE_EMPRESA", True))
        Me.NOMBRE_EMPRESATextBox.Location = New System.Drawing.Point(144, 60)
        Me.NOMBRE_EMPRESATextBox.Name = "NOMBRE_EMPRESATextBox"
        Me.NOMBRE_EMPRESATextBox.Size = New System.Drawing.Size(200, 20)
        Me.NOMBRE_EMPRESATextBox.TabIndex = 5
        Me.NOMBRE_EMPRESATextBox.MaxLength = 100
        '
        'DIRECCIONTextBox
        '
        Me.DIRECCIONTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaSOLIC_EMPLEO_ANTERIORBindingSource, "DIRECCION", True))
        Me.DIRECCIONTextBox.Location = New System.Drawing.Point(144, 86)
        Me.DIRECCIONTextBox.Name = "DIRECCIONTextBox"
        Me.DIRECCIONTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DIRECCIONTextBox.TabIndex = 7
        Me.DIRECCIONTextBox.MaxLength = 150
        '
        'ZONATextBox
        '
        Me.ZONATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaSOLIC_EMPLEO_ANTERIORBindingSource, "ZONA", True))
        Me.ZONATextBox.Location = New System.Drawing.Point(144, 112)
        Me.ZONATextBox.Name = "ZONATextBox"
        Me.ZONATextBox.Size = New System.Drawing.Size(200, 20)
        Me.ZONATextBox.TabIndex = 9
        '
        'TELEFONOTextBox
        '
        Me.TELEFONOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaSOLIC_EMPLEO_ANTERIORBindingSource, "TELEFONO", True))
        Me.TELEFONOTextBox.Location = New System.Drawing.Point(144, 138)
        Me.TELEFONOTextBox.Name = "TELEFONOTextBox"
        Me.TELEFONOTextBox.Size = New System.Drawing.Size(200, 20)
        Me.TELEFONOTextBox.TabIndex = 11
        Me.TELEFONOTextBox.MaxLength = 8
        '
        'FAXTextBox
        '
        Me.FAXTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaSOLIC_EMPLEO_ANTERIORBindingSource, "FAX", True))
        Me.FAXTextBox.Location = New System.Drawing.Point(144, 164)
        Me.FAXTextBox.Name = "FAXTextBox"
        Me.FAXTextBox.Size = New System.Drawing.Size(200, 20)
        Me.FAXTextBox.TabIndex = 13
        Me.FAXTextBox.MaxLength = 8
        '
        'EMAILTextBox
        '
        Me.EMAILTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaSOLIC_EMPLEO_ANTERIORBindingSource, "EMAIL", True))
        Me.EMAILTextBox.Location = New System.Drawing.Point(144, 190)
        Me.EMAILTextBox.Name = "EMAILTextBox"
        Me.EMAILTextBox.Size = New System.Drawing.Size(200, 20)
        Me.EMAILTextBox.TabIndex = 15
        Me.EMAILTextBox.MaxLength = 50
        '
        'ISSSTextBox
        '
        Me.ISSSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaSOLIC_EMPLEO_ANTERIORBindingSource, "ISSS", True))
        Me.ISSSTextBox.Location = New System.Drawing.Point(144, 216)
        Me.ISSSTextBox.Name = "ISSSTextBox"
        Me.ISSSTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ISSSTextBox.TabIndex = 17
        Me.ISSSTextBox.MaxLength = 9
        '
        'JEFE_INMEDIATOTextBox
        '
        Me.JEFE_INMEDIATOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaSOLIC_EMPLEO_ANTERIORBindingSource, "JEFE_INMEDIATO", True))
        Me.JEFE_INMEDIATOTextBox.Location = New System.Drawing.Point(144, 242)
        Me.JEFE_INMEDIATOTextBox.Name = "JEFE_INMEDIATOTextBox"
        Me.JEFE_INMEDIATOTextBox.Size = New System.Drawing.Size(200, 20)
        Me.JEFE_INMEDIATOTextBox.TabIndex = 19
        Me.JEFE_INMEDIATOTextBox.MaxLength = 60
        '
        'ACTIVIDAD_ECONOMICAcbxCIUU
        '
        Me.ACTIVIDAD_ECONOMICAcbxCIUU.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ListaSOLIC_EMPLEO_ANTERIORBindingSource, "ACTIVIDAD_ECONOMICA", True))
        Me.ACTIVIDAD_ECONOMICAcbxCIUU.Location = New System.Drawing.Point(144, 268)
        Me.ACTIVIDAD_ECONOMICAcbxCIUU.Name = "ACTIVIDAD_ECONOMICAcbxCIUU"
        Me.ACTIVIDAD_ECONOMICAcbxCIUU.Size = New System.Drawing.Size(200, 20)
        Me.ACTIVIDAD_ECONOMICAcbxCIUU.TabIndex = 21
        '
        'PUESTO_CONTRATADOTextBox
        '
        Me.PUESTO_CONTRATADOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaSOLIC_EMPLEO_ANTERIORBindingSource, "PUESTO_CONTRATADO", True))
        Me.PUESTO_CONTRATADOTextBox.Location = New System.Drawing.Point(144, 294)
        Me.PUESTO_CONTRATADOTextBox.Name = "PUESTO_CONTRATADOTextBox"
        Me.PUESTO_CONTRATADOTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PUESTO_CONTRATADOTextBox.TabIndex = 23
        Me.PUESTO_CONTRATADOTextBox.MaxLength = 80
        '
        'PUESTO_ACTUALTextBox
        '
        Me.PUESTO_ACTUALTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaSOLIC_EMPLEO_ANTERIORBindingSource, "PUESTO_ACTUAL", True))
        Me.PUESTO_ACTUALTextBox.Location = New System.Drawing.Point(144, 320)
        Me.PUESTO_ACTUALTextBox.Name = "PUESTO_ACTUALTextBox"
        Me.PUESTO_ACTUALTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PUESTO_ACTUALTextBox.TabIndex = 25
        Me.PUESTO_ACTUALTextBox.MaxLength = 80
        '
        'TIEMPO_TRABAJOTextBox
        '
        Me.TIEMPO_TRABAJOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaSOLIC_EMPLEO_ANTERIORBindingSource, "TIEMPO_TRABAJO", True))
        Me.TIEMPO_TRABAJOTextBox.Location = New System.Drawing.Point(144, 346)
        Me.TIEMPO_TRABAJOTextBox.Name = "TIEMPO_TRABAJOTextBox"
        Me.TIEMPO_TRABAJOTextBox.Size = New System.Drawing.Size(200, 20)
        Me.TIEMPO_TRABAJOTextBox.TabIndex = 27
        '
        'AREA_TRABAJOTextBox
        '
        Me.AREA_TRABAJOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaSOLIC_EMPLEO_ANTERIORBindingSource, "AREA_TRABAJO", True))
        Me.AREA_TRABAJOTextBox.Location = New System.Drawing.Point(144, 372)
        Me.AREA_TRABAJOTextBox.Name = "AREA_TRABAJOTextBox"
        Me.AREA_TRABAJOTextBox.Size = New System.Drawing.Size(200, 20)
        Me.AREA_TRABAJOTextBox.TabIndex = 29
        '
        'AREA_OTROTextBox
        '
        Me.AREA_OTROTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaSOLIC_EMPLEO_ANTERIORBindingSource, "AREA_OTRO", True))
        Me.AREA_OTROTextBox.Location = New System.Drawing.Point(144, 398)
        Me.AREA_OTROTextBox.Name = "AREA_OTROTextBox"
        Me.AREA_OTROTextBox.Size = New System.Drawing.Size(200, 20)
        Me.AREA_OTROTextBox.TabIndex = 31
        Me.AREA_OTROTextBox.MaxLength = 60
        '
        'CODIGO_MUNICIPIOcbxMUNICIPIO
        '
        Me.CODIGO_MUNICIPIOcbxMUNICIPIO.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ListaSOLIC_EMPLEO_ANTERIORBindingSource, "CODIGO_MUNICIPIO", True))
        Me.CODIGO_MUNICIPIOcbxMUNICIPIO.Location = New System.Drawing.Point(144, 424)
        Me.CODIGO_MUNICIPIOcbxMUNICIPIO.Name = "CODIGO_MUNICIPIOcbxMUNICIPIO"
        Me.CODIGO_MUNICIPIOcbxMUNICIPIO.Size = New System.Drawing.Size(200, 20)
        Me.CODIGO_MUNICIPIOcbxMUNICIPIO.TabIndex = 33
        '
        'CODIGO_REGIONcbxREGION
        '
        Me.CODIGO_REGIONcbxREGION.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ListaSOLIC_EMPLEO_ANTERIORBindingSource, "CODIGO_REGION", True))
        Me.CODIGO_REGIONcbxREGION.Location = New System.Drawing.Point(144, 450)
        Me.CODIGO_REGIONcbxREGION.Name = "CODIGO_REGIONcbxREGION"
        Me.CODIGO_REGIONcbxREGION.Size = New System.Drawing.Size(200, 20)
        Me.CODIGO_REGIONcbxREGION.TabIndex = 35
        '
        'CODIGO_DEPARTAMENTOcbxDEPARTAMENTO
        '
        Me.CODIGO_DEPARTAMENTOcbxDEPARTAMENTO.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ListaSOLIC_EMPLEO_ANTERIORBindingSource, "CODIGO_DEPARTAMENTO", True))
        Me.CODIGO_DEPARTAMENTOcbxDEPARTAMENTO.Location = New System.Drawing.Point(144, 476)
        Me.CODIGO_DEPARTAMENTOcbxDEPARTAMENTO.Name = "CODIGO_DEPARTAMENTOcbxDEPARTAMENTO"
        Me.CODIGO_DEPARTAMENTOcbxDEPARTAMENTO.Size = New System.Drawing.Size(200, 20)
        Me.CODIGO_DEPARTAMENTOcbxDEPARTAMENTO.TabIndex = 37
        '
        'ucDetalleSOLIC_EMPLEO_ANTERIOR
        '
        Me.AutoScroll = True
        Me.Controls.Add(ID_EMPLEO_ANTLabel)
        Me.Controls.Add(Me.ID_EMPLEO_ANTTextBox)
        Me.Controls.Add(ID_SOLICITUDLabel)
        Me.Controls.Add(Me.ID_SOLICITUDcbxSOLICITUD_INSCRIPCION_AF)
        Me.Controls.Add(NOMBRE_EMPRESALabel)
        Me.Controls.Add(Me.NOMBRE_EMPRESATextBox)
        Me.Controls.Add(DIRECCIONLabel)
        Me.Controls.Add(Me.DIRECCIONTextBox)
        Me.Controls.Add(ZONALabel)
        Me.Controls.Add(Me.ZONATextBox)
        Me.Controls.Add(TELEFONOLabel)
        Me.Controls.Add(Me.TELEFONOTextBox)
        Me.Controls.Add(FAXLabel)
        Me.Controls.Add(Me.FAXTextBox)
        Me.Controls.Add(EMAILLabel)
        Me.Controls.Add(Me.EMAILTextBox)
        Me.Controls.Add(ISSSLabel)
        Me.Controls.Add(Me.ISSSTextBox)
        Me.Controls.Add(JEFE_INMEDIATOLabel)
        Me.Controls.Add(Me.JEFE_INMEDIATOTextBox)
        Me.Controls.Add(ACTIVIDAD_ECONOMICALabel)
        Me.Controls.Add(Me.ACTIVIDAD_ECONOMICAcbxCIUU)
        Me.Controls.Add(PUESTO_CONTRATADOLabel)
        Me.Controls.Add(Me.PUESTO_CONTRATADOTextBox)
        Me.Controls.Add(PUESTO_ACTUALLabel)
        Me.Controls.Add(Me.PUESTO_ACTUALTextBox)
        Me.Controls.Add(TIEMPO_TRABAJOLabel)
        Me.Controls.Add(Me.TIEMPO_TRABAJOTextBox)
        Me.Controls.Add(AREA_TRABAJOLabel)
        Me.Controls.Add(Me.AREA_TRABAJOTextBox)
        Me.Controls.Add(AREA_OTROLabel)
        Me.Controls.Add(Me.AREA_OTROTextBox)
        Me.Controls.Add(CODIGO_MUNICIPIOLabel)
        Me.Controls.Add(Me.CODIGO_MUNICIPIOcbxMUNICIPIO)
        Me.Controls.Add(CODIGO_REGIONLabel)
        Me.Controls.Add(Me.CODIGO_REGIONcbxREGION)
        Me.Controls.Add(CODIGO_DEPARTAMENTOLabel)
        Me.Controls.Add(Me.CODIGO_DEPARTAMENTOcbxDEPARTAMENTO)
        Me.Name = "ucDetalleSOLIC_EMPLEO_ANTERIOR"
        Me.Size = New System.Drawing.Size(382, 528)
        CType(Me.ListaSOLIC_EMPLEO_ANTERIORBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaSOLIC_EMPLEO_ANTERIORBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ID_EMPLEO_ANTTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ID_SOLICITUDcbxSOLICITUD_INSCRIPCION_AF As SGAFP.WinUC.cbxSOLICITUD_INSCRIPCION_AF
    Friend WithEvents NOMBRE_EMPRESATextBox As System.Windows.Forms.TextBox
    Friend WithEvents DIRECCIONTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ZONATextBox As System.Windows.Forms.TextBox
    Friend WithEvents TELEFONOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FAXTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EMAILTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ISSSTextBox As System.Windows.Forms.TextBox
    Friend WithEvents JEFE_INMEDIATOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ACTIVIDAD_ECONOMICAcbxCIUU As SGAFP.WinUC.cbxCIUU
    Friend WithEvents PUESTO_CONTRATADOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PUESTO_ACTUALTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TIEMPO_TRABAJOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AREA_TRABAJOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AREA_OTROTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CODIGO_MUNICIPIOcbxMUNICIPIO As SGAFP.WinUC.cbxMUNICIPIO
    Friend WithEvents CODIGO_REGIONcbxREGION As SGAFP.WinUC.cbxREGION
    Friend WithEvents CODIGO_DEPARTAMENTOcbxDEPARTAMENTO As SGAFP.WinUC.cbxDEPARTAMENTO

End Class
