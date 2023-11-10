let product = []
for(let i = 0; i<3; i++)
    document.getElementById(i).addEventListener("change", () =>{
        if(document.getElementById(i).checked)
            product.push(document.getElementById("art"+i).innerHTML)
        else
            product.remove(document.getElementById("art"+i).innerHTML)
        
    })

document.getElementById("submit").onclick = () => {
    if(product.length == 0) alert("Nessun Articolo")
    else{
        let str = ""
        for(let i of product)
            str += i + " --- "
        str = str.slice(0, -4)
        alert(str)
    }
}

Array.prototype.remove = function(value){
    if(this.indexOf(value) != -1)
        this.splice(this.indexOf(value), 1)
}