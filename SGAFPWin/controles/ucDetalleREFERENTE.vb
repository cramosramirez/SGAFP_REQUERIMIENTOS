Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucDetalleREFERENTE
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	05/10/2012	Created
''' </history>
''' -----------------------------------------------------------------------------
Public Class ucDetalleREFERENTE

    Private _EsConsulta As Boolean = False
    <DefaultValue(False)> _
    Public Property EsConsulta() As Boolean
        Get
            Return Me._EsConsulta
        End Get
        Set(ByVal value As Boolean)
            Me._EsConsulta = value
            Me.HabilitarEdicion(Not value)
        End Set
    End Property

    Public ReadOnly Property Current() As REFERENTE
        Get
            Return CType(Me.ListaREFERENTEBindingSource.Current, REFERENTE)
        End Get
    End Property

    Public Overrides Property DataSource() As System.Windows.Forms.BindingSource 
        Get 
            Return Me.ListaREFERENTEBindingSource 
        End Get 
        Set(ByVal value As System.Windows.Forms.BindingSource) 
            Me.ListaREFERENTEBindingSource = value 
        End Set 
    End Property 

    Private Sub ListaREFERENTEBindingSource_CurrentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaREFERENTEBindingSource.CurrentChanged
        Me.CODIGO_DEPARTAMENTOcbxDEPARTAMENTO.Recuperar()
        If Me.Current.CODIGO_DEPARTAMENTO IsNot Nothing Then
            Me.CODIGO_DEPARTAMENTOcbxDEPARTAMENTO.SelectedValue = Me.Current.CODIGO_DEPARTAMENTO
        Else
            Me.CODIGO_DEPARTAMENTOcbxDEPARTAMENTO.SelectedIndex = 0
        End If
        Me.CODIGO_MUNICIPIOcbxMUNICIPIO.Recuperar(Me.CODIGO_DEPARTAMENTOcbxDEPARTAMENTO.SelectedValue)
        If Me.Current.CODIGO_MUNICIPIO IsNot Nothing Then
            Me.CODIGO_MUNICIPIOcbxMUNICIPIO.SelectedValue = Me.Current.CODIGO_MUNICIPIO
        Else
            Me.CODIGO_MUNICIPIOcbxMUNICIPIO.SelectedIndex = 0
        End If
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que sobreescribe y realiza la acción de Guardar en la Base de Datos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Actualizar() As Integer 
        Dim mEntidad As New REFERENTE 
        Me.ListaREFERENTEBindingSource.EndEdit() 
        mEntidad = Me.Current 
        Dim mControl As New cREFERENTE 
    	   If mControl.ActualizarREFERENTE(mEntidad) < 1 Then 
            Me.AsignarMensaje("No se pudo guardar el registro", True) 
            Return -1 
        End If 
        Me.ID_REFERENTETextEdit.Text = mEntidad.ID_REFERENTE.ToString()
        Return 1 
    End Function 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que permite Habilitar/Deshabilitar el uso de los controles contenidos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.CODIGO_DEPARTAMENTOcbxDEPARTAMENTO.Enabled = edicion
        Me.CODIGO_MUNICIPIOcbxMUNICIPIO.Enabled = edicion
        Me.NOMBRE_REFERENTETextEdit.Enabled = edicion
        Me.DIRECCION_REFERENTETextEdit.Enabled = edicion
        Me.TELEF1TextEdit.Enabled = edicion
        Me.TELEF2TextEdit.Enabled = edicion
        Me.TELEF3TextEdit.Enabled = edicion
        Me.TELEF_MOVILTextEdit.Enabled = edicion
        Me.FAXTextEdit.Enabled = edicion
        Me.NOMBRE_CONTACTOTextEdit.Enabled = edicion
        Me.APELLIDOS_CONTACTOTextEdit.Enabled = edicion
        Me.EMAIL_CONTACTOTextEdit.Enabled = edicion
        Me.USERIDTextEdit.Enabled = edicion
        Me.LASTUPDATEDateEdit.Enabled = edicion
    End Sub

    Private Sub ucDetalleREFERENTE_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Inicializar()
    End Sub

    Private Sub Inicializar()
        Me.ID_REFERENTETextEdit.Enabled = False
        Me.USERIDLabelControl.Visible = False
        Me.LASTUPDATELabelControl.Visible = False
        Me.USERIDTextEdit.Visible = False
        Me.LASTUPDATEDateEdit.Visible = False
        Me.TELEF1TextEdit.Properties.Mask.EditMask = "####-####"
        Me.TELEF1TextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.TELEF1TextEdit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.TELEF1TextEdit.Properties.Mask.SaveLiteral = False
        Me.TELEF2TextEdit.Properties.Mask.EditMask = "####-####"
        Me.TELEF2TextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.TELEF2TextEdit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.TELEF2TextEdit.Properties.Mask.SaveLiteral = False
        Me.TELEF3TextEdit.Properties.Mask.EditMask = "####-####"
        Me.TELEF3TextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.TELEF3TextEdit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.TELEF3TextEdit.Properties.Mask.SaveLiteral = False
        Me.TELEF_MOVILTextEdit.Properties.Mask.EditMask = "####-####"
        Me.TELEF_MOVILTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.TELEF_MOVILTextEdit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.TELEF_MOVILTextEdit.Properties.Mask.SaveLiteral = False
        Me.FAXTextEdit.Properties.Mask.EditMask = "####-####"
        Me.FAXTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.FAXTextEdit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.FAXTextEdit.Properties.Mask.SaveLiteral = False
    End Sub

    Private Sub CODIGO_DEPARTAMENTOcbxDEPARTAMENTO_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CODIGO_DEPARTAMENTOcbxDEPARTAMENTO.SelectedIndexChanged
        If Me.CODIGO_DEPARTAMENTOcbxDEPARTAMENTO.SelectedValue IsNot Nothing Then Me.CODIGO_MUNICIPIOcbxMUNICIPIO.Recuperar(Me.CODIGO_DEPARTAMENTOcbxDEPARTAMENTO.SelectedValue)
    End Sub
End Class
