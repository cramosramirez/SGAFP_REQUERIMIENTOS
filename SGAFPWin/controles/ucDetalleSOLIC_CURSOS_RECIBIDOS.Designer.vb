<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucDetalleSOLIC_CURSOS_RECIBIDOS
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
        Dim ID_CURSO_RECIBIDOLabel As System.Windows.Forms.Label
        Dim ID_SOLICITUDLabel As System.Windows.Forms.Label
        Dim NOMBRE_CURSOLabel As System.Windows.Forms.Label
        Dim INSTITUCION_CURSOLabel As System.Windows.Forms.Label
        Dim APOYO_INSAFORPLabel As System.Windows.Forms.Label
        Dim ANIOLabel As System.Windows.Forms.Label
        Me.ListaSOLIC_CURSOS_RECIBIDOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ID_CURSO_RECIBIDOTextBox = New System.Windows.Forms.TextBox
        Me.ID_SOLICITUDcbxSOLICITUD_INSCRIPCION_AF = New SGAFP.WinUC.cbxSOLICITUD_INSCRIPCION_AF
        Me.NOMBRE_CURSOTextBox = New System.Windows.Forms.TextBox
        Me.INSTITUCION_CURSOTextBox = New System.Windows.Forms.TextBox
        Me.APOYO_INSAFORPTextBox = New System.Windows.Forms.TextBox
        Me.ANIOTextBox = New System.Windows.Forms.TextBox
        ID_CURSO_RECIBIDOLabel = New System.Windows.Forms.Label
        ID_SOLICITUDLabel = New System.Windows.Forms.Label
        NOMBRE_CURSOLabel = New System.Windows.Forms.Label
        INSTITUCION_CURSOLabel = New System.Windows.Forms.Label
        APOYO_INSAFORPLabel = New System.Windows.Forms.Label
        ANIOLabel = New System.Windows.Forms.Label
        CType(Me.ListaSOLIC_CURSOS_RECIBIDOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ID_CURSO_RECIBIDOLabel
        '
        ID_CURSO_RECIBIDOLabel.Location = New System.Drawing.Point(6, 14)
        ID_CURSO_RECIBIDOLabel.Name = "ID_CURSO_RECIBIDOLabel"
        ID_CURSO_RECIBIDOLabel.Size = New System.Drawing.Size(135, 13)
        ID_CURSO_RECIBIDOLabel.TabIndex = 0
        ID_CURSO_RECIBIDOLabel.Text = "Id curso recibido:"
        '
        'ID_SOLICITUDLabel
        '
        ID_SOLICITUDLabel.Location = New System.Drawing.Point(6, 40)
        ID_SOLICITUDLabel.Name = "ID_SOLICITUDLabel"
        ID_SOLICITUDLabel.Size = New System.Drawing.Size(135, 13)
        ID_SOLICITUDLabel.TabIndex = 2
        ID_SOLICITUDLabel.Text = "Id solicitud:"
        '
        'NOMBRE_CURSOLabel
        '
        NOMBRE_CURSOLabel.Location = New System.Drawing.Point(6, 66)
        NOMBRE_CURSOLabel.Name = "NOMBRE_CURSOLabel"
        NOMBRE_CURSOLabel.Size = New System.Drawing.Size(135, 13)
        NOMBRE_CURSOLabel.TabIndex = 4
        NOMBRE_CURSOLabel.Text = "Nombre curso:"
        '
        'INSTITUCION_CURSOLabel
        '
        INSTITUCION_CURSOLabel.Location = New System.Drawing.Point(6, 92)
        INSTITUCION_CURSOLabel.Name = "INSTITUCION_CURSOLabel"
        INSTITUCION_CURSOLabel.Size = New System.Drawing.Size(135, 13)
        INSTITUCION_CURSOLabel.TabIndex = 6
        INSTITUCION_CURSOLabel.Text = "Institucion curso:"
        '
        'APOYO_INSAFORPLabel
        '
        APOYO_INSAFORPLabel.Location = New System.Drawing.Point(6, 118)
        APOYO_INSAFORPLabel.Name = "APOYO_INSAFORPLabel"
        APOYO_INSAFORPLabel.Size = New System.Drawing.Size(135, 13)
        APOYO_INSAFORPLabel.TabIndex = 8
        APOYO_INSAFORPLabel.Text = "Apoyo insaforp:"
        '
        'ANIOLabel
        '
        ANIOLabel.Location = New System.Drawing.Point(6, 144)
        ANIOLabel.Name = "ANIOLabel"
        ANIOLabel.Size = New System.Drawing.Size(135, 13)
        ANIOLabel.TabIndex = 10
        ANIOLabel.Text = "Anio:"
        '
        'ListaSOLIC_CURSOS_RECIBIDOSBindingSource
        '
        Me.ListaSOLIC_CURSOS_RECIBIDOSBindingSource.DataSource = GetType(SGAFP.EL.SOLIC_CURSOS_RECIBIDOS)
        '
        'ID_CURSO_RECIBIDOTextBox
        '
        Me.ID_CURSO_RECIBIDOTextBox.BackColor = System.Drawing.Color.Linen
        Me.ID_CURSO_RECIBIDOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaSOLIC_CURSOS_RECIBIDOSBindingSource, "ID_CURSO_RECIBIDO", True))
        Me.ID_CURSO_RECIBIDOTextBox.Location = New System.Drawing.Point(144, 8)
        Me.ID_CURSO_RECIBIDOTextBox.Name = "ID_CURSO_RECIBIDOTextBox"
        Me.ID_CURSO_RECIBIDOTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ID_CURSO_RECIBIDOTextBox.TabIndex = 1
        Me.ID_CURSO_RECIBIDOTextBox.ReadOnly = True
        '
        'ID_SOLICITUDcbxSOLICITUD_INSCRIPCION_AF
        '
        Me.ID_SOLICITUDcbxSOLICITUD_INSCRIPCION_AF.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ListaSOLIC_CURSOS_RECIBIDOSBindingSource, "ID_SOLICITUD", True))
        Me.ID_SOLICITUDcbxSOLICITUD_INSCRIPCION_AF.Location = New System.Drawing.Point(144, 34)
        Me.ID_SOLICITUDcbxSOLICITUD_INSCRIPCION_AF.Name = "ID_SOLICITUDcbxSOLICITUD_INSCRIPCION_AF"
        Me.ID_SOLICITUDcbxSOLICITUD_INSCRIPCION_AF.Size = New System.Drawing.Size(200, 20)
        Me.ID_SOLICITUDcbxSOLICITUD_INSCRIPCION_AF.TabIndex = 3
        '
        'NOMBRE_CURSOTextBox
        '
        Me.NOMBRE_CURSOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaSOLIC_CURSOS_RECIBIDOSBindingSource, "NOMBRE_CURSO", True))
        Me.NOMBRE_CURSOTextBox.Location = New System.Drawing.Point(144, 60)
        Me.NOMBRE_CURSOTextBox.Name = "NOMBRE_CURSOTextBox"
        Me.NOMBRE_CURSOTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NOMBRE_CURSOTextBox.TabIndex = 5
        Me.NOMBRE_CURSOTextBox.MaxLength = 100
        '
        'INSTITUCION_CURSOTextBox
        '
        Me.INSTITUCION_CURSOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaSOLIC_CURSOS_RECIBIDOSBindingSource, "INSTITUCION_CURSO", True))
        Me.INSTITUCION_CURSOTextBox.Location = New System.Drawing.Point(144, 86)
        Me.INSTITUCION_CURSOTextBox.Name = "INSTITUCION_CURSOTextBox"
        Me.INSTITUCION_CURSOTextBox.Size = New System.Drawing.Size(200, 20)
        Me.INSTITUCION_CURSOTextBox.TabIndex = 7
        Me.INSTITUCION_CURSOTextBox.MaxLength = 100
        '
        'APOYO_INSAFORPTextBox
        '
        Me.APOYO_INSAFORPTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaSOLIC_CURSOS_RECIBIDOSBindingSource, "APOYO_INSAFORP", True))
        Me.APOYO_INSAFORPTextBox.Location = New System.Drawing.Point(144, 112)
        Me.APOYO_INSAFORPTextBox.Name = "APOYO_INSAFORPTextBox"
        Me.APOYO_INSAFORPTextBox.Size = New System.Drawing.Size(200, 20)
        Me.APOYO_INSAFORPTextBox.TabIndex = 9
        '
        'ANIOTextBox
        '
        Me.ANIOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaSOLIC_CURSOS_RECIBIDOSBindingSource, "ANIO", True))
        Me.ANIOTextBox.Location = New System.Drawing.Point(144, 138)
        Me.ANIOTextBox.Name = "ANIOTextBox"
        Me.ANIOTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ANIOTextBox.TabIndex = 11
        '
        'ucDetalleSOLIC_CURSOS_RECIBIDOS
        '
        Me.AutoScroll = True
        Me.Controls.Add(ID_CURSO_RECIBIDOLabel)
        Me.Controls.Add(Me.ID_CURSO_RECIBIDOTextBox)
        Me.Controls.Add(ID_SOLICITUDLabel)
        Me.Controls.Add(Me.ID_SOLICITUDcbxSOLICITUD_INSCRIPCION_AF)
        Me.Controls.Add(NOMBRE_CURSOLabel)
        Me.Controls.Add(Me.NOMBRE_CURSOTextBox)
        Me.Controls.Add(INSTITUCION_CURSOLabel)
        Me.Controls.Add(Me.INSTITUCION_CURSOTextBox)
        Me.Controls.Add(APOYO_INSAFORPLabel)
        Me.Controls.Add(Me.APOYO_INSAFORPTextBox)
        Me.Controls.Add(ANIOLabel)
        Me.Controls.Add(Me.ANIOTextBox)
        Me.Name = "ucDetalleSOLIC_CURSOS_RECIBIDOS"
        Me.Size = New System.Drawing.Size(382, 190)
        CType(Me.ListaSOLIC_CURSOS_RECIBIDOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaSOLIC_CURSOS_RECIBIDOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ID_CURSO_RECIBIDOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ID_SOLICITUDcbxSOLICITUD_INSCRIPCION_AF As SGAFP.WinUC.cbxSOLICITUD_INSCRIPCION_AF
    Friend WithEvents NOMBRE_CURSOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents INSTITUCION_CURSOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents APOYO_INSAFORPTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ANIOTextBox As System.Windows.Forms.TextBox

End Class
