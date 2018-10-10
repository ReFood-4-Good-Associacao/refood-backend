
// ################################################################
//                      Code generated with T4
// ################################################################

var Web = Web || {};

// viewmodel

Web.beneficiary = function ( beneficiaryId, name, number, addressId, numberOfAdults, numberOfChildren, numberOfTupperware, numberOfSoups, description, active, isDeleted) {
    this.beneficiaryId = ko.observable(beneficiaryId);
    this.name = ko.observable(name);
    this.number = ko.observable(number);
    this.addressId = ko.observable(addressId);
    this.numberOfAdults = ko.observable(numberOfAdults);
    this.numberOfChildren = ko.observable(numberOfChildren);
    this.numberOfTupperware = ko.observable(numberOfTupperware);
    this.numberOfSoups = ko.observable(numberOfSoups);
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

Web.beneficiaryHelper = function (isLoading, serviceRootUrl, moduleHeaders) {

    var beneficiaryList = ko.observableArray([]);
    var deletedBeneficiaryList = ko.observableArray([]);
    var isLoading = isLoading;
    var serviceRootUrl = serviceRootUrl;
    var moduleHeaders = moduleHeaders;
    var searchText = ko.observable('');


    // get

    var getBeneficiaryList = function () {
        isLoading(true);

        // need to calculate a different Url for Beneficiary service
        var restUrl = serviceRootUrl + "api/BeneficiaryApi/GetList/";
        var jqXHR = $.ajax({
            url: restUrl,
            beforeSend: moduleHeaders,
            dataType: "json",
            async: false
        }).done(function (data) {
            if (data) {
                loadBeneficiarys(data);
            }
            else {
                clear();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };




    // load

    var loadBeneficiarys = function (data) {
        beneficiaryList.removeAll();
        var underlyingArray = beneficiaryList();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var beneficiary = new Web.beneficiary
            (
                result.beneficiaryId, 
                result.name, 
                result.number, 
                result.addressId, 
                result.numberOfAdults, 
                result.numberOfChildren, 
                result.numberOfTupperware, 
                result.numberOfSoups, 
                result.description, 
                result.active, 
                result.isDeleted 
            );
            underlyingArray.push(beneficiary);
        }
        beneficiaryList.valueHasMutated();
    };


    // extract knockout array to simple json objects

    var extractKoArrayToJson = function (data) {
        var simpleArray = new Array();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var beneficiary = {
                beneficiaryId: result.beneficiaryId(), 
                name: result.name(), 
                number: result.number(), 
                addressId: result.addressId(), 
                numberOfAdults: result.numberOfAdults(), 
                numberOfChildren: result.numberOfChildren(), 
                numberOfTupperware: result.numberOfTupperware(), 
                numberOfSoups: result.numberOfSoups(), 
                description: result.description(), 
                active: result.active(), 
                isDeleted: result.isDeleted() 
            };

            simpleArray.push(beneficiary);
        }
        return simpleArray;
    };


    // add

    var addBeneficiary = function () {
        var beneficiary = new Web.beneficiary(0, '', '', '', '');
        beneficiaryList.push(beneficiary);
    };


    // remove

    var removeBeneficiary = function (model, event) {
        var beneficiary = model;
        beneficiary.isDeleted = true;
        deletedBeneficiaryList.push(beneficiary);
        beneficiaryList.pop(beneficiary);
    };


    // clear

    var clear = function () {
        beneficiaryList([]);
    };


    // quickSearch

    var quickSearch = function () {
        for (var i = 0; i < beneficiaryList().length; i++) {
            var result = beneficiaryList()[i];

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
        beneficiaryList: beneficiaryList,
        deletedBeneficiaryList: deletedBeneficiaryList,
        getBeneficiaryList: getBeneficiaryList,
        loadBeneficiarys: loadBeneficiarys,
        isLoading: isLoading,
        addBeneficiary: addBeneficiary,
        removeBeneficiary: removeBeneficiary,
        clear: clear,
        searchText: searchText,
        quickSearch: quickSearch,
        extractKoArrayToJson: extractKoArrayToJson
    };
}
    