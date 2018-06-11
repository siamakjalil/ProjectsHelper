$(document).ready(function () {
    debugger;
    var pageId = $("#pageId").val();
    var pageCount = $("#pageCount").val();
    if (pageId - 1 <= 0) {
        /*   $("#backward").addClass('disabled');;*/
        $("#backward").hide();
    }
    if (pageId + 1 > pageCount) {
        //$("#forward").addClass('disabled');
        $("#forward").hide();
    }

});