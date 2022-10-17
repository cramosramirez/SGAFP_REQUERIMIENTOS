<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucBarraNavegacion.ascx.vb" Inherits="controles_ucBarraNavegacion" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxMenu" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxRoundPanel" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxPanel" TagPrefix="dx" %>
<%@ Register assembly="DevExpress.Web.ASPxGridView.v11.1.Export, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxGridView.Export" tagprefix="dx" %>
<dx:ASPxRoundPanel ShowHeader="False" ID="ASPxRoundPanel1" runat="server" Width="100%" CssFilePath="~/App_Themes/Office2010Blue/{0}/styles.css" CssPostfix="Office2010Blue" EnableDefaultAppearance="False" GroupBoxCaptionOffsetX="6px" GroupBoxCaptionOffsetY="-19px" SpriteCssFilePath="~/App_Themes/Office2010Blue/{0}/sprite.css">
    <ContentPaddings PaddingBottom="4px" PaddingLeft="9px" PaddingRight="11px" PaddingTop="4px" />
    <HeaderStyle>    
    </HeaderStyle>   
    <PanelCollection>
        <dx:PanelContent ID="PanelContent1" runat="server">
            <dx:ASPxMenu ID="mDinamico" runat="server" SkinID="None" SeparatorWidth="2px" BackColor="Transparent"
                SeparatorHeight="15px" ItemSpacing="1px" AutoPostBack="false" Font-Names="Verdana,Arial,Tahoma" Font-Size="X-Small" Font-Bold="True" >
                <SeparatorBackgroundImage ImageUrl="~/imagenes/SeparatorBackground.png" Repeat="NoRepeat"
                    VerticalPosition="center" />
                <Border BorderWidth="0px" />
                <Paddings Padding="0px" PaddingLeft="2px" />
                <ItemStyle Wrap="False">
                    <Paddings Padding="3px" PaddingLeft="4px" />
                    <HoverStyle>
                        <BackgroundImage ImageUrl="~/imagenes/BackgroundHover.gif" Repeat="RepeatX" />
                        <Border BorderColor="Navy" BorderStyle="Solid" BorderWidth="1px" />
                    </HoverStyle>
                    <CheckedStyle>
                        <BackgroundImage ImageUrl="~/imagenes/BackgroundSelected.gif" Repeat="RepeatX" />
                        <Border BorderColor="Navy" BorderStyle="Solid" BorderWidth="1px" />
                    </CheckedStyle>
                </ItemStyle>
                <ItemImage Height="16px" Width="16px" />
                <SeparatorPaddings PaddingLeft="2px" PaddingRight="2px" />
                <Items>
                    <dx:MenuItem GroupName="General" Name="miAgregar" Text="Agregar">
                        <Image AlternateText="Agregar" Height="16px" Url="~/imagenes/Nuevo.png" Width="16px">
                        </Image>
                    </dx:MenuItem>
                    <dx:MenuItem GroupName="General" Name="miEditar" Text="Editar">
                        <Image Height="16px" Url="~/imagenes/Editar.png" Width="16px">
                        </Image>
                    </dx:MenuItem>
                    <dx:MenuItem GroupName="General" Name="miGuardar" Text="Guardar">
                        <Image AlternateText="Guardar" Height="16px" Url="~/imagenes/ButtonSave.png" Width="16px">
                        </Image>
                    </dx:MenuItem>
                    <dx:MenuItem BeginGroup="true" GroupName="Exportar" Name="miExportarAExcel" Text="Exportar a Excel" Visible="False">
                        <Image AlternateText="Exportar a Excel" Height="16px" Url="~/imagenes/excel.png" Width="16px">
                        </Image>
                    </dx:MenuItem>
                    <dx:MenuItem GroupName="Exportar" Name="miExportarAPDF" Text="Exportar a PDF" Visible="False">
                        <Image AlternateText="Exportar a PDF" Height="16px" Url="~/imagenes/pdf.gif" Width="16px">
                        </Image>
                    </dx:MenuItem>
                </Items>
            </dx:ASPxMenu>
        </dx:PanelContent>
    </PanelCollection>
    
</dx:ASPxRoundPanel>
<dx:ASPxGridViewExporter ID="ASPxGridViewExporter1" runat="server">
</dx:ASPxGridViewExporter>

