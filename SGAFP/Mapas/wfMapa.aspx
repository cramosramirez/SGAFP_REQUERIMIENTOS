<%@ Page Language="VB" AutoEventWireup="false" CodeFile="wfMapa.aspx.vb" Inherits="Mapas_wfMapa" %>

<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxCallbackPanel" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxLoadingPanel" TagPrefix="dx" %>


<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxMenu" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxTabControl" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxClasses" tagprefix="dx" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>

<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxPopupControl" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxRoundPanel" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxPanel" TagPrefix="dx" %>
<%@ Register assembly="DevExpress.Web.ASPxGridView.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxGridView" TagPrefix="dx" %>
<%@ Register assembly="DevExpress.Web.ASPxPivotGrid.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxPivotGrid" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxHiddenField" TagPrefix="dx" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">    
    <style type="text/css">
      html { height: 100% }
      body { height: 100%; margin: 0px; padding: 0px }
      #map_canvas { height: 100% }
    </style>
    <meta name="viewport" content="initial-scale=1.0, user-scalable=no" />
    <script type="text/javascript" src="http://maps.google.com/maps/api/js?key=AIzaSyCmNlMdmJTyoRdRlR-PCg-cqcQ_2uw8GnU"></script>
    <title>SGAFP .:: Mapas ::. </title>
</head>

<script type="text/javascript" language="javascript" >
    var postponedCallbackValue = null;
    var map;
    var mapaActivo = 0;
    var elementosMapaHTP = [];
    var elementosMapaPATI = [];
    var elementosMapaISSS = [];
    
    function InicializarMapa() {
        //var latlng = new google.maps.LatLng(13.6333333, -88.8);
        var latlng = new google.maps.LatLng(13.698976, -89.191453);
        var myOptions = {
            zoom: 9,
            center: latlng,
            mapTypeId: google.maps.MapTypeId.ROADMAP,
            mapTypeControlOptions: {
                style: google.maps.MapTypeControlStyle.HORIZONTAL_BAR
            },  
            navigationControlOptions: {  
                style: google.maps.NavigationControlStyle.ZOOM_PAN  
                } 
        };
        map = new google.maps.Map(document.getElementById("map_canvas"), myOptions);        
    }

    function TabSeleccionado() {
        mapaActivo = TabMapas.GetActiveTab().index;
        limpiarMapa(0);
        limpiarMapa(1);
        limpiarMapa(2);                
        mostrarMapa(mapaActivo);
    }

    function MostrarReporte(url) {
        window.open(url, 'blank_', '')   
    }

    function SetTodos(s, e) {        
        s.SetText('[Todos]');
    }

    function ProcesarCriterios() {
        Cargando.Show();
        cpMapa.PerformCallback('ProcesarMapa;');        
    }
    
    function OnEndCallback(s, e) {        
        if (postponedCallbackValue != null) {
            cpMapa.PerformCallback(postponedCallbackValue);
            postponedCallbackValue = null;         
        }
        else {
            //  Llenar mapa de Google con la infomación obtenida
            if (s.cpResultCallback != undefined) {
                if (s.cpResultCallback == 'LlenarMapa') {                    
                    //eliminarMapa(mapaActivo);
                    LlenarMapaHTP();                    
                }
            }           
            Cargando.Hide();
        }
    }
    
    //  Función que dibuja y devuelve una marca en el mapa
    function crearMarca(posicion, icono, nombre, mapa) {
        var marca = new google.maps.Marker({
            position: posicion,
            map: map,
            icon: icono,
            title: nombre
        });        
        agregarElementoMapa(marca, mapa);
        return marca
    }

    //  Función que asocia una ventana de información a una marca en el mapa
    function crearVentanaInfo(marca, texto) {        
        var ventanaInfo = new google.maps.InfoWindow({
            content: texto
        });
        google.maps.event.addListener(marca, 'click', function() {
            ventanaInfo.open(map, marca);
        });
    }    

    //  Función que crea un línea entre dos posiciones dentro del mapa
    function crearLinea(posicion1, posicion2, mapa) {
        var coordenadas = [posicion1, posicion2];
        var lineas = new google.maps.Polyline({
            path: coordenadas,
            strokeColor: "#3C3C3C",
            strokeOpacity: 0.5,
            strokeWeight: 1
        });
        lineas.setMap(map);
        agregarElementoMapa(lineas,mapa);
    }
    function crearLinea2(posicion1, posicion2, mapa) {
        var coordenadas = [posicion1, posicion2];
        var lineas = new google.maps.Polyline({
            path: coordenadas,
            strokeColor: "#000000",
            strokeOpacity: 0.5,
            strokeWeight: 1
        });
        lineas.setMap(map);
        agregarElementoMapa(lineas, mapa);
    }


    //  Función que agrega un elemento al mapa
    function agregarElementoMapa(elemento, mapa) {
        switch (mapa) {
            case 0:
                elementosMapaHTP.push(elemento);
                break;
            case 1:
                elementosMapaPATI.push(elemento);
                break;
            case 2:
                break;
        }  
    };

    //  Función que restaura los Overlays del mapa
    function restaurarMapa(mapa) {
        switch (mapa) {
            case 0:
                if (elementosMapaHTP) {
                    for (i in elementosMapaHTP) {
                        elementosMapaHTP[i].setMap(map);
                    }
                }
                break;
            case 1:
                if (elementosMapaPATI) {
                    for (i in elementosMapaPATI) {
                        elementosMapaPATI[i].setMap(map);
                    }
                }
                break;
            case 2:
                break;
        }  
    };
    //  Función que quita los Overlays del mapa
    function limpiarMapa(mapa) {
        switch (mapa) {
            case 0:
                if (elementosMapaHTP) {
                    for (i in elementosMapaHTP) {
                        elementosMapaHTP[i].setMap(null);
                    }                    
                }
                break;
            case 1:
                if (elementosMapaPATI) {
                    for (i in elementosMapaPATI) {
                        elementosMapaPATI[i].setMap(null);
                    }                    
                }
                break;
            case 2:
                break;
        }  
    };
    //  Función que quita los Overlays del mapa
    function mostrarMapa(mapa) {
        switch (mapa) {
            case 0:
                if (elementosMapaHTP) {
                    for (i in elementosMapaHTP) {
                        elementosMapaHTP[i].setMap(map);
                    }                    
                }
                break;
            case 1:
                if (elementosMapaPATI) {
                    for (i in elementosMapaPATI) {
                        elementosMapaPATI[i].setMap(map);
                    }                    
                }
                break;
            case 2:
                break;
        }  
    };
    //  Función que borra los Overlays del mapa
    function eliminarMapa(mapa) {
        switch (mapa) {
            case 0:
                if (elementosMapaHTP) {
                    for (i in elementosMapaHTP) {
                        elementosMapaHTP[i].setMap(null);
                    }
                    elementosMapaHTP.length = 0;
                }
                break;
            case 1:
                if (elementosMapaPATI) {
                    for (i in elementosMapaPATI) {
                        elementosMapaPATI[i].setMap(null);
                    }
                    elementosMapaPATI.length = 0;
                }
                break;
            case 2:
                break;
        }  
    };    

    
    function LlenarMapaHTP() {        
        //  Municipios BM              
        var coordsLtdLng;
        var mensaje = '';        
        var marca;
        for (var i in cpMapa.cpMunicipiosLatLng) {
            var iconoMarca = cpMapa.cpIconos[i];
            var coordsLtdLng = ObtenerArrayLatLng(cpMapa.cpMunicipiosLatLng[i]);
            var posicion = coordsLtdLng[0];            
            marca = crearMarca(posicion, iconoMarca, cpMapa.cpMunicipiosNombre[i], 1);
        }       
       
        dibujarDepartamentos(1);
    }       

    function LlenarMapaISSS() {
    }

    function dibujarDepartamentos(mapa) {
        //  Departamentos con presencia
        var poligono;
        for (var i in cpMapa.cpDepartamentosPresencia) {
            poligono = new google.maps.Polygon({
                paths: ObtenerArrayLatLng(cpMapa.cpDepartamentosPresencia[i]),
                strokeColor: "#333376",
                strokeOpacity: 1,
                fillColor: "#CAEBFF",
                strokeWeight: 2,                
                fillOpacity: 1
            });
            poligono.setMap(map);
            agregarElementoMapa(poligono, mapa);
        }
        //"#0000CC",fillColor: "#999999", fillOpacity: 0.2
        //  Departamentos sin presencia       
    }

    function ObtenerArrayLatLng(listaCoord){
        var coordenadas = new Array(); 

        var coordenada;
        var latitud;
        var longitud;

        var posini = 0;
        var posfin = 0;
        var i = 0;

        while (posini <= listaCoord.toString().length - 1) {
            posini = listaCoord.toString().indexOf('(', posini);
            posfin = listaCoord.toString().indexOf(')', posini);

            coordenada = listaCoord.toString().substr(posini + 1, posfin - posini - 1).replace(/^\s+/g, '').replace(/\s+$/g, '');
            latitud = parseFloat(coordenada.toString().substr(0, coordenada.toString().indexOf(',') - 1).replace(/^\s+/g, '').replace(/\s+$/g, ''));
            longitud = parseFloat(coordenada.toString().substr(coordenada.toString().indexOf(',') + 1).replace(/^\s+/g, '').replace(/\s+$/g, ''));

            coordenadas[i++] = new google.maps.LatLng(latitud, longitud);
            posini = posfin + 1;
        }
        return coordenadas;
    }  
</script>

 <style type="text/css"> 
        v\:* { behavior:url(#default#VML); } 
            
         .EtiquetaDer
        {
            font-family: Arial;
            font-size:xx-small;  
            padding-left: 5px;
            height: 20px;  
            text-align:right;     
        }    
         .Boton
        {
            font-family:Tahoma;
            font-size: 7.5pt;   
            padding-left: 10px;
            height: 15px;  
            text-align:left;     
        }    
        .EtiquetaIzq
        {
            font-family:Verdana, Arial;
            font-size: 7.5pt;   
            padding: 1px;    
            height: 20px;    
            text-align:left;               
        }
        .DropDown
        {
            font-family:Verdana, Arial;
            font-size: 7.5pt;           
            text-align :left;
            font-weight: bold;
        }  
        .Check
        {
            font-family:Verdana, Arial;
            font-size: 7.5pt;            
            text-align :left;
            vertical-align:middle; 
        }      
        .pcmSideSpacer {
	        width: 150px;
	        height: 1px;
        }   
        .NombreCentro
        {
            font-family:Verdana, Arial;
            font-size: xx-small;  
            font-weight: bold;  
        }
        .DireccionCentro
        {
            font-family:Verdana, Arial;
            font-size: 7pt;                
        }
    </style>
    <body onload="InicializarMapa()" style="margin:0px;" scroll="no"  >
        <form id="form1" runat="server">           
        <dx:ASPxCallbackPanel runat="server" ID="cpMapa" ShowLoadingPanel="false" ClientInstanceName="cpMapa" >
            <ClientSideEvents EndCallback="OnEndCallback" />            
             <PanelCollection>
                <dx:PanelContent ID="PanelContent1" runat="server">  
                    <div>  
                        <div style="text-align:right; border: solid 1; width:100%">
                            <table cellpadding="0" cellspacing="0" border="0" width="100%">
                                <tr align="right">
                                    <td>
                                        <dx:ASPxButton ID="btnMostrar" runat="server" ClientInstanceName="btnMostrar" AutoPostBack="False" Text="Procesar" Width="80px" CssFilePath="~/App_Themes/Aqua/{0}/styles.css" CssPostfix="Aqua" SpriteCssFilePath="~/App_Themes/Aqua/{0}/sprite.css" >                                                      
                                        <ClientSideEvents Click="ProcesarCriterios" /> 
                                        </dx:ASPxButton>
                                    </td>
                                    <td style="padding-left:5px; width:100px">
                                        <dx:ASPxButton ID="btnCriterios" runat="server" ClientInstanceName="btnCriterios" AutoPostBack="False" Text="Ver Criterios" Width="100px" CssFilePath="~/App_Themes/Aqua/{0}/styles.css" CssPostfix="Aqua" SpriteCssFilePath="~/App_Themes/Aqua/{0}/sprite.css" >                                                      
                                        <ClientSideEvents Click="function(){
                                                            switch(mapaActivo){  
                                                                case 0:     
                                                                    popCriteriosHTP.Show(); 
                                                            }
                                                     }" /> 
                                        </dx:ASPxButton>
                                    </td>
                                    <td style="padding-left:5px; width:85px">
                                        <dx:ASPxButton ID="btnLimpiar" runat="server" AutoPostBack="False" Text="Limpiar" Width="80px" CssFilePath="~/App_Themes/Aqua/{0}/styles.css" CssPostfix="Aqua" SpriteCssFilePath="~/App_Themes/Aqua/{0}/sprite.css" >    
                                            <ClientSideEvents Click="function() {       
                                                            eliminarMapa(mapaActivo);
                                                            switch(mapaActivo){  
                                                                case 0:    
                                                                    cpMapa.PerformCallback('LimpiarCriteriosHTP');                                                                     
                                                                    //cpMapa.PerformCallback('MunicipiosSanSalvador');                                                                     
                                                                                                          
                                                            }                                                                                                                   
                                                    }"  />
                                        </dx:ASPxButton>
                                    </td>
                                </tr>
                            </table>
                        </div>  
                        <table cellpadding="0" cellspacing="0" border="0" style="width: 100%;">
                            <tr>
                                <td>
                                    <dx:ASPxPageControl ID="TabMapas" runat="server" ActiveTabIndex="0" ClientInstanceName="TabMapas" 
                                        EnableHierarchyRecreation="True" Width="100%"
                                        CssFilePath="~/App_Themes/Aqua/{0}/styles.css" 
                                        CssPostfix="Aqua" Font-Names="Verdana, Arial, Tahoma" Font-Size="X-Small" ClientVisible="False" >    
                                        <ClientSideEvents ActiveTabChanged="TabSeleccionado" />
                                        <LoadingPanelImage Url="~/App_Themes/Aqua/Web/Loading.gif">
                                        </LoadingPanelImage>
                                        <ContentStyle>
                                            <Border BorderColor="#4E4F51" BorderStyle="Solid" BorderWidth="1px" />
                                        </ContentStyle>
                                        <TabPages>                
                                         <dx:TabPage Text="Mapa HTP" >
                                            <ContentCollection>              
                                                <dx:ContentControl ID="ContentControl1" runat="server">
                                                    <table id="TblMapa" cellspacing="0" cellpadding="0" border="0" width="100%">                    
                                                        <tr>
                                                            <td>    
                                                                <div>                                                    
                                                                    <table id="TblParametros" border="0" cellpadding="1" cellspacing="0" >
                                                                        <tr>
                                                                            <td class="EtiquetaDer">
                                                                                Ejercicio: 
                                                                            </td>
                                                                            <th colspan="5" class="EtiquetaIzq" >
                                                                                <dx:ASPxComboBox runat="server" ID="cmbEjercicio" Width="75px" 
                                                                                    DropDownStyle="DropDownList" IncrementalFilteringMode="StartsWith" 
                                                                                    DataSourceID="odsEjercicio" TextField="ID_EJERCICIO" 
                                                                                    ValueField="ID_EJERCICIO" ClientInstanceName="cmbEjercicio"  
                                                                                    EnableSynchronization="False" CssFilePath="~/App_Themes/Aqua/{0}/styles.css" 
                                                                                    CssPostfix="Aqua" LoadingPanelImagePosition="Top" ShowShadow="False" 
                                                                                    SpriteCssFilePath="~/App_Themes/Aqua/{0}/sprite.css" 
                                                                                    Font-Names="Arial,Tahoma" Font-Size="XX-Small">    
                                                                                    <ClientSideEvents SelectedIndexChanged="function(s,e){                                                                                                                                
                                                                                                                                cpMapa.PerformCallback('CargarProveedores;' + cmbEjercicio.GetValue().toString());                                                                                                                
                                                                                                                             }" />                                                                 
                                                                                     <LoadingPanelImage Url="~/App_Themes/Aqua/Editors/Loading.gif">
                                                                                     </LoadingPanelImage>
                                                                                     <DropDownButton>
                                                                                         <Image>
                                                                                             <SpriteProperties HottrackedCssClass="dxEditors_edtDropDownHover_Aqua" PressedCssClass="dxEditors_edtDropDownPressed_Aqua" />
                                                                                         </Image>
                                                                                     </DropDownButton>
                                                                                     <ValidationSettings>
                                                                                         <ErrorFrameStyle ImageSpacing="4px">
                                                                                             <ErrorTextPaddings PaddingLeft="4px" />
                                                                                         </ErrorFrameStyle>
                                                                                     </ValidationSettings>
                                                                                </dx:ASPxComboBox>
                                                                            </th>
                                                                        </tr>
                                                                        <tr id="tr1" runat="server">                                                            
                                                                            <td class="EtiquetaDer">
                                                                                Proveedor:     
                                                                            </td>
                                                                            <td>
                                                                                <dx:ASPxComboBox runat="server" ID="cmbProveedor" DropDownStyle="DropDownList" IncrementalFilteringMode="StartsWith" 
                                                                                    DataSourceID="odsProveedor" TextField="NOMBRE_PROVEEDOR" 
                                                                                    ValueField="ID_PROVEEDOR_AF" ClientInstanceName="cmbProveedor" 
                                                                                    EnableSynchronization="False" CssFilePath="~/App_Themes/Aqua/{0}/styles.css" 
                                                                                    CssPostfix="Aqua" LoadingPanelImagePosition="Top" ShowShadow="False" 
                                                                                    SpriteCssFilePath="~/App_Themes/Aqua/{0}/sprite.css" 
                                                                                    Font-Names="Arial,Tahoma" Font-Size="XX-Small">
                                                                                     <ClientSideEvents SelectedIndexChanged="function(s,e){                                                                                                                                
                                                                                                                                cpMapa.PerformCallback('CargarCentros;' + cmbProveedor.GetValue().toString());                                                                                                                
                                                                                                                             }" />
                                                                                     <LoadingPanelImage Url="~/App_Themes/Aqua/Editors/Loading.gif">
                                                                                     </LoadingPanelImage>
                                                                                     <DropDownButton>
                                                                                         <Image>
                                                                                             <SpriteProperties HottrackedCssClass="dxEditors_edtDropDownHover_Aqua" PressedCssClass="dxEditors_edtDropDownPressed_Aqua" />
                                                                                         </Image>
                                                                                     </DropDownButton>
                                                                                     <ValidationSettings>
                                                                                         <ErrorFrameStyle ImageSpacing="4px">
                                                                                             <ErrorTextPaddings PaddingLeft="4px" />
                                                                                         </ErrorFrameStyle>
                                                                                     </ValidationSettings>
                                                                                </dx:ASPxComboBox>
                                                                            </td>    
                                                                            <td class="EtiquetaDer">
                                                                                Centro:     
                                                                            </td>
                                                                            <td style="font-size: small;" >
                                                                                <dx:ASPxComboBox runat="server" ID="cmbCentroFormacion"  
                                                                                    DropDownStyle="DropDownList" IncrementalFilteringMode="StartsWith" 
                                                                                    DataSourceID="odsCentroFormacion" TextField="NOMBRE_SITIO" 
                                                                                    ValueField="ID_SITIO_CAPACITACION" ValueType="System.Int32"  ClientInstanceName="cmbCentroFormacion"  
                                                                                    EnableSynchronization="False" CssFilePath="~/App_Themes/Aqua/{0}/styles.css"
                                                                                    CssPostfix="Aqua" LoadingPanelImagePosition="Top" ShowShadow="False" 
                                                                                    SpriteCssFilePath="~/App_Themes/Aqua/{0}/sprite.css"
                                                                                    Font-Names="Arial,Tahoma" Font-Size="XX-Small">                                      
                                                                                    <ClientSideEvents EndCallback="SetTodos" SelectedIndexChanged="function(s,e){hf.Set('IdSitioCapacitacion_Select',cmbCentroFormacion.GetValue())}"  />                               
                                                                                     <LoadingPanelImage Url="~/App_Themes/Aqua/Editors/Loading.gif">
                                                                                     </LoadingPanelImage>
                                                                                     <DropDownButton>
                                                                                         <Image>
                                                                                             <SpriteProperties HottrackedCssClass="dxEditors_edtDropDownHover_Aqua" PressedCssClass="dxEditors_edtDropDownPressed_Aqua" />
                                                                                         </Image>
                                                                                     </DropDownButton>
                                                                                     <ValidationSettings>
                                                                                         <ErrorFrameStyle ImageSpacing="4px">
                                                                                             <ErrorTextPaddings PaddingLeft="4px" />
                                                                                         </ErrorFrameStyle>
                                                                                     </ValidationSettings>
                                                                                </dx:ASPxComboBox>
                                                                            </td> 
                                                                            <td class="EtiquetaDer">
                                                                                Departamento:     
                                                                            </td>                                                     
                                                                            <td style="font-size: small;">
                                                                                <dx:ASPxComboBox runat="server" ID="cmbDepartamento" 
                                                                                    DropDownStyle="DropDownList" IncrementalFilteringMode="StartsWith" 
                                                                                    DataSourceID="odsDepartamento" TextField="NOMBRE" 
                                                                                    ValueField="CODIGO_DEPARTAMENTO" ClientInstanceName="cmbDepartamento"  
                                                                                    EnableSynchronization="False" CssFilePath="~/App_Themes/Aqua/{0}/styles.css" 
                                                                                    CssPostfix="Aqua" LoadingPanelImagePosition="Top" ShowShadow="False" 
                                                                                    SpriteCssFilePath="~/App_Themes/Aqua/{0}/sprite.css" 
                                                                                    Font-Names="Arial,Tahoma" Font-Size="XX-Small">                                                                     
                                                                                     <LoadingPanelImage Url="~/App_Themes/Aqua/Editors/Loading.gif">
                                                                                     </LoadingPanelImage>
                                                                                     <DropDownButton>
                                                                                         <Image>
                                                                                             <SpriteProperties HottrackedCssClass="dxEditors_edtDropDownHover_Aqua" PressedCssClass="dxEditors_edtDropDownPressed_Aqua" />
                                                                                         </Image>
                                                                                     </DropDownButton>
                                                                                     <ValidationSettings>
                                                                                         <ErrorFrameStyle ImageSpacing="4px">
                                                                                             <ErrorTextPaddings PaddingLeft="4px" />
                                                                                         </ErrorFrameStyle>
                                                                                     </ValidationSettings>
                                                                                </dx:ASPxComboBox>
                                                                            </td>                                                                                                                                                                                                                                                       
                                                                        </tr>                                                                                                                                                                                                                           
                                                                    </table> 
                                                                </div>
                                                            </td>
                                                        </tr>
                                                    </table>       
                                                </dx:ContentControl>
                                            </ContentCollection>
                                         </dx:TabPage>         
                                         <dx:TabPage Text="Mapa PATI">
                                            <ContentCollection>
                                                <dx:ContentControl ID="ContentControl2" runat="server" > 
                                                        <table id="Table2" cellspacing="0" cellpadding="0" border="0" width="100%">                    
                                                        <tr>
                                                            <td>    
                                                                <div style="padding-top:4px;">
                                                                    <table id="Table3" border="0" cellpadding="2" cellspacing="0">
                                                                        <tr id="tr3" runat="server">
                                                                            <td class="EtiquetaDer">
                                                                                Entidad:     
                                                                            </td>
                                                                            <td style="font-size: small;" >
                                                                                <dx:ASPxComboBox runat="server" ID="cmbEntidadPati" ClientInstanceName="cmbEntidadPati"
                                                                                    DataSourceID="odsEntidadPati" TextField="NOMBRE_FUENTE" 
                                                                                    ValueField="ID_FUENTE"
                                                                                    DropDownStyle="DropDownList" IncrementalFilteringMode="StartsWith"                 
                                                                                    EnableSynchronization="False" CssFilePath="~/App_Themes/Aqua/{0}/styles.css" 
                                                                                    CssPostfix="Aqua" LoadingPanelImagePosition="Top" ShowShadow="False" 
                                                                                    SpriteCssFilePath="~/App_Themes/Aqua/{0}/sprite.css" 
                                                                                    Font-Names="Verdana,Arial,Tahoma" Font-Size="X-Small">                                                                     
                                                                                     <LoadingPanelImage Url="~/App_Themes/Aqua/Editors/Loading.gif">
                                                                                     </LoadingPanelImage>
                                                                                     <DropDownButton>
                                                                                         <Image>
                                                                                             <SpriteProperties HottrackedCssClass="dxEditors_edtDropDownHover_Aqua" PressedCssClass="dxEditors_edtDropDownPressed_Aqua" />
                                                                                         </Image>
                                                                                     </DropDownButton>
                                                                                     <ValidationSettings>
                                                                                         <ErrorFrameStyle ImageSpacing="4px">
                                                                                             <ErrorTextPaddings PaddingLeft="4px" />
                                                                                         </ErrorFrameStyle>
                                                                                     </ValidationSettings>
                                                                                </dx:ASPxComboBox>        
                                                                            </td>
                                                                            <td class="EtiquetaDer">
                                                                                Fase:     
                                                                            </td>
                                                                            <td style="font-size: small;" >
                                                                                <dx:ASPxComboBox runat="server" ID="cmbFasePati" ClientInstanceName="cmbFasePati"  
                                                                                    DataSourceID="odsFasePati" TextField="NOMBRE_FASE" 
                                                                                    ValueField="ID_FASE"
                                                                                    DropDownStyle="DropDownList" IncrementalFilteringMode="StartsWith"                                                                                                                                         
                                                                                    EnableSynchronization="False" CssFilePath="~/App_Themes/Aqua/{0}/styles.css" 
                                                                                    CssPostfix="Aqua" LoadingPanelImagePosition="Top" ShowShadow="False" 
                                                                                    SpriteCssFilePath="~/App_Themes/Aqua/{0}/sprite.css" 
                                                                                    Font-Names="Verdana,Arial,Tahoma" Font-Size="X-Small">                                                                     
                                                                                     <LoadingPanelImage Url="~/App_Themes/Aqua/Editors/Loading.gif">
                                                                                     </LoadingPanelImage>
                                                                                     <DropDownButton>
                                                                                         <Image>
                                                                                             <SpriteProperties HottrackedCssClass="dxEditors_edtDropDownHover_Aqua" PressedCssClass="dxEditors_edtDropDownPressed_Aqua" />
                                                                                         </Image>
                                                                                     </DropDownButton>
                                                                                     <ValidationSettings>
                                                                                         <ErrorFrameStyle ImageSpacing="4px">
                                                                                             <ErrorTextPaddings PaddingLeft="4px" />
                                                                                         </ErrorFrameStyle>
                                                                                     </ValidationSettings>
                                                                                </dx:ASPxComboBox>        
                                                                            </td>                                                                                      
                                                                        </tr>                                                                                                             
                                                                    </table> 
                                                                </div>
                                                            </td>
                                                        </tr>
                                                        </table>  
                                                </dx:ContentControl>
                                            </ContentCollection>
                                         </dx:TabPage>      
                                         <dx:TabPage Text="Mapa ISSS">
                                            <ContentCollection>
                                                <dx:ContentControl ID="ContentControl3" runat="server" > 
                                                    <table id="Table1" cellspacing="0" cellpadding="0" border="0" width="100%">                    
                                                        <tr>
                                                            <td>    
                                                                <div style="padding-top:4px;">
                                                                    <table id="Table4" border="0" cellpadding="2" cellspacing="0">
                                                                        <tr id="tr2" runat="server">
                                                                            <td class="EtiquetaDer">
                                                                                Sector:     
                                                                            </td>
                                                                            <td style="font-size: small;" >
                                                                                <dx:ASPxComboBox runat="server" ID="cmbSectorISSS" 
                                                                                    DataSourceID="" TextField="" 
                                                                                    ValueField=""
                                                                                    DropDownStyle="DropDownList" IncrementalFilteringMode="StartsWith"                                                                     
                                                                                    ClientInstanceName="cmbClasificacionISSS"  
                                                                                    EnableSynchronization="False" CssFilePath="~/App_Themes/Aqua/{0}/styles.css" 
                                                                                    CssPostfix="Aqua" LoadingPanelImagePosition="Top" ShowShadow="False" 
                                                                                    SpriteCssFilePath="~/App_Themes/Aqua/{0}/sprite.css" 
                                                                                    Font-Names="Verdana,Arial,Tahoma" Font-Size="X-Small">                                                                     
                                                                                     <LoadingPanelImage Url="~/App_Themes/Aqua/Editors/Loading.gif">
                                                                                     </LoadingPanelImage>
                                                                                     <DropDownButton>
                                                                                         <Image>
                                                                                             <SpriteProperties HottrackedCssClass="dxEditors_edtDropDownHover_Aqua" PressedCssClass="dxEditors_edtDropDownPressed_Aqua" />
                                                                                         </Image>
                                                                                     </DropDownButton>
                                                                                     <ValidationSettings>
                                                                                         <ErrorFrameStyle ImageSpacing="4px">
                                                                                             <ErrorTextPaddings PaddingLeft="4px" />
                                                                                         </ErrorFrameStyle>
                                                                                     </ValidationSettings>
                                                                                </dx:ASPxComboBox>        
                                                                            </td>
                                                                            <td class="EtiquetaDer">
                                                                                Actividad Economica:     
                                                                            </td>
                                                                            <td style="font-size: small;" >
                                                                                <dx:ASPxComboBox runat="server" ID="cmbActividadEconomicaISSS" 
                                                                                    DataSourceID="" TextField="" 
                                                                                    ValueField=""
                                                                                    DropDownStyle="DropDownList" IncrementalFilteringMode="StartsWith"                                                                     
                                                                                    ClientInstanceName="cmbActividadEconomicaISSS"  
                                                                                    EnableSynchronization="False" CssFilePath="~/App_Themes/Aqua/{0}/styles.css" 
                                                                                    CssPostfix="Aqua" LoadingPanelImagePosition="Top" ShowShadow="False" 
                                                                                    SpriteCssFilePath="~/App_Themes/Aqua/{0}/sprite.css" 
                                                                                    Font-Names="Verdana,Arial,Tahoma" Font-Size="X-Small">                                                                     
                                                                                     <LoadingPanelImage Url="~/App_Themes/Aqua/Editors/Loading.gif">
                                                                                     </LoadingPanelImage>
                                                                                     <DropDownButton>
                                                                                         <Image>
                                                                                             <SpriteProperties HottrackedCssClass="dxEditors_edtDropDownHover_Aqua" PressedCssClass="dxEditors_edtDropDownPressed_Aqua" />
                                                                                         </Image>
                                                                                     </DropDownButton>
                                                                                     <ValidationSettings>
                                                                                         <ErrorFrameStyle ImageSpacing="4px">
                                                                                             <ErrorTextPaddings PaddingLeft="4px" />
                                                                                         </ErrorFrameStyle>
                                                                                     </ValidationSettings>
                                                                                </dx:ASPxComboBox>        
                                                                            </td>                                                                  
                                                                        </tr>    
                                                                               
                                                                        <tr id="tr4" runat="server">
                                                                            <td class="EtiquetaDer">
                                                                                Departamento:     
                                                                            </td>
                                                                            <td style="font-size: small;" >
                                                                                <dx:ASPxComboBox runat="server" ID="cmbDepartamentoISSS"  
                                                                                    DataSourceID="" TextField="" 
                                                                                    ValueField=""
                                                                                    DropDownStyle="DropDownList" IncrementalFilteringMode="StartsWith"                                                                     
                                                                                    ClientInstanceName="cmbDepartamentoISSS"  
                                                                                    EnableSynchronization="False" CssFilePath="~/App_Themes/Aqua/{0}/styles.css" 
                                                                                    CssPostfix="Aqua" LoadingPanelImagePosition="Top" ShowShadow="False" 
                                                                                    SpriteCssFilePath="~/App_Themes/Aqua/{0}/sprite.css" 
                                                                                    Font-Names="Verdana,Arial,Tahoma" Font-Size="X-Small">                                                                     
                                                                                     <LoadingPanelImage Url="~/App_Themes/Aqua/Editors/Loading.gif">
                                                                                     </LoadingPanelImage>
                                                                                     <DropDownButton>
                                                                                         <Image>
                                                                                             <SpriteProperties HottrackedCssClass="dxEditors_edtDropDownHover_Aqua" PressedCssClass="dxEditors_edtDropDownPressed_Aqua" />
                                                                                         </Image>
                                                                                     </DropDownButton>
                                                                                     <ValidationSettings>
                                                                                         <ErrorFrameStyle ImageSpacing="4px">
                                                                                             <ErrorTextPaddings PaddingLeft="4px" />
                                                                                         </ErrorFrameStyle>
                                                                                     </ValidationSettings>
                                                                                </dx:ASPxComboBox>        
                                                                            </td>        
                                                                            <td class="EtiquetaDer">
                                                                                Municipio:     
                                                                            </td>
                                                                            <td style="font-size: small;" >
                                                                                <dx:ASPxComboBox runat="server" ID="cmbMunicipioISSS"  
                                                                                    DataSourceID="" TextField="" 
                                                                                    ValueField=""
                                                                                    DropDownStyle="DropDownList" IncrementalFilteringMode="StartsWith"                                                                     
                                                                                    ClientInstanceName="cmbDepartamentoISSS"  
                                                                                    EnableSynchronization="False" CssFilePath="~/App_Themes/Aqua/{0}/styles.css" 
                                                                                    CssPostfix="Aqua" LoadingPanelImagePosition="Top" ShowShadow="False" 
                                                                                    SpriteCssFilePath="~/App_Themes/Aqua/{0}/sprite.css" 
                                                                                    Font-Names="Verdana,Arial,Tahoma" Font-Size="X-Small">                                                                     
                                                                                     <LoadingPanelImage Url="~/App_Themes/Aqua/Editors/Loading.gif">
                                                                                     </LoadingPanelImage>
                                                                                     <DropDownButton>
                                                                                         <Image>
                                                                                             <SpriteProperties HottrackedCssClass="dxEditors_edtDropDownHover_Aqua" PressedCssClass="dxEditors_edtDropDownPressed_Aqua" />
                                                                                         </Image>
                                                                                     </DropDownButton>
                                                                                     <ValidationSettings>
                                                                                         <ErrorFrameStyle ImageSpacing="4px">
                                                                                             <ErrorTextPaddings PaddingLeft="4px" />
                                                                                         </ErrorFrameStyle>
                                                                                     </ValidationSettings>
                                                                                </dx:ASPxComboBox>        
                                                                            </td>                                                                                                                                                   
                                                                        </tr>                    
                                                                        <tr>
                                                                             <td class="EtiquetaDer">
                                                                                Cotiza INSAFORP:     
                                                                            </td>
                                                                            <td style="font-size: small;" >                                                                
                                                                                <dx:ASPxCheckBox ID="chkCotizaINSAFORP" runat="server">
                                                                                </dx:ASPxCheckBox>                                                                
                                                                            </td>    
                                                                            <th colpspan="2"></th>
                                                                        </tr>                                                                                         
                                                                    </table> 
                                                                </div>
                                                            </td>
                                                        </tr>
                                                        </table>  
                                                </dx:ContentControl>
                                            </ContentCollection>
                                         </dx:TabPage>    
                                        </TabPages>
                                    </dx:ASPxPageControl>  
                                </td>
                            </tr>                       
                        </table>   
                    </div>
                    <dx:ASPxPopupControl ID="popCriteriosHTP" Modal="false"  runat="server" 
                        PopupHorizontalAlign="LeftSides"  PopupVerticalAlign="WindowCenter" PopupElementID="BuscarNombresbtn" 
                        AllowResize="False" DragElement="Header" HeaderStyle-Font-Bold="true" HeaderText="Mapa HTP - Criterios de búsqueda" ContentStyle-Paddings-Padding="7px"   
                        AllowDragging="True" ClientInstanceName="popCriteriosHTP" ShowShadow="true" Font-Names="Arial,Tahoma" Font-Size="X-Small"
                        CloseAction="CloseButton" CssFilePath="~/App_Themes/Aqua/{0}/styles.css" CssPostfix="Aqua" SpriteCssFilePath="~/App_Themes/Aqua/{0}/sprite.css" Width="370px">  
                                 <ContentCollection>
                                     <dx:PopupControlContentControl ID="PopupControlContentControl1" runat="server" >          
                                        <table width="100%">               
                                            <tr>
                                                <td>
                                                    <dx:ASPxCheckBox runat="server" id="chkhtpProcedencia" ClientInstanceName="chkhtpProcedencia" Text="Procedencia:" Font-Names="Arial,Tahoma" Font-Size="XX-Small" >
                                                        <ClientSideEvents CheckedChanged="function(s,e){ 
                                                                                                hf.Set('HabilitarCriteriosHTP',s.GetValue())                                                                                                
                                                                                                if(s.GetValue()){
                                                                                                    cmbDeptoProcedencia.SetEnabled(true);                                                                                                    
                                                                                                    chkhtpSexo.SetEnabled(true);
                                                                                                    chkhtpAreaFormativa.SetEnabled(true);                                                                                                    
                                                                                                }
                                                                                                else{
                                                                                                    cmbDeptoProcedencia.SetEnabled(false);                                                                                                   
                                                                                                    
                                                                                                    chkhtpSexo.SetEnabled(false);
                                                                                                    chkhtpSexo.SetValue(false);
                                                                                                    rdbTodos.SetEnabled(false);
                                                                                                    rdbMasculino.SetEnabled(false);
                                                                                                    rdbFemenino.SetEnabled(false);
                                                                                                    spnPorcentajeParticipantes.SetEnabled(false);
                                                                                                    
                                                                                                    chkhtpAreaFormativa.SetEnabled(false);
                                                                                                    chkhtpAreaFormativa.SetValue(false);
                                                                                                    cmbAreaFormacion.SetEnabled(false);                                                                                                                                                                                                       
                                                                                                }                                                                                                
                                                                                          }" />
                                                    </dx:ASPxCheckBox>
                                                </td>
                                                <td class="EtiquetaIzq">
                                                    <table>
                                                        <tr>
                                                            <td>
                                                                <dx:ASPxComboBox runat="server" ID="cmbDeptoProcedencia" 
                                                                    DropDownStyle="DropDownList" IncrementalFilteringMode="StartsWith" 
                                                                    DataSourceID="odsDepartamento" TextField="NOMBRE" 
                                                                    ValueField="CODIGO_DEPARTAMENTO" ClientInstanceName="cmbDeptoProcedencia"  
                                                                    EnableSynchronization="False" CssFilePath="~/App_Themes/Aqua/{0}/styles.css" 
                                                                    CssPostfix="Aqua" LoadingPanelImagePosition="Top" ShowShadow="False" 
                                                                    SpriteCssFilePath="~/App_Themes/Aqua/{0}/sprite.css" 
                                                                    Font-Names="Arial,Tahoma" Font-Size="XX-Small">                                                                     
                                                                     <LoadingPanelImage Url="~/App_Themes/Aqua/Editors/Loading.gif">
                                                                     </LoadingPanelImage>
                                                                     <DropDownButton>
                                                                         <Image>
                                                                             <SpriteProperties HottrackedCssClass="dxEditors_edtDropDownHover_Aqua" PressedCssClass="dxEditors_edtDropDownPressed_Aqua" />
                                                                         </Image>
                                                                     </DropDownButton>
                                                                     <ValidationSettings>
                                                                         <ErrorFrameStyle ImageSpacing="4px">
                                                                             <ErrorTextPaddings PaddingLeft="4px" />
                                                                         </ErrorFrameStyle>
                                                                     </ValidationSettings>
                                                                </dx:ASPxComboBox>
                                                            </td>                                                                                                                        
                                                        </tr>                                                                                                                                        
                                                    </table>           
                                                </td>
                                            </tr>
                                            <tr>
                                                <td style="width:200px">
                                                    <dx:ASPxCheckBox runat="server" id="chkhtpSexo" ClientInstanceName="chkhtpSexo" Text="Sexo:" Font-Names="Arial,Tahoma" Font-Size="XX-Small" >
                                                        <ClientSideEvents CheckedChanged="function(s,e){
                                                                                                if(s.GetValue()){                                                                                                   
                                                                                                    rdbTodos.SetEnabled(true);
                                                                                                    rdbMasculino.SetEnabled(true);
                                                                                                    rdbFemenino.SetEnabled(true);
                                                                                                    spnPorcentajeParticipantes.SetEnabled(true);                                                                                                     
                                                                                                }
                                                                                                else{                                                                                                    
                                                                                                     rdbTodos.SetEnabled(false);
                                                                                                    rdbMasculino.SetEnabled(false);
                                                                                                    rdbFemenino.SetEnabled(false);
                                                                                                    spnPorcentajeParticipantes.SetEnabled(false);                                                                                                                                                                                                                                                                                                      
                                                                                                }                       
                                                                                            }" />
                                                    </dx:ASPxCheckBox>                                                    
                                                </td>
                                                <td class="EtiquetaIzq">      
                                                    <table>
                                                        <tr>
                                                            <td>
                                                            <dx:ASPxRadioButton ID="rdbTodos" ClientInstanceName="rdbTodos"  runat="server" GroupName="Genero"  Text="Todos" Checked="true" 
                                                                    Font-Names="Arial,Tahoma" Font-Size="XX-Small" /> 
                                                            </td>
                                                            <td>
                                                            <dx:ASPxRadioButton ID="rdbMasculino" ClientInstanceName="rdbMasculino" runat="server" GroupName="Genero" Text="Hombres"   
                                                                    Font-Names="Arial,Tahoma" Font-Size="XX-Small" />     
                                                            </td>
                                                            <td>
                                                            <dx:ASPxRadioButton ID="rdbFemenino" ClientInstanceName="rdbFemenino" runat="server" GroupName="Genero" Text="Mujeres" 
                                                                    Font-Names="Arial,Tahoma" Font-Size="XX-Small" /> 
                                                            </td>                                                            
                                                        </tr>       
                                                        <tr>
                                                            <th colspan="3" >
                                                                <dx:ASPxSpinEdit ID="spnPorcentajeParticipantes" AllowUserInput="true" runat="server" Width="70px" DisplayFormatString="{0}%" ClientInstanceName="spnPorcentajeParticipantes" 
                                                                    MinValue="1" Increment="1" MaxValue="100" Number="100" Font-Names="Arial,Tahoma" Font-Size="XX-Small"
                                                                    CssFilePath="~/App_Themes/Aqua/{0}/styles.css" CssPostfix="Aqua" Height="21px" SpriteCssFilePath="~/App_Themes/Aqua/{0}/sprite.css" >
                                                                    <SpinButtons>
                                                                        <IncrementImage>
                                                                            <SpriteProperties HottrackedCssClass="dxEditors_edtSpinEditIncrementImageHover_Aqua" PressedCssClass="dxEditors_edtSpinEditIncrementImagePressed_Aqua" />
                                                                        </IncrementImage>
                                                                        <DecrementImage>
                                                                            <SpriteProperties HottrackedCssClass="dxEditors_edtSpinEditDecrementImageHover_Aqua" PressedCssClass="dxEditors_edtSpinEditDecrementImagePressed_Aqua" />
                                                                        </DecrementImage>
                                                                        <LargeIncrementImage>
                                                                            <SpriteProperties HottrackedCssClass="dxEditors_edtSpinEditLargeIncImageHover_Aqua" PressedCssClass="dxEditors_edtSpinEditLargeIncImagePressed_Aqua" />
                                                                        </LargeIncrementImage>
                                                                        <LargeDecrementImage>
                                                                            <SpriteProperties HottrackedCssClass="dxEditors_edtSpinEditLargeDecImageHover_Aqua" PressedCssClass="dxEditors_edtSpinEditLargeDecImagePressed_Aqua" />
                                                                        </LargeDecrementImage>
                                                                    </SpinButtons>
                                                                </dx:ASPxSpinEdit>
                                                            </th> 
                                                        </tr>                                                                                                                                 
                                                    </table>                                                          
                                                </td>   
                                            </tr>
                                            <tr>
                                                <td><dx:ASPxCheckBox runat="server" id="chkhtpAreaFormativa" ClientInstanceName="chkhtpAreaFormativa" Text="Area Formativa:" Font-Names="Arial,Tahoma" Font-Size="XX-Small" >
                                                    <ClientSideEvents CheckedChanged="function(s,e){
                                                                                                if(s.GetValue()){                                                                                                   
                                                                                                    cmbAreaFormacion.SetEnabled(true);                                                                                                   
                                                                                                }
                                                                                                else{                                                                                                    
                                                                                                    cmbAreaFormacion.SetEnabled(false);                                                                                                    
                                                                                                }                       
                                                                                            }" />
                                                    </dx:ASPxCheckBox>                             
                                                </td>
                                                <td>
                                                    <dx:ASPxComboBox ID="cmbAreaFormacion" runat="server" ClientInstanceName="cmbAreaFormacion" CssFilePath="~/App_Themes/Aqua/{0}/styles.css" CssPostfix="Aqua" DataSourceID="odsAreaFormacion" EnableIncrementalFiltering="True" EnableSynchronization="False" Font-Names="Arial,Tahoma" Font-Size="XX-Small" IncrementalFilteringMode="StartsWith" LoadingPanelImagePosition="Top" ShowShadow="False" SpriteCssFilePath="~/App_Themes/Aqua/{0}/sprite.css" TextField="AREA_FORMACION" ValueField="ID_AREA_FORMACION" ValueType="System.Int32">
                                                    <ClientSideEvents SelectedIndexChanged="function(s,e){
                                                                                                hf.Set('IdAreaFormacion_Select',s.GetValue())   
                                                                                            }"  />
                                                        <LoadingPanelImage Url="~/App_Themes/Aqua/Editors/Loading.gif">
                                                        </LoadingPanelImage>
                                                        <DropDownButton>
                                                            <Image>
                                                                <SpriteProperties HottrackedCssClass="dxEditors_edtDropDownHover_Aqua" PressedCssClass="dxEditors_edtDropDownPressed_Aqua" />
                                                            </Image>
                                                        </DropDownButton>
                                                        <ValidationSettings>
                                                            <ErrorFrameStyle ImageSpacing="4px">
                                                                <ErrorTextPaddings PaddingLeft="4px" />
                                                            </ErrorFrameStyle>
                                                        </ValidationSettings>
                                                    </dx:ASPxComboBox>
                                                </td>
                                            </tr>                                                                      
                                        </table>             
                                     </dx:PopupControlContentControl>
                                 </ContentCollection>

                                 <ContentStyle VerticalAlign="Top">
<Paddings Padding="7px"></Paddings>
                                 </ContentStyle>

                                <HeaderStyle Font-Bold="True"></HeaderStyle>
                    </dx:ASPxPopupControl> 
                    <dx:ASPxHiddenField runat="server" ID="hf" ClientInstanceName="hf" SyncWithServer="true" /> 
                </dx:PanelContent>
            </PanelCollection>
        </dx:ASPxCallbackPanel>    
        
        <asp:ObjectDataSource ID="odsProveedor" runat="server" 
            OldValuesParameterFormatString="original_{0}"
            SelectMethod="ObtenerListaProveedoresHTP" TypeName="SGAFP.BL.cPROVEEDOR_AF">
            <SelectParameters>                       
                <asp:Parameter DefaultValue="" Name="ID_EJERCICIO" Type="String" />
                <asp:Parameter DefaultValue="NOMBRE_PROVEEDOR" Name="asColumnaOrden" Type="String" />
                <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
            </SelectParameters>
        </asp:ObjectDataSource>
        <asp:ObjectDataSource ID="odsDepartamento" runat="server" 
            OldValuesParameterFormatString="original_{0}"
            SelectMethod="ObtenerLista" TypeName="SGAFP.BL.cDEPARTAMENTO">
            <SelectParameters>                        
                <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
                <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />        
                <asp:Parameter DefaultValue="NOMBRE" Name="asColumnaOrden" Type="String" />
                <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
            </SelectParameters>
        </asp:ObjectDataSource>
        <asp:ObjectDataSource ID="odsPais" runat="server" 
            OldValuesParameterFormatString="original_{0}"
            SelectMethod="ObtenerListaPorEjercicioProveedorSitio" TypeName="SGAFP.BL.cPAIS">
            <SelectParameters>                        
                <asp:Parameter DefaultValue="" Name="ID_EJERCICIO" Type="String" />
                <asp:Parameter DefaultValue="" Name="ID_PROVEEDOR_AF" Type="Decimal"  />
                <asp:Parameter DefaultValue="" Name="ID_SITIO_CAPACITACION" Type="Decimal" />                
                <asp:Parameter DefaultValue="NOMBRE_PAIS" Name="asColumnaOrden" Type="String" />
                <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
            </SelectParameters>
        </asp:ObjectDataSource>
        <asp:ObjectDataSource ID="odsCentroFormacion" runat="server" 
            OldValuesParameterFormatString="original_{0}"
            SelectMethod="ObtenerListaPorPROVEEDOR_AF" TypeName="SGAFP.BL.cSITIO_CAPACITACION">
            <SelectParameters>            
                <asp:Parameter DefaultValue="" Name="ID_PROVEEDOR_AF" Type="Decimal" />
                <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
                <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />        
                <asp:Parameter DefaultValue="NOMBRE_SITIO" Name="asColumnaOrden" Type="String" />
                <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
            </SelectParameters>
        </asp:ObjectDataSource>
        <asp:ObjectDataSource ID="odsAreaFormacion" runat="server" 
            OldValuesParameterFormatString="original_{0}"
            SelectMethod="ObtenerListaPorProveedorEjercicio" TypeName="SGAFP.BL.cAREA_FORMACION">
            <SelectParameters>                        
                <asp:Parameter DefaultValue="-1" Name="ID_PROVEEDOR_AF" Type="Decimal" />
                <asp:Parameter DefaultValue="" Name="ID_EJERCICIO" Type="String" />
                <asp:Parameter DefaultValue="AREA_FORMACION" Name="asColumnaOrden" Type="String" />
                <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
            </SelectParameters>
        </asp:ObjectDataSource>
        <asp:ObjectDataSource ID="odsEjercicio" runat="server" 
            OldValuesParameterFormatString="original_{0}"
            SelectMethod="ObtenerLista" TypeName="SGAFP.BL.cEJERCICIO">
            <SelectParameters>                        
                <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />            
                <asp:Parameter DefaultValue="ID_EJERCICIO" Name="asColumnaOrden" Type="String" />
                <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
            </SelectParameters>
        </asp:ObjectDataSource>    
        <asp:ObjectDataSource ID="odsEntidadPati" runat="server" 
            OldValuesParameterFormatString="original_{0}"
            SelectMethod="ObtenerLista" TypeName="SGAFP.BL.cFUENTE_FINANCIAMIENTO">
            <SelectParameters>                        
                <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />            
                <asp:Parameter DefaultValue="NOMBRE_FUENTE" Name="asColumnaOrden" Type="String" />
                <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
            </SelectParameters>
        </asp:ObjectDataSource>
        <asp:ObjectDataSource ID="odsFasePati" runat="server" 
            OldValuesParameterFormatString="original_{0}"
            SelectMethod="ObtenerLista" TypeName="SGAFP.BL.cFASE">
            <SelectParameters>                        
                <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />            
                <asp:Parameter DefaultValue="NOMBRE_FASE" Name="asColumnaOrden" Type="String" />
                <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
            </SelectParameters>
        </asp:ObjectDataSource>
        <dx:ASPxLoadingPanel ID="Cargando" runat="server"  ClientInstanceName="Cargando" Text="Cargando..."  
            Modal="True" CssFilePath="~/App_Themes/Aqua/{0}/styles.css" CssPostfix="Aqua" ImagePosition="Top" >
            <Image Url="~/App_Themes/Aqua/Web/Loading.gif">
            </Image>
        </dx:ASPxLoadingPanel>
        </form>
        <div id="map_canvas" style="width: 100%; height: 100%"></div>      
    </body>
</html>
