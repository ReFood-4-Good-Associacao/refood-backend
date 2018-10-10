
// ################################################################
//                      Code generated with T4
// ################################################################

var Web = Web || {};

// viewmodel

Web.deliveryReportMessage = function ( deliveryReportMessageId, deliveryReportMessageTypeId, message, isDeleted) {
    this.deliveryReportMessageId = ko.observable(deliveryReportMessageId);
    this.deliveryReportMessageTypeId = ko.observable(deliveryReportMessageTypeId);
    this.message = ko.observable(message);
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

Web.deliveryReportMessageHelper = function (isLoading, serviceRootUrl, moduleHeaders) {

    var deliveryReportMessageList = ko.observableArray([]);
    var deletedDeliveryReportMessageList = ko.observableArray([]);
    var isLoading = isLoading;
    var serviceRootUrl = serviceRootUrl;
    var moduleHeaders = moduleHeaders;
    var searchText = ko.observable('');


    // get

    var getDeliveryReportMessageList = function () {
        isLoading(true);

        // need to calculate a different Url for DeliveryReportMessage service
        var restUrl = serviceRootUrl + "api/DeliveryReportMessageApi/GetList/";
        var jqXHR = $.ajax({
            url: restUrl,
            beforeSend: moduleHeaders,
            dataType: "json",
            async: false
        }).done(function (data) {
            if (data) {
                loadDeliveryReportMessages(data);
            }
            else {
                clear();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };




    // load

    var loadDeliveryReportMessages = function (data) {
        deliveryReportMessageList.removeAll();
        var underlyingArray = deliveryReportMessageList();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var deliveryReportMessage = new Web.deliveryReportMessage
            (
                result.deliveryReportMessageId, 
                result.deliveryReportMessageTypeId, 
                result.message, 
                result.isDeleted 
            );
            underlyingArray.push(deliveryReportMessage);
        }
        deliveryReportMessageList.valueHasMutated();
    };


    // extract knockout array to simple json objects

    var extractKoArrayToJson = function (data) {
        var simpleArray = new Array();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var deliveryReportMessage = {
                deliveryReportMessageId: result.deliveryReportMessageId(), 
                deliveryReportMessageTypeId: result.deliveryReportMessageTypeId(), 
                message: result.message(), 
                isDeleted: result.isDeleted() 
            };

            simpleArray.push(deliveryReportMessage);
        }
        return simpleArray;
    };


    // add

    var addDeliveryReportMessage = function () {
        var deliveryReportMessage = new Web.deliveryReportMessage(0, '', '', '', '');
        deliveryReportMessageList.push(deliveryReportMessage);
    };


    // remove

    var removeDeliveryReportMessage = function (model, event) {
        var deliveryReportMessage = model;
        deliveryReportMessage.isDeleted = true;
        deletedDeliveryReportMessageList.push(deliveryReportMessage);
        deliveryReportMessageList.pop(deliveryReportMessage);
    };


    // clear

    var clear = function () {
        deliveryReportMessageList([]);
    };


    // quickSearch

    var quickSearch = function () {
        for (var i = 0; i < deliveryReportMessageList().length; i++) {
            var result = deliveryReportMessageList()[i];

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
        deliveryReportMessageList: deliveryReportMessageList,
        deletedDeliveryReportMessageList: deletedDeliveryReportMessageList,
        getDeliveryReportMessageList: getDeliveryReportMessageList,
        loadDeliveryReportMessages: loadDeliveryReportMessages,
        isLoading: isLoading,
        addDeliveryReportMessage: addDeliveryReportMessage,
        removeDeliveryReportMessage: removeDeliveryReportMessage,
        clear: clear,
        searchText: searchText,
        quickSearch: quickSearch,
        extractKoArrayToJson: extractKoArrayToJson
    };
}
    