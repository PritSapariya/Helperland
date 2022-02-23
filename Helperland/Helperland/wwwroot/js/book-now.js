
$().ready(() => {

    /* INITIAL CODE LOADING */
    $('#addAddressForm').hide();
    let date = new Date();
    let day = ("0" + date.getDate()).slice(-2);
    let month = ("0" + (date.getMonth() + 1)).slice(-2);
    let year = date.getFullYear();
    $("#serviceDateSummary").text(day + "/" + month + "/" + year);



    // Add Address Form Toggle Logic
    $('#addAddressButton').click(() => {
        $('#addAddressButton').hide();
        $('#addAddressForm').show();
    });
    $('#closeAddressForm').click(() => {
        $('#addAddressButton').show();
        $('#addAddressForm').hide();
    });

    $("#extra-service-inside-cabinet").change(() => {
        if (!$(this).is(':checked')) {
            return confirm("Are you sure?");
        }
    });

    /* =============  STEP 1 -> Service Setup  ========== */

    $("#step1").click(() => {
        $(".nav-link").removeClass("filled");
        $(".nav-link").removeClass("active");
        $("#section1").show();
        $("#step1").addClass("active");
        $("#step2").addClass("disabled");
        $("#section2").empty();
        $("section2").hide();
    });

    $("#submit1").click(() => {

        $("#postalCodeError").empty();

        if (postalCodeValidation()) {

            var data = {}
            data.postalCode = parseInt($("#postalCode").val())            

            $.ajax({
                type: "POST",
                url: "/BookNow/CheckPostalCode",
                data: JSON.stringify(data),
                contentType: 'application/json; charset=utf-8',
                success: function (responce) {
                    if (responce.success == true) {
                        step1Complete();
                    }
                    else {
                        $("#step1message").append(`
                                                    <div class="alert alert-warning alert-dismissible fade show" role="alert">
                                                        ${responce.message}
                                                        <button type="button" class="btn-close" data-bs-dismiss="alert" aria-label="Close"></button>
                                                    </div>
                                                 `).fadeOut(7000, () => $("#step1message").empty());
                    }
                },
                failure: function (response) {
                    alert("failure");
                },
                error: function (response) {
                    alert("Something went Worng");
                }
            });

        }
        else {
            $("#postalCodeError").append("<div>Please enter valid 6 digit Postal Code</div");
        }

    });

    // Client side validation
    const postalCodeValidation = () => {
        if ($("#postalCode").val().length == 6)
            return true;
        else return false;
    }

    const step1Complete = () => {
        $("#section1").hide();
        $("#step1").removeClass("active");
        $("#step1").addClass("filled");
        $("#step2").addClass("active");
        $("#step2").removeClass("disabled");
        $("#section2").load("BookNow/GetDetail");
    };


    /* =============  STEP 2, 3 & 4 JS is at own page  ======== */



    //$('#section1').hide();
    //$('#section2').show();
    //$('#section3').hide();
    //$('#section4').hide();

    // $('#section2').show();
    // $('#section1').hide();

    // $('#section1').hide();
    // $('#section2').hide();
    // $('#section3').show();

    // $('#section1').hide();
    // $('#section2').hide();
    // $('#section3').hide();
    // $('#section4').show();



});