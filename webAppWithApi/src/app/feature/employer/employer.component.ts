import { CardComponent } from './../../model/card/card.component';
import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { NavbarComponent } from '../../core/navbar/navbar.component'
import { EmployeeCallsService } from '../../shared/CRUDhttp/employer-call-service.service';

@Component({
	selector: 'app-employees',
	standalone: true,
	imports: [CommonModule, NavbarComponent, CardComponent],
	templateUrl: './employer.component.html',
    providers: [EmployeeCallsService]
})
export class EmployeesComponent {
    employee: any[] = [];

    constructor(private wService: EmployeeCallsService) {}
    
    getEmployeeFromService(){
      this.wService.getEmployeeData().subscribe({
        next: (data: any) => {
          this.employee = data;
          console.log(this.employee)
        },
        error: (err: any) => {
          console.log(err)
        }
      });
    }

    ngOnInit(): void {
        this.getEmployeeFromService()
    }
}