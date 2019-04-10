//function ajaxGetir() {
//    $.ajax({
//        url: "/AJAX/index",
//        type: "GET",
//        data: {"ad":"Mücahit","soyad":"Hamarat"},
//        success: function (gelenVeri) {
//            $(".pIcerik").html(gelenVeri);
//        },
//        error: function (hata) {
//            alert(hata.status)
//        }
//    });


//function ajaxGetir() {
//    $.ajax({
//        url: "/AJAX/index",
//        type: "GET",
//        data: { "ad": $("#iAd").val(), "soyad": $("#iSoyad").val(), "dogumYil":$(".iDogumYil").val() },
//        success: function (veri) {
//            $(".pIcerik").html(veri);
//        },
//        error: function (hata) {
//            alert(hata.responseText)
//        }
//    });
//}


function IlceGetir(tiklayan) {
    $.ajax({
        url: "/AJAX/Ilceler",
        type: "GET",
        data: { "plaka": $(tiklayan).val()},
        success: function (veri) {
            $(".ilceler").empty();
            $(".ilceler").append("<option value=''>İlçe Seçiniz</option>");
            $.each(veri, function (index, item) {
                $(".ilceler").append("<option value='" + item.ID + "'> "+item.Ad+"</option > ");
                })
            
        },
        error: function (hata) {
            alert(hata.responseText)=""
        }
    });
}
function MahalleGetir(tiklayan) {
    $.ajax({
        url: "/AJAX/Mahalleler",
        type: "GET",
        data: { "id": $(tiklayan).val() },
        success: function (veri) {
            $(".mahalleler").empty();
            $(".mahalleler").append("<option value=''>Mahalle Seçiniz</option>");
            $.each(veri, function (index, item) {
                $(".mahalleler").append("<option value='" + item.ID + "'> " + item.Ad + "</option > ");
            })

        },
        error: function (hata) {
            alert(hata.responseText)
        }
    });
}