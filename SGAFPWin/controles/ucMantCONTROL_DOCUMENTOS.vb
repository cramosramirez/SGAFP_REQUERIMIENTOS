Imports SGAFP.EL
Public Class ucMantCONTROL_DOCUMENTOS

    Private mListaCONTROL_DOCUMENTOS As listaCONTROL_DOCUMENTOS

    Private _EsConsulta As Boolean = False
    <DefaultValue(False)> _
    Public Property EsConsulta() As Boolean
        Get
            Return Me._EsConsulta
        End Get
        Set(ByVal value As Boolean)
            Me._EsConsulta = value
            Me.UcListaCONTROL_DOCUMENTOS1.EsConsulta = value
            Me.UcDetalleCONTROL_DOCUMENTOS1.EsConsulta = value
        End Set
    End Property

    Public Overrides ReadOnly Property EnEdicion() As Boolean
        Get
            If Me.UcListaCONTROL_DOCUMENTOS1.Current Is Nothing Then Return False
            Return Me.UcListaCONTROL_DOCUMENTOS1.Current.IsDirty
        End Get
    End Property

    Private Sub CargarCONTROL_DOCUMENTOS()
        Me.UcListaCONTROL_DOCUMENTOS1.CargarDatos()
        If Me.UcListaCONTROL_DOCUMENTOS1.Current Is Nothing Then
            Me.UcDetalleCONTROL_DOCUMENTOS1.DataSource.DataSource = (New CONTROL_DOCUMENTOS)
        Else
            Me.UcDetalleCONTROL_DOCUMENTOS1.DataSource.DataSource = Me.UcListaCONTROL_DOCUMENTOS1.Current
        End If
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla CONTROL_DOCUMENTOS
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub CargarDatos()
        Try 
            Me.UcListaCONTROL_DOCUMENTOS1.CargarDatos()
        Catch ex As Exception 
            Me.AsignarMensaje("No se pudo recuperar los datos")
        End Try 
    End Sub

    Public Overrides Function Guardar() As Integer
        Dim liRet As Integer = Me.UcListaCONTROL_DOCUMENTOS1.Guardar()
        If liRet <> 1 Then
            Me.sError = Me.UcListaCONTROL_DOCUMENTOS1.sError
        Else
            Me.sError = ""
        End If
        Return liRet
    End Function

    Private Sub UcListaCONTROL_DOCUMENTOS1_CambioRegistro() Handles UcListaCONTROL_DOCUMENTOS1.CambioRegistro
        If Not Me.UcListaCONTROL_DOCUMENTOS1.Current Is Nothing Then 
            Me.UcDetalleCONTROL_DOCUMENTOS1.DataSource.DataSource = Me.UcListaCONTROL_DOCUMENTOS1.Current
        End If 
    End Sub





End Class

