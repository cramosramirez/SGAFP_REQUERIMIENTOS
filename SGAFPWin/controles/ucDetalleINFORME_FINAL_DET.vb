Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucDetalleINFORME_FINAL_DET
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
Public Class ucDetalleINFORME_FINAL_DET

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

    Public ReadOnly Property Current() As INFORME_FINAL_DET
        Get
            Return CType(Me.ListaINFORME_FINAL_DETBindingSource.Current, INFORME_FINAL_DET)
        End Get
    End Property

    Public Overrides Property DataSource() As System.Windows.Forms.BindingSource 
        Get 
            Return Me.ListaINFORME_FINAL_DETBindingSource 
        End Get 
        Set(ByVal value As System.Windows.Forms.BindingSource) 
            Me.ListaINFORME_FINAL_DETBindingSource = value 
        End Set 
    End Property 

    Private Sub ListaINFORME_FINAL_DETBindingSource_CurrentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaINFORME_FINAL_DETBindingSource.CurrentChanged
        Me.ID_INFORME_FINALcbxINFORME_FINAL_AF.Recuperar()
        Me.ID_INFORME_FINALcbxINFORME_FINAL_AF.SelectedValue = Me.Current.ID_INFORME_FINAL
        Me.ID_PARTICIPANTEcbxPARTICIPANTE.Recuperar()
        Me.ID_PARTICIPANTEcbxPARTICIPANTE.SelectedValue = Me.Current.ID_PARTICIPANTE
        Me.ID_ACCION_FORMATIVAcbxACCION_FORMATIVA.Recuperar()
        Me.ID_ACCION_FORMATIVAcbxACCION_FORMATIVA.SelectedValue = Me.Current.ID_ACCION_FORMATIVA
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
        Dim mEntidad As New INFORME_FINAL_DET 
        Me.ListaINFORME_FINAL_DETBindingSource.EndEdit() 
        mEntidad = Me.Current 
        Dim mControl As New cINFORME_FINAL_DET 
    	   If mControl.ActualizarINFORME_FINAL_DET(mEntidad) < 1 Then 
            Me.AsignarMensaje("No se pudo guardar el registro", True) 
            Return -1 
        End If 
        Me.ID_INFORME_FINAL_DETTextBox.Text = mEntidad.ID_INFORME_FINAL_DET.ToString()
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
        Me.ID_INFORME_FINALcbxINFORME_FINAL_AF.Enabled = edicion
        Me.ID_PARTICIPANTEcbxPARTICIPANTE.Enabled = edicion
        Me.ID_ACCION_FORMATIVAcbxACCION_FORMATIVA.Enabled = edicion
        Me.NOTA_OBTENIDATextBox.Enabled = edicion
        Me.PORC_ASISTENCIATextBox.Enabled = edicion
        Me.MONTO_SOLICITADOTextBox.Enabled = edicion
        Me.MONTO_APROBADOTextBox.Enabled = edicion
        Me.ESTADOTextBox.Enabled = edicion
        Me.NOTASTextBox.Enabled = edicion
    End Sub

End Class
