Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucDetalleCONTRATO_PROVEEDOR_AF
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
Public Class ucDetalleCONTRATO_PROVEEDOR_AF

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

    Public ReadOnly Property Current() As CONTRATO_PROVEEDOR_AF
        Get
            Return CType(Me.ListaCONTRATO_PROVEEDOR_AFBindingSource.Current, CONTRATO_PROVEEDOR_AF)
        End Get
    End Property

    Public Overrides Property DataSource() As System.Windows.Forms.BindingSource 
        Get 
            Return Me.ListaCONTRATO_PROVEEDOR_AFBindingSource 
        End Get 
        Set(ByVal value As System.Windows.Forms.BindingSource) 
            Me.ListaCONTRATO_PROVEEDOR_AFBindingSource = value 
        End Set 
    End Property 

    Private Sub ListaCONTRATO_PROVEEDOR_AFBindingSource_CurrentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaCONTRATO_PROVEEDOR_AFBindingSource.CurrentChanged
        Me.ID_PROVEEDOR_AFcbxPROVEEDOR_AF.Recuperar()
        Me.ID_PROVEEDOR_AFcbxPROVEEDOR_AF.SelectedValue = Me.Current.ID_PROVEEDOR_AF
        Me.ID_EJERCICIOcbxEJERCICIO.Recuperar()
        Me.ID_EJERCICIOcbxEJERCICIO.SelectedValue = Me.Current.ID_EJERCICIO
        Me.ID_PROGRAMA_FORMACIONcbxPROGRAMA_FORMACION.Recuperar()
        Me.ID_PROGRAMA_FORMACIONcbxPROGRAMA_FORMACION.SelectedValue = Me.Current.ID_PROGRAMA_FORMACION
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
        Dim mEntidad As New CONTRATO_PROVEEDOR_AF 
        Me.ListaCONTRATO_PROVEEDOR_AFBindingSource.EndEdit() 
        mEntidad = Me.Current 
        Dim mControl As New cCONTRATO_PROVEEDOR_AF 
    	   If mControl.ActualizarCONTRATO_PROVEEDOR_AF(mEntidad) < 1 Then 
            Me.AsignarMensaje("No se pudo guardar el registro", True) 
            Return -1 
        End If 
        Me.ID_CONTRATOTextEdit.Text = mEntidad.ID_CONTRATO.ToString()
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
        Me.NUM_CONTRATOTextEdit.Enabled = edicion
        Me.ID_PROVEEDOR_AFcbxPROVEEDOR_AF.Enabled = edicion
        Me.ID_EJERCICIOcbxEJERCICIO.Enabled = edicion
        Me.MONTO_ADJUDICADOSpinEdit.Enabled = edicion
        Me.USERIDTextEdit.Enabled = edicion
        Me.LASTUPDATEDateEdit.Enabled = edicion
        Me.NUM_LICITACIONTextEdit.Enabled = edicion
        Me.MONTO_DEVENGADOSpinEdit.Enabled = edicion
        Me.ID_PROGRAMA_FORMACIONcbxPROGRAMA_FORMACION.Enabled = edicion
        Me.PARTICIP_ADJUDICADASpinEdit.Enabled = edicion
        Me.FECHA_INICIODateEdit.Enabled = edicion
        Me.FECHA_FINDateEdit.Enabled = edicion
        Me.ID_PROYECTO_FORMACIONSpinEdit.Enabled = edicion
    End Sub

End Class
