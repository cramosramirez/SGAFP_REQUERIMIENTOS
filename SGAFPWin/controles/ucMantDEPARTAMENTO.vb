Imports SGAFP.EL
Public Class ucMantDEPARTAMENTO

    Private mListaDEPARTAMENTO As listaDEPARTAMENTO

    Private _EsConsulta As Boolean = False
    <DefaultValue(False)> _
    Public Property EsConsulta() As Boolean
        Get
            Return Me._EsConsulta
        End Get
        Set(ByVal value As Boolean)
            Me._EsConsulta = value
            Me.UcListaDEPARTAMENTO1.EsConsulta = value
            Me.UcDetalleDEPARTAMENTO1.EsConsulta = value
        End Set
    End Property

    Public Overrides ReadOnly Property EnEdicion() As Boolean
        Get
            If Me.UcListaDEPARTAMENTO1.Current Is Nothing Then Return False
            Return Me.UcListaDEPARTAMENTO1.Current.IsDirty
        End Get
    End Property

    Private Sub CargarDEPARTAMENTO()
        Me.UcListaDEPARTAMENTO1.CODIGO_REGION = Me.CODIGO_REGIONCbxREGION.SelectedValue.toString()
        Me.UcListaDEPARTAMENTO1.CargarDatos()
        If Me.UcListaDEPARTAMENTO1.Current Is Nothing Then
            Me.UcDetalleDEPARTAMENTO1.DataSource.DataSource = (New DEPARTAMENTO)
        Else
            Me.UcDetalleDEPARTAMENTO1.DataSource.DataSource = Me.UcListaDEPARTAMENTO1.Current
        End If
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla DEPARTAMENTO
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
            Me.UcListaDEPARTAMENTO1.CODIGO_REGION = Me.CODIGO_REGIONCbxREGION.SelectedValue.ToString()
            Me.UcListaDEPARTAMENTO1.CargarDatos()
        Catch ex As Exception 
            Me.AsignarMensaje("No se pudo recuperar los datos")
        End Try 
    End Sub

    Public Overrides Function Guardar() As Integer
        Dim liRet As Integer = Me.UcListaDEPARTAMENTO1.Guardar()
        If liRet <> 1 Then
            Me.sError = Me.UcListaDEPARTAMENTO1.sError
        Else
            Me.sError = ""
        End If
        Return liRet
    End Function

    Private Sub UcListaDEPARTAMENTO1_CambioRegistro() Handles UcListaDEPARTAMENTO1.CambioRegistro
        If Not Me.UcListaDEPARTAMENTO1.Current Is Nothing Then 
            Me.UcDetalleDEPARTAMENTO1.DataSource.DataSource = Me.UcListaDEPARTAMENTO1.Current
        End If 
    End Sub

    Private Sub CODIGO_REGIONCbxREGION_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CODIGO_REGIONCbxREGION.SelectedIndexChanged
        Me.UcListaDEPARTAMENTO1.CODIGO_REGION = Me.CODIGO_REGIONCbxREGION.SelectedValue.toString()
        Me.UcListaDEPARTAMENTO1.CargarDatos()
    End Sub

End Class

