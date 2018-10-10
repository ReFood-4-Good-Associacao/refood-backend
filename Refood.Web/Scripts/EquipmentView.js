
// ################################################################
//                      Code generated with T4
// ################################################################

var Web = Web || {};

Web.equipmentListViewModel = function (moduleId, resx) {
    var baseUrl = "api/EquipmentApi/";

    var isLoading = ko.observable(false);
    var equipmentList = ko.observableArray([]);
    var editMode = ko.computed(function () {
        return equipmentList().length > 0 && equipmentList()[0].editUrl() != null && equipmentList()[0].editUrl().length > 0;
    });
    var searchText = ko.observable('');



    // filters

    var nameFilter = ko.observable('');
    var descriptionFilter = ko.observable('');
    var categoryFilter = ko.observable('');
    var photoFilter = ko.observable('');
    var quantityInStockFilter = ko.observable('');
    var minimumQuantityNeededFilter = ko.observable('');
    var pricePerUnitFilter = ko.observable('');
    var storageLocationFilter = ko.observable('');
    var activeFilter = ko.observable('');



    // helpers




    // init

    var init = function () {
        //getEquipmentList();
        //getEquipmentPage();
        getEquipmentListAdvanced();

    }



    // get list

    var getEquipmentList = function () {
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
                equipmentList.removeAll();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };



    // get list - advanced search

    var getEquipmentListAdvanced = function () {
        isLoading(true);

        var searchFilters = "?";
        searchFilters += (nameFilter() != '' ? "name=" + nameFilter() : "");
        searchFilters += (descriptionFilter() != '' ? "description=" + descriptionFilter() : "");
        searchFilters += (categoryFilter() != '' ? "category=" + categoryFilter() : "");
        searchFilters += (photoFilter() != '' ? "photo=" + photoFilter() : "");
        searchFilters += (quantityInStockFilter() != '' ? "quantityInStock=" + quantityInStockFilter() : "");
        searchFilters += (minimumQuantityNeededFilter() != '' ? "minimumQuantityNeeded=" + minimumQuantityNeededFilter() : "");
        searchFilters += (pricePerUnitFilter() != '' ? "pricePerUnit=" + pricePerUnitFilter() : "");
        searchFilters += (storageLocationFilter() != '' ? "storageLocation=" + storageLocationFilter() : "");
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
                equipmentList.removeAll();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };

    var advancedSearch = function () {
        getEquipmentListAdvanced();
    };

    var clearSearchFilters = function () {
        nameFilter('');
        descriptionFilter('');
        categoryFilter('');
        photoFilter('');
        quantityInStockFilter('');
        minimumQuantityNeededFilter('');
        pricePerUnitFilter('');
        storageLocationFilter('');
        activeFilter('');
    };



    // get list by page

    var getEquipmentPage = function () {
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
                equipmentList.removeAll();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };



    // delete

    var deleteEquipment = function (equipment) {
        isLoading(true);
        var restUrl = baseUrl + "Delete/" + equipment.equipmentId();
        var jqXHR = $.ajax({
            url: restUrl,
            dataType: "json"
        }).done(function () {
            console.log("Deleted: " + equipment.equipmentId());
            equipmentList.remove(equipment);
        }).fail(function () {
            console.log("Error");
        }).always(function (data) {
            console.log("finished");
            isLoading(false);
        });
    }

    var deleteEquipmentById = function (equipmentId) {
        isLoading(true);
        var restUrl = baseUrl + "Delete/" + equipmentId;
        var jqXHR = $.ajax({
            method: "GET",
            url: restUrl,
            dataType: "json"
        }).done(function () {
            console.log("Deleted: " + equipmentId);
            //equipmentList.remove(equipment);
            // refresh
            getEquipmentList();
        }).fail(function () {
            console.log("Error");
        }).always(function (data) {
            console.log("finished");
            isLoading(false);
        });
    }



    // load

    var load = function (data) {
        equipmentList.removeAll();
        var underlyingArray = equipmentList();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var equipment = new Web.equipmentViewModel();
            equipment.load(result);
            underlyingArray.push(equipment);
        }
        equipmentList.valueHasMutated();
    };



    // data table

    var updateDatatable = function (data) {
        var dataArray = new Array();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var fieldsInArray = new Array();

            fieldsInArray.push(result.name);
            fieldsInArray.push(result.description);
            fieldsInArray.push(result.category);
            fieldsInArray.push(result.photo);
            fieldsInArray.push(result.quantityInStock);
            fieldsInArray.push(result.minimumQuantityNeeded);
            fieldsInArray.push(result.pricePerUnit);
            fieldsInArray.push(result.storageLocation);
            fieldsInArray.push(result.active);

            var viewLinkElement = '<a href=\"' + result.editUrl + '\" style=\"margin-right: 10px;\">View</a>';
            var editLinkElement = '<a href=\"' + result.editUrl + '\" style=\"margin-right: 10px;\">Edit</a>';
            var deleteLinkElement = '<a href=\"' + 'javascript:vm.deleteEquipmentById(' + result.equipmentId + ');' + '\" style=\"margin-right: 10px;\">Delete</a>';
            fieldsInArray.push(viewLinkElement + editLinkElement + deleteLinkElement);

            dataArray.push(fieldsInArray);
        }

        var datatable = $("#EquipmentsTable-" + moduleId).DataTable();
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
        equipmentList: equipmentList,
        getEquipmentList: getEquipmentList,
        getEquipmentPage: getEquipmentPage,
        deleteEquipment: deleteEquipment,
        deleteEquipmentById: deleteEquipmentById,
        editMode: editMode,
        isLoading: isLoading,
        searchText: searchText,
        openCreateForm: openCreateForm,
        getEquipmentListAdvanced: getEquipmentListAdvanced,
        advancedSearch: advancedSearch,
        clearSearchFilters: clearSearchFilters,


        nameFilter: nameFilter,
        descriptionFilter: descriptionFilter,
        categoryFilter: categoryFilter,
        photoFilter: photoFilter,
        quantityInStockFilter: quantityInStockFilter,
        minimumQuantityNeededFilter: minimumQuantityNeededFilter,
        pricePerUnitFilter: pricePerUnitFilter,
        storageLocationFilter: storageLocationFilter,
        activeFilter: activeFilter,
    }
};



// view model

Web.equipmentViewModel = function () {
    var equipmentId = ko.observable(-1);
    var name = ko.observable('');
    var description = ko.observable('');
    var category = ko.observable('');
    var photo = ko.observable('');
    var quantityInStock = ko.observable('');
    var minimumQuantityNeeded = ko.observable('');
    var pricePerUnit = ko.observable('');
    var storageLocation = ko.observable('');
    var active = ko.observable('');
    var isDeleted = ko.observable('');

    var editUrl = ko.observable('');

    var visibleOnSearch = ko.observable(true);
 
    // load

    var load = function (data) {
        equipmentId(data.equipmentId);
        name(data.name);
        description(data.description);
        category(data.category);
        photo(data.photo);
        quantityInStock(data.quantityInStock);
        minimumQuantityNeeded(data.minimumQuantityNeeded);
        pricePerUnit(data.pricePerUnit);
        storageLocation(data.storageLocation);
        active(data.active);
        isDeleted(data.isDeleted);
        editUrl(data.editUrl);
    };



    return {
        equipmentId: equipmentId,
        name: name,
        description: description,
        category: category,
        photo: photo,
        quantityInStock: quantityInStock,
        minimumQuantityNeeded: minimumQuantityNeeded,
        pricePerUnit: pricePerUnit,
        storageLocation: storageLocation,
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






    