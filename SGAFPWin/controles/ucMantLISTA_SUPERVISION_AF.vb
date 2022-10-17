Imports SGAFP.EL
Public Class ucMantLISTA_SUPERVISION_AF

    Private mListaLISTA_SUPERVISION_AF As listaLISTA_SUPERVISION_AF

    Private _EsConsulta As Boolean = False
    <DefaultValue(False)> _
    Public Property EsConsulta() As Boolean
        Get
            Return Me._EsConsulta
        End Get
        Set(ByVal value As Boolean)
            Me._EsConsulta = value
            Me.UcListaLISTA_SUPERVISION_AF1.EsConsulta = value
            Me.UcDetalleLISTA_SUPERVISION_AF1.EsConsulta = value
        End Set
    End Property

    Public Overrides ReadOnly Property EnEdicion() As Boolean
        Get
            If Me.UcListaLISTA_SUPERVISION_AF1.Current Is Nothing Then Return False
            Return Me.UcListaLISTA_SUPERVISION_AF1.Current.IsDirty
        End Get
    End Property

    Private Sub CargarLISTA_SUPERVISION_AF()
        Me.UcListaLISTA_SUPERVISION_AF1.CargarDatos()
        If Me.UcListaLISTA_SUPERVISION_AF1.Current Is Nothing Then
            Me.UcDetalleLISTA_SUPERVISION_AF1.DataSource.DataSource = (New LISTA_SUPERVISION_AF)
        Else
            Me.UcDetalleLISTA_SUPERVISION_AF1.DataSource.DataSource = Me.UcListaLISTA_SUPERVISION_AF1.Current
        End If
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla LISTA_SUPERVISION_AF
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub CargarDatos()
        Try 
            Me.UcListaLISTA_SUPERVISION_AF1.CargarDatos()
        Catch ex As Exception 
            Me.AsignarMensaje("No se pudo recuperar los datos")
        End Try 
    End Sub

    Public Overrides Function Guardar() As Integer
        Dim liRet As Integer = Me.UcListaLISTA_SUPERVISION_AF1.Guardar()
        If liRet <> 1 Then
            Me.sError = Me.UcListaLISTA_SUPERVISION_AF1.sError
        Else
            Me.sError = ""
        End If
        Return liRet
    End Function

    Private Sub UcListaLISTA_SUPERVISION_AF1_CambioRegistro() Handles UcListaLISTA_SUPERVISION_AF1.CambioRegistro
        If Not Me.UcListaLISTA_SUPERVISION_AF1.Current Is Nothing Then 
            Me.UcDetalleLISTA_SUPERVISION_AF1.DataSource.DataSource = Me.UcListaLISTA_SUPERVISION_AF1.Current
        End If 
    End Sub

End Class

