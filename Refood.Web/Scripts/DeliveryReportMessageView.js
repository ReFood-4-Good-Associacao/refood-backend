
// ################################################################
//                      Code generated with T4
// ################################################################

var Web = Web || {};

Web.deliveryReportMessageListViewModel = function (moduleId, resx) {
    var baseUrl = "api/DeliveryReportMessageApi/";

    var isLoading = ko.observable(false);
    var deliveryReportMessageList = ko.observableArray([]);
    var editMode = ko.computed(function () {
        return deliveryReportMessageList().length > 0 && deliveryReportMessageList()[0].editUrl() != null && deliveryReportMessageList()[0].editUrl().length > 0;
    });
    var searchText = ko.observable('');



    // filters

    var deliveryReportMessageTypeIdFilter = ko.observable(-1);
    var messageFilter = ko.observable('');



    // helpers

    var deliveryReportMessageTypeHelper = Web.deliveryReportMessageTypeHelper(isLoading, '/', function(){});



    // init

    var init = function () {
        //getDeliveryReportMessageList();
        //getDeliveryReportMessagePage();
        getDeliveryReportMessageListAdvanced();

        deliveryReportMessageTypeHelper.getDeliveryReportMessageTypeList();
    }



    // get list

    var getDeliveryReportMessageList = function () {
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
                deliveryReportMessageList.removeAll();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };



    // get list - advanced search

    var getDeliveryReportMessageListAdvanced = function () {
        isLoading(true);

        var searchFilters = "?";
        searchFilters += (deliveryReportMessageTypeIdFilter() != -1 && deliveryReportMessageTypeIdFilter() != undefined ? "&" + "deliveryReportMessageTypeId=" + deliveryReportMessageTypeIdFilter() : "");
        searchFilters += (messageFilter() != '' ? "message=" + messageFilter() : "");

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
                deliveryReportMessageList.removeAll();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };

    var advancedSearch = function () {
        getDeliveryReportMessageListAdvanced();
    };

    var clearSearchFilters = function () {
        deliveryReportMessageTypeIdFilter(-1);
        messageFilter('');
    };



    // get list by page

    var getDeliveryReportMessagePage = function () {
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
                deliveryReportMessageList.removeAll();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };



    // delete

    var deleteDeliveryReportMessage = function (deliveryReportMessage) {
        isLoading(true);
        var restUrl = baseUrl + "Delete/" + deliveryReportMessage.deliveryReportMessageId();
        var jqXHR = $.ajax({
            url: restUrl,
            dataType: "json"
        }).done(function () {
            console.log("Deleted: " + deliveryReportMessage.deliveryReportMessageId());
            deliveryReportMessageList.remove(deliveryReportMessage);
        }).fail(function () {
            console.log("Error");
        }).always(function (data) {
            console.log("finished");
            isLoading(false);
        });
    }

    var deleteDeliveryReportMessageById = function (deliveryReportMessageId) {
        isLoading(true);
        var restUrl = baseUrl + "Delete/" + deliveryReportMessageId;
        var jqXHR = $.ajax({
            method: "GET",
            url: restUrl,
            dataType: "json"
        }).done(function () {
            console.log("Deleted: " + deliveryReportMessageId);
            //deliveryReportMessageList.remove(deliveryReportMessage);
            // refresh
            getDeliveryReportMessageList();
        }).fail(function () {
            console.log("Error");
        }).always(function (data) {
            console.log("finished");
            isLoading(false);
        });
    }



    // load

    var load = function (data) {
        deliveryReportMessageList.removeAll();
        var underlyingArray = deliveryReportMessageList();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var deliveryReportMessage = new Web.deliveryReportMessageViewModel();
            deliveryReportMessage.load(result);
            underlyingArray.push(deliveryReportMessage);
        }
        deliveryReportMessageList.valueHasMutated();
    };



    // data table

    var updateDatatable = function (data) {
        var dataArray = new Array();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var fieldsInArray = new Array();

            fieldsInArray.push(result.deliveryReportMessageTypeId);
            fieldsInArray.push(result.message);

            var viewLinkElement = '<a href=\"' + result.editUrl + '\" style=\"margin-right: 10px;\">View</a>';
            var editLinkElement = '<a href=\"' + result.editUrl + '\" style=\"margin-right: 10px;\">Edit</a>';
            var deleteLinkElement = '<a href=\"' + 'javascript:vm.deleteDeliveryReportMessageById(' + result.deliveryReportMessageId + ');' + '\" style=\"margin-right: 10px;\">Delete</a>';
            fieldsInArray.push(viewLinkElement + editLinkElement + deleteLinkElement);

            dataArray.push(fieldsInArray);
        }

        var datatable = $("#DeliveryReportMessagesTable-" + moduleId).DataTable();
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
        deliveryReportMessageList: deliveryReportMessageList,
        getDeliveryReportMessageList: getDeliveryReportMessageList,
        getDeliveryReportMessagePage: getDeliveryReportMessagePage,
        deleteDeliveryReportMessage: deleteDeliveryReportMessage,
        deleteDeliveryReportMessageById: deleteDeliveryReportMessageById,
        editMode: editMode,
        isLoading: isLoading,
        searchText: searchText,
        openCreateForm: openCreateForm,
        getDeliveryReportMessageListAdvanced: getDeliveryReportMessageListAdvanced,
        advancedSearch: advancedSearch,
        clearSearchFilters: clearSearchFilters,

        deliveryReportMessageTypeList: deliveryReportMessageTypeHelper.deliveryReportMessageTypeList,

        deliveryReportMessageTypeIdFilter: deliveryReportMessageTypeIdFilter,
        messageFilter: messageFilter,
    }
};



// view model

Web.deliveryReportMessageViewModel = function () {
    var deliveryReportMessageId = ko.observable(-1);
    var deliveryReportMessageTypeId = ko.observable(-1);
    var message = ko.observable('');
    var isDeleted = ko.observable('');

    var editUrl = ko.observable('');

    var visibleOnSearch = ko.observable(true);
 
    // load

    var load = function (data) {
        deliveryReportMessageId(data.deliveryReportMessageId);
        deliveryReportMessageTypeId(data.deliveryReportMessageTypeId);
        message(data.message);
        isDeleted(data.isDeleted);
        editUrl(data.editUrl);
    };



    return {
        deliveryReportMessageId: deliveryReportMessageId,
        deliveryReportMessageTypeId: deliveryReportMessageTypeId,
        message: message,
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






    