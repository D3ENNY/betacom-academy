import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import {Observable} from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class EmployeeCallsService {
  constructor(private http: HttpClient) { }

  getEmployeeData(): Observable<any>{
    return this.http.get('https://localhost:7210/api/AnagraficaGenerales')
  }

  postEmployee(employ: any){
    return this.http.post('https://localhost:7210/api/AnagraficaGenerales', employ)
  } 

}