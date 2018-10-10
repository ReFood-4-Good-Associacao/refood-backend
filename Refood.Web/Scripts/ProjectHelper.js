
// ################################################################
//                      Code generated with T4
// ################################################################

var Web = Web || {};

// viewmodel

Web.project = function ( projectId, nucleoId, name, description, deadlineCall, budget, funding, startDate, endDate, areaOfInterest, active, isDeleted) {
    this.projectId = ko.observable(projectId);
    this.nucleoId = ko.observable(nucleoId);
    this.name = ko.observable(name);
    this.description = ko.observable(description);
    this.deadlineCall = ko.observable(deadlineCall);
    this.budget = ko.observable(budget);
    this.funding = ko.observable(funding);
    this.startDate = ko.observable(startDate);
    this.endDate = ko.observable(endDate);
    this.areaOfInterest = ko.observable(areaOfInterest);
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

Web.projectHelper = function (isLoading, serviceRootUrl, moduleHeaders) {

    var projectList = ko.observableArray([]);
    var deletedProjectList = ko.observableArray([]);
    var isLoading = isLoading;
    var serviceRootUrl = serviceRootUrl;
    var moduleHeaders = moduleHeaders;
    var searchText = ko.observable('');


    // get

    var getProjectList = function () {
        isLoading(true);

        // need to calculate a different Url for Project service
        var restUrl = serviceRootUrl + "api/ProjectApi/GetList/";
        var jqXHR = $.ajax({
            url: restUrl,
            beforeSend: moduleHeaders,
            dataType: "json",
            async: false
        }).done(function (data) {
            if (data) {
                loadProjects(data);
            }
            else {
                clear();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };




    // load

    var loadProjects = function (data) {
        projectList.removeAll();
        var underlyingArray = projectList();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var project = new Web.project
            (
                result.projectId, 
                result.nucleoId, 
                result.name, 
                result.description, 
                result.deadlineCall, 
                result.budget, 
                result.funding, 
                result.startDate, 
                result.endDate, 
                result.areaOfInterest, 
                result.active, 
                result.isDeleted 
            );
            underlyingArray.push(project);
        }
        projectList.valueHasMutated();
    };


    // extract knockout array to simple json objects

    var extractKoArrayToJson = function (data) {
        var simpleArray = new Array();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var project = {
                projectId: result.projectId(), 
                nucleoId: result.nucleoId(), 
                name: result.name(), 
                description: result.description(), 
                deadlineCall: result.deadlineCall(), 
                budget: result.budget(), 
                funding: result.funding(), 
                startDate: result.startDate(), 
                endDate: result.endDate(), 
                areaOfInterest: result.areaOfInterest(), 
                active: result.active(), 
                isDeleted: result.isDeleted() 
            };

            simpleArray.push(project);
        }
        return simpleArray;
    };


    // add

    var addProject = function () {
        var project = new Web.project(0, '', '', '', '');
        projectList.push(project);
    };


    // remove

    var removeProject = function (model, event) {
        var project = model;
        project.isDeleted = true;
        deletedProjectList.push(project);
        projectList.pop(project);
    };


    // clear

    var clear = function () {
        projectList([]);
    };


    // quickSearch

    var quickSearch = function () {
        for (var i = 0; i < projectList().length; i++) {
            var result = projectList()[i];

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
        projectList: projectList,
        deletedProjectList: deletedProjectList,
        getProjectList: getProjectList,
        loadProjects: loadProjects,
        isLoading: isLoading,
        addProject: addProject,
        removeProject: removeProject,
        clear: clear,
        searchText: searchText,
        quickSearch: quickSearch,
        extractKoArrayToJson: extractKoArrayToJson
    };
}
    