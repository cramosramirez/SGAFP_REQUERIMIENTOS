Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucDetalleUSUARIO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	23/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
Public Class ucDetalleUSUARIO

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

    Public ReadOnly Property Current() As USUARIO
        Get
            Return CType(Me.ListaUSUARIOBindingSource.Current, USUARIO)
        End Get
    End Property

    Public Overrides Property DataSource() As System.Windows.Forms.BindingSource 
        Get 
            Return Me.ListaUSUARIOBindingSource 
        End Get 
        Set(ByVal value As System.Windows.Forms.BindingSource) 
            Me.ListaUSUARIOBindingSource = value 
        End Set 
    End Property 

    Private Sub ListaUSUARIOBindingSource_CurrentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaUSUARIOBindingSource.CurrentChanged

        'If Me.ListaPROVEEDORAFBindingSource.Count = 0 Then
        '    Me.ListaPROVEEDORAFBindingSource.DataSource = (New cPROVEEDOR_AF).ObtenerLista()
        'End If

        ''If Me.ID_PROVEEDOR_AFcbxPROVEEDOR_AF.Items.Count = 0 Then
        ''    Me.ID_PROVEEDOR_AFcbxPROVEEDOR_AF.Recuperar()
        ''End If

        ''Me.ID_PROVEEDOR_AFcbxPROVEEDOR_AF.SelectedValue = Me.Current.ID_PROVEEDOR_AF

        'If Me.ID_SITIO_CAPACITACIONcbxSITIO_CAPACITACION.Items.Count = 0 Then
        '    Me.ID_SITIO_CAPACITACIONcbxSITIO_CAPACITACION.Recuperar()
        'End If
        'Me.ID_SITIO_CAPACITACIONcbxSITIO_CAPACITACION.SelectedValue = Me.Current.ID_SITIO_CAPACITACION

        'Dim lParticipante As New PARTICIPANTE
        'lParticipante = (New cPARTICIPANTE).ObtenerPARTICIPANTE(Me.Current.ID_PARTICIPANTE)
        'If lParticipante Is Nothing OrElse Me.Current.ID_PARTICIPANTE = -1 Then
        '    lParticipante = New PARTICIPANTE
        '    lParticipante.ID_PARTICIPANTE = Me.Current.ID_PARTICIPANTE
        '    lParticipante.NOMBRES = "[Vacio]"
        'End If
        'Dim listaParticipante As New listaPARTICIPANTE
        'listaParticipante.Add(lParticipante)

        'Me.ID_PARTICIPANTEcbxPARTICIPANTE.CargarPorLista(listaParticipante, "NombresApellidos", "ID_PARTICIPANTE")
        'Me.ID_PARTICIPANTEcbxPARTICIPANTE.SelectedValue = Me.Current.ID_PARTICIPANTE
        If Me.ListaPROVEEDORAFBindingSource.Count = 0 Then
            Me.ListaPROVEEDORAFBindingSource.DataSource = (New cPROVEEDOR_AF).ObtenerLista()
        End If

        Dim lUsuario As USUARIO = sender.current
        'Me.ID_PARTICIPANTEcbxPARTICIPANTE.Items.Clear()
        Dim lParticipante As New PARTICIPANTE
        lParticipante = (New cPARTICIPANTE).ObtenerPARTICIPANTE(lUsuario.ID_PARTICIPANTE)
        If lParticipante Is Nothing OrElse lUsuario.ID_PARTICIPANTE = -1 Then
            lParticipante = New PARTICIPANTE
            lParticipante.ID_PARTICIPANTE = lUsuario.ID_PARTICIPANTE
            lParticipante.NOMBRES = "[Vacio]"
        End If
        Dim listaParticipante As New listaPARTICIPANTE
        listaParticipante.Add(lParticipante)
        Me.ListaPARTICIPANTEBindingSource.DataSource = listaParticipante
        Me.gleParticipante.EditValue = lUsuario.ID_PARTICIPANTE

        'Me.ID_PARTICIPANTEcbxPARTICIPANTE.CargarPorLista(listaParticipante, "NombresApellidos", "ID_PARTICIPANTE")
        'Me.ID_PARTICIPANTEcbxPARTICIPANTE.SelectedValue = lUsuario.ID_PARTICIPANTE

        'Me.ListaPARTICIPANTEBindingSource.DataSource = listaParticipante
        Me.gleProveedor.EditValue = lUsuario.ID_PROVEEDOR_AF
        'Me.ID_PROVEEDOR_AFcbxPROVEEDOR_AF.Recuperar(True)
        'Me.ID_PROVEEDOR_AFcbxPROVEEDOR_AF.SelectedValue = lUsuario.ID_PROVEEDOR_AF

        'Me.ID_SITIO_CAPACITACIONcbxSITIO_CAPACITACION.RecuperarPorPROVEEDOR_AF(Me.ID_PROVEEDOR_AFcbxPROVEEDOR_AF.SelectedValue, False, True)
        'Me.ID_SITIO_CAPACITACIONcbxSITIO_CAPACITACION.SelectedValue = lUsuario.ID_SITIO_CAPACITACION

        Dim listaSitio As listaSITIO_CAPACITACION = (New cSITIO_CAPACITACION).ObtenerLista()
        Dim lSitio As New SITIO_CAPACITACION
        lSitio.ID_SITIO_CAPACITACION = -1
        lSitio.NOMBRE_SITIO = "[Vacio]"
        listaSitio.Add(lSitio)
        Me.ListaSITIOCAPACITACIONBindingSource.DataSource = listaSitio
        Me.gleSitioCapacitacion.EditValue = lUsuario.ID_SITIO_CAPACITACION
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que sobreescribe y realiza la acción de Guardar en la Base de Datos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Actualizar() As Integer 
        Dim mEntidad As New USUARIO 
        Me.ListaUSUARIOBindingSource.EndEdit() 
        mEntidad = Me.Current 
        Dim mControl As New cUSUARIO 
    	   If mControl.ActualizarUSUARIO(mEntidad) < 1 Then 
            Me.AsignarMensaje("No se pudo guardar el registro", True) 
            Return -1 
        End If 
        Me.USUARIOTextBox.Text = mEntidad.USUARIO.ToString()
        Return 1 
    End Function 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que permite Habilitar/Deshabilitar el uso de los controles contenidos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.gleProveedor.Enabled = edicion
        Me.gleSitioCapacitacion.Enabled = edicion
        Me.gleParticipante.Enabled = edicion
    End Sub

End Class
