Imports SGAFP.EL
Public Class ucMantCURSO_TEMA

    Private mListaCURSO_TEMA As listaCURSO_TEMA

    Private _EsConsulta As Boolean = False
    <DefaultValue(False)> _
    Public Property EsConsulta() As Boolean
        Get
            Return Me._EsConsulta
        End Get
        Set(ByVal value As Boolean)
            Me._EsConsulta = value
            Me.UcListaCURSO_TEMA1.EsConsulta = value
            Me.UcDetalleCURSO_TEMA1.EsConsulta = value
        End Set
    End Property

    Public Overrides ReadOnly Property EnEdicion() As Boolean
        Get
            If Me.UcListaCURSO_TEMA1.Current Is Nothing Then Return False
            Return Me.UcListaCURSO_TEMA1.Current.IsDirty
        End Get
    End Property

    Private Sub CargarCURSO_TEMA()
        Me.UcListaCURSO_TEMA1.CargarDatos()
        If Me.UcListaCURSO_TEMA1.Current Is Nothing Then
            Me.UcDetalleCURSO_TEMA1.DataSource.DataSource = (New CURSO_TEMA)
        Else
            Me.UcDetalleCURSO_TEMA1.DataSource.DataSource = Me.UcListaCURSO_TEMA1.Current
        End If
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla CURSO_TEMA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub CargarDatos()
        Try 
            Me.UcListaCURSO_TEMA1.CargarDatos()
        Catch ex As Exception 
            Me.AsignarMensaje("No se pudo recuperar los datos")
        End Try 
    End Sub

    Public Overrides Function Guardar() As Integer
        Dim liRet As Integer = Me.UcListaCURSO_TEMA1.Guardar()
        If liRet <> 1 Then
            Me.sError = Me.UcListaCURSO_TEMA1.sError
        Else
            Me.sError = ""
        End If
        Return liRet
    End Function

    Private Sub UcListaCURSO_TEMA1_CambioRegistro() Handles UcListaCURSO_TEMA1.CambioRegistro
        If Not Me.UcListaCURSO_TEMA1.Current Is Nothing Then 
            Me.UcDetalleCURSO_TEMA1.DataSource.DataSource = Me.UcListaCURSO_TEMA1.Current
        End If 
    End Sub


End Class

