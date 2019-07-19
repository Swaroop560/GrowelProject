import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AuthService } from '../_services/Auth.service';
import { AlertifyService } from '../_services/alertify.service';

@Component({
  selector: 'app-home',
  templateUrl: './Home.component.html',
  styleUrls: ['./Home.component.css']
})
export class HomeComponent implements OnInit {

  model: any = {};
  isAdmin = false;
  loginModel = true;

  constructor(public authService: AuthService, private alertify: AlertifyService, private routes: Router) { }

  ngOnInit() {
  }

  login() {
    // console.log(this.model);
     this.authService.login(this.model).subscribe(res => {
        this.authService.userName = this.model.username;
        this.loginModel = false;
        if (res === 'ADMIN') {
          this.routes.navigate(['admin']);
          console.log('2. User Role is :' + this.authService.userRole);
          // this.isAdmin = true;
          // this.alertify.success('Admin Logged in Successfully');
        }
        if (res === 'USER') {
          this.routes.navigate(['user']);
          this.alertify.success('USER Logged in Successfully');
          console.log('USER Logged in Successfully');
        }
      },
      err => {
        this.alertify.error('Login Failed');
        console.log('Login Failed');
       }
    );
  }

  loggedIn() {
    return this.authService.loggedIn(); // this will return token

  }

}
