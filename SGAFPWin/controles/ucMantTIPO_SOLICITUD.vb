Imports SGAFP.EL
Public Class ucMantTIPO_SOLICITUD

    Private mListaTIPO_SOLICITUD As listaTIPO_SOLICITUD

    Private _EsConsulta As Boolean = False
    <DefaultValue(False)> _
    Public Property EsConsulta() As Boolean
        Get
            Return Me._EsConsulta
        End Get
        Set(ByVal value As Boolean)
            Me._EsConsulta = value
            Me.UcListaTIPO_SOLICITUD1.EsConsulta = value
            Me.UcDetalleTIPO_SOLICITUD1.EsConsulta = value
        End Set
    End Property

    Public Overrides ReadOnly Property EnEdicion() As Boolean
        Get
            If Me.UcListaTIPO_SOLICITUD1.Current Is Nothing Then Return False
            Return Me.UcListaTIPO_SOLICITUD1.Current.IsDirty
        End Get
    End Property

    Private Sub CargarTIPO_SOLICITUD()
        Me.UcListaTIPO_SOLICITUD1.CargarDatos()
        If Me.UcListaTIPO_SOLICITUD1.Current Is Nothing Then
            Me.UcDetalleTIPO_SOLICITUD1.DataSource.DataSource = (New TIPO_SOLICITUD)
        Else
            Me.UcDetalleTIPO_SOLICITUD1.DataSource.DataSource = Me.UcListaTIPO_SOLICITUD1.Current
        End If
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla TIPO_SOLICITUD
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub CargarDatos()
        Try 
            Me.UcListaTIPO_SOLICITUD1.CargarDatos()
        Catch ex As Exception 
            Me.AsignarMensaje("No se pudo recuperar los datos")
        End Try 
    End Sub

    Public Overrides Function Guardar() As Integer
        Dim liRet As Integer = Me.UcListaTIPO_SOLICITUD1.Guardar()
        If liRet <> 1 Then
            Me.sError = Me.UcListaTIPO_SOLICITUD1.sError
        Else
            Me.sError = ""
        End If
        Return liRet
    End Function

    Private Sub UcListaTIPO_SOLICITUD1_CambioRegistro() Handles UcListaTIPO_SOLICITUD1.CambioRegistro
        If Not Me.UcListaTIPO_SOLICITUD1.Current Is Nothing Then 
            Me.UcDetalleTIPO_SOLICITUD1.DataSource.DataSource = Me.UcListaTIPO_SOLICITUD1.Current
        End If 
    End Sub


End Class

