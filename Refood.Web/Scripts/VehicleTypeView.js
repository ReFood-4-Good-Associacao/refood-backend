
// ################################################################
//                      Code generated with T4
// ################################################################

var Web = Web || {};

Web.vehicleTypeListViewModel = function (moduleId, resx) {
    var baseUrl = "api/VehicleTypeApi/";

    var isLoading = ko.observable(false);
    var vehicleTypeList = ko.observableArray([]);
    var editMode = ko.computed(function () {
        return vehicleTypeList().length > 0 && vehicleTypeList()[0].editUrl() != null && vehicleTypeList()[0].editUrl().length > 0;
    });
    var searchText = ko.observable('');



    // filters

    var nameFilter = ko.observable('');
    var descriptionFilter = ko.observable('');
    var activeFilter = ko.observable('');



    // helpers




    // init

    var init = function () {
        //getVehicleTypeList();
        //getVehicleTypePage();
        getVehicleTypeListAdvanced();

    }



    // get list

    var getVehicleTypeList = function () {
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
                vehicleTypeList.removeAll();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };



    // get list - advanced search

    var getVehicleTypeListAdvanced = function () {
        isLoading(true);

        var searchFilters = "?";
        searchFilters += (nameFilter() != '' ? "name=" + nameFilter() : "");
        searchFilters += (descriptionFilter() != '' ? "description=" + descriptionFilter() : "");
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
                vehicleTypeList.removeAll();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };

    var advancedSearch = function () {
        getVehicleTypeListAdvanced();
    };

    var clearSearchFilters = function () {
        nameFilter('');
        descriptionFilter('');
        activeFilter('');
    };



    // get list by page

    var getVehicleTypePage = function () {
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
                vehicleTypeList.removeAll();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };



    // delete

    var deleteVehicleType = function (vehicleType) {
        isLoading(true);
        var restUrl = baseUrl + "Delete/" + vehicleType.vehicleTypeId();
        var jqXHR = $.ajax({
            url: restUrl,
            dataType: "json"
        }).done(function () {
            console.log("Deleted: " + vehicleType.vehicleTypeId());
            vehicleTypeList.remove(vehicleType);
        }).fail(function () {
            console.log("Error");
        }).always(function (data) {
            console.log("finished");
            isLoading(false);
        });
    }

    var deleteVehicleTypeById = function (vehicleTypeId) {
        isLoading(true);
        var restUrl = baseUrl + "Delete/" + vehicleTypeId;
        var jqXHR = $.ajax({
            method: "GET",
            url: restUrl,
            dataType: "json"
        }).done(function () {
            console.log("Deleted: " + vehicleTypeId);
            //vehicleTypeList.remove(vehicleType);
            // refresh
            getVehicleTypeList();
        }).fail(function () {
            console.log("Error");
        }).always(function (data) {
            console.log("finished");
            isLoading(false);
        });
    }



    // load

    var load = function (data) {
        vehicleTypeList.removeAll();
        var underlyingArray = vehicleTypeList();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var vehicleType = new Web.vehicleTypeViewModel();
            vehicleType.load(result);
            underlyingArray.push(vehicleType);
        }
        vehicleTypeList.valueHasMutated();
    };



    // data table

    var updateDatatable = function (data) {
        var dataArray = new Array();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var fieldsInArray = new Array();

            fieldsInArray.push(result.name);
            fieldsInArray.push(result.description);
            fieldsInArray.push(result.active);

            var viewLinkElement = '<a href=\"' + result.editUrl + '\" style=\"margin-right: 10px;\">View</a>';
            var editLinkElement = '<a href=\"' + result.editUrl + '\" style=\"margin-right: 10px;\">Edit</a>';
            var deleteLinkElement = '<a href=\"' + 'javascript:vm.deleteVehicleTypeById(' + result.vehicleTypeId + ');' + '\" style=\"margin-right: 10px;\">Delete</a>';
            fieldsInArray.push(viewLinkElement + editLinkElement + deleteLinkElement);

            dataArray.push(fieldsInArray);
        }

        var datatable = $("#VehicleTypesTable-" + moduleId).DataTable();
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
        vehicleTypeList: vehicleTypeList,
        getVehicleTypeList: getVehicleTypeList,
        getVehicleTypePage: getVehicleTypePage,
        deleteVehicleType: deleteVehicleType,
        deleteVehicleTypeById: deleteVehicleTypeById,
        editMode: editMode,
        isLoading: isLoading,
        searchText: searchText,
        openCreateForm: openCreateForm,
        getVehicleTypeListAdvanced: getVehicleTypeListAdvanced,
        advancedSearch: advancedSearch,
        clearSearchFilters: clearSearchFilters,


        nameFilter: nameFilter,
        descriptionFilter: descriptionFilter,
        activeFilter: activeFilter,
    }
};



// view model

Web.vehicleTypeViewModel = function () {
    var vehicleTypeId = ko.observable(-1);
    var name = ko.observable('');
    var description = ko.observable('');
    var active = ko.observable('');
    var isDeleted = ko.observable('');

    var editUrl = ko.observable('');

    var visibleOnSearch = ko.observable(true);
 
    // load

    var load = function (data) {
        vehicleTypeId(data.vehicleTypeId);
        name(data.name);
        description(data.description);
        active(data.active);
        isDeleted(data.isDeleted);
        editUrl(data.editUrl);
    };



    return {
        vehicleTypeId: vehicleTypeId,
        name: name,
        description: description,
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






    