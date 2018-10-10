
// ################################################################
//                      Code generated with T4
// ################################################################

var Web = Web || {};

Web.tutorialListViewModel = function (moduleId, resx) {
    var baseUrl = "api/TutorialApi/";

    var isLoading = ko.observable(false);
    var tutorialList = ko.observableArray([]);
    var editMode = ko.computed(function () {
        return tutorialList().length > 0 && tutorialList()[0].editUrl() != null && tutorialList()[0].editUrl().length > 0;
    });
    var searchText = ko.observable('');



    // filters

    var nameFilter = ko.observable('');
    var descriptionFilter = ko.observable('');
    var locationFilter = ko.observable('');
    var isOnlineTutorialFilter = ko.observable('');
    var languageFilter = ko.observable('');
    var activeFilter = ko.observable('');



    // helpers




    // init

    var init = function () {
        //getTutorialList();
        //getTutorialPage();
        getTutorialListAdvanced();

    }



    // get list

    var getTutorialList = function () {
        isLoading(true);
        var jqXHR = $.ajax({
            url: baseUrl + "GetList/",
            dataType: "json"
        }).done(function (data) {
            if (data) {
                load(data);

                // update datatable
                updateDatatable(data);
            }
            else {
                // No data to load 
                tutorialList.removeAll();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };



    // get list - advanced search

    var getTutorialListAdvanced = function () {
        isLoading(true);

        var searchFilters = "?";
        searchFilters += (nameFilter() != '' ? "name=" + nameFilter() : "");
        searchFilters += (descriptionFilter() != '' ? "description=" + descriptionFilter() : "");
        searchFilters += (locationFilter() != '' ? "location=" + locationFilter() : "");
        searchFilters += (isOnlineTutorialFilter() != '' ? "isOnlineTutorial=" + isOnlineTutorialFilter() : "");
        searchFilters += (languageFilter() != '' ? "language=" + languageFilter() : "");
        searchFilters += (activeFilter() != '' ? "active=" + activeFilter() : "");

        var jqXHR = $.ajax({
            url: baseUrl + "GetListAdvancedSearch/0/" + searchFilters,
            dataType: "json"
        }).done(function (data) {
            if (data) {
                load(data);

                // update datatable
                updateDatatable(data);
            }
            else {
                // No data to load 
                tutorialList.removeAll();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };

    var advancedSearch = function () {
        getTutorialListAdvanced();
    };

    var clearSearchFilters = function () {
        nameFilter('');
        descriptionFilter('');
        locationFilter('');
        isOnlineTutorialFilter('');
        languageFilter('');
        activeFilter('');
    };



    // get list by page

    var getTutorialPage = function () {
        isLoading(true);

        var searchFilters = "?"
            + (searchText() != '' ? "searchTerm=" + searchText() : "")
            + "&" + "pageIndex=" + pager.currentPageIndex()
            + "&" + "pageSize=" + pager.currentPageSize()
        ;

        var restUrl = baseUrl + "GetPage/0/" + searchFilters;

        var jqXHR = $.ajax({
            url: restUrl,
            dataType: "json"
        }).done(function (data) {
            if (data) {
                load(data);

                // update datatable
                updateDatatable(data);
            }
            else {
                // No data to load 
                tutorialList.removeAll();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };



    // delete

    var deleteTutorial = function (tutorial) {
        isLoading(true);
        var restUrl = baseUrl + "Delete/" + tutorial.tutorialId();
        var jqXHR = $.ajax({
            url: restUrl,
            dataType: "json"
        }).done(function () {
            console.log("Deleted: " + tutorial.tutorialId());
            tutorialList.remove(tutorial);
        }).fail(function () {
            console.log("Error");
        }).always(function (data) {
            console.log("finished");
            isLoading(false);
        });
    }

    var deleteTutorialById = function (tutorialId) {
        isLoading(true);
        var restUrl = baseUrl + "Delete/" + tutorialId;
        var jqXHR = $.ajax({
            method: "GET",
            url: restUrl,
            dataType: "json"
        }).done(function () {
            console.log("Deleted: " + tutorialId);
            //tutorialList.remove(tutorial);
            // refresh
            getTutorialList();
        }).fail(function () {
            console.log("Error");
        }).always(function (data) {
            console.log("finished");
            isLoading(false);
        });
    }



    // load

    var load = function (data) {
        tutorialList.removeAll();
        var underlyingArray = tutorialList();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var tutorial = new Web.tutorialViewModel();
            tutorial.load(result);
            underlyingArray.push(tutorial);
        }
        tutorialList.valueHasMutated();
    };



    // data table

    var updateDatatable = function (data) {
        var dataArray = new Array();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var fieldsInArray = new Array();

            fieldsInArray.push(result.name);
            fieldsInArray.push(result.description);
            fieldsInArray.push(result.location);
            fieldsInArray.push(result.isOnlineTutorial);
            fieldsInArray.push(result.language);
            fieldsInArray.push(result.active);

            var viewLinkElement = '<a href=\"' + result.editUrl + '\" style=\"margin-right: 10px;\">View</a>';
            var editLinkElement = '<a href=\"' + result.editUrl + '\" style=\"margin-right: 10px;\">Edit</a>';
            var deleteLinkElement = '<a href=\"' + 'javascript:vm.deleteTutorialById(' + result.tutorialId + ');' + '\" style=\"margin-right: 10px;\">Delete</a>';
            fieldsInArray.push(viewLinkElement + editLinkElement + deleteLinkElement);

            dataArray.push(fieldsInArray);
        }

        var datatable = $("#TutorialsTable-" + moduleId).DataTable();
        datatable.clear();
        datatable.rows.add(dataArray);
        datatable.draw();
    };



    // open create form

    var openCreateForm = function () {
        var isPopUp = "?popUp=true";
        var path = location.pathname + "/ctl/Edit/mid/" + moduleId + isPopUp;
        dnnModal.show(path, false, 550, 950, true, '');
    };



    return {
        init: init,
        load: load,
        tutorialList: tutorialList,
        getTutorialList: getTutorialList,
        getTutorialPage: getTutorialPage,
        deleteTutorial: deleteTutorial,
        deleteTutorialById: deleteTutorialById,
        editMode: editMode,
        isLoading: isLoading,
        searchText: searchText,
        openCreateForm: openCreateForm,
        getTutorialListAdvanced: getTutorialListAdvanced,
        advancedSearch: advancedSearch,
        clearSearchFilters: clearSearchFilters,


        nameFilter: nameFilter,
        descriptionFilter: descriptionFilter,
        locationFilter: locationFilter,
        isOnlineTutorialFilter: isOnlineTutorialFilter,
        languageFilter: languageFilter,
        activeFilter: activeFilter,
    }
};



// view model

Web.tutorialViewModel = function () {
    var tutorialId = ko.observable(-1);
    var name = ko.observable('');
    var description = ko.observable('');
    var location = ko.observable('');
    var isOnlineTutorial = ko.observable('');
    var language = ko.observable('');
    var active = ko.observable('');
    var isDeleted = ko.observable('');

    var editUrl = ko.observable('');

    var visibleOnSearch = ko.observable(true);
 
    // load

    var load = function (data) {
        tutorialId(data.tutorialId);
        name(data.name);
        description(data.description);
        location(data.location);
        isOnlineTutorial(data.isOnlineTutorial);
        language(data.language);
        active(data.active);
        isDeleted(data.isDeleted);
        editUrl(data.editUrl);
    };



    return {
        tutorialId: tutorialId,
        name: name,
        description: description,
        location: location,
        isOnlineTutorial: isOnlineTutorial,
        language: language,
        active: active,
        isDeleted: isDeleted,
        editUrl: editUrl,
        load: load,
        visibleOnSearch: visibleOnSearch
    }
}



// aux

// date picker

ko.bindingHandlers.datepicker = {
    init: function (element, valueAccessor, allBindingsAccessor) {
        //initialize datepicker with some optional options
        var options = allBindingsAccessor().datepickerOptions || {},
            $el = $(element);

        $el.datepicker(options);

        //handle the field changing
        ko.utils.registerEventHandler(element, "change", function () {
            var observable = valueAccessor();
            observable($el.datepicker("getDate"));
        });

        //handle disposal (if KO removes by the template binding)
        ko.utils.domNodeDisposal.addDisposeCallback(element, function () {
            $el.datepicker("destroy");
        });

    },
    update: function (element, valueAccessor) {
        var value = ko.utils.unwrapObservable(valueAccessor()),
            $el = $(element);

        //handle date data coming via json from Microsoft
        if (String(value).indexOf('/Date(') == 0) {
            value = new Date(parseInt(value.replace(/\/Date\((.*?)\)\//gi, "$1")));
        }

        var current = $el.datepicker("getDate");

        if (value - current !== 0) {
            $el.datepicker("setDate", value);
        }
    }
};



// date format

function dateToStringServerFormat(d) {
    // server format: 2017-10-20T00:00:00
    var datestring = d.getFullYear() + "-" + ("0" + (d.getMonth() + 1)).slice(-2) + "-" + ("0" + d.getDate()).slice(-2) + "T00:00:00";
    return datestring;
}






    