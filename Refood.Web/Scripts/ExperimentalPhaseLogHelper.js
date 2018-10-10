
// ################################################################
//                      Code generated with T4
// ################################################################

var Web = Web || {};

// viewmodel

Web.experimentalPhaseLog = function ( experimentalPhaseLogId, nucleoId, logDate, task, activityDescription, managerName, volunteerName, volunteerConfirmation, documentId, isDeleted) {
    this.experimentalPhaseLogId = ko.observable(experimentalPhaseLogId);
    this.nucleoId = ko.observable(nucleoId);
    this.logDate = ko.observable(logDate);
    this.task = ko.observable(task);
    this.activityDescription = ko.observable(activityDescription);
    this.managerName = ko.observable(managerName);
    this.volunteerName = ko.observable(volunteerName);
    this.volunteerConfirmation = ko.observable(volunteerConfirmation);
    this.documentId = ko.observable(documentId);
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

Web.experimentalPhaseLogHelper = function (isLoading, serviceRootUrl, moduleHeaders) {

    var experimentalPhaseLogList = ko.observableArray([]);
    var deletedExperimentalPhaseLogList = ko.observableArray([]);
    var isLoading = isLoading;
    var serviceRootUrl = serviceRootUrl;
    var moduleHeaders = moduleHeaders;
    var searchText = ko.observable('');


    // get

    var getExperimentalPhaseLogList = function () {
        isLoading(true);

        // need to calculate a different Url for ExperimentalPhaseLog service
        var restUrl = serviceRootUrl + "api/ExperimentalPhaseLogApi/GetList/";
        var jqXHR = $.ajax({
            url: restUrl,
            beforeSend: moduleHeaders,
            dataType: "json",
            async: false
        }).done(function (data) {
            if (data) {
                loadExperimentalPhaseLogs(data);
            }
            else {
                clear();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };




    // load

    var loadExperimentalPhaseLogs = function (data) {
        experimentalPhaseLogList.removeAll();
        var underlyingArray = experimentalPhaseLogList();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var experimentalPhaseLog = new Web.experimentalPhaseLog
            (
                result.experimentalPhaseLogId, 
                result.nucleoId, 
                result.logDate, 
                result.task, 
                result.activityDescription, 
                result.managerName, 
                result.volunteerName, 
                result.volunteerConfirmation, 
                result.documentId, 
                result.isDeleted 
            );
            underlyingArray.push(experimentalPhaseLog);
        }
        experimentalPhaseLogList.valueHasMutated();
    };


    // extract knockout array to simple json objects

    var extractKoArrayToJson = function (data) {
        var simpleArray = new Array();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var experimentalPhaseLog = {
                experimentalPhaseLogId: result.experimentalPhaseLogId(), 
                nucleoId: result.nucleoId(), 
                logDate: result.logDate(), 
                task: result.task(), 
                activityDescription: result.activityDescription(), 
                managerName: result.managerName(), 
                volunteerName: result.volunteerName(), 
                volunteerConfirmation: result.volunteerConfirmation(), 
                documentId: result.documentId(), 
                isDeleted: result.isDeleted() 
            };

            simpleArray.push(experimentalPhaseLog);
        }
        return simpleArray;
    };


    // add

    var addExperimentalPhaseLog = function () {
        var experimentalPhaseLog = new Web.experimentalPhaseLog(0, '', '', '', '');
        experimentalPhaseLogList.push(experimentalPhaseLog);
    };


    // remove

    var removeExperimentalPhaseLog = function (model, event) {
        var experimentalPhaseLog = model;
        experimentalPhaseLog.isDeleted = true;
        deletedExperimentalPhaseLogList.push(experimentalPhaseLog);
        experimentalPhaseLogList.pop(experimentalPhaseLog);
    };


    // clear

    var clear = function () {
        experimentalPhaseLogList([]);
    };


    // quickSearch

    var quickSearch = function () {
        for (var i = 0; i < experimentalPhaseLogList().length; i++) {
            var result = experimentalPhaseLogList()[i];

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
        experimentalPhaseLogList: experimentalPhaseLogList,
        deletedExperimentalPhaseLogList: deletedExperimentalPhaseLogList,
        getExperimentalPhaseLogList: getExperimentalPhaseLogList,
        loadExperimentalPhaseLogs: loadExperimentalPhaseLogs,
        isLoading: isLoading,
        addExperimentalPhaseLog: addExperimentalPhaseLog,
        removeExperimentalPhaseLog: removeExperimentalPhaseLog,
        clear: clear,
        searchText: searchText,
        quickSearch: quickSearch,
        extractKoArrayToJson: extractKoArrayToJson
    };
}
    