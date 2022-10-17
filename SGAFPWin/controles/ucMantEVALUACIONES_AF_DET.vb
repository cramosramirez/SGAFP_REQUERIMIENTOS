Imports SGAFP.EL
Public Class ucMantEVALUACIONES_AF_DET

    Private mListaEVALUACIONES_AF_DET As listaEVALUACIONES_AF_DET

    Private _EsConsulta As Boolean = False
    <DefaultValue(False)> _
    Public Property EsConsulta() As Boolean
        Get
            Return Me._EsConsulta
        End Get
        Set(ByVal value As Boolean)
            Me._EsConsulta = value
            Me.UcListaEVALUACIONES_AF_DET1.EsConsulta = value
            Me.UcDetalleEVALUACIONES_AF_DET1.EsConsulta = value
        End Set
    End Property

    Public Overrides ReadOnly Property EnEdicion() As Boolean
        Get
            If Me.UcListaEVALUACIONES_AF_DET1.Current Is Nothing Then Return False
            Return Me.UcListaEVALUACIONES_AF_DET1.Current.IsDirty
        End Get
    End Property

    Private Sub CargarEVALUACIONES_AF_DET()
        Me.UcListaEVALUACIONES_AF_DET1.CargarDatos()
        If Me.UcListaEVALUACIONES_AF_DET1.Current Is Nothing Then
            Me.UcDetalleEVALUACIONES_AF_DET1.DataSource.DataSource = (New EVALUACIONES_AF_DET)
        Else
            Me.UcDetalleEVALUACIONES_AF_DET1.DataSource.DataSource = Me.UcListaEVALUACIONES_AF_DET1.Current
        End If
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla EVALUACIONES_AF_DET
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub CargarDatos()
        Try 
            Me.UcListaEVALUACIONES_AF_DET1.CargarDatos()
        Catch ex As Exception 
            Me.AsignarMensaje("No se pudo recuperar los datos")
        End Try 
    End Sub

    Public Overrides Function Guardar() As Integer
        Dim liRet As Integer = Me.UcListaEVALUACIONES_AF_DET1.Guardar()
        If liRet <> 1 Then
            Me.sError = Me.UcListaEVALUACIONES_AF_DET1.sError
        Else
            Me.sError = ""
        End If
        Return liRet
    End Function

    Private Sub UcListaEVALUACIONES_AF_DET1_CambioRegistro() Handles UcListaEVALUACIONES_AF_DET1.CambioRegistro
        If Not Me.UcListaEVALUACIONES_AF_DET1.Current Is Nothing Then 
            Me.UcDetalleEVALUACIONES_AF_DET1.DataSource.DataSource = Me.UcListaEVALUACIONES_AF_DET1.Current
        End If 
    End Sub



End Class

