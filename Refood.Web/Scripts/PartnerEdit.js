
// ################################################################
//                      Code generated with T4
// ################################################################

var Web = Web || {};

Web.partnerViewModel = function (moduleId, resx) {
    var baseUrl = "/api/PartnerApi/";

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
    var userList = ko.observableArray([]);
    var isLoading = ko.observable(false);



    // helpers

    var nucleoHelper = Web.nucleoHelper(isLoading, '/', function(){});
    var contributionTypeHelper = Web.contributionTypeHelper(isLoading, '/', function(){});
    var partnershipTypeHelper = Web.partnershipTypeHelper(isLoading, '/', function(){});
    var addressHelper = Web.addressHelper(isLoading, '/', function(){});



    // init

    var init = function () {
        var qs = getQueryStrings();
        var partnerId = qs["tid"];
        if (partnerId) {
            getPartner(partnerId);
        }
        //getUserList();

        nucleoHelper.getNucleoList();
        contributionTypeHelper.getContributionTypeList();
        partnershipTypeHelper.getPartnershipTypeList();
        addressHelper.getAddressList();
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

    var getPartner = function (partnerId) {
        isLoading(true);

        var restUrl = baseUrl + "Get/" + partnerId;
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
        partnershipStartDate(serverDateTimeStringToJavascriptDate(data.partnershipStartDate));
        durationCommitment(serverDateTimeStringToJavascriptDate(data.durationCommitment));
        refoodAreaInteraction(data.refoodAreaInteraction);
        reliability(data.reliability);
        interactionFrequency(data.interactionFrequency);
        active(data.active);
        isDeleted(data.isDeleted);
    };

    

    // save

    var save = function () {
        isLoading(true);
        var partner = {
            partnerId: partnerId(),
            nucleoId: nucleoId(),
            name: name(),
            enterpriseContributor: enterpriseContributor(),
            privateContributor: privateContributor(),
            contributionTypeId: contributionTypeId(),
            partnershipTypeId: partnershipTypeId(),
            contactPerson: contactPerson(),
            department: department(),
            phone: phone(),
            email: email(),
            iban: iban(),
            bicSwift: bicSwift(),
            fiscalNumber: fiscalNumber(),
            latitude: latitude(),
            longitude: longitude(),
            photoUrl: photoUrl(),
            addressId: addressId(),
            partnershipStartDate: dateToStringServerFormat(partnershipStartDate()),
            durationCommitment: dateToStringServerFormat(durationCommitment()),
            refoodAreaInteraction: refoodAreaInteraction(),
            reliability: reliability(),
            interactionFrequency: interactionFrequency(),
            active: active(),
            isDeleted: isDeleted(),
        };
        var ajaxMethod = "POST";
        var restUrl = baseUrl + "Upsert/";

        if (partner.partnerId > 0) {
            // ajaxMethod = "PATCH";
            restUrl += partner.partnerId;
        }
        else {
            restUrl += 0;
        }

        var jqXHR = $.ajax({
            method: ajaxMethod,
            url: restUrl,
            contentType: "application/json; charset=UTF-8",
            data: JSON.stringify(partner),
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
        partnerId('');
        nucleoId('');
        name('');
        enterpriseContributor('');
        privateContributor('');
        contributionTypeId('');
        partnershipTypeId('');
        contactPerson('');
        department('');
        phone('');
        email('');
        iban('');
        bicSwift('');
        fiscalNumber('');
        latitude('');
        longitude('');
        photoUrl('');
        addressId('');
        partnershipStartDate('');
        durationCommitment('');
        refoodAreaInteraction('');
        reliability('');
        interactionFrequency('');
        active('');
        isDeleted('');
    };


    
    // cancel

    var cancel = function () {
        dnnModal.closePopUp(false);
    };



    // return viewmodel

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
        userList: userList,
        cancel: cancel,
        load: load,
        save: save,
        init: init,
        isLoading: isLoading,
        nucleoList: nucleoHelper.nucleoList,
        contributionTypeList: contributionTypeHelper.contributionTypeList,
        partnershipTypeList: partnershipTypeHelper.partnershipTypeList,
        addressList: addressHelper.addressList,
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



    