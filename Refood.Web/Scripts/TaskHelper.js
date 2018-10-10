
// ################################################################
//                      Code generated with T4
// ################################################################

var Web = Web || {};

// viewmodel

Web.task = function ( taskId, name, taskTypeId, taskDate, weekDay, startTime, endTime, estimatedDuration, description, requiresCar, teamLeaderId, active, isDeleted) {
    this.taskId = ko.observable(taskId);
    this.name = ko.observable(name);
    this.taskTypeId = ko.observable(taskTypeId);
    this.taskDate = ko.observable(taskDate);
    this.weekDay = ko.observable(weekDay);
    this.startTime = ko.observable(startTime);
    this.endTime = ko.observable(endTime);
    this.estimatedDuration = ko.observable(estimatedDuration);
    this.description = ko.observable(description);
    this.requiresCar = ko.observable(requiresCar);
    this.teamLeaderId = ko.observable(teamLeaderId);
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

Web.taskHelper = function (isLoading, serviceRootUrl, moduleHeaders) {

    var taskList = ko.observableArray([]);
    var deletedTaskList = ko.observableArray([]);
    var isLoading = isLoading;
    var serviceRootUrl = serviceRootUrl;
    var moduleHeaders = moduleHeaders;
    var searchText = ko.observable('');


    // get

    var getTaskList = function () {
        isLoading(true);

        // need to calculate a different Url for Task service
        var restUrl = serviceRootUrl + "api/TaskApi/GetList/";
        var jqXHR = $.ajax({
            url: restUrl,
            beforeSend: moduleHeaders,
            dataType: "json",
            async: false
        }).done(function (data) {
            if (data) {
                loadTasks(data);
            }
            else {
                clear();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };




    // load

    var loadTasks = function (data) {
        taskList.removeAll();
        var underlyingArray = taskList();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var task = new Web.task
            (
                result.taskId, 
                result.name, 
                result.taskTypeId, 
                result.taskDate, 
                result.weekDay, 
                result.startTime, 
                result.endTime, 
                result.estimatedDuration, 
                result.description, 
                result.requiresCar, 
                result.teamLeaderId, 
                result.active, 
                result.isDeleted 
            );
            underlyingArray.push(task);
        }
        taskList.valueHasMutated();
    };


    // extract knockout array to simple json objects

    var extractKoArrayToJson = function (data) {
        var simpleArray = new Array();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var task = {
                taskId: result.taskId(), 
                name: result.name(), 
                taskTypeId: result.taskTypeId(), 
                taskDate: result.taskDate(), 
                weekDay: result.weekDay(), 
                startTime: result.startTime(), 
                endTime: result.endTime(), 
                estimatedDuration: result.estimatedDuration(), 
                description: result.description(), 
                requiresCar: result.requiresCar(), 
                teamLeaderId: result.teamLeaderId(), 
                active: result.active(), 
                isDeleted: result.isDeleted() 
            };

            simpleArray.push(task);
        }
        return simpleArray;
    };


    // add

    var addTask = function () {
        var task = new Web.task(0, '', '', '', '');
        taskList.push(task);
    };


    // remove

    var removeTask = function (model, event) {
        var task = model;
        task.isDeleted = true;
        deletedTaskList.push(task);
        taskList.pop(task);
    };


    // clear

    var clear = function () {
        taskList([]);
    };


    // quickSearch

    var quickSearch = function () {
        for (var i = 0; i < taskList().length; i++) {
            var result = taskList()[i];

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
        taskList: taskList,
        deletedTaskList: deletedTaskList,
        getTaskList: getTaskList,
        loadTasks: loadTasks,
        isLoading: isLoading,
        addTask: addTask,
        removeTask: removeTask,
        clear: clear,
        searchText: searchText,
        quickSearch: quickSearch,
        extractKoArrayToJson: extractKoArrayToJson
    };
}
    