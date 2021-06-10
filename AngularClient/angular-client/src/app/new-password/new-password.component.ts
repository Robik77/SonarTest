import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-new-password',
  templateUrl: './new-password.component.html',
  styleUrls: ['./new-password.component.css']
})
export class NewPasswordComponent implements OnInit {

  pass = '';
  repass = '';
  passwordForm: FormGroup;

  constructor() {
    this.passwordForm = new FormGroup({
      password: new FormControl(this.pass, [
        Validators.required,
        Validators.minLength(6)
      ]),
      confirmPassword: new FormControl(this.repass,[
        Validators.required,
        Validators.minLength(6)
      ])
    });
  }

  ngOnInit(): void {

  }

  get password() { return this.passwordForm.get('password'); }

  get repassword() { return this.passwordForm.get('confirmPassword'); }
}
