
// ################################################################
//                      Code generated with T4
// ################################################################

var Web = Web || {};

// viewmodel

Web.volunteer = function ( volunteerId, name, gender, birthDate, occupation, employer, phone, email, identityCardNumber, countryId, friendOrFamilyContact, photo, addressId, hasCar, hasDriverLicense, hasBike, vehicleMake, vehicleModel, active, isDeleted) {
    this.volunteerId = ko.observable(volunteerId);
    this.name = ko.observable(name);
    this.gender = ko.observable(gender);
    this.birthDate = ko.observable(birthDate);
    this.occupation = ko.observable(occupation);
    this.employer = ko.observable(employer);
    this.phone = ko.observable(phone);
    this.email = ko.observable(email);
    this.identityCardNumber = ko.observable(identityCardNumber);
    this.countryId = ko.observable(countryId);
    this.friendOrFamilyContact = ko.observable(friendOrFamilyContact);
    this.photo = ko.observable(photo);
    this.addressId = ko.observable(addressId);
    this.hasCar = ko.observable(hasCar);
    this.hasDriverLicense = ko.observable(hasDriverLicense);
    this.hasBike = ko.observable(hasBike);
    this.vehicleMake = ko.observable(vehicleMake);
    this.vehicleModel = ko.observable(vehicleModel);
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

Web.volunteerHelper = function (isLoading, serviceRootUrl, moduleHeaders) {

    var volunteerList = ko.observableArray([]);
    var deletedVolunteerList = ko.observableArray([]);
    var isLoading = isLoading;
    var serviceRootUrl = serviceRootUrl;
    var moduleHeaders = moduleHeaders;
    var searchText = ko.observable('');


    // get

    var getVolunteerList = function () {
        isLoading(true);

        // need to calculate a different Url for Volunteer service
        var restUrl = serviceRootUrl + "api/VolunteerApi/GetList/";
        var jqXHR = $.ajax({
            url: restUrl,
            beforeSend: moduleHeaders,
            dataType: "json",
            async: false
        }).done(function (data) {
            if (data) {
                loadVolunteers(data);
            }
            else {
                clear();
            }
        }).always(function (data) {
            isLoading(false);
        });
    };




    // load

    var loadVolunteers = function (data) {
        volunteerList.removeAll();
        var underlyingArray = volunteerList();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var volunteer = new Web.volunteer
            (
                result.volunteerId, 
                result.name, 
                result.gender, 
                result.birthDate, 
                result.occupation, 
                result.employer, 
                result.phone, 
                result.email, 
                result.identityCardNumber, 
                result.countryId, 
                result.friendOrFamilyContact, 
                result.photo, 
                result.addressId, 
                result.hasCar, 
                result.hasDriverLicense, 
                result.hasBike, 
                result.vehicleMake, 
                result.vehicleModel, 
                result.active, 
                result.isDeleted 
            );
            underlyingArray.push(volunteer);
        }
        volunteerList.valueHasMutated();
    };


    // extract knockout array to simple json objects

    var extractKoArrayToJson = function (data) {
        var simpleArray = new Array();
        for (var i = 0; i < data.length; i++) {
            var result = data[i];
            var volunteer = {
                volunteerId: result.volunteerId(), 
                name: result.name(), 
                gender: result.gender(), 
                birthDate: result.birthDate(), 
                occupation: result.occupation(), 
                employer: result.employer(), 
                phone: result.phone(), 
                email: result.email(), 
                identityCardNumber: result.identityCardNumber(), 
                countryId: result.countryId(), 
                friendOrFamilyContact: result.friendOrFamilyContact(), 
                photo: result.photo(), 
                addressId: result.addressId(), 
                hasCar: result.hasCar(), 
                hasDriverLicense: result.hasDriverLicense(), 
                hasBike: result.hasBike(), 
                vehicleMake: result.vehicleMake(), 
                vehicleModel: result.vehicleModel(), 
                active: result.active(), 
                isDeleted: result.isDeleted() 
            };

            simpleArray.push(volunteer);
        }
        return simpleArray;
    };


    // add

    var addVolunteer = function () {
        var volunteer = new Web.volunteer(0, '', '', '', '');
        volunteerList.push(volunteer);
    };


    // remove

    var removeVolunteer = function (model, event) {
        var volunteer = model;
        volunteer.isDeleted = true;
        deletedVolunteerList.push(volunteer);
        volunteerList.pop(volunteer);
    };


    // clear

    var clear = function () {
        volunteerList([]);
    };


    // quickSearch

    var quickSearch = function () {
        for (var i = 0; i < volunteerList().length; i++) {
            var result = volunteerList()[i];

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
        volunteerList: volunteerList,
        deletedVolunteerList: deletedVolunteerList,
        getVolunteerList: getVolunteerList,
        loadVolunteers: loadVolunteers,
        isLoading: isLoading,
        addVolunteer: addVolunteer,
        removeVolunteer: removeVolunteer,
        clear: clear,
        searchText: searchText,
        quickSearch: quickSearch,
        extractKoArrayToJson: extractKoArrayToJson
    };
}
    