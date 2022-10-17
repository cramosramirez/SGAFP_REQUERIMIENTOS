Imports SGAFP.EL
Public Class ucMantSOLIC_EMPLEO_ACTUAL

    Private mListaSOLIC_EMPLEO_ACTUAL As listaSOLIC_EMPLEO_ACTUAL

    Private _EsConsulta As Boolean = False
    <DefaultValue(False)> _
    Public Property EsConsulta() As Boolean
        Get
            Return Me._EsConsulta
        End Get
        Set(ByVal value As Boolean)
            Me._EsConsulta = value
            Me.UcListaSOLIC_EMPLEO_ACTUAL1.EsConsulta = value
            Me.UcDetalleSOLIC_EMPLEO_ACTUAL1.EsConsulta = value
        End Set
    End Property

    Public Overrides ReadOnly Property EnEdicion() As Boolean
        Get
            If Me.UcListaSOLIC_EMPLEO_ACTUAL1.Current Is Nothing Then Return False
            Return Me.UcListaSOLIC_EMPLEO_ACTUAL1.Current.IsDirty
        End Get
    End Property

    Private Sub CargarSOLIC_EMPLEO_ACTUAL()
        Me.UcListaSOLIC_EMPLEO_ACTUAL1.CargarDatos()
        If Me.UcListaSOLIC_EMPLEO_ACTUAL1.Current Is Nothing Then
            Me.UcDetalleSOLIC_EMPLEO_ACTUAL1.DataSource.DataSource = (New SOLIC_EMPLEO_ACTUAL)
        Else
            Me.UcDetalleSOLIC_EMPLEO_ACTUAL1.DataSource.DataSource = Me.UcListaSOLIC_EMPLEO_ACTUAL1.Current
        End If
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla SOLIC_EMPLEO_ACTUAL
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub CargarDatos()
        Try 
            Me.UcListaSOLIC_EMPLEO_ACTUAL1.CargarDatos()
        Catch ex As Exception 
            Me.AsignarMensaje("No se pudo recuperar los datos")
        End Try 
    End Sub

    Public Overrides Function Guardar() As Integer
        Dim liRet As Integer = Me.UcListaSOLIC_EMPLEO_ACTUAL1.Guardar()
        If liRet <> 1 Then
            Me.sError = Me.UcListaSOLIC_EMPLEO_ACTUAL1.sError
        Else
            Me.sError = ""
        End If
        Return liRet
    End Function

    Private Sub UcListaSOLIC_EMPLEO_ACTUAL1_CambioRegistro() Handles UcListaSOLIC_EMPLEO_ACTUAL1.CambioRegistro
        If Not Me.UcListaSOLIC_EMPLEO_ACTUAL1.Current Is Nothing Then 
            Me.UcDetalleSOLIC_EMPLEO_ACTUAL1.DataSource.DataSource = Me.UcListaSOLIC_EMPLEO_ACTUAL1.Current
        End If 
    End Sub






End Class

