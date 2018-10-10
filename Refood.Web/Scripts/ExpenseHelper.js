
// ################################################################
//                      Code generated with T4
// ################################################################

var Web = Web || {};

// viewmodel

Web.expense = function ( expenseId, nucleoId, name, description, responsiblePersonId, executerPersonId, documentId, partnerId, invoiceDate, amount, isDeleted) {
    this.expenseId = ko.observable(expenseId);
    this.nucleoId = ko.observable(nucleoId);
    this.name = ko.observable(name);
    this.description = ko.observable(description);
    this.responsiblePersonId = ko.observable(responsiblePersonId);
    this.executerPersonId = ko.observable(executerPersonId);
    this.documentId = ko.observable(documentId);
    this.partnerId = ko.observable(partnerId);
    this.invoiceDate = ko.observable(invoiceDate);
    this.amount = ko.observable(amount);
    this.isDeleted = ko.observable(isDeleted);


    // remove

    this.remove = function (model, event) {
        model.isDeleted(true);
        model.isVisible(false);
    };


    this.visibleOnSearch = ko.observable(true);
    this.isVisible = ko.observable(!isDeleted);
}


// helper

Web.expenseHelper = function (isLoading, serviceRootUrl, moduleHeaders) {

    var expenseList = ko.observableArray([]);
    var deletedExpenseList = ko.observableArray([]);
    var isLoading = isLoading;
    var serviceRootUrl = serviceRootUrl;
    var moduleHeaders = moduleHeaders;
    var searchText = ko.observable('');


    // get

    var getExpenseList = function () {
        isLoading(true);

        // need to calculate a different Url for Expense service
        var restUrl = serviceRootUrl + "api/ExpenseApi/GetList/";
        var jqXHR = $.ajax({
            url: restUrl,
            beforeSend: moduleHeaders,
            dataType: "json",
            async: false
        }).done(function (data) {
            if (data) {
                loadExpenses(data);
            }
            else {
                clear();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };




    // load

    var loadExpenses = function (data) {
        expenseList.removeAll();
        var underlyingArray = expenseList();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var expense = new Web.expense
            (
                result.expenseId, 
                result.nucleoId, 
                result.name, 
                result.description, 
                result.responsiblePersonId, 
                result.executerPersonId, 
                result.documentId, 
                result.partnerId, 
                result.invoiceDate, 
                result.amount, 
                result.isDeleted 
            );
            underlyingArray.push(expense);
        }
        expenseList.valueHasMutated();
    };


    // extract knockout array to simple json objects

    var extractKoArrayToJson = function (data) {
        var simpleArray = new Array();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var expense = {
                expenseId: result.expenseId(), 
                nucleoId: result.nucleoId(), 
                name: result.name(), 
                description: result.description(), 
                responsiblePersonId: result.responsiblePersonId(), 
                executerPersonId: result.executerPersonId(), 
                documentId: result.documentId(), 
                partnerId: result.partnerId(), 
                invoiceDate: result.invoiceDate(), 
                amount: result.amount(), 
                isDeleted: result.isDeleted() 
            };

            simpleArray.push(expense);
        }
        return simpleArray;
    };


    // add

    var addExpense = function () {
        var expense = new Web.expense(0, '', '', '', '');
        expenseList.push(expense);
    };


    // remove

    var removeExpense = function (model, event) {
        var expense = model;
        expense.isDeleted = true;
        deletedExpenseList.push(expense);
        expenseList.pop(expense);
    };


    // clear

    var clear = function () {
        expenseList([]);
    };


    // quickSearch

    var quickSearch = function () {
        for (var i = 0; i < expenseList().length; i++) {
            var result = expenseList()[i];

            if(searchText() == null || searchText() == '' || (result.description() != null && result.description().toLowerCase().indexOf(searchText().toLowerCase()) >= 0))
            {
                result.visibleOnSearch(true);
            }
            else
            {
                result.visibleOnSearch(false);
            }
        }
    };

    $('#searchText').keyup(function() { quickSearch(); });
    

    return {
        expenseList: expenseList,
        deletedExpenseList: deletedExpenseList,
        getExpenseList: getExpenseList,
        loadExpenses: loadExpenses,
        isLoading: isLoading,
        addExpense: addExpense,
        removeExpense: removeExpense,
        clear: clear,
        searchText: searchText,
        quickSearch: quickSearch,
        extractKoArrayToJson: extractKoArrayToJson
    };
}
    