Imports SGAFP.EL
Public Class ucMantUSUARIO

    Private mListaUSUARIO As listaUSUARIO

    Private _EsConsulta As Boolean = False
    <DefaultValue(False)> _
    Public Property EsConsulta() As Boolean
        Get
            Return Me._EsConsulta
        End Get
        Set(ByVal value As Boolean)
            Me._EsConsulta = value
            Me.UcListaUSUARIO1.EsConsulta = value
            Me.UcDetalleUSUARIO1.EsConsulta = value
        End Set
    End Property

    Public Overrides ReadOnly Property EnEdicion() As Boolean
        Get
            If Me.UcListaUSUARIO1.Current Is Nothing Then Return False
            Return Me.UcListaUSUARIO1.Current.IsDirty
        End Get
    End Property

    Private Sub CargarUSUARIO()
        Me.UcListaUSUARIO1.CargarDatos()
        If Me.UcListaUSUARIO1.Current Is Nothing Then
            Me.UcDetalleUSUARIO1.DataSource.DataSource = (New USUARIO)
        Else
            Me.UcDetalleUSUARIO1.DataSource.DataSource = Me.UcListaUSUARIO1.Current
        End If
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla USUARIO
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub CargarDatos()
        Try 
            Me.UcListaUSUARIO1.CargarDatos()
        Catch ex As Exception 
            Me.AsignarMensaje("No se pudo recuperar los datos")
        End Try 
    End Sub

    Public Overrides Function Guardar() As Integer
        Dim liRet As Integer = Me.UcListaUSUARIO1.Guardar()
        If liRet <> 1 Then
            Me.sError = Me.UcListaUSUARIO1.sError
        Else
            Me.sError = ""
        End If
        Return liRet
    End Function

    Private Sub UcListaUSUARIO1_CambioRegistro() Handles UcListaUSUARIO1.CambioRegistro
        If Not Me.UcListaUSUARIO1.Current Is Nothing Then 
            Me.UcDetalleUSUARIO1.DataSource.DataSource = Me.UcListaUSUARIO1.Current
        End If 
    End Sub




End Class

