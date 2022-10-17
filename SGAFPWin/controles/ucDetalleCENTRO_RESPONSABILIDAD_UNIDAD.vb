Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucDetalleCENTRO_RESPONSABILIDAD_UNIDAD
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
Public Class ucDetalleCENTRO_RESPONSABILIDAD_UNIDAD

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

    Public ReadOnly Property Current() As CENTRO_RESPONSABILIDAD_UNIDAD
        Get
            Return CType(Me.ListaCENTRO_RESPONSABILIDAD_UNIDADBindingSource.Current, CENTRO_RESPONSABILIDAD_UNIDAD)
        End Get
    End Property

    Public Overrides Property DataSource() As System.Windows.Forms.BindingSource 
        Get 
            Return Me.ListaCENTRO_RESPONSABILIDAD_UNIDADBindingSource 
        End Get 
        Set(ByVal value As System.Windows.Forms.BindingSource) 
            Me.ListaCENTRO_RESPONSABILIDAD_UNIDADBindingSource = value 
        End Set 
    End Property 

    Private Sub ListaCENTRO_RESPONSABILIDAD_UNIDADBindingSource_CurrentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaCENTRO_RESPONSABILIDAD_UNIDADBindingSource.CurrentChanged
        Me.ID_CENTRO_RESPONSABILIDADcbxCENTRO_RESPONSABILIDAD.Recuperar()
        Me.ID_CENTRO_RESPONSABILIDADcbxCENTRO_RESPONSABILIDAD.SelectedValue = Me.Current.ID_CENTRO_RESPONSABILIDAD
        Me.ID_UNIDAD_ORGANIZATIVAcbxUNIDAD_ORGANIZATIVA.Recuperar()
        Me.ID_UNIDAD_ORGANIZATIVAcbxUNIDAD_ORGANIZATIVA.SelectedValue = Me.Current.ID_UNIDAD_ORGANIZATIVA
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
        Dim mEntidad As New CENTRO_RESPONSABILIDAD_UNIDAD 
        Me.ListaCENTRO_RESPONSABILIDAD_UNIDADBindingSource.EndEdit() 
        mEntidad = Me.Current 
        Dim mControl As New cCENTRO_RESPONSABILIDAD_UNIDAD 
        If Me.EsNuevo Then 
            If mControl.AgregarCENTRO_RESPONSABILIDAD_UNIDAD(mEntidad) < 1 Then 
                Me.AsignarMensaje("No se pudo agregar el registro", True) 
                Return -1 
            End If 
        Else 
            If mControl.ActualizarCENTRO_RESPONSABILIDAD_UNIDAD(mEntidad) < 1 Then 
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
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.USERIDTextEdit.Enabled = edicion
        Me.LASTUPDATEDateEdit.Enabled = edicion
    End Sub

End Class
