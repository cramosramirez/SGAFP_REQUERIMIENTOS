<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucDetalleCONTROL_DOCUMENTOS
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
        Dim NUMERO_DOCUMENTOLabel As System.Windows.Forms.Label
        Dim NUMERO_PATRONALLabel As System.Windows.Forms.Label
        Dim NUMERO_FOLIOLabel As System.Windows.Forms.Label
        Dim ID_TIPO_SOLICITUDLabel As System.Windows.Forms.Label
        Dim CODIGO_ETAPALabel As System.Windows.Forms.Label
        Dim CODIGO_PROCESOLabel As System.Windows.Forms.Label
        Dim ID_ESTADO_SOLICITUDLabel As System.Windows.Forms.Label
        Dim NITLabel As System.Windows.Forms.Label
        Dim PRESENTADO_PORLabel As System.Windows.Forms.Label
        Dim FECHA_RECEPCIONLabel As System.Windows.Forms.Label
        Dim RESPONSABLE_ACTUALLabel As System.Windows.Forms.Label
        Dim RESPONSABLE_ANTERIORLabel As System.Windows.Forms.Label
        Dim PRIORIDADLabel As System.Windows.Forms.Label
        Dim NO_DOCUMENTO_ORIGENLabel As System.Windows.Forms.Label
        Dim NO_DOCUMENTO_PADRELabel As System.Windows.Forms.Label
        Dim FECHA_REQUERIDA_FINLabel As System.Windows.Forms.Label
        Dim NOTASLabel As System.Windows.Forms.Label
        Dim USERIDLabel As System.Windows.Forms.Label
        Dim LASTUPDATELabel As System.Windows.Forms.Label
        Me.ListaCONTROL_DOCUMENTOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NUMERO_DOCUMENTOTextBox = New System.Windows.Forms.TextBox
        Me.NUMERO_PATRONALTextBox = New System.Windows.Forms.TextBox
        Me.NUMERO_FOLIOTextBox = New System.Windows.Forms.TextBox
        Me.ID_TIPO_SOLICITUDcbxTIPO_SOLICITUD = New SGAFP.WinUC.cbxTIPO_SOLICITUD
        Me.CODIGO_ETAPAcbxETAPA = New SGAFP.WinUC.cbxETAPA
        Me.CODIGO_PROCESOcbxPROCESO = New SGAFP.WinUC.cbxPROCESO
        Me.ID_ESTADO_SOLICITUDcbxESTADO_SOLICITUD = New SGAFP.WinUC.cbxESTADO_SOLICITUD
        Me.NITTextBox = New System.Windows.Forms.TextBox
        Me.PRESENTADO_PORTextBox = New System.Windows.Forms.TextBox
        Me.FECHA_RECEPCIONDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.RESPONSABLE_ACTUALTextBox = New System.Windows.Forms.TextBox
        Me.RESPONSABLE_ANTERIORTextBox = New System.Windows.Forms.TextBox
        Me.PRIORIDADTextBox = New System.Windows.Forms.TextBox
        Me.NO_DOCUMENTO_ORIGENTextBox = New System.Windows.Forms.TextBox
        Me.NO_DOCUMENTO_PADRETextBox = New System.Windows.Forms.TextBox
        Me.FECHA_REQUERIDA_FINDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.NOTASTextBox = New System.Windows.Forms.TextBox
        Me.USERIDTextBox = New System.Windows.Forms.TextBox
        Me.LASTUPDATEDateTimePicker = New System.Windows.Forms.DateTimePicker
        NUMERO_DOCUMENTOLabel = New System.Windows.Forms.Label
        NUMERO_PATRONALLabel = New System.Windows.Forms.Label
        NUMERO_FOLIOLabel = New System.Windows.Forms.Label
        ID_TIPO_SOLICITUDLabel = New System.Windows.Forms.Label
        CODIGO_ETAPALabel = New System.Windows.Forms.Label
        CODIGO_PROCESOLabel = New System.Windows.Forms.Label
        ID_ESTADO_SOLICITUDLabel = New System.Windows.Forms.Label
        NITLabel = New System.Windows.Forms.Label
        PRESENTADO_PORLabel = New System.Windows.Forms.Label
        FECHA_RECEPCIONLabel = New System.Windows.Forms.Label
        RESPONSABLE_ACTUALLabel = New System.Windows.Forms.Label
        RESPONSABLE_ANTERIORLabel = New System.Windows.Forms.Label
        PRIORIDADLabel = New System.Windows.Forms.Label
        NO_DOCUMENTO_ORIGENLabel = New System.Windows.Forms.Label
        NO_DOCUMENTO_PADRELabel = New System.Windows.Forms.Label
        FECHA_REQUERIDA_FINLabel = New System.Windows.Forms.Label
        NOTASLabel = New System.Windows.Forms.Label
        USERIDLabel = New System.Windows.Forms.Label
        LASTUPDATELabel = New System.Windows.Forms.Label
        CType(Me.ListaCONTROL_DOCUMENTOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NUMERO_DOCUMENTOLabel
        '
        NUMERO_DOCUMENTOLabel.Location = New System.Drawing.Point(6, 14)
        NUMERO_DOCUMENTOLabel.Name = "NUMERO_DOCUMENTOLabel"
        NUMERO_DOCUMENTOLabel.Size = New System.Drawing.Size(135, 13)
        NUMERO_DOCUMENTOLabel.TabIndex = 0
        NUMERO_DOCUMENTOLabel.Text = "Numero documento:"
        '
        'NUMERO_PATRONALLabel
        '
        NUMERO_PATRONALLabel.Location = New System.Drawing.Point(6, 40)
        NUMERO_PATRONALLabel.Name = "NUMERO_PATRONALLabel"
        NUMERO_PATRONALLabel.Size = New System.Drawing.Size(135, 13)
        NUMERO_PATRONALLabel.TabIndex = 2
        NUMERO_PATRONALLabel.Text = "Numero patronal:"
        '
        'NUMERO_FOLIOLabel
        '
        NUMERO_FOLIOLabel.Location = New System.Drawing.Point(6, 66)
        NUMERO_FOLIOLabel.Name = "NUMERO_FOLIOLabel"
        NUMERO_FOLIOLabel.Size = New System.Drawing.Size(135, 13)
        NUMERO_FOLIOLabel.TabIndex = 4
        NUMERO_FOLIOLabel.Text = "Numero folio:"
        '
        'ID_TIPO_SOLICITUDLabel
        '
        ID_TIPO_SOLICITUDLabel.Location = New System.Drawing.Point(6, 92)
        ID_TIPO_SOLICITUDLabel.Name = "ID_TIPO_SOLICITUDLabel"
        ID_TIPO_SOLICITUDLabel.Size = New System.Drawing.Size(135, 13)
        ID_TIPO_SOLICITUDLabel.TabIndex = 6
        ID_TIPO_SOLICITUDLabel.Text = "Id tipo solicitud:"
        '
        'CODIGO_ETAPALabel
        '
        CODIGO_ETAPALabel.Location = New System.Drawing.Point(6, 118)
        CODIGO_ETAPALabel.Name = "CODIGO_ETAPALabel"
        CODIGO_ETAPALabel.Size = New System.Drawing.Size(135, 13)
        CODIGO_ETAPALabel.TabIndex = 8
        CODIGO_ETAPALabel.Text = "Codigo etapa:"
        '
        'CODIGO_PROCESOLabel
        '
        CODIGO_PROCESOLabel.Location = New System.Drawing.Point(6, 144)
        CODIGO_PROCESOLabel.Name = "CODIGO_PROCESOLabel"
        CODIGO_PROCESOLabel.Size = New System.Drawing.Size(135, 13)
        CODIGO_PROCESOLabel.TabIndex = 10
        CODIGO_PROCESOLabel.Text = "Codigo proceso:"
        '
        'ID_ESTADO_SOLICITUDLabel
        '
        ID_ESTADO_SOLICITUDLabel.Location = New System.Drawing.Point(6, 170)
        ID_ESTADO_SOLICITUDLabel.Name = "ID_ESTADO_SOLICITUDLabel"
        ID_ESTADO_SOLICITUDLabel.Size = New System.Drawing.Size(135, 13)
        ID_ESTADO_SOLICITUDLabel.TabIndex = 12
        ID_ESTADO_SOLICITUDLabel.Text = "Id estado solicitud:"
        '
        'NITLabel
        '
        NITLabel.Location = New System.Drawing.Point(6, 196)
        NITLabel.Name = "NITLabel"
        NITLabel.Size = New System.Drawing.Size(135, 13)
        NITLabel.TabIndex = 14
        NITLabel.Text = "Nit:"
        '
        'PRESENTADO_PORLabel
        '
        PRESENTADO_PORLabel.Location = New System.Drawing.Point(6, 222)
        PRESENTADO_PORLabel.Name = "PRESENTADO_PORLabel"
        PRESENTADO_PORLabel.Size = New System.Drawing.Size(135, 13)
        PRESENTADO_PORLabel.TabIndex = 16
        PRESENTADO_PORLabel.Text = "Presentado por:"
        '
        'FECHA_RECEPCIONLabel
        '
        FECHA_RECEPCIONLabel.Location = New System.Drawing.Point(6, 248)
        FECHA_RECEPCIONLabel.Name = "FECHA_RECEPCIONLabel"
        FECHA_RECEPCIONLabel.Size = New System.Drawing.Size(135, 13)
        FECHA_RECEPCIONLabel.TabIndex = 18
        FECHA_RECEPCIONLabel.Text = "Fecha recepcion:"
        '
        'RESPONSABLE_ACTUALLabel
        '
        RESPONSABLE_ACTUALLabel.Location = New System.Drawing.Point(6, 274)
        RESPONSABLE_ACTUALLabel.Name = "RESPONSABLE_ACTUALLabel"
        RESPONSABLE_ACTUALLabel.Size = New System.Drawing.Size(135, 13)
        RESPONSABLE_ACTUALLabel.TabIndex = 20
        RESPONSABLE_ACTUALLabel.Text = "Responsable actual:"
        '
        'RESPONSABLE_ANTERIORLabel
        '
        RESPONSABLE_ANTERIORLabel.Location = New System.Drawing.Point(6, 300)
        RESPONSABLE_ANTERIORLabel.Name = "RESPONSABLE_ANTERIORLabel"
        RESPONSABLE_ANTERIORLabel.Size = New System.Drawing.Size(135, 13)
        RESPONSABLE_ANTERIORLabel.TabIndex = 22
        RESPONSABLE_ANTERIORLabel.Text = "Responsable anterior:"
        '
        'PRIORIDADLabel
        '
        PRIORIDADLabel.Location = New System.Drawing.Point(6, 326)
        PRIORIDADLabel.Name = "PRIORIDADLabel"
        PRIORIDADLabel.Size = New System.Drawing.Size(135, 13)
        PRIORIDADLabel.TabIndex = 24
        PRIORIDADLabel.Text = "Prioridad:"
        '
        'NO_DOCUMENTO_ORIGENLabel
        '
        NO_DOCUMENTO_ORIGENLabel.Location = New System.Drawing.Point(6, 352)
        NO_DOCUMENTO_ORIGENLabel.Name = "NO_DOCUMENTO_ORIGENLabel"
        NO_DOCUMENTO_ORIGENLabel.Size = New System.Drawing.Size(135, 13)
        NO_DOCUMENTO_ORIGENLabel.TabIndex = 26
        NO_DOCUMENTO_ORIGENLabel.Text = "No documento origen:"
        '
        'NO_DOCUMENTO_PADRELabel
        '
        NO_DOCUMENTO_PADRELabel.Location = New System.Drawing.Point(6, 378)
        NO_DOCUMENTO_PADRELabel.Name = "NO_DOCUMENTO_PADRELabel"
        NO_DOCUMENTO_PADRELabel.Size = New System.Drawing.Size(135, 13)
        NO_DOCUMENTO_PADRELabel.TabIndex = 28
        NO_DOCUMENTO_PADRELabel.Text = "No documento padre:"
        '
        'FECHA_REQUERIDA_FINLabel
        '
        FECHA_REQUERIDA_FINLabel.Location = New System.Drawing.Point(6, 404)
        FECHA_REQUERIDA_FINLabel.Name = "FECHA_REQUERIDA_FINLabel"
        FECHA_REQUERIDA_FINLabel.Size = New System.Drawing.Size(135, 13)
        FECHA_REQUERIDA_FINLabel.TabIndex = 30
        FECHA_REQUERIDA_FINLabel.Text = "Fecha requerida fin:"
        '
        'NOTASLabel
        '
        NOTASLabel.Location = New System.Drawing.Point(6, 430)
        NOTASLabel.Name = "NOTASLabel"
        NOTASLabel.Size = New System.Drawing.Size(135, 13)
        NOTASLabel.TabIndex = 32
        NOTASLabel.Text = "Notas:"
        '
        'USERIDLabel
        '
        USERIDLabel.Location = New System.Drawing.Point(6, 456)
        USERIDLabel.Name = "USERIDLabel"
        USERIDLabel.Size = New System.Drawing.Size(135, 13)
        USERIDLabel.TabIndex = 34
        USERIDLabel.Text = "Userid:"
        '
        'LASTUPDATELabel
        '
        LASTUPDATELabel.Location = New System.Drawing.Point(6, 482)
        LASTUPDATELabel.Name = "LASTUPDATELabel"
        LASTUPDATELabel.Size = New System.Drawing.Size(135, 13)
        LASTUPDATELabel.TabIndex = 36
        LASTUPDATELabel.Text = "Lastupdate:"
        '
        'ListaCONTROL_DOCUMENTOSBindingSource
        '
        Me.ListaCONTROL_DOCUMENTOSBindingSource.DataSource = GetType(SGAFP.EL.CONTROL_DOCUMENTOS)
        '
        'NUMERO_DOCUMENTOTextBox
        '
        Me.NUMERO_DOCUMENTOTextBox.BackColor = System.Drawing.Color.Linen
        Me.NUMERO_DOCUMENTOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaCONTROL_DOCUMENTOSBindingSource, "NUMERO_DOCUMENTO", True))
        Me.NUMERO_DOCUMENTOTextBox.Location = New System.Drawing.Point(144, 8)
        Me.NUMERO_DOCUMENTOTextBox.Name = "NUMERO_DOCUMENTOTextBox"
        Me.NUMERO_DOCUMENTOTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NUMERO_DOCUMENTOTextBox.TabIndex = 1
        Me.NUMERO_DOCUMENTOTextBox.ReadOnly = True
        '
        'NUMERO_PATRONALTextBox
        '
        Me.NUMERO_PATRONALTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaCONTROL_DOCUMENTOSBindingSource, "NUMERO_PATRONAL", True))
        Me.NUMERO_PATRONALTextBox.Location = New System.Drawing.Point(144, 34)
        Me.NUMERO_PATRONALTextBox.Name = "NUMERO_PATRONALTextBox"
        Me.NUMERO_PATRONALTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NUMERO_PATRONALTextBox.TabIndex = 3
        Me.NUMERO_PATRONALTextBox.MaxLength = 9
        '
        'NUMERO_FOLIOTextBox
        '
        Me.NUMERO_FOLIOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaCONTROL_DOCUMENTOSBindingSource, "NUMERO_FOLIO", True))
        Me.NUMERO_FOLIOTextBox.Location = New System.Drawing.Point(144, 60)
        Me.NUMERO_FOLIOTextBox.Name = "NUMERO_FOLIOTextBox"
        Me.NUMERO_FOLIOTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NUMERO_FOLIOTextBox.TabIndex = 5
        Me.NUMERO_FOLIOTextBox.MaxLength = 14
        '
        'ID_TIPO_SOLICITUDcbxTIPO_SOLICITUD
        '
        Me.ID_TIPO_SOLICITUDcbxTIPO_SOLICITUD.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ListaCONTROL_DOCUMENTOSBindingSource, "ID_TIPO_SOLICITUD", True))
        Me.ID_TIPO_SOLICITUDcbxTIPO_SOLICITUD.Location = New System.Drawing.Point(144, 86)
        Me.ID_TIPO_SOLICITUDcbxTIPO_SOLICITUD.Name = "ID_TIPO_SOLICITUDcbxTIPO_SOLICITUD"
        Me.ID_TIPO_SOLICITUDcbxTIPO_SOLICITUD.Size = New System.Drawing.Size(200, 20)
        Me.ID_TIPO_SOLICITUDcbxTIPO_SOLICITUD.TabIndex = 7
        '
        'CODIGO_ETAPAcbxETAPA
        '
        Me.CODIGO_ETAPAcbxETAPA.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ListaCONTROL_DOCUMENTOSBindingSource, "CODIGO_ETAPA", True))
        Me.CODIGO_ETAPAcbxETAPA.Location = New System.Drawing.Point(144, 112)
        Me.CODIGO_ETAPAcbxETAPA.Name = "CODIGO_ETAPAcbxETAPA"
        Me.CODIGO_ETAPAcbxETAPA.Size = New System.Drawing.Size(200, 20)
        Me.CODIGO_ETAPAcbxETAPA.TabIndex = 9
        '
        'CODIGO_PROCESOcbxPROCESO
        '
        Me.CODIGO_PROCESOcbxPROCESO.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ListaCONTROL_DOCUMENTOSBindingSource, "CODIGO_PROCESO", True))
        Me.CODIGO_PROCESOcbxPROCESO.Location = New System.Drawing.Point(144, 138)
        Me.CODIGO_PROCESOcbxPROCESO.Name = "CODIGO_PROCESOcbxPROCESO"
        Me.CODIGO_PROCESOcbxPROCESO.Size = New System.Drawing.Size(200, 20)
        Me.CODIGO_PROCESOcbxPROCESO.TabIndex = 11
        '
        'ID_ESTADO_SOLICITUDcbxESTADO_SOLICITUD
        '
        Me.ID_ESTADO_SOLICITUDcbxESTADO_SOLICITUD.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ListaCONTROL_DOCUMENTOSBindingSource, "ID_ESTADO_SOLICITUD", True))
        Me.ID_ESTADO_SOLICITUDcbxESTADO_SOLICITUD.Location = New System.Drawing.Point(144, 164)
        Me.ID_ESTADO_SOLICITUDcbxESTADO_SOLICITUD.Name = "ID_ESTADO_SOLICITUDcbxESTADO_SOLICITUD"
        Me.ID_ESTADO_SOLICITUDcbxESTADO_SOLICITUD.Size = New System.Drawing.Size(200, 20)
        Me.ID_ESTADO_SOLICITUDcbxESTADO_SOLICITUD.TabIndex = 13
        '
        'NITTextBox
        '
        Me.NITTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaCONTROL_DOCUMENTOSBindingSource, "NIT", True))
        Me.NITTextBox.Location = New System.Drawing.Point(144, 190)
        Me.NITTextBox.Name = "NITTextBox"
        Me.NITTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NITTextBox.TabIndex = 15
        Me.NITTextBox.MaxLength = 14
        '
        'PRESENTADO_PORTextBox
        '
        Me.PRESENTADO_PORTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaCONTROL_DOCUMENTOSBindingSource, "PRESENTADO_POR", True))
        Me.PRESENTADO_PORTextBox.Location = New System.Drawing.Point(144, 216)
        Me.PRESENTADO_PORTextBox.Name = "PRESENTADO_PORTextBox"
        Me.PRESENTADO_PORTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PRESENTADO_PORTextBox.TabIndex = 17
        Me.PRESENTADO_PORTextBox.MaxLength = 60
        '
        'FECHA_RECEPCIONDateTimePicker
        '
        Me.FECHA_RECEPCIONDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ListaCONTROL_DOCUMENTOSBindingSource, "FECHA_RECEPCION", True))
        Me.FECHA_RECEPCIONDateTimePicker.Location = New System.Drawing.Point(144, 242)
        Me.FECHA_RECEPCIONDateTimePicker.Name = "FECHA_RECEPCIONDateTimePicker"
        Me.FECHA_RECEPCIONDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.FECHA_RECEPCIONDateTimePicker.TabIndex = 19
        '
        'RESPONSABLE_ACTUALTextBox
        '
        Me.RESPONSABLE_ACTUALTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaCONTROL_DOCUMENTOSBindingSource, "RESPONSABLE_ACTUAL", True))
        Me.RESPONSABLE_ACTUALTextBox.Location = New System.Drawing.Point(144, 268)
        Me.RESPONSABLE_ACTUALTextBox.Name = "RESPONSABLE_ACTUALTextBox"
        Me.RESPONSABLE_ACTUALTextBox.Size = New System.Drawing.Size(200, 20)
        Me.RESPONSABLE_ACTUALTextBox.TabIndex = 21
        Me.RESPONSABLE_ACTUALTextBox.MaxLength = 16
        '
        'RESPONSABLE_ANTERIORTextBox
        '
        Me.RESPONSABLE_ANTERIORTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaCONTROL_DOCUMENTOSBindingSource, "RESPONSABLE_ANTERIOR", True))
        Me.RESPONSABLE_ANTERIORTextBox.Location = New System.Drawing.Point(144, 294)
        Me.RESPONSABLE_ANTERIORTextBox.Name = "RESPONSABLE_ANTERIORTextBox"
        Me.RESPONSABLE_ANTERIORTextBox.Size = New System.Drawing.Size(200, 20)
        Me.RESPONSABLE_ANTERIORTextBox.TabIndex = 23
        Me.RESPONSABLE_ANTERIORTextBox.MaxLength = 16
        '
        'PRIORIDADTextBox
        '
        Me.PRIORIDADTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaCONTROL_DOCUMENTOSBindingSource, "PRIORIDAD", True))
        Me.PRIORIDADTextBox.Location = New System.Drawing.Point(144, 320)
        Me.PRIORIDADTextBox.Name = "PRIORIDADTextBox"
        Me.PRIORIDADTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PRIORIDADTextBox.TabIndex = 25
        Me.PRIORIDADTextBox.MaxLength = 1
        '
        'NO_DOCUMENTO_ORIGENTextBox
        '
        Me.NO_DOCUMENTO_ORIGENTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaCONTROL_DOCUMENTOSBindingSource, "NO_DOCUMENTO_ORIGEN", True))
        Me.NO_DOCUMENTO_ORIGENTextBox.Location = New System.Drawing.Point(144, 346)
        Me.NO_DOCUMENTO_ORIGENTextBox.Name = "NO_DOCUMENTO_ORIGENTextBox"
        Me.NO_DOCUMENTO_ORIGENTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NO_DOCUMENTO_ORIGENTextBox.TabIndex = 27
        '
        'NO_DOCUMENTO_PADRETextBox
        '
        Me.NO_DOCUMENTO_PADRETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaCONTROL_DOCUMENTOSBindingSource, "NO_DOCUMENTO_PADRE", True))
        Me.NO_DOCUMENTO_PADRETextBox.Location = New System.Drawing.Point(144, 372)
        Me.NO_DOCUMENTO_PADRETextBox.Name = "NO_DOCUMENTO_PADRETextBox"
        Me.NO_DOCUMENTO_PADRETextBox.Size = New System.Drawing.Size(200, 20)
        Me.NO_DOCUMENTO_PADRETextBox.TabIndex = 29
        '
        'FECHA_REQUERIDA_FINDateTimePicker
        '
        Me.FECHA_REQUERIDA_FINDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ListaCONTROL_DOCUMENTOSBindingSource, "FECHA_REQUERIDA_FIN", True))
        Me.FECHA_REQUERIDA_FINDateTimePicker.Location = New System.Drawing.Point(144, 398)
        Me.FECHA_REQUERIDA_FINDateTimePicker.Name = "FECHA_REQUERIDA_FINDateTimePicker"
        Me.FECHA_REQUERIDA_FINDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.FECHA_REQUERIDA_FINDateTimePicker.TabIndex = 31
        '
        'NOTASTextBox
        '
        Me.NOTASTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaCONTROL_DOCUMENTOSBindingSource, "NOTAS", True))
        Me.NOTASTextBox.Location = New System.Drawing.Point(144, 424)
        Me.NOTASTextBox.Name = "NOTASTextBox"
        Me.NOTASTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NOTASTextBox.TabIndex = 33
        Me.NOTASTextBox.MaxLength = 255
        '
        'USERIDTextBox
        '
        Me.USERIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaCONTROL_DOCUMENTOSBindingSource, "USERID", True))
        Me.USERIDTextBox.Location = New System.Drawing.Point(144, 450)
        Me.USERIDTextBox.Name = "USERIDTextBox"
        Me.USERIDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.USERIDTextBox.TabIndex = 35
        Me.USERIDTextBox.MaxLength = 16
        '
        'LASTUPDATEDateTimePicker
        '
        Me.LASTUPDATEDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ListaCONTROL_DOCUMENTOSBindingSource, "LASTUPDATE", True))
        Me.LASTUPDATEDateTimePicker.Location = New System.Drawing.Point(144, 476)
        Me.LASTUPDATEDateTimePicker.Name = "LASTUPDATEDateTimePicker"
        Me.LASTUPDATEDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.LASTUPDATEDateTimePicker.TabIndex = 37
        '
        'ucDetalleCONTROL_DOCUMENTOS
        '
        Me.AutoScroll = True
        Me.Controls.Add(NUMERO_DOCUMENTOLabel)
        Me.Controls.Add(Me.NUMERO_DOCUMENTOTextBox)
        Me.Controls.Add(NUMERO_PATRONALLabel)
        Me.Controls.Add(Me.NUMERO_PATRONALTextBox)
        Me.Controls.Add(NUMERO_FOLIOLabel)
        Me.Controls.Add(Me.NUMERO_FOLIOTextBox)
        Me.Controls.Add(ID_TIPO_SOLICITUDLabel)
        Me.Controls.Add(Me.ID_TIPO_SOLICITUDcbxTIPO_SOLICITUD)
        Me.Controls.Add(CODIGO_ETAPALabel)
        Me.Controls.Add(Me.CODIGO_ETAPAcbxETAPA)
        Me.Controls.Add(CODIGO_PROCESOLabel)
        Me.Controls.Add(Me.CODIGO_PROCESOcbxPROCESO)
        Me.Controls.Add(ID_ESTADO_SOLICITUDLabel)
        Me.Controls.Add(Me.ID_ESTADO_SOLICITUDcbxESTADO_SOLICITUD)
        Me.Controls.Add(NITLabel)
        Me.Controls.Add(Me.NITTextBox)
        Me.Controls.Add(PRESENTADO_PORLabel)
        Me.Controls.Add(Me.PRESENTADO_PORTextBox)
        Me.Controls.Add(FECHA_RECEPCIONLabel)
        Me.Controls.Add(Me.FECHA_RECEPCIONDateTimePicker)
        Me.Controls.Add(RESPONSABLE_ACTUALLabel)
        Me.Controls.Add(Me.RESPONSABLE_ACTUALTextBox)
        Me.Controls.Add(RESPONSABLE_ANTERIORLabel)
        Me.Controls.Add(Me.RESPONSABLE_ANTERIORTextBox)
        Me.Controls.Add(PRIORIDADLabel)
        Me.Controls.Add(Me.PRIORIDADTextBox)
        Me.Controls.Add(NO_DOCUMENTO_ORIGENLabel)
        Me.Controls.Add(Me.NO_DOCUMENTO_ORIGENTextBox)
        Me.Controls.Add(NO_DOCUMENTO_PADRELabel)
        Me.Controls.Add(Me.NO_DOCUMENTO_PADRETextBox)
        Me.Controls.Add(FECHA_REQUERIDA_FINLabel)
        Me.Controls.Add(Me.FECHA_REQUERIDA_FINDateTimePicker)
        Me.Controls.Add(NOTASLabel)
        Me.Controls.Add(Me.NOTASTextBox)
        Me.Controls.Add(USERIDLabel)
        Me.Controls.Add(Me.USERIDTextBox)
        Me.Controls.Add(LASTUPDATELabel)
        Me.Controls.Add(Me.LASTUPDATEDateTimePicker)
        Me.Name = "ucDetalleCONTROL_DOCUMENTOS"
        Me.Size = New System.Drawing.Size(382, 528)
        CType(Me.ListaCONTROL_DOCUMENTOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaCONTROL_DOCUMENTOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NUMERO_DOCUMENTOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NUMERO_PATRONALTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NUMERO_FOLIOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ID_TIPO_SOLICITUDcbxTIPO_SOLICITUD As SGAFP.WinUC.cbxTIPO_SOLICITUD
    Friend WithEvents CODIGO_ETAPAcbxETAPA As SGAFP.WinUC.cbxETAPA
    Friend WithEvents CODIGO_PROCESOcbxPROCESO As SGAFP.WinUC.cbxPROCESO
    Friend WithEvents ID_ESTADO_SOLICITUDcbxESTADO_SOLICITUD As SGAFP.WinUC.cbxESTADO_SOLICITUD
    Friend WithEvents NITTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PRESENTADO_PORTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FECHA_RECEPCIONDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents RESPONSABLE_ACTUALTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RESPONSABLE_ANTERIORTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PRIORIDADTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NO_DOCUMENTO_ORIGENTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NO_DOCUMENTO_PADRETextBox As System.Windows.Forms.TextBox
    Friend WithEvents FECHA_REQUERIDA_FINDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents NOTASTextBox As System.Windows.Forms.TextBox
    Friend WithEvents USERIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LASTUPDATEDateTimePicker As System.Windows.Forms.DateTimePicker

End Class
