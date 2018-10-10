
// ################################################################
//                      Code generated with T4
// ################################################################

var Web = Web || {};

Web.plannedRouteListViewModel = function (moduleId, resx) {
    var baseUrl = "/PlannedRoute/";

    var isLoading = ko.observable(false);
    var plannedRouteList = ko.observableArray([]);
    var editMode = ko.computed(function () {
        return plannedRouteList().length > 0 && plannedRouteList()[0].editUrl() != null && plannedRouteList()[0].editUrl().length > 0;
    });
    var searchText = ko.observable('');



    // filters

    var nameFilter = ko.observable('');
    var routeTypeIdFilter = ko.observable(-1);
    var transportTypeIdFilter = ko.observable(-1);
    var descriptionFilter = ko.observable('');
    var startHourFromFilter = ko.observable('');
    var startHourToFilter = ko.observable('');
    var estimatedDurationFilter = ko.observable('');
    var totalDistanceFilter = ko.observable('');
    var routeDayOfTheWeekFilter = ko.observable('');
    var activeFilter = ko.observable('');



    // helpers

    var routeTypeHelper = Web.routeTypeHelper(isLoading, '/', function(){});
    var transportTypeHelper = Web.transportTypeHelper(isLoading, '/', function(){});



    // init

    var init = function () {
        //getPlannedRouteList();
        //getPlannedRoutePage();
        getPlannedRouteListAdvanced();

        routeTypeHelper.getRouteTypeList();
        transportTypeHelper.getTransportTypeList();
    }



    // get list

    var getPlannedRouteList = function () {
        isLoading(true);
        var jqXHR = $.ajax({
            url: baseUrl + "GetList/0/",
            dataType: "json"
        }).done(function (data) {
            if (data) {
                load(data);

                // update datatable
                updateDatatable(data);
            }
            else {
                // No data to load 
                plannedRouteList.removeAll();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };



    // get list - advanced search

    var getPlannedRouteListAdvanced = function () {
        isLoading(true);

        var searchFilters = "?";
        searchFilters += (nameFilter() != '' ? "name=" + nameFilter() : "");
        searchFilters += (routeTypeIdFilter() != -1 && routeTypeIdFilter() != undefined ? "&" + "routeTypeId=" + routeTypeIdFilter() : "");
        searchFilters += (transportTypeIdFilter() != -1 && transportTypeIdFilter() != undefined ? "&" + "transportTypeId=" + transportTypeIdFilter() : "");
        searchFilters += (descriptionFilter() != '' ? "description=" + descriptionFilter() : "");
        searchFilters += (startHourFromFilter() != '' && startHourFromFilter() != null ? "&" + "startHourFrom=" + dateToStringServerFormat(startHourFromFilter()) : "");
        searchFilters += (startHourToFilter() != '' && startHourToFilter() != null ? "&" + "startHourTo=" + dateToStringServerFormat(startHourToFilter()) : "");
        searchFilters += (estimatedDurationFilter() != '' ? "estimatedDuration=" + estimatedDurationFilter() : "");
        searchFilters += (totalDistanceFilter() != '' ? "totalDistance=" + totalDistanceFilter() : "");
        searchFilters += (routeDayOfTheWeekFilter() != '' ? "routeDayOfTheWeek=" + routeDayOfTheWeekFilter() : "");
        searchFilters += (activeFilter() != '' ? "active=" + activeFilter() : "");

        var jqXHR = $.ajax({
            url: baseUrl + "GetListAdvancedSearch/0/" + searchFilters,
            dataType: "json"
        }).done(function (data) {
            if (data) {
                load(data);

                // update datatable
                updateDatatable(data);
            }
            else {
                // No data to load 
                plannedRouteList.removeAll();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };

    var advancedSearch = function () {
        getPlannedRouteListAdvanced();
    };

    var clearSearchFilters = function () {
        nameFilter('');
        routeTypeIdFilter(-1);
        transportTypeIdFilter(-1);
        descriptionFilter('');
        startHourFromFilter('');
        startHourToFilter('');
        estimatedDurationFilter('');
        totalDistanceFilter('');
        routeDayOfTheWeekFilter('');
        activeFilter('');
    };



    // get list by page

    var getPlannedRoutePage = function () {
        isLoading(true);

        var searchFilters = "?"
            + (searchText() != '' ? "searchTerm=" + searchText() : "")
            + "&" + "pageIndex=" + pager.currentPageIndex()
            + "&" + "pageSize=" + pager.currentPageSize()
        ;

        var restUrl = baseUrl + "GetPage/0/" + searchFilters;

        var jqXHR = $.ajax({
            url: restUrl,
            dataType: "json"
        }).done(function (data) {
            if (data) {
                load(data);

                // update datatable
                updateDatatable(data);
            }
            else {
                // No data to load 
                plannedRouteList.removeAll();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };



    // delete

    var deletePlannedRoute = function (plannedRoute) {
        isLoading(true);
        var restUrl = baseUrl + "Delete/" + plannedRoute.plannedRouteId();
        var jqXHR = $.ajax({
            url: restUrl,
            dataType: "json"
        }).done(function () {
            console.log("Deleted: " + plannedRoute.plannedRouteId());
            plannedRouteList.remove(plannedRoute);
        }).fail(function () {
            console.log("Error");
        }).always(function (data) {
            console.log("finished");
            isLoading(false);
        });
    }

    var deletePlannedRouteById = function (plannedRouteId) {
        isLoading(true);
        var restUrl = baseUrl + "Delete/" + plannedRouteId;
        var jqXHR = $.ajax({
            method: "GET",
            url: restUrl,
            dataType: "json"
        }).done(function () {
            console.log("Deleted: " + plannedRouteId);
            //plannedRouteList.remove(plannedRoute);
            // refresh
            getPlannedRouteList();
        }).fail(function () {
            console.log("Error");
        }).always(function (data) {
            console.log("finished");
            isLoading(false);
        });
    }



    // load

    var load = function (data) {
        plannedRouteList.removeAll();
        var underlyingArray = plannedRouteList();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var plannedRoute = new Web.plannedRouteViewModel();
            plannedRoute.load(result);
            underlyingArray.push(plannedRoute);
        }
        plannedRouteList.valueHasMutated();
    };



    // data table

    var updateDatatable = function (data) {
        var dataArray = new Array();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var fieldsInArray = new Array();

            fieldsInArray.push(result.name);
            fieldsInArray.push(result.routeTypeId);
            fieldsInArray.push(result.transportTypeId);
            fieldsInArray.push(result.description);
            fieldsInArray.push(result.startHour);
            fieldsInArray.push(result.estimatedDuration);
            fieldsInArray.push(result.totalDistance);
            fieldsInArray.push(result.routeDayOfTheWeek);
            fieldsInArray.push(result.active);

            var viewLinkElement = '<a href=\"' + result.editUrl + '\" style=\"margin-right: 10px;\">View</a>';
            var editLinkElement = '<a href=\"' + result.editUrl + '\" style=\"margin-right: 10px;\">Edit</a>';
            var deleteLinkElement = '<a href=\"' + 'javascript:vm.deletePlannedRouteById(' + result.plannedRouteId + ');' + '\" style=\"margin-right: 10px;\">Delete</a>';
            fieldsInArray.push(viewLinkElement + editLinkElement + deleteLinkElement);

            dataArray.push(fieldsInArray);
        }

        var datatable = $("#PlannedRoutesTable-" + moduleId).DataTable();
        datatable.clear();
        datatable.rows.add(dataArray);
        datatable.draw();
    };



    // open create form

    var openCreateForm = function () {
        var isPopUp = "?popUp=true";
        var path = location.pathname + "/ctl/Edit/mid/" + moduleId + isPopUp;
        dnnModal.show(path, false, 550, 950, true, '');
    };



    return {
        init: init,
        load: load,
        plannedRouteList: plannedRouteList,
        getPlannedRouteList: getPlannedRouteList,
        getPlannedRoutePage: getPlannedRoutePage,
        deletePlannedRoute: deletePlannedRoute,
        deletePlannedRouteById: deletePlannedRouteById,
        editMode: editMode,
        isLoading: isLoading,
        searchText: searchText,
        openCreateForm: openCreateForm,
        getPlannedRouteListAdvanced: getPlannedRouteListAdvanced,
        advancedSearch: advancedSearch,
        clearSearchFilters: clearSearchFilters,

        routeTypeList: routeTypeHelper.routeTypeList,
        transportTypeList: transportTypeHelper.transportTypeList,

        nameFilter: nameFilter,
        routeTypeIdFilter: routeTypeIdFilter,
        transportTypeIdFilter: transportTypeIdFilter,
        descriptionFilter: descriptionFilter,
        startHourFromFilter: startHourFromFilter,
        startHourToFilter: startHourToFilter,
        estimatedDurationFilter: estimatedDurationFilter,
        totalDistanceFilter: totalDistanceFilter,
        routeDayOfTheWeekFilter: routeDayOfTheWeekFilter,
        activeFilter: activeFilter,
    }
};



// view model

Web.plannedRouteViewModel = function () {
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

    var editUrl = ko.observable('');

    var visibleOnSearch = ko.observable(true);
 
    // load

    var load = function (data) {
        plannedRouteId(data.plannedRouteId);
        name(data.name);
        routeTypeId(data.routeTypeId);
        transportTypeId(data.transportTypeId);
        description(data.description);
        startHour(data.startHour);
        estimatedDuration(data.estimatedDuration);
        totalDistance(data.totalDistance);
        routeDayOfTheWeek(data.routeDayOfTheWeek);
        active(data.active);
        isDeleted(data.isDeleted);
        editUrl(data.editUrl);
    };



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
        editUrl: editUrl,
        load: load,
        visibleOnSearch: visibleOnSearch
    }
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






    