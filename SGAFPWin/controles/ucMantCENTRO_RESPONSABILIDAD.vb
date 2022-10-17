Imports SGAFP.EL
Public Class ucMantCENTRO_RESPONSABILIDAD

    Private mListaCENTRO_RESPONSABILIDAD As listaCENTRO_RESPONSABILIDAD

    Private _EsConsulta As Boolean = False
    <DefaultValue(False)> _
    Public Property EsConsulta() As Boolean
        Get
            Return Me._EsConsulta
        End Get
        Set(ByVal value As Boolean)
            Me._EsConsulta = value
            Me.UcListaCENTRO_RESPONSABILIDAD1.EsConsulta = value
            Me.UcDetalleCENTRO_RESPONSABILIDAD1.EsConsulta = value
        End Set
    End Property

    Public Overrides ReadOnly Property EnEdicion() As Boolean
        Get
            If Me.UcListaCENTRO_RESPONSABILIDAD1.Current Is Nothing Then Return False
            Return Me.UcListaCENTRO_RESPONSABILIDAD1.Current.IsDirty
        End Get
    End Property

    Private Sub CargarCENTRO_RESPONSABILIDAD()
        Me.UcListaCENTRO_RESPONSABILIDAD1.CargarDatos()
        If Me.UcListaCENTRO_RESPONSABILIDAD1.Current Is Nothing Then
            Me.UcDetalleCENTRO_RESPONSABILIDAD1.DataSource.DataSource = (New CENTRO_RESPONSABILIDAD)
        Else
            Me.UcDetalleCENTRO_RESPONSABILIDAD1.DataSource.DataSource = Me.UcListaCENTRO_RESPONSABILIDAD1.Current
        End If
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla CENTRO_RESPONSABILIDAD
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub CargarDatos()
        Try 
            Me.UcListaCENTRO_RESPONSABILIDAD1.CargarDatos()
        Catch ex As Exception 
            Me.AsignarMensaje("No se pudo recuperar los datos")
        End Try 
    End Sub

    Public Overrides Function Guardar() As Integer
        Me.UcDetalleCENTRO_RESPONSABILIDAD1.DataSource.EndEdit()
        Dim liRet As Integer = Me.UcListaCENTRO_RESPONSABILIDAD1.Guardar()
        If liRet <> 1 Then
            Me.sError = Me.UcListaCENTRO_RESPONSABILIDAD1.sError
        Else
            Me.sError = ""
        End If
        Return liRet
    End Function

    Private Sub UcListaCENTRO_RESPONSABILIDAD1_CambioRegistro() Handles UcListaCENTRO_RESPONSABILIDAD1.CambioRegistro
        If Not Me.UcListaCENTRO_RESPONSABILIDAD1.Current Is Nothing Then 
            Me.UcDetalleCENTRO_RESPONSABILIDAD1.DataSource.DataSource = Me.UcListaCENTRO_RESPONSABILIDAD1.Current
        End If 
    End Sub


End Class

