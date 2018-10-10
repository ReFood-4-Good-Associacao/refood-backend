
// ################################################################
//                      Code generated with T4
// ################################################################

var Web = Web || {};

// viewmodel

Web.vehicle = function ( vehicleId, make, model, owner, ownerId, nucleoId, vehicleTypeId, energySourceId, averageSpeed, horsePower, fuelConsumption, fuelAutonomyDistance, rechargeTime, licensePlate, color, numberSeats, cargoVolumeCapacity, active, isDeleted) {
    this.vehicleId = ko.observable(vehicleId);
    this.make = ko.observable(make);
    this.model = ko.observable(model);
    this.owner = ko.observable(owner);
    this.ownerId = ko.observable(ownerId);
    this.nucleoId = ko.observable(nucleoId);
    this.vehicleTypeId = ko.observable(vehicleTypeId);
    this.energySourceId = ko.observable(energySourceId);
    this.averageSpeed = ko.observable(averageSpeed);
    this.horsePower = ko.observable(horsePower);
    this.fuelConsumption = ko.observable(fuelConsumption);
    this.fuelAutonomyDistance = ko.observable(fuelAutonomyDistance);
    this.rechargeTime = ko.observable(rechargeTime);
    this.licensePlate = ko.observable(licensePlate);
    this.color = ko.observable(color);
    this.numberSeats = ko.observable(numberSeats);
    this.cargoVolumeCapacity = ko.observable(cargoVolumeCapacity);
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

Web.vehicleHelper = function (isLoading, serviceRootUrl, moduleHeaders) {

    var vehicleList = ko.observableArray([]);
    var deletedVehicleList = ko.observableArray([]);
    var isLoading = isLoading;
    var serviceRootUrl = serviceRootUrl;
    var moduleHeaders = moduleHeaders;
    var searchText = ko.observable('');


    // get

    var getVehicleList = function () {
        isLoading(true);

        // need to calculate a different Url for Vehicle service
        var restUrl = serviceRootUrl + "api/VehicleApi/GetList/";
        var jqXHR = $.ajax({
            url: restUrl,
            beforeSend: moduleHeaders,
            dataType: "json",
            async: false
        }).done(function (data) {
            if (data) {
                loadVehicles(data);
            }
            else {
                clear();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };




    // load

    var loadVehicles = function (data) {
        vehicleList.removeAll();
        var underlyingArray = vehicleList();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var vehicle = new Web.vehicle
            (
                result.vehicleId, 
                result.make, 
                result.model, 
                result.owner, 
                result.ownerId, 
                result.nucleoId, 
                result.vehicleTypeId, 
                result.energySourceId, 
                result.averageSpeed, 
                result.horsePower, 
                result.fuelConsumption, 
                result.fuelAutonomyDistance, 
                result.rechargeTime, 
                result.licensePlate, 
                result.color, 
                result.numberSeats, 
                result.cargoVolumeCapacity, 
                result.active, 
                result.isDeleted 
            );
            underlyingArray.push(vehicle);
        }
        vehicleList.valueHasMutated();
    };


    // extract knockout array to simple json objects

    var extractKoArrayToJson = function (data) {
        var simpleArray = new Array();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var vehicle = {
                vehicleId: result.vehicleId(), 
                make: result.make(), 
                model: result.model(), 
                owner: result.owner(), 
                ownerId: result.ownerId(), 
                nucleoId: result.nucleoId(), 
                vehicleTypeId: result.vehicleTypeId(), 
                energySourceId: result.energySourceId(), 
                averageSpeed: result.averageSpeed(), 
                horsePower: result.horsePower(), 
                fuelConsumption: result.fuelConsumption(), 
                fuelAutonomyDistance: result.fuelAutonomyDistance(), 
                rechargeTime: result.rechargeTime(), 
                licensePlate: result.licensePlate(), 
                color: result.color(), 
                numberSeats: result.numberSeats(), 
                cargoVolumeCapacity: result.cargoVolumeCapacity(), 
                active: result.active(), 
                isDeleted: result.isDeleted() 
            };

            simpleArray.push(vehicle);
        }
        return simpleArray;
    };


    // add

    var addVehicle = function () {
        var vehicle = new Web.vehicle(0, '', '', '', '');
        vehicleList.push(vehicle);
    };


    // remove

    var removeVehicle = function (model, event) {
        var vehicle = model;
        vehicle.isDeleted = true;
        deletedVehicleList.push(vehicle);
        vehicleList.pop(vehicle);
    };


    // clear

    var clear = function () {
        vehicleList([]);
    };


    // quickSearch

    var quickSearch = function () {
        for (var i = 0; i < vehicleList().length; i++) {
            var result = vehicleList()[i];

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
        vehicleList: vehicleList,
        deletedVehicleList: deletedVehicleList,
        getVehicleList: getVehicleList,
        loadVehicles: loadVehicles,
        isLoading: isLoading,
        addVehicle: addVehicle,
        removeVehicle: removeVehicle,
        clear: clear,
        searchText: searchText,
        quickSearch: quickSearch,
        extractKoArrayToJson: extractKoArrayToJson
    };
}
    