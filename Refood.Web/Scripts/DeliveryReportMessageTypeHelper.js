
// ################################################################
//                      Code generated with T4
// ################################################################

var Web = Web || {};

// viewmodel

Web.deliveryReportMessageType = function ( deliveryReportMessageTypeId, name, description, active, isDeleted) {
    this.deliveryReportMessageTypeId = ko.observable(deliveryReportMessageTypeId);
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

Web.deliveryReportMessageTypeHelper = function (isLoading, serviceRootUrl, moduleHeaders) {

    var deliveryReportMessageTypeList = ko.observableArray([]);
    var deletedDeliveryReportMessageTypeList = ko.observableArray([]);
    var isLoading = isLoading;
    var serviceRootUrl = serviceRootUrl;
    var moduleHeaders = moduleHeaders;
    var searchText = ko.observable('');


    // get

    var getDeliveryReportMessageTypeList = function () {
        isLoading(true);

        // need to calculate a different Url for DeliveryReportMessageType service
        var restUrl = serviceRootUrl + "api/DeliveryReportMessageTypeApi/GetList/";
        var jqXHR = $.ajax({
            url: restUrl,
            beforeSend: moduleHeaders,
            dataType: "json",
            async: false
        }).done(function (data) {
            if (data) {
                loadDeliveryReportMessageTypes(data);
            }
            else {
                clear();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };




    // load

    var loadDeliveryReportMessageTypes = function (data) {
        deliveryReportMessageTypeList.removeAll();
        var underlyingArray = deliveryReportMessageTypeList();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var deliveryReportMessageType = new Web.deliveryReportMessageType
            (
                result.deliveryReportMessageTypeId, 
                result.name, 
                result.description, 
                result.active, 
                result.isDeleted 
            );
            underlyingArray.push(deliveryReportMessageType);
        }
        deliveryReportMessageTypeList.valueHasMutated();
    };


    // extract knockout array to simple json objects

    var extractKoArrayToJson = function (data) {
        var simpleArray = new Array();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var deliveryReportMessageType = {
                deliveryReportMessageTypeId: result.deliveryReportMessageTypeId(), 
                name: result.name(), 
                description: result.description(), 
                active: result.active(), 
                isDeleted: result.isDeleted() 
            };

            simpleArray.push(deliveryReportMessageType);
        }
        return simpleArray;
    };


    // add

    var addDeliveryReportMessageType = function () {
        var deliveryReportMessageType = new Web.deliveryReportMessageType(0, '', '', '', '');
        deliveryReportMessageTypeList.push(deliveryReportMessageType);
    };


    // remove

    var removeDeliveryReportMessageType = function (model, event) {
        var deliveryReportMessageType = model;
        deliveryReportMessageType.isDeleted = true;
        deletedDeliveryReportMessageTypeList.push(deliveryReportMessageType);
        deliveryReportMessageTypeList.pop(deliveryReportMessageType);
    };


    // clear

    var clear = function () {
        deliveryReportMessageTypeList([]);
    };


    // quickSearch

    var quickSearch = function () {
        for (var i = 0; i < deliveryReportMessageTypeList().length; i++) {
            var result = deliveryReportMessageTypeList()[i];

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
        deliveryReportMessageTypeList: deliveryReportMessageTypeList,
        deletedDeliveryReportMessageTypeList: deletedDeliveryReportMessageTypeList,
        getDeliveryReportMessageTypeList: getDeliveryReportMessageTypeList,
        loadDeliveryReportMessageTypes: loadDeliveryReportMessageTypes,
        isLoading: isLoading,
        addDeliveryReportMessageType: addDeliveryReportMessageType,
        removeDeliveryReportMessageType: removeDeliveryReportMessageType,
        clear: clear,
        searchText: searchText,
        quickSearch: quickSearch,
        extractKoArrayToJson: extractKoArrayToJson
    };
}
    