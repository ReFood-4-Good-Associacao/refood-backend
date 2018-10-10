
// ################################################################
//                      Code generated with T4
// ################################################################

var Web = Web || {};

// viewmodel

Web.contributionMonetary = function ( contributionMonetaryId, nucleoId, responsiblePersonId, documentId, partnerId, contributionDate, amount, contactPerson, ibanOrigin, bicSwiftOrigin, ibanDestination, bicSwiftDestination, fiscalNumber, contributionChannelId, isDeleted) {
    this.contributionMonetaryId = ko.observable(contributionMonetaryId);
    this.nucleoId = ko.observable(nucleoId);
    this.responsiblePersonId = ko.observable(responsiblePersonId);
    this.documentId = ko.observable(documentId);
    this.partnerId = ko.observable(partnerId);
    this.contributionDate = ko.observable(contributionDate);
    this.amount = ko.observable(amount);
    this.contactPerson = ko.observable(contactPerson);
    this.ibanOrigin = ko.observable(ibanOrigin);
    this.bicSwiftOrigin = ko.observable(bicSwiftOrigin);
    this.ibanDestination = ko.observable(ibanDestination);
    this.bicSwiftDestination = ko.observable(bicSwiftDestination);
    this.fiscalNumber = ko.observable(fiscalNumber);
    this.contributionChannelId = ko.observable(contributionChannelId);
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

Web.contributionMonetaryHelper = function (isLoading, serviceRootUrl, moduleHeaders) {

    var contributionMonetaryList = ko.observableArray([]);
    var deletedContributionMonetaryList = ko.observableArray([]);
    var isLoading = isLoading;
    var serviceRootUrl = serviceRootUrl;
    var moduleHeaders = moduleHeaders;
    var searchText = ko.observable('');


    // get

    var getContributionMonetaryList = function () {
        isLoading(true);

        // need to calculate a different Url for ContributionMonetary service
        var restUrl = serviceRootUrl + "api/ContributionMonetaryApi/GetList/";
        var jqXHR = $.ajax({
            url: restUrl,
            beforeSend: moduleHeaders,
            dataType: "json",
            async: false
        }).done(function (data) {
            if (data) {
                loadContributionMonetarys(data);
            }
            else {
                clear();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };




    // load

    var loadContributionMonetarys = function (data) {
        contributionMonetaryList.removeAll();
        var underlyingArray = contributionMonetaryList();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var contributionMonetary = new Web.contributionMonetary
            (
                result.contributionMonetaryId, 
                result.nucleoId, 
                result.responsiblePersonId, 
                result.documentId, 
                result.partnerId, 
                result.contributionDate, 
                result.amount, 
                result.contactPerson, 
                result.ibanOrigin, 
                result.bicSwiftOrigin, 
                result.ibanDestination, 
                result.bicSwiftDestination, 
                result.fiscalNumber, 
                result.contributionChannelId, 
                result.isDeleted 
            );
            underlyingArray.push(contributionMonetary);
        }
        contributionMonetaryList.valueHasMutated();
    };


    // extract knockout array to simple json objects

    var extractKoArrayToJson = function (data) {
        var simpleArray = new Array();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var contributionMonetary = {
                contributionMonetaryId: result.contributionMonetaryId(), 
                nucleoId: result.nucleoId(), 
                responsiblePersonId: result.responsiblePersonId(), 
                documentId: result.documentId(), 
                partnerId: result.partnerId(), 
                contributionDate: result.contributionDate(), 
                amount: result.amount(), 
                contactPerson: result.contactPerson(), 
                ibanOrigin: result.ibanOrigin(), 
                bicSwiftOrigin: result.bicSwiftOrigin(), 
                ibanDestination: result.ibanDestination(), 
                bicSwiftDestination: result.bicSwiftDestination(), 
                fiscalNumber: result.fiscalNumber(), 
                contributionChannelId: result.contributionChannelId(), 
                isDeleted: result.isDeleted() 
            };

            simpleArray.push(contributionMonetary);
        }
        return simpleArray;
    };


    // add

    var addContributionMonetary = function () {
        var contributionMonetary = new Web.contributionMonetary(0, '', '', '', '');
        contributionMonetaryList.push(contributionMonetary);
    };


    // remove

    var removeContributionMonetary = function (model, event) {
        var contributionMonetary = model;
        contributionMonetary.isDeleted = true;
        deletedContributionMonetaryList.push(contributionMonetary);
        contributionMonetaryList.pop(contributionMonetary);
    };


    // clear

    var clear = function () {
        contributionMonetaryList([]);
    };


    // quickSearch

    var quickSearch = function () {
        for (var i = 0; i < contributionMonetaryList().length; i++) {
            var result = contributionMonetaryList()[i];

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
        contributionMonetaryList: contributionMonetaryList,
        deletedContributionMonetaryList: deletedContributionMonetaryList,
        getContributionMonetaryList: getContributionMonetaryList,
        loadContributionMonetarys: loadContributionMonetarys,
        isLoading: isLoading,
        addContributionMonetary: addContributionMonetary,
        removeContributionMonetary: removeContributionMonetary,
        clear: clear,
        searchText: searchText,
        quickSearch: quickSearch,
        extractKoArrayToJson: extractKoArrayToJson
    };
}
    