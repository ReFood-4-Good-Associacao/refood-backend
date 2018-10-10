
// ################################################################
//                      Code generated with T4
// ################################################################

var Web = Web || {};

// viewmodel

Web.contributionChannel = function ( contributionChannelId, name, description, active, isDeleted) {
    this.contributionChannelId = ko.observable(contributionChannelId);
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

Web.contributionChannelHelper = function (isLoading, serviceRootUrl, moduleHeaders) {

    var contributionChannelList = ko.observableArray([]);
    var deletedContributionChannelList = ko.observableArray([]);
    var isLoading = isLoading;
    var serviceRootUrl = serviceRootUrl;
    var moduleHeaders = moduleHeaders;
    var searchText = ko.observable('');


    // get

    var getContributionChannelList = function () {
        isLoading(true);

        // need to calculate a different Url for ContributionChannel service
        var restUrl = serviceRootUrl + "api/ContributionChannelApi/GetList/";
        var jqXHR = $.ajax({
            url: restUrl,
            beforeSend: moduleHeaders,
            dataType: "json",
            async: false
        }).done(function (data) {
            if (data) {
                loadContributionChannels(data);
            }
            else {
                clear();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };




    // load

    var loadContributionChannels = function (data) {
        contributionChannelList.removeAll();
        var underlyingArray = contributionChannelList();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var contributionChannel = new Web.contributionChannel
            (
                result.contributionChannelId, 
                result.name, 
                result.description, 
                result.active, 
                result.isDeleted 
            );
            underlyingArray.push(contributionChannel);
        }
        contributionChannelList.valueHasMutated();
    };


    // extract knockout array to simple json objects

    var extractKoArrayToJson = function (data) {
        var simpleArray = new Array();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var contributionChannel = {
                contributionChannelId: result.contributionChannelId(), 
                name: result.name(), 
                description: result.description(), 
                active: result.active(), 
                isDeleted: result.isDeleted() 
            };

            simpleArray.push(contributionChannel);
        }
        return simpleArray;
    };


    // add

    var addContributionChannel = function () {
        var contributionChannel = new Web.contributionChannel(0, '', '', '', '');
        contributionChannelList.push(contributionChannel);
    };


    // remove

    var removeContributionChannel = function (model, event) {
        var contributionChannel = model;
        contributionChannel.isDeleted = true;
        deletedContributionChannelList.push(contributionChannel);
        contributionChannelList.pop(contributionChannel);
    };


    // clear

    var clear = function () {
        contributionChannelList([]);
    };


    // quickSearch

    var quickSearch = function () {
        for (var i = 0; i < contributionChannelList().length; i++) {
            var result = contributionChannelList()[i];

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
        contributionChannelList: contributionChannelList,
        deletedContributionChannelList: deletedContributionChannelList,
        getContributionChannelList: getContributionChannelList,
        loadContributionChannels: loadContributionChannels,
        isLoading: isLoading,
        addContributionChannel: addContributionChannel,
        removeContributionChannel: removeContributionChannel,
        clear: clear,
        searchText: searchText,
        quickSearch: quickSearch,
        extractKoArrayToJson: extractKoArrayToJson
    };
}
    