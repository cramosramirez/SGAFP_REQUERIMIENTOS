Imports SGAFP.EL
Imports System.Web.Security.Membership
Imports SQLMembershipProvider.BL

''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucDetalleSOLICITUD_CAPACITACION
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	05/10/2012	Created
''' </history>
''' -----------------------------------------------------------------------------
Public Class ucDetalleSOLICITUD_CAPACITACION

    Private CambiandoPosicion As Boolean = False
    Private _SolicitudCapacitacion As New SOLICITUD_CAPACITACION
    Private _EsConsulta As Boolean = False

    <DefaultValue(False)> _
    Public Property EsConsulta() As Boolean
        Get
            Return Me._EsConsulta
        End Get
        Set(ByVal value As Boolean)
            Me._EsConsulta = value
            Me.HabilitarEdicion(Not value)
        End Set
    End Property

    Public Property SOLICITUD_CAPACITACION() As SOLICITUD_CAPACITACION
        Get
            Return _SolicitudCapacitacion
        End Get
        Set(ByVal value As SOLICITUD_CAPACITACION)
            _SolicitudCapacitacion = value
            Me.CargarDatos()
        End Set
    End Property

    Private Sub CargarDatos()
        Inicializar()
        If _SolicitudCapacitacion IsNot Nothing AndAlso _SolicitudCapacitacion.ID_SOLICITUD > 0 Then
            ID_SOLICITUDTextEdit.Text = _SolicitudCapacitacion.ID_SOLICITUD
            FECHA_SOLICITUDDateEdit.DateTime = _SolicitudCapacitacion.FECHA_SOLICITUD
            ID_UNIDAD_ORGANIZATIVAcbxUNIDAD_ORGANIZATIVA.SelectedValue = _SolicitudCapacitacion.ID_UNIDAD_ORGANIZATIVA
            CargarCentrosResponsabilidadEnUnidad(_SolicitudCapacitacion.ID_UNIDAD_ORGANIZATIVA)
            Dim lCentroResp As CENTRO_RESPONSABILIDAD
            lCentroResp = (New cCENTRO_RESPONSABILIDAD).ObtenerCENTRO_RESPONSABILIDAD(_SolicitudCapacitacion.ID_CENTRO_RESPONSABILIDAD)
            If lCentroResp IsNot Nothing Then
                Me.ID_CENTRO_RESPONSABILIDADcbxCENTRO_RESPONSABILIDAD.EditValue = lCentroResp.ID_CENTRO_RESPONSABILIDAD
            End If
            ID_PROGRAMA_FORMACIONcbxPROGRAMA_FORMACION.SelectedValue = _SolicitudCapacitacion.ID_PROGRAMA_FORMACION
            ID_PROYECTO_FORMACIONcbxPROYECTO_FORMACION.SelectedValue = _SolicitudCapacitacion.ID_PROYECTO_FORMACION
            ID_REFERENTEcbxREFERENTE.SelectedValue = _SolicitudCapacitacion.ID_REFERENTE
            TELEF1TextEdit.Text = _SolicitudCapacitacion.TELEF1
            TELEF2TextEdit.Text = _SolicitudCapacitacion.TELEF2
            TELEF3TextEdit.Text = _SolicitudCapacitacion.TELEF3
            TELEF_MOVILTextEdit.Text = _SolicitudCapacitacion.TELEF_MOVIL
            FAXTextEdit.Text = _SolicitudCapacitacion.FAX
            NOMBRES_CONTACTOTextEdit.Text = _SolicitudCapacitacion.NOMBRES_CONTACTO
            APELLIDOS_CONTACTOTextEdit.Text = _SolicitudCapacitacion.APELLIDOS_CONTACTO
            EMAIL_CONTACTOTextEdit.Text = _SolicitudCapacitacion.EMAIL_CONTACTO
            OBJETIVO_CAPACITACIONTextEdit.Text = _SolicitudCapacitacion.OBJETIVO_CAPACITACION
            HORARIOTextEdit.Text = _SolicitudCapacitacion.HORARIO
            USERIDTextEdit.Text = _SolicitudCapacitacion.USERID
            LASTUPDATEDateEdit.DateTime = _SolicitudCapacitacion.LASTUPDATE
            Me.txtPORC_PAGO_INFORME1.Text = _SolicitudCapacitacion.PORC_PAGO_INFORME1
        End If
    End Sub

    Public ReadOnly Property Current() As SOLICITUD_CAPACITACION
        Get
            Return CType(Me.ListaSOLICITUD_CAPACITACIONBindingSource.Current, SOLICITUD_CAPACITACION)
        End Get
    End Property

    Public Overrides Property DataSource() As System.Windows.Forms.BindingSource 
        Get 
            Return Me.ListaSOLICITUD_CAPACITACIONBindingSource 
        End Get 
        Set(ByVal value As System.Windows.Forms.BindingSource)
            Me.ListaSOLICITUD_CAPACITACIONBindingSource = value
        End Set
    End Property

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que sobreescribe y realiza la acción de Guardar en la Base de Datos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    '''     [cramos]	19/06/2013	Modificada: Se cambia la lógica del método actualizar sin utilizar BindingSource
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Actualizar() As Integer
        Dim mControl As New cSOLICITUD_CAPACITACION
        If FECHA_SOLICITUDDateEdit.DateTime = #12:00:00 AM# Then
            Me.AsignarMensaje("Ingrese la fecha de la solicitud", True)
            Return -1
        End If
        If ID_UNIDAD_ORGANIZATIVAcbxUNIDAD_ORGANIZATIVA.SelectedValue Is Nothing OrElse ID_UNIDAD_ORGANIZATIVAcbxUNIDAD_ORGANIZATIVA.SelectedValue = -1 Then
            Me.AsignarMensaje("Seleccione la Unidad Organizativa", True)
            Return -1
        End If
        If ID_CENTRO_RESPONSABILIDADcbxCENTRO_RESPONSABILIDAD.EditValue Is Nothing Then
            Me.AsignarMensaje("Seleccione el Centro de Responsabilidad", True)
            Return -1
        End If
        If Me.ID_PROGRAMA_FORMACIONcbxPROGRAMA_FORMACION.SelectedValue Is Nothing OrElse Me.ID_PROGRAMA_FORMACIONcbxPROGRAMA_FORMACION.SelectedValue = -1 Then
            Me.AsignarMensaje("Seleccione el Programa de Formación", True)
            Return -1
        End If
        If Me.ID_PROYECTO_FORMACIONcbxPROYECTO_FORMACION.SelectedValue Is Nothing OrElse Me.ID_PROYECTO_FORMACIONcbxPROYECTO_FORMACION.SelectedValue = -1 Then
            Me.AsignarMensaje("Seleccione el Proyecto de Formación", True)
            Return -1
        End If
        If Me.ID_REFERENTEcbxREFERENTE.SelectedValue Is Nothing OrElse Me.ID_REFERENTEcbxREFERENTE.SelectedValue = -1 Then
            Me.AsignarMensaje("Seleccione el Referente de la Capacitación", True)
            Return -1
        End If
        If TELEF1TextEdit.Text.TrimEnd = String.Empty Then
            Me.AsignarMensaje("Ingrese al menos el Telefono1", True)
            Return -1
        End If
        If NOMBRES_CONTACTOTextEdit.Text.TrimEnd = String.Empty Then
            Me.AsignarMensaje("Ingrese los Nombres del Contacto", True)
            Return -1
        End If
        If APELLIDOS_CONTACTOTextEdit.Text.TrimEnd = String.Empty Then
            Me.AsignarMensaje("Ingrese los Apellidos del Contacto", True)
            Return -1
        End If
        If EMAIL_CONTACTOTextEdit.Text.TrimEnd = String.Empty Then
            Me.AsignarMensaje("Ingrese el Correo del Contacto", True)
            Return -1
        End If
        If OBJETIVO_CAPACITACIONTextEdit.Text.TrimEnd = String.Empty Then
            Me.AsignarMensaje("Ingrese el Objetivo de la Capacitación", True)
            Return -1
        End If
        If HORARIOTextEdit.Text.TrimEnd = String.Empty Then
            Me.AsignarMensaje("Ingrese el Horario de la Capacitación", True)
            Return -1
        End If

        If IsNumeric(Me.txtPORC_PAGO_INFORME1.Text) Then
            If CDec(Me.txtPORC_PAGO_INFORME1.Text) <= 0 OrElse CDec(Me.txtPORC_PAGO_INFORME1.Text) > 1 Then
                Me.AsignarMensaje("El factor de pago del primer informe de ser mayor de cero y menor o igual a 1", True)
                Return -1
            End If
        Else
            If Me.txtPORC_PAGO_INFORME1.Text.Trim = "" Then
                Me.txtPORC_PAGO_INFORME1.Text = "1"
            Else
                Me.AsignarMensaje("Ingrese un factor valido", True)
                Return -1
            End If
        End If

        _SolicitudCapacitacion.FECHA_SOLICITUD = FECHA_SOLICITUDDateEdit.DateTime
        _SolicitudCapacitacion.ID_UNIDAD_ORGANIZATIVA = ID_UNIDAD_ORGANIZATIVAcbxUNIDAD_ORGANIZATIVA.SelectedValue
        _SolicitudCapacitacion.ID_CENTRO_RESPONSABILIDAD = ID_CENTRO_RESPONSABILIDADcbxCENTRO_RESPONSABILIDAD.EditValue
        _SolicitudCapacitacion.ID_PROGRAMA_FORMACION = ID_PROGRAMA_FORMACIONcbxPROGRAMA_FORMACION.SelectedValue
        _SolicitudCapacitacion.ID_PROYECTO_FORMACION = ID_PROYECTO_FORMACIONcbxPROYECTO_FORMACION.SelectedValue
        _SolicitudCapacitacion.ID_REFERENTE = ID_REFERENTEcbxREFERENTE.SelectedValue
        _SolicitudCapacitacion.TELEF1 = TELEF1TextEdit.EditValue
        _SolicitudCapacitacion.TELEF2 = TELEF2TextEdit.EditValue
        _SolicitudCapacitacion.TELEF3 = TELEF3TextEdit.EditValue
        _SolicitudCapacitacion.FAX = FAXTextEdit.EditValue
        _SolicitudCapacitacion.NOMBRES_CONTACTO = NOMBRES_CONTACTOTextEdit.Text.TrimEnd
        _SolicitudCapacitacion.APELLIDOS_CONTACTO = APELLIDOS_CONTACTOTextEdit.Text.TrimEnd
        _SolicitudCapacitacion.EMAIL_CONTACTO = EMAIL_CONTACTOTextEdit.Text.TrimEnd
        _SolicitudCapacitacion.OBJETIVO_CAPACITACION = OBJETIVO_CAPACITACIONTextEdit.Text.TrimEnd
        _SolicitudCapacitacion.HORARIO = HORARIOTextEdit.Text.TrimEnd
        _SolicitudCapacitacion.USERID = Utilerias.ObtenerUsuario
        _SolicitudCapacitacion.LASTUPDATE = Now
        _SolicitudCapacitacion.PORC_PAGO_INFORME1 = Convert.ToDecimal(Me.txtPORC_PAGO_INFORME1.Text)

        If mControl.ActualizarSOLICITUD_CAPACITACION(_SolicitudCapacitacion, TipoConcurrencia.Pesimistica) < 1 Then
            Me.AsignarMensaje(mControl.sError, True)
            Return -1
        End If
        Me.ID_SOLICITUDTextEdit.Text = _SolicitudCapacitacion.ID_SOLICITUD.ToString()
        Return 1
    End Function
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que permite Habilitar/Deshabilitar el uso de los controles contenidos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.ID_REFERENTEcbxREFERENTE.Enabled = edicion
        Me.ID_CENTRO_RESPONSABILIDADcbxCENTRO_RESPONSABILIDAD.Enabled = edicion
        Me.ID_UNIDAD_ORGANIZATIVAcbxUNIDAD_ORGANIZATIVA.Enabled = edicion
        Me.ID_PROGRAMA_FORMACIONcbxPROGRAMA_FORMACION.Enabled = edicion
        Me.ID_PROYECTO_FORMACIONcbxPROYECTO_FORMACION.Enabled = edicion
        Me.FECHA_SOLICITUDDateEdit.Enabled = edicion
        Me.OBJETIVO_CAPACITACIONTextEdit.Enabled = edicion
        Me.HORARIOTextEdit.Enabled = edicion
        Me.TELEF1TextEdit.Enabled = edicion
        Me.TELEF2TextEdit.Enabled = edicion
        Me.TELEF3TextEdit.Enabled = edicion
        Me.TELEF_MOVILTextEdit.Enabled = edicion
        Me.FAXTextEdit.Enabled = edicion
        Me.NOMBRES_CONTACTOTextEdit.Enabled = edicion
        Me.APELLIDOS_CONTACTOTextEdit.Enabled = edicion
        Me.EMAIL_CONTACTOTextEdit.Enabled = edicion
        Me.USERIDTextEdit.Enabled = edicion
        Me.LASTUPDATEDateEdit.Enabled = edicion
        Me.txtPORC_PAGO_INFORME1.Enabled = edicion
    End Sub

    Private Sub Inicializar()
        Dim c As cmembershipProvider
        c = CType(Provider, cmembershipProvider)

        ID_SOLICITUDTextEdit.Enabled = False
        ID_UNIDAD_ORGANIZATIVAcbxUNIDAD_ORGANIZATIVA.RecuperarPorProyectosEspeciales()
        ID_UNIDAD_ORGANIZATIVAcbxUNIDAD_ORGANIZATIVA.SelectedIndex = -1
        CargarCentrosResponsabilidadEnUnidad(-1)
        ID_PROGRAMA_FORMACIONcbxPROGRAMA_FORMACION.RecuperarPorRoles(c.ObtenerRoles(Utilerias.ObtenerUsuario))
        ID_PROGRAMA_FORMACIONcbxPROGRAMA_FORMACION.SelectedIndex = -1
        ID_PROYECTO_FORMACIONcbxPROYECTO_FORMACION.Recuperar()
        ID_PROYECTO_FORMACIONcbxPROYECTO_FORMACION.SelectedIndex = -1
        ID_REFERENTEcbxREFERENTE.Recuperar()
        ID_REFERENTEcbxREFERENTE.SelectedIndex = -1
        FECHA_SOLICITUDDateEdit.DateTime = Nothing
        OBJETIVO_CAPACITACIONTextEdit.Text = ""
        HORARIOTextEdit.Text = ""
        TELEF1TextEdit.Text = ""
        TELEF2TextEdit.Text = ""
        TELEF3TextEdit.Text = ""
        TELEF_MOVILTextEdit.Text = ""
        FAXTextEdit.Text = ""
        NOMBRES_CONTACTOTextEdit.Text = ""
        APELLIDOS_CONTACTOTextEdit.Text = ""
        EMAIL_CONTACTOTextEdit.Text = ""
        USERIDTextEdit.Text = ""
        LASTUPDATEDateEdit.DateTime = Now
        Me.txtPORC_PAGO_INFORME1.Text = "1"

        Me.USERIDLabelControl.Visible = False
        Me.LASTUPDATELabelControl.Visible = False
        Me.USERIDTextEdit.Visible = False
        Me.LASTUPDATEDateEdit.Visible = False
        Me.TELEF1TextEdit.Properties.Mask.EditMask = "####-####"
        Me.TELEF1TextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.TELEF1TextEdit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.TELEF1TextEdit.Properties.Mask.SaveLiteral = False
        Me.TELEF2TextEdit.Properties.Mask.EditMask = "####-####"
        Me.TELEF2TextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.TELEF2TextEdit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.TELEF2TextEdit.Properties.Mask.SaveLiteral = False
        Me.TELEF3TextEdit.Properties.Mask.EditMask = "####-####"
        Me.TELEF3TextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.TELEF3TextEdit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.TELEF3TextEdit.Properties.Mask.SaveLiteral = False
        Me.TELEF_MOVILTextEdit.Properties.Mask.EditMask = "####-####"
        Me.TELEF_MOVILTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.TELEF_MOVILTextEdit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.TELEF_MOVILTextEdit.Properties.Mask.SaveLiteral = False
        Me.FAXTextEdit.Properties.Mask.EditMask = "####-####"
        Me.FAXTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.FAXTextEdit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.FAXTextEdit.Properties.Mask.SaveLiteral = False
    End Sub

    Private Sub ID_UNIDAD_ORGANIZATIVAcbxUNIDAD_ORGANIZATIVA_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ID_UNIDAD_ORGANIZATIVAcbxUNIDAD_ORGANIZATIVA.SelectedValueChanged
        If ID_UNIDAD_ORGANIZATIVAcbxUNIDAD_ORGANIZATIVA.SelectedValue IsNot Nothing Then
            CargarCentrosResponsabilidadEnUnidad(ID_UNIDAD_ORGANIZATIVAcbxUNIDAD_ORGANIZATIVA.SelectedValue)
        End If
    End Sub

    Private Sub CargarCentrosResponsabilidadEnUnidad(ByVal idUnidadOrganizativa As Decimal)
        Dim listaCentrosResp As New listaCENTRO_RESPONSABILIDAD
        Dim listaUnidadesEnCentro As listaCENTRO_RESPONSABILIDAD_UNIDAD = (New cCENTRO_RESPONSABILIDAD_UNIDAD).ObtenerListaPorUNIDAD_ORGANIZATIVA(idUnidadOrganizativa)
        If listaUnidadesEnCentro IsNot Nothing Then
            For Each lEntidad As CENTRO_RESPONSABILIDAD_UNIDAD In listaUnidadesEnCentro
                Dim lEntidadCentro As CENTRO_RESPONSABILIDAD = (New cCENTRO_RESPONSABILIDAD).ObtenerCENTRO_RESPONSABILIDAD(lEntidad.ID_CENTRO_RESPONSABILIDAD)
                listaCentrosResp.Add((New cCENTRO_RESPONSABILIDAD).ObtenerCENTRO_RESPONSABILIDAD(lEntidad.ID_CENTRO_RESPONSABILIDAD))
            Next
        End If
        Me.ListaCENTRORESPONSABILIDADBindingSource.DataSource = listaCentrosResp
    End Sub

    Private Sub ID_REFERENTEcbxREFERENTE_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ID_REFERENTEcbxREFERENTE.SelectedValueChanged
        'Recuperar información del referente
        If ID_REFERENTEcbxREFERENTE.SelectedValue IsNot Nothing Then
            Dim lEntidad As REFERENTE = (New cREFERENTE).ObtenerREFERENTE(ID_REFERENTEcbxREFERENTE.SelectedValue)
            If lEntidad IsNot Nothing Then
                Me.TELEF1TextEdit.Text = lEntidad.TELEF1
                Me.TELEF2TextEdit.Text = lEntidad.TELEF2
                Me.TELEF3TextEdit.Text = lEntidad.TELEF3
                Me.TELEF_MOVILTextEdit.Text = lEntidad.TELEF_MOVIL
                Me.FAXTextEdit.Text = lEntidad.FAX
                Me.NOMBRES_CONTACTOTextEdit.Text = lEntidad.NOMBRE_CONTACTO
                Me.APELLIDOS_CONTACTOTextEdit.Text = lEntidad.APELLIDOS_CONTACTO
                Me.EMAIL_CONTACTOTextEdit.Text = lEntidad.EMAIL_CONTACTO
            End If
        End If
    End Sub

End Class
