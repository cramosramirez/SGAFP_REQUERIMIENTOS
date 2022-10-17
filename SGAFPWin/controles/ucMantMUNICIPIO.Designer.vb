Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucMantMUNICIPIO
    Inherits SGAFP.ucBaseMant

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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.LabelREGION = New System.Windows.Forms.Label
        Me.CODIGO_REGIONCbxREGION = New SGAFP.WinUC.cbxREGION
        Me.LabelDEPARTAMENTO = New System.Windows.Forms.Label
        Me.CODIGO_DEPARTAMENTOCbxDEPARTAMENTO = New SGAFP.WinUC.cbxDEPARTAMENTO
        Me.UcListaMUNICIPIO1 = New SGAFP.ucListaMUNICIPIO
        Me.UcDetalleMUNICIPIO1 = New SGAFP.ucDetalleMUNICIPIO
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.LabelREGION)
        Me.SplitContainer1.Panel1.Controls.Add(Me.CODIGO_REGIONCbxREGION)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LabelDEPARTAMENTO)
        Me.SplitContainer1.Panel1.Controls.Add(Me.CODIGO_DEPARTAMENTOCbxDEPARTAMENTO)
        Me.SplitContainer1.Panel1.Controls.Add(Me.UcListaMUNICIPIO1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.UcDetalleMUNICIPIO1)
        Me.SplitContainer1.Size = New System.Drawing.Size(650, 440)
        Me.SplitContainer1.SplitterDistance = 251
        Me.SplitContainer1.TabIndex = 1
        '
        'LabelREGION
        '
        Me.LabelREGION.AutoSize = True
        Me.LabelREGION.Location = New System.Drawing.Point(3, 11)
        Me.LabelREGION.Name = "LabelREGION"
        Me.LabelREGION.Size = New System.Drawing.Size(132, 13)
        Me.LabelREGION.TabIndex = 3
        Me.LabelREGION.Text = "REGION:"
        '
        'CODIGO_REGIONCbxREGION
        '
        Me.CODIGO_REGIONCbxREGION.Location = New System.Drawing.Point(100, 5)
        Me.CODIGO_REGIONCbxREGION.Name = "CODIGO_REGIONCbxREGION"
        Me.CODIGO_REGIONCbxREGION.Size = New System.Drawing.Size(121, 21)
        Me.CODIGO_REGIONCbxREGION.TabIndex = 2
        Me.CODIGO_REGIONCbxREGION.Text = "CbxREGION"
        '
        'LabelDEPARTAMENTO
        '
        Me.LabelDEPARTAMENTO.AutoSize = True
        Me.LabelDEPARTAMENTO.Location = New System.Drawing.Point(3, 36)
        Me.LabelDEPARTAMENTO.Name = "LabelDEPARTAMENTO"
        Me.LabelDEPARTAMENTO.Size = New System.Drawing.Size(132, 13)
        Me.LabelDEPARTAMENTO.TabIndex = 3
        Me.LabelDEPARTAMENTO.Text = "DEPARTAMENTO:"
        '
        'CODIGO_DEPARTAMENTOCbxDEPARTAMENTO
        '
        Me.CODIGO_DEPARTAMENTOCbxDEPARTAMENTO.Location = New System.Drawing.Point(100, 30)
        Me.CODIGO_DEPARTAMENTOCbxDEPARTAMENTO.Name = "CODIGO_DEPARTAMENTOCbxDEPARTAMENTO"
        Me.CODIGO_DEPARTAMENTOCbxDEPARTAMENTO.Size = New System.Drawing.Size(121, 21)
        Me.CODIGO_DEPARTAMENTOCbxDEPARTAMENTO.TabIndex = 2
        Me.CODIGO_DEPARTAMENTOCbxDEPARTAMENTO.Text = "CbxDEPARTAMENTO"
        '
        'UcListaMUNICIPIO1
        '
        Me.UcListaMUNICIPIO1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcListaMUNICIPIO1.Location = New System.Drawing.Point(0,0)
        Me.UcListaMUNICIPIO1.Name = "UcListaMUNICIPIO1"
        Me.UcListaMUNICIPIO1.PermitirBuscarEntityType = GetType(MUNICIPIO)
        Me.UcListaMUNICIPIO1.sError = Nothing
        Me.UcListaMUNICIPIO1.Size = New System.Drawing.Size(650, 251)
        Me.UcListaMUNICIPIO1.TabIndex = 1
        '
        'UcDetalleMUNICIPIO1
        '
        Me.UcDetalleMUNICIPIO1.AutoScroll = True
        Me.UcDetalleMUNICIPIO1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcDetalleMUNICIPIO1.EsNuevo = False
        Me.UcDetalleMUNICIPIO1.Location = New System.Drawing.Point(0, 0)
        Me.UcDetalleMUNICIPIO1.Name = "UcDetalleMUNICIPIO1"
        Me.UcDetalleMUNICIPIO1.Size = New System.Drawing.Size(650, 185)
        Me.UcDetalleMUNICIPIO1.TabIndex = 0
        '
        'ucMantMUNICIPIO
        '
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "ucMantMUNICIPIO"
        Me.Size = New System.Drawing.Size(650, 440)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents UcListaMUNICIPIO1 As SGAFP.ucListaMUNICIPIO
    Friend WithEvents UcDetalleMUNICIPIO1 As SGAFP.UcDetalleMUNICIPIO
    Friend WithEvents LabelREGION As System.Windows.Forms.Label
    Friend WithEvents CODIGO_REGIONCbxREGION As SGAFP.WinUC.cbxREGION
    Friend WithEvents LabelDEPARTAMENTO As System.Windows.Forms.Label
    Friend WithEvents CODIGO_DEPARTAMENTOCbxDEPARTAMENTO As SGAFP.WinUC.cbxDEPARTAMENTO

End Class
