
// ################################################################
//                      Code generated with T4
// ################################################################

var Web = Web || {};

Web.contributionMonetaryReviewerListViewModel = function (moduleId, resx) {
    var baseUrl = "api/ContributionMonetaryReviewerApi/";

    var isLoading = ko.observable(false);
    var contributionMonetaryReviewerList = ko.observableArray([]);
    var editMode = ko.computed(function () {
        return contributionMonetaryReviewerList().length > 0 && contributionMonetaryReviewerList()[0].editUrl() != null && contributionMonetaryReviewerList()[0].editUrl().length > 0;
    });
    var searchText = ko.observable('');



    // filters

    var volunteerIdFilter = ko.observable(-1);



    // helpers

    var volunteerHelper = Web.volunteerHelper(isLoading, '/', function(){});



    // init

    var init = function () {
        //getContributionMonetaryReviewerList();
        //getContributionMonetaryReviewerPage();
        getContributionMonetaryReviewerListAdvanced();

        volunteerHelper.getVolunteerList();
    }



    // get list

    var getContributionMonetaryReviewerList = function () {
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
                contributionMonetaryReviewerList.removeAll();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };



    // get list - advanced search

    var getContributionMonetaryReviewerListAdvanced = function () {
        isLoading(true);

        var searchFilters = "?";
        searchFilters += (volunteerIdFilter() != -1 && volunteerIdFilter() != undefined ? "&" + "volunteerId=" + volunteerIdFilter() : "");

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
                contributionMonetaryReviewerList.removeAll();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };

    var advancedSearch = function () {
        getContributionMonetaryReviewerListAdvanced();
    };

    var clearSearchFilters = function () {
        volunteerIdFilter(-1);
    };



    // get list by page

    var getContributionMonetaryReviewerPage = function () {
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
                contributionMonetaryReviewerList.removeAll();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };



    // delete

    var deleteContributionMonetaryReviewer = function (contributionMonetaryReviewer) {
        isLoading(true);
        var restUrl = baseUrl + "Delete/" + contributionMonetaryReviewer.contributionMonetaryReviewerId();
        var jqXHR = $.ajax({
            url: restUrl,
            dataType: "json"
        }).done(function () {
            console.log("Deleted: " + contributionMonetaryReviewer.contributionMonetaryReviewerId());
            contributionMonetaryReviewerList.remove(contributionMonetaryReviewer);
        }).fail(function () {
            console.log("Error");
        }).always(function (data) {
            console.log("finished");
            isLoading(false);
        });
    }

    var deleteContributionMonetaryReviewerById = function (contributionMonetaryReviewerId) {
        isLoading(true);
        var restUrl = baseUrl + "Delete/" + contributionMonetaryReviewerId;
        var jqXHR = $.ajax({
            method: "GET",
            url: restUrl,
            dataType: "json"
        }).done(function () {
            console.log("Deleted: " + contributionMonetaryReviewerId);
            //contributionMonetaryReviewerList.remove(contributionMonetaryReviewer);
            // refresh
            getContributionMonetaryReviewerList();
        }).fail(function () {
            console.log("Error");
        }).always(function (data) {
            console.log("finished");
            isLoading(false);
        });
    }



    // load

    var load = function (data) {
        contributionMonetaryReviewerList.removeAll();
        var underlyingArray = contributionMonetaryReviewerList();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var contributionMonetaryReviewer = new Web.contributionMonetaryReviewerViewModel();
            contributionMonetaryReviewer.load(result);
            underlyingArray.push(contributionMonetaryReviewer);
        }
        contributionMonetaryReviewerList.valueHasMutated();
    };



    // data table

    var updateDatatable = function (data) {
        var dataArray = new Array();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var fieldsInArray = new Array();

            fieldsInArray.push(result.volunteerId);

            var viewLinkElement = '<a href=\"' + result.editUrl + '\" style=\"margin-right: 10px;\">View</a>';
            var editLinkElement = '<a href=\"' + result.editUrl + '\" style=\"margin-right: 10px;\">Edit</a>';
            var deleteLinkElement = '<a href=\"' + 'javascript:vm.deleteContributionMonetaryReviewerById(' + result.contributionMonetaryReviewerId + ');' + '\" style=\"margin-right: 10px;\">Delete</a>';
            fieldsInArray.push(viewLinkElement + editLinkElement + deleteLinkElement);

            dataArray.push(fieldsInArray);
        }

        var datatable = $("#ContributionMonetaryReviewersTable-" + moduleId).DataTable();
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
        contributionMonetaryReviewerList: contributionMonetaryReviewerList,
        getContributionMonetaryReviewerList: getContributionMonetaryReviewerList,
        getContributionMonetaryReviewerPage: getContributionMonetaryReviewerPage,
        deleteContributionMonetaryReviewer: deleteContributionMonetaryReviewer,
        deleteContributionMonetaryReviewerById: deleteContributionMonetaryReviewerById,
        editMode: editMode,
        isLoading: isLoading,
        searchText: searchText,
        openCreateForm: openCreateForm,
        getContributionMonetaryReviewerListAdvanced: getContributionMonetaryReviewerListAdvanced,
        advancedSearch: advancedSearch,
        clearSearchFilters: clearSearchFilters,

        volunteerList: volunteerHelper.volunteerList,

        volunteerIdFilter: volunteerIdFilter,
    }
};



// view model

Web.contributionMonetaryReviewerViewModel = function () {
    var contributionMonetaryReviewerId = ko.observable(-1);
    var volunteerId = ko.observable(-1);
    var isDeleted = ko.observable('');

    var editUrl = ko.observable('');

    var visibleOnSearch = ko.observable(true);
 
    // load

    var load = function (data) {
        contributionMonetaryReviewerId(data.contributionMonetaryReviewerId);
        volunteerId(data.volunteerId);
        isDeleted(data.isDeleted);
        editUrl(data.editUrl);
    };



    return {
        contributionMonetaryReviewerId: contributionMonetaryReviewerId,
        volunteerId: volunteerId,
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






    