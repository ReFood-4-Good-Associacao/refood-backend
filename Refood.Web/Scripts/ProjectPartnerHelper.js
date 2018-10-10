
// ################################################################
//                      Code generated with T4
// ################################################################

var Web = Web || {};

// viewmodel

Web.projectPartner = function ( projectPartnerId, projectId, partnerId, grantValue, isDeleted) {
    this.projectPartnerId = ko.observable(projectPartnerId);
    this.projectId = ko.observable(projectId);
    this.partnerId = ko.observable(partnerId);
    this.grantValue = ko.observable(grantValue);
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

Web.projectPartnerHelper = function (isLoading, serviceRootUrl, moduleHeaders) {

    var projectPartnerList = ko.observableArray([]);
    var deletedProjectPartnerList = ko.observableArray([]);
    var isLoading = isLoading;
    var serviceRootUrl = serviceRootUrl;
    var moduleHeaders = moduleHeaders;
    var searchText = ko.observable('');


    // get

    var getProjectPartnerList = function () {
        isLoading(true);

        // need to calculate a different Url for ProjectPartner service
        var restUrl = serviceRootUrl + "api/ProjectPartnerApi/GetList/";
        var jqXHR = $.ajax({
            url: restUrl,
            beforeSend: moduleHeaders,
            dataType: "json",
            async: false
        }).done(function (data) {
            if (data) {
                loadProjectPartners(data);
            }
            else {
                clear();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };




    // load

    var loadProjectPartners = function (data) {
        projectPartnerList.removeAll();
        var underlyingArray = projectPartnerList();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var projectPartner = new Web.projectPartner
            (
                result.projectPartnerId, 
                result.projectId, 
                result.partnerId, 
                result.grantValue, 
                result.isDeleted 
            );
            underlyingArray.push(projectPartner);
        }
        projectPartnerList.valueHasMutated();
    };


    // extract knockout array to simple json objects

    var extractKoArrayToJson = function (data) {
        var simpleArray = new Array();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var projectPartner = {
                projectPartnerId: result.projectPartnerId(), 
                projectId: result.projectId(), 
                partnerId: result.partnerId(), 
                grantValue: result.grantValue(), 
                isDeleted: result.isDeleted() 
            };

            simpleArray.push(projectPartner);
        }
        return simpleArray;
    };


    // add

    var addProjectPartner = function () {
        var projectPartner = new Web.projectPartner(0, '', '', '', '');
        projectPartnerList.push(projectPartner);
    };


    // remove

    var removeProjectPartner = function (model, event) {
        var projectPartner = model;
        projectPartner.isDeleted = true;
        deletedProjectPartnerList.push(projectPartner);
        projectPartnerList.pop(projectPartner);
    };


    // clear

    var clear = function () {
        projectPartnerList([]);
    };


    // quickSearch

    var quickSearch = function () {
        for (var i = 0; i < projectPartnerList().length; i++) {
            var result = projectPartnerList()[i];

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
        projectPartnerList: projectPartnerList,
        deletedProjectPartnerList: deletedProjectPartnerList,
        getProjectPartnerList: getProjectPartnerList,
        loadProjectPartners: loadProjectPartners,
        isLoading: isLoading,
        addProjectPartner: addProjectPartner,
        removeProjectPartner: removeProjectPartner,
        clear: clear,
        searchText: searchText,
        quickSearch: quickSearch,
        extractKoArrayToJson: extractKoArrayToJson
    };
}
    