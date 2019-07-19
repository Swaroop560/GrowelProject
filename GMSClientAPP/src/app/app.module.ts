import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {HttpClientModule} from '@angular/common/http';
import {FormsModule} from '@angular/forms';
import {BsDropdownModule} from 'ngx-bootstrap';

import { AppComponent } from './app.component';
import { ValueComponent } from './value/value.component';
import { AuthService } from './_services/Auth.service';

import { AdminComponent } from './Admin/Admin.component';


import {AppRoutingModule} from './app-routing.module';
import { UserDashBoardComponent } from './user-dash-board/user-dash-board.component';
import { NavigationComponent } from './navigation/navigation.component';
import { AlertifyService } from './_services/alertify.service';
import { HomeComponent } from './Home/Home.component';
import { AuthGuard} from './_guards/auth.guard';

@NgModule({
   declarations: [
      AppComponent,
      ValueComponent,
      AdminComponent,
      UserDashBoardComponent,
      NavigationComponent,
      HomeComponent
   ],
   imports: [
      BrowserModule,
      HttpClientModule,
      FormsModule,
      AppRoutingModule,
      BsDropdownModule.forRoot()
   ],
   providers: [
      AuthService,
      AlertifyService,
      AuthGuard
   ],
   bootstrap: [
      AppComponent
   ]
})
export class AppModule { }
