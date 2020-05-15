requirejs.config({
    //By default load any module IDs from js/lib
    baseUrl: '/Scripts/app',
    //except, if the module ID starts with "app",
    //load it from the js/app directory. paths
    //config is relative to the baseUrl, and
    //never includes a ".js" extension since
    //the paths config could be for a directory.
    paths: {
        app: '../app',
        domReady: "/lib/domReady",
        jquery: "/lib/jquery/dist/jquery.min",
        bootstrap: "/lib/bootstrap/dist/js/bootstrap.bundle.min",
        site: "/js/site"
    }
});

requirejs(['jquery', 'bootstrap', 'site'], function ($, bootstrap, site) {
  //jQuery, canvas and the app/sub module are all
  //loaded and can be used here now.
});
