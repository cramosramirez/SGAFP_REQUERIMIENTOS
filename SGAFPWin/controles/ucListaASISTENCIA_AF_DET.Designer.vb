<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucListaASISTENCIA_AF_DET
    Inherits SGAFP.ucBaseLista

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
        Me.ListaASISTENCIA_AF_DETBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListaASISTENCIA_AF_DETDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxID_ASISTENCIA_DET = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxID_ASISTENCIA_AF = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxID_PARTICIPANTE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxASISTIO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxPRESENTA_JUSTIFICACION = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxJUSTIFICACION = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.ListaASISTENCIA_AF_DETBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaASISTENCIA_AF_DETDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListaASISTENCIA_AF_DETBindingSource
        '
        Me.ListaASISTENCIA_AF_DETBindingSource.DataSource = GetType(SGAFP.EL.ASISTENCIA_AF_DET)
        '
        'ListaASISTENCIA_AF_DETDataGridView
        '
        Me.ListaASISTENCIA_AF_DETDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListaASISTENCIA_AF_DETDataGridView.AutoGenerateColumns = False
        Me.ListaASISTENCIA_AF_DETDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxID_ASISTENCIA_DET, Me.DataGridViewTextBoxID_ASISTENCIA_AF, Me.DataGridViewTextBoxID_PARTICIPANTE, Me.DataGridViewTextBoxASISTIO, Me.DataGridViewTextBoxPRESENTA_JUSTIFICACION, Me.DataGridViewTextBoxJUSTIFICACION})
        Me.ListaASISTENCIA_AF_DETDataGridView.DataSource = Me.ListaASISTENCIA_AF_DETBindingSource
        Me.ListaASISTENCIA_AF_DETDataGridView.Location = New System.Drawing.Point(3, 28)
        Me.ListaASISTENCIA_AF_DETDataGridView.Name = "ListaASISTENCIA_AF_DETDataGridView"
        Me.ListaASISTENCIA_AF_DETDataGridView.Size = New System.Drawing.Size(523, 323)
        Me.ListaASISTENCIA_AF_DETDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxID_ASISTENCIA_DET
        '
        Me.DataGridViewTextBoxID_ASISTENCIA_DET.DataPropertyName = "ID_ASISTENCIA_DET"
        Me.DataGridViewTextBoxID_ASISTENCIA_DET.HeaderText = "Id asistencia det"
        Me.DataGridViewTextBoxID_ASISTENCIA_DET.Name = "DataGridViewTextBoxID_ASISTENCIA_DET"
        '
        'DataGridViewTextBoxID_ASISTENCIA_AF
        '
        Me.DataGridViewTextBoxID_ASISTENCIA_AF.DataPropertyName = "ID_ASISTENCIA_AF"
        Me.DataGridViewTextBoxID_ASISTENCIA_AF.HeaderText = "Id asistencia af"
        Me.DataGridViewTextBoxID_ASISTENCIA_AF.Name = "DataGridViewTextBoxID_ASISTENCIA_AF"
        '
        'DataGridViewTextBoxID_PARTICIPANTE
        '
        Me.DataGridViewTextBoxID_PARTICIPANTE.DataPropertyName = "ID_PARTICIPANTE"
        Me.DataGridViewTextBoxID_PARTICIPANTE.HeaderText = "Id participante"
        Me.DataGridViewTextBoxID_PARTICIPANTE.Name = "DataGridViewTextBoxID_PARTICIPANTE"
        '
        'DataGridViewTextBoxASISTIO
        '
        Me.DataGridViewTextBoxASISTIO.DataPropertyName = "ASISTIO"
        Me.DataGridViewTextBoxASISTIO.HeaderText = "Asistio"
        Me.DataGridViewTextBoxASISTIO.Name = "DataGridViewTextBoxASISTIO"
        '
        'DataGridViewTextBoxPRESENTA_JUSTIFICACION
        '
        Me.DataGridViewTextBoxPRESENTA_JUSTIFICACION.DataPropertyName = "PRESENTA_JUSTIFICACION"
        Me.DataGridViewTextBoxPRESENTA_JUSTIFICACION.HeaderText = "Presenta justificacion"
        Me.DataGridViewTextBoxPRESENTA_JUSTIFICACION.Name = "DataGridViewTextBoxPRESENTA_JUSTIFICACION"
        '
        'DataGridViewTextBoxJUSTIFICACION
        '
        Me.DataGridViewTextBoxJUSTIFICACION.DataPropertyName = "JUSTIFICACION"
        Me.DataGridViewTextBoxJUSTIFICACION.HeaderText = "Justificacion"
        Me.DataGridViewTextBoxJUSTIFICACION.Name = "DataGridViewTextBoxJUSTIFICACION"
        '
        'ucListaASISTENCIA_AF_DET
        '
        Me.Controls.Add(Me.ListaASISTENCIA_AF_DETDataGridView)
        Me.Name = "ucListaASISTENCIA_AF_DET"
        Me.Size = New System.Drawing.Size(529, 354)
        Me.Controls.SetChildIndex(Me.ListaASISTENCIA_AF_DETDataGridView, 0)
        CType(Me.ListaASISTENCIA_AF_DETBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaASISTENCIA_AF_DETDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaASISTENCIA_AF_DETBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListaASISTENCIA_AF_DETDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxID_ASISTENCIA_DET As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxID_ASISTENCIA_AF As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxID_PARTICIPANTE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxASISTIO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxPRESENTA_JUSTIFICACION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxJUSTIFICACION As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
