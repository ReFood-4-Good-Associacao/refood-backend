
// ################################################################
//                      Code generated with T4
// ################################################################

var Web = Web || {};

Web.foodViewModel = function (moduleId, resx) {
    var baseUrl = "/api/FoodApi/";

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
    var userList = ko.observableArray([]);
    var isLoading = ko.observable(false);



    // helpers

    var foodTemplateHelper = Web.foodTemplateHelper(isLoading, '/', function(){});



    // init

    var init = function () {
        var qs = getQueryStrings();
        var foodId = qs["tid"];
        if (foodId) {
            getFood(foodId);
        }
        //getUserList();

        foodTemplateHelper.getFoodTemplateList();
    };

    var getQueryStrings = function () {
        var assoc = {};
        var decode = function (s) { return decodeURIComponent(s.replace(/\+/g, " ")); };
        var queryString = location.search.substring(1);
        var keyValues = queryString.split('&');

        for (var i = 0; i < keyValues.length; i++) {
            var key = keyValues[i].split('=');
            if (key.length > 1) {
                assoc[decode(key[0])] = decode(key[1]);
            }
        }

        return addRewriteQueryString(assoc, decode);
    };

    var addRewriteQueryString = function (hash, decode) {
        var path = location.pathname;
        var queryString = path.substring(path.search('/ctl/') + 1);
        var keyValues = queryString.split('/');

        for (var i = 0; i < keyValues.length; i += 2) {
            hash[decode(keyValues[i])] = decode(keyValues[i + 1])
        }

        return hash;
    };



    // get

    var getFood = function (foodId) {
        isLoading(true);

        var restUrl = baseUrl + "Get/" + foodId;
        var jqXHR = $.ajax({
            url: restUrl,
            dataType: "json"
        }).done(function (data) {
            if (data) {
                load(data);
            }
            else {
                clear();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };



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
        orderDateTime(serverDateTimeStringToJavascriptDate(data.orderDateTime));
        cookedDateTime(serverDateTimeStringToJavascriptDate(data.cookedDateTime));
        pickupDateTime(serverDateTimeStringToJavascriptDate(data.pickupDateTime));
        storageDateTime(serverDateTimeStringToJavascriptDate(data.storageDateTime));
        deliveryDateTime(serverDateTimeStringToJavascriptDate(data.deliveryDateTime));
        active(data.active);
        isDeleted(data.isDeleted);
    };

    

    // save

    var save = function () {
        isLoading(true);
        var food = {
            foodId: foodId(),
            name: name(),
            quantity: quantity(),
            foodTemplateId: foodTemplateId(),
            specificObservations: specificObservations(),
            location: location(),
            progress: progress(),
            expired: expired(),
            liquid: liquid(),
            rating: rating(),
            feedbackFromBeneficiary: feedbackFromBeneficiary(),
            deliveredBy: deliveredBy(),
            deliveredTo: deliveredTo(),
            orderDateTime: dateToStringServerFormat(orderDateTime()),
            cookedDateTime: dateToStringServerFormat(cookedDateTime()),
            pickupDateTime: dateToStringServerFormat(pickupDateTime()),
            storageDateTime: dateToStringServerFormat(storageDateTime()),
            deliveryDateTime: dateToStringServerFormat(deliveryDateTime()),
            active: active(),
            isDeleted: isDeleted(),
        };
        var ajaxMethod = "POST";
        var restUrl = baseUrl + "Upsert/";

        if (food.foodId > 0) {
            // ajaxMethod = "PATCH";
            restUrl += food.foodId;
        }
        else {
            restUrl += 0;
        }

        var jqXHR = $.ajax({
            method: ajaxMethod,
            url: restUrl,
            contentType: "application/json; charset=UTF-8",
            data: JSON.stringify(food),
            dataType: "json"
        }).done(function (data) {
            console.log(data);
            toastr.success('Gravado com sucesso');
        }).always(function (data) {
            isLoading(false);
        });
    };

    // clear

    var clear = function () {
        foodId('');
        name('');
        quantity('');
        foodTemplateId('');
        specificObservations('');
        location('');
        progress('');
        expired('');
        liquid('');
        rating('');
        feedbackFromBeneficiary('');
        deliveredBy('');
        deliveredTo('');
        orderDateTime('');
        cookedDateTime('');
        pickupDateTime('');
        storageDateTime('');
        deliveryDateTime('');
        active('');
        isDeleted('');
    };


    
    // cancel

    var cancel = function () {
        dnnModal.closePopUp(false);
    };



    // return viewmodel

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
        userList: userList,
        cancel: cancel,
        load: load,
        save: save,
        init: init,
        isLoading: isLoading,
        foodTemplateList: foodTemplateHelper.foodTemplateList,
    };
}

Web.user = function (id, name) {
    this.id = id;
    this.name = name;
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

function serverDateTimeStringToJavascriptDate(dateString) {

    // server format: 2017-10-20T00:00:00
    // desired format: 20-10-2017

    var date;
    if (dateString != null && dateString.length >= 10) {

        var day = dateString.substring(8, 10);
        // javascript datetime months have a zero based index
        var month = dateString != null ? parseInt(dateString.substring(5, 7)) - 1 : 0; 
        var year = dateString.substring(0, 4);

        var hours = dateString.substring(11, 13);
        var minutes = dateString.substring(14, 16);
        var seconds = dateString.substring(17, 19);

        date = new Date(year, month, day, hours, minutes, seconds);
    }
    return date;
}

function dateTimeToStringServerFormat(d) {
    // server format: 2017-10-20T00:00:00
    if (d != null)
    {
        var datestring = d.getFullYear() + "-" + ("0" + (d.getMonth() + 1)).slice(-2) + "-" + ("0" + d.getDate()).slice(-2)
            + "T" + ("0" + d.getHours()).slice(-2) + ":" + ("0" + d.getMinutes()).slice(-2) + ":00";
        return datestring;
    }
    else
    {
        return null;
    }
}



    