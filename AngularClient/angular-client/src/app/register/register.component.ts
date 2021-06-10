import { Component, OnInit } from '@angular/core';
import { AuthService } from '../_services/auth.service';
import { MatSnackBar } from '@angular/material/snack-bar';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
  form: any = {
    username: null,
    email: null,
    password: null
  };
  isSuccessful = false;
  isSignUpFailed = false;
  errorMessage = '';

  constructor(private authService: AuthService, private _snackBar: MatSnackBar) { }

  ngOnInit(): void {
  }

  onSubmit(): void {
    const { username, email, password } = this.form;
    this.authService.register(username, email, password).subscribe(
      data => {
        console.log(data);
        this.isSuccessful = true;
        this.isSignUpFailed = false;
        this.openSnackBar('Register as ' + this.form.email);
      },
      err => {
        this.errorMessage = err.error.message;
        this.isSignUpFailed = true;
        this.openSnackBar('Register failed ' + (this.errorMessage !== undefined ? this.errorMessage : ''));
      }
    );
  }

  openSnackBar(message: string): void {
    this._snackBar.open(message, undefined, {
      duration: 2000,
    });
  }
}
