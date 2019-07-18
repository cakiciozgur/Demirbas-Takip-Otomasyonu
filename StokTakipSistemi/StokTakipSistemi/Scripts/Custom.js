$(function () {
    $(".dep").change(function () {
        var depid = $(".dep").val();
        $.ajax({
            type: "GET",
            url: "/SAStok/GetPersonels/" + depid,
            success: function (data) {
                $(".pers").empty();
                $.each(data, function (index){
                    $(".pers").append('<option value=' + data[index].personelId + '>' +
                               data[index].personelAd + "   " + data[index].personelSoyad + "   " + data[index].SGKNO+'</option>');
                });
            },
            error: function (request, status, xhr) {
                console.log(request.responseText);
            }
        });

    });

    $(".btnZimmet").click(function () {

        if ($(".pers").val() == null || $(".pers").val() <= 0) {
            $("#zimpervalid").text("Lütfen Personel Seçiniz!").addClass("field-validation-error");
            return false;
        }
      
    });


});