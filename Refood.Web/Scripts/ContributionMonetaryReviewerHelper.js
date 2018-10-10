
// ################################################################
//                      Code generated with T4
// ################################################################

var Web = Web || {};

// viewmodel

Web.contributionMonetaryReviewer = function ( contributionMonetaryReviewerId, volunteerId, isDeleted) {
    this.contributionMonetaryReviewerId = ko.observable(contributionMonetaryReviewerId);
    this.volunteerId = ko.observable(volunteerId);
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

Web.contributionMonetaryReviewerHelper = function (isLoading, serviceRootUrl, moduleHeaders) {

    var contributionMonetaryReviewerList = ko.observableArray([]);
    var deletedContributionMonetaryReviewerList = ko.observableArray([]);
    var isLoading = isLoading;
    var serviceRootUrl = serviceRootUrl;
    var moduleHeaders = moduleHeaders;
    var searchText = ko.observable('');


    // get

    var getContributionMonetaryReviewerList = function () {
        isLoading(true);

        // need to calculate a different Url for ContributionMonetaryReviewer service
        var restUrl = serviceRootUrl + "api/ContributionMonetaryReviewerApi/GetList/";
        var jqXHR = $.ajax({
            url: restUrl,
            beforeSend: moduleHeaders,
            dataType: "json",
            async: false
        }).done(function (data) {
            if (data) {
                loadContributionMonetaryReviewers(data);
            }
            else {
                clear();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };




    // load

    var loadContributionMonetaryReviewers = function (data) {
        contributionMonetaryReviewerList.removeAll();
        var underlyingArray = contributionMonetaryReviewerList();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var contributionMonetaryReviewer = new Web.contributionMonetaryReviewer
            (
                result.contributionMonetaryReviewerId, 
                result.volunteerId, 
                result.isDeleted 
            );
            underlyingArray.push(contributionMonetaryReviewer);
        }
        contributionMonetaryReviewerList.valueHasMutated();
    };


    // extract knockout array to simple json objects

    var extractKoArrayToJson = function (data) {
        var simpleArray = new Array();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var contributionMonetaryReviewer = {
                contributionMonetaryReviewerId: result.contributionMonetaryReviewerId(), 
                volunteerId: result.volunteerId(), 
                isDeleted: result.isDeleted() 
            };

            simpleArray.push(contributionMonetaryReviewer);
        }
        return simpleArray;
    };


    // add

    var addContributionMonetaryReviewer = function () {
        var contributionMonetaryReviewer = new Web.contributionMonetaryReviewer(0, '', '', '', '');
        contributionMonetaryReviewerList.push(contributionMonetaryReviewer);
    };


    // remove

    var removeContributionMonetaryReviewer = function (model, event) {
        var contributionMonetaryReviewer = model;
        contributionMonetaryReviewer.isDeleted = true;
        deletedContributionMonetaryReviewerList.push(contributionMonetaryReviewer);
        contributionMonetaryReviewerList.pop(contributionMonetaryReviewer);
    };


    // clear

    var clear = function () {
        contributionMonetaryReviewerList([]);
    };


    // quickSearch

    var quickSearch = function () {
        for (var i = 0; i < contributionMonetaryReviewerList().length; i++) {
            var result = contributionMonetaryReviewerList()[i];

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
        contributionMonetaryReviewerList: contributionMonetaryReviewerList,
        deletedContributionMonetaryReviewerList: deletedContributionMonetaryReviewerList,
        getContributionMonetaryReviewerList: getContributionMonetaryReviewerList,
        loadContributionMonetaryReviewers: loadContributionMonetaryReviewers,
        isLoading: isLoading,
        addContributionMonetaryReviewer: addContributionMonetaryReviewer,
        removeContributionMonetaryReviewer: removeContributionMonetaryReviewer,
        clear: clear,
        searchText: searchText,
        quickSearch: quickSearch,
        extractKoArrayToJson: extractKoArrayToJson
    };
}
    