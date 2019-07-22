import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders , HttpResponse } from '@angular/common/http';
import {map} from 'rxjs/operators';
import {JwtHelperService} from '@auth0/angular-jwt';
import { Token } from '@angular/compiler/src/ml_parser/lexer';


@Injectable({
  providedIn: 'root'
})
export class AuthService {

    baseUrl = 'http://localhost:5000/api/Sample/';

    jwtHelper = new JwtHelperService();

    rawToken: any;

    decodedToken: any;

    userRole: string;

    userId: number;

    userName: string;

    constructor(private http: HttpClient) { }

        login(model: any) {
          return this.http.post(this.baseUrl + 'login', model)
                          .pipe(
                            map((response: any) => {
                                const user = response;
                                console.log(user);
                                if (user) {
                                  console.log('token sent');
                                  this.rawToken = user.token;
                                  localStorage.setItem('token', user.token);
                                  this.decodedToken = this.jwtHelper.decodeToken(user.token);
                                  this.userId = this.decodedToken.nameid;
                                  console.log(this.decodedToken);
                                  if (this.decodedToken.role === 'True') {
                                      this.userRole = 'ADMIN';
                                      console.log('User Has Admin Rights');
                                      return 'ADMIN';
                                  }
                                  if (this.decodedToken.role === 'False') {
                                      this.userRole = 'USER';
                                      console.log('Login Status of User is : ' + this.loggedIn());
                                      console.log('User Has no Admin Rights');
                                      return 'USER';
                                  }
                                }
                            })
                          );
        }
        loggedIn() {
           const token = localStorage.getItem('token');
           return !this.jwtHelper.isTokenExpired(token);
        }
        getEmployeeById(id: number) {

          const headers = new HttpHeaders().set('Authorization', 'Bearer ' + localStorage.getItem('token'));

          return this.http.get(this.baseUrl + 'Emps/' + id, { headers});
        }

}
