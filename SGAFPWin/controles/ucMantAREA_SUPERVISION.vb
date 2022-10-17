Imports SGAFP.EL
Public Class ucMantAREA_SUPERVISION

    Private mListaAREA_SUPERVISION As listaAREA_SUPERVISION

    Private _EsConsulta As Boolean = False
    <DefaultValue(False)> _
    Public Property EsConsulta() As Boolean
        Get
            Return Me._EsConsulta
        End Get
        Set(ByVal value As Boolean)
            Me._EsConsulta = value
            Me.UcListaAREA_SUPERVISION1.EsConsulta = value
            Me.UcDetalleAREA_SUPERVISION1.EsConsulta = value
        End Set
    End Property

    Public Overrides ReadOnly Property EnEdicion() As Boolean
        Get
            If Me.UcListaAREA_SUPERVISION1.Current Is Nothing Then Return False
            Return Me.UcListaAREA_SUPERVISION1.Current.IsDirty
        End Get
    End Property

    Private Sub CargarAREA_SUPERVISION()
        Me.UcListaAREA_SUPERVISION1.CargarDatos()
        If Me.UcListaAREA_SUPERVISION1.Current Is Nothing Then
            Me.UcDetalleAREA_SUPERVISION1.DataSource.DataSource = (New AREA_SUPERVISION)
        Else
            Me.UcDetalleAREA_SUPERVISION1.DataSource.DataSource = Me.UcListaAREA_SUPERVISION1.Current
        End If
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla AREA_SUPERVISION
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub CargarDatos()
        Try 
            Me.UcListaAREA_SUPERVISION1.CargarDatos()
        Catch ex As Exception 
            Me.AsignarMensaje("No se pudo recuperar los datos")
        End Try 
    End Sub

    Public Overrides Function Guardar() As Integer
        Dim liRet As Integer = Me.UcListaAREA_SUPERVISION1.Guardar()
        If liRet <> 1 Then
            Me.sError = Me.UcListaAREA_SUPERVISION1.sError
        Else
            Me.sError = ""
        End If
        Return liRet
    End Function

    Private Sub UcListaAREA_SUPERVISION1_CambioRegistro() Handles UcListaAREA_SUPERVISION1.CambioRegistro
        If Not Me.UcListaAREA_SUPERVISION1.Current Is Nothing Then 
            Me.UcDetalleAREA_SUPERVISION1.DataSource.DataSource = Me.UcListaAREA_SUPERVISION1.Current
        End If 
    End Sub

End Class

