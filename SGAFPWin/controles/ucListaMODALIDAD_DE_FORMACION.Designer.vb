<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucListaMODALIDAD_DE_FORMACION
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
        Me.ListaMODALIDAD_DE_FORMACIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListaMODALIDAD_DE_FORMACIONGridControl = New DevExpress.XtraGrid.GridControl()
        Me.ListaMODALIDAD_DE_FORMACIONGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID_MODALIDAD_FORMACION = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMODALIDAD_FORMACION = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNOTAS = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.ListaMODALIDAD_DE_FORMACIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaMODALIDAD_DE_FORMACIONGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaMODALIDAD_DE_FORMACIONGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListaMODALIDAD_DE_FORMACIONBindingSource
        '
        Me.ListaMODALIDAD_DE_FORMACIONBindingSource.DataSource = GetType(SGAFP.EL.MODALIDAD_DE_FORMACION)
        '
        'ListaMODALIDAD_DE_FORMACIONGridControl
        '
        Me.ListaMODALIDAD_DE_FORMACIONGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListaMODALIDAD_DE_FORMACIONGridControl.DataSource = Me.ListaMODALIDAD_DE_FORMACIONBindingSource
        Me.ListaMODALIDAD_DE_FORMACIONGridControl.Location = New System.Drawing.Point(3, 28)
        Me.ListaMODALIDAD_DE_FORMACIONGridControl.MainView = Me.ListaMODALIDAD_DE_FORMACIONGridView
        Me.ListaMODALIDAD_DE_FORMACIONGridControl.Name = "ListaMODALIDAD_DE_FORMACIONGridControl"
        Me.ListaMODALIDAD_DE_FORMACIONGridControl.Size = New System.Drawing.Size(523, 323)
        Me.ListaMODALIDAD_DE_FORMACIONGridControl.TabIndex = 1
        Me.ListaMODALIDAD_DE_FORMACIONGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.ListaMODALIDAD_DE_FORMACIONGridView})
        '
        'ListaMODALIDAD_DE_FORMACIONGridView
        '
        Me.ListaMODALIDAD_DE_FORMACIONGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID_MODALIDAD_FORMACION, Me.colMODALIDAD_FORMACION, Me.colNOTAS})
        Me.ListaMODALIDAD_DE_FORMACIONGridView.GridControl = Me.ListaMODALIDAD_DE_FORMACIONGridControl
        Me.ListaMODALIDAD_DE_FORMACIONGridView.Name = "ListaMODALIDAD_DE_FORMACIONGridView"
        Me.ListaMODALIDAD_DE_FORMACIONGridView.OptionsView.ShowGroupPanel = False
        '
        'colID_MODALIDAD_FORMACION
        '
        Me.colID_MODALIDAD_FORMACION.Caption = "Id modalidad formacion"
        Me.colID_MODALIDAD_FORMACION.FieldName = "ID_MODALIDAD_FORMACION"
        Me.colID_MODALIDAD_FORMACION.Name = "colID_MODALIDAD_FORMACION"
        Me.colID_MODALIDAD_FORMACION.Visible = True
        Me.colID_MODALIDAD_FORMACION.VisibleIndex = 0
        '
        'colMODALIDAD_FORMACION
        '
        Me.colMODALIDAD_FORMACION.Caption = "Modalidad formacion"
        Me.colMODALIDAD_FORMACION.FieldName = "MODALIDAD_FORMACION"
        Me.colMODALIDAD_FORMACION.Name = "colMODALIDAD_FORMACION"
        Me.colMODALIDAD_FORMACION.Visible = True
        Me.colMODALIDAD_FORMACION.VisibleIndex = 1
        '
        'colNOTAS
        '
        Me.colNOTAS.Caption = "Notas"
        Me.colNOTAS.FieldName = "NOTAS"
        Me.colNOTAS.Name = "colNOTAS"
        Me.colNOTAS.Visible = True
        Me.colNOTAS.VisibleIndex = 2
        '
        'ucListaMODALIDAD_DE_FORMACION
        '
        Me.Controls.Add(Me.ListaMODALIDAD_DE_FORMACIONGridControl)
        Me.Name = "ucListaMODALIDAD_DE_FORMACION"
        Me.Size = New System.Drawing.Size(529, 354)
        Me.Controls.SetChildIndex(Me.ListaMODALIDAD_DE_FORMACIONGridControl, 0)
        CType(Me.ListaMODALIDAD_DE_FORMACIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaMODALIDAD_DE_FORMACIONGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaMODALIDAD_DE_FORMACIONGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaMODALIDAD_DE_FORMACIONBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListaMODALIDAD_DE_FORMACIONGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents ListaMODALIDAD_DE_FORMACIONGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID_MODALIDAD_FORMACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMODALIDAD_FORMACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOTAS As DevExpress.XtraGrid.Columns.GridColumn

End Class
