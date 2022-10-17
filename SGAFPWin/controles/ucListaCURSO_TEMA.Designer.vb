<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucListaCURSO_TEMA
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
        Me.ListaCURSO_TEMABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListaCURSO_TEMADataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxID_TEMA_CURSO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxID_AREA_FORMACION = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxTEMA_CURSO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxDURACION_HORAS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxFECHA_ACREDITACION = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxNOTAS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxUSERID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxLASTUPDATE = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.ListaCURSO_TEMABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaCURSO_TEMADataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListaCURSO_TEMABindingSource
        '
        Me.ListaCURSO_TEMABindingSource.DataSource = GetType(SGAFP.EL.CURSO_TEMA)
        '
        'ListaCURSO_TEMADataGridView
        '
        Me.ListaCURSO_TEMADataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListaCURSO_TEMADataGridView.AutoGenerateColumns = False
        Me.ListaCURSO_TEMADataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxID_TEMA_CURSO, Me.DataGridViewTextBoxID_AREA_FORMACION, Me.DataGridViewTextBoxTEMA_CURSO, Me.DataGridViewTextBoxDURACION_HORAS, Me.DataGridViewTextBoxFECHA_ACREDITACION, Me.DataGridViewTextBoxNOTAS, Me.DataGridViewTextBoxUSERID, Me.DataGridViewTextBoxLASTUPDATE})
        Me.ListaCURSO_TEMADataGridView.DataSource = Me.ListaCURSO_TEMABindingSource
        Me.ListaCURSO_TEMADataGridView.Location = New System.Drawing.Point(3, 28)
        Me.ListaCURSO_TEMADataGridView.Name = "ListaCURSO_TEMADataGridView"
        Me.ListaCURSO_TEMADataGridView.Size = New System.Drawing.Size(523, 323)
        Me.ListaCURSO_TEMADataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxID_TEMA_CURSO
        '
        Me.DataGridViewTextBoxID_TEMA_CURSO.DataPropertyName = "ID_TEMA_CURSO"
        Me.DataGridViewTextBoxID_TEMA_CURSO.HeaderText = "Id tema curso"
        Me.DataGridViewTextBoxID_TEMA_CURSO.Name = "DataGridViewTextBoxID_TEMA_CURSO"
        '
        'DataGridViewTextBoxID_AREA_FORMACION
        '
        Me.DataGridViewTextBoxID_AREA_FORMACION.DataPropertyName = "ID_AREA_FORMACION"
        Me.DataGridViewTextBoxID_AREA_FORMACION.HeaderText = "Id area formacion"
        Me.DataGridViewTextBoxID_AREA_FORMACION.Name = "DataGridViewTextBoxID_AREA_FORMACION"
        '
        'DataGridViewTextBoxTEMA_CURSO
        '
        Me.DataGridViewTextBoxTEMA_CURSO.DataPropertyName = "TEMA_CURSO"
        Me.DataGridViewTextBoxTEMA_CURSO.HeaderText = "Tema curso"
        Me.DataGridViewTextBoxTEMA_CURSO.Name = "DataGridViewTextBoxTEMA_CURSO"
        '
        'DataGridViewTextBoxDURACION_HORAS
        '
        Me.DataGridViewTextBoxDURACION_HORAS.DataPropertyName = "DURACION_HORAS"
        Me.DataGridViewTextBoxDURACION_HORAS.HeaderText = "Duracion horas"
        Me.DataGridViewTextBoxDURACION_HORAS.Name = "DataGridViewTextBoxDURACION_HORAS"
        '
        'DataGridViewTextBoxFECHA_ACREDITACION
        '
        Me.DataGridViewTextBoxFECHA_ACREDITACION.DataPropertyName = "FECHA_ACREDITACION"
        Me.DataGridViewTextBoxFECHA_ACREDITACION.HeaderText = "Fecha acreditacion"
        Me.DataGridViewTextBoxFECHA_ACREDITACION.Name = "DataGridViewTextBoxFECHA_ACREDITACION"
        '
        'DataGridViewTextBoxNOTAS
        '
        Me.DataGridViewTextBoxNOTAS.DataPropertyName = "NOTAS"
        Me.DataGridViewTextBoxNOTAS.HeaderText = "Notas"
        Me.DataGridViewTextBoxNOTAS.Name = "DataGridViewTextBoxNOTAS"
        '
        'DataGridViewTextBoxUSERID
        '
        Me.DataGridViewTextBoxUSERID.DataPropertyName = "USERID"
        Me.DataGridViewTextBoxUSERID.HeaderText = "Userid"
        Me.DataGridViewTextBoxUSERID.Name = "DataGridViewTextBoxUSERID"
        '
        'DataGridViewTextBoxLASTUPDATE
        '
        Me.DataGridViewTextBoxLASTUPDATE.DataPropertyName = "LASTUPDATE"
        Me.DataGridViewTextBoxLASTUPDATE.HeaderText = "Lastupdate"
        Me.DataGridViewTextBoxLASTUPDATE.Name = "DataGridViewTextBoxLASTUPDATE"
        '
        'ucListaCURSO_TEMA
        '
        Me.Controls.Add(Me.ListaCURSO_TEMADataGridView)
        Me.Name = "ucListaCURSO_TEMA"
        Me.Size = New System.Drawing.Size(529, 354)
        Me.Controls.SetChildIndex(Me.ListaCURSO_TEMADataGridView, 0)
        CType(Me.ListaCURSO_TEMABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaCURSO_TEMADataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaCURSO_TEMABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListaCURSO_TEMADataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxID_TEMA_CURSO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxID_AREA_FORMACION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxTEMA_CURSO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxDURACION_HORAS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxFECHA_ACREDITACION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxNOTAS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxUSERID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxLASTUPDATE As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
