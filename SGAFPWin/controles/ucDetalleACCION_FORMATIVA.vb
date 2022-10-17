Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucDetalleACCION_FORMATIVA
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
Public Class ucDetalleACCION_FORMATIVA

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

    Public ReadOnly Property Current() As ACCION_FORMATIVA
        Get
            Return CType(Me.ListaACCION_FORMATIVABindingSource.Current, ACCION_FORMATIVA)
        End Get
    End Property

    Public Overrides Property DataSource() As System.Windows.Forms.BindingSource 
        Get 
            Return Me.ListaACCION_FORMATIVABindingSource 
        End Get 
        Set(ByVal value As System.Windows.Forms.BindingSource) 
            Me.ListaACCION_FORMATIVABindingSource = value 
        End Set 
    End Property 

    Private Sub ListaACCION_FORMATIVABindingSource_CurrentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaACCION_FORMATIVABindingSource.CurrentChanged
        Me.ID_OFERTA_FORMATIVAcbxOFERTA_FORMATIVA.Recuperar()
        Me.ID_OFERTA_FORMATIVAcbxOFERTA_FORMATIVA.SelectedValue = Me.Current.ID_OFERTA_FORMATIVA
        Me.ID_SITIO_CAPACITACIONcbxSITIO_CAPACITACION.Recuperar()
        Me.ID_SITIO_CAPACITACIONcbxSITIO_CAPACITACION.SelectedValue = Me.Current.ID_SITIO_CAPACITACION
        Me.ID_PROVEEDOR_AFcbxPROVEEDOR_AF.Recuperar()
        Me.ID_PROVEEDOR_AFcbxPROVEEDOR_AF.SelectedValue = Me.Current.ID_PROVEEDOR_AF
        Me.ID_TEMA_CURSOcbxCURSO_TEMA.Recuperar()
        Me.ID_TEMA_CURSOcbxCURSO_TEMA.SelectedValue = Me.Current.ID_TEMA_CURSO
        Me.ID_EJERCICIOcbxEJERCICIO.Recuperar()
        Me.ID_EJERCICIOcbxEJERCICIO.SelectedValue = Me.Current.ID_EJERCICIO
        Me.CODIGO_ESTADO_AFcbxESTADO_ACCION_FORMATIVA.Recuperar()
        Me.CODIGO_ESTADO_AFcbxESTADO_ACCION_FORMATIVA.SelectedValue = Me.Current.CODIGO_ESTADO_AF
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
        Dim mEntidad As New ACCION_FORMATIVA 
        Me.ListaACCION_FORMATIVABindingSource.EndEdit() 
        mEntidad = Me.Current 
        Dim mControl As New cACCION_FORMATIVA 
    	   If mControl.ActualizarACCION_FORMATIVA(mEntidad) < 1 Then 
            Me.AsignarMensaje("No se pudo guardar el registro", True) 
            Return -1 
        End If 
        Me.ID_ACCION_FORMATIVATextBox.Text = mEntidad.ID_ACCION_FORMATIVA.ToString()
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
        Me.ID_OFERTA_FORMATIVAcbxOFERTA_FORMATIVA.Enabled = edicion
        Me.ID_SITIO_CAPACITACIONcbxSITIO_CAPACITACION.Enabled = edicion
        Me.ID_PROVEEDOR_AFcbxPROVEEDOR_AF.Enabled = edicion
        Me.ID_TEMA_CURSOcbxCURSO_TEMA.Enabled = edicion
        Me.ID_EJERCICIOcbxEJERCICIO.Enabled = edicion
        Me.NOMBRE_ACCION_FORMATIVATextBox.Enabled = edicion
        Me.CODIGO_GRUPOTextBox.Enabled = edicion
        Me.NUMERO_PARTICIPANTESTextBox.Enabled = edicion
        Me.PARTICIPANTES_INSCRITOSTextBox.Enabled = edicion
        Me.FECHA_INICIODateTimePicker.Enabled = edicion
        Me.FECHA_FINDateTimePicker.Enabled = edicion
        Me.HORARIOTextBox.Enabled = edicion
        Me.NOTASTextBox.Enabled = edicion
        Me.CODIGO_ESTADO_AFcbxESTADO_ACCION_FORMATIVA.Enabled = edicion
        Me.DURACION_HORASTextBox.Enabled = edicion
        Me.COSTO_X_PARTICIPANTETextBox.Enabled = edicion
        Me.USERIDTextBox.Enabled = edicion
        Me.LASTUPDATEDateTimePicker.Enabled = edicion
    End Sub

End Class
