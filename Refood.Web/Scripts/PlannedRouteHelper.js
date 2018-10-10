
// ################################################################
//                      Code generated with T4
// ################################################################

var Web = Web || {};

// viewmodel

Web.plannedRoute = function ( plannedRouteId, name, routeTypeId, transportTypeId, description, startHour, estimatedDuration, totalDistance, routeDayOfTheWeek, active, isDeleted) {
    this.plannedRouteId = ko.observable(plannedRouteId);
    this.name = ko.observable(name);
    this.routeTypeId = ko.observable(routeTypeId);
    this.transportTypeId = ko.observable(transportTypeId);
    this.description = ko.observable(description);
    this.startHour = ko.observable(startHour);
    this.estimatedDuration = ko.observable(estimatedDuration);
    this.totalDistance = ko.observable(totalDistance);
    this.routeDayOfTheWeek = ko.observable(routeDayOfTheWeek);
    this.active = ko.observable(active);
    this.isDeleted = ko.observable(isDeleted);


    // remove

    this.remove = function (model, event) {
        model.isDeleted(true);
        model.isVisible(false);
    };


    this.visibleOnSearch = ko.observable(true);
    this.isVisible = ko.observable(!isDeleted);
}


// helper

Web.plannedRouteHelper = function (isLoading, serviceRootUrl, moduleHeaders) {

    var plannedRouteList = ko.observableArray([]);
    var deletedPlannedRouteList = ko.observableArray([]);
    var isLoading = isLoading;
    var serviceRootUrl = serviceRootUrl;
    var moduleHeaders = moduleHeaders;
    var searchText = ko.observable('');


    // get

    var getPlannedRouteList = function () {
        isLoading(true);

        // need to calculate a different Url for PlannedRoute service
        var restUrl = serviceRootUrl + "PlannedRoute/GetList/";
        var jqXHR = $.ajax({
            url: restUrl,
            beforeSend: moduleHeaders,
            dataType: "json",
            async: false
        }).done(function (data) {
            if (data) {
                loadPlannedRoutes(data);
            }
            else {
                clear();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };




    // load

    var loadPlannedRoutes = function (data) {
        plannedRouteList.removeAll();
        var underlyingArray = plannedRouteList();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var plannedRoute = new Web.plannedRoute
            (
                result.plannedRouteId, 
                result.name, 
                result.routeTypeId, 
                result.transportTypeId, 
                result.description, 
                result.startHour, 
                result.estimatedDuration, 
                result.totalDistance, 
                result.routeDayOfTheWeek, 
                result.active, 
                result.isDeleted 
            );
            underlyingArray.push(plannedRoute);
        }
        plannedRouteList.valueHasMutated();
    };


    // extract knockout array to simple json objects

    var extractKoArrayToJson = function (data) {
        var simpleArray = new Array();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var plannedRoute = {
                plannedRouteId: result.plannedRouteId(), 
                name: result.name(), 
                routeTypeId: result.routeTypeId(), 
                transportTypeId: result.transportTypeId(), 
                description: result.description(), 
                startHour: result.startHour(), 
                estimatedDuration: result.estimatedDuration(), 
                totalDistance: result.totalDistance(), 
                routeDayOfTheWeek: result.routeDayOfTheWeek(), 
                active: result.active(), 
                isDeleted: result.isDeleted() 
            };

            simpleArray.push(plannedRoute);
        }
        return simpleArray;
    };


    // add

    var addPlannedRoute = function () {
        var plannedRoute = new Web.plannedRoute(0, '', '', '', '');
        plannedRouteList.push(plannedRoute);
    };


    // remove

    var removePlannedRoute = function (model, event) {
        var plannedRoute = model;
        plannedRoute.isDeleted = true;
        deletedPlannedRouteList.push(plannedRoute);
        plannedRouteList.pop(plannedRoute);
    };


    // clear

    var clear = function () {
        plannedRouteList([]);
    };


    // quickSearch

    var quickSearch = function () {
        for (var i = 0; i < plannedRouteList().length; i++) {
            var result = plannedRouteList()[i];

            if(searchText() == null || searchText() == '' || (result.description() != null && result.description().toLowerCase().indexOf(searchText().toLowerCase()) >= 0))
            {
                result.visibleOnSearch(true);
            }
            else
            {
                result.visibleOnSearch(false);
            }
        }
    };

    $('#searchText').keyup(function() { quickSearch(); });
    

    return {
        plannedRouteList: plannedRouteList,
        deletedPlannedRouteList: deletedPlannedRouteList,
        getPlannedRouteList: getPlannedRouteList,
        loadPlannedRoutes: loadPlannedRoutes,
        isLoading: isLoading,
        addPlannedRoute: addPlannedRoute,
        removePlannedRoute: removePlannedRoute,
        clear: clear,
        searchText: searchText,
        quickSearch: quickSearch,
        extractKoArrayToJson: extractKoArrayToJson
    };
}
    