import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { EmployeeCallsService } from '../../shared/CRUDhttp/employer-call-service.service';
import { Attivita, Employee } from '../../shared/object/Employee';
import { FormsModule, NgForm } from '@angular/forms';

@Component({
	selector: 'app-newEmployee',
	templateUrl: './newEmployee.component.html',
	standalone: true,
	imports: [CommonModule, FormsModule],
	providers: [EmployeeCallsService]
})
export class NewEmployeeComponent {

	emp: Employee = new Employee();

	constructor(private wService: EmployeeCallsService){ }

	submit(frm: NgForm) {
		this.emp = {
			matricola: frm.value.matricola, 
			nominativo: frm.value.nominativo,
			ruolo: frm.value.ruolo,
			reparto: frm.value.reparto,
			eta: frm.value.eta,
			telefono: frm.value.telefono,
			indirizzo: frm.value.indirizzo,
			citta: frm.value.citta,
			cap: frm.value.cap,
			provincia: frm.value.provincia,
			attivitaDipendentis: []
		}
		this.insertEmployee(frm)
	}

	insertEmployee(frm: NgForm) {
		console.log(this.emp);
		
		this.wService.postEmployee(this.emp).subscribe({
			next: (data: any) => {
				console.log("inserimento avvenuto con successo")
				frm.resetForm()
			},
			error: (err: any) => {
				console.log(err);
				alert(err.error.errors)
			}
		})
	}

}
