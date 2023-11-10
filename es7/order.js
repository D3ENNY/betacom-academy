$(() => {
    let product = document.URL.split("?")[1].replaceAll("%20", " ").split(",")
    if(product.length == 0) $("#result").text("nessun articolo")
    else{
        let str = ""
        for(let i of product)
            str += i + " --- "
        str = str.slice(0, -4)
        $("#result").text(str)
    }
})

const escapeRegex = () =>{
    return string.replace(/[.*+?^${}()|[\]\\]/g, '\\$&');
}

String.replaceAll = (find, replace) =>{
    return this.replace(new RegExp(escapeRegex(find), 'g'), replace);
}