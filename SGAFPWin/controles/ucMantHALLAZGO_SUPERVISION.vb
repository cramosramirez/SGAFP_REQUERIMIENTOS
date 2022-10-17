Imports SGAFP.EL
Public Class ucMantHALLAZGO_SUPERVISION

    Private mListaHALLAZGO_SUPERVISION As listaHALLAZGO_SUPERVISION

    Private _EsConsulta As Boolean = False
    <DefaultValue(False)> _
    Public Property EsConsulta() As Boolean
        Get
            Return Me._EsConsulta
        End Get
        Set(ByVal value As Boolean)
            Me._EsConsulta = value
            Me.UcListaHALLAZGO_SUPERVISION1.EsConsulta = value
            Me.UcDetalleHALLAZGO_SUPERVISION1.EsConsulta = value
        End Set
    End Property

    Public Overrides ReadOnly Property EnEdicion() As Boolean
        Get
            If Me.UcListaHALLAZGO_SUPERVISION1.Current Is Nothing Then Return False
            Return Me.UcListaHALLAZGO_SUPERVISION1.Current.IsDirty
        End Get
    End Property

    Private Sub CargarHALLAZGO_SUPERVISION()
        Me.UcListaHALLAZGO_SUPERVISION1.CargarDatos()
        If Me.UcListaHALLAZGO_SUPERVISION1.Current Is Nothing Then
            Me.UcDetalleHALLAZGO_SUPERVISION1.DataSource.DataSource = (New HALLAZGO_SUPERVISION)
        Else
            Me.UcDetalleHALLAZGO_SUPERVISION1.DataSource.DataSource = Me.UcListaHALLAZGO_SUPERVISION1.Current
        End If
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla HALLAZGO_SUPERVISION
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub CargarDatos()
        Try 
            Me.UcListaHALLAZGO_SUPERVISION1.CargarDatos()
        Catch ex As Exception 
            Me.AsignarMensaje("No se pudo recuperar los datos")
        End Try 
    End Sub

    Public Overrides Function Guardar() As Integer
        Dim liRet As Integer = Me.UcListaHALLAZGO_SUPERVISION1.Guardar()
        If liRet <> 1 Then
            Me.sError = Me.UcListaHALLAZGO_SUPERVISION1.sError
        Else
            Me.sError = ""
        End If
        Return liRet
    End Function

    Private Sub UcListaHALLAZGO_SUPERVISION1_CambioRegistro() Handles UcListaHALLAZGO_SUPERVISION1.CambioRegistro
        If Not Me.UcListaHALLAZGO_SUPERVISION1.Current Is Nothing Then 
            Me.UcDetalleHALLAZGO_SUPERVISION1.DataSource.DataSource = Me.UcListaHALLAZGO_SUPERVISION1.Current
        End If 
    End Sub



End Class

