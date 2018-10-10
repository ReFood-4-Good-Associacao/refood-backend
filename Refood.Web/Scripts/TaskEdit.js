
// ################################################################
//                      Code generated with T4
// ################################################################

var Web = Web || {};

Web.taskViewModel = function (moduleId, resx) {
    var baseUrl = "/api/TaskApi/";

    var taskId = ko.observable(-1);
    var name = ko.observable('');
    var taskTypeId = ko.observable(-1);
    var taskDate = ko.observable('');
    var weekDay = ko.observable('');
    var startTime = ko.observable('');
    var endTime = ko.observable('');
    var estimatedDuration = ko.observable('');
    var description = ko.observable('');
    var requiresCar = ko.observable('');
    var teamLeaderId = ko.observable(-1);
    var active = ko.observable('');
    var isDeleted = ko.observable('');
    var userList = ko.observableArray([]);
    var isLoading = ko.observable(false);



    // helpers

    var taskTypeHelper = Web.taskTypeHelper(isLoading, '/', function(){});
    var teamLeaderHelper = Web.teamLeaderHelper(isLoading, '/', function(){});



    // init

    var init = function () {
        var qs = getQueryStrings();
        var taskId = qs["tid"];
        if (taskId) {
            getTask(taskId);
        }
        //getUserList();

        taskTypeHelper.getTaskTypeList();
        teamLeaderHelper.getTeamLeaderList();
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

    var getTask = function (taskId) {
        isLoading(true);

        var restUrl = baseUrl + "Get/" + taskId;
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
        taskId(data.taskId);
        name(data.name);
        taskTypeId(data.taskTypeId);
        taskDate(serverDateTimeStringToJavascriptDate(data.taskDate));
        weekDay(data.weekDay);
        startTime(serverDateTimeStringToJavascriptDate(data.startTime));
        endTime(serverDateTimeStringToJavascriptDate(data.endTime));
        estimatedDuration(data.estimatedDuration);
        description(data.description);
        requiresCar(data.requiresCar);
        teamLeaderId(data.teamLeaderId);
        active(data.active);
        isDeleted(data.isDeleted);
    };

    

    // save

    var save = function () {
        isLoading(true);
        var task = {
            taskId: taskId(),
            name: name(),
            taskTypeId: taskTypeId(),
            taskDate: dateToStringServerFormat(taskDate()),
            weekDay: weekDay(),
            startTime: dateToStringServerFormat(startTime()),
            endTime: dateToStringServerFormat(endTime()),
            estimatedDuration: estimatedDuration(),
            description: description(),
            requiresCar: requiresCar(),
            teamLeaderId: teamLeaderId(),
            active: active(),
            isDeleted: isDeleted(),
        };
        var ajaxMethod = "POST";
        var restUrl = baseUrl + "Upsert/";

        if (task.taskId > 0) {
            // ajaxMethod = "PATCH";
            restUrl += task.taskId;
        }
        else {
            restUrl += 0;
        }

        var jqXHR = $.ajax({
            method: ajaxMethod,
            url: restUrl,
            contentType: "application/json; charset=UTF-8",
            data: JSON.stringify(task),
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
        taskId('');
        name('');
        taskTypeId('');
        taskDate('');
        weekDay('');
        startTime('');
        endTime('');
        estimatedDuration('');
        description('');
        requiresCar('');
        teamLeaderId('');
        active('');
        isDeleted('');
    };


    
    // cancel

    var cancel = function () {
        dnnModal.closePopUp(false);
    };



    // return viewmodel

    return {
        taskId: taskId,
        name: name,
        taskTypeId: taskTypeId,
        taskDate: taskDate,
        weekDay: weekDay,
        startTime: startTime,
        endTime: endTime,
        estimatedDuration: estimatedDuration,
        description: description,
        requiresCar: requiresCar,
        teamLeaderId: teamLeaderId,
        active: active,
        isDeleted: isDeleted,
        userList: userList,
        cancel: cancel,
        load: load,
        save: save,
        init: init,
        isLoading: isLoading,
        taskTypeList: taskTypeHelper.taskTypeList,
        teamLeaderList: teamLeaderHelper.teamLeaderList,
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



    