Imports SGAFP.EL
Public Class ucMantFACILITADOR_CAPACITADOR

    Private mListaFACILITADOR_CAPACITADOR As listaFACILITADOR_CAPACITADOR

    Private _EsConsulta As Boolean = False
    <DefaultValue(False)> _
    Public Property EsConsulta() As Boolean
        Get
            Return Me._EsConsulta
        End Get
        Set(ByVal value As Boolean)
            Me._EsConsulta = value
            Me.UcListaFACILITADOR_CAPACITADOR1.EsConsulta = value
            Me.UcDetalleFACILITADOR_CAPACITADOR1.EsConsulta = value
        End Set
    End Property

    Public Overrides ReadOnly Property EnEdicion() As Boolean
        Get
            If Me.UcListaFACILITADOR_CAPACITADOR1.Current Is Nothing Then Return False
            Return Me.UcListaFACILITADOR_CAPACITADOR1.Current.IsDirty
        End Get
    End Property

    Private Sub CargarFACILITADOR_CAPACITADOR()
        Me.UcListaFACILITADOR_CAPACITADOR1.CargarDatos()
        If Me.UcListaFACILITADOR_CAPACITADOR1.Current Is Nothing Then
            Me.UcDetalleFACILITADOR_CAPACITADOR1.DataSource.DataSource = (New FACILITADOR_CAPACITADOR)
        Else
            Me.UcDetalleFACILITADOR_CAPACITADOR1.DataSource.DataSource = Me.UcListaFACILITADOR_CAPACITADOR1.Current
        End If
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla FACILITADOR_CAPACITADOR
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub CargarDatos()
        Try 
            Me.UcListaFACILITADOR_CAPACITADOR1.CargarDatos()
        Catch ex As Exception 
            Me.AsignarMensaje("No se pudo recuperar los datos")
        End Try 
    End Sub

    Public Overrides Function Guardar() As Integer
        Dim liRet As Integer = Me.UcListaFACILITADOR_CAPACITADOR1.Guardar()
        If liRet <> 1 Then
            Me.sError = Me.UcListaFACILITADOR_CAPACITADOR1.sError
        Else
            Me.sError = ""
        End If
        Return liRet
    End Function

    Private Sub UcListaFACILITADOR_CAPACITADOR1_CambioRegistro() Handles UcListaFACILITADOR_CAPACITADOR1.CambioRegistro
        If Not Me.UcListaFACILITADOR_CAPACITADOR1.Current Is Nothing Then 
            Me.UcDetalleFACILITADOR_CAPACITADOR1.DataSource.DataSource = Me.UcListaFACILITADOR_CAPACITADOR1.Current
        End If 
    End Sub






End Class

