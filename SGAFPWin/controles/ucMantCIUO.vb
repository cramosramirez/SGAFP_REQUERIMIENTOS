Imports SGAFP.EL
Public Class ucMantCIUO

    Private mListaCIUO As listaCIUO

    Private _EsConsulta As Boolean = False
    <DefaultValue(False)> _
    Public Property EsConsulta() As Boolean
        Get
            Return Me._EsConsulta
        End Get
        Set(ByVal value As Boolean)
            Me._EsConsulta = value
            Me.UcListaCIUO1.EsConsulta = value
            Me.UcDetalleCIUO1.EsConsulta = value
        End Set
    End Property

    Public Overrides ReadOnly Property EnEdicion() As Boolean
        Get
            If Me.UcListaCIUO1.Current Is Nothing Then Return False
            Return Me.UcListaCIUO1.Current.IsDirty
        End Get
    End Property

    Private Sub CargarCIUO()
        Me.UcListaCIUO1.CargarDatos()
        If Me.UcListaCIUO1.Current Is Nothing Then
            Me.UcDetalleCIUO1.DataSource.DataSource = (New CIUO)
        Else
            Me.UcDetalleCIUO1.DataSource.DataSource = Me.UcListaCIUO1.Current
        End If
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla CIUO
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub CargarDatos()
        Try 
            Me.UcListaCIUO1.CargarDatos()
        Catch ex As Exception 
            Me.AsignarMensaje("No se pudo recuperar los datos")
        End Try 
    End Sub

    Public Overrides Function Guardar() As Integer
        Dim liRet As Integer = Me.UcListaCIUO1.Guardar()
        If liRet <> 1 Then
            Me.sError = Me.UcListaCIUO1.sError
        Else
            Me.sError = ""
        End If
        Return liRet
    End Function

    Private Sub UcListaCIUO1_CambioRegistro() Handles UcListaCIUO1.CambioRegistro
        If Not Me.UcListaCIUO1.Current Is Nothing Then 
            Me.UcDetalleCIUO1.DataSource.DataSource = Me.UcListaCIUO1.Current
        End If 
    End Sub

End Class

