
// ################################################################
//                      Code generated with T4
// ################################################################

var Web = Web || {};

// viewmodel

Web.taskType = function ( taskTypeId, name, description, active, isDeleted) {
    this.taskTypeId = ko.observable(taskTypeId);
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

Web.taskTypeHelper = function (isLoading, serviceRootUrl, moduleHeaders) {

    var taskTypeList = ko.observableArray([]);
    var deletedTaskTypeList = ko.observableArray([]);
    var isLoading = isLoading;
    var serviceRootUrl = serviceRootUrl;
    var moduleHeaders = moduleHeaders;
    var searchText = ko.observable('');


    // get

    var getTaskTypeList = function () {
        isLoading(true);

        // need to calculate a different Url for TaskType service
        var restUrl = serviceRootUrl + "api/TaskTypeApi/GetList/";
        var jqXHR = $.ajax({
            url: restUrl,
            beforeSend: moduleHeaders,
            dataType: "json",
            async: false
        }).done(function (data) {
            if (data) {
                loadTaskTypes(data);
            }
            else {
                clear();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };




    // load

    var loadTaskTypes = function (data) {
        taskTypeList.removeAll();
        var underlyingArray = taskTypeList();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var taskType = new Web.taskType
            (
                result.taskTypeId, 
                result.name, 
                result.description, 
                result.active, 
                result.isDeleted 
            );
            underlyingArray.push(taskType);
        }
        taskTypeList.valueHasMutated();
    };


    // extract knockout array to simple json objects

    var extractKoArrayToJson = function (data) {
        var simpleArray = new Array();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var taskType = {
                taskTypeId: result.taskTypeId(), 
                name: result.name(), 
                description: result.description(), 
                active: result.active(), 
                isDeleted: result.isDeleted() 
            };

            simpleArray.push(taskType);
        }
        return simpleArray;
    };


    // add

    var addTaskType = function () {
        var taskType = new Web.taskType(0, '', '', '', '');
        taskTypeList.push(taskType);
    };


    // remove

    var removeTaskType = function (model, event) {
        var taskType = model;
        taskType.isDeleted = true;
        deletedTaskTypeList.push(taskType);
        taskTypeList.pop(taskType);
    };


    // clear

    var clear = function () {
        taskTypeList([]);
    };


    // quickSearch

    var quickSearch = function () {
        for (var i = 0; i < taskTypeList().length; i++) {
            var result = taskTypeList()[i];

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
        taskTypeList: taskTypeList,
        deletedTaskTypeList: deletedTaskTypeList,
        getTaskTypeList: getTaskTypeList,
        loadTaskTypes: loadTaskTypes,
        isLoading: isLoading,
        addTaskType: addTaskType,
        removeTaskType: removeTaskType,
        clear: clear,
        searchText: searchText,
        quickSearch: quickSearch,
        extractKoArrayToJson: extractKoArrayToJson
    };
}
    