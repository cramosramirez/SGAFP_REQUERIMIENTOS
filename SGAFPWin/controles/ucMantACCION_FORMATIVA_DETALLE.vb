Imports SGAFP.EL
Public Class ucMantACCION_FORMATIVA_DETALLE

    Private mListaACCION_FORMATIVA_DETALLE As listaACCION_FORMATIVA_DETALLE

    Private _EsConsulta As Boolean = False
    <DefaultValue(False)> _
    Public Property EsConsulta() As Boolean
        Get
            Return Me._EsConsulta
        End Get
        Set(ByVal value As Boolean)
            Me._EsConsulta = value
            Me.UcListaACCION_FORMATIVA_DETALLE1.EsConsulta = value
            Me.UcDetalleACCION_FORMATIVA_DETALLE1.EsConsulta = value
        End Set
    End Property

    Public Overrides ReadOnly Property EnEdicion() As Boolean
        Get
            If Me.UcListaACCION_FORMATIVA_DETALLE1.Current Is Nothing Then Return False
            Return Me.UcListaACCION_FORMATIVA_DETALLE1.Current.IsDirty
        End Get
    End Property

    Private Sub CargarACCION_FORMATIVA_DETALLE()
        Me.UcListaACCION_FORMATIVA_DETALLE1.CargarDatos()
        If Me.UcListaACCION_FORMATIVA_DETALLE1.Current Is Nothing Then
            Me.UcDetalleACCION_FORMATIVA_DETALLE1.DataSource.DataSource = (New ACCION_FORMATIVA_DETALLE)
        Else
            Me.UcDetalleACCION_FORMATIVA_DETALLE1.DataSource.DataSource = Me.UcListaACCION_FORMATIVA_DETALLE1.Current
        End If
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla ACCION_FORMATIVA_DETALLE
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub CargarDatos()
        Try 
            Me.UcListaACCION_FORMATIVA_DETALLE1.CargarDatos()
        Catch ex As Exception 
            Me.AsignarMensaje("No se pudo recuperar los datos")
        End Try 
    End Sub

    Public Overrides Function Guardar() As Integer
        Me.UcDetalleACCION_FORMATIVA_DETALLE1.DataSource.EndEdit()
        Dim liRet As Integer = Me.UcListaACCION_FORMATIVA_DETALLE1.Guardar()
        If liRet <> 1 Then
            Me.sError = Me.UcListaACCION_FORMATIVA_DETALLE1.sError
        Else
            Me.sError = ""
        End If
        Return liRet
    End Function

    Private Sub UcListaACCION_FORMATIVA_DETALLE1_CambioRegistro() Handles UcListaACCION_FORMATIVA_DETALLE1.CambioRegistro
        If Not Me.UcListaACCION_FORMATIVA_DETALLE1.Current Is Nothing Then 
            Me.UcDetalleACCION_FORMATIVA_DETALLE1.DataSource.DataSource = Me.UcListaACCION_FORMATIVA_DETALLE1.Current
        End If 
    End Sub








End Class

