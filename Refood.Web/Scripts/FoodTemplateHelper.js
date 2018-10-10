
// ################################################################
//                      Code generated with T4
// ################################################################

var Web = Web || {};

// viewmodel

Web.foodTemplate = function ( foodTemplateId, name, description, foodCategory, calories, averageExpirationTime, liquid, needsRefrigeration, active, isDeleted) {
    this.foodTemplateId = ko.observable(foodTemplateId);
    this.name = ko.observable(name);
    this.description = ko.observable(description);
    this.foodCategory = ko.observable(foodCategory);
    this.calories = ko.observable(calories);
    this.averageExpirationTime = ko.observable(averageExpirationTime);
    this.liquid = ko.observable(liquid);
    this.needsRefrigeration = ko.observable(needsRefrigeration);
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

Web.foodTemplateHelper = function (isLoading, serviceRootUrl, moduleHeaders) {

    var foodTemplateList = ko.observableArray([]);
    var deletedFoodTemplateList = ko.observableArray([]);
    var isLoading = isLoading;
    var serviceRootUrl = serviceRootUrl;
    var moduleHeaders = moduleHeaders;
    var searchText = ko.observable('');


    // get

    var getFoodTemplateList = function () {
        isLoading(true);

        // need to calculate a different Url for FoodTemplate service
        var restUrl = serviceRootUrl + "FoodTemplate/GetList/";
        var jqXHR = $.ajax({
            url: restUrl,
            beforeSend: moduleHeaders,
            dataType: "json",
            async: false
        }).done(function (data) {
            if (data) {
                loadFoodTemplates(data);
            }
            else {
                clear();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };




    // load

    var loadFoodTemplates = function (data) {
        foodTemplateList.removeAll();
        var underlyingArray = foodTemplateList();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var foodTemplate = new Web.foodTemplate
            (
                result.foodTemplateId, 
                result.name, 
                result.description, 
                result.foodCategory, 
                result.calories, 
                result.averageExpirationTime, 
                result.liquid, 
                result.needsRefrigeration, 
                result.active, 
                result.isDeleted 
            );
            underlyingArray.push(foodTemplate);
        }
        foodTemplateList.valueHasMutated();
    };


    // extract knockout array to simple json objects

    var extractKoArrayToJson = function (data) {
        var simpleArray = new Array();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var foodTemplate = {
                foodTemplateId: result.foodTemplateId(), 
                name: result.name(), 
                description: result.description(), 
                foodCategory: result.foodCategory(), 
                calories: result.calories(), 
                averageExpirationTime: result.averageExpirationTime(), 
                liquid: result.liquid(), 
                needsRefrigeration: result.needsRefrigeration(), 
                active: result.active(), 
                isDeleted: result.isDeleted() 
            };

            simpleArray.push(foodTemplate);
        }
        return simpleArray;
    };


    // add

    var addFoodTemplate = function () {
        var foodTemplate = new Web.foodTemplate(0, '', '', '', '');
        foodTemplateList.push(foodTemplate);
    };


    // remove

    var removeFoodTemplate = function (model, event) {
        var foodTemplate = model;
        foodTemplate.isDeleted = true;
        deletedFoodTemplateList.push(foodTemplate);
        foodTemplateList.pop(foodTemplate);
    };


    // clear

    var clear = function () {
        foodTemplateList([]);
    };


    // quickSearch

    var quickSearch = function () {
        for (var i = 0; i < foodTemplateList().length; i++) {
            var result = foodTemplateList()[i];

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
        foodTemplateList: foodTemplateList,
        deletedFoodTemplateList: deletedFoodTemplateList,
        getFoodTemplateList: getFoodTemplateList,
        loadFoodTemplates: loadFoodTemplates,
        isLoading: isLoading,
        addFoodTemplate: addFoodTemplate,
        removeFoodTemplate: removeFoodTemplate,
        clear: clear,
        searchText: searchText,
        quickSearch: quickSearch,
        extractKoArrayToJson: extractKoArrayToJson
    };
}
    