import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class HttpService {

  constructor(private http: HttpClient) { }

  headerOp = new HttpHeaders({
    contentType: "application/json",
    responseType: 'text'
  })

  exchangeKey(key: string) {

   let  keyObj: Key = { clientPublicKey: key}

    return this.http.post('https://localhost:7125/Crypt/ExchangePublicKey', keyObj, {headers: this.headerOp})
  }

}

export class Key {
  clientPublicKey: string = ""
}
