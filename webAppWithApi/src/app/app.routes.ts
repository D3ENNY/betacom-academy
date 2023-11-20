import { Routes } from '@angular/router';
import { EmployeesComponent } from './feature/employer/employer.component';
import { ActivitiesComponent } from './feature/Activities/Activities.component';
import { NewEmployeeComponent } from './feature/newEmployee/newEmployee.component';


export const routes: Routes = [
    {path:'employee', component: EmployeesComponent},
    {path: "employee/add-employee", component: NewEmployeeComponent},
    {path:'', redirectTo: 'home', pathMatch: 'full'}
];