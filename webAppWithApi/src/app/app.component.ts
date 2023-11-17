import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { EmployeeCallsService } from './shared/CRUDhttp/employer-call-service.service';
import { HttpClientModule } from '@angular/common/http';
import { NavbarComponent } from './core/navbar/navbar.component';
@Component({
  selector: 'app-root',
  standalone: true,
  imports: [CommonModule, NavbarComponent, FormsModule,HttpClientModule],
  templateUrl: './app.component.html',
})
export class AppComponent {

}
