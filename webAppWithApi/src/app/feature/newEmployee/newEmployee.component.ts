import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { EmployeeCallsService } from '../../shared/CRUDhttp/employer-call-service.service';
import { Employee } from '../../shared/object/Employee';

@Component({
	selector: 'app-newEmployee',
	templateUrl: './newEmployee.component.html',
	standalone: true,
	imports: [CommonModule],
	providers: [EmployeeCallsService]
})
export class NewEmployeeComponent {

	emp: Employee = new Employee();

	constructor(private wService: EmployeeCallsService){
		this.emp = {
			matricola: "F076",
			nominativo: "mario",
			ruolo: "gpt",
			reparto: "addetto IA",
			eta: 34,
			indirizzo: "via test",
			citta: "milano",
			provincia: "MI",
			cap: "20345",
			telefono: 1965434567,
			attivitaDipendentis: []
		}

		this.emp.attivitaDipendentis.push({
			dataAttivita: new Date("2023-11-7"), 
			attivita: "test", 
			ore: 10, 
			matricola: "F076", 
			id: 184
		})
	}

	insertEmployee() {
		this.wService.postEmployee(this.emp).subscribe({
			next: (data: any) => {
				console.log("inserimento avvenuto con successo");
			},
			error: (err: any) => {
			  console.log(err)
			}
		  })
	}

}
