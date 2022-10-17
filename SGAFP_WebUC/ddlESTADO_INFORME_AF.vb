Imports System.ComponentModel
Imports System.Web.UI
Imports SGAFP.EL.Enumeradores

''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_WebUC
''' Class	 : WebUC.ddlESTADO_CIVIL
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista Desplegable Web
''' de la tabla ESTADO_CIVIL
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	19/01/2011	Created
''' </history>
''' -----------------------------------------------------------------------------
<DefaultProperty("ID_ESTADO_INFORME"), ToolboxData("<{0}:ddlESTADO_INFORME_AF runat=server></{0}:ddlESTADO_INFORME_AF>")> _
Public Class ddlESTADO_INFORME_AF
    Inherits ddlBase


    Public Sub RecuperarEstadosPorInforme(ByVal ID_INFORME_AF As Decimal)
        Dim lInforme As INFORME_FINAL_AF = (New cINFORME_FINAL_AF).ObtenerINFORME_FINAL_AF(ID_INFORME_AF)
        Dim lInformeHisto As listaINFORME_FINAL_AF_HIS = (New cINFORME_FINAL_AF_HIS).ObtenerListaPorINFORME_FINAL_AF(ID_INFORME_AF, False, "ID_ESTADO_INFORME")
        Dim miComponente As New cESTADO_INFORME_AF
        Dim Lista As New listaESTADO_INFORME_AF

        If lInformeHisto IsNot Nothing AndAlso lInformeHisto.Count > 0 Then
            For i As Integer = 0 To lInformeHisto.Count - 1
                If lInformeHisto(i).ID_ESTADO_INFORME <> lInforme.ID_ESTADO_INFORME AndAlso Lista.BuscarPorId(lInformeHisto(i).ID_ESTADO_INFORME) Is Nothing Then
                    Dim lEstado As ESTADO_INFORME_AF = (New cESTADO_INFORME_AF).ObtenerESTADO_INFORME_AF(lInformeHisto(i).ID_ESTADO_INFORME)
                    Lista.Add(lEstado)
                End If
            Next
        Else
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "NOMBRE_ESTADO_INFORME"
        Me.DataValueField = "ID_ESTADO_INFORME"

        Me.DataBind()
    End Sub

    Public Sub RecuperarEstadosPorRol()
        Dim miComponente As New cESTADO_INFORME_AF
        Dim Lista As New listaESTADO_INFORME_AF
        Dim lEstadoInforme As New ESTADO_INFORME_AF

        lEstadoInforme.ID_ESTADO_INFORME = -1
        lEstadoInforme.NOMBRE_ESTADO_INFORME = "[Todos]"
        Lista.Add(lEstadoInforme)

        Select Case True
            Case Utilerias.EstaEnRol(RolDeUsuario.CARecepcion)
                Lista.Add(miComponente.ObtenerESTADO_INFORME_AF(EstadoInformeFinal.Emitido))
                Lista.Add(miComponente.ObtenerESTADO_INFORME_AF(EstadoInformeFinal.InformeEnProcesoBolpros))
                Lista.Add(miComponente.ObtenerESTADO_INFORME_AF(EstadoInformeFinal.OrdenEntregaValidada))
                Lista.Add(miComponente.ObtenerESTADO_INFORME_AF(EstadoInformeFinal.OrdenEntregaObservada))
                Lista.Add(miComponente.ObtenerESTADO_INFORME_AF(EstadoInformeFinal.FacturaSolicitadaProveedor))
                Lista.Add(miComponente.ObtenerESTADO_INFORME_AF(EstadoInformeFinal.FacturaObservada))
            Case Utilerias.EstaEnRol(RolDeUsuario.CAGestion)
                Lista.Add(miComponente.ObtenerESTADO_INFORME_AF(EstadoInformeFinal.InformeRecibido))
                Lista.Add(miComponente.ObtenerESTADO_INFORME_AF(EstadoInformeFinal.OrdenEntregaRecibida))
                Lista.Add(miComponente.ObtenerESTADO_INFORME_AF(EstadoInformeFinal.FacturaRecibida))
            Case Utilerias.EstaEnRol(RolDeUsuario.CARevision)
                Lista.Add(miComponente.ObtenerESTADO_INFORME_AF(EstadoInformeFinal.InformeEnRevision))
                Lista.Add(miComponente.ObtenerESTADO_INFORME_AF(EstadoInformeFinal.InformeDevueltoConObservaciones))
                Lista.Add(miComponente.ObtenerESTADO_INFORME_AF(EstadoInformeFinal.InformeConObservacionesSolventadas))
                Lista.Add(miComponente.ObtenerESTADO_INFORME_AF(EstadoInformeFinal.InformeValidadoTecnico))
                Lista.Add(miComponente.ObtenerESTADO_INFORME_AF(EstadoInformeFinal.OrdenEntregaEnRevision))
                Lista.Add(miComponente.ObtenerESTADO_INFORME_AF(EstadoInformeFinal.FacturaEnRevision))
        End Select

        Me.DataSource = Lista
        Me.DataTextField = "NOMBRE_ESTADO_INFORME"
        Me.DataValueField = "ID_ESTADO_INFORME"

        Me.DataBind()
    End Sub

    Private Sub RecuperarLista()
        Dim miComponente As New cESTADO_INFORME_AF
        Dim Lista As New listaESTADO_INFORME_AF
        Dim lEstadoInforme As New ESTADO_INFORME_AF

        lEstadoInforme.ID_ESTADO_INFORME = -1
        lEstadoInforme.NOMBRE_ESTADO_INFORME = "[Todos]"

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Lista.Insert(0, lEstadoInforme)
        Me.DataSource = Lista
        Me.DataTextField = "NOMBRE_ESTADO_INFORME"
        Me.DataValueField = "ID_ESTADO_INFORME"

        Me.DataBind()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el DropDownList con los Datos de la Tabla ESTADO_CIVIL.
    ''' </summary>
    ''' <remarks>
    ''' Si la tabla es de llave compuesta, recibe los parametros de la Tabla Padre
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/01/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub Recuperar()
        RecuperarLista()
    End Sub

End Class

