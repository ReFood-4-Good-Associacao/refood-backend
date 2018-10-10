
// ################################################################
//                      Code generated with T4
// ################################################################

var Web = Web || {};

Web.volunteerListViewModel = function (moduleId, resx) {
    var baseUrl = "api/VolunteerApi/";

    var isLoading = ko.observable(false);
    var volunteerList = ko.observableArray([]);
    var editMode = ko.computed(function () {
        return volunteerList().length > 0 && volunteerList()[0].editUrl() != null && volunteerList()[0].editUrl().length > 0;
    });
    var searchText = ko.observable('');



    // filters

    var nameFilter = ko.observable('');
    var genderFilter = ko.observable('');
    var birthDateFromFilter = ko.observable('');
    var birthDateToFilter = ko.observable('');
    var occupationFilter = ko.observable('');
    var employerFilter = ko.observable('');
    var phoneFilter = ko.observable('');
    var emailFilter = ko.observable('');
    var identityCardNumberFilter = ko.observable('');
    var countryIdFilter = ko.observable(-1);
    var friendOrFamilyContactFilter = ko.observable('');
    var photoFilter = ko.observable('');
    var addressIdFilter = ko.observable(-1);
    var hasCarFilter = ko.observable('');
    var hasDriverLicenseFilter = ko.observable('');
    var hasBikeFilter = ko.observable('');
    var vehicleMakeFilter = ko.observable('');
    var vehicleModelFilter = ko.observable('');
    var activeFilter = ko.observable('');



    // helpers

    var countryHelper = Web.countryHelper(isLoading, '/', function(){});
    var addressHelper = Web.addressHelper(isLoading, '/', function(){});



    // init

    var init = function () {
        //getVolunteerList();
        //getVolunteerPage();
        getVolunteerListAdvanced();

        countryHelper.getCountryList();
        addressHelper.getAddressList();
    }



    // get list

    var getVolunteerList = function () {
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
                volunteerList.removeAll();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };



    // get list - advanced search

    var getVolunteerListAdvanced = function () {
        isLoading(true);

        var searchFilters = "?";
        searchFilters += (nameFilter() != '' ? "name=" + nameFilter() : "");
        searchFilters += (genderFilter() != '' ? "gender=" + genderFilter() : "");
        searchFilters += (birthDateFromFilter() != '' && birthDateFromFilter() != null ? "&" + "birthDateFrom=" + dateToStringServerFormat(birthDateFromFilter()) : "");
        searchFilters += (birthDateToFilter() != '' && birthDateToFilter() != null ? "&" + "birthDateTo=" + dateToStringServerFormat(birthDateToFilter()) : "");
        searchFilters += (occupationFilter() != '' ? "occupation=" + occupationFilter() : "");
        searchFilters += (employerFilter() != '' ? "employer=" + employerFilter() : "");
        searchFilters += (phoneFilter() != '' ? "phone=" + phoneFilter() : "");
        searchFilters += (emailFilter() != '' ? "email=" + emailFilter() : "");
        searchFilters += (identityCardNumberFilter() != '' ? "identityCardNumber=" + identityCardNumberFilter() : "");
        searchFilters += (countryIdFilter() != -1 && countryIdFilter() != undefined ? "&" + "countryId=" + countryIdFilter() : "");
        searchFilters += (friendOrFamilyContactFilter() != '' ? "friendOrFamilyContact=" + friendOrFamilyContactFilter() : "");
        searchFilters += (photoFilter() != '' ? "photo=" + photoFilter() : "");
        searchFilters += (addressIdFilter() != -1 && addressIdFilter() != undefined ? "&" + "addressId=" + addressIdFilter() : "");
        searchFilters += (hasCarFilter() != '' ? "hasCar=" + hasCarFilter() : "");
        searchFilters += (hasDriverLicenseFilter() != '' ? "hasDriverLicense=" + hasDriverLicenseFilter() : "");
        searchFilters += (hasBikeFilter() != '' ? "hasBike=" + hasBikeFilter() : "");
        searchFilters += (vehicleMakeFilter() != '' ? "vehicleMake=" + vehicleMakeFilter() : "");
        searchFilters += (vehicleModelFilter() != '' ? "vehicleModel=" + vehicleModelFilter() : "");
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
                volunteerList.removeAll();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };

    var advancedSearch = function () {
        getVolunteerListAdvanced();
    };

    var clearSearchFilters = function () {
        nameFilter('');
        genderFilter('');
        birthDateFromFilter('');
        birthDateToFilter('');
        occupationFilter('');
        employerFilter('');
        phoneFilter('');
        emailFilter('');
        identityCardNumberFilter('');
        countryIdFilter(-1);
        friendOrFamilyContactFilter('');
        photoFilter('');
        addressIdFilter(-1);
        hasCarFilter('');
        hasDriverLicenseFilter('');
        hasBikeFilter('');
        vehicleMakeFilter('');
        vehicleModelFilter('');
        activeFilter('');
    };



    // get list by page

    var getVolunteerPage = function () {
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
                volunteerList.removeAll();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };



    // delete

    var deleteVolunteer = function (volunteer) {
        isLoading(true);
        var restUrl = baseUrl + "Delete/" + volunteer.volunteerId();
        var jqXHR = $.ajax({
            url: restUrl,
            dataType: "json"
        }).done(function () {
            console.log("Deleted: " + volunteer.volunteerId());
            volunteerList.remove(volunteer);
        }).fail(function () {
            console.log("Error");
        }).always(function (data) {
            console.log("finished");
            isLoading(false);
        });
    }

    var deleteVolunteerById = function (volunteerId) {
        isLoading(true);
        var restUrl = baseUrl + "Delete/" + volunteerId;
        var jqXHR = $.ajax({
            method: "GET",
            url: restUrl,
            dataType: "json"
        }).done(function () {
            console.log("Deleted: " + volunteerId);
            //volunteerList.remove(volunteer);
            // refresh
            getVolunteerList();
        }).fail(function () {
            console.log("Error");
        }).always(function (data) {
            console.log("finished");
            isLoading(false);
        });
    }



    // load

    var load = function (data) {
        volunteerList.removeAll();
        var underlyingArray = volunteerList();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var volunteer = new Web.volunteerViewModel();
            volunteer.load(result);
            underlyingArray.push(volunteer);
        }
        volunteerList.valueHasMutated();
    };



    // data table

    var updateDatatable = function (data) {
        var dataArray = new Array();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var fieldsInArray = new Array();

            fieldsInArray.push(result.name);
            fieldsInArray.push(result.gender);
            fieldsInArray.push(result.birthDate);
            fieldsInArray.push(result.occupation);
            fieldsInArray.push(result.employer);
            fieldsInArray.push(result.phone);
            fieldsInArray.push(result.email);
            fieldsInArray.push(result.identityCardNumber);
            fieldsInArray.push(result.countryId);
            fieldsInArray.push(result.friendOrFamilyContact);
            fieldsInArray.push(result.photo);
            fieldsInArray.push(result.addressId);
            fieldsInArray.push(result.hasCar);
            fieldsInArray.push(result.hasDriverLicense);
            fieldsInArray.push(result.hasBike);
            fieldsInArray.push(result.vehicleMake);
            fieldsInArray.push(result.vehicleModel);
            fieldsInArray.push(result.active);

            var viewLinkElement = '<a href=\"' + result.editUrl + '\" style=\"margin-right: 10px;\">View</a>';
            var editLinkElement = '<a href=\"' + result.editUrl + '\" style=\"margin-right: 10px;\">Edit</a>';
            var deleteLinkElement = '<a href=\"' + 'javascript:vm.deleteVolunteerById(' + result.volunteerId + ');' + '\" style=\"margin-right: 10px;\">Delete</a>';
            fieldsInArray.push(viewLinkElement + editLinkElement + deleteLinkElement);

            dataArray.push(fieldsInArray);
        }

        var datatable = $("#VolunteersTable-" + moduleId).DataTable();
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
        volunteerList: volunteerList,
        getVolunteerList: getVolunteerList,
        getVolunteerPage: getVolunteerPage,
        deleteVolunteer: deleteVolunteer,
        deleteVolunteerById: deleteVolunteerById,
        editMode: editMode,
        isLoading: isLoading,
        searchText: searchText,
        openCreateForm: openCreateForm,
        getVolunteerListAdvanced: getVolunteerListAdvanced,
        advancedSearch: advancedSearch,
        clearSearchFilters: clearSearchFilters,

        countryList: countryHelper.countryList,
        addressList: addressHelper.addressList,

        nameFilter: nameFilter,
        genderFilter: genderFilter,
        birthDateFromFilter: birthDateFromFilter,
        birthDateToFilter: birthDateToFilter,
        occupationFilter: occupationFilter,
        employerFilter: employerFilter,
        phoneFilter: phoneFilter,
        emailFilter: emailFilter,
        identityCardNumberFilter: identityCardNumberFilter,
        countryIdFilter: countryIdFilter,
        friendOrFamilyContactFilter: friendOrFamilyContactFilter,
        photoFilter: photoFilter,
        addressIdFilter: addressIdFilter,
        hasCarFilter: hasCarFilter,
        hasDriverLicenseFilter: hasDriverLicenseFilter,
        hasBikeFilter: hasBikeFilter,
        vehicleMakeFilter: vehicleMakeFilter,
        vehicleModelFilter: vehicleModelFilter,
        activeFilter: activeFilter,
    }
};



// view model

Web.volunteerViewModel = function () {
    var volunteerId = ko.observable(-1);
    var name = ko.observable('');
    var gender = ko.observable('');
    var birthDate = ko.observable('');
    var occupation = ko.observable('');
    var employer = ko.observable('');
    var phone = ko.observable('');
    var email = ko.observable('');
    var identityCardNumber = ko.observable('');
    var countryId = ko.observable(-1);
    var friendOrFamilyContact = ko.observable('');
    var photo = ko.observable('');
    var addressId = ko.observable(-1);
    var hasCar = ko.observable('');
    var hasDriverLicense = ko.observable('');
    var hasBike = ko.observable('');
    var vehicleMake = ko.observable('');
    var vehicleModel = ko.observable('');
    var active = ko.observable('');
    var isDeleted = ko.observable('');

    var editUrl = ko.observable('');

    var visibleOnSearch = ko.observable(true);
 
    // load

    var load = function (data) {
        volunteerId(data.volunteerId);
        name(data.name);
        gender(data.gender);
        birthDate(data.birthDate);
        occupation(data.occupation);
        employer(data.employer);
        phone(data.phone);
        email(data.email);
        identityCardNumber(data.identityCardNumber);
        countryId(data.countryId);
        friendOrFamilyContact(data.friendOrFamilyContact);
        photo(data.photo);
        addressId(data.addressId);
        hasCar(data.hasCar);
        hasDriverLicense(data.hasDriverLicense);
        hasBike(data.hasBike);
        vehicleMake(data.vehicleMake);
        vehicleModel(data.vehicleModel);
        active(data.active);
        isDeleted(data.isDeleted);
        editUrl(data.editUrl);
    };



    return {
        volunteerId: volunteerId,
        name: name,
        gender: gender,
        birthDate: birthDate,
        occupation: occupation,
        employer: employer,
        phone: phone,
        email: email,
        identityCardNumber: identityCardNumber,
        countryId: countryId,
        friendOrFamilyContact: friendOrFamilyContact,
        photo: photo,
        addressId: addressId,
        hasCar: hasCar,
        hasDriverLicense: hasDriverLicense,
        hasBike: hasBike,
        vehicleMake: vehicleMake,
        vehicleModel: vehicleModel,
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






    