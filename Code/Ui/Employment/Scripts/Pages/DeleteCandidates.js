$(document).ready(function () {

    $("form").submit(function (e) {

        new DeleteCandidate().Delete();

        e.preventDefault();
    });

    function DeleteCandidate() {

        this.Delete = function () {
            var candidateId = $(".deleteCandidates").val();
            new Ajax().Call("POST", "/candidate/RemoveCandidate", { id: candidateid })
        }

    }

});