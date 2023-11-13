$(() => {
  let urlCharacters = "https://swapi.dev/api/people/?page={0}";
  let urlPlanet = "https://swapi.dev/api/planets/?page={0}";
  var planet = {};
  let cntCharacter = 1;
  let cntPlanet = 1;

  function fetchData() {
    $.ajax({
      type: "GET",
      url: urlCharacters.formatApiString(cntCharacter),
      dataType: "json",
      success: (response) => {
        console.log(response)
        addCard2(response);
        // Chiamata ricorsiva per ottenere la pagina successiva
        cntCharacter++;
        fetchData();
      },
      error: (xhr, status, error) => {
        if (cntCharacter === 1) {
          console.error(
            "Errore durante la connessione all'API: ",
            status,
            error
          );
          console.error("Codice di errore: ", xhr.status);
        } else if (cntCharacter > 1 && xhr.status === 404) {
          console.log("Fine delle pagine");
        }
      },
    });
  }

  function fetchAllPlanet() {
    $.ajax({
      type: "GET",
      url: urlPlanet.formatApiString(cntPlanet),
      dataType: "json",
      success: (response) => {
        //        console.log(response)

        response.results.forEach((element, i) => {
          planet[element.url.match(/\/(\d+)\/$/)[1]] = element;
        });

        cntPlanet++;
        fetchAllPlanet();
      },
      error: (xhr, status, error) => {
        if (cntPlanet === 1) {
          console.error(
            "Errore durante la connessione all'API: ",
            status,
            error
          );
          console.error("Codice di errore: ", xhr.status);
        } else if (cntPlanet > 1 && xhr.status === 404) {
          console.log("Fine delle pagine");
        }
      },
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
      },
    });
  }

  function addCard(res) {
    res.results.forEach((el) => {
      $.get("card.html", (cardContent) => {
        let card = $(cardContent);

        card.find("#name").text(el.name);
        card.find("#birthDate").text(el.birth_year);
        card.find("#hairColor").text(el.hair_color);

        fetchPlanet(el.homeworld, (planetName) => {
          card.find("#planet").text(planetName);
        });

        $("#card").append(card);
      });
    });
  }

  function addCard2(res) {
    res.results.forEach((el) => {
      const processElement = async (el) => {
        return new Promise((resolve, reject) => {
          const tryGetPlanetName = async () => {
            const planetPos = el.homeworld.match(/\/(\d+)\/$/)[1];

            if (planet[planetPos]) {
              resolve(planet[planetPos].name);
            } else {
              // Simulare un ritardo, sostituire con la tua logica asincrona reale
              await new Promise((innerResolve) =>
                setTimeout(innerResolve, 100)
              )
              tryGetPlanetName();
            }
          }
          tryGetPlanetName();
        })
      }

      $.get("card.html", async (content) => {
        let card = $(content);
        try {
          card.find("#name").text(el.name);
          card.find("#birthDate").text(el.birth_year);
          card.find("#hairColor").text(el.hair_color);
          card.find("#planet").text(await processElement(el))
          $("#card").append(card);
        } catch (Exception) {}
      });
    });
  }

  fetchData();
  fetchAllPlanet();
});

String.prototype.formatApiString = function (...args) {
  return this.replace(/{(\d+)}/g, (match, number) => {
    return typeof args[number] !== "undefined" ? args[number] : match;
  });
};
