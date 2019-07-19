import { Injectable } from '@angular/core';
import { HttpClient} from '@angular/common/http';
import {map} from 'rxjs/operators';
import {JwtHelperService} from '@auth0/angular-jwt';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

    baseUrl = 'http://localhost:5000/api/Sample/';

    jwtHelper = new JwtHelperService();

    decodedToken: any;

    userRole: string;

    userName: string;

    constructor(private http: HttpClient) { }

        login(model: any) {
          return this.http.post(this.baseUrl + 'login', model)
                          .pipe(
                            map((response: any) => {
                                const user = response;
                                if (user) {
                                  localStorage.setItem('token', user.token);
                                  this.decodedToken = this.jwtHelper.decodeToken(user.token);
                                  console.log(this.decodedToken);
                                  if (this.decodedToken.role) {
                                      this.userRole = 'ADMIN';
                                      console.log('User Has Admin Rights');
                                      return 'ADMIN';
                                  } else {
                                      this.userRole = 'USER';
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
}
