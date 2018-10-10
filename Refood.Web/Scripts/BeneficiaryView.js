
// ################################################################
//                      Code generated with T4
// ################################################################

var Web = Web || {};

Web.beneficiaryListViewModel = function (moduleId, resx) {
    var baseUrl = "api/BeneficiaryApi/";

    var isLoading = ko.observable(false);
    var beneficiaryList = ko.observableArray([]);
    var editMode = ko.computed(function () {
        return beneficiaryList().length > 0 && beneficiaryList()[0].editUrl() != null && beneficiaryList()[0].editUrl().length > 0;
    });
    var searchText = ko.observable('');



    // filters

    var nameFilter = ko.observable('');
    var numberFilter = ko.observable('');
    var addressIdFilter = ko.observable(-1);
    var numberOfAdultsFilter = ko.observable('');
    var numberOfChildrenFilter = ko.observable('');
    var numberOfTupperwareFilter = ko.observable('');
    var numberOfSoupsFilter = ko.observable('');
    var descriptionFilter = ko.observable('');
    var activeFilter = ko.observable('');



    // helpers

    var addressHelper = Web.addressHelper(isLoading, '/', function(){});



    // init

    var init = function () {
        //getBeneficiaryList();
        //getBeneficiaryPage();
        getBeneficiaryListAdvanced();

        addressHelper.getAddressList();
    }



    // get list

    var getBeneficiaryList = function () {
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
                beneficiaryList.removeAll();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };



    // get list - advanced search

    var getBeneficiaryListAdvanced = function () {
        isLoading(true);

        var searchFilters = "?";
        searchFilters += (nameFilter() != '' ? "name=" + nameFilter() : "");
        searchFilters += (numberFilter() != '' ? "number=" + numberFilter() : "");
        searchFilters += (addressIdFilter() != -1 && addressIdFilter() != undefined ? "&" + "addressId=" + addressIdFilter() : "");
        searchFilters += (numberOfAdultsFilter() != '' ? "numberOfAdults=" + numberOfAdultsFilter() : "");
        searchFilters += (numberOfChildrenFilter() != '' ? "numberOfChildren=" + numberOfChildrenFilter() : "");
        searchFilters += (numberOfTupperwareFilter() != '' ? "numberOfTupperware=" + numberOfTupperwareFilter() : "");
        searchFilters += (numberOfSoupsFilter() != '' ? "numberOfSoups=" + numberOfSoupsFilter() : "");
        searchFilters += (descriptionFilter() != '' ? "description=" + descriptionFilter() : "");
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
                beneficiaryList.removeAll();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };

    var advancedSearch = function () {
        getBeneficiaryListAdvanced();
    };

    var clearSearchFilters = function () {
        nameFilter('');
        numberFilter('');
        addressIdFilter(-1);
        numberOfAdultsFilter('');
        numberOfChildrenFilter('');
        numberOfTupperwareFilter('');
        numberOfSoupsFilter('');
        descriptionFilter('');
        activeFilter('');
    };



    // get list by page

    var getBeneficiaryPage = function () {
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
                beneficiaryList.removeAll();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };



    // delete

    var deleteBeneficiary = function (beneficiary) {
        isLoading(true);
        var restUrl = baseUrl + "Delete/" + beneficiary.beneficiaryId();
        var jqXHR = $.ajax({
            url: restUrl,
            dataType: "json"
        }).done(function () {
            console.log("Deleted: " + beneficiary.beneficiaryId());
            beneficiaryList.remove(beneficiary);
        }).fail(function () {
            console.log("Error");
        }).always(function (data) {
            console.log("finished");
            isLoading(false);
        });
    }

    var deleteBeneficiaryById = function (beneficiaryId) {
        isLoading(true);
        var restUrl = baseUrl + "Delete/" + beneficiaryId;
        var jqXHR = $.ajax({
            method: "GET",
            url: restUrl,
            dataType: "json"
        }).done(function () {
            console.log("Deleted: " + beneficiaryId);
            //beneficiaryList.remove(beneficiary);
            // refresh
            getBeneficiaryList();
        }).fail(function () {
            console.log("Error");
        }).always(function (data) {
            console.log("finished");
            isLoading(false);
        });
    }



    // load

    var load = function (data) {
        beneficiaryList.removeAll();
        var underlyingArray = beneficiaryList();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var beneficiary = new Web.beneficiaryViewModel();
            beneficiary.load(result);
            underlyingArray.push(beneficiary);
        }
        beneficiaryList.valueHasMutated();
    };



    // data table

    var updateDatatable = function (data) {
        var dataArray = new Array();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var fieldsInArray = new Array();

            fieldsInArray.push(result.name);
            fieldsInArray.push(result.number);
            fieldsInArray.push(result.addressId);
            fieldsInArray.push(result.numberOfAdults);
            fieldsInArray.push(result.numberOfChildren);
            fieldsInArray.push(result.numberOfTupperware);
            fieldsInArray.push(result.numberOfSoups);
            fieldsInArray.push(result.description);
            fieldsInArray.push(result.active);

            var viewLinkElement = '<a href=\"' + result.editUrl + '\" style=\"margin-right: 10px;\">View</a>';
            var editLinkElement = '<a href=\"' + result.editUrl + '\" style=\"margin-right: 10px;\">Edit</a>';
            var deleteLinkElement = '<a href=\"' + 'javascript:vm.deleteBeneficiaryById(' + result.beneficiaryId + ');' + '\" style=\"margin-right: 10px;\">Delete</a>';
            fieldsInArray.push(viewLinkElement + editLinkElement + deleteLinkElement);

            dataArray.push(fieldsInArray);
        }

        var datatable = $("#BeneficiarysTable-" + moduleId).DataTable();
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
        beneficiaryList: beneficiaryList,
        getBeneficiaryList: getBeneficiaryList,
        getBeneficiaryPage: getBeneficiaryPage,
        deleteBeneficiary: deleteBeneficiary,
        deleteBeneficiaryById: deleteBeneficiaryById,
        editMode: editMode,
        isLoading: isLoading,
        searchText: searchText,
        openCreateForm: openCreateForm,
        getBeneficiaryListAdvanced: getBeneficiaryListAdvanced,
        advancedSearch: advancedSearch,
        clearSearchFilters: clearSearchFilters,

        addressList: addressHelper.addressList,

        nameFilter: nameFilter,
        numberFilter: numberFilter,
        addressIdFilter: addressIdFilter,
        numberOfAdultsFilter: numberOfAdultsFilter,
        numberOfChildrenFilter: numberOfChildrenFilter,
        numberOfTupperwareFilter: numberOfTupperwareFilter,
        numberOfSoupsFilter: numberOfSoupsFilter,
        descriptionFilter: descriptionFilter,
        activeFilter: activeFilter,
    }
};



// view model

Web.beneficiaryViewModel = function () {
    var beneficiaryId = ko.observable(-1);
    var name = ko.observable('');
    var number = ko.observable('');
    var addressId = ko.observable(-1);
    var numberOfAdults = ko.observable('');
    var numberOfChildren = ko.observable('');
    var numberOfTupperware = ko.observable('');
    var numberOfSoups = ko.observable('');
    var description = ko.observable('');
    var active = ko.observable('');
    var isDeleted = ko.observable('');

    var editUrl = ko.observable('');

    var visibleOnSearch = ko.observable(true);
 
    // load

    var load = function (data) {
        beneficiaryId(data.beneficiaryId);
        name(data.name);
        number(data.number);
        addressId(data.addressId);
        numberOfAdults(data.numberOfAdults);
        numberOfChildren(data.numberOfChildren);
        numberOfTupperware(data.numberOfTupperware);
        numberOfSoups(data.numberOfSoups);
        description(data.description);
        active(data.active);
        isDeleted(data.isDeleted);
        editUrl(data.editUrl);
    };



    return {
        beneficiaryId: beneficiaryId,
        name: name,
        number: number,
        addressId: addressId,
        numberOfAdults: numberOfAdults,
        numberOfChildren: numberOfChildren,
        numberOfTupperware: numberOfTupperware,
        numberOfSoups: numberOfSoups,
        description: description,
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






    