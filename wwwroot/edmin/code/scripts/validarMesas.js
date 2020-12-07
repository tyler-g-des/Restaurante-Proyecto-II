jQuery(document).ready(function ($) {

    $('#primeraMesa').ready(function () {
        ValidateMesa1();
        ValidateMesa2();
        ValidateMesa3();
        ValidateMesa4();
        ValidateMesa5();
        ValidateMesa6();
        ValidateMesa7();
        ValidateMesa8();
        ValidateMesa9();

    });

    function ValidateMesa1() {
            var record = {
                idMesaBusqueda1: 1
            };

            $.ajax({
                url: '/mesas/GetStatusMesa1',
                async: false,
                type: 'POST',
                data: record,
                beforeSend: function (xhr, opts) {
                },
                complete: function () {
                },
                success: function (data) {
                    if (data.mesa1 == "Libre") {

                        $('#primeraMesa').removeClass('btn-success');
                        $('#primeraMesa').removeClass('btn-warning');

                        $('#primeraMesa').addClass('btn-success');

                    }
                    else if (data.mesa1 == "Ocupada") {

                        $('#primeraMesa').removeClass('btn-success');
                        $('#primeraMesa').removeClass('btn-warning');

                        $('#primeraMesa').addClass('btn-danger');

                    }
                    else if (data.mesa1 == "Atendida") {

                        $('#primeraMesa').removeClass('btn-success');
                        $('#primeraMesa').removeClass('btn-danger');

                        $('#primeraMesa').addClass('btn-warning');

                    }

                },
                error: function (record) {
                    alert("error2");

                }
            });
        } 

    function ValidateMesa2() {
        var record = {
            idMesaBusqueda2: 2
        };

        $.ajax({
            url: '/mesas/GetStatusMesa2',
            async: false,
            type: 'POST',
            data: record,
            beforeSend: function (xhr, opts) {
            },
            complete: function () {
            },
            success: function (data) {
                if (data.mesa2 == "Libre") {

                    $('#segundaMesa').removeClass('btn-success');
                    $('#segundaMesa').removeClass('btn-warning');

                    $('#segundaMesa').addClass('btn-success');

                }
                else if (data.mesa2 == "Ocupada") {

                    $('#segundaMesa').removeClass('btn-success');
                    $('#segundaMesa').removeClass('btn-warning');

                    $('#segundaMesa').addClass('btn-danger');

                }
                else if (data.mesa2 == "Atendida") {

                    $('#segundaMesa').removeClass('btn-success');
                    $('#segundaMesa').removeClass('btn-danger');

                    $('#segundaMesa').addClass('btn-warning');

                }
            },
            error: function (record) {
                alert("error2");

            }
        });
    }

    function ValidateMesa3() {
        var record = {
            idMesaBusqueda3: 3
        };

        $.ajax({
            url: '/mesas/GetStatusMesa3',
            async: false,
            type: 'POST',
            data: record,
            beforeSend: function (xhr, opts) {
            },
            complete: function () {
            },
            success: function (data) {
                if (data.mesa3 == "Libre") {

                    $('#terceraMesa').removeClass('btn-success');
                    $('#terceraMesa').removeClass('btn-warning');

                    $('#terceraMesa').addClass('btn-success');

                }
                else if (data.mesa3 == "Ocupada") {

                    $('#terceraMesa').removeClass('btn-success');
                    $('#terceraMesa').removeClass('btn-warning');

                    $('#terceraMesa').addClass('btn-danger');

                }
                else if (data.mesa3 == "Atendida") {

                    $('#terceraMesa').removeClass('btn-success');
                    $('#terceraMesa').removeClass('btn-danger');

                    $('#terceraMesa').addClass('btn-warning');

                }
            },
            error: function (record) {
                alert("error2");

            }
        });
    } 

    function ValidateMesa4() {
        var record = {
            idMesaBusqueda4: 4
        };

        $.ajax({
            url: '/mesas/GetStatusMesa4',
            async: false,
            type: 'POST',
            data: record,
            beforeSend: function (xhr, opts) {
            },
            complete: function () {
            },
            success: function (data) {
                if (data.mesa4 == "Libre") {

                    $('#cuartaMesa').removeClass('btn-success');
                    $('#cuartaMesa').removeClass('btn-warning');

                    $('#cuartaMesa').addClass('btn-success');

                }
                else if (data.mesa4 == "Ocupada") {

                    $('#cuartaMesa').removeClass('btn-success');
                    $('#cuartaMesa').removeClass('btn-warning');

                    $('#cuartaMesa').addClass('btn-danger');

                }
                else if (data.mesa4 == "Atendida") {

                    $('#cuartaMesa').removeClass('btn-success');
                    $('#cuartaMesa').removeClass('btn-danger');

                    $('#cuartaMesa').addClass('btn-warning');

                }
            },
            error: function (record) {
                alert("error2");

            }
        });
    } 

    function ValidateMesa5() {
        var record = {
            idMesaBusqueda5: 5
        };

        $.ajax({
            url: '/mesas/GetStatusMesa5',
            async: false,
            type: 'POST',
            data: record,
            beforeSend: function (xhr, opts) {
            },
            complete: function () {
            },
            success: function (data) {
                if (data.mesa5 == "Libre") {

                    $('#quintaMesa').removeClass('btn-success');
                    $('#quintaMesa').removeClass('btn-warning');

                    $('#quintaMesa').addClass('btn-success');

                }
                else if (data.mesa5 == "Ocupada") {

                    $('#quintaMesa').removeClass('btn-success');
                    $('#quintaMesa').removeClass('btn-warning');

                    $('#quintaMesa').addClass('btn-danger');

                }
                else if (data.mesa5 == "Atendida") {

                    $('#quintaMesa').removeClass('btn-success');
                    $('#quintaMesa').removeClass('btn-danger');

                    $('#quintaMesa').addClass('btn-warning');

                }
            },
            error: function (record) {
                alert("error2");

            }
        });
    } 

    function ValidateMesa6() {
        var record = {
            idMesaBusqueda6: 6
        };

        $.ajax({
            url: '/mesas/GetStatusMesa6',
            async: false,
            type: 'POST',
            data: record,
            beforeSend: function (xhr, opts) {
            },
            complete: function () {
            },
            success: function (data) {
                if (data.mesa6 == "Libre") {

                    $('#sextaMesa').removeClass('btn-success');
                    $('#sextaMesa').removeClass('btn-warning');

                    $('#sextaMesa').addClass('btn-success');

                }
                else if (data.mesa6 == "Ocupada") {

                    $('#sextaMesa').removeClass('btn-success');
                    $('#sextaMesa').removeClass('btn-warning');

                    $('#sextaMesa').addClass('btn-danger');

                }
                else if (data.mesa6 == "Atendida") {

                    $('#sextaMesa').removeClass('btn-success');
                    $('#sextaMesa').removeClass('btn-danger');

                    $('#sextaMesa').addClass('btn-warning');

                }
            },
            error: function (record) {
                alert("error2");

            }
        });
    } 

    function ValidateMesa7() {
        var record = {
            idMesaBusqueda7: 7
        };

        $.ajax({
            url: '/mesas/GetStatusMesa7',
            async: false,
            type: 'POST',
            data: record,
            beforeSend: function (xhr, opts) {
            },
            complete: function () {
            },
            success: function (data) {
                if (data.mesa7 == "Libre") {

                    $('#septimaMesa').removeClass('btn-success');
                    $('#septimaMesa').removeClass('btn-warning');

                    $('#septimaMesa').addClass('btn-success');

                }
                else if (data.mesa7 == "Ocupada") {

                    $('#septimaMesa').removeClass('btn-success');
                    $('#septimaMesa').removeClass('btn-warning');

                    $('#septimaMesa').addClass('btn-danger');

                }
                else if (data.mesa7 == "Atendida") {

                    $('#septimaMesa').removeClass('btn-success');
                    $('#septimaMesa').removeClass('btn-danger');

                    $('#septimaMesa').addClass('btn-warning');

                }
            },
            error: function (record) {
                alert("error2");

            }
        });
    } 

    function ValidateMesa8() {
        var record = {
            idMesaBusqueda8: 8
        };

        $.ajax({
            url: '/mesas/GetStatusMesa8',
            async: false,
            type: 'POST',
            data: record,
            beforeSend: function (xhr, opts) {
            },
            complete: function () {
            },
            success: function (data) {
                if (data.mesa8 == "Libre") {

                    $('#octabaMesa').removeClass('btn-success');
                    $('#octabaMesa').removeClass('btn-warning');

                    $('#octabaMesa').addClass('btn-success');

                }
                else if (data.mesa8 == "Ocupada") {

                    $('#octabaMesa').removeClass('btn-success');
                    $('#octabaMesa').removeClass('btn-warning');

                    $('#octabaMesa').addClass('btn-danger');

                }
                else if (data.mesa8 == "Atendida") {

                    $('#octabaMesa').removeClass('btn-success');
                    $('#octabaMesa').removeClass('btn-danger');

                    $('#octabaMesa').addClass('btn-warning');

                }
            },
            error: function (record) {
                alert("error2");

            }
        });
    } 

    function ValidateMesa9() {
        var record = {
            idMesaBusqueda9: 9
        };

        $.ajax({
            url: '/mesas/GetStatusMesa9',
            async: false,
            type: 'POST',
            data: record,
            beforeSend: function (xhr, opts) {
            },
            complete: function () {
            },
            success: function (data) {
                if (data.mesa9 == "Libre") {

                    $('#novenaMesa').removeClass('btn-success');
                    $('#novenaMesa').removeClass('btn-warning');

                    $('#novenaMesa').addClass('btn-success');

                }
                else if (data.mesa9 == "Ocupada") {

                    $('#novenaMesa').removeClass('btn-success');
                    $('#novenaMesa').removeClass('btn-warning');

                    $('#novenaMesa').addClass('btn-danger');

                }
                else if (data.mesa9 == "Atendida") {

                    $('#novenaMesa').removeClass('btn-success');
                    $('#novenaMesa').removeClass('btn-danger');

                    $('#novenaMesa').addClass('btn-warning');

                }
            },
            error: function (record) {
                alert("error2");

            }
        });
    } 
});