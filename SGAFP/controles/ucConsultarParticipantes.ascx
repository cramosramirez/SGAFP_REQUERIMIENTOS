<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucConsultarParticipantes.ascx.vb" Inherits="controles_ucConsultarParticipantes" %>
<%@ Register src="ucBarraNavegacion.ascx" tagname="ucBarraNavegacion" tagprefix="uc1" %>
<%@ Register src="ucCriteriosParticipante.ascx" tagname="ucCriteriosParticipante" tagprefix="uc2" %>
                    <%@ Register src="ucListaPARTICIPANTE.ascx" tagname="ucListaPARTICIPANTE" tagprefix="uc3" %>
                    <uc1:ucBarraNavegacion ID="UcBarraNavegacion1" 
    runat="server" PermitirAgregar="false"
                        PermitirEditar="false" PermitirGuardar="false" PermitirNavegacion="false" 
                        Visible="true" />
                <uc2:ucCriteriosParticipante ID="ucCriteriosParticipante1" 
    runat="server" />
<asp:Image ID="Image1" runat="server" Height="8px" 
    ImageUrl="~/imagenes/spacer.gif" Width="8px" /><br />
<uc3:ucListaPARTICIPANTE ID="ucListaPARTICIPANTE1" runat="server"  VerCARGO="false" VerCIUO="false" VerCLAVE_USUARIO="false" VerCODIGO_DEPARTAMENTO="false" VerCODIGO_MUNICIPIO="false" VerCODIGO_REGION="false" VerCUENTA_USUARIO="false" VerDEPARTAMENTO_NAC="false" VerDIRECCION="false" VerEMAIL="false" VerESTADO_CIVIL="false" VerESTADO_FAMILIAR="false" VerFAX="false" VerFECHA_VENCIMIENTO_CLAVE="false" VerISSS="false" VerLASTUPDATE="false" VerLUGAR_NACIMIENTO="false" VerMUNICIPIO_NAC="false" VerNIT_EMPRESA="false" VerNOMBRE_EMPRESA="false" VerOCUPACION_ACTUAL="false" VerPROFESION_OFICIO="false" VerTITULO_CERTIFICADO_OBTENIDO="false" VerUSERID="false" VerZONA="false" PermitirEditar="false" PermitirEliminar="false" />



