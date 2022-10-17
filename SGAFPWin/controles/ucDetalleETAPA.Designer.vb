<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucDetalleETAPA
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
        Dim CODIGO_ETAPALabel As System.Windows.Forms.Label
        Dim CODIGO_PROCESOLabel As System.Windows.Forms.Label
        Dim ID_ESTADO_SOLICITUDLabel As System.Windows.Forms.Label
        Dim UNIDAD_DE_TIEMPOLabel As System.Windows.Forms.Label
        Dim NOMBRE_ETAPALabel As System.Windows.Forms.Label
        Dim ETAPA_ANTLabel As System.Windows.Forms.Label
        Dim ETAPA_SIGLabel As System.Windows.Forms.Label
        Dim TIPO_ETAPALabel As System.Windows.Forms.Label
        Dim DURACIONLabel As System.Windows.Forms.Label
        Dim ORDEN_EJECUCIONLabel As System.Windows.Forms.Label
        Dim USERIDLabel As System.Windows.Forms.Label
        Dim LASTUPDATELabel As System.Windows.Forms.Label
        Me.ListaETAPABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CODIGO_ETAPATextBox = New System.Windows.Forms.TextBox
        Me.CODIGO_PROCESOcbxPROCESO = New SGAFP.WinUC.cbxPROCESO
        Me.ID_ESTADO_SOLICITUDcbxESTADO_SOLICITUD = New SGAFP.WinUC.cbxESTADO_SOLICITUD
        Me.UNIDAD_DE_TIEMPOTextBox = New System.Windows.Forms.TextBox
        Me.NOMBRE_ETAPATextBox = New System.Windows.Forms.TextBox
        Me.ETAPA_ANTTextBox = New System.Windows.Forms.TextBox
        Me.ETAPA_SIGTextBox = New System.Windows.Forms.TextBox
        Me.TIPO_ETAPATextBox = New System.Windows.Forms.TextBox
        Me.DURACIONTextBox = New System.Windows.Forms.TextBox
        Me.ORDEN_EJECUCIONTextBox = New System.Windows.Forms.TextBox
        Me.USERIDTextBox = New System.Windows.Forms.TextBox
        Me.LASTUPDATEDateTimePicker = New System.Windows.Forms.DateTimePicker
        CODIGO_ETAPALabel = New System.Windows.Forms.Label
        CODIGO_PROCESOLabel = New System.Windows.Forms.Label
        ID_ESTADO_SOLICITUDLabel = New System.Windows.Forms.Label
        UNIDAD_DE_TIEMPOLabel = New System.Windows.Forms.Label
        NOMBRE_ETAPALabel = New System.Windows.Forms.Label
        ETAPA_ANTLabel = New System.Windows.Forms.Label
        ETAPA_SIGLabel = New System.Windows.Forms.Label
        TIPO_ETAPALabel = New System.Windows.Forms.Label
        DURACIONLabel = New System.Windows.Forms.Label
        ORDEN_EJECUCIONLabel = New System.Windows.Forms.Label
        USERIDLabel = New System.Windows.Forms.Label
        LASTUPDATELabel = New System.Windows.Forms.Label
        CType(Me.ListaETAPABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CODIGO_ETAPALabel
        '
        CODIGO_ETAPALabel.Location = New System.Drawing.Point(6, 14)
        CODIGO_ETAPALabel.Name = "CODIGO_ETAPALabel"
        CODIGO_ETAPALabel.Size = New System.Drawing.Size(135, 13)
        CODIGO_ETAPALabel.TabIndex = 0
        CODIGO_ETAPALabel.Text = "Codigo etapa:"
        '
        'CODIGO_PROCESOLabel
        '
        CODIGO_PROCESOLabel.Location = New System.Drawing.Point(6, 40)
        CODIGO_PROCESOLabel.Name = "CODIGO_PROCESOLabel"
        CODIGO_PROCESOLabel.Size = New System.Drawing.Size(135, 13)
        CODIGO_PROCESOLabel.TabIndex = 2
        CODIGO_PROCESOLabel.Text = "Codigo proceso:"
        '
        'ID_ESTADO_SOLICITUDLabel
        '
        ID_ESTADO_SOLICITUDLabel.Location = New System.Drawing.Point(6, 66)
        ID_ESTADO_SOLICITUDLabel.Name = "ID_ESTADO_SOLICITUDLabel"
        ID_ESTADO_SOLICITUDLabel.Size = New System.Drawing.Size(135, 13)
        ID_ESTADO_SOLICITUDLabel.TabIndex = 4
        ID_ESTADO_SOLICITUDLabel.Text = "Id estado solicitud:"
        '
        'UNIDAD_DE_TIEMPOLabel
        '
        UNIDAD_DE_TIEMPOLabel.Location = New System.Drawing.Point(6, 92)
        UNIDAD_DE_TIEMPOLabel.Name = "UNIDAD_DE_TIEMPOLabel"
        UNIDAD_DE_TIEMPOLabel.Size = New System.Drawing.Size(135, 13)
        UNIDAD_DE_TIEMPOLabel.TabIndex = 6
        UNIDAD_DE_TIEMPOLabel.Text = "Unidad de tiempo:"
        '
        'NOMBRE_ETAPALabel
        '
        NOMBRE_ETAPALabel.Location = New System.Drawing.Point(6, 118)
        NOMBRE_ETAPALabel.Name = "NOMBRE_ETAPALabel"
        NOMBRE_ETAPALabel.Size = New System.Drawing.Size(135, 13)
        NOMBRE_ETAPALabel.TabIndex = 8
        NOMBRE_ETAPALabel.Text = "Nombre etapa:"
        '
        'ETAPA_ANTLabel
        '
        ETAPA_ANTLabel.Location = New System.Drawing.Point(6, 144)
        ETAPA_ANTLabel.Name = "ETAPA_ANTLabel"
        ETAPA_ANTLabel.Size = New System.Drawing.Size(135, 13)
        ETAPA_ANTLabel.TabIndex = 10
        ETAPA_ANTLabel.Text = "Etapa ant:"
        '
        'ETAPA_SIGLabel
        '
        ETAPA_SIGLabel.Location = New System.Drawing.Point(6, 170)
        ETAPA_SIGLabel.Name = "ETAPA_SIGLabel"
        ETAPA_SIGLabel.Size = New System.Drawing.Size(135, 13)
        ETAPA_SIGLabel.TabIndex = 12
        ETAPA_SIGLabel.Text = "Etapa sig:"
        '
        'TIPO_ETAPALabel
        '
        TIPO_ETAPALabel.Location = New System.Drawing.Point(6, 196)
        TIPO_ETAPALabel.Name = "TIPO_ETAPALabel"
        TIPO_ETAPALabel.Size = New System.Drawing.Size(135, 13)
        TIPO_ETAPALabel.TabIndex = 14
        TIPO_ETAPALabel.Text = "Tipo etapa:"
        '
        'DURACIONLabel
        '
        DURACIONLabel.Location = New System.Drawing.Point(6, 222)
        DURACIONLabel.Name = "DURACIONLabel"
        DURACIONLabel.Size = New System.Drawing.Size(135, 13)
        DURACIONLabel.TabIndex = 16
        DURACIONLabel.Text = "Duracion:"
        '
        'ORDEN_EJECUCIONLabel
        '
        ORDEN_EJECUCIONLabel.Location = New System.Drawing.Point(6, 248)
        ORDEN_EJECUCIONLabel.Name = "ORDEN_EJECUCIONLabel"
        ORDEN_EJECUCIONLabel.Size = New System.Drawing.Size(135, 13)
        ORDEN_EJECUCIONLabel.TabIndex = 18
        ORDEN_EJECUCIONLabel.Text = "Orden ejecucion:"
        '
        'USERIDLabel
        '
        USERIDLabel.Location = New System.Drawing.Point(6, 274)
        USERIDLabel.Name = "USERIDLabel"
        USERIDLabel.Size = New System.Drawing.Size(135, 13)
        USERIDLabel.TabIndex = 20
        USERIDLabel.Text = "Userid:"
        '
        'LASTUPDATELabel
        '
        LASTUPDATELabel.Location = New System.Drawing.Point(6, 300)
        LASTUPDATELabel.Name = "LASTUPDATELabel"
        LASTUPDATELabel.Size = New System.Drawing.Size(135, 13)
        LASTUPDATELabel.TabIndex = 22
        LASTUPDATELabel.Text = "Lastupdate:"
        '
        'ListaETAPABindingSource
        '
        Me.ListaETAPABindingSource.DataSource = GetType(SGAFP.EL.ETAPA)
        '
        'CODIGO_ETAPATextBox
        '
        Me.CODIGO_ETAPATextBox.BackColor = System.Drawing.Color.Linen
        Me.CODIGO_ETAPATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaETAPABindingSource, "CODIGO_ETAPA", True))
        Me.CODIGO_ETAPATextBox.Location = New System.Drawing.Point(144, 8)
        Me.CODIGO_ETAPATextBox.Name = "CODIGO_ETAPATextBox"
        Me.CODIGO_ETAPATextBox.Size = New System.Drawing.Size(200, 20)
        Me.CODIGO_ETAPATextBox.TabIndex = 1
        Me.CODIGO_ETAPATextBox.ReadOnly = True
        Me.CODIGO_ETAPATextBox.MaxLength = 2
        '
        'CODIGO_PROCESOcbxPROCESO
        '
        Me.CODIGO_PROCESOcbxPROCESO.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ListaETAPABindingSource, "CODIGO_PROCESO", True))
        Me.CODIGO_PROCESOcbxPROCESO.Location = New System.Drawing.Point(144, 34)
        Me.CODIGO_PROCESOcbxPROCESO.Name = "CODIGO_PROCESOcbxPROCESO"
        Me.CODIGO_PROCESOcbxPROCESO.Size = New System.Drawing.Size(200, 20)
        Me.CODIGO_PROCESOcbxPROCESO.TabIndex = 3
        Me.CODIGO_PROCESOcbxPROCESO.BackColor = System.Drawing.Color.Linen
        Me.CODIGO_PROCESOcbxPROCESO.Enabled = False
        '
        'ID_ESTADO_SOLICITUDcbxESTADO_SOLICITUD
        '
        Me.ID_ESTADO_SOLICITUDcbxESTADO_SOLICITUD.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ListaETAPABindingSource, "ID_ESTADO_SOLICITUD", True))
        Me.ID_ESTADO_SOLICITUDcbxESTADO_SOLICITUD.Location = New System.Drawing.Point(144, 60)
        Me.ID_ESTADO_SOLICITUDcbxESTADO_SOLICITUD.Name = "ID_ESTADO_SOLICITUDcbxESTADO_SOLICITUD"
        Me.ID_ESTADO_SOLICITUDcbxESTADO_SOLICITUD.Size = New System.Drawing.Size(200, 20)
        Me.ID_ESTADO_SOLICITUDcbxESTADO_SOLICITUD.TabIndex = 5
        '
        'UNIDAD_DE_TIEMPOTextBox
        '
        Me.UNIDAD_DE_TIEMPOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaETAPABindingSource, "UNIDAD_DE_TIEMPO", True))
        Me.UNIDAD_DE_TIEMPOTextBox.Location = New System.Drawing.Point(144, 86)
        Me.UNIDAD_DE_TIEMPOTextBox.Name = "UNIDAD_DE_TIEMPOTextBox"
        Me.UNIDAD_DE_TIEMPOTextBox.Size = New System.Drawing.Size(200, 20)
        Me.UNIDAD_DE_TIEMPOTextBox.TabIndex = 7
        Me.UNIDAD_DE_TIEMPOTextBox.MaxLength = 1
        '
        'NOMBRE_ETAPATextBox
        '
        Me.NOMBRE_ETAPATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaETAPABindingSource, "NOMBRE_ETAPA", True))
        Me.NOMBRE_ETAPATextBox.Location = New System.Drawing.Point(144, 112)
        Me.NOMBRE_ETAPATextBox.Name = "NOMBRE_ETAPATextBox"
        Me.NOMBRE_ETAPATextBox.Size = New System.Drawing.Size(200, 20)
        Me.NOMBRE_ETAPATextBox.TabIndex = 9
        Me.NOMBRE_ETAPATextBox.MaxLength = 50
        '
        'ETAPA_ANTTextBox
        '
        Me.ETAPA_ANTTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaETAPABindingSource, "ETAPA_ANT", True))
        Me.ETAPA_ANTTextBox.Location = New System.Drawing.Point(144, 138)
        Me.ETAPA_ANTTextBox.Name = "ETAPA_ANTTextBox"
        Me.ETAPA_ANTTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ETAPA_ANTTextBox.TabIndex = 11
        Me.ETAPA_ANTTextBox.MaxLength = 2
        '
        'ETAPA_SIGTextBox
        '
        Me.ETAPA_SIGTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaETAPABindingSource, "ETAPA_SIG", True))
        Me.ETAPA_SIGTextBox.Location = New System.Drawing.Point(144, 164)
        Me.ETAPA_SIGTextBox.Name = "ETAPA_SIGTextBox"
        Me.ETAPA_SIGTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ETAPA_SIGTextBox.TabIndex = 13
        Me.ETAPA_SIGTextBox.MaxLength = 2
        '
        'TIPO_ETAPATextBox
        '
        Me.TIPO_ETAPATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaETAPABindingSource, "TIPO_ETAPA", True))
        Me.TIPO_ETAPATextBox.Location = New System.Drawing.Point(144, 190)
        Me.TIPO_ETAPATextBox.Name = "TIPO_ETAPATextBox"
        Me.TIPO_ETAPATextBox.Size = New System.Drawing.Size(200, 20)
        Me.TIPO_ETAPATextBox.TabIndex = 15
        Me.TIPO_ETAPATextBox.MaxLength = 1
        '
        'DURACIONTextBox
        '
        Me.DURACIONTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaETAPABindingSource, "DURACION", True))
        Me.DURACIONTextBox.Location = New System.Drawing.Point(144, 216)
        Me.DURACIONTextBox.Name = "DURACIONTextBox"
        Me.DURACIONTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DURACIONTextBox.TabIndex = 17
        '
        'ORDEN_EJECUCIONTextBox
        '
        Me.ORDEN_EJECUCIONTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaETAPABindingSource, "ORDEN_EJECUCION", True))
        Me.ORDEN_EJECUCIONTextBox.Location = New System.Drawing.Point(144, 242)
        Me.ORDEN_EJECUCIONTextBox.Name = "ORDEN_EJECUCIONTextBox"
        Me.ORDEN_EJECUCIONTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ORDEN_EJECUCIONTextBox.TabIndex = 19
        '
        'USERIDTextBox
        '
        Me.USERIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaETAPABindingSource, "USERID", True))
        Me.USERIDTextBox.Location = New System.Drawing.Point(144, 268)
        Me.USERIDTextBox.Name = "USERIDTextBox"
        Me.USERIDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.USERIDTextBox.TabIndex = 21
        Me.USERIDTextBox.MaxLength = 16
        '
        'LASTUPDATEDateTimePicker
        '
        Me.LASTUPDATEDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ListaETAPABindingSource, "LASTUPDATE", True))
        Me.LASTUPDATEDateTimePicker.Location = New System.Drawing.Point(144, 294)
        Me.LASTUPDATEDateTimePicker.Name = "LASTUPDATEDateTimePicker"
        Me.LASTUPDATEDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.LASTUPDATEDateTimePicker.TabIndex = 23
        '
        'ucDetalleETAPA
        '
        Me.AutoScroll = True
        Me.Controls.Add(CODIGO_ETAPALabel)
        Me.Controls.Add(Me.CODIGO_ETAPATextBox)
        Me.Controls.Add(CODIGO_PROCESOLabel)
        Me.Controls.Add(Me.CODIGO_PROCESOcbxPROCESO)
        Me.Controls.Add(ID_ESTADO_SOLICITUDLabel)
        Me.Controls.Add(Me.ID_ESTADO_SOLICITUDcbxESTADO_SOLICITUD)
        Me.Controls.Add(UNIDAD_DE_TIEMPOLabel)
        Me.Controls.Add(Me.UNIDAD_DE_TIEMPOTextBox)
        Me.Controls.Add(NOMBRE_ETAPALabel)
        Me.Controls.Add(Me.NOMBRE_ETAPATextBox)
        Me.Controls.Add(ETAPA_ANTLabel)
        Me.Controls.Add(Me.ETAPA_ANTTextBox)
        Me.Controls.Add(ETAPA_SIGLabel)
        Me.Controls.Add(Me.ETAPA_SIGTextBox)
        Me.Controls.Add(TIPO_ETAPALabel)
        Me.Controls.Add(Me.TIPO_ETAPATextBox)
        Me.Controls.Add(DURACIONLabel)
        Me.Controls.Add(Me.DURACIONTextBox)
        Me.Controls.Add(ORDEN_EJECUCIONLabel)
        Me.Controls.Add(Me.ORDEN_EJECUCIONTextBox)
        Me.Controls.Add(USERIDLabel)
        Me.Controls.Add(Me.USERIDTextBox)
        Me.Controls.Add(LASTUPDATELabel)
        Me.Controls.Add(Me.LASTUPDATEDateTimePicker)
        Me.Name = "ucDetalleETAPA"
        Me.Size = New System.Drawing.Size(382, 346)
        CType(Me.ListaETAPABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaETAPABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CODIGO_ETAPATextBox As System.Windows.Forms.TextBox
    Friend WithEvents CODIGO_PROCESOcbxPROCESO As SGAFP.WinUC.cbxPROCESO
    Friend WithEvents ID_ESTADO_SOLICITUDcbxESTADO_SOLICITUD As SGAFP.WinUC.cbxESTADO_SOLICITUD
    Friend WithEvents UNIDAD_DE_TIEMPOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NOMBRE_ETAPATextBox As System.Windows.Forms.TextBox
    Friend WithEvents ETAPA_ANTTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ETAPA_SIGTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TIPO_ETAPATextBox As System.Windows.Forms.TextBox
    Friend WithEvents DURACIONTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ORDEN_EJECUCIONTextBox As System.Windows.Forms.TextBox
    Friend WithEvents USERIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LASTUPDATEDateTimePicker As System.Windows.Forms.DateTimePicker

End Class
