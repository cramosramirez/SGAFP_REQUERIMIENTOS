Imports SGAFP.EL
Public Class ucMantCATCURSO_2

    Private mListaCATCURSO_2 As listaCATCURSO_2

    Private _EsConsulta As Boolean = False
    <DefaultValue(False)> _
    Public Property EsConsulta() As Boolean
        Get
            Return Me._EsConsulta
        End Get
        Set(ByVal value As Boolean)
            Me._EsConsulta = value
            Me.UcListaCATCURSO_21.EsConsulta = value
            Me.UcDetalleCATCURSO_21.EsConsulta = value
        End Set
    End Property

    Public Overrides ReadOnly Property EnEdicion() As Boolean
        Get
            If Me.UcListaCATCURSO_21.Current Is Nothing Then Return False
            Return Me.UcListaCATCURSO_21.Current.IsDirty
        End Get
    End Property

    Private Sub CargarCATCURSO_2()
        Me.UcListaCATCURSO_21.CargarDatos()
        If Me.UcListaCATCURSO_21.Current Is Nothing Then
            Me.UcDetalleCATCURSO_21.DataSource.DataSource = (New CATCURSO_2)
        Else
            Me.UcDetalleCATCURSO_21.DataSource.DataSource = Me.UcListaCATCURSO_21.Current
        End If
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla CATCURSO_2
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub CargarDatos()
        Try 
            Me.UcListaCATCURSO_21.CargarDatos()
        Catch ex As Exception 
            Me.AsignarMensaje("No se pudo recuperar los datos")
        End Try 
    End Sub

    Public Overrides Function Guardar() As Integer
        Dim liRet As Integer = Me.UcListaCATCURSO_21.Guardar()
        If liRet <> 1 Then
            Me.sError = Me.UcListaCATCURSO_21.sError
        Else
            Me.sError = ""
        End If
        Return liRet
    End Function

    Private Sub UcListaCATCURSO_21_CambioRegistro() Handles UcListaCATCURSO_21.CambioRegistro
        If Not Me.UcListaCATCURSO_21.Current Is Nothing Then 
            Me.UcDetalleCATCURSO_21.DataSource.DataSource = Me.UcListaCATCURSO_21.Current
        End If 
    End Sub

End Class

