
// ################################################################
//                      Code generated with T4
// ################################################################

var Web = Web || {};

// viewmodel

Web.contributionType = function ( contributionTypeId, name, description, active, isDeleted) {
    this.contributionTypeId = ko.observable(contributionTypeId);
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

Web.contributionTypeHelper = function (isLoading, serviceRootUrl, moduleHeaders) {

    var contributionTypeList = ko.observableArray([]);
    var deletedContributionTypeList = ko.observableArray([]);
    var isLoading = isLoading;
    var serviceRootUrl = serviceRootUrl;
    var moduleHeaders = moduleHeaders;
    var searchText = ko.observable('');


    // get

    var getContributionTypeList = function () {
        isLoading(true);

        // need to calculate a different Url for ContributionType service
        var restUrl = serviceRootUrl + "api/ContributionTypeApi/GetList/";
        var jqXHR = $.ajax({
            url: restUrl,
            beforeSend: moduleHeaders,
            dataType: "json",
            async: false
        }).done(function (data) {
            if (data) {
                loadContributionTypes(data);
            }
            else {
                clear();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };




    // load

    var loadContributionTypes = function (data) {
        contributionTypeList.removeAll();
        var underlyingArray = contributionTypeList();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var contributionType = new Web.contributionType
            (
                result.contributionTypeId, 
                result.name, 
                result.description, 
                result.active, 
                result.isDeleted 
            );
            underlyingArray.push(contributionType);
        }
        contributionTypeList.valueHasMutated();
    };


    // extract knockout array to simple json objects

    var extractKoArrayToJson = function (data) {
        var simpleArray = new Array();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var contributionType = {
                contributionTypeId: result.contributionTypeId(), 
                name: result.name(), 
                description: result.description(), 
                active: result.active(), 
                isDeleted: result.isDeleted() 
            };

            simpleArray.push(contributionType);
        }
        return simpleArray;
    };


    // add

    var addContributionType = function () {
        var contributionType = new Web.contributionType(0, '', '', '', '');
        contributionTypeList.push(contributionType);
    };


    // remove

    var removeContributionType = function (model, event) {
        var contributionType = model;
        contributionType.isDeleted = true;
        deletedContributionTypeList.push(contributionType);
        contributionTypeList.pop(contributionType);
    };


    // clear

    var clear = function () {
        contributionTypeList([]);
    };


    // quickSearch

    var quickSearch = function () {
        for (var i = 0; i < contributionTypeList().length; i++) {
            var result = contributionTypeList()[i];

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
        contributionTypeList: contributionTypeList,
        deletedContributionTypeList: deletedContributionTypeList,
        getContributionTypeList: getContributionTypeList,
        loadContributionTypes: loadContributionTypes,
        isLoading: isLoading,
        addContributionType: addContributionType,
        removeContributionType: removeContributionType,
        clear: clear,
        searchText: searchText,
        quickSearch: quickSearch,
        extractKoArrayToJson: extractKoArrayToJson
    };
}
    