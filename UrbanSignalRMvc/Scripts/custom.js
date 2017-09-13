$(function () {
    // Reference the auto-generated proxy for the hub.
    var chat = $.connection.displayHub;
    // Create a function that the hub can call back to display messages.

    chat.client.refreshBrowser = function () {
        $.ajax({
            url: "",
            context: document.body,
            success: function (s, x) {
                $(this).html(s);
            }
        });
    };

    chat.client.addNewMessageToPage = function (message) {
        // Add the message to the page. 
        $('#TicketContent').html(message);
    };
    $.connection.hub.start().done(function () {
       // $('#status').html('Connected');
        //$('#sendmessage').click(function () {
        //    // Call the Send method on the hub.
        //    chat.server.send($('#displayname').val(), $('#message').val());
        //    // Clear text box and reset focus for next comment.
        //    $('#message').val('').focus();
        //});
    });

    function htmlEncode(value) {
        var encodedValue = $('<div />').text(value).html();
        return encodedValue;
    }
});
