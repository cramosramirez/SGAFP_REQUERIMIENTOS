Imports SGAFP.EL
Public Class ucMantOPCION_GRUPO

    Private mListaOPCION_GRUPO As listaOPCION_GRUPO

    Private _EsConsulta As Boolean = False
    <DefaultValue(False)> _
    Public Property EsConsulta() As Boolean
        Get
            Return Me._EsConsulta
        End Get
        Set(ByVal value As Boolean)
            Me._EsConsulta = value
            Me.UcListaOPCION_GRUPO1.EsConsulta = value
            Me.UcDetalleOPCION_GRUPO1.EsConsulta = value
        End Set
    End Property

    Public Overrides ReadOnly Property EnEdicion() As Boolean
        Get
            If Me.UcListaOPCION_GRUPO1.Current Is Nothing Then Return False
            Return Me.UcListaOPCION_GRUPO1.Current.IsDirty
        End Get
    End Property

    Private Sub CargarOPCION_GRUPO()
        Me.UcListaOPCION_GRUPO1.CargarDatos()
        If Me.UcListaOPCION_GRUPO1.Current Is Nothing Then
            Me.UcDetalleOPCION_GRUPO1.DataSource.DataSource = (New OPCION_GRUPO)
        Else
            Me.UcDetalleOPCION_GRUPO1.DataSource.DataSource = Me.UcListaOPCION_GRUPO1.Current
        End If
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla OPCION_GRUPO
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub CargarDatos()
        Try 
            Me.UcListaOPCION_GRUPO1.CargarDatos()
        Catch ex As Exception 
            Me.AsignarMensaje("No se pudo recuperar los datos")
        End Try 
    End Sub

    Public Overrides Function Guardar() As Integer
        Dim liRet As Integer = Me.UcListaOPCION_GRUPO1.Guardar()
        If liRet <> 1 Then
            Me.sError = Me.UcListaOPCION_GRUPO1.sError
        Else
            Me.sError = ""
        End If
        Return liRet
    End Function

    Private Sub UcListaOPCION_GRUPO1_CambioRegistro() Handles UcListaOPCION_GRUPO1.CambioRegistro
        If Not Me.UcListaOPCION_GRUPO1.Current Is Nothing Then 
            Me.UcDetalleOPCION_GRUPO1.DataSource.DataSource = Me.UcListaOPCION_GRUPO1.Current
        End If 
    End Sub



End Class

