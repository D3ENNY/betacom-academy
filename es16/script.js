$(() =>{
    let product = []

    for(let i=0; i<3; i++)
        $('#'+i).change(function() {
            let article = $("#art"+i).text()
            if(!product.includes(article)) product.push(article)
            else product.remove(article)
        });

    $("#view").click(() => {
        if(product.length == 0) alert("Nessun Articolo")
        else{
            let str = ""
            for(let i of product)
                str += i + " --- "
            str = str.slice(0, -4)
            alert(str)
        }
    })

    $("#order").click(() => {
        window.location.replace("order.html?"+product)
    })
})

Array.prototype.remove = function(value){
    if(this.indexOf(value) != -1)
        this.splice(this.indexOf(value), 1)
}

