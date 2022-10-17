Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucDetalleOFERTA_FORMATIVA
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
Public Class ucDetalleOFERTA_FORMATIVA

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

    Public ReadOnly Property Current() As OFERTA_FORMATIVA
        Get
            Return CType(Me.ListaOFERTA_FORMATIVABindingSource.Current, OFERTA_FORMATIVA)
        End Get
    End Property

    Public Overrides Property DataSource() As System.Windows.Forms.BindingSource 
        Get 
            Return Me.ListaOFERTA_FORMATIVABindingSource 
        End Get 
        Set(ByVal value As System.Windows.Forms.BindingSource) 
            Me.ListaOFERTA_FORMATIVABindingSource = value 
        End Set 
    End Property 

    Private Sub ListaOFERTA_FORMATIVABindingSource_CurrentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaOFERTA_FORMATIVABindingSource.CurrentChanged
        Me.ID_EJERCICIOcbxEJERCICIO.Recuperar()
        Me.ID_EJERCICIOcbxEJERCICIO.SelectedValue = Me.Current.ID_EJERCICIO
        Me.ID_TEMA_CURSOcbxCURSO_TEMA.Recuperar()
        Me.ID_TEMA_CURSOcbxCURSO_TEMA.SelectedValue = Me.Current.ID_TEMA_CURSO
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
        Dim mEntidad As New OFERTA_FORMATIVA 
        Me.ListaOFERTA_FORMATIVABindingSource.EndEdit() 
        mEntidad = Me.Current 
        Dim mControl As New cOFERTA_FORMATIVA 
    	   If mControl.ActualizarOFERTA_FORMATIVA(mEntidad) < 1 Then 
            Me.AsignarMensaje("No se pudo guardar el registro", True) 
            Return -1 
        End If 
        Me.ID_OFERTA_FORMATIVATextBox.Text = mEntidad.ID_OFERTA_FORMATIVA.ToString()
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
        Me.ID_EJERCICIOcbxEJERCICIO.Enabled = edicion
        Me.ID_TEMA_CURSOcbxCURSO_TEMA.Enabled = edicion
        Me.ID_PROVEEDOR_AFcbxPROVEEDOR_AF.Enabled = edicion
        Me.DURACION_HORASTextBox.Enabled = edicion
        Me.COSTO_X_PARTICIPANTETextBox.Enabled = edicion
        Me.FECHA_INICIODateTimePicker.Enabled = edicion
        Me.FECHA_FINDateTimePicker.Enabled = edicion
        Me.NOTASTextBox.Enabled = edicion
        Me.ESTADOTextBox.Enabled = edicion
        Me.FECHA_APROBACIONDateTimePicker.Enabled = edicion
        Me.USUARIO_APROBACIONTextBox.Enabled = edicion
        Me.USERIDTextBox.Enabled = edicion
        Me.LASTUPDATEDateTimePicker.Enabled = edicion
    End Sub

End Class
