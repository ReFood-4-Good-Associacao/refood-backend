
// ################################################################
//                      Code generated with T4
// ################################################################

var Web = Web || {};

Web.districtListViewModel = function (moduleId, resx) {
    var baseUrl = "api/DistrictApi/";

    var isLoading = ko.observable(false);
    var districtList = ko.observableArray([]);
    var editMode = ko.computed(function () {
        return districtList().length > 0 && districtList()[0].editUrl() != null && districtList()[0].editUrl().length > 0;
    });
    var searchText = ko.observable('');



    // filters

    var countryIdFilter = ko.observable(-1);
    var nameFilter = ko.observable('');
    var codeFilter = ko.observable('');
    var latitudeFilter = ko.observable('');
    var longitudeFilter = ko.observable('');
    var activeFilter = ko.observable('');



    // helpers

    var countryHelper = Web.countryHelper(isLoading, '/', function(){});



    // init

    var init = function () {
        //getDistrictList();
        //getDistrictPage();
        getDistrictListAdvanced();

        countryHelper.getCountryList();
    }



    // get list

    var getDistrictList = function () {
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
                districtList.removeAll();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };



    // get list - advanced search

    var getDistrictListAdvanced = function () {
        isLoading(true);

        var searchFilters = "?";
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
                districtList.removeAll();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };

    var advancedSearch = function () {
        getDistrictListAdvanced();
    };

    var clearSearchFilters = function () {
        countryIdFilter(-1);
        nameFilter('');
        codeFilter('');
        latitudeFilter('');
        longitudeFilter('');
        activeFilter('');
    };



    // get list by page

    var getDistrictPage = function () {
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
                districtList.removeAll();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };



    // delete

    var deleteDistrict = function (district) {
        isLoading(true);
        var restUrl = baseUrl + "Delete/" + district.districtId();
        var jqXHR = $.ajax({
            url: restUrl,
            dataType: "json"
        }).done(function () {
            console.log("Deleted: " + district.districtId());
            districtList.remove(district);
        }).fail(function () {
            console.log("Error");
        }).always(function (data) {
            console.log("finished");
            isLoading(false);
        });
    }

    var deleteDistrictById = function (districtId) {
        isLoading(true);
        var restUrl = baseUrl + "Delete/" + districtId;
        var jqXHR = $.ajax({
            method: "GET",
            url: restUrl,
            dataType: "json"
        }).done(function () {
            console.log("Deleted: " + districtId);
            //districtList.remove(district);
            // refresh
            getDistrictList();
        }).fail(function () {
            console.log("Error");
        }).always(function (data) {
            console.log("finished");
            isLoading(false);
        });
    }



    // load

    var load = function (data) {
        districtList.removeAll();
        var underlyingArray = districtList();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var district = new Web.districtViewModel();
            district.load(result);
            underlyingArray.push(district);
        }
        districtList.valueHasMutated();
    };



    // data table

    var updateDatatable = function (data) {
        var dataArray = new Array();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var fieldsInArray = new Array();

            fieldsInArray.push(result.countryId);
            fieldsInArray.push(result.name);
            fieldsInArray.push(result.code);
            fieldsInArray.push(result.latitude);
            fieldsInArray.push(result.longitude);
            fieldsInArray.push(result.active);

            var viewLinkElement = '<a href=\"' + result.editUrl + '\" style=\"margin-right: 10px;\">View</a>';
            var editLinkElement = '<a href=\"' + result.editUrl + '\" style=\"margin-right: 10px;\">Edit</a>';
            var deleteLinkElement = '<a href=\"' + 'javascript:vm.deleteDistrictById(' + result.districtId + ');' + '\" style=\"margin-right: 10px;\">Delete</a>';
            fieldsInArray.push(viewLinkElement + editLinkElement + deleteLinkElement);

            dataArray.push(fieldsInArray);
        }

        var datatable = $("#DistrictsTable-" + moduleId).DataTable();
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
        districtList: districtList,
        getDistrictList: getDistrictList,
        getDistrictPage: getDistrictPage,
        deleteDistrict: deleteDistrict,
        deleteDistrictById: deleteDistrictById,
        editMode: editMode,
        isLoading: isLoading,
        searchText: searchText,
        openCreateForm: openCreateForm,
        getDistrictListAdvanced: getDistrictListAdvanced,
        advancedSearch: advancedSearch,
        clearSearchFilters: clearSearchFilters,

        countryList: countryHelper.countryList,

        countryIdFilter: countryIdFilter,
        nameFilter: nameFilter,
        codeFilter: codeFilter,
        latitudeFilter: latitudeFilter,
        longitudeFilter: longitudeFilter,
        activeFilter: activeFilter,
    }
};



// view model

Web.districtViewModel = function () {
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






    