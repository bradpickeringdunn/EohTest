
function Ajax() {

    this.Call = function (type, url, data, successFunction, errorFunction) {

        $.ajax({
            url: url,
            type: type,
            data: data
        })
            .success(successFunction)
            .error(errorFunction);

    }
}