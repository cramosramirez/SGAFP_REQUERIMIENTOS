Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucDetallePROYECTO_FORMACION
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
Public Class ucDetallePROYECTO_FORMACION

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

    Public ReadOnly Property Current() As PROYECTO_FORMACION
        Get
            Return CType(Me.ListaPROYECTO_FORMACIONBindingSource.Current, PROYECTO_FORMACION)
        End Get
    End Property

    Public Overrides Property DataSource() As System.Windows.Forms.BindingSource 
        Get 
            Return Me.ListaPROYECTO_FORMACIONBindingSource 
        End Get 
        Set(ByVal value As System.Windows.Forms.BindingSource) 
            Me.ListaPROYECTO_FORMACIONBindingSource = value 
        End Set 
    End Property 

    Private Sub ListaPROYECTO_FORMACIONBindingSource_CurrentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaPROYECTO_FORMACIONBindingSource.CurrentChanged
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
        Dim mEntidad As New PROYECTO_FORMACION 
        Me.ListaPROYECTO_FORMACIONBindingSource.EndEdit() 
        mEntidad = Me.Current 
        Dim mControl As New cPROYECTO_FORMACION 
    	   If mControl.ActualizarPROYECTO_FORMACION(mEntidad) < 1 Then 
            Me.AsignarMensaje("No se pudo guardar el registro", True) 
            Return -1 
        End If 
        Me.ID_PROYECTO_FORMACIONTextEdit.Text = mEntidad.ID_PROYECTO_FORMACION.ToString()
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
        Me.NOMBRE_PROYECTO_FORMACIONTextEdit.Enabled = edicion
        Me.USERIDTextEdit.Enabled = edicion
        Me.LASTUPDATEDateEdit.Enabled = edicion
    End Sub

    Private Sub Inicializar()
        Me.ID_PROYECTO_FORMACIONTextEdit.Enabled = False
        Me.USERIDLabelControl.Visible = False
        Me.LASTUPDATELabelControl.Visible = False
        Me.USERIDTextEdit.Visible = False
        Me.LASTUPDATEDateEdit.Visible = False
    End Sub

    Private Sub ucDetallePROYECTO_FORMACION_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Inicializar()
    End Sub
End Class
