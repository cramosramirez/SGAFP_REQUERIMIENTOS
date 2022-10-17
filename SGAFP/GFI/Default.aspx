<%@ Page Title="" Language="VB" MasterPageFile="~/principal.master" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="GFI_Default" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxSiteMapControl" TagPrefix="dx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenido" Runat="Server">
     <dx:aspxsitemapcontrol id="ASPxSiteMapControl1" runat="server" datasourceid="ASPxSiteMapDataSource1"
        cssfilepath="~/App_Themes/Office2003Blue/{0}/styles.css" csspostfix="Office2003Blue"
        spritecssfilepath="~/App_Themes/Office2003Blue/{0}/sprite.css">
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
    </dx:aspxsitemapcontrol>
    <dx:aspxsitemapdatasource id="ASPxSiteMapDataSource1" runat="server" sitemapfilename="~/Web.sitemap"
        startingnodeurl="~/GFI/Default.aspx" showstartingnode="True" 
        enableroles="True" />
</asp:Content>

