Imports SGAFP.BL
Imports SGAFP.EL

Partial Class controles_ucMantASISTENCIA_PAGO
    Inherits ucBase


#Region "Inicializaciones Mantenimiento"

    Public Sub InicializarLista()
        Me.ucBarraNavegacion1.Navegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = True
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.PermitirGuardar = False
        Me.ucBarraNavegacion1.HabilitarEdicion(False)
        Me.ucListaASISTENCIA_PAGO1.Visible = True
        Me.ucVistaDetalleASISTENCIA_PAGO1.Visible = False
        If Me.CargarDatos() <> 1 Then
            Me.AsignarMensaje("Error al Recuperar Lista", True, True)
        End If
    End Sub

    Private Sub InicializarDetalle()
        Me.ucBarraNavegacion1.Navegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = True
        Me.ucBarraNavegacion1.HabilitarEdicion(True)
        Me.ucListaASISTENCIA_PAGO1.Visible = False
        Me.ucVistaDetalleASISTENCIA_PAGO1.Visible = True
    End Sub

    Public Function CargarDatos() As Integer
        Try
            Return Me.CargarASISTENCIA_PAGO()
        Catch ex As Exception
            Return -1
        End Try
        Return 1
    End Function
#End Region

    Private Function CargarASISTENCIA_PAGO() As Integer
        If Me.ucListaASISTENCIA_PAGO1.CargarDatos() <> 1 Then Return -1
        Return 1
    End Function

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            Me.InicializarLista()
        End If
    End Sub

    Private Sub UcBarraNavegacion1_Agregar(ByVal sender As Object, ByVal e As System.EventArgs) Handles ucBarraNavegacion1.Agregar
        Me.InicializarDetalle()
        Me.ucVistaDetalleASISTENCIA_PAGO1.LimpiarControles()
        Me.ucVistaDetalleASISTENCIA_PAGO1.ID_ASISTE_PAGO = 0
    End Sub

    Private Sub ucBarraNavegacion1_Cancelar(ByVal sender As Object, ByVal e As System.EventArgs) Handles ucBarraNavegacion1.Cancelar
        Me.InicializarLista()
    End Sub

    Private Sub ucBarraNavegacion1_Guardar(ByVal sender As Object, ByVal e As System.EventArgs) Handles ucBarraNavegacion1.Guardar
        Dim sError As String
        sError = Me.ucVistaDetalleASISTENCIA_PAGO1.Actualizar()
        If sError <> "" Then
            AsignarMensaje(sError, True, True)
            Return
        End If
        Me.InicializarLista()
    End Sub

    Protected Sub ucListaASISTENCIA_PAGO1_Editando(ByVal ID_ASISTE_PAGO As Decimal) Handles ucListaASISTENCIA_PAGO1.Editando
        Me.InicializarDetalle()
        Me.ucVistaDetalleASISTENCIA_PAGO1.ID_ASISTE_PAGO = ID_ASISTE_PAGO
    End Sub

    Private Sub ucVistaDetalleASISTENCIA_PAGO1_ErrorEvent(ByVal errorMessage As String) Handles ucVistaDetalleASISTENCIA_PAGO1.ErrorEvent
        'Mostrar mensaje de error contenido en errorMessage
        Me.AsignarMensaje(errorMessage, True, True)
    End Sub
End Class
