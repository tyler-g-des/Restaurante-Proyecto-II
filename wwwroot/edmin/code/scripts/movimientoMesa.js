jQuery(document).ready(function ($) {

    $('#primeraMesa').on('click',function () {
        AccionesMesas1($('#primeraMesa').val());
    });
    $('#segundaMesa').on('click', function () {
        AccionesMesas2($('#primeraMesa').val());
    });
    $('#terceraMesa').on('click', function () {
        AccionesMesas3($('#primeraMesa').val());
    });
    $('#cuartaMesa').on('click', function () {
        AccionesMesas4($('#primeraMesa').val());
    });
    $('#quintaMesa').on('click', function () {
        AccionesMesas5($('#primeraMesa').val());
    });
    $('#sextaMesa').on('click', function () {
        AccionesMesas6($('#primeraMesa').val());
    });
    $('#septimaMesa').on('click', function () {
        AccionesMesas7($('#primeraMesa').val());
    });
    $('#octabaMesa').on('click', function () {
        AccionesMesas8($('#primeraMesa').val());
    });
    $('#novenaMesa').on('click', function () {
        AccionesMesas9($('#novenaMesa').val());
    });
     function AccionesMesas1(mesa) {

         if ($('#primeraMesa').hasClass('btn-success') == true) {

             var opcion = confirm("Deseas atender esta mesa");
             if (opcion == true) {
                 window.location.href = "/pedidos/Create";

             } else {
                 mensaje = "Has clickado Cancelar";
             }
                   
         }
         // metodo de prueba
         else if ($('#primeraMesa').hasClass('btn-danger') == true) {

             var opcion = confirm("Deseas liberar  esta mesa");
             if (opcion == true) {

                 var record = {
                     idMesaBusqueda1: 1
                 };
                 // Valida el pedido realizado para llevarlo a la pantalla del pedido
                 $.ajax({
                     url: '/Home/finalizarOrden',
                     async: false,
                     type: 'POST',
                     data: record,
                     beforeSend: function (xhr, opts) {
                     },
                     complete: function () {
                     },
                     success: function (data) {
                         if (data.estado == true) {
                             window.location.href = "/pedidos/Details/" + data.id;
                         }
                     }
                 });

             } else {
                 mensaje = "Has clickado Cancelar";
             }

         }


         else if ($('#primeraMesa').hasClass('btn-warning') == true) {

             var opcion = confirm("Esta mesa esta siendo atendida");
             if (opcion == true) {
             }
                window.location.href = "/pedidos/Index"

         }
    }

     function AccionesMesas2(mesa) {

        if ($('#segundaMesa').hasClass('btn-success') == true) {

            var opcion = confirm("Deseas atender esta mesa");
            if (opcion == true) {
                window.location.href = "/pedidos/Create";

            } else {
                mensaje = "Has clickado Cancelar";
            }

        }
        else if ($('#segundaMesa').hasClass('btn-danger') == true) {

            var opcion = confirm("Deseas liberar  esta mesa");
            if (opcion == true) {
                window.location.href = "/pedidos/Index"


            } else {
                mensaje = "Has clickado Cancelar";
            }

        }
        else if ($('#segundaMesa').hasClass('btn-warning') == true) {

            var opcion = confirm("Esta mesa esta siendo atendida");
            if (opcion == true) {
            } else {
            }

        }
    }

     function AccionesMesas3(mesa) {

        if ($('#terceraMesa').hasClass('btn-success') == true) {

            var opcion = confirm("Deseas atender esta mesa");
            if (opcion == true) {
                window.location.href = "/pedidos/Create";

            } else {
                mensaje = "Has clickado Cancelar";
            }

        }
        else if ($('#terceraMesa').hasClass('btn-danger') == true) {

            var opcion = confirm("Deseas liberar  esta mesa");
            if (opcion == true) {
                window.location.href = "/pedidos/Index"

            } else {
                mensaje = "Has clickado Cancelar";
            }

        }
        else if ($('#terceraMesa').hasClass('btn-warning') == true) {

            var opcion = confirm("Esta mesa esta siendo atendida");
            if (opcion == true) {
            } else {
            }

        }
    }

     function AccionesMesas4(mesa) {

        if ($('#cuartaMesa').hasClass('btn-success') == true) {

            var opcion = confirm("Deseas atender esta mesa");
            if (opcion == true) {
                window.location.href = "/pedidos/Create";

            } else {
                mensaje = "Has clickado Cancelar";
            }

        }
        else if ($('#cuartaMesa').hasClass('btn-danger') == true) {

            var opcion = confirm("Deseas liberar  esta mesa");
            if (opcion == true) {
                window.location.href = "/pedidos/Index"

            } else {
                mensaje = "Has clickado Cancelar";
            }

        }
        else if ($('#cuartaMesa').hasClass('btn-warning') == true) {

            var opcion = confirm("Esta mesa esta siendo atendida");
            if (opcion == true) {
            } else {
            }

        }
     }

     function AccionesMesas5(mesa) {

        if ($('#quintaMesa').hasClass('btn-success') == true) {

            var opcion = confirm("Deseas atender esta mesa");
            if (opcion == true) {
                window.location.href = "/pedidos/Create";

            } else {
                mensaje = "Has clickado Cancelar";
            }

        }
        else if ($('#quintaMesa').hasClass('btn-danger') == true) {

            var opcion = confirm("Deseas liberar  esta mesa");
            if (opcion == true) {
                window.location.href = "/pedidos/Index"

            } else {
                mensaje = "Has clickado Cancelar";
            }

        }
        else if ($('#quintaMesa').hasClass('btn-warning') == true) {

            var opcion = confirm("Esta mesa esta siendo atendida");
            if (opcion == true) {
            } else {
            }

        }
     }

     function AccionesMesas6(mesa) {

        if ($('#sextaMesa').hasClass('btn-success') == true) {

            var opcion = confirm("Deseas atender esta mesa");
            if (opcion == true) {
                window.location.href = "/pedidos/Create";

            } else {
                mensaje = "Has clickado Cancelar";
            }

        }
        else if ($('#sextaMesa').hasClass('btn-danger') == true) {

            var opcion = confirm("Deseas liberar  esta mesa");
            if (opcion == true) {
                window.location.href = "/pedidos/Index"

            } else {
                mensaje = "Has clickado Cancelar";
            }

        }
        else if ($('#sextaMesa').hasClass('btn-warning') == true) {

            var opcion = confirm("Esta mesa esta siendo atendida");
            if (opcion == true) {
            } else {
            }

        }
    }

     function AccionesMesas7(mesa) {

        if ($('#septimaMesa').hasClass('btn-success') == true) {

            var opcion = confirm("Deseas atender esta mesa");
            if (opcion == true) {
                window.location.href = "/pedidos/Create";

            } else {
                mensaje = "Has clickado Cancelar";
            }

        }
        else if ($('#septimaMesa').hasClass('btn-danger') == true) {

            var opcion = confirm("Deseas liberar  esta mesa");
            if (opcion == true) {
                window.location.href = "/pedidos/Index"

            } else {
                mensaje = "Has clickado Cancelar";
            }

        }
        else if ($('#septimaMesa').hasClass('btn-warning') == true) {

            var opcion = confirm("Esta mesa esta siendo atendida");
            if (opcion == true) {
            } else {
            }

        }
     }

     function AccionesMesas8(mesa) {

        if ($('#octabaMesa').hasClass('btn-success') == true) {

            var opcion = confirm("Deseas atender esta mesa");
            if (opcion == true) {
                window.location.href = "/pedidos/Create";

            } else {
                mensaje = "Has clickado Cancelar";
            }

        }
        else if ($('#octabaMesa').hasClass('btn-danger') == true) {

            var opcion = confirm("Deseas liberar  esta mesa");
            if (opcion == true) {
                window.location.href = "/pedidos/Index"
            } else {
                mensaje = "Has clickado Cancelar";
            }

        }
        else if ($('#octabaMesa').hasClass('btn-warning') == true) {

            var opcion = confirm("Esta mesa esta siendo atendida");
            if (opcion == true) {
            } else {
            }

        }
     }

     function AccionesMesas9(mesa) {

        if ($('#novenaMesa').hasClass('btn-success') == true) {

            var opcion = confirm("Deseas atender esta mesa");
            if (opcion == true) {
                window.location.href = "/pedidos/Create";

            } else {
                mensaje = "Has clickado Cancelar";
            }

        }
        else if ($('#novenaMesa').hasClass('btn-danger') == true) {

            var opcion = confirm("Deseas liberar  esta mesa");
            if (opcion == true) {
                window.location.href = "/pedidos/Index"

            } else {
                mensaje = "Has clickado Cancelar";
            }

        }
        else if ($('#novenaMesa').hasClass('btn-warning') == true) {

            var opcion = confirm("Esta mesa esta siendo atendida");
            if (opcion == true) {
            } else {
            }

        }
    }
});