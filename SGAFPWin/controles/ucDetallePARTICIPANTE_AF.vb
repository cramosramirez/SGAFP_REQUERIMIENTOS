Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucDetallePARTICIPANTE_AF
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
Public Class ucDetallePARTICIPANTE_AF

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

    Public ReadOnly Property Current() As PARTICIPANTE_AF
        Get
            Return CType(Me.ListaPARTICIPANTE_AFBindingSource.Current, PARTICIPANTE_AF)
        End Get
    End Property

    Public Overrides Property DataSource() As System.Windows.Forms.BindingSource 
        Get 
            Return Me.ListaPARTICIPANTE_AFBindingSource 
        End Get 
        Set(ByVal value As System.Windows.Forms.BindingSource) 
            Me.ListaPARTICIPANTE_AFBindingSource = value 
        End Set 
    End Property 

    Private Sub ListaPARTICIPANTE_AFBindingSource_CurrentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaPARTICIPANTE_AFBindingSource.CurrentChanged
        Me.ID_PARTICIPANTEcbxPARTICIPANTE.Recuperar()
        Me.ID_PARTICIPANTEcbxPARTICIPANTE.SelectedValue = Me.Current.ID_PARTICIPANTE
        Me.ID_ACCION_FORMATIVAcbxACCION_FORMATIVA.Recuperar()
        Me.ID_ACCION_FORMATIVAcbxACCION_FORMATIVA.SelectedValue = Me.Current.ID_ACCION_FORMATIVA
        Me.ID_SOLICITUDcbxSOLICITUD_INSCRIPCION_AF.Recuperar()
        Me.ID_SOLICITUDcbxSOLICITUD_INSCRIPCION_AF.SelectedValue = Me.Current.ID_SOLICITUD
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
        Dim mEntidad As New PARTICIPANTE_AF 
        Me.ListaPARTICIPANTE_AFBindingSource.EndEdit() 
        mEntidad = Me.Current 
        Dim mControl As New cPARTICIPANTE_AF 
        If Me.EsNuevo Then 
            If mControl.AgregarPARTICIPANTE_AF(mEntidad) < 1 Then 
                Me.AsignarMensaje("No se pudo agregar el registro", True) 
                Return -1 
            End If 
        Else 
            If mControl.ActualizarPARTICIPANTE_AF(mEntidad) < 1 Then 
                Me.AsignarMensaje("No se pudo guardar el registro", True) 
                Return -1 
            End If 
        End If 
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
        Me.ID_SOLICITUDcbxSOLICITUD_INSCRIPCION_AF.Enabled = edicion
        Me.ESTADOTextBox.Enabled = edicion
        Me.FECHA_INSCRIPCIONDateTimePicker.Enabled = edicion
        Me.NOTA_FINALTextBox.Enabled = edicion
        Me.PORC_ASISTENCIATextBox.Enabled = edicion
        Me.ENTREGA_DIPLOMATextBox.Enabled = edicion
        Me.NOTASTextBox.Enabled = edicion
    End Sub

End Class
