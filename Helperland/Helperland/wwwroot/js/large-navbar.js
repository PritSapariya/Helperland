
$(document).ready(() => {

    /* Responsible for converting large navbar into small in HOME page and REGISTER AS SP page */
    $(this).scroll(() => {
        /* Toggling the LARGE - HEADER class */
        if ($(window).scrollTop() === 0) {
            $("header").addClass("large-header");
            $("#branding").attr("src", "/images/logo-large.png");
        }
        else {
            $("header").removeClass("large-header");
            $("#branding").attr("src", "/images/logo-small.png");
        }
    });
});
