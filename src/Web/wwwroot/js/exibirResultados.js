$(document).on("click", ".exibirResultados", function (e) {
    var action = $(this).data("action");

    $.ajax({
        url: action,
        type: 'get',
        processData: false,
        contentType: false,
        success: function (data) {
            $("#resultados").html(data);
        },
        error: function () {
            Alert("Erro ao processar a operação.");
        }
    });
});