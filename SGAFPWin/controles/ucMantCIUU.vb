Imports SGAFP.EL
Public Class ucMantCIUU

    Private mListaCIUU As listaCIUU

    Private _EsConsulta As Boolean = False
    <DefaultValue(False)> _
    Public Property EsConsulta() As Boolean
        Get
            Return Me._EsConsulta
        End Get
        Set(ByVal value As Boolean)
            Me._EsConsulta = value
            Me.UcListaCIUU1.EsConsulta = value
            Me.UcDetalleCIUU1.EsConsulta = value
        End Set
    End Property

    Public Overrides ReadOnly Property EnEdicion() As Boolean
        Get
            If Me.UcListaCIUU1.Current Is Nothing Then Return False
            Return Me.UcListaCIUU1.Current.IsDirty
        End Get
    End Property

    Private Sub CargarCIUU()
        Me.UcListaCIUU1.CargarDatos()
        If Me.UcListaCIUU1.Current Is Nothing Then
            Me.UcDetalleCIUU1.DataSource.DataSource = (New CIUU)
        Else
            Me.UcDetalleCIUU1.DataSource.DataSource = Me.UcListaCIUU1.Current
        End If
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla CIUU
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub CargarDatos()
        Try 
            Me.UcListaCIUU1.CargarDatos()
        Catch ex As Exception 
            Me.AsignarMensaje("No se pudo recuperar los datos")
        End Try 
    End Sub

    Public Overrides Function Guardar() As Integer
        Dim liRet As Integer = Me.UcListaCIUU1.Guardar()
        If liRet <> 1 Then
            Me.sError = Me.UcListaCIUU1.sError
        Else
            Me.sError = ""
        End If
        Return liRet
    End Function

    Private Sub UcListaCIUU1_CambioRegistro() Handles UcListaCIUU1.CambioRegistro
        If Not Me.UcListaCIUU1.Current Is Nothing Then 
            Me.UcDetalleCIUU1.DataSource.DataSource = Me.UcListaCIUU1.Current
        End If 
    End Sub

End Class

