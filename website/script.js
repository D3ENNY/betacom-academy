function getEmployers () {
    fetch("https://localhost:7210/api/AnagraficaGenerales")
    .then(response => response.json())
    .then(data =>{
        console.log(data)
        document.getElementById("emp").textContent = JSON.stringify(data, null, 2)
    })
    .catch(err => console.log(err))
}