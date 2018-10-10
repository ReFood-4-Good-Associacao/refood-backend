
// ################################################################
//                      Code generated with T4
// ################################################################

var Web = Web || {};

Web.taskListViewModel = function (moduleId, resx) {
    var baseUrl = "api/TaskApi/";

    var isLoading = ko.observable(false);
    var taskList = ko.observableArray([]);
    var editMode = ko.computed(function () {
        return taskList().length > 0 && taskList()[0].editUrl() != null && taskList()[0].editUrl().length > 0;
    });
    var searchText = ko.observable('');



    // filters

    var nameFilter = ko.observable('');
    var taskTypeIdFilter = ko.observable(-1);
    var taskDateFromFilter = ko.observable('');
    var taskDateToFilter = ko.observable('');
    var weekDayFilter = ko.observable('');
    var startTimeFromFilter = ko.observable('');
    var startTimeToFilter = ko.observable('');
    var endTimeFromFilter = ko.observable('');
    var endTimeToFilter = ko.observable('');
    var estimatedDurationFilter = ko.observable('');
    var descriptionFilter = ko.observable('');
    var requiresCarFilter = ko.observable('');
    var teamLeaderIdFilter = ko.observable(-1);
    var activeFilter = ko.observable('');



    // helpers

    var taskTypeHelper = Web.taskTypeHelper(isLoading, '/', function(){});
    var teamLeaderHelper = Web.teamLeaderHelper(isLoading, '/', function(){});



    // init

    var init = function () {
        //getTaskList();
        //getTaskPage();
        getTaskListAdvanced();

        taskTypeHelper.getTaskTypeList();
        teamLeaderHelper.getTeamLeaderList();
    }



    // get list

    var getTaskList = function () {
        isLoading(true);
        var jqXHR = $.ajax({
            url: baseUrl + "GetList/",
            dataType: "json"
        }).done(function (data) {
            if (data) {
                load(data);

                // update datatable
                updateDatatable(data);
            }
            else {
                // No data to load 
                taskList.removeAll();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };



    // get list - advanced search

    var getTaskListAdvanced = function () {
        isLoading(true);

        var searchFilters = "?";
        searchFilters += (nameFilter() != '' ? "name=" + nameFilter() : "");
        searchFilters += (taskTypeIdFilter() != -1 && taskTypeIdFilter() != undefined ? "&" + "taskTypeId=" + taskTypeIdFilter() : "");
        searchFilters += (taskDateFromFilter() != '' && taskDateFromFilter() != null ? "&" + "taskDateFrom=" + dateToStringServerFormat(taskDateFromFilter()) : "");
        searchFilters += (taskDateToFilter() != '' && taskDateToFilter() != null ? "&" + "taskDateTo=" + dateToStringServerFormat(taskDateToFilter()) : "");
        searchFilters += (weekDayFilter() != '' ? "weekDay=" + weekDayFilter() : "");
        searchFilters += (startTimeFromFilter() != '' && startTimeFromFilter() != null ? "&" + "startTimeFrom=" + dateToStringServerFormat(startTimeFromFilter()) : "");
        searchFilters += (startTimeToFilter() != '' && startTimeToFilter() != null ? "&" + "startTimeTo=" + dateToStringServerFormat(startTimeToFilter()) : "");
        searchFilters += (endTimeFromFilter() != '' && endTimeFromFilter() != null ? "&" + "endTimeFrom=" + dateToStringServerFormat(endTimeFromFilter()) : "");
        searchFilters += (endTimeToFilter() != '' && endTimeToFilter() != null ? "&" + "endTimeTo=" + dateToStringServerFormat(endTimeToFilter()) : "");
        searchFilters += (estimatedDurationFilter() != '' ? "estimatedDuration=" + estimatedDurationFilter() : "");
        searchFilters += (descriptionFilter() != '' ? "description=" + descriptionFilter() : "");
        searchFilters += (requiresCarFilter() != '' ? "requiresCar=" + requiresCarFilter() : "");
        searchFilters += (teamLeaderIdFilter() != -1 && teamLeaderIdFilter() != undefined ? "&" + "teamLeaderId=" + teamLeaderIdFilter() : "");
        searchFilters += (activeFilter() != '' ? "active=" + activeFilter() : "");

        var jqXHR = $.ajax({
            url: baseUrl + "GetListAdvancedSearch/0/" + searchFilters,
            dataType: "json"
        }).done(function (data) {
            if (data) {
                load(data);

                // update datatable
                updateDatatable(data);
            }
            else {
                // No data to load 
                taskList.removeAll();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };

    var advancedSearch = function () {
        getTaskListAdvanced();
    };

    var clearSearchFilters = function () {
        nameFilter('');
        taskTypeIdFilter(-1);
        taskDateFromFilter('');
        taskDateToFilter('');
        weekDayFilter('');
        startTimeFromFilter('');
        startTimeToFilter('');
        endTimeFromFilter('');
        endTimeToFilter('');
        estimatedDurationFilter('');
        descriptionFilter('');
        requiresCarFilter('');
        teamLeaderIdFilter(-1);
        activeFilter('');
    };



    // get list by page

    var getTaskPage = function () {
        isLoading(true);

        var searchFilters = "?"
            + (searchText() != '' ? "searchTerm=" + searchText() : "")
            + "&" + "pageIndex=" + pager.currentPageIndex()
            + "&" + "pageSize=" + pager.currentPageSize()
        ;

        var restUrl = baseUrl + "GetPage/0/" + searchFilters;

        var jqXHR = $.ajax({
            url: restUrl,
            dataType: "json"
        }).done(function (data) {
            if (data) {
                load(data);

                // update datatable
                updateDatatable(data);
            }
            else {
                // No data to load 
                taskList.removeAll();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };



    // delete

    var deleteTask = function (task) {
        isLoading(true);
        var restUrl = baseUrl + "Delete/" + task.taskId();
        var jqXHR = $.ajax({
            url: restUrl,
            dataType: "json"
        }).done(function () {
            console.log("Deleted: " + task.taskId());
            taskList.remove(task);
        }).fail(function () {
            console.log("Error");
        }).always(function (data) {
            console.log("finished");
            isLoading(false);
        });
    }

    var deleteTaskById = function (taskId) {
        isLoading(true);
        var restUrl = baseUrl + "Delete/" + taskId;
        var jqXHR = $.ajax({
            method: "GET",
            url: restUrl,
            dataType: "json"
        }).done(function () {
            console.log("Deleted: " + taskId);
            //taskList.remove(task);
            // refresh
            getTaskList();
        }).fail(function () {
            console.log("Error");
        }).always(function (data) {
            console.log("finished");
            isLoading(false);
        });
    }



    // load

    var load = function (data) {
        taskList.removeAll();
        var underlyingArray = taskList();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var task = new Web.taskViewModel();
            task.load(result);
            underlyingArray.push(task);
        }
        taskList.valueHasMutated();
    };



    // data table

    var updateDatatable = function (data) {
        var dataArray = new Array();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var fieldsInArray = new Array();

            fieldsInArray.push(result.name);
            fieldsInArray.push(result.taskTypeId);
            fieldsInArray.push(result.taskDate);
            fieldsInArray.push(result.weekDay);
            fieldsInArray.push(result.startTime);
            fieldsInArray.push(result.endTime);
            fieldsInArray.push(result.estimatedDuration);
            fieldsInArray.push(result.description);
            fieldsInArray.push(result.requiresCar);
            fieldsInArray.push(result.teamLeaderId);
            fieldsInArray.push(result.active);

            var viewLinkElement = '<a href=\"' + result.editUrl + '\" style=\"margin-right: 10px;\">View</a>';
            var editLinkElement = '<a href=\"' + result.editUrl + '\" style=\"margin-right: 10px;\">Edit</a>';
            var deleteLinkElement = '<a href=\"' + 'javascript:vm.deleteTaskById(' + result.taskId + ');' + '\" style=\"margin-right: 10px;\">Delete</a>';
            fieldsInArray.push(viewLinkElement + editLinkElement + deleteLinkElement);

            dataArray.push(fieldsInArray);
        }

        var datatable = $("#TasksTable-" + moduleId).DataTable();
        datatable.clear();
        datatable.rows.add(dataArray);
        datatable.draw();
    };



    // open create form

    var openCreateForm = function () {
        var isPopUp = "?popUp=true";
        var path = location.pathname + "/ctl/Edit/mid/" + moduleId + isPopUp;
        dnnModal.show(path, false, 550, 950, true, '');
    };



    return {
        init: init,
        load: load,
        taskList: taskList,
        getTaskList: getTaskList,
        getTaskPage: getTaskPage,
        deleteTask: deleteTask,
        deleteTaskById: deleteTaskById,
        editMode: editMode,
        isLoading: isLoading,
        searchText: searchText,
        openCreateForm: openCreateForm,
        getTaskListAdvanced: getTaskListAdvanced,
        advancedSearch: advancedSearch,
        clearSearchFilters: clearSearchFilters,

        taskTypeList: taskTypeHelper.taskTypeList,
        teamLeaderList: teamLeaderHelper.teamLeaderList,

        nameFilter: nameFilter,
        taskTypeIdFilter: taskTypeIdFilter,
        taskDateFromFilter: taskDateFromFilter,
        taskDateToFilter: taskDateToFilter,
        weekDayFilter: weekDayFilter,
        startTimeFromFilter: startTimeFromFilter,
        startTimeToFilter: startTimeToFilter,
        endTimeFromFilter: endTimeFromFilter,
        endTimeToFilter: endTimeToFilter,
        estimatedDurationFilter: estimatedDurationFilter,
        descriptionFilter: descriptionFilter,
        requiresCarFilter: requiresCarFilter,
        teamLeaderIdFilter: teamLeaderIdFilter,
        activeFilter: activeFilter,
    }
};



// view model

Web.taskViewModel = function () {
    var taskId = ko.observable(-1);
    var name = ko.observable('');
    var taskTypeId = ko.observable(-1);
    var taskDate = ko.observable('');
    var weekDay = ko.observable('');
    var startTime = ko.observable('');
    var endTime = ko.observable('');
    var estimatedDuration = ko.observable('');
    var description = ko.observable('');
    var requiresCar = ko.observable('');
    var teamLeaderId = ko.observable(-1);
    var active = ko.observable('');
    var isDeleted = ko.observable('');

    var editUrl = ko.observable('');

    var visibleOnSearch = ko.observable(true);
 
    // load

    var load = function (data) {
        taskId(data.taskId);
        name(data.name);
        taskTypeId(data.taskTypeId);
        taskDate(data.taskDate);
        weekDay(data.weekDay);
        startTime(data.startTime);
        endTime(data.endTime);
        estimatedDuration(data.estimatedDuration);
        description(data.description);
        requiresCar(data.requiresCar);
        teamLeaderId(data.teamLeaderId);
        active(data.active);
        isDeleted(data.isDeleted);
        editUrl(data.editUrl);
    };



    return {
        taskId: taskId,
        name: name,
        taskTypeId: taskTypeId,
        taskDate: taskDate,
        weekDay: weekDay,
        startTime: startTime,
        endTime: endTime,
        estimatedDuration: estimatedDuration,
        description: description,
        requiresCar: requiresCar,
        teamLeaderId: teamLeaderId,
        active: active,
        isDeleted: isDeleted,
        editUrl: editUrl,
        load: load,
        visibleOnSearch: visibleOnSearch
    }
}



// aux

// date picker

ko.bindingHandlers.datepicker = {
    init: function (element, valueAccessor, allBindingsAccessor) {
        //initialize datepicker with some optional options
        var options = allBindingsAccessor().datepickerOptions || {},
            $el = $(element);

        $el.datepicker(options);

        //handle the field changing
        ko.utils.registerEventHandler(element, "change", function () {
            var observable = valueAccessor();
            observable($el.datepicker("getDate"));
        });

        //handle disposal (if KO removes by the template binding)
        ko.utils.domNodeDisposal.addDisposeCallback(element, function () {
            $el.datepicker("destroy");
        });

    },
    update: function (element, valueAccessor) {
        var value = ko.utils.unwrapObservable(valueAccessor()),
            $el = $(element);

        //handle date data coming via json from Microsoft
        if (String(value).indexOf('/Date(') == 0) {
            value = new Date(parseInt(value.replace(/\/Date\((.*?)\)\//gi, "$1")));
        }

        var current = $el.datepicker("getDate");

        if (value - current !== 0) {
            $el.datepicker("setDate", value);
        }
    }
};



// date format

function dateToStringServerFormat(d) {
    // server format: 2017-10-20T00:00:00
    var datestring = d.getFullYear() + "-" + ("0" + (d.getMonth() + 1)).slice(-2) + "-" + ("0" + d.getDate()).slice(-2) + "T00:00:00";
    return datestring;
}






    