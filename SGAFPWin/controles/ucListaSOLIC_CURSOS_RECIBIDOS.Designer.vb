<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucListaSOLIC_CURSOS_RECIBIDOS
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
        Me.ListaSOLIC_CURSOS_RECIBIDOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListaSOLIC_CURSOS_RECIBIDOSDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxID_CURSO_RECIBIDO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxID_SOLICITUD = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxNOMBRE_CURSO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxINSTITUCION_CURSO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxAPOYO_INSAFORP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxANIO = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.ListaSOLIC_CURSOS_RECIBIDOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaSOLIC_CURSOS_RECIBIDOSDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListaSOLIC_CURSOS_RECIBIDOSBindingSource
        '
        Me.ListaSOLIC_CURSOS_RECIBIDOSBindingSource.DataSource = GetType(SGAFP.EL.SOLIC_CURSOS_RECIBIDOS)
        '
        'ListaSOLIC_CURSOS_RECIBIDOSDataGridView
        '
        Me.ListaSOLIC_CURSOS_RECIBIDOSDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListaSOLIC_CURSOS_RECIBIDOSDataGridView.AutoGenerateColumns = False
        Me.ListaSOLIC_CURSOS_RECIBIDOSDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxID_CURSO_RECIBIDO, Me.DataGridViewTextBoxID_SOLICITUD, Me.DataGridViewTextBoxNOMBRE_CURSO, Me.DataGridViewTextBoxINSTITUCION_CURSO, Me.DataGridViewTextBoxAPOYO_INSAFORP, Me.DataGridViewTextBoxANIO})
        Me.ListaSOLIC_CURSOS_RECIBIDOSDataGridView.DataSource = Me.ListaSOLIC_CURSOS_RECIBIDOSBindingSource
        Me.ListaSOLIC_CURSOS_RECIBIDOSDataGridView.Location = New System.Drawing.Point(3, 28)
        Me.ListaSOLIC_CURSOS_RECIBIDOSDataGridView.Name = "ListaSOLIC_CURSOS_RECIBIDOSDataGridView"
        Me.ListaSOLIC_CURSOS_RECIBIDOSDataGridView.Size = New System.Drawing.Size(523, 323)
        Me.ListaSOLIC_CURSOS_RECIBIDOSDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxID_CURSO_RECIBIDO
        '
        Me.DataGridViewTextBoxID_CURSO_RECIBIDO.DataPropertyName = "ID_CURSO_RECIBIDO"
        Me.DataGridViewTextBoxID_CURSO_RECIBIDO.HeaderText = "Id curso recibido"
        Me.DataGridViewTextBoxID_CURSO_RECIBIDO.Name = "DataGridViewTextBoxID_CURSO_RECIBIDO"
        '
        'DataGridViewTextBoxID_SOLICITUD
        '
        Me.DataGridViewTextBoxID_SOLICITUD.DataPropertyName = "ID_SOLICITUD"
        Me.DataGridViewTextBoxID_SOLICITUD.HeaderText = "Id solicitud"
        Me.DataGridViewTextBoxID_SOLICITUD.Name = "DataGridViewTextBoxID_SOLICITUD"
        '
        'DataGridViewTextBoxNOMBRE_CURSO
        '
        Me.DataGridViewTextBoxNOMBRE_CURSO.DataPropertyName = "NOMBRE_CURSO"
        Me.DataGridViewTextBoxNOMBRE_CURSO.HeaderText = "Nombre curso"
        Me.DataGridViewTextBoxNOMBRE_CURSO.Name = "DataGridViewTextBoxNOMBRE_CURSO"
        '
        'DataGridViewTextBoxINSTITUCION_CURSO
        '
        Me.DataGridViewTextBoxINSTITUCION_CURSO.DataPropertyName = "INSTITUCION_CURSO"
        Me.DataGridViewTextBoxINSTITUCION_CURSO.HeaderText = "Institucion curso"
        Me.DataGridViewTextBoxINSTITUCION_CURSO.Name = "DataGridViewTextBoxINSTITUCION_CURSO"
        '
        'DataGridViewTextBoxAPOYO_INSAFORP
        '
        Me.DataGridViewTextBoxAPOYO_INSAFORP.DataPropertyName = "APOYO_INSAFORP"
        Me.DataGridViewTextBoxAPOYO_INSAFORP.HeaderText = "Apoyo insaforp"
        Me.DataGridViewTextBoxAPOYO_INSAFORP.Name = "DataGridViewTextBoxAPOYO_INSAFORP"
        '
        'DataGridViewTextBoxANIO
        '
        Me.DataGridViewTextBoxANIO.DataPropertyName = "ANIO"
        Me.DataGridViewTextBoxANIO.HeaderText = "Anio"
        Me.DataGridViewTextBoxANIO.Name = "DataGridViewTextBoxANIO"
        '
        'ucListaSOLIC_CURSOS_RECIBIDOS
        '
        Me.Controls.Add(Me.ListaSOLIC_CURSOS_RECIBIDOSDataGridView)
        Me.Name = "ucListaSOLIC_CURSOS_RECIBIDOS"
        Me.Size = New System.Drawing.Size(529, 354)
        Me.Controls.SetChildIndex(Me.ListaSOLIC_CURSOS_RECIBIDOSDataGridView, 0)
        CType(Me.ListaSOLIC_CURSOS_RECIBIDOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaSOLIC_CURSOS_RECIBIDOSDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaSOLIC_CURSOS_RECIBIDOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListaSOLIC_CURSOS_RECIBIDOSDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxID_CURSO_RECIBIDO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxID_SOLICITUD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxNOMBRE_CURSO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxINSTITUCION_CURSO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxAPOYO_INSAFORP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxANIO As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
