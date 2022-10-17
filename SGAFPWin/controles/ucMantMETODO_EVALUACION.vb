Imports SGAFP.EL
Public Class ucMantMETODO_EVALUACION

    Private mListaMETODO_EVALUACION As listaMETODO_EVALUACION

    Private _EsConsulta As Boolean = False
    <DefaultValue(False)> _
    Public Property EsConsulta() As Boolean
        Get
            Return Me._EsConsulta
        End Get
        Set(ByVal value As Boolean)
            Me._EsConsulta = value
            Me.UcListaMETODO_EVALUACION1.EsConsulta = value
            Me.UcDetalleMETODO_EVALUACION1.EsConsulta = value
        End Set
    End Property

    Public Overrides ReadOnly Property EnEdicion() As Boolean
        Get
            If Me.UcListaMETODO_EVALUACION1.Current Is Nothing Then Return False
            Return Me.UcListaMETODO_EVALUACION1.Current.IsDirty
        End Get
    End Property

    Private Sub CargarMETODO_EVALUACION()
        Me.UcListaMETODO_EVALUACION1.CargarDatos()
        If Me.UcListaMETODO_EVALUACION1.Current Is Nothing Then
            Me.UcDetalleMETODO_EVALUACION1.DataSource.DataSource = (New METODO_EVALUACION)
        Else
            Me.UcDetalleMETODO_EVALUACION1.DataSource.DataSource = Me.UcListaMETODO_EVALUACION1.Current
        End If
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla METODO_EVALUACION
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub CargarDatos()
        Try 
            Me.UcListaMETODO_EVALUACION1.CargarDatos()
        Catch ex As Exception 
            Me.AsignarMensaje("No se pudo recuperar los datos")
        End Try 
    End Sub

    Public Overrides Function Guardar() As Integer
        Dim liRet As Integer = Me.UcListaMETODO_EVALUACION1.Guardar()
        If liRet <> 1 Then
            Me.sError = Me.UcListaMETODO_EVALUACION1.sError
        Else
            Me.sError = ""
        End If
        Return liRet
    End Function

    Private Sub UcListaMETODO_EVALUACION1_CambioRegistro() Handles UcListaMETODO_EVALUACION1.CambioRegistro
        If Not Me.UcListaMETODO_EVALUACION1.Current Is Nothing Then 
            Me.UcDetalleMETODO_EVALUACION1.DataSource.DataSource = Me.UcListaMETODO_EVALUACION1.Current
        End If 
    End Sub

End Class

