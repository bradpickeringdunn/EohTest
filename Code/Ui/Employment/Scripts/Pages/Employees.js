

$(document).ready(function () {

    $("form").submit(function (e) {

        e.preventDefault();

        new EmployeeClass().Delete();
    });

    function EmployeeClass() {

        var employeeId = 0;

        this.Delete = function () {

            employeeId = $(".employeeList").val();

            new Ajax().Call("PUT", "/Employee/DismissEmployee", { employeId: employeeId }, this.SuccessfulDelete, this.FailedDelete);
        }

        this.SuccessfulDelete = function(data){
            alert("The employee has ben dismissed");
            
        }

        this.FailedDelete = function (xhr, data) {
            alert("There was an error.");
        }

    }

});