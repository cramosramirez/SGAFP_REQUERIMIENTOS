<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucListaUNIDAD_ORGANIZATIVA
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
        Me.ListaUNIDAD_ORGANIZATIVABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListaUNIDAD_ORGANIZATIVAGridControl = New DevExpress.XtraGrid.GridControl()
        Me.ListaUNIDAD_ORGANIZATIVAGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID_UNIDAD_ORGANIZATIVA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNOMBRE_UNIDAD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCODIGO_UNIDAD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colID_UNIDAD_PADRE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colESTADO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUSERID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colLASTUPDATE = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.ListaUNIDAD_ORGANIZATIVABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaUNIDAD_ORGANIZATIVAGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaUNIDAD_ORGANIZATIVAGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListaUNIDAD_ORGANIZATIVABindingSource
        '
        Me.ListaUNIDAD_ORGANIZATIVABindingSource.DataSource = GetType(SGAFP.EL.UNIDAD_ORGANIZATIVA)
        '
        'ListaUNIDAD_ORGANIZATIVAGridControl
        '
        Me.ListaUNIDAD_ORGANIZATIVAGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListaUNIDAD_ORGANIZATIVAGridControl.DataSource = Me.ListaUNIDAD_ORGANIZATIVABindingSource
        Me.ListaUNIDAD_ORGANIZATIVAGridControl.Location = New System.Drawing.Point(3, 28)
        Me.ListaUNIDAD_ORGANIZATIVAGridControl.MainView = Me.ListaUNIDAD_ORGANIZATIVAGridView
        Me.ListaUNIDAD_ORGANIZATIVAGridControl.Name = "ListaUNIDAD_ORGANIZATIVAGridControl"
        Me.ListaUNIDAD_ORGANIZATIVAGridControl.Size = New System.Drawing.Size(523, 323)
        Me.ListaUNIDAD_ORGANIZATIVAGridControl.TabIndex = 1
        Me.ListaUNIDAD_ORGANIZATIVAGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.ListaUNIDAD_ORGANIZATIVAGridView})
        '
        'ListaUNIDAD_ORGANIZATIVAGridView
        '
        Me.ListaUNIDAD_ORGANIZATIVAGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID_UNIDAD_ORGANIZATIVA, Me.colNOMBRE_UNIDAD, Me.colCODIGO_UNIDAD, Me.colID_UNIDAD_PADRE, Me.colESTADO, Me.colUSERID, Me.colLASTUPDATE})
        Me.ListaUNIDAD_ORGANIZATIVAGridView.GridControl = Me.ListaUNIDAD_ORGANIZATIVAGridControl
        Me.ListaUNIDAD_ORGANIZATIVAGridView.Name = "ListaUNIDAD_ORGANIZATIVAGridView"
        Me.ListaUNIDAD_ORGANIZATIVAGridView.OptionsView.ShowGroupPanel = False
        '
        'colID_UNIDAD_ORGANIZATIVA
        '
        Me.colID_UNIDAD_ORGANIZATIVA.Caption = "Id unidad organizativa"
        Me.colID_UNIDAD_ORGANIZATIVA.FieldName = "ID_UNIDAD_ORGANIZATIVA"
        Me.colID_UNIDAD_ORGANIZATIVA.Name = "colID_UNIDAD_ORGANIZATIVA"
        Me.colID_UNIDAD_ORGANIZATIVA.Visible = True
        Me.colID_UNIDAD_ORGANIZATIVA.VisibleIndex = 0
        '
        'colNOMBRE_UNIDAD
        '
        Me.colNOMBRE_UNIDAD.Caption = "Nombre unidad"
        Me.colNOMBRE_UNIDAD.FieldName = "NOMBRE_UNIDAD"
        Me.colNOMBRE_UNIDAD.Name = "colNOMBRE_UNIDAD"
        Me.colNOMBRE_UNIDAD.Visible = True
        Me.colNOMBRE_UNIDAD.VisibleIndex = 1
        '
        'colCODIGO_UNIDAD
        '
        Me.colCODIGO_UNIDAD.Caption = "Codigo unidad"
        Me.colCODIGO_UNIDAD.FieldName = "CODIGO_UNIDAD"
        Me.colCODIGO_UNIDAD.Name = "colCODIGO_UNIDAD"
        Me.colCODIGO_UNIDAD.Visible = True
        Me.colCODIGO_UNIDAD.VisibleIndex = 2
        '
        'colID_UNIDAD_PADRE
        '
        Me.colID_UNIDAD_PADRE.Caption = "Id unidad padre"
        Me.colID_UNIDAD_PADRE.FieldName = "ID_UNIDAD_PADRE"
        Me.colID_UNIDAD_PADRE.Name = "colID_UNIDAD_PADRE"
        Me.colID_UNIDAD_PADRE.Visible = True
        Me.colID_UNIDAD_PADRE.VisibleIndex = 3
        '
        'colESTADO
        '
        Me.colESTADO.Caption = "Estado"
        Me.colESTADO.FieldName = "ESTADO"
        Me.colESTADO.Name = "colESTADO"
        Me.colESTADO.Visible = True
        Me.colESTADO.VisibleIndex = 4
        '
        'colUSERID
        '
        Me.colUSERID.Caption = "Userid"
        Me.colUSERID.FieldName = "USERID"
        Me.colUSERID.Name = "colUSERID"
        Me.colUSERID.Visible = True
        Me.colUSERID.VisibleIndex = 5
        '
        'colLASTUPDATE
        '
        Me.colLASTUPDATE.Caption = "Lastupdate"
        Me.colLASTUPDATE.FieldName = "LASTUPDATE"
        Me.colLASTUPDATE.Name = "colLASTUPDATE"
        Me.colLASTUPDATE.Visible = True
        Me.colLASTUPDATE.VisibleIndex = 6
        '
        'ucListaUNIDAD_ORGANIZATIVA
        '
        Me.Controls.Add(Me.ListaUNIDAD_ORGANIZATIVAGridControl)
        Me.Name = "ucListaUNIDAD_ORGANIZATIVA"
        Me.Size = New System.Drawing.Size(529, 354)
        Me.Controls.SetChildIndex(Me.ListaUNIDAD_ORGANIZATIVAGridControl, 0)
        CType(Me.ListaUNIDAD_ORGANIZATIVABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaUNIDAD_ORGANIZATIVAGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaUNIDAD_ORGANIZATIVAGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaUNIDAD_ORGANIZATIVABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListaUNIDAD_ORGANIZATIVAGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents ListaUNIDAD_ORGANIZATIVAGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID_UNIDAD_ORGANIZATIVA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRE_UNIDAD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODIGO_UNIDAD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID_UNIDAD_PADRE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colESTADO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUSERID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLASTUPDATE As DevExpress.XtraGrid.Columns.GridColumn

End Class
