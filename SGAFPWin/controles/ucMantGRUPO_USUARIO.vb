Imports SGAFP.EL
Public Class ucMantGRUPO_USUARIO

    Private mListaGRUPO_USUARIO As listaGRUPO_USUARIO

    Private _EsConsulta As Boolean = False
    <DefaultValue(False)> _
    Public Property EsConsulta() As Boolean
        Get
            Return Me._EsConsulta
        End Get
        Set(ByVal value As Boolean)
            Me._EsConsulta = value
            Me.UcListaGRUPO_USUARIO1.EsConsulta = value
            Me.UcDetalleGRUPO_USUARIO1.EsConsulta = value
        End Set
    End Property

    Public Overrides ReadOnly Property EnEdicion() As Boolean
        Get
            If Me.UcListaGRUPO_USUARIO1.Current Is Nothing Then Return False
            Return Me.UcListaGRUPO_USUARIO1.Current.IsDirty
        End Get
    End Property

    Private Sub CargarGRUPO_USUARIO()
        Me.UcListaGRUPO_USUARIO1.CargarDatos()
        If Me.UcListaGRUPO_USUARIO1.Current Is Nothing Then
            Me.UcDetalleGRUPO_USUARIO1.DataSource.DataSource = (New GRUPO_USUARIO)
        Else
            Me.UcDetalleGRUPO_USUARIO1.DataSource.DataSource = Me.UcListaGRUPO_USUARIO1.Current
        End If
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla GRUPO_USUARIO
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub CargarDatos()
        Try 
            Me.UcListaGRUPO_USUARIO1.CargarDatos()
        Catch ex As Exception 
            Me.AsignarMensaje("No se pudo recuperar los datos")
        End Try 
    End Sub

    Public Overrides Function Guardar() As Integer
        Dim liRet As Integer = Me.UcListaGRUPO_USUARIO1.Guardar()
        If liRet <> 1 Then
            Me.sError = Me.UcListaGRUPO_USUARIO1.sError
        Else
            Me.sError = ""
        End If
        Return liRet
    End Function

    Private Sub UcListaGRUPO_USUARIO1_CambioRegistro() Handles UcListaGRUPO_USUARIO1.CambioRegistro
        If Not Me.UcListaGRUPO_USUARIO1.Current Is Nothing Then 
            Me.UcDetalleGRUPO_USUARIO1.DataSource.DataSource = Me.UcListaGRUPO_USUARIO1.Current
        End If 
    End Sub

End Class

