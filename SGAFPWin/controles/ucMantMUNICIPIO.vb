Imports SGAFP.EL
Public Class ucMantMUNICIPIO

    Private mListaMUNICIPIO As listaMUNICIPIO

    Private _EsConsulta As Boolean = False
    <DefaultValue(False)> _
    Public Property EsConsulta() As Boolean
        Get
            Return Me._EsConsulta
        End Get
        Set(ByVal value As Boolean)
            Me._EsConsulta = value
            Me.UcListaMUNICIPIO1.EsConsulta = value
            Me.UcDetalleMUNICIPIO1.EsConsulta = value
        End Set
    End Property

    Public Overrides ReadOnly Property EnEdicion() As Boolean
        Get
            If Me.UcListaMUNICIPIO1.Current Is Nothing Then Return False
            Return Me.UcListaMUNICIPIO1.Current.IsDirty
        End Get
    End Property

    Private Sub CargarMUNICIPIO()
        Me.UcListaMUNICIPIO1.CODIGO_REGION = Me.CODIGO_REGIONCbxREGION.SelectedValue.toString()
        Me.UcListaMUNICIPIO1.CODIGO_DEPARTAMENTO = Me.CODIGO_DEPARTAMENTOCbxDEPARTAMENTO.SelectedValue.toString()
        Me.UcListaMUNICIPIO1.CargarDatos()
        If Me.UcListaMUNICIPIO1.Current Is Nothing Then
            Me.UcDetalleMUNICIPIO1.DataSource.DataSource = (New MUNICIPIO)
        Else
            Me.UcDetalleMUNICIPIO1.DataSource.DataSource = Me.UcListaMUNICIPIO1.Current
        End If
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla MUNICIPIO
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub CargarDatos()
        Try 
            Me.CODIGO_REGIONCbxREGION.Recuperar()
            Me.UcListaMUNICIPIO1.CODIGO_REGION = Me.CODIGO_REGIONCbxREGION.SelectedValue.ToString()
            Me.CODIGO_DEPARTAMENTOCbxDEPARTAMENTO.Recuperar(Me.CODIGO_REGIONCbxREGION.SelectedValue)
            Me.UcListaMUNICIPIO1.CODIGO_DEPARTAMENTO = Me.CODIGO_DEPARTAMENTOCbxDEPARTAMENTO.SelectedValue.ToString()
            Me.UcListaMUNICIPIO1.CargarDatos()
        Catch ex As Exception 
            Me.AsignarMensaje("No se pudo recuperar los datos")
        End Try 
    End Sub

    Public Overrides Function Guardar() As Integer
        Dim liRet As Integer = Me.UcListaMUNICIPIO1.Guardar()
        If liRet <> 1 Then
            Me.sError = Me.UcListaMUNICIPIO1.sError
        Else
            Me.sError = ""
        End If
        Return liRet
    End Function

    Private Sub UcListaMUNICIPIO1_CambioRegistro() Handles UcListaMUNICIPIO1.CambioRegistro
        If Not Me.UcListaMUNICIPIO1.Current Is Nothing Then 
            Me.UcDetalleMUNICIPIO1.DataSource.DataSource = Me.UcListaMUNICIPIO1.Current
        End If 
    End Sub

    Private Sub CODIGO_REGIONCbxREGION_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CODIGO_REGIONCbxREGION.SelectedIndexChanged
        Me.CODIGO_DEPARTAMENTOCbxDEPARTAMENTO.Recuperar(Me.CODIGO_REGIONCbxREGION.SelectedValue)
    End Sub

    Private Sub CODIGO_DEPARTAMENTOCbxDEPARTAMENTO_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CODIGO_DEPARTAMENTOCbxDEPARTAMENTO.SelectedIndexChanged
        Me.UcListaMUNICIPIO1.CODIGO_REGION = Me.CODIGO_REGIONCbxREGION.SelectedValue.toString()
        Me.UcListaMUNICIPIO1.CODIGO_DEPARTAMENTO = Me.CODIGO_DEPARTAMENTOCbxDEPARTAMENTO.SelectedValue.toString()
        Me.UcListaMUNICIPIO1.CargarDatos()
    End Sub

End Class

