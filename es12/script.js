$(() => {
    $("#btn").click((e) => {
        $("#lamp").attr("src", "assets/img/" + ($("#lamp").attr("src").includes("offLamp") ? "onLamp.png" : "offLamp.png"));
    });
});