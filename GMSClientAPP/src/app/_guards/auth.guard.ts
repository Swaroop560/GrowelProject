import { Injectable } from '@angular/core';
import { CanActivate, Router } from '@angular/router';
import { Observable } from 'rxjs';
import { AuthService } from '../_services/Auth.service';
import { AlertifyService } from '../_services/alertify.service';

@Injectable({
  providedIn: 'root'
})
export class AuthGuard implements CanActivate {
  constructor(private authService: AuthService, private route: Router, private alertify: AlertifyService) {}
  canActivate(): boolean  {
    if (this.authService.loggedIn()) {
        return true;
    }
    this.alertify.error('You Dont Have Access');
    this.route.navigate(['/home']);
    return false;

  }
}