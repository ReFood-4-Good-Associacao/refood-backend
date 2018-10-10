
// ################################################################
//                      Code generated with T4
// ################################################################

var Web = Web || {};

Web.foodListViewModel = function (moduleId, resx) {
    var baseUrl = "api/FoodApi/";

    var isLoading = ko.observable(false);
    var foodList = ko.observableArray([]);
    var editMode = ko.computed(function () {
        return foodList().length > 0 && foodList()[0].editUrl() != null && foodList()[0].editUrl().length > 0;
    });
    var searchText = ko.observable('');



    // filters

    var nameFilter = ko.observable('');
    var quantityFilter = ko.observable('');
    var foodTemplateIdFilter = ko.observable(-1);
    var specificObservationsFilter = ko.observable('');
    var locationFilter = ko.observable('');
    var progressFilter = ko.observable('');
    var expiredFilter = ko.observable('');
    var liquidFilter = ko.observable('');
    var ratingFilter = ko.observable('');
    var feedbackFromBeneficiaryFilter = ko.observable('');
    var deliveredByFilter = ko.observable('');
    var deliveredToFilter = ko.observable('');
    var orderDateTimeFromFilter = ko.observable('');
    var orderDateTimeToFilter = ko.observable('');
    var cookedDateTimeFromFilter = ko.observable('');
    var cookedDateTimeToFilter = ko.observable('');
    var pickupDateTimeFromFilter = ko.observable('');
    var pickupDateTimeToFilter = ko.observable('');
    var storageDateTimeFromFilter = ko.observable('');
    var storageDateTimeToFilter = ko.observable('');
    var deliveryDateTimeFromFilter = ko.observable('');
    var deliveryDateTimeToFilter = ko.observable('');
    var activeFilter = ko.observable('');



    // helpers

    var foodTemplateHelper = Web.foodTemplateHelper(isLoading, '/', function(){});



    // init

    var init = function () {
        //getFoodList();
        //getFoodPage();
        getFoodListAdvanced();

        foodTemplateHelper.getFoodTemplateList();
    }



    // get list

    var getFoodList = function () {
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
                foodList.removeAll();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };



    // get list - advanced search

    var getFoodListAdvanced = function () {
        isLoading(true);

        var searchFilters = "?";
        searchFilters += (nameFilter() != '' ? "name=" + nameFilter() : "");
        searchFilters += (quantityFilter() != '' ? "quantity=" + quantityFilter() : "");
        searchFilters += (foodTemplateIdFilter() != -1 && foodTemplateIdFilter() != undefined ? "&" + "foodTemplateId=" + foodTemplateIdFilter() : "");
        searchFilters += (specificObservationsFilter() != '' ? "specificObservations=" + specificObservationsFilter() : "");
        searchFilters += (locationFilter() != '' ? "location=" + locationFilter() : "");
        searchFilters += (progressFilter() != '' ? "progress=" + progressFilter() : "");
        searchFilters += (expiredFilter() != '' ? "expired=" + expiredFilter() : "");
        searchFilters += (liquidFilter() != '' ? "liquid=" + liquidFilter() : "");
        searchFilters += (ratingFilter() != '' ? "rating=" + ratingFilter() : "");
        searchFilters += (feedbackFromBeneficiaryFilter() != '' ? "feedbackFromBeneficiary=" + feedbackFromBeneficiaryFilter() : "");
        searchFilters += (deliveredByFilter() != '' ? "deliveredBy=" + deliveredByFilter() : "");
        searchFilters += (deliveredToFilter() != '' ? "deliveredTo=" + deliveredToFilter() : "");
        searchFilters += (orderDateTimeFromFilter() != '' && orderDateTimeFromFilter() != null ? "&" + "orderDateTimeFrom=" + dateToStringServerFormat(orderDateTimeFromFilter()) : "");
        searchFilters += (orderDateTimeToFilter() != '' && orderDateTimeToFilter() != null ? "&" + "orderDateTimeTo=" + dateToStringServerFormat(orderDateTimeToFilter()) : "");
        searchFilters += (cookedDateTimeFromFilter() != '' && cookedDateTimeFromFilter() != null ? "&" + "cookedDateTimeFrom=" + dateToStringServerFormat(cookedDateTimeFromFilter()) : "");
        searchFilters += (cookedDateTimeToFilter() != '' && cookedDateTimeToFilter() != null ? "&" + "cookedDateTimeTo=" + dateToStringServerFormat(cookedDateTimeToFilter()) : "");
        searchFilters += (pickupDateTimeFromFilter() != '' && pickupDateTimeFromFilter() != null ? "&" + "pickupDateTimeFrom=" + dateToStringServerFormat(pickupDateTimeFromFilter()) : "");
        searchFilters += (pickupDateTimeToFilter() != '' && pickupDateTimeToFilter() != null ? "&" + "pickupDateTimeTo=" + dateToStringServerFormat(pickupDateTimeToFilter()) : "");
        searchFilters += (storageDateTimeFromFilter() != '' && storageDateTimeFromFilter() != null ? "&" + "storageDateTimeFrom=" + dateToStringServerFormat(storageDateTimeFromFilter()) : "");
        searchFilters += (storageDateTimeToFilter() != '' && storageDateTimeToFilter() != null ? "&" + "storageDateTimeTo=" + dateToStringServerFormat(storageDateTimeToFilter()) : "");
        searchFilters += (deliveryDateTimeFromFilter() != '' && deliveryDateTimeFromFilter() != null ? "&" + "deliveryDateTimeFrom=" + dateToStringServerFormat(deliveryDateTimeFromFilter()) : "");
        searchFilters += (deliveryDateTimeToFilter() != '' && deliveryDateTimeToFilter() != null ? "&" + "deliveryDateTimeTo=" + dateToStringServerFormat(deliveryDateTimeToFilter()) : "");
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
                foodList.removeAll();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };

    var advancedSearch = function () {
        getFoodListAdvanced();
    };

    var clearSearchFilters = function () {
        nameFilter('');
        quantityFilter('');
        foodTemplateIdFilter(-1);
        specificObservationsFilter('');
        locationFilter('');
        progressFilter('');
        expiredFilter('');
        liquidFilter('');
        ratingFilter('');
        feedbackFromBeneficiaryFilter('');
        deliveredByFilter('');
        deliveredToFilter('');
        orderDateTimeFromFilter('');
        orderDateTimeToFilter('');
        cookedDateTimeFromFilter('');
        cookedDateTimeToFilter('');
        pickupDateTimeFromFilter('');
        pickupDateTimeToFilter('');
        storageDateTimeFromFilter('');
        storageDateTimeToFilter('');
        deliveryDateTimeFromFilter('');
        deliveryDateTimeToFilter('');
        activeFilter('');
    };



    // get list by page

    var getFoodPage = function () {
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
                foodList.removeAll();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };



    // delete

    var deleteFood = function (food) {
        isLoading(true);
        var restUrl = baseUrl + "Delete/" + food.foodId();
        var jqXHR = $.ajax({
            url: restUrl,
            dataType: "json"
        }).done(function () {
            console.log("Deleted: " + food.foodId());
            foodList.remove(food);
        }).fail(function () {
            console.log("Error");
        }).always(function (data) {
            console.log("finished");
            isLoading(false);
        });
    }

    var deleteFoodById = function (foodId) {
        isLoading(true);
        var restUrl = baseUrl + "Delete/" + foodId;
        var jqXHR = $.ajax({
            method: "GET",
            url: restUrl,
            dataType: "json"
        }).done(function () {
            console.log("Deleted: " + foodId);
            //foodList.remove(food);
            // refresh
            getFoodList();
        }).fail(function () {
            console.log("Error");
        }).always(function (data) {
            console.log("finished");
            isLoading(false);
        });
    }



    // load

    var load = function (data) {
        foodList.removeAll();
        var underlyingArray = foodList();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var food = new Web.foodViewModel();
            food.load(result);
            underlyingArray.push(food);
        }
        foodList.valueHasMutated();
    };



    // data table

    var updateDatatable = function (data) {
        var dataArray = new Array();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var fieldsInArray = new Array();

            fieldsInArray.push(result.name);
            fieldsInArray.push(result.quantity);
            fieldsInArray.push(result.foodTemplateId);
            fieldsInArray.push(result.specificObservations);
            fieldsInArray.push(result.location);
            fieldsInArray.push(result.progress);
            fieldsInArray.push(result.expired);
            fieldsInArray.push(result.liquid);
            fieldsInArray.push(result.rating);
            fieldsInArray.push(result.feedbackFromBeneficiary);
            fieldsInArray.push(result.deliveredBy);
            fieldsInArray.push(result.deliveredTo);
            fieldsInArray.push(result.orderDateTime);
            fieldsInArray.push(result.cookedDateTime);
            fieldsInArray.push(result.pickupDateTime);
            fieldsInArray.push(result.storageDateTime);
            fieldsInArray.push(result.deliveryDateTime);
            fieldsInArray.push(result.active);

            var viewLinkElement = '<a href=\"' + result.editUrl + '\" style=\"margin-right: 10px;\">View</a>';
            var editLinkElement = '<a href=\"' + result.editUrl + '\" style=\"margin-right: 10px;\">Edit</a>';
            var deleteLinkElement = '<a href=\"' + 'javascript:vm.deleteFoodById(' + result.foodId + ');' + '\" style=\"margin-right: 10px;\">Delete</a>';
            fieldsInArray.push(viewLinkElement + editLinkElement + deleteLinkElement);

            dataArray.push(fieldsInArray);
        }

        var datatable = $("#FoodsTable-" + moduleId).DataTable();
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
        foodList: foodList,
        getFoodList: getFoodList,
        getFoodPage: getFoodPage,
        deleteFood: deleteFood,
        deleteFoodById: deleteFoodById,
        editMode: editMode,
        isLoading: isLoading,
        searchText: searchText,
        openCreateForm: openCreateForm,
        getFoodListAdvanced: getFoodListAdvanced,
        advancedSearch: advancedSearch,
        clearSearchFilters: clearSearchFilters,

        foodTemplateList: foodTemplateHelper.foodTemplateList,

        nameFilter: nameFilter,
        quantityFilter: quantityFilter,
        foodTemplateIdFilter: foodTemplateIdFilter,
        specificObservationsFilter: specificObservationsFilter,
        locationFilter: locationFilter,
        progressFilter: progressFilter,
        expiredFilter: expiredFilter,
        liquidFilter: liquidFilter,
        ratingFilter: ratingFilter,
        feedbackFromBeneficiaryFilter: feedbackFromBeneficiaryFilter,
        deliveredByFilter: deliveredByFilter,
        deliveredToFilter: deliveredToFilter,
        orderDateTimeFromFilter: orderDateTimeFromFilter,
        orderDateTimeToFilter: orderDateTimeToFilter,
        cookedDateTimeFromFilter: cookedDateTimeFromFilter,
        cookedDateTimeToFilter: cookedDateTimeToFilter,
        pickupDateTimeFromFilter: pickupDateTimeFromFilter,
        pickupDateTimeToFilter: pickupDateTimeToFilter,
        storageDateTimeFromFilter: storageDateTimeFromFilter,
        storageDateTimeToFilter: storageDateTimeToFilter,
        deliveryDateTimeFromFilter: deliveryDateTimeFromFilter,
        deliveryDateTimeToFilter: deliveryDateTimeToFilter,
        activeFilter: activeFilter,
    }
};



// view model

Web.foodViewModel = function () {
    var foodId = ko.observable(-1);
    var name = ko.observable('');
    var quantity = ko.observable('');
    var foodTemplateId = ko.observable(-1);
    var specificObservations = ko.observable('');
    var location = ko.observable('');
    var progress = ko.observable('');
    var expired = ko.observable('');
    var liquid = ko.observable('');
    var rating = ko.observable('');
    var feedbackFromBeneficiary = ko.observable('');
    var deliveredBy = ko.observable('');
    var deliveredTo = ko.observable('');
    var orderDateTime = ko.observable('');
    var cookedDateTime = ko.observable('');
    var pickupDateTime = ko.observable('');
    var storageDateTime = ko.observable('');
    var deliveryDateTime = ko.observable('');
    var active = ko.observable('');
    var isDeleted = ko.observable('');

    var editUrl = ko.observable('');

    var visibleOnSearch = ko.observable(true);
 
    // load

    var load = function (data) {
        foodId(data.foodId);
        name(data.name);
        quantity(data.quantity);
        foodTemplateId(data.foodTemplateId);
        specificObservations(data.specificObservations);
        location(data.location);
        progress(data.progress);
        expired(data.expired);
        liquid(data.liquid);
        rating(data.rating);
        feedbackFromBeneficiary(data.feedbackFromBeneficiary);
        deliveredBy(data.deliveredBy);
        deliveredTo(data.deliveredTo);
        orderDateTime(data.orderDateTime);
        cookedDateTime(data.cookedDateTime);
        pickupDateTime(data.pickupDateTime);
        storageDateTime(data.storageDateTime);
        deliveryDateTime(data.deliveryDateTime);
        active(data.active);
        isDeleted(data.isDeleted);
        editUrl(data.editUrl);
    };



    return {
        foodId: foodId,
        name: name,
        quantity: quantity,
        foodTemplateId: foodTemplateId,
        specificObservations: specificObservations,
        location: location,
        progress: progress,
        expired: expired,
        liquid: liquid,
        rating: rating,
        feedbackFromBeneficiary: feedbackFromBeneficiary,
        deliveredBy: deliveredBy,
        deliveredTo: deliveredTo,
        orderDateTime: orderDateTime,
        cookedDateTime: cookedDateTime,
        pickupDateTime: pickupDateTime,
        storageDateTime: storageDateTime,
        deliveryDateTime: deliveryDateTime,
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






    