export class Employee {

    matricola: string = ""
    nominativo: string = ""
    ruolo: string = ""
    reparto: string = ""
    eta: number = 0
    indirizzo: string = ""
    citta: string = ""
    provincia: string = ""
    cap: string = ""
    telefono: string = ""
    attivitaDipendentis: Attivita[] = []

    constructor() { }

}

export class Attivita {

    dataAttivita: Date = new Date()
    attivita: string = ""
    ore: number = 0
    matricola: string = ""
    id: number = 0

    constructor() { }
}