$(() =>{
    let product = []

    for(let i=0; i<3; i++)
        $('#'+i).change(function() {
            let articleName = $("#art"+i).text()
            let articlePrice = $("#pr"+i).text()
            let item = {articleName: articleName, articlePrice: articlePrice}
            if(!product.find(p => p.articleName === articleName)) product.push(item)
            else product.remove(item)

            console.log(product)

            if(product.length == 0) $("#order").prop("disabled",true)
            else $("#order").prop("disabled", false)
        });

    $("#view").click(() => {
        if(product.length == 0) alert("Nessun Articolo")
        else{
            let str = ""
            for(let i of product)
                str += i.articleName + " --- "
            str = str.slice(0, -4)
            alert(str)
        }
    })

    $("#order").click(() => {
        if(product.length > 0){
            let jsonProduct = JSON.stringify(product)
            window.location.replace("order.html?"+jsonProduct)
        }
    })
})

Array.prototype.remove = function(value) {
    const index = this.findIndex(item => item.articleName === value.articleName);
    if (index !== -1) {
      this.splice(index, 1);
    }
  };
  
  