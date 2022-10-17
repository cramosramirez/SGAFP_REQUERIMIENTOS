Imports SGAFP.EL
Public Class ucMantOFERTA_FORMATIVA

    Private mListaOFERTA_FORMATIVA As listaOFERTA_FORMATIVA

    Private _EsConsulta As Boolean = False
    <DefaultValue(False)> _
    Public Property EsConsulta() As Boolean
        Get
            Return Me._EsConsulta
        End Get
        Set(ByVal value As Boolean)
            Me._EsConsulta = value
            Me.UcListaOFERTA_FORMATIVA1.EsConsulta = value
            Me.UcDetalleOFERTA_FORMATIVA1.EsConsulta = value
        End Set
    End Property

    Public Overrides ReadOnly Property EnEdicion() As Boolean
        Get
            If Me.UcListaOFERTA_FORMATIVA1.Current Is Nothing Then Return False
            Return Me.UcListaOFERTA_FORMATIVA1.Current.IsDirty
        End Get
    End Property

    Private Sub CargarOFERTA_FORMATIVA()
        Me.UcListaOFERTA_FORMATIVA1.CargarDatos()
        If Me.UcListaOFERTA_FORMATIVA1.Current Is Nothing Then
            Me.UcDetalleOFERTA_FORMATIVA1.DataSource.DataSource = (New OFERTA_FORMATIVA)
        Else
            Me.UcDetalleOFERTA_FORMATIVA1.DataSource.DataSource = Me.UcListaOFERTA_FORMATIVA1.Current
        End If
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla OFERTA_FORMATIVA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub CargarDatos()
        Try 
            Me.UcListaOFERTA_FORMATIVA1.CargarDatos()
        Catch ex As Exception 
            Me.AsignarMensaje("No se pudo recuperar los datos")
        End Try 
    End Sub

    Public Overrides Function Guardar() As Integer
        Dim liRet As Integer = Me.UcListaOFERTA_FORMATIVA1.Guardar()
        If liRet <> 1 Then
            Me.sError = Me.UcListaOFERTA_FORMATIVA1.sError
        Else
            Me.sError = ""
        End If
        Return liRet
    End Function

    Private Sub UcListaOFERTA_FORMATIVA1_CambioRegistro() Handles UcListaOFERTA_FORMATIVA1.CambioRegistro
        If Not Me.UcListaOFERTA_FORMATIVA1.Current Is Nothing Then 
            Me.UcDetalleOFERTA_FORMATIVA1.DataSource.DataSource = Me.UcListaOFERTA_FORMATIVA1.Current
        End If 
    End Sub




End Class

