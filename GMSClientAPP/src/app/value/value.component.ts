import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { AuthService } from '../_services/Auth.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-value',
  templateUrl: './value.component.html',
  styleUrls: ['./value.component.css']
})
export class ValueComponent implements OnInit {

  values: any;

  model: any = {};


  constructor(private authService: AuthService, private routes: Router) { }

  ngOnInit() {
  }

  login() {
    // console.log(this.model);
    // const result = this.authService.login(this.model);
     this.authService.login(this.model).subscribe(next => {
      console.log('Logged in Successfully');
      this.routes.navigate(['admin']);
     }, error => {
       console.log('Log in Failed');
       this.routes.navigate(['login']);
     });
  }
}
