
// ################################################################
//                      Code generated with T4
// ################################################################

var Web = Web || {};

Web.contributionMonetaryListViewModel = function (moduleId, resx) {
    var baseUrl = "api/ContributionMonetaryApi/";

    var isLoading = ko.observable(false);
    var contributionMonetaryList = ko.observableArray([]);
    var editMode = ko.computed(function () {
        return contributionMonetaryList().length > 0 && contributionMonetaryList()[0].editUrl() != null && contributionMonetaryList()[0].editUrl().length > 0;
    });
    var searchText = ko.observable('');



    // filters

    var nucleoIdFilter = ko.observable(-1);
    var responsiblePersonIdFilter = ko.observable(-1);
    var documentIdFilter = ko.observable(-1);
    var partnerIdFilter = ko.observable(-1);
    var contributionDateFromFilter = ko.observable('');
    var contributionDateToFilter = ko.observable('');
    var amountFilter = ko.observable('');
    var contactPersonFilter = ko.observable('');
    var ibanOriginFilter = ko.observable('');
    var bicSwiftOriginFilter = ko.observable('');
    var ibanDestinationFilter = ko.observable('');
    var bicSwiftDestinationFilter = ko.observable('');
    var fiscalNumberFilter = ko.observable('');
    var contributionChannelIdFilter = ko.observable(-1);



    // helpers

    var nucleoHelper = Web.nucleoHelper(isLoading, '/', function(){});
    var responsiblePersonHelper = Web.responsiblePersonHelper(isLoading, '/', function(){});
    var documentHelper = Web.documentHelper(isLoading, '/', function(){});
    var partnerHelper = Web.partnerHelper(isLoading, '/', function(){});
    var contributionChannelHelper = Web.contributionChannelHelper(isLoading, '/', function(){});



    // init

    var init = function () {
        //getContributionMonetaryList();
        //getContributionMonetaryPage();
        getContributionMonetaryListAdvanced();

        nucleoHelper.getNucleoList();
        responsiblePersonHelper.getResponsiblePersonList();
        documentHelper.getDocumentList();
        partnerHelper.getPartnerList();
        contributionChannelHelper.getContributionChannelList();
    }



    // get list

    var getContributionMonetaryList = function () {
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
                contributionMonetaryList.removeAll();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };



    // get list - advanced search

    var getContributionMonetaryListAdvanced = function () {
        isLoading(true);

        var searchFilters = "?";
        searchFilters += (nucleoIdFilter() != -1 && nucleoIdFilter() != undefined ? "&" + "nucleoId=" + nucleoIdFilter() : "");
        searchFilters += (responsiblePersonIdFilter() != -1 && responsiblePersonIdFilter() != undefined ? "&" + "responsiblePersonId=" + responsiblePersonIdFilter() : "");
        searchFilters += (documentIdFilter() != -1 && documentIdFilter() != undefined ? "&" + "documentId=" + documentIdFilter() : "");
        searchFilters += (partnerIdFilter() != -1 && partnerIdFilter() != undefined ? "&" + "partnerId=" + partnerIdFilter() : "");
        searchFilters += (contributionDateFromFilter() != '' && contributionDateFromFilter() != null ? "&" + "contributionDateFrom=" + dateToStringServerFormat(contributionDateFromFilter()) : "");
        searchFilters += (contributionDateToFilter() != '' && contributionDateToFilter() != null ? "&" + "contributionDateTo=" + dateToStringServerFormat(contributionDateToFilter()) : "");
        searchFilters += (amountFilter() != '' ? "amount=" + amountFilter() : "");
        searchFilters += (contactPersonFilter() != '' ? "contactPerson=" + contactPersonFilter() : "");
        searchFilters += (ibanOriginFilter() != '' ? "ibanOrigin=" + ibanOriginFilter() : "");
        searchFilters += (bicSwiftOriginFilter() != '' ? "bicSwiftOrigin=" + bicSwiftOriginFilter() : "");
        searchFilters += (ibanDestinationFilter() != '' ? "ibanDestination=" + ibanDestinationFilter() : "");
        searchFilters += (bicSwiftDestinationFilter() != '' ? "bicSwiftDestination=" + bicSwiftDestinationFilter() : "");
        searchFilters += (fiscalNumberFilter() != '' ? "fiscalNumber=" + fiscalNumberFilter() : "");
        searchFilters += (contributionChannelIdFilter() != -1 && contributionChannelIdFilter() != undefined ? "&" + "contributionChannelId=" + contributionChannelIdFilter() : "");

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
                contributionMonetaryList.removeAll();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };

    var advancedSearch = function () {
        getContributionMonetaryListAdvanced();
    };

    var clearSearchFilters = function () {
        nucleoIdFilter(-1);
        responsiblePersonIdFilter(-1);
        documentIdFilter(-1);
        partnerIdFilter(-1);
        contributionDateFromFilter('');
        contributionDateToFilter('');
        amountFilter('');
        contactPersonFilter('');
        ibanOriginFilter('');
        bicSwiftOriginFilter('');
        ibanDestinationFilter('');
        bicSwiftDestinationFilter('');
        fiscalNumberFilter('');
        contributionChannelIdFilter(-1);
    };



    // get list by page

    var getContributionMonetaryPage = function () {
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
                contributionMonetaryList.removeAll();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };



    // delete

    var deleteContributionMonetary = function (contributionMonetary) {
        isLoading(true);
        var restUrl = baseUrl + "Delete/" + contributionMonetary.contributionMonetaryId();
        var jqXHR = $.ajax({
            url: restUrl,
            dataType: "json"
        }).done(function () {
            console.log("Deleted: " + contributionMonetary.contributionMonetaryId());
            contributionMonetaryList.remove(contributionMonetary);
        }).fail(function () {
            console.log("Error");
        }).always(function (data) {
            console.log("finished");
            isLoading(false);
        });
    }

    var deleteContributionMonetaryById = function (contributionMonetaryId) {
        isLoading(true);
        var restUrl = baseUrl + "Delete/" + contributionMonetaryId;
        var jqXHR = $.ajax({
            method: "GET",
            url: restUrl,
            dataType: "json"
        }).done(function () {
            console.log("Deleted: " + contributionMonetaryId);
            //contributionMonetaryList.remove(contributionMonetary);
            // refresh
            getContributionMonetaryList();
        }).fail(function () {
            console.log("Error");
        }).always(function (data) {
            console.log("finished");
            isLoading(false);
        });
    }



    // load

    var load = function (data) {
        contributionMonetaryList.removeAll();
        var underlyingArray = contributionMonetaryList();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var contributionMonetary = new Web.contributionMonetaryViewModel();
            contributionMonetary.load(result);
            underlyingArray.push(contributionMonetary);
        }
        contributionMonetaryList.valueHasMutated();
    };



    // data table

    var updateDatatable = function (data) {
        var dataArray = new Array();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var fieldsInArray = new Array();

            fieldsInArray.push(result.nucleoId);
            fieldsInArray.push(result.responsiblePersonId);
            fieldsInArray.push(result.documentId);
            fieldsInArray.push(result.partnerId);
            fieldsInArray.push(result.contributionDate);
            fieldsInArray.push(result.amount);
            fieldsInArray.push(result.contactPerson);
            fieldsInArray.push(result.ibanOrigin);
            fieldsInArray.push(result.bicSwiftOrigin);
            fieldsInArray.push(result.ibanDestination);
            fieldsInArray.push(result.bicSwiftDestination);
            fieldsInArray.push(result.fiscalNumber);
            fieldsInArray.push(result.contributionChannelId);

            var viewLinkElement = '<a href=\"' + result.editUrl + '\" style=\"margin-right: 10px;\">View</a>';
            var editLinkElement = '<a href=\"' + result.editUrl + '\" style=\"margin-right: 10px;\">Edit</a>';
            var deleteLinkElement = '<a href=\"' + 'javascript:vm.deleteContributionMonetaryById(' + result.contributionMonetaryId + ');' + '\" style=\"margin-right: 10px;\">Delete</a>';
            fieldsInArray.push(viewLinkElement + editLinkElement + deleteLinkElement);

            dataArray.push(fieldsInArray);
        }

        var datatable = $("#ContributionMonetarysTable-" + moduleId).DataTable();
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
        contributionMonetaryList: contributionMonetaryList,
        getContributionMonetaryList: getContributionMonetaryList,
        getContributionMonetaryPage: getContributionMonetaryPage,
        deleteContributionMonetary: deleteContributionMonetary,
        deleteContributionMonetaryById: deleteContributionMonetaryById,
        editMode: editMode,
        isLoading: isLoading,
        searchText: searchText,
        openCreateForm: openCreateForm,
        getContributionMonetaryListAdvanced: getContributionMonetaryListAdvanced,
        advancedSearch: advancedSearch,
        clearSearchFilters: clearSearchFilters,

        nucleoList: nucleoHelper.nucleoList,
        responsiblePersonList: responsiblePersonHelper.responsiblePersonList,
        documentList: documentHelper.documentList,
        partnerList: partnerHelper.partnerList,
        contributionChannelList: contributionChannelHelper.contributionChannelList,

        nucleoIdFilter: nucleoIdFilter,
        responsiblePersonIdFilter: responsiblePersonIdFilter,
        documentIdFilter: documentIdFilter,
        partnerIdFilter: partnerIdFilter,
        contributionDateFromFilter: contributionDateFromFilter,
        contributionDateToFilter: contributionDateToFilter,
        amountFilter: amountFilter,
        contactPersonFilter: contactPersonFilter,
        ibanOriginFilter: ibanOriginFilter,
        bicSwiftOriginFilter: bicSwiftOriginFilter,
        ibanDestinationFilter: ibanDestinationFilter,
        bicSwiftDestinationFilter: bicSwiftDestinationFilter,
        fiscalNumberFilter: fiscalNumberFilter,
        contributionChannelIdFilter: contributionChannelIdFilter,
    }
};



// view model

Web.contributionMonetaryViewModel = function () {
    var contributionMonetaryId = ko.observable(-1);
    var nucleoId = ko.observable(-1);
    var responsiblePersonId = ko.observable(-1);
    var documentId = ko.observable(-1);
    var partnerId = ko.observable(-1);
    var contributionDate = ko.observable('');
    var amount = ko.observable('');
    var contactPerson = ko.observable('');
    var ibanOrigin = ko.observable('');
    var bicSwiftOrigin = ko.observable('');
    var ibanDestination = ko.observable('');
    var bicSwiftDestination = ko.observable('');
    var fiscalNumber = ko.observable('');
    var contributionChannelId = ko.observable(-1);
    var isDeleted = ko.observable('');

    var editUrl = ko.observable('');

    var visibleOnSearch = ko.observable(true);
 
    // load

    var load = function (data) {
        contributionMonetaryId(data.contributionMonetaryId);
        nucleoId(data.nucleoId);
        responsiblePersonId(data.responsiblePersonId);
        documentId(data.documentId);
        partnerId(data.partnerId);
        contributionDate(data.contributionDate);
        amount(data.amount);
        contactPerson(data.contactPerson);
        ibanOrigin(data.ibanOrigin);
        bicSwiftOrigin(data.bicSwiftOrigin);
        ibanDestination(data.ibanDestination);
        bicSwiftDestination(data.bicSwiftDestination);
        fiscalNumber(data.fiscalNumber);
        contributionChannelId(data.contributionChannelId);
        isDeleted(data.isDeleted);
        editUrl(data.editUrl);
    };



    return {
        contributionMonetaryId: contributionMonetaryId,
        nucleoId: nucleoId,
        responsiblePersonId: responsiblePersonId,
        documentId: documentId,
        partnerId: partnerId,
        contributionDate: contributionDate,
        amount: amount,
        contactPerson: contactPerson,
        ibanOrigin: ibanOrigin,
        bicSwiftOrigin: bicSwiftOrigin,
        ibanDestination: ibanDestination,
        bicSwiftDestination: bicSwiftDestination,
        fiscalNumber: fiscalNumber,
        contributionChannelId: contributionChannelId,
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






    