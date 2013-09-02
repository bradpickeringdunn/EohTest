

$(document).ready(function () {

    $("form").submit(function (e) {

        var employeeId = $(".employeeList").val();

        new Ajax().Call("PUT", "/Employee/DismissEmployee", { employeId: employeeId });


        e.preventDefault();
    });


});