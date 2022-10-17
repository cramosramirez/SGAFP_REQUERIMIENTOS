Imports SGAFP.EL
Public Class ucMantCONTRATO_PROVEEDOR_AF

    Private mListaCONTRATO_PROVEEDOR_AF As listaCONTRATO_PROVEEDOR_AF

    Private _EsConsulta As Boolean = False
    <DefaultValue(False)> _
    Public Property EsConsulta() As Boolean
        Get
            Return Me._EsConsulta
        End Get
        Set(ByVal value As Boolean)
            Me._EsConsulta = value
            Me.UcListaCONTRATO_PROVEEDOR_AF1.EsConsulta = value
            Me.UcDetalleCONTRATO_PROVEEDOR_AF1.EsConsulta = value
        End Set
    End Property

    Public Overrides ReadOnly Property EnEdicion() As Boolean
        Get
            If Me.UcListaCONTRATO_PROVEEDOR_AF1.Current Is Nothing Then Return False
            Return Me.UcListaCONTRATO_PROVEEDOR_AF1.Current.IsDirty
        End Get
    End Property

    Private Sub CargarCONTRATO_PROVEEDOR_AF()
        Me.UcListaCONTRATO_PROVEEDOR_AF1.CargarDatos()
        If Me.UcListaCONTRATO_PROVEEDOR_AF1.Current Is Nothing Then
            Me.UcDetalleCONTRATO_PROVEEDOR_AF1.DataSource.DataSource = (New CONTRATO_PROVEEDOR_AF)
        Else
            Me.UcDetalleCONTRATO_PROVEEDOR_AF1.DataSource.DataSource = Me.UcListaCONTRATO_PROVEEDOR_AF1.Current
        End If
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla CONTRATO_PROVEEDOR_AF
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub CargarDatos()
        Try 
            Me.UcListaCONTRATO_PROVEEDOR_AF1.CargarDatos()
        Catch ex As Exception 
            Me.AsignarMensaje("No se pudo recuperar los datos")
        End Try 
    End Sub

    Public Overrides Function Guardar() As Integer
        Me.UcDetalleCONTRATO_PROVEEDOR_AF1.DataSource.EndEdit()
        Dim liRet As Integer = Me.UcListaCONTRATO_PROVEEDOR_AF1.Guardar()
        If liRet <> 1 Then
            Me.sError = Me.UcListaCONTRATO_PROVEEDOR_AF1.sError
        Else
            Me.sError = ""
        End If
        Return liRet
    End Function

    Private Sub UcListaCONTRATO_PROVEEDOR_AF1_CambioRegistro() Handles UcListaCONTRATO_PROVEEDOR_AF1.CambioRegistro
        If Not Me.UcListaCONTRATO_PROVEEDOR_AF1.Current Is Nothing Then 
            Me.UcDetalleCONTRATO_PROVEEDOR_AF1.DataSource.DataSource = Me.UcListaCONTRATO_PROVEEDOR_AF1.Current
        End If 
    End Sub




End Class

