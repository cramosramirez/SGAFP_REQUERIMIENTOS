Imports System.Configuration.ConfigurationManager
Imports SGAFP.BL
Imports SGAFP.EL

''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucVistaDetalleMUNICIPIO_CONVOCATORIA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla MUNICIPIO_CONVOCATORIA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	10/09/2011	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleMUNICIPIO_CONVOCATORIA
    Inherits ucBase
 
#Region"Propiedades"

    Public Sub CargarMunicipioConvocatoria(ByVal ID_FUENTE As Decimal, ByVal NO_CONVOCATORIA As Decimal, ByVal CODIGO_DEPARTAMENTO As String, ByVal CODIGO_MUNICIPIO As String)
        Me._ID_FUENTE = ID_FUENTE
        Me._NO_CONVOCATORIA = NO_CONVOCATORIA
        Me._CODIGO_DEPARTAMENTO = CODIGO_DEPARTAMENTO
        Me._CODIGO_MUNICIPIO = CODIGO_MUNICIPIO

        If Me._ID_FUENTE > 0 AndAlso Me._NO_CONVOCATORIA > 0 AndAlso _CODIGO_DEPARTAMENTO <> "" AndAlso _CODIGO_MUNICIPIO <> "" Then
            Me.cbxID_FUENTE.ClientEnabled = False
            Me.cbxCODIGO_DEPARTAMENTO.ClientEnabled = False
            Me.cbxCODIGO_MUNICIPIO.ClientEnabled = False
            Me.txtNO_CONVOCATORIA.ClientEnabled = False
            Me.CargarDatos()
            Return
        Else
            Me.LimpiarControles()
            Me.Nuevo()
        End If
        Me.HabilitarEdicion(Me._Enabled)
    End Sub

    Private _ID_FUENTE As Decimal
    Public Property ID_FUENTE() As Decimal
        Get
            Return _ID_FUENTE
        End Get
        Set(ByVal Value As Decimal)
            Me._ID_FUENTE = Value
        End Set
    End Property

    Private _NO_CONVOCATORIA As Decimal
    Public Property NO_CONVOCATORIA() As Decimal
        Get
            Return _NO_CONVOCATORIA
        End Get
        Set(ByVal Value As Decimal)
            Me._NO_CONVOCATORIA = Value
        End Set
    End Property

    Private _CODIGO_DEPARTAMENTO As String
    Public Property CODIGO_DEPARTAMENTO() As String
        Get
            Return _CODIGO_DEPARTAMENTO
        End Get
        Set(ByVal Value As String)
            Me._CODIGO_DEPARTAMENTO = Value
        End Set
    End Property

    Private _CODIGO_MUNICIPIO As String
    Public Property CODIGO_MUNICIPIO() As String
        Get
            Return _CODIGO_MUNICIPIO
        End Get
        Set(ByVal Value As String)
            Me._CODIGO_MUNICIPIO = Value
        End Set
    End Property

    Public Property APORTE_FISDL() As Decimal
        Get
            If Me.txtAporteFISDL.Value Is Nothing Then Return -1
            Return Me.txtAporteFISDL.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtAporteFISDL.Value = value
        End Set
    End Property

    Public Property MONTO_LIQUIDADO() As Decimal
        Get
            If Me.txtMontoLiquidado.Value Is Nothing Then Return -1
            Return Me.txtMontoLiquidado.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtMontoLiquidado.Value = value
        End Set
    End Property

    Public Property ASESOR_MUNICIPAL() As String
        Get
            Return Me.txtAsesorMunicipal.Text
        End Get
        Set(ByVal value As String)
            Me.txtAsesorMunicipal.Text = value.ToString()
        End Set
    End Property

    Public Property CODIGO_PROYECTO() As String
        Get
            Return Me.txtCodigoProyecto.Text
        End Get
        Set(ByVal value As String)
            Me.txtCodigoProyecto.Text = value.ToString()
        End Set
    End Property

    Public Property NOMBRE_PROYECTO() As String
        Get
            Return Me.txtNombreProyecto.Text
        End Get
        Set(ByVal value As String)
            Me.txtNombreProyecto.Text = value.ToString()
        End Set
    End Property

    Public Property USERID() As String
        Get
            Return Me.txtUserId.Text
        End Get
        Set(ByVal value As String)
            Me.txtUserId.Text = value.ToString()
        End Set
    End Property

    Public Property LASTUPDATE() As DateTime
        Get
            Return Me.dteLastUpdate.Value
        End Get
        Set(ByVal value As DateTime)
            Me.dteLastUpdate.Value = value
        End Set
    End Property

    Public Property VerNO_CONVOCATORIA() As Boolean
        Get
            Return Me.txtNO_CONVOCATORIA.ClientVisible
        End Get
        Set(ByVal value As Boolean)
            Me.lblConvocatoria.ClientVisible = value
            Me.txtNO_CONVOCATORIA.ClientVisible = value
        End Set
    End Property

    Public Property VerCODIGO_DEPARTAMENTO() As Boolean
        Get
            Return Me.cbxCODIGO_DEPARTAMENTO.ClientVisible
        End Get
        Set(ByVal value As Boolean)
            Me.lblDepartamento.ClientVisible = value
            Me.cbxCODIGO_DEPARTAMENTO.ClientVisible = value
        End Set
    End Property

    Public Property VerCODIGO_MUNICIPIO() As Boolean
        Get
            Return Me.cbxCODIGO_MUNICIPIO.ClientVisible
        End Get
        Set(ByVal value As Boolean)
            Me.lblMunicipio.ClientVisible = value
            Me.cbxCODIGO_MUNICIPIO.ClientVisible = value
        End Set
    End Property

    Public Property VerAPORTE_FISDL() As Boolean
        Get
            Return Me.txtAporteFISDL.ClientVisible
        End Get
        Set(ByVal value As Boolean)
            Me.lblAporteFISDL.ClientVisible = value
            Me.txtAporteFISDL.ClientVisible = value
        End Set
    End Property

    Public Property VerMONTO_LIQUIDADO() As Boolean
        Get
            Return Me.txtMontoLiquidado.ClientVisible
        End Get
        Set(ByVal value As Boolean)
            Me.lblMontoLiquidado.ClientVisible = value
            Me.txtMontoLiquidado.ClientVisible = value
        End Set
    End Property

    Public Property VerASESOR_MUNICIPAL() As Boolean
        Get
            Return Me.txtAsesorMunicipal.ClientVisible
        End Get
        Set(ByVal value As Boolean)
            Me.lblAsesorMunicipal.ClientVisible = value
            Me.txtAsesorMunicipal.ClientVisible = value
        End Set
    End Property

    Public Property VerCODIGO_PROYECTO() As Boolean
        Get
            Return Me.txtCodigoProyecto.ClientVisible
        End Get
        Set(ByVal value As Boolean)
            Me.lblCodigoProyecto.ClientVisible = value
            Me.txtCodigoProyecto.ClientVisible = value
        End Set
    End Property

    Public Property VerNOMBRE_PROYECTO() As Boolean
        Get
            Return Me.txtNombreProyecto.ClientVisible
        End Get
        Set(ByVal value As Boolean)
            Me.lblNombreProyecto.ClientVisible = value
            Me.txtNombreProyecto.ClientVisible = value
        End Set
    End Property

    Public Property VerUSERID() As Boolean
        Get
            Return Me.txtUserId.ClientVisible
        End Get
        Set(ByVal value As Boolean)
            Me.lblUserId.ClientVisible = value
            Me.txtUserId.ClientVisible = value
        End Set
    End Property

    Public Property VerNUMERO_CHEQUE_REINTEGRO() As Boolean
        Get
            Return Me.txtNumeroChequeReintegro.ClientVisible
        End Get
        Set(ByVal value As Boolean)
            Me.lblNumeroChequeReintegro.ClientVisible = value
            Me.txtNumeroChequeReintegro.ClientVisible = value
        End Set
    End Property

    Public Property VerFECHA_CHEQUE_REINTEGRO() As Boolean
        Get
            Return Me.dteFechaChequeReint.ClientVisible
        End Get
        Set(ByVal value As Boolean)
            Me.lblFechaChequeReintegro.ClientVisible = value
            Me.dteFechaChequeReint.ClientVisible = value
        End Set
    End Property

    Public Property VerLASTUPDATE() As Boolean
        Get
            Return Me.trLASTUPDATE.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trLASTUPDATE.Visible = value
        End Set
    End Property

    Private _Enabled As Boolean = True
    Private _sError As String
    Private _nuevo As Boolean = False
    Private mComponente As New cMUNICIPIO_CONVOCATORIA
    Private mEntidad As MUNICIPIO_CONVOCATORIA
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

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Load
        If Not IsPostBack Then
            hfucVistaDetalleMUNICIPIO_CONVOCATORIA.Clear()
            hfucVistaDetalleMUNICIPIO_CONVOCATORIA.Add("nuevo", True)
            CargarFuente()
        End If
    End Sub

    Private Sub Inicializar()
        If cbxID_FUENTE.Value = 1 Then
            Me.txtNO_CONVOCATORIA.Value = AppSettings("PATI_BM_CONVOCATORIA")
        Else
            Me.txtNO_CONVOCATORIA.Value = AppSettings("PATI_USAID_CONVOCATORIA")
        End If
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información del registro de la tabla MUNICIPIO_CONVOCATORIA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	10/09/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()
        hfucVistaDetalleMUNICIPIO_CONVOCATORIA("nuevo") = False
        Dim sError As New String("")
        mEntidad = New MUNICIPIO_CONVOCATORIA
        mEntidad = mComponente.ObtenerMUNICIPIO_CONVOCATORIA(ID_FUENTE, NO_CONVOCATORIA, CODIGO_DEPARTAMENTO, CODIGO_MUNICIPIO)

        If mEntidad Is Nothing Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Dim lEntidadFuente As FUENTE_FINANCIAMIENTO
        Dim lListaFaseMunicipios As listaFASE_MUNICIPIOS = (New cFASE_MUNICIPIOS).ObtenerListaPorMUNICIPIO(CODIGO_DEPARTAMENTO, CODIGO_MUNICIPIO)
        If lListaFaseMunicipios Is Nothing OrElse lListaFaseMunicipios.Count = 0 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        lEntidadFuente = (New cFUENTE_FINANCIAMIENTO).ObtenerFUENTE_FINANCIAMIENTO(lListaFaseMunicipios(0).ID_FUENTE)
        Dim lEntidadDepartamento As DEPARTAMENTO = (New cDEPARTAMENTO).ObtenerDEPARTAMENTO(CODIGO_DEPARTAMENTO)
        Dim lEntidadMunicipio As MUNICIPIO = (New cMUNICIPIO).ObtenerMUNICIPIO(CODIGO_DEPARTAMENTO, CODIGO_MUNICIPIO)
        Me.cbxID_FUENTE.Items.Add(lEntidadFuente.NOMBRE_FUENTE, lEntidadFuente.ID_FUENTE).Selected = True
        Me.cbxCODIGO_DEPARTAMENTO.Items.Add(lEntidadDepartamento.NOMBRE, lEntidadDepartamento.CODIGO_DEPARTAMENTO).Selected = True
        Me.cbxCODIGO_MUNICIPIO.Items.Add(lEntidadMunicipio.NOMBRE, lEntidadMunicipio.CODIGO_DEPARTAMENTO).Selected = True
        Me.txtNO_CONVOCATORIA.Value = mEntidad.NO_CONVOCATORIA
        Me.txtAporteFISDL.Value = mEntidad.APORTE_FISDL
        Me.txtMontoLiquidado.Value = mEntidad.MONTO_LIQUIDADO
        Me.txtAsesorMunicipal.Text = mEntidad.ASESOR_MUNICIPAL
        Me.txtCodigoProyecto.Text = mEntidad.CODIGO_PROYECTO
        Me.txtNombreProyecto.Text = mEntidad.NOMBRE_PROYECTO
        Me.txtNumeroChequeReintegro.Text = mEntidad.NUMERO_CHEQUE_REINTEGRO
        If mEntidad.FECHA_CHEQUE_REINTEGRO <> #12:00:00 AM# Then
            Me.dteFechaChequeReint.Date = mEntidad.FECHA_CHEQUE_REINTEGRO
        End If
        Me.txtUserId.Text = mEntidad.USERID
        Me.dteLastUpdate.Value = mEntidad.LASTUPDATE
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que permite Habilitar/Deshabilitar el uso de los controles contenidos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	10/09/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.txtAporteFISDL.ClientEnabled = edicion
        Me.txtMontoLiquidado.ClientEnabled = False
        Me.txtAsesorMunicipal.ClientEnabled = edicion
        Me.txtCodigoProyecto.ClientEnabled = edicion
        Me.txtNombreProyecto.ClientEnabled = edicion
        Me.txtNumeroChequeReintegro.ClientEnabled = edicion
        Me.dteFechaChequeReint.ClientEnabled = edicion
        Me.txtUserId.ClientEnabled = False
        Me.dteLastUpdate.ClientEnabled = False
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Configura si es un registro nuevo el cargado
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	10/09/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub Nuevo()
        Me._nuevo = True
        hfucVistaDetalleMUNICIPIO_CONVOCATORIA("nuevo") = True
        Me.txtAporteFISDL.Value = 0
        Me.txtMontoLiquidado.Value = 0
        Me.txtAsesorMunicipal.Text = ""
        Me.txtCodigoProyecto.Text = ""
        Me.txtNombreProyecto.Text = ""
        Me.txtNumeroChequeReintegro.Text = ""
        Me.dteFechaChequeReint.Text = ""
        Me.txtUserId.Text = Me.ObtenerUsuario()
        Me.dteLastUpdate.Value = Now
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Guarda la información del registro en la tabla MUNICIPIO_CONVOCATORIA
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	10/09/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim sError As New String("")
        Dim alDatos As New ArrayList
        Dim lEntidadDepto As DEPARTAMENTO
        Dim lEntidadMunic As MUNICIPIO

        lEntidadDepto = (New cDEPARTAMENTO).ObtenerDEPARTAMENTO(Me.cbxCODIGO_DEPARTAMENTO.Value)
        If lEntidadDepto Is Nothing Then Return "Error al Guardar registro."
        lEntidadMunic = (New cMUNICIPIO).ObtenerMUNICIPIOPorNOMBRE(lEntidadDepto.CODIGO_DEPARTAMENTO, Me.cbxCODIGO_MUNICIPIO.Text)
        If lEntidadMunic Is Nothing Then Return "Error al Guardar registro."

        mEntidad = mComponente.ObtenerMUNICIPIO_CONVOCATORIA(Me.cbxID_FUENTE.Value, Me.txtNO_CONVOCATORIA.Value, lEntidadMunic.CODIGO_DEPARTAMENTO, lEntidadMunic.CODIGO_MUNICIPIO)
        If hfucVistaDetalleMUNICIPIO_CONVOCATORIA("nuevo") Then
            'Verificar que no exista la Convocatoria para el Municipio Actual
            If mEntidad IsNot Nothing Then Return "Error al Guardar registro. La Convocatoria ya esta Registrada para este Municipio."
            If mComponente.AgregarMUNICIPIO_CONVOCATORIA(Me.txtNO_CONVOCATORIA.Value, _
                                                        lEntidadMunic.CODIGO_DEPARTAMENTO, _
                                                        lEntidadMunic.CODIGO_MUNICIPIO, _
                                                        CDec(Me.txtAporteFISDL.Value), 0, Me.txtAsesorMunicipal.Text.Trim, _
                                                        Me.txtCodigoProyecto.Value, Me.txtNombreProyecto.Text.Trim.ToUpper, Me.txtNumeroChequeReintegro.Text, Me.dteFechaChequeReint.Date, Me.ObtenerUsuario, Now, cbxID_FUENTE.Value) <> 1 Then
                Me.AsignarMensaje("Error al Guardar registro.", True, True)
                Return "Error al Guardar registro."
            End If
        Else
            mEntidad.ID_FUENTE = Me.cbxID_FUENTE.Value
            mEntidad.APORTE_FISDL = CDec(Me.txtAporteFISDL.Value)
            mEntidad.ASESOR_MUNICIPAL = Me.txtAsesorMunicipal.Text.Trim
            mEntidad.CODIGO_PROYECTO = Me.txtCodigoProyecto.Text
            mEntidad.NOMBRE_PROYECTO = Me.txtNombreProyecto.Text.Trim.ToUpper
            mEntidad.NUMERO_CHEQUE_REINTEGRO = Me.txtNumeroChequeReintegro.Text.Trim
            mEntidad.FECHA_CHEQUE_REINTEGRO = Me.dteFechaChequeReint.Date
            mEntidad.USERID = Me.ObtenerUsuario()
            mEntidad.LASTUPDATE = Now
            If mComponente.ActualizarMUNICIPIO_CONVOCATORIA(mEntidad) <> 1 Then
                Me.AsignarMensaje("Error al Guardar registro.", True, True)
                Return "Error al Guardar registro."
            End If
        End If
        hfucVistaDetalleMUNICIPIO_CONVOCATORIA("nuevo") = False
        Return ""
    End Function

    Private Sub CargarDepartamentos(ByVal IdFuente As Decimal)
        Me.odsDepartamento.SelectParameters("ID_FUENTE").DefaultValue = IdFuente
        Me.odsDepartamento.DataBind()
        Me.cbxCODIGO_DEPARTAMENTO.DataBind()
    End Sub

    Private Sub CargarFuente()
        Me.odsFuente.DataBind()
        Me.cbxID_FUENTE.DataBind()
        Me.cbxID_FUENTE.SelectedIndex = 0
    End Sub

    Private Sub CargarMunicipios(ByVal IdFuente As Decimal, ByVal CodigoDepartamento As String)
        Me.odsMunicipio.SelectParameters("ID_FUENTE").DefaultValue = IdFuente
        Me.odsMunicipio.SelectParameters("CODIGO_DEPARTAMENTO").DefaultValue = CodigoDepartamento
        Me.odsMunicipio.DataBind()
        Me.cbxCODIGO_MUNICIPIO.DataBind()
    End Sub

    Protected Sub cbxCODIGO_DEPARTAMENTO_Callback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxClasses.CallbackEventArgsBase) Handles cbxCODIGO_DEPARTAMENTO.Callback
        CargarDepartamentos(CDec(e.Parameter))
    End Sub

    Protected Sub cbxCODIGO_MUNICIPIO_Callback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxClasses.CallbackEventArgsBase) Handles cbxCODIGO_MUNICIPIO.Callback
        Dim parametros() As String = e.Parameter.Split(";")
        CargarMunicipios(CDec(parametros(0)), parametros(1))
    End Sub
End Class
