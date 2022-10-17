Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucDetalleINFORME_FINAL_AF
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	23/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
Public Class ucDetalleINFORME_FINAL_AF

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

    Public ReadOnly Property Current() As INFORME_FINAL_AF
        Get
            Return CType(Me.ListaINFORME_FINAL_AFBindingSource.Current, INFORME_FINAL_AF)
        End Get
    End Property

    Public Overrides Property DataSource() As System.Windows.Forms.BindingSource 
        Get 
            Return Me.ListaINFORME_FINAL_AFBindingSource 
        End Get 
        Set(ByVal value As System.Windows.Forms.BindingSource) 
            Me.ListaINFORME_FINAL_AFBindingSource = value 
        End Set 
    End Property 

    Private Sub ListaINFORME_FINAL_AFBindingSource_CurrentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaINFORME_FINAL_AFBindingSource.CurrentChanged
        Me.ID_ACCION_FORMATIVAcbxACCION_FORMATIVA.Recuperar()
        Me.ID_ACCION_FORMATIVAcbxACCION_FORMATIVA.SelectedValue = Me.Current.ID_ACCION_FORMATIVA
        Me.ID_PROVEEDOR_AFcbxPROVEEDOR_AF.Recuperar()
        Me.ID_PROVEEDOR_AFcbxPROVEEDOR_AF.SelectedValue = Me.Current.ID_PROVEEDOR_AF
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que sobreescribe y realiza la acción de Guardar en la Base de Datos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Actualizar() As Integer 
        Dim mEntidad As New INFORME_FINAL_AF 
        Me.ListaINFORME_FINAL_AFBindingSource.EndEdit() 
        mEntidad = Me.Current 
        Dim mControl As New cINFORME_FINAL_AF 
    	   If mControl.ActualizarINFORME_FINAL_AF(mEntidad) < 1 Then 
            Me.AsignarMensaje("No se pudo guardar el registro", True) 
            Return -1 
        End If 
        Me.ID_INFORME_FINALTextBox.Text = mEntidad.ID_INFORME_FINAL.ToString()
        Return 1 
    End Function 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que permite Habilitar/Deshabilitar el uso de los controles contenidos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.ID_ACCION_FORMATIVAcbxACCION_FORMATIVA.Enabled = edicion
        Me.ID_PROVEEDOR_AFcbxPROVEEDOR_AF.Enabled = edicion
        Me.FECHA_INFORMEDateTimePicker.Enabled = edicion
        Me.NUMERO_FACTURATextBox.Enabled = edicion
        Me.ELABORADO_PORTextBox.Enabled = edicion
        Me.MONTO_FACTURATextBox.Enabled = edicion
        Me.MONTO_APROBADOTextBox.Enabled = edicion
        Me.PARTICIPANTES_INSCRITOSTextBox.Enabled = edicion
        Me.PARTICIPANTES_FINALESTextBox.Enabled = edicion
        Me.PORC_PROM_ASISTENCIATextBox.Enabled = edicion
        Me.NOTA_PROMEDIOTextBox.Enabled = edicion
        Me.ESTADOTextBox.Enabled = edicion
        Me.COMENTARIOSTextBox.Enabled = edicion
        Me.USUARIO_APROBACIONTextBox.Enabled = edicion
        Me.USERIDTextBox.Enabled = edicion
        Me.LASTUDATEDateTimePicker.Enabled = edicion
    End Sub

End Class
