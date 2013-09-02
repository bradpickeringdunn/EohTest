
function Ajax() {

    this.Call = function (type, url, data) {

        $.ajax({
            url: url,
            type: type,
            data: data
        });

    }

}