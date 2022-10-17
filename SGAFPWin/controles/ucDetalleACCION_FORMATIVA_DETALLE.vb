Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucDetalleACCION_FORMATIVA_DETALLE
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
Public Class ucDetalleACCION_FORMATIVA_DETALLE

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

    Public ReadOnly Property Current() As ACCION_FORMATIVA_DETALLE
        Get
            Return CType(Me.ListaACCION_FORMATIVA_DETALLEBindingSource.Current, ACCION_FORMATIVA_DETALLE)
        End Get
    End Property

    Public Overrides Property DataSource() As System.Windows.Forms.BindingSource 
        Get 
            Return Me.ListaACCION_FORMATIVA_DETALLEBindingSource 
        End Get 
        Set(ByVal value As System.Windows.Forms.BindingSource) 
            Me.ListaACCION_FORMATIVA_DETALLEBindingSource = value 
        End Set 
    End Property 

    Private Sub ListaACCION_FORMATIVA_DETALLEBindingSource_CurrentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaACCION_FORMATIVA_DETALLEBindingSource.CurrentChanged
        Me.ID_ACCION_FORMATIVAcbxACCION_FORMATIVA.Recuperar()
        Me.ID_ACCION_FORMATIVAcbxACCION_FORMATIVA.SelectedValue = Me.Current.ID_ACCION_FORMATIVA
        Me.ID_PROGRAMA_FORMACIONcbxPROGRAMA_FORMACION.Recuperar()
        Me.ID_PROGRAMA_FORMACIONcbxPROGRAMA_FORMACION.SelectedValue = Me.Current.ID_PROGRAMA_FORMACION
        Me.ID_MODALIDAD_FORMACIONcbxMODALIDAD_DE_FORMACION.Recuperar()
        Me.ID_MODALIDAD_FORMACIONcbxMODALIDAD_DE_FORMACION.SelectedValue = Me.Current.ID_MODALIDAD_FORMACION
        Me.ID_CONTRATOcbxCONTRATO_PROVEEDOR_AF.Recuperar()
        Me.ID_CONTRATOcbxCONTRATO_PROVEEDOR_AF.SelectedValue = Me.Current.ID_CONTRATO
        Me.ID_FUENTEcbxFUENTE_FINANCIAMIENTO.Recuperar()
        Me.ID_FUENTEcbxFUENTE_FINANCIAMIENTO.SelectedValue = Me.Current.ID_FUENTE
        Me.CODIGO_DEPARTAMENTOcbxDEPARTAMENTO.Recuperar()
        Me.CODIGO_DEPARTAMENTOcbxDEPARTAMENTO.SelectedValue = Me.Current.CODIGO_DEPARTAMENTO
        Me.CODIGO_MUNICIPIOcbxMUNICIPIO.Recuperar(Me.CODIGO_DEPARTAMENTOCbxDEPARTAMENTO.SelectedValue)
        Me.CODIGO_MUNICIPIOcbxMUNICIPIO.SelectedValue = Me.Current.CODIGO_MUNICIPIO
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que sobreescribe y realiza la acción de Guardar en la Base de Datos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Actualizar() As Integer 
        Dim mEntidad As New ACCION_FORMATIVA_DETALLE 
        Me.ListaACCION_FORMATIVA_DETALLEBindingSource.EndEdit() 
        mEntidad = Me.Current 
        Dim mControl As New cACCION_FORMATIVA_DETALLE 
        If Me.EsNuevo Then 
            If mControl.AgregarACCION_FORMATIVA_DETALLE(mEntidad) < 1 Then 
                Me.AsignarMensaje("No se pudo agregar el registro", True) 
                Return -1 
            End If 
        Else 
            If mControl.ActualizarACCION_FORMATIVA_DETALLE(mEntidad) < 1 Then 
                Me.AsignarMensaje("No se pudo guardar el registro", True) 
                Return -1 
            End If 
        End If 
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
        Me.ID_PROGRAMA_FORMACIONcbxPROGRAMA_FORMACION.Enabled = edicion
        Me.ID_MODALIDAD_FORMACIONcbxMODALIDAD_DE_FORMACION.Enabled = edicion
        Me.ID_CONTRATOcbxCONTRATO_PROVEEDOR_AF.Enabled = edicion
        Me.ID_FUENTEcbxFUENTE_FINANCIAMIENTO.Enabled = edicion
        Me.NO_CONVOCATORIASpinEdit.Enabled = edicion
        Me.CODIGO_DEPARTAMENTOcbxDEPARTAMENTO.Enabled = edicion
        Me.CODIGO_MUNICIPIOcbxMUNICIPIO.Enabled = edicion
        Me.LUGAR_EJECUCIONTextEdit.Enabled = edicion
        Me.TELEFONOTextEdit.Enabled = edicion
        Me.CONTACTOTextEdit.Enabled = edicion
        Me.USERIDTextEdit.Enabled = edicion
        Me.LASTUPDATEDateEdit.Enabled = edicion
    End Sub

End Class
