
// ################################################################
//                      Code generated with T4
// ################################################################

var Web = Web || {};

Web.deliveryReportListViewModel = function (moduleId, resx) {
    var baseUrl = "api/DeliveryReportApi/";

    var isLoading = ko.observable(false);
    var deliveryReportList = ko.observableArray([]);
    var editMode = ko.computed(function () {
        return deliveryReportList().length > 0 && deliveryReportList()[0].editUrl() != null && deliveryReportList()[0].editUrl().length > 0;
    });
    var searchText = ko.observable('');



    // filters

    var nameFilter = ko.observable('');
    var descriptionFilter = ko.observable('');
    var reportDateFromFilter = ko.observable('');
    var reportDateToFilter = ko.observable('');
    var weekDayFilter = ko.observable('');
    var submittedFilter = ko.observable('');



    // helpers




    // init

    var init = function () {
        //getDeliveryReportList();
        //getDeliveryReportPage();
        getDeliveryReportListAdvanced();

    }



    // get list

    var getDeliveryReportList = function () {
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
                deliveryReportList.removeAll();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };



    // get list - advanced search

    var getDeliveryReportListAdvanced = function () {
        isLoading(true);

        var searchFilters = "?";
        searchFilters += (nameFilter() != '' ? "name=" + nameFilter() : "");
        searchFilters += (descriptionFilter() != '' ? "description=" + descriptionFilter() : "");
        searchFilters += (reportDateFromFilter() != '' && reportDateFromFilter() != null ? "&" + "reportDateFrom=" + dateToStringServerFormat(reportDateFromFilter()) : "");
        searchFilters += (reportDateToFilter() != '' && reportDateToFilter() != null ? "&" + "reportDateTo=" + dateToStringServerFormat(reportDateToFilter()) : "");
        searchFilters += (weekDayFilter() != '' ? "weekDay=" + weekDayFilter() : "");
        searchFilters += (submittedFilter() != '' ? "submitted=" + submittedFilter() : "");

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
                deliveryReportList.removeAll();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };

    var advancedSearch = function () {
        getDeliveryReportListAdvanced();
    };

    var clearSearchFilters = function () {
        nameFilter('');
        descriptionFilter('');
        reportDateFromFilter('');
        reportDateToFilter('');
        weekDayFilter('');
        submittedFilter('');
    };



    // get list by page

    var getDeliveryReportPage = function () {
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
                deliveryReportList.removeAll();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };



    // delete

    var deleteDeliveryReport = function (deliveryReport) {
        isLoading(true);
        var restUrl = baseUrl + "Delete/" + deliveryReport.deliveryReportId();
        var jqXHR = $.ajax({
            url: restUrl,
            dataType: "json"
        }).done(function () {
            console.log("Deleted: " + deliveryReport.deliveryReportId());
            deliveryReportList.remove(deliveryReport);
        }).fail(function () {
            console.log("Error");
        }).always(function (data) {
            console.log("finished");
            isLoading(false);
        });
    }

    var deleteDeliveryReportById = function (deliveryReportId) {
        isLoading(true);
        var restUrl = baseUrl + "Delete/" + deliveryReportId;
        var jqXHR = $.ajax({
            method: "GET",
            url: restUrl,
            dataType: "json"
        }).done(function () {
            console.log("Deleted: " + deliveryReportId);
            //deliveryReportList.remove(deliveryReport);
            // refresh
            getDeliveryReportList();
        }).fail(function () {
            console.log("Error");
        }).always(function (data) {
            console.log("finished");
            isLoading(false);
        });
    }



    // load

    var load = function (data) {
        deliveryReportList.removeAll();
        var underlyingArray = deliveryReportList();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var deliveryReport = new Web.deliveryReportViewModel();
            deliveryReport.load(result);
            underlyingArray.push(deliveryReport);
        }
        deliveryReportList.valueHasMutated();
    };



    // data table

    var updateDatatable = function (data) {
        var dataArray = new Array();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var fieldsInArray = new Array();

            fieldsInArray.push(result.name);
            fieldsInArray.push(result.description);
            fieldsInArray.push(result.reportDate);
            fieldsInArray.push(result.weekDay);
            fieldsInArray.push(result.submitted);

            var viewLinkElement = '<a href=\"' + result.editUrl + '\" style=\"margin-right: 10px;\">View</a>';
            var editLinkElement = '<a href=\"' + result.editUrl + '\" style=\"margin-right: 10px;\">Edit</a>';
            var deleteLinkElement = '<a href=\"' + 'javascript:vm.deleteDeliveryReportById(' + result.deliveryReportId + ');' + '\" style=\"margin-right: 10px;\">Delete</a>';
            fieldsInArray.push(viewLinkElement + editLinkElement + deleteLinkElement);

            dataArray.push(fieldsInArray);
        }

        var datatable = $("#DeliveryReportsTable-" + moduleId).DataTable();
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
        deliveryReportList: deliveryReportList,
        getDeliveryReportList: getDeliveryReportList,
        getDeliveryReportPage: getDeliveryReportPage,
        deleteDeliveryReport: deleteDeliveryReport,
        deleteDeliveryReportById: deleteDeliveryReportById,
        editMode: editMode,
        isLoading: isLoading,
        searchText: searchText,
        openCreateForm: openCreateForm,
        getDeliveryReportListAdvanced: getDeliveryReportListAdvanced,
        advancedSearch: advancedSearch,
        clearSearchFilters: clearSearchFilters,


        nameFilter: nameFilter,
        descriptionFilter: descriptionFilter,
        reportDateFromFilter: reportDateFromFilter,
        reportDateToFilter: reportDateToFilter,
        weekDayFilter: weekDayFilter,
        submittedFilter: submittedFilter,
    }
};



// view model

Web.deliveryReportViewModel = function () {
    var deliveryReportId = ko.observable(-1);
    var name = ko.observable('');
    var description = ko.observable('');
    var reportDate = ko.observable('');
    var weekDay = ko.observable('');
    var submitted = ko.observable('');
    var isDeleted = ko.observable('');

    var editUrl = ko.observable('');

    var visibleOnSearch = ko.observable(true);
 
    // load

    var load = function (data) {
        deliveryReportId(data.deliveryReportId);
        name(data.name);
        description(data.description);
        reportDate(data.reportDate);
        weekDay(data.weekDay);
        submitted(data.submitted);
        isDeleted(data.isDeleted);
        editUrl(data.editUrl);
    };



    return {
        deliveryReportId: deliveryReportId,
        name: name,
        description: description,
        reportDate: reportDate,
        weekDay: weekDay,
        submitted: submitted,
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






    