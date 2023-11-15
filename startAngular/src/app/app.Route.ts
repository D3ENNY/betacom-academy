import { Routes } from "@angular/router";
import { EmployeesComponent } from "./features/Employees/employees.component";

export const routes: Routes = [
    {path:'employee', component: EmployeesComponent},
    {path:'', redirectTo: 'home', pathMatch: 'full'}
]