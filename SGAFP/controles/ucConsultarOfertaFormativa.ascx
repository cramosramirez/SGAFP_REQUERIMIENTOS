<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucConsultarOfertaFormativa.ascx.vb" Inherits="controles_ucConsultarOfertaFormativa" %>
<%@ Register src="ucBarraNavegacion.ascx" tagname="ucBarraNavegacion" tagprefix="uc1" %>
<%@ Register src="ucCriteriosOfertaFormativa.ascx" tagname="ucCriteriosOfertaFormativa" tagprefix="uc2" %>
                    <%@ Register src="ucListaOFERTA_FORMATIVA.ascx" tagname="ucListaOFERTA_FORMATIVA" tagprefix="uc3" %>
                    <uc1:ucBarraNavegacion ID="UcBarraNavegacion1" 
    runat="server" PermitirAgregar="false"
                        PermitirEditar="false" PermitirGuardar="false" PermitirNavegacion="false" 
                        Visible="true" />
                <uc2:ucCriteriosOfertaFormativa ID="ucCriteriosOfertaFormativa1" 
    runat="server" />
<asp:Image ID="Image1" runat="server" Height="8px" ImageUrl="~/imagenes/spacer.gif"
    Width="8px" /><br />
<uc3:ucListaOFERTA_FORMATIVA ID="ucListaOFERTA_FORMATIVA1" runat="server" PermitirEditar="false" PermitirEliminar="false" VerCOSTO_X_PARTICIPANTE="false" VerESTADO="false" VerFECHA_APROBACION="false" VerFECHA_INICIO="false" VerFECHA_FIN="false" VerID_EJERCICIO="false" VerID_PROVEEDOR_AF="True" VerID_TEMA_CURSO="True" VerLASTUPDATE="false" VerUSERID="false" VerUSUARIO_APROBACION="false" VerNOTAS="false" />

