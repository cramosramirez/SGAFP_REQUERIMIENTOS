<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucDetalleSUPERVISION_AF
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
        Dim ID_SUPERVISION_AFLabel As System.Windows.Forms.Label
        Dim ID_MODALIDAD_FORMACIONLabel As System.Windows.Forms.Label
        Dim ID_ACCION_FORMATIVALabel As System.Windows.Forms.Label
        Dim FECHALabel As System.Windows.Forms.Label
        Dim NOMBRE_AFLabel As System.Windows.Forms.Label
        Dim CENTRO_FORMACIONLabel As System.Windows.Forms.Label
        Dim OPCIONLabel As System.Windows.Forms.Label
        Dim GRUPOLabel As System.Windows.Forms.Label
        Dim HORARIOLabel As System.Windows.Forms.Label
        Dim CODIGOLabel As System.Windows.Forms.Label
        Dim COORDINADOR_CFPLabel As System.Windows.Forms.Label
        Dim DIRECTOR_CFPLabel As System.Windows.Forms.Label
        Dim PARTICIPANTES_PRESENTESLabel As System.Windows.Forms.Label
        Dim PARTICIPANTES_AUSENTESLabel As System.Windows.Forms.Label
        Dim PARTICIPANTES_INSCRITOSLabel As System.Windows.Forms.Label
        Dim PARTICIPANTES_DESERTADOSLabel As System.Windows.Forms.Label
        Dim PARTICIPANTES_SUPLENTESLabel As System.Windows.Forms.Label
        Dim OBJETIVO_VISITALabel As System.Windows.Forms.Label
        Dim NOTASLabel As System.Windows.Forms.Label
        Dim DURACION_VISITALabel As System.Windows.Forms.Label
        Me.ListaSUPERVISION_AFBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ID_SUPERVISION_AFTextBox = New System.Windows.Forms.TextBox
        Me.ID_MODALIDAD_FORMACIONcbxMODALIDAD_DE_FORMACION = New SGAFP.WinUC.cbxMODALIDAD_DE_FORMACION
        Me.ID_ACCION_FORMATIVAcbxACCION_FORMATIVA = New SGAFP.WinUC.cbxACCION_FORMATIVA
        Me.FECHADateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.NOMBRE_AFTextBox = New System.Windows.Forms.TextBox
        Me.CENTRO_FORMACIONTextBox = New System.Windows.Forms.TextBox
        Me.OPCIONTextBox = New System.Windows.Forms.TextBox
        Me.GRUPOTextBox = New System.Windows.Forms.TextBox
        Me.HORARIOTextBox = New System.Windows.Forms.TextBox
        Me.CODIGOTextBox = New System.Windows.Forms.TextBox
        Me.COORDINADOR_CFPTextBox = New System.Windows.Forms.TextBox
        Me.DIRECTOR_CFPTextBox = New System.Windows.Forms.TextBox
        Me.PARTICIPANTES_PRESENTESTextBox = New System.Windows.Forms.TextBox
        Me.PARTICIPANTES_AUSENTESTextBox = New System.Windows.Forms.TextBox
        Me.PARTICIPANTES_INSCRITOSTextBox = New System.Windows.Forms.TextBox
        Me.PARTICIPANTES_DESERTADOSTextBox = New System.Windows.Forms.TextBox
        Me.PARTICIPANTES_SUPLENTESTextBox = New System.Windows.Forms.TextBox
        Me.OBJETIVO_VISITATextBox = New System.Windows.Forms.TextBox
        Me.NOTASTextBox = New System.Windows.Forms.TextBox
        Me.DURACION_VISITATextBox = New System.Windows.Forms.TextBox
        ID_SUPERVISION_AFLabel = New System.Windows.Forms.Label
        ID_MODALIDAD_FORMACIONLabel = New System.Windows.Forms.Label
        ID_ACCION_FORMATIVALabel = New System.Windows.Forms.Label
        FECHALabel = New System.Windows.Forms.Label
        NOMBRE_AFLabel = New System.Windows.Forms.Label
        CENTRO_FORMACIONLabel = New System.Windows.Forms.Label
        OPCIONLabel = New System.Windows.Forms.Label
        GRUPOLabel = New System.Windows.Forms.Label
        HORARIOLabel = New System.Windows.Forms.Label
        CODIGOLabel = New System.Windows.Forms.Label
        COORDINADOR_CFPLabel = New System.Windows.Forms.Label
        DIRECTOR_CFPLabel = New System.Windows.Forms.Label
        PARTICIPANTES_PRESENTESLabel = New System.Windows.Forms.Label
        PARTICIPANTES_AUSENTESLabel = New System.Windows.Forms.Label
        PARTICIPANTES_INSCRITOSLabel = New System.Windows.Forms.Label
        PARTICIPANTES_DESERTADOSLabel = New System.Windows.Forms.Label
        PARTICIPANTES_SUPLENTESLabel = New System.Windows.Forms.Label
        OBJETIVO_VISITALabel = New System.Windows.Forms.Label
        NOTASLabel = New System.Windows.Forms.Label
        DURACION_VISITALabel = New System.Windows.Forms.Label
        CType(Me.ListaSUPERVISION_AFBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ID_SUPERVISION_AFLabel
        '
        ID_SUPERVISION_AFLabel.Location = New System.Drawing.Point(6, 14)
        ID_SUPERVISION_AFLabel.Name = "ID_SUPERVISION_AFLabel"
        ID_SUPERVISION_AFLabel.Size = New System.Drawing.Size(135, 13)
        ID_SUPERVISION_AFLabel.TabIndex = 0
        ID_SUPERVISION_AFLabel.Text = "Id supervision af:"
        '
        'ID_MODALIDAD_FORMACIONLabel
        '
        ID_MODALIDAD_FORMACIONLabel.Location = New System.Drawing.Point(6, 40)
        ID_MODALIDAD_FORMACIONLabel.Name = "ID_MODALIDAD_FORMACIONLabel"
        ID_MODALIDAD_FORMACIONLabel.Size = New System.Drawing.Size(135, 13)
        ID_MODALIDAD_FORMACIONLabel.TabIndex = 2
        ID_MODALIDAD_FORMACIONLabel.Text = "Id modalidad formacion:"
        '
        'ID_ACCION_FORMATIVALabel
        '
        ID_ACCION_FORMATIVALabel.Location = New System.Drawing.Point(6, 66)
        ID_ACCION_FORMATIVALabel.Name = "ID_ACCION_FORMATIVALabel"
        ID_ACCION_FORMATIVALabel.Size = New System.Drawing.Size(135, 13)
        ID_ACCION_FORMATIVALabel.TabIndex = 4
        ID_ACCION_FORMATIVALabel.Text = "Id accion formativa:"
        '
        'FECHALabel
        '
        FECHALabel.Location = New System.Drawing.Point(6, 92)
        FECHALabel.Name = "FECHALabel"
        FECHALabel.Size = New System.Drawing.Size(135, 13)
        FECHALabel.TabIndex = 6
        FECHALabel.Text = "Fecha:"
        '
        'NOMBRE_AFLabel
        '
        NOMBRE_AFLabel.Location = New System.Drawing.Point(6, 118)
        NOMBRE_AFLabel.Name = "NOMBRE_AFLabel"
        NOMBRE_AFLabel.Size = New System.Drawing.Size(135, 13)
        NOMBRE_AFLabel.TabIndex = 8
        NOMBRE_AFLabel.Text = "Nombre af:"
        '
        'CENTRO_FORMACIONLabel
        '
        CENTRO_FORMACIONLabel.Location = New System.Drawing.Point(6, 144)
        CENTRO_FORMACIONLabel.Name = "CENTRO_FORMACIONLabel"
        CENTRO_FORMACIONLabel.Size = New System.Drawing.Size(135, 13)
        CENTRO_FORMACIONLabel.TabIndex = 10
        CENTRO_FORMACIONLabel.Text = "Centro formacion:"
        '
        'OPCIONLabel
        '
        OPCIONLabel.Location = New System.Drawing.Point(6, 170)
        OPCIONLabel.Name = "OPCIONLabel"
        OPCIONLabel.Size = New System.Drawing.Size(135, 13)
        OPCIONLabel.TabIndex = 12
        OPCIONLabel.Text = "Opcion:"
        '
        'GRUPOLabel
        '
        GRUPOLabel.Location = New System.Drawing.Point(6, 196)
        GRUPOLabel.Name = "GRUPOLabel"
        GRUPOLabel.Size = New System.Drawing.Size(135, 13)
        GRUPOLabel.TabIndex = 14
        GRUPOLabel.Text = "Grupo:"
        '
        'HORARIOLabel
        '
        HORARIOLabel.Location = New System.Drawing.Point(6, 222)
        HORARIOLabel.Name = "HORARIOLabel"
        HORARIOLabel.Size = New System.Drawing.Size(135, 13)
        HORARIOLabel.TabIndex = 16
        HORARIOLabel.Text = "Horario:"
        '
        'CODIGOLabel
        '
        CODIGOLabel.Location = New System.Drawing.Point(6, 248)
        CODIGOLabel.Name = "CODIGOLabel"
        CODIGOLabel.Size = New System.Drawing.Size(135, 13)
        CODIGOLabel.TabIndex = 18
        CODIGOLabel.Text = "Codigo:"
        '
        'COORDINADOR_CFPLabel
        '
        COORDINADOR_CFPLabel.Location = New System.Drawing.Point(6, 274)
        COORDINADOR_CFPLabel.Name = "COORDINADOR_CFPLabel"
        COORDINADOR_CFPLabel.Size = New System.Drawing.Size(135, 13)
        COORDINADOR_CFPLabel.TabIndex = 20
        COORDINADOR_CFPLabel.Text = "Coordinador cfp:"
        '
        'DIRECTOR_CFPLabel
        '
        DIRECTOR_CFPLabel.Location = New System.Drawing.Point(6, 300)
        DIRECTOR_CFPLabel.Name = "DIRECTOR_CFPLabel"
        DIRECTOR_CFPLabel.Size = New System.Drawing.Size(135, 13)
        DIRECTOR_CFPLabel.TabIndex = 22
        DIRECTOR_CFPLabel.Text = "Director cfp:"
        '
        'PARTICIPANTES_PRESENTESLabel
        '
        PARTICIPANTES_PRESENTESLabel.Location = New System.Drawing.Point(6, 326)
        PARTICIPANTES_PRESENTESLabel.Name = "PARTICIPANTES_PRESENTESLabel"
        PARTICIPANTES_PRESENTESLabel.Size = New System.Drawing.Size(135, 13)
        PARTICIPANTES_PRESENTESLabel.TabIndex = 24
        PARTICIPANTES_PRESENTESLabel.Text = "Participantes presentes:"
        '
        'PARTICIPANTES_AUSENTESLabel
        '
        PARTICIPANTES_AUSENTESLabel.Location = New System.Drawing.Point(6, 352)
        PARTICIPANTES_AUSENTESLabel.Name = "PARTICIPANTES_AUSENTESLabel"
        PARTICIPANTES_AUSENTESLabel.Size = New System.Drawing.Size(135, 13)
        PARTICIPANTES_AUSENTESLabel.TabIndex = 26
        PARTICIPANTES_AUSENTESLabel.Text = "Participantes ausentes:"
        '
        'PARTICIPANTES_INSCRITOSLabel
        '
        PARTICIPANTES_INSCRITOSLabel.Location = New System.Drawing.Point(6, 378)
        PARTICIPANTES_INSCRITOSLabel.Name = "PARTICIPANTES_INSCRITOSLabel"
        PARTICIPANTES_INSCRITOSLabel.Size = New System.Drawing.Size(135, 13)
        PARTICIPANTES_INSCRITOSLabel.TabIndex = 28
        PARTICIPANTES_INSCRITOSLabel.Text = "Participantes inscritos:"
        '
        'PARTICIPANTES_DESERTADOSLabel
        '
        PARTICIPANTES_DESERTADOSLabel.Location = New System.Drawing.Point(6, 404)
        PARTICIPANTES_DESERTADOSLabel.Name = "PARTICIPANTES_DESERTADOSLabel"
        PARTICIPANTES_DESERTADOSLabel.Size = New System.Drawing.Size(135, 13)
        PARTICIPANTES_DESERTADOSLabel.TabIndex = 30
        PARTICIPANTES_DESERTADOSLabel.Text = "Participantes desertados:"
        '
        'PARTICIPANTES_SUPLENTESLabel
        '
        PARTICIPANTES_SUPLENTESLabel.Location = New System.Drawing.Point(6, 430)
        PARTICIPANTES_SUPLENTESLabel.Name = "PARTICIPANTES_SUPLENTESLabel"
        PARTICIPANTES_SUPLENTESLabel.Size = New System.Drawing.Size(135, 13)
        PARTICIPANTES_SUPLENTESLabel.TabIndex = 32
        PARTICIPANTES_SUPLENTESLabel.Text = "Participantes suplentes:"
        '
        'OBJETIVO_VISITALabel
        '
        OBJETIVO_VISITALabel.Location = New System.Drawing.Point(6, 456)
        OBJETIVO_VISITALabel.Name = "OBJETIVO_VISITALabel"
        OBJETIVO_VISITALabel.Size = New System.Drawing.Size(135, 13)
        OBJETIVO_VISITALabel.TabIndex = 34
        OBJETIVO_VISITALabel.Text = "Objetivo visita:"
        '
        'NOTASLabel
        '
        NOTASLabel.Location = New System.Drawing.Point(6, 482)
        NOTASLabel.Name = "NOTASLabel"
        NOTASLabel.Size = New System.Drawing.Size(135, 13)
        NOTASLabel.TabIndex = 36
        NOTASLabel.Text = "Notas:"
        '
        'DURACION_VISITALabel
        '
        DURACION_VISITALabel.Location = New System.Drawing.Point(6, 508)
        DURACION_VISITALabel.Name = "DURACION_VISITALabel"
        DURACION_VISITALabel.Size = New System.Drawing.Size(135, 13)
        DURACION_VISITALabel.TabIndex = 38
        DURACION_VISITALabel.Text = "Duracion visita:"
        '
        'ListaSUPERVISION_AFBindingSource
        '
        Me.ListaSUPERVISION_AFBindingSource.DataSource = GetType(SGAFP.EL.SUPERVISION_AF)
        '
        'ID_SUPERVISION_AFTextBox
        '
        Me.ID_SUPERVISION_AFTextBox.BackColor = System.Drawing.Color.Linen
        Me.ID_SUPERVISION_AFTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaSUPERVISION_AFBindingSource, "ID_SUPERVISION_AF", True))
        Me.ID_SUPERVISION_AFTextBox.Location = New System.Drawing.Point(144, 8)
        Me.ID_SUPERVISION_AFTextBox.Name = "ID_SUPERVISION_AFTextBox"
        Me.ID_SUPERVISION_AFTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ID_SUPERVISION_AFTextBox.TabIndex = 1
        Me.ID_SUPERVISION_AFTextBox.ReadOnly = True
        '
        'ID_MODALIDAD_FORMACIONcbxMODALIDAD_DE_FORMACION
        '
        Me.ID_MODALIDAD_FORMACIONcbxMODALIDAD_DE_FORMACION.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ListaSUPERVISION_AFBindingSource, "ID_MODALIDAD_FORMACION", True))
        Me.ID_MODALIDAD_FORMACIONcbxMODALIDAD_DE_FORMACION.Location = New System.Drawing.Point(144, 34)
        Me.ID_MODALIDAD_FORMACIONcbxMODALIDAD_DE_FORMACION.Name = "ID_MODALIDAD_FORMACIONcbxMODALIDAD_DE_FORMACION"
        Me.ID_MODALIDAD_FORMACIONcbxMODALIDAD_DE_FORMACION.Size = New System.Drawing.Size(200, 20)
        Me.ID_MODALIDAD_FORMACIONcbxMODALIDAD_DE_FORMACION.TabIndex = 3
        '
        'ID_ACCION_FORMATIVAcbxACCION_FORMATIVA
        '
        Me.ID_ACCION_FORMATIVAcbxACCION_FORMATIVA.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ListaSUPERVISION_AFBindingSource, "ID_ACCION_FORMATIVA", True))
        Me.ID_ACCION_FORMATIVAcbxACCION_FORMATIVA.Location = New System.Drawing.Point(144, 60)
        Me.ID_ACCION_FORMATIVAcbxACCION_FORMATIVA.Name = "ID_ACCION_FORMATIVAcbxACCION_FORMATIVA"
        Me.ID_ACCION_FORMATIVAcbxACCION_FORMATIVA.Size = New System.Drawing.Size(200, 20)
        Me.ID_ACCION_FORMATIVAcbxACCION_FORMATIVA.TabIndex = 5
        '
        'FECHADateTimePicker
        '
        Me.FECHADateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ListaSUPERVISION_AFBindingSource, "FECHA", True))
        Me.FECHADateTimePicker.Location = New System.Drawing.Point(144, 86)
        Me.FECHADateTimePicker.Name = "FECHADateTimePicker"
        Me.FECHADateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.FECHADateTimePicker.TabIndex = 7
        '
        'NOMBRE_AFTextBox
        '
        Me.NOMBRE_AFTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaSUPERVISION_AFBindingSource, "NOMBRE_AF", True))
        Me.NOMBRE_AFTextBox.Location = New System.Drawing.Point(144, 112)
        Me.NOMBRE_AFTextBox.Name = "NOMBRE_AFTextBox"
        Me.NOMBRE_AFTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NOMBRE_AFTextBox.TabIndex = 9
        Me.NOMBRE_AFTextBox.MaxLength = 150
        '
        'CENTRO_FORMACIONTextBox
        '
        Me.CENTRO_FORMACIONTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaSUPERVISION_AFBindingSource, "CENTRO_FORMACION", True))
        Me.CENTRO_FORMACIONTextBox.Location = New System.Drawing.Point(144, 138)
        Me.CENTRO_FORMACIONTextBox.Name = "CENTRO_FORMACIONTextBox"
        Me.CENTRO_FORMACIONTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CENTRO_FORMACIONTextBox.TabIndex = 11
        Me.CENTRO_FORMACIONTextBox.MaxLength = 100
        '
        'OPCIONTextBox
        '
        Me.OPCIONTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaSUPERVISION_AFBindingSource, "OPCION", True))
        Me.OPCIONTextBox.Location = New System.Drawing.Point(144, 164)
        Me.OPCIONTextBox.Name = "OPCIONTextBox"
        Me.OPCIONTextBox.Size = New System.Drawing.Size(200, 20)
        Me.OPCIONTextBox.TabIndex = 13
        Me.OPCIONTextBox.MaxLength = 1
        '
        'GRUPOTextBox
        '
        Me.GRUPOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaSUPERVISION_AFBindingSource, "GRUPO", True))
        Me.GRUPOTextBox.Location = New System.Drawing.Point(144, 190)
        Me.GRUPOTextBox.Name = "GRUPOTextBox"
        Me.GRUPOTextBox.Size = New System.Drawing.Size(200, 20)
        Me.GRUPOTextBox.TabIndex = 15
        Me.GRUPOTextBox.MaxLength = 30
        '
        'HORARIOTextBox
        '
        Me.HORARIOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaSUPERVISION_AFBindingSource, "HORARIO", True))
        Me.HORARIOTextBox.Location = New System.Drawing.Point(144, 216)
        Me.HORARIOTextBox.Name = "HORARIOTextBox"
        Me.HORARIOTextBox.Size = New System.Drawing.Size(200, 20)
        Me.HORARIOTextBox.TabIndex = 17
        Me.HORARIOTextBox.MaxLength = 255
        '
        'CODIGOTextBox
        '
        Me.CODIGOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaSUPERVISION_AFBindingSource, "CODIGO", True))
        Me.CODIGOTextBox.Location = New System.Drawing.Point(144, 242)
        Me.CODIGOTextBox.Name = "CODIGOTextBox"
        Me.CODIGOTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CODIGOTextBox.TabIndex = 19
        Me.CODIGOTextBox.MaxLength = 20
        '
        'COORDINADOR_CFPTextBox
        '
        Me.COORDINADOR_CFPTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaSUPERVISION_AFBindingSource, "COORDINADOR_CFP", True))
        Me.COORDINADOR_CFPTextBox.Location = New System.Drawing.Point(144, 268)
        Me.COORDINADOR_CFPTextBox.Name = "COORDINADOR_CFPTextBox"
        Me.COORDINADOR_CFPTextBox.Size = New System.Drawing.Size(200, 20)
        Me.COORDINADOR_CFPTextBox.TabIndex = 21
        Me.COORDINADOR_CFPTextBox.MaxLength = 60
        '
        'DIRECTOR_CFPTextBox
        '
        Me.DIRECTOR_CFPTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaSUPERVISION_AFBindingSource, "DIRECTOR_CFP", True))
        Me.DIRECTOR_CFPTextBox.Location = New System.Drawing.Point(144, 294)
        Me.DIRECTOR_CFPTextBox.Name = "DIRECTOR_CFPTextBox"
        Me.DIRECTOR_CFPTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DIRECTOR_CFPTextBox.TabIndex = 23
        Me.DIRECTOR_CFPTextBox.MaxLength = 60
        '
        'PARTICIPANTES_PRESENTESTextBox
        '
        Me.PARTICIPANTES_PRESENTESTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaSUPERVISION_AFBindingSource, "PARTICIPANTES_PRESENTES", True))
        Me.PARTICIPANTES_PRESENTESTextBox.Location = New System.Drawing.Point(144, 320)
        Me.PARTICIPANTES_PRESENTESTextBox.Name = "PARTICIPANTES_PRESENTESTextBox"
        Me.PARTICIPANTES_PRESENTESTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PARTICIPANTES_PRESENTESTextBox.TabIndex = 25
        '
        'PARTICIPANTES_AUSENTESTextBox
        '
        Me.PARTICIPANTES_AUSENTESTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaSUPERVISION_AFBindingSource, "PARTICIPANTES_AUSENTES", True))
        Me.PARTICIPANTES_AUSENTESTextBox.Location = New System.Drawing.Point(144, 346)
        Me.PARTICIPANTES_AUSENTESTextBox.Name = "PARTICIPANTES_AUSENTESTextBox"
        Me.PARTICIPANTES_AUSENTESTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PARTICIPANTES_AUSENTESTextBox.TabIndex = 27
        '
        'PARTICIPANTES_INSCRITOSTextBox
        '
        Me.PARTICIPANTES_INSCRITOSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaSUPERVISION_AFBindingSource, "PARTICIPANTES_INSCRITOS", True))
        Me.PARTICIPANTES_INSCRITOSTextBox.Location = New System.Drawing.Point(144, 372)
        Me.PARTICIPANTES_INSCRITOSTextBox.Name = "PARTICIPANTES_INSCRITOSTextBox"
        Me.PARTICIPANTES_INSCRITOSTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PARTICIPANTES_INSCRITOSTextBox.TabIndex = 29
        '
        'PARTICIPANTES_DESERTADOSTextBox
        '
        Me.PARTICIPANTES_DESERTADOSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaSUPERVISION_AFBindingSource, "PARTICIPANTES_DESERTADOS", True))
        Me.PARTICIPANTES_DESERTADOSTextBox.Location = New System.Drawing.Point(144, 398)
        Me.PARTICIPANTES_DESERTADOSTextBox.Name = "PARTICIPANTES_DESERTADOSTextBox"
        Me.PARTICIPANTES_DESERTADOSTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PARTICIPANTES_DESERTADOSTextBox.TabIndex = 31
        '
        'PARTICIPANTES_SUPLENTESTextBox
        '
        Me.PARTICIPANTES_SUPLENTESTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaSUPERVISION_AFBindingSource, "PARTICIPANTES_SUPLENTES", True))
        Me.PARTICIPANTES_SUPLENTESTextBox.Location = New System.Drawing.Point(144, 424)
        Me.PARTICIPANTES_SUPLENTESTextBox.Name = "PARTICIPANTES_SUPLENTESTextBox"
        Me.PARTICIPANTES_SUPLENTESTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PARTICIPANTES_SUPLENTESTextBox.TabIndex = 33
        '
        'OBJETIVO_VISITATextBox
        '
        Me.OBJETIVO_VISITATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaSUPERVISION_AFBindingSource, "OBJETIVO_VISITA", True))
        Me.OBJETIVO_VISITATextBox.Location = New System.Drawing.Point(144, 450)
        Me.OBJETIVO_VISITATextBox.Name = "OBJETIVO_VISITATextBox"
        Me.OBJETIVO_VISITATextBox.Size = New System.Drawing.Size(200, 20)
        Me.OBJETIVO_VISITATextBox.TabIndex = 35
        Me.OBJETIVO_VISITATextBox.MaxLength = 255
        '
        'NOTASTextBox
        '
        Me.NOTASTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaSUPERVISION_AFBindingSource, "NOTAS", True))
        Me.NOTASTextBox.Location = New System.Drawing.Point(144, 476)
        Me.NOTASTextBox.Name = "NOTASTextBox"
        Me.NOTASTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NOTASTextBox.TabIndex = 37
        Me.NOTASTextBox.MaxLength = 255
        '
        'DURACION_VISITATextBox
        '
        Me.DURACION_VISITATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaSUPERVISION_AFBindingSource, "DURACION_VISITA", True))
        Me.DURACION_VISITATextBox.Location = New System.Drawing.Point(144, 502)
        Me.DURACION_VISITATextBox.Name = "DURACION_VISITATextBox"
        Me.DURACION_VISITATextBox.Size = New System.Drawing.Size(200, 20)
        Me.DURACION_VISITATextBox.TabIndex = 39
        '
        'ucDetalleSUPERVISION_AF
        '
        Me.AutoScroll = True
        Me.Controls.Add(ID_SUPERVISION_AFLabel)
        Me.Controls.Add(Me.ID_SUPERVISION_AFTextBox)
        Me.Controls.Add(ID_MODALIDAD_FORMACIONLabel)
        Me.Controls.Add(Me.ID_MODALIDAD_FORMACIONcbxMODALIDAD_DE_FORMACION)
        Me.Controls.Add(ID_ACCION_FORMATIVALabel)
        Me.Controls.Add(Me.ID_ACCION_FORMATIVAcbxACCION_FORMATIVA)
        Me.Controls.Add(FECHALabel)
        Me.Controls.Add(Me.FECHADateTimePicker)
        Me.Controls.Add(NOMBRE_AFLabel)
        Me.Controls.Add(Me.NOMBRE_AFTextBox)
        Me.Controls.Add(CENTRO_FORMACIONLabel)
        Me.Controls.Add(Me.CENTRO_FORMACIONTextBox)
        Me.Controls.Add(OPCIONLabel)
        Me.Controls.Add(Me.OPCIONTextBox)
        Me.Controls.Add(GRUPOLabel)
        Me.Controls.Add(Me.GRUPOTextBox)
        Me.Controls.Add(HORARIOLabel)
        Me.Controls.Add(Me.HORARIOTextBox)
        Me.Controls.Add(CODIGOLabel)
        Me.Controls.Add(Me.CODIGOTextBox)
        Me.Controls.Add(COORDINADOR_CFPLabel)
        Me.Controls.Add(Me.COORDINADOR_CFPTextBox)
        Me.Controls.Add(DIRECTOR_CFPLabel)
        Me.Controls.Add(Me.DIRECTOR_CFPTextBox)
        Me.Controls.Add(PARTICIPANTES_PRESENTESLabel)
        Me.Controls.Add(Me.PARTICIPANTES_PRESENTESTextBox)
        Me.Controls.Add(PARTICIPANTES_AUSENTESLabel)
        Me.Controls.Add(Me.PARTICIPANTES_AUSENTESTextBox)
        Me.Controls.Add(PARTICIPANTES_INSCRITOSLabel)
        Me.Controls.Add(Me.PARTICIPANTES_INSCRITOSTextBox)
        Me.Controls.Add(PARTICIPANTES_DESERTADOSLabel)
        Me.Controls.Add(Me.PARTICIPANTES_DESERTADOSTextBox)
        Me.Controls.Add(PARTICIPANTES_SUPLENTESLabel)
        Me.Controls.Add(Me.PARTICIPANTES_SUPLENTESTextBox)
        Me.Controls.Add(OBJETIVO_VISITALabel)
        Me.Controls.Add(Me.OBJETIVO_VISITATextBox)
        Me.Controls.Add(NOTASLabel)
        Me.Controls.Add(Me.NOTASTextBox)
        Me.Controls.Add(DURACION_VISITALabel)
        Me.Controls.Add(Me.DURACION_VISITATextBox)
        Me.Name = "ucDetalleSUPERVISION_AF"
        Me.Size = New System.Drawing.Size(382, 554)
        CType(Me.ListaSUPERVISION_AFBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaSUPERVISION_AFBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ID_SUPERVISION_AFTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ID_MODALIDAD_FORMACIONcbxMODALIDAD_DE_FORMACION As SGAFP.WinUC.cbxMODALIDAD_DE_FORMACION
    Friend WithEvents ID_ACCION_FORMATIVAcbxACCION_FORMATIVA As SGAFP.WinUC.cbxACCION_FORMATIVA
    Friend WithEvents FECHADateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents NOMBRE_AFTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CENTRO_FORMACIONTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OPCIONTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GRUPOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HORARIOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CODIGOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents COORDINADOR_CFPTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DIRECTOR_CFPTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PARTICIPANTES_PRESENTESTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PARTICIPANTES_AUSENTESTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PARTICIPANTES_INSCRITOSTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PARTICIPANTES_DESERTADOSTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PARTICIPANTES_SUPLENTESTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OBJETIVO_VISITATextBox As System.Windows.Forms.TextBox
    Friend WithEvents NOTASTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DURACION_VISITATextBox As System.Windows.Forms.TextBox

End Class
