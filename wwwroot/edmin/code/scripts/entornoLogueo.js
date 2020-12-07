jQuery(document).ready(function ($) {



    $('#nombreLogueo').ready(function () {
        logueo($('#inputUser').val());
    });

    function logueo(nombre) {
        $('#nombreLogueo').removeAttr('a');
        $('#nombreLogueo').addClass('<a> nombre </a>');
    }

});