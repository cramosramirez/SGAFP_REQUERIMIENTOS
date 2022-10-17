Imports SGAFP.EL
Public Class ucMantPARTICIPANTE_EXONERADO_DOC

    Private mListaPARTICIPANTE_EXONERADO_DOC As listaPARTICIPANTE

    Private _EsConsulta As Boolean = False
    <DefaultValue(False)> _
    Public Property EsConsulta() As Boolean
        Get
            Return Me._EsConsulta
        End Get
        Set(ByVal value As Boolean)
            Me._EsConsulta = value
            Me.UcListaPARTICIPANTE1.EsConsulta = value
        End Set
    End Property

    Public Overrides ReadOnly Property EnEdicion() As Boolean
        Get
            If Me.UcListaPARTICIPANTE1.Current Is Nothing Then Return False
            Return Me.UcListaPARTICIPANTE1.Current.IsDirty
        End Get
    End Property

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros Exonerados de Documentos de Identificación de la tabla PARTICIPANTE_EXONERADO_DOC
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	28/06/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub CargarDatosPorExoneradoDocumentos()
        Try
            Me.UcListaPARTICIPANTE1.CargarDatosPorExoneradoDocumentos()
        Catch ex As Exception
            Me.AsignarMensaje("No se pudo recuperar los datos")
        End Try
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla PARTICIPANTE_EXONERADO_DOC
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

    Private Sub ucMantPARTICIPANTE_EXONERADO_DOC_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.UcListaPARTICIPANTE1.EsParticipantesExoneradosDocumentos = True
    End Sub
End Class

