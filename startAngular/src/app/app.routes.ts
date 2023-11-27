import { Routes } from '@angular/router';
import { EmployeesComponent } from './features/Employees/employees.component';
import { ActivitiesComponent } from './features/Activities/Activities.component';
import { RegisterComponent } from './features/register/register.component';


export const routes: Routes = [
    {path:'employee', component: EmployeesComponent},
    {path: 'employee/activities', component: ActivitiesComponent},
    {path: 'register', component: RegisterComponent},
    {path:'', redirectTo: 'home', pathMatch: 'full'}
];
