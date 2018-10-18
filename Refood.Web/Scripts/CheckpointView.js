
// ################################################################
//                      Code generated with T4
// ################################################################

var Web = Web || {};

Web.checkpointListViewModel = function (moduleId, resx) {
    var baseUrl = "api/CheckpointApi/";

    var isLoading = ko.observable(false);
    var checkpointList = ko.observableArray([]);
    var editMode = ko.computed(function () {
        return checkpointList().length > 0 && checkpointList()[0].editUrl() != null && checkpointList()[0].editUrl().length > 0;
    });
    var searchText = ko.observable('');



    // filters

    var plannedRouteIdFilter = ko.observable(-1);
    var nameFilter = ko.observable('');
    var orderNumberFilter = ko.observable('');
    var latitudeFilter = ko.observable('');
    var longitudeFilter = ko.observable('');
    var addressIdFilter = ko.observable(-1);
    var estimatedTimeArrivalFilter = ko.observable('');
    var minimumTimeFromFilter = ko.observable('');
    var minimumTimeToFilter = ko.observable('');
    var maximumTimeFromFilter = ko.observable('');
    var maximumTimeToFilter = ko.observable('');
    var nucleoIdFilter = ko.observable(-1);
    var supplierIdFilter = ko.observable(-1);
    var activeFilter = ko.observable('');



    // helpers

    var plannedRouteHelper = Web.plannedRouteHelper(isLoading, '/', function(){});
    var addressHelper = Web.addressHelper(isLoading, '/', function(){});
    var nucleoHelper = Web.nucleoHelper(isLoading, '/', function(){});
    var supplierHelper = Web.supplierHelper(isLoading, '/', function(){});



    // init

    var init = function () {
        //getCheckpointList();
        //getCheckpointPage();
        getCheckpointListAdvanced();

        plannedRouteHelper.getPlannedRouteList();
        addressHelper.getAddressList();
        nucleoHelper.getNucleoList();
        supplierHelper.getSupplierList();
    }



    // get list

    var getCheckpointList = function () {
        isLoading(true);
        var jqXHR = $.ajax({
            url: baseUrl + "GetList/",
            dataType: "json"
        }).done(function (data) {
            if (data) {
                load(data);

                // update datatable
                updateDatatable(data);
            }
            else {
                // No data to load 
                checkpointList.removeAll();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };



    // get list - advanced search

    var getCheckpointListAdvanced = function () {
        isLoading(true);

        var searchFilters = "?";
        searchFilters += (plannedRouteIdFilter() != -1 && plannedRouteIdFilter() != undefined ? "&" + "plannedRouteId=" + plannedRouteIdFilter() : "");
        searchFilters += (nameFilter() != '' ? "name=" + nameFilter() : "");
        searchFilters += (orderNumberFilter() != '' ? "orderNumber=" + orderNumberFilter() : "");
        searchFilters += (latitudeFilter() != '' ? "latitude=" + latitudeFilter() : "");
        searchFilters += (longitudeFilter() != '' ? "longitude=" + longitudeFilter() : "");
        searchFilters += (addressIdFilter() != -1 && addressIdFilter() != undefined ? "&" + "addressId=" + addressIdFilter() : "");
        searchFilters += (estimatedTimeArrivalFilter() != '' ? "estimatedTimeArrival=" + estimatedTimeArrivalFilter() : "");
        searchFilters += (minimumTimeFromFilter() != '' && minimumTimeFromFilter() != null ? "&" + "minimumTimeFrom=" + dateToStringServerFormat(minimumTimeFromFilter()) : "");
        searchFilters += (minimumTimeToFilter() != '' && minimumTimeToFilter() != null ? "&" + "minimumTimeTo=" + dateToStringServerFormat(minimumTimeToFilter()) : "");
        searchFilters += (maximumTimeFromFilter() != '' && maximumTimeFromFilter() != null ? "&" + "maximumTimeFrom=" + dateToStringServerFormat(maximumTimeFromFilter()) : "");
        searchFilters += (maximumTimeToFilter() != '' && maximumTimeToFilter() != null ? "&" + "maximumTimeTo=" + dateToStringServerFormat(maximumTimeToFilter()) : "");
        searchFilters += (nucleoIdFilter() != -1 && nucleoIdFilter() != undefined ? "&" + "nucleoId=" + nucleoIdFilter() : "");
        searchFilters += (supplierIdFilter() != -1 && supplierIdFilter() != undefined ? "&" + "supplierId=" + supplierIdFilter() : "");
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
                checkpointList.removeAll();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };

    var advancedSearch = function () {
        getCheckpointListAdvanced();
    };

    var clearSearchFilters = function () {
        plannedRouteIdFilter(-1);
        nameFilter('');
        orderNumberFilter('');
        latitudeFilter('');
        longitudeFilter('');
        addressIdFilter(-1);
        estimatedTimeArrivalFilter('');
        minimumTimeFromFilter('');
        minimumTimeToFilter('');
        maximumTimeFromFilter('');
        maximumTimeToFilter('');
        nucleoIdFilter(-1);
        supplierIdFilter(-1);
        activeFilter('');
    };



    // get list by page

    var getCheckpointPage = function () {
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
                checkpointList.removeAll();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };



    // delete

    var deleteCheckpoint = function (checkpoint) {
        isLoading(true);
        var restUrl = baseUrl + "Delete/" + checkpoint.checkpointId();
        var jqXHR = $.ajax({
            url: restUrl,
            dataType: "json"
        }).done(function () {
            console.log("Deleted: " + checkpoint.checkpointId());
            checkpointList.remove(checkpoint);
        }).fail(function () {
            console.log("Error");
        }).always(function (data) {
            console.log("finished");
            isLoading(false);
        });
    }

    var deleteCheckpointById = function (checkpointId) {
        isLoading(true);
        var restUrl = baseUrl + "Delete/" + checkpointId;
        var jqXHR = $.ajax({
            method: "GET",
            url: restUrl,
            dataType: "json"
        }).done(function () {
            console.log("Deleted: " + checkpointId);
            //checkpointList.remove(checkpoint);
            // refresh
            getCheckpointList();
        }).fail(function () {
            console.log("Error");
        }).always(function (data) {
            console.log("finished");
            isLoading(false);
        });
    }



    // load

    var load = function (data) {
        checkpointList.removeAll();
        var underlyingArray = checkpointList();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var checkpoint = new Web.checkpointViewModel();
            checkpoint.load(result);
            underlyingArray.push(checkpoint);
        }
        checkpointList.valueHasMutated();
    };



    // data table

    var updateDatatable = function (data) {
        var dataArray = new Array();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var fieldsInArray = new Array();

            fieldsInArray.push(result.plannedRouteId);
            fieldsInArray.push(result.name);
            fieldsInArray.push(result.orderNumber);
            fieldsInArray.push(result.latitude);
            fieldsInArray.push(result.longitude);
            fieldsInArray.push(result.addressId);
            fieldsInArray.push(result.estimatedTimeArrival);
            fieldsInArray.push(result.minimumTime);
            fieldsInArray.push(result.maximumTime);
            fieldsInArray.push(result.nucleoId);
            fieldsInArray.push(result.supplierId);
            fieldsInArray.push(result.active);

            var viewLinkElement = '<a href=\"' + result.editUrl + '\" style=\"margin-right: 10px;\">View</a>';
            var editLinkElement = '<a href=\"' + result.editUrl + '\" style=\"margin-right: 10px;\">Edit</a>';
            var deleteLinkElement = '<a href=\"' + 'javascript:vm.deleteCheckpointById(' + result.checkpointId + ');' + '\" style=\"margin-right: 10px;\">Delete</a>';
            fieldsInArray.push(viewLinkElement + editLinkElement + deleteLinkElement);

            dataArray.push(fieldsInArray);
        }

        var datatable = $("#CheckpointsTable-" + moduleId).DataTable();
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
        checkpointList: checkpointList,
        getCheckpointList: getCheckpointList,
        getCheckpointPage: getCheckpointPage,
        deleteCheckpoint: deleteCheckpoint,
        deleteCheckpointById: deleteCheckpointById,
        editMode: editMode,
        isLoading: isLoading,
        searchText: searchText,
        openCreateForm: openCreateForm,
        getCheckpointListAdvanced: getCheckpointListAdvanced,
        advancedSearch: advancedSearch,
        clearSearchFilters: clearSearchFilters,

        plannedRouteList: plannedRouteHelper.plannedRouteList,
        addressList: addressHelper.addressList,
        nucleoList: nucleoHelper.nucleoList,
        supplierList: supplierHelper.supplierList,

        plannedRouteIdFilter: plannedRouteIdFilter,
        nameFilter: nameFilter,
        orderNumberFilter: orderNumberFilter,
        latitudeFilter: latitudeFilter,
        longitudeFilter: longitudeFilter,
        addressIdFilter: addressIdFilter,
        estimatedTimeArrivalFilter: estimatedTimeArrivalFilter,
        minimumTimeFromFilter: minimumTimeFromFilter,
        minimumTimeToFilter: minimumTimeToFilter,
        maximumTimeFromFilter: maximumTimeFromFilter,
        maximumTimeToFilter: maximumTimeToFilter,
        nucleoIdFilter: nucleoIdFilter,
        supplierIdFilter: supplierIdFilter,
        activeFilter: activeFilter,
    }
};



// view model

Web.checkpointViewModel = function () {
    var checkpointId = ko.observable(-1);
    var plannedRouteId = ko.observable(-1);
    var name = ko.observable('');
    var orderNumber = ko.observable('');
    var latitude = ko.observable('');
    var longitude = ko.observable('');
    var addressId = ko.observable(-1);
    var estimatedTimeArrival = ko.observable('');
    var minimumTime = ko.observable('');
    var maximumTime = ko.observable('');
    var nucleoId = ko.observable(-1);
    var supplierId = ko.observable(-1);
    var active = ko.observable('');
    var isDeleted = ko.observable('');

    var editUrl = ko.observable('');

    var visibleOnSearch = ko.observable(true);
 
    // load

    var load = function (data) {
        checkpointId(data.checkpointId);
        plannedRouteId(data.plannedRouteId);
        name(data.name);
        orderNumber(data.orderNumber);
        latitude(data.latitude);
        longitude(data.longitude);
        addressId(data.addressId);
        estimatedTimeArrival(data.estimatedTimeArrival);
        minimumTime(data.minimumTime);
        maximumTime(data.maximumTime);
        nucleoId(data.nucleoId);
        supplierId(data.supplierId);
        active(data.active);
        isDeleted(data.isDeleted);
        editUrl(data.editUrl);
    };



    return {
        checkpointId: checkpointId,
        plannedRouteId: plannedRouteId,
        name: name,
        orderNumber: orderNumber,
        latitude: latitude,
        longitude: longitude,
        addressId: addressId,
        estimatedTimeArrival: estimatedTimeArrival,
        minimumTime: minimumTime,
        maximumTime: maximumTime,
        nucleoId: nucleoId,
        supplierId: supplierId,
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






    