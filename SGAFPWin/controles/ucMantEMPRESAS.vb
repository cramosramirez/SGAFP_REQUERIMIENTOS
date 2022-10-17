Imports SGAFP.EL
Public Class ucMantEMPRESAS

    Private mListaEMPRESAS As listaEMPRESAS

    Private _EsConsulta As Boolean = False
    <DefaultValue(False)> _
    Public Property EsConsulta() As Boolean
        Get
            Return Me._EsConsulta
        End Get
        Set(ByVal value As Boolean)
            Me._EsConsulta = value
            Me.UcListaEMPRESAS1.EsConsulta = value
            Me.UcDetalleEMPRESAS1.EsConsulta = value
        End Set
    End Property

    Public Overrides ReadOnly Property EnEdicion() As Boolean
        Get
            If Me.UcListaEMPRESAS1.Current Is Nothing Then Return False
            Return Me.UcListaEMPRESAS1.Current.IsDirty
        End Get
    End Property

    Private Sub CargarEMPRESAS()
        Me.UcListaEMPRESAS1.CargarDatos()
        If Me.UcListaEMPRESAS1.Current Is Nothing Then
            Me.UcDetalleEMPRESAS1.DataSource.DataSource = (New EMPRESAS)
        Else
            Me.UcDetalleEMPRESAS1.DataSource.DataSource = Me.UcListaEMPRESAS1.Current
        End If
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla EMPRESAS
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub CargarDatos()
        Try 
            Me.UcListaEMPRESAS1.CargarDatos()
        Catch ex As Exception 
            Me.AsignarMensaje("No se pudo recuperar los datos")
        End Try 
    End Sub

    Public Overrides Function Guardar() As Integer
        Dim liRet As Integer = Me.UcListaEMPRESAS1.Guardar()
        If liRet <> 1 Then
            Me.sError = Me.UcListaEMPRESAS1.sError
        Else
            Me.sError = ""
        End If
        Return liRet
    End Function

    Private Sub UcListaEMPRESAS1_CambioRegistro() Handles UcListaEMPRESAS1.CambioRegistro
        If Not Me.UcListaEMPRESAS1.Current Is Nothing Then 
            Me.UcDetalleEMPRESAS1.DataSource.DataSource = Me.UcListaEMPRESAS1.Current
        End If 
    End Sub

End Class

