
// ################################################################
//                      Code generated with T4
// ################################################################

var Web = Web || {};

// viewmodel

Web.nucleo = function ( nucleoId, name, personResponsible, photo, addressId, openingDate, primaryPhoneNumber, primaryEmail, active, isDeleted) {
    this.nucleoId = ko.observable(nucleoId);
    this.name = ko.observable(name);
    this.personResponsible = ko.observable(personResponsible);
    this.photo = ko.observable(photo);
    this.addressId = ko.observable(addressId);
    this.openingDate = ko.observable(openingDate);
    this.primaryPhoneNumber = ko.observable(primaryPhoneNumber);
    this.primaryEmail = ko.observable(primaryEmail);
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

Web.nucleoHelper = function (isLoading, serviceRootUrl, moduleHeaders) {

    var nucleoList = ko.observableArray([]);
    var deletedNucleoList = ko.observableArray([]);
    var isLoading = isLoading;
    var serviceRootUrl = serviceRootUrl;
    var moduleHeaders = moduleHeaders;
    var searchText = ko.observable('');


    // get

    var getNucleoList = function () {
        isLoading(true);

        // need to calculate a different Url for Nucleo service
        var restUrl = serviceRootUrl + "api/NucleoApi/GetList/";
        var jqXHR = $.ajax({
            url: restUrl,
            beforeSend: moduleHeaders,
            dataType: "json",
            async: false
        }).done(function (data) {
            if (data) {
                loadNucleos(data);
            }
            else {
                clear();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };




    // load

    var loadNucleos = function (data) {
        nucleoList.removeAll();
        var underlyingArray = nucleoList();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var nucleo = new Web.nucleo
            (
                result.nucleoId, 
                result.name, 
                result.personResponsible, 
                result.photo, 
                result.addressId, 
                result.openingDate, 
                result.primaryPhoneNumber, 
                result.primaryEmail, 
                result.active, 
                result.isDeleted 
            );
            underlyingArray.push(nucleo);
        }
        nucleoList.valueHasMutated();
    };


    // extract knockout array to simple json objects

    var extractKoArrayToJson = function (data) {
        var simpleArray = new Array();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var nucleo = {
                nucleoId: result.nucleoId(), 
                name: result.name(), 
                personResponsible: result.personResponsible(), 
                photo: result.photo(), 
                addressId: result.addressId(), 
                openingDate: result.openingDate(), 
                primaryPhoneNumber: result.primaryPhoneNumber(), 
                primaryEmail: result.primaryEmail(), 
                active: result.active(), 
                isDeleted: result.isDeleted() 
            };

            simpleArray.push(nucleo);
        }
        return simpleArray;
    };


    // add

    var addNucleo = function () {
        var nucleo = new Web.nucleo(0, '', '', '', '');
        nucleoList.push(nucleo);
    };


    // remove

    var removeNucleo = function (model, event) {
        var nucleo = model;
        nucleo.isDeleted = true;
        deletedNucleoList.push(nucleo);
        nucleoList.pop(nucleo);
    };


    // clear

    var clear = function () {
        nucleoList([]);
    };


    // quickSearch

    var quickSearch = function () {
        for (var i = 0; i < nucleoList().length; i++) {
            var result = nucleoList()[i];

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
        nucleoList: nucleoList,
        deletedNucleoList: deletedNucleoList,
        getNucleoList: getNucleoList,
        loadNucleos: loadNucleos,
        isLoading: isLoading,
        addNucleo: addNucleo,
        removeNucleo: removeNucleo,
        clear: clear,
        searchText: searchText,
        quickSearch: quickSearch,
        extractKoArrayToJson: extractKoArrayToJson
    };
}
    