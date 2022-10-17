Imports SGAFP.EL
Public Class ucMantTERMINO_REFERENCIA_AF

    Private mListaTERMINO_REFERENCIA_AF As listaTERMINO_REFERENCIA_AF

    Private _EsConsulta As Boolean = False
    <DefaultValue(False)> _
    Public Property EsConsulta() As Boolean
        Get
            Return Me._EsConsulta
        End Get
        Set(ByVal value As Boolean)
            Me._EsConsulta = value
            Me.UcListaTERMINO_REFERENCIA_AF1.EsConsulta = value
            Me.UcDetalleTERMINO_REFERENCIA_AF1.EsConsulta = value
        End Set
    End Property

    Public Overrides ReadOnly Property EnEdicion() As Boolean
        Get
            If Me.UcListaTERMINO_REFERENCIA_AF1.Current Is Nothing Then Return False
            Return Me.UcListaTERMINO_REFERENCIA_AF1.Current.IsDirty
        End Get
    End Property

    Private Sub CargarTERMINO_REFERENCIA_AF()
        Me.UcListaTERMINO_REFERENCIA_AF1.CargarDatos()
        If Me.UcListaTERMINO_REFERENCIA_AF1.Current Is Nothing Then
            Me.UcDetalleTERMINO_REFERENCIA_AF1.DataSource.DataSource = (New TERMINO_REFERENCIA_AF)
        Else
            Me.UcDetalleTERMINO_REFERENCIA_AF1.DataSource.DataSource = Me.UcListaTERMINO_REFERENCIA_AF1.Current
        End If
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla TERMINO_REFERENCIA_AF
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub CargarDatos()
        Try 
            Me.UcListaTERMINO_REFERENCIA_AF1.CargarDatos()
        Catch ex As Exception 
            Me.AsignarMensaje("No se pudo recuperar los datos")
        End Try 
    End Sub

    Public Overrides Function Guardar() As Integer
        Me.UcDetalleTERMINO_REFERENCIA_AF1.DataSource.EndEdit()
        Dim liRet As Integer = Me.UcListaTERMINO_REFERENCIA_AF1.Guardar()
        If liRet <> 1 Then
            Me.sError = Me.UcListaTERMINO_REFERENCIA_AF1.sError
        Else
            Me.sError = ""
        End If
        Return liRet
    End Function

    Private Sub UcListaTERMINO_REFERENCIA_AF1_CambioRegistro() Handles UcListaTERMINO_REFERENCIA_AF1.CambioRegistro
        If Not Me.UcListaTERMINO_REFERENCIA_AF1.Current Is Nothing Then 
            Me.UcDetalleTERMINO_REFERENCIA_AF1.DataSource.DataSource = Me.UcListaTERMINO_REFERENCIA_AF1.Current
        End If 
    End Sub



End Class

