import { Routes } from '@angular/router';
import { EmployeesComponent } from './feature/employer/employer.component';
import { ActivitiesComponent } from './feature/Activities/Activities.component';


export const routes: Routes = [
    {path:'employee', component: EmployeesComponent},
    {path: 'employee/activities', component: ActivitiesComponent},
    {path:'', redirectTo: 'home', pathMatch: 'full'}
];