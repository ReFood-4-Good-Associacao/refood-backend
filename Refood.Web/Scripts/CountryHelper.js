
// ################################################################
//                      Code generated with T4
// ################################################################

var Web = Web || {};

// viewmodel

Web.country = function ( countryId, name, englishName, isoCode, capitalCity, latitude, longitude, phonePrefix, active, isDeleted) {
    this.countryId = ko.observable(countryId);
    this.name = ko.observable(name);
    this.englishName = ko.observable(englishName);
    this.isoCode = ko.observable(isoCode);
    this.capitalCity = ko.observable(capitalCity);
    this.latitude = ko.observable(latitude);
    this.longitude = ko.observable(longitude);
    this.phonePrefix = ko.observable(phonePrefix);
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

Web.countryHelper = function (isLoading, serviceRootUrl, moduleHeaders) {

    var countryList = ko.observableArray([]);
    var deletedCountryList = ko.observableArray([]);
    var isLoading = isLoading;
    var serviceRootUrl = serviceRootUrl;
    var moduleHeaders = moduleHeaders;
    var searchText = ko.observable('');


    // get

    var getCountryList = function () {
        isLoading(true);

        // need to calculate a different Url for Country service
        var restUrl = serviceRootUrl + "api/CountryApi/GetList/";
        var jqXHR = $.ajax({
            url: restUrl,
            beforeSend: moduleHeaders,
            dataType: "json",
            async: false
        }).done(function (data) {
            if (data) {
                loadCountrys(data);
            }
            else {
                clear();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };




    // load

    var loadCountrys = function (data) {
        countryList.removeAll();
        var underlyingArray = countryList();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var country = new Web.country
            (
                result.countryId, 
                result.name, 
                result.englishName, 
                result.isoCode, 
                result.capitalCity, 
                result.latitude, 
                result.longitude, 
                result.phonePrefix, 
                result.active, 
                result.isDeleted 
            );
            underlyingArray.push(country);
        }
        countryList.valueHasMutated();
    };


    // extract knockout array to simple json objects

    var extractKoArrayToJson = function (data) {
        var simpleArray = new Array();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var country = {
                countryId: result.countryId(), 
                name: result.name(), 
                englishName: result.englishName(), 
                isoCode: result.isoCode(), 
                capitalCity: result.capitalCity(), 
                latitude: result.latitude(), 
                longitude: result.longitude(), 
                phonePrefix: result.phonePrefix(), 
                active: result.active(), 
                isDeleted: result.isDeleted() 
            };

            simpleArray.push(country);
        }
        return simpleArray;
    };


    // add

    var addCountry = function () {
        var country = new Web.country(0, '', '', '', '');
        countryList.push(country);
    };


    // remove

    var removeCountry = function (model, event) {
        var country = model;
        country.isDeleted = true;
        deletedCountryList.push(country);
        countryList.pop(country);
    };


    // clear

    var clear = function () {
        countryList([]);
    };


    // quickSearch

    var quickSearch = function () {
        for (var i = 0; i < countryList().length; i++) {
            var result = countryList()[i];

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
        countryList: countryList,
        deletedCountryList: deletedCountryList,
        getCountryList: getCountryList,
        loadCountrys: loadCountrys,
        isLoading: isLoading,
        addCountry: addCountry,
        removeCountry: removeCountry,
        clear: clear,
        searchText: searchText,
        quickSearch: quickSearch,
        extractKoArrayToJson: extractKoArrayToJson
    };
}
    