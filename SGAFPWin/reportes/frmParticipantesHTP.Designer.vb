<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmParticipantesHTP
    Inherits DevExpress.XtraEditors.XtraForm

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
        Me.PivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl
        Me.fieldAREAFORMATIVA1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldBUSCATRABAJO1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldCONDISCAPACIDAD1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldDEPARTAMENTORESIDENCIA1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldEDAD1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldEJERCICIO1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldESTADOCIVIL1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldESTUDIA1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldMUNICIPIORESIDENCIA1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldNIVELACADEMICO1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldOFICIOSHOGAR1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldPROVEEDOR1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldRANGOEDAD1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldRANGOEDAD21 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldRANGONIVELACADEMICO1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldSECTOR1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldSEXO1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldSITIOCAPACITACION1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldSITUACIONLABORAL1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldTIPOEMPLEO1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldTRABAJA1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldCountOfIDCURSO1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldCountOfIDSOLICITUD1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldSumOfCOSTOXPARTICIPANTE1 = New DevExpress.XtraPivotGrid.PivotGridField
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PivotGridControl1
        '
        Me.PivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldAREAFORMATIVA1, Me.fieldBUSCATRABAJO1, Me.fieldCONDISCAPACIDAD1, Me.fieldDEPARTAMENTORESIDENCIA1, Me.fieldEDAD1, Me.fieldEJERCICIO1, Me.fieldESTADOCIVIL1, Me.fieldESTUDIA1, Me.fieldMUNICIPIORESIDENCIA1, Me.fieldNIVELACADEMICO1, Me.fieldOFICIOSHOGAR1, Me.fieldPROVEEDOR1, Me.fieldRANGOEDAD1, Me.fieldRANGOEDAD21, Me.fieldRANGONIVELACADEMICO1, Me.fieldSECTOR1, Me.fieldSEXO1, Me.fieldSITIOCAPACITACION1, Me.fieldSITUACIONLABORAL1, Me.fieldTIPOEMPLEO1, Me.fieldTRABAJA1, Me.fieldCountOfIDCURSO1, Me.fieldCountOfIDSOLICITUD1, Me.fieldSumOfCOSTOXPARTICIPANTE1})
        Me.PivotGridControl1.Location = New System.Drawing.Point(0, 0)
        Me.PivotGridControl1.Name = "PivotGridControl1"
        Me.PivotGridControl1.OLAPConnectionString = "provider=MSOLAP;cube name=MyCube;data source=c:\solicitudeshtp.cub;initial catalo" & _
            "g=MyCube;user id=prueba;password=prueba"
        Me.PivotGridControl1.Size = New System.Drawing.Size(1107, 560)
        Me.PivotGridControl1.TabIndex = 0
        '
        'fieldAREAFORMATIVA1
        '
        Me.fieldAREAFORMATIVA1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldAREAFORMATIVA1.AreaIndex = 1
        Me.fieldAREAFORMATIVA1.Caption = "Area Formativa"
        Me.fieldAREAFORMATIVA1.FieldName = "[AREA_FORMATIVA].[AREA_FORMATIVA]"
        Me.fieldAREAFORMATIVA1.Name = "fieldAREAFORMATIVA1"
        '
        'fieldBUSCATRABAJO1
        '
        Me.fieldBUSCATRABAJO1.AreaIndex = 0
        Me.fieldBUSCATRABAJO1.Caption = "BUSCA_TRABAJO"
        Me.fieldBUSCATRABAJO1.FieldName = "[BUSCA_TRABAJO].[BUSCA_TRABAJO]"
        Me.fieldBUSCATRABAJO1.Name = "fieldBUSCATRABAJO1"
        '
        'fieldCONDISCAPACIDAD1
        '
        Me.fieldCONDISCAPACIDAD1.AreaIndex = 1
        Me.fieldCONDISCAPACIDAD1.Caption = "Con Discapacidad"
        Me.fieldCONDISCAPACIDAD1.FieldName = "[CON_DISCAPACIDAD].[CON_DISCAPACIDAD]"
        Me.fieldCONDISCAPACIDAD1.Name = "fieldCONDISCAPACIDAD1"
        '
        'fieldDEPARTAMENTORESIDENCIA1
        '
        Me.fieldDEPARTAMENTORESIDENCIA1.AreaIndex = 3
        Me.fieldDEPARTAMENTORESIDENCIA1.Caption = "Departamento Residencia"
        Me.fieldDEPARTAMENTORESIDENCIA1.FieldName = "[DEPARTAMENTO_RESIDENCIA].[DEPARTAMENTO_RESIDENCIA]"
        Me.fieldDEPARTAMENTORESIDENCIA1.Name = "fieldDEPARTAMENTORESIDENCIA1"
        '
        'fieldEDAD1
        '
        Me.fieldEDAD1.AreaIndex = 2
        Me.fieldEDAD1.Caption = "Edad"
        Me.fieldEDAD1.FieldName = "[EDAD].[EDAD]"
        Me.fieldEDAD1.Name = "fieldEDAD1"
        '
        'fieldEJERCICIO1
        '
        Me.fieldEJERCICIO1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldEJERCICIO1.AreaIndex = 0
        Me.fieldEJERCICIO1.Caption = "Ejercicio"
        Me.fieldEJERCICIO1.FieldName = "[EJERCICIO].[EJERCICIO]"
        Me.fieldEJERCICIO1.Name = "fieldEJERCICIO1"
        '
        'fieldESTADOCIVIL1
        '
        Me.fieldESTADOCIVIL1.AreaIndex = 4
        Me.fieldESTADOCIVIL1.Caption = "Estado Civil"
        Me.fieldESTADOCIVIL1.FieldName = "[ESTADO_CIVIL].[ESTADO_CIVIL]"
        Me.fieldESTADOCIVIL1.Name = "fieldESTADOCIVIL1"
        '
        'fieldESTUDIA1
        '
        Me.fieldESTUDIA1.AreaIndex = 5
        Me.fieldESTUDIA1.Caption = "ESTUDIA"
        Me.fieldESTUDIA1.FieldName = "[ESTUDIA].[ESTUDIA]"
        Me.fieldESTUDIA1.Name = "fieldESTUDIA1"
        '
        'fieldMUNICIPIORESIDENCIA1
        '
        Me.fieldMUNICIPIORESIDENCIA1.AreaIndex = 6
        Me.fieldMUNICIPIORESIDENCIA1.Caption = "Municipio Residencia"
        Me.fieldMUNICIPIORESIDENCIA1.FieldName = "[MUNICIPIO_RESIDENCIA].[MUNICIPIO_RESIDENCIA]"
        Me.fieldMUNICIPIORESIDENCIA1.Name = "fieldMUNICIPIORESIDENCIA1"
        '
        'fieldNIVELACADEMICO1
        '
        Me.fieldNIVELACADEMICO1.AreaIndex = 7
        Me.fieldNIVELACADEMICO1.Caption = "Nivel Academico"
        Me.fieldNIVELACADEMICO1.FieldName = "[NIVEL_ACADEMICO].[NIVEL_ACADEMICO]"
        Me.fieldNIVELACADEMICO1.Name = "fieldNIVELACADEMICO1"
        '
        'fieldOFICIOSHOGAR1
        '
        Me.fieldOFICIOSHOGAR1.AreaIndex = 8
        Me.fieldOFICIOSHOGAR1.Caption = "Oficios del Hogar"
        Me.fieldOFICIOSHOGAR1.FieldName = "[OFICIOS_HOGAR].[OFICIOS_HOGAR]"
        Me.fieldOFICIOSHOGAR1.Name = "fieldOFICIOSHOGAR1"
        '
        'fieldPROVEEDOR1
        '
        Me.fieldPROVEEDOR1.AreaIndex = 9
        Me.fieldPROVEEDOR1.Caption = "Proveedor"
        Me.fieldPROVEEDOR1.FieldName = "[PROVEEDOR].[PROVEEDOR]"
        Me.fieldPROVEEDOR1.Name = "fieldPROVEEDOR1"
        '
        'fieldRANGOEDAD1
        '
        Me.fieldRANGOEDAD1.AreaIndex = 10
        Me.fieldRANGOEDAD1.Caption = "Rango Edad"
        Me.fieldRANGOEDAD1.FieldName = "[RANGO_EDAD].[RANGO_EDAD]"
        Me.fieldRANGOEDAD1.Name = "fieldRANGOEDAD1"
        '
        'fieldRANGOEDAD21
        '
        Me.fieldRANGOEDAD21.AreaIndex = 11
        Me.fieldRANGOEDAD21.Caption = "RANGO_EDAD2"
        Me.fieldRANGOEDAD21.FieldName = "[RANGO_EDAD2].[RANGO_EDAD2]"
        Me.fieldRANGOEDAD21.Name = "fieldRANGOEDAD21"
        '
        'fieldRANGONIVELACADEMICO1
        '
        Me.fieldRANGONIVELACADEMICO1.AreaIndex = 12
        Me.fieldRANGONIVELACADEMICO1.Caption = "Rango Nivel Academico"
        Me.fieldRANGONIVELACADEMICO1.FieldName = "[RANGO_NIVEL_ACADEMICO].[RANGO_NIVEL_ACADEMICO]"
        Me.fieldRANGONIVELACADEMICO1.Name = "fieldRANGONIVELACADEMICO1"
        '
        'fieldSECTOR1
        '
        Me.fieldSECTOR1.AreaIndex = 13
        Me.fieldSECTOR1.Caption = "Sector"
        Me.fieldSECTOR1.FieldName = "[SECTOR].[SECTOR]"
        Me.fieldSECTOR1.Name = "fieldSECTOR1"
        '
        'fieldSEXO1
        '
        Me.fieldSEXO1.AreaIndex = 14
        Me.fieldSEXO1.Caption = "Sexo"
        Me.fieldSEXO1.FieldName = "[SEXO].[SEXO]"
        Me.fieldSEXO1.Name = "fieldSEXO1"
        '
        'fieldSITIOCAPACITACION1
        '
        Me.fieldSITIOCAPACITACION1.AreaIndex = 15
        Me.fieldSITIOCAPACITACION1.Caption = "Centro Formación"
        Me.fieldSITIOCAPACITACION1.FieldName = "[SITIO_CAPACITACION].[SITIO_CAPACITACION]"
        Me.fieldSITIOCAPACITACION1.Name = "fieldSITIOCAPACITACION1"
        '
        'fieldSITUACIONLABORAL1
        '
        Me.fieldSITUACIONLABORAL1.AreaIndex = 16
        Me.fieldSITUACIONLABORAL1.Caption = "SITUACION_LABORAL"
        Me.fieldSITUACIONLABORAL1.FieldName = "[SITUACION_LABORAL].[SITUACION_LABORAL]"
        Me.fieldSITUACIONLABORAL1.Name = "fieldSITUACIONLABORAL1"
        '
        'fieldTIPOEMPLEO1
        '
        Me.fieldTIPOEMPLEO1.AreaIndex = 17
        Me.fieldTIPOEMPLEO1.Caption = "TIPO_EMPLEO"
        Me.fieldTIPOEMPLEO1.FieldName = "[TIPO_EMPLEO].[TIPO_EMPLEO]"
        Me.fieldTIPOEMPLEO1.Name = "fieldTIPOEMPLEO1"
        '
        'fieldTRABAJA1
        '
        Me.fieldTRABAJA1.AreaIndex = 18
        Me.fieldTRABAJA1.Caption = "TRABAJA"
        Me.fieldTRABAJA1.FieldName = "[TRABAJA].[TRABAJA]"
        Me.fieldTRABAJA1.Name = "fieldTRABAJA1"
        '
        'fieldCountOfIDCURSO1
        '
        Me.fieldCountOfIDCURSO1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldCountOfIDCURSO1.AreaIndex = 0
        Me.fieldCountOfIDCURSO1.Caption = "Cursos"
        Me.fieldCountOfIDCURSO1.FieldName = "[Measures].[CountOfID_CURSO]"
        Me.fieldCountOfIDCURSO1.Name = "fieldCountOfIDCURSO1"
        '
        'fieldCountOfIDSOLICITUD1
        '
        Me.fieldCountOfIDSOLICITUD1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldCountOfIDSOLICITUD1.AreaIndex = 1
        Me.fieldCountOfIDSOLICITUD1.Caption = "Participantes"
        Me.fieldCountOfIDSOLICITUD1.FieldName = "[Measures].[CountOfID_SOLICITUD]"
        Me.fieldCountOfIDSOLICITUD1.Name = "fieldCountOfIDSOLICITUD1"
        '
        'fieldSumOfCOSTOXPARTICIPANTE1
        '
        Me.fieldSumOfCOSTOXPARTICIPANTE1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldSumOfCOSTOXPARTICIPANTE1.AreaIndex = 2
        Me.fieldSumOfCOSTOXPARTICIPANTE1.Caption = "Costo"
        Me.fieldSumOfCOSTOXPARTICIPANTE1.FieldName = "[Measures].[SumOfCOSTO_X_PARTICIPANTE]"
        Me.fieldSumOfCOSTOXPARTICIPANTE1.Name = "fieldSumOfCOSTOXPARTICIPANTE1"
        '
        'frmSolicitudesParticipantesHTP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1107, 560)
        Me.Controls.Add(Me.PivotGridControl1)
        Me.Name = "frmSolicitudesParticipantesHTP"
        Me.Text = "Participantes Hábil Técnico Permanente"
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents fieldAREAFORMATIVA1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldBUSCATRABAJO1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCONDISCAPACIDAD1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldDEPARTAMENTORESIDENCIA1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldEDAD1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldEJERCICIO1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldESTADOCIVIL1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldESTUDIA1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldMUNICIPIORESIDENCIA1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldNIVELACADEMICO1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldOFICIOSHOGAR1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldPROVEEDOR1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldRANGOEDAD1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldRANGOEDAD21 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldRANGONIVELACADEMICO1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldSECTOR1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldSEXO1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldSITIOCAPACITACION1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldSITUACIONLABORAL1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldTIPOEMPLEO1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldTRABAJA1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCountOfIDCURSO1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCountOfIDSOLICITUD1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldSumOfCOSTOXPARTICIPANTE1 As DevExpress.XtraPivotGrid.PivotGridField
End Class
