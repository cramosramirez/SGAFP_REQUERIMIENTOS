Imports SGAFP.BL
Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucVistaDetalleINFORME_FINAL_AF_HIS
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla INFORME_FINAL_AF_HIS
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	20/07/2012	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleINFORME_FINAL_AF_HIS
    Inherits ucBase
 
#Region"Propiedades"

    Private _ID_INFORME_FINAL_HIS As Decimal
    Public Property ID_INFORME_FINAL_HIS() As Decimal
        Get
            Return Me.txtID_INFORME_FINAL_HIS.Text
        End Get
        Set(ByVal Value As Decimal)
            Me._ID_INFORME_FINAL_HIS = Value
            Me.txtID_INFORME_FINAL_HIS.Text = CStr(Value)
            If Me._ID_INFORME_FINAL_HIS > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Property ID_INFORME_FINAL() As Decimal
        Get
            Return Me.cbxINFORME_FINAL_AFID_INFORME_FINAL.Value
        End Get
        Set(ByVal value As Decimal)
            If Not Me.cbxINFORME_FINAL_AFID_INFORME_FINAL.Items.FindByValue(value) Is Nothing Then
                Me.cbxINFORME_FINAL_AFID_INFORME_FINAL.Value = CInt(value)
            End If
        End Set
    End Property

    Public Property ID_ACCION_FORMATIVA() As Decimal
        Get
            Return Me.cbxACCION_FORMATIVAID_ACCION_FORMATIVA.Value
        End Get
        Set(ByVal value As Decimal)
            If Not Me.cbxACCION_FORMATIVAID_ACCION_FORMATIVA.Items.FindByValue(value) Is Nothing Then
                Me.cbxACCION_FORMATIVAID_ACCION_FORMATIVA.Value = CInt(value)
            End If
        End Set
    End Property

    Public Property ID_PROVEEDOR_AF() As Decimal
        Get
            Return Me.cbxPROVEEDOR_AFID_PROVEEDOR_AF.Value
        End Get
        Set(ByVal value As Decimal)
            If Not Me.cbxPROVEEDOR_AFID_PROVEEDOR_AF.Items.FindByValue(value) Is Nothing Then
                Me.cbxPROVEEDOR_AFID_PROVEEDOR_AF.Value = CInt(value)
            End If
        End Set
    End Property

    Public Property FECHA_INFORME() As DateTime
        Get
            Return Me.deFECHA_INFORME.Value
        End Get
        Set(ByVal value As DateTime)
            Me.deFECHA_INFORME.Value = value
        End Set
    End Property

    Public Property NUMERO_FACTURA() As String
        Get
            Return Me.txtNUMERO_FACTURA.Text
        End Get
        Set(ByVal value As String)
            Me.txtNUMERO_FACTURA.Text = value.ToString()
        End Set
    End Property

    Public Property ELABORADO_POR() As String
        Get
            Return Me.txtELABORADO_POR.Text
        End Get
        Set(ByVal value As String)
            Me.txtELABORADO_POR.Text = value.ToString()
        End Set
    End Property

    Public Property MONTO_FACTURA() As Decimal
        Get
            If Me.txtMONTO_FACTURA.Value Is Nothing Then Return -1
            Return Me.txtMONTO_FACTURA.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtMONTO_FACTURA.Value = value
        End Set
    End Property

    Public Property MONTO_APROBADO() As Decimal
        Get
            If Me.txtMONTO_APROBADO.Value Is Nothing Then Return -1
            Return Me.txtMONTO_APROBADO.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtMONTO_APROBADO.Value = value
        End Set
    End Property

    Public Property PARTICIPANTES_INSCRITOS() As Decimal
        Get
            If Me.txtPARTICIPANTES_INSCRITOS.Value Is Nothing Then Return -1
            Return Me.txtPARTICIPANTES_INSCRITOS.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtPARTICIPANTES_INSCRITOS.Value = value
        End Set
    End Property

    Public Property PARTICIPANTES_FINALES() As Decimal
        Get
            If Me.txtPARTICIPANTES_FINALES.Value Is Nothing Then Return -1
            Return Me.txtPARTICIPANTES_FINALES.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtPARTICIPANTES_FINALES.Value = value
        End Set
    End Property

    Public Property PORC_PROM_ASISTENCIA() As Decimal
        Get
            If Me.txtPORC_PROM_ASISTENCIA.Value Is Nothing Then Return -1
            Return Me.txtPORC_PROM_ASISTENCIA.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtPORC_PROM_ASISTENCIA.Value = value
        End Set
    End Property

    Public Property NOTA_PROMEDIO() As Decimal
        Get
            If Me.txtNOTA_PROMEDIO.Value Is Nothing Then Return -1
            Return Me.txtNOTA_PROMEDIO.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtNOTA_PROMEDIO.Value = value
        End Set
    End Property

    Public Property COMENTARIOS() As String
        Get
            Return Me.txtCOMENTARIOS.Text
        End Get
        Set(ByVal value As String)
            Me.txtCOMENTARIOS.Text = value.ToString()
        End Set
    End Property

    Public Property USUARIO_APROBACION() As String
        Get
            Return Me.txtUSUARIO_APROBACION.Text
        End Get
        Set(ByVal value As String)
            Me.txtUSUARIO_APROBACION.Text = value.ToString()
        End Set
    End Property

    Public Property LASTUPDATE() As DateTime
        Get
            Return Me.deLASTUPDATE.Value
        End Get
        Set(ByVal value As DateTime)
            Me.deLASTUPDATE.Value = value
        End Set
    End Property

    Public Property USERID() As String
        Get
            Return Me.txtUSERID.Text
        End Get
        Set(ByVal value As String)
            Me.txtUSERID.Text = value.ToString()
        End Set
    End Property

    Public Property ID_ESTADO_INFORME() As Decimal
        Get
            Return Me.cbxESTADO_INFORME_AFID_ESTADO_INFORME.Value
        End Get
        Set(ByVal value As Decimal)
            If Not Me.cbxESTADO_INFORME_AFID_ESTADO_INFORME.Items.FindByValue(value) Is Nothing Then
                Me.cbxESTADO_INFORME_AFID_ESTADO_INFORME.Value = CInt(value)
            End If
        End Set
    End Property

    Public Property HORAS_DESARROLLADAS() As Decimal
        Get
            If Me.txtHORAS_DESARROLLADAS.Value Is Nothing Then Return -1
            Return Me.txtHORAS_DESARROLLADAS.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtHORAS_DESARROLLADAS.Value = value
        End Set
    End Property

    Public Property FECHA_INICIAL() As DateTime
        Get
            Return Me.deFECHA_INICIAL.Value
        End Get
        Set(ByVal value As DateTime)
            Me.deFECHA_INICIAL.Value = value
        End Set
    End Property

    Public Property FECHA_FINAL() As DateTime
        Get
            Return Me.deFECHA_FINAL.Value
        End Get
        Set(ByVal value As DateTime)
            Me.deFECHA_FINAL.Value = value
        End Set
    End Property

    Public Property VerID_INFORME_FINAL_HIS() As Boolean
        Get
            Return Me.trID_INFORME_FINAL_HIS.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_INFORME_FINAL_HIS.Visible = value
        End Set
    End Property

    Public Property VerID_INFORME_FINAL() As Boolean
        Get
            Return Me.trID_INFORME_FINAL.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_INFORME_FINAL.Visible = value
        End Set
    End Property

    Public Property VerID_ACCION_FORMATIVA() As Boolean
        Get
            Return Me.trID_ACCION_FORMATIVA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_ACCION_FORMATIVA.Visible = value
        End Set
    End Property

    Public Property VerID_PROVEEDOR_AF() As Boolean
        Get
            Return Me.trID_PROVEEDOR_AF.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_PROVEEDOR_AF.Visible = value
        End Set
    End Property

    Public Property VerFECHA_INFORME() As Boolean
        Get
            Return Me.trFECHA_INFORME.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trFECHA_INFORME.Visible = value
        End Set
    End Property

    Public Property VerNUMERO_FACTURA() As Boolean
        Get
            Return Me.trNUMERO_FACTURA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trNUMERO_FACTURA.Visible = value
        End Set
    End Property

    Public Property VerELABORADO_POR() As Boolean
        Get
            Return Me.trELABORADO_POR.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trELABORADO_POR.Visible = value
        End Set
    End Property

    Public Property VerMONTO_FACTURA() As Boolean
        Get
            Return Me.trMONTO_FACTURA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trMONTO_FACTURA.Visible = value
        End Set
    End Property

    Public Property VerMONTO_APROBADO() As Boolean
        Get
            Return Me.trMONTO_APROBADO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trMONTO_APROBADO.Visible = value
        End Set
    End Property

    Public Property VerPARTICIPANTES_INSCRITOS() As Boolean
        Get
            Return Me.trPARTICIPANTES_INSCRITOS.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trPARTICIPANTES_INSCRITOS.Visible = value
        End Set
    End Property

    Public Property VerPARTICIPANTES_FINALES() As Boolean
        Get
            Return Me.trPARTICIPANTES_FINALES.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trPARTICIPANTES_FINALES.Visible = value
        End Set
    End Property

    Public Property VerPORC_PROM_ASISTENCIA() As Boolean
        Get
            Return Me.trPORC_PROM_ASISTENCIA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trPORC_PROM_ASISTENCIA.Visible = value
        End Set
    End Property

    Public Property VerNOTA_PROMEDIO() As Boolean
        Get
            Return Me.trNOTA_PROMEDIO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trNOTA_PROMEDIO.Visible = value
        End Set
    End Property

    Public Property VerCOMENTARIOS() As Boolean
        Get
            Return Me.trCOMENTARIOS.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trCOMENTARIOS.Visible = value
        End Set
    End Property

    Public Property VerUSUARIO_APROBACION() As Boolean
        Get
            Return Me.trUSUARIO_APROBACION.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trUSUARIO_APROBACION.Visible = value
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

    Public Property VerUSERID() As Boolean
        Get
            Return Me.trUSERID.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trUSERID.Visible = value
        End Set
    End Property

    Public Property VerID_ESTADO_INFORME() As Boolean
        Get
            Return Me.trID_ESTADO_INFORME.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_ESTADO_INFORME.Visible = value
        End Set
    End Property

    Public Property VerHORAS_DESARROLLADAS() As Boolean
        Get
            Return Me.trHORAS_DESARROLLADAS.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trHORAS_DESARROLLADAS.Visible = value
        End Set
    End Property

    Public Property VerFECHA_INICIAL() As Boolean
        Get
            Return Me.trFECHA_INICIAL.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trFECHA_INICIAL.Visible = value
        End Set
    End Property

    Public Property VerFECHA_FINAL() As Boolean
        Get
            Return Me.trFECHA_FINAL.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trFECHA_FINAL.Visible = value
        End Set
    End Property

    Private _Enabled As Boolean = True
    Private _sError As String
    Private _nuevo As Boolean = False
    Private mComponente As New cINFORME_FINAL_AF_HIS
    Private mEntidad As INFORME_FINAL_AF_HIS
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
        If Not Me.ViewState("ID_INFORME_FINAL_HIS") Is Nothing Then Me._ID_INFORME_FINAL_HIS = Me.ViewState("ID_INFORME_FINAL_HIS")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información del registro de la tabla INFORME_FINAL_AF_HIS
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	20/07/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()

        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")
        mEntidad = New INFORME_FINAL_AF_HIS
        mEntidad.ID_INFORME_FINAL_HIS = ID_INFORME_FINAL_HIS
 
        If mComponente.ObtenerINFORME_FINAL_AF_HIS(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtID_INFORME_FINAL_HIS.Text = mEntidad.ID_INFORME_FINAL_HIS.ToString()
        Me.cbxINFORME_FINAL_AFID_INFORME_FINAL.DataBind()
        Me.cbxINFORME_FINAL_AFID_INFORME_FINAL.Value = CInt(mEntidad.ID_INFORME_FINAL)
        Me.cbxACCION_FORMATIVAID_ACCION_FORMATIVA.DataBind()
        Me.cbxACCION_FORMATIVAID_ACCION_FORMATIVA.Value = CInt(mEntidad.ID_ACCION_FORMATIVA)
        Me.cbxPROVEEDOR_AFID_PROVEEDOR_AF.DataBind()
        Me.cbxPROVEEDOR_AFID_PROVEEDOR_AF.Value = CInt(mEntidad.ID_PROVEEDOR_AF)
        Me.deFECHA_INFORME.Value = mEntidad.FECHA_INFORME
        Me.txtNUMERO_FACTURA.Text = mEntidad.NUMERO_FACTURA
        Me.txtELABORADO_POR.Text = mEntidad.ELABORADO_POR
        Me.txtMONTO_FACTURA.Value = mEntidad.MONTO_FACTURA
        Me.txtMONTO_APROBADO.Value = mEntidad.MONTO_APROBADO
        Me.txtPARTICIPANTES_INSCRITOS.Value = mEntidad.PARTICIPANTES_INSCRITOS
        Me.txtPARTICIPANTES_FINALES.Value = mEntidad.PARTICIPANTES_FINALES
        Me.txtPORC_PROM_ASISTENCIA.Value = mEntidad.PORC_PROM_ASISTENCIA
        Me.txtNOTA_PROMEDIO.Value = mEntidad.NOTA_PROMEDIO
        Me.txtCOMENTARIOS.Text = mEntidad.COMENTARIOS
        Me.txtUSUARIO_APROBACION.Text = mEntidad.USUARIO_APROBACION
        Me.deLASTUPDATE.Value = mEntidad.LASTUPDATE
        Me.txtUSERID.Text = mEntidad.USERID
        Me.cbxESTADO_INFORME_AFID_ESTADO_INFORME.DataBind()
        Me.cbxESTADO_INFORME_AFID_ESTADO_INFORME.Value = CInt(mEntidad.ID_ESTADO_INFORME)
        Me.txtHORAS_DESARROLLADAS.Value = mEntidad.HORAS_DESARROLLADAS
        Me.deFECHA_INICIAL.Value = mEntidad.FECHA_INICIAL
        Me.deFECHA_FINAL.Value = mEntidad.FECHA_FINAL
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que permite Habilitar/Deshabilitar el uso de los controles contenidos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	20/07/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.cbxINFORME_FINAL_AFID_INFORME_FINAL.Enabled = edicion
        Me.cbxACCION_FORMATIVAID_ACCION_FORMATIVA.Enabled = edicion
        Me.cbxPROVEEDOR_AFID_PROVEEDOR_AF.Enabled = edicion
        Me.cbxESTADO_INFORME_AFID_ESTADO_INFORME.Enabled = edicion
        Me.deFECHA_INFORME.Enabled = edicion
        Me.txtNUMERO_FACTURA.Enabled = edicion
        Me.txtELABORADO_POR.Enabled = edicion
        Me.txtMONTO_FACTURA.Enabled = edicion
        Me.txtMONTO_APROBADO.Enabled = edicion
        Me.txtPARTICIPANTES_INSCRITOS.Enabled = edicion
        Me.txtPARTICIPANTES_FINALES.Enabled = edicion
        Me.txtPORC_PROM_ASISTENCIA.Enabled = edicion
        Me.txtNOTA_PROMEDIO.Enabled = edicion
        Me.txtCOMENTARIOS.Enabled = edicion
        Me.txtUSUARIO_APROBACION.Enabled = edicion
        Me.deLASTUPDATE.Enabled = False
        Me.txtUSERID.Enabled = False
        Me.txtHORAS_DESARROLLADAS.Enabled = edicion
        Me.deFECHA_INICIAL.Enabled = edicion
        Me.deFECHA_FINAL.Enabled = edicion
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Configura si es un registro nuevo el cargado
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	20/07/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub Nuevo()
        Me._nuevo = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Me.cbxINFORME_FINAL_AFID_INFORME_FINAL.DataBind()
        Me.cbxACCION_FORMATIVAID_ACCION_FORMATIVA.DataBind()
        Me.cbxPROVEEDOR_AFID_PROVEEDOR_AF.DataBind()
        Me.cbxESTADO_INFORME_AFID_ESTADO_INFORME.DataBind()
        Me.deFECHA_INFORME.Value = Nothing
        Me.txtNUMERO_FACTURA.Text = ""
        Me.txtELABORADO_POR.Text = ""
        Me.txtMONTO_FACTURA.Value = Nothing
        Me.txtMONTO_APROBADO.Value = Nothing
        Me.txtPARTICIPANTES_INSCRITOS.Value = Nothing
        Me.txtPARTICIPANTES_FINALES.Value = Nothing
        Me.txtPORC_PROM_ASISTENCIA.Value = Nothing
        Me.txtNOTA_PROMEDIO.Value = Nothing
        Me.txtCOMENTARIOS.Text = ""
        Me.txtUSUARIO_APROBACION.Text = ""
        Me.deLASTUPDATE.Value = Now
        Me.txtUSERID.Text = Me.ObtenerUsuario()
        Me.txtHORAS_DESARROLLADAS.Value = Nothing
        Me.deFECHA_INICIAL.Value = Nothing
        Me.deFECHA_FINAL.Value = Nothing
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Guarda la información del registro en la tabla INFORME_FINAL_AF_HIS
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	20/07/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim sError As New String("")
        Dim alDatos As New ArrayList
        mEntidad = New INFORME_FINAL_AF_HIS
        If Me._nuevo Then
            mEntidad.ID_INFORME_FINAL_HIS = 0
        Else
            mEntidad.ID_INFORME_FINAL_HIS = CInt(Me.txtID_INFORME_FINAL_HIS.Text)
        End If
        mEntidad.ID_INFORME_FINAL = Me.cbxINFORME_FINAL_AFID_INFORME_FINAL.Value
        mEntidad.ID_ACCION_FORMATIVA = Me.cbxACCION_FORMATIVAID_ACCION_FORMATIVA.Value
        mEntidad.ID_PROVEEDOR_AF = Me.cbxPROVEEDOR_AFID_PROVEEDOR_AF.Value
        mEntidad.FECHA_INFORME = Me.deFECHA_INFORME.Value
        mEntidad.NUMERO_FACTURA = Me.txtNUMERO_FACTURA.Text
        mEntidad.ELABORADO_POR = Me.txtELABORADO_POR.Text
        mEntidad.MONTO_FACTURA = Me.txtMONTO_FACTURA.Value
        mEntidad.MONTO_APROBADO = Me.txtMONTO_APROBADO.Value
        mEntidad.PARTICIPANTES_INSCRITOS = Me.txtPARTICIPANTES_INSCRITOS.Value
        mEntidad.PARTICIPANTES_FINALES = Me.txtPARTICIPANTES_FINALES.Value
        mEntidad.PORC_PROM_ASISTENCIA = Me.txtPORC_PROM_ASISTENCIA.Value
        mEntidad.NOTA_PROMEDIO = Me.txtNOTA_PROMEDIO.Value
        mEntidad.COMENTARIOS = Me.txtCOMENTARIOS.Text
        mEntidad.USUARIO_APROBACION = Me.txtUSUARIO_APROBACION.Text
        mEntidad.LASTUPDATE = Me.deLASTUPDATE.Value
        mEntidad.USERID = Me.ObtenerUsuario()
        mEntidad.ID_ESTADO_INFORME = Me.cbxESTADO_INFORME_AFID_ESTADO_INFORME.Value
        mEntidad.HORAS_DESARROLLADAS = Me.txtHORAS_DESARROLLADAS.Value
        mEntidad.FECHA_INICIAL = Me.deFECHA_INICIAL.Value
        mEntidad.FECHA_FINAL = Me.deFECHA_FINAL.Value

        If mComponente.ActualizarINFORME_FINAL_AF_HIS(mEntidad) <> 1 Then
            Me.AsignarMensaje("Error al Guardar registro.", True, True)
            Return "Error al Guardar registro."
        End If
        Me.txtID_INFORME_FINAL_HIS.Text = mEntidad.ID_INFORME_FINAL_HIS.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function
End Class
