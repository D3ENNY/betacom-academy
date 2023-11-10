$(() => {
    let product = document.URL.split("?")[1].replaceAll("%22", '"')
    product = JSON.parse(product)
    product.forEach(x => {
        x.articleName = x.articleName.replaceAll("%20", " ")
        x.articlePrice = x.articlePrice.replaceAll("%20", " ")
        x.discount = x.discount.replaceAll("%20", " ")
    });

    if(product.lenght == 0) $("#result").text("nessun articolo presente")
    else{
        let str = ""
        let price = 0.0;
        for(let i of product){
            str += i.articleName + " --- "
            price += (parseFloat(i.articlePrice.replace(",",".") * i.discount)/100)
        }
        str = str.slice(0,-4)
        $("#result").text(str)
        $("#price").text(price.toFixed(2) + "€")
        console.log(product)
    }
})

const escapeRegex = (string) =>{
    return string.replace(/[.*+?^${}()|[\]\\]/g, '\\$&')
}

String.prototype.replaceAll = (find, replace) =>{
    return this.replace(new RegExp(escapeRegex(find), 'g'), replace)
}


