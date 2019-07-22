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

  modelData: any = {};
  userId: any;
  imgUrl: any = 'bill.jpg';
  constructor(public authService: AuthService , private route: Router, private alertify: AlertifyService) { }

  ngOnInit() {
    this.userId = this.authService.userId;
    this.getUserInfo();
  }
  getUserInfo() {
    this.authService.getEmployeeById(this.userId).subscribe(
      next => {
        console.log('The method get user info has started execution');
        console.log(next);
        this.modelData = next;
        console.log('Model Data : ' + this.modelData);
      },
      error => {
        this.alertify.error('Invalid Data Returned');
        console.log('Invalid ID');
      }
    );
  }
  logout() {
    localStorage.removeItem('token');
    this.route.navigate(['home']);
    // this.model.username = '';
    // this.model.password = '';
    // console.log('Logged Out Successfully');
    this.alertify.success('Logout Successful');
    // this.authService.userName = '';
    // console.log('Logout Successful');

  }
}
