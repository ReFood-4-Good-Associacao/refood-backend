
// ################################################################
//                      Code generated with T4
// ################################################################

var Web = Web || {};

Web.weekDayListViewModel = function (moduleId, resx) {
    var baseUrl = "api/WeekDayApi/";

    var isLoading = ko.observable(false);
    var weekDayList = ko.observableArray([]);
    var editMode = ko.computed(function () {
        return weekDayList().length > 0 && weekDayList()[0].editUrl() != null && weekDayList()[0].editUrl().length > 0;
    });
    var searchText = ko.observable('');



    // filters

    var nucleoIdFilter = ko.observable(-1);
    var nameFilter = ko.observable('');
    var descriptionFilter = ko.observable('');
    var responsiblePersonIdFilter = ko.observable(-1);
    var activeFilter = ko.observable('');



    // helpers

    var nucleoHelper = Web.nucleoHelper(isLoading, '/', function(){});
    var responsiblePersonHelper = Web.responsiblePersonHelper(isLoading, '/', function(){});



    // init

    var init = function () {
        //getWeekDayList();
        //getWeekDayPage();
        getWeekDayListAdvanced();

        nucleoHelper.getNucleoList();
        responsiblePersonHelper.getResponsiblePersonList();
    }



    // get list

    var getWeekDayList = function () {
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
                weekDayList.removeAll();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };



    // get list - advanced search

    var getWeekDayListAdvanced = function () {
        isLoading(true);

        var searchFilters = "?";
        searchFilters += (nucleoIdFilter() != -1 && nucleoIdFilter() != undefined ? "&" + "nucleoId=" + nucleoIdFilter() : "");
        searchFilters += (nameFilter() != '' ? "name=" + nameFilter() : "");
        searchFilters += (descriptionFilter() != '' ? "description=" + descriptionFilter() : "");
        searchFilters += (responsiblePersonIdFilter() != -1 && responsiblePersonIdFilter() != undefined ? "&" + "responsiblePersonId=" + responsiblePersonIdFilter() : "");
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
                weekDayList.removeAll();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };

    var advancedSearch = function () {
        getWeekDayListAdvanced();
    };

    var clearSearchFilters = function () {
        nucleoIdFilter(-1);
        nameFilter('');
        descriptionFilter('');
        responsiblePersonIdFilter(-1);
        activeFilter('');
    };



    // get list by page

    var getWeekDayPage = function () {
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
                weekDayList.removeAll();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };



    // delete

    var deleteWeekDay = function (weekDay) {
        isLoading(true);
        var restUrl = baseUrl + "Delete/" + weekDay.weekDayId();
        var jqXHR = $.ajax({
            url: restUrl,
            dataType: "json"
        }).done(function () {
            console.log("Deleted: " + weekDay.weekDayId());
            weekDayList.remove(weekDay);
        }).fail(function () {
            console.log("Error");
        }).always(function (data) {
            console.log("finished");
            isLoading(false);
        });
    }

    var deleteWeekDayById = function (weekDayId) {
        isLoading(true);
        var restUrl = baseUrl + "Delete/" + weekDayId;
        var jqXHR = $.ajax({
            method: "GET",
            url: restUrl,
            dataType: "json"
        }).done(function () {
            console.log("Deleted: " + weekDayId);
            //weekDayList.remove(weekDay);
            // refresh
            getWeekDayList();
        }).fail(function () {
            console.log("Error");
        }).always(function (data) {
            console.log("finished");
            isLoading(false);
        });
    }



    // load

    var load = function (data) {
        weekDayList.removeAll();
        var underlyingArray = weekDayList();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var weekDay = new Web.weekDayViewModel();
            weekDay.load(result);
            underlyingArray.push(weekDay);
        }
        weekDayList.valueHasMutated();
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
            fieldsInArray.push(result.responsiblePersonId);
            fieldsInArray.push(result.active);

            var viewLinkElement = '<a href=\"' + result.editUrl + '\" style=\"margin-right: 10px;\">View</a>';
            var editLinkElement = '<a href=\"' + result.editUrl + '\" style=\"margin-right: 10px;\">Edit</a>';
            var deleteLinkElement = '<a href=\"' + 'javascript:vm.deleteWeekDayById(' + result.weekDayId + ');' + '\" style=\"margin-right: 10px;\">Delete</a>';
            fieldsInArray.push(viewLinkElement + editLinkElement + deleteLinkElement);

            dataArray.push(fieldsInArray);
        }

        var datatable = $("#WeekDaysTable-" + moduleId).DataTable();
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
        weekDayList: weekDayList,
        getWeekDayList: getWeekDayList,
        getWeekDayPage: getWeekDayPage,
        deleteWeekDay: deleteWeekDay,
        deleteWeekDayById: deleteWeekDayById,
        editMode: editMode,
        isLoading: isLoading,
        searchText: searchText,
        openCreateForm: openCreateForm,
        getWeekDayListAdvanced: getWeekDayListAdvanced,
        advancedSearch: advancedSearch,
        clearSearchFilters: clearSearchFilters,

        nucleoList: nucleoHelper.nucleoList,
        responsiblePersonList: responsiblePersonHelper.responsiblePersonList,

        nucleoIdFilter: nucleoIdFilter,
        nameFilter: nameFilter,
        descriptionFilter: descriptionFilter,
        responsiblePersonIdFilter: responsiblePersonIdFilter,
        activeFilter: activeFilter,
    }
};



// view model

Web.weekDayViewModel = function () {
    var weekDayId = ko.observable(-1);
    var nucleoId = ko.observable(-1);
    var name = ko.observable('');
    var description = ko.observable('');
    var responsiblePersonId = ko.observable(-1);
    var active = ko.observable('');
    var isDeleted = ko.observable('');

    var editUrl = ko.observable('');

    var visibleOnSearch = ko.observable(true);
 
    // load

    var load = function (data) {
        weekDayId(data.weekDayId);
        nucleoId(data.nucleoId);
        name(data.name);
        description(data.description);
        responsiblePersonId(data.responsiblePersonId);
        active(data.active);
        isDeleted(data.isDeleted);
        editUrl(data.editUrl);
    };



    return {
        weekDayId: weekDayId,
        nucleoId: nucleoId,
        name: name,
        description: description,
        responsiblePersonId: responsiblePersonId,
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






    