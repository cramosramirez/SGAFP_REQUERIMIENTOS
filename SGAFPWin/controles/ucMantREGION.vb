Imports SGAFP.EL
Public Class ucMantREGION

    Private mListaREGION As listaREGION

    Private _EsConsulta As Boolean = False
    <DefaultValue(False)> _
    Public Property EsConsulta() As Boolean
        Get
            Return Me._EsConsulta
        End Get
        Set(ByVal value As Boolean)
            Me._EsConsulta = value
            Me.UcListaREGION1.EsConsulta = value
            Me.UcDetalleREGION1.EsConsulta = value
        End Set
    End Property

    Public Overrides ReadOnly Property EnEdicion() As Boolean
        Get
            If Me.UcListaREGION1.Current Is Nothing Then Return False
            Return Me.UcListaREGION1.Current.IsDirty
        End Get
    End Property

    Private Sub CargarREGION()
        Me.UcListaREGION1.CargarDatos()
        If Me.UcListaREGION1.Current Is Nothing Then
            Me.UcDetalleREGION1.DataSource.DataSource = (New REGION)
        Else
            Me.UcDetalleREGION1.DataSource.DataSource = Me.UcListaREGION1.Current
        End If
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla REGION
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub CargarDatos()
        Try 
            Me.UcListaREGION1.CargarDatos()
        Catch ex As Exception 
            Me.AsignarMensaje("No se pudo recuperar los datos")
        End Try 
    End Sub

    Public Overrides Function Guardar() As Integer
        Dim liRet As Integer = Me.UcListaREGION1.Guardar()
        If liRet <> 1 Then
            Me.sError = Me.UcListaREGION1.sError
        Else
            Me.sError = ""
        End If
        Return liRet
    End Function

    Private Sub UcListaREGION1_CambioRegistro() Handles UcListaREGION1.CambioRegistro
        If Not Me.UcListaREGION1.Current Is Nothing Then 
            Me.UcDetalleREGION1.DataSource.DataSource = Me.UcListaREGION1.Current
        End If 
    End Sub

End Class

