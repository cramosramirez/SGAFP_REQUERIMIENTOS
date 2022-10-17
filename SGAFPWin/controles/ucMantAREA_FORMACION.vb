Imports SGAFP.EL
Public Class ucMantAREA_FORMACION

    Private mListaAREA_FORMACION As listaAREA_FORMACION

    Private _EsConsulta As Boolean = False
    <DefaultValue(False)> _
    Public Property EsConsulta() As Boolean
        Get
            Return Me._EsConsulta
        End Get
        Set(ByVal value As Boolean)
            Me._EsConsulta = value
            Me.UcListaAREA_FORMACION1.EsConsulta = value
            Me.UcDetalleAREA_FORMACION1.EsConsulta = value
        End Set
    End Property

    Public Overrides ReadOnly Property EnEdicion() As Boolean
        Get
            If Me.UcListaAREA_FORMACION1.Current Is Nothing Then Return False
            Return Me.UcListaAREA_FORMACION1.Current.IsDirty
        End Get
    End Property

    Private Sub CargarAREA_FORMACION()
        Me.UcListaAREA_FORMACION1.CargarDatos()
        If Me.UcListaAREA_FORMACION1.Current Is Nothing Then
            Me.UcDetalleAREA_FORMACION1.DataSource.DataSource = (New AREA_FORMACION)
        Else
            Me.UcDetalleAREA_FORMACION1.DataSource.DataSource = Me.UcListaAREA_FORMACION1.Current
        End If
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla AREA_FORMACION
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub CargarDatos()
        Try 
            Me.UcListaAREA_FORMACION1.CargarDatos()
        Catch ex As Exception 
            Me.AsignarMensaje("No se pudo recuperar los datos")
        End Try 
    End Sub

    Public Overrides Function Guardar() As Integer
        Dim liRet As Integer = Me.UcListaAREA_FORMACION1.Guardar()
        If liRet <> 1 Then
            Me.sError = Me.UcListaAREA_FORMACION1.sError
        Else
            Me.sError = ""
        End If
        Return liRet
    End Function

    Private Sub UcListaAREA_FORMACION1_CambioRegistro() Handles UcListaAREA_FORMACION1.CambioRegistro
        If Not Me.UcListaAREA_FORMACION1.Current Is Nothing Then 
            Me.UcDetalleAREA_FORMACION1.DataSource.DataSource = Me.UcListaAREA_FORMACION1.Current
        End If 
    End Sub

End Class

