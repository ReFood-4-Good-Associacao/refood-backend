
// ################################################################
//                      Code generated with T4
// ################################################################

var Web = Web || {};

// viewmodel

Web.checkpoint = function ( checkpointId, plannedRouteId, name, orderNumber, latitude, longitude, addressId, estimatedTimeArrival, minimumTime, maximumTime, nucleoId, supplierId, active, isDeleted) {
    this.checkpointId = ko.observable(checkpointId);
    this.plannedRouteId = ko.observable(plannedRouteId);
    this.name = ko.observable(name);
    this.orderNumber = ko.observable(orderNumber);
    this.latitude = ko.observable(latitude);
    this.longitude = ko.observable(longitude);
    this.addressId = ko.observable(addressId);
    this.estimatedTimeArrival = ko.observable(estimatedTimeArrival);
    this.minimumTime = ko.observable(minimumTime);
    this.maximumTime = ko.observable(maximumTime);
    this.nucleoId = ko.observable(nucleoId);
    this.supplierId = ko.observable(supplierId);
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

Web.checkpointHelper = function (isLoading, serviceRootUrl, moduleHeaders) {

    var checkpointList = ko.observableArray([]);
    var deletedCheckpointList = ko.observableArray([]);
    var isLoading = isLoading;
    var serviceRootUrl = serviceRootUrl;
    var moduleHeaders = moduleHeaders;
    var searchText = ko.observable('');


    // get

    var getCheckpointList = function (callback) {
        isLoading(true);

        // need to calculate a different Url for Checkpoint service
        var restUrl = serviceRootUrl + "api/CheckpointApi/GetList/";
        var jqXHR = $.ajax({
            url: restUrl,
            beforeSend: moduleHeaders,
            dataType: "json",
            async: false
        }).done(function (data) {
            if (data) {
                loadCheckpoints(data);

                if (callback != null) {
                    callback(data);
                }
            }
            else {
                clear();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };

    var getListByPlannedRouteId = function (itemId, callback) {
        isLoading(true);

        // need to calculate a different Url for Checkpoint service
        var restUrl = serviceRootUrl + "api/CheckpointApi/GetCheckpointListByPlannedRouteId/" + itemId;
        var jqXHR = $.ajax({
            url: restUrl,
            beforeSend: moduleHeaders,
            dataType: "json",
            async: false
        }).done(function (data) {
            if (data) {
                loadCheckpoints(data);

                if (callback != null) {
                    callback(data);
                }
            }
            else {
                clear();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };



    // load

    var loadCheckpoints = function (data) {
        checkpointList.removeAll();
        var underlyingArray = checkpointList();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var checkpoint = new Web.checkpoint
            (
                result.checkpointId, 
                result.plannedRouteId, 
                result.name, 
                result.orderNumber, 
                result.latitude, 
                result.longitude, 
                result.addressId, 
                result.estimatedTimeArrival, 
                result.minimumTime, 
                result.maximumTime, 
                result.nucleoId, 
                result.supplierId, 
                result.active, 
                result.isDeleted 
            );
            underlyingArray.push(checkpoint);
        }
        checkpointList.valueHasMutated();
    };


    // extract knockout array to simple json objects

    var extractKoArrayToJson = function (data) {
        var simpleArray = new Array();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var checkpoint = {
                checkpointId: result.checkpointId(), 
                plannedRouteId: result.plannedRouteId(), 
                name: result.name(), 
                orderNumber: result.orderNumber(), 
                latitude: result.latitude(), 
                longitude: result.longitude(), 
                addressId: result.addressId(), 
                estimatedTimeArrival: result.estimatedTimeArrival(), 
                minimumTime: result.minimumTime(), 
                maximumTime: result.maximumTime(), 
                nucleoId: result.nucleoId(), 
                supplierId: result.supplierId(), 
                active: result.active(), 
                isDeleted: result.isDeleted() 
            };

            simpleArray.push(checkpoint);
        }
        return simpleArray;
    };


    // add

    var addCheckpoint = function () {
        var checkpoint = new Web.checkpoint(0, '', '', '', '');
        checkpointList.push(checkpoint);
    };


    // remove

    var removeCheckpoint = function (model, event) {
        var checkpoint = model;
        checkpoint.isDeleted = true;
        deletedCheckpointList.push(checkpoint);
        checkpointList.pop(checkpoint);
    };


    // clear

    var clear = function () {
        checkpointList([]);
    };


    // quickSearch

    var quickSearch = function () {
        for (var i = 0; i < checkpointList().length; i++) {
            var result = checkpointList()[i];

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
        checkpointList: checkpointList,
        deletedCheckpointList: deletedCheckpointList,
        getCheckpointList: getCheckpointList,
        getListByPlannedRouteId: getListByPlannedRouteId,
        loadCheckpoints: loadCheckpoints,
        isLoading: isLoading,
        addCheckpoint: addCheckpoint,
        removeCheckpoint: removeCheckpoint,
        clear: clear,
        searchText: searchText,
        quickSearch: quickSearch,
        extractKoArrayToJson: extractKoArrayToJson
    };
}
    