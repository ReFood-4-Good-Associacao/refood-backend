
// ################################################################
//                      Code generated with T4
// ################################################################

var Web = Web || {};

// viewmodel

Web.calendarEvent = function ( calendarEventId, nucleoId, name, description, startDate, endDate, active, isDeleted) {
    this.calendarEventId = ko.observable(calendarEventId);
    this.nucleoId = ko.observable(nucleoId);
    this.name = ko.observable(name);
    this.description = ko.observable(description);
    this.startDate = ko.observable(startDate);
    this.endDate = ko.observable(endDate);
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

Web.calendarEventHelper = function (isLoading, serviceRootUrl, moduleHeaders) {

    var calendarEventList = ko.observableArray([]);
    var deletedCalendarEventList = ko.observableArray([]);
    var isLoading = isLoading;
    var serviceRootUrl = serviceRootUrl;
    var moduleHeaders = moduleHeaders;
    var searchText = ko.observable('');


    // get

    var getCalendarEventList = function () {
        isLoading(true);

        // need to calculate a different Url for CalendarEvent service
        var restUrl = serviceRootUrl + "api/CalendarEventApi/GetList/";
        var jqXHR = $.ajax({
            url: restUrl,
            beforeSend: moduleHeaders,
            dataType: "json",
            async: false
        }).done(function (data) {
            if (data) {
                loadCalendarEvents(data);
            }
            else {
                clear();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };




    // load

    var loadCalendarEvents = function (data) {
        calendarEventList.removeAll();
        var underlyingArray = calendarEventList();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var calendarEvent = new Web.calendarEvent
            (
                result.calendarEventId, 
                result.nucleoId, 
                result.name, 
                result.description, 
                result.startDate, 
                result.endDate, 
                result.active, 
                result.isDeleted 
            );
            underlyingArray.push(calendarEvent);
        }
        calendarEventList.valueHasMutated();
    };


    // extract knockout array to simple json objects

    var extractKoArrayToJson = function (data) {
        var simpleArray = new Array();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var calendarEvent = {
                calendarEventId: result.calendarEventId(), 
                nucleoId: result.nucleoId(), 
                name: result.name(), 
                description: result.description(), 
                startDate: result.startDate(), 
                endDate: result.endDate(), 
                active: result.active(), 
                isDeleted: result.isDeleted() 
            };

            simpleArray.push(calendarEvent);
        }
        return simpleArray;
    };


    // add

    var addCalendarEvent = function () {
        var calendarEvent = new Web.calendarEvent(0, '', '', '', '');
        calendarEventList.push(calendarEvent);
    };


    // remove

    var removeCalendarEvent = function (model, event) {
        var calendarEvent = model;
        calendarEvent.isDeleted = true;
        deletedCalendarEventList.push(calendarEvent);
        calendarEventList.pop(calendarEvent);
    };


    // clear

    var clear = function () {
        calendarEventList([]);
    };


    // quickSearch

    var quickSearch = function () {
        for (var i = 0; i < calendarEventList().length; i++) {
            var result = calendarEventList()[i];

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
        calendarEventList: calendarEventList,
        deletedCalendarEventList: deletedCalendarEventList,
        getCalendarEventList: getCalendarEventList,
        loadCalendarEvents: loadCalendarEvents,
        isLoading: isLoading,
        addCalendarEvent: addCalendarEvent,
        removeCalendarEvent: removeCalendarEvent,
        clear: clear,
        searchText: searchText,
        quickSearch: quickSearch,
        extractKoArrayToJson: extractKoArrayToJson
    };
}
    