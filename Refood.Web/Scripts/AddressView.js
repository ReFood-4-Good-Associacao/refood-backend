
// ################################################################
//                      Code generated with T4
// ################################################################

var Web = Web || {};

Web.addressListViewModel = function (moduleId, resx) {
    var baseUrl = "/Address/";

    var isLoading = ko.observable(false);
    var addressList = ko.observableArray([]);
    var editMode = ko.computed(function () {
        return addressList().length > 0 && addressList()[0].editUrl() != null && addressList()[0].editUrl().length > 0;
    });
    var searchText = ko.observable('');



    // filters

    var nameFilter = ko.observable('');
    var addressFirstLineFilter = ko.observable('');
    var addressSecondLineFilter = ko.observable('');
    var countryIdFilter = ko.observable(-1);
    var districtIdFilter = ko.observable(-1);
    var countyIdFilter = ko.observable(-1);
    var parishIdFilter = ko.observable(-1);
    var zipCodeFilter = ko.observable('');
    var latitudeFilter = ko.observable('');
    var longitudeFilter = ko.observable('');
    var activeFilter = ko.observable('');



    // helpers

    var countryHelper = Web.countryHelper(isLoading, '/', function(){});
    var districtHelper = Web.districtHelper(isLoading, '/', function(){});
    var countyHelper = Web.countyHelper(isLoading, '/', function(){});
    var parishHelper = Web.parishHelper(isLoading, '/', function(){});



    // init

    var init = function () {
        //getAddressList();
        //getAddressPage();
        getAddressListAdvanced();

        countryHelper.getCountryList();
        districtHelper.getDistrictList();
        countyHelper.getCountyList();
        parishHelper.getParishList();
    }



    // get list

    var getAddressList = function () {
        isLoading(true);
        var jqXHR = $.ajax({
            url: baseUrl + "GetList/0/",
            dataType: "json"
        }).done(function (data) {
            if (data) {
                load(data);

                // update datatable
                updateDatatable(data);
            }
            else {
                // No data to load 
                addressList.removeAll();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };



    // get list - advanced search

    var getAddressListAdvanced = function () {
        isLoading(true);

        var searchFilters = "?";
        searchFilters += (nameFilter() != '' ? "name=" + nameFilter() : "");
        searchFilters += (addressFirstLineFilter() != '' ? "addressFirstLine=" + addressFirstLineFilter() : "");
        searchFilters += (addressSecondLineFilter() != '' ? "addressSecondLine=" + addressSecondLineFilter() : "");
        searchFilters += (countryIdFilter() != -1 && countryIdFilter() != undefined ? "&" + "countryId=" + countryIdFilter() : "");
        searchFilters += (districtIdFilter() != -1 && districtIdFilter() != undefined ? "&" + "districtId=" + districtIdFilter() : "");
        searchFilters += (countyIdFilter() != -1 && countyIdFilter() != undefined ? "&" + "countyId=" + countyIdFilter() : "");
        searchFilters += (parishIdFilter() != -1 && parishIdFilter() != undefined ? "&" + "parishId=" + parishIdFilter() : "");
        searchFilters += (zipCodeFilter() != '' ? "zipCode=" + zipCodeFilter() : "");
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
                addressList.removeAll();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };

    var advancedSearch = function () {
        getAddressListAdvanced();
    };

    var clearSearchFilters = function () {
        nameFilter('');
        addressFirstLineFilter('');
        addressSecondLineFilter('');
        countryIdFilter(-1);
        districtIdFilter(-1);
        countyIdFilter(-1);
        parishIdFilter(-1);
        zipCodeFilter('');
        latitudeFilter('');
        longitudeFilter('');
        activeFilter('');
    };



    // get list by page

    var getAddressPage = function () {
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
                addressList.removeAll();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };



    // delete

    var deleteAddress = function (address) {
        isLoading(true);
        var restUrl = baseUrl + "Delete/" + address.addressId();
        var jqXHR = $.ajax({
            url: restUrl,
            dataType: "json"
        }).done(function () {
            console.log("Deleted: " + address.addressId());
            addressList.remove(address);
        }).fail(function () {
            console.log("Error");
        }).always(function (data) {
            console.log("finished");
            isLoading(false);
        });
    }

    var deleteAddressById = function (addressId) {
        isLoading(true);
        var restUrl = baseUrl + "Delete/" + addressId;
        var jqXHR = $.ajax({
            method: "GET",
            url: restUrl,
            dataType: "json"
        }).done(function () {
            console.log("Deleted: " + addressId);
            //addressList.remove(address);
            // refresh
            getAddressList();
        }).fail(function () {
            console.log("Error");
        }).always(function (data) {
            console.log("finished");
            isLoading(false);
        });
    }



    // load

    var load = function (data) {
        addressList.removeAll();
        var underlyingArray = addressList();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var address = new Web.addressViewModel();
            address.load(result);
            underlyingArray.push(address);
        }
        addressList.valueHasMutated();
    };



    // data table

    var updateDatatable = function (data) {
        var dataArray = new Array();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var fieldsInArray = new Array();

            fieldsInArray.push(result.name);
            fieldsInArray.push(result.addressFirstLine);
            fieldsInArray.push(result.addressSecondLine);
            fieldsInArray.push(result.countryId);
            fieldsInArray.push(result.districtId);
            fieldsInArray.push(result.countyId);
            fieldsInArray.push(result.parishId);
            fieldsInArray.push(result.zipCode);
            fieldsInArray.push(result.latitude);
            fieldsInArray.push(result.longitude);
            fieldsInArray.push(result.active);

            var viewLinkElement = '<a href=\"' + result.editUrl + '\" style=\"margin-right: 10px;\">View</a>';
            var editLinkElement = '<a href=\"' + result.editUrl + '\" style=\"margin-right: 10px;\">Edit</a>';
            var deleteLinkElement = '<a href=\"' + 'javascript:vm.deleteAddressById(' + result.addressId + ');' + '\" style=\"margin-right: 10px;\">Delete</a>';
            fieldsInArray.push(viewLinkElement + editLinkElement + deleteLinkElement);

            dataArray.push(fieldsInArray);
        }

        var datatable = $("#AddresssTable-" + moduleId).DataTable();
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
        addressList: addressList,
        getAddressList: getAddressList,
        getAddressPage: getAddressPage,
        deleteAddress: deleteAddress,
        deleteAddressById: deleteAddressById,
        editMode: editMode,
        isLoading: isLoading,
        searchText: searchText,
        openCreateForm: openCreateForm,
        getAddressListAdvanced: getAddressListAdvanced,
        advancedSearch: advancedSearch,
        clearSearchFilters: clearSearchFilters,

        countryList: countryHelper.countryList,
        districtList: districtHelper.districtList,
        countyList: countyHelper.countyList,
        parishList: parishHelper.parishList,

        nameFilter: nameFilter,
        addressFirstLineFilter: addressFirstLineFilter,
        addressSecondLineFilter: addressSecondLineFilter,
        countryIdFilter: countryIdFilter,
        districtIdFilter: districtIdFilter,
        countyIdFilter: countyIdFilter,
        parishIdFilter: parishIdFilter,
        zipCodeFilter: zipCodeFilter,
        latitudeFilter: latitudeFilter,
        longitudeFilter: longitudeFilter,
        activeFilter: activeFilter,
    }
};



// view model

Web.addressViewModel = function () {
    var addressId = ko.observable(-1);
    var name = ko.observable('');
    var addressFirstLine = ko.observable('');
    var addressSecondLine = ko.observable('');
    var countryId = ko.observable(-1);
    var districtId = ko.observable(-1);
    var countyId = ko.observable(-1);
    var parishId = ko.observable(-1);
    var zipCode = ko.observable('');
    var latitude = ko.observable('');
    var longitude = ko.observable('');
    var active = ko.observable('');
    var isDeleted = ko.observable('');

    var editUrl = ko.observable('');

    var visibleOnSearch = ko.observable(true);
 
    // load

    var load = function (data) {
        addressId(data.addressId);
        name(data.name);
        addressFirstLine(data.addressFirstLine);
        addressSecondLine(data.addressSecondLine);
        countryId(data.countryId);
        districtId(data.districtId);
        countyId(data.countyId);
        parishId(data.parishId);
        zipCode(data.zipCode);
        latitude(data.latitude);
        longitude(data.longitude);
        active(data.active);
        isDeleted(data.isDeleted);
        editUrl(data.editUrl);
    };



    return {
        addressId: addressId,
        name: name,
        addressFirstLine: addressFirstLine,
        addressSecondLine: addressSecondLine,
        countryId: countryId,
        districtId: districtId,
        countyId: countyId,
        parishId: parishId,
        zipCode: zipCode,
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






    