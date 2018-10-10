
// ################################################################
//                      Code generated with T4
// ################################################################

var Web = Web || {};

Web.supplierListViewModel = function (moduleId, resx) {
    var baseUrl = "api/SupplierApi/";

    var isLoading = ko.observable(false);
    var supplierList = ko.observableArray([]);
    var editMode = ko.computed(function () {
        return supplierList().length > 0 && supplierList()[0].editUrl() != null && supplierList()[0].editUrl().length > 0;
    });
    var searchText = ko.observable('');



    // filters

    var nameFilter = ko.observable('');
    var supplierTypeIdFilter = ko.observable(-1);
    var phoneFilter = ko.observable('');
    var emailFilter = ko.observable('');
    var latitudeFilter = ko.observable('');
    var longitudeFilter = ko.observable('');
    var descriptionFilter = ko.observable('');
    var websiteFilter = ko.observable('');
    var addressIdFilter = ko.observable(-1);



    // helpers

    var supplierTypeHelper = Web.supplierTypeHelper(isLoading, '/', function(){});
    var addressHelper = Web.addressHelper(isLoading, '/', function(){});



    // init

    var init = function () {
        //getSupplierList();
        //getSupplierPage();
        getSupplierListAdvanced();

        supplierTypeHelper.getSupplierTypeList();
        addressHelper.getAddressList();
    }



    // get list

    var getSupplierList = function () {
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
                supplierList.removeAll();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };



    // get list - advanced search

    var getSupplierListAdvanced = function () {
        isLoading(true);

        var searchFilters = "?";
        searchFilters += (nameFilter() != '' ? "name=" + nameFilter() : "");
        searchFilters += (supplierTypeIdFilter() != -1 && supplierTypeIdFilter() != undefined ? "&" + "supplierTypeId=" + supplierTypeIdFilter() : "");
        searchFilters += (phoneFilter() != '' ? "phone=" + phoneFilter() : "");
        searchFilters += (emailFilter() != '' ? "email=" + emailFilter() : "");
        searchFilters += (latitudeFilter() != '' ? "latitude=" + latitudeFilter() : "");
        searchFilters += (longitudeFilter() != '' ? "longitude=" + longitudeFilter() : "");
        searchFilters += (descriptionFilter() != '' ? "description=" + descriptionFilter() : "");
        searchFilters += (websiteFilter() != '' ? "website=" + websiteFilter() : "");
        searchFilters += (addressIdFilter() != -1 && addressIdFilter() != undefined ? "&" + "addressId=" + addressIdFilter() : "");

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
                supplierList.removeAll();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };

    var advancedSearch = function () {
        getSupplierListAdvanced();
    };

    var clearSearchFilters = function () {
        nameFilter('');
        supplierTypeIdFilter(-1);
        phoneFilter('');
        emailFilter('');
        latitudeFilter('');
        longitudeFilter('');
        descriptionFilter('');
        websiteFilter('');
        addressIdFilter(-1);
    };



    // get list by page

    var getSupplierPage = function () {
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
                supplierList.removeAll();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };



    // delete

    var deleteSupplier = function (supplier) {
        isLoading(true);
        var restUrl = baseUrl + "Delete/" + supplier.supplierId();
        var jqXHR = $.ajax({
            url: restUrl,
            dataType: "json"
        }).done(function () {
            console.log("Deleted: " + supplier.supplierId());
            supplierList.remove(supplier);
        }).fail(function () {
            console.log("Error");
        }).always(function (data) {
            console.log("finished");
            isLoading(false);
        });
    }

    var deleteSupplierById = function (supplierId) {
        isLoading(true);
        var restUrl = baseUrl + "Delete/" + supplierId;
        var jqXHR = $.ajax({
            method: "GET",
            url: restUrl,
            dataType: "json"
        }).done(function () {
            console.log("Deleted: " + supplierId);
            //supplierList.remove(supplier);
            // refresh
            getSupplierList();
        }).fail(function () {
            console.log("Error");
        }).always(function (data) {
            console.log("finished");
            isLoading(false);
        });
    }



    // load

    var load = function (data) {
        supplierList.removeAll();
        var underlyingArray = supplierList();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var supplier = new Web.supplierViewModel();
            supplier.load(result);
            underlyingArray.push(supplier);
        }
        supplierList.valueHasMutated();
    };



    // data table

    var updateDatatable = function (data) {
        var dataArray = new Array();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var fieldsInArray = new Array();

            fieldsInArray.push(result.name);
            fieldsInArray.push(result.supplierTypeId);
            fieldsInArray.push(result.phone);
            fieldsInArray.push(result.email);
            fieldsInArray.push(result.latitude);
            fieldsInArray.push(result.longitude);
            fieldsInArray.push(result.description);
            fieldsInArray.push(result.website);
            fieldsInArray.push(result.addressId);

            var viewLinkElement = '<a href=\"' + result.editUrl + '\" style=\"margin-right: 10px;\">View</a>';
            var editLinkElement = '<a href=\"' + result.editUrl + '\" style=\"margin-right: 10px;\">Edit</a>';
            var deleteLinkElement = '<a href=\"' + 'javascript:vm.deleteSupplierById(' + result.supplierId + ');' + '\" style=\"margin-right: 10px;\">Delete</a>';
            fieldsInArray.push(viewLinkElement + editLinkElement + deleteLinkElement);

            dataArray.push(fieldsInArray);
        }

        var datatable = $("#SuppliersTable-" + moduleId).DataTable();
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
        supplierList: supplierList,
        getSupplierList: getSupplierList,
        getSupplierPage: getSupplierPage,
        deleteSupplier: deleteSupplier,
        deleteSupplierById: deleteSupplierById,
        editMode: editMode,
        isLoading: isLoading,
        searchText: searchText,
        openCreateForm: openCreateForm,
        getSupplierListAdvanced: getSupplierListAdvanced,
        advancedSearch: advancedSearch,
        clearSearchFilters: clearSearchFilters,

        supplierTypeList: supplierTypeHelper.supplierTypeList,
        addressList: addressHelper.addressList,

        nameFilter: nameFilter,
        supplierTypeIdFilter: supplierTypeIdFilter,
        phoneFilter: phoneFilter,
        emailFilter: emailFilter,
        latitudeFilter: latitudeFilter,
        longitudeFilter: longitudeFilter,
        descriptionFilter: descriptionFilter,
        websiteFilter: websiteFilter,
        addressIdFilter: addressIdFilter,
    }
};



// view model

Web.supplierViewModel = function () {
    var supplierId = ko.observable(-1);
    var name = ko.observable('');
    var supplierTypeId = ko.observable(-1);
    var phone = ko.observable('');
    var email = ko.observable('');
    var latitude = ko.observable('');
    var longitude = ko.observable('');
    var description = ko.observable('');
    var website = ko.observable('');
    var addressId = ko.observable(-1);
    var isDeleted = ko.observable('');

    var editUrl = ko.observable('');

    var visibleOnSearch = ko.observable(true);
 
    // load

    var load = function (data) {
        supplierId(data.supplierId);
        name(data.name);
        supplierTypeId(data.supplierTypeId);
        phone(data.phone);
        email(data.email);
        latitude(data.latitude);
        longitude(data.longitude);
        description(data.description);
        website(data.website);
        addressId(data.addressId);
        isDeleted(data.isDeleted);
        editUrl(data.editUrl);
    };



    return {
        supplierId: supplierId,
        name: name,
        supplierTypeId: supplierTypeId,
        phone: phone,
        email: email,
        latitude: latitude,
        longitude: longitude,
        description: description,
        website: website,
        addressId: addressId,
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






    