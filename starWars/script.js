$(() => {
    let urlSwapi = "https://swapi.dev/api/people/?page={0}";
    let cnt = 1;
  
    function fetchData() {
        $.ajax({
            type: "GET",
            url: urlSwapi.formatApiString(cnt),
            dataType: "json",
            success: (response) => {
                console.log(response)
                addCard(response)
                // Chiamata ricorsiva per ottenere la pagina successiva
                cnt++;
                fetchData()
            },
            error: (xhr, status, error) => {
                if (cnt === 1) {
                    console.error("Errore durante la connessione all'API: ", status, error)
                    console.error("Codice di errore: ", xhr.status)
                } else if (cnt > 1 && xhr.status === 404) {
                    console.log("Fine delle pagine")
                }
            }
        });
    }

    function fetchPlanet(apiLink, callback) {
        $.ajax({
            type: "GET",
            url: apiLink,
            dataType: "json",
            success: (res) => {
                if (callback) {
                    callback(res.name);
                }
            },
            error: (xhr, status, error) => {
                console.error("errore durante la ricerca del pianeta: ", status, error);
                console.error("Codice di errore: ", xhr.status);
                if (callback) {
                    callback("Errore nella ricerca del pianeta");
                }
            }
        });
    }
    
    function addCard(res) {
        res.results.forEach(el => {
            $.get('card.html', (cardContent) => {
                let card = $(cardContent)
    
                card.find('#name').text(el.name)
                card.find('#birthDate').text(el.birth_year)
                card.find('#hairColor').text(el.hair_color)
    
                fetchPlanet(el.homeworld, (planetName) => {
                    card.find('#planet').text(planetName)
                })
    
                $('#card').append(card)
            })
        })
    }
    fetchData()
})

String.prototype.formatApiString = function(...args) {
    return this.replace(/{(\d+)}/g, (match, number) => {
      return typeof args[number] !== 'undefined' ? args[number] : match
    })
}