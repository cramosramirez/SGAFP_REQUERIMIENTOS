<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultarCursos
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
        Me.components = New System.ComponentModel.Container
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl
        Me.txtCodigoGrupo = New DevExpress.XtraEditors.TextEdit
        Me.CbxESTADO_ACCION_FORMATIVA1 = New SGAFP.WinUC.cbxESTADO_ACCION_FORMATIVA
        Me.CbxEJERCICIO1 = New SGAFP.WinUC.cbxEJERCICIO
        Me.CbxSITIO_CAPACITACION1 = New SGAFP.WinUC.cbxSITIO_CAPACITACION
        Me.CbxPROVEEDOR_AF1 = New SGAFP.WinUC.cbxPROVEEDOR_AF
        Me.CbxAREA_FORMACION1 = New SGAFP.WinUC.cbxAREA_FORMACION
        Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl
        Me.UcListaACCION_FORMATIVA1 = New SGAFP.ucListaACCION_FORMATIVA
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.txtCodigoGrupo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Controls.Add(Me.txtCodigoGrupo)
        Me.LayoutControl2.Controls.Add(Me.CbxESTADO_ACCION_FORMATIVA1)
        Me.LayoutControl2.Controls.Add(Me.CbxEJERCICIO1)
        Me.LayoutControl2.Controls.Add(Me.CbxSITIO_CAPACITACION1)
        Me.LayoutControl2.Controls.Add(Me.CbxPROVEEDOR_AF1)
        Me.LayoutControl2.Controls.Add(Me.CbxAREA_FORMACION1)
        Me.LayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.Root = Me.LayoutControlGroup4
        Me.LayoutControl2.Size = New System.Drawing.Size(716, 90)
        Me.LayoutControl2.TabIndex = 4
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'txtCodigoGrupo
        '
        Me.txtCodigoGrupo.Location = New System.Drawing.Point(116, 62)
        Me.txtCodigoGrupo.Name = "txtCodigoGrupo"
        Me.txtCodigoGrupo.Size = New System.Drawing.Size(267, 20)
        Me.txtCodigoGrupo.StyleController = Me.LayoutControl2
        Me.txtCodigoGrupo.TabIndex = 9
        '
        'CbxESTADO_ACCION_FORMATIVA1
        '
        Me.CbxESTADO_ACCION_FORMATIVA1.AllowFindEntityType = Nothing
        Me.CbxESTADO_ACCION_FORMATIVA1.Location = New System.Drawing.Point(491, 62)
        Me.CbxESTADO_ACCION_FORMATIVA1.Name = "CbxESTADO_ACCION_FORMATIVA1"
        Me.CbxESTADO_ACCION_FORMATIVA1.Size = New System.Drawing.Size(196, 21)
        Me.CbxESTADO_ACCION_FORMATIVA1.TabIndex = 8
        Me.CbxESTADO_ACCION_FORMATIVA1.Text = "CbxESTADO_ACCION_FORMATIVA1"
        '
        'CbxEJERCICIO1
        '
        Me.CbxEJERCICIO1.AllowFindEntityType = Nothing
        Me.CbxEJERCICIO1.Location = New System.Drawing.Point(116, 37)
        Me.CbxEJERCICIO1.Name = "CbxEJERCICIO1"
        Me.CbxEJERCICIO1.Size = New System.Drawing.Size(267, 21)
        Me.CbxEJERCICIO1.TabIndex = 7
        Me.CbxEJERCICIO1.Text = "CbxEJERCICIO1"
        '
        'CbxSITIO_CAPACITACION1
        '
        Me.CbxSITIO_CAPACITACION1.AllowFindEntityType = Nothing
        Me.CbxSITIO_CAPACITACION1.Location = New System.Drawing.Point(491, 12)
        Me.CbxSITIO_CAPACITACION1.Name = "CbxSITIO_CAPACITACION1"
        Me.CbxSITIO_CAPACITACION1.Size = New System.Drawing.Size(196, 21)
        Me.CbxSITIO_CAPACITACION1.TabIndex = 6
        Me.CbxSITIO_CAPACITACION1.Text = "CbxSITIO_CAPACITACION1"
        '
        'CbxPROVEEDOR_AF1
        '
        Me.CbxPROVEEDOR_AF1.AllowFindEntityType = Nothing
        Me.CbxPROVEEDOR_AF1.Location = New System.Drawing.Point(116, 12)
        Me.CbxPROVEEDOR_AF1.Name = "CbxPROVEEDOR_AF1"
        Me.CbxPROVEEDOR_AF1.Size = New System.Drawing.Size(267, 21)
        Me.CbxPROVEEDOR_AF1.TabIndex = 5
        Me.CbxPROVEEDOR_AF1.Text = "CbxPROVEEDOR_AF1"
        '
        'CbxAREA_FORMACION1
        '
        Me.CbxAREA_FORMACION1.AllowFindEntityType = Nothing
        Me.CbxAREA_FORMACION1.Location = New System.Drawing.Point(491, 37)
        Me.CbxAREA_FORMACION1.Name = "CbxAREA_FORMACION1"
        Me.CbxAREA_FORMACION1.Size = New System.Drawing.Size(196, 21)
        Me.CbxAREA_FORMACION1.TabIndex = 4
        Me.CbxAREA_FORMACION1.Text = "CbxAREA_FORMACION1"
        '
        'LayoutControlGroup4
        '
        Me.LayoutControlGroup4.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup4.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup4.GroupBordersVisible = False
        Me.LayoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem4, Me.LayoutControlItem6, Me.LayoutControlItem3, Me.LayoutControlItem1, Me.LayoutControlItem5})
        Me.LayoutControlGroup4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup4.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup4.Size = New System.Drawing.Size(699, 95)
        Me.LayoutControlGroup4.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutControlGroup4.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup4.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.CbxPROVEEDOR_AF1
        Me.LayoutControlItem2.CustomizationFormText = "Proveedor"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(375, 25)
        Me.LayoutControlItem2.Text = "Proveedor"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(100, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.CbxEJERCICIO1
        Me.LayoutControlItem4.CustomizationFormText = "Ejercicio"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 25)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(375, 25)
        Me.LayoutControlItem4.Text = "Ejercicio"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(100, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.txtCodigoGrupo
        Me.LayoutControlItem6.CustomizationFormText = "Codigo Grupo"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 50)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(375, 25)
        Me.LayoutControlItem6.Text = "Codigo Grupo"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(100, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.CbxSITIO_CAPACITACION1
        Me.LayoutControlItem3.CustomizationFormText = "Centro de Formacion"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(375, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(304, 25)
        Me.LayoutControlItem3.Text = "Centro de Formacion"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(100, 13)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.CbxAREA_FORMACION1
        Me.LayoutControlItem1.CustomizationFormText = "Area de Formacion"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(375, 25)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(304, 25)
        Me.LayoutControlItem1.Text = "Area de Formacion"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(100, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.CbxESTADO_ACCION_FORMATIVA1
        Me.LayoutControlItem5.CustomizationFormText = "Estado"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(375, 50)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(304, 25)
        Me.LayoutControlItem5.Text = "Estado Curso"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(100, 13)
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Horizontal = False
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.LayoutControl2)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.UcListaACCION_FORMATIVA1)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(716, 351)
        Me.SplitContainerControl1.SplitterPosition = 90
        Me.SplitContainerControl1.TabIndex = 5
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'UcListaACCION_FORMATIVA1
        '
        Me.UcListaACCION_FORMATIVA1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcListaACCION_FORMATIVA1.Location = New System.Drawing.Point(0, 0)
        Me.UcListaACCION_FORMATIVA1.Name = "UcListaACCION_FORMATIVA1"
        Me.UcListaACCION_FORMATIVA1.PermitirAgregar = False
        Me.UcListaACCION_FORMATIVA1.PermitirBuscarEntityType = Nothing
        Me.UcListaACCION_FORMATIVA1.PermitirEliminar = False
        Me.UcListaACCION_FORMATIVA1.PermitirGuardar = False
        Me.UcListaACCION_FORMATIVA1.PreguntaEliminar = "¿Esta seguro de eliminar el registro?"
        Me.UcListaACCION_FORMATIVA1.sError = Nothing
        Me.UcListaACCION_FORMATIVA1.Size = New System.Drawing.Size(716, 255)
        Me.UcListaACCION_FORMATIVA1.TabIndex = 0
        Me.UcListaACCION_FORMATIVA1.VerCODIGO_ESTADO_AF = False
        Me.UcListaACCION_FORMATIVA1.VerCOSTO_X_PARTICIPANTE = False
        Me.UcListaACCION_FORMATIVA1.VerID_OFERTA_FORMATIVA = False
        Me.UcListaACCION_FORMATIVA1.VerID_PROVEEDOR_AF = False
        Me.UcListaACCION_FORMATIVA1.VerID_SITIO_CAPACITACION = False
        Me.UcListaACCION_FORMATIVA1.VerID_TEMA_CURSO = False
        Me.UcListaACCION_FORMATIVA1.VerLASTUPDATE = False
        Me.UcListaACCION_FORMATIVA1.VerNOTAS = False
        Me.UcListaACCION_FORMATIVA1.VerUSERID = False
        '
        'frmConsultarCursos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(716, 351)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Name = "frmConsultarCursos"
        Me.Text = "Consultar Cursos/Acciones Formativas"
        Me.Controls.SetChildIndex(Me.SplitContainerControl1, 0)
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.txtCodigoGrupo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents CbxESTADO_ACCION_FORMATIVA1 As SGAFP.WinUC.cbxESTADO_ACCION_FORMATIVA
    Friend WithEvents CbxEJERCICIO1 As SGAFP.WinUC.cbxEJERCICIO
    Friend WithEvents CbxSITIO_CAPACITACION1 As SGAFP.WinUC.cbxSITIO_CAPACITACION
    Friend WithEvents CbxPROVEEDOR_AF1 As SGAFP.WinUC.cbxPROVEEDOR_AF
    Friend WithEvents CbxAREA_FORMACION1 As SGAFP.WinUC.cbxAREA_FORMACION
    Friend WithEvents LayoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents UcListaACCION_FORMATIVA1 As SGAFP.ucListaACCION_FORMATIVA
    Friend WithEvents txtCodigoGrupo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
End Class
