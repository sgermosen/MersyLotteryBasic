var trans = 'es';

function setCurrentDate() {
    var mytoday = new Date();
    var dd = mytoday.getDate();
    var mm = mytoday.getMonth() + 1; //January is 0!

    var yyyy = mytoday.getFullYear();
    if (dd < 10) {
        dd = '0' + dd;
    }
    if (mm < 10) {
        mm = '0' + mm;
    }
    var mytoday2 = dd + '/' + mm + '/' + yyyy;
    $(".PsDates").val(mytoday2);
    // document.getElementById('DATE').value = mytoday2;
}


function getAge(dateString) {
    var now = new Date();
    var today = new Date(now.getYear(), now.getMonth(), now.getDate());

    var yearNow = now.getYear();
    var monthNow = now.getMonth();
    var dateNow = now.getDate();

    var dob = new Date(dateString.substring(6, 10),
        dateString.substring(3, 5) - 1,
        dateString.substring(0, 2)
    );

    var yearDob = dob.getYear();
    var monthDob = dob.getMonth();
    var dateDob = dob.getDate();
    var age = {};
    var ageString = "";
    var yearString = "";
    var monthString = "";
    var dayString = "";
    var monthAge;
    var dateAge;
    var yearAge;
    yearAge = yearNow - yearDob;

    if (monthNow >= monthDob)
        monthAge = monthNow - monthDob;
    else {
        yearAge--;
        monthAge = 12 + monthNow - monthDob;
    }

    if (dateNow >= dateDob)
        dateAge = dateNow - dateDob;
    else {
        monthAge--;
        dateAge = 31 + dateNow - dateDob;

        if (monthAge < 0) {
            monthAge = 11;
            yearAge--;
        }
    }

    age = {
        years: yearAge,
        months: monthAge,
        days: dateAge
    };

    if (age.years > 1) yearString = " Años";
    else yearString = " Año";
    if (age.months > 1) monthString = " Meses";
    else monthString = " Mes";
    if (age.days > 1) dayString = " Dias";
    else dayString = " Dia";


    //if ((age.years > 0) && (age.months > 0) && (age.days > 0))
    //    ageString = age.years + yearString + ", " + age.months + monthString + ", y " + age.days + dayString + "";
    //else if ((age.years == 0) && (age.months == 0) && (age.days > 0))
    //    ageString = "" + age.days + dayString + "";
    //else if ((age.years > 0) && (age.months == 0) && (age.days == 0))
    //    ageString = age.years + yearString + "";
    //else if ((age.years > 0) && (age.months > 0) && (age.days == 0))
    //    ageString = age.years + yearString + " y " + age.months + monthString + "";
    //else if ((age.years == 0) && (age.months > 0) && (age.days > 0))
    //    ageString = age.months + monthString + " y " + age.days + dayString + "";
    //else if ((age.years > 0) && (age.months == 0) && (age.days > 0))
    //    ageString = age.years + yearString + " y " + age.days + dayString + "";
    //else if ((age.years == 0) && (age.months > 0) && (age.days == 0))
    //    ageString = age.months + monthString + "";
    //else ageString = "Oops! Escoja una fecha inferior a la del dia!";

    if ((age.years > 0) && (age.months > 0) && (age.days > 0))
        ageString = age.years + yearString;
    else if ((age.years == 0) && (age.months == 0) && (age.days > 0))
        ageString = age.days + dayString;
    else if ((age.years > 0) && (age.months == 0) && (age.days == 0))
        ageString = age.years + yearString;
    else if ((age.years > 0) && (age.months > 0) && (age.days == 0))
        ageString = age.years + yearString;
    else if ((age.years == 0) && (age.months > 0) && (age.days > 0))
        ageString = age.months + monthString;
    else if ((age.years > 0) && (age.months == 0) && (age.days > 0))
        ageString = age.years + yearString;
    else if ((age.years == 0) && (age.months > 0) && (age.days == 0))
        ageString = age.months + monthString;
    else ageString = "Oops! Escoja una fecha inferior a la del dia!";

    return ageString;
}

function daysInMonth(m, y) {
    switch (m) {
        case "2":
            return (y % 4 === 0 && y % 100) || y % 400 === 0 ? 29 : 28;
        case "9": case "4": case "6": case "11":
            return 30;
        default:
            return 31
    }
}

function isValidDate(d, m, y) {
    return m >= 0 && m < 12 && d > 0 && d <= daysInMonth(m, y);
}

$(document).ready(function () {
      
    $('.PsDates').datepicker({
        format: "dd/mm/yyyy",
       // todayBtn: "linked",
     //   clearBtn: true,
        language: "es",
        autoclose: true,
        todayHighlight: true
    });
    $(".PsTimes").datepicker({
        format: "hh:mm A",
    });
    $('#Age').attr('readonly', true);
     //$(".PsDates").datetimepicker({
    //    format: "DD/MM/YYYY",
    //    icons: {
    //        up: "fa fa-chevron-circle-up",
    //        down: "fa fa-chevron-circle-down",
    //        next: 'fa fa-chevron-circle-right',
    //        previous: 'fa fa-chevron-circle-left'
    //    },
    //});

    $(".Tel").mask("(999) 999-9999");
  locale: 'es'
    //$(".PsDates").datetimepicker({
    //    format: "DD/MM/YYYY",       
    //});
    //$(".PsDates").datetimepicker({
    //    format: "DD/MM/YYYY",
    //    icons: {
    //        up: "fa fa-chevron-circle-up",
    //        down: "fa fa-chevron-circle-down",
    //        next: 'fa fa-chevron-circle-right',
    //        previous: 'fa fa-chevron-circle-left'
    //    },
    //});

    $(".IsDetailForm").find("input,select,textarea,button").prop("disabled", true);

    //$(".PsTimes").datetimepicker({
    //    format: "hh:mm A",
    //});

    //$(".PsTimes").datetimepicker({
    //    format: "hh:mm A",
    //    icons: {
    //        up: "fa fa-chevron-circle-up",
    //        down: "fa fa-chevron-circle-down",
    //        next: 'fa fa-chevron-circle-right',
    //        previous: 'fa fa-chevron-circle-left'
    //    },
    //});
    $("#BornDate").change(function (e) {
        // e.preventDefault();
        //var today = new Date();
        //var mydate = $('#BornDate').val();
        //var birthDate = new Date($('#BornDate').val());
        //var age = today.getFullYear() - birthDate.getFullYear();
        //var m = today.getMonth() - birthDate.getMonth();
        //if (m < 0 || (m === 0 && today.getDate() < birthDate.getDate())) {
        //    age--;
        //}
        if ($("#BornDate").val() != '') {
            return $('#Age').val(getAge($('#BornDate').val()));
        }

        //  $("#Age").val(getAge($("#BornDate").val()));

    });
    $('#manualAge').change(function () {
        if ($(this).is(":checked")) {
            var returnVal = confirm("Seguro que desea insertar una edad manual?");
            $(this).attr("checked", returnVal);
            if (returnVal == true) {
                $('#Age').attr('readonly', false);
                $('#BornDate').attr('readonly', true);
                $('#BornDate').val('');

            } else {
                $('#Age').attr('readonly', true);
                $('#BornDate').attr('readonly', false);
                $('#Age').val('');
            }

        }
        else {
            $('#Age').attr('readonly', true);
            $('#BornDate').attr('readonly', false);
            $('#Age').val('');
        }
        $('#textbox1').val($(this).is(':checked'));
    });
    $('.dateVal').change(function () {
        if (($("#Day").val() != "" && $("#Day").val() != "0") && $("#Month").val() != "" && $("#Month").val() != "0" && $("#Year").val() != "" && $("#Year").val() != "0") {

            if (daysInMonth($("#Month").val(), $("#Year").val()) < $("#Day").val()) {
                $('#Day option[value=0]').prop('selected', true);
                alert("Fecha invalida");
                return;
            }

            var myDate = ('0' + $("#Day").val()).slice(-2) + "/" + ('0' + $("#Month").val()).slice(-2) + "/" + $("#Year").val();
            console.log(myDate);
            return $('#Age').val(getAge(myDate));

        }
    });

    //$(function () {
    //    $.validator.methods.date = function (value, element) {
    //        //if (typeof ($.browser) == "undefined") {
    //        //    $.browser = {};
    //        //}
    //        if (typeof ($.browser.webkit) == "undefined") {
    //            $.browser.webkit = false;
    //        }
    //        //  try {
    //        if ($.browser.webkit) {

    //            //ES - Chrome does not use the locale when new Date objects instantiated:
    //            var d = new Date();

    //            return this.optional(element) || !/Invalid|NaN/.test(new Date(d.toLocaleDateString(value)));
    //        }
    //        else {

    //            return this.optional(element) || !/Invalid|NaN/.test(new Date(value));
    //        }
    //        //}
    //        //catch (err) {
    //        //    return this.optional(element) || !/Invalid|NaN/.test(new Date(value));
    //        // //   document.getElementById("demo").innerHTML = err.message;
    //        //}
    //    };
    //});

    //function getAge(dateString) {
    //    var now = new Date();
    //    var today = new Date(now.getYear(), now.getMonth(), now.getDate());

    //    var yearNow = now.getYear();
    //    var monthNow = now.getMonth();
    //    var dateNow = now.getDate();

    //    var dob = new Date(dateString.substring(6, 10),
    //        dateString.substring(3, 5) - 1,
    //        dateString.substring(0, 2)
    //    );

    //    var yearDob = dob.getYear();
    //    var monthDob = dob.getMonth();
    //    var dateDob = dob.getDate();
    //    var age = {};
    //    var ageString = "";
    //    var yearString = "";
    //    var monthString = "";
    //    var dayString = "";
    //    var monthAge;
    //    var dateAge;
    //    var yearAge;
    //    yearAge = yearNow - yearDob;

    //    if (monthNow >= monthDob)
    //        monthAge = monthNow - monthDob;
    //    else {
    //        yearAge--;
    //        monthAge = 12 + monthNow - monthDob;
    //    }

    //    if (dateNow >= dateDob)
    //        dateAge = dateNow - dateDob;
    //    else {
    //        monthAge--;
    //        dateAge = 31 + dateNow - dateDob;

    //        if (monthAge < 0) {
    //            monthAge = 11;
    //            yearAge--;
    //        }
    //    }

    //    age = {
    //        years: yearAge,
    //        months: monthAge,
    //        days: dateAge
    //    };

    //    if (age.years > 1) yearString = " years";
    //    else yearString = " year";
    //    if (age.months > 1) monthString = " months";
    //    else monthString = " month";
    //    if (age.days > 1) dayString = " days";
    //    else dayString = " day";


    //    if ((age.years > 0) && (age.months > 0) && (age.days > 0))
    //        ageString = age.years + yearString + ", " + age.months + monthString + ", and " + age.days + dayString + " old.";
    //    else if ((age.years == 0) && (age.months == 0) && (age.days > 0))
    //        ageString = "Only " + age.days + dayString + " old!";
    //    else if ((age.years > 0) && (age.months == 0) && (age.days == 0))
    //        ageString = age.years + yearString + " old. Happy Birthday!!";
    //    else if ((age.years > 0) && (age.months > 0) && (age.days == 0))
    //        ageString = age.years + yearString + " and " + age.months + monthString + " old.";
    //    else if ((age.years == 0) && (age.months > 0) && (age.days > 0))
    //        ageString = age.months + monthString + " and " + age.days + dayString + " old.";
    //    else if ((age.years > 0) && (age.months == 0) && (age.days > 0))
    //        ageString = age.years + yearString + " and " + age.days + dayString + " old.";
    //    else if ((age.years == 0) && (age.months > 0) && (age.days == 0))
    //        ageString = age.months + monthString + " old.";
    //    else ageString = "Oops! Could not calculate age!";

    //    return ageString;
    //}


    //checkSupportForInputTypeDate();


    //function checkSupportForInputTypeDate() {
    //    jQuery.validator.methods.date = function (value, element) {
    //        var isChrome = /Chrome/.test(navigator.userAgent) && /Google Inc/.test(navigator.vendor);
    //        var isSafari = /Safari/.test(navigator.userAgent) && /Apple Computer/.test(navigator.vendor);
    //        if (isSafari || isChrome) {
    //            var d = new Date();
    //            return this.optional(element) || !/Invalid|NaN/.test(new Date(d.toLocaleDateString(value)));
    //        } else {
    //            return this.optional(element) || !/Invalid|NaN/.test(new Date(value));
    //        }
    //    };
    //}


    //$("").children().prop('disabled', true);
    //$(".")({
    //    $(function() {
    //    $('input,textarea,select').attr('disabled', true);
    //});
    //$(function () {
    //    $("input[name='setAlg']").attr("disabled", true);
    //});


    //function printRecibe (recipedate,patientname,recipetext,observation, place) {

    //        var detalle = "<br><br>";
    //        detalle += " Fecha: <b>" + recipedate.val() + "</b>  <br>";


    //        detalle += "Se otorga la presente receta a: <b>" + patientname.val() + "</b>    <br>";
    //        detalle += " <br> <br> <b>" + recipetext.val() + "</b> <br> <br> <br>";
    //        detalle += "" + observation.val() + " <br><br><br> <br>"; detalle += "<br><br><br><br><br><br><br>  ";
    //        detalle += "<br>";
    //        detalle += " Expido la presente Certificación en: " + place.val() + "    <br>";

    //        detalle += "<br><br><br><br>  ";
    //        detalle += "<br><br><br><br>  ";
    //        detalle += "<center> Firma Medico:___________________________________</center>";

    //        //detalle += "<div style='position:absolute; width:100%; bottom=1px;' align='right'>Firma Medico:_______________________________</div>";



    //        var url = '@Url.Action("DetailsPrint", "Reports", new {area = "Configurations", id = Model.Patient.Person.AuthorId, description = "Receta Medica"})';
    //        url = url + "&body=" + encodeURIComponent(detalle);
    //        var win = window.open(url);

    //        if (win) {
    //            //Browser has allowed it to be opened
    //            win.focus();
    //        } else {
    //            //Browser has blocked it
    //            alert("Porfavor, debes permitir que se abran las ventanas emergentes o el reporte no va a salir :'( ");
    //        }


    //};

    //function getAge(dateString) {
    //    var now = new Date();
    //    var today = new Date(now.getYear(), now.getMonth(), now.getDate());

    //    var yearNow = now.getYear();
    //    var monthNow = now.getMonth();
    //    var dateNow = now.getDate();
    //    //date must be mm/dd/yyyy
    //    var dob = new Date(dateString.substring(6, 10),
    //        dateString.substring(0, 2) - 1,
    //        dateString.substring(3, 5)
    //    );

    //    var yearDob = dob.getFullYear();
    //    var monthDob = dob.getMonth();
    //    var dateDob = dob.getDate();
    //    var age = {};
    //    var ageString = "";
    //    var yearString = "";
    //    var monthString = "";
    //    var dayString = "";
    //    var monthage = monthNow;
    //    var dateAge = dateNow;
    //   var yearAge = yearNow - yearDob;

    //    if (monthNow >= monthDob)
    //        monthage = monthNow - monthDob;
    //    else {
    //        yearAge--;
    //          monthage = 12 + monthNow - monthDob;
    //    }

    //    if (dateNow >= dateDob)
    //        dateAge = dateNow - dateDob;
    //    else {
    //        monthage--;
    //          dateAge = 31 + dateNow - dateDob;

    //        if (monthage < 0) {
    //            monthage = 11;
    //            yearAge--;
    //        }
    //    }

    //    age = {
    //        years: yearAge,
    //        months: monthage,
    //        days: dateAge
    //    };

    //    if (age.years > 1) yearString = " Años";
    //    else yearString = " Año";
    //    if (age.months > 1) monthString = " Meses";
    //    else monthString = " Mes";
    //    if (age.days > 1) dayString = " Dias";
    //    else dayString = " Dia";


    //    if ((age.years > 0) && (age.months > 0) && (age.days > 0))
    //        ageString = age.years + yearString + ", " + age.months + monthString + ", and " + age.days + dayString + " old.";
    //    else if ((age.years == 0) && (age.months == 0) && (age.days > 0))
    //        ageString = "Only " + age.days + dayString + " old!";
    //    else if ((age.years > 0) && (age.months == 0) && (age.days == 0))
    //        ageString = age.years + yearString + " old. Happy Birthday!!";
    //    else if ((age.years > 0) && (age.months > 0) && (age.days == 0))
    //        ageString = age.years + yearString + " and " + age.months + monthString + " old.";
    //    else if ((age.years == 0) && (age.months > 0) && (age.days > 0))
    //        ageString = age.months + monthString + " and " + age.days + dayString + " old.";
    //    else if ((age.years > 0) && (age.months == 0) && (age.days > 0))
    //        ageString = age.years + yearString + " and " + age.days + dayString + " old.";
    //    else if ((age.years == 0) && (age.months > 0) && (age.days == 0))
    //        ageString = age.months + monthString + " old.";
    //    else ageString = "Oops! Could not calculate age!";

    //    return ageString;
    //}


});
