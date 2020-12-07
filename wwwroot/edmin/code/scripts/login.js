 jQuery(document).ready(function ($) {


    $('#mesa').ready(function () {
            Validate();            
    });

    function Validate() {

        $.ajax({
            url: '/Home/GetRoles',
            async: false,
            type: 'POST',
            data: record,
            beforeSend: function (xhr, opts) {
            },
            complete: function () {
            },
            success: function (data) {
                if (data.roles == 'mesero') {    
                    $('#mesa').addClass('hidden');
                    $('#usuario').addClass('hidden');
                    $('#inventario').addClass('hidden');

                }
                else if (data.roles == 'cocinero') {
                    $('#mesa').addClass('hidden');
                    $('#usuario').addClass('hidden');
                }
                else (data.roles == 'administrador')
                {
                    $('#mesa').removeClass('hidden');
                    $('#usuario').removeClass('hidden');
                    $('#inventario').removeClass('hidden');
                }
            },
            error: function (record) {
                $('#factura').addClass('hidden');


            }
        });
    }

  
});
