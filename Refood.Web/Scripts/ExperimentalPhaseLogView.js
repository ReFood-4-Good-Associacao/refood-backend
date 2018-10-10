
// ################################################################
//                      Code generated with T4
// ################################################################

var Web = Web || {};

Web.experimentalPhaseLogListViewModel = function (moduleId, resx) {
    var baseUrl = "api/ExperimentalPhaseLogApi/";

    var isLoading = ko.observable(false);
    var experimentalPhaseLogList = ko.observableArray([]);
    var editMode = ko.computed(function () {
        return experimentalPhaseLogList().length > 0 && experimentalPhaseLogList()[0].editUrl() != null && experimentalPhaseLogList()[0].editUrl().length > 0;
    });
    var searchText = ko.observable('');



    // filters

    var nucleoIdFilter = ko.observable(-1);
    var logDateFromFilter = ko.observable('');
    var logDateToFilter = ko.observable('');
    var taskFilter = ko.observable('');
    var activityDescriptionFilter = ko.observable('');
    var managerNameFilter = ko.observable('');
    var volunteerNameFilter = ko.observable('');
    var volunteerConfirmationFilter = ko.observable('');
    var documentIdFilter = ko.observable(-1);



    // helpers

    var nucleoHelper = Web.nucleoHelper(isLoading, '/', function(){});
    var documentHelper = Web.documentHelper(isLoading, '/', function(){});



    // init

    var init = function () {
        //getExperimentalPhaseLogList();
        //getExperimentalPhaseLogPage();
        getExperimentalPhaseLogListAdvanced();

        nucleoHelper.getNucleoList();
        documentHelper.getDocumentList();
    }



    // get list

    var getExperimentalPhaseLogList = function () {
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
                experimentalPhaseLogList.removeAll();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };



    // get list - advanced search

    var getExperimentalPhaseLogListAdvanced = function () {
        isLoading(true);

        var searchFilters = "?";
        searchFilters += (nucleoIdFilter() != -1 && nucleoIdFilter() != undefined ? "&" + "nucleoId=" + nucleoIdFilter() : "");
        searchFilters += (logDateFromFilter() != '' && logDateFromFilter() != null ? "&" + "logDateFrom=" + dateToStringServerFormat(logDateFromFilter()) : "");
        searchFilters += (logDateToFilter() != '' && logDateToFilter() != null ? "&" + "logDateTo=" + dateToStringServerFormat(logDateToFilter()) : "");
        searchFilters += (taskFilter() != '' ? "task=" + taskFilter() : "");
        searchFilters += (activityDescriptionFilter() != '' ? "activityDescription=" + activityDescriptionFilter() : "");
        searchFilters += (managerNameFilter() != '' ? "managerName=" + managerNameFilter() : "");
        searchFilters += (volunteerNameFilter() != '' ? "volunteerName=" + volunteerNameFilter() : "");
        searchFilters += (volunteerConfirmationFilter() != '' ? "volunteerConfirmation=" + volunteerConfirmationFilter() : "");
        searchFilters += (documentIdFilter() != -1 && documentIdFilter() != undefined ? "&" + "documentId=" + documentIdFilter() : "");

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
                experimentalPhaseLogList.removeAll();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };

    var advancedSearch = function () {
        getExperimentalPhaseLogListAdvanced();
    };

    var clearSearchFilters = function () {
        nucleoIdFilter(-1);
        logDateFromFilter('');
        logDateToFilter('');
        taskFilter('');
        activityDescriptionFilter('');
        managerNameFilter('');
        volunteerNameFilter('');
        volunteerConfirmationFilter('');
        documentIdFilter(-1);
    };



    // get list by page

    var getExperimentalPhaseLogPage = function () {
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
                experimentalPhaseLogList.removeAll();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };



    // delete

    var deleteExperimentalPhaseLog = function (experimentalPhaseLog) {
        isLoading(true);
        var restUrl = baseUrl + "Delete/" + experimentalPhaseLog.experimentalPhaseLogId();
        var jqXHR = $.ajax({
            url: restUrl,
            dataType: "json"
        }).done(function () {
            console.log("Deleted: " + experimentalPhaseLog.experimentalPhaseLogId());
            experimentalPhaseLogList.remove(experimentalPhaseLog);
        }).fail(function () {
            console.log("Error");
        }).always(function (data) {
            console.log("finished");
            isLoading(false);
        });
    }

    var deleteExperimentalPhaseLogById = function (experimentalPhaseLogId) {
        isLoading(true);
        var restUrl = baseUrl + "Delete/" + experimentalPhaseLogId;
        var jqXHR = $.ajax({
            method: "GET",
            url: restUrl,
            dataType: "json"
        }).done(function () {
            console.log("Deleted: " + experimentalPhaseLogId);
            //experimentalPhaseLogList.remove(experimentalPhaseLog);
            // refresh
            getExperimentalPhaseLogList();
        }).fail(function () {
            console.log("Error");
        }).always(function (data) {
            console.log("finished");
            isLoading(false);
        });
    }



    // load

    var load = function (data) {
        experimentalPhaseLogList.removeAll();
        var underlyingArray = experimentalPhaseLogList();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var experimentalPhaseLog = new Web.experimentalPhaseLogViewModel();
            experimentalPhaseLog.load(result);
            underlyingArray.push(experimentalPhaseLog);
        }
        experimentalPhaseLogList.valueHasMutated();
    };



    // data table

    var updateDatatable = function (data) {
        var dataArray = new Array();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var fieldsInArray = new Array();

            fieldsInArray.push(result.nucleoId);
            fieldsInArray.push(result.logDate);
            fieldsInArray.push(result.task);
            fieldsInArray.push(result.activityDescription);
            fieldsInArray.push(result.managerName);
            fieldsInArray.push(result.volunteerName);
            fieldsInArray.push(result.volunteerConfirmation);
            fieldsInArray.push(result.documentId);

            var viewLinkElement = '<a href=\"' + result.editUrl + '\" style=\"margin-right: 10px;\">View</a>';
            var editLinkElement = '<a href=\"' + result.editUrl + '\" style=\"margin-right: 10px;\">Edit</a>';
            var deleteLinkElement = '<a href=\"' + 'javascript:vm.deleteExperimentalPhaseLogById(' + result.experimentalPhaseLogId + ');' + '\" style=\"margin-right: 10px;\">Delete</a>';
            fieldsInArray.push(viewLinkElement + editLinkElement + deleteLinkElement);

            dataArray.push(fieldsInArray);
        }

        var datatable = $("#ExperimentalPhaseLogsTable-" + moduleId).DataTable();
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
        experimentalPhaseLogList: experimentalPhaseLogList,
        getExperimentalPhaseLogList: getExperimentalPhaseLogList,
        getExperimentalPhaseLogPage: getExperimentalPhaseLogPage,
        deleteExperimentalPhaseLog: deleteExperimentalPhaseLog,
        deleteExperimentalPhaseLogById: deleteExperimentalPhaseLogById,
        editMode: editMode,
        isLoading: isLoading,
        searchText: searchText,
        openCreateForm: openCreateForm,
        getExperimentalPhaseLogListAdvanced: getExperimentalPhaseLogListAdvanced,
        advancedSearch: advancedSearch,
        clearSearchFilters: clearSearchFilters,

        nucleoList: nucleoHelper.nucleoList,
        documentList: documentHelper.documentList,

        nucleoIdFilter: nucleoIdFilter,
        logDateFromFilter: logDateFromFilter,
        logDateToFilter: logDateToFilter,
        taskFilter: taskFilter,
        activityDescriptionFilter: activityDescriptionFilter,
        managerNameFilter: managerNameFilter,
        volunteerNameFilter: volunteerNameFilter,
        volunteerConfirmationFilter: volunteerConfirmationFilter,
        documentIdFilter: documentIdFilter,
    }
};



// view model

Web.experimentalPhaseLogViewModel = function () {
    var experimentalPhaseLogId = ko.observable(-1);
    var nucleoId = ko.observable(-1);
    var logDate = ko.observable('');
    var task = ko.observable('');
    var activityDescription = ko.observable('');
    var managerName = ko.observable('');
    var volunteerName = ko.observable('');
    var volunteerConfirmation = ko.observable('');
    var documentId = ko.observable(-1);
    var isDeleted = ko.observable('');

    var editUrl = ko.observable('');

    var visibleOnSearch = ko.observable(true);
 
    // load

    var load = function (data) {
        experimentalPhaseLogId(data.experimentalPhaseLogId);
        nucleoId(data.nucleoId);
        logDate(data.logDate);
        task(data.task);
        activityDescription(data.activityDescription);
        managerName(data.managerName);
        volunteerName(data.volunteerName);
        volunteerConfirmation(data.volunteerConfirmation);
        documentId(data.documentId);
        isDeleted(data.isDeleted);
        editUrl(data.editUrl);
    };



    return {
        experimentalPhaseLogId: experimentalPhaseLogId,
        nucleoId: nucleoId,
        logDate: logDate,
        task: task,
        activityDescription: activityDescription,
        managerName: managerName,
        volunteerName: volunteerName,
        volunteerConfirmation: volunteerConfirmation,
        documentId: documentId,
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






    