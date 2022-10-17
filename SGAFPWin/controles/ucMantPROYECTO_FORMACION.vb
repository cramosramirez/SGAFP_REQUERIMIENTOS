Imports SGAFP.EL
Public Class ucMantPROYECTO_FORMACION

    Private mListaPROYECTO_FORMACION As listaPROYECTO_FORMACION

    Private _EsConsulta As Boolean = False
    <DefaultValue(False)> _
    Public Property EsConsulta() As Boolean
        Get
            Return Me._EsConsulta
        End Get
        Set(ByVal value As Boolean)
            Me._EsConsulta = value
            Me.UcListaPROYECTO_FORMACION1.EsConsulta = value
            Me.UcDetallePROYECTO_FORMACION1.EsConsulta = value
        End Set
    End Property

    Public Overrides ReadOnly Property EnEdicion() As Boolean
        Get
            If Me.UcListaPROYECTO_FORMACION1.Current Is Nothing Then Return False
            Return Me.UcListaPROYECTO_FORMACION1.Current.IsDirty
        End Get
    End Property

    Private Sub CargarPROYECTO_FORMACION()
        Me.UcListaPROYECTO_FORMACION1.CargarDatos()
        If Me.UcListaPROYECTO_FORMACION1.Current Is Nothing Then
            Me.UcDetallePROYECTO_FORMACION1.DataSource.DataSource = (New PROYECTO_FORMACION)
        Else
            Me.UcDetallePROYECTO_FORMACION1.DataSource.DataSource = Me.UcListaPROYECTO_FORMACION1.Current
        End If
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla PROYECTO_FORMACION
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub CargarDatos()
        Try 
            Me.UcListaPROYECTO_FORMACION1.CargarDatos()
        Catch ex As Exception 
            Me.AsignarMensaje("No se pudo recuperar los datos")
        End Try 
    End Sub

    Public Overrides Function Guardar() As Integer
        Me.UcDetallePROYECTO_FORMACION1.DataSource.EndEdit()
        Dim liRet As Integer = Me.UcListaPROYECTO_FORMACION1.Guardar()
        If liRet <> 1 Then
            Me.sError = Me.UcListaPROYECTO_FORMACION1.sError
        Else
            Me.sError = ""
        End If
        Return liRet
    End Function

    Private Sub UcListaPROYECTO_FORMACION1_CambioRegistro() Handles UcListaPROYECTO_FORMACION1.CambioRegistro
        If Not Me.UcListaPROYECTO_FORMACION1.Current Is Nothing Then
            Me.UcDetallePROYECTO_FORMACION1.EsConsulta = Me.UcListaPROYECTO_FORMACION1.TieneSolicitudCapacitacion
            Me.UcDetallePROYECTO_FORMACION1.DataSource.DataSource = Me.UcListaPROYECTO_FORMACION1.Current
        End If
    End Sub

    Private Sub ucMantPROYECTO_FORMACION_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.UcListaPROYECTO_FORMACION1.PermitirEditarGrid = False
    End Sub
End Class

