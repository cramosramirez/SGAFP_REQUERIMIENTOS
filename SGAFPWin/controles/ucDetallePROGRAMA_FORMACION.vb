Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucDetallePROGRAMA_FORMACION
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
Public Class ucDetallePROGRAMA_FORMACION

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

    Public ReadOnly Property Current() As PROGRAMA_FORMACION
        Get
            Return CType(Me.ListaPROGRAMA_FORMACIONBindingSource.Current, PROGRAMA_FORMACION)
        End Get
    End Property

    Public Overrides Property DataSource() As System.Windows.Forms.BindingSource 
        Get 
            Return Me.ListaPROGRAMA_FORMACIONBindingSource 
        End Get 
        Set(ByVal value As System.Windows.Forms.BindingSource) 
            Me.ListaPROGRAMA_FORMACIONBindingSource = value 
        End Set 
    End Property 

    Private Sub ListaPROGRAMA_FORMACIONBindingSource_CurrentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaPROGRAMA_FORMACIONBindingSource.CurrentChanged
        Me.ID_TIPO_PAGOcbxPROGRAMA_FORMACION_TIPOPAGO.Recuperar()
        Me.ID_TIPO_PAGOcbxPROGRAMA_FORMACION_TIPOPAGO.SelectedValue = Me.Current.ID_TIPO_PAGO
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
        Dim mEntidad As New PROGRAMA_FORMACION 
        Me.ListaPROGRAMA_FORMACIONBindingSource.EndEdit() 
        mEntidad = Me.Current 
        Dim mControl As New cPROGRAMA_FORMACION 
    	   If mControl.ActualizarPROGRAMA_FORMACION(mEntidad) < 1 Then 
            Me.AsignarMensaje("No se pudo guardar el registro", True) 
            Return -1 
        End If 
        Me.ID_PROGRAMA_FORMACIONTextEdit.Text = mEntidad.ID_PROGRAMA_FORMACION.ToString()
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
        Me.NOMBRE_PROGRAMA_FORMACIONTextEdit.Enabled = edicion
        Me.USERIDTextEdit.Enabled = edicion
        Me.LASTUPDATEDateEdit.Enabled = edicion
        Me.PORC_ASISTENCIA_MINIMASpinEdit.Enabled = edicion
        Me.NOTA_MINIMASpinEdit.Enabled = edicion
        Me.ID_TIPO_PAGOcbxPROGRAMA_FORMACION_TIPOPAGO.Enabled = edicion
    End Sub

End Class
