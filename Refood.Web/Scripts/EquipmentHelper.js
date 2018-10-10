
// ################################################################
//                      Code generated with T4
// ################################################################

var Web = Web || {};

// viewmodel

Web.equipment = function ( equipmentId, name, description, category, photo, quantityInStock, minimumQuantityNeeded, pricePerUnit, storageLocation, active, isDeleted) {
    this.equipmentId = ko.observable(equipmentId);
    this.name = ko.observable(name);
    this.description = ko.observable(description);
    this.category = ko.observable(category);
    this.photo = ko.observable(photo);
    this.quantityInStock = ko.observable(quantityInStock);
    this.minimumQuantityNeeded = ko.observable(minimumQuantityNeeded);
    this.pricePerUnit = ko.observable(pricePerUnit);
    this.storageLocation = ko.observable(storageLocation);
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

Web.equipmentHelper = function (isLoading, serviceRootUrl, moduleHeaders) {

    var equipmentList = ko.observableArray([]);
    var deletedEquipmentList = ko.observableArray([]);
    var isLoading = isLoading;
    var serviceRootUrl = serviceRootUrl;
    var moduleHeaders = moduleHeaders;
    var searchText = ko.observable('');


    // get

    var getEquipmentList = function () {
        isLoading(true);

        // need to calculate a different Url for Equipment service
        var restUrl = serviceRootUrl + "api/EquipmentApi/GetList/";
        var jqXHR = $.ajax({
            url: restUrl,
            beforeSend: moduleHeaders,
            dataType: "json",
            async: false
        }).done(function (data) {
            if (data) {
                loadEquipments(data);
            }
            else {
                clear();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };




    // load

    var loadEquipments = function (data) {
        equipmentList.removeAll();
        var underlyingArray = equipmentList();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var equipment = new Web.equipment
            (
                result.equipmentId, 
                result.name, 
                result.description, 
                result.category, 
                result.photo, 
                result.quantityInStock, 
                result.minimumQuantityNeeded, 
                result.pricePerUnit, 
                result.storageLocation, 
                result.active, 
                result.isDeleted 
            );
            underlyingArray.push(equipment);
        }
        equipmentList.valueHasMutated();
    };


    // extract knockout array to simple json objects

    var extractKoArrayToJson = function (data) {
        var simpleArray = new Array();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var equipment = {
                equipmentId: result.equipmentId(), 
                name: result.name(), 
                description: result.description(), 
                category: result.category(), 
                photo: result.photo(), 
                quantityInStock: result.quantityInStock(), 
                minimumQuantityNeeded: result.minimumQuantityNeeded(), 
                pricePerUnit: result.pricePerUnit(), 
                storageLocation: result.storageLocation(), 
                active: result.active(), 
                isDeleted: result.isDeleted() 
            };

            simpleArray.push(equipment);
        }
        return simpleArray;
    };


    // add

    var addEquipment = function () {
        var equipment = new Web.equipment(0, '', '', '', '');
        equipmentList.push(equipment);
    };


    // remove

    var removeEquipment = function (model, event) {
        var equipment = model;
        equipment.isDeleted = true;
        deletedEquipmentList.push(equipment);
        equipmentList.pop(equipment);
    };


    // clear

    var clear = function () {
        equipmentList([]);
    };


    // quickSearch

    var quickSearch = function () {
        for (var i = 0; i < equipmentList().length; i++) {
            var result = equipmentList()[i];

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
        equipmentList: equipmentList,
        deletedEquipmentList: deletedEquipmentList,
        getEquipmentList: getEquipmentList,
        loadEquipments: loadEquipments,
        isLoading: isLoading,
        addEquipment: addEquipment,
        removeEquipment: removeEquipment,
        clear: clear,
        searchText: searchText,
        quickSearch: quickSearch,
        extractKoArrayToJson: extractKoArrayToJson
    };
}
    