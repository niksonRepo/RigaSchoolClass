$(document).ready(function () {

    $("#MyOwnButtonId").click(function () {
        event.preventDefault();
                        // /Controller/Method Name
        var serviceUrl = "/MyOwn/ModifyViewData";
        
        var dataModel = {
            MyOwnName: "Andris",
            MyOwnEmail: "andris@inbox.lv",
            MyOwnPhone: "+371 22887458"
        };

        $.post(serviceUrl, dataModel, function () {
            console.log("success");
        })
            .done(function (data, status) {
                if (data.nameMassege != "") {
                    alert(data.nameMassege);
                }

                console.log(data);
            })
            .fail(function (data, status) {
                alert("error");
            })
            .always(function (data, status) {

            });
    });
});