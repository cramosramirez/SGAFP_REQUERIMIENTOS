Imports SGAFP.EL
Public Class ucMantPARTICIPANTE

    Private mListaPARTICIPANTE As listaPARTICIPANTE

    Private _EsConsulta As Boolean = False
    <DefaultValue(False)> _
    Public Property EsConsulta() As Boolean
        Get
            Return Me._EsConsulta
        End Get
        Set(ByVal value As Boolean)
            Me._EsConsulta = value
            Me.UcListaPARTICIPANTE1.EsConsulta = value
            Me.UcDetallePARTICIPANTE1.EsConsulta = value
        End Set
    End Property

    Public Overrides ReadOnly Property EnEdicion() As Boolean
        Get
            If Me.UcListaPARTICIPANTE1.Current Is Nothing Then Return False
            Return Me.UcListaPARTICIPANTE1.Current.IsDirty
        End Get
    End Property

    Private Sub CargarPARTICIPANTE()
        Me.UcListaPARTICIPANTE1.CargarDatos()
        If Me.UcListaPARTICIPANTE1.Current Is Nothing Then
            Me.UcDetallePARTICIPANTE1.DataSource.DataSource = (New PARTICIPANTE)
        Else
            Me.UcDetallePARTICIPANTE1.DataSource.DataSource = Me.UcListaPARTICIPANTE1.Current
        End If
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla PARTICIPANTE
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/06/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub CargarDatos()
        Try 
            Me.UcListaPARTICIPANTE1.CargarDatos()
        Catch ex As Exception 
            Me.AsignarMensaje("No se pudo recuperar los datos")
        End Try 
    End Sub

    Public Overrides Function Guardar() As Integer
        Dim liRet As Integer = Me.UcListaPARTICIPANTE1.Guardar()
        If liRet <> 1 Then
            Me.sError = Me.UcListaPARTICIPANTE1.sError
        Else
            Me.sError = ""
        End If
        Return liRet
    End Function

    Private Sub UcListaPARTICIPANTE1_CambioRegistro() Handles UcListaPARTICIPANTE1.CambioRegistro
        If Not Me.UcListaPARTICIPANTE1.Current Is Nothing Then 
            Me.UcDetallePARTICIPANTE1.DataSource.DataSource = Me.UcListaPARTICIPANTE1.Current
        End If 
    End Sub






End Class

