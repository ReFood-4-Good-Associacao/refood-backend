
// ################################################################
//                      Code generated with T4
// ################################################################

var Web = Web || {};

Web.countryListViewModel = function (moduleId, resx) {
    var baseUrl = "api/CountryApi/";

    var isLoading = ko.observable(false);
    var countryList = ko.observableArray([]);
    var editMode = ko.computed(function () {
        return countryList().length > 0 && countryList()[0].editUrl() != null && countryList()[0].editUrl().length > 0;
    });
    var searchText = ko.observable('');



    // filters

    var nameFilter = ko.observable('');
    var englishNameFilter = ko.observable('');
    var isoCodeFilter = ko.observable('');
    var capitalCityFilter = ko.observable('');
    var latitudeFilter = ko.observable('');
    var longitudeFilter = ko.observable('');
    var phonePrefixFilter = ko.observable('');
    var activeFilter = ko.observable('');



    // helpers




    // init

    var init = function () {
        //getCountryList();
        //getCountryPage();
        getCountryListAdvanced();

    }



    // get list

    var getCountryList = function () {
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
                countryList.removeAll();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };



    // get list - advanced search

    var getCountryListAdvanced = function () {
        isLoading(true);

        var searchFilters = "?";
        searchFilters += (nameFilter() != '' ? "name=" + nameFilter() : "");
        searchFilters += (englishNameFilter() != '' ? "englishName=" + englishNameFilter() : "");
        searchFilters += (isoCodeFilter() != '' ? "isoCode=" + isoCodeFilter() : "");
        searchFilters += (capitalCityFilter() != '' ? "capitalCity=" + capitalCityFilter() : "");
        searchFilters += (latitudeFilter() != '' ? "latitude=" + latitudeFilter() : "");
        searchFilters += (longitudeFilter() != '' ? "longitude=" + longitudeFilter() : "");
        searchFilters += (phonePrefixFilter() != '' ? "phonePrefix=" + phonePrefixFilter() : "");
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
                countryList.removeAll();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };

    var advancedSearch = function () {
        getCountryListAdvanced();
    };

    var clearSearchFilters = function () {
        nameFilter('');
        englishNameFilter('');
        isoCodeFilter('');
        capitalCityFilter('');
        latitudeFilter('');
        longitudeFilter('');
        phonePrefixFilter('');
        activeFilter('');
    };



    // get list by page

    var getCountryPage = function () {
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
                countryList.removeAll();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };



    // delete

    var deleteCountry = function (country) {
        isLoading(true);
        var restUrl = baseUrl + "Delete/" + country.countryId();
        var jqXHR = $.ajax({
            url: restUrl,
            dataType: "json"
        }).done(function () {
            console.log("Deleted: " + country.countryId());
            countryList.remove(country);
        }).fail(function () {
            console.log("Error");
        }).always(function (data) {
            console.log("finished");
            isLoading(false);
        });
    }

    var deleteCountryById = function (countryId) {
        isLoading(true);
        var restUrl = baseUrl + "Delete/" + countryId;
        var jqXHR = $.ajax({
            method: "GET",
            url: restUrl,
            dataType: "json"
        }).done(function () {
            console.log("Deleted: " + countryId);
            //countryList.remove(country);
            // refresh
            getCountryList();
        }).fail(function () {
            console.log("Error");
        }).always(function (data) {
            console.log("finished");
            isLoading(false);
        });
    }



    // load

    var load = function (data) {
        countryList.removeAll();
        var underlyingArray = countryList();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var country = new Web.countryViewModel();
            country.load(result);
            underlyingArray.push(country);
        }
        countryList.valueHasMutated();
    };



    // data table

    var updateDatatable = function (data) {
        var dataArray = new Array();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var fieldsInArray = new Array();

            fieldsInArray.push(result.name);
            fieldsInArray.push(result.englishName);
            fieldsInArray.push(result.isoCode);
            fieldsInArray.push(result.capitalCity);
            fieldsInArray.push(result.latitude);
            fieldsInArray.push(result.longitude);
            fieldsInArray.push(result.phonePrefix);
            fieldsInArray.push(result.active);

            var viewLinkElement = '<a href=\"' + result.editUrl + '\" style=\"margin-right: 10px;\">View</a>';
            var editLinkElement = '<a href=\"' + result.editUrl + '\" style=\"margin-right: 10px;\">Edit</a>';
            var deleteLinkElement = '<a href=\"' + 'javascript:vm.deleteCountryById(' + result.countryId + ');' + '\" style=\"margin-right: 10px;\">Delete</a>';
            fieldsInArray.push(viewLinkElement + editLinkElement + deleteLinkElement);

            dataArray.push(fieldsInArray);
        }

        var datatable = $("#CountrysTable-" + moduleId).DataTable();
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
        countryList: countryList,
        getCountryList: getCountryList,
        getCountryPage: getCountryPage,
        deleteCountry: deleteCountry,
        deleteCountryById: deleteCountryById,
        editMode: editMode,
        isLoading: isLoading,
        searchText: searchText,
        openCreateForm: openCreateForm,
        getCountryListAdvanced: getCountryListAdvanced,
        advancedSearch: advancedSearch,
        clearSearchFilters: clearSearchFilters,


        nameFilter: nameFilter,
        englishNameFilter: englishNameFilter,
        isoCodeFilter: isoCodeFilter,
        capitalCityFilter: capitalCityFilter,
        latitudeFilter: latitudeFilter,
        longitudeFilter: longitudeFilter,
        phonePrefixFilter: phonePrefixFilter,
        activeFilter: activeFilter,
    }
};



// view model

Web.countryViewModel = function () {
    var countryId = ko.observable(-1);
    var name = ko.observable('');
    var englishName = ko.observable('');
    var isoCode = ko.observable('');
    var capitalCity = ko.observable('');
    var latitude = ko.observable('');
    var longitude = ko.observable('');
    var phonePrefix = ko.observable('');
    var active = ko.observable('');
    var isDeleted = ko.observable('');

    var editUrl = ko.observable('');

    var visibleOnSearch = ko.observable(true);
 
    // load

    var load = function (data) {
        countryId(data.countryId);
        name(data.name);
        englishName(data.englishName);
        isoCode(data.isoCode);
        capitalCity(data.capitalCity);
        latitude(data.latitude);
        longitude(data.longitude);
        phonePrefix(data.phonePrefix);
        active(data.active);
        isDeleted(data.isDeleted);
        editUrl(data.editUrl);
    };



    return {
        countryId: countryId,
        name: name,
        englishName: englishName,
        isoCode: isoCode,
        capitalCity: capitalCity,
        latitude: latitude,
        longitude: longitude,
        phonePrefix: phonePrefix,
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






    