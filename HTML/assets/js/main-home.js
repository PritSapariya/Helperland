$(document).ready(() => {

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
    /* Sidenavbar Events Ends */

    /* Window Events */
    $(this).scroll(() => {
        $('#side-navbar-model').removeClass('open');

        /* Toggling the LARGE-HEADER class */
        if($(window).scrollTop() === 0) {
            $("header").addClass("large-header");
            $("#branding").attr("src","./assets/images/logo-large.png");
        }
        else {
            $("header").removeClass("large-header");
            $("#branding").attr("src","./assets/images/logo-small.png");
        }
    });
});