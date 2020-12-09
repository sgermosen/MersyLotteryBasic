$(document).ready(function () {

    
    $("#tableSearch,#BtnCancelFilter,#Stock,#formaPagoPanel,#LineDiscount,#Vat").hide();

    $('#Stock,#LineDiscount').attr('readonly', true);

    if ($('#IsPrivate').val() === 'False') {
        $('input:radio[name="priceFromprivate"]').filter('[value="2"]').attr('checked', true);
    }

    $('#add').click(function () {
        addItemToable();
    });

    $('#BtnFilter').click(function () {
        $("#BtnFilter,#tableItem").hide();
        $("#tableSearch,#BtnCancelFilter").show();
    });

    $('#BtnCancelFilter').click(function () {
        $("#BtnFilter,#tableItem").show();
        $("#tableSearch,#BtnCancelFilter").hide();
    });

    $('#BtnSearch').click(function (e) {
        e.preventDefault();

        var isPrivate = true;

        if ($('input[name=priceFromprivate]:checked').val() === 2) {
            isPrivate = false;
        }

        $.get($(this).attr('href'),
            {
                opParam: $('input[name=criteriaFilter]:checked').val(),
                param: $('#option0').val(),
                isPrivate: isPrivate,
                personId: $('#PersonId').val()
            },
            function (result) {
                // console.log(result);
                $('#tableHolder').html(result.Table);
                $('#MyTable').DataTable({
                    "searching": false
                });
            },
            'json');
    });

    $("#Products").change(function () {
        addFromPanel($("#Categories option:selected").val(), $("#Products option:selected").val(), 2);
        if ($("#Categories option:selected").text() === "Prod/Serv de Monto Variable") {
            $('#SellPrice').attr('readonly', false);
            $('#SellPrice').val('');
        } else {
            // $('#SellPrice').attr('readonly', true);
        }
    });

});

function makeid() {
    var text = "";
    var possible = "0123456789";

    for (var i = 0; i < 8; i++)
        text += possible.charAt(Math.floor(Math.random() * possible.length));

    return "INV-" + text.toUpperCase();
}