
// ################################################################
//                      Code generated with T4
// ################################################################

var Web = Web || {};

Web.partnerListViewModel = function (moduleId, resx) {
    var baseUrl = "api/PartnerApi/";

    var isLoading = ko.observable(false);
    var partnerList = ko.observableArray([]);
    var editMode = ko.computed(function () {
        return partnerList().length > 0 && partnerList()[0].editUrl() != null && partnerList()[0].editUrl().length > 0;
    });
    var searchText = ko.observable('');



    // filters

    var nucleoIdFilter = ko.observable(-1);
    var nameFilter = ko.observable('');
    var enterpriseContributorFilter = ko.observable('');
    var privateContributorFilter = ko.observable('');
    var contributionTypeIdFilter = ko.observable(-1);
    var partnershipTypeIdFilter = ko.observable(-1);
    var contactPersonFilter = ko.observable('');
    var departmentFilter = ko.observable('');
    var phoneFilter = ko.observable('');
    var emailFilter = ko.observable('');
    var ibanFilter = ko.observable('');
    var bicSwiftFilter = ko.observable('');
    var fiscalNumberFilter = ko.observable('');
    var latitudeFilter = ko.observable('');
    var longitudeFilter = ko.observable('');
    var photoUrlFilter = ko.observable('');
    var addressIdFilter = ko.observable(-1);
    var partnershipStartDateFromFilter = ko.observable('');
    var partnershipStartDateToFilter = ko.observable('');
    var durationCommitmentFromFilter = ko.observable('');
    var durationCommitmentToFilter = ko.observable('');
    var refoodAreaInteractionFilter = ko.observable('');
    var reliabilityFilter = ko.observable('');
    var interactionFrequencyFilter = ko.observable('');
    var activeFilter = ko.observable('');



    // helpers

    var nucleoHelper = Web.nucleoHelper(isLoading, '/', function(){});
    var contributionTypeHelper = Web.contributionTypeHelper(isLoading, '/', function(){});
    var partnershipTypeHelper = Web.partnershipTypeHelper(isLoading, '/', function(){});
    var addressHelper = Web.addressHelper(isLoading, '/', function(){});



    // init

    var init = function () {
        //getPartnerList();
        //getPartnerPage();
        getPartnerListAdvanced();

        nucleoHelper.getNucleoList();
        contributionTypeHelper.getContributionTypeList();
        partnershipTypeHelper.getPartnershipTypeList();
        addressHelper.getAddressList();
    }



    // get list

    var getPartnerList = function () {
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
                partnerList.removeAll();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };



    // get list - advanced search

    var getPartnerListAdvanced = function () {
        isLoading(true);

        var searchFilters = "?";
        searchFilters += (nucleoIdFilter() != -1 && nucleoIdFilter() != undefined ? "&" + "nucleoId=" + nucleoIdFilter() : "");
        searchFilters += (nameFilter() != '' ? "name=" + nameFilter() : "");
        searchFilters += (enterpriseContributorFilter() != '' ? "enterpriseContributor=" + enterpriseContributorFilter() : "");
        searchFilters += (privateContributorFilter() != '' ? "privateContributor=" + privateContributorFilter() : "");
        searchFilters += (contributionTypeIdFilter() != -1 && contributionTypeIdFilter() != undefined ? "&" + "contributionTypeId=" + contributionTypeIdFilter() : "");
        searchFilters += (partnershipTypeIdFilter() != -1 && partnershipTypeIdFilter() != undefined ? "&" + "partnershipTypeId=" + partnershipTypeIdFilter() : "");
        searchFilters += (contactPersonFilter() != '' ? "contactPerson=" + contactPersonFilter() : "");
        searchFilters += (departmentFilter() != '' ? "department=" + departmentFilter() : "");
        searchFilters += (phoneFilter() != '' ? "phone=" + phoneFilter() : "");
        searchFilters += (emailFilter() != '' ? "email=" + emailFilter() : "");
        searchFilters += (ibanFilter() != '' ? "iban=" + ibanFilter() : "");
        searchFilters += (bicSwiftFilter() != '' ? "bicSwift=" + bicSwiftFilter() : "");
        searchFilters += (fiscalNumberFilter() != '' ? "fiscalNumber=" + fiscalNumberFilter() : "");
        searchFilters += (latitudeFilter() != '' ? "latitude=" + latitudeFilter() : "");
        searchFilters += (longitudeFilter() != '' ? "longitude=" + longitudeFilter() : "");
        searchFilters += (photoUrlFilter() != '' ? "photoUrl=" + photoUrlFilter() : "");
        searchFilters += (addressIdFilter() != -1 && addressIdFilter() != undefined ? "&" + "addressId=" + addressIdFilter() : "");
        searchFilters += (partnershipStartDateFromFilter() != '' && partnershipStartDateFromFilter() != null ? "&" + "partnershipStartDateFrom=" + dateToStringServerFormat(partnershipStartDateFromFilter()) : "");
        searchFilters += (partnershipStartDateToFilter() != '' && partnershipStartDateToFilter() != null ? "&" + "partnershipStartDateTo=" + dateToStringServerFormat(partnershipStartDateToFilter()) : "");
        searchFilters += (durationCommitmentFromFilter() != '' && durationCommitmentFromFilter() != null ? "&" + "durationCommitmentFrom=" + dateToStringServerFormat(durationCommitmentFromFilter()) : "");
        searchFilters += (durationCommitmentToFilter() != '' && durationCommitmentToFilter() != null ? "&" + "durationCommitmentTo=" + dateToStringServerFormat(durationCommitmentToFilter()) : "");
        searchFilters += (refoodAreaInteractionFilter() != '' ? "refoodAreaInteraction=" + refoodAreaInteractionFilter() : "");
        searchFilters += (reliabilityFilter() != '' ? "reliability=" + reliabilityFilter() : "");
        searchFilters += (interactionFrequencyFilter() != '' ? "interactionFrequency=" + interactionFrequencyFilter() : "");
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
                partnerList.removeAll();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };

    var advancedSearch = function () {
        getPartnerListAdvanced();
    };

    var clearSearchFilters = function () {
        nucleoIdFilter(-1);
        nameFilter('');
        enterpriseContributorFilter('');
        privateContributorFilter('');
        contributionTypeIdFilter(-1);
        partnershipTypeIdFilter(-1);
        contactPersonFilter('');
        departmentFilter('');
        phoneFilter('');
        emailFilter('');
        ibanFilter('');
        bicSwiftFilter('');
        fiscalNumberFilter('');
        latitudeFilter('');
        longitudeFilter('');
        photoUrlFilter('');
        addressIdFilter(-1);
        partnershipStartDateFromFilter('');
        partnershipStartDateToFilter('');
        durationCommitmentFromFilter('');
        durationCommitmentToFilter('');
        refoodAreaInteractionFilter('');
        reliabilityFilter('');
        interactionFrequencyFilter('');
        activeFilter('');
    };



    // get list by page

    var getPartnerPage = function () {
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
                partnerList.removeAll();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };



    // delete

    var deletePartner = function (partner) {
        isLoading(true);
        var restUrl = baseUrl + "Delete/" + partner.partnerId();
        var jqXHR = $.ajax({
            url: restUrl,
            dataType: "json"
        }).done(function () {
            console.log("Deleted: " + partner.partnerId());
            partnerList.remove(partner);
        }).fail(function () {
            console.log("Error");
        }).always(function (data) {
            console.log("finished");
            isLoading(false);
        });
    }

    var deletePartnerById = function (partnerId) {
        isLoading(true);
        var restUrl = baseUrl + "Delete/" + partnerId;
        var jqXHR = $.ajax({
            method: "GET",
            url: restUrl,
            dataType: "json"
        }).done(function () {
            console.log("Deleted: " + partnerId);
            //partnerList.remove(partner);
            // refresh
            getPartnerList();
        }).fail(function () {
            console.log("Error");
        }).always(function (data) {
            console.log("finished");
            isLoading(false);
        });
    }



    // load

    var load = function (data) {
        partnerList.removeAll();
        var underlyingArray = partnerList();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var partner = new Web.partnerViewModel();
            partner.load(result);
            underlyingArray.push(partner);
        }
        partnerList.valueHasMutated();
    };



    // data table

    var updateDatatable = function (data) {
        var dataArray = new Array();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var fieldsInArray = new Array();

            fieldsInArray.push(result.nucleoId);
            fieldsInArray.push(result.name);
            fieldsInArray.push(result.enterpriseContributor);
            fieldsInArray.push(result.privateContributor);
            fieldsInArray.push(result.contributionTypeId);
            fieldsInArray.push(result.partnershipTypeId);
            fieldsInArray.push(result.contactPerson);
            fieldsInArray.push(result.department);
            fieldsInArray.push(result.phone);
            fieldsInArray.push(result.email);
            fieldsInArray.push(result.iban);
            fieldsInArray.push(result.bicSwift);
            fieldsInArray.push(result.fiscalNumber);
            fieldsInArray.push(result.latitude);
            fieldsInArray.push(result.longitude);
            fieldsInArray.push(result.photoUrl);
            fieldsInArray.push(result.addressId);
            fieldsInArray.push(result.partnershipStartDate);
            fieldsInArray.push(result.durationCommitment);
            fieldsInArray.push(result.refoodAreaInteraction);
            fieldsInArray.push(result.reliability);
            fieldsInArray.push(result.interactionFrequency);
            fieldsInArray.push(result.active);

            var viewLinkElement = '<a href=\"' + result.editUrl + '\" style=\"margin-right: 10px;\">View</a>';
            var editLinkElement = '<a href=\"' + result.editUrl + '\" style=\"margin-right: 10px;\">Edit</a>';
            var deleteLinkElement = '<a href=\"' + 'javascript:vm.deletePartnerById(' + result.partnerId + ');' + '\" style=\"margin-right: 10px;\">Delete</a>';
            fieldsInArray.push(viewLinkElement + editLinkElement + deleteLinkElement);

            dataArray.push(fieldsInArray);
        }

        var datatable = $("#PartnersTable-" + moduleId).DataTable();
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
        partnerList: partnerList,
        getPartnerList: getPartnerList,
        getPartnerPage: getPartnerPage,
        deletePartner: deletePartner,
        deletePartnerById: deletePartnerById,
        editMode: editMode,
        isLoading: isLoading,
        searchText: searchText,
        openCreateForm: openCreateForm,
        getPartnerListAdvanced: getPartnerListAdvanced,
        advancedSearch: advancedSearch,
        clearSearchFilters: clearSearchFilters,

        nucleoList: nucleoHelper.nucleoList,
        contributionTypeList: contributionTypeHelper.contributionTypeList,
        partnershipTypeList: partnershipTypeHelper.partnershipTypeList,
        addressList: addressHelper.addressList,

        nucleoIdFilter: nucleoIdFilter,
        nameFilter: nameFilter,
        enterpriseContributorFilter: enterpriseContributorFilter,
        privateContributorFilter: privateContributorFilter,
        contributionTypeIdFilter: contributionTypeIdFilter,
        partnershipTypeIdFilter: partnershipTypeIdFilter,
        contactPersonFilter: contactPersonFilter,
        departmentFilter: departmentFilter,
        phoneFilter: phoneFilter,
        emailFilter: emailFilter,
        ibanFilter: ibanFilter,
        bicSwiftFilter: bicSwiftFilter,
        fiscalNumberFilter: fiscalNumberFilter,
        latitudeFilter: latitudeFilter,
        longitudeFilter: longitudeFilter,
        photoUrlFilter: photoUrlFilter,
        addressIdFilter: addressIdFilter,
        partnershipStartDateFromFilter: partnershipStartDateFromFilter,
        partnershipStartDateToFilter: partnershipStartDateToFilter,
        durationCommitmentFromFilter: durationCommitmentFromFilter,
        durationCommitmentToFilter: durationCommitmentToFilter,
        refoodAreaInteractionFilter: refoodAreaInteractionFilter,
        reliabilityFilter: reliabilityFilter,
        interactionFrequencyFilter: interactionFrequencyFilter,
        activeFilter: activeFilter,
    }
};



// view model

Web.partnerViewModel = function () {
    var partnerId = ko.observable(-1);
    var nucleoId = ko.observable(-1);
    var name = ko.observable('');
    var enterpriseContributor = ko.observable('');
    var privateContributor = ko.observable('');
    var contributionTypeId = ko.observable(-1);
    var partnershipTypeId = ko.observable(-1);
    var contactPerson = ko.observable('');
    var department = ko.observable('');
    var phone = ko.observable('');
    var email = ko.observable('');
    var iban = ko.observable('');
    var bicSwift = ko.observable('');
    var fiscalNumber = ko.observable('');
    var latitude = ko.observable('');
    var longitude = ko.observable('');
    var photoUrl = ko.observable('');
    var addressId = ko.observable(-1);
    var partnershipStartDate = ko.observable('');
    var durationCommitment = ko.observable('');
    var refoodAreaInteraction = ko.observable('');
    var reliability = ko.observable('');
    var interactionFrequency = ko.observable('');
    var active = ko.observable('');
    var isDeleted = ko.observable('');

    var editUrl = ko.observable('');

    var visibleOnSearch = ko.observable(true);
 
    // load

    var load = function (data) {
        partnerId(data.partnerId);
        nucleoId(data.nucleoId);
        name(data.name);
        enterpriseContributor(data.enterpriseContributor);
        privateContributor(data.privateContributor);
        contributionTypeId(data.contributionTypeId);
        partnershipTypeId(data.partnershipTypeId);
        contactPerson(data.contactPerson);
        department(data.department);
        phone(data.phone);
        email(data.email);
        iban(data.iban);
        bicSwift(data.bicSwift);
        fiscalNumber(data.fiscalNumber);
        latitude(data.latitude);
        longitude(data.longitude);
        photoUrl(data.photoUrl);
        addressId(data.addressId);
        partnershipStartDate(data.partnershipStartDate);
        durationCommitment(data.durationCommitment);
        refoodAreaInteraction(data.refoodAreaInteraction);
        reliability(data.reliability);
        interactionFrequency(data.interactionFrequency);
        active(data.active);
        isDeleted(data.isDeleted);
        editUrl(data.editUrl);
    };



    return {
        partnerId: partnerId,
        nucleoId: nucleoId,
        name: name,
        enterpriseContributor: enterpriseContributor,
        privateContributor: privateContributor,
        contributionTypeId: contributionTypeId,
        partnershipTypeId: partnershipTypeId,
        contactPerson: contactPerson,
        department: department,
        phone: phone,
        email: email,
        iban: iban,
        bicSwift: bicSwift,
        fiscalNumber: fiscalNumber,
        latitude: latitude,
        longitude: longitude,
        photoUrl: photoUrl,
        addressId: addressId,
        partnershipStartDate: partnershipStartDate,
        durationCommitment: durationCommitment,
        refoodAreaInteraction: refoodAreaInteraction,
        reliability: reliability,
        interactionFrequency: interactionFrequency,
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






    