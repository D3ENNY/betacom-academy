import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { NavbarComponent } from '../../core/navbar/navbar.component'
import { CardComponent } from '../../models/card/card.component';

import data from '../../shared/employee.json'

@Component({
	selector: 'app-employees',
	standalone: true,
	imports: [CommonModule, NavbarComponent, CardComponent],
	templateUrl: './employees.component.html',
})
export class EmployeesComponent {
	employee = data
}
