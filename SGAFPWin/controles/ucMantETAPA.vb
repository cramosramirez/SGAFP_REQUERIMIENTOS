Imports SGAFP.EL
Public Class ucMantETAPA

    Private mListaETAPA As listaETAPA

    Private _EsConsulta As Boolean = False
    <DefaultValue(False)> _
    Public Property EsConsulta() As Boolean
        Get
            Return Me._EsConsulta
        End Get
        Set(ByVal value As Boolean)
            Me._EsConsulta = value
            Me.UcListaETAPA1.EsConsulta = value
            Me.UcDetalleETAPA1.EsConsulta = value
        End Set
    End Property

    Public Overrides ReadOnly Property EnEdicion() As Boolean
        Get
            If Me.UcListaETAPA1.Current Is Nothing Then Return False
            Return Me.UcListaETAPA1.Current.IsDirty
        End Get
    End Property

    Private Sub CargarETAPA()
        Me.UcListaETAPA1.CODIGO_PROCESO = Me.CODIGO_PROCESOCbxPROCESO.SelectedValue.toString()
        Me.UcListaETAPA1.CargarDatos()
        If Me.UcListaETAPA1.Current Is Nothing Then
            Me.UcDetalleETAPA1.DataSource.DataSource = (New ETAPA)
        Else
            Me.UcDetalleETAPA1.DataSource.DataSource = Me.UcListaETAPA1.Current
        End If
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla ETAPA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub CargarDatos()
        Try 
            Me.CODIGO_PROCESOCbxPROCESO.Recuperar()
            Me.UcListaETAPA1.CODIGO_PROCESO = Me.CODIGO_PROCESOCbxPROCESO.SelectedValue.ToString()
            Me.UcListaETAPA1.CargarDatos()
        Catch ex As Exception 
            Me.AsignarMensaje("No se pudo recuperar los datos")
        End Try 
    End Sub

    Public Overrides Function Guardar() As Integer
        Dim liRet As Integer = Me.UcListaETAPA1.Guardar()
        If liRet <> 1 Then
            Me.sError = Me.UcListaETAPA1.sError
        Else
            Me.sError = ""
        End If
        Return liRet
    End Function

    Private Sub UcListaETAPA1_CambioRegistro() Handles UcListaETAPA1.CambioRegistro
        If Not Me.UcListaETAPA1.Current Is Nothing Then 
            Me.UcDetalleETAPA1.DataSource.DataSource = Me.UcListaETAPA1.Current
        End If 
    End Sub

    Private Sub CODIGO_PROCESOCbxPROCESO_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CODIGO_PROCESOCbxPROCESO.SelectedIndexChanged
        Me.UcListaETAPA1.CODIGO_PROCESO = Me.CODIGO_PROCESOCbxPROCESO.SelectedValue.toString()
        Me.UcListaETAPA1.CargarDatos()
    End Sub


End Class

