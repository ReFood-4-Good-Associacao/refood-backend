
// ################################################################
//                      Code generated with T4
// ################################################################

var Web = Web || {};

Web.projectListViewModel = function (moduleId, resx) {
    var baseUrl = "api/ProjectApi/";

    var isLoading = ko.observable(false);
    var projectList = ko.observableArray([]);
    var editMode = ko.computed(function () {
        return projectList().length > 0 && projectList()[0].editUrl() != null && projectList()[0].editUrl().length > 0;
    });
    var searchText = ko.observable('');



    // filters

    var nucleoIdFilter = ko.observable(-1);
    var nameFilter = ko.observable('');
    var descriptionFilter = ko.observable('');
    var deadlineCallFilter = ko.observable('');
    var budgetFilter = ko.observable('');
    var fundingFilter = ko.observable('');
    var startDateFromFilter = ko.observable('');
    var startDateToFilter = ko.observable('');
    var endDateFromFilter = ko.observable('');
    var endDateToFilter = ko.observable('');
    var areaOfInterestFilter = ko.observable('');
    var activeFilter = ko.observable('');



    // helpers

    var nucleoHelper = Web.nucleoHelper(isLoading, '/', function(){});



    // init

    var init = function () {
        //getProjectList();
        //getProjectPage();
        getProjectListAdvanced();

        nucleoHelper.getNucleoList();
    }



    // get list

    var getProjectList = function () {
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
                projectList.removeAll();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };



    // get list - advanced search

    var getProjectListAdvanced = function () {
        isLoading(true);

        var searchFilters = "?";
        searchFilters += (nucleoIdFilter() != -1 && nucleoIdFilter() != undefined ? "&" + "nucleoId=" + nucleoIdFilter() : "");
        searchFilters += (nameFilter() != '' ? "name=" + nameFilter() : "");
        searchFilters += (descriptionFilter() != '' ? "description=" + descriptionFilter() : "");
        searchFilters += (deadlineCallFilter() != '' ? "deadlineCall=" + deadlineCallFilter() : "");
        searchFilters += (budgetFilter() != '' ? "budget=" + budgetFilter() : "");
        searchFilters += (fundingFilter() != '' ? "funding=" + fundingFilter() : "");
        searchFilters += (startDateFromFilter() != '' && startDateFromFilter() != null ? "&" + "startDateFrom=" + dateToStringServerFormat(startDateFromFilter()) : "");
        searchFilters += (startDateToFilter() != '' && startDateToFilter() != null ? "&" + "startDateTo=" + dateToStringServerFormat(startDateToFilter()) : "");
        searchFilters += (endDateFromFilter() != '' && endDateFromFilter() != null ? "&" + "endDateFrom=" + dateToStringServerFormat(endDateFromFilter()) : "");
        searchFilters += (endDateToFilter() != '' && endDateToFilter() != null ? "&" + "endDateTo=" + dateToStringServerFormat(endDateToFilter()) : "");
        searchFilters += (areaOfInterestFilter() != '' ? "areaOfInterest=" + areaOfInterestFilter() : "");
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
                projectList.removeAll();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };

    var advancedSearch = function () {
        getProjectListAdvanced();
    };

    var clearSearchFilters = function () {
        nucleoIdFilter(-1);
        nameFilter('');
        descriptionFilter('');
        deadlineCallFilter('');
        budgetFilter('');
        fundingFilter('');
        startDateFromFilter('');
        startDateToFilter('');
        endDateFromFilter('');
        endDateToFilter('');
        areaOfInterestFilter('');
        activeFilter('');
    };



    // get list by page

    var getProjectPage = function () {
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
                projectList.removeAll();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };



    // delete

    var deleteProject = function (project) {
        isLoading(true);
        var restUrl = baseUrl + "Delete/" + project.projectId();
        var jqXHR = $.ajax({
            url: restUrl,
            dataType: "json"
        }).done(function () {
            console.log("Deleted: " + project.projectId());
            projectList.remove(project);
        }).fail(function () {
            console.log("Error");
        }).always(function (data) {
            console.log("finished");
            isLoading(false);
        });
    }

    var deleteProjectById = function (projectId) {
        isLoading(true);
        var restUrl = baseUrl + "Delete/" + projectId;
        var jqXHR = $.ajax({
            method: "GET",
            url: restUrl,
            dataType: "json"
        }).done(function () {
            console.log("Deleted: " + projectId);
            //projectList.remove(project);
            // refresh
            getProjectList();
        }).fail(function () {
            console.log("Error");
        }).always(function (data) {
            console.log("finished");
            isLoading(false);
        });
    }



    // load

    var load = function (data) {
        projectList.removeAll();
        var underlyingArray = projectList();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var project = new Web.projectViewModel();
            project.load(result);
            underlyingArray.push(project);
        }
        projectList.valueHasMutated();
    };



    // data table

    var updateDatatable = function (data) {
        var dataArray = new Array();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var fieldsInArray = new Array();

            fieldsInArray.push(result.nucleoId);
            fieldsInArray.push(result.name);
            fieldsInArray.push(result.description);
            fieldsInArray.push(result.deadlineCall);
            fieldsInArray.push(result.budget);
            fieldsInArray.push(result.funding);
            fieldsInArray.push(result.startDate);
            fieldsInArray.push(result.endDate);
            fieldsInArray.push(result.areaOfInterest);
            fieldsInArray.push(result.active);

            var viewLinkElement = '<a href=\"' + result.editUrl + '\" style=\"margin-right: 10px;\">View</a>';
            var editLinkElement = '<a href=\"' + result.editUrl + '\" style=\"margin-right: 10px;\">Edit</a>';
            var deleteLinkElement = '<a href=\"' + 'javascript:vm.deleteProjectById(' + result.projectId + ');' + '\" style=\"margin-right: 10px;\">Delete</a>';
            fieldsInArray.push(viewLinkElement + editLinkElement + deleteLinkElement);

            dataArray.push(fieldsInArray);
        }

        var datatable = $("#ProjectsTable-" + moduleId).DataTable();
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
        projectList: projectList,
        getProjectList: getProjectList,
        getProjectPage: getProjectPage,
        deleteProject: deleteProject,
        deleteProjectById: deleteProjectById,
        editMode: editMode,
        isLoading: isLoading,
        searchText: searchText,
        openCreateForm: openCreateForm,
        getProjectListAdvanced: getProjectListAdvanced,
        advancedSearch: advancedSearch,
        clearSearchFilters: clearSearchFilters,

        nucleoList: nucleoHelper.nucleoList,

        nucleoIdFilter: nucleoIdFilter,
        nameFilter: nameFilter,
        descriptionFilter: descriptionFilter,
        deadlineCallFilter: deadlineCallFilter,
        budgetFilter: budgetFilter,
        fundingFilter: fundingFilter,
        startDateFromFilter: startDateFromFilter,
        startDateToFilter: startDateToFilter,
        endDateFromFilter: endDateFromFilter,
        endDateToFilter: endDateToFilter,
        areaOfInterestFilter: areaOfInterestFilter,
        activeFilter: activeFilter,
    }
};



// view model

Web.projectViewModel = function () {
    var projectId = ko.observable(-1);
    var nucleoId = ko.observable(-1);
    var name = ko.observable('');
    var description = ko.observable('');
    var deadlineCall = ko.observable('');
    var budget = ko.observable('');
    var funding = ko.observable('');
    var startDate = ko.observable('');
    var endDate = ko.observable('');
    var areaOfInterest = ko.observable('');
    var active = ko.observable('');
    var isDeleted = ko.observable('');

    var editUrl = ko.observable('');

    var visibleOnSearch = ko.observable(true);
 
    // load

    var load = function (data) {
        projectId(data.projectId);
        nucleoId(data.nucleoId);
        name(data.name);
        description(data.description);
        deadlineCall(data.deadlineCall);
        budget(data.budget);
        funding(data.funding);
        startDate(data.startDate);
        endDate(data.endDate);
        areaOfInterest(data.areaOfInterest);
        active(data.active);
        isDeleted(data.isDeleted);
        editUrl(data.editUrl);
    };



    return {
        projectId: projectId,
        nucleoId: nucleoId,
        name: name,
        description: description,
        deadlineCall: deadlineCall,
        budget: budget,
        funding: funding,
        startDate: startDate,
        endDate: endDate,
        areaOfInterest: areaOfInterest,
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






    