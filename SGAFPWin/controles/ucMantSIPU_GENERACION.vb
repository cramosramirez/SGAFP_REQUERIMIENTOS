Imports SGAFP.EL
Public Class ucMantSIPU_GENERACION

    Private mListaSIPU_GENERACION As listaSIPU_GENERACION

    Private _EsConsulta As Boolean = False
    <DefaultValue(False)> _
    Public Property EsConsulta() As Boolean
        Get
            Return Me._EsConsulta
        End Get
        Set(ByVal value As Boolean)
            Me._EsConsulta = value
            Me.UcListaSIPU_GENERACION1.EsConsulta = value
            Me.UcDetalleSIPU_GENERACION1.EsConsulta = value
        End Set
    End Property

    Public Overrides ReadOnly Property EnEdicion() As Boolean
        Get
            If Me.UcListaSIPU_GENERACION1.Current Is Nothing Then Return False
            Return Me.UcListaSIPU_GENERACION1.Current.IsDirty
        End Get
    End Property

    Private Sub CargarSIPU_GENERACION()
        Me.UcListaSIPU_GENERACION1.CargarDatos()
        If Me.UcListaSIPU_GENERACION1.Current Is Nothing Then
            Me.UcDetalleSIPU_GENERACION1.DataSource.DataSource = (New SIPU_GENERACION)
        Else
            Me.UcDetalleSIPU_GENERACION1.DataSource.DataSource = Me.UcListaSIPU_GENERACION1.Current
        End If
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla SIPU_GENERACION
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub CargarDatos()
        Try 
            Me.UcListaSIPU_GENERACION1.CargarDatos()
        Catch ex As Exception 
            Me.AsignarMensaje("No se pudo recuperar los datos")
        End Try 
    End Sub

    Public Overrides Function Guardar() As Integer
        Me.UcDetalleSIPU_GENERACION1.DataSource.EndEdit()
        Dim liRet As Integer = Me.UcListaSIPU_GENERACION1.Guardar()
        If liRet <> 1 Then
            Me.sError = Me.UcListaSIPU_GENERACION1.sError
        Else
            Me.sError = ""
        End If
        Return liRet
    End Function

    Private Sub UcListaSIPU_GENERACION1_CambioRegistro() Handles UcListaSIPU_GENERACION1.CambioRegistro
        If Not Me.UcListaSIPU_GENERACION1.Current Is Nothing Then 
            Me.UcDetalleSIPU_GENERACION1.DataSource.DataSource = Me.UcListaSIPU_GENERACION1.Current
        End If 
    End Sub

End Class

