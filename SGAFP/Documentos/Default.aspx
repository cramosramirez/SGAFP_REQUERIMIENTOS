<%@ Page Title="" Language="VB" MasterPageFile="~/principal.master" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="Documentos_Default" %>

<%@ Register assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxSiteMapControl" tagprefix="dx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenido" Runat="Server">
    <dx:ASPxSiteMapControl ID="ASPxSiteMapControl1" runat="server" 
        DataSourceID="ASPxSiteMapDataSource1" 
        CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css" 
        CssPostfix="Office2003Blue" 
        SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css">
        <LevelProperties>
            <dx:LevelProperties NodeSpacing="5px">
            </dx:LevelProperties>
            <dx:LevelProperties BulletStyle="None">
                <Image>
                    <SpriteProperties CssClass="dxWeb_smBullet_Office2003Blue" />
                </Image>
            </dx:LevelProperties>
        </LevelProperties>
        <Paddings PaddingBottom="1px" PaddingLeft="2px" PaddingRight="2px" 
            PaddingTop="5px" />
        <ColumnSeparatorStyle>
            <Paddings PaddingLeft="0px" PaddingRight="1px" />
        </ColumnSeparatorStyle>
    </dx:ASPxSiteMapControl>
    <dx:ASPxSiteMapDataSource ID="ASPxSiteMapDataSource1" runat="server" 
        SiteMapFileName="~/Web.sitemap" 
        StartingNodeUrl="~/Documentos/Default.aspx" 
        ShowStartingNode="True" EnableRoles="True" />
</asp:Content>
