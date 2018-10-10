
// ################################################################
//                      Code generated with T4
// ################################################################

var Web = Web || {};

// viewmodel

Web.district = function ( districtId, countryId, name, code, latitude, longitude, active, isDeleted) {
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

Web.districtHelper = function (isLoading, serviceRootUrl, moduleHeaders) {

    var districtList = ko.observableArray([]);
    var deletedDistrictList = ko.observableArray([]);
    var isLoading = isLoading;
    var serviceRootUrl = serviceRootUrl;
    var moduleHeaders = moduleHeaders;
    var searchText = ko.observable('');


    // get

    var getDistrictList = function () {
        isLoading(true);

        // need to calculate a different Url for District service
        var restUrl = serviceRootUrl + "api/DistrictApi/GetList/";
        var jqXHR = $.ajax({
            url: restUrl,
            beforeSend: moduleHeaders,
            dataType: "json",
            async: false
        }).done(function (data) {
            if (data) {
                loadDistricts(data);
            }
            else {
                clear();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };




    // load

    var loadDistricts = function (data) {
        districtList.removeAll();
        var underlyingArray = districtList();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var district = new Web.district
            (
                result.districtId, 
                result.countryId, 
                result.name, 
                result.code, 
                result.latitude, 
                result.longitude, 
                result.active, 
                result.isDeleted 
            );
            underlyingArray.push(district);
        }
        districtList.valueHasMutated();
    };


    // extract knockout array to simple json objects

    var extractKoArrayToJson = function (data) {
        var simpleArray = new Array();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var district = {
                districtId: result.districtId(), 
                countryId: result.countryId(), 
                name: result.name(), 
                code: result.code(), 
                latitude: result.latitude(), 
                longitude: result.longitude(), 
                active: result.active(), 
                isDeleted: result.isDeleted() 
            };

            simpleArray.push(district);
        }
        return simpleArray;
    };


    // add

    var addDistrict = function () {
        var district = new Web.district(0, '', '', '', '');
        districtList.push(district);
    };


    // remove

    var removeDistrict = function (model, event) {
        var district = model;
        district.isDeleted = true;
        deletedDistrictList.push(district);
        districtList.pop(district);
    };


    // clear

    var clear = function () {
        districtList([]);
    };


    // quickSearch

    var quickSearch = function () {
        for (var i = 0; i < districtList().length; i++) {
            var result = districtList()[i];

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
        districtList: districtList,
        deletedDistrictList: deletedDistrictList,
        getDistrictList: getDistrictList,
        loadDistricts: loadDistricts,
        isLoading: isLoading,
        addDistrict: addDistrict,
        removeDistrict: removeDistrict,
        clear: clear,
        searchText: searchText,
        quickSearch: quickSearch,
        extractKoArrayToJson: extractKoArrayToJson
    };
}
    