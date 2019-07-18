$(function () {

    $(".personeller").change(function () {
        $(".departmanlar").val("selected");
        var persid = $(".personeller").val();
        $.ajax({
            type: "GET",
            url: "/AdminRapor/GetProductforPer/" + persid,
            success: function (data) {
                $(".zimtable").empty();
                $(".zimtable").append('<tr><th>' + "Ürün Ad" + '</th><th>' + "Satýn Alma Tarihi" + '</th><th>' + "Ürün Fiyatý" + '</th><th>' + "Parça Tipi" + '</th><th>' + "Satýn Alýnan Kurum" + '</th></tr>');
                $.each(data, function (index) {
                    var date = new Date(parseInt(data[index].Urun.urunSatinAlmaTarih.substr(6)));
                    var lastdatevalue = date.getDate() +
                        "." +
                        parseInt(date.getMonth() + 1)
                        +
                        "." +
                        date.getFullYear() + "  " + date.getHours() + ":" + date.getMinutes() + ":" + date.getSeconds();
                    $(".zimtable").append
                        ('<tr>' +
                        '<td > ' + data[index].Urun.urunAd + '</td > ' +
                        '<td>' + lastdatevalue + '</td>' +
                        '<td>' + data[index].Urun.urunFiyat +'<span class="simge-tl"> &#8378;</span></td>' +
                        '<td>' + data[index].Parca + '</td>' +
                        '<td>' + data[index].Urun.satinAlinanKurum + '</td>' +
                        '</tr>'
                        );
                });


            },
            error: function (error, statur, xhr) {
                console.log("Error:", error.status);
            }
        });

    });

 $(".departmanlar").change(function () {
        $(".personeller").val('selected');
        var departmanid = $(".departmanlar").val();
        $.ajax({
            type: "GET",
            url: "/AdminRapor/GetProductforDep/" + departmanid,
            success: function (data) {
                $(".zimtable").empty();
                $(".zimtable").append('<tr><th>' + "Ürün Ad" + '</th><th>' + "Satýn Alma Tarihi" + '</th><th>' + "Ürün Fiyatý" + '</th><th>' + "Parça Tipi" + '</th><th>' + "Satýn Alýnan Kurum" + '</th><th>')
                $(data).each(function (index) {
                    var date = new Date(parseInt(data[index].Urun.urunSatinAlmaTarih.substr(6)));
                    var lastdate = date.getDate() + "." +
                        parseInt(date.getMonth() + 1) + "." +
                        date.getFullYear() + "  " + date.getHours() + ":" + date.getMinutes() + ":" + date.getSeconds();
                    $(".zimtable").append
                        ('<tr><td>' + data[index].Urun.urunAd + '</td>' +
                        '<td>' + lastdate + '</td>' +
                        '<td>' + data[index].Urun.urunFiyat + '<span class="simge-tl"> &#8378;</span></td>' +
                        '<td>' + data[index].Parca + '</td>' +
                        '<td>' + data[index].Urun.satinAlinanKurum + '</td></tr>'
                        )
                });
            },
            error: function (error, status, xhr) {
                console.log("Error:", error.responseText);
            }

        });


    });


    function Search_Table(deger, table) {
        $(table).each(function (index) {
            if (index == 0) {
                return true;
            }
            else {
                var found = "false";
                $(this).each(function () {
                    if ($(this).text().toLowerCase().indexOf(deger.toLowerCase()) >= 0) {
                        found = "true";
                    }
                    if (found == "true") {
                        $(this).show();
                    }
                    else {
                        $(this).hide();
                    }

                });
            }
        });
    }

    $(".search").keyup(function () {
        var text = $(".search").val();
        var table = ".stoktable tr";
        Search_Table(text, table);
    });
    $(".searchStok").keyup(function () {
        var text = $(".searchStok").val();
        var table = ".tableStok tr";
        Search_Table(text, table);
    });
    $(".SAsearchPer").keyup(function () {
        var text = $(".SAsearchPer").val();
        var table = ".SATablePer tr";
        Search_Table(text, table);
    });
    $(".StokArama").keyup(function () {
        var text = $(".StokArama").val();
        var table = ".StokAramaTable tr";
        Search_Table(text, table);
    });
    $(".PersonelArama").keyup(function () {
        var text = $(".PersonelArama").val();
        var table = ".PersonelTablo tr";
        Search_Table(text, table);
    });
    $(".AtýkArama").keyup(function () {
        var text = $(".AtýkArama").val();
        var table = ".AtýkTable tr";
        Search_Table(text, table);
    });
    $(".AdminsearchPers").keyup(function () {
        var text = $(".AdminsearchPers").val();
        var table = ".AdminPersTable tr";
        Search_Table(text, table);
    });
    $(".AdminsearchDepartman").keyup(function () {
        var text = $(".AdminsearchDepartman").val();
        var table = ".AdminDepartmanTable tr";
        Search_Table(text, table);
    });
    $(".AdminsearchKullanici").keyup(function () {
        var text = $(".AdminsearchKullanici").val();
        var table = ".AdminKullaniciTable tr";
        Search_Table(text, table);
    });
    $(".AdminsearchRapor").keyup(function () {
        var text = $(".AdminsearchRapor").val();
        var table = ".AdminRaporTable tr";
        Search_Table(text, table);
    });
    $(".AdminAtikArama").keyup(function () {
        var text = $(".AdminAtikArama").val();
        var table = ".AdminAtikTable tr";
        Search_Table(text, table);
    });




    $(".AdminzimmetleBtn").click(function () {
        var PersonelId = $(".adminpers").val();
        if (PersonelId == null || PersonelId <= 0) {
            $(".adminpers").show();
            $("#valid").text("Lütfen Personel Seçiniz!").addClass("field-validation-error");
            return false;
        }
        else
        {
        
        }

        
        
    });
});