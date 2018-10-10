
// ################################################################
//                      Code generated with T4
// ################################################################

var Web = Web || {};

Web.projectPartnerListViewModel = function (moduleId, resx) {
    var baseUrl = "api/ProjectPartnerApi/";

    var isLoading = ko.observable(false);
    var projectPartnerList = ko.observableArray([]);
    var editMode = ko.computed(function () {
        return projectPartnerList().length > 0 && projectPartnerList()[0].editUrl() != null && projectPartnerList()[0].editUrl().length > 0;
    });
    var searchText = ko.observable('');



    // filters

    var projectIdFilter = ko.observable(-1);
    var partnerIdFilter = ko.observable(-1);
    var grantValueFilter = ko.observable('');



    // helpers

    var projectHelper = Web.projectHelper(isLoading, '/', function(){});
    var partnerHelper = Web.partnerHelper(isLoading, '/', function(){});



    // init

    var init = function () {
        //getProjectPartnerList();
        //getProjectPartnerPage();
        getProjectPartnerListAdvanced();

        projectHelper.getProjectList();
        partnerHelper.getPartnerList();
    }



    // get list

    var getProjectPartnerList = function () {
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
                projectPartnerList.removeAll();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };



    // get list - advanced search

    var getProjectPartnerListAdvanced = function () {
        isLoading(true);

        var searchFilters = "?";
        searchFilters += (projectIdFilter() != -1 && projectIdFilter() != undefined ? "&" + "projectId=" + projectIdFilter() : "");
        searchFilters += (partnerIdFilter() != -1 && partnerIdFilter() != undefined ? "&" + "partnerId=" + partnerIdFilter() : "");
        searchFilters += (grantValueFilter() != '' ? "grantValue=" + grantValueFilter() : "");

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
                projectPartnerList.removeAll();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };

    var advancedSearch = function () {
        getProjectPartnerListAdvanced();
    };

    var clearSearchFilters = function () {
        projectIdFilter(-1);
        partnerIdFilter(-1);
        grantValueFilter('');
    };



    // get list by page

    var getProjectPartnerPage = function () {
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
                projectPartnerList.removeAll();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };



    // delete

    var deleteProjectPartner = function (projectPartner) {
        isLoading(true);
        var restUrl = baseUrl + "Delete/" + projectPartner.projectPartnerId();
        var jqXHR = $.ajax({
            url: restUrl,
            dataType: "json"
        }).done(function () {
            console.log("Deleted: " + projectPartner.projectPartnerId());
            projectPartnerList.remove(projectPartner);
        }).fail(function () {
            console.log("Error");
        }).always(function (data) {
            console.log("finished");
            isLoading(false);
        });
    }

    var deleteProjectPartnerById = function (projectPartnerId) {
        isLoading(true);
        var restUrl = baseUrl + "Delete/" + projectPartnerId;
        var jqXHR = $.ajax({
            method: "GET",
            url: restUrl,
            dataType: "json"
        }).done(function () {
            console.log("Deleted: " + projectPartnerId);
            //projectPartnerList.remove(projectPartner);
            // refresh
            getProjectPartnerList();
        }).fail(function () {
            console.log("Error");
        }).always(function (data) {
            console.log("finished");
            isLoading(false);
        });
    }



    // load

    var load = function (data) {
        projectPartnerList.removeAll();
        var underlyingArray = projectPartnerList();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var projectPartner = new Web.projectPartnerViewModel();
            projectPartner.load(result);
            underlyingArray.push(projectPartner);
        }
        projectPartnerList.valueHasMutated();
    };



    // data table

    var updateDatatable = function (data) {
        var dataArray = new Array();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var fieldsInArray = new Array();

            fieldsInArray.push(result.projectId);
            fieldsInArray.push(result.partnerId);
            fieldsInArray.push(result.grantValue);

            var viewLinkElement = '<a href=\"' + result.editUrl + '\" style=\"margin-right: 10px;\">View</a>';
            var editLinkElement = '<a href=\"' + result.editUrl + '\" style=\"margin-right: 10px;\">Edit</a>';
            var deleteLinkElement = '<a href=\"' + 'javascript:vm.deleteProjectPartnerById(' + result.projectPartnerId + ');' + '\" style=\"margin-right: 10px;\">Delete</a>';
            fieldsInArray.push(viewLinkElement + editLinkElement + deleteLinkElement);

            dataArray.push(fieldsInArray);
        }

        var datatable = $("#ProjectPartnersTable-" + moduleId).DataTable();
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
        projectPartnerList: projectPartnerList,
        getProjectPartnerList: getProjectPartnerList,
        getProjectPartnerPage: getProjectPartnerPage,
        deleteProjectPartner: deleteProjectPartner,
        deleteProjectPartnerById: deleteProjectPartnerById,
        editMode: editMode,
        isLoading: isLoading,
        searchText: searchText,
        openCreateForm: openCreateForm,
        getProjectPartnerListAdvanced: getProjectPartnerListAdvanced,
        advancedSearch: advancedSearch,
        clearSearchFilters: clearSearchFilters,

        projectList: projectHelper.projectList,
        partnerList: partnerHelper.partnerList,

        projectIdFilter: projectIdFilter,
        partnerIdFilter: partnerIdFilter,
        grantValueFilter: grantValueFilter,
    }
};



// view model

Web.projectPartnerViewModel = function () {
    var projectPartnerId = ko.observable(-1);
    var projectId = ko.observable(-1);
    var partnerId = ko.observable(-1);
    var grantValue = ko.observable('');
    var isDeleted = ko.observable('');

    var editUrl = ko.observable('');

    var visibleOnSearch = ko.observable(true);
 
    // load

    var load = function (data) {
        projectPartnerId(data.projectPartnerId);
        projectId(data.projectId);
        partnerId(data.partnerId);
        grantValue(data.grantValue);
        isDeleted(data.isDeleted);
        editUrl(data.editUrl);
    };



    return {
        projectPartnerId: projectPartnerId,
        projectId: projectId,
        partnerId: partnerId,
        grantValue: grantValue,
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






    