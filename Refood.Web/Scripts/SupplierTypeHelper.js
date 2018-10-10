
// ################################################################
//                      Code generated with T4
// ################################################################

var Web = Web || {};

// viewmodel

Web.supplierType = function ( supplierTypeId, name, description, active, isDeleted) {
    this.supplierTypeId = ko.observable(supplierTypeId);
    this.name = ko.observable(name);
    this.description = ko.observable(description);
    this.active = ko.observable(active);
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

Web.supplierTypeHelper = function (isLoading, serviceRootUrl, moduleHeaders) {

    var supplierTypeList = ko.observableArray([]);
    var deletedSupplierTypeList = ko.observableArray([]);
    var isLoading = isLoading;
    var serviceRootUrl = serviceRootUrl;
    var moduleHeaders = moduleHeaders;
    var searchText = ko.observable('');


    // get

    var getSupplierTypeList = function () {
        isLoading(true);

        // need to calculate a different Url for SupplierType service
        var restUrl = serviceRootUrl + "api/SupplierTypeApi/GetList/";
        var jqXHR = $.ajax({
            url: restUrl,
            beforeSend: moduleHeaders,
            dataType: "json",
            async: false
        }).done(function (data) {
            if (data) {
                loadSupplierTypes(data);
            }
            else {
                clear();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };




    // load

    var loadSupplierTypes = function (data) {
        supplierTypeList.removeAll();
        var underlyingArray = supplierTypeList();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var supplierType = new Web.supplierType
            (
                result.supplierTypeId, 
                result.name, 
                result.description, 
                result.active, 
                result.isDeleted 
            );
            underlyingArray.push(supplierType);
        }
        supplierTypeList.valueHasMutated();
    };


    // extract knockout array to simple json objects

    var extractKoArrayToJson = function (data) {
        var simpleArray = new Array();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var supplierType = {
                supplierTypeId: result.supplierTypeId(), 
                name: result.name(), 
                description: result.description(), 
                active: result.active(), 
                isDeleted: result.isDeleted() 
            };

            simpleArray.push(supplierType);
        }
        return simpleArray;
    };


    // add

    var addSupplierType = function () {
        var supplierType = new Web.supplierType(0, '', '', '', '');
        supplierTypeList.push(supplierType);
    };


    // remove

    var removeSupplierType = function (model, event) {
        var supplierType = model;
        supplierType.isDeleted = true;
        deletedSupplierTypeList.push(supplierType);
        supplierTypeList.pop(supplierType);
    };


    // clear

    var clear = function () {
        supplierTypeList([]);
    };


    // quickSearch

    var quickSearch = function () {
        for (var i = 0; i < supplierTypeList().length; i++) {
            var result = supplierTypeList()[i];

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
        supplierTypeList: supplierTypeList,
        deletedSupplierTypeList: deletedSupplierTypeList,
        getSupplierTypeList: getSupplierTypeList,
        loadSupplierTypes: loadSupplierTypes,
        isLoading: isLoading,
        addSupplierType: addSupplierType,
        removeSupplierType: removeSupplierType,
        clear: clear,
        searchText: searchText,
        quickSearch: quickSearch,
        extractKoArrayToJson: extractKoArrayToJson
    };
}
    