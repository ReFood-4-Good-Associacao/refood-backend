
// ################################################################
//                      Code generated with T4
// ################################################################

var Web = Web || {};

Web.expenseListViewModel = function (moduleId, resx) {
    var baseUrl = "api/ExpenseApi/";

    var isLoading = ko.observable(false);
    var expenseList = ko.observableArray([]);
    var editMode = ko.computed(function () {
        return expenseList().length > 0 && expenseList()[0].editUrl() != null && expenseList()[0].editUrl().length > 0;
    });
    var searchText = ko.observable('');



    // filters

    var nucleoIdFilter = ko.observable(-1);
    var nameFilter = ko.observable('');
    var descriptionFilter = ko.observable('');
    var responsiblePersonIdFilter = ko.observable(-1);
    var executerPersonIdFilter = ko.observable(-1);
    var documentIdFilter = ko.observable(-1);
    var partnerIdFilter = ko.observable(-1);
    var invoiceDateFromFilter = ko.observable('');
    var invoiceDateToFilter = ko.observable('');
    var amountFilter = ko.observable('');



    // helpers

    var nucleoHelper = Web.nucleoHelper(isLoading, '/', function(){});
    var responsiblePersonHelper = Web.responsiblePersonHelper(isLoading, '/', function(){});
    var executerPersonHelper = Web.executerPersonHelper(isLoading, '/', function(){});
    var documentHelper = Web.documentHelper(isLoading, '/', function(){});
    var partnerHelper = Web.partnerHelper(isLoading, '/', function(){});



    // init

    var init = function () {
        //getExpenseList();
        //getExpensePage();
        getExpenseListAdvanced();

        nucleoHelper.getNucleoList();
        responsiblePersonHelper.getResponsiblePersonList();
        executerPersonHelper.getExecuterPersonList();
        documentHelper.getDocumentList();
        partnerHelper.getPartnerList();
    }



    // get list

    var getExpenseList = function () {
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
                expenseList.removeAll();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };



    // get list - advanced search

    var getExpenseListAdvanced = function () {
        isLoading(true);

        var searchFilters = "?";
        searchFilters += (nucleoIdFilter() != -1 && nucleoIdFilter() != undefined ? "&" + "nucleoId=" + nucleoIdFilter() : "");
        searchFilters += (nameFilter() != '' ? "name=" + nameFilter() : "");
        searchFilters += (descriptionFilter() != '' ? "description=" + descriptionFilter() : "");
        searchFilters += (responsiblePersonIdFilter() != -1 && responsiblePersonIdFilter() != undefined ? "&" + "responsiblePersonId=" + responsiblePersonIdFilter() : "");
        searchFilters += (executerPersonIdFilter() != -1 && executerPersonIdFilter() != undefined ? "&" + "executerPersonId=" + executerPersonIdFilter() : "");
        searchFilters += (documentIdFilter() != -1 && documentIdFilter() != undefined ? "&" + "documentId=" + documentIdFilter() : "");
        searchFilters += (partnerIdFilter() != -1 && partnerIdFilter() != undefined ? "&" + "partnerId=" + partnerIdFilter() : "");
        searchFilters += (invoiceDateFromFilter() != '' && invoiceDateFromFilter() != null ? "&" + "invoiceDateFrom=" + dateToStringServerFormat(invoiceDateFromFilter()) : "");
        searchFilters += (invoiceDateToFilter() != '' && invoiceDateToFilter() != null ? "&" + "invoiceDateTo=" + dateToStringServerFormat(invoiceDateToFilter()) : "");
        searchFilters += (amountFilter() != '' ? "amount=" + amountFilter() : "");

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
                expenseList.removeAll();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };

    var advancedSearch = function () {
        getExpenseListAdvanced();
    };

    var clearSearchFilters = function () {
        nucleoIdFilter(-1);
        nameFilter('');
        descriptionFilter('');
        responsiblePersonIdFilter(-1);
        executerPersonIdFilter(-1);
        documentIdFilter(-1);
        partnerIdFilter(-1);
        invoiceDateFromFilter('');
        invoiceDateToFilter('');
        amountFilter('');
    };



    // get list by page

    var getExpensePage = function () {
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
                expenseList.removeAll();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };



    // delete

    var deleteExpense = function (expense) {
        isLoading(true);
        var restUrl = baseUrl + "Delete/" + expense.expenseId();
        var jqXHR = $.ajax({
            url: restUrl,
            dataType: "json"
        }).done(function () {
            console.log("Deleted: " + expense.expenseId());
            expenseList.remove(expense);
        }).fail(function () {
            console.log("Error");
        }).always(function (data) {
            console.log("finished");
            isLoading(false);
        });
    }

    var deleteExpenseById = function (expenseId) {
        isLoading(true);
        var restUrl = baseUrl + "Delete/" + expenseId;
        var jqXHR = $.ajax({
            method: "GET",
            url: restUrl,
            dataType: "json"
        }).done(function () {
            console.log("Deleted: " + expenseId);
            //expenseList.remove(expense);
            // refresh
            getExpenseList();
        }).fail(function () {
            console.log("Error");
        }).always(function (data) {
            console.log("finished");
            isLoading(false);
        });
    }



    // load

    var load = function (data) {
        expenseList.removeAll();
        var underlyingArray = expenseList();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var expense = new Web.expenseViewModel();
            expense.load(result);
            underlyingArray.push(expense);
        }
        expenseList.valueHasMutated();
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
            fieldsInArray.push(result.executerPersonId);
            fieldsInArray.push(result.documentId);
            fieldsInArray.push(result.partnerId);
            fieldsInArray.push(result.invoiceDate);
            fieldsInArray.push(result.amount);

            var viewLinkElement = '<a href=\"' + result.editUrl + '\" style=\"margin-right: 10px;\">View</a>';
            var editLinkElement = '<a href=\"' + result.editUrl + '\" style=\"margin-right: 10px;\">Edit</a>';
            var deleteLinkElement = '<a href=\"' + 'javascript:vm.deleteExpenseById(' + result.expenseId + ');' + '\" style=\"margin-right: 10px;\">Delete</a>';
            fieldsInArray.push(viewLinkElement + editLinkElement + deleteLinkElement);

            dataArray.push(fieldsInArray);
        }

        var datatable = $("#ExpensesTable-" + moduleId).DataTable();
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
        expenseList: expenseList,
        getExpenseList: getExpenseList,
        getExpensePage: getExpensePage,
        deleteExpense: deleteExpense,
        deleteExpenseById: deleteExpenseById,
        editMode: editMode,
        isLoading: isLoading,
        searchText: searchText,
        openCreateForm: openCreateForm,
        getExpenseListAdvanced: getExpenseListAdvanced,
        advancedSearch: advancedSearch,
        clearSearchFilters: clearSearchFilters,

        nucleoList: nucleoHelper.nucleoList,
        responsiblePersonList: responsiblePersonHelper.responsiblePersonList,
        executerPersonList: executerPersonHelper.executerPersonList,
        documentList: documentHelper.documentList,
        partnerList: partnerHelper.partnerList,

        nucleoIdFilter: nucleoIdFilter,
        nameFilter: nameFilter,
        descriptionFilter: descriptionFilter,
        responsiblePersonIdFilter: responsiblePersonIdFilter,
        executerPersonIdFilter: executerPersonIdFilter,
        documentIdFilter: documentIdFilter,
        partnerIdFilter: partnerIdFilter,
        invoiceDateFromFilter: invoiceDateFromFilter,
        invoiceDateToFilter: invoiceDateToFilter,
        amountFilter: amountFilter,
    }
};



// view model

Web.expenseViewModel = function () {
    var expenseId = ko.observable(-1);
    var nucleoId = ko.observable(-1);
    var name = ko.observable('');
    var description = ko.observable('');
    var responsiblePersonId = ko.observable(-1);
    var executerPersonId = ko.observable(-1);
    var documentId = ko.observable(-1);
    var partnerId = ko.observable(-1);
    var invoiceDate = ko.observable('');
    var amount = ko.observable('');
    var isDeleted = ko.observable('');

    var editUrl = ko.observable('');

    var visibleOnSearch = ko.observable(true);
 
    // load

    var load = function (data) {
        expenseId(data.expenseId);
        nucleoId(data.nucleoId);
        name(data.name);
        description(data.description);
        responsiblePersonId(data.responsiblePersonId);
        executerPersonId(data.executerPersonId);
        documentId(data.documentId);
        partnerId(data.partnerId);
        invoiceDate(data.invoiceDate);
        amount(data.amount);
        isDeleted(data.isDeleted);
        editUrl(data.editUrl);
    };



    return {
        expenseId: expenseId,
        nucleoId: nucleoId,
        name: name,
        description: description,
        responsiblePersonId: responsiblePersonId,
        executerPersonId: executerPersonId,
        documentId: documentId,
        partnerId: partnerId,
        invoiceDate: invoiceDate,
        amount: amount,
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






    