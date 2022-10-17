Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucDetalleUNIDAD_ORGANIZATIVA
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
Public Class ucDetalleUNIDAD_ORGANIZATIVA

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

    Public ReadOnly Property Current() As UNIDAD_ORGANIZATIVA
        Get
            Return CType(Me.ListaUNIDAD_ORGANIZATIVABindingSource.Current, UNIDAD_ORGANIZATIVA)
        End Get
    End Property

    Public Overrides Property DataSource() As System.Windows.Forms.BindingSource 
        Get 
            Return Me.ListaUNIDAD_ORGANIZATIVABindingSource 
        End Get 
        Set(ByVal value As System.Windows.Forms.BindingSource) 
            Me.ListaUNIDAD_ORGANIZATIVABindingSource = value 
        End Set 
    End Property 

    Private Sub ListaUNIDAD_ORGANIZATIVABindingSource_CurrentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaUNIDAD_ORGANIZATIVABindingSource.CurrentChanged
        Me.ID_UNIDAD_PADREcbxUNIDAD_ORGANIZATIVA.Recuperar()
        Me.ID_UNIDAD_PADREcbxUNIDAD_ORGANIZATIVA.SelectedValue = Me.Current.ID_UNIDAD_PADRE
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
        Dim mEntidad As New UNIDAD_ORGANIZATIVA 
        Me.ListaUNIDAD_ORGANIZATIVABindingSource.EndEdit() 
        mEntidad = Me.Current 
        Dim mControl As New cUNIDAD_ORGANIZATIVA 
    	   If mControl.ActualizarUNIDAD_ORGANIZATIVA(mEntidad) < 1 Then 
            Me.AsignarMensaje("No se pudo guardar el registro", True) 
            Return -1 
        End If 
        Me.ID_UNIDAD_ORGANIZATIVATextEdit.Text = mEntidad.ID_UNIDAD_ORGANIZATIVA.ToString()
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
        Me.NOMBRE_UNIDADTextEdit.Enabled = edicion
        Me.CODIGO_UNIDADTextEdit.Enabled = edicion
        Me.ID_UNIDAD_PADREcbxUNIDAD_ORGANIZATIVA.Enabled = edicion
        Me.ESTADOSpinEdit.Enabled = edicion
        Me.USERIDTextEdit.Enabled = edicion
        Me.LASTUPDATEDateEdit.Enabled = edicion
    End Sub

End Class
