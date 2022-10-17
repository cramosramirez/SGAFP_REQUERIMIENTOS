Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucDetallePARTICIPANTE_EXONERADO_DOC
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	28/06/2012	Created
''' </history>
''' -----------------------------------------------------------------------------
Public Class ucDetallePARTICIPANTE_EXONERADO_DOC

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

    Public ReadOnly Property Current() As PARTICIPANTE_EXONERADO_DOC
        Get
            Return CType(Me.ListaPARTICIPANTE_EXONERADO_DOCBindingSource.Current, PARTICIPANTE_EXONERADO_DOC)
        End Get
    End Property

    Public Overrides Property DataSource() As System.Windows.Forms.BindingSource 
        Get 
            Return Me.ListaPARTICIPANTE_EXONERADO_DOCBindingSource 
        End Get 
        Set(ByVal value As System.Windows.Forms.BindingSource) 
            Me.ListaPARTICIPANTE_EXONERADO_DOCBindingSource = value 
        End Set 
    End Property 

    Private Sub ListaPARTICIPANTE_EXONERADO_DOCBindingSource_CurrentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaPARTICIPANTE_EXONERADO_DOCBindingSource.CurrentChanged
        Me.ID_PARTICIPANTEcbxPARTICIPANTE.Recuperar()
        Me.ID_PARTICIPANTEcbxPARTICIPANTE.SelectedValue = Me.Current.ID_PARTICIPANTE
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que sobreescribe y realiza la acción de Guardar en la Base de Datos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/06/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Actualizar() As Integer 
        Dim mEntidad As New PARTICIPANTE_EXONERADO_DOC 
        Me.ListaPARTICIPANTE_EXONERADO_DOCBindingSource.EndEdit() 
        mEntidad = Me.Current 
        Dim mControl As New cPARTICIPANTE_EXONERADO_DOC 
        If Me.EsNuevo Then 
            If mControl.AgregarPARTICIPANTE_EXONERADO_DOC(mEntidad) < 1 Then 
                Me.AsignarMensaje("No se pudo agregar el registro", True) 
                Return -1 
            End If 
        Else 
            If mControl.ActualizarPARTICIPANTE_EXONERADO_DOC(mEntidad) < 1 Then 
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
    ''' 	[GenApp]	28/06/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.USERIDTextEdit.Enabled = edicion
        Me.LASTUPDATEDateEdit.Enabled = edicion
    End Sub

End Class
