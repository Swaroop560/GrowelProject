import { NgModule } from '@angular/core';
import {HttpClientModule} from '@angular/common/http';
import {FormsModule} from '@angular/forms';
import {RouterModule, Routes} from '@angular/router';

import { ValueComponent } from './value/value.component';
import { AdminComponent } from './Admin/Admin.component';

import { UserDashBoardComponent } from './user-dash-board/user-dash-board.component';
import { NavigationComponent } from './navigation/navigation.component';
import { HomeComponent } from './Home/Home.component';
import { AuthGuard } from './_guards/auth.guard';

const appRoutes: Routes = [
   {
      path: 'home',
      component: HomeComponent
   },
   {
      path: 'nav',
      component: NavigationComponent
   },
    {
       path: 'admin',
       component: AdminComponent,
       canActivate: [AuthGuard]
    },
    {
       path: 'value',
       component: ValueComponent
    },
    {
       path: 'user',
       component: UserDashBoardComponent
    },
    {
       path: '**',
       redirectTo: '/home',
       pathMatch: 'full'
   },
];
@NgModule({
   imports: [
      RouterModule.forRoot(appRoutes)
   ],
   exports: [RouterModule]
})
export class AppRoutingModule { }
