Public Class ucBaseDetalleMant
    Inherits ucBaseWin

    Private _EsNuevo As Boolean = False
    Protected _PermitirEditar As Boolean = True
    Protected ListaControles() As String

    Protected WithEvents _DataSource As BindingSource

    Protected Overridable Sub InicializarListaControles()

    End Sub

    Public Overridable Property DataSource() As BindingSource
        Get
            Return Me._DataSource
        End Get
        Set(ByVal value As BindingSource)
            Me._DataSource = value
        End Set
    End Property

    Protected Sub VerOcultarObjeto(ByVal aObjeto As Control, ByVal abVisible As Boolean)
        aObjeto.Visible = abVisible
        Dim indice As Integer = 0
        Dim nombreObjeto As String = aObjeto.Name
        Dim ancho As Integer = aObjeto.Width
        indice = System.Array.IndexOf(ListaControles, nombreObjeto)
        If abVisible Then
            For Each mControl As Control In Me.Controls
                If nombreObjeto <> mControl.Name And System.Array.IndexOf(ListaControles, mControl.Name) > indice Then
                    mControl.Left += ancho
                End If
            Next
        Else
            For Each mControl As Control In Me.Controls
                If nombreObjeto <> mControl.Name And System.Array.IndexOf(ListaControles, mControl.Name) > indice Then
                    mControl.Left -= ancho
                End If
            Next
        End If
    End Sub

    Public Property EsNuevo() As Boolean
        Get
            Return Me._EsNuevo
        End Get
        Set(ByVal value As Boolean)
            Me._EsNuevo = value
        End Set
    End Property

    Public Overloads Sub Nuevo()
        Me._EsNuevo = True
    End Sub

    Public Overridable Function Actualizar() As Integer
        Return -1
    End Function

End Class
