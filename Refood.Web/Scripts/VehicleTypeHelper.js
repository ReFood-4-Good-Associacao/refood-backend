
// ################################################################
//                      Code generated with T4
// ################################################################

var Web = Web || {};

// viewmodel

Web.vehicleType = function ( vehicleTypeId, name, description, active, isDeleted) {
    this.vehicleTypeId = ko.observable(vehicleTypeId);
    this.name = ko.observable(name);
    this.description = ko.observable(description);
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

Web.vehicleTypeHelper = function (isLoading, serviceRootUrl, moduleHeaders) {

    var vehicleTypeList = ko.observableArray([]);
    var deletedVehicleTypeList = ko.observableArray([]);
    var isLoading = isLoading;
    var serviceRootUrl = serviceRootUrl;
    var moduleHeaders = moduleHeaders;
    var searchText = ko.observable('');


    // get

    var getVehicleTypeList = function () {
        isLoading(true);

        // need to calculate a different Url for VehicleType service
        var restUrl = serviceRootUrl + "VehicleType/GetList/";
        var jqXHR = $.ajax({
            url: restUrl,
            beforeSend: moduleHeaders,
            dataType: "json",
            async: false
        }).done(function (data) {
            if (data) {
                loadVehicleTypes(data);
            }
            else {
                clear();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };




    // load

    var loadVehicleTypes = function (data) {
        vehicleTypeList.removeAll();
        var underlyingArray = vehicleTypeList();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var vehicleType = new Web.vehicleType
            (
                result.vehicleTypeId, 
                result.name, 
                result.description, 
                result.active, 
                result.isDeleted 
            );
            underlyingArray.push(vehicleType);
        }
        vehicleTypeList.valueHasMutated();
    };


    // extract knockout array to simple json objects

    var extractKoArrayToJson = function (data) {
        var simpleArray = new Array();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var vehicleType = {
                vehicleTypeId: result.vehicleTypeId(), 
                name: result.name(), 
                description: result.description(), 
                active: result.active(), 
                isDeleted: result.isDeleted() 
            };

            simpleArray.push(vehicleType);
        }
        return simpleArray;
    };


    // add

    var addVehicleType = function () {
        var vehicleType = new Web.vehicleType(0, '', '', '', '');
        vehicleTypeList.push(vehicleType);
    };


    // remove

    var removeVehicleType = function (model, event) {
        var vehicleType = model;
        vehicleType.isDeleted = true;
        deletedVehicleTypeList.push(vehicleType);
        vehicleTypeList.pop(vehicleType);
    };


    // clear

    var clear = function () {
        vehicleTypeList([]);
    };


    // quickSearch

    var quickSearch = function () {
        for (var i = 0; i < vehicleTypeList().length; i++) {
            var result = vehicleTypeList()[i];

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
        vehicleTypeList: vehicleTypeList,
        deletedVehicleTypeList: deletedVehicleTypeList,
        getVehicleTypeList: getVehicleTypeList,
        loadVehicleTypes: loadVehicleTypes,
        isLoading: isLoading,
        addVehicleType: addVehicleType,
        removeVehicleType: removeVehicleType,
        clear: clear,
        searchText: searchText,
        quickSearch: quickSearch,
        extractKoArrayToJson: extractKoArrayToJson
    };
}
    