Imports SGAFP.EL
Public Class ucMantPARTICIPANTE_AF

    Private mListaPARTICIPANTE_AF As listaPARTICIPANTE_AF

    Private _EsConsulta As Boolean = False
    <DefaultValue(False)> _
    Public Property EsConsulta() As Boolean
        Get
            Return Me._EsConsulta
        End Get
        Set(ByVal value As Boolean)
            Me._EsConsulta = value
            Me.UcListaPARTICIPANTE_AF1.EsConsulta = value
            Me.UcDetallePARTICIPANTE_AF1.EsConsulta = value
        End Set
    End Property

    Public Overrides ReadOnly Property EnEdicion() As Boolean
        Get
            If Me.UcListaPARTICIPANTE_AF1.Current Is Nothing Then Return False
            Return Me.UcListaPARTICIPANTE_AF1.Current.IsDirty
        End Get
    End Property

    Private Sub CargarPARTICIPANTE_AF()
        Me.UcListaPARTICIPANTE_AF1.ID_ACCION_FORMATIVA = CDec(Me.ID_ACCION_FORMATIVACbxACCION_FORMATIVA.SelectedValue)
        Me.UcListaPARTICIPANTE_AF1.CargarDatos()
        If Me.UcListaPARTICIPANTE_AF1.Current Is Nothing Then
            Me.UcDetallePARTICIPANTE_AF1.DataSource.DataSource = (New PARTICIPANTE_AF)
        Else
            Me.UcDetallePARTICIPANTE_AF1.DataSource.DataSource = Me.UcListaPARTICIPANTE_AF1.Current
        End If
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla PARTICIPANTE_AF
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub CargarDatos()
        Try 
            Me.ID_ACCION_FORMATIVACbxACCION_FORMATIVA.Recuperar()
            Me.UcListaPARTICIPANTE_AF1.ID_ACCION_FORMATIVA = CDec(Me.ID_ACCION_FORMATIVACbxACCION_FORMATIVA.SelectedValue.ToString())
            Me.UcListaPARTICIPANTE_AF1.CargarDatos()
        Catch ex As Exception 
            Me.AsignarMensaje("No se pudo recuperar los datos")
        End Try 
    End Sub

    Public Overrides Function Guardar() As Integer
        Dim liRet As Integer = Me.UcListaPARTICIPANTE_AF1.Guardar()
        If liRet <> 1 Then
            Me.sError = Me.UcListaPARTICIPANTE_AF1.sError
        Else
            Me.sError = ""
        End If
        Return liRet
    End Function

    Private Sub UcListaPARTICIPANTE_AF1_CambioRegistro() Handles UcListaPARTICIPANTE_AF1.CambioRegistro
        If Not Me.UcListaPARTICIPANTE_AF1.Current Is Nothing Then 
            Me.UcDetallePARTICIPANTE_AF1.DataSource.DataSource = Me.UcListaPARTICIPANTE_AF1.Current
        End If 
    End Sub


    Private Sub ID_ACCION_FORMATIVACbxACCION_FORMATIVA_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ID_ACCION_FORMATIVACbxACCION_FORMATIVA.SelectedIndexChanged
        Me.UcListaPARTICIPANTE_AF1.ID_ACCION_FORMATIVA = CDec(Me.ID_ACCION_FORMATIVACbxACCION_FORMATIVA.SelectedValue)
        Me.UcListaPARTICIPANTE_AF1.CargarDatos()
    End Sub


End Class

