
// ################################################################
//                      Code generated with T4
// ################################################################

var Web = Web || {};

// viewmodel

Web.team = function ( teamId, nucleoId, name, description, active, isDeleted) {
    this.teamId = ko.observable(teamId);
    this.nucleoId = ko.observable(nucleoId);
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

Web.teamHelper = function (isLoading, serviceRootUrl, moduleHeaders) {

    var teamList = ko.observableArray([]);
    var deletedTeamList = ko.observableArray([]);
    var isLoading = isLoading;
    var serviceRootUrl = serviceRootUrl;
    var moduleHeaders = moduleHeaders;
    var searchText = ko.observable('');


    // get

    var getTeamList = function () {
        isLoading(true);

        // need to calculate a different Url for Team service
        var restUrl = serviceRootUrl + "api/TeamApi/GetList/";
        var jqXHR = $.ajax({
            url: restUrl,
            beforeSend: moduleHeaders,
            dataType: "json",
            async: false
        }).done(function (data) {
            if (data) {
                loadTeams(data);
            }
            else {
                clear();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };




    // load

    var loadTeams = function (data) {
        teamList.removeAll();
        var underlyingArray = teamList();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var team = new Web.team
            (
                result.teamId, 
                result.nucleoId, 
                result.name, 
                result.description, 
                result.active, 
                result.isDeleted 
            );
            underlyingArray.push(team);
        }
        teamList.valueHasMutated();
    };


    // extract knockout array to simple json objects

    var extractKoArrayToJson = function (data) {
        var simpleArray = new Array();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var team = {
                teamId: result.teamId(), 
                nucleoId: result.nucleoId(), 
                name: result.name(), 
                description: result.description(), 
                active: result.active(), 
                isDeleted: result.isDeleted() 
            };

            simpleArray.push(team);
        }
        return simpleArray;
    };


    // add

    var addTeam = function () {
        var team = new Web.team(0, '', '', '', '');
        teamList.push(team);
    };


    // remove

    var removeTeam = function (model, event) {
        var team = model;
        team.isDeleted = true;
        deletedTeamList.push(team);
        teamList.pop(team);
    };


    // clear

    var clear = function () {
        teamList([]);
    };


    // quickSearch

    var quickSearch = function () {
        for (var i = 0; i < teamList().length; i++) {
            var result = teamList()[i];

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
        teamList: teamList,
        deletedTeamList: deletedTeamList,
        getTeamList: getTeamList,
        loadTeams: loadTeams,
        isLoading: isLoading,
        addTeam: addTeam,
        removeTeam: removeTeam,
        clear: clear,
        searchText: searchText,
        quickSearch: quickSearch,
        extractKoArrayToJson: extractKoArrayToJson
    };
}
    