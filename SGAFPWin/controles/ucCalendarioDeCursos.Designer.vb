<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucCalendarioDeCursos
    Inherits ucBaseWin

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Dim TimeRuler3 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler
        Dim TimeRuler4 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler
        Me.SchedulerControl1 = New DevExpress.XtraScheduler.SchedulerControl
        Me.SchedulerStorage1 = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
        Me.ACCIONFORMATIVABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DateNavigator1 = New DevExpress.XtraScheduler.DateNavigator
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl
        Me.CbxSITIO_CAPACITACION1 = New SGAFP.WinUC.cbxSITIO_CAPACITACION
        Me.CbxPROVEEDOR_AF1 = New SGAFP.WinUC.cbxPROVEEDOR_AF
        Me.CbxAREA_FORMACION1 = New SGAFP.WinUC.cbxAREA_FORMACION
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem
        Me.CbxEJERCICIO1 = New SGAFP.WinUC.cbxEJERCICIO
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem
        Me.CbxESTADO_ACCION_FORMATIVA1 = New SGAFP.WinUC.cbxESTADO_ACCION_FORMATIVA
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem
        CType(Me.SchedulerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SchedulerStorage1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ACCIONFORMATIVABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SchedulerControl1
        '
        Me.SchedulerControl1.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.Month
        Me.SchedulerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SchedulerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SchedulerControl1.Name = "SchedulerControl1"
        Me.SchedulerControl1.Size = New System.Drawing.Size(478, 270)
        Me.SchedulerControl1.Start = New Date(2010, 5, 3, 0, 0, 0, 0)
        Me.SchedulerControl1.Storage = Me.SchedulerStorage1
        Me.SchedulerControl1.TabIndex = 0
        Me.SchedulerControl1.Text = "SchedulerControl1"
        Me.SchedulerControl1.Views.DayView.TimeRulers.Add(TimeRuler3)
        Me.SchedulerControl1.Views.WorkWeekView.TimeRulers.Add(TimeRuler4)
        '
        'SchedulerStorage1
        '
        Me.SchedulerStorage1.Appointments.DataSource = Me.ACCIONFORMATIVABindingSource
        Me.SchedulerStorage1.Appointments.Mappings.Description = "NOMBRE_ACCION_FORMATIVA"
        Me.SchedulerStorage1.Appointments.Mappings.End = "FECHA_FIN"
        Me.SchedulerStorage1.Appointments.Mappings.Location = "NOMBRE_SITIO"
        Me.SchedulerStorage1.Appointments.Mappings.Start = "FECHA_INICIO"
        Me.SchedulerStorage1.Appointments.Mappings.Subject = "CODIGO_GRUPO"
        '
        'ACCIONFORMATIVABindingSource
        '
        Me.ACCIONFORMATIVABindingSource.DataSource = GetType(SGAFP.EL.ACCION_FORMATIVA)
        '
        'DateNavigator1
        '
        Me.DateNavigator1.Dock = System.Windows.Forms.DockStyle.Right
        Me.DateNavigator1.HotDate = Nothing
        Me.DateNavigator1.Location = New System.Drawing.Point(478, 0)
        Me.DateNavigator1.Name = "DateNavigator1"
        Me.DateNavigator1.SchedulerControl = Me.SchedulerControl1
        Me.DateNavigator1.Size = New System.Drawing.Size(179, 270)
        Me.DateNavigator1.TabIndex = 1
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Horizontal = False
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.LayoutControl1)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.SchedulerControl1)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.DateNavigator1)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(657, 389)
        Me.SplitContainerControl1.SplitterPosition = 113
        Me.SplitContainerControl1.TabIndex = 2
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.CbxESTADO_ACCION_FORMATIVA1)
        Me.LayoutControl1.Controls.Add(Me.CbxEJERCICIO1)
        Me.LayoutControl1.Controls.Add(Me.CbxSITIO_CAPACITACION1)
        Me.LayoutControl1.Controls.Add(Me.CbxPROVEEDOR_AF1)
        Me.LayoutControl1.Controls.Add(Me.CbxAREA_FORMACION1)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(657, 113)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'CbxSITIO_CAPACITACION1
        '
        Me.CbxSITIO_CAPACITACION1.AllowFindEntityType = Nothing
        Me.CbxSITIO_CAPACITACION1.Location = New System.Drawing.Point(116, 37)
        Me.CbxSITIO_CAPACITACION1.Name = "CbxSITIO_CAPACITACION1"
        Me.CbxSITIO_CAPACITACION1.Size = New System.Drawing.Size(512, 21)
        Me.CbxSITIO_CAPACITACION1.TabIndex = 6
        Me.CbxSITIO_CAPACITACION1.Text = "CbxSITIO_CAPACITACION1"
        '
        'CbxPROVEEDOR_AF1
        '
        Me.CbxPROVEEDOR_AF1.AllowFindEntityType = Nothing
        Me.CbxPROVEEDOR_AF1.Location = New System.Drawing.Point(116, 12)
        Me.CbxPROVEEDOR_AF1.Name = "CbxPROVEEDOR_AF1"
        Me.CbxPROVEEDOR_AF1.Size = New System.Drawing.Size(512, 21)
        Me.CbxPROVEEDOR_AF1.TabIndex = 5
        Me.CbxPROVEEDOR_AF1.Text = "CbxPROVEEDOR_AF1"
        '
        'CbxAREA_FORMACION1
        '
        Me.CbxAREA_FORMACION1.AllowFindEntityType = Nothing
        Me.CbxAREA_FORMACION1.Location = New System.Drawing.Point(116, 62)
        Me.CbxAREA_FORMACION1.Name = "CbxAREA_FORMACION1"
        Me.CbxAREA_FORMACION1.Size = New System.Drawing.Size(512, 21)
        Me.CbxAREA_FORMACION1.TabIndex = 4
        Me.CbxAREA_FORMACION1.Text = "CbxAREA_FORMACION1"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(640, 145)
        Me.LayoutControlGroup1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.CbxAREA_FORMACION1
        Me.LayoutControlItem1.CustomizationFormText = "Area de Formacion"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 50)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(620, 25)
        Me.LayoutControlItem1.Text = "Area de Formacion"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(100, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.CbxPROVEEDOR_AF1
        Me.LayoutControlItem2.CustomizationFormText = "Proveedor"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(620, 25)
        Me.LayoutControlItem2.Text = "Proveedor"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(100, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.CbxSITIO_CAPACITACION1
        Me.LayoutControlItem3.CustomizationFormText = "Centro de Formacion"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 25)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(620, 25)
        Me.LayoutControlItem3.Text = "Centro de Formacion"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(100, 13)
        '
        'CbxEJERCICIO1
        '
        Me.CbxEJERCICIO1.AllowFindEntityType = Nothing
        Me.CbxEJERCICIO1.Location = New System.Drawing.Point(116, 87)
        Me.CbxEJERCICIO1.Name = "CbxEJERCICIO1"
        Me.CbxEJERCICIO1.Size = New System.Drawing.Size(512, 21)
        Me.CbxEJERCICIO1.TabIndex = 7
        Me.CbxEJERCICIO1.Text = "CbxEJERCICIO1"
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.CbxEJERCICIO1
        Me.LayoutControlItem4.CustomizationFormText = "Ejercicio"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 75)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(620, 25)
        Me.LayoutControlItem4.Text = "Ejercicio"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(100, 13)
        '
        'CbxESTADO_ACCION_FORMATIVA1
        '
        Me.CbxESTADO_ACCION_FORMATIVA1.AllowFindEntityType = Nothing
        Me.CbxESTADO_ACCION_FORMATIVA1.Location = New System.Drawing.Point(116, 112)
        Me.CbxESTADO_ACCION_FORMATIVA1.Name = "CbxESTADO_ACCION_FORMATIVA1"
        Me.CbxESTADO_ACCION_FORMATIVA1.Size = New System.Drawing.Size(512, 21)
        Me.CbxESTADO_ACCION_FORMATIVA1.TabIndex = 8
        Me.CbxESTADO_ACCION_FORMATIVA1.Text = "CbxESTADO_ACCION_FORMATIVA1"
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.CbxESTADO_ACCION_FORMATIVA1
        Me.LayoutControlItem5.CustomizationFormText = "Estado"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 100)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(620, 25)
        Me.LayoutControlItem5.Text = "Estado"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(100, 13)
        '
        'ucCalendarioDeCursos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Name = "ucCalendarioDeCursos"
        Me.Size = New System.Drawing.Size(657, 389)
        CType(Me.SchedulerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SchedulerStorage1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ACCIONFORMATIVABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SchedulerControl1 As DevExpress.XtraScheduler.SchedulerControl
    Friend WithEvents SchedulerStorage1 As DevExpress.XtraScheduler.SchedulerStorage
    Friend WithEvents ACCIONFORMATIVABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DateNavigator1 As DevExpress.XtraScheduler.DateNavigator
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents CbxSITIO_CAPACITACION1 As SGAFP.WinUC.cbxSITIO_CAPACITACION
    Friend WithEvents CbxPROVEEDOR_AF1 As SGAFP.WinUC.cbxPROVEEDOR_AF
    Friend WithEvents CbxAREA_FORMACION1 As SGAFP.WinUC.cbxAREA_FORMACION
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents CbxESTADO_ACCION_FORMATIVA1 As SGAFP.WinUC.cbxESTADO_ACCION_FORMATIVA
    Friend WithEvents CbxEJERCICIO1 As SGAFP.WinUC.cbxEJERCICIO
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem

End Class
