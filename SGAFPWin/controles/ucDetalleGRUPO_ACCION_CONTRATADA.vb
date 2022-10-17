Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucDetalleGRUPO_ACCION_CONTRATADA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	12/04/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
Public Class ucDetalleGRUPO_ACCION_CONTRATADA

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

    Public ReadOnly Property Current() As GRUPO_ACCION_CONTRATADA
        Get
            Return CType(Me.ListaGRUPO_ACCION_CONTRATADABindingSource.Current, GRUPO_ACCION_CONTRATADA)
        End Get
    End Property

    Public Overrides Property DataSource() As System.Windows.Forms.BindingSource 
        Get 
            Return Me.ListaGRUPO_ACCION_CONTRATADABindingSource 
        End Get 
        Set(ByVal value As System.Windows.Forms.BindingSource) 
            Me.ListaGRUPO_ACCION_CONTRATADABindingSource = value 
        End Set 
    End Property 

    Private Sub ListaGRUPO_ACCION_CONTRATADABindingSource_CurrentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaGRUPO_ACCION_CONTRATADABindingSource.CurrentChanged
        Me.ID_ACCION_CONTRATADAcbxACCION_CONTRATADA.Recuperar()
        Me.ID_ACCION_CONTRATADAcbxACCION_CONTRATADA.SelectedValue = Me.Current.ID_ACCION_CONTRATADA
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
    ''' 	[GenApp]	12/04/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Actualizar() As Integer 
        Dim mEntidad As New GRUPO_ACCION_CONTRATADA 
        Me.ListaGRUPO_ACCION_CONTRATADABindingSource.EndEdit() 
        mEntidad = Me.Current 
        Dim mControl As New cGRUPO_ACCION_CONTRATADA 
    	   If mControl.ActualizarGRUPO_ACCION_CONTRATADA(mEntidad) < 1 Then 
            Me.AsignarMensaje("No se pudo guardar el registro", True) 
            Return -1 
        End If 
        Me.ID_GRUPO_ACCIONTextEdit.Text = mEntidad.ID_GRUPO_ACCION.ToString()
        Return 1 
    End Function 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que permite Habilitar/Deshabilitar el uso de los controles contenidos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	12/04/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.ID_ACCION_CONTRATADAcbxACCION_CONTRATADA.Enabled = edicion
        Me.ID_GRUPO_AFSpinEdit.Enabled = edicion
        Me.ID_ACCION_FORMATIVAcbxACCION_FORMATIVA.Enabled = edicion
        Me.USUARIO_CREACIONTextEdit.Enabled = edicion
        Me.FECHA_CREACIONDateEdit.Enabled = edicion
        Me.USERIDTextEdit.Enabled = edicion
        Me.LASTUPDATEDateEdit.Enabled = edicion
    End Sub

End Class
