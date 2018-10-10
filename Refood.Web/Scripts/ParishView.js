
// ################################################################
//                      Code generated with T4
// ################################################################

var Web = Web || {};

Web.parishListViewModel = function (moduleId, resx) {
    var baseUrl = "api/ParishApi/";

    var isLoading = ko.observable(false);
    var parishList = ko.observableArray([]);
    var editMode = ko.computed(function () {
        return parishList().length > 0 && parishList()[0].editUrl() != null && parishList()[0].editUrl().length > 0;
    });
    var searchText = ko.observable('');



    // filters

    var countyIdFilter = ko.observable(-1);
    var districtIdFilter = ko.observable(-1);
    var countryIdFilter = ko.observable(-1);
    var nameFilter = ko.observable('');
    var codeFilter = ko.observable('');
    var latitudeFilter = ko.observable('');
    var longitudeFilter = ko.observable('');
    var activeFilter = ko.observable('');



    // helpers

    var countyHelper = Web.countyHelper(isLoading, '/', function(){});
    var districtHelper = Web.districtHelper(isLoading, '/', function(){});
    var countryHelper = Web.countryHelper(isLoading, '/', function(){});



    // init

    var init = function () {
        //getParishList();
        //getParishPage();
        getParishListAdvanced();

        countyHelper.getCountyList();
        districtHelper.getDistrictList();
        countryHelper.getCountryList();
    }



    // get list

    var getParishList = function () {
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
                parishList.removeAll();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };



    // get list - advanced search

    var getParishListAdvanced = function () {
        isLoading(true);

        var searchFilters = "?";
        searchFilters += (countyIdFilter() != -1 && countyIdFilter() != undefined ? "&" + "countyId=" + countyIdFilter() : "");
        searchFilters += (districtIdFilter() != -1 && districtIdFilter() != undefined ? "&" + "districtId=" + districtIdFilter() : "");
        searchFilters += (countryIdFilter() != -1 && countryIdFilter() != undefined ? "&" + "countryId=" + countryIdFilter() : "");
        searchFilters += (nameFilter() != '' ? "name=" + nameFilter() : "");
        searchFilters += (codeFilter() != '' ? "code=" + codeFilter() : "");
        searchFilters += (latitudeFilter() != '' ? "latitude=" + latitudeFilter() : "");
        searchFilters += (longitudeFilter() != '' ? "longitude=" + longitudeFilter() : "");
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
                parishList.removeAll();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };

    var advancedSearch = function () {
        getParishListAdvanced();
    };

    var clearSearchFilters = function () {
        countyIdFilter(-1);
        districtIdFilter(-1);
        countryIdFilter(-1);
        nameFilter('');
        codeFilter('');
        latitudeFilter('');
        longitudeFilter('');
        activeFilter('');
    };



    // get list by page

    var getParishPage = function () {
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
                parishList.removeAll();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };



    // delete

    var deleteParish = function (parish) {
        isLoading(true);
        var restUrl = baseUrl + "Delete/" + parish.parishId();
        var jqXHR = $.ajax({
            url: restUrl,
            dataType: "json"
        }).done(function () {
            console.log("Deleted: " + parish.parishId());
            parishList.remove(parish);
        }).fail(function () {
            console.log("Error");
        }).always(function (data) {
            console.log("finished");
            isLoading(false);
        });
    }

    var deleteParishById = function (parishId) {
        isLoading(true);
        var restUrl = baseUrl + "Delete/" + parishId;
        var jqXHR = $.ajax({
            method: "GET",
            url: restUrl,
            dataType: "json"
        }).done(function () {
            console.log("Deleted: " + parishId);
            //parishList.remove(parish);
            // refresh
            getParishList();
        }).fail(function () {
            console.log("Error");
        }).always(function (data) {
            console.log("finished");
            isLoading(false);
        });
    }



    // load

    var load = function (data) {
        parishList.removeAll();
        var underlyingArray = parishList();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var parish = new Web.parishViewModel();
            parish.load(result);
            underlyingArray.push(parish);
        }
        parishList.valueHasMutated();
    };



    // data table

    var updateDatatable = function (data) {
        var dataArray = new Array();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var fieldsInArray = new Array();

            fieldsInArray.push(result.countyId);
            fieldsInArray.push(result.districtId);
            fieldsInArray.push(result.countryId);
            fieldsInArray.push(result.name);
            fieldsInArray.push(result.code);
            fieldsInArray.push(result.latitude);
            fieldsInArray.push(result.longitude);
            fieldsInArray.push(result.active);

            var viewLinkElement = '<a href=\"' + result.editUrl + '\" style=\"margin-right: 10px;\">View</a>';
            var editLinkElement = '<a href=\"' + result.editUrl + '\" style=\"margin-right: 10px;\">Edit</a>';
            var deleteLinkElement = '<a href=\"' + 'javascript:vm.deleteParishById(' + result.parishId + ');' + '\" style=\"margin-right: 10px;\">Delete</a>';
            fieldsInArray.push(viewLinkElement + editLinkElement + deleteLinkElement);

            dataArray.push(fieldsInArray);
        }

        var datatable = $("#ParishsTable-" + moduleId).DataTable();
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
        parishList: parishList,
        getParishList: getParishList,
        getParishPage: getParishPage,
        deleteParish: deleteParish,
        deleteParishById: deleteParishById,
        editMode: editMode,
        isLoading: isLoading,
        searchText: searchText,
        openCreateForm: openCreateForm,
        getParishListAdvanced: getParishListAdvanced,
        advancedSearch: advancedSearch,
        clearSearchFilters: clearSearchFilters,

        countyList: countyHelper.countyList,
        districtList: districtHelper.districtList,
        countryList: countryHelper.countryList,

        countyIdFilter: countyIdFilter,
        districtIdFilter: districtIdFilter,
        countryIdFilter: countryIdFilter,
        nameFilter: nameFilter,
        codeFilter: codeFilter,
        latitudeFilter: latitudeFilter,
        longitudeFilter: longitudeFilter,
        activeFilter: activeFilter,
    }
};



// view model

Web.parishViewModel = function () {
    var parishId = ko.observable(-1);
    var countyId = ko.observable(-1);
    var districtId = ko.observable(-1);
    var countryId = ko.observable(-1);
    var name = ko.observable('');
    var code = ko.observable('');
    var latitude = ko.observable('');
    var longitude = ko.observable('');
    var active = ko.observable('');
    var isDeleted = ko.observable('');

    var editUrl = ko.observable('');

    var visibleOnSearch = ko.observable(true);
 
    // load

    var load = function (data) {
        parishId(data.parishId);
        countyId(data.countyId);
        districtId(data.districtId);
        countryId(data.countryId);
        name(data.name);
        code(data.code);
        latitude(data.latitude);
        longitude(data.longitude);
        active(data.active);
        isDeleted(data.isDeleted);
        editUrl(data.editUrl);
    };



    return {
        parishId: parishId,
        countyId: countyId,
        districtId: districtId,
        countryId: countryId,
        name: name,
        code: code,
        latitude: latitude,
        longitude: longitude,
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






    