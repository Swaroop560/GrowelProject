import { Component, OnInit } from '@angular/core';
import { AuthService } from '../_services/Auth.service';
import { Router } from '@angular/router';
import { AlertifyService } from '../_services/alertify.service';

@Component({
  selector: 'app-admin',
  templateUrl: './Admin.component.html',
  styleUrls: ['./Admin.component.css']
})
export class AdminComponent implements OnInit {

  loggedInUserName: string;
  constructor(private authService: AuthService , private route: Router, private alertify: AlertifyService) { }

  ngOnInit() {
      this.loggedInUserName = this.authService.userName;
  }
  logout() {
    localStorage.removeItem('token');
    this.route.navigate(['home']);
    // this.model.username = '';
    // this.model.password = '';
    // console.log('Logged Out Successfully');
    this.alertify.success('Logout Successful');
    // console.log('Logout Successful');

  }
}
