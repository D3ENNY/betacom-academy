import { Component, Input, OnChanges } from '@angular/core';
import { CommonModule } from '@angular/common';
import { EmployeesComponent } from '../../features/Employees/employees.component';
import { ObjectsService } from '../../shared/services/objects.service';
import { RouterModule } from '@angular/router';
import { ActivitiesComponent } from '../../features/Activities/Activities.component';


@Component({
	selector: 'app-card',
	standalone: true,
	imports: [CommonModule, EmployeesComponent, RouterModule, ActivitiesComponent],
	templateUrl: './card.component.html',
})

export class CardComponent implements OnChanges {
	@Input() employer!: any
	matricola: string = '';
	nominativo: string = '';
	ruolo: string = '';
	reparto: string = '';
	eta: number = 0;
	indirizzo: string = '';
	citta: string = '';
	provincia: string = '';
	cap: string = '';
	telefono: number = 0;

	ngOnChanges(): void {
	  if (this.employer) {
		this.matricola = this.employer['matricola'] || '';
		this.nominativo = this.employer['nominativo'] || '';
		this.ruolo = this.employer['ruolo'] || '';
		this.reparto = this.employer['reparto'] || '';
		this.eta = this.employer['eta'] || 0;
		this.indirizzo = this.employer['indirizzo'] || '';
		this.citta = this.employer['citta'] || '';
		this.provincia = this.employer['provincia'] || '';
		this.cap = this.employer['cap'] || '';
		this.telefono = this.employer['telefono'] || 0;
	  }
	}

}