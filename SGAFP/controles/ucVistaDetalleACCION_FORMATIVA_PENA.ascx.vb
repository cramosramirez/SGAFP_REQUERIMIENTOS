Imports SGAFP.BL
Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucVistaDetalleACCION_FORMATIVA_PENA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla ACCION_FORMATIVA_PENA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	20/02/2017	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleACCION_FORMATIVA_PENA
    Inherits ucBase
 
#Region"Propiedades"


    Public Property ID_ACCION_FORMATIVA_PENA() As Decimal
        Get
            If Me.ViewState("ID_ACCION_FORMATIVA_PENA") IsNot Nothing Then
                Return CDec(Me.ViewState("ID_ACCION_FORMATIVA_PENA"))
            Else
                Return -1
            End If
        End Get
        Set(ByVal Value As Decimal)
            Me.ViewState("ID_ACCION_FORMATIVA_PENA") = Value
            Me.txtID_ACCION_FORMATIVA_PENA.Text = CStr(Value)
            If Value > 0 Then
                Me.CargarDatos()
            End If
        End Set
    End Property

    Public Property ID_ACCION_FORMATIVA() As Decimal
        Get
            If Me.ViewState("ID_ACCION_FORMATIVA") IsNot Nothing Then
                Return CDec(Me.ViewState("ID_ACCION_FORMATIVA"))
            Else
                Return -1
            End If
        End Get
        Set(ByVal value As Decimal)
            Me.txtID_ACCION_FORMATIVA.Text = value
            Me.ViewState("ID_ACCION_FORMATIVA") = value
            Me.CargarDatosCurso()
        End Set
    End Property

   
    Private _Enabled As Boolean = True
    Private _sError As String
    Private mComponente As New cACCION_FORMATIVA_PENA
    Private mEntidad As ACCION_FORMATIVA_PENA
    Public Event ErrorEvent(ByVal errorMessage As String)


    Private Property Nuevo As Boolean 
        Get
            If Me.ViewState("Nuevo") Is Nothing Then
                Return True
            Else
                Return CBool(Me.ViewState("Nuevo"))
            End If
        End Get
        Set(value As Boolean)
            Me.ViewState("Nuevo") = value
        End Set
    End Property

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
        End Set
    End Property

#End Region
    Private Sub CargarDatosCurso()
        Dim lAccion As ACCION_FORMATIVA = (New cACCION_FORMATIVA).ObtenerACCION_FORMATIVA(Me.ID_ACCION_FORMATIVA)
        Dim lProveedor As PROVEEDOR_AF
        Dim lUsuario As USUARIO

        Me.Nuevo = True
        If lAccion IsNot Nothing Then
            lProveedor = (New cPROVEEDOR_AF).ObtenerPROVEEDOR_AF(lAccion.ID_PROVEEDOR_AF)

            Me.txtPROVEEDOR_AF.Text = lProveedor.NOMBRE_PROVEEDOR
            Me.txtNOMBRE_ACCION_FORMATIVA.Text = lAccion.NOMBRE_ACCION_FORMATIVA
            Me.txtCODIGO_GRUPO.Text = lAccion.CODIGO_GRUPO
            Me.txtID_ACCION_FORMATIVA.Text = lAccion.ID_ACCION_FORMATIVA.ToString
            Me.txtID_ACCION_FORMATIVA_PENA.Text = 0
            Me.txtPORC_PENALIZACION.Value = 0
            Me.txtMOTIVO.Text = ""

            lUsuario = (New cUSUARIO).ObtenerUSUARIO(Me.ObtenerUsuario)
            If lUsuario IsNot Nothing Then
                Me.txtUSUARIO.Text = lUsuario.NOMBRE
            End If
            Me.txtFECHA_CREACION.Text = Now.ToString("dd/MM/yyyy HH:mm tt")

            Me.txtPROVEEDOR_AF.ClientEnabled = False
            Me.txtID_ACCION_FORMATIVA_PENA.ClientEnabled = False
            Me.txtID_ACCION_FORMATIVA.ClientEnabled = False
            Me.txtNOMBRE_ACCION_FORMATIVA.ClientEnabled = False
            Me.txtCODIGO_GRUPO.ClientEnabled = False
            Me.txtUSUARIO.ClientEnabled = False
            Me.txtFECHA_CREACION.ClientEnabled = False
        End If
    End Sub

    Private Sub CargarDatos()
        Dim lPenalizacion As ACCION_FORMATIVA_PENA = mComponente.ObtenerACCION_FORMATIVA_PENA(Me.ID_ACCION_FORMATIVA_PENA)
        Dim lProveedor As PROVEEDOR_AF
        Dim lUsuario As USUARIO
        Dim lAccion As ACCION_FORMATIVA

        Me.Nuevo = False
        If lPenalizacion IsNot Nothing Then
            lAccion = (New cACCION_FORMATIVA).ObtenerACCION_FORMATIVA(lPenalizacion.ID_ACCION_FORMATIVA)
            lProveedor = (New cPROVEEDOR_AF).ObtenerPROVEEDOR_AF(lAccion.ID_PROVEEDOR_AF)

            Me.ViewState("ID_ACCION_FORMATIVA") = lPenalizacion.ID_ACCION_FORMATIVA
            Me.txtPROVEEDOR_AF.Text = lProveedor.NOMBRE_PROVEEDOR
            Me.txtNOMBRE_ACCION_FORMATIVA.Text = lAccion.NOMBRE_ACCION_FORMATIVA
            Me.txtCODIGO_GRUPO.Text = lAccion.CODIGO_GRUPO
            Me.txtID_ACCION_FORMATIVA.Text = lAccion.ID_ACCION_FORMATIVA.ToString
            Me.txtID_ACCION_FORMATIVA_PENA.Text = lPenalizacion.ID_ACCION_FORMATIVA_PENA
            Me.txtPORC_PENALIZACION.Value = lPenalizacion.PORC_PENALIZACION
            Me.txtMOTIVO.Text = lPenalizacion.MOTIVO

            lUsuario = (New cUSUARIO).ObtenerUSUARIO(lPenalizacion.USUARIO_CREACION)
            If lUsuario IsNot Nothing Then
                Me.txtUSUARIO.Text = lUsuario.NOMBRE
            End If
            Me.txtFECHA_CREACION.Text = lPenalizacion.FECHA_CREACION.ToString("dd/MM/yyyy HH:mm tt")

            Me.txtPROVEEDOR_AF.ClientEnabled = False
            Me.txtID_ACCION_FORMATIVA_PENA.ClientEnabled = False
            Me.txtID_ACCION_FORMATIVA.ClientEnabled = False
            Me.txtNOMBRE_ACCION_FORMATIVA.ClientEnabled = False
            Me.txtCODIGO_GRUPO.ClientEnabled = False
            Me.txtUSUARIO.ClientEnabled = False
            Me.txtFECHA_CREACION.ClientEnabled = False
        End If
    End Sub

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquÃ­ el cÃ³digo de usuario para inicializar la pÃ¡gina
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Guarda la informaciÃ³n del registro en la tabla ACCION_FORMATIVA_PENA
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	20/02/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim sError As New String("")
        Dim alDatos As New ArrayList
        mEntidad = New ACCION_FORMATIVA_PENA
        If Me.Nuevo Then
            mEntidad.ID_ACCION_FORMATIVA_PENA = 0
            mEntidad.ID_ACCION_FORMATIVA = Me.ID_ACCION_FORMATIVA
            mEntidad.ID_TIPO_PENA = Enumeradores.TipoPenalizacion.NoDefinida
            mEntidad.USUARIO_CREACION = Me.ObtenerUsuario
            mEntidad.FECHA_CREACION = Now
        Else
            mEntidad = (New cACCION_FORMATIVA_PENA).ObtenerACCION_FORMATIVA_PENA(Me.ID_ACCION_FORMATIVA_PENA)
        End If

        If Me.txtPORC_PENALIZACION.Value Is Nothing Then
            Return "Ingrese el porcentaje de penalizacion"
        End If
        If Me.txtPORC_PENALIZACION.Value > 100 Then
            Return "Porcentaje de penalizacion debe ser menor o igual a 100"
        End If
        If Me.txtMOTIVO.Text.Trim = "" Then
            Return "Indique el motivo de la penalizacion"
        End If

        ''Verificar si ya existe penalización para el curso
        'Dim lPenalizaciones As listaACCION_FORMATIVA_PENA = (New cACCION_FORMATIVA_PENA).ObtenerListaPorACCION_FORMATIVA(Me.ID_ACCION_FORMATIVA)
        'If Me.Nuevo AndAlso lPenalizaciones IsNot Nothing AndAlso lPenalizaciones.Count > 0 Then
        '    Return "Ya se ha ingresado una penalizacion para este curso. Fecha de penalizacion: " + _
        '        lPenalizaciones(0).FECHA_CREACION.ToString("dd/MM/yyyy") + " Porcentaje: " + lPenalizaciones(0).PORC_PENALIZACION.ToString("#,##0.00") + "%"
        'End If

        mEntidad.PORC_PENALIZACION = Me.txtPORC_PENALIZACION.Value
        mEntidad.MOTIVO = Strings.Left(Me.txtMOTIVO.Text.ToUpper, 1000)

        If mComponente.ActualizarACCION_FORMATIVA_PENA(mEntidad) <> 1 Then
            Return "Error al Guardar registro."
        End If

        'Reactualizar monto a pagar si existen informes de ejecución
        Dim bInforme As New cINFORME_FINAL_AF
        Dim bInformeFinalHis As New cINFORME_FINAL_AF_HIS
        Dim listaInformes As listaINFORME_FINAL_AF = bInforme.ObtenerListaPorACCION_FORMATIVA(Me.ID_ACCION_FORMATIVA)
        If listaInformes IsNot Nothing AndAlso listaInformes.Count > 0 Then
            For Each lEntidad As INFORME_FINAL_AF In listaInformes
                Dim lInforme As INFORME_FINAL_AF
                lInforme = bInforme.GenerarInformeParcial(Me.ID_ACCION_FORMATIVA, lEntidad.FECHA_INICIAL, lEntidad.FECHA_FINAL, False)

                If lInforme IsNot Nothing Then
                    Dim lInformeHis As INFORME_FINAL_AF_HIS
                    lInforme.ID_INFORME_FINAL = lEntidad.ID_INFORME_FINAL
                    lInforme.ID_ESTADO_INFORME = lEntidad.ID_ESTADO_INFORME
                    lInforme.ELABORADO_POR = lEntidad.ELABORADO_POR
                    lInforme.USERID = Me.ObtenerUsuario
                    lInforme.LASTUPDATE = Now
                    bInforme.ActualizarINFORME_FINAL_AF(lInforme, TipoConcurrencia.Pesimistica, False, False, False)

                    lInformeHis = New INFORME_FINAL_AF_HIS
                    With lInformeHis
                        .ID_INFORME_FINAL_HIS = 0
                        .ID_INFORME_FINAL = lEntidad.ID_INFORME_FINAL
                        .ID_ACCION_FORMATIVA = lEntidad.ID_ACCION_FORMATIVA
                        .ID_PROVEEDOR_AF = lEntidad.ID_PROVEEDOR_AF
                        .FECHA_INFORME = lEntidad.FECHA_INFORME
                        .NUMERO_FACTURA = lEntidad.NUMERO_FACTURA
                        .ELABORADO_POR = lEntidad.ELABORADO_POR
                        .MONTO_FACTURA = lEntidad.MONTO_FACTURA
                        .MONTO_APROBADO = lEntidad.MONTO_APROBADO
                        .PARTICIPANTES_INSCRITOS = lEntidad.PARTICIPANTES_INSCRITOS
                        .PARTICIPANTES_FINALES = lEntidad.PARTICIPANTES_FINALES
                        .PORC_PROM_ASISTENCIA = lEntidad.PORC_PROM_ASISTENCIA
                        .NOTA_PROMEDIO = lEntidad.NOTA_PROMEDIO
                        .COMENTARIOS = "RECALCULO DE MONTO A PAGAR POR APLICACION DE PORCENTAJE DE PENALIZACION DEL " + mEntidad.PORC_PENALIZACION.ToString + "%"
                        .USUARIO_APROBACION = lEntidad.USUARIO_APROBACION
                        .LASTUPDATE = Now
                        .USERID = Me.ObtenerUsuario
                        .ID_ESTADO_INFORME = EstadoInformeFinal.RecalculoMontoPagar
                        .HORAS_DESARROLLADAS = lEntidad.HORAS_DESARROLLADAS
                        .FECHA_INICIAL = lEntidad.FECHA_INICIAL
                        .FECHA_FINAL = lEntidad.FECHA_FINAL
                        .HORARIO = lEntidad.HORARIO
                        .COSTO_X_HORA = lEntidad.COSTO_X_HORA
                        .USERID = Me.ObtenerUsuario
                        .LASTUPDATE = Now
                        .USUARIO_ASIGNADO = lEntidad.USUARIO_ASIGNADO
                    End With
                    bInformeFinalHis.ActualizarINFORME_FINAL_AF_HIS(lInformeHis)
                End If
            Next
        End If

        Me.txtID_ACCION_FORMATIVA_PENA.Text = mEntidad.ID_ACCION_FORMATIVA_PENA.ToString()
        Me.Nuevo = False
        Return ""
    End Function
End Class
