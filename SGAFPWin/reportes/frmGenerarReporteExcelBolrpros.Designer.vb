<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGenerarReporteExcelBolrpros
    Inherits frmBase

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.txtLUGAR_EJECUCION = New System.Windows.Forms.TextBox()
        Me.CbxCENTRO_RESPONSABILIDAD1 = New SGAFP.WinUC.cbxCENTRO_RESPONSABILIDAD()
        Me.CbxMUNICIPIO1 = New SGAFP.WinUC.cbxMUNICIPIO()
        Me.CbxDEPARTAMENTO1 = New SGAFP.WinUC.cbxDEPARTAMENTO()
        Me.CbxAREA_FORMACION1 = New SGAFP.WinUC.cbxAREA_FORMACION()
        Me.txtNOMBRE_REFERENTE = New System.Windows.Forms.TextBox()
        Me.txtID_SOLICITUD = New System.Windows.Forms.TextBox()
        Me.txtNOMBRE_ACCION_FORMATIVA = New System.Windows.Forms.TextBox()
        Me.txtNUM_ITEM = New System.Windows.Forms.TextBox()
        Me.txtNUM_CONTRATO = New System.Windows.Forms.TextBox()
        Me.CbxCONTRATO_COMPRA1 = New SGAFP.WinUC.cbxCONTRATO_COMPRA()
        Me.CbxPROVEEDOR_AF1 = New SGAFP.WinUC.cbxPROVEEDOR_AF()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.DS_DL1 = New SGAFP.DL.DS_DL()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.ConsultA_BOLPROS_EXCELTableAdapter1 = New SGAFP.DL.DS_DLTableAdapters.CONSULTA_BOLPROS_EXCELTableAdapter()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_DL1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel1
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Horizontal = False
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.LayoutControl1)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(995, 216)
        Me.SplitContainerControl1.SplitterPosition = 186
        Me.SplitContainerControl1.TabIndex = 5
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.txtLUGAR_EJECUCION)
        Me.LayoutControl1.Controls.Add(Me.CbxCENTRO_RESPONSABILIDAD1)
        Me.LayoutControl1.Controls.Add(Me.CbxMUNICIPIO1)
        Me.LayoutControl1.Controls.Add(Me.CbxDEPARTAMENTO1)
        Me.LayoutControl1.Controls.Add(Me.CbxAREA_FORMACION1)
        Me.LayoutControl1.Controls.Add(Me.txtNOMBRE_REFERENTE)
        Me.LayoutControl1.Controls.Add(Me.txtID_SOLICITUD)
        Me.LayoutControl1.Controls.Add(Me.txtNOMBRE_ACCION_FORMATIVA)
        Me.LayoutControl1.Controls.Add(Me.txtNUM_ITEM)
        Me.LayoutControl1.Controls.Add(Me.txtNUM_CONTRATO)
        Me.LayoutControl1.Controls.Add(Me.CbxCONTRATO_COMPRA1)
        Me.LayoutControl1.Controls.Add(Me.CbxPROVEEDOR_AF1)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsView.UseDefaultDragAndDropRendering = False
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(995, 186)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'txtLUGAR_EJECUCION
        '
        Me.txtLUGAR_EJECUCION.Location = New System.Drawing.Point(177, 136)
        Me.txtLUGAR_EJECUCION.Name = "txtLUGAR_EJECUCION"
        Me.txtLUGAR_EJECUCION.Size = New System.Drawing.Size(325, 20)
        Me.txtLUGAR_EJECUCION.TabIndex = 29
        '
        'CbxCENTRO_RESPONSABILIDAD1
        '
        Me.CbxCENTRO_RESPONSABILIDAD1.AllowFindEntityType = Nothing
        Me.CbxCENTRO_RESPONSABILIDAD1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxCENTRO_RESPONSABILIDAD1.Location = New System.Drawing.Point(177, 86)
        Me.CbxCENTRO_RESPONSABILIDAD1.Name = "CbxCENTRO_RESPONSABILIDAD1"
        Me.CbxCENTRO_RESPONSABILIDAD1.Size = New System.Drawing.Size(325, 21)
        Me.CbxCENTRO_RESPONSABILIDAD1.TabIndex = 28
        '
        'CbxMUNICIPIO1
        '
        Me.CbxMUNICIPIO1.AllowFindEntityType = Nothing
        Me.CbxMUNICIPIO1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxMUNICIPIO1.Location = New System.Drawing.Point(671, 136)
        Me.CbxMUNICIPIO1.Name = "CbxMUNICIPIO1"
        Me.CbxMUNICIPIO1.Size = New System.Drawing.Size(312, 21)
        Me.CbxMUNICIPIO1.TabIndex = 27
        '
        'CbxDEPARTAMENTO1
        '
        Me.CbxDEPARTAMENTO1.AllowFindEntityType = Nothing
        Me.CbxDEPARTAMENTO1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxDEPARTAMENTO1.Location = New System.Drawing.Point(671, 111)
        Me.CbxDEPARTAMENTO1.Name = "CbxDEPARTAMENTO1"
        Me.CbxDEPARTAMENTO1.Size = New System.Drawing.Size(312, 21)
        Me.CbxDEPARTAMENTO1.TabIndex = 26
        '
        'CbxAREA_FORMACION1
        '
        Me.CbxAREA_FORMACION1.AllowFindEntityType = Nothing
        Me.CbxAREA_FORMACION1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxAREA_FORMACION1.Location = New System.Drawing.Point(177, 111)
        Me.CbxAREA_FORMACION1.Name = "CbxAREA_FORMACION1"
        Me.CbxAREA_FORMACION1.Size = New System.Drawing.Size(325, 21)
        Me.CbxAREA_FORMACION1.TabIndex = 25
        '
        'txtNOMBRE_REFERENTE
        '
        Me.txtNOMBRE_REFERENTE.Location = New System.Drawing.Point(671, 86)
        Me.txtNOMBRE_REFERENTE.Name = "txtNOMBRE_REFERENTE"
        Me.txtNOMBRE_REFERENTE.Size = New System.Drawing.Size(312, 20)
        Me.txtNOMBRE_REFERENTE.TabIndex = 24
        '
        'txtID_SOLICITUD
        '
        Me.txtID_SOLICITUD.Location = New System.Drawing.Point(671, 62)
        Me.txtID_SOLICITUD.Name = "txtID_SOLICITUD"
        Me.txtID_SOLICITUD.Size = New System.Drawing.Size(312, 20)
        Me.txtID_SOLICITUD.TabIndex = 22
        '
        'txtNOMBRE_ACCION_FORMATIVA
        '
        Me.txtNOMBRE_ACCION_FORMATIVA.Location = New System.Drawing.Point(177, 62)
        Me.txtNOMBRE_ACCION_FORMATIVA.Name = "txtNOMBRE_ACCION_FORMATIVA"
        Me.txtNOMBRE_ACCION_FORMATIVA.Size = New System.Drawing.Size(325, 20)
        Me.txtNOMBRE_ACCION_FORMATIVA.TabIndex = 21
        '
        'txtNUM_ITEM
        '
        Me.txtNUM_ITEM.Location = New System.Drawing.Point(177, 37)
        Me.txtNUM_ITEM.Name = "txtNUM_ITEM"
        Me.txtNUM_ITEM.Size = New System.Drawing.Size(325, 20)
        Me.txtNUM_ITEM.TabIndex = 20
        '
        'txtNUM_CONTRATO
        '
        Me.txtNUM_CONTRATO.Location = New System.Drawing.Point(671, 12)
        Me.txtNUM_CONTRATO.Name = "txtNUM_CONTRATO"
        Me.txtNUM_CONTRATO.Size = New System.Drawing.Size(312, 20)
        Me.txtNUM_CONTRATO.TabIndex = 19
        '
        'CbxCONTRATO_COMPRA1
        '
        Me.CbxCONTRATO_COMPRA1.AllowFindEntityType = Nothing
        Me.CbxCONTRATO_COMPRA1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxCONTRATO_COMPRA1.Location = New System.Drawing.Point(177, 12)
        Me.CbxCONTRATO_COMPRA1.Name = "CbxCONTRATO_COMPRA1"
        Me.CbxCONTRATO_COMPRA1.Size = New System.Drawing.Size(325, 21)
        Me.CbxCONTRATO_COMPRA1.TabIndex = 18
        '
        'CbxPROVEEDOR_AF1
        '
        Me.CbxPROVEEDOR_AF1.AllowFindEntityType = Nothing
        Me.CbxPROVEEDOR_AF1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxPROVEEDOR_AF1.Location = New System.Drawing.Point(671, 37)
        Me.CbxPROVEEDOR_AF1.Name = "CbxPROVEEDOR_AF1"
        Me.CbxPROVEEDOR_AF1.Size = New System.Drawing.Size(312, 21)
        Me.CbxPROVEEDOR_AF1.TabIndex = 6
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem6, Me.LayoutControlItem10, Me.LayoutControlItem11, Me.LayoutControlItem8, Me.LayoutControlItem12, Me.LayoutControlItem13, Me.LayoutControlItem15, Me.LayoutControlItem18, Me.LayoutControlItem1, Me.LayoutControlItem17, Me.LayoutControlItem2, Me.LayoutControlItem16})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(995, 186)
        Me.LayoutControlGroup1.Text = "Root"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.CbxCONTRATO_COMPRA1
        Me.LayoutControlItem6.CustomizationFormText = "Oferta de Compra"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(494, 25)
        Me.LayoutControlItem6.Text = "Oferta de Compra / Licitación"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(162, 13)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.txtNUM_CONTRATO
        Me.LayoutControlItem10.CustomizationFormText = "No. Contrato"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(494, 0)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(481, 25)
        Me.LayoutControlItem10.Text = "No. Contrato"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(162, 13)
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.txtNUM_ITEM
        Me.LayoutControlItem11.CustomizationFormText = "LayoutControlItem11"
        Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 25)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(494, 25)
        Me.LayoutControlItem11.Text = "No. Item"
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(162, 13)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.CbxPROVEEDOR_AF1
        Me.LayoutControlItem8.CustomizationFormText = "Proveedor"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(494, 25)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(481, 25)
        Me.LayoutControlItem8.Text = "Proveedor"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(162, 13)
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.txtNOMBRE_ACCION_FORMATIVA
        Me.LayoutControlItem12.CustomizationFormText = "Nombre de acción formativa"
        Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 50)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(494, 24)
        Me.LayoutControlItem12.Text = "Nombre de acción formativa"
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(162, 13)
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.txtID_SOLICITUD
        Me.LayoutControlItem13.CustomizationFormText = "Id Solicitud"
        Me.LayoutControlItem13.Location = New System.Drawing.Point(494, 50)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(481, 24)
        Me.LayoutControlItem13.Text = "Id Solicitud"
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(162, 13)
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.txtNOMBRE_REFERENTE
        Me.LayoutControlItem15.CustomizationFormText = "Nombre del referente"
        Me.LayoutControlItem15.Location = New System.Drawing.Point(494, 74)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(481, 25)
        Me.LayoutControlItem15.Text = "Nombre del referente"
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(162, 13)
        '
        'LayoutControlItem18
        '
        Me.LayoutControlItem18.Control = Me.CbxMUNICIPIO1
        Me.LayoutControlItem18.CustomizationFormText = "Municipio"
        Me.LayoutControlItem18.Location = New System.Drawing.Point(494, 124)
        Me.LayoutControlItem18.Name = "LayoutControlItem18"
        Me.LayoutControlItem18.Size = New System.Drawing.Size(481, 42)
        Me.LayoutControlItem18.Text = "Municipio"
        Me.LayoutControlItem18.TextSize = New System.Drawing.Size(162, 13)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.CbxCENTRO_RESPONSABILIDAD1
        Me.LayoutControlItem1.CustomizationFormText = "Centro de responsabilidad"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 74)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(494, 25)
        Me.LayoutControlItem1.Text = "Centro de responsabilidad"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(162, 13)
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.Control = Me.CbxDEPARTAMENTO1
        Me.LayoutControlItem17.CustomizationFormText = "Departamento"
        Me.LayoutControlItem17.Location = New System.Drawing.Point(494, 99)
        Me.LayoutControlItem17.Name = "LayoutControlItem17"
        Me.LayoutControlItem17.Size = New System.Drawing.Size(481, 25)
        Me.LayoutControlItem17.Text = "Departamento"
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(162, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.txtLUGAR_EJECUCION
        Me.LayoutControlItem2.CustomizationFormText = "Lugar de ejecución"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 124)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(494, 42)
        Me.LayoutControlItem2.Text = "Lugar de ejecución"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(162, 13)
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.CbxAREA_FORMACION1
        Me.LayoutControlItem16.CustomizationFormText = "Área/Categoría acción formativa"
        Me.LayoutControlItem16.Location = New System.Drawing.Point(0, 99)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(494, 25)
        Me.LayoutControlItem16.Text = "Área / Categoría acción formativa"
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(162, 13)
        '
        'DS_DL1
        '
        Me.DS_DL1.DataSetName = "DS_DL"
        Me.DS_DL1.EnforceConstraints = False
        Me.DS_DL1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ConsultA_BOLPROS_EXCELTableAdapter1
        '
        Me.ConsultA_BOLPROS_EXCELTableAdapter1.ClearBeforeFill = True
        '
        'frmGenerarReporteExcelBolrpros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(995, 216)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Name = "frmGenerarReporteExcelBolrpros"
        Me.Text = "Generarción de información de Licitación/Mercado Bursatil"
        Me.Controls.SetChildIndex(Me.SplitContainerControl1, 0)
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_DL1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents CbxPROVEEDOR_AF1 As SGAFP.WinUC.cbxPROVEEDOR_AF
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DS_DL1 As SGAFP.DL.DS_DL
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents CbxCONTRATO_COMPRA1 As SGAFP.WinUC.cbxCONTRATO_COMPRA
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtNUM_CONTRATO As System.Windows.Forms.TextBox
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtNUM_ITEM As System.Windows.Forms.TextBox
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtNOMBRE_ACCION_FORMATIVA As System.Windows.Forms.TextBox
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtID_SOLICITUD As System.Windows.Forms.TextBox
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents CbxMUNICIPIO1 As SGAFP.WinUC.cbxMUNICIPIO
    Friend WithEvents CbxDEPARTAMENTO1 As SGAFP.WinUC.cbxDEPARTAMENTO
    Friend WithEvents CbxAREA_FORMACION1 As SGAFP.WinUC.cbxAREA_FORMACION
    Friend WithEvents txtNOMBRE_REFERENTE As System.Windows.Forms.TextBox
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents CbxCENTRO_RESPONSABILIDAD1 As SGAFP.WinUC.cbxCENTRO_RESPONSABILIDAD
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtLUGAR_EJECUCION As System.Windows.Forms.TextBox
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ConsultA_BOLPROS_EXCELTableAdapter1 As SGAFP.DL.DS_DLTableAdapters.CONSULTA_BOLPROS_EXCELTableAdapter
End Class
