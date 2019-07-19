import { Component, OnInit } from '@angular/core';
import { AuthService } from '../_services/Auth.service';
import { AlertifyService } from '../_services/alertify.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-navigation',
  templateUrl: './navigation.component.html',
  styleUrls: ['./navigation.component.css']
})
export class NavigationComponent implements OnInit {

  model: any = {};
  isAdmin = false;

  constructor(public authService: AuthService, private alertify: AlertifyService, private routes: Router) { }

  ngOnInit() {
  }

  login() {
    // console.log(this.model);
     this.authService.login(this.model).subscribe(res => {
        console.log('The Logged In User is : ' + res);
        if (res === 'ADMIN') {
          // this.routes.navigate(['admin']);
          console.log('User Role is :' + this.authService.userRole);
          this.isAdmin = true;
          this.alertify.success('Admin Logged in Successfully');
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
    return this.authService.loggedIn();
  }
  logout() {
    localStorage.removeItem('token');
    this.model.username = '';
    this.model.password = '';
    console.log('Logged Out Successfully');
    this.alertify.error('Logged Out Successfully');
  }
}
