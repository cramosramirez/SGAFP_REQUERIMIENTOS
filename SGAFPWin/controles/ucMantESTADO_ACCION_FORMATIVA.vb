Imports SGAFP.EL
Public Class ucMantESTADO_ACCION_FORMATIVA

    Private mListaESTADO_ACCION_FORMATIVA As listaESTADO_ACCION_FORMATIVA

    Private _EsConsulta As Boolean = False
    <DefaultValue(False)> _
    Public Property EsConsulta() As Boolean
        Get
            Return Me._EsConsulta
        End Get
        Set(ByVal value As Boolean)
            Me._EsConsulta = value
            Me.UcListaESTADO_ACCION_FORMATIVA1.EsConsulta = value
            Me.UcDetalleESTADO_ACCION_FORMATIVA1.EsConsulta = value
        End Set
    End Property

    Public Overrides ReadOnly Property EnEdicion() As Boolean
        Get
            If Me.UcListaESTADO_ACCION_FORMATIVA1.Current Is Nothing Then Return False
            Return Me.UcListaESTADO_ACCION_FORMATIVA1.Current.IsDirty
        End Get
    End Property

    Private Sub CargarESTADO_ACCION_FORMATIVA()
        Me.UcListaESTADO_ACCION_FORMATIVA1.CargarDatos()
        If Me.UcListaESTADO_ACCION_FORMATIVA1.Current Is Nothing Then
            Me.UcDetalleESTADO_ACCION_FORMATIVA1.DataSource.DataSource = (New ESTADO_ACCION_FORMATIVA)
        Else
            Me.UcDetalleESTADO_ACCION_FORMATIVA1.DataSource.DataSource = Me.UcListaESTADO_ACCION_FORMATIVA1.Current
        End If
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla ESTADO_ACCION_FORMATIVA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub CargarDatos()
        Try 
            Me.UcListaESTADO_ACCION_FORMATIVA1.CargarDatos()
        Catch ex As Exception 
            Me.AsignarMensaje("No se pudo recuperar los datos")
        End Try 
    End Sub

    Public Overrides Function Guardar() As Integer
        Dim liRet As Integer = Me.UcListaESTADO_ACCION_FORMATIVA1.Guardar()
        If liRet <> 1 Then
            Me.sError = Me.UcListaESTADO_ACCION_FORMATIVA1.sError
        Else
            Me.sError = ""
        End If
        Return liRet
    End Function

    Private Sub UcListaESTADO_ACCION_FORMATIVA1_CambioRegistro() Handles UcListaESTADO_ACCION_FORMATIVA1.CambioRegistro
        If Not Me.UcListaESTADO_ACCION_FORMATIVA1.Current Is Nothing Then 
            Me.UcDetalleESTADO_ACCION_FORMATIVA1.DataSource.DataSource = Me.UcListaESTADO_ACCION_FORMATIVA1.Current
        End If 
    End Sub

End Class

