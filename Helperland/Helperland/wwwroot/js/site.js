// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

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
    });

});
