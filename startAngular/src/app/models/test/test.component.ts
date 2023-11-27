import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, NgForm } from '@angular/forms';

@Component({
  selector: 'app-test',
  standalone: true,
  imports: [CommonModule, FormsModule],
  templateUrl: './test.component.html',
})
export class TestComponent {

  usr: user = new user()

  submit(frm: NgForm){
    this.usr = {
      name: frm.value.name,
      surname: frm.value.surname
    }

    frm.resetForm()
    console.log(this.usr)
  }

  submitwo(name: HTMLInputElement, surname: HTMLInputElement) {
    this.usr = {
      name: name.value,
      surname: surname.value
    }

    console.log(this.usr);
  }

}

export class user {
  name: string = ""
  surname: string = ""
}