
// ################################################################
//                      Code generated with T4
// ################################################################

var Web = Web || {};

Web.plannedRouteViewModel = function (moduleId, resx) {
    var baseUrl = "/PlannedRoute/";

    var plannedRouteId = ko.observable(-1);
    var name = ko.observable('');
    var routeTypeId = ko.observable(-1);
    var transportTypeId = ko.observable(-1);
    var description = ko.observable('');
    var startHour = ko.observable('');
    var estimatedDuration = ko.observable('');
    var totalDistance = ko.observable('');
    var routeDayOfTheWeek = ko.observable('');
    var active = ko.observable('');
    var isDeleted = ko.observable('');
    var userList = ko.observableArray([]);
    var isLoading = ko.observable(false);



    // helpers
    //var routeTypeHelper = Web.routeTypeHelper(isLoading, '/', function(){});
    //var transportTypeHelper = Web.transportTypeHelper(isLoading, '/', function(){});
    var supplierHelper = Web.supplierHelper(isLoading, '/', function () { });
    var supplierTypeHelper = Web.supplierTypeHelper(isLoading, '/', function () { });
    var checkpointHelper = Web.checkpointHelper(isLoading, '/', function () { });

    // google maps
    var map;
    var directionsService;
    var directionsDisplay;
    var markerArray = [];



    // #######################################################################################
    // init
    // #######################################################################################

    var init = function () {
        var qs = getQueryStrings();
        var plannedRouteId = qs["tid"];
        if (plannedRouteId) {
            getPlannedRoute(plannedRouteId);
        }
        //getUserList();

        //routeTypeHelper.getRouteTypeList();
        //transportTypeHelper.getTransportTypeList();
        
        // get lists
        supplierTypeHelper.getSupplierTypeList();
        supplierHelper.getSupplierList(function getSupplierListCallback(data) {
            // load all suppliers to map
            loadSupplierListToMap(map);
        });
        
        if (plannedRouteId) {
            // get checkpoints
            checkpointHelper.getListByPlannedRouteId(plannedRouteId, function getListByPlannedRouteIdCallback(data) {
                // load current route checkpoints to map
                loadRoutePathsToMap(map);
            });
        }
    };

    var getQueryStrings = function () {
        var assoc = {};
        var decode = function (s) { return decodeURIComponent(s.replace(/\+/g, " ")); };
        var queryString = location.search.substring(1);
        var keyValues = queryString.split('&');

        for (var i = 0; i < keyValues.length; i++) {
            var key = keyValues[i].split('=');
            if (key.length > 1) {
                assoc[decode(key[0])] = decode(key[1]);
            }
        }

        return addRewriteQueryString(assoc, decode);
    };

    var addRewriteQueryString = function (hash, decode) {
        var path = location.pathname;
        var queryString = path.substring(path.search('/ctl/') + 1);
        var keyValues = queryString.split('/');

        for (var i = 0; i < keyValues.length; i += 2) {
            hash[decode(keyValues[i])] = decode(keyValues[i + 1])
        }

        return hash;
    };



    // #######################################################################################
    // map
    // #######################################################################################

    // init map

    var initMap = function () {
        // directions service
        directionsService = new google.maps.DirectionsService;
        directionsDisplay = new google.maps.DirectionsRenderer;

        // main map
        map = new google.maps.Map(document.getElementById('map'), {
            center: { lat: 38.7223, lng: -9.1393 }, // Lisboa
            zoom: 13
        });
        directionsDisplay.setMap(map);

        // Instantiate an info window to hold directions step text.
        var stepDisplay = new google.maps.InfoWindow;

        // load refood data to map
        loadSupplierListToMap(map);
        loadRoutePathsToMap(map);
    };


    // load suppliers to map

    var loadSupplierListToMap = function (map) {
        if (map != null && supplierHelper.supplierList().length > 0) {
            console.log("load suppliers to map - count: " + supplierHelper.supplierList().length);

            // https://developers.google.com/maps/documentation/javascript/adding-a-google-map
            for (var i = 0; i < supplierHelper.supplierList().length; i++) {
                var currentSupplier = supplierHelper.supplierList()[i];
                var supplierCoordinates = { lat: currentSupplier.latitude(), lng: currentSupplier.longitude() };

                var supplierMarker = new google.maps.Marker({
                    position: supplierCoordinates,
                    label: i.toString(),
                    //icon: 'dining',
                    map: map
                });

                console.log("adding supplier to map: " + currentSupplier.name() + " (" + currentSupplier.latitude() + ", " + currentSupplier.longitude() + ")");
            }
        }
    };


    // load route paths to map
    // Directions Service - https://developers.google.com/maps/documentation/javascript/directions
    // Directions Service (Complex) - https://developers.google.com/maps/documentation/javascript/examples/directions-complex

    var loadRoutePathsToMap = function (map) {
        if (map != null && supplierHelper.supplierList().length > 0) {
            console.log("load route paths to map - count: " + supplierHelper.supplierList().length);

            // TODO - add starting point = nucleo coordinates
            var nucleoCoordinates = '38.739497, -9.150911'; // teste - Núcleo Nossa Senhora de Fátima
            var startPoint = nucleoCoordinates;
            var endPoint = nucleoCoordinates;

            // Travel modes: 'DRIVING', 'WALKING', 'BICYCLING', 'TRANSIT'
            var travelMode = 'WALKING';

            // waypoints
            var waypoints = [];

            // add each supplier to the route
            for (var i = 0; i < supplierHelper.supplierList().length; i++) {
                var currentSupplier = supplierHelper.supplierList()[i];
                var currentPointText = currentSupplier.latitude() + ", " + currentSupplier.longitude();

                waypoints.push({
                    location: currentPointText,
                    stopover: true
                });
            }

            // TODO - add ending point = nucleo coordinates

            // calculate route with waypoints
            calculateAndDisplayRouteWithWaypoints(directionsService, directionsDisplay, startPoint, endPoint, waypoints, travelMode);
        }
    };


    // calculate and display route

    function calculateAndDisplayRoute(directionsService, directionsDisplay, startPoint, endPoint) {

        directionsService.route({
            origin: startPoint,
            destination: endPoint,
            travelMode: 'DRIVING' // Travel modes: 'DRIVING', 'WALKING', 'BICYCLING', 'TRANSIT'
        }, function (response, status) {
            if (status === 'OK') {
                directionsDisplay.setDirections(response);
            } else {
                window.alert('Directions request failed due to ' + status);
            }
        });
    }


    // calculate and display route with waypoints

    function calculateAndDisplayRouteWithWaypoints(directionsService, directionsDisplay, startPoint, endPoint, waypoints, travelMode) {

        directionsService.route({
            origin: startPoint,
            destination: endPoint,
            waypoints: waypoints,
            optimizeWaypoints: true,
            travelMode: travelMode // Travel modes: 'DRIVING', 'WALKING', 'BICYCLING', 'TRANSIT'
        }, function (response, status) {
            if (status === 'OK') {
                directionsDisplay.setDirections(response);

                var route = response.routes[0];
                var summaryPanel = document.getElementById('directions-panel');
                summaryPanel.innerHTML = '';

                // For each route segment, display summary information.
                for (var i = 0; i < route.legs.length; i++) {
                    var routeSegment = i + 1;
                    summaryPanel.innerHTML += '<b>Route Segment: ' + routeSegment +
                        '</b><br>';
                    summaryPanel.innerHTML += route.legs[i].start_address + ' to ';
                    summaryPanel.innerHTML += route.legs[i].end_address + '<br>';
                    summaryPanel.innerHTML += route.legs[i].distance.text + '<br><br>';
                }
            } else {
                window.alert('Directions request failed due to ' + status);
            }
        });
    }



    // #######################################################################################
    // ajax
    // #######################################################################################

    // get

    var getPlannedRoute = function (plannedRouteId) {
        isLoading(true);

        var restUrl = baseUrl + "Get/?id=" + plannedRouteId;
        var jqXHR = $.ajax({
            url: restUrl,
            dataType: "json"
        }).done(function (data) {
            if (data) {
                load(data);
            }
            else {
                clear();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };



    // load

    var load = function (data) {
        plannedRouteId(data.plannedRouteId);
        name(data.name);
        routeTypeId(data.routeTypeId);
        transportTypeId(data.transportTypeId);
        description(data.description);
        startHour(serverDateTimeStringToJavascriptDate(data.startHour));
        estimatedDuration(data.estimatedDuration);
        totalDistance(data.totalDistance);
        routeDayOfTheWeek(data.routeDayOfTheWeek);
        active(data.active);
        isDeleted(data.isDeleted);
    };

    

    // save

    var save = function () {
        isLoading(true);
        var plannedRoute = {
            plannedRouteId: plannedRouteId(),
            name: name(),
            routeTypeId: routeTypeId(),
            transportTypeId: transportTypeId(),
            description: description(),
            startHour: dateToStringServerFormat(startHour()),
            estimatedDuration: estimatedDuration(),
            totalDistance: totalDistance(),
            routeDayOfTheWeek: routeDayOfTheWeek(),
            active: active(),
            isDeleted: isDeleted(),
        };
        var ajaxMethod = "POST";
        var restUrl = baseUrl + "Upsert/";

        if (plannedRoute.plannedRouteId > 0) {
            // ajaxMethod = "PATCH";
            restUrl += plannedRoute.plannedRouteId;
        }
        else {
            restUrl += 0;
        }

        var jqXHR = $.ajax({
            method: ajaxMethod,
            url: restUrl,
            contentType: "application/json; charset=UTF-8",
            data: JSON.stringify(plannedRoute),
            dataType: "json"
        }).done(function (data) {
            console.log(data);
            toastr.success('Gravado com sucesso');
        }).always(function (data) {
            isLoading(false);
        });
    };

    // clear

    var clear = function () {
        plannedRouteId('');
        name('');
        routeTypeId('');
        transportTypeId('');
        description('');
        startHour('');
        estimatedDuration('');
        totalDistance('');
        routeDayOfTheWeek('');
        active('');
        isDeleted('');
    };


    
    // cancel

    var cancel = function () {
        dnnModal.closePopUp(false);
    };



    // return viewmodel

    return {
        plannedRouteId: plannedRouteId,
        name: name,
        routeTypeId: routeTypeId,
        transportTypeId: transportTypeId,
        description: description,
        startHour: startHour,
        estimatedDuration: estimatedDuration,
        totalDistance: totalDistance,
        routeDayOfTheWeek: routeDayOfTheWeek,
        active: active,
        isDeleted: isDeleted,
        userList: userList,
        cancel: cancel,
        load: load,
        save: save,
        init: init,
        isLoading: isLoading,
        //routeTypeList: routeTypeHelper.routeTypeList,
        //transportTypeList: transportTypeHelper.transportTypeList,
        supplierHelper: supplierHelper,
        supplierTypeHelper: supplierTypeHelper,
        checkpointHelper: checkpointHelper,
        map: map,
        initMap: initMap,
        directionsService: directionsService,
        directionsDisplay: directionsDisplay,
        loadSupplierListToMap: loadSupplierListToMap
    };
}

Web.user = function (id, name) {
    this.id = id;
    this.name = name;
}



// aux

// date picker

ko.bindingHandlers.datepicker = {
    init: function (element, valueAccessor, allBindingsAccessor) {
        //initialize datepicker with some optional options
        var options = allBindingsAccessor().datepickerOptions || {},
            $el = $(element);

        $el.datepicker(options);

        //handle the field changing
        ko.utils.registerEventHandler(element, "change", function () {
            var observable = valueAccessor();
            observable($el.datepicker("getDate"));
        });

        //handle disposal (if KO removes by the template binding)
        ko.utils.domNodeDisposal.addDisposeCallback(element, function () {
            $el.datepicker("destroy");
        });

    },
    update: function (element, valueAccessor) {
        var value = ko.utils.unwrapObservable(valueAccessor()),
            $el = $(element);

        //handle date data coming via json from Microsoft
        if (String(value).indexOf('/Date(') == 0) {
            value = new Date(parseInt(value.replace(/\/Date\((.*?)\)\//gi, "$1")));
        }

        var current = $el.datepicker("getDate");

        if (value - current !== 0) {
            $el.datepicker("setDate", value);
        }
    }
};



// date format

function dateToStringServerFormat(d) {
    // server format: 2017-10-20T00:00:00
    var datestring = d.getFullYear() + "-" + ("0" + (d.getMonth() + 1)).slice(-2) + "-" + ("0" + d.getDate()).slice(-2) + "T00:00:00";
    return datestring;
}

function serverDateTimeStringToJavascriptDate(dateString) {

    // server format: 2017-10-20T00:00:00
    // desired format: 20-10-2017

    var date;
    if (dateString != null && dateString.length >= 10) {

        var day = dateString.substring(8, 10);
        // javascript datetime months have a zero based index
        var month = dateString != null ? parseInt(dateString.substring(5, 7)) - 1 : 0; 
        var year = dateString.substring(0, 4);

        var hours = dateString.substring(11, 13);
        var minutes = dateString.substring(14, 16);
        var seconds = dateString.substring(17, 19);

        date = new Date(year, month, day, hours, minutes, seconds);
    }
    return date;
}

function dateTimeToStringServerFormat(d) {
    // server format: 2017-10-20T00:00:00
    if (d != null)
    {
        var datestring = d.getFullYear() + "-" + ("0" + (d.getMonth() + 1)).slice(-2) + "-" + ("0" + d.getDate()).slice(-2)
            + "T" + ("0" + d.getHours()).slice(-2) + ":" + ("0" + d.getMinutes()).slice(-2) + ":00";
        return datestring;
    }
    else
    {
        return null;
    }
}



    