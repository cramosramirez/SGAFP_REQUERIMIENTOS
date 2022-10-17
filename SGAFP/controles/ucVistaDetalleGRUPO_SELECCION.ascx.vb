Imports SGAFP.BL
Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucVistaDetalleGRUPO_SELECCION
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla GRUPO_SELECCION
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	28/03/2019	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleGRUPO_SELECCION
    Inherits ucBase
 
#Region"Propiedades"

    Public Property ID_GRUPO_SELEC() As Decimal
        Get
            If Me.ViewState("ID_GRUPO_SELEC") Is Nothing Then
                Return -1
            Else
                Return CInt(Me.ViewState("ID_GRUPO_SELEC"))
            End If
        End Get
        Set(ByVal Value As Decimal)
            Me.ViewState("ID_GRUPO_SELEC") = Value
            Me.txtID_GRUPO_SELEC.Text = CStr(Value)
            If Value > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Property ID_ACCION_CONTRATADA() As Decimal
        Get
            If Me.ViewState("ID_ACCION_CONTRATADA") Is Nothing Then
                Return -1
            Else
                Return CInt(Me.ViewState("ID_ACCION_CONTRATADA"))
            End If
        End Get
        Set(ByVal value As Decimal)
            Me.ViewState("ID_ACCION_CONTRATADA") = value
            Dim lContrato As CONTRATO_BOLPROS = Me.ObtenerContrato(value)
            If lContrato IsNot Nothing Then Me.txtNUM_CONTRATO.Text = lContrato.NUM_CONTRATO
        End Set
    End Property

    Public Property FECHA_HABILITA() As DateTime
        Get
            Return Me.deFECHA_HABILITA.Value
        End Get
        Set(ByVal value As DateTime)
            Me.deFECHA_HABILITA.Value = value
        End Set
    End Property

    Public Property FECHA_INICIO() As DateTime
        Get
            Return Me.deFECHA_INICIO.Value
        End Get
        Set(ByVal value As DateTime)
            Me.deFECHA_INICIO.Value = value
        End Set
    End Property

    Public Property FECHA_FIN() As DateTime
        Get
            Return Me.deFECHA_FIN.Value
        End Get
        Set(ByVal value As DateTime)
            Me.deFECHA_FIN.Value = value
        End Set
    End Property

    Public Property NO_GRUPO() As Decimal
        Get
            If Me.txtNO_GRUPO.Value Is Nothing Then Return -1
            Return Me.txtNO_GRUPO.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtNO_GRUPO.Value = value
        End Set
    End Property

   

    

    Private _Enabled As Boolean = True
    Private _sError As String
    Private _nuevo As Boolean = False
    Private mComponente As New cGRUPO_SELECCION
    Private mEntidad As GRUPO_SELECCION
    Public Event ErrorEvent(ByVal errorMessage As String)

    Public ReadOnly Property sError() As String
        Get
            Return _sError
        End Get
    End Property
 
    Public Property Enabled() As Boolean
        Get
            Return Me._Enabled
        End Get
        Set(ByVal Value As Boolean)
            Me._Enabled = Value
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not Me.ViewState("nuevo") Is Nothing Then Me._nuevo = Me.ViewState("nuevo")
        'If Not Me.ViewState("ID_GRUPO_SELEC") Is Nothing Then Me.ID_GRUPO_SELEC = Me.ViewState("ID_GRUPO_SELEC")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información del registro de la tabla GRUPO_SELECCION
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/03/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()
        Dim lContrato As CONTRATO_BOLPROS

        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")
        mEntidad = New GRUPO_SELECCION
        mEntidad.ID_GRUPO_SELEC = ID_GRUPO_SELEC

        If mComponente.ObtenerGRUPO_SELECCION(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtID_GRUPO_SELEC.Text = mEntidad.ID_GRUPO_SELEC.ToString()

        lContrato = ObtenerContrato(Me.ID_ACCION_CONTRATADA)
        If lContrato IsNot Nothing Then Me.txtNUM_CONTRATO.Text = lContrato.NUM_CONTRATO
        Me.ID_ACCION_CONTRATADA = mEntidad.ID_ACCION_CONTRATADA
        Me.deFECHA_HABILITA.Value = mEntidad.FECHA_HABILITA
        Me.deFECHA_INICIO.Value = mEntidad.FECHA_INICIO
        Me.deFECHA_FIN.Value = mEntidad.FECHA_FIN
        Me.txtNO_GRUPO.Value = mEntidad.NO_GRUPO
        Me.txtCODIGO.Text = mEntidad.CODIGO
        Me.txtLUGAR_EJECUCION.Text = mEntidad.LUGAR_EJECUCION
    End Sub

    Private Function ObtenerContrato(ByVal ID_ACCION_CONTRATADA As Decimal) As CONTRATO_BOLPROS
        Dim lContrato As New CONTRATO_BOLPROS
        Dim lAccion As New ACCION_CONTRATADA

        lContrato = Nothing
        lAccion = (New cACCION_CONTRATADA).ObtenerACCION_CONTRATADA(Me.ID_ACCION_CONTRATADA)
        If lAccion IsNot Nothing Then
            lContrato = (New cCONTRATO_BOLPROS).ObtenerCONTRATO_BOLPROS(lAccion.ID_CONTRATO)
            If lContrato IsNot Nothing Then Me.txtNUM_CONTRATO.Text = lContrato.NUM_CONTRATO
        End If

        Return lContrato
    End Function
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que permite Habilitar/Deshabilitar el uso de los controles contenidos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/03/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.txtNUM_CONTRATO.ClientEnabled = False
        Me.deFECHA_HABILITA.ClientEnabled = False
        Me.deFECHA_INICIO.ClientEnabled = edicion
        Me.deFECHA_FIN.ClientEnabled = edicion
        Me.txtNO_GRUPO.ClientEnabled = False
        Me.txtCODIGO.ClientEnabled = False
        Me.trCODIGO_GRUPO.Visible = Not Me._nuevo
        Me.txtLUGAR_EJECUCION.ClientEnabled = True
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Configura si es un registro nuevo el cargado
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/03/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub Nuevo()
        Dim listaG As listaGRUPO_SELECCION = (New cGRUPO_SELECCION).ObtenerListaPorACCION_CONTRATADA(Me.ID_ACCION_CONTRATADA)
        Me._nuevo = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Me.deFECHA_HABILITA.Value = Today
        Me.deFECHA_INICIO.Value = Nothing
        Me.deFECHA_FIN.Value = Nothing
        Me.txtNO_GRUPO.Value = If(listaG Is Nothing, 1, listaG.Count + 1)
        Me.txtLUGAR_EJECUCION.Text = ""
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Guarda la información del registro en la tabla GRUPO_SELECCION
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/03/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim sError As New String("")
        Dim alDatos As New ArrayList
        Dim lContrato As CONTRATO_BOLPROS
        Dim lOferta As CONTRATO_COMPRA
        Dim lAccion As ACCION_CONTRATADA = (New cACCION_CONTRATADA).ObtenerACCION_CONTRATADA(Me.ID_ACCION_CONTRATADA)
        Dim listaG As listaGRUPO_SELECCION = (New cGRUPO_SELECCION).ObtenerListaPorACCION_CONTRATADA(Me.ID_ACCION_CONTRATADA)
        Dim sNumOferta As String = ""

        mEntidad = New GRUPO_SELECCION
        If Me._nuevo Then
            mEntidad.ID_GRUPO_SELEC = 0
            mEntidad.USUARIO_CREA = Me.ObtenerUsuario
            mEntidad.FECHA_CREA = Now

            If lAccion IsNot Nothing Then
                If listaG Is Nothing OrElse (listaG IsNot Nothing AndAlso (listaG.Count + 1) > lAccion.CANT_CURSOS) Then
                    Return "La habilitacion de este grupo excede la cantidad de grupos contratada"
                End If
            End If
        Else
            mEntidad = (New cGRUPO_SELECCION).ObtenerGRUPO_SELECCION(CInt(Me.txtID_GRUPO_SELEC.Text))
        End If

        lContrato = (New cCONTRATO_BOLPROS).ObtenerCONTRATO_BOLPROS(lAccion.ID_CONTRATO)
        If lContrato IsNot Nothing Then
            'Validar las fechas de ejecución
            If Me.deFECHA_INICIO.Date < lContrato.FECHA_INI_EJEC OrElse Me.deFECHA_FIN.Date > lContrato.FECHA_FIN_EJEC Then
                Return "Las fechas de ejecucion del grupo deben estar comprendidas en el periodo de ejecucion del contrato "
            End If

            lOferta = (New cCONTRATO_COMPRA).ObtenerCONTRATO_COMPRA(lContrato.ID_CONTRATO_COMPRA)
            If lOferta IsNot Nothing Then sNumOferta = lOferta.NO_CONTRATO_COMPRA
        End If

        mEntidad.ID_ACCION_CONTRATADA = Me.ID_ACCION_CONTRATADA
        mEntidad.FECHA_HABILITA = Me.deFECHA_HABILITA.Value
        mEntidad.FECHA_INICIO = Me.deFECHA_INICIO.Value
        mEntidad.FECHA_FIN = Me.deFECHA_FIN.Value
        mEntidad.NO_GRUPO = Me.txtNO_GRUPO.Value
        mEntidad.CODIGO = sNumOferta + "-" + Me.txtNUM_CONTRATO.Text
        mEntidad.LUGAR_EJECUCION = Me.txtLUGAR_EJECUCION.Text.Trim.ToUpper

        If mComponente.ActualizarGRUPO_SELECCION(mEntidad) <> 1 Then
            Me.AsignarMensaje("Error al Guardar registro.", True, True)
            Return "Error al Guardar registro."
        End If
        Me.txtID_GRUPO_SELEC.Text = mEntidad.ID_GRUPO_SELEC.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function

End Class
