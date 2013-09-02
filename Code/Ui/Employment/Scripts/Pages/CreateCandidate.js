$(document).ready(function () {

    $("form").submit(function (e) {

        new CreateCandidate().Create();

        e.preventDefault();
    });

    function CreateCandidate() {

        this.Create = function () {

            var firstName = $('input[name=firstName]').val();
            var lastame = $("input[name='lastName']").val();
            var date = $(".dateOfBirth").val();

            new Ajax().Call("POST", "/candidate/create", { firstName: firstName, lastName: lastame, dateOfBirth: date }, this.CandidateAdded, this.ErrorCreatingCandidate);
            
        }
        
        this.CandidateAdded = function (date) {
            alert("The candidate has been added.");
        }

        this.ErrorCreatingCandidate = function (xhr, data) {
            alert("There was an error when adding the candidate.");
        }
    }

});