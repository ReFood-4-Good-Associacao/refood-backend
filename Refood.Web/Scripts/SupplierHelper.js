
// ################################################################
//                      Code generated with T4
// ################################################################

var Web = Web || {};

// viewmodel

Web.supplier = function ( supplierId, name, supplierTypeId, phone, email, latitude, longitude, description, website, addressId, isDeleted) {
    this.supplierId = ko.observable(supplierId);
    this.name = ko.observable(name);
    this.supplierTypeId = ko.observable(supplierTypeId);
    this.phone = ko.observable(phone);
    this.email = ko.observable(email);
    this.latitude = ko.observable(latitude);
    this.longitude = ko.observable(longitude);
    this.description = ko.observable(description);
    this.website = ko.observable(website);
    this.addressId = ko.observable(addressId);
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

Web.supplierHelper = function (isLoading, serviceRootUrl, moduleHeaders) {

    var supplierList = ko.observableArray([]);
    var deletedSupplierList = ko.observableArray([]);
    var isLoading = isLoading;
    var serviceRootUrl = serviceRootUrl;
    var moduleHeaders = moduleHeaders;
    var searchText = ko.observable('');


    // get

    var getSupplierList = function () {
        isLoading(true);

        // need to calculate a different Url for Supplier service
        var restUrl = serviceRootUrl + "api/SupplierApi/GetList";
        var jqXHR = $.ajax({
            url: restUrl,
            beforeSend: moduleHeaders,
            dataType: "json",
            async: false
        }).done(function (data) {
            if (data) {
                loadSuppliers(data);
            }
            else {
                clear();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };




    // load

    var loadSuppliers = function (data) {
        supplierList.removeAll();
        var underlyingArray = supplierList();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var supplier = new Web.supplier
            (
                result.supplierId, 
                result.name, 
                result.supplierTypeId, 
                result.phone, 
                result.email, 
                result.latitude, 
                result.longitude, 
                result.description, 
                result.website, 
                result.addressId, 
                result.isDeleted 
            );
            underlyingArray.push(supplier);
        }
        supplierList.valueHasMutated();
    };


    // extract knockout array to simple json objects

    var extractKoArrayToJson = function (data) {
        var simpleArray = new Array();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var supplier = {
                supplierId: result.supplierId(), 
                name: result.name(), 
                supplierTypeId: result.supplierTypeId(), 
                phone: result.phone(), 
                email: result.email(), 
                latitude: result.latitude(), 
                longitude: result.longitude(), 
                description: result.description(), 
                website: result.website(), 
                addressId: result.addressId(), 
                isDeleted: result.isDeleted() 
            };

            simpleArray.push(supplier);
        }
        return simpleArray;
    };


    // add

    var addSupplier = function () {
        var supplier = new Web.supplier(0, '', '', '', '');
        supplierList.push(supplier);
    };


    // remove

    var removeSupplier = function (model, event) {
        var supplier = model;
        supplier.isDeleted = true;
        deletedSupplierList.push(supplier);
        supplierList.pop(supplier);
    };


    // clear

    var clear = function () {
        supplierList([]);
    };


    // quickSearch

    var quickSearch = function () {
        for (var i = 0; i < supplierList().length; i++) {
            var result = supplierList()[i];

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
        supplierList: supplierList,
        deletedSupplierList: deletedSupplierList,
        getSupplierList: getSupplierList,
        loadSuppliers: loadSuppliers,
        isLoading: isLoading,
        addSupplier: addSupplier,
        removeSupplier: removeSupplier,
        clear: clear,
        searchText: searchText,
        quickSearch: quickSearch,
        extractKoArrayToJson: extractKoArrayToJson
    };
}
    