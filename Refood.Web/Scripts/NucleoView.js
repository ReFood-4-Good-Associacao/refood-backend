
// ################################################################
//                      Code generated with T4
// ################################################################

var Web = Web || {};

Web.nucleoListViewModel = function (moduleId, resx) {
    var baseUrl = "api/NucleoApi/";

    var isLoading = ko.observable(false);
    var nucleoList = ko.observableArray([]);
    var editMode = ko.computed(function () {
        return nucleoList().length > 0 && nucleoList()[0].editUrl() != null && nucleoList()[0].editUrl().length > 0;
    });
    var searchText = ko.observable('');



    // filters

    var nameFilter = ko.observable('');
    var personResponsibleFilter = ko.observable('');
    var photoFilter = ko.observable('');
    var addressIdFilter = ko.observable(-1);
    var openingDateFromFilter = ko.observable('');
    var openingDateToFilter = ko.observable('');
    var primaryPhoneNumberFilter = ko.observable('');
    var primaryEmailFilter = ko.observable('');
    var activeFilter = ko.observable('');



    // helpers

    var addressHelper = Web.addressHelper(isLoading, '/', function(){});



    // init

    var init = function () {
        //getNucleoList();
        //getNucleoPage();
        getNucleoListAdvanced();

        addressHelper.getAddressList();
    }



    // get list

    var getNucleoList = function () {
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
                nucleoList.removeAll();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };



    // get list - advanced search

    var getNucleoListAdvanced = function () {
        isLoading(true);

        var searchFilters = "?";
        searchFilters += (nameFilter() != '' ? "name=" + nameFilter() : "");
        searchFilters += (personResponsibleFilter() != '' ? "personResponsible=" + personResponsibleFilter() : "");
        searchFilters += (photoFilter() != '' ? "photo=" + photoFilter() : "");
        searchFilters += (addressIdFilter() != -1 && addressIdFilter() != undefined ? "&" + "addressId=" + addressIdFilter() : "");
        searchFilters += (openingDateFromFilter() != '' && openingDateFromFilter() != null ? "&" + "openingDateFrom=" + dateToStringServerFormat(openingDateFromFilter()) : "");
        searchFilters += (openingDateToFilter() != '' && openingDateToFilter() != null ? "&" + "openingDateTo=" + dateToStringServerFormat(openingDateToFilter()) : "");
        searchFilters += (primaryPhoneNumberFilter() != '' ? "primaryPhoneNumber=" + primaryPhoneNumberFilter() : "");
        searchFilters += (primaryEmailFilter() != '' ? "primaryEmail=" + primaryEmailFilter() : "");
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
                nucleoList.removeAll();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };

    var advancedSearch = function () {
        getNucleoListAdvanced();
    };

    var clearSearchFilters = function () {
        nameFilter('');
        personResponsibleFilter('');
        photoFilter('');
        addressIdFilter(-1);
        openingDateFromFilter('');
        openingDateToFilter('');
        primaryPhoneNumberFilter('');
        primaryEmailFilter('');
        activeFilter('');
    };



    // get list by page

    var getNucleoPage = function () {
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
                nucleoList.removeAll();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };



    // delete

    var deleteNucleo = function (nucleo) {
        isLoading(true);
        var restUrl = baseUrl + "Delete/" + nucleo.nucleoId();
        var jqXHR = $.ajax({
            url: restUrl,
            dataType: "json"
        }).done(function () {
            console.log("Deleted: " + nucleo.nucleoId());
            nucleoList.remove(nucleo);
        }).fail(function () {
            console.log("Error");
        }).always(function (data) {
            console.log("finished");
            isLoading(false);
        });
    }

    var deleteNucleoById = function (nucleoId) {
        isLoading(true);
        var restUrl = baseUrl + "Delete/" + nucleoId;
        var jqXHR = $.ajax({
            method: "GET",
            url: restUrl,
            dataType: "json"
        }).done(function () {
            console.log("Deleted: " + nucleoId);
            //nucleoList.remove(nucleo);
            // refresh
            getNucleoList();
        }).fail(function () {
            console.log("Error");
        }).always(function (data) {
            console.log("finished");
            isLoading(false);
        });
    }



    // load

    var load = function (data) {
        nucleoList.removeAll();
        var underlyingArray = nucleoList();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var nucleo = new Web.nucleoViewModel();
            nucleo.load(result);
            underlyingArray.push(nucleo);
        }
        nucleoList.valueHasMutated();
    };



    // data table

    var updateDatatable = function (data) {
        var dataArray = new Array();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var fieldsInArray = new Array();

            fieldsInArray.push(result.name);
            fieldsInArray.push(result.personResponsible);
            fieldsInArray.push(result.photo);
            fieldsInArray.push(result.addressId);
            fieldsInArray.push(result.openingDate);
            fieldsInArray.push(result.primaryPhoneNumber);
            fieldsInArray.push(result.primaryEmail);
            fieldsInArray.push(result.active);

            var viewLinkElement = '<a href=\"' + result.editUrl + '\" style=\"margin-right: 10px;\">View</a>';
            var editLinkElement = '<a href=\"' + result.editUrl + '\" style=\"margin-right: 10px;\">Edit</a>';
            var deleteLinkElement = '<a href=\"' + 'javascript:vm.deleteNucleoById(' + result.nucleoId + ');' + '\" style=\"margin-right: 10px;\">Delete</a>';
            fieldsInArray.push(viewLinkElement + editLinkElement + deleteLinkElement);

            dataArray.push(fieldsInArray);
        }

        var datatable = $("#NucleosTable-" + moduleId).DataTable();
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
        nucleoList: nucleoList,
        getNucleoList: getNucleoList,
        getNucleoPage: getNucleoPage,
        deleteNucleo: deleteNucleo,
        deleteNucleoById: deleteNucleoById,
        editMode: editMode,
        isLoading: isLoading,
        searchText: searchText,
        openCreateForm: openCreateForm,
        getNucleoListAdvanced: getNucleoListAdvanced,
        advancedSearch: advancedSearch,
        clearSearchFilters: clearSearchFilters,

        addressList: addressHelper.addressList,

        nameFilter: nameFilter,
        personResponsibleFilter: personResponsibleFilter,
        photoFilter: photoFilter,
        addressIdFilter: addressIdFilter,
        openingDateFromFilter: openingDateFromFilter,
        openingDateToFilter: openingDateToFilter,
        primaryPhoneNumberFilter: primaryPhoneNumberFilter,
        primaryEmailFilter: primaryEmailFilter,
        activeFilter: activeFilter,
    }
};



// view model

Web.nucleoViewModel = function () {
    var nucleoId = ko.observable(-1);
    var name = ko.observable('');
    var personResponsible = ko.observable('');
    var photo = ko.observable('');
    var addressId = ko.observable(-1);
    var openingDate = ko.observable('');
    var primaryPhoneNumber = ko.observable('');
    var primaryEmail = ko.observable('');
    var active = ko.observable('');
    var isDeleted = ko.observable('');

    var editUrl = ko.observable('');

    var visibleOnSearch = ko.observable(true);
 
    // load

    var load = function (data) {
        nucleoId(data.nucleoId);
        name(data.name);
        personResponsible(data.personResponsible);
        photo(data.photo);
        addressId(data.addressId);
        openingDate(data.openingDate);
        primaryPhoneNumber(data.primaryPhoneNumber);
        primaryEmail(data.primaryEmail);
        active(data.active);
        isDeleted(data.isDeleted);
        editUrl(data.editUrl);
    };



    return {
        nucleoId: nucleoId,
        name: name,
        personResponsible: personResponsible,
        photo: photo,
        addressId: addressId,
        openingDate: openingDate,
        primaryPhoneNumber: primaryPhoneNumber,
        primaryEmail: primaryEmail,
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






    