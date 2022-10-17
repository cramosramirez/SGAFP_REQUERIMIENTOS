Imports SGAFP.EL
Public Class ucMantSOLIC_CURSOS_RECIBIDOS

    Private mListaSOLIC_CURSOS_RECIBIDOS As listaSOLIC_CURSOS_RECIBIDOS

    Private _EsConsulta As Boolean = False
    <DefaultValue(False)> _
    Public Property EsConsulta() As Boolean
        Get
            Return Me._EsConsulta
        End Get
        Set(ByVal value As Boolean)
            Me._EsConsulta = value
            Me.UcListaSOLIC_CURSOS_RECIBIDOS1.EsConsulta = value
            Me.UcDetalleSOLIC_CURSOS_RECIBIDOS1.EsConsulta = value
        End Set
    End Property

    Public Overrides ReadOnly Property EnEdicion() As Boolean
        Get
            If Me.UcListaSOLIC_CURSOS_RECIBIDOS1.Current Is Nothing Then Return False
            Return Me.UcListaSOLIC_CURSOS_RECIBIDOS1.Current.IsDirty
        End Get
    End Property

    Private Sub CargarSOLIC_CURSOS_RECIBIDOS()
        Me.UcListaSOLIC_CURSOS_RECIBIDOS1.CargarDatos()
        If Me.UcListaSOLIC_CURSOS_RECIBIDOS1.Current Is Nothing Then
            Me.UcDetalleSOLIC_CURSOS_RECIBIDOS1.DataSource.DataSource = (New SOLIC_CURSOS_RECIBIDOS)
        Else
            Me.UcDetalleSOLIC_CURSOS_RECIBIDOS1.DataSource.DataSource = Me.UcListaSOLIC_CURSOS_RECIBIDOS1.Current
        End If
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla SOLIC_CURSOS_RECIBIDOS
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub CargarDatos()
        Try 
            Me.UcListaSOLIC_CURSOS_RECIBIDOS1.CargarDatos()
        Catch ex As Exception 
            Me.AsignarMensaje("No se pudo recuperar los datos")
        End Try 
    End Sub

    Public Overrides Function Guardar() As Integer
        Dim liRet As Integer = Me.UcListaSOLIC_CURSOS_RECIBIDOS1.Guardar()
        If liRet <> 1 Then
            Me.sError = Me.UcListaSOLIC_CURSOS_RECIBIDOS1.sError
        Else
            Me.sError = ""
        End If
        Return liRet
    End Function

    Private Sub UcListaSOLIC_CURSOS_RECIBIDOS1_CambioRegistro() Handles UcListaSOLIC_CURSOS_RECIBIDOS1.CambioRegistro
        If Not Me.UcListaSOLIC_CURSOS_RECIBIDOS1.Current Is Nothing Then 
            Me.UcDetalleSOLIC_CURSOS_RECIBIDOS1.DataSource.DataSource = Me.UcListaSOLIC_CURSOS_RECIBIDOS1.Current
        End If 
    End Sub


End Class

