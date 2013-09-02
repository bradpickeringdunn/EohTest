$(document).ready(function () {

    $("form").submit(function (e) {

        new CreateCandidate()

        e.preventDefault();
    });

    function DeleteCandidate() {

        this.Create = function () {
            $("form").submit();
        }

        this.SuccessfulDeletion = function(data){
            alert("The candidae has been deleted");
        }

        this.FailedDeletion = function (xhr, data) {
            alert("The candidae has been deleted");
        }

    }

});