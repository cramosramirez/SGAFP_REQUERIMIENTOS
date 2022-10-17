Imports SGAFP.EL
Public Class ucMantGRUPO_SOLICITUD

    Private mListaGRUPO_SOLICITUD As listaGRUPO_SOLICITUD

    Private _EsConsulta As Boolean = False
    <DefaultValue(False)> _
    Public Property EsConsulta() As Boolean
        Get
            Return Me._EsConsulta
        End Get
        Set(ByVal value As Boolean)
            Me._EsConsulta = value
            Me.UcListaGRUPO_SOLICITUD1.EsConsulta = value
            Me.UcDetalleGRUPO_SOLICITUD1.EsConsulta = value
        End Set
    End Property

    Public Overrides ReadOnly Property EnEdicion() As Boolean
        Get
            If Me.UcListaGRUPO_SOLICITUD1.Current Is Nothing Then Return False
            Return Me.UcListaGRUPO_SOLICITUD1.Current.IsDirty
        End Get
    End Property

    Private Sub CargarGRUPO_SOLICITUD()
        Me.UcListaGRUPO_SOLICITUD1.CargarDatos()
        If Me.UcListaGRUPO_SOLICITUD1.Current Is Nothing Then
            Me.UcDetalleGRUPO_SOLICITUD1.DataSource.DataSource = (New GRUPO_SOLICITUD)
        Else
            Me.UcDetalleGRUPO_SOLICITUD1.DataSource.DataSource = Me.UcListaGRUPO_SOLICITUD1.Current
        End If
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla GRUPO_SOLICITUD
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub CargarDatos()
        Try 
            Me.UcListaGRUPO_SOLICITUD1.CargarDatos()
        Catch ex As Exception 
            Me.AsignarMensaje("No se pudo recuperar los datos")
        End Try 
    End Sub

    Public Overrides Function Guardar() As Integer
        Me.UcDetalleGRUPO_SOLICITUD1.DataSource.EndEdit()
        Dim liRet As Integer = Me.UcListaGRUPO_SOLICITUD1.Guardar()
        If liRet <> 1 Then
            Me.sError = Me.UcListaGRUPO_SOLICITUD1.sError
        Else
            Me.sError = ""
        End If
        Return liRet
    End Function

    Private Sub UcListaGRUPO_SOLICITUD1_CambioRegistro() Handles UcListaGRUPO_SOLICITUD1.CambioRegistro
        If Not Me.UcListaGRUPO_SOLICITUD1.Current Is Nothing Then 
            Me.UcDetalleGRUPO_SOLICITUD1.DataSource.DataSource = Me.UcListaGRUPO_SOLICITUD1.Current
        End If 
    End Sub



End Class

