Imports SGAFP.EL
Public Class ucMantREFERENTE

    Private mListaREFERENTE As listaREFERENTE

    Private _EsConsulta As Boolean = False
    <DefaultValue(False)> _
    Public Property EsConsulta() As Boolean
        Get
            Return Me._EsConsulta
        End Get
        Set(ByVal value As Boolean)
            Me._EsConsulta = value
            Me.UcListaREFERENTE1.EsConsulta = value
            Me.UcDetalleREFERENTE1.EsConsulta = value
        End Set
    End Property

    Public Overrides ReadOnly Property EnEdicion() As Boolean
        Get
            If Me.UcListaREFERENTE1.Current Is Nothing Then Return False
            Return Me.UcListaREFERENTE1.Current.IsDirty
        End Get
    End Property

    Private Sub CargarREFERENTE()
        Me.UcListaREFERENTE1.CargarDatos()
        If Me.UcListaREFERENTE1.Current Is Nothing Then
            Me.UcDetalleREFERENTE1.DataSource.DataSource = (New REFERENTE)
        Else
            Me.UcDetalleREFERENTE1.DataSource.DataSource = Me.UcListaREFERENTE1.Current
        End If
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla REFERENTE
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub CargarDatos()
        Try 
            Me.UcListaREFERENTE1.CargarDatos()
        Catch ex As Exception 
            Me.AsignarMensaje("No se pudo recuperar los datos")
        End Try 
    End Sub

    Public Overrides Function Guardar() As Integer
        Me.UcDetalleREFERENTE1.DataSource.EndEdit()
        Dim liRet As Integer = Me.UcListaREFERENTE1.Guardar()
        If liRet <> 1 Then
            Me.sError = Me.UcListaREFERENTE1.sError
        Else
            Me.sError = ""
        End If
        Return liRet
    End Function

    Private Sub UcListaREFERENTE1_CambioRegistro() Handles UcListaREFERENTE1.CambioRegistro
        If Not Me.UcListaREFERENTE1.Current Is Nothing Then
            Me.UcDetalleREFERENTE1.EsConsulta = Me.UcListaREFERENTE1.TieneSolicitudCapacitacion
            Me.UcDetalleREFERENTE1.DataSource.DataSource = Me.UcListaREFERENTE1.Current
        End If
    End Sub

    Private Sub ucMantREFERENTE_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.UcListaREFERENTE1.PermitirEditarGrid = False
    End Sub
End Class

