Imports SGAFP.EL
Public Class ucMantSIPU_TIPOCAPACITACIONES

    Private mListaSIPU_TIPOCAPACITACIONES As listaSIPU_TIPOCAPACITACIONES

    Private _EsConsulta As Boolean = False
    <DefaultValue(False)> _
    Public Property EsConsulta() As Boolean
        Get
            Return Me._EsConsulta
        End Get
        Set(ByVal value As Boolean)
            Me._EsConsulta = value
            Me.UcListaSIPU_TIPOCAPACITACIONES1.EsConsulta = value
            Me.UcDetalleSIPU_TIPOCAPACITACIONES1.EsConsulta = value
        End Set
    End Property

    Public Overrides ReadOnly Property EnEdicion() As Boolean
        Get
            If Me.UcListaSIPU_TIPOCAPACITACIONES1.Current Is Nothing Then Return False
            Return Me.UcListaSIPU_TIPOCAPACITACIONES1.Current.IsDirty
        End Get
    End Property

    Private Sub CargarSIPU_TIPOCAPACITACIONES()
        Me.UcListaSIPU_TIPOCAPACITACIONES1.CargarDatos()
        If Me.UcListaSIPU_TIPOCAPACITACIONES1.Current Is Nothing Then
            Me.UcDetalleSIPU_TIPOCAPACITACIONES1.DataSource.DataSource = (New SIPU_TIPOCAPACITACIONES)
        Else
            Me.UcDetalleSIPU_TIPOCAPACITACIONES1.DataSource.DataSource = Me.UcListaSIPU_TIPOCAPACITACIONES1.Current
        End If
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla SIPU_TIPOCAPACITACIONES
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub CargarDatos()
        Try 
            Me.UcListaSIPU_TIPOCAPACITACIONES1.CargarDatos()
        Catch ex As Exception 
            Me.AsignarMensaje("No se pudo recuperar los datos")
        End Try 
    End Sub

    Public Overrides Function Guardar() As Integer
        Me.UcDetalleSIPU_TIPOCAPACITACIONES1.DataSource.EndEdit()
        Dim liRet As Integer = Me.UcListaSIPU_TIPOCAPACITACIONES1.Guardar()
        If liRet <> 1 Then
            Me.sError = Me.UcListaSIPU_TIPOCAPACITACIONES1.sError
        Else
            Me.sError = ""
        End If
        Return liRet
    End Function

    Private Sub UcListaSIPU_TIPOCAPACITACIONES1_CambioRegistro() Handles UcListaSIPU_TIPOCAPACITACIONES1.CambioRegistro
        If Not Me.UcListaSIPU_TIPOCAPACITACIONES1.Current Is Nothing Then 
            Me.UcDetalleSIPU_TIPOCAPACITACIONES1.DataSource.DataSource = Me.UcListaSIPU_TIPOCAPACITACIONES1.Current
        End If 
    End Sub

End Class

