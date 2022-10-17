Imports SGAFP.EL
Public Class ucMantOPCION_MENU

    Private mListaOPCION_MENU As listaOPCION_MENU

    Private _EsConsulta As Boolean = False
    <DefaultValue(False)> _
    Public Property EsConsulta() As Boolean
        Get
            Return Me._EsConsulta
        End Get
        Set(ByVal value As Boolean)
            Me._EsConsulta = value
            Me.UcListaOPCION_MENU1.EsConsulta = value
            Me.UcDetalleOPCION_MENU1.EsConsulta = value
        End Set
    End Property

    Public Overrides ReadOnly Property EnEdicion() As Boolean
        Get
            If Me.UcListaOPCION_MENU1.Current Is Nothing Then Return False
            Return Me.UcListaOPCION_MENU1.Current.IsDirty
        End Get
    End Property

    Private Sub CargarOPCION_MENU()
        Me.UcListaOPCION_MENU1.CargarDatos()
        If Me.UcListaOPCION_MENU1.Current Is Nothing Then
            Me.UcDetalleOPCION_MENU1.DataSource.DataSource = (New OPCION_MENU)
        Else
            Me.UcDetalleOPCION_MENU1.DataSource.DataSource = Me.UcListaOPCION_MENU1.Current
        End If
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla OPCION_MENU
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub CargarDatos()
        Try 
            Me.UcListaOPCION_MENU1.CargarDatos()
        Catch ex As Exception 
            Me.AsignarMensaje("No se pudo recuperar los datos")
        End Try 
    End Sub

    Public Overrides Function Guardar() As Integer
        Dim liRet As Integer = Me.UcListaOPCION_MENU1.Guardar()
        If liRet <> 1 Then
            Me.sError = Me.UcListaOPCION_MENU1.sError
        Else
            Me.sError = ""
        End If
        Return liRet
    End Function

    Private Sub UcListaOPCION_MENU1_CambioRegistro() Handles UcListaOPCION_MENU1.CambioRegistro
        If Not Me.UcListaOPCION_MENU1.Current Is Nothing Then 
            Me.UcDetalleOPCION_MENU1.DataSource.DataSource = Me.UcListaOPCION_MENU1.Current
        End If 
    End Sub

End Class

