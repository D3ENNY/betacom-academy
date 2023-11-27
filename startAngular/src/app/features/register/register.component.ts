import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CryptService } from '../../shared/services/crypt-services.service';

@Component({
  selector: 'app-register',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './register.component.html',
  providers: [CryptService]
})

export class RegisterComponent {

  constructor(private cryptSw: CryptService) { }

  plainTxt: string = "pippo"
  crypted: string = ""
  decrypted: string = ""

  ngOnInit(): void {
    this.crypted = this.cryptSw.crypt(this.plainTxt)

    console.log(this.cryptSw.crypt(this.plainTxt));
    
    this.decrypted = this.cryptSw.decrypt(this.crypted)
  }

}
