Imports SGAFP.EL
Public Class ucMantEJERCICIO

    Private mListaEJERCICIO As listaEJERCICIO

    Private _EsConsulta As Boolean = False
    <DefaultValue(False)> _
    Public Property EsConsulta() As Boolean
        Get
            Return Me._EsConsulta
        End Get
        Set(ByVal value As Boolean)
            Me._EsConsulta = value
            Me.UcListaEJERCICIO1.EsConsulta = value
            Me.UcDetalleEJERCICIO1.EsConsulta = value
        End Set
    End Property

    Public Overrides ReadOnly Property EnEdicion() As Boolean
        Get
            If Me.UcListaEJERCICIO1.Current Is Nothing Then Return False
            Return Me.UcListaEJERCICIO1.Current.IsDirty
        End Get
    End Property

    Private Sub CargarEJERCICIO()
        Me.UcListaEJERCICIO1.CargarDatos()
        If Me.UcListaEJERCICIO1.Current Is Nothing Then
            Me.UcDetalleEJERCICIO1.DataSource.DataSource = (New EJERCICIO)
        Else
            Me.UcDetalleEJERCICIO1.DataSource.DataSource = Me.UcListaEJERCICIO1.Current
        End If
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla EJERCICIO
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub CargarDatos()
        Try 
            Me.UcListaEJERCICIO1.CargarDatos()
        Catch ex As Exception 
            Me.AsignarMensaje("No se pudo recuperar los datos")
        End Try 
    End Sub

    Public Overrides Function Guardar() As Integer
        Dim liRet As Integer = Me.UcListaEJERCICIO1.Guardar()
        If liRet <> 1 Then
            Me.sError = Me.UcListaEJERCICIO1.sError
        Else
            Me.sError = ""
        End If
        Return liRet
    End Function

    Private Sub UcListaEJERCICIO1_CambioRegistro() Handles UcListaEJERCICIO1.CambioRegistro
        If Not Me.UcListaEJERCICIO1.Current Is Nothing Then 
            Me.UcDetalleEJERCICIO1.DataSource.DataSource = Me.UcListaEJERCICIO1.Current
        End If 
    End Sub

End Class

