$(document).ready(function () {

    $("form").submit(function (e) {

        new DeleteCandidate().Delete();

        e.preventDefault();
    });

    function DeleteCandidate() {

        var candidateId = 0;

        this.Delete = function () {
            candidateId = $(".deleteCandidates").val();
            new Ajax().Call("POST", "/candidate/RemoveCandidate", { id: candidateid }, this.SuccessfulDeletion(), this.FailedDeletion());
        }

        this.SuccessfulDeletion = function(data){
            dropdownElement = $(".deleteCandidates");
            dropdownElement.find('option[value=' + candidateId + ']').remove();
            alert("The candidae has been deleted");
        }

        this.FailedDeletion = function (xhr, data) {
            alert("The candidae has been deleted");
        }

    }

});