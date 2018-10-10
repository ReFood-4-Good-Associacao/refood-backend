
// ################################################################
//                      Code generated with T4
// ################################################################

var Web = Web || {};

// viewmodel

Web.parish = function ( parishId, countyId, districtId, countryId, name, code, latitude, longitude, active, isDeleted) {
    this.parishId = ko.observable(parishId);
    this.countyId = ko.observable(countyId);
    this.districtId = ko.observable(districtId);
    this.countryId = ko.observable(countryId);
    this.name = ko.observable(name);
    this.code = ko.observable(code);
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

Web.parishHelper = function (isLoading, serviceRootUrl, moduleHeaders) {

    var parishList = ko.observableArray([]);
    var deletedParishList = ko.observableArray([]);
    var isLoading = isLoading;
    var serviceRootUrl = serviceRootUrl;
    var moduleHeaders = moduleHeaders;
    var searchText = ko.observable('');


    // get

    var getParishList = function () {
        isLoading(true);

        // need to calculate a different Url for Parish service
        var restUrl = serviceRootUrl + "api/ParishApi/GetList/";
        var jqXHR = $.ajax({
            url: restUrl,
            beforeSend: moduleHeaders,
            dataType: "json",
            async: false
        }).done(function (data) {
            if (data) {
                loadParishs(data);
            }
            else {
                clear();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };




    // load

    var loadParishs = function (data) {
        parishList.removeAll();
        var underlyingArray = parishList();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var parish = new Web.parish
            (
                result.parishId, 
                result.countyId, 
                result.districtId, 
                result.countryId, 
                result.name, 
                result.code, 
                result.latitude, 
                result.longitude, 
                result.active, 
                result.isDeleted 
            );
            underlyingArray.push(parish);
        }
        parishList.valueHasMutated();
    };


    // extract knockout array to simple json objects

    var extractKoArrayToJson = function (data) {
        var simpleArray = new Array();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var parish = {
                parishId: result.parishId(), 
                countyId: result.countyId(), 
                districtId: result.districtId(), 
                countryId: result.countryId(), 
                name: result.name(), 
                code: result.code(), 
                latitude: result.latitude(), 
                longitude: result.longitude(), 
                active: result.active(), 
                isDeleted: result.isDeleted() 
            };

            simpleArray.push(parish);
        }
        return simpleArray;
    };


    // add

    var addParish = function () {
        var parish = new Web.parish(0, '', '', '', '');
        parishList.push(parish);
    };


    // remove

    var removeParish = function (model, event) {
        var parish = model;
        parish.isDeleted = true;
        deletedParishList.push(parish);
        parishList.pop(parish);
    };


    // clear

    var clear = function () {
        parishList([]);
    };


    // quickSearch

    var quickSearch = function () {
        for (var i = 0; i < parishList().length; i++) {
            var result = parishList()[i];

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
        parishList: parishList,
        deletedParishList: deletedParishList,
        getParishList: getParishList,
        loadParishs: loadParishs,
        isLoading: isLoading,
        addParish: addParish,
        removeParish: removeParish,
        clear: clear,
        searchText: searchText,
        quickSearch: quickSearch,
        extractKoArrayToJson: extractKoArrayToJson
    };
}
    