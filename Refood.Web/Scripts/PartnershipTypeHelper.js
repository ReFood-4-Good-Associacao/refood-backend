
// ################################################################
//                      Code generated with T4
// ################################################################

var Web = Web || {};

// viewmodel

Web.partnershipType = function ( partnershipTypeId, name, description, activityType, active, isDeleted) {
    this.partnershipTypeId = ko.observable(partnershipTypeId);
    this.name = ko.observable(name);
    this.description = ko.observable(description);
    this.activityType = ko.observable(activityType);
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

Web.partnershipTypeHelper = function (isLoading, serviceRootUrl, moduleHeaders) {

    var partnershipTypeList = ko.observableArray([]);
    var deletedPartnershipTypeList = ko.observableArray([]);
    var isLoading = isLoading;
    var serviceRootUrl = serviceRootUrl;
    var moduleHeaders = moduleHeaders;
    var searchText = ko.observable('');


    // get

    var getPartnershipTypeList = function () {
        isLoading(true);

        // need to calculate a different Url for PartnershipType service
        var restUrl = serviceRootUrl + "api/PartnershipTypeApi/GetList/";
        var jqXHR = $.ajax({
            url: restUrl,
            beforeSend: moduleHeaders,
            dataType: "json",
            async: false
        }).done(function (data) {
            if (data) {
                loadPartnershipTypes(data);
            }
            else {
                clear();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };




    // load

    var loadPartnershipTypes = function (data) {
        partnershipTypeList.removeAll();
        var underlyingArray = partnershipTypeList();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var partnershipType = new Web.partnershipType
            (
                result.partnershipTypeId, 
                result.name, 
                result.description, 
                result.activityType, 
                result.active, 
                result.isDeleted 
            );
            underlyingArray.push(partnershipType);
        }
        partnershipTypeList.valueHasMutated();
    };


    // extract knockout array to simple json objects

    var extractKoArrayToJson = function (data) {
        var simpleArray = new Array();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var partnershipType = {
                partnershipTypeId: result.partnershipTypeId(), 
                name: result.name(), 
                description: result.description(), 
                activityType: result.activityType(), 
                active: result.active(), 
                isDeleted: result.isDeleted() 
            };

            simpleArray.push(partnershipType);
        }
        return simpleArray;
    };


    // add

    var addPartnershipType = function () {
        var partnershipType = new Web.partnershipType(0, '', '', '', '');
        partnershipTypeList.push(partnershipType);
    };


    // remove

    var removePartnershipType = function (model, event) {
        var partnershipType = model;
        partnershipType.isDeleted = true;
        deletedPartnershipTypeList.push(partnershipType);
        partnershipTypeList.pop(partnershipType);
    };


    // clear

    var clear = function () {
        partnershipTypeList([]);
    };


    // quickSearch

    var quickSearch = function () {
        for (var i = 0; i < partnershipTypeList().length; i++) {
            var result = partnershipTypeList()[i];

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
        partnershipTypeList: partnershipTypeList,
        deletedPartnershipTypeList: deletedPartnershipTypeList,
        getPartnershipTypeList: getPartnershipTypeList,
        loadPartnershipTypes: loadPartnershipTypes,
        isLoading: isLoading,
        addPartnershipType: addPartnershipType,
        removePartnershipType: removePartnershipType,
        clear: clear,
        searchText: searchText,
        quickSearch: quickSearch,
        extractKoArrayToJson: extractKoArrayToJson
    };
}
    