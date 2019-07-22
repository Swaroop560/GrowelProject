import { Component, OnInit } from '@angular/core';
import { AuthService } from '../_services/Auth.service';
import { Router } from '@angular/router';
import { AlertifyService } from '../_services/alertify.service';
import { THIS_EXPR } from '@angular/compiler/src/output/output_ast';

@Component({
  selector: 'app-user-dash-board',
  templateUrl: './user-dash-board.component.html',
  styleUrls: ['./user-dash-board.component.css']
})
export class UserDashBoardComponent implements OnInit {

  loggedInUserName: string;
  modelData: any = {};
  userId: any;
  tokenSend: any;
  constructor(public authService: AuthService, private route: Router, private alertify: AlertifyService) { }

  ngOnInit() {
    this.userId = this.authService.userId;
    // this.tokenSend = this.authService.rawToken;
    this.getUserInfo();
  }

  loggedIn() {
      if (this.authService.loggedIn()) {
          return true;
      }

      return false;
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
  logOut() {
    localStorage.removeItem('token');
    this.route.navigate(['/home']);
    this.alertify.success('Logout Successful');
    this.authService.userName = '';
  }

}
