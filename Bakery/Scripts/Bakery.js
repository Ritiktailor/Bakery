function SendPost(url, parameters, successCallback) {
    $.ajax({
        type: 'POST',
        url: url,
        data: JSON.stringify(parameters),
        contentType: 'application/json;',
        dataType: 'json',
        beforeSend: function () {
        },
        success: successCallback,
        error: function (xhr, textStatus, errorThrown) {
            console.log('error');
        }, complete: function () {
        }
    });
}

