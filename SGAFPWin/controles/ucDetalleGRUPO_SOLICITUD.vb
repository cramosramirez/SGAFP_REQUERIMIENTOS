Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucDetalleGRUPO_SOLICITUD
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
Public Class ucDetalleGRUPO_SOLICITUD

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

    Public ReadOnly Property Current() As GRUPO_SOLICITUD
        Get
            Return CType(Me.ListaGRUPO_SOLICITUDBindingSource.Current, GRUPO_SOLICITUD)
        End Get
    End Property

    Public Overrides Property DataSource() As System.Windows.Forms.BindingSource
        Get
            Return Me.ListaGRUPO_SOLICITUDBindingSource
        End Get
        Set(ByVal value As System.Windows.Forms.BindingSource)
            Me.ListaGRUPO_SOLICITUDBindingSource = value
        End Set
    End Property

    Private Sub ListaGRUPO_SOLICITUDBindingSource_CurrentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaGRUPO_SOLICITUDBindingSource.CurrentChanged
        Me.ID_SOLICITUDcbxSOLICITUD_CAPACITACION.Recuperar()
        Me.ID_SOLICITUDcbxSOLICITUD_CAPACITACION.SelectedValue = Me.Current.ID_SOLICITUD
        Me.ID_MODALIDAD_FORMACIONcbxMODALIDAD_DE_FORMACION.Recuperar()
        Me.ID_MODALIDAD_FORMACIONcbxMODALIDAD_DE_FORMACION.SelectedValue = Me.Current.ID_MODALIDAD_FORMACION
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
        Dim mEntidad As New GRUPO_SOLICITUD
        Me.ListaGRUPO_SOLICITUDBindingSource.EndEdit()
        mEntidad = Me.Current
        Dim mControl As New cGRUPO_SOLICITUD
        If mControl.ActualizarGRUPO_SOLICITUD(mEntidad) < 1 Then
            Me.AsignarMensaje("No se pudo guardar el registro", True)
            Return -1
        End If
        Me.ID_GRUPO_SOLICITUDTextEdit.Text = mEntidad.ID_GRUPO_SOLICITUD.ToString()
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
        Me.ID_SOLICITUDcbxSOLICITUD_CAPACITACION.Enabled = edicion
        Me.ID_MODALIDAD_FORMACIONcbxMODALIDAD_DE_FORMACION.Enabled = edicion
        Me.CODIGO_PROGRAMATextEdit.Enabled = edicion
        Me.DURACION_HORASSpinEdit.Enabled = edicion
        Me.NUM_PARTICIPANTESSpinEdit.Enabled = edicion
        Me.TDRTextEdit.Enabled = edicion
        Me.USERIDTextEdit.Enabled = edicion
        Me.LASTUPDATEDateEdit.Enabled = edicion
    End Sub

End Class
