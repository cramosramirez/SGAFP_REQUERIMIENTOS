Imports SGAFP.EL
Public Class ucMantTIPO_PERSONA

    Private mListaTIPO_PERSONA As listaTIPO_PERSONA

    Private _EsConsulta As Boolean = False
    <DefaultValue(False)> _
    Public Property EsConsulta() As Boolean
        Get
            Return Me._EsConsulta
        End Get
        Set(ByVal value As Boolean)
            Me._EsConsulta = value
            Me.UcListaTIPO_PERSONA1.EsConsulta = value
            Me.UcDetalleTIPO_PERSONA1.EsConsulta = value
        End Set
    End Property

    Public Overrides ReadOnly Property EnEdicion() As Boolean
        Get
            If Me.UcListaTIPO_PERSONA1.Current Is Nothing Then Return False
            Return Me.UcListaTIPO_PERSONA1.Current.IsDirty
        End Get
    End Property

    Private Sub CargarTIPO_PERSONA()
        Me.UcListaTIPO_PERSONA1.CargarDatos()
        If Me.UcListaTIPO_PERSONA1.Current Is Nothing Then
            Me.UcDetalleTIPO_PERSONA1.DataSource.DataSource = (New TIPO_PERSONA)
        Else
            Me.UcDetalleTIPO_PERSONA1.DataSource.DataSource = Me.UcListaTIPO_PERSONA1.Current
        End If
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla TIPO_PERSONA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub CargarDatos()
        Try 
            Me.UcListaTIPO_PERSONA1.CargarDatos()
        Catch ex As Exception 
            Me.AsignarMensaje("No se pudo recuperar los datos")
        End Try 
    End Sub

    Public Overrides Function Guardar() As Integer
        Dim liRet As Integer = Me.UcListaTIPO_PERSONA1.Guardar()
        If liRet <> 1 Then
            Me.sError = Me.UcListaTIPO_PERSONA1.sError
        Else
            Me.sError = ""
        End If
        Return liRet
    End Function

    Private Sub UcListaTIPO_PERSONA1_CambioRegistro() Handles UcListaTIPO_PERSONA1.CambioRegistro
        If Not Me.UcListaTIPO_PERSONA1.Current Is Nothing Then 
            Me.UcDetalleTIPO_PERSONA1.DataSource.DataSource = Me.UcListaTIPO_PERSONA1.Current
        End If 
    End Sub

End Class

