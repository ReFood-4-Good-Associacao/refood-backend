
// ################################################################
//                      Code generated with T4
// ################################################################

var Web = Web || {};

// viewmodel

Web.energySource = function ( energySourceId, name, description, active, isDeleted) {
    this.energySourceId = ko.observable(energySourceId);
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

Web.energySourceHelper = function (isLoading, serviceRootUrl, moduleHeaders) {

    var energySourceList = ko.observableArray([]);
    var deletedEnergySourceList = ko.observableArray([]);
    var isLoading = isLoading;
    var serviceRootUrl = serviceRootUrl;
    var moduleHeaders = moduleHeaders;
    var searchText = ko.observable('');


    // get

    var getEnergySourceList = function () {
        isLoading(true);

        // need to calculate a different Url for EnergySource service
        var restUrl = serviceRootUrl + "EnergySource/GetList/";
        var jqXHR = $.ajax({
            url: restUrl,
            beforeSend: moduleHeaders,
            dataType: "json",
            async: false
        }).done(function (data) {
            if (data) {
                loadEnergySources(data);
            }
            else {
                clear();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };




    // load

    var loadEnergySources = function (data) {
        energySourceList.removeAll();
        var underlyingArray = energySourceList();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var energySource = new Web.energySource
            (
                result.energySourceId, 
                result.name, 
                result.description, 
                result.active, 
                result.isDeleted 
            );
            underlyingArray.push(energySource);
        }
        energySourceList.valueHasMutated();
    };


    // extract knockout array to simple json objects

    var extractKoArrayToJson = function (data) {
        var simpleArray = new Array();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var energySource = {
                energySourceId: result.energySourceId(), 
                name: result.name(), 
                description: result.description(), 
                active: result.active(), 
                isDeleted: result.isDeleted() 
            };

            simpleArray.push(energySource);
        }
        return simpleArray;
    };


    // add

    var addEnergySource = function () {
        var energySource = new Web.energySource(0, '', '', '', '');
        energySourceList.push(energySource);
    };


    // remove

    var removeEnergySource = function (model, event) {
        var energySource = model;
        energySource.isDeleted = true;
        deletedEnergySourceList.push(energySource);
        energySourceList.pop(energySource);
    };


    // clear

    var clear = function () {
        energySourceList([]);
    };


    // quickSearch

    var quickSearch = function () {
        for (var i = 0; i < energySourceList().length; i++) {
            var result = energySourceList()[i];

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
        energySourceList: energySourceList,
        deletedEnergySourceList: deletedEnergySourceList,
        getEnergySourceList: getEnergySourceList,
        loadEnergySources: loadEnergySources,
        isLoading: isLoading,
        addEnergySource: addEnergySource,
        removeEnergySource: removeEnergySource,
        clear: clear,
        searchText: searchText,
        quickSearch: quickSearch,
        extractKoArrayToJson: extractKoArrayToJson
    };
}
    