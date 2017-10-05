//Data Extraction Function
function extractData() {
    var place = $("#place")[0].value;
    var checkInDate = $("#datePickerId1")[0].value;
    var checkOutDate=$("#datePickerId2")[0].value;
    var adultNumber = $("#adult")[0].value;
    var childNumber=$("#children")[0].value;
    $.ajax({
        type: "GET",
        url: "guestDetails/",
        success: function (addElement) { $("#addElement").html(addElement); }
    })
};