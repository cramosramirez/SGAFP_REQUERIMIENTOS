Imports System.Windows.Forms
Public Class frmPrincipal

    Private mFrmLogin As frmLogin
    Private _Usuario As String

    Public ReadOnly Property Usuario() As String
        Get
            Return Me._Usuario
        End Get
    End Property

#Region "System Functions"
    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles NewToolStripMenuItem.Click, NewToolStripButton.Click, NewWindowToolStripMenuItem.Click
        ' Create a new instance of the child form.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Window " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs) Handles OpenToolStripMenuItem.Click, OpenToolStripButton.Click
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: Add code here to open the file.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Add code here to save the current contents of the form to a file.
        End If
    End Sub

    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Salir()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CutToolStripMenuItem.Click
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CopyToolStripMenuItem.Click
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PasteToolStripMenuItem.Click
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolBarToolStripMenuItem.Click
        Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StatusBarToolStripMenuItem.Click
        Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticleToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer = 0

    Private Sub ToolStripButtonSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButtonSalir.Click
        Me.Salir()
    End Sub

    Public Sub Salir()
        Global.System.Windows.Forms.Application.Exit()
    End Sub

    Public Function ObtenerVentanaActiva() As frmBase
        Return CType(Me.ActiveMdiChild, frmBase)
    End Function

    Private Sub AddToolBarOption(ByVal asText As String)
        Me.AddToolBarOption(asText, Nothing)
    End Sub

    Private Sub AddToolBarOption(ByVal asText As String, ByVal aiImageIcon As Image, Optional ByVal abViewText As Boolean = False)
        If aiImageIcon Is Nothing Then
            Me.GenToolBar1.AddOption(asText, Nothing, AddressOf ClickOption_Activate, abViewText)
        ElseIf Not aiImageIcon Is Nothing Then
            Me.GenToolBar1.AddOption(asText, aiImageIcon, AddressOf ClickOption_Activate, abViewText)
        End If
    End Sub

    Public Sub AddMenuOption(ByVal asText As String, Optional ByVal abToolbarOption As Boolean = False)
        Me.AddMenuOption(asText, Nothing, abToolbarOption)
    End Sub

    Public Sub AddMenuOption(ByVal asText As String, ByVal aiImageIcon As Image, Optional ByVal abToolbarOption As Boolean = False, Optional ByVal abVerTexto As Boolean = False)
        If Me.OptionsToolStripMenuItem1.DropDownItems.ContainsKey("mn" + asText) Then
            Me.EnableMenuOption(asText)
            Return
        End If
        'Add Menu Option to MDI Frame
        Dim lToolStripItem As ToolStripMenuItem = Nothing
        If aiImageIcon Is Nothing Then
            lToolStripItem = New ToolStripMenuItem(asText, Nothing, AddressOf ClickOption_Activate)
        ElseIf Not aiImageIcon Is Nothing Then
            lToolStripItem = New ToolStripMenuItem(asText, aiImageIcon, AddressOf ClickOption_Activate)
        End If
        lToolStripItem.ToolTipText = asText
        lToolStripItem.Name = "mn" + asText
        Me.OptionsToolStripMenuItem1.DropDownItems.Add(lToolStripItem)
        ' If is a ToolBarOption, create a Button in a ToolBar for use with 
        ' the same funcionality that the Menu Option
        If abToolbarOption Then
            Me.AddToolBarOption(asText, aiImageIcon, abVerTexto)
        End If
    End Sub

    Public Sub EnableMenuOption(ByVal asText As String)
        If Me.OptionsToolStripMenuItem1.DropDownItems.IndexOfKey("mn" + asText) > -1 Then
            Me.OptionsToolStripMenuItem1.DropDownItems(Me.OptionsToolStripMenuItem1.DropDownItems.IndexOfKey("mn" + asText)).Enabled = True
        End If
        Me.GenToolBar1.EnableToolBarOption(asText)
    End Sub

    Public Sub DisableMenuOption(ByVal asText As String)
        If Me.OptionsToolStripMenuItem1.DropDownItems.IndexOfKey("mn" + asText) > -1 Then
            Me.OptionsToolStripMenuItem1.DropDownItems(Me.OptionsToolStripMenuItem1.DropDownItems.IndexOfKey("mn" + asText)).Enabled = False
        End If
        Me.GenToolBar1.DisableToolBarOption(asText)
    End Sub

    Public Sub EnableOptions()
        Me.OptionsToolStripMenuItem1.Visible = True
        Me.GenToolBar1.Visible = True
    End Sub

    Public Sub DisableOptions()
        Try
            Me.OptionsToolStripMenuItem1.Visible = False
            Me.GenToolBar1.Visible = False
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ClickOption_Activate(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim lsOption As String
        lsOption = CType(sender, ToolStripItem).ToolTipText
        If Not Me.ObtenerVentanaActiva() Is Nothing Then Me.ObtenerVentanaActiva().EjecutarOpcion(lsOption)
    End Sub

    Public Sub ClearOptions()
        Me.OptionsToolStripMenuItem1.DropDownItems.Clear()
        Me.GenToolBar1.Items.Clear()
    End Sub
#End Region

    Private Sub frmPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'SGAFP.EL.configuracion.tituloAplicacion = System.Configuration.ConfigurationManager.AppSettings("nombreSistema")
        Me.Text = SGAFP.EL.configuracion.tituloAplicacion
        Me.IniciarLogin()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        Dim lFrmAbout As New frmAcercaDe
        lFrmAbout.ShowDialog()
    End Sub

    Private Sub IniciarLogin()
        mFrmLogin = New frmLogin
        AddHandler Me.mFrmLogin.Closing, AddressOf Me.mFrmLogin_Close
        Dim dResult As System.Windows.Forms.DialogResult
        dResult = mFrmLogin.ShowDialog(Me)
        If dResult <> Windows.Forms.DialogResult.OK Then
            Me.Close()
            Return
        End If
        'Configurar Valores Globales
        Try
            SGAFP.EL.configuracion.usuarioActualiza = Me.Usuario
            'Obtencion de Roles para aplicación
        Catch ex As Exception

        End Try

    End Sub

    Private Sub mFrmLogin_Close(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
        Dim form As frmLogin
        form = CType(sender, frmLogin)
        Me._Usuario = form.Usuario
        Me.Text = Me.Text & " - Usuario: " & Me._Usuario
    End Sub

    Private Sub USUARIOToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles USUARIOToolStripMenuItem.Click
        Dim mForma As New frmMantUSUARIO
        mForma.MdiParent = Me
        mForma.Show()
    End Sub

    Private Sub UNIDAD_ORGANIZATIVAToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UNIDAD_ORGANIZATIVAToolStripMenuItem.Click
        Dim mForma As New frmMantUNIDAD_ORGANIZATIVA
        mForma.MdiParent = Me
        mForma.Show()
    End Sub

    Private Sub TIPO_SOLICITUDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TIPO_SOLICITUDToolStripMenuItem.Click
        Dim mForma As New frmMantTIPO_SOLICITUD
        mForma.MdiParent = Me
        mForma.Show()
    End Sub

    Private Sub TIPO_PERSONAToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TIPO_PERSONAToolStripMenuItem.Click
        Dim mForma As New frmMantTIPO_PERSONA
        mForma.MdiParent = Me
        mForma.Show()
    End Sub

    Private Sub SUPERVISION_AF_DETToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SUPERVISION_AF_DETToolStripMenuItem.Click
        Dim mForma As New frmMantSUPERVISION_AF_DET
        mForma.MdiParent = Me
        mForma.Show()
    End Sub

    Private Sub SUPERVISION_AFToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SUPERVISION_AFToolStripMenuItem.Click
        Dim mForma As New frmMantSUPERVISION_AF
        mForma.MdiParent = Me
        mForma.Show()
    End Sub

    Private Sub SOLICITUD_INSCRIPCION_AFToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SOLICITUD_INSCRIPCION_AFToolStripMenuItem.Click
        Dim mForma As New frmMantSOLICITUD_INSCRIPCION_AF
        mForma.MdiParent = Me
        mForma.Show()
    End Sub

    Private Sub SOLIC_EMPLEO_ANTERIORToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SOLIC_EMPLEO_ANTERIORToolStripMenuItem.Click
        Dim mForma As New frmMantSOLIC_EMPLEO_ANTERIOR
        mForma.MdiParent = Me
        mForma.Show()
    End Sub

    Private Sub SOLIC_EMPLEO_ACTUALToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SOLIC_EMPLEO_ACTUALToolStripMenuItem.Click
        Dim mForma As New frmMantSOLIC_EMPLEO_ACTUAL
        mForma.MdiParent = Me
        mForma.Show()
    End Sub

    Private Sub SOLIC_CURSOS_RECIBIDOSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SOLIC_CURSOS_RECIBIDOSToolStripMenuItem.Click
        Dim mForma As New frmMantSOLIC_CURSOS_RECIBIDOS
        mForma.MdiParent = Me
        mForma.Show()
    End Sub

    Private Sub SITIO_CAPACITACIONToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SITIO_CAPACITACIONToolStripMenuItem.Click
        Dim mForma As New frmMantSITIO_CAPACITACION
        mForma.MdiParent = Me
        mForma.Show()
    End Sub

    Private Sub REGIONToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REGIONToolStripMenuItem.Click
        Dim mForma As New frmMantREGION
        mForma.MdiParent = Me
        mForma.Show()
    End Sub

    Private Sub PROVEEDOR_AFToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PROVEEDOR_AFToolStripMenuItem.Click
        Dim mForma As New frmMantPROVEEDOR_AF
        mForma.MdiParent = Me
        mForma.Show()
    End Sub

    Private Sub PROGRAMA_FORMACIONToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PROGRAMA_FORMACIONToolStripMenuItem.Click
        Dim mForma As New frmMantPROGRAMA_FORMACION
        mForma.MdiParent = Me
        mForma.Show()
    End Sub

    Private Sub PROCESOToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PROCESOToolStripMenuItem.Click
        Dim mForma As New frmMantPROCESO
        mForma.MdiParent = Me
        mForma.Show()
    End Sub

    Private Sub PARTICIPANTE_AFToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PARTICIPANTE_AFToolStripMenuItem.Click
        Dim mForma As New frmMantPARTICIPANTE_AF
        mForma.MdiParent = Me
        mForma.Show()
    End Sub

    Private Sub PARTICIPANTEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PARTICIPANTEToolStripMenuItem.Click
        Dim mForma As New frmMantPARTICIPANTE
        mForma.MdiParent = Me
        mForma.Show()
    End Sub

    Private Sub OPCION_MENUToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OPCION_MENUToolStripMenuItem.Click
        Dim mForma As New frmMantOPCION_MENU
        mForma.MdiParent = Me
        mForma.Show()
    End Sub

    Private Sub OPCION_GRUPOToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OPCION_GRUPOToolStripMenuItem.Click
        Dim mForma As New frmMantOPCION_GRUPO
        mForma.MdiParent = Me
        mForma.Show()
    End Sub

    Private Sub OFERTA_FORMATIVAToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OFERTA_FORMATIVAToolStripMenuItem.Click
        Dim mForma As New frmMantOFERTA_FORMATIVA
        mForma.MdiParent = Me
        mForma.Show()
    End Sub

    Private Sub NIVEL_ACADEMICOToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NIVEL_ACADEMICOToolStripMenuItem.Click
        Dim mForma As New frmMantNIVEL_ACADEMICO
        mForma.MdiParent = Me
        mForma.Show()
    End Sub

    Private Sub MUNICIPIOToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MUNICIPIOToolStripMenuItem.Click
        Dim mForma As New frmMantMUNICIPIO
        mForma.MdiParent = Me
        mForma.Show()
    End Sub

    Private Sub MODALIDAD_DE_FORMACIONToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MODALIDAD_DE_FORMACIONToolStripMenuItem.Click
        Dim mForma As New frmMantMODALIDAD_DE_FORMACION
        mForma.MdiParent = Me
        mForma.Show()
    End Sub

    Private Sub METODO_EVALUACIONToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles METODO_EVALUACIONToolStripMenuItem.Click
        Dim mForma As New frmMantMETODO_EVALUACION
        mForma.MdiParent = Me
        mForma.Show()
    End Sub

    Private Sub LISTA_SUPERVISION_AFToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LISTA_SUPERVISION_AFToolStripMenuItem.Click
        Dim mForma As New frmMantLISTA_SUPERVISION_AF
        mForma.MdiParent = Me
        mForma.Show()
    End Sub

    Private Sub INFORME_FINAL_DETToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles INFORME_FINAL_DETToolStripMenuItem.Click
        Dim mForma As New frmMantINFORME_FINAL_DET
        mForma.MdiParent = Me
        mForma.Show()
    End Sub

    Private Sub INFORME_FINAL_AFToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles INFORME_FINAL_AFToolStripMenuItem.Click
        Dim mForma As New frmMantINFORME_FINAL_AF
        mForma.MdiParent = Me
        mForma.Show()
    End Sub

    Private Sub HALLAZGO_SUPERVISIONToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HALLAZGO_SUPERVISIONToolStripMenuItem.Click
        Dim mForma As New frmMantHALLAZGO_SUPERVISION
        mForma.MdiParent = Me
        mForma.Show()
    End Sub

    Private Sub GRUPO_USUARIOToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GRUPO_USUARIOToolStripMenuItem.Click
        Dim mForma As New frmMantGRUPO_USUARIO
        mForma.MdiParent = Me
        mForma.Show()
    End Sub

    Private Sub FACILITADOR_CAPACITADORToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FACILITADOR_CAPACITADORToolStripMenuItem.Click
        Dim mForma As New frmMantFACILITADOR_CAPACITADOR
        mForma.MdiParent = Me
        mForma.Show()
    End Sub

    Private Sub EVALUACIONES_AF_DETToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EVALUACIONES_AF_DETToolStripMenuItem.Click
        Dim mForma As New frmMantEVALUACIONES_AF_DET
        mForma.MdiParent = Me
        mForma.Show()
    End Sub

    Private Sub EVALUACION_AFToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EVALUACION_AFToolStripMenuItem.Click
        Dim mForma As New frmMantEVALUACION_AF
        mForma.MdiParent = Me
        mForma.Show()
    End Sub

    Private Sub ETAPAToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ETAPAToolStripMenuItem.Click
        Dim mForma As New frmMantETAPA
        mForma.MdiParent = Me
        mForma.Show()
    End Sub

    Private Sub ESTADO_SOLICITUDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ESTADO_SOLICITUDToolStripMenuItem.Click
        Dim mForma As New frmMantESTADO_SOLICITUD
        mForma.MdiParent = Me
        mForma.Show()
    End Sub

    Private Sub ESTADO_ACCION_FORMATIVAToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ESTADO_ACCION_FORMATIVAToolStripMenuItem.Click
        Dim mForma As New frmMantESTADO_ACCION_FORMATIVA
        mForma.MdiParent = Me
        mForma.Show()
    End Sub

    Private Sub EMPRESASToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EMPRESASToolStripMenuItem.Click
        Dim mForma As New frmMantEMPRESAS
        mForma.MdiParent = Me
        mForma.Show()
    End Sub

    Private Sub EJERCICIOToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EJERCICIOToolStripMenuItem.Click
        Dim mForma As New frmMantEJERCICIO
        mForma.MdiParent = Me
        mForma.Show()
    End Sub

    Private Sub DEPARTAMENTOToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DEPARTAMENTOToolStripMenuItem.Click
        Dim mForma As New frmMantDEPARTAMENTO
        mForma.MdiParent = Me
        mForma.Show()
    End Sub

    Private Sub CURSO_TEMAToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CURSO_TEMAToolStripMenuItem.Click
        Dim mForma As New frmMantCURSO_TEMA
        mForma.MdiParent = Me
        mForma.Show()
    End Sub

    Private Sub CONTROL_DOCUMENTOSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CONTROL_DOCUMENTOSToolStripMenuItem.Click
        Dim mForma As New frmMantCONTROL_DOCUMENTOS
        mForma.MdiParent = Me
        mForma.Show()
    End Sub

    Private Sub CIUUToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CIUUToolStripMenuItem.Click
        Dim mForma As New frmMantCIUU
        mForma.MdiParent = Me
        mForma.Show()
    End Sub

    Private Sub CIUOToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CIUOToolStripMenuItem.Click
        Dim mForma As New frmMantCIUO
        mForma.MdiParent = Me
        mForma.Show()
    End Sub

    Private Sub CATCURSO_2ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CATCURSO_2ToolStripMenuItem.Click
        Dim mForma As New frmMantCATCURSO_2
        mForma.MdiParent = Me
        mForma.Show()
    End Sub

    Private Sub ASISTENCIA_AF_DETToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ASISTENCIA_AF_DETToolStripMenuItem.Click
        Dim mForma As New frmMantASISTENCIA_AF_DET
        mForma.MdiParent = Me
        mForma.Show()
    End Sub

    Private Sub ASISTENCIA_AFToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ASISTENCIA_AFToolStripMenuItem.Click
        Dim mForma As New frmMantASISTENCIA_AF
        mForma.MdiParent = Me
        mForma.Show()
    End Sub

    Private Sub AREA_SUPERVISIONToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AREA_SUPERVISIONToolStripMenuItem.Click
        Dim mForma As New frmMantAREA_SUPERVISION
        mForma.MdiParent = Me
        mForma.Show()
    End Sub

    Private Sub ACCION_FORMATIVAToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ACCION_FORMATIVAToolStripMenuItem.Click
        Dim mForma As New frmMantACCION_FORMATIVA
        mForma.MdiParent = Me
        mForma.Show()
    End Sub

    Private Sub AREA_FORMACIONToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AREA_FORMACIONToolStripMenuItem.Click
        Dim mForma As New frmMantAREA_FORMACION
        mForma.MdiParent = Me
        mForma.Show()
    End Sub

End Class

