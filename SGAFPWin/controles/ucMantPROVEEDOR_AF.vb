Imports SGAFP.EL
Public Class ucMantPROVEEDOR_AF

    Private mListaPROVEEDOR_AF As listaPROVEEDOR_AF

    Private _EsConsulta As Boolean = False
    <DefaultValue(False)> _
    Public Property EsConsulta() As Boolean
        Get
            Return Me._EsConsulta
        End Get
        Set(ByVal value As Boolean)
            Me._EsConsulta = value
            Me.UcListaPROVEEDOR_AF1.EsConsulta = value
            Me.UcDetallePROVEEDOR_AF1.EsConsulta = value
        End Set
    End Property

    Public Overrides ReadOnly Property EnEdicion() As Boolean
        Get
            If Me.UcListaPROVEEDOR_AF1.Current Is Nothing Then Return False
            Return Me.UcListaPROVEEDOR_AF1.Current.IsDirty
        End Get
    End Property

    Private Sub CargarPROVEEDOR_AF()
        Me.UcListaPROVEEDOR_AF1.CargarDatos()
        If Me.UcListaPROVEEDOR_AF1.Current Is Nothing Then
            Me.UcDetallePROVEEDOR_AF1.DataSource.DataSource = (New PROVEEDOR_AF)
        Else
            Me.UcDetallePROVEEDOR_AF1.DataSource.DataSource = Me.UcListaPROVEEDOR_AF1.Current
        End If
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla PROVEEDOR_AF
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub CargarDatos()
        Try 
            Me.UcListaPROVEEDOR_AF1.CargarDatos()
        Catch ex As Exception 
            Me.AsignarMensaje("No se pudo recuperar los datos")
        End Try 
    End Sub

    Public Overrides Function Guardar() As Integer
        Dim liRet As Integer = Me.UcListaPROVEEDOR_AF1.Guardar()
        If liRet <> 1 Then
            Me.sError = Me.UcListaPROVEEDOR_AF1.sError
        Else
            Me.sError = ""
        End If
        Return liRet
    End Function

    Private Sub UcListaPROVEEDOR_AF1_CambioRegistro() Handles UcListaPROVEEDOR_AF1.CambioRegistro
        If Not Me.UcListaPROVEEDOR_AF1.Current Is Nothing Then 
            Me.UcDetallePROVEEDOR_AF1.DataSource.DataSource = Me.UcListaPROVEEDOR_AF1.Current
        End If 
    End Sub





End Class

