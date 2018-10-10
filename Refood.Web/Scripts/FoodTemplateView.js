
// ################################################################
//                      Code generated with T4
// ################################################################

var Web = Web || {};

Web.foodTemplateListViewModel = function (moduleId, resx) {
    var baseUrl = "api/FoodTemplateApi/";

    var isLoading = ko.observable(false);
    var foodTemplateList = ko.observableArray([]);
    var editMode = ko.computed(function () {
        return foodTemplateList().length > 0 && foodTemplateList()[0].editUrl() != null && foodTemplateList()[0].editUrl().length > 0;
    });
    var searchText = ko.observable('');



    // filters

    var nameFilter = ko.observable('');
    var descriptionFilter = ko.observable('');
    var foodCategoryFilter = ko.observable('');
    var caloriesFilter = ko.observable('');
    var averageExpirationTimeFromFilter = ko.observable('');
    var averageExpirationTimeToFilter = ko.observable('');
    var liquidFilter = ko.observable('');
    var needsRefrigerationFilter = ko.observable('');
    var activeFilter = ko.observable('');



    // helpers




    // init

    var init = function () {
        //getFoodTemplateList();
        //getFoodTemplatePage();
        getFoodTemplateListAdvanced();

    }



    // get list

    var getFoodTemplateList = function () {
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
                foodTemplateList.removeAll();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };



    // get list - advanced search

    var getFoodTemplateListAdvanced = function () {
        isLoading(true);

        var searchFilters = "?";
        searchFilters += (nameFilter() != '' ? "name=" + nameFilter() : "");
        searchFilters += (descriptionFilter() != '' ? "description=" + descriptionFilter() : "");
        searchFilters += (foodCategoryFilter() != '' ? "foodCategory=" + foodCategoryFilter() : "");
        searchFilters += (caloriesFilter() != '' ? "calories=" + caloriesFilter() : "");
        searchFilters += (averageExpirationTimeFromFilter() != '' && averageExpirationTimeFromFilter() != null ? "&" + "averageExpirationTimeFrom=" + dateToStringServerFormat(averageExpirationTimeFromFilter()) : "");
        searchFilters += (averageExpirationTimeToFilter() != '' && averageExpirationTimeToFilter() != null ? "&" + "averageExpirationTimeTo=" + dateToStringServerFormat(averageExpirationTimeToFilter()) : "");
        searchFilters += (liquidFilter() != '' ? "liquid=" + liquidFilter() : "");
        searchFilters += (needsRefrigerationFilter() != '' ? "needsRefrigeration=" + needsRefrigerationFilter() : "");
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
                foodTemplateList.removeAll();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };

    var advancedSearch = function () {
        getFoodTemplateListAdvanced();
    };

    var clearSearchFilters = function () {
        nameFilter('');
        descriptionFilter('');
        foodCategoryFilter('');
        caloriesFilter('');
        averageExpirationTimeFromFilter('');
        averageExpirationTimeToFilter('');
        liquidFilter('');
        needsRefrigerationFilter('');
        activeFilter('');
    };



    // get list by page

    var getFoodTemplatePage = function () {
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
                foodTemplateList.removeAll();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };



    // delete

    var deleteFoodTemplate = function (foodTemplate) {
        isLoading(true);
        var restUrl = baseUrl + "Delete/" + foodTemplate.foodTemplateId();
        var jqXHR = $.ajax({
            url: restUrl,
            dataType: "json"
        }).done(function () {
            console.log("Deleted: " + foodTemplate.foodTemplateId());
            foodTemplateList.remove(foodTemplate);
        }).fail(function () {
            console.log("Error");
        }).always(function (data) {
            console.log("finished");
            isLoading(false);
        });
    }

    var deleteFoodTemplateById = function (foodTemplateId) {
        isLoading(true);
        var restUrl = baseUrl + "Delete/" + foodTemplateId;
        var jqXHR = $.ajax({
            method: "GET",
            url: restUrl,
            dataType: "json"
        }).done(function () {
            console.log("Deleted: " + foodTemplateId);
            //foodTemplateList.remove(foodTemplate);
            // refresh
            getFoodTemplateList();
        }).fail(function () {
            console.log("Error");
        }).always(function (data) {
            console.log("finished");
            isLoading(false);
        });
    }



    // load

    var load = function (data) {
        foodTemplateList.removeAll();
        var underlyingArray = foodTemplateList();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var foodTemplate = new Web.foodTemplateViewModel();
            foodTemplate.load(result);
            underlyingArray.push(foodTemplate);
        }
        foodTemplateList.valueHasMutated();
    };



    // data table

    var updateDatatable = function (data) {
        var dataArray = new Array();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var fieldsInArray = new Array();

            fieldsInArray.push(result.name);
            fieldsInArray.push(result.description);
            fieldsInArray.push(result.foodCategory);
            fieldsInArray.push(result.calories);
            fieldsInArray.push(result.averageExpirationTime);
            fieldsInArray.push(result.liquid);
            fieldsInArray.push(result.needsRefrigeration);
            fieldsInArray.push(result.active);

            var viewLinkElement = '<a href=\"' + result.editUrl + '\" style=\"margin-right: 10px;\">View</a>';
            var editLinkElement = '<a href=\"' + result.editUrl + '\" style=\"margin-right: 10px;\">Edit</a>';
            var deleteLinkElement = '<a href=\"' + 'javascript:vm.deleteFoodTemplateById(' + result.foodTemplateId + ');' + '\" style=\"margin-right: 10px;\">Delete</a>';
            fieldsInArray.push(viewLinkElement + editLinkElement + deleteLinkElement);

            dataArray.push(fieldsInArray);
        }

        var datatable = $("#FoodTemplatesTable-" + moduleId).DataTable();
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
        foodTemplateList: foodTemplateList,
        getFoodTemplateList: getFoodTemplateList,
        getFoodTemplatePage: getFoodTemplatePage,
        deleteFoodTemplate: deleteFoodTemplate,
        deleteFoodTemplateById: deleteFoodTemplateById,
        editMode: editMode,
        isLoading: isLoading,
        searchText: searchText,
        openCreateForm: openCreateForm,
        getFoodTemplateListAdvanced: getFoodTemplateListAdvanced,
        advancedSearch: advancedSearch,
        clearSearchFilters: clearSearchFilters,


        nameFilter: nameFilter,
        descriptionFilter: descriptionFilter,
        foodCategoryFilter: foodCategoryFilter,
        caloriesFilter: caloriesFilter,
        averageExpirationTimeFromFilter: averageExpirationTimeFromFilter,
        averageExpirationTimeToFilter: averageExpirationTimeToFilter,
        liquidFilter: liquidFilter,
        needsRefrigerationFilter: needsRefrigerationFilter,
        activeFilter: activeFilter,
    }
};



// view model

Web.foodTemplateViewModel = function () {
    var foodTemplateId = ko.observable(-1);
    var name = ko.observable('');
    var description = ko.observable('');
    var foodCategory = ko.observable('');
    var calories = ko.observable('');
    var averageExpirationTime = ko.observable('');
    var liquid = ko.observable('');
    var needsRefrigeration = ko.observable('');
    var active = ko.observable('');
    var isDeleted = ko.observable('');

    var editUrl = ko.observable('');

    var visibleOnSearch = ko.observable(true);
 
    // load

    var load = function (data) {
        foodTemplateId(data.foodTemplateId);
        name(data.name);
        description(data.description);
        foodCategory(data.foodCategory);
        calories(data.calories);
        averageExpirationTime(data.averageExpirationTime);
        liquid(data.liquid);
        needsRefrigeration(data.needsRefrigeration);
        active(data.active);
        isDeleted(data.isDeleted);
        editUrl(data.editUrl);
    };



    return {
        foodTemplateId: foodTemplateId,
        name: name,
        description: description,
        foodCategory: foodCategory,
        calories: calories,
        averageExpirationTime: averageExpirationTime,
        liquid: liquid,
        needsRefrigeration: needsRefrigeration,
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






    