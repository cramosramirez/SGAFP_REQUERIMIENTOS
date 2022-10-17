<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucListaTIPO_CONTRATACION
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
        Me.ListaTIPO_CONTRATACIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListaTIPO_CONTRATACIONGridControl = New DevExpress.XtraGrid.GridControl()
        Me.ListaTIPO_CONTRATACIONGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID_TIPO_CONTRA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNOM_TIPO_CONTRA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUSUARIO_CREACION = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFECHA_CREACION = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUSERID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colLASTUPDATE = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.ListaTIPO_CONTRATACIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaTIPO_CONTRATACIONGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaTIPO_CONTRATACIONGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListaTIPO_CONTRATACIONBindingSource
        '
        Me.ListaTIPO_CONTRATACIONBindingSource.DataSource = GetType(SGAFP.EL.TIPO_CONTRATACION)
        '
        'ListaTIPO_CONTRATACIONGridControl
        '
        Me.ListaTIPO_CONTRATACIONGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListaTIPO_CONTRATACIONGridControl.DataSource = Me.ListaTIPO_CONTRATACIONBindingSource
        Me.ListaTIPO_CONTRATACIONGridControl.Location = New System.Drawing.Point(3, 28)
        Me.ListaTIPO_CONTRATACIONGridControl.MainView = Me.ListaTIPO_CONTRATACIONGridView
        Me.ListaTIPO_CONTRATACIONGridControl.Name = "ListaTIPO_CONTRATACIONGridControl"
        Me.ListaTIPO_CONTRATACIONGridControl.Size = New System.Drawing.Size(523, 323)
        Me.ListaTIPO_CONTRATACIONGridControl.TabIndex = 1
        Me.ListaTIPO_CONTRATACIONGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.ListaTIPO_CONTRATACIONGridView})
        '
        'ListaTIPO_CONTRATACIONGridView
        '
        Me.ListaTIPO_CONTRATACIONGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID_TIPO_CONTRA, Me.colNOM_TIPO_CONTRA, Me.colUSUARIO_CREACION, Me.colFECHA_CREACION, Me.colUSERID, Me.colLASTUPDATE})
        Me.ListaTIPO_CONTRATACIONGridView.GridControl = Me.ListaTIPO_CONTRATACIONGridControl
        Me.ListaTIPO_CONTRATACIONGridView.Name = "ListaTIPO_CONTRATACIONGridView"
        Me.ListaTIPO_CONTRATACIONGridView.OptionsView.ShowGroupPanel = False
        '
        'colID_TIPO_CONTRA
        '
        Me.colID_TIPO_CONTRA.Caption = "Id tipo contra"
        Me.colID_TIPO_CONTRA.FieldName = "ID_TIPO_CONTRA"
        Me.colID_TIPO_CONTRA.Name = "colID_TIPO_CONTRA"
        Me.colID_TIPO_CONTRA.Visible = True
        Me.colID_TIPO_CONTRA.VisibleIndex = 0
        '
        'colNOM_TIPO_CONTRA
        '
        Me.colNOM_TIPO_CONTRA.Caption = "Nom tipo contra"
        Me.colNOM_TIPO_CONTRA.FieldName = "NOM_TIPO_CONTRA"
        Me.colNOM_TIPO_CONTRA.Name = "colNOM_TIPO_CONTRA"
        Me.colNOM_TIPO_CONTRA.Visible = True
        Me.colNOM_TIPO_CONTRA.VisibleIndex = 1
        '
        'colUSUARIO_CREACION
        '
        Me.colUSUARIO_CREACION.Caption = "Usuario creacion"
        Me.colUSUARIO_CREACION.FieldName = "USUARIO_CREACION"
        Me.colUSUARIO_CREACION.Name = "colUSUARIO_CREACION"
        Me.colUSUARIO_CREACION.Visible = True
        Me.colUSUARIO_CREACION.VisibleIndex = 2
        '
        'colFECHA_CREACION
        '
        Me.colFECHA_CREACION.Caption = "Fecha creacion"
        Me.colFECHA_CREACION.FieldName = "FECHA_CREACION"
        Me.colFECHA_CREACION.Name = "colFECHA_CREACION"
        Me.colFECHA_CREACION.Visible = True
        Me.colFECHA_CREACION.VisibleIndex = 3
        '
        'colUSERID
        '
        Me.colUSERID.Caption = "Userid"
        Me.colUSERID.FieldName = "USERID"
        Me.colUSERID.Name = "colUSERID"
        Me.colUSERID.Visible = True
        Me.colUSERID.VisibleIndex = 4
        '
        'colLASTUPDATE
        '
        Me.colLASTUPDATE.Caption = "Lastupdate"
        Me.colLASTUPDATE.FieldName = "LASTUPDATE"
        Me.colLASTUPDATE.Name = "colLASTUPDATE"
        Me.colLASTUPDATE.Visible = True
        Me.colLASTUPDATE.VisibleIndex = 5
        '
        'ucListaTIPO_CONTRATACION
        '
        Me.Controls.Add(Me.ListaTIPO_CONTRATACIONGridControl)
        Me.Name = "ucListaTIPO_CONTRATACION"
        Me.Size = New System.Drawing.Size(529, 354)
        Me.Controls.SetChildIndex(Me.ListaTIPO_CONTRATACIONGridControl, 0)
        CType(Me.ListaTIPO_CONTRATACIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaTIPO_CONTRATACIONGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaTIPO_CONTRATACIONGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaTIPO_CONTRATACIONBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListaTIPO_CONTRATACIONGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents ListaTIPO_CONTRATACIONGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID_TIPO_CONTRA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOM_TIPO_CONTRA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUSUARIO_CREACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFECHA_CREACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUSERID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLASTUPDATE As DevExpress.XtraGrid.Columns.GridColumn

End Class
