$(document).ready(function () {

    $("form").submit(function (e) {

        new CreateCandidate().Create();

        e.preventDefault();
    });

    function CreateCandidate() {

        this.Create = function () {
            $("form").submit();
        }
        
    }

});