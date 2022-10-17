Imports SGAFP.EL
Public Class ucMantSITIO_CAPACITACION

    Private mListaSITIO_CAPACITACION As listaSITIO_CAPACITACION

    Private _EsConsulta As Boolean = False
    <DefaultValue(False)> _
    Public Property EsConsulta() As Boolean
        Get
            Return Me._EsConsulta
        End Get
        Set(ByVal value As Boolean)
            Me._EsConsulta = value
            Me.UcListaSITIO_CAPACITACION1.EsConsulta = value
            Me.UcDetalleSITIO_CAPACITACION1.EsConsulta = value
        End Set
    End Property

    Public Overrides ReadOnly Property EnEdicion() As Boolean
        Get
            If Me.UcListaSITIO_CAPACITACION1.Current Is Nothing Then Return False
            Return Me.UcListaSITIO_CAPACITACION1.Current.IsDirty
        End Get
    End Property

    Private Sub CargarSITIO_CAPACITACION()
        Me.UcListaSITIO_CAPACITACION1.CargarDatos()
        If Me.UcListaSITIO_CAPACITACION1.Current Is Nothing Then
            Me.UcDetalleSITIO_CAPACITACION1.DataSource.DataSource = (New SITIO_CAPACITACION)
        Else
            Me.UcDetalleSITIO_CAPACITACION1.DataSource.DataSource = Me.UcListaSITIO_CAPACITACION1.Current
        End If
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla SITIO_CAPACITACION
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub CargarDatos()
        Try 
            Me.UcListaSITIO_CAPACITACION1.CargarDatos()
        Catch ex As Exception 
            Me.AsignarMensaje("No se pudo recuperar los datos")
        End Try 
    End Sub

    Public Overrides Function Guardar() As Integer
        Dim liRet As Integer = Me.UcListaSITIO_CAPACITACION1.Guardar()
        If liRet <> 1 Then
            Me.sError = Me.UcListaSITIO_CAPACITACION1.sError
        Else
            Me.sError = ""
        End If
        Return liRet
    End Function

    Private Sub UcListaSITIO_CAPACITACION1_CambioRegistro() Handles UcListaSITIO_CAPACITACION1.CambioRegistro
        If Not Me.UcListaSITIO_CAPACITACION1.Current Is Nothing Then 
            Me.UcDetalleSITIO_CAPACITACION1.DataSource.DataSource = Me.UcListaSITIO_CAPACITACION1.Current
        End If 
    End Sub





End Class

