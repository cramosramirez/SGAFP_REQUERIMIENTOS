Imports SGAFP.EL
Public Class ucMantPROGRAMA_FORMACION

    Private mListaPROGRAMA_FORMACION As listaPROGRAMA_FORMACION

    Private _EsConsulta As Boolean = False
    <DefaultValue(False)> _
    Public Property EsConsulta() As Boolean
        Get
            Return Me._EsConsulta
        End Get
        Set(ByVal value As Boolean)
            Me._EsConsulta = value
            Me.UcListaPROGRAMA_FORMACION1.EsConsulta = value
            Me.UcDetallePROGRAMA_FORMACION1.EsConsulta = value
        End Set
    End Property

    Public Overrides ReadOnly Property EnEdicion() As Boolean
        Get
            If Me.UcListaPROGRAMA_FORMACION1.Current Is Nothing Then Return False
            Return Me.UcListaPROGRAMA_FORMACION1.Current.IsDirty
        End Get
    End Property

    Private Sub CargarPROGRAMA_FORMACION()
        Me.UcListaPROGRAMA_FORMACION1.CargarDatos()
        If Me.UcListaPROGRAMA_FORMACION1.Current Is Nothing Then
            Me.UcDetallePROGRAMA_FORMACION1.DataSource.DataSource = (New PROGRAMA_FORMACION)
        Else
            Me.UcDetallePROGRAMA_FORMACION1.DataSource.DataSource = Me.UcListaPROGRAMA_FORMACION1.Current
        End If
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla PROGRAMA_FORMACION
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub CargarDatos()
        Try 
            Me.UcListaPROGRAMA_FORMACION1.CargarDatos()
        Catch ex As Exception 
            Me.AsignarMensaje("No se pudo recuperar los datos")
        End Try 
    End Sub

    Public Overrides Function Guardar() As Integer
        Me.UcDetallePROGRAMA_FORMACION1.DataSource.EndEdit()
        Dim liRet As Integer = Me.UcListaPROGRAMA_FORMACION1.Guardar()
        If liRet <> 1 Then
            Me.sError = Me.UcListaPROGRAMA_FORMACION1.sError
        Else
            Me.sError = ""
        End If
        Return liRet
    End Function

    Private Sub UcListaPROGRAMA_FORMACION1_CambioRegistro() Handles UcListaPROGRAMA_FORMACION1.CambioRegistro
        If Not Me.UcListaPROGRAMA_FORMACION1.Current Is Nothing Then 
            Me.UcDetallePROGRAMA_FORMACION1.DataSource.DataSource = Me.UcListaPROGRAMA_FORMACION1.Current
        End If 
    End Sub


End Class

