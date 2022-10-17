Imports SGAFP.EL
Public Class ucMantSOLICITUD_INSCRIPCION_AF

    Private mListaSOLICITUD_INSCRIPCION_AF As listaSOLICITUD_INSCRIPCION_AF

    Private _EsConsulta As Boolean = False
    <DefaultValue(False)> _
    Public Property EsConsulta() As Boolean
        Get
            Return Me._EsConsulta
        End Get
        Set(ByVal value As Boolean)
            Me._EsConsulta = value
            Me.UcListaSOLICITUD_INSCRIPCION_AF1.EsConsulta = value
            Me.UcDetalleSOLICITUD_INSCRIPCION_AF1.EsConsulta = value
        End Set
    End Property

    Public Overrides ReadOnly Property EnEdicion() As Boolean
        Get
            If Me.UcListaSOLICITUD_INSCRIPCION_AF1.Current Is Nothing Then Return False
            Return Me.UcListaSOLICITUD_INSCRIPCION_AF1.Current.IsDirty
        End Get
    End Property

    Private Sub CargarSOLICITUD_INSCRIPCION_AF()
        Me.UcListaSOLICITUD_INSCRIPCION_AF1.CargarDatos()
        If Me.UcListaSOLICITUD_INSCRIPCION_AF1.Current Is Nothing Then
            Me.UcDetalleSOLICITUD_INSCRIPCION_AF1.DataSource.DataSource = (New SOLICITUD_INSCRIPCION_AF)
        Else
            Me.UcDetalleSOLICITUD_INSCRIPCION_AF1.DataSource.DataSource = Me.UcListaSOLICITUD_INSCRIPCION_AF1.Current
        End If
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla SOLICITUD_INSCRIPCION_AF
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub CargarDatos()
        Try 
            Me.UcListaSOLICITUD_INSCRIPCION_AF1.CargarDatos()
        Catch ex As Exception 
            Me.AsignarMensaje("No se pudo recuperar los datos")
        End Try 
    End Sub

    Public Overrides Function Guardar() As Integer
        Dim liRet As Integer = Me.UcListaSOLICITUD_INSCRIPCION_AF1.Guardar()
        If liRet <> 1 Then
            Me.sError = Me.UcListaSOLICITUD_INSCRIPCION_AF1.sError
        Else
            Me.sError = ""
        End If
        Return liRet
    End Function

    Private Sub UcListaSOLICITUD_INSCRIPCION_AF1_CambioRegistro() Handles UcListaSOLICITUD_INSCRIPCION_AF1.CambioRegistro
        If Not Me.UcListaSOLICITUD_INSCRIPCION_AF1.Current Is Nothing Then 
            Me.UcDetalleSOLICITUD_INSCRIPCION_AF1.DataSource.DataSource = Me.UcListaSOLICITUD_INSCRIPCION_AF1.Current
        End If 
    End Sub













End Class

