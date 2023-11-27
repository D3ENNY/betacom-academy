import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CryptService } from '../../shared/services/crypt-services.service';
import { HttpService } from '../../shared/services/CRUD/http.service';

@Component({
  selector: 'app-register',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './register.component.html',
  providers: [CryptService, HttpService]
})

export class RegisterComponent {

  constructor(private cryptSw: CryptService, private http: HttpService) { }

  plainTxt: string = "pippo"
  crypted: string = ""
  decrypted: string = ""

  ngOnInit(): void {
    this.http.exchangeKey(this.cryptSw.convertFromPem(this.cryptSw.publicKey)).subscribe({
      next: (data: any) => {
        console.log("scambio chiave pubblica", data);
        this.cryptSw.serverPublicKey = data.serverPublicKey
        this.crypted = this.cryptSw.crypt(this.plainTxt)
      },
      error: (err: any) => {
        if (err.error instanceof ErrorEvent) {
          console.error('Errore del client:', err.error.message);
        } else {
          console.error(`Errore server - Codice: ${err.status}, Messaggio: ${err.message}`);
          console.error('Corpo della risposta:', err.error);
          console.error('=> ', err)
        }
      }
    })
  }

}
