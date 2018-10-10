
// ################################################################
//                      Code generated with T4
// ################################################################

var Web = Web || {};

// viewmodel

Web.partner = function ( partnerId, nucleoId, name, enterpriseContributor, privateContributor, contributionTypeId, partnershipTypeId, contactPerson, department, phone, email, iban, bicSwift, fiscalNumber, latitude, longitude, photoUrl, addressId, partnershipStartDate, durationCommitment, refoodAreaInteraction, reliability, interactionFrequency, active, isDeleted) {
    this.partnerId = ko.observable(partnerId);
    this.nucleoId = ko.observable(nucleoId);
    this.name = ko.observable(name);
    this.enterpriseContributor = ko.observable(enterpriseContributor);
    this.privateContributor = ko.observable(privateContributor);
    this.contributionTypeId = ko.observable(contributionTypeId);
    this.partnershipTypeId = ko.observable(partnershipTypeId);
    this.contactPerson = ko.observable(contactPerson);
    this.department = ko.observable(department);
    this.phone = ko.observable(phone);
    this.email = ko.observable(email);
    this.iban = ko.observable(iban);
    this.bicSwift = ko.observable(bicSwift);
    this.fiscalNumber = ko.observable(fiscalNumber);
    this.latitude = ko.observable(latitude);
    this.longitude = ko.observable(longitude);
    this.photoUrl = ko.observable(photoUrl);
    this.addressId = ko.observable(addressId);
    this.partnershipStartDate = ko.observable(partnershipStartDate);
    this.durationCommitment = ko.observable(durationCommitment);
    this.refoodAreaInteraction = ko.observable(refoodAreaInteraction);
    this.reliability = ko.observable(reliability);
    this.interactionFrequency = ko.observable(interactionFrequency);
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

Web.partnerHelper = function (isLoading, serviceRootUrl, moduleHeaders) {

    var partnerList = ko.observableArray([]);
    var deletedPartnerList = ko.observableArray([]);
    var isLoading = isLoading;
    var serviceRootUrl = serviceRootUrl;
    var moduleHeaders = moduleHeaders;
    var searchText = ko.observable('');


    // get

    var getPartnerList = function () {
        isLoading(true);

        // need to calculate a different Url for Partner service
        var restUrl = serviceRootUrl + "api/PartnerApi/GetList/";
        var jqXHR = $.ajax({
            url: restUrl,
            beforeSend: moduleHeaders,
            dataType: "json",
            async: false
        }).done(function (data) {
            if (data) {
                loadPartners(data);
            }
            else {
                clear();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };




    // load

    var loadPartners = function (data) {
        partnerList.removeAll();
        var underlyingArray = partnerList();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var partner = new Web.partner
            (
                result.partnerId, 
                result.nucleoId, 
                result.name, 
                result.enterpriseContributor, 
                result.privateContributor, 
                result.contributionTypeId, 
                result.partnershipTypeId, 
                result.contactPerson, 
                result.department, 
                result.phone, 
                result.email, 
                result.iban, 
                result.bicSwift, 
                result.fiscalNumber, 
                result.latitude, 
                result.longitude, 
                result.photoUrl, 
                result.addressId, 
                result.partnershipStartDate, 
                result.durationCommitment, 
                result.refoodAreaInteraction, 
                result.reliability, 
                result.interactionFrequency, 
                result.active, 
                result.isDeleted 
            );
            underlyingArray.push(partner);
        }
        partnerList.valueHasMutated();
    };


    // extract knockout array to simple json objects

    var extractKoArrayToJson = function (data) {
        var simpleArray = new Array();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var partner = {
                partnerId: result.partnerId(), 
                nucleoId: result.nucleoId(), 
                name: result.name(), 
                enterpriseContributor: result.enterpriseContributor(), 
                privateContributor: result.privateContributor(), 
                contributionTypeId: result.contributionTypeId(), 
                partnershipTypeId: result.partnershipTypeId(), 
                contactPerson: result.contactPerson(), 
                department: result.department(), 
                phone: result.phone(), 
                email: result.email(), 
                iban: result.iban(), 
                bicSwift: result.bicSwift(), 
                fiscalNumber: result.fiscalNumber(), 
                latitude: result.latitude(), 
                longitude: result.longitude(), 
                photoUrl: result.photoUrl(), 
                addressId: result.addressId(), 
                partnershipStartDate: result.partnershipStartDate(), 
                durationCommitment: result.durationCommitment(), 
                refoodAreaInteraction: result.refoodAreaInteraction(), 
                reliability: result.reliability(), 
                interactionFrequency: result.interactionFrequency(), 
                active: result.active(), 
                isDeleted: result.isDeleted() 
            };

            simpleArray.push(partner);
        }
        return simpleArray;
    };


    // add

    var addPartner = function () {
        var partner = new Web.partner(0, '', '', '', '');
        partnerList.push(partner);
    };


    // remove

    var removePartner = function (model, event) {
        var partner = model;
        partner.isDeleted = true;
        deletedPartnerList.push(partner);
        partnerList.pop(partner);
    };


    // clear

    var clear = function () {
        partnerList([]);
    };


    // quickSearch

    var quickSearch = function () {
        for (var i = 0; i < partnerList().length; i++) {
            var result = partnerList()[i];

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
        partnerList: partnerList,
        deletedPartnerList: deletedPartnerList,
        getPartnerList: getPartnerList,
        loadPartners: loadPartners,
        isLoading: isLoading,
        addPartner: addPartner,
        removePartner: removePartner,
        clear: clear,
        searchText: searchText,
        quickSearch: quickSearch,
        extractKoArrayToJson: extractKoArrayToJson
    };
}
    