Imports SGAFP.EL
Public Class ucMantINFORME_FINAL_AF

    Private mListaINFORME_FINAL_AF As listaINFORME_FINAL_AF

    Private _EsConsulta As Boolean = False
    <DefaultValue(False)> _
    Public Property EsConsulta() As Boolean
        Get
            Return Me._EsConsulta
        End Get
        Set(ByVal value As Boolean)
            Me._EsConsulta = value
            Me.UcListaINFORME_FINAL_AF1.EsConsulta = value
            Me.UcDetalleINFORME_FINAL_AF1.EsConsulta = value
        End Set
    End Property

    Public Overrides ReadOnly Property EnEdicion() As Boolean
        Get
            If Me.UcListaINFORME_FINAL_AF1.Current Is Nothing Then Return False
            Return Me.UcListaINFORME_FINAL_AF1.Current.IsDirty
        End Get
    End Property

    Private Sub CargarINFORME_FINAL_AF()
        Me.UcListaINFORME_FINAL_AF1.CargarDatos()
        If Me.UcListaINFORME_FINAL_AF1.Current Is Nothing Then
            Me.UcDetalleINFORME_FINAL_AF1.DataSource.DataSource = (New INFORME_FINAL_AF)
        Else
            Me.UcDetalleINFORME_FINAL_AF1.DataSource.DataSource = Me.UcListaINFORME_FINAL_AF1.Current
        End If
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla INFORME_FINAL_AF
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub CargarDatos()
        Try 
            Me.UcListaINFORME_FINAL_AF1.CargarDatos()
        Catch ex As Exception 
            Me.AsignarMensaje("No se pudo recuperar los datos")
        End Try 
    End Sub

    Public Overrides Function Guardar() As Integer
        Dim liRet As Integer = Me.UcListaINFORME_FINAL_AF1.Guardar()
        If liRet <> 1 Then
            Me.sError = Me.UcListaINFORME_FINAL_AF1.sError
        Else
            Me.sError = ""
        End If
        Return liRet
    End Function

    Private Sub UcListaINFORME_FINAL_AF1_CambioRegistro() Handles UcListaINFORME_FINAL_AF1.CambioRegistro
        If Not Me.UcListaINFORME_FINAL_AF1.Current Is Nothing Then 
            Me.UcDetalleINFORME_FINAL_AF1.DataSource.DataSource = Me.UcListaINFORME_FINAL_AF1.Current
        End If 
    End Sub



End Class

