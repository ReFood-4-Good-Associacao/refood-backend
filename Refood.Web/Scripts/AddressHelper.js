
// ################################################################
//                      Code generated with T4
// ################################################################

var Web = Web || {};

// viewmodel

Web.address = function ( addressId, name, addressFirstLine, addressSecondLine, countryId, districtId, countyId, parishId, zipCode, latitude, longitude, active, isDeleted) {
    this.addressId = ko.observable(addressId);
    this.name = ko.observable(name);
    this.addressFirstLine = ko.observable(addressFirstLine);
    this.addressSecondLine = ko.observable(addressSecondLine);
    this.countryId = ko.observable(countryId);
    this.districtId = ko.observable(districtId);
    this.countyId = ko.observable(countyId);
    this.parishId = ko.observable(parishId);
    this.zipCode = ko.observable(zipCode);
    this.latitude = ko.observable(latitude);
    this.longitude = ko.observable(longitude);
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

Web.addressHelper = function (isLoading, serviceRootUrl, moduleHeaders) {

    var addressList = ko.observableArray([]);
    var deletedAddressList = ko.observableArray([]);
    var isLoading = isLoading;
    var serviceRootUrl = serviceRootUrl;
    var moduleHeaders = moduleHeaders;
    var searchText = ko.observable('');


    // get

    var getAddressList = function () {
        isLoading(true);

        // need to calculate a different Url for Address service
        var restUrl = serviceRootUrl + "Address/GetList/";
        var jqXHR = $.ajax({
            url: restUrl,
            beforeSend: moduleHeaders,
            dataType: "json",
            async: false
        }).done(function (data) {
            if (data) {
                loadAddresss(data);
            }
            else {
                clear();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };




    // load

    var loadAddresss = function (data) {
        addressList.removeAll();
        var underlyingArray = addressList();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var address = new Web.address
            (
                result.addressId, 
                result.name, 
                result.addressFirstLine, 
                result.addressSecondLine, 
                result.countryId, 
                result.districtId, 
                result.countyId, 
                result.parishId, 
                result.zipCode, 
                result.latitude, 
                result.longitude, 
                result.active, 
                result.isDeleted 
            );
            underlyingArray.push(address);
        }
        addressList.valueHasMutated();
    };


    // extract knockout array to simple json objects

    var extractKoArrayToJson = function (data) {
        var simpleArray = new Array();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var address = {
                addressId: result.addressId(), 
                name: result.name(), 
                addressFirstLine: result.addressFirstLine(), 
                addressSecondLine: result.addressSecondLine(), 
                countryId: result.countryId(), 
                districtId: result.districtId(), 
                countyId: result.countyId(), 
                parishId: result.parishId(), 
                zipCode: result.zipCode(), 
                latitude: result.latitude(), 
                longitude: result.longitude(), 
                active: result.active(), 
                isDeleted: result.isDeleted() 
            };

            simpleArray.push(address);
        }
        return simpleArray;
    };


    // add

    var addAddress = function () {
        var address = new Web.address(0, '', '', '', '');
        addressList.push(address);
    };


    // remove

    var removeAddress = function (model, event) {
        var address = model;
        address.isDeleted = true;
        deletedAddressList.push(address);
        addressList.pop(address);
    };


    // clear

    var clear = function () {
        addressList([]);
    };


    // quickSearch

    var quickSearch = function () {
        for (var i = 0; i < addressList().length; i++) {
            var result = addressList()[i];

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
        addressList: addressList,
        deletedAddressList: deletedAddressList,
        getAddressList: getAddressList,
        loadAddresss: loadAddresss,
        isLoading: isLoading,
        addAddress: addAddress,
        removeAddress: removeAddress,
        clear: clear,
        searchText: searchText,
        quickSearch: quickSearch,
        extractKoArrayToJson: extractKoArrayToJson
    };
}
    