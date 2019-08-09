
/*Ajax post function*/
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
/*Calculate and display the total value function*/
function Totalvalue() {
    $('#lbltotalvalue').text('');
    var PackCode = $('#drpBakeryitem').val();
    var Numberofcount = $('#txtNumberofitem').val();
    if (Numberofcount != '') {
        if (PackCode != '') {
            var Data = { "NumberofPackages": Numberofcount, "PackCode": PackCode }
            SendPost("/Home/BakeryResult", Data, function (response) {
                if (response.result == true) {
                    $('#lbltotalvalue').text("$" + response.TotalAmount);
                }
            });
        }
        else {
            console.log('error');
            alert('Please select Bakery item.');
        }
    }
    else {
        console.log('error');
        alert('Please enter number.');
    }
}