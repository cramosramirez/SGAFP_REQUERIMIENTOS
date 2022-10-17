Imports SGAFP.EL
Public Class ucMantPROCESO

    Private mListaPROCESO As listaPROCESO

    Private _EsConsulta As Boolean = False
    <DefaultValue(False)> _
    Public Property EsConsulta() As Boolean
        Get
            Return Me._EsConsulta
        End Get
        Set(ByVal value As Boolean)
            Me._EsConsulta = value
            Me.UcListaPROCESO1.EsConsulta = value
            Me.UcDetallePROCESO1.EsConsulta = value
        End Set
    End Property

    Public Overrides ReadOnly Property EnEdicion() As Boolean
        Get
            If Me.UcListaPROCESO1.Current Is Nothing Then Return False
            Return Me.UcListaPROCESO1.Current.IsDirty
        End Get
    End Property

    Private Sub CargarPROCESO()
        Me.UcListaPROCESO1.CargarDatos()
        If Me.UcListaPROCESO1.Current Is Nothing Then
            Me.UcDetallePROCESO1.DataSource.DataSource = (New PROCESO)
        Else
            Me.UcDetallePROCESO1.DataSource.DataSource = Me.UcListaPROCESO1.Current
        End If
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla PROCESO
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub CargarDatos()
        Try 
            Me.UcListaPROCESO1.CargarDatos()
        Catch ex As Exception 
            Me.AsignarMensaje("No se pudo recuperar los datos")
        End Try 
    End Sub

    Public Overrides Function Guardar() As Integer
        Dim liRet As Integer = Me.UcListaPROCESO1.Guardar()
        If liRet <> 1 Then
            Me.sError = Me.UcListaPROCESO1.sError
        Else
            Me.sError = ""
        End If
        Return liRet
    End Function

    Private Sub UcListaPROCESO1_CambioRegistro() Handles UcListaPROCESO1.CambioRegistro
        If Not Me.UcListaPROCESO1.Current Is Nothing Then 
            Me.UcDetallePROCESO1.DataSource.DataSource = Me.UcListaPROCESO1.Current
        End If 
    End Sub

End Class

