Imports SGAFP.EL
Public Class ucMantASISTENCIA_AF_DET

    Private mListaASISTENCIA_AF_DET As listaASISTENCIA_AF_DET

    Private _EsConsulta As Boolean = False
    <DefaultValue(False)> _
    Public Property EsConsulta() As Boolean
        Get
            Return Me._EsConsulta
        End Get
        Set(ByVal value As Boolean)
            Me._EsConsulta = value
            Me.UcListaASISTENCIA_AF_DET1.EsConsulta = value
            Me.UcDetalleASISTENCIA_AF_DET1.EsConsulta = value
        End Set
    End Property

    Public Overrides ReadOnly Property EnEdicion() As Boolean
        Get
            If Me.UcListaASISTENCIA_AF_DET1.Current Is Nothing Then Return False
            Return Me.UcListaASISTENCIA_AF_DET1.Current.IsDirty
        End Get
    End Property

    Private Sub CargarASISTENCIA_AF_DET()
        Me.UcListaASISTENCIA_AF_DET1.CargarDatos()
        If Me.UcListaASISTENCIA_AF_DET1.Current Is Nothing Then
            Me.UcDetalleASISTENCIA_AF_DET1.DataSource.DataSource = (New ASISTENCIA_AF_DET)
        Else
            Me.UcDetalleASISTENCIA_AF_DET1.DataSource.DataSource = Me.UcListaASISTENCIA_AF_DET1.Current
        End If
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla ASISTENCIA_AF_DET
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub CargarDatos()
        Try 
            Me.UcListaASISTENCIA_AF_DET1.CargarDatos()
        Catch ex As Exception 
            Me.AsignarMensaje("No se pudo recuperar los datos")
        End Try 
    End Sub

    Public Overrides Function Guardar() As Integer
        Dim liRet As Integer = Me.UcListaASISTENCIA_AF_DET1.Guardar()
        If liRet <> 1 Then
            Me.sError = Me.UcListaASISTENCIA_AF_DET1.sError
        Else
            Me.sError = ""
        End If
        Return liRet
    End Function

    Private Sub UcListaASISTENCIA_AF_DET1_CambioRegistro() Handles UcListaASISTENCIA_AF_DET1.CambioRegistro
        If Not Me.UcListaASISTENCIA_AF_DET1.Current Is Nothing Then 
            Me.UcDetalleASISTENCIA_AF_DET1.DataSource.DataSource = Me.UcListaASISTENCIA_AF_DET1.Current
        End If 
    End Sub



End Class

