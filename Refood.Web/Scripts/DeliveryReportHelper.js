
// ################################################################
//                      Code generated with T4
// ################################################################

var Web = Web || {};

// viewmodel

Web.deliveryReport = function ( deliveryReportId, name, description, reportDate, weekDay, submitted, isDeleted) {
    this.deliveryReportId = ko.observable(deliveryReportId);
    this.name = ko.observable(name);
    this.description = ko.observable(description);
    this.reportDate = ko.observable(reportDate);
    this.weekDay = ko.observable(weekDay);
    this.submitted = ko.observable(submitted);
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

Web.deliveryReportHelper = function (isLoading, serviceRootUrl, moduleHeaders) {

    var deliveryReportList = ko.observableArray([]);
    var deletedDeliveryReportList = ko.observableArray([]);
    var isLoading = isLoading;
    var serviceRootUrl = serviceRootUrl;
    var moduleHeaders = moduleHeaders;
    var searchText = ko.observable('');


    // get

    var getDeliveryReportList = function () {
        isLoading(true);

        // need to calculate a different Url for DeliveryReport service
        var restUrl = serviceRootUrl + "api/DeliveryReportApi/GetList/";
        var jqXHR = $.ajax({
            url: restUrl,
            beforeSend: moduleHeaders,
            dataType: "json",
            async: false
        }).done(function (data) {
            if (data) {
                loadDeliveryReports(data);
            }
            else {
                clear();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };




    // load

    var loadDeliveryReports = function (data) {
        deliveryReportList.removeAll();
        var underlyingArray = deliveryReportList();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var deliveryReport = new Web.deliveryReport
            (
                result.deliveryReportId, 
                result.name, 
                result.description, 
                result.reportDate, 
                result.weekDay, 
                result.submitted, 
                result.isDeleted 
            );
            underlyingArray.push(deliveryReport);
        }
        deliveryReportList.valueHasMutated();
    };


    // extract knockout array to simple json objects

    var extractKoArrayToJson = function (data) {
        var simpleArray = new Array();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var deliveryReport = {
                deliveryReportId: result.deliveryReportId(), 
                name: result.name(), 
                description: result.description(), 
                reportDate: result.reportDate(), 
                weekDay: result.weekDay(), 
                submitted: result.submitted(), 
                isDeleted: result.isDeleted() 
            };

            simpleArray.push(deliveryReport);
        }
        return simpleArray;
    };


    // add

    var addDeliveryReport = function () {
        var deliveryReport = new Web.deliveryReport(0, '', '', '', '');
        deliveryReportList.push(deliveryReport);
    };


    // remove

    var removeDeliveryReport = function (model, event) {
        var deliveryReport = model;
        deliveryReport.isDeleted = true;
        deletedDeliveryReportList.push(deliveryReport);
        deliveryReportList.pop(deliveryReport);
    };


    // clear

    var clear = function () {
        deliveryReportList([]);
    };


    // quickSearch

    var quickSearch = function () {
        for (var i = 0; i < deliveryReportList().length; i++) {
            var result = deliveryReportList()[i];

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
        deliveryReportList: deliveryReportList,
        deletedDeliveryReportList: deletedDeliveryReportList,
        getDeliveryReportList: getDeliveryReportList,
        loadDeliveryReports: loadDeliveryReports,
        isLoading: isLoading,
        addDeliveryReport: addDeliveryReport,
        removeDeliveryReport: removeDeliveryReport,
        clear: clear,
        searchText: searchText,
        quickSearch: quickSearch,
        extractKoArrayToJson: extractKoArrayToJson
    };
}
    