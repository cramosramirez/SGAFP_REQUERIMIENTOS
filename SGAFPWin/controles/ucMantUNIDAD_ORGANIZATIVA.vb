Imports SGAFP.EL
Public Class ucMantUNIDAD_ORGANIZATIVA

    Private mListaUNIDAD_ORGANIZATIVA As listaUNIDAD_ORGANIZATIVA

    Private _EsConsulta As Boolean = False
    <DefaultValue(False)> _
    Public Property EsConsulta() As Boolean
        Get
            Return Me._EsConsulta
        End Get
        Set(ByVal value As Boolean)
            Me._EsConsulta = value
            Me.UcListaUNIDAD_ORGANIZATIVA1.EsConsulta = value
            Me.UcDetalleUNIDAD_ORGANIZATIVA1.EsConsulta = value
        End Set
    End Property

    Public Overrides ReadOnly Property EnEdicion() As Boolean
        Get
            If Me.UcListaUNIDAD_ORGANIZATIVA1.Current Is Nothing Then Return False
            Return Me.UcListaUNIDAD_ORGANIZATIVA1.Current.IsDirty
        End Get
    End Property

    Private Sub CargarUNIDAD_ORGANIZATIVA()
        Me.UcListaUNIDAD_ORGANIZATIVA1.CargarDatos()
        If Me.UcListaUNIDAD_ORGANIZATIVA1.Current Is Nothing Then
            Me.UcDetalleUNIDAD_ORGANIZATIVA1.DataSource.DataSource = (New UNIDAD_ORGANIZATIVA)
        Else
            Me.UcDetalleUNIDAD_ORGANIZATIVA1.DataSource.DataSource = Me.UcListaUNIDAD_ORGANIZATIVA1.Current
        End If
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla UNIDAD_ORGANIZATIVA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub CargarDatos()
        Try 
            Me.UcListaUNIDAD_ORGANIZATIVA1.CargarDatos()
        Catch ex As Exception 
            Me.AsignarMensaje("No se pudo recuperar los datos")
        End Try 
    End Sub

    Public Overrides Function Guardar() As Integer
        Me.UcDetalleUNIDAD_ORGANIZATIVA1.DataSource.EndEdit()
        Dim liRet As Integer = Me.UcListaUNIDAD_ORGANIZATIVA1.Guardar()
        If liRet <> 1 Then
            Me.sError = Me.UcListaUNIDAD_ORGANIZATIVA1.sError
        Else
            Me.sError = ""
        End If
        Return liRet
    End Function

    Private Sub UcListaUNIDAD_ORGANIZATIVA1_CambioRegistro() Handles UcListaUNIDAD_ORGANIZATIVA1.CambioRegistro
        If Not Me.UcListaUNIDAD_ORGANIZATIVA1.Current Is Nothing Then 
            Me.UcDetalleUNIDAD_ORGANIZATIVA1.DataSource.DataSource = Me.UcListaUNIDAD_ORGANIZATIVA1.Current
        End If 
    End Sub


End Class

