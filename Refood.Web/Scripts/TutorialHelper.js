
// ################################################################
//                      Code generated with T4
// ################################################################

var Web = Web || {};

// viewmodel

Web.tutorial = function ( tutorialId, name, description, location, isOnlineTutorial, language, active, isDeleted) {
    this.tutorialId = ko.observable(tutorialId);
    this.name = ko.observable(name);
    this.description = ko.observable(description);
    this.location = ko.observable(location);
    this.isOnlineTutorial = ko.observable(isOnlineTutorial);
    this.language = ko.observable(language);
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

Web.tutorialHelper = function (isLoading, serviceRootUrl, moduleHeaders) {

    var tutorialList = ko.observableArray([]);
    var deletedTutorialList = ko.observableArray([]);
    var isLoading = isLoading;
    var serviceRootUrl = serviceRootUrl;
    var moduleHeaders = moduleHeaders;
    var searchText = ko.observable('');


    // get

    var getTutorialList = function () {
        isLoading(true);

        // need to calculate a different Url for Tutorial service
        var restUrl = serviceRootUrl + "api/TutorialApi/GetList/";
        var jqXHR = $.ajax({
            url: restUrl,
            beforeSend: moduleHeaders,
            dataType: "json",
            async: false
        }).done(function (data) {
            if (data) {
                loadTutorials(data);
            }
            else {
                clear();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };




    // load

    var loadTutorials = function (data) {
        tutorialList.removeAll();
        var underlyingArray = tutorialList();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var tutorial = new Web.tutorial
            (
                result.tutorialId, 
                result.name, 
                result.description, 
                result.location, 
                result.isOnlineTutorial, 
                result.language, 
                result.active, 
                result.isDeleted 
            );
            underlyingArray.push(tutorial);
        }
        tutorialList.valueHasMutated();
    };


    // extract knockout array to simple json objects

    var extractKoArrayToJson = function (data) {
        var simpleArray = new Array();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var tutorial = {
                tutorialId: result.tutorialId(), 
                name: result.name(), 
                description: result.description(), 
                location: result.location(), 
                isOnlineTutorial: result.isOnlineTutorial(), 
                language: result.language(), 
                active: result.active(), 
                isDeleted: result.isDeleted() 
            };

            simpleArray.push(tutorial);
        }
        return simpleArray;
    };


    // add

    var addTutorial = function () {
        var tutorial = new Web.tutorial(0, '', '', '', '');
        tutorialList.push(tutorial);
    };


    // remove

    var removeTutorial = function (model, event) {
        var tutorial = model;
        tutorial.isDeleted = true;
        deletedTutorialList.push(tutorial);
        tutorialList.pop(tutorial);
    };


    // clear

    var clear = function () {
        tutorialList([]);
    };


    // quickSearch

    var quickSearch = function () {
        for (var i = 0; i < tutorialList().length; i++) {
            var result = tutorialList()[i];

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
        tutorialList: tutorialList,
        deletedTutorialList: deletedTutorialList,
        getTutorialList: getTutorialList,
        loadTutorials: loadTutorials,
        isLoading: isLoading,
        addTutorial: addTutorial,
        removeTutorial: removeTutorial,
        clear: clear,
        searchText: searchText,
        quickSearch: quickSearch,
        extractKoArrayToJson: extractKoArrayToJson
    };
}
    