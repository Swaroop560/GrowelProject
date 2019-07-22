import { NgModule } from '@angular/core';
import {HttpClientModule} from '@angular/common/http';
import {FormsModule} from '@angular/forms';
import {RouterModule, Routes} from '@angular/router';

import { ValueComponent } from './value/value.component';
import { AdminComponent } from './Admin/Admin.component';

import { UserDashBoardComponent } from './user-dash-board/user-dash-board.component';
import { HomeComponent } from './Home/Home.component';
import { AuthGuard } from './_guards/auth.guard';
import { ProfileComponent } from './profile/profile.component';

const appRoutes: Routes = [
   {
      path: 'home',
      component: HomeComponent
   },
    {
       path: 'admin',
       component: AdminComponent,
       canActivate: [AuthGuard],

    },
    {
       path: 'value',
       component: ValueComponent
    },
    {
       path: 'user',
       component: UserDashBoardComponent,
       canActivate: [AuthGuard],
       children: [
         {
              path: 'profile', component: ProfileComponent
         }
      ]
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
