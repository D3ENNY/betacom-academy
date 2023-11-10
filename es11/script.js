$(() => {
    $("#btn").click((e) => { 
        let src = $("#lamp").attr("src");
        console.log(src);
        if(src.includes("onLamp"))
            $("#lamp").attr("src", "assets/img/offLamp.png");
        else
            $("#lamp").attr("src", "assets/img/onLamp.png");
    });
}) 