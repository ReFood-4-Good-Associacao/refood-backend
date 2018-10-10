
// ################################################################
//                      Code generated with T4
// ################################################################

var Web = Web || {};

// viewmodel

Web.food = function ( foodId, name, quantity, foodTemplateId, specificObservations, location, progress, expired, liquid, rating, feedbackFromBeneficiary, deliveredBy, deliveredTo, orderDateTime, cookedDateTime, pickupDateTime, storageDateTime, deliveryDateTime, active, isDeleted) {
    this.foodId = ko.observable(foodId);
    this.name = ko.observable(name);
    this.quantity = ko.observable(quantity);
    this.foodTemplateId = ko.observable(foodTemplateId);
    this.specificObservations = ko.observable(specificObservations);
    this.location = ko.observable(location);
    this.progress = ko.observable(progress);
    this.expired = ko.observable(expired);
    this.liquid = ko.observable(liquid);
    this.rating = ko.observable(rating);
    this.feedbackFromBeneficiary = ko.observable(feedbackFromBeneficiary);
    this.deliveredBy = ko.observable(deliveredBy);
    this.deliveredTo = ko.observable(deliveredTo);
    this.orderDateTime = ko.observable(orderDateTime);
    this.cookedDateTime = ko.observable(cookedDateTime);
    this.pickupDateTime = ko.observable(pickupDateTime);
    this.storageDateTime = ko.observable(storageDateTime);
    this.deliveryDateTime = ko.observable(deliveryDateTime);
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

Web.foodHelper = function (isLoading, serviceRootUrl, moduleHeaders) {

    var foodList = ko.observableArray([]);
    var deletedFoodList = ko.observableArray([]);
    var isLoading = isLoading;
    var serviceRootUrl = serviceRootUrl;
    var moduleHeaders = moduleHeaders;
    var searchText = ko.observable('');


    // get

    var getFoodList = function () {
        isLoading(true);

        // need to calculate a different Url for Food service
        var restUrl = serviceRootUrl + "api/FoodApi/GetList/";
        var jqXHR = $.ajax({
            url: restUrl,
            beforeSend: moduleHeaders,
            dataType: "json",
            async: false
        }).done(function (data) {
            if (data) {
                loadFoods(data);
            }
            else {
                clear();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };




    // load

    var loadFoods = function (data) {
        foodList.removeAll();
        var underlyingArray = foodList();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var food = new Web.food
            (
                result.foodId, 
                result.name, 
                result.quantity, 
                result.foodTemplateId, 
                result.specificObservations, 
                result.location, 
                result.progress, 
                result.expired, 
                result.liquid, 
                result.rating, 
                result.feedbackFromBeneficiary, 
                result.deliveredBy, 
                result.deliveredTo, 
                result.orderDateTime, 
                result.cookedDateTime, 
                result.pickupDateTime, 
                result.storageDateTime, 
                result.deliveryDateTime, 
                result.active, 
                result.isDeleted 
            );
            underlyingArray.push(food);
        }
        foodList.valueHasMutated();
    };


    // extract knockout array to simple json objects

    var extractKoArrayToJson = function (data) {
        var simpleArray = new Array();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var food = {
                foodId: result.foodId(), 
                name: result.name(), 
                quantity: result.quantity(), 
                foodTemplateId: result.foodTemplateId(), 
                specificObservations: result.specificObservations(), 
                location: result.location(), 
                progress: result.progress(), 
                expired: result.expired(), 
                liquid: result.liquid(), 
                rating: result.rating(), 
                feedbackFromBeneficiary: result.feedbackFromBeneficiary(), 
                deliveredBy: result.deliveredBy(), 
                deliveredTo: result.deliveredTo(), 
                orderDateTime: result.orderDateTime(), 
                cookedDateTime: result.cookedDateTime(), 
                pickupDateTime: result.pickupDateTime(), 
                storageDateTime: result.storageDateTime(), 
                deliveryDateTime: result.deliveryDateTime(), 
                active: result.active(), 
                isDeleted: result.isDeleted() 
            };

            simpleArray.push(food);
        }
        return simpleArray;
    };


    // add

    var addFood = function () {
        var food = new Web.food(0, '', '', '', '');
        foodList.push(food);
    };


    // remove

    var removeFood = function (model, event) {
        var food = model;
        food.isDeleted = true;
        deletedFoodList.push(food);
        foodList.pop(food);
    };


    // clear

    var clear = function () {
        foodList([]);
    };


    // quickSearch

    var quickSearch = function () {
        for (var i = 0; i < foodList().length; i++) {
            var result = foodList()[i];

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
        foodList: foodList,
        deletedFoodList: deletedFoodList,
        getFoodList: getFoodList,
        loadFoods: loadFoods,
        isLoading: isLoading,
        addFood: addFood,
        removeFood: removeFood,
        clear: clear,
        searchText: searchText,
        quickSearch: quickSearch,
        extractKoArrayToJson: extractKoArrayToJson
    };
}
    