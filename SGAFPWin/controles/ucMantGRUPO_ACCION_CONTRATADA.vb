Imports SGAFP.EL
Public Class ucMantGRUPO_ACCION_CONTRATADA

    Private mListaGRUPO_ACCION_CONTRATADA As listaGRUPO_ACCION_CONTRATADA

    Private _EsConsulta As Boolean = False
    <DefaultValue(False)> _
    Public Property EsConsulta() As Boolean
        Get
            Return Me._EsConsulta
        End Get
        Set(ByVal value As Boolean)
            Me._EsConsulta = value
            Me.UcListaGRUPO_ACCION_CONTRATADA1.EsConsulta = value
            Me.UcDetalleGRUPO_ACCION_CONTRATADA1.EsConsulta = value
        End Set
    End Property

    Public Overrides ReadOnly Property EnEdicion() As Boolean
        Get
            If Me.UcListaGRUPO_ACCION_CONTRATADA1.Current Is Nothing Then Return False
            Return Me.UcListaGRUPO_ACCION_CONTRATADA1.Current.IsDirty
        End Get
    End Property

    Private Sub CargarGRUPO_ACCION_CONTRATADA()
        Me.UcListaGRUPO_ACCION_CONTRATADA1.CargarDatos()
        If Me.UcListaGRUPO_ACCION_CONTRATADA1.Current Is Nothing Then
            Me.UcDetalleGRUPO_ACCION_CONTRATADA1.DataSource.DataSource = (New GRUPO_ACCION_CONTRATADA)
        Else
            Me.UcDetalleGRUPO_ACCION_CONTRATADA1.DataSource.DataSource = Me.UcListaGRUPO_ACCION_CONTRATADA1.Current
        End If
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla GRUPO_ACCION_CONTRATADA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	12/04/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub CargarDatos()
        Try 
            Me.UcListaGRUPO_ACCION_CONTRATADA1.CargarDatos()
        Catch ex As Exception 
            Me.AsignarMensaje("No se pudo recuperar los datos")
        End Try 
    End Sub

    Public Overrides Function Guardar() As Integer
        Me.UcDetalleGRUPO_ACCION_CONTRATADA1.DataSource.EndEdit()
        Dim liRet As Integer = Me.UcListaGRUPO_ACCION_CONTRATADA1.Guardar()
        If liRet <> 1 Then
            Me.sError = Me.UcListaGRUPO_ACCION_CONTRATADA1.sError
        Else
            Me.sError = ""
        End If
        Return liRet
    End Function

    Private Sub UcListaGRUPO_ACCION_CONTRATADA1_CambioRegistro() Handles UcListaGRUPO_ACCION_CONTRATADA1.CambioRegistro
        If Not Me.UcListaGRUPO_ACCION_CONTRATADA1.Current Is Nothing Then 
            Me.UcDetalleGRUPO_ACCION_CONTRATADA1.DataSource.DataSource = Me.UcListaGRUPO_ACCION_CONTRATADA1.Current
        End If 
    End Sub



End Class

