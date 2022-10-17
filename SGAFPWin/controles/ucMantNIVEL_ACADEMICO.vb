Imports SGAFP.EL
Public Class ucMantNIVEL_ACADEMICO

    Private mListaNIVEL_ACADEMICO As listaNIVEL_ACADEMICO

    Private _EsConsulta As Boolean = False
    <DefaultValue(False)> _
    Public Property EsConsulta() As Boolean
        Get
            Return Me._EsConsulta
        End Get
        Set(ByVal value As Boolean)
            Me._EsConsulta = value
            Me.UcListaNIVEL_ACADEMICO1.EsConsulta = value
            Me.UcDetalleNIVEL_ACADEMICO1.EsConsulta = value
        End Set
    End Property

    Public Overrides ReadOnly Property EnEdicion() As Boolean
        Get
            If Me.UcListaNIVEL_ACADEMICO1.Current Is Nothing Then Return False
            Return Me.UcListaNIVEL_ACADEMICO1.Current.IsDirty
        End Get
    End Property

    Private Sub CargarNIVEL_ACADEMICO()
        Me.UcListaNIVEL_ACADEMICO1.CargarDatos()
        If Me.UcListaNIVEL_ACADEMICO1.Current Is Nothing Then
            Me.UcDetalleNIVEL_ACADEMICO1.DataSource.DataSource = (New NIVEL_ACADEMICO)
        Else
            Me.UcDetalleNIVEL_ACADEMICO1.DataSource.DataSource = Me.UcListaNIVEL_ACADEMICO1.Current
        End If
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla NIVEL_ACADEMICO
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub CargarDatos()
        Try 
            Me.UcListaNIVEL_ACADEMICO1.CargarDatos()
        Catch ex As Exception 
            Me.AsignarMensaje("No se pudo recuperar los datos")
        End Try 
    End Sub

    Public Overrides Function Guardar() As Integer
        Dim liRet As Integer = Me.UcListaNIVEL_ACADEMICO1.Guardar()
        If liRet <> 1 Then
            Me.sError = Me.UcListaNIVEL_ACADEMICO1.sError
        Else
            Me.sError = ""
        End If
        Return liRet
    End Function

    Private Sub UcListaNIVEL_ACADEMICO1_CambioRegistro() Handles UcListaNIVEL_ACADEMICO1.CambioRegistro
        If Not Me.UcListaNIVEL_ACADEMICO1.Current Is Nothing Then 
            Me.UcDetalleNIVEL_ACADEMICO1.DataSource.DataSource = Me.UcListaNIVEL_ACADEMICO1.Current
        End If 
    End Sub

End Class

