<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucListaPARTICIPANTE_EXONERADO_DOC
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
        Me.ListaPARTICIPANTE_EXONERADO_DOCBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListaPARTICIPANTE_EXONERADO_DOCGridControl = New DevExpress.XtraGrid.GridControl
        Me.ListaPARTICIPANTE_EXONERADO_DOCGridView = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colID_PARTICIPANTE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUSERID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colLASTUPDATE = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.ListaPARTICIPANTE_EXONERADO_DOCBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaPARTICIPANTE_EXONERADO_DOCGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaPARTICIPANTE_EXONERADO_DOCGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListaPARTICIPANTE_EXONERADO_DOCBindingSource
        '
        Me.ListaPARTICIPANTE_EXONERADO_DOCBindingSource.DataSource = GetType(SGAFP.EL.PARTICIPANTE_EXONERADO_DOC)
        '
        'ListaPARTICIPANTE_EXONERADO_DOCGridControl
        '
        Me.ListaPARTICIPANTE_EXONERADO_DOCGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListaPARTICIPANTE_EXONERADO_DOCGridControl.DataSource = Me.ListaPARTICIPANTE_EXONERADO_DOCBindingSource
        Me.ListaPARTICIPANTE_EXONERADO_DOCGridControl.Location = New System.Drawing.Point(3, 28)
        Me.ListaPARTICIPANTE_EXONERADO_DOCGridControl.MainView = Me.ListaPARTICIPANTE_EXONERADO_DOCGridView
        Me.ListaPARTICIPANTE_EXONERADO_DOCGridControl.Name = "ListaPARTICIPANTE_EXONERADO_DOCGridControl"
        Me.ListaPARTICIPANTE_EXONERADO_DOCGridControl.Size = New System.Drawing.Size(523, 323)
        Me.ListaPARTICIPANTE_EXONERADO_DOCGridControl.TabIndex = 1
        Me.ListaPARTICIPANTE_EXONERADO_DOCGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.ListaPARTICIPANTE_EXONERADO_DOCGridView})
        '
        'ListaPARTICIPANTE_EXONERADO_DOCGridView
        '
        Me.ListaPARTICIPANTE_EXONERADO_DOCGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID_PARTICIPANTE, Me.colUSERID, Me.colLASTUPDATE})
        Me.ListaPARTICIPANTE_EXONERADO_DOCGridView.GridControl = Me.ListaPARTICIPANTE_EXONERADO_DOCGridControl
        Me.ListaPARTICIPANTE_EXONERADO_DOCGridView.Name = "ListaPARTICIPANTE_EXONERADO_DOCGridView"
        Me.ListaPARTICIPANTE_EXONERADO_DOCGridView.OptionsView.ShowGroupPanel = False
        '
        'colID_PARTICIPANTE
        '
        Me.colID_PARTICIPANTE.Caption = "Id participante"
        Me.colID_PARTICIPANTE.FieldName = "ID_PARTICIPANTE"
        Me.colID_PARTICIPANTE.Name = "colID_PARTICIPANTE"
        Me.colID_PARTICIPANTE.Visible = True
        Me.colID_PARTICIPANTE.VisibleIndex = 0
        '
        'colUSERID
        '
        Me.colUSERID.Caption = "Userid"
        Me.colUSERID.FieldName = "USERID"
        Me.colUSERID.Name = "colUSERID"
        Me.colUSERID.Visible = True
        Me.colUSERID.VisibleIndex = 1
        '
        'colLASTUPDATE
        '
        Me.colLASTUPDATE.Caption = "Lastupdate"
        Me.colLASTUPDATE.FieldName = "LASTUPDATE"
        Me.colLASTUPDATE.Name = "colLASTUPDATE"
        Me.colLASTUPDATE.Visible = True
        Me.colLASTUPDATE.VisibleIndex = 2
        '
        'ucListaPARTICIPANTE_EXONERADO_DOC
        '
        Me.Controls.Add(Me.ListaPARTICIPANTE_EXONERADO_DOCGridControl)
        Me.Name = "ucListaPARTICIPANTE_EXONERADO_DOC"
        Me.Size = New System.Drawing.Size(529, 354)
        Me.Controls.SetChildIndex(Me.ListaPARTICIPANTE_EXONERADO_DOCGridControl, 0)
        CType(Me.ListaPARTICIPANTE_EXONERADO_DOCBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaPARTICIPANTE_EXONERADO_DOCGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaPARTICIPANTE_EXONERADO_DOCGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaPARTICIPANTE_EXONERADO_DOCBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListaPARTICIPANTE_EXONERADO_DOCGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents ListaPARTICIPANTE_EXONERADO_DOCGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID_PARTICIPANTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUSERID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLASTUPDATE As DevExpress.XtraGrid.Columns.GridColumn

End Class
