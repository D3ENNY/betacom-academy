import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterOutlet } from '@angular/router';
import {FormsModule} from '@angular/forms'

import { Employee } from './app.Employees';
import { NavbarComponent } from './core/navbar/navbar.component';
import { HttpClientModule } from '@angular/common/http';

@Component({
	selector: 'app-root',
	standalone: true,
	imports: [CommonModule, RouterOutlet, HttpClientModule , FormsModule, NavbarComponent],
	templateUrl: './app.component.html',
	styleUrls: ['./app.component.css'],
})
export class AppComponent {
	title = 'La nostra prima app angular';
	abc: string = 'ciao'
	btnDisabled: boolean = true
	bidirezionale: string = "ciaouu"
	isOK: boolean = true
	num1: number = 2.2341
	tDay: Date = new Date()

	emp: Employee = new Employee('','','','')

	moviesList: any[] = [
		{
			title : "Star Wars",
			year : 1977,
			director : "george lucas"
		}, 
		{
			title : "the matrix",
			year : 1999,
			director : "Wachowski"
		},
		{
			title : "the lord of rings",
			year : 2001,
			director : "peter jackson"
		}
	]

	// constructor() {
	// 	console.log(this.abc);
	// }

	// ngOnInit(): void {
	// 	this.myFirst()
	// }

	myFirst() {
		console.log("ciao from my init");
	}

	myFunc(n1: number, n2:number) {
		return n1*n2
	}

	btnClick(msg: string) {
		alert(msg)
		alert(this.insertEmployee().toString())
	}

	insertEmployee() {
		return new Employee("K001", "geppo il fallo", "milano", "lago duria")
	}

}
