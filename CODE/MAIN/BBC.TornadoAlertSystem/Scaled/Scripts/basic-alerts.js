/// <reference path="jquery-1.8.2.intellisense.js" />
$(function () {
    var tornadoHubProxy = $.connection.tornadoAlertsHub;
    tornadoHubProxy.client.addTornadoAlertMessage = function (alertMessage) {
        var tornadoAlertDiv = $("<div><h3>New Alert!!</h3>Name: " + alertMessage.Name + "<br />Location: " + alertMessage.Location + "<br /></div>");
        $("#tornado-warnings").append(tornadoAlertDiv);
    };

    $.connection.hub.start()
        .done(function () { console.log('Now connected, connection ID=' + $.connection.hub.id); })
        .fail(function () { console.log('Could not Connect!'); });

    $("#submit-alert").click(function () {
        var tornadoAlert = {
            Name: $("#name").val(),
            Location: $("#location").val()
        };
        tornadoHubProxy.server.sendTornadoAlert(tornadoAlert);
    });
});