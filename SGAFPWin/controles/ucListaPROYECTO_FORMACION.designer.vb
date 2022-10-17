<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucListaPROYECTO_FORMACION
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
        Me.ListaPROYECTO_FORMACIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListaPROYECTO_FORMACIONGridControl = New DevExpress.XtraGrid.GridControl
        Me.ListaPROYECTO_FORMACIONGridView = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colID_PROYECTO_FORMACION = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNOMBRE_PROYECTO_FORMACION = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUSERID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colLASTUPDATE = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.ListaPROYECTO_FORMACIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaPROYECTO_FORMACIONGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaPROYECTO_FORMACIONGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListaPROYECTO_FORMACIONBindingSource
        '
        Me.ListaPROYECTO_FORMACIONBindingSource.DataSource = GetType(SGAFP.EL.PROYECTO_FORMACION)
        '
        'ListaPROYECTO_FORMACIONGridControl
        '
        Me.ListaPROYECTO_FORMACIONGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListaPROYECTO_FORMACIONGridControl.DataSource = Me.ListaPROYECTO_FORMACIONBindingSource
        Me.ListaPROYECTO_FORMACIONGridControl.Location = New System.Drawing.Point(3, 28)
        Me.ListaPROYECTO_FORMACIONGridControl.MainView = Me.ListaPROYECTO_FORMACIONGridView
        Me.ListaPROYECTO_FORMACIONGridControl.Name = "ListaPROYECTO_FORMACIONGridControl"
        Me.ListaPROYECTO_FORMACIONGridControl.Size = New System.Drawing.Size(523, 323)
        Me.ListaPROYECTO_FORMACIONGridControl.TabIndex = 1
        Me.ListaPROYECTO_FORMACIONGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.ListaPROYECTO_FORMACIONGridView})
        '
        'ListaPROYECTO_FORMACIONGridView
        '
        Me.ListaPROYECTO_FORMACIONGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID_PROYECTO_FORMACION, Me.colNOMBRE_PROYECTO_FORMACION, Me.colUSERID, Me.colLASTUPDATE})
        Me.ListaPROYECTO_FORMACIONGridView.GridControl = Me.ListaPROYECTO_FORMACIONGridControl
        Me.ListaPROYECTO_FORMACIONGridView.Name = "ListaPROYECTO_FORMACIONGridView"
        Me.ListaPROYECTO_FORMACIONGridView.OptionsView.ShowGroupPanel = False
        '
        'colID_PROYECTO_FORMACION
        '
        Me.colID_PROYECTO_FORMACION.Caption = "Id Proyecto Formación"
        Me.colID_PROYECTO_FORMACION.FieldName = "ID_PROYECTO_FORMACION"
        Me.colID_PROYECTO_FORMACION.Name = "colID_PROYECTO_FORMACION"
        Me.colID_PROYECTO_FORMACION.Visible = True
        Me.colID_PROYECTO_FORMACION.VisibleIndex = 0
        Me.colID_PROYECTO_FORMACION.Width = 60
        '
        'colNOMBRE_PROYECTO_FORMACION
        '
        Me.colNOMBRE_PROYECTO_FORMACION.Caption = "Nombre Proyecto Formación"
        Me.colNOMBRE_PROYECTO_FORMACION.FieldName = "NOMBRE_PROYECTO_FORMACION"
        Me.colNOMBRE_PROYECTO_FORMACION.Name = "colNOMBRE_PROYECTO_FORMACION"
        Me.colNOMBRE_PROYECTO_FORMACION.Visible = True
        Me.colNOMBRE_PROYECTO_FORMACION.VisibleIndex = 1
        Me.colNOMBRE_PROYECTO_FORMACION.Width = 445
        '
        'colUSERID
        '
        Me.colUSERID.Caption = "Userid"
        Me.colUSERID.FieldName = "USERID"
        Me.colUSERID.Name = "colUSERID"
        Me.colUSERID.Width = 151
        '
        'colLASTUPDATE
        '
        Me.colLASTUPDATE.Caption = "Lastupdate"
        Me.colLASTUPDATE.FieldName = "LASTUPDATE"
        Me.colLASTUPDATE.Name = "colLASTUPDATE"
        Me.colLASTUPDATE.Width = 153
        '
        'ucListaPROYECTO_FORMACION
        '
        Me.Controls.Add(Me.ListaPROYECTO_FORMACIONGridControl)
        Me.Name = "ucListaPROYECTO_FORMACION"
        Me.Size = New System.Drawing.Size(529, 354)
        Me.Controls.SetChildIndex(Me.ListaPROYECTO_FORMACIONGridControl, 0)
        CType(Me.ListaPROYECTO_FORMACIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaPROYECTO_FORMACIONGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaPROYECTO_FORMACIONGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaPROYECTO_FORMACIONBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListaPROYECTO_FORMACIONGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents ListaPROYECTO_FORMACIONGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID_PROYECTO_FORMACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRE_PROYECTO_FORMACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUSERID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLASTUPDATE As DevExpress.XtraGrid.Columns.GridColumn

End Class
