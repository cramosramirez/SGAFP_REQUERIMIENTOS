Imports SGAFP.EL
Public Class ucMantTIPO_CONTRATACION

    Private mListaTIPO_CONTRATACION As listaTIPO_CONTRATACION

    Private _EsConsulta As Boolean = False
    <DefaultValue(False)> _
    Public Property EsConsulta() As Boolean
        Get
            Return Me._EsConsulta
        End Get
        Set(ByVal value As Boolean)
            Me._EsConsulta = value
            Me.UcListaTIPO_CONTRATACION1.EsConsulta = value
            Me.UcDetalleTIPO_CONTRATACION1.EsConsulta = value
        End Set
    End Property

    Public Overrides ReadOnly Property EnEdicion() As Boolean
        Get
            If Me.UcListaTIPO_CONTRATACION1.Current Is Nothing Then Return False
            Return Me.UcListaTIPO_CONTRATACION1.Current.IsDirty
        End Get
    End Property

    Private Sub CargarTIPO_CONTRATACION()
        Me.UcListaTIPO_CONTRATACION1.CargarDatos()
        If Me.UcListaTIPO_CONTRATACION1.Current Is Nothing Then
            Me.UcDetalleTIPO_CONTRATACION1.DataSource.DataSource = (New TIPO_CONTRATACION)
        Else
            Me.UcDetalleTIPO_CONTRATACION1.DataSource.DataSource = Me.UcListaTIPO_CONTRATACION1.Current
        End If
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla TIPO_CONTRATACION
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	11/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub CargarDatos()
        Try 
            Me.UcListaTIPO_CONTRATACION1.CargarDatos()
        Catch ex As Exception 
            Me.AsignarMensaje("No se pudo recuperar los datos")
        End Try 
    End Sub

    Public Overrides Function Guardar() As Integer
        Me.UcDetalleTIPO_CONTRATACION1.DataSource.EndEdit()
        Dim liRet As Integer = Me.UcListaTIPO_CONTRATACION1.Guardar()
        If liRet <> 1 Then
            Me.sError = Me.UcListaTIPO_CONTRATACION1.sError
        Else
            Me.sError = ""
        End If
        Return liRet
    End Function

    Private Sub UcListaTIPO_CONTRATACION1_CambioRegistro() Handles UcListaTIPO_CONTRATACION1.CambioRegistro
        If Not Me.UcListaTIPO_CONTRATACION1.Current Is Nothing Then 
            Me.UcDetalleTIPO_CONTRATACION1.DataSource.DataSource = Me.UcListaTIPO_CONTRATACION1.Current
        End If 
    End Sub

End Class

