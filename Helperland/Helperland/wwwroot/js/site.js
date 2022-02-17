$(document).ready(() => {

    // To set Login Modal open
    let searchParams = new URLSearchParams(window.location.search);
    if (searchParams.has("isLoginOpen")) {

        $("#loginModal").modal("show");
    }


    /* Set LARGE-HEADER for Home page and SP register page */
    if ($("#large-header").length) {

        $("header").addClass("large-header");
        $("#branding").attr("src", "/images/logo-large.png");
    }

    /* Sidenavbar Events Starts */
    $('#hamburger').click(() => {
        $('#side-navbar-model').addClass('open');
    });
    $('#side-navbar-wrapper').click(() => {
        $('#side-navbar-model').removeClass('open');
    });
    $('#side-navbar-menu').click((e) => {
        e.stopPropagation();
    });
    $('.side-nav-link').click(() => {
        $('#side-navbar-model').removeClass('open');
    });


    /* Window Events */
    $(this).scroll(() => {
        $('#side-navbar-model').removeClass('open');
    });


    /* Only for FAQ page */
    /* Data Toggle Control Starts */
    $('#customerFAQ').click(() => {
        $('.serviceFAQ').removeClass('open');
        $('.customerFAQ').addClass('open');
        $('#serviceFAQ').removeClass('active');
        $('#customerFAQ').addClass('active');
    });
    $('#serviceFAQ').click(() => {
        $('.customerFAQ').removeClass('open');
        $('.serviceFAQ').addClass('open');
        $('#customerFAQ').removeClass('active');
        $('#serviceFAQ').addClass('active');
    });

    $('#question1').click(() => { $('#question1').toggleClass('open'); });
    $('#question2').click(() => { $('#question2').toggleClass('open'); });
    $('#question3').click(() => { $('#question3').toggleClass('open'); });
    $('#question4').click(() => { $('#question4').toggleClass('open'); });
    $('#question5').click(() => { $('#question5').toggleClass('open'); });
    $('#question6').click(() => { $('#question6').toggleClass('open'); });
    $('#question7').click(() => { $('#question7').toggleClass('open'); });

    $('#sp-question1').click(() => { $('#sp-question1').toggleClass('open'); });
    $('#sp-question2').click(() => { $('#sp-question2').toggleClass('open'); });
    /* Data Toggle Control Ends */

});
