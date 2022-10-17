Imports SGAFP.EL
Public Class ucMantMODALIDAD_DE_FORMACION

    Private mListaMODALIDAD_DE_FORMACION As listaMODALIDAD_DE_FORMACION

    Private _EsConsulta As Boolean = False
    <DefaultValue(False)> _
    Public Property EsConsulta() As Boolean
        Get
            Return Me._EsConsulta
        End Get
        Set(ByVal value As Boolean)
            Me._EsConsulta = value
            Me.UcListaMODALIDAD_DE_FORMACION1.EsConsulta = value
            Me.UcDetalleMODALIDAD_DE_FORMACION1.EsConsulta = value
        End Set
    End Property

    Public Overrides ReadOnly Property EnEdicion() As Boolean
        Get
            If Me.UcListaMODALIDAD_DE_FORMACION1.Current Is Nothing Then Return False
            Return Me.UcListaMODALIDAD_DE_FORMACION1.Current.IsDirty
        End Get
    End Property

    Private Sub CargarMODALIDAD_DE_FORMACION()
        Me.UcListaMODALIDAD_DE_FORMACION1.CargarDatos()
        If Me.UcListaMODALIDAD_DE_FORMACION1.Current Is Nothing Then
            Me.UcDetalleMODALIDAD_DE_FORMACION1.DataSource.DataSource = (New MODALIDAD_DE_FORMACION)
        Else
            Me.UcDetalleMODALIDAD_DE_FORMACION1.DataSource.DataSource = Me.UcListaMODALIDAD_DE_FORMACION1.Current
        End If
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla MODALIDAD_DE_FORMACION
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub CargarDatos()
        Try 
            Me.UcListaMODALIDAD_DE_FORMACION1.CargarDatos()
        Catch ex As Exception 
            Me.AsignarMensaje("No se pudo recuperar los datos")
        End Try 
    End Sub

    Public Overrides Function Guardar() As Integer
        Me.UcDetalleMODALIDAD_DE_FORMACION1.DataSource.EndEdit()
        Dim liRet As Integer = Me.UcListaMODALIDAD_DE_FORMACION1.Guardar()
        If liRet <> 1 Then
            Me.sError = Me.UcListaMODALIDAD_DE_FORMACION1.sError
        Else
            Me.sError = ""
        End If
        Return liRet
    End Function

    Private Sub UcListaMODALIDAD_DE_FORMACION1_CambioRegistro() Handles UcListaMODALIDAD_DE_FORMACION1.CambioRegistro
        If Not Me.UcListaMODALIDAD_DE_FORMACION1.Current Is Nothing Then 
            Me.UcDetalleMODALIDAD_DE_FORMACION1.DataSource.DataSource = Me.UcListaMODALIDAD_DE_FORMACION1.Current
        End If 
    End Sub

End Class

