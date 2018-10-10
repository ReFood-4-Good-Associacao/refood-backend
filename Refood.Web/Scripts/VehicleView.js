
// ################################################################
//                      Code generated with T4
// ################################################################

var Web = Web || {};

Web.vehicleListViewModel = function (moduleId, resx) {
    var baseUrl = "api/VehicleApi/";

    var isLoading = ko.observable(false);
    var vehicleList = ko.observableArray([]);
    var editMode = ko.computed(function () {
        return vehicleList().length > 0 && vehicleList()[0].editUrl() != null && vehicleList()[0].editUrl().length > 0;
    });
    var searchText = ko.observable('');



    // filters

    var makeFilter = ko.observable('');
    var modelFilter = ko.observable('');
    var ownerFilter = ko.observable('');
    var ownerIdFilter = ko.observable(-1);
    var nucleoIdFilter = ko.observable(-1);
    var vehicleTypeIdFilter = ko.observable(-1);
    var energySourceIdFilter = ko.observable(-1);
    var averageSpeedFilter = ko.observable('');
    var horsePowerFilter = ko.observable('');
    var fuelConsumptionFilter = ko.observable('');
    var fuelAutonomyDistanceFilter = ko.observable('');
    var rechargeTimeFilter = ko.observable('');
    var licensePlateFilter = ko.observable('');
    var colorFilter = ko.observable('');
    var numberSeatsFilter = ko.observable('');
    var cargoVolumeCapacityFilter = ko.observable('');
    var activeFilter = ko.observable('');



    // helpers

    var ownerHelper = Web.ownerHelper(isLoading, '/', function(){});
    var nucleoHelper = Web.nucleoHelper(isLoading, '/', function(){});
    var vehicleTypeHelper = Web.vehicleTypeHelper(isLoading, '/', function(){});
    var energySourceHelper = Web.energySourceHelper(isLoading, '/', function(){});



    // init

    var init = function () {
        //getVehicleList();
        //getVehiclePage();
        getVehicleListAdvanced();

        ownerHelper.getOwnerList();
        nucleoHelper.getNucleoList();
        vehicleTypeHelper.getVehicleTypeList();
        energySourceHelper.getEnergySourceList();
    }



    // get list

    var getVehicleList = function () {
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
                vehicleList.removeAll();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };



    // get list - advanced search

    var getVehicleListAdvanced = function () {
        isLoading(true);

        var searchFilters = "?";
        searchFilters += (makeFilter() != '' ? "make=" + makeFilter() : "");
        searchFilters += (modelFilter() != '' ? "model=" + modelFilter() : "");
        searchFilters += (ownerFilter() != '' ? "owner=" + ownerFilter() : "");
        searchFilters += (ownerIdFilter() != -1 && ownerIdFilter() != undefined ? "&" + "ownerId=" + ownerIdFilter() : "");
        searchFilters += (nucleoIdFilter() != -1 && nucleoIdFilter() != undefined ? "&" + "nucleoId=" + nucleoIdFilter() : "");
        searchFilters += (vehicleTypeIdFilter() != -1 && vehicleTypeIdFilter() != undefined ? "&" + "vehicleTypeId=" + vehicleTypeIdFilter() : "");
        searchFilters += (energySourceIdFilter() != -1 && energySourceIdFilter() != undefined ? "&" + "energySourceId=" + energySourceIdFilter() : "");
        searchFilters += (averageSpeedFilter() != '' ? "averageSpeed=" + averageSpeedFilter() : "");
        searchFilters += (horsePowerFilter() != '' ? "horsePower=" + horsePowerFilter() : "");
        searchFilters += (fuelConsumptionFilter() != '' ? "fuelConsumption=" + fuelConsumptionFilter() : "");
        searchFilters += (fuelAutonomyDistanceFilter() != '' ? "fuelAutonomyDistance=" + fuelAutonomyDistanceFilter() : "");
        searchFilters += (rechargeTimeFilter() != '' ? "rechargeTime=" + rechargeTimeFilter() : "");
        searchFilters += (licensePlateFilter() != '' ? "licensePlate=" + licensePlateFilter() : "");
        searchFilters += (colorFilter() != '' ? "color=" + colorFilter() : "");
        searchFilters += (numberSeatsFilter() != '' ? "numberSeats=" + numberSeatsFilter() : "");
        searchFilters += (cargoVolumeCapacityFilter() != '' ? "cargoVolumeCapacity=" + cargoVolumeCapacityFilter() : "");
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
                vehicleList.removeAll();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };

    var advancedSearch = function () {
        getVehicleListAdvanced();
    };

    var clearSearchFilters = function () {
        makeFilter('');
        modelFilter('');
        ownerFilter('');
        ownerIdFilter(-1);
        nucleoIdFilter(-1);
        vehicleTypeIdFilter(-1);
        energySourceIdFilter(-1);
        averageSpeedFilter('');
        horsePowerFilter('');
        fuelConsumptionFilter('');
        fuelAutonomyDistanceFilter('');
        rechargeTimeFilter('');
        licensePlateFilter('');
        colorFilter('');
        numberSeatsFilter('');
        cargoVolumeCapacityFilter('');
        activeFilter('');
    };



    // get list by page

    var getVehiclePage = function () {
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
                vehicleList.removeAll();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };



    // delete

    var deleteVehicle = function (vehicle) {
        isLoading(true);
        var restUrl = baseUrl + "Delete/" + vehicle.vehicleId();
        var jqXHR = $.ajax({
            url: restUrl,
            dataType: "json"
        }).done(function () {
            console.log("Deleted: " + vehicle.vehicleId());
            vehicleList.remove(vehicle);
        }).fail(function () {
            console.log("Error");
        }).always(function (data) {
            console.log("finished");
            isLoading(false);
        });
    }

    var deleteVehicleById = function (vehicleId) {
        isLoading(true);
        var restUrl = baseUrl + "Delete/" + vehicleId;
        var jqXHR = $.ajax({
            method: "GET",
            url: restUrl,
            dataType: "json"
        }).done(function () {
            console.log("Deleted: " + vehicleId);
            //vehicleList.remove(vehicle);
            // refresh
            getVehicleList();
        }).fail(function () {
            console.log("Error");
        }).always(function (data) {
            console.log("finished");
            isLoading(false);
        });
    }



    // load

    var load = function (data) {
        vehicleList.removeAll();
        var underlyingArray = vehicleList();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var vehicle = new Web.vehicleViewModel();
            vehicle.load(result);
            underlyingArray.push(vehicle);
        }
        vehicleList.valueHasMutated();
    };



    // data table

    var updateDatatable = function (data) {
        var dataArray = new Array();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var fieldsInArray = new Array();

            fieldsInArray.push(result.make);
            fieldsInArray.push(result.model);
            fieldsInArray.push(result.owner);
            fieldsInArray.push(result.ownerId);
            fieldsInArray.push(result.nucleoId);
            fieldsInArray.push(result.vehicleTypeId);
            fieldsInArray.push(result.energySourceId);
            fieldsInArray.push(result.averageSpeed);
            fieldsInArray.push(result.horsePower);
            fieldsInArray.push(result.fuelConsumption);
            fieldsInArray.push(result.fuelAutonomyDistance);
            fieldsInArray.push(result.rechargeTime);
            fieldsInArray.push(result.licensePlate);
            fieldsInArray.push(result.color);
            fieldsInArray.push(result.numberSeats);
            fieldsInArray.push(result.cargoVolumeCapacity);
            fieldsInArray.push(result.active);

            var viewLinkElement = '<a href=\"' + result.editUrl + '\" style=\"margin-right: 10px;\">View</a>';
            var editLinkElement = '<a href=\"' + result.editUrl + '\" style=\"margin-right: 10px;\">Edit</a>';
            var deleteLinkElement = '<a href=\"' + 'javascript:vm.deleteVehicleById(' + result.vehicleId + ');' + '\" style=\"margin-right: 10px;\">Delete</a>';
            fieldsInArray.push(viewLinkElement + editLinkElement + deleteLinkElement);

            dataArray.push(fieldsInArray);
        }

        var datatable = $("#VehiclesTable-" + moduleId).DataTable();
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
        vehicleList: vehicleList,
        getVehicleList: getVehicleList,
        getVehiclePage: getVehiclePage,
        deleteVehicle: deleteVehicle,
        deleteVehicleById: deleteVehicleById,
        editMode: editMode,
        isLoading: isLoading,
        searchText: searchText,
        openCreateForm: openCreateForm,
        getVehicleListAdvanced: getVehicleListAdvanced,
        advancedSearch: advancedSearch,
        clearSearchFilters: clearSearchFilters,

        ownerList: ownerHelper.ownerList,
        nucleoList: nucleoHelper.nucleoList,
        vehicleTypeList: vehicleTypeHelper.vehicleTypeList,
        energySourceList: energySourceHelper.energySourceList,

        makeFilter: makeFilter,
        modelFilter: modelFilter,
        ownerFilter: ownerFilter,
        ownerIdFilter: ownerIdFilter,
        nucleoIdFilter: nucleoIdFilter,
        vehicleTypeIdFilter: vehicleTypeIdFilter,
        energySourceIdFilter: energySourceIdFilter,
        averageSpeedFilter: averageSpeedFilter,
        horsePowerFilter: horsePowerFilter,
        fuelConsumptionFilter: fuelConsumptionFilter,
        fuelAutonomyDistanceFilter: fuelAutonomyDistanceFilter,
        rechargeTimeFilter: rechargeTimeFilter,
        licensePlateFilter: licensePlateFilter,
        colorFilter: colorFilter,
        numberSeatsFilter: numberSeatsFilter,
        cargoVolumeCapacityFilter: cargoVolumeCapacityFilter,
        activeFilter: activeFilter,
    }
};



// view model

Web.vehicleViewModel = function () {
    var vehicleId = ko.observable(-1);
    var make = ko.observable('');
    var model = ko.observable('');
    var owner = ko.observable('');
    var ownerId = ko.observable(-1);
    var nucleoId = ko.observable(-1);
    var vehicleTypeId = ko.observable(-1);
    var energySourceId = ko.observable(-1);
    var averageSpeed = ko.observable('');
    var horsePower = ko.observable('');
    var fuelConsumption = ko.observable('');
    var fuelAutonomyDistance = ko.observable('');
    var rechargeTime = ko.observable('');
    var licensePlate = ko.observable('');
    var color = ko.observable('');
    var numberSeats = ko.observable('');
    var cargoVolumeCapacity = ko.observable('');
    var active = ko.observable('');
    var isDeleted = ko.observable('');

    var editUrl = ko.observable('');

    var visibleOnSearch = ko.observable(true);
 
    // load

    var load = function (data) {
        vehicleId(data.vehicleId);
        make(data.make);
        model(data.model);
        owner(data.owner);
        ownerId(data.ownerId);
        nucleoId(data.nucleoId);
        vehicleTypeId(data.vehicleTypeId);
        energySourceId(data.energySourceId);
        averageSpeed(data.averageSpeed);
        horsePower(data.horsePower);
        fuelConsumption(data.fuelConsumption);
        fuelAutonomyDistance(data.fuelAutonomyDistance);
        rechargeTime(data.rechargeTime);
        licensePlate(data.licensePlate);
        color(data.color);
        numberSeats(data.numberSeats);
        cargoVolumeCapacity(data.cargoVolumeCapacity);
        active(data.active);
        isDeleted(data.isDeleted);
        editUrl(data.editUrl);
    };



    return {
        vehicleId: vehicleId,
        make: make,
        model: model,
        owner: owner,
        ownerId: ownerId,
        nucleoId: nucleoId,
        vehicleTypeId: vehicleTypeId,
        energySourceId: energySourceId,
        averageSpeed: averageSpeed,
        horsePower: horsePower,
        fuelConsumption: fuelConsumption,
        fuelAutonomyDistance: fuelAutonomyDistance,
        rechargeTime: rechargeTime,
        licensePlate: licensePlate,
        color: color,
        numberSeats: numberSeats,
        cargoVolumeCapacity: cargoVolumeCapacity,
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






    