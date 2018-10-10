
// ################################################################
//                      Code generated with T4
// ################################################################

var Web = Web || {};

// viewmodel

Web.weekDay = function ( weekDayId, nucleoId, name, description, responsiblePersonId, active, isDeleted) {
    this.weekDayId = ko.observable(weekDayId);
    this.nucleoId = ko.observable(nucleoId);
    this.name = ko.observable(name);
    this.description = ko.observable(description);
    this.responsiblePersonId = ko.observable(responsiblePersonId);
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

Web.weekDayHelper = function (isLoading, serviceRootUrl, moduleHeaders) {

    var weekDayList = ko.observableArray([]);
    var deletedWeekDayList = ko.observableArray([]);
    var isLoading = isLoading;
    var serviceRootUrl = serviceRootUrl;
    var moduleHeaders = moduleHeaders;
    var searchText = ko.observable('');


    // get

    var getWeekDayList = function () {
        isLoading(true);

        // need to calculate a different Url for WeekDay service
        var restUrl = serviceRootUrl + "api/WeekDayApi/GetList/";
        var jqXHR = $.ajax({
            url: restUrl,
            beforeSend: moduleHeaders,
            dataType: "json",
            async: false
        }).done(function (data) {
            if (data) {
                loadWeekDays(data);
            }
            else {
                clear();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };




    // load

    var loadWeekDays = function (data) {
        weekDayList.removeAll();
        var underlyingArray = weekDayList();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var weekDay = new Web.weekDay
            (
                result.weekDayId, 
                result.nucleoId, 
                result.name, 
                result.description, 
                result.responsiblePersonId, 
                result.active, 
                result.isDeleted 
            );
            underlyingArray.push(weekDay);
        }
        weekDayList.valueHasMutated();
    };


    // extract knockout array to simple json objects

    var extractKoArrayToJson = function (data) {
        var simpleArray = new Array();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var weekDay = {
                weekDayId: result.weekDayId(), 
                nucleoId: result.nucleoId(), 
                name: result.name(), 
                description: result.description(), 
                responsiblePersonId: result.responsiblePersonId(), 
                active: result.active(), 
                isDeleted: result.isDeleted() 
            };

            simpleArray.push(weekDay);
        }
        return simpleArray;
    };


    // add

    var addWeekDay = function () {
        var weekDay = new Web.weekDay(0, '', '', '', '');
        weekDayList.push(weekDay);
    };


    // remove

    var removeWeekDay = function (model, event) {
        var weekDay = model;
        weekDay.isDeleted = true;
        deletedWeekDayList.push(weekDay);
        weekDayList.pop(weekDay);
    };


    // clear

    var clear = function () {
        weekDayList([]);
    };


    // quickSearch

    var quickSearch = function () {
        for (var i = 0; i < weekDayList().length; i++) {
            var result = weekDayList()[i];

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
        weekDayList: weekDayList,
        deletedWeekDayList: deletedWeekDayList,
        getWeekDayList: getWeekDayList,
        loadWeekDays: loadWeekDays,
        isLoading: isLoading,
        addWeekDay: addWeekDay,
        removeWeekDay: removeWeekDay,
        clear: clear,
        searchText: searchText,
        quickSearch: quickSearch,
        extractKoArrayToJson: extractKoArrayToJson
    };
}
    