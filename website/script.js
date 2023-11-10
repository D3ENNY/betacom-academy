fetch("https://localhost:7210")
.then(response => response.json())
.then(data =>{
    console.log(data)
})
.catch(err => console.log(err))

function getEmployers () {
    fetch("https://localhost:7210")
    .then(response => response.json())
    .then(data =>{
        console.log(data)
        document.getElementById("emp").textContent = JSON.stringify(data, null, 2)
    })
    .catch(err => console.log(err))
}