require (["esri/config", "esri/Map", "esri/views/MapView", "esri/layers/FeatureLayer", "esri/layers/WMSLayer"],
    function(esriConfig, Map, MapView, FeatureLayer, WMSLayer){
    
    esriConfig.apiKey="AAPK81509221ae8b49458f20b53d523169c9coujw2sbl-hg3Xp3n_AkIv4ds64xLz-pGXxEuyHfyq-qlcQgDa_DqDjVXtItHzTO";
    
    //const wmsUrl="http://127.0.0.1/qgisserver/cgi-bin/qgis_mapserv.fcgi?MAP=/home/barramou/dotNetProjects/labs/casablanca.qgs&SERVICE=WMS&REQUEST=GetCapabilities";
    const wmsUrl="http://172.205.217.231/qgisserver/cgi-bin/qgis_mapserv.fcgi?MAP=/home/gisadmin/Documents/projects/casavm.qgs&SERVICE=WMS&REQUEST=GetCapabilities";
    
   const wmsLayer = new WMSLayer({
       url: wmsUrl,
        sublayers: [
            { name: "Commune" },
            { name: "Site" }
        ]
        });
        
    
    const map=new Map({
    
        basemap: "streets-vector",
        layers: [wmsLayer]
        
    });
    
    const view=new MapView({
    
        map: map,
        center: [-7.62, 33.59], // Longitude, latitude
        zoom: 9, // Zoom level
        container: "mapDiv"
    });
    
    
});