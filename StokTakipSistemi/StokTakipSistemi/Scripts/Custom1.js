//import index from "../../../../AppData/Local/Microsoft/TypeScript/2.6/node_modules/popper.js";
$(function () {
    $(".admindep").change(function () {
        var depid = $(".admindep").val();
        $.ajax({
            type: "GET",
            url: "/AdminStok/GetPersonels/" + depid,
            success: function (data) {
                $(".adminpers").empty();
                $.each(data, function (index) {
                    $(".adminpers").append('<option value=' + data[index].personelId + '>' + data[index].personelAd +"  "+ data[index].personelSoyad +"  "+ data[index].SGKNO+'</option>');
                });
            },
            error: function (error, status, xhr) {
                console.log("Error:", error.responseText);
            }
        });

    });

    $("#btnLog").click(function () {
        bootbox.confirm("Çıkış yapmak istediğinize eminmisiniz", function (result) {
            if (result) {
                window.location.href = "http://localhost:55640/Security/Logout";
            }
            
        })

    });
    
});